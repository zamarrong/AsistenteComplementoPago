// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Edicom.CancelData
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
  public class CancelData
  {
    private string ackField;
    private CancelQueryData cancelQueryDataField;
    private string rfcEField;
    private string statusField;
    private string statusCodeField;
    private string uuidField;

    [XmlElement(IsNullable = true)]
    public string ack
    {
      get => this.ackField;
      set => this.ackField = value;
    }

    [XmlElement(IsNullable = true)]
    public CancelQueryData cancelQueryData
    {
      get => this.cancelQueryDataField;
      set => this.cancelQueryDataField = value;
    }

    [XmlElement(IsNullable = true)]
    public string rfcE
    {
      get => this.rfcEField;
      set => this.rfcEField = value;
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

    [XmlElement(IsNullable = true)]
    public string uuid
    {
      get => this.uuidField;
      set => this.uuidField = value;
    }
  }
}
