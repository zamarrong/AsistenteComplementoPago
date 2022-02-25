// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Edicom.CancelQueryData
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
  public class CancelQueryData
  {
    private string cancelStatusField;
    private string isCancelableField;
    private string statusField;
    private string statusCodeField;

    [XmlElement(IsNullable = true)]
    public string cancelStatus
    {
      get => this.cancelStatusField;
      set => this.cancelStatusField = value;
    }

    [XmlElement(IsNullable = true)]
    public string isCancelable
    {
      get => this.isCancelableField;
      set => this.isCancelableField = value;
    }

    [XmlElement(IsNullable = true)]
    public string status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    [XmlElement(IsNullable = true)]
    public string statusCode
    {
      get => this.statusCodeField;
      set => this.statusCodeField = value;
    }
  }
}
