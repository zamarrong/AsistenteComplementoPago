// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Utilidades.StringWriterWithEncoding
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System.IO;
using System.Text;

namespace AsistenteComplementoPago.Utilidades
{
  public class StringWriterWithEncoding : StringWriter
  {
    private readonly Encoding m_Encoding;

    public StringWriterWithEncoding(Encoding encoding) => this.m_Encoding = encoding;

    public override Encoding Encoding => this.m_Encoding;
  }
}
