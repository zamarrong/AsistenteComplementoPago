// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Edicom.CancelaResponse
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace AsistenteComplementoPago.Edicom
{
  [GeneratedCode("System.Xml", "4.7.3056.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://cfdi.service.ediwinws.edicom.com")]
  [Serializable]
  public class CancelaResponse
  {
    private string ackField;
    private string textField;
    private string[] uuidsField;

    [XmlElement(IsNullable = true)]
    public string ack
    {
      get => this.ackField;
      set => this.ackField = value;
    }

    [XmlElement(IsNullable = true)]
    public string text
    {
      get => this.textField;
      set => this.textField = value;
    }

    [XmlArray(IsNullable = true)]
    [XmlArrayItem("item", IsNullable = false)]
    public string[] uuids
    {
      get => this.uuidsField;
      set => this.uuidsField = value;
    }
  }
}
