// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Comprobante
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace AsistenteComplementoPago
{
  [GeneratedCode("xsd", "4.0.30319.18020")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  [XmlRoot(IsNullable = false, Namespace = "http://www.sat.gob.mx/cfd/3")]
  [Serializable]
  public class Comprobante
  {
    private ComprobanteCfdiRelacionados cfdiRelacionadosField;
    private ComprobanteEmisor emisorField;
    private ComprobanteReceptor receptorField;
    private ComprobanteConcepto[] conceptosField;
    private ComprobanteImpuestos impuestosField;
    private ComprobanteComplemento[] complementoField;
    private ComprobanteAddenda addendaField;
    private string versionField;
    private string serieField;
    private string folioField;
    private string fechaField;
    private string selloField;
    private string formaPagoField;
    private bool formaPagoFieldSpecified;
    private string noCertificadoField;
    private string certificadoField;
    private string condicionesDePagoField;
    private Decimal subTotalField;
    private Decimal descuentoField;
    private bool descuentoFieldSpecified;
    private string monedaField;
    private Decimal tipoCambioField;
    private bool tipoCambioFieldSpecified;
    private Decimal totalField;
    private string tipoDeComprobanteField;
    private string metodoPagoField;
    private bool metodoPagoFieldSpecified;
    private string lugarExpedicionField;
    private string confirmacionField;
    [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string xsiSchemaLocation = "http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd";

    public Comprobante() => this.versionField = "3.3";

    public ComprobanteCfdiRelacionados CfdiRelacionados
    {
      get => this.cfdiRelacionadosField;
      set => this.cfdiRelacionadosField = value;
    }

    public ComprobanteEmisor Emisor
    {
      get => this.emisorField;
      set => this.emisorField = value;
    }

    public ComprobanteReceptor Receptor
    {
      get => this.receptorField;
      set => this.receptorField = value;
    }

    [XmlArrayItem("Concepto", IsNullable = false)]
    public ComprobanteConcepto[] Conceptos
    {
      get => this.conceptosField;
      set => this.conceptosField = value;
    }

    public ComprobanteImpuestos Impuestos
    {
      get => this.impuestosField;
      set => this.impuestosField = value;
    }

    [XmlElement("Complemento")]
    public ComprobanteComplemento[] Complemento
    {
      get => this.complementoField;
      set => this.complementoField = value;
    }

    public ComprobanteAddenda Addenda
    {
      get => this.addendaField;
      set => this.addendaField = value;
    }

    [XmlAttribute]
    public string Version
    {
      get => this.versionField;
      set => this.versionField = value;
    }

    [XmlAttribute]
    public string Serie
    {
      get => this.serieField;
      set => this.serieField = value;
    }

    [XmlAttribute]
    public string Folio
    {
      get => this.folioField;
      set => this.folioField = value;
    }

    [XmlAttribute]
    public string Fecha
    {
      get => this.fechaField;
      set => this.fechaField = value;
    }

    [XmlAttribute]
    public string Sello
    {
      get => this.selloField;
      set => this.selloField = value;
    }

    [XmlAttribute]
    public string FormaPago
    {
      get => this.formaPagoField;
      set
      {
        this.formaPagoFieldSpecified = true;
        this.formaPagoField = value;
      }
    }

    [XmlIgnore]
    public bool FormaPagoSpecified
    {
      get => this.formaPagoFieldSpecified;
      set => this.formaPagoFieldSpecified = value;
    }

    [XmlAttribute]
    public string NoCertificado
    {
      get => this.noCertificadoField;
      set => this.noCertificadoField = value;
    }

    [XmlAttribute]
    public string Certificado
    {
      get => this.certificadoField;
      set => this.certificadoField = value;
    }

    [XmlAttribute]
    public string CondicionesDePago
    {
      get => this.condicionesDePagoField;
      set => this.condicionesDePagoField = value;
    }

    [XmlAttribute]
    public Decimal SubTotal
    {
      get => this.subTotalField;
      set => this.subTotalField = value;
    }

    [XmlAttribute]
    public Decimal Descuento
    {
      get => this.descuentoField;
      set
      {
        this.descuentoFieldSpecified = true;
        this.descuentoField = value;
      }
    }

    [XmlIgnore]
    public bool DescuentoSpecified
    {
      get => this.descuentoFieldSpecified;
      set => this.descuentoFieldSpecified = value;
    }

    [XmlAttribute]
    public string Moneda
    {
      get => this.monedaField;
      set => this.monedaField = value;
    }

    [XmlAttribute]
    public Decimal TipoCambio
    {
      get => this.tipoCambioField;
      set
      {
        this.tipoCambioFieldSpecified = true;
        this.tipoCambioField = value;
      }
    }

    [XmlIgnore]
    public bool TipoCambioSpecified
    {
      get => this.tipoCambioFieldSpecified;
      set => this.tipoCambioFieldSpecified = value;
    }

    [XmlAttribute]
    public Decimal Total
    {
      get => this.totalField;
      set => this.totalField = value;
    }

    [XmlAttribute]
    public string TipoDeComprobante
    {
      get => this.tipoDeComprobanteField;
      set => this.tipoDeComprobanteField = value;
    }

    [XmlAttribute]
    public string MetodoPago
    {
      get => this.metodoPagoField;
      set
      {
        this.metodoPagoFieldSpecified = true;
        this.metodoPagoField = value;
      }
    }

    [XmlIgnore]
    public bool MetodoPagoSpecified
    {
      get => this.metodoPagoFieldSpecified;
      set => this.metodoPagoFieldSpecified = value;
    }

    [XmlAttribute]
    public string LugarExpedicion
    {
      get => this.lugarExpedicionField;
      set => this.lugarExpedicionField = value;
    }

    [XmlAttribute]
    public string Confirmacion
    {
      get => this.confirmacionField;
      set => this.confirmacionField = value;
    }
  }
}
