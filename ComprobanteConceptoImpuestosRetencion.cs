// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.ComprobanteConceptoImpuestosRetencion
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
  [Serializable]
  public class ComprobanteConceptoImpuestosRetencion
  {
    private Decimal baseField;
    private string impuestoField;
    private string tipoFactorField;
    private Decimal tasaOCuotaField;
    private Decimal importeField;

    [XmlAttribute]
    public Decimal Base
    {
      get => this.baseField;
      set => this.baseField = value;
    }

    [XmlAttribute]
    public string Impuesto
    {
      get => this.impuestoField;
      set => this.impuestoField = value;
    }

    [XmlAttribute]
    public string TipoFactor
    {
      get => this.tipoFactorField;
      set => this.tipoFactorField = value;
    }

    [XmlAttribute]
    public Decimal TasaOCuota
    {
      get => this.tasaOCuotaField;
      set => this.tasaOCuotaField = value;
    }

    [XmlAttribute]
    public Decimal Importe
    {
      get => this.importeField;
      set => this.importeField = value;
    }
  }
}
