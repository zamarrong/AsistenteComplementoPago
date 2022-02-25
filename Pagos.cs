// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Pagos
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
  [XmlRoot(IsNullable = false, Namespace = "http://www.sat.gob.mx/Pagos")]
  [Serializable]
  public class Pagos
  {
    private PagosPago[] pagoField;
    private string versionField;

    public Pagos() => this.versionField = "1.0";

    [XmlElement("Pago")]
    public PagosPago[] Pago
    {
      get => this.pagoField;
      set => this.pagoField = value;
    }

    [XmlAttribute]
    public string Version
    {
      get => this.versionField;
      set => this.versionField = value;
    }
  }
}
