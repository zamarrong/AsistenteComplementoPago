// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.CookieReader
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AsistenteComplementoPago
{
  public class CookieReader
  {
    private const int InternetCookieHttponly = 8192;

    public static string GetCookie(string url)
    {
      int size = 512;
      StringBuilder cookieData = new StringBuilder(size);
      if (!CookieReader.InternetGetCookieEx(url, (string) null, cookieData, ref size, 8192, IntPtr.Zero))
      {
        if (size < 0)
          return (string) null;
        cookieData = new StringBuilder(size);
        if (!CookieReader.InternetGetCookieEx(url, (string) null, cookieData, ref size, 8192, IntPtr.Zero))
          return (string) null;
      }
      return cookieData.ToString();
    }

    [DllImport("wininet.dll", SetLastError = true)]
    private static extern bool InternetGetCookieEx(
      string url,
      string cookieName,
      StringBuilder cookieData,
      ref int size,
      int flags,
      IntPtr pReserved);
  }
}
