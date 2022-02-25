// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Utilidades.SelloDigital
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Xsl;
using JavaScience;

namespace AsistenteComplementoPago.Utilidades
{
  public class SelloDigital
  {
    public string Sellar2(string CadenaOriginal, string ArchivoClavePrivada, string lPassword)
    {
      try
      {
        byte[] numArray = File.ReadAllBytes(ArchivoClavePrivada);
        RsaKeyParameters rsaKeyParameters = (RsaKeyParameters) PrivateKeyFactory.DecryptKey(lPassword.ToCharArray(), numArray);
        ISigner signer = SignerUtilities.GetSigner("SHA256withRSA");
        signer.Init(true, (ICipherParameters) rsaKeyParameters);
        byte[] bytes = Encoding.UTF8.GetBytes(CadenaOriginal);
        signer.BlockUpdate(bytes, 0, bytes.Length);
        return Convert.ToBase64String(signer.GenerateSignature());
      }
      catch (NullReferenceException ex)
      {
        throw new NullReferenceException("Imposible sellar el documento.");
      }
    }

    public string Sellar(string CadenaOriginal, string ArchivoClavePrivada, string lPassword)
    {
      byte[] encpkcs8 = File.ReadAllBytes(ArchivoClavePrivada);
      byte[] numArray = (byte[]) null;
      SecureString secpswd = new SecureString();
      SHA256Managed shA256Managed = new SHA256Managed();
      secpswd.Clear();
      foreach (char c in lPassword.ToCharArray())
        secpswd.AppendChar(c);
      RSACryptoServiceProvider cryptoServiceProvider = opensslkey.DecodeEncryptedPrivateKeyInfo(encpkcs8, secpswd);
      numArray = Encoding.UTF8.GetBytes(CadenaOriginal);
      byte[] inArray;
      try
      {
        inArray = cryptoServiceProvider.SignData(Encoding.UTF8.GetBytes(CadenaOriginal), (object) shA256Managed);
      }
      catch (NullReferenceException ex)
      {
        return this.Sellar2(CadenaOriginal, ArchivoClavePrivada, lPassword);
      }
      return Convert.ToBase64String(inArray);
    }

    public string Sellar(string CadenaOriginal, byte[] ArchivoClavePrivada, string lPassword)
    {
      byte[] encpkcs8 = ArchivoClavePrivada;
      byte[] numArray = (byte[]) null;
      SecureString secpswd = new SecureString();
      SHA256Managed shA256Managed = new SHA256Managed();
      secpswd.Clear();
      foreach (char c in lPassword.ToCharArray())
        secpswd.AppendChar(c);
      RSACryptoServiceProvider cryptoServiceProvider = opensslkey.DecodeEncryptedPrivateKeyInfo(encpkcs8, secpswd);
      numArray = Encoding.UTF8.GetBytes(CadenaOriginal);
      byte[] inArray;
      try
      {
        inArray = cryptoServiceProvider.SignData(Encoding.UTF8.GetBytes(CadenaOriginal), (object) shA256Managed);
      }
      catch (NullReferenceException ex)
      {
        throw new NullReferenceException("Clave privada incorrecta.");
      }
      return Convert.ToBase64String(inArray);
    }

    public bool VerificarSello(
      string CadenaOriginal,
      string ArchivoClavePrivada,
      string lPassword,
      string ArchivoClavePublica)
    {
      byte[] encpkcs8 = File.ReadAllBytes(ArchivoClavePrivada);
      byte[] numArray1 = (byte[]) null;
      SecureString secpswd = new SecureString();
      SHA1Managed shA1Managed1 = new SHA1Managed();
      secpswd.Clear();
      foreach (char c in lPassword.ToCharArray())
        secpswd.AppendChar(c);
      RSACryptoServiceProvider cryptoServiceProvider1 = opensslkey.DecodeEncryptedPrivateKeyInfo(encpkcs8, secpswd);
      numArray1 = Encoding.UTF8.GetBytes(CadenaOriginal);
      byte[] numArray2;
      try
      {
        numArray2 = cryptoServiceProvider1.SignData(Encoding.UTF8.GetBytes(CadenaOriginal), (object) shA1Managed1);
      }
      catch (NullReferenceException ex)
      {
        throw new NullReferenceException("Clave privada incorrecta.");
      }
      Convert.ToBase64String(numArray2);
      RSACryptoServiceProvider cryptoServiceProvider2 = new RSACryptoServiceProvider();
      SHA1Managed shA1Managed2 = new SHA1Managed();
      cryptoServiceProvider2.VerifyData(Encoding.UTF8.GetBytes(CadenaOriginal), (object) CryptoConfig.MapNameToOID("SHA1"), numArray2);
      byte[] hash = shA1Managed2.ComputeHash(numArray2);
      return cryptoServiceProvider2.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), Encoding.UTF8.GetBytes(CadenaOriginal));
    }

    public string SellarMD5(string CadenaOriginal, string ArchivoClavePrivada, string lPassword)
    {
      byte[] encpkcs8 = File.ReadAllBytes(ArchivoClavePrivada);
      SecureString secpswd = new SecureString();
      secpswd.Clear();
      foreach (char c in lPassword.ToCharArray())
        secpswd.AppendChar(c);
      RSACryptoServiceProvider cryptoServiceProvider1 = opensslkey.DecodeEncryptedPrivateKeyInfo(encpkcs8, secpswd);
      MD5CryptoServiceProvider cryptoServiceProvider2 = new MD5CryptoServiceProvider();
      byte[] bytes = Encoding.UTF8.GetBytes(CadenaOriginal);
      cryptoServiceProvider2.ComputeHash(bytes);
      return Convert.ToBase64String(cryptoServiceProvider1.SignData(bytes, (object) cryptoServiceProvider2));
    }

    public string Certificado(string ArchivoCER) => this.Base64_Encode(File.ReadAllBytes(ArchivoCER));

    public string Certificado(byte[] ArchivoCER) => this.Base64_Encode(ArchivoCER);

    private string Base64_Encode(byte[] str) => Convert.ToBase64String(str);

    private byte[] Base64_Decode(string str)
    {
      try
      {
        return Convert.FromBase64String(str);
      }
      catch
      {
        return (byte[]) null;
      }
    }

    public static string ObtenerCadenaOriginal(string NombreXML)
    {
      XslCompiledTransform compiledTransform = new XslCompiledTransform();
      StringWriter stringWriter = new StringWriter();
      if (File.Exists("cadenaoriginal_3_3.xslt"))
      {
        try
        {
          compiledTransform.Load("cadenaoriginal_3_3.xslt");
          compiledTransform.Transform(NombreXML, (XsltArgumentList) null, (TextWriter) stringWriter);
          return stringWriter.ToString();
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
      }
      if (!File.Exists("cadenaoriginal_3_3.xslt"))
        return "Error al cargar el validador.";
      try
      {
        compiledTransform.Load("cadenaoriginal_3_3.xslt");
        compiledTransform.Transform(NombreXML, (XsltArgumentList) null, (TextWriter) stringWriter);
        return stringWriter.ToString();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        throw ex;
      }
    }

    public static string MD5(string Value)
    {
      byte[] hash = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(Value));
      string str = "";
      for (int index = 0; index < hash.Length; ++index)
        str += hash[index].ToString("x2").ToLower();
      return str;
    }

    public static bool LeerCER(
      string NombreArchivo,
      out string Inicio,
      out string Final,
      out string Serie,
      out string Numero)
    {
      if (NombreArchivo.Length < 1)
      {
        Inicio = "";
        Final = "";
        Serie = "INVALIDO";
        Numero = "";
        return false;
      }
      X509Certificate2 x509Certificate2 = new X509Certificate2(NombreArchivo);
      StringBuilder stringBuilder = new StringBuilder("Detalle del certificado: \n\n");
      stringBuilder.AppendLine("Persona = " + x509Certificate2.Subject);
      stringBuilder.AppendLine("Emisor = " + x509Certificate2.Issuer);
      stringBuilder.AppendLine("Válido desde = " + x509Certificate2.NotBefore.ToString());
      Inicio = x509Certificate2.NotBefore.ToString();
      stringBuilder.AppendLine("Válido hasta = " + x509Certificate2.NotAfter.ToString());
      Final = x509Certificate2.NotAfter.ToString();
      stringBuilder.AppendLine("Tamaño de la clave = " + x509Certificate2.PublicKey.Key.KeySize.ToString());
      stringBuilder.AppendLine("Número de serie = " + x509Certificate2.SerialNumber);
      Serie = x509Certificate2.SerialNumber.ToString();
      stringBuilder.AppendLine("Hash = " + x509Certificate2.Thumbprint);
      string str1 = "";
      string str2 = "";
      if (Serie.Length < 2)
      {
        Numero = "";
      }
      else
      {
        foreach (char ch in Serie)
        {
          switch (ch)
          {
            case '0':
              str1 += ch.ToString();
              break;
            case '1':
              str1 += ch.ToString();
              break;
            case '2':
              str1 += ch.ToString();
              break;
            case '3':
              str1 += ch.ToString();
              break;
            case '4':
              str1 += ch.ToString();
              break;
            case '5':
              str1 += ch.ToString();
              break;
            case '6':
              str1 += ch.ToString();
              break;
            case '7':
              str1 += ch.ToString();
              break;
            case '8':
              str1 += ch.ToString();
              break;
            case '9':
              str1 += ch.ToString();
              break;
          }
        }
        int length;
        for (int index = 1; index < str1.Length; index = length + 1)
        {
          length = index + 1;
          string str3 = str1.Substring(0, length);
          str2 += str3.Substring(str3.Length - 1, 1);
        }
        Numero = str2;
      }
      return DateTime.Now < x509Certificate2.NotAfter && DateTime.Now > x509Certificate2.NotBefore;
    }

    public static bool LeerCER(
      byte[] NombreArchivo,
      out string Inicio,
      out string Final,
      out string Serie,
      out string Numero)
    {
      if (NombreArchivo.Length < 1)
      {
        Inicio = "";
        Final = "";
        Serie = "INVALIDO";
        Numero = "";
        return false;
      }
      X509Certificate2 x509Certificate2 = new X509Certificate2(NombreArchivo);
      StringBuilder stringBuilder = new StringBuilder("Detalle del certificado: \n\n");
      stringBuilder.AppendLine("Persona = " + x509Certificate2.Subject);
      stringBuilder.AppendLine("Emisor = " + x509Certificate2.Issuer);
      stringBuilder.AppendLine("Válido desde = " + x509Certificate2.NotBefore.ToString());
      Inicio = x509Certificate2.NotBefore.ToString();
      stringBuilder.AppendLine("Válido hasta = " + x509Certificate2.NotAfter.ToString());
      Final = x509Certificate2.NotAfter.ToString();
      stringBuilder.AppendLine("Tamaño de la clave = " + x509Certificate2.PublicKey.Key.KeySize.ToString());
      stringBuilder.AppendLine("Número de serie = " + x509Certificate2.SerialNumber);
      Serie = x509Certificate2.SerialNumber.ToString();
      stringBuilder.AppendLine("Hash = " + x509Certificate2.Thumbprint);
      string str1 = "";
      string str2 = "";
      if (Serie.Length < 2)
      {
        Numero = "";
      }
      else
      {
        foreach (char ch in Serie)
        {
          switch (ch)
          {
            case '0':
              str1 += ch.ToString();
              break;
            case '1':
              str1 += ch.ToString();
              break;
            case '2':
              str1 += ch.ToString();
              break;
            case '3':
              str1 += ch.ToString();
              break;
            case '4':
              str1 += ch.ToString();
              break;
            case '5':
              str1 += ch.ToString();
              break;
            case '6':
              str1 += ch.ToString();
              break;
            case '7':
              str1 += ch.ToString();
              break;
            case '8':
              str1 += ch.ToString();
              break;
            case '9':
              str1 += ch.ToString();
              break;
          }
        }
        int length;
        for (int index = 1; index < str1.Length; index = length + 1)
        {
          length = index + 1;
          string str3 = str1.Substring(0, length);
          str2 += str3.Substring(str3.Length - 1, 1);
        }
        Numero = str2;
      }
      return DateTime.Now < x509Certificate2.NotAfter && DateTime.Now > x509Certificate2.NotBefore;
    }

    public static bool ValidarCERKEY(
      string NombreArchivoCER,
      string NombreArchivoKEY,
      string ClavePrivada)
    {
      new X509Certificate2(File.ReadAllBytes(NombreArchivoCER)).GetPublicKey();
      X509Certificate2 x509Certificate2 = new X509Certificate2(File.ReadAllBytes(NombreArchivoKEY));
      return false;
    }
  }
}
