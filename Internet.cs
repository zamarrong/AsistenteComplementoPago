// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Internet
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System.Runtime.InteropServices;

namespace AsistenteComplementoPago
{
  public class Internet
  {
    [DllImport("wininet.dll")]
    private static extern bool InternetGetConnectedState(out int description, int reservedValue);

    public static bool IsConnectedToInternet() => Internet.InternetGetConnectedState(out int _, 0);
  }
}
