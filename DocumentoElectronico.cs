// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.DocumentoElectronico
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System;

namespace AsistenteComplementoPago
{
  public class DocumentoElectronico
  {
    public char estado { get; set; }

    public string folio_fiscal { get; set; }

    public string cadena_original { get; set; }

    public string sello_CFD { get; set; }

    public string sello_SAT { get; set; }

    public DateTime fecha_timbrado { get; set; }

    public string mensaje { get; set; }

    public DocumentoElectronico()
    {
      this.estado = 'N';
      this.folio_fiscal = string.Empty;
      this.cadena_original = string.Empty;
      this.sello_CFD = string.Empty;
      this.sello_SAT = string.Empty;
      this.mensaje = string.Empty;
      this.fecha_timbrado = DateTime.Now;
    }
  }
}
