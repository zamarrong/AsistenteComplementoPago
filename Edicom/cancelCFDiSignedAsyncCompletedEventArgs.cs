// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Edicom.cancelCFDiSignedAsyncCompletedEventArgs
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace AsistenteComplementoPago.Edicom
{
  [GeneratedCode("System.Web.Services", "4.7.3056.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class cancelCFDiSignedAsyncCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal cancelCFDiSignedAsyncCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public CancelData Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (CancelData) this.results[0];
      }
    }
  }
}
