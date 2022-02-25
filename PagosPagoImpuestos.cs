// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.PagosPagoImpuestos
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
  public class PagosPagoImpuestos
  {
    private PagosPagoImpuestosRetencion[] retencionesField;
    private PagosPagoImpuestosTraslado[] trasladosField;
    private Decimal totalImpuestosRetenidosField;
    private bool totalImpuestosRetenidosFieldSpecified;
    private Decimal totalImpuestosTrasladadosField;
    private bool totalImpuestosTrasladadosFieldSpecified;

    [XmlArrayItem("Retencion", IsNullable = false)]
    public PagosPagoImpuestosRetencion[] Retenciones
    {
      get => this.retencionesField;
      set => this.retencionesField = value;
    }

    [XmlArrayItem("Traslado", IsNullable = false)]
    public PagosPagoImpuestosTraslado[] Traslados
    {
      get => this.trasladosField;
      set => this.trasladosField = value;
    }

    [XmlAttribute]
    public Decimal TotalImpuestosRetenidos
    {
      get => this.totalImpuestosRetenidosField;
      set => this.totalImpuestosRetenidosField = value;
    }

    [XmlIgnore]
    public bool TotalImpuestosRetenidosSpecified
    {
      get => this.totalImpuestosRetenidosFieldSpecified;
      set => this.totalImpuestosRetenidosFieldSpecified = value;
    }

    [XmlAttribute]
    public Decimal TotalImpuestosTrasladados
    {
      get => this.totalImpuestosTrasladadosField;
      set => this.totalImpuestosTrasladadosField = value;
    }

    [XmlIgnore]
    public bool TotalImpuestosTrasladadosSpecified
    {
      get => this.totalImpuestosTrasladadosFieldSpecified;
      set => this.totalImpuestosTrasladadosFieldSpecified = value;
    }
  }
}
