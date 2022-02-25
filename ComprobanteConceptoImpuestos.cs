// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.ComprobanteConceptoImpuestos
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
  public class ComprobanteConceptoImpuestos
  {
    private ComprobanteConceptoImpuestosTraslado[] trasladosField;
    private ComprobanteConceptoImpuestosRetencion[] retencionesField;

    [XmlArrayItem("Traslado", IsNullable = false)]
    public ComprobanteConceptoImpuestosTraslado[] Traslados
    {
      get => this.trasladosField;
      set => this.trasladosField = value;
    }

    [XmlArrayItem("Retencion", IsNullable = false)]
    public ComprobanteConceptoImpuestosRetencion[] Retenciones
    {
      get => this.retencionesField;
      set => this.retencionesField = value;
    }
  }
}
