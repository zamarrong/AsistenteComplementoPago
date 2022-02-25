// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.ComprobanteConcepto
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
  public class ComprobanteConcepto
  {
    private ComprobanteConceptoImpuestos impuestosField;
    private ComprobanteConceptoInformacionAduanera[] informacionAduaneraField;
    private ComprobanteConceptoCuentaPredial cuentaPredialField;
    private ComprobanteConceptoComplementoConcepto complementoConceptoField;
    private ComprobanteConceptoParte[] parteField;
    private string claveProdServField;
    private string noIdentificacionField;
    private Decimal cantidadField;
    private string claveUnidadField;
    private string unidadField;
    private string descripcionField;
    private Decimal valorUnitarioField;
    private Decimal importeField;
    private Decimal descuentoField;
    private bool descuentoFieldSpecified;

    public ComprobanteConceptoImpuestos Impuestos
    {
      get => this.impuestosField;
      set => this.impuestosField = value;
    }

    [XmlElement("InformacionAduanera")]
    public ComprobanteConceptoInformacionAduanera[] InformacionAduanera
    {
      get => this.informacionAduaneraField;
      set => this.informacionAduaneraField = value;
    }

    public ComprobanteConceptoCuentaPredial CuentaPredial
    {
      get => this.cuentaPredialField;
      set => this.cuentaPredialField = value;
    }

    public ComprobanteConceptoComplementoConcepto ComplementoConcepto
    {
      get => this.complementoConceptoField;
      set => this.complementoConceptoField = value;
    }

    [XmlElement("Parte")]
    public ComprobanteConceptoParte[] Parte
    {
      get => this.parteField;
      set => this.parteField = value;
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
    public string ClaveUnidad
    {
      get => this.claveUnidadField;
      set => this.claveUnidadField = value;
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

    [XmlAttribute]
    public Decimal Importe
    {
      get => this.importeField;
      set => this.importeField = value;
    }

    [XmlAttribute]
    public Decimal Descuento
    {
      get => this.descuentoField;
      set
      {
        this.descuentoFieldSpecified = true;
        this.descuentoField = value;
      }
    }

    [XmlIgnore]
    public bool DescuentoSpecified
    {
      get => this.descuentoFieldSpecified;
      set => this.descuentoFieldSpecified = value;
    }
  }
}
