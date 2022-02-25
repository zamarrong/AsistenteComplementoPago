// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Asistente
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AsistenteComplementoPago
{
  public class Asistente : Form
  {
    public bool cargando = false;
    private IContainer components = (IContainer) null;
    private Button btnGenerar;
    private Button btnVistaPrevia;
    private Button btnRestablecer;
    private GroupBox gbComplemento;
    private Label lblMonto;
    private TextBox txtMonto;
    private Label lblTipoCambioP;
    private TextBox txtTipoCambioP;
    private Label lblMonedaP;
    private TextBox txtMonedaP;
    private GroupBox gbEmisor;
    private GroupBox gbReceptor;
    private GroupBox gbComprobante;
    private Label lblSerie;
    private TextBox txtSerie;
    private Label lblNoOperacion;
    private TextBox txtFolio;
    private DateTimePicker dtpFecha;
    private Label lblFecha;
    private ComboBox cbFormaPago;
    private Label lblFormaPago;
    private GroupBox gbDocumentosRelacionados;
    private DataGridView gvDocumentosRelacionados;
    private ComboBox cbPagos;
    private Label lblPagos;
    private Button btnAgregarPago;
    private Button btnAgregarDocumentoRelacionado;
    private DataGridViewTextBoxColumn IdDocumento;
    private DataGridViewTextBoxColumn Serie;
    private DataGridViewTextBoxColumn Folio;
    private DataGridViewTextBoxColumn MetodoDePagoDR;
    private DataGridViewTextBoxColumn MonedaDR;
    private DataGridViewTextBoxColumn TipoCambioDR;
    private DataGridViewTextBoxColumn NumParcialidad;
    private DataGridViewTextBoxColumn ImpSaldoAnt;
    private DataGridViewTextBoxColumn ImpPagado;
    private DataGridViewTextBoxColumn ImpSaldoInsoluto;
    private Button btnImportarDR;
    private Button btnEliminarDR;
    private Label lblNombreReceptor;
    private TextBox txtNombreReceptor;
    private Label lblRfcReceptor;
    private TextBox txtRfcReceptor;
    private Label lblNombreEmisor;
    private TextBox txtNombreEmisor;
    private Label lblRfcEmisor;
    private TextBox txtRfcEmisor;
    private DateTimePicker dtpFechaPago;
    private Label lblFechaPago;
    private CheckBox cbModoPrueba;
    private Button btnExcel;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem cancelaciónCFDIToolStripMenuItem;
    private Label label1;
    private TextBox txtNumOperacion;

    public List<PagosPago> pagos { get; set; }

    public Dictionary<string, string> formas_pago { get; set; }

    public Asistente()
    {
      this.InitializeComponent();
      this.CargarFormasPago();
      this.gvDocumentosRelacionados.AutoGenerateColumns = false;
      this.Inicializar();
    }

    private void Inicializar()
    {
      Empresa empresa = new Empresa();
      this.txtRfcEmisor.Text = empresa.rfc;
      this.txtNombreEmisor.Text = empresa.nombre;
      this.pagos = new List<PagosPago>();
      this.cbPagos.Items.Clear();
      this.AgregarPago();
    }

    private void CargarFormasPago()
    {
      try
      {
        this.formas_pago = new Dictionary<string, string>()
        {
          {
            "01",
            "01 - Efectivo"
          },
          {
            "02",
            "02 - Cheque nominativo"
          },
          {
            "03",
            "03 - Transferencia electrónica de fondos"
          },
          {
            "04",
            "04 - Tarjeta de crédito"
          },
          {
            "05",
            "05 - Monedero electrónico"
          },
          {
            "06",
            "06 - Dinero electrónico"
          },
          {
            "08",
            "08 - Vales de despensa"
          },
          {
            "12",
            "12 - Dación en pago"
          },
          {
            "13",
            "13 - Pago por subrogación"
          },
          {
            "14",
            "14 - Pago por consignación"
          },
          {
            "15",
            "15 - Condonación"
          },
          {
            "17",
            "17 - Compensación"
          },
          {
            "23",
            "23 - Novación"
          },
          {
            "24",
            "24 - Confusión"
          },
          {
            "25",
            "25 - Remisión de deuda"
          },
          {
            "26",
            "26 - Prescripción o caducidad"
          },
          {
            "27",
            "27 - A satisfacción del acreedor"
          },
          {
            "28",
            "28 - Tarjeta de débito"
          },
          {
            "29",
            "29 - Tarjeta de servicios"
          },
          {
            "30",
            "30 - Aplicación de anticipos"
          },
          {
            "31",
            "31 - Intermediario pagos"
          },
          {
            "99",
            "99 - Por definir"
          }
        };
        this.cbFormaPago.DataSource = (object) new BindingSource((object) this.formas_pago, (string) null);
        this.cbFormaPago.ValueMember = "Key";
        this.cbFormaPago.DisplayMember = "Value";
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void AgregarPago()
    {
      try
      {
        this.pagos.Add(new PagosPago());
        this.cbPagos.Items.Add((object) string.Format("Pago {0}", (object) (this.cbPagos.Items.Count + 1)));
        this.cbPagos.SelectedIndex = this.pagos.Count - 1;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void CargarPago(int index = 0)
    {
      try
      {
        this.cargando = true;
        if (index == -1)
          return;
        PagosPago pago = this.pagos[index];
        Decimal num;
        if (!pago.Monto.IsNullOrEmpty())
        {
          TextBox txtMonto = this.txtMonto;
          num = pago.Monto;
          string str = num.ToString();
          txtMonto.Text = str;
        }
        if (!pago.MonedaP.IsNullOrEmpty())
          this.txtMonedaP.Text = pago.MonedaP;
        if (pago.TipoCambioPSpecified)
        {
          TextBox txtTipoCambioP = this.txtTipoCambioP;
          num = pago.TipoCambioP;
          string str = num.ToString();
          txtTipoCambioP.Text = str;
        }
        else
          this.txtTipoCambioP.Text = "1.00";
        if (!pago.FormaDePagoP.IsNullOrEmpty())
          this.cbFormaPago.SelectedValue = (object) pago.FormaDePagoP;
        if (!pago.FechaPago.IsNullOrEmpty())
          this.dtpFechaPago.Value = DateTime.ParseExact(pago.FechaPago, "yyyy-MM-ddTHH:mm:ss", (IFormatProvider) null);
        this.gvDocumentosRelacionados.DataSource = (object) null;
        this.gvDocumentosRelacionados.DataSource = (object) pago.DoctoRelacionado;
        ((CurrencyManager) this.gvDocumentosRelacionados.BindingContext[this.gvDocumentosRelacionados.DataSource])?.Refresh();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      finally
      {
        this.cargando = false;
      }
    }

    private void ActualizarPago(int index = 0)
    {
      try
      {
        if (index == -1 || this.cargando)
          return;
        PagosPago pago = this.pagos[index];
        PagosPago pagosPago = pago;
        DateTime date = this.dtpFechaPago.Value;
        date = date.Date;
        string str = date.ToString("yyyy-MM-ddTHH:mm:ss");
        pagosPago.FechaPago = str;
        pago.NumOperacion = this.txtNumOperacion.Text;
        pago.MonedaP = this.txtMonedaP.Text;
        if (pago.MonedaP != "MXN")
          pago.TipoCambioP = Convert.ToDecimal(this.txtTipoCambioP.Text);
        else
          pago.TipoCambioPSpecified = false;
        if (this.txtMonto.Text.Length > 0)
          pago.Monto = Convert.ToDecimal(this.txtMonto.Text);
        if (this.cbFormaPago.SelectedIndex != -1)
          pago.FormaDePagoP = (string) this.cbFormaPago.SelectedValue;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void btnGenerar_Click(object sender, EventArgs e)
    {
      try
      {
        this.GenerarCFDI(false);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void GenerarCFDI(bool vista_previa = true)
    {
      try
      {
        Comprobante comprobante1 = new Comprobante();
        Empresa empresa = new Empresa();
        comprobante1.Version = "3.3";
        comprobante1.Serie = this.txtSerie.Text;
        comprobante1.Folio = this.txtFolio.Text;
        Comprobante comprobante2 = comprobante1;
        DateTime date = this.dtpFecha.Value;
        date = date.Date;
        string str1 = date.ToString("yyyy-MM-ddTHH:mm:ss");
        comprobante2.Fecha = str1;
        comprobante1.Moneda = "XXX";
        comprobante1.TipoDeComprobante = "P";
        comprobante1.LugarExpedicion = empresa.cp;
        ComprobanteEmisor comprobanteEmisor = new ComprobanteEmisor()
        {
          Rfc = empresa.rfc,
          Nombre = empresa.nombre,
          RegimenFiscal = empresa.regimen_fiscal
        };
        ComprobanteReceptor comprobanteReceptor = new ComprobanteReceptor()
        {
          Rfc = this.txtRfcReceptor.Text,
          Nombre = this.txtNombreReceptor.Text,
          UsoCFDI = "P01"
        };
        comprobante1.Emisor = comprobanteEmisor;
        comprobante1.Receptor = comprobanteReceptor;
        comprobante1.Conceptos = new List<ComprobanteConcepto>()
        {
          new ComprobanteConcepto()
          {
            Importe = 0M,
            ClaveProdServ = "84111506",
            Cantidad = 1M,
            ClaveUnidad = "ACT",
            Descripcion = "Pago",
            ValorUnitario = 0M
          }
        }.ToArray();
        comprobante1.SubTotal = 0M;
        comprobante1.Total = 0M;
        List<ComprobanteComplemento> comprobanteComplementoList = new List<ComprobanteComplemento>();
        ComprobanteComplemento comprobanteComplemento = new ComprobanteComplemento();
        Pagos complemento = new Pagos();
        complemento.Version = "1.0";
        foreach (PagosPago pago in this.pagos)
        {
          foreach (PagosPagoDoctoRelacionado doctoRelacionado in pago.DoctoRelacionado)
            doctoRelacionado.TipoCambioDRSpecified = !(doctoRelacionado.MonedaDR == "MXN");
        }
        complemento.Pago = this.pagos.ToArray();
        comprobanteComplemento.Any = new XmlElement[1]
        {
          CFDI.GenerarComplementoPago(complemento)
        };
        comprobanteComplementoList.Add(comprobanteComplemento);
        comprobante1.Complemento = comprobanteComplementoList.ToArray();
        CFDI cfdi = new CFDI()
        {
          comprobante = comprobante1
        };
        cfdi.Inicializar();
        string str2 = cfdi.Timbrar(vista_previa, this.cbModoPrueba.Checked);
        if (str2.IsNullOrEmpty())
          return;
        if (str2.Contains("Error"))
        {
          int num = (int) MessageBox.Show(str2);
        }
        else
          Process.Start(str2);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void btnAgregarPago_Click(object sender, EventArgs e) => this.AgregarPago();

    private void cbPagos_SelectedIndexChanged(object sender, EventArgs e) => this.CargarPago(this.cbPagos.SelectedIndex);

    private void btnAgregarDocumentoRelacionado_Click(object sender, EventArgs e)
    {
      this.pagos[this.cbPagos.SelectedIndex].DoctoRelacionado.Add(new PagosPagoDoctoRelacionado()
      {
        IdDocumento = "",
        MetodoDePagoDR = "PPD",
        MonedaDR = "MXN",
        NumParcialidad = "1",
        ImpSaldoAnt = 0M,
        ImpPagado = 0M,
        ImpSaldoInsoluto = 0M
      });
      this.CargarPago(this.cbPagos.SelectedIndex);
    }

    private void ActualizarPago_TextChanged(object sender, EventArgs e) => this.ActualizarPago(this.cbPagos.SelectedIndex);

    private void btnImportarDR_Click(object sender, EventArgs e)
    {
      try
      {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
          openFileDialog.Filter = "Archivos XML|*.xml";
          openFileDialog.Multiselect = true;
          if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;
          foreach (string fileName in openFileDialog.FileNames)
          {
            XNamespace xnamespace1 = (XNamespace) "http://www.sat.gob.mx/cfd/3";
            XNamespace xnamespace2 = (XNamespace) "http://www.sat.gob.mx/TimbreFiscalDigital";
            XDocument xdocument = XDocument.Load(fileName);
            XElement xelement1 = xdocument.Element(xnamespace1 + "Comprobante");
            XElement xelement2 = xdocument.Element(xnamespace1 + "Comprobante").Element(xnamespace1 + "Complemento").Element(xnamespace2 + "TimbreFiscalDigital");
            this.pagos[this.cbPagos.SelectedIndex].DoctoRelacionado.Add(new PagosPagoDoctoRelacionado()
            {
              IdDocumento = (string) xelement2.Attribute((XName) "UUID"),
              Serie = (string) xelement1.Attribute((XName) "Serie"),
              Folio = (string) xelement1.Attribute((XName) "Folio"),
              MetodoDePagoDR = (string) xelement1.Attribute((XName) "MetodoPago"),
              MonedaDR = (string) xelement1.Attribute((XName) "Moneda"),
              NumParcialidad = "1",
              ImpSaldoAnt = (Decimal) xelement1.Attribute((XName) "Total"),
              ImpPagado = (Decimal) xelement1.Attribute((XName) "Total"),
              ImpSaldoInsoluto = 0M
            });
          }
          this.CargarPago(this.cbPagos.SelectedIndex);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void btnEliminarDR_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.gvDocumentosRelacionados.SelectedRows.Count <= 0)
          return;
        foreach (DataGridViewBand selectedRow in (BaseCollection) this.gvDocumentosRelacionados.SelectedRows)
          this.pagos[this.cbPagos.SelectedIndex].DoctoRelacionado.RemoveAt(selectedRow.Index);
        this.CargarPago(this.cbPagos.SelectedIndex);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void btnRestablecer_Click(object sender, EventArgs e)
    {
      try
      {
        this.Inicializar();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void btnVistaPrevia_Click(object sender, EventArgs e)
    {
      try
      {
        this.GenerarCFDI();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void btnExcel_Click(object sender, EventArgs e)
    {
      try
      {
        string[] strArray = Clipboard.GetText().Replace("\n", "").Split('\r');
        int rowIndex = 0;
        int columnIndex = 0;
        foreach (string str1 in strArray)
        {
          char[] chArray = new char[1]{ '\t' };
          foreach (string str2 in str1.Split(chArray))
          {
            Console.WriteLine(str2);
            this.gvDocumentosRelacionados[columnIndex, rowIndex].Value = (object) str2;
            ++columnIndex;
          }
          ++rowIndex;
          columnIndex = 0;
        }
      }
      catch
      {
      }
    }

    private void cancelaciónCFDIToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
          openFileDialog.Filter = "Archivos XML|*.xml";
          openFileDialog.Multiselect = true;
          if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;
          foreach (string fileName in openFileDialog.FileNames)
          {
            XNamespace xnamespace1 = (XNamespace) "http://www.sat.gob.mx/cfd/3";
            XNamespace xnamespace2 = (XNamespace) "http://www.sat.gob.mx/TimbreFiscalDigital";
            XDocument xdocument = XDocument.Load(fileName);
            xdocument.Element(xnamespace1 + "Comprobante");
            XElement xelement1 = xdocument.Element(xnamespace1 + "Comprobante").Element(xnamespace1 + "Receptor");
            XElement xelement2 = xdocument.Element(xnamespace1 + "Comprobante").Element(xnamespace1 + "Complemento").Element(xnamespace2 + "TimbreFiscalDigital");
            if (MessageBox.Show(string.Format("¿Estas seguro que deseas cancelar el comprobante con UUID {0}", (object) (string) xelement2.Attribute((XName) "UUID")), "Cancelación CFDI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              CFDI cfdi = new CFDI();
              cfdi.Inicializar();
              int num = (int) MessageBox.Show(cfdi.Cancelar((string) xelement2.Attribute((XName) "UUID"), (string) xelement1.Attribute((XName) "Rfc"), 0.0));
            }
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Asistente));
      this.btnGenerar = new Button();
      this.btnVistaPrevia = new Button();
      this.btnRestablecer = new Button();
      this.gbComplemento = new GroupBox();
      this.btnExcel = new Button();
      this.cbModoPrueba = new CheckBox();
      this.dtpFechaPago = new DateTimePicker();
      this.lblFechaPago = new Label();
      this.btnAgregarPago = new Button();
      this.btnEliminarDR = new Button();
      this.lblPagos = new Label();
      this.btnImportarDR = new Button();
      this.cbPagos = new ComboBox();
      this.btnAgregarDocumentoRelacionado = new Button();
      this.gbDocumentosRelacionados = new GroupBox();
      this.gvDocumentosRelacionados = new DataGridView();
      this.IdDocumento = new DataGridViewTextBoxColumn();
      this.Serie = new DataGridViewTextBoxColumn();
      this.Folio = new DataGridViewTextBoxColumn();
      this.MetodoDePagoDR = new DataGridViewTextBoxColumn();
      this.MonedaDR = new DataGridViewTextBoxColumn();
      this.TipoCambioDR = new DataGridViewTextBoxColumn();
      this.NumParcialidad = new DataGridViewTextBoxColumn();
      this.ImpSaldoAnt = new DataGridViewTextBoxColumn();
      this.ImpPagado = new DataGridViewTextBoxColumn();
      this.ImpSaldoInsoluto = new DataGridViewTextBoxColumn();
      this.lblFormaPago = new Label();
      this.cbFormaPago = new ComboBox();
      this.lblMonedaP = new Label();
      this.txtMonedaP = new TextBox();
      this.lblTipoCambioP = new Label();
      this.txtTipoCambioP = new TextBox();
      this.lblMonto = new Label();
      this.txtMonto = new TextBox();
      this.gbEmisor = new GroupBox();
      this.lblNombreEmisor = new Label();
      this.txtNombreEmisor = new TextBox();
      this.lblRfcEmisor = new Label();
      this.txtRfcEmisor = new TextBox();
      this.gbReceptor = new GroupBox();
      this.lblNombreReceptor = new Label();
      this.txtNombreReceptor = new TextBox();
      this.lblRfcReceptor = new Label();
      this.txtRfcReceptor = new TextBox();
      this.gbComprobante = new GroupBox();
      this.dtpFecha = new DateTimePicker();
      this.lblFecha = new Label();
      this.lblNoOperacion = new Label();
      this.txtFolio = new TextBox();
      this.lblSerie = new Label();
      this.txtSerie = new TextBox();
      this.menuStrip1 = new MenuStrip();
      this.cancelaciónCFDIToolStripMenuItem = new ToolStripMenuItem();
      this.label1 = new Label();
      this.txtNumOperacion = new TextBox();
      this.gbComplemento.SuspendLayout();
      this.gbDocumentosRelacionados.SuspendLayout();
      ((ISupportInitialize) this.gvDocumentosRelacionados).BeginInit();
      this.gbEmisor.SuspendLayout();
      this.gbReceptor.SuspendLayout();
      this.gbComprobante.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.btnGenerar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnGenerar.Location = new Point(12, 539);
      this.btnGenerar.Margin = new Padding(3, 4, 3, 4);
      this.btnGenerar.Name = "btnGenerar";
      this.btnGenerar.Size = new Size(87, 30);
      this.btnGenerar.TabIndex = 0;
      this.btnGenerar.Text = "Generar";
      this.btnGenerar.UseVisualStyleBackColor = true;
      this.btnGenerar.Click += new EventHandler(this.btnGenerar_Click);
      this.btnVistaPrevia.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnVistaPrevia.FlatStyle = FlatStyle.System;
      this.btnVistaPrevia.Location = new Point(105, 539);
      this.btnVistaPrevia.Margin = new Padding(3, 4, 3, 4);
      this.btnVistaPrevia.Name = "btnVistaPrevia";
      this.btnVistaPrevia.Size = new Size(149, 30);
      this.btnVistaPrevia.TabIndex = 1;
      this.btnVistaPrevia.Text = "Vista previa";
      this.btnVistaPrevia.UseVisualStyleBackColor = true;
      this.btnVistaPrevia.Click += new EventHandler(this.btnVistaPrevia_Click);
      this.btnRestablecer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnRestablecer.Location = new Point(685, 539);
      this.btnRestablecer.Margin = new Padding(3, 4, 3, 4);
      this.btnRestablecer.Name = "btnRestablecer";
      this.btnRestablecer.Size = new Size(87, 30);
      this.btnRestablecer.TabIndex = 2;
      this.btnRestablecer.Text = "Restablecer";
      this.btnRestablecer.UseVisualStyleBackColor = true;
      this.btnRestablecer.Click += new EventHandler(this.btnRestablecer_Click);
      this.gbComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.gbComplemento.Controls.Add((Control) this.btnExcel);
      this.gbComplemento.Controls.Add((Control) this.cbModoPrueba);
      this.gbComplemento.Controls.Add((Control) this.dtpFechaPago);
      this.gbComplemento.Controls.Add((Control) this.lblFechaPago);
      this.gbComplemento.Controls.Add((Control) this.btnAgregarPago);
      this.gbComplemento.Controls.Add((Control) this.btnEliminarDR);
      this.gbComplemento.Controls.Add((Control) this.lblPagos);
      this.gbComplemento.Controls.Add((Control) this.btnImportarDR);
      this.gbComplemento.Controls.Add((Control) this.cbPagos);
      this.gbComplemento.Controls.Add((Control) this.btnAgregarDocumentoRelacionado);
      this.gbComplemento.Controls.Add((Control) this.gbDocumentosRelacionados);
      this.gbComplemento.Controls.Add((Control) this.lblFormaPago);
      this.gbComplemento.Controls.Add((Control) this.cbFormaPago);
      this.gbComplemento.Controls.Add((Control) this.lblMonedaP);
      this.gbComplemento.Controls.Add((Control) this.txtMonedaP);
      this.gbComplemento.Controls.Add((Control) this.lblTipoCambioP);
      this.gbComplemento.Controls.Add((Control) this.txtTipoCambioP);
      this.gbComplemento.Controls.Add((Control) this.lblMonto);
      this.gbComplemento.Controls.Add((Control) this.txtMonto);
      this.gbComplemento.Location = new Point(12, 169);
      this.gbComplemento.Name = "gbComplemento";
      this.gbComplemento.Size = new Size(760, 363);
      this.gbComplemento.TabIndex = 3;
      this.gbComplemento.TabStop = false;
      this.gbComplemento.Text = "Complemento";
      this.btnExcel.FlatAppearance.BorderColor = Color.Silver;
      this.btnExcel.Location = new Point(11, 286);
      this.btnExcel.Margin = new Padding(3, 4, 3, 4);
      this.btnExcel.Name = "btnExcel";
      this.btnExcel.Size = new Size(230, 30);
      this.btnExcel.TabIndex = 16;
      this.btnExcel.Text = "Pegar desde Excel";
      this.btnExcel.UseVisualStyleBackColor = true;
      this.btnExcel.Click += new EventHandler(this.btnExcel_Click);
      this.cbModoPrueba.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.cbModoPrueba.AutoSize = true;
      this.cbModoPrueba.Location = new Point(11, 336);
      this.cbModoPrueba.Name = "cbModoPrueba";
      this.cbModoPrueba.Size = new Size(109, 21);
      this.cbModoPrueba.TabIndex = 15;
      this.cbModoPrueba.Text = "Modo prueba";
      this.cbModoPrueba.UseVisualStyleBackColor = true;
      this.dtpFechaPago.CustomFormat = "yyyy-MM-ddTHH:mm:ss";
      this.dtpFechaPago.Format = DateTimePickerFormat.Custom;
      this.dtpFechaPago.Location = new Point(93, 89);
      this.dtpFechaPago.Name = "dtpFechaPago";
      this.dtpFechaPago.Size = new Size(149, 25);
      this.dtpFechaPago.TabIndex = 14;
      this.dtpFechaPago.ValueChanged += new EventHandler(this.ActualizarPago_TextChanged);
      this.lblFechaPago.AutoSize = true;
      this.lblFechaPago.Location = new Point(8, 95);
      this.lblFechaPago.Name = "lblFechaPago";
      this.lblFechaPago.Size = new Size(76, 17);
      this.lblFechaPago.TabIndex = 13;
      this.lblFechaPago.Text = "Fecha pago";
      this.btnAgregarPago.FlatAppearance.BorderColor = Color.Silver;
      this.btnAgregarPago.FlatStyle = FlatStyle.System;
      this.btnAgregarPago.Location = new Point(10, 53);
      this.btnAgregarPago.Name = "btnAgregarPago";
      this.btnAgregarPago.Size = new Size(232, 30);
      this.btnAgregarPago.TabIndex = 9;
      this.btnAgregarPago.Text = "Agregar";
      this.btnAgregarPago.UseVisualStyleBackColor = true;
      this.btnAgregarPago.Click += new EventHandler(this.btnAgregarPago_Click);
      this.btnEliminarDR.FlatAppearance.BorderColor = Color.Silver;
      this.btnEliminarDR.Location = new Point(10, 249);
      this.btnEliminarDR.Name = "btnEliminarDR";
      this.btnEliminarDR.Size = new Size(232, 30);
      this.btnEliminarDR.TabIndex = 12;
      this.btnEliminarDR.Text = "Eliminar DR";
      this.btnEliminarDR.UseVisualStyleBackColor = true;
      this.btnEliminarDR.Click += new EventHandler(this.btnEliminarDR_Click);
      this.lblPagos.AutoSize = true;
      this.lblPagos.Location = new Point(7, 24);
      this.lblPagos.Name = "lblPagos";
      this.lblPagos.Size = new Size(44, 17);
      this.lblPagos.TabIndex = 8;
      this.lblPagos.Text = "Pagos";
      this.btnImportarDR.FlatAppearance.BorderColor = Color.Silver;
      this.btnImportarDR.Location = new Point(171, 213);
      this.btnImportarDR.Name = "btnImportarDR";
      this.btnImportarDR.Size = new Size(71, 30);
      this.btnImportarDR.TabIndex = 11;
      this.btnImportarDR.Text = "Importar";
      this.btnImportarDR.UseVisualStyleBackColor = true;
      this.btnImportarDR.Click += new EventHandler(this.btnImportarDR_Click);
      this.cbPagos.FormattingEnabled = true;
      this.cbPagos.Location = new Point(92, 22);
      this.cbPagos.Name = "cbPagos";
      this.cbPagos.Size = new Size(150, 25);
      this.cbPagos.TabIndex = 6;
      this.cbPagos.SelectedIndexChanged += new EventHandler(this.cbPagos_SelectedIndexChanged);
      this.btnAgregarDocumentoRelacionado.Location = new Point(10, 213);
      this.btnAgregarDocumentoRelacionado.Name = "btnAgregarDocumentoRelacionado";
      this.btnAgregarDocumentoRelacionado.Size = new Size(108, 30);
      this.btnAgregarDocumentoRelacionado.TabIndex = 10;
      this.btnAgregarDocumentoRelacionado.Text = "Agregar DR";
      this.btnAgregarDocumentoRelacionado.UseVisualStyleBackColor = true;
      this.btnAgregarDocumentoRelacionado.Click += new EventHandler(this.btnAgregarDocumentoRelacionado_Click);
      this.gbDocumentosRelacionados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.gbDocumentosRelacionados.Controls.Add((Control) this.gvDocumentosRelacionados);
      this.gbDocumentosRelacionados.Location = new Point(248, 22);
      this.gbDocumentosRelacionados.Name = "gbDocumentosRelacionados";
      this.gbDocumentosRelacionados.Size = new Size(506, 335);
      this.gbDocumentosRelacionados.TabIndex = 9;
      this.gbDocumentosRelacionados.TabStop = false;
      this.gbDocumentosRelacionados.Text = "Documentos relacionados";
      this.gvDocumentosRelacionados.BackgroundColor = Color.WhiteSmoke;
      this.gvDocumentosRelacionados.BorderStyle = BorderStyle.None;
      this.gvDocumentosRelacionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvDocumentosRelacionados.Columns.AddRange((DataGridViewColumn) this.IdDocumento, (DataGridViewColumn) this.Serie, (DataGridViewColumn) this.Folio, (DataGridViewColumn) this.MetodoDePagoDR, (DataGridViewColumn) this.MonedaDR, (DataGridViewColumn) this.TipoCambioDR, (DataGridViewColumn) this.NumParcialidad, (DataGridViewColumn) this.ImpSaldoAnt, (DataGridViewColumn) this.ImpPagado, (DataGridViewColumn) this.ImpSaldoInsoluto);
      this.gvDocumentosRelacionados.Dock = DockStyle.Fill;
      this.gvDocumentosRelacionados.Location = new Point(3, 21);
      this.gvDocumentosRelacionados.Name = "gvDocumentosRelacionados";
      this.gvDocumentosRelacionados.Size = new Size(500, 311);
      this.gvDocumentosRelacionados.TabIndex = 8;
      this.IdDocumento.DataPropertyName = "IdDocumento";
      this.IdDocumento.HeaderText = "UUID";
      this.IdDocumento.Name = "IdDocumento";
      this.Serie.DataPropertyName = "Serie";
      this.Serie.HeaderText = "Serie";
      this.Serie.Name = "Serie";
      this.Folio.DataPropertyName = "Folio";
      this.Folio.HeaderText = "Folio";
      this.Folio.Name = "Folio";
      this.MetodoDePagoDR.DataPropertyName = "MetodoDePagoDR";
      this.MetodoDePagoDR.HeaderText = "Método pago";
      this.MetodoDePagoDR.Name = "MetodoDePagoDR";
      this.MonedaDR.DataPropertyName = "MonedaDR";
      this.MonedaDR.HeaderText = "Moneda";
      this.MonedaDR.Name = "MonedaDR";
      this.TipoCambioDR.DataPropertyName = "TipoCambioDR";
      this.TipoCambioDR.HeaderText = "T.C.";
      this.TipoCambioDR.Name = "TipoCambioDR";
      this.NumParcialidad.DataPropertyName = "NumParcialidad";
      this.NumParcialidad.HeaderText = "Parcialidad";
      this.NumParcialidad.Name = "NumParcialidad";
      this.ImpSaldoAnt.DataPropertyName = "ImpSaldoAnt";
      this.ImpSaldoAnt.HeaderText = "Saldo anterior";
      this.ImpSaldoAnt.Name = "ImpSaldoAnt";
      this.ImpSaldoAnt.Resizable = DataGridViewTriState.True;
      this.ImpPagado.DataPropertyName = "ImpPagado";
      this.ImpPagado.HeaderText = "Importe";
      this.ImpPagado.Name = "ImpPagado";
      this.ImpSaldoInsoluto.DataPropertyName = "ImpSaldoInsoluto";
      this.ImpSaldoInsoluto.HeaderText = "Saldo insoluto";
      this.ImpSaldoInsoluto.Name = "ImpSaldoInsoluto";
      this.lblFormaPago.AutoSize = true;
      this.lblFormaPago.Location = new Point(7, 123);
      this.lblFormaPago.Name = "lblFormaPago";
      this.lblFormaPago.Size = new Size(80, 17);
      this.lblFormaPago.TabIndex = 7;
      this.lblFormaPago.Text = "Forma pago";
      this.cbFormaPago.FormattingEnabled = true;
      this.cbFormaPago.Location = new Point(92, 120);
      this.cbFormaPago.Name = "cbFormaPago";
      this.cbFormaPago.Size = new Size(150, 25);
      this.cbFormaPago.TabIndex = 6;
      this.cbFormaPago.SelectedIndexChanged += new EventHandler(this.ActualizarPago_TextChanged);
      this.lblMonedaP.AutoSize = true;
      this.lblMonedaP.Location = new Point(7, 154);
      this.lblMonedaP.Name = "lblMonedaP";
      this.lblMonedaP.Size = new Size(57, 17);
      this.lblMonedaP.TabIndex = 5;
      this.lblMonedaP.Text = "Moneda";
      this.txtMonedaP.Location = new Point(92, 151);
      this.txtMonedaP.Name = "txtMonedaP";
      this.txtMonedaP.Size = new Size(42, 25);
      this.txtMonedaP.TabIndex = 4;
      this.txtMonedaP.Text = "MXN";
      this.txtMonedaP.TextChanged += new EventHandler(this.ActualizarPago_TextChanged);
      this.lblTipoCambioP.AutoSize = true;
      this.lblTipoCambioP.Location = new Point(151, 154);
      this.lblTipoCambioP.Name = "lblTipoCambioP";
      this.lblTipoCambioP.Size = new Size(29, 17);
      this.lblTipoCambioP.TabIndex = 3;
      this.lblTipoCambioP.Text = "T.C.";
      this.txtTipoCambioP.Location = new Point(196, 151);
      this.txtTipoCambioP.Name = "txtTipoCambioP";
      this.txtTipoCambioP.Size = new Size(46, 25);
      this.txtTipoCambioP.TabIndex = 2;
      this.txtTipoCambioP.Text = "1.00";
      this.txtTipoCambioP.TextChanged += new EventHandler(this.ActualizarPago_TextChanged);
      this.lblMonto.AutoSize = true;
      this.lblMonto.Location = new Point(8, 185);
      this.lblMonto.Name = "lblMonto";
      this.lblMonto.Size = new Size(47, 17);
      this.lblMonto.TabIndex = 1;
      this.lblMonto.Text = "Monto";
      this.txtMonto.Location = new Point(92, 182);
      this.txtMonto.Name = "txtMonto";
      this.txtMonto.Size = new Size(150, 25);
      this.txtMonto.TabIndex = 0;
      this.txtMonto.Text = "0.00";
      this.txtMonto.TextChanged += new EventHandler(this.ActualizarPago_TextChanged);
      this.gbEmisor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.gbEmisor.Controls.Add((Control) this.lblNombreEmisor);
      this.gbEmisor.Controls.Add((Control) this.txtNombreEmisor);
      this.gbEmisor.Controls.Add((Control) this.lblRfcEmisor);
      this.gbEmisor.Controls.Add((Control) this.txtRfcEmisor);
      this.gbEmisor.Location = new Point(271, 45);
      this.gbEmisor.Name = "gbEmisor";
      this.gbEmisor.Size = new Size(501, 62);
      this.gbEmisor.TabIndex = 4;
      this.gbEmisor.TabStop = false;
      this.gbEmisor.Text = "Emisor";
      this.lblNombreEmisor.AutoSize = true;
      this.lblNombreEmisor.Location = new Point(159, 29);
      this.lblNombreEmisor.Name = "lblNombreEmisor";
      this.lblNombreEmisor.Size = new Size(57, 17);
      this.lblNombreEmisor.TabIndex = 17;
      this.lblNombreEmisor.Text = "Nombre";
      this.txtNombreEmisor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtNombreEmisor.Enabled = false;
      this.txtNombreEmisor.Location = new Point(222, 25);
      this.txtNombreEmisor.Name = "txtNombreEmisor";
      this.txtNombreEmisor.Size = new Size(270, 25);
      this.txtNombreEmisor.TabIndex = 16;
      this.lblRfcEmisor.AutoSize = true;
      this.lblRfcEmisor.Location = new Point(6, 28);
      this.lblRfcEmisor.Name = "lblRfcEmisor";
      this.lblRfcEmisor.Size = new Size(30, 17);
      this.lblRfcEmisor.TabIndex = 15;
      this.lblRfcEmisor.Text = "RFC";
      this.txtRfcEmisor.Enabled = false;
      this.txtRfcEmisor.Location = new Point(42, 25);
      this.txtRfcEmisor.MaxLength = 13;
      this.txtRfcEmisor.Name = "txtRfcEmisor";
      this.txtRfcEmisor.Size = new Size(111, 25);
      this.txtRfcEmisor.TabIndex = 14;
      this.gbReceptor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.gbReceptor.Controls.Add((Control) this.lblNombreReceptor);
      this.gbReceptor.Controls.Add((Control) this.txtNombreReceptor);
      this.gbReceptor.Controls.Add((Control) this.lblRfcReceptor);
      this.gbReceptor.Controls.Add((Control) this.txtRfcReceptor);
      this.gbReceptor.Location = new Point(271, 108);
      this.gbReceptor.Name = "gbReceptor";
      this.gbReceptor.Size = new Size(501, 62);
      this.gbReceptor.TabIndex = 5;
      this.gbReceptor.TabStop = false;
      this.gbReceptor.Text = "Receptor";
      this.lblNombreReceptor.AutoSize = true;
      this.lblNombreReceptor.Location = new Point(159, 29);
      this.lblNombreReceptor.Name = "lblNombreReceptor";
      this.lblNombreReceptor.Size = new Size(57, 17);
      this.lblNombreReceptor.TabIndex = 13;
      this.lblNombreReceptor.Text = "Nombre";
      this.txtNombreReceptor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtNombreReceptor.Location = new Point(222, 25);
      this.txtNombreReceptor.Name = "txtNombreReceptor";
      this.txtNombreReceptor.Size = new Size(270, 25);
      this.txtNombreReceptor.TabIndex = 12;
      this.txtNombreReceptor.Text = "PÚBLICO EN GENERAL";
      this.lblRfcReceptor.AutoSize = true;
      this.lblRfcReceptor.Location = new Point(6, 28);
      this.lblRfcReceptor.Name = "lblRfcReceptor";
      this.lblRfcReceptor.Size = new Size(30, 17);
      this.lblRfcReceptor.TabIndex = 11;
      this.lblRfcReceptor.Text = "RFC";
      this.txtRfcReceptor.Location = new Point(42, 25);
      this.txtRfcReceptor.MaxLength = 13;
      this.txtRfcReceptor.Name = "txtRfcReceptor";
      this.txtRfcReceptor.Size = new Size(111, 25);
      this.txtRfcReceptor.TabIndex = 10;
      this.txtRfcReceptor.Text = "XAXX010101000";
      this.gbComprobante.Controls.Add((Control) this.txtNumOperacion);
      this.gbComprobante.Controls.Add((Control) this.dtpFecha);
      this.gbComprobante.Controls.Add((Control) this.lblFecha);
      this.gbComprobante.Controls.Add((Control) this.lblNoOperacion);
      this.gbComprobante.Controls.Add((Control) this.txtFolio);
      this.gbComprobante.Controls.Add((Control) this.lblSerie);
      this.gbComprobante.Controls.Add((Control) this.txtSerie);
      this.gbComprobante.Location = new Point(12, 45);
      this.gbComprobante.Name = "gbComprobante";
      this.gbComprobante.Size = new Size(253, 125);
      this.gbComprobante.TabIndex = 5;
      this.gbComprobante.TabStop = false;
      this.gbComprobante.Text = "Comprobante";
      this.dtpFecha.CustomFormat = "yyyy-MM-ddTHH:mm:ss";
      this.dtpFecha.Format = DateTimePickerFormat.Custom;
      this.dtpFecha.Location = new Point(92, 83);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new Size(149, 25);
      this.dtpFecha.TabIndex = 12;
      this.lblFecha.AutoSize = true;
      this.lblFecha.Location = new Point(7, 89);
      this.lblFecha.Name = "lblFecha";
      this.lblFecha.Size = new Size(41, 17);
      this.lblFecha.TabIndex = 11;
      this.lblFecha.Text = "Fecha";
      this.lblNoOperacion.AutoSize = true;
      this.lblNoOperacion.Location = new Point(7, 55);
      this.lblNoOperacion.Name = "lblNoOperacion";
      this.lblNoOperacion.Size = new Size(88, 17);
      this.lblNoOperacion.TabIndex = 9;
      this.lblNoOperacion.Text = "N° Operación";
      this.txtFolio.Location = new Point(140, 21);
      this.txtFolio.Name = "txtFolio";
      this.txtFolio.Size = new Size(101, 25);
      this.txtFolio.TabIndex = 8;
      this.txtFolio.Text = "00001";
      this.lblSerie.AutoSize = true;
      this.lblSerie.Location = new Point(7, 24);
      this.lblSerie.Name = "lblSerie";
      this.lblSerie.Size = new Size(37, 17);
      this.lblSerie.TabIndex = 7;
      this.lblSerie.Text = "Serie";
      this.txtSerie.Location = new Point(92, 21);
      this.txtSerie.Name = "txtSerie";
      this.txtSerie.Size = new Size(42, 25);
      this.txtSerie.TabIndex = 6;
      this.txtSerie.Text = "P";
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.cancelaciónCFDIToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(784, 24);
      this.menuStrip1.TabIndex = 6;
      this.menuStrip1.Text = "menuStrip1";
      this.cancelaciónCFDIToolStripMenuItem.Name = "cancelaciónCFDIToolStripMenuItem";
      this.cancelaciónCFDIToolStripMenuItem.Size = new Size(112, 20);
      this.cancelaciónCFDIToolStripMenuItem.Text = "Cancelación CFDI";
      this.cancelaciónCFDIToolStripMenuItem.Click += new EventHandler(this.cancelaciónCFDIToolStripMenuItem_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.DimGray;
      this.label1.Location = new Point(12, 22);
      this.label1.Name = "label1";
      this.label1.Size = new Size(329, 21);
      this.label1.TabIndex = 7;
      this.label1.Text = "Asistente de creación de complemento de pago";
      this.txtNumOperacion.Location = new Point(92, 52);
      this.txtNumOperacion.Name = "txtNumOperacion";
      this.txtNumOperacion.Size = new Size(149, 25);
      this.txtNumOperacion.TabIndex = 13;
      this.txtNumOperacion.TextChanged += new EventHandler(this.ActualizarPago_TextChanged);
      this.AutoScaleDimensions = new SizeF(7f, 17f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.WhiteSmoke;
      this.ClientSize = new Size(784, 580);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.gbEmisor);
      this.Controls.Add((Control) this.gbComprobante);
      this.Controls.Add((Control) this.gbReceptor);
      this.Controls.Add((Control) this.gbComplemento);
      this.Controls.Add((Control) this.btnRestablecer);
      this.Controls.Add((Control) this.btnVistaPrevia);
      this.Controls.Add((Control) this.btnGenerar);
      this.Controls.Add((Control) this.menuStrip1);
      this.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (Asistente);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Asistente Complemento Pago";
      this.gbComplemento.ResumeLayout(false);
      this.gbComplemento.PerformLayout();
      this.gbDocumentosRelacionados.ResumeLayout(false);
      ((ISupportInitialize) this.gvDocumentosRelacionados).EndInit();
      this.gbEmisor.ResumeLayout(false);
      this.gbEmisor.PerformLayout();
      this.gbReceptor.ResumeLayout(false);
      this.gbReceptor.PerformLayout();
      this.gbComprobante.ResumeLayout(false);
      this.gbComprobante.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
