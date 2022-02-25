// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Empresa
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System.Collections.Generic;

namespace AsistenteComplementoPago
{
  public class Empresa
  {
    public string nombre { get; set; }

    public string rfc { get; set; }

    public string regimen_fiscal { get; set; }

    public string cp { get; set; }

    public Empresa()
    {
      this.nombre = "";
      this.rfc = "";
      this.regimen_fiscal = "";
      this.cp = "";
    }

    public class TipoPersona
    {
      public char tipo { get; set; }

      public string nombre { get; set; }

      public static List<Empresa.TipoPersona> Tipos() => new List<Empresa.TipoPersona>()
      {
        new Empresa.TipoPersona()
        {
          tipo = 'F',
          nombre = "Persona física"
        },
        new Empresa.TipoPersona()
        {
          tipo = 'M',
          nombre = "Persona moral"
        }
      };

      public static char ObtenerPredeterminado() => 'F';
    }
  }
}
