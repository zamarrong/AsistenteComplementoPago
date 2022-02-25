// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.PagosPagoDoctoRelacionado
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
  [GeneratedCode("xsd", "4.0.30319.1")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
  [Serializable]
  public class PagosPagoDoctoRelacionado
  {
    private string idDocumentoField;
    private string serieField;
    private string folioField;
    private string monedaDRField;
    private Decimal tipoCambioDRField;
    private bool tipoCambioDRFieldSpecified;
    private string metodoDePagoDRField;
    private string numParcialidadField;
    private Decimal impSaldoAntField;
    private bool impSaldoAntFieldSpecified;
    private Decimal impPagadoField;
    private bool impPagadoFieldSpecified;
    private Decimal impSaldoInsolutoField;
    private bool impSaldoInsolutoFieldSpecified;

    [XmlAttribute]
    public string IdDocumento
    {
      get => this.idDocumentoField;
      set => this.idDocumentoField = value;
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
    public string MonedaDR
    {
      get => this.monedaDRField;
      set => this.monedaDRField = value;
    }

    [XmlAttribute]
    public Decimal TipoCambioDR
    {
      get => this.tipoCambioDRField;
      set
      {
        this.tipoCambioDRFieldSpecified = true;
        this.tipoCambioDRField = value;
      }
    }

    [XmlIgnore]
    public bool TipoCambioDRSpecified
    {
      get => this.tipoCambioDRFieldSpecified;
      set => this.tipoCambioDRFieldSpecified = value;
    }

    [XmlAttribute]
    public string MetodoDePagoDR
    {
      get => this.metodoDePagoDRField;
      set => this.metodoDePagoDRField = value;
    }

    [XmlAttribute(DataType = "integer")]
    public string NumParcialidad
    {
      get => this.numParcialidadField;
      set => this.numParcialidadField = value;
    }

    [XmlAttribute]
    public Decimal ImpSaldoAnt
    {
      get => this.impSaldoAntField;
      set
      {
        this.impSaldoAntFieldSpecified = true;
        this.impSaldoAntField = value;
      }
    }

    [XmlIgnore]
    public bool ImpSaldoAntSpecified
    {
      get => this.impSaldoAntFieldSpecified;
      set => this.impSaldoAntFieldSpecified = value;
    }

    [XmlAttribute]
    public Decimal ImpPagado
    {
      get => this.impPagadoField;
      set
      {
        this.impPagadoFieldSpecified = true;
        this.impPagadoField = value;
      }
    }

    [XmlIgnore]
    public bool ImpPagadoSpecified
    {
      get => this.impPagadoFieldSpecified;
      set => this.impPagadoFieldSpecified = value;
    }

    [XmlAttribute]
    public Decimal ImpSaldoInsoluto
    {
      get => this.impSaldoInsolutoField;
      set
      {
        this.impSaldoInsolutoFieldSpecified = true;
        this.impSaldoInsolutoField = value;
      }
    }

    [XmlIgnore]
    public bool ImpSaldoInsolutoSpecified
    {
      get => this.impSaldoInsolutoFieldSpecified;
      set => this.impSaldoInsolutoFieldSpecified = value;
    }
  }
}
