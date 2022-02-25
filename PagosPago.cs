// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.PagosPago
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace AsistenteComplementoPago
{
  [GeneratedCode("xsd", "4.0.30319.1")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
  [Serializable]
  public class PagosPago
  {
    private PagosPagoImpuestos[] impuestosField;
    private string fechaPagoField;
    private string formaDePagoPField;
    private string monedaPField;
    private Decimal tipoCambioPField;
    private bool tipoCambioPFieldSpecified;
    private Decimal montoField;
    private string numOperacionField;
    private string rfcEmisorCtaOrdField;
    private string nomBancoOrdExtField;
    private string ctaOrdenanteField;
    private string rfcEmisorCtaBenField;
    private string ctaBeneficiarioField;
    private string tipoCadPagoField;
    private bool tipoCadPagoFieldSpecified;
    private byte[] certPagoField;
    private string cadPagoField;
    private byte[] selloPagoField;

    public PagosPago() => this.DoctoRelacionado = new List<PagosPagoDoctoRelacionado>();

    [XmlElement("DoctoRelacionado")]
    public List<PagosPagoDoctoRelacionado> DoctoRelacionado { get; set; }

    [XmlElement("Impuestos")]
    public PagosPagoImpuestos[] Impuestos
    {
      get => this.impuestosField;
      set => this.impuestosField = value;
    }

    [XmlAttribute]
    public string FechaPago
    {
      get => this.fechaPagoField;
      set => this.fechaPagoField = value;
    }

    [XmlAttribute]
    public string FormaDePagoP
    {
      get => this.formaDePagoPField;
      set => this.formaDePagoPField = value;
    }

    [XmlAttribute]
    public string MonedaP
    {
      get => this.monedaPField;
      set => this.monedaPField = value;
    }

    [XmlAttribute]
    public Decimal TipoCambioP
    {
      get => this.tipoCambioPField;
      set
      {
        this.tipoCambioPFieldSpecified = true;
        this.tipoCambioPField = value;
      }
    }

    [XmlIgnore]
    public bool TipoCambioPSpecified
    {
      get => this.tipoCambioPFieldSpecified;
      set => this.tipoCambioPFieldSpecified = value;
    }

    [XmlAttribute]
    public Decimal Monto
    {
      get => this.montoField;
      set => this.montoField = value;
    }

    [XmlAttribute]
    public string NumOperacion
    {
      get => this.numOperacionField;
      set => this.numOperacionField = value;
    }

    [XmlAttribute]
    public string RfcEmisorCtaOrd
    {
      get => this.rfcEmisorCtaOrdField;
      set => this.rfcEmisorCtaOrdField = value;
    }

    [XmlAttribute]
    public string NomBancoOrdExt
    {
      get => this.nomBancoOrdExtField;
      set => this.nomBancoOrdExtField = value;
    }

    [XmlAttribute]
    public string CtaOrdenante
    {
      get => this.ctaOrdenanteField;
      set => this.ctaOrdenanteField = value;
    }

    [XmlAttribute]
    public string RfcEmisorCtaBen
    {
      get => this.rfcEmisorCtaBenField;
      set => this.rfcEmisorCtaBenField = value;
    }

    [XmlAttribute]
    public string CtaBeneficiario
    {
      get => this.ctaBeneficiarioField;
      set => this.ctaBeneficiarioField = value;
    }

    [XmlAttribute]
    public string TipoCadPago
    {
      get => this.tipoCadPagoField;
      set => this.tipoCadPagoField = value;
    }

    [XmlIgnore]
    public bool TipoCadPagoSpecified
    {
      get => this.tipoCadPagoFieldSpecified;
      set => this.tipoCadPagoFieldSpecified = value;
    }

    [XmlAttribute(DataType = "base64Binary")]
    public byte[] CertPago
    {
      get => this.certPagoField;
      set => this.certPagoField = value;
    }

    [XmlAttribute]
    public string CadPago
    {
      get => this.cadPagoField;
      set => this.cadPagoField = value;
    }

    [XmlAttribute(DataType = "base64Binary")]
    public byte[] SelloPago
    {
      get => this.selloPagoField;
      set => this.selloPagoField = value;
    }
  }
}
