// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.ComprobanteReceptor
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
  public class ComprobanteReceptor
  {
    private string rfcField;
    private string nombreField;
    private string residenciaFiscalField;
    private bool residenciaFiscalFieldSpecified;
    private string numRegIdTribField;
    private string usoCFDIField;

    [XmlAttribute]
    public string Rfc
    {
      get => this.rfcField;
      set => this.rfcField = value;
    }

    [XmlAttribute]
    public string Nombre
    {
      get => this.nombreField;
      set => this.nombreField = value;
    }

    [XmlAttribute]
    public string ResidenciaFiscal
    {
      get => this.residenciaFiscalField;
      set => this.residenciaFiscalField = value;
    }

    [XmlIgnore]
    public bool ResidenciaFiscalSpecified
    {
      get => this.residenciaFiscalFieldSpecified;
      set => this.residenciaFiscalFieldSpecified = value;
    }

    [XmlAttribute]
    public string NumRegIdTrib
    {
      get => this.numRegIdTribField;
      set => this.numRegIdTribField = value;
    }

    [XmlAttribute]
    public string UsoCFDI
    {
      get => this.usoCFDIField;
      set => this.usoCFDIField = value;
    }
  }
}
