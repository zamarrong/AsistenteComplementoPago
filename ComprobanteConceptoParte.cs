// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.ComprobanteConceptoParte
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
  public class ComprobanteConceptoParte
  {
    private ComprobanteConceptoParteInformacionAduanera[] informacionAduaneraField;
    private string claveProdServField;
    private string noIdentificacionField;
    private Decimal cantidadField;
    private string unidadField;
    private string descripcionField;
    private Decimal valorUnitarioField;
    private bool valorUnitarioFieldSpecified;
    private Decimal importeField;
    private bool importeFieldSpecified;

    [XmlElement("InformacionAduanera")]
    public ComprobanteConceptoParteInformacionAduanera[] InformacionAduanera
    {
      get => this.informacionAduaneraField;
      set => this.informacionAduaneraField = value;
    }

    [XmlAttribute]
    public string ClaveProdServ
    {
      get => this.claveProdServField;
      set => this.claveProdServField = value;
    }

    [XmlAttribute]
    public string NoIdentificacion
    {
      get => this.noIdentificacionField;
      set => this.noIdentificacionField = value;
    }

    [XmlAttribute]
    public Decimal Cantidad
    {
      get => this.cantidadField;
      set => this.cantidadField = value;
    }

    [XmlAttribute]
    public string Unidad
    {
      get => this.unidadField;
      set => this.unidadField = value;
    }

    [XmlAttribute]
    public string Descripcion
    {
      get => this.descripcionField;
      set => this.descripcionField = value;
    }

    [XmlAttribute]
    public Decimal ValorUnitario
    {
      get => this.valorUnitarioField;
      set => this.valorUnitarioField = value;
    }

    [XmlIgnore]
    public bool ValorUnitarioSpecified
    {
      get => this.valorUnitarioFieldSpecified;
      set => this.valorUnitarioFieldSpecified = value;
    }

    [XmlAttribute]
    public Decimal Importe
    {
      get => this.importeField;
      set => this.importeField = value;
    }

    [XmlIgnore]
    public bool ImporteSpecified
    {
      get => this.importeFieldSpecified;
      set => this.importeFieldSpecified = value;
    }
  }
}
