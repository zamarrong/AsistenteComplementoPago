// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.CFDI
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using AsistenteComplementoPago.PACS;
using AsistenteComplementoPago.Utilidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace AsistenteComplementoPago
{
  public class CFDI
  {
    private Empresa empresa;

    public Comprobante comprobante { get; set; }

    public Configuracion configuracion { get; set; }

    public string usuario { get; set; }

    public string contraseña { get; set; }

    public CFDI.Certificado certificado { get; set; }

    public Exception error { get; set; }

    public CFDI()
    {
      try
      {
        this.certificado = new CFDI.Certificado();
      }
      catch
      {
        throw;
      }
    }

    public bool Inicializar()
    {
      try
      {
        this.empresa = new Empresa();
        this.configuracion = new Configuracion();
        this.usuario = "BSO080117GU2";
        this.contraseña = "5o1fplbbyl";
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        return false;
      }
    }

    public bool Cancelar(DocumentoElectronico documento_electronico)
    {
      if (!documento_electronico.estado.Equals('A') || documento_electronico.folio_fiscal.Length <= 0)
        return false;
      try
      {
        documento_electronico = new EDICOM(this.usuario, this.contraseña, this.configuracion.modo_prueba).CancelarUUID(documento_electronico, this.empresa.rfc, File.ReadAllBytes(this.certificado.pfx), this.certificado.contraseña_pfx);
        return true;
      }
      catch (Exception ex)
      {
        documento_electronico.estado = 'E';
        documento_electronico.mensaje = ex.Message;
        return false;
      }
    }

    public string Cancelar(string uuid, string rfc_receptor, double total)
    {
      try
      {
        return new EDICOM(this.usuario, this.contraseña, this.configuracion.modo_prueba).CancelarUUID(uuid, rfc_receptor, total, this.empresa.rfc, File.ReadAllBytes(this.certificado.pfx), this.certificado.contraseña_pfx);
      }
      catch (Exception ex)
      {
        return ex.Message;
      }
    }

    public string ObtenerEstado(DocumentoElectronico documento_electronico)
    {
      if (documento_electronico.folio_fiscal.Length <= 0)
        return string.Empty;
      try
      {
        return new EDICOM(this.usuario, this.contraseña, this.configuracion.modo_prueba).ObtenerEstado(documento_electronico, this.empresa.rfc);
      }
      catch (Exception ex)
      {
        return ex.Message;
      }
    }

    public string Timbrar(bool vista_previa, bool modo_prueba)
    {
      try
      {
        string str = string.Format("{0}\\{1}.xml", (object) this.configuracion.directorio_xml, (object) this.comprobante.Folio);
        DocumentoElectronico documento_electronico = new DocumentoElectronico();
        string Numero;
        SelloDigital.LeerCER(this.certificado.cer, out string _, out string _, out string _, out Numero);
        this.comprobante.NoCertificado = Numero;
        string empty = string.Empty;
        string stylesheetUri = this.configuracion.directorio_xml + "\\cadenaoriginal_3_3.xslt";
        this.GenerarXML(this.comprobante, str);
        XslCompiledTransform compiledTransform = new XslCompiledTransform(true);
        compiledTransform.Load(stylesheetUri);
        using (StringWriter stringWriter = new StringWriter())
        {
          using (XmlWriter results = XmlWriter.Create((TextWriter) stringWriter, compiledTransform.OutputSettings))
          {
            compiledTransform.Transform(str, results);
            empty = stringWriter.ToString();
          }
        }
        SelloDigital selloDigital = new SelloDigital();
        this.comprobante.Certificado = selloDigital.Certificado(this.certificado.cer);
        this.comprobante.Sello = selloDigital.Sellar(empty, this.certificado.key, this.certificado.contraseña);
        this.GenerarXML(this.comprobante, str);
        documento_electronico.sello_CFD = this.comprobante.Sello;
        documento_electronico.cadena_original = empty;
        if (vista_previa)
          return str;
        DocumentoElectronico documentoElectronico = new EDICOM(this.usuario, this.contraseña, modo_prueba).Timbrar(documento_electronico, str);
        return documentoElectronico.estado.Equals('A') ? string.Format("{0}\\{1}.xml", (object) this.configuracion.directorio_xml, (object) documentoElectronico.folio_fiscal) : string.Format("Error: {0}", (object) documentoElectronico.mensaje);
      }
      catch (Exception ex)
      {
        this.error = ex;
        return string.Format("Error: {0}", (object) ex.Message);
      }
    }

    private void GenerarXML(Comprobante comprobante, string ruta)
    {
      XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
      namespaces.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
      namespaces.Add("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital");
      namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
      try
      {
        if (((IEnumerable<ComprobanteComplemento>) comprobante.Complemento).Count<ComprobanteComplemento>() > 0)
          namespaces.Add("pago10", "http://www.sat.gob.mx/Pagos");
      }
      catch
      {
      }
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (Comprobante));
      string contents = "";
      using (StringWriterWithEncoding writerWithEncoding = new StringWriterWithEncoding(Encoding.UTF8))
      {
        using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) writerWithEncoding))
        {
          xmlSerializer.Serialize(xmlWriter, (object) comprobante, namespaces);
          contents = writerWithEncoding.ToString();
        }
      }
      File.WriteAllText(ruta, contents);
    }

    public static XmlElement GenerarComplementoPago(Pagos complemento)
    {
      XmlDocument xmlDocument = new XmlDocument();
      XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
      namespaces.Add("pago10", "http://www.sat.gob.mx/Pagos");
      using (XmlWriter xmlWriter = xmlDocument.CreateNavigator().AppendChild())
        new XmlSerializer(complemento.GetType()).Serialize(xmlWriter, (object) complemento, namespaces);
      xmlDocument.DocumentElement.RemoveAttribute("xmlns");
      return xmlDocument.DocumentElement;
    }

    public class Certificado
    {
      public string cer { get; set; }

      public string key { get; set; }

      public string contraseña { get; set; }

      public string pfx { get; set; }

      public string contraseña_pfx { get; set; }

      public Certificado()
      {
        this.cer = "cer.cer";
        this.key = "key.key";
        this.contraseña = "";
        this.pfx = "pfx.pfx";
        this.contraseña_pfx = "";
      }
    }
  }
}
