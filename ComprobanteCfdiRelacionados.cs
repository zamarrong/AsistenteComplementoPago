// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.ComprobanteCfdiRelacionados
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
  public class ComprobanteCfdiRelacionados
  {
    private ComprobanteCfdiRelacionadosCfdiRelacionado[] cfdiRelacionadoField;
    private string tipoRelacionField;

    [XmlElement("CfdiRelacionado")]
    public ComprobanteCfdiRelacionadosCfdiRelacionado[] CfdiRelacionado
    {
      get => this.cfdiRelacionadoField;
      set => this.cfdiRelacionadoField = value;
    }

    [XmlAttribute]
    public string TipoRelacion
    {
      get => this.tipoRelacionField;
      set => this.tipoRelacionField = value;
    }
  }
}
