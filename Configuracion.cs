// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Configuracion
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System.IO;

namespace AsistenteComplementoPago
{
  public class Configuracion
  {
    public bool modo_prueba { get; set; }

    public string directorio_xml { get; set; }

    public Configuracion()
    {
      this.modo_prueba = true;
      this.directorio_xml = Directory.GetCurrentDirectory() + "/XML";
    }
  }
}
