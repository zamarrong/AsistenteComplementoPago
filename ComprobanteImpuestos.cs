// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.ComprobanteImpuestos
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
  public class ComprobanteImpuestos
  {
    private ComprobanteImpuestosRetencion[] retencionesField;
    private ComprobanteImpuestosTraslado[] trasladosField;
    private Decimal totalImpuestosRetenidosField;
    private bool totalImpuestosRetenidosFieldSpecified;
    private Decimal totalImpuestosTrasladadosField;
    private bool totalImpuestosTrasladadosFieldSpecified;

    [XmlArrayItem("Retencion", IsNullable = false)]
    public ComprobanteImpuestosRetencion[] Retenciones
    {
      get => this.retencionesField;
      set => this.retencionesField = value;
    }

    [XmlArrayItem("Traslado", IsNullable = false)]
    public ComprobanteImpuestosTraslado[] Traslados
    {
      get => this.trasladosField;
      set
      {
        this.TotalImpuestosTrasladadosSpecified = true;
        this.trasladosField = value;
      }
    }

    [XmlAttribute]
    public Decimal TotalImpuestosRetenidos
    {
      get => this.totalImpuestosRetenidosField;
      set
      {
        this.totalImpuestosRetenidosFieldSpecified = true;
        this.totalImpuestosRetenidosField = value;
      }
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
