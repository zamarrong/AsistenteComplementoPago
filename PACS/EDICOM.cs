// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.PACS.EDICOM
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using AsistenteComplementoPago.Edicom;
using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace AsistenteComplementoPago.PACS
{
  internal class EDICOM
  {
    public CFDiService servicio { get; private set; }

    public string usuario { get; set; }

    public string contraseña { get; set; }

    public bool modo_prueba { get; set; }

    public EDICOM(string usuario, string contraseña, bool modo_prueba)
    {
      this.servicio = new CFDiService();
      this.usuario = usuario;
      this.contraseña = contraseña;
      this.modo_prueba = modo_prueba;
    }

    public DocumentoElectronico Timbrar(
      DocumentoElectronico documento_electronico,
      string ruta_xml)
    {
      try
      {
        byte[] file = File.ReadAllBytes(ruta_xml);
        ZipEntry zipEntry = ((IEnumerable<ZipEntry>) ZipFile.Read(this.modo_prueba ? this.servicio.getCfdiTest(this.usuario, this.contraseña, file) : this.servicio.getCfdi(this.usuario, this.contraseña, file)).Entries).First<ZipEntry>((Func<ZipEntry, bool>) (x => x.FileName.EndsWith(".xml")));
        MemoryStream memoryStream = new MemoryStream();
        zipEntry.Extract((Stream) memoryStream);
        byte[] array = memoryStream.ToArray();
        File.WriteAllBytes(ruta_xml, array);
        string empty = string.Empty;
        string str;
        try
        {
          XNamespace xnamespace1 = (XNamespace) "http://www.sat.gob.mx/cfd/3";
          XNamespace xnamespace2 = (XNamespace) "http://www.sat.gob.mx/TimbreFiscalDigital";
          XElement xelement = XDocument.Load(ruta_xml).Element(xnamespace1 + "Comprobante").Element(xnamespace1 + "Complemento").Element(xnamespace2 + "TimbreFiscalDigital");
          str = (string) xelement.Attribute((XName) "UUID");
          documento_electronico.sello_SAT = (string) xelement.Attribute((XName) "SelloSAT");
        }
        catch
        {
          str = this.ObtenerUUID(array);
        }
        if (!str.IsNullOrEmpty())
        {
          documento_electronico.estado = 'A';
          if (str.Length == 36)
          {
            documento_electronico.folio_fiscal = str;
            documento_electronico.mensaje = string.Empty;
          }
          else
            documento_electronico.mensaje = str;
          try
          {
            File.Move(ruta_xml, string.Format("{0}\\{1}.xml", (object) Path.GetDirectoryName(ruta_xml), (object) str));
          }
          catch
          {
          }
        }
        else
        {
          documento_electronico.estado = 'P';
          documento_electronico.mensaje = "El comprobante aún no ha sido timbrado.";
        }
      }
      catch (EDICOM.CFDiException ex)
      {
        documento_electronico.estado = 'E';
        documento_electronico.mensaje = ex.text;
      }
      catch (Exception ex)
      {
        documento_electronico.estado = 'E';
        documento_electronico.mensaje = ex.Message;
      }
      return documento_electronico;
    }

    public string ObtenerUUID(byte[] archivo_xml)
    {
      string empty = string.Empty;
      string str;
      try
      {
        str = this.modo_prueba ? this.servicio.getUUIDTest(this.usuario, this.contraseña, archivo_xml) : this.servicio.getUUID(this.usuario, this.contraseña, archivo_xml);
      }
      catch (EDICOM.CFDiException ex)
      {
        str = ex.text;
      }
      catch (Exception ex)
      {
        str = ex.Message;
      }
      return str;
    }

    public DocumentoElectronico CancelarUUID(
      DocumentoElectronico documento_electronico,
      string rfc,
      byte[] pfx,
      string contraseña_pfx)
    {
      try
      {
        string[] uuid = new string[1]
        {
          documento_electronico.folio_fiscal
        };
        this.servicio.cancelaCFDiAsync(this.usuario, this.contraseña, rfc, uuid, pfx, contraseña_pfx);
        var data = new{ total = 0.0 };
        string rfcR = "XAXX010101000";
        CancelData cancelData = this.servicio.cancelCFDiAsync(this.usuario, this.contraseña, rfc, rfcR, documento_electronico.folio_fiscal, Math.Round(Convert.ToDouble(data.total), 2), pfx, contraseña_pfx, this.modo_prueba);
        documento_electronico.estado = 'C';
        documento_electronico.mensaje = string.Format("{0} - ({1}) | {2} - {3}", (object) cancelData.status, (object) cancelData.statusCode, (object) cancelData.cancelQueryData.cancelStatus, (object) cancelData.cancelQueryData.isCancelable);
      }
      catch (EDICOM.CFDiException ex)
      {
        documento_electronico.estado = 'E';
        documento_electronico.mensaje = ex.text;
      }
      catch (Exception ex)
      {
        documento_electronico.estado = 'E';
        documento_electronico.mensaje = ex.Message;
      }
      return documento_electronico;
    }

    public string CancelarUUID(
      string uuid,
      string rfc_receptor,
      double total,
      string rfc,
      byte[] pfx,
      string contraseña_pfx)
    {
      try
      {
        string[] uuid1 = new string[1]{ uuid };
        this.servicio.cancelaCFDiAsync(this.usuario, this.contraseña, rfc, uuid1, pfx, contraseña_pfx);
        CancelData cancelData = this.servicio.cancelCFDiAsync(this.usuario, this.contraseña, rfc, rfc_receptor, uuid, total, pfx, contraseña_pfx, this.modo_prueba);
        return string.Format("{0} - ({1}) | {2} - {3}", (object) cancelData.status, (object) cancelData.statusCode, (object) cancelData.cancelQueryData.cancelStatus, (object) cancelData.cancelQueryData.isCancelable);
      }
      catch (EDICOM.CFDiException ex)
      {
        return ex.text;
      }
      catch (Exception ex)
      {
        return ex.Message;
      }
    }

    public string ObtenerEstado(DocumentoElectronico documento_electronico, string rfc)
    {
      string empty = string.Empty;
      string str;
      try
      {
        string[] strArray = new string[1]
        {
          documento_electronico.folio_fiscal
        };
        var data = new{ total = 0.0 };
        string rfcR = "XAXX010101000";
        CancelQueryData cfDiStatus = this.servicio.getCFDiStatus(this.usuario, this.contraseña, rfc, rfcR, documento_electronico.folio_fiscal, Math.Round(Convert.ToDouble(data.total), 2), this.modo_prueba);
        str = string.Format("{0} - ({1}) | {2} - {3}", (object) cfDiStatus.status, (object) cfDiStatus.statusCode, (object) cfDiStatus.cancelStatus, (object) cfDiStatus.isCancelable);
      }
      catch (EDICOM.CFDiException ex)
      {
        str = ex.text;
      }
      catch (Exception ex)
      {
        str = ex.Message;
      }
      return str;
    }

    public class CFDiException : Exception
    {
      public int cod;
      public string text;
    }
  }
}
