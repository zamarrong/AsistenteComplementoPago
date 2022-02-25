// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Edicom.CFDiService
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using AsistenteComplementoPago.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace AsistenteComplementoPago.Edicom
{
  [GeneratedCode("System.Web.Services", "4.7.3056.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [WebServiceBinding(Name = "CFDiSoapBinding", Namespace = "http://cfdi.service.ediwinws.edicom.com")]
  public class CFDiService : SoapHttpClientProtocol
  {
    private SendOrPostCallback getCfdiAckOperationCompleted;
    private SendOrPostCallback getCFDiStatusOperationCompleted;
    private SendOrPostCallback cancelaCFDiOperationCompleted;
    private SendOrPostCallback cancelCFDiAsyncOperationCompleted;
    private SendOrPostCallback getUUIDTestOperationCompleted;
    private SendOrPostCallback getCfdiTestOperationCompleted;
    private SendOrPostCallback getCfdiFromUUIDOperationCompleted;
    private SendOrPostCallback getTimbreCfdiOperationCompleted;
    private SendOrPostCallback exportCfdiOperationCompleted;
    private SendOrPostCallback getCfdiRetencionesOperationCompleted;
    private SendOrPostCallback getTimbreCfdiRetencionesOperationCompleted;
    private SendOrPostCallback getCfdiRetencionesTestOperationCompleted;
    private SendOrPostCallback getTimbreCfdiRetencionesTestOperationCompleted;
    private SendOrPostCallback cancelaCFDiRetencionesOperationCompleted;
    private SendOrPostCallback cancelaCFDiRetencionesSignedOperationCompleted;
    private SendOrPostCallback cancelCFDiSignedAsyncOperationCompleted;
    private SendOrPostCallback getTimbreCfdiTestOperationCompleted;
    private SendOrPostCallback cancelaCFDiSignedOperationCompleted;
    private SendOrPostCallback getCfdiOperationCompleted;
    private SendOrPostCallback getUUIDOperationCompleted;
    private SendOrPostCallback changePasswordOperationCompleted;
    private bool useDefaultCredentialsSetExplicitly;

    public CFDiService()
    {
      this.Url = Settings.Default.AsistenteComplementoPago_Edicom_CFDiService;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    public new string Url
    {
      get => base.Url;
      set
      {
        if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
          base.UseDefaultCredentials = false;
        base.Url = value;
      }
    }

    public new bool UseDefaultCredentials
    {
      get => base.UseDefaultCredentials;
      set
      {
        base.UseDefaultCredentials = value;
        this.useDefaultCredentialsSetExplicitly = true;
      }
    }

    public event getCfdiAckCompletedEventHandler getCfdiAckCompleted;

    public event getCFDiStatusCompletedEventHandler getCFDiStatusCompleted;

    public event cancelaCFDiCompletedEventHandler cancelaCFDiCompleted;

    public event cancelCFDiAsyncCompletedEventHandler cancelCFDiAsyncCompleted;

    public event getUUIDTestCompletedEventHandler getUUIDTestCompleted;

    public event getCfdiTestCompletedEventHandler getCfdiTestCompleted;

    public event getCfdiFromUUIDCompletedEventHandler getCfdiFromUUIDCompleted;

    public event getTimbreCfdiCompletedEventHandler getTimbreCfdiCompleted;

    public event exportCfdiCompletedEventHandler exportCfdiCompleted;

    public event getCfdiRetencionesCompletedEventHandler getCfdiRetencionesCompleted;

    public event getTimbreCfdiRetencionesCompletedEventHandler getTimbreCfdiRetencionesCompleted;

    public event getCfdiRetencionesTestCompletedEventHandler getCfdiRetencionesTestCompleted;

    public event getTimbreCfdiRetencionesTestCompletedEventHandler getTimbreCfdiRetencionesTestCompleted;

    public event cancelaCFDiRetencionesCompletedEventHandler cancelaCFDiRetencionesCompleted;

    public event cancelaCFDiRetencionesSignedCompletedEventHandler cancelaCFDiRetencionesSignedCompleted;

    public event cancelCFDiSignedAsyncCompletedEventHandler cancelCFDiSignedAsyncCompleted;

    public event getTimbreCfdiTestCompletedEventHandler getTimbreCfdiTestCompleted;

    public event cancelaCFDiSignedCompletedEventHandler cancelaCFDiSignedCompleted;

    public event getCfdiCompletedEventHandler getCfdiCompleted;

    public event getUUIDCompletedEventHandler getUUIDCompleted;

    public event changePasswordCompletedEventHandler changePasswordCompleted;

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getCfdiAckReturn", DataType = "base64Binary")]
    public byte[] getCfdiAck(string user, string password, [XmlElement("uuid")] string[] uuid) => (byte[]) this.Invoke(nameof (getCfdiAck), new object[3]
    {
      (object) user,
      (object) password,
      (object) uuid
    })[0];

    public void getCfdiAckAsync(string user, string password, string[] uuid) => this.getCfdiAckAsync(user, password, uuid, (object) null);

    public void getCfdiAckAsync(string user, string password, string[] uuid, object userState)
    {
      if (this.getCfdiAckOperationCompleted == null)
        this.getCfdiAckOperationCompleted = new SendOrPostCallback(this.OngetCfdiAckOperationCompleted);
      this.InvokeAsync("getCfdiAck", new object[3]
      {
        (object) user,
        (object) password,
        (object) uuid
      }, this.getCfdiAckOperationCompleted, userState);
    }

    private void OngetCfdiAckOperationCompleted(object arg)
    {
      if (this.getCfdiAckCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getCfdiAckCompleted((object) this, new getCfdiAckCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getCFDiStatusReturn")]
    public CancelQueryData getCFDiStatus(
      string user,
      string password,
      string rfcE,
      string rfcR,
      string uuid,
      double total,
      bool test)
    {
      return (CancelQueryData) this.Invoke(nameof (getCFDiStatus), new object[7]
      {
        (object) user,
        (object) password,
        (object) rfcE,
        (object) rfcR,
        (object) uuid,
        (object) total,
        (object) test
      })[0];
    }

    public void getCFDiStatusAsync(
      string user,
      string password,
      string rfcE,
      string rfcR,
      string uuid,
      double total,
      bool test)
    {
      this.getCFDiStatusAsync(user, password, rfcE, rfcR, uuid, total, test, (object) null);
    }

    public void getCFDiStatusAsync(
      string user,
      string password,
      string rfcE,
      string rfcR,
      string uuid,
      double total,
      bool test,
      object userState)
    {
      if (this.getCFDiStatusOperationCompleted == null)
        this.getCFDiStatusOperationCompleted = new SendOrPostCallback(this.OngetCFDiStatusOperationCompleted);
      this.InvokeAsync("getCFDiStatus", new object[7]
      {
        (object) user,
        (object) password,
        (object) rfcE,
        (object) rfcR,
        (object) uuid,
        (object) total,
        (object) test
      }, this.getCFDiStatusOperationCompleted, userState);
    }

    private void OngetCFDiStatusOperationCompleted(object arg)
    {
      if (this.getCFDiStatusCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getCFDiStatusCompleted((object) this, new getCFDiStatusCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("cancelaCFDiReturn")]
    public CancelaResponse cancelaCFDi(
      string user,
      string password,
      string rfc,
      [XmlElement("uuid")] string[] uuid,
      [XmlElement(DataType = "base64Binary")] byte[] pfx,
      string pfxPassword)
    {
      return (CancelaResponse) this.Invoke(nameof (cancelaCFDi), new object[6]
      {
        (object) user,
        (object) password,
        (object) rfc,
        (object) uuid,
        (object) pfx,
        (object) pfxPassword
      })[0];
    }

    public void cancelaCFDiAsync(
      string user,
      string password,
      string rfc,
      string[] uuid,
      byte[] pfx,
      string pfxPassword)
    {
      this.cancelaCFDiAsync(user, password, rfc, uuid, pfx, pfxPassword, (object) null);
    }

    public void cancelaCFDiAsync(
      string user,
      string password,
      string rfc,
      string[] uuid,
      byte[] pfx,
      string pfxPassword,
      object userState)
    {
      if (this.cancelaCFDiOperationCompleted == null)
        this.cancelaCFDiOperationCompleted = new SendOrPostCallback(this.OncancelaCFDiOperationCompleted);
      this.InvokeAsync("cancelaCFDi", new object[6]
      {
        (object) user,
        (object) password,
        (object) rfc,
        (object) uuid,
        (object) pfx,
        (object) pfxPassword
      }, this.cancelaCFDiOperationCompleted, userState);
    }

    private void OncancelaCFDiOperationCompleted(object arg)
    {
      if (this.cancelaCFDiCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.cancelaCFDiCompleted((object) this, new cancelaCFDiCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("cancelCFDiAsyncReturn")]
    public CancelData cancelCFDiAsync(
      string user,
      string password,
      string rfcE,
      string rfcR,
      string uuid,
      double total,
      [XmlElement(DataType = "base64Binary")] byte[] pfx,
      string pfxPassword,
      bool test)
    {
      return (CancelData) this.Invoke(nameof (cancelCFDiAsync), new object[9]
      {
        (object) user,
        (object) password,
        (object) rfcE,
        (object) rfcR,
        (object) uuid,
        (object) total,
        (object) pfx,
        (object) pfxPassword,
        (object) test
      })[0];
    }

    public void cancelCFDiAsyncAsync(
      string user,
      string password,
      string rfcE,
      string rfcR,
      string uuid,
      double total,
      byte[] pfx,
      string pfxPassword,
      bool test)
    {
      this.cancelCFDiAsyncAsync(user, password, rfcE, rfcR, uuid, total, pfx, pfxPassword, test, (object) null);
    }

    public void cancelCFDiAsyncAsync(
      string user,
      string password,
      string rfcE,
      string rfcR,
      string uuid,
      double total,
      byte[] pfx,
      string pfxPassword,
      bool test,
      object userState)
    {
      if (this.cancelCFDiAsyncOperationCompleted == null)
        this.cancelCFDiAsyncOperationCompleted = new SendOrPostCallback(this.OncancelCFDiAsyncOperationCompleted);
      this.InvokeAsync("cancelCFDiAsync", new object[9]
      {
        (object) user,
        (object) password,
        (object) rfcE,
        (object) rfcR,
        (object) uuid,
        (object) total,
        (object) pfx,
        (object) pfxPassword,
        (object) test
      }, this.cancelCFDiAsyncOperationCompleted, userState);
    }

    private void OncancelCFDiAsyncOperationCompleted(object arg)
    {
      if (this.cancelCFDiAsyncCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.cancelCFDiAsyncCompleted((object) this, new cancelCFDiAsyncCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getUUIDTestReturn")]
    public string getUUIDTest(string user, string password, [XmlElement(DataType = "base64Binary")] byte[] file) => (string) this.Invoke(nameof (getUUIDTest), new object[3]
    {
      (object) user,
      (object) password,
      (object) file
    })[0];

    public void getUUIDTestAsync(string user, string password, byte[] file) => this.getUUIDTestAsync(user, password, file, (object) null);

    public void getUUIDTestAsync(string user, string password, byte[] file, object userState)
    {
      if (this.getUUIDTestOperationCompleted == null)
        this.getUUIDTestOperationCompleted = new SendOrPostCallback(this.OngetUUIDTestOperationCompleted);
      this.InvokeAsync("getUUIDTest", new object[3]
      {
        (object) user,
        (object) password,
        (object) file
      }, this.getUUIDTestOperationCompleted, userState);
    }

    private void OngetUUIDTestOperationCompleted(object arg)
    {
      if (this.getUUIDTestCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getUUIDTestCompleted((object) this, new getUUIDTestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getCfdiTestReturn", DataType = "base64Binary")]
    public byte[] getCfdiTest(string user, string password, [XmlElement(DataType = "base64Binary")] byte[] file) => (byte[]) this.Invoke(nameof (getCfdiTest), new object[3]
    {
      (object) user,
      (object) password,
      (object) file
    })[0];

    public void getCfdiTestAsync(string user, string password, byte[] file) => this.getCfdiTestAsync(user, password, file, (object) null);

    public void getCfdiTestAsync(string user, string password, byte[] file, object userState)
    {
      if (this.getCfdiTestOperationCompleted == null)
        this.getCfdiTestOperationCompleted = new SendOrPostCallback(this.OngetCfdiTestOperationCompleted);
      this.InvokeAsync("getCfdiTest", new object[3]
      {
        (object) user,
        (object) password,
        (object) file
      }, this.getCfdiTestOperationCompleted, userState);
    }

    private void OngetCfdiTestOperationCompleted(object arg)
    {
      if (this.getCfdiTestCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getCfdiTestCompleted((object) this, new getCfdiTestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getCfdiFromUUIDReturn", DataType = "base64Binary")]
    public byte[] getCfdiFromUUID(string user, string password, string rfc, [XmlElement("uuid")] string[] uuid) => (byte[]) this.Invoke(nameof (getCfdiFromUUID), new object[4]
    {
      (object) user,
      (object) password,
      (object) rfc,
      (object) uuid
    })[0];

    public void getCfdiFromUUIDAsync(string user, string password, string rfc, string[] uuid) => this.getCfdiFromUUIDAsync(user, password, rfc, uuid, (object) null);

    public void getCfdiFromUUIDAsync(
      string user,
      string password,
      string rfc,
      string[] uuid,
      object userState)
    {
      if (this.getCfdiFromUUIDOperationCompleted == null)
        this.getCfdiFromUUIDOperationCompleted = new SendOrPostCallback(this.OngetCfdiFromUUIDOperationCompleted);
      this.InvokeAsync("getCfdiFromUUID", new object[4]
      {
        (object) user,
        (object) password,
        (object) rfc,
        (object) uuid
      }, this.getCfdiFromUUIDOperationCompleted, userState);
    }

    private void OngetCfdiFromUUIDOperationCompleted(object arg)
    {
      if (this.getCfdiFromUUIDCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getCfdiFromUUIDCompleted((object) this, new getCfdiFromUUIDCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getTimbreCfdiReturn", DataType = "base64Binary")]
    public byte[] getTimbreCfdi(string user, string password, [XmlElement(DataType = "base64Binary")] byte[] file) => (byte[]) this.Invoke(nameof (getTimbreCfdi), new object[3]
    {
      (object) user,
      (object) password,
      (object) file
    })[0];

    public void getTimbreCfdiAsync(string user, string password, byte[] file) => this.getTimbreCfdiAsync(user, password, file, (object) null);

    public void getTimbreCfdiAsync(string user, string password, byte[] file, object userState)
    {
      if (this.getTimbreCfdiOperationCompleted == null)
        this.getTimbreCfdiOperationCompleted = new SendOrPostCallback(this.OngetTimbreCfdiOperationCompleted);
      this.InvokeAsync("getTimbreCfdi", new object[3]
      {
        (object) user,
        (object) password,
        (object) file
      }, this.getTimbreCfdiOperationCompleted, userState);
    }

    private void OngetTimbreCfdiOperationCompleted(object arg)
    {
      if (this.getTimbreCfdiCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getTimbreCfdiCompleted((object) this, new getTimbreCfdiCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("exportCfdiReturn", DataType = "base64Binary")]
    public byte[] exportCfdi(
      string user,
      string password,
      string rfc,
      DateTime iniDate,
      DateTime endDate)
    {
      return (byte[]) this.Invoke(nameof (exportCfdi), new object[5]
      {
        (object) user,
        (object) password,
        (object) rfc,
        (object) iniDate,
        (object) endDate
      })[0];
    }

    public void exportCfdiAsync(
      string user,
      string password,
      string rfc,
      DateTime iniDate,
      DateTime endDate)
    {
      this.exportCfdiAsync(user, password, rfc, iniDate, endDate, (object) null);
    }

    public void exportCfdiAsync(
      string user,
      string password,
      string rfc,
      DateTime iniDate,
      DateTime endDate,
      object userState)
    {
      if (this.exportCfdiOperationCompleted == null)
        this.exportCfdiOperationCompleted = new SendOrPostCallback(this.OnexportCfdiOperationCompleted);
      this.InvokeAsync("exportCfdi", new object[5]
      {
        (object) user,
        (object) password,
        (object) rfc,
        (object) iniDate,
        (object) endDate
      }, this.exportCfdiOperationCompleted, userState);
    }

    private void OnexportCfdiOperationCompleted(object arg)
    {
      if (this.exportCfdiCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.exportCfdiCompleted((object) this, new exportCfdiCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getCfdiRetencionesReturn", DataType = "base64Binary")]
    public byte[] getCfdiRetenciones(string user, string password, [XmlElement(DataType = "base64Binary")] byte[] file) => (byte[]) this.Invoke(nameof (getCfdiRetenciones), new object[3]
    {
      (object) user,
      (object) password,
      (object) file
    })[0];

    public void getCfdiRetencionesAsync(string user, string password, byte[] file) => this.getCfdiRetencionesAsync(user, password, file, (object) null);

    public void getCfdiRetencionesAsync(
      string user,
      string password,
      byte[] file,
      object userState)
    {
      if (this.getCfdiRetencionesOperationCompleted == null)
        this.getCfdiRetencionesOperationCompleted = new SendOrPostCallback(this.OngetCfdiRetencionesOperationCompleted);
      this.InvokeAsync("getCfdiRetenciones", new object[3]
      {
        (object) user,
        (object) password,
        (object) file
      }, this.getCfdiRetencionesOperationCompleted, userState);
    }

    private void OngetCfdiRetencionesOperationCompleted(object arg)
    {
      if (this.getCfdiRetencionesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getCfdiRetencionesCompleted((object) this, new getCfdiRetencionesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getTimbreCfdiRetencionesReturn", DataType = "base64Binary")]
    public byte[] getTimbreCfdiRetenciones(string user, string password, [XmlElement(DataType = "base64Binary")] byte[] file) => (byte[]) this.Invoke(nameof (getTimbreCfdiRetenciones), new object[3]
    {
      (object) user,
      (object) password,
      (object) file
    })[0];

    public void getTimbreCfdiRetencionesAsync(string user, string password, byte[] file) => this.getTimbreCfdiRetencionesAsync(user, password, file, (object) null);

    public void getTimbreCfdiRetencionesAsync(
      string user,
      string password,
      byte[] file,
      object userState)
    {
      if (this.getTimbreCfdiRetencionesOperationCompleted == null)
        this.getTimbreCfdiRetencionesOperationCompleted = new SendOrPostCallback(this.OngetTimbreCfdiRetencionesOperationCompleted);
      this.InvokeAsync("getTimbreCfdiRetenciones", new object[3]
      {
        (object) user,
        (object) password,
        (object) file
      }, this.getTimbreCfdiRetencionesOperationCompleted, userState);
    }

    private void OngetTimbreCfdiRetencionesOperationCompleted(object arg)
    {
      if (this.getTimbreCfdiRetencionesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getTimbreCfdiRetencionesCompleted((object) this, new getTimbreCfdiRetencionesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getCfdiRetencionesTestReturn", DataType = "base64Binary")]
    public byte[] getCfdiRetencionesTest(string user, string password, [XmlElement(DataType = "base64Binary")] byte[] file) => (byte[]) this.Invoke(nameof (getCfdiRetencionesTest), new object[3]
    {
      (object) user,
      (object) password,
      (object) file
    })[0];

    public void getCfdiRetencionesTestAsync(string user, string password, byte[] file) => this.getCfdiRetencionesTestAsync(user, password, file, (object) null);

    public void getCfdiRetencionesTestAsync(
      string user,
      string password,
      byte[] file,
      object userState)
    {
      if (this.getCfdiRetencionesTestOperationCompleted == null)
        this.getCfdiRetencionesTestOperationCompleted = new SendOrPostCallback(this.OngetCfdiRetencionesTestOperationCompleted);
      this.InvokeAsync("getCfdiRetencionesTest", new object[3]
      {
        (object) user,
        (object) password,
        (object) file
      }, this.getCfdiRetencionesTestOperationCompleted, userState);
    }

    private void OngetCfdiRetencionesTestOperationCompleted(object arg)
    {
      if (this.getCfdiRetencionesTestCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getCfdiRetencionesTestCompleted((object) this, new getCfdiRetencionesTestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getTimbreCfdiRetencionesTestReturn", DataType = "base64Binary")]
    public byte[] getTimbreCfdiRetencionesTest(string user, string password, [XmlElement(DataType = "base64Binary")] byte[] file) => (byte[]) this.Invoke(nameof (getTimbreCfdiRetencionesTest), new object[3]
    {
      (object) user,
      (object) password,
      (object) file
    })[0];

    public void getTimbreCfdiRetencionesTestAsync(string user, string password, byte[] file) => this.getTimbreCfdiRetencionesTestAsync(user, password, file, (object) null);

    public void getTimbreCfdiRetencionesTestAsync(
      string user,
      string password,
      byte[] file,
      object userState)
    {
      if (this.getTimbreCfdiRetencionesTestOperationCompleted == null)
        this.getTimbreCfdiRetencionesTestOperationCompleted = new SendOrPostCallback(this.OngetTimbreCfdiRetencionesTestOperationCompleted);
      this.InvokeAsync("getTimbreCfdiRetencionesTest", new object[3]
      {
        (object) user,
        (object) password,
        (object) file
      }, this.getTimbreCfdiRetencionesTestOperationCompleted, userState);
    }

    private void OngetTimbreCfdiRetencionesTestOperationCompleted(object arg)
    {
      if (this.getTimbreCfdiRetencionesTestCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getTimbreCfdiRetencionesTestCompleted((object) this, new getTimbreCfdiRetencionesTestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("cancelaCFDiRetencionesReturn")]
    public CancelaResponse cancelaCFDiRetenciones(
      string user,
      string password,
      string rfc,
      [XmlElement("uuid")] string[] uuid,
      [XmlElement(DataType = "base64Binary")] byte[] pfx,
      string pfxPassword)
    {
      return (CancelaResponse) this.Invoke(nameof (cancelaCFDiRetenciones), new object[6]
      {
        (object) user,
        (object) password,
        (object) rfc,
        (object) uuid,
        (object) pfx,
        (object) pfxPassword
      })[0];
    }

    public void cancelaCFDiRetencionesAsync(
      string user,
      string password,
      string rfc,
      string[] uuid,
      byte[] pfx,
      string pfxPassword)
    {
      this.cancelaCFDiRetencionesAsync(user, password, rfc, uuid, pfx, pfxPassword, (object) null);
    }

    public void cancelaCFDiRetencionesAsync(
      string user,
      string password,
      string rfc,
      string[] uuid,
      byte[] pfx,
      string pfxPassword,
      object userState)
    {
      if (this.cancelaCFDiRetencionesOperationCompleted == null)
        this.cancelaCFDiRetencionesOperationCompleted = new SendOrPostCallback(this.OncancelaCFDiRetencionesOperationCompleted);
      this.InvokeAsync("cancelaCFDiRetenciones", new object[6]
      {
        (object) user,
        (object) password,
        (object) rfc,
        (object) uuid,
        (object) pfx,
        (object) pfxPassword
      }, this.cancelaCFDiRetencionesOperationCompleted, userState);
    }

    private void OncancelaCFDiRetencionesOperationCompleted(object arg)
    {
      if (this.cancelaCFDiRetencionesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.cancelaCFDiRetencionesCompleted((object) this, new cancelaCFDiRetencionesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("cancelaCFDiRetencionesSignedReturn")]
    public CancelaResponse cancelaCFDiRetencionesSigned(
      string user,
      string password,
      [XmlElement(DataType = "base64Binary")] byte[] sign)
    {
      return (CancelaResponse) this.Invoke(nameof (cancelaCFDiRetencionesSigned), new object[3]
      {
        (object) user,
        (object) password,
        (object) sign
      })[0];
    }

    public void cancelaCFDiRetencionesSignedAsync(string user, string password, byte[] sign) => this.cancelaCFDiRetencionesSignedAsync(user, password, sign, (object) null);

    public void cancelaCFDiRetencionesSignedAsync(
      string user,
      string password,
      byte[] sign,
      object userState)
    {
      if (this.cancelaCFDiRetencionesSignedOperationCompleted == null)
        this.cancelaCFDiRetencionesSignedOperationCompleted = new SendOrPostCallback(this.OncancelaCFDiRetencionesSignedOperationCompleted);
      this.InvokeAsync("cancelaCFDiRetencionesSigned", new object[3]
      {
        (object) user,
        (object) password,
        (object) sign
      }, this.cancelaCFDiRetencionesSignedOperationCompleted, userState);
    }

    private void OncancelaCFDiRetencionesSignedOperationCompleted(object arg)
    {
      if (this.cancelaCFDiRetencionesSignedCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.cancelaCFDiRetencionesSignedCompleted((object) this, new cancelaCFDiRetencionesSignedCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("cancelCFDiSignedAsyncReturn")]
    public CancelData cancelCFDiSignedAsync(
      string user,
      string password,
      [XmlElement(DataType = "base64Binary")] byte[] sign,
      string rfcE,
      string rfcR,
      string uuid,
      double total,
      bool test)
    {
      return (CancelData) this.Invoke(nameof (cancelCFDiSignedAsync), new object[8]
      {
        (object) user,
        (object) password,
        (object) sign,
        (object) rfcE,
        (object) rfcR,
        (object) uuid,
        (object) total,
        (object) test
      })[0];
    }

    public void cancelCFDiSignedAsyncAsync(
      string user,
      string password,
      byte[] sign,
      string rfcE,
      string rfcR,
      string uuid,
      double total,
      bool test)
    {
      this.cancelCFDiSignedAsyncAsync(user, password, sign, rfcE, rfcR, uuid, total, test, (object) null);
    }

    public void cancelCFDiSignedAsyncAsync(
      string user,
      string password,
      byte[] sign,
      string rfcE,
      string rfcR,
      string uuid,
      double total,
      bool test,
      object userState)
    {
      if (this.cancelCFDiSignedAsyncOperationCompleted == null)
        this.cancelCFDiSignedAsyncOperationCompleted = new SendOrPostCallback(this.OncancelCFDiSignedAsyncOperationCompleted);
      this.InvokeAsync("cancelCFDiSignedAsync", new object[8]
      {
        (object) user,
        (object) password,
        (object) sign,
        (object) rfcE,
        (object) rfcR,
        (object) uuid,
        (object) total,
        (object) test
      }, this.cancelCFDiSignedAsyncOperationCompleted, userState);
    }

    private void OncancelCFDiSignedAsyncOperationCompleted(object arg)
    {
      if (this.cancelCFDiSignedAsyncCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.cancelCFDiSignedAsyncCompleted((object) this, new cancelCFDiSignedAsyncCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getTimbreCfdiTestReturn", DataType = "base64Binary")]
    public byte[] getTimbreCfdiTest(string user, string password, [XmlElement(DataType = "base64Binary")] byte[] file) => (byte[]) this.Invoke(nameof (getTimbreCfdiTest), new object[3]
    {
      (object) user,
      (object) password,
      (object) file
    })[0];

    public void getTimbreCfdiTestAsync(string user, string password, byte[] file) => this.getTimbreCfdiTestAsync(user, password, file, (object) null);

    public void getTimbreCfdiTestAsync(
      string user,
      string password,
      byte[] file,
      object userState)
    {
      if (this.getTimbreCfdiTestOperationCompleted == null)
        this.getTimbreCfdiTestOperationCompleted = new SendOrPostCallback(this.OngetTimbreCfdiTestOperationCompleted);
      this.InvokeAsync("getTimbreCfdiTest", new object[3]
      {
        (object) user,
        (object) password,
        (object) file
      }, this.getTimbreCfdiTestOperationCompleted, userState);
    }

    private void OngetTimbreCfdiTestOperationCompleted(object arg)
    {
      if (this.getTimbreCfdiTestCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getTimbreCfdiTestCompleted((object) this, new getTimbreCfdiTestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("cancelaCFDiSignedReturn")]
    public CancelaResponse cancelaCFDiSigned(
      string user,
      string password,
      [XmlElement(DataType = "base64Binary")] byte[] sign)
    {
      return (CancelaResponse) this.Invoke(nameof (cancelaCFDiSigned), new object[3]
      {
        (object) user,
        (object) password,
        (object) sign
      })[0];
    }

    public void cancelaCFDiSignedAsync(string user, string password, byte[] sign) => this.cancelaCFDiSignedAsync(user, password, sign, (object) null);

    public void cancelaCFDiSignedAsync(
      string user,
      string password,
      byte[] sign,
      object userState)
    {
      if (this.cancelaCFDiSignedOperationCompleted == null)
        this.cancelaCFDiSignedOperationCompleted = new SendOrPostCallback(this.OncancelaCFDiSignedOperationCompleted);
      this.InvokeAsync("cancelaCFDiSigned", new object[3]
      {
        (object) user,
        (object) password,
        (object) sign
      }, this.cancelaCFDiSignedOperationCompleted, userState);
    }

    private void OncancelaCFDiSignedOperationCompleted(object arg)
    {
      if (this.cancelaCFDiSignedCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.cancelaCFDiSignedCompleted((object) this, new cancelaCFDiSignedCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getCfdiReturn", DataType = "base64Binary")]
    public byte[] getCfdi(string user, string password, [XmlElement(DataType = "base64Binary")] byte[] file) => (byte[]) this.Invoke(nameof (getCfdi), new object[3]
    {
      (object) user,
      (object) password,
      (object) file
    })[0];

    public void getCfdiAsync(string user, string password, byte[] file) => this.getCfdiAsync(user, password, file, (object) null);

    public void getCfdiAsync(string user, string password, byte[] file, object userState)
    {
      if (this.getCfdiOperationCompleted == null)
        this.getCfdiOperationCompleted = new SendOrPostCallback(this.OngetCfdiOperationCompleted);
      this.InvokeAsync("getCfdi", new object[3]
      {
        (object) user,
        (object) password,
        (object) file
      }, this.getCfdiOperationCompleted, userState);
    }

    private void OngetCfdiOperationCompleted(object arg)
    {
      if (this.getCfdiCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getCfdiCompleted((object) this, new getCfdiCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("getUUIDReturn")]
    public string getUUID(string user, string password, [XmlElement(DataType = "base64Binary")] byte[] file) => (string) this.Invoke(nameof (getUUID), new object[3]
    {
      (object) user,
      (object) password,
      (object) file
    })[0];

    public void getUUIDAsync(string user, string password, byte[] file) => this.getUUIDAsync(user, password, file, (object) null);

    public void getUUIDAsync(string user, string password, byte[] file, object userState)
    {
      if (this.getUUIDOperationCompleted == null)
        this.getUUIDOperationCompleted = new SendOrPostCallback(this.OngetUUIDOperationCompleted);
      this.InvokeAsync("getUUID", new object[3]
      {
        (object) user,
        (object) password,
        (object) file
      }, this.getUUIDOperationCompleted, userState);
    }

    private void OngetUUIDOperationCompleted(object arg)
    {
      if (this.getUUIDCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getUUIDCompleted((object) this, new getUUIDCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://cfdi.service.ediwinws.edicom.com", ResponseNamespace = "http://cfdi.service.ediwinws.edicom.com", Use = SoapBindingUse.Literal)]
    [return: XmlElement("changePasswordReturn")]
    public bool changePassword(string user, string password, string newPassword) => (bool) this.Invoke(nameof (changePassword), new object[3]
    {
      (object) user,
      (object) password,
      (object) newPassword
    })[0];

    public void changePasswordAsync(string user, string password, string newPassword) => this.changePasswordAsync(user, password, newPassword, (object) null);

    public void changePasswordAsync(
      string user,
      string password,
      string newPassword,
      object userState)
    {
      if (this.changePasswordOperationCompleted == null)
        this.changePasswordOperationCompleted = new SendOrPostCallback(this.OnchangePasswordOperationCompleted);
      this.InvokeAsync("changePassword", new object[3]
      {
        (object) user,
        (object) password,
        (object) newPassword
      }, this.changePasswordOperationCompleted, userState);
    }

    private void OnchangePasswordOperationCompleted(object arg)
    {
      if (this.changePasswordCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.changePasswordCompleted((object) this, new changePasswordCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    public new void CancelAsync(object userState) => base.CancelAsync(userState);

    private bool IsLocalFileSystemWebService(string url)
    {
      if (url == null || url == string.Empty)
        return false;
      Uri uri = new Uri(url);
      return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
    }
  }
}
