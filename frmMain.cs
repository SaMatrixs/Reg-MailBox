// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.frmMain
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [DesignerGenerated]
  public class frmMain : Form
  {
    private IContainer components;
    [AccessedThroughProperty("btmStart")]
    private Button _btmStart;
    [AccessedThroughProperty("picVOTE_CAPTCHA_0")]
    private PictureBox _picVOTE_CAPTCHA_0;
    [AccessedThroughProperty("cmbThread")]
    private ComboBox _cmbThread;
    [AccessedThroughProperty("tmrConnect")]
    private System.Windows.Forms.Timer _tmrConnect;
    [AccessedThroughProperty("LV")]
    private ListView _LV;
    [AccessedThroughProperty("ColumnHeader1")]
    private ColumnHeader _ColumnHeader1;
    [AccessedThroughProperty("ColumnHeader2")]
    private ColumnHeader _ColumnHeader2;
    [AccessedThroughProperty("ColumnHeader3")]
    private ColumnHeader _ColumnHeader3;
    [AccessedThroughProperty("ColumnHeader4")]
    private ColumnHeader _ColumnHeader4;
    [AccessedThroughProperty("ColumnHeader5")]
    private ColumnHeader _ColumnHeader5;
    [AccessedThroughProperty("ColumnHeader6")]
    private ColumnHeader _ColumnHeader6;
    [AccessedThroughProperty("IL_LV")]
    private ImageList _IL_LV;
    [AccessedThroughProperty("LV_Dostupno")]
    private ListView _LV_Dostupno;
    [AccessedThroughProperty("ColumnHeader16")]
    private ColumnHeader _ColumnHeader16;
    [AccessedThroughProperty("ColumnHeader22")]
    private ColumnHeader _ColumnHeader22;
    [AccessedThroughProperty("txtCaptcha")]
    private TextBox _txtCaptcha;
    [AccessedThroughProperty("txtCurrentMail")]
    private TextBox _txtCurrentMail;
    [AccessedThroughProperty("picCollection0")]
    private PictureBox _picCollection0;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("btmGlobalOptions")]
    private Button _btmGlobalOptions;
    [AccessedThroughProperty("btmGenMailOptions")]
    private Button _btmGenMailOptions;
    [AccessedThroughProperty("chAutoCaptcha")]
    private CheckBox _chAutoCaptcha;
    [AccessedThroughProperty("chProxy")]
    private CheckBox _chProxy;
    [AccessedThroughProperty("lblProxy")]
    private Label _lblProxy;
    [AccessedThroughProperty("btmLoadMail")]
    private Button _btmLoadMail;
    [AccessedThroughProperty("chAllMail")]
    private CheckBox _chAllMail;
    [AccessedThroughProperty("lblMailCountCur")]
    private Label _lblMailCountCur;
    [AccessedThroughProperty("lblMailCountAll")]
    private Label _lblMailCountAll;
    [AccessedThroughProperty("ColumnHeader7")]
    private ColumnHeader _ColumnHeader7;
    [AccessedThroughProperty("grAccountEdit")]
    private GroupBox _grAccountEdit;
    [AccessedThroughProperty("gbAccSell_1")]
    private GroupBox _gbAccSell_1;
    [AccessedThroughProperty("lblAccSelNUM")]
    private Label _lblAccSelNUM;
    [AccessedThroughProperty("txtAccSel_Login")]
    private TextBox _txtAccSel_Login;
    [AccessedThroughProperty("gbAccSell_2")]
    private GroupBox _gbAccSell_2;
    [AccessedThroughProperty("txtAccSel_Password")]
    private TextBox _txtAccSel_Password;
    [AccessedThroughProperty("gbAccSell_4")]
    private GroupBox _gbAccSell_4;
    [AccessedThroughProperty("txtAccSel_SecretAnswer")]
    private TextBox _txtAccSel_SecretAnswer;
    [AccessedThroughProperty("btmSaveList")]
    private Button _btmSaveList;
    [AccessedThroughProperty("btmAccSel_Save")]
    private Button _btmAccSel_Save;
    [AccessedThroughProperty("btmAccSel_Del")]
    private Button _btmAccSel_Del;
    [AccessedThroughProperty("IL")]
    private ImageList _IL;
    [AccessedThroughProperty("chAutoUpdate")]
    private CheckBox _chAutoUpdate;
    [AccessedThroughProperty("txtMon")]
    private TextBox _txtMon;
    [AccessedThroughProperty("btmAbout")]
    private Button _btmAbout;
    [AccessedThroughProperty("lblActionInSelect")]
    private Label _lblActionInSelect;
    [AccessedThroughProperty("StatusBar")]
    private StatusStrip _StatusBar;
    [AccessedThroughProperty("stlbl_1")]
    private ToolStripStatusLabel _stlbl_1;
    [AccessedThroughProperty("stlbl_2")]
    private ToolStripStatusLabel _stlbl_2;
    [AccessedThroughProperty("stlbl_3")]
    private ToolStripStatusLabel _stlbl_3;
    [AccessedThroughProperty("stlbl_4")]
    private ToolStripStatusLabel _stlbl_4;
    [AccessedThroughProperty("cmbReg")]
    private ComboBox _cmbReg;
    [AccessedThroughProperty("ColumnHeader8")]
    private ColumnHeader _ColumnHeader8;
    [AccessedThroughProperty("gbAccSell_5")]
    private GroupBox _gbAccSell_5;
    [AccessedThroughProperty("txtAccSel_Comment")]
    private TextBox _txtAccSel_Comment;
    [AccessedThroughProperty("gbAccSell_3")]
    private GroupBox _gbAccSell_3;
    [AccessedThroughProperty("txtAccSel_SecretQuestion")]
    private TextBox _txtAccSel_SecretQuestion;
    [AccessedThroughProperty("ToolTip1")]
    private ToolTip _ToolTip1;
    [AccessedThroughProperty("tmrHelp")]
    private System.Windows.Forms.Timer _tmrHelp;
    [AccessedThroughProperty("rbAccSel_J")]
    private RadioButton _rbAccSel_J;
    [AccessedThroughProperty("rbAccSel_M")]
    private RadioButton _rbAccSel_M;
    [AccessedThroughProperty("gbAccSell_6")]
    private GroupBox _gbAccSell_6;
    [AccessedThroughProperty("txtAccSel_Town")]
    private TextBox _txtAccSel_Town;
    [AccessedThroughProperty("picLine_2")]
    private PictureBox _picLine_2;
    [AccessedThroughProperty("picLine_3")]
    private PictureBox _picLine_3;
    [AccessedThroughProperty("tmrUpdate")]
    private System.Windows.Forms.Timer _tmrUpdate;
    [AccessedThroughProperty("picAutoCaptchaEnable")]
    private PictureBox _picAutoCaptchaEnable;
    [AccessedThroughProperty("picBanner")]
    private PictureBox _picBanner;
    [AccessedThroughProperty("stlbl_CurProxy_1")]
    private ToolStripStatusLabel _stlbl_CurProxy_1;
    [AccessedThroughProperty("boxOptions")]
    private GroupBox _boxOptions;
    [AccessedThroughProperty("chReport_6")]
    private CheckBox _chReport_6;
    [AccessedThroughProperty("chReport_2")]
    private CheckBox _chReport_2;
    [AccessedThroughProperty("chReport_1")]
    private CheckBox _chReport_1;
    [AccessedThroughProperty("chReport_3")]
    private CheckBox _chReport_3;
    [AccessedThroughProperty("boxCounter")]
    private GroupBox _boxCounter;
    [AccessedThroughProperty("INFO_8")]
    private Label _INFO_8;
    [AccessedThroughProperty("INFO_9")]
    private Label _INFO_9;
    [AccessedThroughProperty("INFO_3")]
    private Label _INFO_3;
    [AccessedThroughProperty("INFO_4")]
    private Label _INFO_4;
    [AccessedThroughProperty("INFO_6")]
    private Label _INFO_6;
    [AccessedThroughProperty("INFO_5")]
    private Label _INFO_5;
    [AccessedThroughProperty("INFO_2")]
    private Label _INFO_2;
    [AccessedThroughProperty("INFO_1")]
    private Label _INFO_1;
    [AccessedThroughProperty("lbl8")]
    private Label _lbl8;
    [AccessedThroughProperty("lbl9")]
    private Label _lbl9;
    [AccessedThroughProperty("lbl5")]
    private Label _lbl5;
    [AccessedThroughProperty("lbl2")]
    private Label _lbl2;
    [AccessedThroughProperty("lbl3")]
    private Label _lbl3;
    [AccessedThroughProperty("lbl4")]
    private Label _lbl4;
    [AccessedThroughProperty("lbl6")]
    private Label _lbl6;
    [AccessedThroughProperty("lbl1")]
    private Label _lbl1;
    [AccessedThroughProperty("chReport_4")]
    private CheckBox _chReport_4;
    [AccessedThroughProperty("chReport_5")]
    private CheckBox _chReport_5;
    [AccessedThroughProperty("chReport_7")]
    private CheckBox _chReport_7;
    [AccessedThroughProperty("chReport_8")]
    private CheckBox _chReport_8;
    [AccessedThroughProperty("lblBUSY")]
    private Label _lblBUSY;
    [AccessedThroughProperty("SaveFileDialog1")]
    private SaveFileDialog _SaveFileDialog1;
    [AccessedThroughProperty("picVOTE_CAPTCHA_3")]
    private PictureBox _picVOTE_CAPTCHA_3;
    [AccessedThroughProperty("grCAPTCHA")]
    private GroupBox _grCAPTCHA;
    [AccessedThroughProperty("picCollection3")]
    private PictureBox _picCollection3;
    [AccessedThroughProperty("picRequestCaptcha")]
    private PictureBox _picRequestCaptcha;
    [AccessedThroughProperty("picVOTE_CAPTCHA_4")]
    private PictureBox _picVOTE_CAPTCHA_4;
    [AccessedThroughProperty("picCollection4")]
    private PictureBox _picCollection4;
    [AccessedThroughProperty("tmrLoadProgram")]
    private System.Windows.Forms.Timer _tmrLoadProgram;
    [AccessedThroughProperty("picWait")]
    private PictureBox _picWait;
    [AccessedThroughProperty("lbl11")]
    private Label _lbl11;
    [AccessedThroughProperty("INFO_11")]
    private Label _INFO_11;
    [AccessedThroughProperty("INFO_10")]
    private Label _INFO_10;
    [AccessedThroughProperty("lbl10")]
    private Label _lbl10;
    [AccessedThroughProperty("tmrInfo")]
    private System.Windows.Forms.Timer _tmrInfo;
    [AccessedThroughProperty("tmrMailDownload")]
    private System.Windows.Forms.Timer _tmrMailDownload;
    [AccessedThroughProperty("btnOpenMail")]
    private Button _btnOpenMail;
    [AccessedThroughProperty("INFO_7")]
    private Label _INFO_7;
    [AccessedThroughProperty("lbl7")]
    private Label _lbl7;
    [AccessedThroughProperty("btnOpenProxy")]
    private Button _btnOpenProxy;
    [AccessedThroughProperty("stlbl_CurProxy_2")]
    private ToolStripStatusLabel _stlbl_CurProxy_2;
    [AccessedThroughProperty("ToolStripStatusLabel1")]
    private ToolStripStatusLabel _ToolStripStatusLabel1;
    [AccessedThroughProperty("stlbl_Speed_1")]
    private ToolStripStatusLabel _stlbl_Speed_1;
    [AccessedThroughProperty("stlbl_Speed_2")]
    private ToolStripStatusLabel _stlbl_Speed_2;
    [AccessedThroughProperty("picNoSlot")]
    private PictureBox _picNoSlot;
    [AccessedThroughProperty("IL_16")]
    private ImageList _IL_16;
    [AccessedThroughProperty("tmrTXT")]
    private System.Windows.Forms.Timer _tmrTXT;
    [AccessedThroughProperty("INFO_13")]
    private Label _INFO_13;
    [AccessedThroughProperty("tmrNetworkReboot")]
    private System.Windows.Forms.Timer _tmrNetworkReboot;
    [AccessedThroughProperty("lbl13")]
    private Label _lbl13;
    [AccessedThroughProperty("btnSort")]
    private Button _btnSort;
    [AccessedThroughProperty("tmrVPNReboot")]
    private System.Windows.Forms.Timer _tmrVPNReboot;
    [AccessedThroughProperty("INFO_12")]
    private Label _INFO_12;
    [AccessedThroughProperty("lbl12")]
    private Label _lbl12;
    [AccessedThroughProperty("chCheckMail_WebFace")]
    private CheckBox _chCheckMail_WebFace;
    [AccessedThroughProperty("picCollection1")]
    private PictureBox _picCollection1;
    [AccessedThroughProperty("picVOTE_CAPTCHA_1")]
    private PictureBox _picVOTE_CAPTCHA_1;
    [AccessedThroughProperty("btnSort_Random")]
    private Button _btnSort_Random;
    [AccessedThroughProperty("btnSort_Turn")]
    private Button _btnSort_Turn;
    [AccessedThroughProperty("picVOTE_CAPTCHA_2")]
    private PictureBox _picVOTE_CAPTCHA_2;
    [AccessedThroughProperty("picCollection2")]
    private PictureBox _picCollection2;
    [AccessedThroughProperty("btnSaveLog")]
    private Button _btnSaveLog;
    [AccessedThroughProperty("Button6")]
    private Button _Button6;
    [AccessedThroughProperty("pbGenLogin")]
    private ProgressBar _pbGenLogin;
    [AccessedThroughProperty("btnSQL")]
    private Button _btnSQL;
    private BackgroundWorker[] BW_LoadMail;
    private StringBuilder[] txtBuffer_LoadMail;
    private POP3[] popConn;
    private bool[] LoadMail_FreeSocket;
    private bool DownloadAllMail;
    private int sTimerCNT;
    private System.Timers.Timer[] sTimer;
    private object sOB;
    [SpecialName]
    private short \u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep;
    [SpecialName]
    private StaticLocalInitFlag \u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep\u0024Init;

    public frmMain()
    {
      this.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);
      this.Load += new EventHandler(this.frmMain_Load);
      this.DownloadAllMail = false;
      this.sOB = RuntimeHelpers.GetObjectValue(new object());
      this.\u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep\u0024Init = new StaticLocalInitFlag();
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMain));
      this.btmStart = new Button();
      this.picVOTE_CAPTCHA_0 = new PictureBox();
      this.cmbThread = new ComboBox();
      this.tmrConnect = new System.Windows.Forms.Timer(this.components);
      this.LV = new ListView();
      this.ColumnHeader1 = new ColumnHeader();
      this.ColumnHeader2 = new ColumnHeader();
      this.ColumnHeader3 = new ColumnHeader();
      this.ColumnHeader4 = new ColumnHeader();
      this.ColumnHeader5 = new ColumnHeader();
      this.ColumnHeader6 = new ColumnHeader();
      this.ColumnHeader7 = new ColumnHeader();
      this.ColumnHeader8 = new ColumnHeader();
      this.IL_LV = new ImageList(this.components);
      this.LV_Dostupno = new ListView();
      this.ColumnHeader16 = new ColumnHeader();
      this.ColumnHeader22 = new ColumnHeader();
      this.txtCaptcha = new TextBox();
      this.txtCurrentMail = new TextBox();
      this.picCollection0 = new PictureBox();
      this.Label2 = new Label();
      this.btmGlobalOptions = new Button();
      this.btmGenMailOptions = new Button();
      this.chAutoCaptcha = new CheckBox();
      this.chProxy = new CheckBox();
      this.lblProxy = new Label();
      this.btmLoadMail = new Button();
      this.chAllMail = new CheckBox();
      this.lblMailCountCur = new Label();
      this.lblMailCountAll = new Label();
      this.grAccountEdit = new GroupBox();
      this.btnSort_Random = new Button();
      this.btnSort_Turn = new Button();
      this.btnSort = new Button();
      this.gbAccSell_5 = new GroupBox();
      this.txtAccSel_Comment = new TextBox();
      this.rbAccSel_J = new RadioButton();
      this.rbAccSel_M = new RadioButton();
      this.gbAccSell_3 = new GroupBox();
      this.txtAccSel_SecretQuestion = new TextBox();
      this.cmbReg = new ComboBox();
      this.btmAccSel_Del = new Button();
      this.btmAccSel_Save = new Button();
      this.gbAccSell_4 = new GroupBox();
      this.txtAccSel_SecretAnswer = new TextBox();
      this.gbAccSell_2 = new GroupBox();
      this.txtAccSel_Password = new TextBox();
      this.gbAccSell_1 = new GroupBox();
      this.txtAccSel_Login = new TextBox();
      this.lblAccSelNUM = new Label();
      this.gbAccSell_6 = new GroupBox();
      this.txtAccSel_Town = new TextBox();
      this.btmSaveList = new Button();
      this.IL = new ImageList(this.components);
      this.chAutoUpdate = new CheckBox();
      this.txtMon = new TextBox();
      this.btmAbout = new Button();
      this.lblActionInSelect = new Label();
      this.StatusBar = new StatusStrip();
      this.stlbl_1 = new ToolStripStatusLabel();
      this.stlbl_2 = new ToolStripStatusLabel();
      this.stlbl_3 = new ToolStripStatusLabel();
      this.stlbl_4 = new ToolStripStatusLabel();
      this.stlbl_CurProxy_1 = new ToolStripStatusLabel();
      this.stlbl_CurProxy_2 = new ToolStripStatusLabel();
      this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
      this.stlbl_Speed_1 = new ToolStripStatusLabel();
      this.stlbl_Speed_2 = new ToolStripStatusLabel();
      this.ToolTip1 = new ToolTip(this.components);
      this.tmrHelp = new System.Windows.Forms.Timer(this.components);
      this.picLine_2 = new PictureBox();
      this.picLine_3 = new PictureBox();
      this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
      this.picAutoCaptchaEnable = new PictureBox();
      this.picBanner = new PictureBox();
      this.boxOptions = new GroupBox();
      this.btnSQL = new Button();
      this.chReport_8 = new CheckBox();
      this.chReport_7 = new CheckBox();
      this.chReport_5 = new CheckBox();
      this.chReport_4 = new CheckBox();
      this.chReport_6 = new CheckBox();
      this.chReport_2 = new CheckBox();
      this.chReport_1 = new CheckBox();
      this.chReport_3 = new CheckBox();
      this.Button6 = new Button();
      this.boxCounter = new GroupBox();
      this.lbl12 = new Label();
      this.INFO_12 = new Label();
      this.INFO_13 = new Label();
      this.lbl13 = new Label();
      this.picNoSlot = new PictureBox();
      this.INFO_7 = new Label();
      this.lbl7 = new Label();
      this.INFO_3 = new Label();
      this.lbl3 = new Label();
      this.INFO_11 = new Label();
      this.INFO_10 = new Label();
      this.INFO_8 = new Label();
      this.INFO_9 = new Label();
      this.INFO_4 = new Label();
      this.INFO_6 = new Label();
      this.INFO_5 = new Label();
      this.INFO_2 = new Label();
      this.INFO_1 = new Label();
      this.lbl11 = new Label();
      this.lbl10 = new Label();
      this.lbl9 = new Label();
      this.lbl5 = new Label();
      this.lbl2 = new Label();
      this.lbl4 = new Label();
      this.lbl6 = new Label();
      this.lbl1 = new Label();
      this.lbl8 = new Label();
      this.lblBUSY = new Label();
      this.SaveFileDialog1 = new SaveFileDialog();
      this.picVOTE_CAPTCHA_3 = new PictureBox();
      this.grCAPTCHA = new GroupBox();
      this.picVOTE_CAPTCHA_1 = new PictureBox();
      this.picRequestCaptcha = new PictureBox();
      this.picVOTE_CAPTCHA_2 = new PictureBox();
      this.picVOTE_CAPTCHA_4 = new PictureBox();
      this.picCollection3 = new PictureBox();
      this.picCollection4 = new PictureBox();
      this.tmrLoadProgram = new System.Windows.Forms.Timer(this.components);
      this.picWait = new PictureBox();
      this.tmrInfo = new System.Windows.Forms.Timer(this.components);
      this.tmrMailDownload = new System.Windows.Forms.Timer(this.components);
      this.btnOpenMail = new Button();
      this.btnOpenProxy = new Button();
      this.IL_16 = new ImageList(this.components);
      this.tmrTXT = new System.Windows.Forms.Timer(this.components);
      this.tmrNetworkReboot = new System.Windows.Forms.Timer(this.components);
      this.tmrVPNReboot = new System.Windows.Forms.Timer(this.components);
      this.chCheckMail_WebFace = new CheckBox();
      this.picCollection1 = new PictureBox();
      this.picCollection2 = new PictureBox();
      this.btnSaveLog = new Button();
      this.pbGenLogin = new ProgressBar();
      ((ISupportInitialize) this.picVOTE_CAPTCHA_0).BeginInit();
      ((ISupportInitialize) this.picCollection0).BeginInit();
      this.grAccountEdit.SuspendLayout();
      this.gbAccSell_5.SuspendLayout();
      this.gbAccSell_3.SuspendLayout();
      this.gbAccSell_4.SuspendLayout();
      this.gbAccSell_2.SuspendLayout();
      this.gbAccSell_1.SuspendLayout();
      this.gbAccSell_6.SuspendLayout();
      this.StatusBar.SuspendLayout();
      ((ISupportInitialize) this.picLine_2).BeginInit();
      ((ISupportInitialize) this.picLine_3).BeginInit();
      ((ISupportInitialize) this.picAutoCaptchaEnable).BeginInit();
      ((ISupportInitialize) this.picBanner).BeginInit();
      this.boxOptions.SuspendLayout();
      this.boxCounter.SuspendLayout();
      ((ISupportInitialize) this.picNoSlot).BeginInit();
      ((ISupportInitialize) this.picVOTE_CAPTCHA_3).BeginInit();
      this.grCAPTCHA.SuspendLayout();
      ((ISupportInitialize) this.picVOTE_CAPTCHA_1).BeginInit();
      ((ISupportInitialize) this.picRequestCaptcha).BeginInit();
      ((ISupportInitialize) this.picVOTE_CAPTCHA_2).BeginInit();
      ((ISupportInitialize) this.picVOTE_CAPTCHA_4).BeginInit();
      ((ISupportInitialize) this.picCollection3).BeginInit();
      ((ISupportInitialize) this.picCollection4).BeginInit();
      ((ISupportInitialize) this.picWait).BeginInit();
      ((ISupportInitialize) this.picCollection1).BeginInit();
      ((ISupportInitialize) this.picCollection2).BeginInit();
      this.SuspendLayout();
      this.btmStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btmStart.BackColor = Color.Lime;
      this.btmStart.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btmStart.Image = (Image) componentResourceManager.GetObject("btmStart.Image");
      this.btmStart.ImageAlign = ContentAlignment.MiddleLeft;
      Button btmStart1 = this.btmStart;
      Point point1 = new Point(740, 3);
      Point point2 = point1;
      btmStart1.Location = point2;
      this.btmStart.Name = "btmStart";
      Button btmStart2 = this.btmStart;
      Size size1 = new Size(111, 48);
      Size size2 = size1;
      btmStart2.Size = size2;
      this.btmStart.TabIndex = 1;
      this.btmStart.TabStop = false;
      this.btmStart.Text = "START";
      this.btmStart.TextAlign = ContentAlignment.MiddleRight;
      this.btmStart.UseVisualStyleBackColor = false;
      this.picVOTE_CAPTCHA_0.BackColor = Color.FromArgb(0, 64, 0);
      this.picVOTE_CAPTCHA_0.BorderStyle = BorderStyle.FixedSingle;
      this.picVOTE_CAPTCHA_0.ErrorImage = (Image) null;
      this.picVOTE_CAPTCHA_0.Image = (Image) componentResourceManager.GetObject("picVOTE_CAPTCHA_0.Image");
      this.picVOTE_CAPTCHA_0.InitialImage = (Image) null;
      PictureBox picVoteCaptcha0_1 = this.picVOTE_CAPTCHA_0;
      point1 = new Point(3, 27);
      Point point3 = point1;
      picVoteCaptcha0_1.Location = point3;
      this.picVOTE_CAPTCHA_0.Name = "picVOTE_CAPTCHA_0";
      PictureBox picVoteCaptcha0_2 = this.picVOTE_CAPTCHA_0;
      size1 = new Size(225, 51);
      Size size3 = size1;
      picVoteCaptcha0_2.Size = size3;
      this.picVOTE_CAPTCHA_0.TabIndex = 3;
      this.picVOTE_CAPTCHA_0.TabStop = false;
      this.picVOTE_CAPTCHA_0.Visible = false;
      this.cmbThread.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbThread.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbThread.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbThread.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbThread.ForeColor = Color.Black;
      this.cmbThread.FormattingEnabled = true;
      this.cmbThread.Items.AddRange(new object[14]
      {
        (object) "1",
        (object) "2",
        (object) "4",
        (object) "8",
        (object) "16",
        (object) "32",
        (object) "64",
        (object) "128",
        (object) "192",
        (object) "256",
        (object) "512",
        (object) "1024",
        (object) "2048",
        (object) "4096"
      });
      ComboBox cmbThread1 = this.cmbThread;
      point1 = new Point(913, 3);
      Point point4 = point1;
      cmbThread1.Location = point4;
      this.cmbThread.Name = "cmbThread";
      ComboBox cmbThread2 = this.cmbThread;
      size1 = new Size(62, 24);
      Size size4 = size1;
      cmbThread2.Size = size4;
      this.cmbThread.TabIndex = 5;
      this.cmbThread.TabStop = false;
      this.tmrConnect.Interval = 33;
      this.LV.AllowColumnReorder = true;
      this.LV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LV.BackColor = Color.White;
      this.LV.Columns.AddRange(new ColumnHeader[8]
      {
        this.ColumnHeader1,
        this.ColumnHeader2,
        this.ColumnHeader3,
        this.ColumnHeader4,
        this.ColumnHeader5,
        this.ColumnHeader6,
        this.ColumnHeader7,
        this.ColumnHeader8
      });
      this.LV.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.LV.FullRowSelect = true;
      this.LV.GridLines = true;
      this.LV.HideSelection = false;
      this.LV.ImeMode = ImeMode.On;
      this.LV.LabelWrap = false;
      ListView lv1 = this.LV;
      point1 = new Point(0, 0);
      Point point5 = point1;
      lv1.Location = point5;
      this.LV.Name = "LV";
      ListView lv2 = this.LV;
      size1 = new Size(737, 387);
      Size size5 = size1;
      lv2.Size = size5;
      this.LV.SmallImageList = this.IL_LV;
      this.LV.TabIndex = 0;
      this.LV.TabStop = false;
      this.LV.UseCompatibleStateImageBehavior = false;
      this.LV.View = View.Details;
      this.ColumnHeader1.Text = "№";
      this.ColumnHeader2.Text = "Login";
      this.ColumnHeader2.TextAlign = HorizontalAlignment.Right;
      this.ColumnHeader2.Width = 98;
      this.ColumnHeader3.Text = "Domain";
      this.ColumnHeader3.Width = 72;
      this.ColumnHeader4.Text = "Name";
      this.ColumnHeader4.TextAlign = HorizontalAlignment.Right;
      this.ColumnHeader4.Width = 77;
      this.ColumnHeader5.Text = "LastName";
      this.ColumnHeader5.Width = 150;
      this.ColumnHeader6.Text = "Creation Date";
      this.ColumnHeader6.TextAlign = HorizontalAlignment.Center;
      this.ColumnHeader6.Width = 100;
      this.ColumnHeader7.Text = "Mail count";
      this.ColumnHeader7.TextAlign = HorizontalAlignment.Right;
      this.ColumnHeader7.Width = 74;
      this.ColumnHeader8.Text = "Comment";
      this.ColumnHeader8.Width = 80;
      this.IL_LV.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("IL_LV.ImageStream");
      this.IL_LV.TransparentColor = Color.Transparent;
      this.IL_LV.Images.SetKeyName(0, "5.png");
      this.IL_LV.Images.SetKeyName(1, "1.png");
      this.IL_LV.Images.SetKeyName(2, "2.png");
      this.IL_LV.Images.SetKeyName(3, "34.png");
      this.IL_LV.Images.SetKeyName(4, "stock_mail.png");
      this.IL_LV.Images.SetKeyName(5, "52.png");
      this.IL_LV.Images.SetKeyName(6, "badlogin.png");
      this.IL_LV.Images.SetKeyName(7, "время аккаунта истекло_24.png");
      this.LV_Dostupno.AllowColumnReorder = true;
      this.LV_Dostupno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LV_Dostupno.BackColor = Color.White;
      this.LV_Dostupno.Columns.AddRange(new ColumnHeader[2]
      {
        this.ColumnHeader16,
        this.ColumnHeader22
      });
      this.LV_Dostupno.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.LV_Dostupno.FullRowSelect = true;
      this.LV_Dostupno.GridLines = true;
      this.LV_Dostupno.HideSelection = false;
      this.LV_Dostupno.ImeMode = ImeMode.On;
      this.LV_Dostupno.LabelWrap = false;
      ListView lvDostupno1 = this.LV_Dostupno;
      point1 = new Point(484, 515);
      Point point6 = point1;
      lvDostupno1.Location = point6;
      this.LV_Dostupno.MultiSelect = false;
      this.LV_Dostupno.Name = "LV_Dostupno";
      ListView lvDostupno2 = this.LV_Dostupno;
      size1 = new Size(248, 226);
      Size size6 = size1;
      lvDostupno2.Size = size6;
      this.LV_Dostupno.TabIndex = 27;
      this.LV_Dostupno.TabStop = false;
      this.LV_Dostupno.UseCompatibleStateImageBehavior = false;
      this.LV_Dostupno.View = View.Details;
      this.ColumnHeader16.Text = "№";
      this.ColumnHeader16.Width = 54;
      this.ColumnHeader22.Text = "Доступно для регистрации";
      this.ColumnHeader22.Width = 190;
      this.txtCaptcha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.txtCaptcha.BorderStyle = BorderStyle.FixedSingle;
      this.txtCaptcha.Font = new Font("Tahoma", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtCaptcha1 = this.txtCaptcha;
      point1 = new Point(742, 159);
      Point point7 = point1;
      txtCaptcha1.Location = point7;
      this.txtCaptcha.MaxLength = 0;
      this.txtCaptcha.Name = "txtCaptcha";
      TextBox txtCaptcha2 = this.txtCaptcha;
      size1 = new Size(110, 30);
      Size size7 = size1;
      txtCaptcha2.Size = size7;
      this.txtCaptcha.TabIndex = 30;
      this.txtCaptcha.TextAlign = HorizontalAlignment.Center;
      this.txtCaptcha.WordWrap = false;
      this.txtCurrentMail.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.txtCurrentMail.BackColor = Color.Black;
      this.txtCurrentMail.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtCurrentMail.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      TextBox txtCurrentMail1 = this.txtCurrentMail;
      point1 = new Point(484, 470);
      Point point8 = point1;
      txtCurrentMail1.Location = point8;
      this.txtCurrentMail.Name = "txtCurrentMail";
      TextBox txtCurrentMail2 = this.txtCurrentMail;
      size1 = new Size(248, 26);
      Size size8 = size1;
      txtCurrentMail2.Size = size8;
      this.txtCurrentMail.TabIndex = 31;
      this.txtCurrentMail.TabStop = false;
      this.txtCurrentMail.Text = "e-mail to reg";
      this.txtCurrentMail.TextAlign = HorizontalAlignment.Center;
      this.txtCurrentMail.WordWrap = false;
      this.picCollection0.BackColor = Color.FromArgb(0, 64, 0);
      this.picCollection0.BorderStyle = BorderStyle.FixedSingle;
      this.picCollection0.Enabled = false;
      this.picCollection0.Image = (Image) componentResourceManager.GetObject("picCollection0.Image");
      PictureBox picCollection0_1 = this.picCollection0;
      point1 = new Point(512, 42);
      Point point9 = point1;
      picCollection0_1.Location = point9;
      this.picCollection0.Name = "picCollection0";
      PictureBox picCollection0_2 = this.picCollection0;
      size1 = new Size(225, 51);
      Size size9 = size1;
      picCollection0_2.Size = size9;
      this.picCollection0.TabIndex = 34;
      this.picCollection0.TabStop = false;
      this.picCollection0.Visible = false;
      this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label2_1 = this.Label2;
      point1 = new Point(851, 8);
      Point point10 = point1;
      label2_1.Location = point10;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(65, 14);
      Size size10 = size1;
      label2_2.Size = size10;
      this.Label2.TabIndex = 35;
      this.Label2.Text = "Потоков:";
      this.btmGlobalOptions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btmGlobalOptions.BackColor = Color.WhiteSmoke;
      this.btmGlobalOptions.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btmGlobalOptions.Image = (Image) componentResourceManager.GetObject("btmGlobalOptions.Image");
      this.btmGlobalOptions.ImageAlign = ContentAlignment.MiddleLeft;
      Button btmGlobalOptions1 = this.btmGlobalOptions;
      point1 = new Point(742, 266);
      Point point11 = point1;
      btmGlobalOptions1.Location = point11;
      this.btmGlobalOptions.Name = "btmGlobalOptions";
      Button btmGlobalOptions2 = this.btmGlobalOptions;
      size1 = new Size(110, 40);
      Size size11 = size1;
      btmGlobalOptions2.Size = size11;
      this.btmGlobalOptions.TabIndex = 36;
      this.btmGlobalOptions.TabStop = false;
      this.btmGlobalOptions.Text = "Общие\r\nНастройки";
      this.btmGlobalOptions.TextAlign = ContentAlignment.MiddleRight;
      this.btmGlobalOptions.UseVisualStyleBackColor = false;
      this.btmGenMailOptions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btmGenMailOptions.BackColor = Color.WhiteSmoke;
      this.btmGenMailOptions.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btmGenMailOptions.Image = (Image) componentResourceManager.GetObject("btmGenMailOptions.Image");
      this.btmGenMailOptions.ImageAlign = ContentAlignment.MiddleLeft;
      Button btmGenMailOptions1 = this.btmGenMailOptions;
      point1 = new Point(742, 356);
      Point point12 = point1;
      btmGenMailOptions1.Location = point12;
      this.btmGenMailOptions.Name = "btmGenMailOptions";
      Button btmGenMailOptions2 = this.btmGenMailOptions;
      size1 = new Size(110, 40);
      Size size12 = size1;
      btmGenMailOptions2.Size = size12;
      this.btmGenMailOptions.TabIndex = 38;
      this.btmGenMailOptions.TabStop = false;
      this.btmGenMailOptions.Text = "E-MAIL\r\nзаготовки";
      this.btmGenMailOptions.TextAlign = ContentAlignment.MiddleRight;
      this.btmGenMailOptions.UseVisualStyleBackColor = false;
      this.chAutoCaptcha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.chAutoCaptcha.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      CheckBox chAutoCaptcha1 = this.chAutoCaptcha;
      point1 = new Point(742, 194);
      Point point13 = point1;
      chAutoCaptcha1.Location = point13;
      this.chAutoCaptcha.Name = "chAutoCaptcha";
      CheckBox chAutoCaptcha2 = this.chAutoCaptcha;
      size1 = new Size(110, 17);
      Size size13 = size1;
      chAutoCaptcha2.Size = size13;
      this.chAutoCaptcha.TabIndex = 39;
      this.chAutoCaptcha.TabStop = false;
      this.chAutoCaptcha.Text = "Auto CAPTCHA";
      this.chAutoCaptcha.UseVisualStyleBackColor = true;
      this.chProxy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.chProxy.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.chProxy.ForeColor = Color.Green;
      CheckBox chProxy1 = this.chProxy;
      point1 = new Point(742, 217);
      Point point14 = point1;
      chProxy1.Location = point14;
      this.chProxy.Name = "chProxy";
      CheckBox chProxy2 = this.chProxy;
      size1 = new Size(88, 17);
      Size size14 = size1;
      chProxy2.Size = size14;
      this.chProxy.TabIndex = 40;
      this.chProxy.TabStop = false;
      this.chProxy.Text = "Use PROXY";
      this.chProxy.UseVisualStyleBackColor = true;
      this.lblProxy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lblProxy.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.lblProxy.BorderStyle = BorderStyle.FixedSingle;
      this.lblProxy.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      Label lblProxy1 = this.lblProxy;
      point1 = new Point(742, 237);
      Point point15 = point1;
      lblProxy1.Location = point15;
      this.lblProxy.Name = "lblProxy";
      Label lblProxy2 = this.lblProxy;
      size1 = new Size(110, 20);
      Size size15 = size1;
      lblProxy2.Size = size15;
      this.lblProxy.TabIndex = 41;
      this.lblProxy.Text = "DIRECT";
      this.lblProxy.TextAlign = ContentAlignment.MiddleCenter;
      this.btmLoadMail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btmLoadMail.BackColor = Color.WhiteSmoke;
      this.btmLoadMail.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btmLoadMail.Image = (Image) componentResourceManager.GetObject("btmLoadMail.Image");
      this.btmLoadMail.ImageAlign = ContentAlignment.MiddleLeft;
      Button btmLoadMail1 = this.btmLoadMail;
      point1 = new Point(742, 417);
      Point point16 = point1;
      btmLoadMail1.Location = point16;
      this.btmLoadMail.Name = "btmLoadMail";
      Button btmLoadMail2 = this.btmLoadMail;
      size1 = new Size(111, 40);
      Size size16 = size1;
      btmLoadMail2.Size = size16;
      this.btmLoadMail.TabIndex = 42;
      this.btmLoadMail.TabStop = false;
      this.btmLoadMail.Text = "Скачать\r\nписьма";
      this.btmLoadMail.TextAlign = ContentAlignment.MiddleRight;
      this.btmLoadMail.UseVisualStyleBackColor = false;
      this.chAllMail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.chAllMail.ForeColor = Color.Black;
      CheckBox chAllMail1 = this.chAllMail;
      point1 = new Point(857, 441);
      Point point17 = point1;
      chAllMail1.Location = point17;
      this.chAllMail.Name = "chAllMail";
      CheckBox chAllMail2 = this.chAllMail;
      size1 = new Size(54, 17);
      Size size17 = size1;
      chAllMail2.Size = size17;
      this.chAllMail.TabIndex = 43;
      this.chAllMail.TabStop = false;
      this.chAllMail.Text = "все";
      this.chAllMail.UseVisualStyleBackColor = true;
      this.lblMailCountCur.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lblMailCountCur.BackColor = Color.FromArgb(176, 186, 210);
      this.lblMailCountCur.BorderStyle = BorderStyle.FixedSingle;
      this.lblMailCountCur.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      Label lblMailCountCur1 = this.lblMailCountCur;
      point1 = new Point(912, 417);
      Point point18 = point1;
      lblMailCountCur1.Location = point18;
      this.lblMailCountCur.Name = "lblMailCountCur";
      Label lblMailCountCur2 = this.lblMailCountCur;
      size1 = new Size(62, 20);
      Size size18 = size1;
      lblMailCountCur2.Size = size18;
      this.lblMailCountCur.TabIndex = 49;
      this.lblMailCountCur.Text = "0";
      this.lblMailCountCur.TextAlign = ContentAlignment.MiddleCenter;
      this.lblMailCountAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lblMailCountAll.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.lblMailCountAll.BorderStyle = BorderStyle.FixedSingle;
      this.lblMailCountAll.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      Label lblMailCountAll1 = this.lblMailCountAll;
      point1 = new Point(857, 417);
      Point point19 = point1;
      lblMailCountAll1.Location = point19;
      this.lblMailCountAll.Name = "lblMailCountAll";
      Label lblMailCountAll2 = this.lblMailCountAll;
      size1 = new Size(54, 20);
      Size size19 = size1;
      lblMailCountAll2.Size = size19;
      this.lblMailCountAll.TabIndex = 50;
      this.lblMailCountAll.Text = "0";
      this.lblMailCountAll.TextAlign = ContentAlignment.MiddleCenter;
      this.grAccountEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.grAccountEdit.BackColor = Color.WhiteSmoke;
      this.grAccountEdit.Controls.Add((Control) this.btnSort_Random);
      this.grAccountEdit.Controls.Add((Control) this.btnSort_Turn);
      this.grAccountEdit.Controls.Add((Control) this.btnSort);
      this.grAccountEdit.Controls.Add((Control) this.gbAccSell_5);
      this.grAccountEdit.Controls.Add((Control) this.rbAccSel_J);
      this.grAccountEdit.Controls.Add((Control) this.rbAccSel_M);
      this.grAccountEdit.Controls.Add((Control) this.gbAccSell_3);
      this.grAccountEdit.Controls.Add((Control) this.cmbReg);
      this.grAccountEdit.Controls.Add((Control) this.btmAccSel_Del);
      this.grAccountEdit.Controls.Add((Control) this.btmAccSel_Save);
      this.grAccountEdit.Controls.Add((Control) this.gbAccSell_4);
      this.grAccountEdit.Controls.Add((Control) this.gbAccSell_2);
      this.grAccountEdit.Controls.Add((Control) this.gbAccSell_1);
      this.grAccountEdit.Controls.Add((Control) this.lblAccSelNUM);
      this.grAccountEdit.Controls.Add((Control) this.gbAccSell_6);
      GroupBox grAccountEdit1 = this.grAccountEdit;
      point1 = new Point(2, 390);
      Point point20 = point1;
      grAccountEdit1.Location = point20;
      this.grAccountEdit.Name = "grAccountEdit";
      GroupBox grAccountEdit2 = this.grAccountEdit;
      size1 = new Size(733, 79);
      Size size20 = size1;
      grAccountEdit2.Size = size20;
      this.grAccountEdit.TabIndex = 52;
      this.grAccountEdit.TabStop = false;
      this.grAccountEdit.Text = "№ аккаунта";
      this.btnSort_Random.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnSort_Random.BackColor = Color.FromArgb(224, 224, 224);
      this.btnSort_Random.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnSort_Random.Image = (Image) componentResourceManager.GetObject("btnSort_Random.Image");
      Button btnSortRandom1 = this.btnSort_Random;
      point1 = new Point(614, 9);
      Point point21 = point1;
      btnSortRandom1.Location = point21;
      this.btnSort_Random.Name = "btnSort_Random";
      Button btnSortRandom2 = this.btnSort_Random;
      size1 = new Size(29, 27);
      Size size21 = size1;
      btnSortRandom2.Size = size21;
      this.btnSort_Random.TabIndex = 168;
      this.btnSort_Random.TabStop = false;
      this.btnSort_Random.TextAlign = ContentAlignment.MiddleRight;
      this.btnSort_Random.UseVisualStyleBackColor = false;
      this.btnSort_Turn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnSort_Turn.BackColor = Color.FromArgb(224, 224, 224);
      this.btnSort_Turn.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnSort_Turn.Image = (Image) componentResourceManager.GetObject("btnSort_Turn.Image");
      Button btnSortTurn1 = this.btnSort_Turn;
      point1 = new Point(643, 9);
      Point point22 = point1;
      btnSortTurn1.Location = point22;
      this.btnSort_Turn.Name = "btnSort_Turn";
      Button btnSortTurn2 = this.btnSort_Turn;
      size1 = new Size(29, 27);
      Size size22 = size1;
      btnSortTurn2.Size = size22;
      this.btnSort_Turn.TabIndex = 169;
      this.btnSort_Turn.TabStop = false;
      this.btnSort_Turn.TextAlign = ContentAlignment.MiddleRight;
      this.btnSort_Turn.UseVisualStyleBackColor = false;
      this.btnSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnSort.BackColor = Color.FromArgb(224, 224, 224);
      this.btnSort.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnSort.Image = (Image) componentResourceManager.GetObject("btnSort.Image");
      this.btnSort.ImageAlign = ContentAlignment.MiddleLeft;
      Button btnSort1 = this.btnSort;
      point1 = new Point(672, 9);
      Point point23 = point1;
      btnSort1.Location = point23;
      this.btnSort.Name = "btnSort";
      Button btnSort2 = this.btnSort;
      size1 = new Size(58, 27);
      Size size23 = size1;
      btnSort2.Size = size23;
      this.btnSort.TabIndex = 167;
      this.btnSort.TabStop = false;
      this.btnSort.Text = "SORT";
      this.btnSort.TextAlign = ContentAlignment.MiddleRight;
      this.btnSort.UseVisualStyleBackColor = false;
      this.gbAccSell_5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.gbAccSell_5.BackColor = Color.Transparent;
      this.gbAccSell_5.Controls.Add((Control) this.txtAccSel_Comment);
      this.gbAccSell_5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox gbAccSell5_1 = this.gbAccSell_5;
      point1 = new Point(486, 0);
      Point point24 = point1;
      gbAccSell5_1.Location = point24;
      this.gbAccSell_5.Name = "gbAccSell_5";
      GroupBox gbAccSell5_2 = this.gbAccSell_5;
      size1 = new Size(128, 38);
      Size size24 = size1;
      gbAccSell5_2.Size = size24;
      this.gbAccSell_5.TabIndex = 59;
      this.gbAccSell_5.TabStop = false;
      this.gbAccSell_5.Text = "комментарий:";
      this.txtAccSel_Comment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtAccSel_Comment.BackColor = Color.WhiteSmoke;
      this.txtAccSel_Comment.BorderStyle = BorderStyle.None;
      TextBox txtAccSelComment1 = this.txtAccSel_Comment;
      point1 = new Point(4, 16);
      Point point25 = point1;
      txtAccSelComment1.Location = point25;
      this.txtAccSel_Comment.Name = "txtAccSel_Comment";
      TextBox txtAccSelComment2 = this.txtAccSel_Comment;
      size1 = new Size(118, 14);
      Size size25 = size1;
      txtAccSelComment2.Size = size25;
      this.txtAccSel_Comment.TabIndex = 55;
      this.txtAccSel_Comment.TabStop = false;
      this.txtAccSel_Comment.TextAlign = HorizontalAlignment.Center;
      this.rbAccSel_J.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.rbAccSel_J.AutoSize = true;
      this.rbAccSel_J.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      RadioButton rbAccSelJ1 = this.rbAccSel_J;
      point1 = new Point(280, 50);
      Point point26 = point1;
      rbAccSelJ1.Location = point26;
      this.rbAccSel_J.Name = "rbAccSel_J";
      RadioButton rbAccSelJ2 = this.rbAccSel_J;
      size1 = new Size(38, 18);
      Size size26 = size1;
      rbAccSelJ2.Size = size26;
      this.rbAccSel_J.TabIndex = 62;
      this.rbAccSel_J.Text = "Ж";
      this.rbAccSel_J.UseVisualStyleBackColor = true;
      this.rbAccSel_M.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.rbAccSel_M.AutoSize = true;
      this.rbAccSel_M.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      RadioButton rbAccSelM1 = this.rbAccSel_M;
      point1 = new Point(242, 50);
      Point point27 = point1;
      rbAccSelM1.Location = point27;
      this.rbAccSel_M.Name = "rbAccSel_M";
      RadioButton rbAccSelM2 = this.rbAccSel_M;
      size1 = new Size(36, 18);
      Size size27 = size1;
      rbAccSelM2.Size = size27;
      this.rbAccSel_M.TabIndex = 61;
      this.rbAccSel_M.Text = "М";
      this.rbAccSel_M.UseVisualStyleBackColor = true;
      this.gbAccSell_3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.gbAccSell_3.BackColor = Color.Transparent;
      this.gbAccSell_3.Controls.Add((Control) this.txtAccSel_SecretQuestion);
      GroupBox gbAccSell3_1 = this.gbAccSell_3;
      point1 = new Point(328, 0);
      Point point28 = point1;
      gbAccSell3_1.Location = point28;
      this.gbAccSell_3.Name = "gbAccSell_3";
      GroupBox gbAccSell3_2 = this.gbAccSell_3;
      size1 = new Size(156, 38);
      Size size28 = size1;
      gbAccSell3_2.Size = size28;
      this.gbAccSell_3.TabIndex = 60;
      this.gbAccSell_3.TabStop = false;
      this.gbAccSell_3.Text = "секретный вопрос:";
      this.txtAccSel_SecretQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtAccSel_SecretQuestion.BackColor = Color.WhiteSmoke;
      this.txtAccSel_SecretQuestion.BorderStyle = BorderStyle.None;
      TextBox selSecretQuestion1 = this.txtAccSel_SecretQuestion;
      point1 = new Point(4, 16);
      Point point29 = point1;
      selSecretQuestion1.Location = point29;
      this.txtAccSel_SecretQuestion.Name = "txtAccSel_SecretQuestion";
      TextBox selSecretQuestion2 = this.txtAccSel_SecretQuestion;
      size1 = new Size(146, 14);
      Size size29 = size1;
      selSecretQuestion2.Size = size29;
      this.txtAccSel_SecretQuestion.TabIndex = 55;
      this.txtAccSel_SecretQuestion.TabStop = false;
      this.txtAccSel_SecretQuestion.TextAlign = HorizontalAlignment.Center;
      this.cmbReg.BackColor = Color.White;
      this.cmbReg.DropDownHeight = 160;
      this.cmbReg.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbReg.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbReg.FormattingEnabled = true;
      this.cmbReg.IntegralHeight = false;
      ComboBox cmbReg1 = this.cmbReg;
      point1 = new Point(22, 44);
      Point point30 = point1;
      cmbReg1.Location = point30;
      this.cmbReg.Name = "cmbReg";
      ComboBox cmbReg2 = this.cmbReg;
      size1 = new Size(46, 27);
      Size size30 = size1;
      cmbReg2.Size = size30;
      this.cmbReg.TabIndex = 58;
      this.cmbReg.TabStop = false;
      this.btmAccSel_Del.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btmAccSel_Del.BackColor = Color.FromArgb(224, 224, 224);
      this.btmAccSel_Del.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btmAccSel_Del.Image = (Image) componentResourceManager.GetObject("btmAccSel_Del.Image");
      this.btmAccSel_Del.ImageAlign = ContentAlignment.MiddleLeft;
      Button btmAccSelDel1 = this.btmAccSel_Del;
      point1 = new Point(614, 46);
      Point point31 = point1;
      btmAccSelDel1.Location = point31;
      this.btmAccSel_Del.Name = "btmAccSel_Del";
      Button btmAccSelDel2 = this.btmAccSel_Del;
      size1 = new Size(58, 27);
      Size size31 = size1;
      btmAccSelDel2.Size = size31;
      this.btmAccSel_Del.TabIndex = 57;
      this.btmAccSel_Del.TabStop = false;
      this.btmAccSel_Del.Text = "DEL";
      this.btmAccSel_Del.TextAlign = ContentAlignment.MiddleRight;
      this.btmAccSel_Del.UseVisualStyleBackColor = false;
      this.btmAccSel_Save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btmAccSel_Save.BackColor = Color.FromArgb(224, 224, 224);
      this.btmAccSel_Save.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btmAccSel_Save.Image = (Image) componentResourceManager.GetObject("btmAccSel_Save.Image");
      this.btmAccSel_Save.ImageAlign = ContentAlignment.MiddleLeft;
      Button btmAccSelSave1 = this.btmAccSel_Save;
      point1 = new Point(672, 46);
      Point point32 = point1;
      btmAccSelSave1.Location = point32;
      this.btmAccSel_Save.Name = "btmAccSel_Save";
      Button btmAccSelSave2 = this.btmAccSel_Save;
      size1 = new Size(58, 27);
      Size size32 = size1;
      btmAccSelSave2.Size = size32;
      this.btmAccSel_Save.TabIndex = 56;
      this.btmAccSel_Save.TabStop = false;
      this.btmAccSel_Save.Text = "SAVE";
      this.btmAccSel_Save.TextAlign = ContentAlignment.MiddleRight;
      this.btmAccSel_Save.UseVisualStyleBackColor = false;
      this.gbAccSell_4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.gbAccSell_4.BackColor = Color.Transparent;
      this.gbAccSell_4.Controls.Add((Control) this.txtAccSel_SecretAnswer);
      GroupBox gbAccSell4_1 = this.gbAccSell_4;
      point1 = new Point(328, 38);
      Point point33 = point1;
      gbAccSell4_1.Location = point33;
      this.gbAccSell_4.Name = "gbAccSell_4";
      GroupBox gbAccSell4_2 = this.gbAccSell_4;
      size1 = new Size(156, 38);
      Size size33 = size1;
      gbAccSell4_2.Size = size33;
      this.gbAccSell_4.TabIndex = 55;
      this.gbAccSell_4.TabStop = false;
      this.gbAccSell_4.Text = "секретный ответ:";
      this.txtAccSel_SecretAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtAccSel_SecretAnswer.BackColor = Color.WhiteSmoke;
      this.txtAccSel_SecretAnswer.BorderStyle = BorderStyle.None;
      TextBox accSelSecretAnswer1 = this.txtAccSel_SecretAnswer;
      point1 = new Point(4, 16);
      Point point34 = point1;
      accSelSecretAnswer1.Location = point34;
      this.txtAccSel_SecretAnswer.Name = "txtAccSel_SecretAnswer";
      TextBox accSelSecretAnswer2 = this.txtAccSel_SecretAnswer;
      size1 = new Size(146, 14);
      Size size34 = size1;
      accSelSecretAnswer2.Size = size34;
      this.txtAccSel_SecretAnswer.TabIndex = 55;
      this.txtAccSel_SecretAnswer.TabStop = false;
      this.txtAccSel_SecretAnswer.TextAlign = HorizontalAlignment.Center;
      this.gbAccSell_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.gbAccSell_2.BackColor = Color.Transparent;
      this.gbAccSell_2.Controls.Add((Control) this.txtAccSel_Password);
      GroupBox gbAccSell2_1 = this.gbAccSell_2;
      point1 = new Point(90, 38);
      Point point35 = point1;
      gbAccSell2_1.Location = point35;
      this.gbAccSell_2.Name = "gbAccSell_2";
      GroupBox gbAccSell2_2 = this.gbAccSell_2;
      size1 = new Size(142, 38);
      Size size35 = size1;
      gbAccSell2_2.Size = size35;
      this.gbAccSell_2.TabIndex = 54;
      this.gbAccSell_2.TabStop = false;
      this.gbAccSell_2.Text = "пароль:";
      this.txtAccSel_Password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtAccSel_Password.BackColor = Color.WhiteSmoke;
      this.txtAccSel_Password.BorderStyle = BorderStyle.None;
      TextBox txtAccSelPassword1 = this.txtAccSel_Password;
      point1 = new Point(4, 16);
      Point point36 = point1;
      txtAccSelPassword1.Location = point36;
      this.txtAccSel_Password.Name = "txtAccSel_Password";
      TextBox txtAccSelPassword2 = this.txtAccSel_Password;
      size1 = new Size(132, 14);
      Size size36 = size1;
      txtAccSelPassword2.Size = size36;
      this.txtAccSel_Password.TabIndex = 55;
      this.txtAccSel_Password.TabStop = false;
      this.txtAccSel_Password.TextAlign = HorizontalAlignment.Center;
      this.gbAccSell_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.gbAccSell_1.BackColor = Color.Transparent;
      this.gbAccSell_1.Controls.Add((Control) this.txtAccSel_Login);
      GroupBox gbAccSell1_1 = this.gbAccSell_1;
      point1 = new Point(90, 0);
      Point point37 = point1;
      gbAccSell1_1.Location = point37;
      this.gbAccSell_1.Name = "gbAccSell_1";
      GroupBox gbAccSell1_2 = this.gbAccSell_1;
      size1 = new Size(238, 38);
      Size size37 = size1;
      gbAccSell1_2.Size = size37;
      this.gbAccSell_1.TabIndex = 53;
      this.gbAccSell_1.TabStop = false;
      this.gbAccSell_1.Text = "логин:";
      this.txtAccSel_Login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtAccSel_Login.BackColor = Color.WhiteSmoke;
      this.txtAccSel_Login.BorderStyle = BorderStyle.None;
      this.txtAccSel_Login.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtAccSelLogin1 = this.txtAccSel_Login;
      point1 = new Point(4, 16);
      Point point38 = point1;
      txtAccSelLogin1.Location = point38;
      this.txtAccSel_Login.Name = "txtAccSel_Login";
      TextBox txtAccSelLogin2 = this.txtAccSel_Login;
      size1 = new Size(228, 15);
      Size size38 = size1;
      txtAccSelLogin2.Size = size38;
      this.txtAccSel_Login.TabIndex = 55;
      this.txtAccSel_Login.TabStop = false;
      this.txtAccSel_Login.TextAlign = HorizontalAlignment.Center;
      this.lblAccSelNUM.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label lblAccSelNum1 = this.lblAccSelNUM;
      point1 = new Point(8, 11);
      Point point39 = point1;
      lblAccSelNum1.Location = point39;
      this.lblAccSelNUM.Name = "lblAccSelNUM";
      Label lblAccSelNum2 = this.lblAccSelNUM;
      size1 = new Size(78, 22);
      Size size39 = size1;
      lblAccSelNum2.Size = size39;
      this.lblAccSelNUM.TabIndex = 52;
      this.lblAccSelNUM.Text = "0";
      this.lblAccSelNUM.TextAlign = ContentAlignment.MiddleCenter;
      this.gbAccSell_6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.gbAccSell_6.BackColor = Color.Transparent;
      this.gbAccSell_6.Controls.Add((Control) this.txtAccSel_Town);
      GroupBox gbAccSell6_1 = this.gbAccSell_6;
      point1 = new Point(486, 38);
      Point point40 = point1;
      gbAccSell6_1.Location = point40;
      this.gbAccSell_6.Name = "gbAccSell_6";
      GroupBox gbAccSell6_2 = this.gbAccSell_6;
      size1 = new Size(128, 38);
      Size size40 = size1;
      gbAccSell6_2.Size = size40;
      this.gbAccSell_6.TabIndex = 63;
      this.gbAccSell_6.TabStop = false;
      this.gbAccSell_6.Text = "город:";
      this.txtAccSel_Town.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtAccSel_Town.BackColor = Color.WhiteSmoke;
      this.txtAccSel_Town.BorderStyle = BorderStyle.None;
      TextBox txtAccSelTown1 = this.txtAccSel_Town;
      point1 = new Point(4, 16);
      Point point41 = point1;
      txtAccSelTown1.Location = point41;
      this.txtAccSel_Town.Name = "txtAccSel_Town";
      TextBox txtAccSelTown2 = this.txtAccSel_Town;
      size1 = new Size(118, 14);
      Size size41 = size1;
      txtAccSelTown2.Size = size41;
      this.txtAccSel_Town.TabIndex = 55;
      this.txtAccSel_Town.TabStop = false;
      this.txtAccSel_Town.TextAlign = HorizontalAlignment.Center;
      this.btmSaveList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btmSaveList.BackColor = Color.WhiteSmoke;
      this.btmSaveList.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btmSaveList.Image = (Image) componentResourceManager.GetObject("btmSaveList.Image");
      this.btmSaveList.ImageAlign = ContentAlignment.MiddleLeft;
      Button btmSaveList1 = this.btmSaveList;
      point1 = new Point(742, 310);
      Point point42 = point1;
      btmSaveList1.Location = point42;
      this.btmSaveList.Name = "btmSaveList";
      Button btmSaveList2 = this.btmSaveList;
      size1 = new Size(110, 40);
      Size size42 = size1;
      btmSaveList2.Size = size42;
      this.btmSaveList.TabIndex = 54;
      this.btmSaveList.TabStop = false;
      this.btmSaveList.Text = "Сохранить\r\nсписком";
      this.btmSaveList.TextAlign = ContentAlignment.MiddleRight;
      this.btmSaveList.UseVisualStyleBackColor = false;
      this.IL.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("IL.ImageStream");
      this.IL.TransparentColor = Color.Transparent;
      this.IL.Images.SetKeyName(0, "run.png");
      this.IL.Images.SetKeyName(1, "stop1normalred.png");
      this.chAutoUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.chAutoUpdate.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chAutoUpdate.ForeColor = Color.Blue;
      CheckBox chAutoUpdate1 = this.chAutoUpdate;
      point1 = new Point(739, 722);
      Point point43 = point1;
      chAutoUpdate1.Location = point43;
      this.chAutoUpdate.Name = "chAutoUpdate";
      CheckBox chAutoUpdate2 = this.chAutoUpdate;
      size1 = new Size(222, 17);
      Size size43 = size1;
      chAutoUpdate2.Size = size43;
      this.chAutoUpdate.TabIndex = 57;
      this.chAutoUpdate.TabStop = false;
      this.chAutoUpdate.Text = "проверять обновление при запуске";
      this.chAutoUpdate.UseVisualStyleBackColor = true;
      this.txtMon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.txtMon.BackColor = Color.White;
      TextBox txtMon1 = this.txtMon;
      point1 = new Point(0, 471);
      Point point44 = point1;
      txtMon1.Location = point44;
      this.txtMon.Multiline = true;
      this.txtMon.Name = "txtMon";
      this.txtMon.ScrollBars = ScrollBars.Vertical;
      TextBox txtMon2 = this.txtMon;
      size1 = new Size(482, 270);
      Size size44 = size1;
      txtMon2.Size = size44;
      this.txtMon.TabIndex = 58;
      this.txtMon.TabStop = false;
      this.btmAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btmAbout.BackColor = Color.FromArgb(224, 224, 224);
      Button btmAbout1 = this.btmAbout;
      point1 = new Point(913, 718);
      Point point45 = point1;
      btmAbout1.Location = point45;
      this.btmAbout.Name = "btmAbout";
      Button btmAbout2 = this.btmAbout;
      size1 = new Size(62, 25);
      Size size45 = size1;
      btmAbout2.Size = size45;
      this.btmAbout.TabIndex = 66;
      this.btmAbout.TabStop = false;
      this.btmAbout.Text = "about";
      this.btmAbout.UseVisualStyleBackColor = false;
      this.lblActionInSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Label lblActionInSelect1 = this.lblActionInSelect;
      point1 = new Point(484, 499);
      Point point46 = point1;
      lblActionInSelect1.Location = point46;
      this.lblActionInSelect.Name = "lblActionInSelect";
      Label lblActionInSelect2 = this.lblActionInSelect;
      size1 = new Size(244, 13);
      Size size46 = size1;
      lblActionInSelect2.Size = size46;
      this.lblActionInSelect.TabIndex = 67;
      this.lblActionInSelect.Text = "Действие при занятом логине";
      this.lblActionInSelect.TextAlign = ContentAlignment.TopCenter;
      this.StatusBar.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.StatusBar.Items.AddRange(new ToolStripItem[9]
      {
        (ToolStripItem) this.stlbl_1,
        (ToolStripItem) this.stlbl_2,
        (ToolStripItem) this.stlbl_3,
        (ToolStripItem) this.stlbl_4,
        (ToolStripItem) this.stlbl_CurProxy_1,
        (ToolStripItem) this.stlbl_CurProxy_2,
        (ToolStripItem) this.ToolStripStatusLabel1,
        (ToolStripItem) this.stlbl_Speed_1,
        (ToolStripItem) this.stlbl_Speed_2
      });
      StatusStrip statusBar1 = this.StatusBar;
      point1 = new Point(0, 756);
      Point point47 = point1;
      statusBar1.Location = point47;
      this.StatusBar.Name = "StatusBar";
      StatusStrip statusBar2 = this.StatusBar;
      size1 = new Size(977, 27);
      Size size47 = size1;
      statusBar2.Size = size47;
      this.StatusBar.TabIndex = 71;
      this.StatusBar.Text = "statusbar";
      this.stlbl_1.AutoSize = false;
      this.stlbl_1.BorderSides = ToolStripStatusLabelBorderSides.All;
      this.stlbl_1.BorderStyle = Border3DStyle.Bump;
      this.stlbl_1.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.stlbl_1.Name = "stlbl_1";
      ToolStripStatusLabel stlbl1 = this.stlbl_1;
      size1 = new Size(150, 22);
      Size size48 = size1;
      stlbl1.Size = size48;
      this.stlbl_1.Text = "<М> Имя:";
      this.stlbl_1.TextAlign = ContentAlignment.MiddleLeft;
      this.stlbl_2.AutoSize = false;
      this.stlbl_2.BorderSides = ToolStripStatusLabelBorderSides.All;
      this.stlbl_2.BorderStyle = Border3DStyle.Bump;
      this.stlbl_2.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.stlbl_2.Name = "stlbl_2";
      ToolStripStatusLabel stlbl2 = this.stlbl_2;
      size1 = new Size(150, 22);
      Size size49 = size1;
      stlbl2.Size = size49;
      this.stlbl_2.Text = "<М> Фамилии:";
      this.stlbl_2.TextAlign = ContentAlignment.MiddleLeft;
      this.stlbl_3.AutoSize = false;
      this.stlbl_3.BorderSides = ToolStripStatusLabelBorderSides.All;
      this.stlbl_3.BorderStyle = Border3DStyle.Bump;
      this.stlbl_3.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.stlbl_3.Name = "stlbl_3";
      ToolStripStatusLabel stlbl3 = this.stlbl_3;
      size1 = new Size(150, 22);
      Size size50 = size1;
      stlbl3.Size = size50;
      this.stlbl_3.Text = "<Ж> Имя:";
      this.stlbl_3.TextAlign = ContentAlignment.MiddleLeft;
      this.stlbl_4.AutoSize = false;
      this.stlbl_4.BorderSides = ToolStripStatusLabelBorderSides.All;
      this.stlbl_4.BorderStyle = Border3DStyle.Bump;
      this.stlbl_4.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.stlbl_4.Name = "stlbl_4";
      ToolStripStatusLabel stlbl4 = this.stlbl_4;
      size1 = new Size(150, 22);
      Size size51 = size1;
      stlbl4.Size = size51;
      this.stlbl_4.Text = "<Ж> Фамилии:";
      this.stlbl_4.TextAlign = ContentAlignment.MiddleLeft;
      this.stlbl_CurProxy_1.BackColor = Color.Transparent;
      this.stlbl_CurProxy_1.Name = "stlbl_CurProxy_1";
      ToolStripStatusLabel stlblCurProxy1 = this.stlbl_CurProxy_1;
      size1 = new Size(43, 22);
      Size size52 = size1;
      stlblCurProxy1.Size = size52;
      this.stlbl_CurProxy_1.Text = "Proxy:";
      this.stlbl_CurProxy_1.TextAlign = ContentAlignment.MiddleLeft;
      this.stlbl_CurProxy_2.AutoSize = false;
      this.stlbl_CurProxy_2.BackColor = Color.Transparent;
      this.stlbl_CurProxy_2.Name = "stlbl_CurProxy_2";
      ToolStripStatusLabel stlblCurProxy2 = this.stlbl_CurProxy_2;
      size1 = new Size(88, 22);
      Size size53 = size1;
      stlblCurProxy2.Size = size53;
      this.stlbl_CurProxy_2.Text = "???";
      this.ToolStripStatusLabel1.BackColor = Color.Transparent;
      this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
      ToolStripStatusLabel stripStatusLabel1 = this.ToolStripStatusLabel1;
      size1 = new Size(48, 22);
      Size size54 = size1;
      stripStatusLabel1.Size = size54;
      this.ToolStripStatusLabel1.Text = "Speed:";
      this.ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
      this.stlbl_Speed_1.AutoSize = false;
      this.stlbl_Speed_1.BackColor = Color.Transparent;
      this.stlbl_Speed_1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.stlbl_Speed_1.Name = "stlbl_Speed_1";
      ToolStripStatusLabel stlblSpeed1 = this.stlbl_Speed_1;
      size1 = new Size(90, 22);
      Size size55 = size1;
      stlblSpeed1.Size = size55;
      this.stlbl_Speed_1.Text = "???";
      this.stlbl_Speed_2.AutoSize = false;
      this.stlbl_Speed_2.BackColor = Color.Transparent;
      this.stlbl_Speed_2.Name = "stlbl_Speed_2";
      ToolStripStatusLabel stlblSpeed2 = this.stlbl_Speed_2;
      size1 = new Size(90, 22);
      Size size56 = size1;
      stlblSpeed2.Size = size56;
      this.stlbl_Speed_2.Text = "???";
      this.ToolTip1.IsBalloon = true;
      this.ToolTip1.ToolTipIcon = ToolTipIcon.Info;
      this.ToolTip1.ToolTipTitle = "подсказка";
      this.tmrHelp.Interval = 7000;
      this.picLine_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.picLine_2.Image = (Image) componentResourceManager.GetObject("picLine_2.Image");
      PictureBox picLine2_1 = this.picLine_2;
      point1 = new Point(759, 401);
      Point point48 = point1;
      picLine2_1.Location = point48;
      this.picLine_2.Name = "picLine_2";
      PictureBox picLine2_2 = this.picLine_2;
      size1 = new Size(200, 9);
      Size size57 = size1;
      picLine2_2.Size = size57;
      this.picLine_2.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picLine_2.TabIndex = 73;
      this.picLine_2.TabStop = false;
      this.picLine_3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.picLine_3.Image = (Image) componentResourceManager.GetObject("picLine_3.Image");
      PictureBox picLine3_1 = this.picLine_3;
      point1 = new Point(760, 463);
      Point point49 = point1;
      picLine3_1.Location = point49;
      this.picLine_3.Name = "picLine_3";
      PictureBox picLine3_2 = this.picLine_3;
      size1 = new Size(200, 9);
      Size size58 = size1;
      picLine3_2.Size = size58;
      this.picLine_3.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picLine_3.TabIndex = 74;
      this.picLine_3.TabStop = false;
      this.tmrUpdate.Interval = 1000;
      this.picAutoCaptchaEnable.BackColor = Color.FromArgb(0, 64, 0);
      this.picAutoCaptchaEnable.BorderStyle = BorderStyle.FixedSingle;
      this.picAutoCaptchaEnable.ErrorImage = (Image) componentResourceManager.GetObject("picAutoCaptchaEnable.ErrorImage");
      this.picAutoCaptchaEnable.Image = (Image) componentResourceManager.GetObject("picAutoCaptchaEnable.Image");
      this.picAutoCaptchaEnable.InitialImage = (Image) componentResourceManager.GetObject("picAutoCaptchaEnable.InitialImage");
      PictureBox autoCaptchaEnable1 = this.picAutoCaptchaEnable;
      point1 = new Point(4, 28);
      Point point50 = point1;
      autoCaptchaEnable1.Location = point50;
      this.picAutoCaptchaEnable.Name = "picAutoCaptchaEnable";
      PictureBox autoCaptchaEnable2 = this.picAutoCaptchaEnable;
      size1 = new Size(225, 51);
      Size size59 = size1;
      autoCaptchaEnable2.Size = size59;
      this.picAutoCaptchaEnable.TabIndex = 76;
      this.picAutoCaptchaEnable.TabStop = false;
      this.picAutoCaptchaEnable.Visible = false;
      this.picBanner.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.picBanner.Cursor = Cursors.Hand;
      this.picBanner.Image = (Image) componentResourceManager.GetObject("picBanner.Image");
      PictureBox picBanner1 = this.picBanner;
      point1 = new Point(743, 642);
      Point point51 = point1;
      picBanner1.Location = point51;
      this.picBanner.Name = "picBanner";
      PictureBox picBanner2 = this.picBanner;
      size1 = new Size(232, 77);
      Size size60 = size1;
      picBanner2.Size = size60;
      this.picBanner.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picBanner.TabIndex = 78;
      this.picBanner.TabStop = false;
      this.boxOptions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.boxOptions.Controls.Add((Control) this.btnSQL);
      this.boxOptions.Controls.Add((Control) this.chReport_8);
      this.boxOptions.Controls.Add((Control) this.chReport_7);
      this.boxOptions.Controls.Add((Control) this.chReport_5);
      this.boxOptions.Controls.Add((Control) this.chReport_4);
      this.boxOptions.Controls.Add((Control) this.chReport_6);
      this.boxOptions.Controls.Add((Control) this.chReport_2);
      this.boxOptions.Controls.Add((Control) this.chReport_1);
      this.boxOptions.Controls.Add((Control) this.chReport_3);
      GroupBox boxOptions1 = this.boxOptions;
      point1 = new Point(745, 474);
      Point point52 = point1;
      boxOptions1.Location = point52;
      this.boxOptions.Name = "boxOptions";
      GroupBox boxOptions2 = this.boxOptions;
      size1 = new Size(222, 166);
      Size size61 = size1;
      boxOptions2.Size = size61;
      this.boxOptions.TabIndex = 81;
      this.boxOptions.TabStop = false;
      this.boxOptions.Text = "Report:";
      this.btnSQL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnSQL.BackColor = Color.WhiteSmoke;
      this.btnSQL.FlatStyle = FlatStyle.Flat;
      this.btnSQL.ForeColor = Color.Gray;
      this.btnSQL.Image = (Image) componentResourceManager.GetObject("btnSQL.Image");
      Button btnSql1 = this.btnSQL;
      point1 = new Point(146, 13);
      Point point53 = point1;
      btnSql1.Location = point53;
      this.btnSQL.Name = "btnSQL";
      Button btnSql2 = this.btnSQL;
      size1 = new Size(70, 40);
      Size size62 = size1;
      btnSql2.Size = size62;
      this.btnSQL.TabIndex = 101;
      this.btnSQL.TabStop = false;
      this.btnSQL.UseVisualStyleBackColor = false;
      CheckBox chReport8_1 = this.chReport_8;
      point1 = new Point(12, 126);
      Point point54 = point1;
      chReport8_1.Location = point54;
      this.chReport_8.Name = "chReport_8";
      CheckBox chReport8_2 = this.chReport_8;
      size1 = new Size(204, 17);
      Size size63 = size1;
      chReport8_2.Size = size63;
      this.chReport_8.TabIndex = 8;
      this.chReport_8.TabStop = false;
      this.chReport_8.Tag = (object) "8";
      this.chReport_8.Text = "Message from AutoCAPTCHA";
      this.chReport_8.UseVisualStyleBackColor = true;
      CheckBox chReport7_1 = this.chReport_7;
      point1 = new Point(12, 144);
      Point point55 = point1;
      chReport7_1.Location = point55;
      this.chReport_7.Name = "chReport_7";
      CheckBox chReport7_2 = this.chReport_7;
      size1 = new Size(180, 17);
      Size size64 = size1;
      chReport7_2.Size = size64;
      this.chReport_7.TabIndex = 7;
      this.chReport_7.TabStop = false;
      this.chReport_7.Tag = (object) "7";
      this.chReport_7.Text = "Registered - yyyyy@xxxx.ru";
      this.chReport_7.UseVisualStyleBackColor = true;
      this.chReport_5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      CheckBox chReport5_1 = this.chReport_5;
      point1 = new Point(12, 18);
      Point point56 = point1;
      chReport5_1.Location = point56;
      this.chReport_5.Name = "chReport_5";
      CheckBox chReport5_2 = this.chReport_5;
      size1 = new Size(128, 17);
      Size size65 = size1;
      chReport5_2.Size = size65;
      this.chReport_5.TabIndex = 5;
      this.chReport_5.TabStop = false;
      this.chReport_5.Tag = (object) "5";
      this.chReport_5.Text = "Socket Response";
      this.chReport_5.UseVisualStyleBackColor = true;
      CheckBox chReport4_1 = this.chReport_4;
      point1 = new Point(12, 90);
      Point point57 = point1;
      chReport4_1.Location = point57;
      this.chReport_4.Name = "chReport_4";
      CheckBox chReport4_2 = this.chReport_4;
      size1 = new Size(204, 17);
      Size size66 = size1;
      chReport4_2.Size = size66;
      this.chReport_4.TabIndex = 4;
      this.chReport_4.TabStop = false;
      this.chReport_4.Tag = (object) "4";
      this.chReport_4.Text = "ERROR_NO_SLOT_AVAILABLE";
      this.chReport_4.UseVisualStyleBackColor = true;
      CheckBox chReport6_1 = this.chReport_6;
      point1 = new Point(12, 108);
      Point point58 = point1;
      chReport6_1.Location = point58;
      this.chReport_6.Name = "chReport_6";
      CheckBox chReport6_2 = this.chReport_6;
      size1 = new Size(204, 17);
      Size size67 = size1;
      chReport6_2.Size = size67;
      this.chReport_6.TabIndex = 2;
      this.chReport_6.TabStop = false;
      this.chReport_6.Tag = (object) "6";
      this.chReport_6.Text = "Connection error";
      this.chReport_6.UseVisualStyleBackColor = true;
      CheckBox chReport2_1 = this.chReport_2;
      point1 = new Point(12, 72);
      Point point59 = point1;
      chReport2_1.Location = point59;
      this.chReport_2.Name = "chReport_2";
      CheckBox chReport2_2 = this.chReport_2;
      size1 = new Size(204, 17);
      Size size68 = size1;
      chReport2_2.Size = size68;
      this.chReport_2.TabIndex = 1;
      this.chReport_2.TabStop = false;
      this.chReport_2.Tag = (object) "2";
      this.chReport_2.Text = "Captcha solved = XXXXXX";
      this.chReport_2.UseVisualStyleBackColor = true;
      CheckBox chReport1_1 = this.chReport_1;
      point1 = new Point(12, 54);
      Point point60 = point1;
      chReport1_1.Location = point60;
      this.chReport_1.Name = "chReport_1";
      CheckBox chReport1_2 = this.chReport_1;
      size1 = new Size(139, 17);
      Size size69 = size1;
      chReport1_2.Size = size69;
      this.chReport_1.TabIndex = 0;
      this.chReport_1.TabStop = false;
      this.chReport_1.Tag = (object) "1";
      this.chReport_1.Text = "Thread X send captcha";
      this.chReport_1.UseVisualStyleBackColor = true;
      CheckBox chReport3_1 = this.chReport_3;
      point1 = new Point(12, 36);
      Point point61 = point1;
      chReport3_1.Location = point61;
      this.chReport_3.Name = "chReport_3";
      CheckBox chReport3_2 = this.chReport_3;
      size1 = new Size(110, 17);
      Size size70 = size1;
      chReport3_2.Size = size70;
      this.chReport_3.TabIndex = 3;
      this.chReport_3.TabStop = false;
      this.chReport_3.Tag = (object) "3";
      this.chReport_3.Text = "Thread X - STOP";
      this.chReport_3.UseVisualStyleBackColor = true;
      this.Button6.BackColor = Color.FromArgb(224, 224, 224);
      this.Button6.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button button6_1 = this.Button6;
      point1 = new Point(488, 658);
      Point point62 = point1;
      button6_1.Location = point62;
      this.Button6.Name = "Button6";
      Button button6_2 = this.Button6;
      size1 = new Size(100, 34);
      Size size71 = size1;
      button6_2.Size = size71;
      this.Button6.TabIndex = 100;
      this.Button6.Text = "test";
      this.Button6.UseVisualStyleBackColor = false;
      this.Button6.Visible = false;
      this.boxCounter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.boxCounter.Controls.Add((Control) this.lbl12);
      this.boxCounter.Controls.Add((Control) this.INFO_12);
      this.boxCounter.Controls.Add((Control) this.INFO_13);
      this.boxCounter.Controls.Add((Control) this.lbl13);
      this.boxCounter.Controls.Add((Control) this.picNoSlot);
      this.boxCounter.Controls.Add((Control) this.INFO_7);
      this.boxCounter.Controls.Add((Control) this.lbl7);
      this.boxCounter.Controls.Add((Control) this.INFO_3);
      this.boxCounter.Controls.Add((Control) this.lbl3);
      this.boxCounter.Controls.Add((Control) this.INFO_11);
      this.boxCounter.Controls.Add((Control) this.INFO_10);
      this.boxCounter.Controls.Add((Control) this.INFO_8);
      this.boxCounter.Controls.Add((Control) this.INFO_9);
      this.boxCounter.Controls.Add((Control) this.INFO_4);
      this.boxCounter.Controls.Add((Control) this.INFO_6);
      this.boxCounter.Controls.Add((Control) this.INFO_5);
      this.boxCounter.Controls.Add((Control) this.INFO_2);
      this.boxCounter.Controls.Add((Control) this.INFO_1);
      this.boxCounter.Controls.Add((Control) this.lbl11);
      this.boxCounter.Controls.Add((Control) this.lbl10);
      this.boxCounter.Controls.Add((Control) this.lbl9);
      this.boxCounter.Controls.Add((Control) this.lbl5);
      this.boxCounter.Controls.Add((Control) this.lbl2);
      this.boxCounter.Controls.Add((Control) this.lbl4);
      this.boxCounter.Controls.Add((Control) this.lbl6);
      this.boxCounter.Controls.Add((Control) this.lbl1);
      this.boxCounter.Controls.Add((Control) this.lbl8);
      this.boxCounter.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.boxCounter.ForeColor = Color.Black;
      GroupBox boxCounter1 = this.boxCounter;
      point1 = new Point(856, 152);
      Point point63 = point1;
      boxCounter1.Location = point63;
      this.boxCounter.Name = "boxCounter";
      GroupBox boxCounter2 = this.boxCounter;
      size1 = new Size(118, 258);
      Size size72 = size1;
      boxCounter2.Size = size72;
      this.boxCounter.TabIndex = 82;
      this.boxCounter.TabStop = false;
      this.boxCounter.Text = "ручной ввод";
      this.lbl12.AutoSize = true;
      this.lbl12.Enabled = false;
      this.lbl12.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl12.ForeColor = Color.Black;
      Label lbl12_1 = this.lbl12;
      point1 = new Point(12, 217);
      Point point64 = point1;
      lbl12_1.Location = point64;
      this.lbl12.Name = "lbl12";
      Label lbl12_2 = this.lbl12;
      size1 = new Size(47, 14);
      Size size73 = size1;
      lbl12_2.Size = size73;
      this.lbl12.TabIndex = 106;
      this.lbl12.Text = "NoSlot:";
      this.lbl12.TextAlign = ContentAlignment.MiddleRight;
      this.INFO_12.Enabled = false;
      this.INFO_12.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.INFO_12.ForeColor = Color.Black;
      Label info12_1 = this.INFO_12;
      point1 = new Point(58, 217);
      Point point65 = point1;
      info12_1.Location = point65;
      this.INFO_12.Name = "INFO_12";
      Label info12_2 = this.INFO_12;
      size1 = new Size(56, 14);
      Size size74 = size1;
      info12_2.Size = size74;
      this.INFO_12.TabIndex = 105;
      this.INFO_12.Text = "0";
      this.INFO_12.TextAlign = ContentAlignment.BottomCenter;
      this.INFO_13.Enabled = false;
      this.INFO_13.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.INFO_13.ForeColor = Color.Black;
      Label info13_1 = this.INFO_13;
      point1 = new Point(58, 235);
      Point point66 = point1;
      info13_1.Location = point66;
      this.INFO_13.Name = "INFO_13";
      Label info13_2 = this.INFO_13;
      size1 = new Size(56, 14);
      Size size75 = size1;
      info13_2.Size = size75;
      this.INFO_13.TabIndex = 104;
      this.INFO_13.Text = "0";
      this.INFO_13.TextAlign = ContentAlignment.BottomCenter;
      this.lbl13.AutoSize = true;
      this.lbl13.Enabled = false;
      this.lbl13.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl13.ForeColor = Color.Black;
      Label lbl13_1 = this.lbl13;
      point1 = new Point(14, 235);
      Point point67 = point1;
      lbl13_1.Location = point67;
      this.lbl13.Name = "lbl13";
      Label lbl13_2 = this.lbl13;
      size1 = new Size(45, 14);
      Size size76 = size1;
      lbl13_2.Size = size76;
      this.lbl13.TabIndex = 104;
      this.lbl13.Text = "At Prx:";
      this.lbl13.TextAlign = ContentAlignment.MiddleRight;
      this.picNoSlot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.picNoSlot.Image = (Image) componentResourceManager.GetObject("picNoSlot.Image");
      PictureBox picNoSlot1 = this.picNoSlot;
      point1 = new Point(93, 0);
      Point point68 = point1;
      picNoSlot1.Location = point68;
      this.picNoSlot.Name = "picNoSlot";
      PictureBox picNoSlot2 = this.picNoSlot;
      size1 = new Size(16, 16);
      Size size77 = size1;
      picNoSlot2.Size = size77;
      this.picNoSlot.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picNoSlot.TabIndex = 103;
      this.picNoSlot.TabStop = false;
      this.INFO_7.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.INFO_7.ForeColor = Color.Olive;
      Label info7_1 = this.INFO_7;
      point1 = new Point(58, (int) sbyte.MaxValue);
      Point point69 = point1;
      info7_1.Location = point69;
      this.INFO_7.Name = "INFO_7";
      Label info7_2 = this.INFO_7;
      size1 = new Size(56, 14);
      Size size78 = size1;
      info7_2.Size = size78;
      this.INFO_7.TabIndex = 101;
      this.INFO_7.Text = "0";
      this.INFO_7.TextAlign = ContentAlignment.BottomCenter;
      this.lbl7.AutoSize = true;
      this.lbl7.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl7.ForeColor = Color.Black;
      Label lbl7_1 = this.lbl7;
      point1 = new Point(25, (int) sbyte.MaxValue);
      Point point70 = point1;
      lbl7_1.Location = point70;
      this.lbl7.Name = "lbl7";
      Label lbl7_2 = this.lbl7;
      size1 = new Size(34, 14);
      Size size79 = size1;
      lbl7_2.Size = size79;
      this.lbl7.TabIndex = 102;
      this.lbl7.Text = "Lost:";
      this.lbl7.TextAlign = ContentAlignment.MiddleRight;
      this.INFO_3.Enabled = false;
      this.INFO_3.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.INFO_3.ForeColor = Color.Black;
      Label info3_1 = this.INFO_3;
      point1 = new Point(58, 55);
      Point point71 = point1;
      info3_1.Location = point71;
      this.INFO_3.Name = "INFO_3";
      Label info3_2 = this.INFO_3;
      size1 = new Size(56, 14);
      Size size80 = size1;
      info3_2.Size = size80;
      this.INFO_3.TabIndex = 93;
      this.INFO_3.Text = "0";
      this.INFO_3.TextAlign = ContentAlignment.BottomCenter;
      this.lbl3.AutoSize = true;
      this.lbl3.Enabled = false;
      this.lbl3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl3.ForeColor = Color.Black;
      Label lbl3_1 = this.lbl3;
      point1 = new Point(11, 55);
      Point point72 = point1;
      lbl3_1.Location = point72;
      this.lbl3.Name = "lbl3";
      Label lbl3_2 = this.lbl3;
      size1 = new Size(48, 14);
      Size size81 = size1;
      lbl3_2.Size = size81;
      this.lbl3.TabIndex = 84;
      this.lbl3.Text = "ERROR:";
      this.lbl3.TextAlign = ContentAlignment.MiddleRight;
      this.INFO_11.Enabled = false;
      this.INFO_11.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.INFO_11.ForeColor = Color.Black;
      Label info11_1 = this.INFO_11;
      point1 = new Point(58, 199);
      Point point73 = point1;
      info11_1.Location = point73;
      this.INFO_11.Name = "INFO_11";
      Label info11_2 = this.INFO_11;
      size1 = new Size(56, 14);
      Size size82 = size1;
      info11_2.Size = size82;
      this.INFO_11.TabIndex = 99;
      this.INFO_11.Text = "0";
      this.INFO_11.TextAlign = ContentAlignment.BottomCenter;
      this.INFO_10.Enabled = false;
      this.INFO_10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.INFO_10.ForeColor = Color.Black;
      Label info10_1 = this.INFO_10;
      point1 = new Point(54, 181);
      Point point74 = point1;
      info10_1.Location = point74;
      this.INFO_10.Name = "INFO_10";
      Label info10_2 = this.INFO_10;
      size1 = new Size(60, 14);
      Size size83 = size1;
      info10_2.Size = size83;
      this.INFO_10.TabIndex = 98;
      this.INFO_10.Text = "n/a";
      this.INFO_10.TextAlign = ContentAlignment.BottomCenter;
      this.INFO_8.Enabled = false;
      this.INFO_8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.INFO_8.ForeColor = Color.Black;
      Label info8_1 = this.INFO_8;
      point1 = new Point(54, 145);
      Point point75 = point1;
      info8_1.Location = point75;
      this.INFO_8.Name = "INFO_8";
      Label info8_2 = this.INFO_8;
      size1 = new Size(60, 14);
      Size size84 = size1;
      info8_2.Size = size84;
      this.INFO_8.TabIndex = 96;
      this.INFO_8.Text = "n/a";
      this.INFO_8.TextAlign = ContentAlignment.BottomCenter;
      this.INFO_9.Enabled = false;
      this.INFO_9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.INFO_9.ForeColor = Color.Black;
      Label info9_1 = this.INFO_9;
      point1 = new Point(54, 163);
      Point point76 = point1;
      info9_1.Location = point76;
      this.INFO_9.Name = "INFO_9";
      Label info9_2 = this.INFO_9;
      size1 = new Size(60, 14);
      Size size85 = size1;
      info9_2.Size = size85;
      this.INFO_9.TabIndex = 94;
      this.INFO_9.Text = "n/a";
      this.INFO_9.TextAlign = ContentAlignment.BottomCenter;
      this.INFO_4.Enabled = false;
      this.INFO_4.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.INFO_4.ForeColor = Color.Black;
      Label info4_1 = this.INFO_4;
      point1 = new Point(58, 73);
      Point point77 = point1;
      info4_1.Location = point77;
      this.INFO_4.Name = "INFO_4";
      Label info4_2 = this.INFO_4;
      size1 = new Size(56, 14);
      Size size86 = size1;
      info4_2.Size = size86;
      this.INFO_4.TabIndex = 92;
      this.INFO_4.Text = "0";
      this.INFO_4.TextAlign = ContentAlignment.BottomCenter;
      this.INFO_6.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.INFO_6.ForeColor = Color.FromArgb(192, 0, 0);
      Label info6_1 = this.INFO_6;
      point1 = new Point(58, 109);
      Point point78 = point1;
      info6_1.Location = point78;
      this.INFO_6.Name = "INFO_6";
      Label info6_2 = this.INFO_6;
      size1 = new Size(56, 14);
      Size size87 = size1;
      info6_2.Size = size87;
      this.INFO_6.TabIndex = 91;
      this.INFO_6.Text = "0";
      this.INFO_6.TextAlign = ContentAlignment.BottomCenter;
      this.INFO_5.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.INFO_5.ForeColor = Color.Green;
      Label info5_1 = this.INFO_5;
      point1 = new Point(58, 91);
      Point point79 = point1;
      info5_1.Location = point79;
      this.INFO_5.Name = "INFO_5";
      Label info5_2 = this.INFO_5;
      size1 = new Size(56, 14);
      Size size88 = size1;
      info5_2.Size = size88;
      this.INFO_5.TabIndex = 90;
      this.INFO_5.Text = "0";
      this.INFO_5.TextAlign = ContentAlignment.BottomCenter;
      this.INFO_2.Enabled = false;
      this.INFO_2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.INFO_2.ForeColor = Color.Black;
      Label info2_1 = this.INFO_2;
      point1 = new Point(58, 37);
      Point point80 = point1;
      info2_1.Location = point80;
      this.INFO_2.Name = "INFO_2";
      Label info2_2 = this.INFO_2;
      size1 = new Size(56, 14);
      Size size89 = size1;
      info2_2.Size = size89;
      this.INFO_2.TabIndex = 89;
      this.INFO_2.Text = "0";
      this.INFO_2.TextAlign = ContentAlignment.BottomCenter;
      this.INFO_1.Enabled = false;
      this.INFO_1.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.INFO_1.ForeColor = Color.Black;
      Label info1_1 = this.INFO_1;
      point1 = new Point(58, 19);
      Point point81 = point1;
      info1_1.Location = point81;
      this.INFO_1.Name = "INFO_1";
      Label info1_2 = this.INFO_1;
      size1 = new Size(56, 14);
      Size size90 = size1;
      info1_2.Size = size90;
      this.INFO_1.TabIndex = 88;
      this.INFO_1.Text = "0";
      this.INFO_1.TextAlign = ContentAlignment.BottomCenter;
      this.lbl11.AutoSize = true;
      this.lbl11.Enabled = false;
      this.lbl11.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl11.ForeColor = Color.Black;
      Label lbl11_1 = this.lbl11;
      point1 = new Point(14, 199);
      Point point82 = point1;
      lbl11_1.Location = point82;
      this.lbl11.Name = "lbl11";
      Label lbl11_2 = this.lbl11;
      size1 = new Size(45, 14);
      Size size91 = size1;
      lbl11_2.Size = size91;
      this.lbl11.TabIndex = 100;
      this.lbl11.Text = "IsBusy:";
      this.lbl11.TextAlign = ContentAlignment.MiddleRight;
      this.lbl10.Enabled = false;
      this.lbl10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl10.ForeColor = Color.Black;
      Label lbl10_1 = this.lbl10;
      point1 = new Point(8, 181);
      Point point83 = point1;
      lbl10_1.Location = point83;
      this.lbl10.Name = "lbl10";
      Label lbl10_2 = this.lbl10;
      size1 = new Size(51, 14);
      Size size92 = size1;
      lbl10_2.Size = size92;
      this.lbl10.TabIndex = 97;
      this.lbl10.Text = "BL_Exp:";
      this.lbl10.TextAlign = ContentAlignment.MiddleRight;
      this.lbl9.Enabled = false;
      this.lbl9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl9.ForeColor = Color.Black;
      Label lbl9_1 = this.lbl9;
      point1 = new Point(8, 163);
      Point point84 = point1;
      lbl9_1.Location = point84;
      this.lbl9.Name = "lbl9";
      Label lbl9_2 = this.lbl9;
      size1 = new Size(51, 14);
      Size size93 = size1;
      lbl9_2.Size = size93;
      this.lbl9.TabIndex = 87;
      this.lbl9.Text = "BL_Curr:";
      this.lbl9.TextAlign = ContentAlignment.MiddleRight;
      this.lbl5.AutoSize = true;
      this.lbl5.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl5.ForeColor = Color.Black;
      Label lbl5_1 = this.lbl5;
      point1 = new Point(32, 91);
      Point point85 = point1;
      lbl5_1.Location = point85;
      this.lbl5.Name = "lbl5";
      Label lbl5_2 = this.lbl5;
      size1 = new Size(27, 14);
      Size size94 = size1;
      lbl5_2.Size = size94;
      this.lbl5.TabIndex = 86;
      this.lbl5.Text = "OK:";
      this.lbl5.TextAlign = ContentAlignment.MiddleRight;
      this.lbl2.AutoSize = true;
      this.lbl2.Enabled = false;
      this.lbl2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl2.ForeColor = Color.Black;
      Label lbl2_1 = this.lbl2;
      point1 = new Point(12, 37);
      Point point86 = point1;
      lbl2_1.Location = point86;
      this.lbl2.Name = "lbl2";
      Label lbl2_2 = this.lbl2;
      size1 = new Size(47, 14);
      Size size95 = size1;
      lbl2_2.Size = size95;
      this.lbl2.TabIndex = 85;
      this.lbl2.Text = "Solved:";
      this.lbl2.TextAlign = ContentAlignment.MiddleRight;
      this.lbl4.AutoSize = true;
      this.lbl4.Enabled = false;
      this.lbl4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl4.ForeColor = Color.Black;
      Label lbl4_1 = this.lbl4;
      point1 = new Point(15, 73);
      Point point87 = point1;
      lbl4_1.Location = point87;
      this.lbl4.Name = "lbl4";
      Label lbl4_2 = this.lbl4;
      size1 = new Size(44, 14);
      Size size96 = size1;
      lbl4_2.Size = size96;
      this.lbl4.TabIndex = 83;
      this.lbl4.Text = "TLimit:";
      this.lbl4.TextAlign = ContentAlignment.MiddleRight;
      this.lbl6.AutoSize = true;
      this.lbl6.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl6.ForeColor = Color.Black;
      Label lbl6_1 = this.lbl6;
      point1 = new Point(11, 109);
      Point point88 = point1;
      lbl6_1.Location = point88;
      this.lbl6.Name = "lbl6";
      Label lbl6_2 = this.lbl6;
      size1 = new Size(48, 14);
      Size size97 = size1;
      lbl6_2.Size = size97;
      this.lbl6.TabIndex = 82;
      this.lbl6.Text = "Wrong:";
      this.lbl6.TextAlign = ContentAlignment.MiddleRight;
      this.lbl1.AutoSize = true;
      this.lbl1.Enabled = false;
      this.lbl1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl1.ForeColor = Color.Black;
      Label lbl1_1 = this.lbl1;
      point1 = new Point(8, 19);
      Point point89 = point1;
      lbl1_1.Location = point89;
      this.lbl1.Name = "lbl1";
      Label lbl1_2 = this.lbl1;
      size1 = new Size(51, 14);
      Size size98 = size1;
      lbl1_2.Size = size98;
      this.lbl1.TabIndex = 81;
      this.lbl1.Text = "Loaded:";
      this.lbl1.TextAlign = ContentAlignment.MiddleRight;
      this.lbl8.Enabled = false;
      this.lbl8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl8.ForeColor = Color.Black;
      Label lbl8_1 = this.lbl8;
      point1 = new Point(6, 145);
      Point point90 = point1;
      lbl8_1.Location = point90;
      this.lbl8.Name = "lbl8";
      Label lbl8_2 = this.lbl8;
      size1 = new Size(53, 14);
      Size size99 = size1;
      lbl8_2.Size = size99;
      this.lbl8.TabIndex = 95;
      this.lbl8.Text = "BL_Start:";
      this.lbl8.TextAlign = ContentAlignment.MiddleRight;
      this.lblBUSY.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lblBUSY.BackColor = Color.White;
      this.lblBUSY.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lblBUSY.ForeColor = Color.Red;
      Label lblBusy1 = this.lblBUSY;
      point1 = new Point(252, 160);
      Point point91 = point1;
      lblBusy1.Location = point91;
      this.lblBUSY.Name = "lblBUSY";
      Label lblBusy2 = this.lblBUSY;
      size1 = new Size(222, 131);
      Size size100 = size1;
      lblBusy2.Size = size100;
      this.lblBUSY.TabIndex = 83;
      this.lblBUSY.Text = "Идет удаление";
      this.lblBUSY.TextAlign = ContentAlignment.MiddleCenter;
      this.lblBUSY.Visible = false;
      this.SaveFileDialog1.OverwritePrompt = false;
      this.SaveFileDialog1.SupportMultiDottedExtensions = true;
      this.SaveFileDialog1.Title = "Сохранить MailList";
      this.picVOTE_CAPTCHA_3.BackColor = Color.FromArgb(0, 64, 0);
      this.picVOTE_CAPTCHA_3.BackgroundImageLayout = ImageLayout.None;
      this.picVOTE_CAPTCHA_3.Image = (Image) componentResourceManager.GetObject("picVOTE_CAPTCHA_3.Image");
      PictureBox picVoteCaptcha3_1 = this.picVOTE_CAPTCHA_3;
      point1 = new Point(14, 24);
      Point point92 = point1;
      picVoteCaptcha3_1.Location = point92;
      this.picVOTE_CAPTCHA_3.Name = "picVOTE_CAPTCHA_3";
      PictureBox picVoteCaptcha3_2 = this.picVOTE_CAPTCHA_3;
      size1 = new Size(200, 60);
      Size size101 = size1;
      picVoteCaptcha3_2.Size = size101;
      this.picVOTE_CAPTCHA_3.TabIndex = 84;
      this.picVOTE_CAPTCHA_3.TabStop = false;
      this.picVOTE_CAPTCHA_3.Visible = false;
      this.grCAPTCHA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.grCAPTCHA.Controls.Add((Control) this.picVOTE_CAPTCHA_1);
      this.grCAPTCHA.Controls.Add((Control) this.picRequestCaptcha);
      this.grCAPTCHA.Controls.Add((Control) this.picVOTE_CAPTCHA_3);
      this.grCAPTCHA.Controls.Add((Control) this.picAutoCaptchaEnable);
      this.grCAPTCHA.Controls.Add((Control) this.picVOTE_CAPTCHA_0);
      this.grCAPTCHA.Controls.Add((Control) this.picVOTE_CAPTCHA_2);
      this.grCAPTCHA.Controls.Add((Control) this.picVOTE_CAPTCHA_4);
      GroupBox grCaptcha1 = this.grCAPTCHA;
      point1 = new Point(742, 54);
      Point point93 = point1;
      grCaptcha1.Location = point93;
      this.grCAPTCHA.Name = "grCAPTCHA";
      GroupBox grCaptcha2 = this.grCAPTCHA;
      size1 = new Size(232, 98);
      Size size102 = size1;
      grCaptcha2.Size = size102;
      this.grCAPTCHA.TabIndex = 85;
      this.grCAPTCHA.TabStop = false;
      this.grCAPTCHA.Text = "captcha";
      this.picVOTE_CAPTCHA_1.BackColor = Color.FromArgb(0, 64, 0);
      this.picVOTE_CAPTCHA_1.BorderStyle = BorderStyle.FixedSingle;
      this.picVOTE_CAPTCHA_1.Image = (Image) componentResourceManager.GetObject("picVOTE_CAPTCHA_1.Image");
      PictureBox picVoteCaptcha1_1 = this.picVOTE_CAPTCHA_1;
      point1 = new Point(35, 14);
      Point point94 = point1;
      picVoteCaptcha1_1.Location = point94;
      this.picVOTE_CAPTCHA_1.Name = "picVOTE_CAPTCHA_1";
      PictureBox picVoteCaptcha1_2 = this.picVOTE_CAPTCHA_1;
      size1 = new Size(160, 80);
      Size size103 = size1;
      picVoteCaptcha1_2.Size = size103;
      this.picVOTE_CAPTCHA_1.TabIndex = 95;
      this.picVOTE_CAPTCHA_1.TabStop = false;
      this.picVOTE_CAPTCHA_1.Visible = false;
      this.picRequestCaptcha.Image = (Image) componentResourceManager.GetObject("picRequestCaptcha.Image");
      PictureBox picRequestCaptcha1 = this.picRequestCaptcha;
      point1 = new Point(88, 28);
      Point point95 = point1;
      picRequestCaptcha1.Location = point95;
      this.picRequestCaptcha.Name = "picRequestCaptcha";
      PictureBox picRequestCaptcha2 = this.picRequestCaptcha;
      size1 = new Size(51, 51);
      Size size104 = size1;
      picRequestCaptcha2.Size = size104;
      this.picRequestCaptcha.TabIndex = 87;
      this.picRequestCaptcha.TabStop = false;
      this.picRequestCaptcha.Visible = false;
      this.picVOTE_CAPTCHA_2.BackColor = Color.FromArgb(0, 64, 0);
      this.picVOTE_CAPTCHA_2.BackgroundImageLayout = ImageLayout.None;
      this.picVOTE_CAPTCHA_2.Image = (Image) componentResourceManager.GetObject("picVOTE_CAPTCHA_2.Image");
      PictureBox picVoteCaptcha2_1 = this.picVOTE_CAPTCHA_2;
      point1 = new Point(14, 24);
      Point point96 = point1;
      picVoteCaptcha2_1.Location = point96;
      this.picVOTE_CAPTCHA_2.Name = "picVOTE_CAPTCHA_2";
      PictureBox picVoteCaptcha2_2 = this.picVOTE_CAPTCHA_2;
      size1 = new Size(200, 60);
      Size size105 = size1;
      picVoteCaptcha2_2.Size = size105;
      this.picVOTE_CAPTCHA_2.TabIndex = 96;
      this.picVOTE_CAPTCHA_2.TabStop = false;
      this.picVOTE_CAPTCHA_2.Visible = false;
      this.picVOTE_CAPTCHA_4.BackColor = Color.FromArgb(0, 64, 0);
      this.picVOTE_CAPTCHA_4.BorderStyle = BorderStyle.FixedSingle;
      this.picVOTE_CAPTCHA_4.Image = (Image) componentResourceManager.GetObject("picVOTE_CAPTCHA_4.Image");
      PictureBox picVoteCaptcha4_1 = this.picVOTE_CAPTCHA_4;
      point1 = new Point(24, 20);
      Point point97 = point1;
      picVoteCaptcha4_1.Location = point97;
      this.picVOTE_CAPTCHA_4.Name = "picVOTE_CAPTCHA_4";
      PictureBox picVoteCaptcha4_2 = this.picVOTE_CAPTCHA_4;
      size1 = new Size(180, 70);
      Size size106 = size1;
      picVoteCaptcha4_2.Size = size106;
      this.picVOTE_CAPTCHA_4.TabIndex = 87;
      this.picVOTE_CAPTCHA_4.TabStop = false;
      this.picVOTE_CAPTCHA_4.Visible = false;
      this.picCollection3.BackColor = Color.FromArgb(0, 64, 0);
      this.picCollection3.BorderStyle = BorderStyle.FixedSingle;
      this.picCollection3.Enabled = false;
      this.picCollection3.Image = (Image) componentResourceManager.GetObject("picCollection3.Image");
      PictureBox picCollection3_1 = this.picCollection3;
      point1 = new Point(512, 233);
      Point point98 = point1;
      picCollection3_1.Location = point98;
      this.picCollection3.Name = "picCollection3";
      PictureBox picCollection3_2 = this.picCollection3;
      size1 = new Size(200, 60);
      Size size107 = size1;
      picCollection3_2.Size = size107;
      this.picCollection3.TabIndex = 86;
      this.picCollection3.TabStop = false;
      this.picCollection3.Visible = false;
      this.picCollection4.BackColor = Color.FromArgb(0, 64, 0);
      this.picCollection4.BorderStyle = BorderStyle.FixedSingle;
      this.picCollection4.Enabled = false;
      this.picCollection4.Image = (Image) componentResourceManager.GetObject("picCollection4.Image");
      PictureBox picCollection4_1 = this.picCollection4;
      point1 = new Point(512, 297);
      Point point99 = point1;
      picCollection4_1.Location = point99;
      this.picCollection4.Name = "picCollection4";
      PictureBox picCollection4_2 = this.picCollection4;
      size1 = new Size(180, 70);
      Size size108 = size1;
      picCollection4_2.Size = size108;
      this.picCollection4.TabIndex = 88;
      this.picCollection4.TabStop = false;
      this.picCollection4.Visible = false;
      this.tmrLoadProgram.Interval = 33;
      this.picWait.BackColor = Color.White;
      this.picWait.Image = (Image) componentResourceManager.GetObject("picWait.Image");
      PictureBox picWait1 = this.picWait;
      point1 = new Point(324, 96);
      Point point100 = point1;
      picWait1.Location = point100;
      this.picWait.Name = "picWait";
      PictureBox picWait2 = this.picWait;
      size1 = new Size(128, 128);
      Size size109 = size1;
      picWait2.Size = size109;
      this.picWait.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picWait.TabIndex = 89;
      this.picWait.TabStop = false;
      this.tmrInfo.Interval = 1000;
      this.tmrMailDownload.Interval = 33;
      this.btnOpenMail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnOpenMail.BackColor = Color.FromArgb(224, 224, 224);
      this.btnOpenMail.Image = (Image) componentResourceManager.GetObject("btnOpenMail.Image");
      this.btnOpenMail.ImageAlign = ContentAlignment.MiddleLeft;
      Button btnOpenMail1 = this.btnOpenMail;
      point1 = new Point(912, 439);
      Point point101 = point1;
      btnOpenMail1.Location = point101;
      this.btnOpenMail.Name = "btnOpenMail";
      Button btnOpenMail2 = this.btnOpenMail;
      size1 = new Size(62, 22);
      Size size110 = size1;
      btnOpenMail2.Size = size110;
      this.btnOpenMail.TabIndex = 90;
      this.btnOpenMail.TabStop = false;
      this.btnOpenMail.Text = "open ";
      this.btnOpenMail.TextAlign = ContentAlignment.MiddleRight;
      this.btnOpenMail.UseVisualStyleBackColor = false;
      this.btnOpenProxy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnOpenProxy.BackColor = Color.FromArgb(224, 224, 224);
      this.btnOpenProxy.Image = (Image) componentResourceManager.GetObject("btnOpenProxy.Image");
      this.btnOpenProxy.ImageAlign = ContentAlignment.BottomRight;
      Button btnOpenProxy1 = this.btnOpenProxy;
      point1 = new Point(826, 211);
      Point point102 = point1;
      btnOpenProxy1.Location = point102;
      this.btnOpenProxy.Name = "btnOpenProxy";
      Button btnOpenProxy2 = this.btnOpenProxy;
      size1 = new Size(26, 25);
      Size size111 = size1;
      btnOpenProxy2.Size = size111;
      this.btnOpenProxy.TabIndex = 91;
      this.btnOpenProxy.TabStop = false;
      this.btnOpenProxy.TextAlign = ContentAlignment.MiddleRight;
      this.btnOpenProxy.UseVisualStyleBackColor = false;
      this.IL_16.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("IL_16.ImageStream");
      this.IL_16.TransparentColor = Color.Transparent;
      this.IL_16.Images.SetKeyName(0, "ledorange_9758.png");
      this.IL_16.Images.SetKeyName(1, "ledgreen_2454.png");
      this.IL_16.Images.SetKeyName(2, "ledred_9017.png");
      this.IL_16.Images.SetKeyName(3, "ledyellow_9814.png");
      this.tmrTXT.Enabled = true;
      this.tmrNetworkReboot.Interval = 500;
      this.tmrVPNReboot.Interval = 500;
      this.chCheckMail_WebFace.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.chCheckMail_WebFace.CheckAlign = ContentAlignment.MiddleRight;
      CheckBox checkMailWebFace1 = this.chCheckMail_WebFace;
      point1 = new Point(854, 34);
      Point point103 = point1;
      checkMailWebFace1.Location = point103;
      this.chCheckMail_WebFace.Name = "chCheckMail_WebFace";
      CheckBox checkMailWebFace2 = this.chCheckMail_WebFace;
      size1 = new Size(117, 17);
      Size size112 = size1;
      checkMailWebFace2.Size = size112;
      this.chCheckMail_WebFace.TabIndex = 93;
      this.chCheckMail_WebFace.TabStop = false;
      this.chCheckMail_WebFace.Tag = (object) "1";
      this.chCheckMail_WebFace.Text = "Сheck mailboxes";
      this.chCheckMail_WebFace.TextAlign = ContentAlignment.MiddleCenter;
      this.chCheckMail_WebFace.UseVisualStyleBackColor = true;
      this.picCollection1.BackColor = Color.FromArgb(0, 64, 0);
      this.picCollection1.BorderStyle = BorderStyle.FixedSingle;
      this.picCollection1.Image = (Image) componentResourceManager.GetObject("picCollection1.Image");
      PictureBox picCollection1_1 = this.picCollection1;
      point1 = new Point(512, 58);
      Point point104 = point1;
      picCollection1_1.Location = point104;
      this.picCollection1.Name = "picCollection1";
      PictureBox picCollection1_2 = this.picCollection1;
      size1 = new Size(160, 80);
      Size size113 = size1;
      picCollection1_2.Size = size113;
      this.picCollection1.TabIndex = 94;
      this.picCollection1.TabStop = false;
      this.picCollection1.Visible = false;
      this.picCollection2.BackColor = Color.FromArgb(0, 64, 0);
      this.picCollection2.BorderStyle = BorderStyle.FixedSingle;
      this.picCollection2.Enabled = false;
      this.picCollection2.Image = (Image) componentResourceManager.GetObject("picCollection2.Image");
      PictureBox picCollection2_1 = this.picCollection2;
      point1 = new Point(512, 143);
      Point point105 = point1;
      picCollection2_1.Location = point105;
      this.picCollection2.Name = "picCollection2";
      PictureBox picCollection2_2 = this.picCollection2;
      size1 = new Size(200, 60);
      Size size114 = size1;
      picCollection2_2.Size = size114;
      this.picCollection2.TabIndex = 95;
      this.picCollection2.TabStop = false;
      this.picCollection2.Visible = false;
      this.btnSaveLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnSaveLog.BackColor = Color.White;
      this.btnSaveLog.FlatStyle = FlatStyle.Popup;
      this.btnSaveLog.Image = (Image) componentResourceManager.GetObject("btnSaveLog.Image");
      this.btnSaveLog.ImageAlign = ContentAlignment.BottomRight;
      Button btnSaveLog1 = this.btnSaveLog;
      point1 = new Point(439, 472);
      Point point106 = point1;
      btnSaveLog1.Location = point106;
      this.btnSaveLog.Name = "btnSaveLog";
      Button btnSaveLog2 = this.btnSaveLog;
      size1 = new Size(24, 24);
      Size size115 = size1;
      btnSaveLog2.Size = size115;
      this.btnSaveLog.TabIndex = 96;
      this.btnSaveLog.TabStop = false;
      this.btnSaveLog.TextAlign = ContentAlignment.MiddleRight;
      this.btnSaveLog.UseVisualStyleBackColor = false;
      this.pbGenLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.pbGenLogin.ForeColor = Color.Green;
      ProgressBar pbGenLogin1 = this.pbGenLogin;
      point1 = new Point(2, 744);
      Point point107 = point1;
      pbGenLogin1.Location = point107;
      this.pbGenLogin.Name = "pbGenLogin";
      ProgressBar pbGenLogin2 = this.pbGenLogin;
      size1 = new Size(972, 10);
      Size size116 = size1;
      pbGenLogin2.Size = size116;
      this.pbGenLogin.TabIndex = 171;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.WhiteSmoke;
      size1 = new Size(977, 783);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.pbGenLogin);
      this.Controls.Add((Control) this.Button6);
      this.Controls.Add((Control) this.btnSaveLog);
      this.Controls.Add((Control) this.picCollection2);
      this.Controls.Add((Control) this.picCollection1);
      this.Controls.Add((Control) this.chCheckMail_WebFace);
      this.Controls.Add((Control) this.btnOpenProxy);
      this.Controls.Add((Control) this.btnOpenMail);
      this.Controls.Add((Control) this.picWait);
      this.Controls.Add((Control) this.picCollection4);
      this.Controls.Add((Control) this.picCollection3);
      this.Controls.Add((Control) this.grCAPTCHA);
      this.Controls.Add((Control) this.lblBUSY);
      this.Controls.Add((Control) this.boxCounter);
      this.Controls.Add((Control) this.boxOptions);
      this.Controls.Add((Control) this.picLine_3);
      this.Controls.Add((Control) this.picLine_2);
      this.Controls.Add((Control) this.StatusBar);
      this.Controls.Add((Control) this.lblActionInSelect);
      this.Controls.Add((Control) this.btmAbout);
      this.Controls.Add((Control) this.txtMon);
      this.Controls.Add((Control) this.chAutoUpdate);
      this.Controls.Add((Control) this.btmSaveList);
      this.Controls.Add((Control) this.grAccountEdit);
      this.Controls.Add((Control) this.lblMailCountAll);
      this.Controls.Add((Control) this.lblMailCountCur);
      this.Controls.Add((Control) this.chAllMail);
      this.Controls.Add((Control) this.btmLoadMail);
      this.Controls.Add((Control) this.lblProxy);
      this.Controls.Add((Control) this.chProxy);
      this.Controls.Add((Control) this.chAutoCaptcha);
      this.Controls.Add((Control) this.btmGenMailOptions);
      this.Controls.Add((Control) this.btmGlobalOptions);
      this.Controls.Add((Control) this.picCollection0);
      this.Controls.Add((Control) this.txtCurrentMail);
      this.Controls.Add((Control) this.txtCaptcha);
      this.Controls.Add((Control) this.LV_Dostupno);
      this.Controls.Add((Control) this.LV);
      this.Controls.Add((Control) this.cmbThread);
      this.Controls.Add((Control) this.btmStart);
      this.Controls.Add((Control) this.picBanner);
      this.Controls.Add((Control) this.Label2);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.ForeColor = Color.Black;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      size1 = new Size(993, 821);
      this.MinimumSize = size1;
      this.Name = nameof (frmMain);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Mailbox@Reg";
      ((ISupportInitialize) this.picVOTE_CAPTCHA_0).EndInit();
      ((ISupportInitialize) this.picCollection0).EndInit();
      this.grAccountEdit.ResumeLayout(false);
      this.grAccountEdit.PerformLayout();
      this.gbAccSell_5.ResumeLayout(false);
      this.gbAccSell_5.PerformLayout();
      this.gbAccSell_3.ResumeLayout(false);
      this.gbAccSell_3.PerformLayout();
      this.gbAccSell_4.ResumeLayout(false);
      this.gbAccSell_4.PerformLayout();
      this.gbAccSell_2.ResumeLayout(false);
      this.gbAccSell_2.PerformLayout();
      this.gbAccSell_1.ResumeLayout(false);
      this.gbAccSell_1.PerformLayout();
      this.gbAccSell_6.ResumeLayout(false);
      this.gbAccSell_6.PerformLayout();
      this.StatusBar.ResumeLayout(false);
      this.StatusBar.PerformLayout();
      ((ISupportInitialize) this.picLine_2).EndInit();
      ((ISupportInitialize) this.picLine_3).EndInit();
      ((ISupportInitialize) this.picAutoCaptchaEnable).EndInit();
      ((ISupportInitialize) this.picBanner).EndInit();
      this.boxOptions.ResumeLayout(false);
      this.boxCounter.ResumeLayout(false);
      this.boxCounter.PerformLayout();
      ((ISupportInitialize) this.picNoSlot).EndInit();
      ((ISupportInitialize) this.picVOTE_CAPTCHA_3).EndInit();
      this.grCAPTCHA.ResumeLayout(false);
      ((ISupportInitialize) this.picVOTE_CAPTCHA_1).EndInit();
      ((ISupportInitialize) this.picRequestCaptcha).EndInit();
      ((ISupportInitialize) this.picVOTE_CAPTCHA_2).EndInit();
      ((ISupportInitialize) this.picVOTE_CAPTCHA_4).EndInit();
      ((ISupportInitialize) this.picCollection3).EndInit();
      ((ISupportInitialize) this.picCollection4).EndInit();
      ((ISupportInitialize) this.picWait).EndInit();
      ((ISupportInitialize) this.picCollection1).EndInit();
      ((ISupportInitialize) this.picCollection2).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button btmStart
    {
      get
      {
        return this._btmStart;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btmStart_Click);
        if (this._btmStart != null)
          this._btmStart.Click -= eventHandler;
        this._btmStart = value;
        if (this._btmStart == null)
          return;
        this._btmStart.Click += eventHandler;
      }
    }

    internal virtual PictureBox picVOTE_CAPTCHA_0
    {
      get
      {
        return this._picVOTE_CAPTCHA_0;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picVOTE_CAPTCHA_0 = value;
      }
    }

    internal virtual ComboBox cmbThread
    {
      get
      {
        return this._cmbThread;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbThread_SelectedIndexChanged);
        if (this._cmbThread != null)
          this._cmbThread.SelectedIndexChanged -= eventHandler;
        this._cmbThread = value;
        if (this._cmbThread == null)
          return;
        this._cmbThread.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer tmrConnect
    {
      get
      {
        return this._tmrConnect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrConnect_Tick);
        if (this._tmrConnect != null)
          this._tmrConnect.Tick -= eventHandler;
        this._tmrConnect = value;
        if (this._tmrConnect == null)
          return;
        this._tmrConnect.Tick += eventHandler;
      }
    }

    internal virtual ListView LV
    {
      get
      {
        return this._LV;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ColumnWidthChangedEventHandler changedEventHandler1 = new ColumnWidthChangedEventHandler(this.LV_ColumnWidthChanged);
        ListViewItemSelectionChangedEventHandler changedEventHandler2 = new ListViewItemSelectionChangedEventHandler(this.LV_ItemSelectionChanged);
        ColumnClickEventHandler clickEventHandler = new ColumnClickEventHandler(this.LV_ColumnClick);
        EventHandler eventHandler1 = new EventHandler(this.LV_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.LV_HandleCreated);
        if (this._LV != null)
        {
          this._LV.ColumnWidthChanged -= changedEventHandler1;
          this._LV.ItemSelectionChanged -= changedEventHandler2;
          this._LV.ColumnClick -= clickEventHandler;
          this._LV.SelectedIndexChanged -= eventHandler1;
          this._LV.HandleCreated -= eventHandler2;
        }
        this._LV = value;
        if (this._LV == null)
          return;
        this._LV.ColumnWidthChanged += changedEventHandler1;
        this._LV.ItemSelectionChanged += changedEventHandler2;
        this._LV.ColumnClick += clickEventHandler;
        this._LV.SelectedIndexChanged += eventHandler1;
        this._LV.HandleCreated += eventHandler2;
      }
    }

    internal virtual ColumnHeader ColumnHeader1
    {
      get
      {
        return this._ColumnHeader1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader1 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader2
    {
      get
      {
        return this._ColumnHeader2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader2 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader3
    {
      get
      {
        return this._ColumnHeader3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader3 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader4
    {
      get
      {
        return this._ColumnHeader4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader4 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader5
    {
      get
      {
        return this._ColumnHeader5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader5 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader6
    {
      get
      {
        return this._ColumnHeader6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader6 = value;
      }
    }

    internal virtual ImageList IL_LV
    {
      get
      {
        return this._IL_LV;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._IL_LV = value;
      }
    }

    internal virtual ListView LV_Dostupno
    {
      get
      {
        return this._LV_Dostupno;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LV_Dostupno_SelectedIndexChanged);
        ListViewItemSelectionChangedEventHandler changedEventHandler = new ListViewItemSelectionChangedEventHandler(this.LV_Dostupno_ItemSelectionChanged);
        if (this._LV_Dostupno != null)
        {
          this._LV_Dostupno.SelectedIndexChanged -= eventHandler;
          this._LV_Dostupno.ItemSelectionChanged -= changedEventHandler;
        }
        this._LV_Dostupno = value;
        if (this._LV_Dostupno == null)
          return;
        this._LV_Dostupno.SelectedIndexChanged += eventHandler;
        this._LV_Dostupno.ItemSelectionChanged += changedEventHandler;
      }
    }

    internal virtual ColumnHeader ColumnHeader16
    {
      get
      {
        return this._ColumnHeader16;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader16 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader22
    {
      get
      {
        return this._ColumnHeader22;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader22 = value;
      }
    }

    internal virtual TextBox txtCaptcha
    {
      get
      {
        return this._txtCaptcha;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtCaptcha_KeyUp);
        EventHandler eventHandler = new EventHandler(this.txtCaptcha_TextChanged);
        if (this._txtCaptcha != null)
        {
          this._txtCaptcha.KeyUp -= keyEventHandler;
          this._txtCaptcha.TextChanged -= eventHandler;
        }
        this._txtCaptcha = value;
        if (this._txtCaptcha == null)
          return;
        this._txtCaptcha.KeyUp += keyEventHandler;
        this._txtCaptcha.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtCurrentMail
    {
      get
      {
        return this._txtCurrentMail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtCurrentMail_KeyUp);
        if (this._txtCurrentMail != null)
          this._txtCurrentMail.KeyUp -= keyEventHandler;
        this._txtCurrentMail = value;
        if (this._txtCurrentMail == null)
          return;
        this._txtCurrentMail.KeyUp += keyEventHandler;
      }
    }

    internal virtual PictureBox picCollection0
    {
      get
      {
        return this._picCollection0;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picCollection0 = value;
      }
    }

    internal virtual Label Label2
    {
      get
      {
        return this._Label2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Label2_Click);
        if (this._Label2 != null)
          this._Label2.Click -= eventHandler;
        this._Label2 = value;
        if (this._Label2 == null)
          return;
        this._Label2.Click += eventHandler;
      }
    }

    internal virtual Button btmGlobalOptions
    {
      get
      {
        return this._btmGlobalOptions;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btmGlobalOptions_Click);
        if (this._btmGlobalOptions != null)
          this._btmGlobalOptions.Click -= eventHandler;
        this._btmGlobalOptions = value;
        if (this._btmGlobalOptions == null)
          return;
        this._btmGlobalOptions.Click += eventHandler;
      }
    }

    internal virtual Button btmGenMailOptions
    {
      get
      {
        return this._btmGenMailOptions;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btmGenMailOptions_Click);
        if (this._btmGenMailOptions != null)
          this._btmGenMailOptions.Click -= eventHandler;
        this._btmGenMailOptions = value;
        if (this._btmGenMailOptions == null)
          return;
        this._btmGenMailOptions.Click += eventHandler;
      }
    }

    internal virtual CheckBox chAutoCaptcha
    {
      get
      {
        return this._chAutoCaptcha;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chAutoCaptcha_CheckedChanged);
        if (this._chAutoCaptcha != null)
          this._chAutoCaptcha.CheckedChanged -= eventHandler;
        this._chAutoCaptcha = value;
        if (this._chAutoCaptcha == null)
          return;
        this._chAutoCaptcha.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chProxy
    {
      get
      {
        return this._chProxy;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chProxy_CheckedChanged);
        if (this._chProxy != null)
          this._chProxy.CheckedChanged -= eventHandler;
        this._chProxy = value;
        if (this._chProxy == null)
          return;
        this._chProxy.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label lblProxy
    {
      get
      {
        return this._lblProxy;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblProxy = value;
      }
    }

    internal virtual Button btmLoadMail
    {
      get
      {
        return this._btmLoadMail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btmLoadMail_Click);
        if (this._btmLoadMail != null)
          this._btmLoadMail.Click -= eventHandler;
        this._btmLoadMail = value;
        if (this._btmLoadMail == null)
          return;
        this._btmLoadMail.Click += eventHandler;
      }
    }

    internal virtual CheckBox chAllMail
    {
      get
      {
        return this._chAllMail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chAllMail_CheckedChanged);
        if (this._chAllMail != null)
          this._chAllMail.CheckedChanged -= eventHandler;
        this._chAllMail = value;
        if (this._chAllMail == null)
          return;
        this._chAllMail.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label lblMailCountCur
    {
      get
      {
        return this._lblMailCountCur;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblMailCountCur = value;
      }
    }

    internal virtual Label lblMailCountAll
    {
      get
      {
        return this._lblMailCountAll;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblMailCountAll = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader7
    {
      get
      {
        return this._ColumnHeader7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader7 = value;
      }
    }

    internal virtual GroupBox grAccountEdit
    {
      get
      {
        return this._grAccountEdit;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._grAccountEdit = value;
      }
    }

    internal virtual GroupBox gbAccSell_1
    {
      get
      {
        return this._gbAccSell_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gbAccSell_1 = value;
      }
    }

    internal virtual Label lblAccSelNUM
    {
      get
      {
        return this._lblAccSelNUM;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblAccSelNUM = value;
      }
    }

    internal virtual TextBox txtAccSel_Login
    {
      get
      {
        return this._txtAccSel_Login;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtAccSel_Login = value;
      }
    }

    internal virtual GroupBox gbAccSell_2
    {
      get
      {
        return this._gbAccSell_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gbAccSell_2 = value;
      }
    }

    internal virtual TextBox txtAccSel_Password
    {
      get
      {
        return this._txtAccSel_Password;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtAccSel_Password = value;
      }
    }

    internal virtual GroupBox gbAccSell_4
    {
      get
      {
        return this._gbAccSell_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gbAccSell_4 = value;
      }
    }

    internal virtual TextBox txtAccSel_SecretAnswer
    {
      get
      {
        return this._txtAccSel_SecretAnswer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtAccSel_SecretAnswer = value;
      }
    }

    internal virtual Button btmSaveList
    {
      get
      {
        return this._btmSaveList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btmSaveList_Click);
        if (this._btmSaveList != null)
          this._btmSaveList.Click -= eventHandler;
        this._btmSaveList = value;
        if (this._btmSaveList == null)
          return;
        this._btmSaveList.Click += eventHandler;
      }
    }

    internal virtual Button btmAccSel_Save
    {
      get
      {
        return this._btmAccSel_Save;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btmAccSel_Save_Click);
        if (this._btmAccSel_Save != null)
          this._btmAccSel_Save.Click -= eventHandler;
        this._btmAccSel_Save = value;
        if (this._btmAccSel_Save == null)
          return;
        this._btmAccSel_Save.Click += eventHandler;
      }
    }

    internal virtual Button btmAccSel_Del
    {
      get
      {
        return this._btmAccSel_Del;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btmAccSel_Del_Click);
        if (this._btmAccSel_Del != null)
          this._btmAccSel_Del.Click -= eventHandler;
        this._btmAccSel_Del = value;
        if (this._btmAccSel_Del == null)
          return;
        this._btmAccSel_Del.Click += eventHandler;
      }
    }

    internal virtual ImageList IL
    {
      get
      {
        return this._IL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._IL = value;
      }
    }

    internal virtual CheckBox chAutoUpdate
    {
      get
      {
        return this._chAutoUpdate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.chAutoUpdate_Click);
        EventHandler eventHandler2 = new EventHandler(this.chAutoUpdate_CheckedChanged);
        if (this._chAutoUpdate != null)
        {
          this._chAutoUpdate.Click -= eventHandler1;
          this._chAutoUpdate.CheckedChanged -= eventHandler2;
        }
        this._chAutoUpdate = value;
        if (this._chAutoUpdate == null)
          return;
        this._chAutoUpdate.Click += eventHandler1;
        this._chAutoUpdate.CheckedChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtMon
    {
      get
      {
        return this._txtMon;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtMon = value;
      }
    }

    internal virtual Button btmAbout
    {
      get
      {
        return this._btmAbout;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._btmAbout != null)
          this._btmAbout.Click -= eventHandler;
        this._btmAbout = value;
        if (this._btmAbout == null)
          return;
        this._btmAbout.Click += eventHandler;
      }
    }

    internal virtual Label lblActionInSelect
    {
      get
      {
        return this._lblActionInSelect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblActionInSelect = value;
      }
    }

    internal virtual StatusStrip StatusBar
    {
      get
      {
        return this._StatusBar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._StatusBar = value;
      }
    }

    internal virtual ToolStripStatusLabel stlbl_1
    {
      get
      {
        return this._stlbl_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._stlbl_1 = value;
      }
    }

    internal virtual ToolStripStatusLabel stlbl_2
    {
      get
      {
        return this._stlbl_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._stlbl_2 = value;
      }
    }

    internal virtual ToolStripStatusLabel stlbl_3
    {
      get
      {
        return this._stlbl_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._stlbl_3 = value;
      }
    }

    internal virtual ToolStripStatusLabel stlbl_4
    {
      get
      {
        return this._stlbl_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._stlbl_4 = value;
      }
    }

    internal virtual ComboBox cmbReg
    {
      get
      {
        return this._cmbReg;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MeasureItemEventHandler itemEventHandler1 = new MeasureItemEventHandler(this.cmbreg_MeasureItem);
        DrawItemEventHandler itemEventHandler2 = new DrawItemEventHandler(this.cmbreg_DrawItem);
        if (this._cmbReg != null)
        {
          this._cmbReg.MeasureItem -= itemEventHandler1;
          this._cmbReg.DrawItem -= itemEventHandler2;
        }
        this._cmbReg = value;
        if (this._cmbReg == null)
          return;
        this._cmbReg.MeasureItem += itemEventHandler1;
        this._cmbReg.DrawItem += itemEventHandler2;
      }
    }

    internal virtual ColumnHeader ColumnHeader8
    {
      get
      {
        return this._ColumnHeader8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader8 = value;
      }
    }

    internal virtual GroupBox gbAccSell_5
    {
      get
      {
        return this._gbAccSell_5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gbAccSell_5 = value;
      }
    }

    internal virtual TextBox txtAccSel_Comment
    {
      get
      {
        return this._txtAccSel_Comment;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtAccSel_Comment = value;
      }
    }

    internal virtual GroupBox gbAccSell_3
    {
      get
      {
        return this._gbAccSell_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gbAccSell_3 = value;
      }
    }

    internal virtual TextBox txtAccSel_SecretQuestion
    {
      get
      {
        return this._txtAccSel_SecretQuestion;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtAccSel_SecretQuestion = value;
      }
    }

    internal virtual ToolTip ToolTip1
    {
      get
      {
        return this._ToolTip1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ToolTip1 = value;
      }
    }

    internal virtual System.Windows.Forms.Timer tmrHelp
    {
      get
      {
        return this._tmrHelp;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrHelp_Tick);
        if (this._tmrHelp != null)
          this._tmrHelp.Tick -= eventHandler;
        this._tmrHelp = value;
        if (this._tmrHelp == null)
          return;
        this._tmrHelp.Tick += eventHandler;
      }
    }

    internal virtual RadioButton rbAccSel_J
    {
      get
      {
        return this._rbAccSel_J;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._rbAccSel_J = value;
      }
    }

    internal virtual RadioButton rbAccSel_M
    {
      get
      {
        return this._rbAccSel_M;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._rbAccSel_M = value;
      }
    }

    internal virtual GroupBox gbAccSell_6
    {
      get
      {
        return this._gbAccSell_6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._gbAccSell_6 = value;
      }
    }

    internal virtual TextBox txtAccSel_Town
    {
      get
      {
        return this._txtAccSel_Town;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtAccSel_Town = value;
      }
    }

    internal virtual PictureBox picLine_2
    {
      get
      {
        return this._picLine_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picLine_2 = value;
      }
    }

    internal virtual PictureBox picLine_3
    {
      get
      {
        return this._picLine_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picLine_3 = value;
      }
    }

    internal virtual System.Windows.Forms.Timer tmrUpdate
    {
      get
      {
        return this._tmrUpdate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrUpdate_Tick);
        if (this._tmrUpdate != null)
          this._tmrUpdate.Tick -= eventHandler;
        this._tmrUpdate = value;
        if (this._tmrUpdate == null)
          return;
        this._tmrUpdate.Tick += eventHandler;
      }
    }

    internal virtual PictureBox picAutoCaptchaEnable
    {
      get
      {
        return this._picAutoCaptchaEnable;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.picAutoCaptchaEnable_Paint);
        if (this._picAutoCaptchaEnable != null)
          this._picAutoCaptchaEnable.Paint -= paintEventHandler;
        this._picAutoCaptchaEnable = value;
        if (this._picAutoCaptchaEnable == null)
          return;
        this._picAutoCaptchaEnable.Paint += paintEventHandler;
      }
    }

    internal virtual PictureBox picBanner
    {
      get
      {
        return this._picBanner;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.picBanner_Click);
        if (this._picBanner != null)
          this._picBanner.Click -= eventHandler;
        this._picBanner = value;
        if (this._picBanner == null)
          return;
        this._picBanner.Click += eventHandler;
      }
    }

    internal virtual ToolStripStatusLabel stlbl_CurProxy_1
    {
      get
      {
        return this._stlbl_CurProxy_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._stlbl_CurProxy_1 = value;
      }
    }

    internal virtual GroupBox boxOptions
    {
      get
      {
        return this._boxOptions;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxOptions = value;
      }
    }

    internal virtual CheckBox chReport_6
    {
      get
      {
        return this._chReport_6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chReport_CheckedChanged);
        if (this._chReport_6 != null)
          this._chReport_6.CheckedChanged -= eventHandler;
        this._chReport_6 = value;
        if (this._chReport_6 == null)
          return;
        this._chReport_6.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chReport_2
    {
      get
      {
        return this._chReport_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chReport_CheckedChanged);
        if (this._chReport_2 != null)
          this._chReport_2.CheckedChanged -= eventHandler;
        this._chReport_2 = value;
        if (this._chReport_2 == null)
          return;
        this._chReport_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chReport_1
    {
      get
      {
        return this._chReport_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chReport_CheckedChanged);
        if (this._chReport_1 != null)
          this._chReport_1.CheckedChanged -= eventHandler;
        this._chReport_1 = value;
        if (this._chReport_1 == null)
          return;
        this._chReport_1.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chReport_3
    {
      get
      {
        return this._chReport_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chReport_CheckedChanged);
        if (this._chReport_3 != null)
          this._chReport_3.CheckedChanged -= eventHandler;
        this._chReport_3 = value;
        if (this._chReport_3 == null)
          return;
        this._chReport_3.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox boxCounter
    {
      get
      {
        return this._boxCounter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxCounter = value;
      }
    }

    internal virtual Label INFO_8
    {
      get
      {
        return this._INFO_8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_8 = value;
      }
    }

    internal virtual Label INFO_9
    {
      get
      {
        return this._INFO_9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_9 = value;
      }
    }

    internal virtual Label INFO_3
    {
      get
      {
        return this._INFO_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_3 = value;
      }
    }

    internal virtual Label INFO_4
    {
      get
      {
        return this._INFO_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_4 = value;
      }
    }

    internal virtual Label INFO_6
    {
      get
      {
        return this._INFO_6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_6 = value;
      }
    }

    internal virtual Label INFO_5
    {
      get
      {
        return this._INFO_5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_5 = value;
      }
    }

    internal virtual Label INFO_2
    {
      get
      {
        return this._INFO_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_2 = value;
      }
    }

    internal virtual Label INFO_1
    {
      get
      {
        return this._INFO_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_1 = value;
      }
    }

    internal virtual Label lbl8
    {
      get
      {
        return this._lbl8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl8 = value;
      }
    }

    internal virtual Label lbl9
    {
      get
      {
        return this._lbl9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl9 = value;
      }
    }

    internal virtual Label lbl5
    {
      get
      {
        return this._lbl5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl5 = value;
      }
    }

    internal virtual Label lbl2
    {
      get
      {
        return this._lbl2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl2 = value;
      }
    }

    internal virtual Label lbl3
    {
      get
      {
        return this._lbl3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl3 = value;
      }
    }

    internal virtual Label lbl4
    {
      get
      {
        return this._lbl4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl4 = value;
      }
    }

    internal virtual Label lbl6
    {
      get
      {
        return this._lbl6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl6 = value;
      }
    }

    internal virtual Label lbl1
    {
      get
      {
        return this._lbl1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl1 = value;
      }
    }

    internal virtual CheckBox chReport_4
    {
      get
      {
        return this._chReport_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chReport_CheckedChanged);
        if (this._chReport_4 != null)
          this._chReport_4.CheckedChanged -= eventHandler;
        this._chReport_4 = value;
        if (this._chReport_4 == null)
          return;
        this._chReport_4.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chReport_5
    {
      get
      {
        return this._chReport_5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chReport_CheckedChanged);
        if (this._chReport_5 != null)
          this._chReport_5.CheckedChanged -= eventHandler;
        this._chReport_5 = value;
        if (this._chReport_5 == null)
          return;
        this._chReport_5.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chReport_7
    {
      get
      {
        return this._chReport_7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chReport_CheckedChanged);
        if (this._chReport_7 != null)
          this._chReport_7.CheckedChanged -= eventHandler;
        this._chReport_7 = value;
        if (this._chReport_7 == null)
          return;
        this._chReport_7.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chReport_8
    {
      get
      {
        return this._chReport_8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chReport_CheckedChanged);
        if (this._chReport_8 != null)
          this._chReport_8.CheckedChanged -= eventHandler;
        this._chReport_8 = value;
        if (this._chReport_8 == null)
          return;
        this._chReport_8.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label lblBUSY
    {
      get
      {
        return this._lblBUSY;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblBUSY = value;
      }
    }

    internal virtual SaveFileDialog SaveFileDialog1
    {
      get
      {
        return this._SaveFileDialog1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._SaveFileDialog1 = value;
      }
    }

    internal virtual PictureBox picVOTE_CAPTCHA_3
    {
      get
      {
        return this._picVOTE_CAPTCHA_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picVOTE_CAPTCHA_3 = value;
      }
    }

    internal virtual GroupBox grCAPTCHA
    {
      get
      {
        return this._grCAPTCHA;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._grCAPTCHA = value;
      }
    }

    internal virtual PictureBox picCollection3
    {
      get
      {
        return this._picCollection3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picCollection3 = value;
      }
    }

    internal virtual PictureBox picRequestCaptcha
    {
      get
      {
        return this._picRequestCaptcha;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picRequestCaptcha = value;
      }
    }

    internal virtual PictureBox picVOTE_CAPTCHA_4
    {
      get
      {
        return this._picVOTE_CAPTCHA_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picVOTE_CAPTCHA_4 = value;
      }
    }

    internal virtual PictureBox picCollection4
    {
      get
      {
        return this._picCollection4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picCollection4 = value;
      }
    }

    internal virtual System.Windows.Forms.Timer tmrLoadProgram
    {
      get
      {
        return this._tmrLoadProgram;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrLoadProgram_Tick);
        if (this._tmrLoadProgram != null)
          this._tmrLoadProgram.Tick -= eventHandler;
        this._tmrLoadProgram = value;
        if (this._tmrLoadProgram == null)
          return;
        this._tmrLoadProgram.Tick += eventHandler;
      }
    }

    internal virtual PictureBox picWait
    {
      get
      {
        return this._picWait;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picWait = value;
      }
    }

    internal virtual Label lbl11
    {
      get
      {
        return this._lbl11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl11 = value;
      }
    }

    internal virtual Label INFO_11
    {
      get
      {
        return this._INFO_11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_11 = value;
      }
    }

    internal virtual Label INFO_10
    {
      get
      {
        return this._INFO_10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_10 = value;
      }
    }

    internal virtual Label lbl10
    {
      get
      {
        return this._lbl10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl10 = value;
      }
    }

    internal virtual System.Windows.Forms.Timer tmrInfo
    {
      get
      {
        return this._tmrInfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrInfo_Tick);
        if (this._tmrInfo != null)
          this._tmrInfo.Tick -= eventHandler;
        this._tmrInfo = value;
        if (this._tmrInfo == null)
          return;
        this._tmrInfo.Tick += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer tmrMailDownload
    {
      get
      {
        return this._tmrMailDownload;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrMailDownload_Tick);
        if (this._tmrMailDownload != null)
          this._tmrMailDownload.Tick -= eventHandler;
        this._tmrMailDownload = value;
        if (this._tmrMailDownload == null)
          return;
        this._tmrMailDownload.Tick += eventHandler;
      }
    }

    internal virtual Button btnOpenMail
    {
      get
      {
        return this._btnOpenMail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnOpenMail_Click);
        if (this._btnOpenMail != null)
          this._btnOpenMail.Click -= eventHandler;
        this._btnOpenMail = value;
        if (this._btnOpenMail == null)
          return;
        this._btnOpenMail.Click += eventHandler;
      }
    }

    internal virtual Label INFO_7
    {
      get
      {
        return this._INFO_7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_7 = value;
      }
    }

    internal virtual Label lbl7
    {
      get
      {
        return this._lbl7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl7 = value;
      }
    }

    internal virtual Button btnOpenProxy
    {
      get
      {
        return this._btnOpenProxy;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnOpenProxy_Click);
        if (this._btnOpenProxy != null)
          this._btnOpenProxy.Click -= eventHandler;
        this._btnOpenProxy = value;
        if (this._btnOpenProxy == null)
          return;
        this._btnOpenProxy.Click += eventHandler;
      }
    }

    internal virtual ToolStripStatusLabel stlbl_CurProxy_2
    {
      get
      {
        return this._stlbl_CurProxy_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._stlbl_CurProxy_2 = value;
      }
    }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel1
    {
      get
      {
        return this._ToolStripStatusLabel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ToolStripStatusLabel1 = value;
      }
    }

    internal virtual ToolStripStatusLabel stlbl_Speed_1
    {
      get
      {
        return this._stlbl_Speed_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._stlbl_Speed_1 = value;
      }
    }

    internal virtual ToolStripStatusLabel stlbl_Speed_2
    {
      get
      {
        return this._stlbl_Speed_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._stlbl_Speed_2 = value;
      }
    }

    internal virtual PictureBox picNoSlot
    {
      get
      {
        return this._picNoSlot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picNoSlot = value;
      }
    }

    internal virtual ImageList IL_16
    {
      get
      {
        return this._IL_16;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._IL_16 = value;
      }
    }

    internal virtual System.Windows.Forms.Timer tmrTXT
    {
      get
      {
        return this._tmrTXT;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrTXT_Tick);
        if (this._tmrTXT != null)
          this._tmrTXT.Tick -= eventHandler;
        this._tmrTXT = value;
        if (this._tmrTXT == null)
          return;
        this._tmrTXT.Tick += eventHandler;
      }
    }

    internal virtual Label INFO_13
    {
      get
      {
        return this._INFO_13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_13 = value;
      }
    }

    internal virtual System.Windows.Forms.Timer tmrNetworkReboot
    {
      get
      {
        return this._tmrNetworkReboot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrNetworkReboot_Tick);
        if (this._tmrNetworkReboot != null)
          this._tmrNetworkReboot.Tick -= eventHandler;
        this._tmrNetworkReboot = value;
        if (this._tmrNetworkReboot == null)
          return;
        this._tmrNetworkReboot.Tick += eventHandler;
      }
    }

    internal virtual Label lbl13
    {
      get
      {
        return this._lbl13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl13 = value;
      }
    }

    internal virtual Button btnSort
    {
      get
      {
        return this._btnSort;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSort_Click);
        if (this._btnSort != null)
          this._btnSort.Click -= eventHandler;
        this._btnSort = value;
        if (this._btnSort == null)
          return;
        this._btnSort.Click += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer tmrVPNReboot
    {
      get
      {
        return this._tmrVPNReboot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrVPNReboot_Tick);
        if (this._tmrVPNReboot != null)
          this._tmrVPNReboot.Tick -= eventHandler;
        this._tmrVPNReboot = value;
        if (this._tmrVPNReboot == null)
          return;
        this._tmrVPNReboot.Tick += eventHandler;
      }
    }

    internal virtual Label INFO_12
    {
      get
      {
        return this._INFO_12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._INFO_12 = value;
      }
    }

    internal virtual Label lbl12
    {
      get
      {
        return this._lbl12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lbl12 = value;
      }
    }

    internal virtual CheckBox chCheckMail_WebFace
    {
      get
      {
        return this._chCheckMail_WebFace;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chCheckMail_WebFace_CheckedChanged);
        if (this._chCheckMail_WebFace != null)
          this._chCheckMail_WebFace.CheckedChanged -= eventHandler;
        this._chCheckMail_WebFace = value;
        if (this._chCheckMail_WebFace == null)
          return;
        this._chCheckMail_WebFace.CheckedChanged += eventHandler;
      }
    }

    internal virtual PictureBox picCollection1
    {
      get
      {
        return this._picCollection1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picCollection1 = value;
      }
    }

    internal virtual PictureBox picVOTE_CAPTCHA_1
    {
      get
      {
        return this._picVOTE_CAPTCHA_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picVOTE_CAPTCHA_1 = value;
      }
    }

    internal virtual Button btnSort_Random
    {
      get
      {
        return this._btnSort_Random;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSort_Random_Click);
        if (this._btnSort_Random != null)
          this._btnSort_Random.Click -= eventHandler;
        this._btnSort_Random = value;
        if (this._btnSort_Random == null)
          return;
        this._btnSort_Random.Click += eventHandler;
      }
    }

    internal virtual Button btnSort_Turn
    {
      get
      {
        return this._btnSort_Turn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSort_Turn_Click);
        if (this._btnSort_Turn != null)
          this._btnSort_Turn.Click -= eventHandler;
        this._btnSort_Turn = value;
        if (this._btnSort_Turn == null)
          return;
        this._btnSort_Turn.Click += eventHandler;
      }
    }

    internal virtual PictureBox picVOTE_CAPTCHA_2
    {
      get
      {
        return this._picVOTE_CAPTCHA_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picVOTE_CAPTCHA_2 = value;
      }
    }

    internal virtual PictureBox picCollection2
    {
      get
      {
        return this._picCollection2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picCollection2 = value;
      }
    }

    internal virtual Button btnSaveLog
    {
      get
      {
        return this._btnSaveLog;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSaveLog_Click);
        if (this._btnSaveLog != null)
          this._btnSaveLog.Click -= eventHandler;
        this._btnSaveLog = value;
        if (this._btnSaveLog == null)
          return;
        this._btnSaveLog.Click += eventHandler;
      }
    }

    internal virtual Button Button6
    {
      get
      {
        return this._Button6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button6_Click);
        if (this._Button6 != null)
          this._Button6.Click -= eventHandler;
        this._Button6 = value;
        if (this._Button6 == null)
          return;
        this._Button6.Click += eventHandler;
      }
    }

    internal virtual ProgressBar pbGenLogin
    {
      get
      {
        return this._pbGenLogin;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._pbGenLogin = value;
      }
    }

    internal virtual Button btnSQL
    {
      get
      {
        return this._btnSQL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSQL_Click);
        if (this._btnSQL != null)
          this._btnSQL.Click -= eventHandler;
        this._btnSQL = value;
        if (this._btnSQL == null)
          return;
        this._btnSQL.Click += eventHandler;
      }
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      int num = 0;
      if (this.LV.SelectedItems.Count > 0)
        num = checked (this.LV.SelectedItems[0].Index + 1);
      _INI.SaveINI("Global", "Item", Conversions.ToString(num));
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      _FUNCTION.FN = new _FUNCTION.clsTXT((Form) this);
      SocketNET.GlobalOBJ = (object) this.btmStart;
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Старт программы Mailbox@Reg v" + _VARIABLES.VER(174);
      fn.TXT(ref sText);
      this.tmrLoadProgram.Start();
      mdConnect.ProxCNT = 0;
    }

    private void cmbreg_DrawItem(object sender, DrawItemEventArgs e)
    {
      if (e.Index == -1)
        return;
      e.Graphics.DrawImage(this.IL_LV.Images[e.Index], e.Bounds.Left, e.Bounds.Top);
    }

    private void cmbreg_MeasureItem(object sender, MeasureItemEventArgs e)
    {
    }

    public void TXTinThread(ref string sText)
    {
      if (this.txtMon.InvokeRequired)
      {
        this.txtMon.BeginInvoke((Delegate) new _FUNCTION.dTXTinThread(this.TXTinThread), (object) sText);
      }
      else
      {
        DateTime date = Conversions.ToDate(DateAndTime.Now.TimeOfDay.ToString());
        TextBox txtMon = this.txtMon;
        if (txtMon.TextLength > 15000)
        {
          if (_VARIABLES.DebugOp.SaveLog)
          {
            string FullPath = Application.StartupPath + "\\Log.txt";
            TextBox textBox = txtMon;
            string text = textBox.Text;
            _LOADSAVE.FileAppend(ref FullPath, ref text);
            textBox.Text = text;
          }
          txtMon.Clear();
          txtMon.AppendText("LOG.Clear\r\n");
        }
        txtMon.AppendText("[" + Conversions.ToString(date) + "] " + sText + "\r\n");
        txtMon.Select(checked (txtMon.TextLength - 1), 0);
        txtMon.ScrollToCaret();
      }
    }

    private void tmrTXT_Tick(object sender, EventArgs e)
    {
      if (_VARIABLES.TXT_SB.Length <= 0)
        return;
      TextBox txtMon = this.txtMon;
      try
      {
        if (txtMon.TextLength > 15000)
        {
          if (_VARIABLES.DebugOp.SaveLog)
          {
            string FullPath = Application.StartupPath + "\\Log.txt";
            TextBox textBox = txtMon;
            string text = textBox.Text;
            _LOADSAVE.FileAppend(ref FullPath, ref text);
            textBox.Text = text;
          }
          txtMon.Clear();
          txtMon.AppendText("LOG.Clear\r\n");
        }
        txtMon.AppendText(_VARIABLES.TXT_SB.ToString());
        _VARIABLES.TXT_SB.Clear();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        txtMon.Clear();
        txtMon.AppendText("Ex.LOG.Clear\r\n");
        ProjectData.ClearProjectError();
      }
    }

    public void LV_ADD(int Index)
    {
      int index = checked (Index - 1);
      this.LV.Items.Add(Conversions.ToString(Index));
      this.LV.Items[index].ImageIndex = (int) _VARIABLES.MailInfo[Index].Registered;
      ListViewItem.ListViewSubItemCollection subItems = this.LV.Items[index].SubItems;
      subItems.Add(_VARIABLES.MailInfo[Index].login);
      subItems.Add("@" + _VARIABLES.MailInfo[Index].domain);
      subItems.Add(_VARIABLES.MailInfo[Index].RegUserData.Name);
      subItems.Add(_VARIABLES.MailInfo[Index].RegUserData.LastName);
      subItems.Add(_VARIABLES.MailInfo[Index].DataCreateBox);
      subItems.Add(Conversions.ToString(_VARIABLES.MailInfo[Index].MailAmount));
      subItems.Add(_VARIABLES.MailInfo[Index].comment);
    }

    internal void LV_Merge(int Index)
    {
      int index = checked (Index - 1);
      this.LV.Items[index].ImageIndex = (int) _VARIABLES.MailInfo[Index].Registered;
      this.LV.Items[index].SubItems[1].Text = _VARIABLES.MailInfo[Index].login;
      this.LV.Items[index].SubItems[2].Text = "@" + _VARIABLES.MailInfo[Index].domain;
      this.LV.Items[index].SubItems[3].Text = _VARIABLES.MailInfo[Index].RegUserData.Name;
      this.LV.Items[index].SubItems[4].Text = _VARIABLES.MailInfo[Index].RegUserData.LastName;
      this.LV.Items[index].SubItems[5].Text = _VARIABLES.MailInfo[Index].DataCreateBox;
      this.LV.Items[index].SubItems[6].Text = Conversions.ToString(_VARIABLES.MailInfo[Index].MailAmount);
      this.LV.Items[index].SubItems[7].Text = _VARIABLES.MailInfo[Index].comment;
    }

    private void tmrConnect_Tick(object sender, EventArgs e)
    {
      if (_VARIABLES.PauseConnect)
        return;
      this.tmrConnect.Interval = _VARIABLES.IntervalConnect;
      if (mdConnect.ProxCNT == Information.UBound((Array) _VARIABLES.Proxy, 1) && md_HttpLoadProxy.HttpLoadProxy.Use)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Сработала функция загрузки proxy с URL";
        fn.TXT(ref sText);
        md_HttpLoadProxy.HttpLoadProxy.LoadRequired = true;
        this.StopReg();
      }
      else
      {
        int sNum = -1;
        int num1 = 1;
        int threadWs = _VARIABLES.ThreadWS;
        int Index = num1;
        while (Index <= threadWs)
        {
          if (_VARIABLES.WS[Index].FreeSocket)
          {
            _VARIABLES.WS[Index].FreeSocket = false;
            checked { ++_VARIABLES.CountUserInfo; }
            int index;
            while (true)
            {
              switch (_VARIABLES.ActionCurrent)
              {
                case _VARIABLES.Action.RegMail:
                  if (_VARIABLES.CountUserInfo > Information.UBound((Array) _VARIABLES.MailInfo, 1))
                  {
                    if (_VARIABLES.OP.OpReg.AutoGenLogin)
                      _FUNCTION.GenLogin(checked ((int) Math.Round(Conversion.Val(MyProject.Forms.frmGenBlank.txtGenCount.Text))), false, false, false, false, false);
                    else
                      goto label_11;
                  }
                  int countUserInfo1 = _VARIABLES.CountUserInfo;
                  int num2 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
                  index = countUserInfo1;
                  while (index <= num2 && ((int) _VARIABLES.MailInfo[index].Registered != 0 && (int) _VARIABLES.MailInfo[index].Registered != 1) && (int) _VARIABLES.MailInfo[index].Registered != 5)
                    checked { ++index; }
                  if (index > Information.UBound((Array) _VARIABLES.MailInfo, 1))
                  {
                    if (_VARIABLES.OP.OpReg.AutoGenLogin)
                    {
                      _FUNCTION.GenLogin(checked ((int) Math.Round(Conversion.Val(MyProject.Forms.frmGenBlank.txtGenCount.Text))), false, false, false, false, false);
                      continue;
                    }
                    goto label_18;
                  }
                  else
                    goto label_25;
                case _VARIABLES.Action.CheckMail_WebFace:
                  goto label_20;
                default:
                  goto label_25;
              }
            }
label_11:
            _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
            string sText1 = "Закончились заготовки аккаунтов.";
            fn1.TXT(ref sText1);
            this.StopReg();
            return;
label_18:
            _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
            string sText2 = "Закончились заготовки аккаунтов.";
            fn2.TXT(ref sText2);
            this.StopReg();
            return;
label_20:
            int countUserInfo2 = _VARIABLES.CountUserInfo;
            int num3 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
            index = countUserInfo2;
            while (index <= num3 && ((int) _VARIABLES.MailInfo[index].Registered != 2 && (int) _VARIABLES.MailInfo[index].Registered != 3) && ((int) _VARIABLES.MailInfo[index].Registered != 4 && (int) _VARIABLES.MailInfo[index].Registered != 6 && (int) _VARIABLES.MailInfo[index].Registered != 7))
              checked { ++index; }
            if (index > Information.UBound((Array) _VARIABLES.MailInfo, 1))
            {
              _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
              string sText3 = "Закончились аккаунты для проверки.";
              fn3.TXT(ref sText3);
              this.StopReg();
              return;
            }
label_25:
            _VARIABLES.CountUserInfo = index;
            _VARIABLES.Mirror[Index] = index;
            sNum = index;
            _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy = 0;
            mdConnect.StartPage(Index);
            if (_VARIABLES.OP.MethodConnect == 1)
              break;
          }
          checked { ++Index; }
        }
        if (sNum == -1)
          return;
        _FUNCTION.AccountSelect(sNum);
      }
    }

    private void txtCaptcha_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtCaptcha_KeyUp(object sender, KeyEventArgs e)
    {
      int num1;
      int num2;
      try
      {
        if (e.KeyCode == Keys.Return)
        {
          if (_VARIABLES.DoWork_Reg)
          {
            int Index = 1;
            ProjectData.ClearProjectError();
            num1 = 2;
            if (Strings.Len(this.txtCaptcha.Text) == 0)
            {
              switch (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].DomainID)
              {
                case 0:
                  _DataArrival_ID0.Mail_ru_Refresh_Captcha(Index);
                  goto label_34;
                case 1:
                  _VARIABLES.WS[Index].ConnectTo = "Captcha";
                  SocketNET socketNet1 = _VARIABLES.WS[Index];
                  string set_URL1 = "http://qip.ru/api/captcha?n=register&k=" + _VARIABLES.CurThreadData[Index].SpareUrl_1 + Conversions.ToString(_FUNCTION.sRND.Next(111, 999));
                  string set_Referer1 = "http://qip.ru/reg/register";
                  string set_PostData1 = (string) null;
                  myProxy set_Proxy1 = mdConnect.SetProxy(Index);
                  _VARIABLES.meCurThreadData[] curThreadData1 = _VARIABLES.CurThreadData;
                  _VARIABLES.meCurThreadData[] meCurThreadDataArray1 = curThreadData1;
                  int index1 = Index;
                  int index2 = index1;
                  short curUserAgent1 = (short) meCurThreadDataArray1[index2].CurUserAgent;
                  string set_X_Forwarded_For1 = (string) null;
                  string set_ContentType1 = (string) null;
                  object set_Accept_Charset1 = (object) 1251;
                  string set_Headers_Add1 = (string) null;
                  socketNet1.Connect(ref set_URL1, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer1, ref set_PostData1, set_Proxy1, ref curUserAgent1, ref set_X_Forwarded_For1, ref set_ContentType1, ref set_Accept_Charset1, ref set_Headers_Add1);
                  curThreadData1[index1].CurUserAgent = checked ((byte) curUserAgent1);
                  goto label_34;
                case 2:
                  _VARIABLES.WS[Index].ConnectTo = "ReloadCaptcha";
                  SocketNET socketNet2 = _VARIABLES.WS[Index];
                  string set_URL2 = "http://captcha.meta.ua/captcha.php?i=1&rand=" + Conversions.ToString(_FUNCTION.sRND.Next(1111, 9999));
                  string set_Referer2 = "http://passport.meta.ua/?mode=reg&ref=main";
                  string set_PostData2 = (string) null;
                  myProxy set_Proxy2 = mdConnect.SetProxy(Index);
                  _VARIABLES.meCurThreadData[] curThreadData2 = _VARIABLES.CurThreadData;
                  _VARIABLES.meCurThreadData[] meCurThreadDataArray2 = curThreadData2;
                  int index3 = Index;
                  int index4 = index3;
                  short curUserAgent2 = (short) meCurThreadDataArray2[index4].CurUserAgent;
                  string set_X_Forwarded_For2 = (string) null;
                  string set_ContentType2 = (string) null;
                  object set_Accept_Charset2 = (object) 1251;
                  string set_Headers_Add2 = (string) null;
                  socketNet2.Connect(ref set_URL2, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer2, ref set_PostData2, set_Proxy2, ref curUserAgent2, ref set_X_Forwarded_For2, ref set_ContentType2, ref set_Accept_Charset2, ref set_Headers_Add2);
                  curThreadData2[index3].CurUserAgent = checked ((byte) curUserAgent2);
                  goto label_34;
                default:
                  goto label_34;
              }
            }
            else
            {
              if ((int) _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].DomainID == 0 && MyProject.Forms.frmNewCaptchaMailRU.Visible)
                MyProject.Forms.frmNewCaptchaMailRU.Hide();
              string text = this.txtCaptcha.Text;
              this.txtCaptcha.Text = "";
              this.txtCaptcha.Refresh();
              _FUNCTION.VisibleRequest(1);
              _FUNCTION.ReloadAllCaptcha();
              if (_VARIABLES.PlaySound.Use && _VARIABLES.PlaySound.Play[2])
                MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[2]);
              switch (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].DomainID)
              {
                case 0:
                  string lower = text.ToLower();
                  _VARIABLES.WS_Data[Index].CaptchaText = lower;
                  if (Operators.CompareString(lower, "000000000", false) == 0 || Operators.CompareString(lower, "ooooooooo", false) == 0)
                  {
                    checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Lost; }
                    if (_VARIABLES.OptionReport[8])
                    {
                      string sText = "Th#" + Conversions.ToString(Index) + " " + _VARIABLES.ServiceNameAC + ": Bad IP Captcha '" + lower + "'";
                      _FUNCTION.SBTXT(ref sText);
                    }
                    string FullPath;
                    if (_VARIABLES.DebugOp.SaveBadIP)
                    {
                      string StrBuffer = _VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].IP + ":" + Conversions.ToString(_VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].Port) + "\n";
                      FullPath = Application.StartupPath + "\\BadIP_000000000.log";
                      _LOADSAVE.FileAppend(ref FullPath, ref StrBuffer);
                    }
                    if (_VARIABLES.DebugOp.FullSessionLog)
                    {
                      FullPath = Application.StartupPath + "\\" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_session_cap_000000000.log";
                      string StrBuffer = _VARIABLES.CurThreadData[Index].SessionLog.ToString();
                      _LOADSAVE.FileSave(ref FullPath, ref StrBuffer);
                      _VARIABLES.CurThreadData[Index].SessionLog = (StringBuilder) null;
                    }
                    _VARIABLES.WS[Index].FreeSocket = true;
                    goto label_34;
                  }
                  else
                  {
                    _VARIABLES.CurThreadData[Index].PostDataVariable[35] = lower;
                    StringBuilder stringBuilder = new StringBuilder();
                    int index5 = Information.UBound((Array) _VARIABLES.CurThreadData[Index].PostDataLine, 1);
                    int num3 = 1;
                    int num4 = checked (index5 - 1);
                    int index6 = num3;
                    while (index6 <= num4)
                    {
                      stringBuilder.Append(_VARIABLES.CurThreadData[Index].PostDataLine[index6] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[index6] + "&");
                      checked { ++index6; }
                    }
                    stringBuilder.Append(_VARIABLES.CurThreadData[Index].PostDataLine[index5] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[index5]);
                    if (_VARIABLES.CurThreadData[Index].CaptchaRef_2.Length == 0)
                      stringBuilder.Append("&new_captcha=1");
                    _VARIABLES.WS[Index].ConnectTo = "reg_domain1";
                    SocketNET socketNet3 = _VARIABLES.WS[Index];
                    string set_URL3 = "https://e.mail.ru/reg?from=main_noc";
                    string set_Referer3 = "https://e.mail.ru/signup?from=main";
                    string set_PostData3 = stringBuilder.ToString();
                    myProxy set_Proxy3 = mdConnect.SetProxy(Index);
                    _VARIABLES.meCurThreadData[] curThreadData3 = _VARIABLES.CurThreadData;
                    _VARIABLES.meCurThreadData[] meCurThreadDataArray3 = curThreadData3;
                    int index7 = Index;
                    int index8 = index7;
                    short curUserAgent3 = (short) meCurThreadDataArray3[index8].CurUserAgent;
                    string set_X_Forwarded_For3 = (string) null;
                    string set_ContentType3 = (string) null;
                    object set_Accept_Charset3 = (object) "utf-8";
                    string set_Headers_Add3 = (string) null;
                    socketNet3.Connect(ref set_URL3, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer3, ref set_PostData3, set_Proxy3, ref curUserAgent3, ref set_X_Forwarded_For3, ref set_ContentType3, ref set_Accept_Charset3, ref set_Headers_Add3);
                    curThreadData3[index7].CurUserAgent = checked ((byte) curUserAgent3);
                    goto label_34;
                  }
                case 1:
                  _VARIABLES.WS_Data[Index].CaptchaText = text;
                  StringBuilder stringBuilder1 = new StringBuilder();
                  stringBuilder1.Append("first_name=" + md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Name));
                  stringBuilder1.Append("&last_name=" + md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.LastName));
                  stringBuilder1.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.username.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.username.Value);
                  stringBuilder1.Append("&reg_host=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain);
                  stringBuilder1.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.pwd.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.pwd.Value);
                  stringBuilder1.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.pwd2.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.pwd2.Value);
                  stringBuilder1.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.email.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.email.Value);
                  stringBuilder1.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.man_sex.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.man_sex.Value);
                  stringBuilder1.Append("&bday=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthDay);
                  stringBuilder1.Append("&bmonth=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthMonth);
                  stringBuilder1.Append("&byear=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthYear);
                  stringBuilder1.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.captcha.Name + "=" + text);
                  stringBuilder1.Append("&agree=on");
                  stringBuilder1.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[0].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[0].Value);
                  stringBuilder1.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[1].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[1].Value);
                  stringBuilder1.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[2].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[2].Value);
                  _VARIABLES.WS[Index].ConnectTo = "Reg_";
                  SocketNET socketNet4 = _VARIABLES.WS[Index];
                  string set_URL4 = "http://qip.ru/reg/register";
                  string set_Referer4 = "http://qip.ru/reg/register";
                  string set_PostData4 = stringBuilder1.ToString();
                  myProxy set_Proxy4 = mdConnect.SetProxy(Index);
                  _VARIABLES.meCurThreadData[] curThreadData4 = _VARIABLES.CurThreadData;
                  _VARIABLES.meCurThreadData[] meCurThreadDataArray4 = curThreadData4;
                  int index9 = Index;
                  int index10 = index9;
                  short curUserAgent4 = (short) meCurThreadDataArray4[index10].CurUserAgent;
                  string set_X_Forwarded_For4 = (string) null;
                  string set_ContentType4 = (string) null;
                  object set_Accept_Charset4 = (object) "utf-8";
                  string set_Headers_Add4 = (string) null;
                  socketNet4.Connect(ref set_URL4, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer4, ref set_PostData4, set_Proxy4, ref curUserAgent4, ref set_X_Forwarded_For4, ref set_ContentType4, ref set_Accept_Charset4, ref set_Headers_Add4);
                  curThreadData4[index9].CurUserAgent = checked ((byte) curUserAgent4);
                  goto label_34;
                case 2:
                  _VARIABLES.WS_Data[Index].CaptchaText = text;
                  StringBuilder stringBuilder2 = new StringBuilder();
                  stringBuilder2.Append(_VARIABLES.CurThreadData[Index].data_METAua.Name.Name + "=" + _FUNCTION.ConvertSTRtoHexWeb1byte(ref _VARIABLES.CurThreadData[Index].data_METAua.Name.Value));
                  stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_METAua.Lastname.Name + "=" + _FUNCTION.ConvertSTRtoHexWeb1byte(ref _VARIABLES.CurThreadData[Index].data_METAua.Lastname.Value));
                  stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_METAua.Login.Name + "=" + _VARIABLES.CurThreadData[Index].data_METAua.Login.Value);
                  stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_METAua.Password1.Name + "=" + _VARIABLES.CurThreadData[Index].data_METAua.Password1.Value);
                  stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_METAua.Password2.Name + "=" + _VARIABLES.CurThreadData[Index].data_METAua.Password2.Value);
                  stringBuilder2.Append("&uniq=" + _VARIABLES.CurThreadData[Index].data_METAua.uniq);
                  stringBuilder2.Append("&captcha=" + text);
                  stringBuilder2.Append("&redirect=");
                  stringBuilder2.Append("&from=passport");
                  stringBuilder2.Append("&portable=0");
                  stringBuilder2.Append("&ref=");
                  stringBuilder2.Append("&rand_digit=" + _VARIABLES.CurThreadData[Index].data_METAua.rand_digit);
                  _VARIABLES.WS[Index].ConnectTo = "Reg_Step1";
                  SocketNET socketNet5 = _VARIABLES.WS[Index];
                  string set_URL5 = "http://passport.meta.ua/reg/";
                  myCookies set_Cookies = (myCookies) null;
                  string set_Referer5 = "http://passport.meta.ua/?mode=reg&ref=main";
                  string set_PostData5 = stringBuilder2.ToString();
                  myProxy set_Proxy5 = mdConnect.SetProxy(Index);
                  _VARIABLES.meCurThreadData[] curThreadData5 = _VARIABLES.CurThreadData;
                  _VARIABLES.meCurThreadData[] meCurThreadDataArray5 = curThreadData5;
                  int index11 = Index;
                  int index12 = index11;
                  short curUserAgent5 = (short) meCurThreadDataArray5[index12].CurUserAgent;
                  string set_X_Forwarded_For5 = (string) null;
                  string set_ContentType5 = (string) null;
                  object set_Accept_Charset5 = (object) 1251;
                  string set_Headers_Add5 = (string) null;
                  socketNet5.Connect(ref set_URL5, ref set_Cookies, ref set_Referer5, ref set_PostData5, set_Proxy5, ref curUserAgent5, ref set_X_Forwarded_For5, ref set_ContentType5, ref set_Accept_Charset5, ref set_Headers_Add5);
                  curThreadData5[index11].CurUserAgent = checked ((byte) curUserAgent5);
                  goto label_34;
                default:
                  goto label_34;
              }
            }
          }
        }
        else
          goto label_34;
label_28:
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText1 = "Ошибка ввода капчи. Рано нажата клавиша 'ENTER'";
        fn.TXT(ref sText1);
        goto label_34;
label_29:
        num2 = -1;
        switch (num1)
        {
          case 2:
            goto label_28;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_29;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_34:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public void StopReg()
    {
      _VARIABLES.DoWork_Reg = false;
      this.tmrConnect.Enabled = false;
      this.tmrVPNReboot.Enabled = false;
      this.tmrNetworkReboot.Enabled = false;
      switch (_VARIABLES.ActionCurrent)
      {
        case _VARIABLES.Action.RegMail:
          if (_VARIABLES.OP.AutoCAPTCHA)
          {
            string sText = "Управление заблокировано до возврата всех CAPTCHA.";
            _FUNCTION.SBTXT(ref sText);
            if (!Information.IsNothing((object) _VARIABLES.AC_NET))
              _VARIABLES.AC_NET.StopSoft();
            this.btmStart.Enabled = false;
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.AutoReset = true;
            timer.Interval = 1000.0;
            timer.Elapsed += new ElapsedEventHandler(this.sTimerStop_Elapsed);
            timer.Start();
          }
          else
            _FUNCTION.UnLockedALL();
          string sText1 = "Регистрация остановлена.";
          _FUNCTION.SBTXT(ref sText1);
          break;
        case _VARIABLES.Action.CheckMail_WebFace:
          string sText2 = "Проверка остановлена.";
          _FUNCTION.SBTXT(ref sText2);
          _FUNCTION.UnLockedALL();
          break;
      }
      this.picNoSlot.Image = this.IL_16.Images[0];
      this.picAutoCaptchaEnable.Visible = false;
      this.btmStart.BackColor = Color.LimeGreen;
      this.btmStart.Image = this.IL.Images[0];
      this.btmStart.Text = "START";
      _FUNCTION.VisibleRequest(0);
      _FUNCTION.ReloadAllCaptcha();
      _FUNCTION.VisibleCapcta(-1);
      if (!_VARIABLES.PlaySound.Use || !_VARIABLES.PlaySound.Play[6])
        return;
      MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[6]);
    }

    private void sTimerStop_Elapsed(object sender, ElapsedEventArgs e)
    {
      if (_VARIABLES.DoWork_Reg)
        NewLateBinding.LateCall(sender, (Type) null, "stop", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
      else if (!_FUNCTION.Locked)
        NewLateBinding.LateCall(sender, (Type) null, "stop", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
      else if (_VARIABLES.IsConnected.Counter == 0)
      {
        NewLateBinding.LateCall(sender, (Type) null, "stop", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
      }
      else
      {
        if (_VARIABLES.AC_NET.CapCounter.IsBusy > 0)
          return;
        if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "Interval", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 1000, false))
        {
          NewLateBinding.LateSet(sender, (Type) null, "Interval", new object[1]
          {
            (object) 40000
          }, (string[]) null, (Type[]) null);
        }
        else
        {
          NewLateBinding.LateSet(sender, (Type) null, "AutoReset", new object[1]
          {
            (object) false
          }, (string[]) null, (Type[]) null);
          NewLateBinding.LateCall(sender, (Type) null, "stop", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
          try
          {
            int num1 = 0;
            int num2 = 1;
            int threadWs = _VARIABLES.ThreadWS;
            int index = num2;
            while (index <= threadWs)
            {
              if (_VARIABLES.WS[index].IsBusy)
              {
                checked { ++num1; }
                _VARIABLES.WS[index].SocketClose();
              }
              checked { ++index; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Ошибка таймера закрытия: " + exception.Message;
            fn.TXT(ref sText);
            ProjectData.ClearProjectError();
          }
        }
      }
    }

    public void btmStart_Click(object sender, EventArgs e)
    {
      if (_VARIABLES.DoWork_Reg)
        this.StopReg();
      else if (this.LV.Items.Count == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "У вас нет чистых заготовок e-Mail.\r\nСгенерируйте нужное вам количество и начните регистрацию.", MsgBoxStyle.Exclamation, (object) "MailBox@Reg");
      }
      else
      {
        if (this.LV.SelectedItems.Count == 0)
          _FUNCTION.AccountSelect(1);
        int SoftID = 281;
        switch (_VARIABLES.ActionCurrent)
        {
          case _VARIABLES.Action.RegMail:
            if (string.IsNullOrEmpty(_VARIABLES.OP.OpAC.Key) && _VARIABLES.OP.AutoCAPTCHA)
            {
              _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
              string sText = "Внимание! У вас не задан ключ для AutoCaptcha. Установите в настройках.";
              fn1.TXT(ref sText);
              _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
              sText = "Для ручного разгадывания, уберите галочку с 'AutoCaptcha'";
              fn2.TXT(ref sText);
              return;
            }
            if (_VARIABLES.OP.AutoCAPTCHA)
            {
              if (string.IsNullOrEmpty(_VARIABLES.OP.OpAC.HostOrIP))
              {
                int num2 = (int) Interaction.MsgBox((object) "У вас выбрано использование Автокапчи, но не задан хост!\r\nПройдите 'Общие настройки' -> 'Опции AutoCaptcha' -> 'HOST'\r\nИ задайте хост для работы с сервисом автокапчи. Например:\r\nantigate.com\r\ncaptchabot.com\r\napi.dbcapi.me  (для deathbycaptcha.com)\r\nИли любой другой сервис поддерживающий API Antigate", MsgBoxStyle.Critical, (object) "Mailbox@Reg Start");
                return;
              }
              _VARIABLES.ServiceNameAC = _FUNCTION.Ret_AC_HostName(_VARIABLES.OP.OpAC.HostOrIP);
              SoftID = Strings.InStr(_VARIABLES.OP.OpAC.HostOrIP.ToLower(), "antigate.com", CompareMethod.Binary) <= 0 ? (Strings.InStr(_VARIABLES.OP.OpAC.HostOrIP.ToLower(), "captchabot.com", CompareMethod.Binary) <= 0 ? 281 : 149230) : 281;
              break;
            }
            break;
        }
        this.btmStart.BackColor = Color.Red;
        this.btmStart.Image = this.IL.Images[1];
        this.btmStart.Text = "STOP";
        _FUNCTION.LockedALL();
        _VARIABLES.ThreadWS = Conversions.ToInteger(this.cmbThread.SelectedItem.ToString());
        _VARIABLES.Mirror = new int[checked (_VARIABLES.ThreadWS + 1)];
        _VARIABLES.CurThreadData = new _VARIABLES.meCurThreadData[checked (_VARIABLES.ThreadWS + 1)];
        _VARIABLES.WS_Data = new _VARIABLES.myWS_Data[checked (_VARIABLES.ThreadWS + 1)];
        string sText1;
        if (_VARIABLES.OP.SocketTimeOut < 5000)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          sText1 = "Таймаут сокета меньше 5с. Увеличен до 60с (по умолчанию).";
          fn.TXT(ref sText1);
          MyProject.Forms.frmOptions.txtSocketTimeOut.Text = Conversions.ToString(60000);
          _VARIABLES.OP.SocketTimeOut = 60000;
        }
        if (!Information.IsNothing((object) _VARIABLES.WS))
        {
          int num2 = 1;
          int num3 = Information.UBound((Array) _VARIABLES.WS, 1);
          int index = num2;
          while (index <= num3)
          {
            _VARIABLES.WS[index].DataArrival -= new SocketNET.DataArrivalEventHandler(mdConnect.DataArrival);
            _VARIABLES.WS[index].ErrorEvent -= new SocketNET.ErrorEventEventHandler(mdConnect.ErrorEvent);
            _VARIABLES.WS[index].DebugEvent -= new SocketNET.DebugEventEventHandler(mdConnect.DebugEvent);
            _VARIABLES.WS[index] = (SocketNET) null;
            checked { ++index; }
          }
          _VARIABLES.WS = (SocketNET[]) null;
        }
        _VARIABLES.IsConnected = new mySocketConnectedCounter()
        {
          Counter = 0
        };
        _VARIABLES.WS = new SocketNET[checked (_VARIABLES.ThreadWS + 1)];
        int num4 = 1;
        int threadWs1 = _VARIABLES.ThreadWS;
        int index1 = num4;
        while (index1 <= threadWs1)
        {
          SocketNET[] ws = _VARIABLES.WS;
          int index2 = index1;
          int set_Index = index1;
          myIsBusyCounter set_IsBusyCounter = (myIsBusyCounter) null;
          SocketNET socketNet = new SocketNET(set_Index, ref _VARIABLES.IsConnected, ref set_IsBusyCounter);
          ws[index2] = socketNet;
          _VARIABLES.WS[index1].CloseSocketAtFree = true;
          _VARIABLES.WS[index1].DataArrival += new SocketNET.DataArrivalEventHandler(mdConnect.DataArrival);
          _VARIABLES.WS[index1].ErrorEvent += new SocketNET.ErrorEventEventHandler(mdConnect.ErrorEvent);
          _VARIABLES.WS[index1].DebugEvent += new SocketNET.DebugEventEventHandler(mdConnect.DebugEvent);
          _VARIABLES.WS[index1].Options.TimeOut = _VARIABLES.OP.SocketTimeOut;
          checked { ++index1; }
        }
        int num5 = 1;
        int threadWs2 = _VARIABLES.ThreadWS;
        int index3 = num5;
        while (index3 <= threadWs2)
        {
          _VARIABLES.CurThreadData[index3].BitmapBuffer = new Bitmap(225, 51);
          checked { ++index3; }
        }
        if (_VARIABLES.OP.AutoCAPTCHA)
        {
          this.picAutoCaptchaEnable.Visible = true;
          _FUNCTION.VisibleRequest(0);
          _FUNCTION.VisibleCapcta(-2);
        }
        this.picNoSlot.Image = this.IL_16.Images[3];
        switch (_VARIABLES.ActionCurrent)
        {
          case _VARIABLES.Action.RegMail:
            if (_VARIABLES.AC_NET != null)
            {
              _VARIABLES.AC_NET.BadReportOK -= new AntiCaptchaNET.BadReportOKEventHandler(mdConnect.AC_NET_BadReportOK);
              _VARIABLES.AC_NET.CaptchaSolved -= new AntiCaptchaNET.CaptchaSolvedEventHandler(mdConnect.AC_NET_CaptchaSolved);
              _VARIABLES.AC_NET.ErrorEvent_Socket -= new AntiCaptchaNET.ErrorEvent_SocketEventHandler(mdConnect.AC_NET_ErrorEvent_Socket);
              _VARIABLES.AC_NET.ErrorEvent_AС -= new AntiCaptchaNET.ErrorEvent_AСEventHandler(mdConnect.AC_NET_ErrorEvent_AС);
              _VARIABLES.AC_NET.ErrorEvent_CAPCHA_NOT_READY -= new AntiCaptchaNET.ErrorEvent_CAPCHA_NOT_READYEventHandler(mdConnect.AC_NET_ErrorEvent_CAPCHA_NOT_READY);
              _VARIABLES.AC_NET.ErrorEvent_ERROR_NO_SLOT_AVAILABLE -= new AntiCaptchaNET.ErrorEvent_ERROR_NO_SLOT_AVAILABLEEventHandler(mdConnect.AC_NET_ErrorEvent_ERROR_NO_SLOT_AVAILABLE);
              _VARIABLES.AC_NET.InfoReport -= new AntiCaptchaNET.InfoReportEventHandler(mdConnect.AC_NET_InfoReport);
              _VARIABLES.AC_NET.ErrorEvent_Balance -= new AntiCaptchaNET.ErrorEvent_BalanceEventHandler(mdConnect.AC_NET_ErrorEvent_Balance);
              _VARIABLES.AC_NET.Dispose();
              _VARIABLES.AC_NET = (AntiCaptchaNET) null;
            }
            int PauseGetBalance = 0;
            switch (_VARIABLES.ActionCurrent)
            {
              case _VARIABLES.Action.RegMail:
                PauseGetBalance = !_VARIABLES.OP.AutoCAPTCHA ? 0 : _VARIABLES.OP.OpAC.PauseGetBalance;
                break;
              case _VARIABLES.Action.CheckMail_WebFace:
                PauseGetBalance = 0;
                break;
            }
            object lbl1 = (object) this.lbl1;
            AntiCaptchaNET antiCaptchaNet = new AntiCaptchaNET(ref lbl1, _VARIABLES.ThreadWS, _VARIABLES.OP.OpAC.Key, _VARIABLES.OP.OpAC.PauseError, _VARIABLES.OP.OpAC.PauseNoSlot, PauseGetBalance, _VARIABLES.OP.OpAC.PauseAfterSending, _VARIABLES.OP.OpAC.NextGetCaptcha, _VARIABLES.OP.OpAC.TimeLimit, _VARIABLES.OP.OpAC.SocketTimeOut, _VARIABLES.OP.OpAC.HostOrIP, SoftID, AntiCaptchaNET.ContentType.jpg, MyProject.Forms.frmOptions.txtProxy_AC.Text);
            this.lbl1 = (Label) lbl1;
            _VARIABLES.AC_NET = antiCaptchaNet;
            _VARIABLES.AC_NET.SetOptions(_VARIABLES.OptionsAntigateProg.phrase, _VARIABLES.OptionsAntigateProg.regsense, _VARIABLES.OptionsAntigateProg.numeric, _VARIABLES.OptionsAntigateProg.calc, _VARIABLES.OptionsAntigateProg.min_len, _VARIABLES.OptionsAntigateProg.max_len, _VARIABLES.OptionsAntigateProg.is_russian);
            _VARIABLES.AC_NET.BadReportOK += new AntiCaptchaNET.BadReportOKEventHandler(mdConnect.AC_NET_BadReportOK);
            _VARIABLES.AC_NET.CaptchaSolved += new AntiCaptchaNET.CaptchaSolvedEventHandler(mdConnect.AC_NET_CaptchaSolved);
            _VARIABLES.AC_NET.ErrorEvent_Socket += new AntiCaptchaNET.ErrorEvent_SocketEventHandler(mdConnect.AC_NET_ErrorEvent_Socket);
            _VARIABLES.AC_NET.ErrorEvent_AС += new AntiCaptchaNET.ErrorEvent_AСEventHandler(mdConnect.AC_NET_ErrorEvent_AС);
            _VARIABLES.AC_NET.ErrorEvent_CAPCHA_NOT_READY += new AntiCaptchaNET.ErrorEvent_CAPCHA_NOT_READYEventHandler(mdConnect.AC_NET_ErrorEvent_CAPCHA_NOT_READY);
            _VARIABLES.AC_NET.ErrorEvent_ERROR_NO_SLOT_AVAILABLE += new AntiCaptchaNET.ErrorEvent_ERROR_NO_SLOT_AVAILABLEEventHandler(mdConnect.AC_NET_ErrorEvent_ERROR_NO_SLOT_AVAILABLE);
            _VARIABLES.AC_NET.InfoReport += new AntiCaptchaNET.InfoReportEventHandler(mdConnect.AC_NET_InfoReport);
            _VARIABLES.AC_NET.ErrorEvent_Balance += new AntiCaptchaNET.ErrorEvent_BalanceEventHandler(mdConnect.AC_NET_ErrorEvent_Balance);
            _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
            sText1 = "Регистрация запущена.";
            fn3.TXT(ref sText1);
            this.tmrInfo.Stop();
            this.tmrInfo.Interval = 1000;
            this.tmrInfo.Start();
            break;
          case _VARIABLES.Action.CheckMail_WebFace:
            _FUNCTION.clsTXT fn4 = _FUNCTION.FN;
            sText1 = "Проверка почтовых ящиков запущена.";
            fn4.TXT(ref sText1);
            break;
        }
        _VARIABLES.CountUserInfo = this.LV.SelectedItems[0].Index;
        _VARIABLES.ProxySpeed = 0;
        _VARIABLES.ErrorCountInWork = 0;
        _VARIABLES.VPN_MD.MailCount = 0;
        this.pbGenLogin.Maximum = Information.UBound((Array) _VARIABLES.MailInfo, 1);
        _VARIABLES.Progress_MaxValue_Reg = 0;
        this.tmrNetworkReboot.Enabled = false;
        this.tmrVPNReboot.Enabled = false;
        md_NetworkReboot.NetworkReboot.ReconnectRequired = false;
        _VARIABLES.PauseConnect = false;
        _VARIABLES.DoWork_Reg = true;
        this.tmrConnect.Interval = 33;
        this.tmrConnect.Enabled = true;
      }
    }

    private void chAutoCaptcha_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chAutoCaptcha.Checked)
      {
        _VARIABLES.OP.AutoCAPTCHA = true;
        this.txtCaptcha.Enabled = false;
        if (Strings.Len(_VARIABLES.OP.OpAC.Key) != 32)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Внимание! У вас не задан ключ для AutoCaptcha. Установите в настройках.";
          fn.TXT(ref sText);
        }
        this.boxCounter.Text = "счетчики";
        this.INFO_1.Enabled = true;
        this.INFO_2.Enabled = true;
        this.INFO_3.Enabled = true;
        this.INFO_4.Enabled = true;
        this.INFO_8.Enabled = true;
        this.INFO_9.Enabled = true;
        this.INFO_10.Enabled = true;
        this.INFO_11.Enabled = true;
        this.INFO_12.Enabled = true;
        this.INFO_13.Enabled = true;
        this.lbl1.Enabled = true;
        this.lbl2.Enabled = true;
        this.lbl3.Enabled = true;
        this.lbl4.Enabled = true;
        this.lbl8.Enabled = true;
        this.lbl9.Enabled = true;
        this.lbl10.Enabled = true;
        this.lbl11.Enabled = true;
        this.lbl12.Enabled = true;
        this.lbl13.Enabled = true;
      }
      else
      {
        this.boxCounter.Text = "ручной ввод";
        this.INFO_1.Enabled = false;
        this.INFO_2.Enabled = false;
        this.INFO_3.Enabled = false;
        this.INFO_4.Enabled = false;
        this.INFO_8.Enabled = false;
        this.INFO_9.Enabled = false;
        this.INFO_10.Enabled = false;
        this.INFO_11.Enabled = false;
        this.INFO_12.Enabled = false;
        this.INFO_13.Enabled = false;
        this.lbl1.Enabled = false;
        this.lbl2.Enabled = false;
        this.lbl3.Enabled = false;
        this.lbl4.Enabled = false;
        this.lbl8.Enabled = false;
        this.lbl9.Enabled = false;
        this.lbl10.Enabled = false;
        this.lbl11.Enabled = false;
        this.lbl12.Enabled = false;
        this.lbl13.Enabled = false;
        _VARIABLES.OP.AutoCAPTCHA = false;
        this.txtCaptcha.Enabled = true;
        this.cmbThread.SelectedIndex = 0;
      }
      _INI.SaveINI("Globals", "chAutoCaptcha", Conversions.ToString(this.chAutoCaptcha.Checked));
    }

    private void LV_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      if (_VARIABLES.DoWork_Reg | this.tmrMailDownload.Enabled)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Сортировка в данный момент недоступна!";
        fn.TXT(ref sText);
      }
      else
      {
        switch (e.Column)
        {
          case 1:
            _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
            string sText1 = "Сортировка по 'Login'";
            fn1.TXT(ref sText1);
            Sort.SortByLogin();
            break;
          case 2:
            _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
            string sText2 = "Сортировка по 'Domain'";
            fn2.TXT(ref sText2);
            Sort.SortByDomain();
            break;
          case 3:
            _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
            string sText3 = "Сортировка по 'Name'";
            fn3.TXT(ref sText3);
            Sort.SortByName();
            break;
          case 4:
            _FUNCTION.clsTXT fn4 = _FUNCTION.FN;
            string sText4 = "Сортировка по 'LastName'";
            fn4.TXT(ref sText4);
            Sort.SortByLastName();
            break;
          case 5:
            _FUNCTION.clsTXT fn5 = _FUNCTION.FN;
            string sText5 = "Сортировка по 'Creation Date'";
            fn5.TXT(ref sText5);
            Sort.SortByCreationDate();
            break;
          default:
            _FUNCTION.clsTXT fn6 = _FUNCTION.FN;
            string sText6 = "Сортировка по этому параметру не предусмотрена.";
            fn6.TXT(ref sText6);
            break;
        }
      }
    }

    private void LV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
      if (!e.IsSelected)
        return;
      switch (this.LV.SelectedItems.Count)
      {
        case 1:
          if (!this.gbAccSell_1.Enabled)
          {
            this.grAccountEdit.Text = "№ аккаунта";
            this.gbAccSell_1.Enabled = true;
            this.gbAccSell_2.Enabled = true;
            this.gbAccSell_3.Enabled = true;
            this.gbAccSell_4.Enabled = true;
            this.gbAccSell_6.Enabled = true;
            this.rbAccSel_M.Enabled = true;
            this.rbAccSel_J.Enabled = true;
            this.gbAccSell_5.Text = "Комментарий";
          }
          int index = checked (e.ItemIndex + 1);
          this.lblAccSelNUM.Text = Conversions.ToString(index);
          this.cmbReg.SelectedIndex = (int) _VARIABLES.MailInfo[index].Registered;
          this.txtAccSel_Login.Text = _VARIABLES.MailInfo[index].login + "@" + _VARIABLES.MailInfo[index].domain;
          this.txtAccSel_Password.Text = _VARIABLES.MailInfo[index].password;
          this.txtAccSel_SecretQuestion.Text = _VARIABLES.MailInfo[index].RegUserData.SecretQuestion;
          this.txtAccSel_SecretAnswer.Text = _VARIABLES.MailInfo[index].RegUserData.SecretAnswer;
          this.txtAccSel_Comment.Text = _VARIABLES.MailInfo[index].comment;
          this.txtAccSel_Town.Text = _VARIABLES.MailInfo[index].RegUserData.City;
          this.lblMailCountAll.Text = Conversions.ToString(_VARIABLES.MailInfo[index].MailAmount);
          if ((int) _VARIABLES.MailInfo[index].RegUserData.Sex == 1)
          {
            this.rbAccSel_M.Checked = true;
            this.rbAccSel_J.Checked = false;
            break;
          }
          this.rbAccSel_M.Checked = false;
          this.rbAccSel_J.Checked = true;
          break;
        case 2:
          this.grAccountEdit.Text = "Выбрано всего:";
          this.lblAccSelNUM.Text = Conversions.ToString(this.LV.SelectedItems.Count);
          this.txtAccSel_Login.Text = "";
          this.txtAccSel_Password.Text = "";
          this.txtAccSel_SecretQuestion.Text = "";
          this.txtAccSel_SecretAnswer.Text = "";
          this.txtAccSel_Comment.Text = "";
          this.gbAccSell_1.Enabled = false;
          this.gbAccSell_2.Enabled = false;
          this.gbAccSell_3.Enabled = false;
          this.gbAccSell_4.Enabled = false;
          this.gbAccSell_6.Enabled = false;
          this.rbAccSel_M.Enabled = false;
          this.rbAccSel_J.Enabled = false;
          this.gbAccSell_5.Text = "Общий комментарий";
          break;
      }
    }

    private void btmAccSel_Save_Click(object sender, EventArgs e)
    {
      int integer = Conversions.ToInteger(this.lblAccSelNUM.Text);
      if (integer == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "У вас на редактировании ничего не находится.", MsgBoxStyle.Exclamation, (object) "MailBox@Reg");
      }
      else if (this.LV.SelectedItems.Count > 1)
      {
        int selectedIndex = this.cmbReg.SelectedIndex;
        string text = this.txtAccSel_Comment.Text;
        int num2 = 0;
        int num3 = checked (this.LV.Items.Count - 1);
        int index = num2;
        while (index <= num3)
        {
          if (this.LV.Items[index].Selected)
          {
            _VARIABLES.MailInfo[checked (index + 1)].comment = text;
            _VARIABLES.MailInfo[checked (index + 1)].Registered = checked ((short) selectedIndex);
            this.LV.Items[index].ImageIndex = selectedIndex;
            this.LV.Items[index].SubItems[7].Text = text;
          }
          checked { ++index; }
        }
        _LOADSAVE.SaveALL_MailInfo();
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Комментарии и Статус к " + Conversions.ToString(this.LV.SelectedItems.Count) + " аккаунтам сохранены.";
        fn.TXT(ref sText);
      }
      else
      {
        if ((int) _VARIABLES.MailInfo[integer].Registered == 2)
        {
          switch (Interaction.MsgBox((object) "Внимание! Вы пытаетесь изменить уже зарегистрированный аккаунт. \r\nЭто может привести к несовпадению данных в базе с учетной записью на Mail.ru\r\nХотите продолжить?", MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo, (object) "Mailbox@Reg"))
          {
            case MsgBoxResult.No:
              return;
          }
        }
        _VARIABLES.MailInfo[integer].Registered = checked ((short) this.cmbReg.SelectedIndex);
        string[] strArray = Strings.Split(this.txtAccSel_Login.Text.ToLower(), "@", -1, CompareMethod.Binary);
        _VARIABLES.MailInfo[integer].login = strArray[0];
        if (Information.UBound((Array) strArray, 1) == 1)
          _VARIABLES.MailInfo[integer].domain = strArray[1];
        string domain = _VARIABLES.MailInfo[integer].domain;
        if (Operators.CompareString(domain, "mail.ru", false) == 0 || Operators.CompareString(domain, "inbox.ru", false) == 0 || (Operators.CompareString(domain, "bk.ru", false) == 0 || Operators.CompareString(domain, "list.ru", false) == 0) || Operators.CompareString(domain, "mail.ua", false) == 0)
          _VARIABLES.MailInfo[integer].DomainID = (short) 0;
        else if (Operators.CompareString(domain, "qip.ru", false) == 0 || Operators.CompareString(domain, "pochta.ru", false) == 0 || (Operators.CompareString(domain, "fromru.com", false) == 0 || Operators.CompareString(domain, "front.ru", false) == 0) || (Operators.CompareString(domain, "hotbox.ru", false) == 0 || Operators.CompareString(domain, "hotmail.ru", false) == 0 || (Operators.CompareString(domain, "krovatka.su", false) == 0 || Operators.CompareString(domain, "land.ru", false) == 0)) || (Operators.CompareString(domain, "mail15.com", false) == 0 || Operators.CompareString(domain, "mail333.com", false) == 0 || (Operators.CompareString(domain, "newmail.ru", false) == 0 || Operators.CompareString(domain, "nightmail.ru", false) == 0) || (Operators.CompareString(domain, "nm.ru", false) == 0 || Operators.CompareString(domain, "pisem.net", false) == 0 || (Operators.CompareString(domain, "pochtamt.ru", false) == 0 || Operators.CompareString(domain, "pop3.ru", false) == 0))) || (Operators.CompareString(domain, "rbcmail.ru", false) == 0 || Operators.CompareString(domain, "smtp.ru", false) == 0 || (Operators.CompareString(domain, "5ballov.ru", false) == 0 || Operators.CompareString(domain, "aeterna.ru", false) == 0) || (Operators.CompareString(domain, "ziza.ru", false) == 0 || Operators.CompareString(domain, "memori.ru", false) == 0 || (Operators.CompareString(domain, "photofile.ru", false) == 0 || Operators.CompareString(domain, "fotoplenka.ru", false) == 0)) || Operators.CompareString(domain, "pochta.com", false) == 0))
        {
          if (Strings.InStr(_VARIABLES.MailInfo[integer].login, "_", CompareMethod.Binary) > 0)
          {
            _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
            string sText1 = "На сервисе QIP.ru запрещено в логинах использовать символ подчеркивания.";
            fn1.TXT(ref sText1);
            _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
            string sText2 = "Произведена замена '_' на '-'";
            fn2.TXT(ref sText2);
            _VARIABLES.MailInfo[integer].login = _VARIABLES.MailInfo[integer].login.Replace("_", "-");
          }
          _VARIABLES.MailInfo[integer].DomainID = (short) 1;
        }
        else
          _VARIABLES.MailInfo[integer].DomainID = Operators.CompareString(domain, "meta.ua", false) != 0 ? (short) 100 : (short) 2;
        _VARIABLES.MailInfo[integer].password = this.txtAccSel_Password.Text;
        _VARIABLES.MailInfo[integer].RegUserData.SecretAnswer = this.txtAccSel_SecretAnswer.Text;
        _VARIABLES.MailInfo[integer].comment = this.txtAccSel_Comment.Text;
        _VARIABLES.MailInfo[integer].RegUserData.City = this.txtAccSel_Town.Text;
        _VARIABLES.MailInfo[integer].RegUserData.Sex = !this.rbAccSel_M.Checked ? (short) 2 : (short) 1;
        this.LV_Merge(integer);
        _LOADSAVE.SaveOne_MailInfo(integer);
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Аккант #" + Conversions.ToString(integer) + " сохранен.";
        fn.TXT(ref sText);
      }
    }

    private void cmbThread_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.cmbThread.SelectedIndex != 0 & !this.chAutoCaptcha.Checked)
      {
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        string sText1 = "Внимание! В многопоточном режиме, ручной ввод CAPTCHA невозможен.";
        fn1.TXT(ref sText1);
        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
        string sText2 = "AutoCapthca - включена.";
        fn2.TXT(ref sText2);
        this.chAutoCaptcha.Checked = true;
      }
      _INI.SaveINI("Globals", "cmbThread", Conversions.ToString(this.cmbThread.SelectedIndex));
    }

    private void chAutoUpdate_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Globals", "chAutoUpdate", Conversions.ToString(this.chAutoUpdate.Checked));
    }

    private void btmGlobalOptions_Click(object sender, EventArgs e)
    {
      int num = (int) MyProject.Forms.frmOptions.ShowDialog();
    }

    private void chProxy_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chProxy.Checked)
      {
        _VARIABLES.OP.UsePoxy = (short) 1;
        if (Information.UBound((Array) _VARIABLES.Proxy, 1) == 0)
        {
          int num = (int) Interaction.MsgBox((object) "У вас не заданы proxy.\r\nВнесите ваш список прокси в файл proxy.txt (папка data)\r\n", MsgBoxStyle.Exclamation, (object) "Mailbox@reg");
          this.chProxy.Checked = false;
          return;
        }
        this.lblProxy.BackColor = Color.Green;
        this.lblProxy.Text = "USE PROXY";
      }
      else
      {
        _VARIABLES.OP.UsePoxy = (short) 0;
        this.lblProxy.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
        this.lblProxy.Text = "DIRECT";
      }
      _INI.SaveINI("Globals", "chProxy", Conversions.ToString(this.chProxy.Checked));
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      int num = (int) MyProject.Forms.AboutBox.ShowDialog();
    }

    private void StopMailDownload()
    {
      this.tmrVPNReboot.Enabled = false;
      this.tmrNetworkReboot.Enabled = false;
      this.btmLoadMail.BackColor = Color.WhiteSmoke;
      this.btmLoadMail.Text = "Скачать письма";
      this.tmrMailDownload.Stop();
      _FUNCTION.UnLockedALL_MailDownload();
      if (!this.DownloadAllMail)
        return;
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Скачивание писем остановлено.";
      fn.TXT(ref sText);
    }

    private void btmLoadMail_Click(object sender, EventArgs e)
    {
      if (this.tmrMailDownload.Enabled)
      {
        this.StopMailDownload();
      }
      else
      {
        _VARIABLES.ThreadWS = Conversions.ToInteger(this.cmbThread.SelectedItem.ToString());
        if (!this.DownloadAllMail)
          _VARIABLES.ThreadWS = 1;
        if (_VARIABLES.ThreadWS > 32)
        {
          int num1 = (int) Interaction.MsgBox((object) ("Скачивание писем происходит в многопоточном режиме.\r\nУ вас выбрано " + Conversions.ToString(_VARIABLES.ThreadWS) + " thread, что может привести к блокированию аккаунтов со стороны почтового сервера.\r\nСнизьте потоки максимум до 32х (рекомендуется до 2х-4х)."), MsgBoxStyle.Exclamation, (object) "MailBox@Reg");
        }
        else if (this.LV.Items.Count == 0)
        {
          int num2 = (int) Interaction.MsgBox((object) "У вас нет почтовых ящиков.", MsgBoxStyle.Exclamation, (object) "MailBox@Reg");
        }
        else
        {
          if (this.LV.SelectedItems.Count == 0)
            _FUNCTION.AccountSelect(1);
          this.BW_LoadMail = new BackgroundWorker[checked (_VARIABLES.ThreadWS + 1)];
          this.txtBuffer_LoadMail = new StringBuilder[checked (_VARIABLES.ThreadWS + 1)];
          this.popConn = new POP3[checked (_VARIABLES.ThreadWS + 1)];
          _VARIABLES.Mirror = new int[checked (_VARIABLES.ThreadWS + 1)];
          this.LoadMail_FreeSocket = new bool[checked (_VARIABLES.ThreadWS + 1)];
          int num3 = 1;
          int threadWs = _VARIABLES.ThreadWS;
          int index = num3;
          while (index <= threadWs)
          {
            this.BW_LoadMail[index] = new BackgroundWorker();
            this.BW_LoadMail[index].RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.BW_LoadMail_RunWorkerCompleted);
            this.BW_LoadMail[index].DoWork += new DoWorkEventHandler(this.BW_LoadMail_DoWork);
            this.LoadMail_FreeSocket[index] = true;
            checked { ++index; }
          }
          this.btmLoadMail.BackColor = Color.OrangeRed;
          this.btmLoadMail.Text = "STOP   ";
          _FUNCTION.LockedALL_MailDownload();
          if (this.DownloadAllMail)
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "=======================================";
            fn.TXT(ref sText);
          }
          _VARIABLES.CountUserInfo = this.LV.SelectedItems[0].Index;
          _VARIABLES.PauseConnect = false;
          _VARIABLES.VPN_MD.MailCount = 0;
          this.tmrMailDownload.Interval = 33;
          this.tmrMailDownload.Start();
        }
      }
    }

    private void BW_LoadMail_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      int index = Array.IndexOf((Array) this.BW_LoadMail, RuntimeHelpers.GetObjectValue(sender));
      if (this.txtBuffer_LoadMail[index] != null)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = this.txtBuffer_LoadMail[index].ToString();
        fn.TXT(ref sText);
      }
      this.txtBuffer_LoadMail[index] = (StringBuilder) null;
      this.lblMailCountCur.Text = Conversions.ToString(_VARIABLES.DownloadMailCount);
      this.LV_Merge(_VARIABLES.Mirror[index]);
      _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[index]);
      if (!this.DownloadAllMail)
        this.StopMailDownload();
      if (_VARIABLES.VPN_MD.Use && _VARIABLES.VPN_MD.UseDownloadMail)
      {
        checked { ++_VARIABLES.VPN_MD.MailCount; }
        if (_VARIABLES.VPN_MD.MailCount >= _VARIABLES.VPN_MD.DownloadMailCount)
        {
          _VARIABLES.PauseConnect = true;
          this.tmrVPNReboot.Start();
        }
      }
      this.LoadMail_FreeSocket[index] = true;
    }

    private void BW_LoadMail_DoWork(object sender, DoWorkEventArgs e)
    {
      int index1 = Array.IndexOf((Array) this.BW_LoadMail, RuntimeHelpers.GetObjectValue(sender));
      int index2 = _VARIABLES.Mirror[index1];
      this.txtBuffer_LoadMail[index1] = new StringBuilder();
      StringBuilder stringBuilder = new StringBuilder();
      this.popConn[index1] = new POP3();
      try
      {
        short domainId = _VARIABLES.MailInfo[index2].DomainID;
        switch (domainId)
        {
          case 0:
            this.popConn[index1].POPConnect("pop3.mail.ru", _VARIABLES.MailInfo[index2].login + "@" + _VARIABLES.MailInfo[index2].domain, _VARIABLES.MailInfo[index2].password);
            break;
          case 1:
            this.popConn[index1].POPConnect("pop.qip.ru", _VARIABLES.MailInfo[index2].login + "@" + _VARIABLES.MailInfo[index2].domain, _VARIABLES.MailInfo[index2].password);
            break;
          case 2:
            this.popConn[index1].POPConnect("pop.meta.ua", _VARIABLES.MailInfo[index2].login + "@" + _VARIABLES.MailInfo[index2].domain, _VARIABLES.MailInfo[index2].password);
            break;
          default:
            if ((int) domainId == (int) Conversions.ToShort("yandex.ru"))
            {
              this.popConn[index1].POPConnect("pop.yandex.ru", _VARIABLES.MailInfo[index2].login + "@" + _VARIABLES.MailInfo[index2].domain, _VARIABLES.MailInfo[index2].password);
              break;
            }
            if ((int) domainId != (int) Conversions.ToShort("km.ru") && (int) domainId != (int) Conversions.ToShort("freemail.ru") && ((int) domainId != (int) Conversions.ToShort("bossmail.ru") && (int) domainId != (int) Conversions.ToShort("girlmail.ru")) && ((int) domainId != (int) Conversions.ToShort("boymail.ru") && (int) domainId != (int) Conversions.ToShort("megabox.ru")))
            {
              if ((int) domainId != (int) Conversions.ToShort("safebox.ru"))
                break;
            }
            this.popConn[index1].POPConnect("pop.km.ru", _VARIABLES.MailInfo[index2].login + "@" + _VARIABLES.MailInfo[index2].domain, _VARIABLES.MailInfo[index2].password);
            break;
        }
      }
      catch (POP3Exception ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        POP3Exception poP3Exception = ex;
        if (Operators.CompareString(Strings.Left(poP3Exception.Message, 32), "POP3 ERROR: -ERR Access for user", false) == 0)
        {
          this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# MAIL.RU: Почтовый ящик закрыт за неиспользование.\r\n");
          _VARIABLES.MailInfo[index2].Registered = (short) 7;
          ProjectData.ClearProjectError();
          goto label_46;
        }
        else
        {
          this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# POP3Ex: " + poP3Exception.Message + "\r\n");
          _VARIABLES.MailInfo[index2].Registered = (short) 4;
          ProjectData.ClearProjectError();
          goto label_46;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# Ex: " + exception.Message + "\r\n");
        _VARIABLES.MailInfo[index2].Registered = (short) 4;
        ProjectData.ClearProjectError();
        goto label_46;
      }
      int num1;
      try
      {
        num1 = this.popConn[index1].STAT();
      }
      catch (POP3Exception ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        POP3Exception poP3Exception = ex;
        this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# POP3Ex STAT: " + poP3Exception.Message + "\r\n");
        _VARIABLES.MailInfo[index2].Registered = (short) 4;
        ProjectData.ClearProjectError();
        goto label_41;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# Ex: " + exception.Message + "\r\n");
        _VARIABLES.MailInfo[index2].Registered = (short) 4;
        ProjectData.ClearProjectError();
        goto label_41;
      }
      switch (_VARIABLES.MailInfo[index2].DomainID)
      {
        case 2:
          if (_VARIABLES.MailInfo[index2].comment.Length == 0)
          {
            _VARIABLES.MailInfo[index2].comment = "POP3/SMTP unlocked";
            break;
          }
          break;
      }
      _VARIABLES.MailInfo[index2].Registered = (short) 3;
      _VARIABLES.meMailInfo[] mailInfo = _VARIABLES.MailInfo;
      _VARIABLES.meMailInfo[] meMailInfoArray = mailInfo;
      int index3 = index2;
      int index4 = index3;
      meMailInfoArray[index4].MailAmount = checked (mailInfo[index3].MailAmount + num1);
      checked { _VARIABLES.DownloadMailCount += num1; }
      if (num1 == 0)
      {
        this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# На почтовом ящике: " + _VARIABLES.MailInfo[index2].login + " нет писем.\r\n");
      }
      else
      {
        this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# eMail: " + _VARIABLES.MailInfo[index2].login + " писем: " + Conversions.ToString(num1) + "\r\n");
        int num2 = 1;
        int num3 = num1;
        int num4 = num2;
        while (num4 <= num3)
        {
          string str1;
          try
          {
            str1 = this.popConn[index1].RETR(num4);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# RETR Ex: " + exception.Message + "\r\n");
            ProjectData.ClearProjectError();
            goto label_39;
          }
          int num5 = Strings.InStr(str1, "charset=", CompareMethod.Binary);
          if (num5 > 0)
          {
            int Start = checked (num5 + 8);
            int num6 = Strings.InStr(Start, str1, "\r", CompareMethod.Binary);
            string lower = Strings.Mid(str1, Start, checked (num6 - Start)).Replace("\"", "").ToLower();
            if (Operators.CompareString(lower, "cp1251", false) != 0 && Operators.CompareString(lower, "windows-1251", false) != 0 && Operators.CompareString(lower, "utf-8", false) == 0)
              str1 = Encoding.UTF8.GetString(Encoding.Default.GetBytes(str1));
          }
          int num7 = Strings.InStr(str1, "from: ", CompareMethod.Text);
          string str2;
          if (num7 > 0)
          {
            int Start1 = checked (num7 + 6);
            int num6 = Strings.InStr(Start1, str1, "\r\n", CompareMethod.Binary);
            str2 = Strings.Mid(str1, Start1, checked (num6 - Start1));
            int Start2 = Strings.InStr(str2, "<", CompareMethod.Binary);
            if (Start2 > 0)
            {
              int num8 = checked (Strings.InStr(Start2, str2, ">", CompareMethod.Binary) + 1);
              str2 = Strings.Mid(str2, Start2, checked (num8 - Start2));
            }
          }
          else
            str2 = "unknown";
          this.txtBuffer_LoadMail[index1].Append("From: " + str2 + "\r\n");
          try
          {
            if (!_VARIABLES.OP.OptMail.DeleteMail)
            {
              if (_VARIABLES.OP.OptMail.SaveMailOneFile != 2)
                goto label_38;
            }
            this.popConn[index1].DELE(num4);
          }
          catch (POP3Exception ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            POP3Exception poP3Exception = ex;
            this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# POP3Ex DELE: " + poP3Exception.Message + "\r\n");
            ProjectData.ClearProjectError();
            break;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# Ex: " + exception.Message + "\r\n");
            ProjectData.ClearProjectError();
            break;
          }
label_38:
          stringBuilder.Append(str1 + "\r\n\r\n\r\n");
label_39:
          checked { ++num4; }
        }
      }
label_41:
      try
      {
        this.popConn[index1].QUIT();
      }
      catch (POP3Exception ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        POP3Exception poP3Exception = ex;
        this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# POP3Ex QUIT: " + poP3Exception.Message + "\r\n");
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# Ex: " + exception.Message + "\r\n");
        ProjectData.ClearProjectError();
      }
      this.txtBuffer_LoadMail[index1].Append("Сессия " + _VARIABLES.MailInfo[index2].login + " закрыта.\r\n");
label_46:
      try
      {
        if (stringBuilder.Length > 0)
        {
          if (_VARIABLES.OP.OptMail.SaveMailOneFile == 0)
          {
            string FullPath = Application.StartupPath + "\\MAIL\\all-mail.txt";
            if (_VARIABLES.OP.OptMail.AppendMail)
            {
              string StrBuffer = stringBuilder.ToString();
              _LOADSAVE.FileAppend(ref FullPath, ref StrBuffer);
              this.txtBuffer_LoadMail[index1].Append("Acc #" + Conversions.ToString(index2) + " Append to file '\\MAIL\\all-mail.txt'\r\n");
            }
            else
            {
              string StrBuffer = stringBuilder.ToString();
              _LOADSAVE.FileSave(ref FullPath, ref StrBuffer);
              this.txtBuffer_LoadMail[index1].Append("Acc #" + Conversions.ToString(index2) + " Save file to '\\MAIL\\all-mail.txt'\r\n");
            }
          }
          else if (_VARIABLES.OP.OptMail.SaveMailOneFile == 1)
          {
            string str = _VARIABLES.MailInfo[index2].login + "@" + _VARIABLES.MailInfo[index2].domain;
            string FullPath = Application.StartupPath + "\\MAIL\\" + str;
            if (_VARIABLES.OP.OptMail.AppendMail)
            {
              string StrBuffer = stringBuilder.ToString();
              _LOADSAVE.FileAppend(ref FullPath, ref StrBuffer);
              this.txtBuffer_LoadMail[index1].Append("Acc #" + Conversions.ToString(index2) + " Append to file \\MAIL\\" + str + "\r\n");
            }
            else
            {
              string StrBuffer = stringBuilder.ToString();
              _LOADSAVE.FileSave(ref FullPath, ref StrBuffer);
              this.txtBuffer_LoadMail[index1].Append("Acc #" + Conversions.ToString(index2) + " Save file to \\MAIL\\" + str + "\r\n");
            }
          }
          else if (_VARIABLES.OP.OptMail.SaveMailOneFile == 2)
            this.txtBuffer_LoadMail[index1].Append("Acc #" + Conversions.ToString(index2) + " Delete\r\n");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.txtBuffer_LoadMail[index1].Append(Conversions.ToString(index2) + "# Ошибка при сохранении писем: " + exception.Message);
        ProjectData.ClearProjectError();
      }
      this.txtBuffer_LoadMail[index1].Append("==============================================");
    }

    private void chAllMail_CheckedChanged(object sender, EventArgs e)
    {
      this.DownloadAllMail = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      _INI.SaveINI("Globals", "chAllMail", Conversions.ToString(this.chAllMail.Checked));
    }

    private void LV_Dostupno_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
      if (_VARIABLES.ThreadWS > 1)
      {
        this.lblActionInSelect.Text = "Потоков > 1 (выбор вручную невозможен)";
      }
      else
      {
        int itemIndex = e.ItemIndex;
        int index = 1;
        string[] strArray = _VARIABLES.CurThreadData[index].FreeMailDomain[itemIndex].Split('@');
        _VARIABLES.MailInfo[_VARIABLES.Mirror[index]].login = strArray[0];
        _VARIABLES.MailInfo[_VARIABLES.Mirror[index]].domain = strArray[1];
        switch (_VARIABLES.MailInfo[_VARIABLES.Mirror[index]].DomainID)
        {
          case 0:
            _VARIABLES.CurThreadData[1].CurrentMailToReg = _VARIABLES.CurThreadData[index].FreeMailDomain[itemIndex];
            _VARIABLES.CurThreadData[index].PostDataVariable[25] = _VARIABLES.MailInfo[_VARIABLES.Mirror[index]].login;
            _VARIABLES.CurThreadData[index].PostDataVariable[26] = _VARIABLES.MailInfo[_VARIABLES.Mirror[index]].domain;
            break;
        }
        this.LV_Merge(_VARIABLES.Mirror[index]);
        this.txtCurrentMail.Text = _VARIABLES.CurThreadData[index].FreeMailDomain[itemIndex];
      }
    }

    private void txtCurrentMail_KeyUp(object sender, KeyEventArgs e)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void btmSaveList_Click(object sender, EventArgs e)
    {
      this.SaveFileDialog1.FileName = "";
      int num1 = (int) this.SaveFileDialog1.ShowDialog();
      string fileName = this.SaveFileDialog1.FileName;
      if (Strings.Len(fileName) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Не выбран файл для сохранения.", MsgBoxStyle.Exclamation, (object) "Ошибка сохранения");
      }
      else
      {
        string separatorInLine = _VARIABLES.OP.OpSaveList.SeparatorInLine;
        string separatorLine = _VARIABLES.OP.OpSaveList.SeparatorLine;
        StringBuilder stringBuilder = new StringBuilder("");
        int num3 = 0;
        int num4 = 1;
        int num5 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
        int index = num4;
        while (index <= num5)
        {
          if (_VARIABLES.OP.OpSaveList.SaveToAll == 0)
          {
            if ((int) _VARIABLES.MailInfo[index].Registered < 2 | (int) _VARIABLES.MailInfo[index].Registered > 3)
              goto label_13;
          }
          else if (!this.LV.Items[checked (index - 1)].Selected)
            goto label_13;
          stringBuilder.Append(_VARIABLES.MailInfo[index].login);
          if (_VARIABLES.OP.OpSaveList.SaveDomain)
            stringBuilder.Append("@" + _VARIABLES.MailInfo[index].domain);
          stringBuilder.Append(separatorInLine + _VARIABLES.MailInfo[index].password);
          if (_VARIABLES.OP.OpSaveList.SaveSecretAnswer)
            stringBuilder.Append(separatorInLine + _VARIABLES.MailInfo[index].RegUserData.SecretAnswer);
          if (_VARIABLES.OP.OpSaveList.SaveLastnameName)
            stringBuilder.Append(separatorInLine + _VARIABLES.MailInfo[index].RegUserData.Name + separatorInLine + _VARIABLES.MailInfo[index].RegUserData.LastName);
          stringBuilder.Append(separatorLine);
          checked { ++num3; }
label_13:
          checked { ++index; }
        }
        int FileNumber = FileSystem.FreeFile();
        string str = stringBuilder.ToString();
        if (!_VARIABLES.OP.OpSaveList.AppendFile && File.Exists(fileName))
          FileSystem.Kill(fileName);
        FileSystem.FileOpen(FileNumber, fileName, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1);
        if (_VARIABLES.OP.OpSaveList.AppendFile)
        {
          int num6 = checked ((int) (FileSystem.FileLen(fileName) + 1L));
          FileSystem.FilePut(FileNumber, str, (long) num6, false);
        }
        else
          FileSystem.FilePut(FileNumber, str, -1L, false);
        FileSystem.FileClose(FileNumber);
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        string sText1 = "Удачно сохранено " + Conversions.ToString(num3) + " зарегистрированных аккаунтов.";
        fn1.TXT(ref sText1);
        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
        string sText2 = "Выходной файл:\r\n" + fileName;
        fn2.TXT(ref sText2);
      }
    }

    private void btmGenMailOptions_Click(object sender, EventArgs e)
    {
      int num = (int) MyProject.Forms.frmGenBlank.ShowDialog();
    }

    private void btmAccSel_Del_Click(object sender, EventArgs e)
    {
      if (this.LV.SelectedItems.Count == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Не выбран аккаунт для удаления.", MsgBoxStyle.Exclamation, (object) "MailBox@Reg");
      }
      else
      {
        int sNum = checked (this.LV.SelectedItems[0].Index + 1);
        if (this.LV.SelectedItems.Count == 1)
        {
          if (Interaction.MsgBox((object) ("Вы действительно желаете удалить аккаунт " + _VARIABLES.MailInfo[sNum].login + "@" + _VARIABLES.MailInfo[sNum].domain + "?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Удаление") == MsgBoxResult.No)
            return;
          this.LV.Items[checked (sNum - 1)].Remove();
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Аккаунт " + _VARIABLES.MailInfo[sNum].login + "@" + _VARIABLES.MailInfo[sNum].domain + " удален.";
          fn.TXT(ref sText);
          int num2 = sNum;
          int num3 = checked (Information.UBound((Array) _VARIABLES.MailInfo, 1) - 1);
          int index = num2;
          while (index <= num3)
          {
            _VARIABLES.MailInfo[index] = _VARIABLES.MailInfo[checked (index + 1)];
            this.LV.Items[checked (index - 1)].SubItems[0].Text = Conversions.ToString(index);
            checked { ++index; }
          }
          _VARIABLES.MailInfo = (_VARIABLES.meMailInfo[]) Utils.CopyArray((Array) _VARIABLES.MailInfo, (Array) new _VARIABLES.meMailInfo[checked (Information.UBound((Array) _VARIABLES.MailInfo, 1) - 1 + 1)]);
          _LOADSAVE.SaveALL_MailInfo();
        }
        else
        {
          if (Interaction.MsgBox((object) ("Вы действительно желаете удалить " + Conversions.ToString(this.LV.SelectedItems.Count) + " mailbox?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Удаление") == MsgBoxResult.No)
            return;
          this.lblBUSY.Visible = true;
          this.lblBUSY.Refresh();
          _FUNCTION.SpeedTest(true);
          IEnumerator enumerator = this.LV.SelectedItems.GetEnumerator();
          int count = this.LV.SelectedItems.Count;
          int num2 = 1;
          int num3 = count;
          int num4 = num2;
          while (num4 <= num3)
          {
            enumerator.MoveNext();
            ListViewItem current = (ListViewItem) enumerator.Current;
            _VARIABLES.MailInfo[Conversions.ToInteger(current.Text)].Registered = (short) -1;
            checked { ++num4; }
          }
          _FUNCTION.SpeedTest(false);
          _VARIABLES.meMailInfo[] meMailInfoArray = new _VARIABLES.meMailInfo[checked (Information.UBound((Array) _VARIABLES.MailInfo, 1) - count + 1)];
          int index1 = 0;
          int num5 = 1;
          int num6 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
          int index2 = num5;
          while (index2 <= num6)
          {
            if ((int) _VARIABLES.MailInfo[index2].Registered > -1)
            {
              checked { ++index1; }
              meMailInfoArray[index1] = _VARIABLES.MailInfo[index2];
            }
            checked { ++index2; }
          }
          _VARIABLES.MailInfo = meMailInfoArray;
          MailRegUnicore._LV.LV_ADD_ALL();
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Удалено " + Conversions.ToString(count) + " mailbox.";
          fn.TXT(ref sText);
          _LOADSAVE.SaveALL_MailInfo();
        }
        if (Information.UBound((Array) _VARIABLES.MailInfo, 1) == 0)
        {
          this.txtAccSel_Comment.Text = "";
          this.txtAccSel_Login.Text = "";
          this.txtAccSel_Password.Text = "";
          this.txtAccSel_SecretAnswer.Text = "";
          this.txtAccSel_SecretQuestion.Text = "";
          this.cmbReg.SelectedIndex = 0;
          this.lblAccSelNUM.Text = Conversions.ToString(0);
        }
        _FUNCTION.AccountSelect(sNum);
        this.lblBUSY.Visible = false;
      }
    }

    private void tmrHelp_Tick(object sender, EventArgs e)
    {
      this.tmrHelp.Interval = 7000;
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) this.\u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep\u0024Init, ref lockTaken);
        if ((int) this.\u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep\u0024Init.State == 0)
        {
          this.\u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep\u0024Init.State = (short) 2;
          this.\u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep = (short) 0;
        }
        else if ((int) this.\u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep\u0024Init.State == 2)
          throw new IncompleteInitialization();
      }
      finally
      {
        this.\u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep\u0024Init.State = (short) 1;
        if (lockTaken)
          Monitor.Exit((object) this.\u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep\u0024Init);
      }
      checked { ++this.\u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep; }
      switch (this.\u0024STATIC\u0024tmrHelp_Tick\u002420211C128091\u0024sStep)
      {
        case 1:
          MyProject.Forms.frmGenBlank.Button2_Click((object) null, (EventArgs) null);
          Point point1;
          point1.X = 350;
          point1.Y = 120;
          this.ToolTip1.Show("", (IWin32Window) this.LV, point1, 1);
          this.ToolTip1.Show("Первый старт программы.\r\nСгенерировано 1000 заготовок e-Mail для регистрации.", (IWin32Window) this.LV, point1, 7000);
          break;
        case 2:
          Point point2;
          point2.X = 58;
          point2.Y = 18;
          this.ToolTip1.Show("", (IWin32Window) this.btmGenMailOptions, point2, 1);
          this.ToolTip1.Show("Далее, вы сможете сами генерировать заготовки\r\n для регистрации, нажав эту кнопку.", (IWin32Window) this.btmGenMailOptions, point2, 7000);
          this.tmrHelp.Enabled = false;
          break;
      }
    }

    private void chAutoUpdate_Click(object sender, EventArgs e)
    {
      if (!this.chAutoUpdate.Checked)
        return;
      int num = (int) Interaction.MsgBox((object) "При следующих стартах, программа будет проверять наличие новых версий.\r\nВозможно,  потребуется настроенное правило в Firewall'e:\r\nРазрешенный ресурс: L2-ru.com\r\nПорт: 80\r\n\r\nПроверку всегда можно отключить, просто, убрав галочку.\r\n", MsgBoxStyle.Information, (object) "Проверка новых версий программы");
    }

    private void tmrUpdate_Tick(object sender, EventArgs e)
    {
      this.tmrUpdate.Enabled = false;
      int set_Index = 1;
      mySocketConnectedCounter set_SocketConnectedCounter = (mySocketConnectedCounter) null;
      myIsBusyCounter set_IsBusyCounter = (myIsBusyCounter) null;
      _VARIABLES.WSupdate = new SocketNET(set_Index, ref set_SocketConnectedCounter, ref set_IsBusyCounter);
      _VARIABLES.WSupdate.DataArrival += new SocketNET.DataArrivalEventHandler(this.DataArrivalUPDATE);
      _VARIABLES.WSupdate.ErrorEvent += new SocketNET.ErrorEventEventHandler(this.ErrorEventUPDATE);
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Идет проверка обновлений.";
      fn.TXT(ref sText);
      SocketNET wsupdate = _VARIABLES.WSupdate;
      string set_URL = "http://soft.l2-ru.com/checkupdate.php?Mailbox@Reg";
      myCookies set_Cookies = (myCookies) null;
      string set_Referer = (string) null;
      string set_PostData = (string) null;
      // ISSUE: variable of the null type
      __Null local = null;
      short set_UseBrowser = 0;
      string set_X_Forwarded_For = (string) null;
      string set_ContentType = (string) null;
      object set_Accept_Charset = (object) 1251;
      string set_Headers_Add = (string) null;
      wsupdate.Connect(ref set_URL, ref set_Cookies, ref set_Referer, ref set_PostData, (myProxy) local, ref set_UseBrowser, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
    }

    public void DataArrivalUPDATE(int Index)
    {
      string packetBody = _VARIABLES.WSupdate.PacketBODY;
      if (Operators.CompareString(Strings.Left(packetBody, 7), "unicore", false) != 0)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ошибка ответа от сервера обновлений.";
        fn.TXT(ref sText);
      }
      else
      {
        int Start1 = checked (Strings.InStr(packetBody, "ver: ", CompareMethod.Binary) + 5);
        int num1 = Strings.InStr(Start1, packetBody, "<", CompareMethod.Binary);
        int integer = Conversions.ToInteger(Strings.Mid(packetBody, Start1, checked (num1 - Start1)));
        if (174 < integer)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Доступна для скачивания новая версия программы v" + _VARIABLES.VER(integer);
          fn.TXT(ref sText);
          int Start2 = checked (Strings.InStr(packetBody, "~!~", CompareMethod.Binary) + 3);
          int num2 = Strings.InStr(Start2, packetBody, "~!~", CompareMethod.Binary);
          TextBox txtMon = this.txtMon;
          txtMon.Text = txtMon.Text + Strings.Mid(packetBody, Start2, checked (num2 - Start2)) + "\r\n";
        }
        else
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "У вас последняя версия программы v" + _VARIABLES.VER(174);
          fn.TXT(ref sText);
        }
      }
    }

    public void ErrorEventUPDATE(int Index, ref string Description)
    {
      _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
      string sText1 = "Ошибка коннекта к серверу обновлений. Проверьте подключение к интернету.";
      fn1.TXT(ref sText1);
      _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
      string sText2 = "Error: " + Description;
      fn2.TXT(ref sText2);
    }

    private void LV_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
    {
      _INI.SaveINI("LV", "ColumnWidth_" + Conversions.ToString(e.ColumnIndex), this.LV.Columns[e.ColumnIndex].Width.ToString());
    }

    private void LV_HandleCreated(object sender, EventArgs e)
    {
      int num1 = 0;
      int num2 = checked (this.LV.Columns.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        int num3 = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("LV", "ColumnWidth_" + Conversions.ToString(index)))));
        if (num3 < 15)
          num3 = 15;
        this.LV.Columns[index].Width = num3;
        checked { ++index; }
      }
    }

    private void LV_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void picBanner_Click(object sender, EventArgs e)
    {
      Process.Start("http://l2-ru.com/");
    }

    private void picAutoCaptchaEnable_Paint(object sender, PaintEventArgs e)
    {
      SolidBrush solidBrush = new SolidBrush(Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue));
      e.Graphics.DrawString("    auto\r\nCAPTCHA", new Font("Tahoma", 10f, FontStyle.Bold), (Brush) solidBrush, 80f, 8f);
    }

    private void chReport_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Report", Conversions.ToString(Operators.ConcatenateObject((object) "chReport_", NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null))), Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "5", false))
      {
        _VARIABLES.OP.ViewResponse = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
        if (_VARIABLES.OP.ViewResponse)
        {
          this.LV.Columns[6].Text = "Response (ms)";
          this.LV.Columns[7].Text = "Route";
        }
        else
        {
          this.LV.Columns[6].Text = "Mail Count";
          this.LV.Columns[7].Text = "Comment";
        }
      }
      else
        _VARIABLES.OptionReport[Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null))] = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
    }

    private void tmrLoadProgram_Tick(object sender, EventArgs e)
    {
      try
      {
        this.tmrLoadProgram.Stop();
        string[] strArray = new string[checked (this.IL_LV.Images.Count - 1 + 1)];
        int num1 = 0;
        int num2 = checked (this.IL_LV.Images.Count - 1);
        int index = num1;
        while (index <= num2)
        {
          strArray[index] = "Item " + index.ToString();
          checked { ++index; }
        }
        this.cmbReg.Items.AddRange((object[]) strArray);
        this.cmbReg.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbReg.DrawMode = DrawMode.OwnerDrawVariable;
        this.cmbReg.ItemHeight = this.IL_LV.ImageSize.Height;
        this.cmbReg.Width = checked (this.IL_LV.ImageSize.Width + 24);
        this.cmbReg.MaxDropDownItems = this.IL_LV.Images.Count;
        frmGenBlank frmGenBlank = MyProject.Forms.frmGenBlank;
        int num3 = 1;
        do
        {
          frmGenBlank.cmbDoubleGlas.Items.Add((object) (Conversions.ToString(num3) + " %"));
          frmGenBlank.cmbDoubleSOglas.Items.Add((object) (Conversions.ToString(num3) + " %"));
          frmGenBlank.cmbUseNumPercent.Items.Add((object) (Conversions.ToString(num3) + " %"));
          frmGenBlank.cmbDopPercent_1.Items.Add((object) (Conversions.ToString(num3) + " %"));
          frmGenBlank.cmbDopPercent_2.Items.Add((object) (Conversions.ToString(num3) + " %"));
          frmGenBlank.cmbDopPercent_3.Items.Add((object) (Conversions.ToString(num3) + " %"));
          frmGenBlank.cmbDopPercent_4.Items.Add((object) (Conversions.ToString(num3) + " %"));
          checked { ++num3; }
        }
        while (num3 <= 100);
        int num4 = 1910;
        do
        {
          frmGenBlank.cmbUserYearBD.Items.Add((object) num4);
          checked { ++num4; }
        }
        while (num4 <= 2011);
        frmGenBlank.cmbUseNum.Items.Add((object) "md0");
        frmGenBlank.cmbUseNum.Items.Add((object) "md1");
        frmGenBlank.cmbUseNum.Items.Add((object) "md2");
        frmGenBlank.cmbUseNum.Items.Add((object) "md3");
        frmGenBlank.cmbUseNum.Items.Add((object) "md4");
        frmGenBlank.cmbUseNum.Items.Add((object) "md5");
        frmGenBlank.cmbUseNum.Items.Add((object) "md6");
        frmGenBlank.cmbUseNum.Items.Add((object) "md7");
        frmGenBlank.cmbUseNum.Items.Add((object) "md8");
        frmGenBlank.cmbUseNum.Items.Add((object) "md9");
        frmGenBlank.cmbUseNum.Items.Add((object) "md10");
        _VARIABLES.MailService = new _VARIABLES.meMailService[5];
        _VARIABLES.MailService[0].Name = "MAIL.RU";
        _VARIABLES.MailService[0].DomainCNT = 4;
        _VARIABLES.MailService[0].domain = new string[checked (_VARIABLES.MailService[0].DomainCNT + 1)];
        _VARIABLES.MailService[0].domain[0] = "mail.ru";
        _VARIABLES.MailService[0].domain[1] = "inbox.ru";
        _VARIABLES.MailService[0].domain[2] = "bk.ru";
        _VARIABLES.MailService[0].domain[3] = "list.ru";
        _VARIABLES.MailService[0].domain[4] = "mail.ua";
        _VARIABLES.MailService[1].Name = "QIP.RU";
        _VARIABLES.MailService[1].DomainCNT = 23;
        _VARIABLES.MailService[1].domain = new string[checked (_VARIABLES.MailService[1].DomainCNT + 1)];
        _VARIABLES.MailService[1].domain[0] = "qip.ru";
        _VARIABLES.MailService[1].domain[1] = "pochta.ru";
        _VARIABLES.MailService[1].domain[2] = "fromru.com";
        _VARIABLES.MailService[1].domain[3] = "front.ru";
        _VARIABLES.MailService[1].domain[4] = "hotbox.ru";
        _VARIABLES.MailService[1].domain[5] = "hotmail.ru";
        _VARIABLES.MailService[1].domain[6] = "krovatka.su";
        _VARIABLES.MailService[1].domain[7] = "land.ru";
        _VARIABLES.MailService[1].domain[8] = "mail15.com";
        _VARIABLES.MailService[1].domain[9] = "mail333.com";
        _VARIABLES.MailService[1].domain[10] = "newmail.ru";
        _VARIABLES.MailService[1].domain[11] = "nightmail.ru";
        _VARIABLES.MailService[1].domain[12] = "nm.ru";
        _VARIABLES.MailService[1].domain[13] = "pisem.net";
        _VARIABLES.MailService[1].domain[14] = "pochtamt.ru";
        _VARIABLES.MailService[1].domain[15] = "pop3.ru";
        _VARIABLES.MailService[1].domain[16] = "rbcmail.ru";
        _VARIABLES.MailService[1].domain[17] = "smtp.ru";
        _VARIABLES.MailService[1].domain[18] = "5ballov.ru";
        _VARIABLES.MailService[1].domain[19] = "aeterna.ru";
        _VARIABLES.MailService[1].domain[20] = "ziza.ru";
        _VARIABLES.MailService[1].domain[21] = "memori.ru";
        _VARIABLES.MailService[1].domain[22] = "photofile.ru";
        _VARIABLES.MailService[1].domain[23] = "fotoplenka.ru";
        _VARIABLES.MailService[2].Name = "META.UA";
        _VARIABLES.MailService[2].DomainCNT = 0;
        _VARIABLES.MailService[2].domain = new string[checked (_VARIABLES.MailService[0].DomainCNT + 1)];
        _VARIABLES.MailService[2].domain[0] = "meta.ua";
        _VARIABLES.MailService[3].Name = "YANDEX.RU";
        _VARIABLES.MailService[3].DomainCNT = 0;
        _VARIABLES.MailService[3].domain = new string[checked (_VARIABLES.MailService[2].DomainCNT + 1)];
        _VARIABLES.MailService[3].domain[0] = "yandex.ru";
        _VARIABLES.MailService[4].Name = "KM.RU";
        _VARIABLES.MailService[4].DomainCNT = 6;
        _VARIABLES.MailService[4].domain = new string[checked (_VARIABLES.MailService[4].DomainCNT + 1)];
        _VARIABLES.MailService[4].domain[0] = "km.ru";
        _VARIABLES.MailService[4].domain[1] = "freemail.ru";
        _VARIABLES.MailService[4].domain[2] = "bossmail.ru";
        _VARIABLES.MailService[4].domain[3] = "girlmail.ru";
        _VARIABLES.MailService[4].domain[4] = "boymail.ru";
        _VARIABLES.MailService[4].domain[5] = "megabox.ru";
        _VARIABLES.MailService[4].domain[6] = "safebox.ru";
        _FUNCTION.LoadData();
        _INI.RegCreateSubkey();
        short num5 = checked ((short) Math.Round(unchecked (Conversion.Val((object) _INI.RegLoad("FirstStart")) + 1.0)));
        string sText1;
        if ((int) num5 < 2)
        {
          this.tmrHelp.Interval = 2000;
          this.tmrHelp.Enabled = true;
          _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
          string sText2 = "Первый старт программы, приветствуем Вас.";
          fn1.TXT(ref sText2);
          _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
          sText1 = "Если Вы не знаете, что делать, просто, нажмите кнопку 'START'";
          fn2.TXT(ref sText1);
        }
        _INI.RegSave("FirstStart", Conversions.ToString((int) num5));
        int sNum = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Global", "Item"))));
        if (sNum > this.LV.Items.Count)
          sNum = 1;
        _FUNCTION.AccountSelect(sNum);
        if (this.chAutoUpdate.Checked)
          this.tmrUpdate.Enabled = true;
        _FUNCTION.VisibleCapcta(-1);
        if (!_VARIABLES.UseErrorCount)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          sText1 = "Внимание! У вас не включена опция остановки регистрации при превышении лимита счетчика ошибок.\r\n Включить опцию можно в настройках";
          fn.TXT(ref sText1);
        }
        this.picWait.Visible = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ошибка загрузки программы: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    private void tmrInfo_Tick(object sender, EventArgs e)
    {
      if (_VARIABLES.OP.ViewResponse && !Information.IsNothing((object) _VARIABLES.WS))
      {
        int num = 1;
        int threadWs = _VARIABLES.ThreadWS;
        int index = num;
        while (index <= threadWs)
        {
          if (_VARIABLES.WS[index].IsBusy)
          {
            this.LV.Items[checked (_VARIABLES.Mirror[index] - 1)].SubItems[6].Text = Conversions.ToString(_VARIABLES.WS[index].Response);
            this.LV.Items[checked (_VARIABLES.Mirror[index] - 1)].SubItems[7].Text = _VARIABLES.WS[index].ConnectTo;
          }
          checked { ++index; }
        }
      }
      if (_VARIABLES.OP.AutoCAPTCHA)
      {
        if (_VARIABLES.AC_NET.CapCounter.NO_SLOT_AVAILABLE > 0)
          this.INFO_12.ForeColor = Color.Brown;
        else
          this.INFO_12.ForeColor = Color.Black;
        this.INFO_1.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_Loaded);
        this.INFO_2.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_Solved);
        this.INFO_3.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_ERROR_);
        this.INFO_4.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_TimeLimit);
        this.INFO_5.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_OK);
        this.INFO_6.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_Wrong);
        this.INFO_7.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_Lost);
        this.INFO_8.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_BL_Start);
        this.INFO_9.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_BL_Current);
        this.INFO_10.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_BL_Expense);
        this.INFO_11.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.IsBusy);
        this.INFO_12.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.NO_SLOT_AVAILABLE);
        this.INFO_13.Text = Conversions.ToString(_VARIABLES.IsConnected.Counter);
        if (!_VARIABLES.DoWork_Reg)
        {
          if (!_FUNCTION.Locked)
            return;
          if (_VARIABLES.AC_NET.CapCounter.IsBusy > 0 | _VARIABLES.IsConnected.Counter > 0)
          {
            this.INFO_11.ForeColor = Color.Red;
          }
          else
          {
            this.tmrInfo.Stop();
            this.INFO_11.ForeColor = Color.Black;
            _FUNCTION.UnLockedALL();
            _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
            string sText = "Все коннекты остановлены.";
            fn1.TXT(ref sText);
            _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
            sText = "Все CAPTCHA возвращены.";
            fn2.TXT(ref sText);
            this.btmStart.Enabled = true;
            if (Operators.CompareString(_INI.LoadINI("SQL", "chAutoSave").ToLower(), "true", false) == 0)
              md_MySQL.UploadTo_MySQL();
            if (!md_HttpLoadProxy.HttpLoadProxy.Use || !md_HttpLoadProxy.HttpLoadProxy.LoadRequired)
              return;
            md_HttpLoadProxy.Start_HttpLoadProxy();
          }
        }
        else
        {
          int num1 = checked ((int) Math.Round(unchecked ((double) _VARIABLES.AC_NET.CapCounter.Cap_OK / (double) _VARIABLES.AC_NET.globalSW.ElapsedMilliseconds / 3600000.0)));
          int num2 = checked ((int) Math.Round(unchecked ((double) _VARIABLES.ProxySpeed / (double) _VARIABLES.AC_NET.globalSW.ElapsedMilliseconds / 3600000.0)));
          if (num1 < 0)
            num1 = 0;
          if (num2 < 0)
            num2 = 0;
          this.stlbl_CurProxy_2.Text = Conversions.ToString(mdConnect.ProxCNT);
          this.stlbl_Speed_1.Text = Conversions.ToString(num1) + " em/h";
          this.stlbl_Speed_2.Text = Conversions.ToString(num2) + " prx/h";
        }
      }
      else
      {
        this.INFO_5.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_OK);
        this.INFO_6.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_Wrong);
        this.INFO_7.Text = Conversions.ToString(_VARIABLES.AC_NET.CapCounter.Cap_Lost);
        int num1 = checked ((int) Math.Round(unchecked ((double) _VARIABLES.AC_NET.CapCounter.Cap_OK / (double) _VARIABLES.AC_NET.globalSW.ElapsedMilliseconds / 3600000.0)));
        int num2 = checked ((int) Math.Round(unchecked ((double) _VARIABLES.ProxySpeed / (double) _VARIABLES.AC_NET.globalSW.ElapsedMilliseconds / 3600000.0)));
        if (num1 < 0)
          num1 = 0;
        if (num2 < 0)
          num2 = 0;
        this.stlbl_CurProxy_2.Text = Conversions.ToString(mdConnect.ProxCNT);
        this.stlbl_Speed_1.Text = Conversions.ToString(num1) + " em/h";
        this.stlbl_Speed_2.Text = Conversions.ToString(num2) + " prx/h";
      }
    }

    private void tmrMailDownload_Tick(object sender, EventArgs e)
    {
      if (_VARIABLES.PauseConnect)
        return;
      int num1 = 1;
      int threadWs = _VARIABLES.ThreadWS;
      int index = num1;
      while (index <= threadWs)
      {
        if (this.LoadMail_FreeSocket[index])
        {
          this.LoadMail_FreeSocket[index] = false;
          checked { ++_VARIABLES.CountUserInfo; }
          if (_VARIABLES.CountUserInfo > Information.UBound((Array) _VARIABLES.MailInfo, 1))
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Закончились аккаунты.";
            fn.TXT(ref sText);
            this.StopMailDownload();
            break;
          }
          int countUserInfo = _VARIABLES.CountUserInfo;
          int num2 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
          int sNum = countUserInfo;
          while (sNum <= num2 && ((int) _VARIABLES.MailInfo[sNum].Registered < 2 || (int) _VARIABLES.MailInfo[sNum].Registered > 4) && (int) _VARIABLES.MailInfo[sNum].Registered != 7)
            checked { ++sNum; }
          _VARIABLES.CountUserInfo = sNum;
          if (sNum > Information.UBound((Array) _VARIABLES.MailInfo, 1))
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Закончились аккаунты.";
            fn.TXT(ref sText);
            this.StopMailDownload();
            break;
          }
          _VARIABLES.Mirror[index] = sNum;
          _FUNCTION.AccountSelect(sNum);
          this.BW_LoadMail[index].RunWorkerAsync();
        }
        checked { ++index; }
      }
    }

    private void btnOpenMail_Click(object sender, EventArgs e)
    {
      if (this.LV.Items.Count == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "У вас нет почтовых ящиков.", MsgBoxStyle.Exclamation, (object) "MailBox@Reg");
      }
      else
      {
        int index = checked (this.LV.SelectedItems[0].Index + 1);
        string str;
        if (_VARIABLES.OP.OptMail.SaveMailOneFile == 0)
        {
          str = Application.StartupPath + "\\MAIL\\all-mail.txt";
          if (!File.Exists(str))
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Отсутствует файл:\r\n" + str;
            fn.TXT(ref sText);
            return;
          }
        }
        else
        {
          if (this.LV.SelectedItems.Count == 0)
          {
            int num2 = (int) Interaction.MsgBox((object) "У вас не выбран почтовый ящик.", MsgBoxStyle.Exclamation, (object) "MailBox@Reg");
            return;
          }
          str = Application.StartupPath + "\\MAIL\\" + (_VARIABLES.MailInfo[index].login + "@" + _VARIABLES.MailInfo[index].domain);
          if (!File.Exists(str))
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Отсутствует файл:\r\n" + str;
            fn.TXT(ref sText);
            return;
          }
        }
        try
        {
          Process.Start(str);
        }
        catch (Win32Exception ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Произошла ошибка при открытии файла.";
          fn.TXT(ref sText);
          ProjectData.ClearProjectError();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Произошла ошибка при открытии файла.";
          fn.TXT(ref sText);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void btnOpenProxy_Click(object sender, EventArgs e)
    {
      string path = Application.StartupPath + "\\Data\\proxy.txt";
      if (!File.Exists(path))
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Отсутствует файл:\r\n" + path;
        fn.TXT(ref sText);
      }
      else
      {
        try
        {
          new Process() { StartInfo = { FileName = path } }.Start();
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Для принятия изменений в списке прокси-серверов, перезапустите программу.";
          fn.TXT(ref sText);
        }
        catch (Win32Exception ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Произошла ошибка при открытии файла.";
          fn.TXT(ref sText);
          ProjectData.ClearProjectError();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Произошла ошибка при открытии файла.";
          fn.TXT(ref sText);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void tmrNetworkReboot_Tick(object sender, EventArgs e)
    {
      if (md_NetworkReboot.NetworkReboot.ReconnectRequired)
      {
        if (_VARIABLES.AC_NET.CapCounter.IsBusy > 0 | _VARIABLES.IsConnected.Counter > 0)
          return;
        md_NetworkReboot.NetworkReboot.ReconnectRequired = false;
        md_NetworkReboot.RebootNetworkAdapter();
      }
      else
      {
        NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        int num1 = 0;
        int num2 = Information.UBound((Array) networkInterfaces, 1);
        int index = num1;
        while (index <= num2)
        {
          if (Operators.CompareString(networkInterfaces[index].Name, md_NetworkReboot.NetworkReboot.NetworkAdapter[md_NetworkReboot.NetworkReboot.NumAdapter].NetConnectionID, false) == 0)
          {
            if (networkInterfaces[index].OperationalStatus != OperationalStatus.Up)
              return;
            goto label_11;
          }
          else
            checked { ++index; }
        }
        if (index > Information.UBound((Array) networkInterfaces, 1))
          return;
label_11:
        this.tmrNetworkReboot.Enabled = false;
        _VARIABLES.VPN_MD.RegCount = 0;
        _VARIABLES.VPN_MD.MailCount = 0;
        if (_VARIABLES.VPN_MD.StartWith1Account)
        {
          _FUNCTION.AccountSelect(1);
          _VARIABLES.CountUserInfo = this.LV.SelectedItems[0].Index;
        }
        _VARIABLES.PauseConnect = false;
      }
    }

    private void btnSort_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "Отсортировать список по Registered?", MsgBoxStyle.OkCancel | MsgBoxStyle.Information, (object) "Сортировка") == MsgBoxResult.Cancel)
        return;
      if (Information.UBound((Array) _VARIABLES.MailInfo, 1) == 0)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Нет аккаунтов для сортировки!";
        fn.TXT(ref sText);
      }
      else
      {
        int num1 = 8;
        byte[] numArray = new byte[checked (num1 + 1)];
        frmOptions frmOptions = MyProject.Forms.frmOptions;
        if (checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked (0.0 + Math.Pow(2.0, (double) frmOptions.cmbSort_1.SelectedIndex)))) + Math.Pow(2.0, (double) frmOptions.cmbSort_2.SelectedIndex)))) + Math.Pow(2.0, (double) frmOptions.cmbSort_3.SelectedIndex)))) + Math.Pow(2.0, (double) frmOptions.cmbSort_4.SelectedIndex)))) + Math.Pow(2.0, (double) frmOptions.cmbSort_5.SelectedIndex)))) + Math.Pow(2.0, (double) frmOptions.cmbSort_6.SelectedIndex)))) + Math.Pow(2.0, (double) frmOptions.cmbSort_7.SelectedIndex)))) + Math.Pow(2.0, (double) frmOptions.cmbSort_8.SelectedIndex)))) == 510)
        {
          numArray[1] = checked ((byte) (frmOptions.cmbSort_1.SelectedIndex - 1));
          numArray[2] = checked ((byte) (frmOptions.cmbSort_2.SelectedIndex - 1));
          numArray[3] = checked ((byte) (frmOptions.cmbSort_3.SelectedIndex - 1));
          numArray[4] = checked ((byte) (frmOptions.cmbSort_4.SelectedIndex - 1));
          numArray[5] = checked ((byte) (frmOptions.cmbSort_5.SelectedIndex - 1));
          numArray[6] = checked ((byte) (frmOptions.cmbSort_6.SelectedIndex - 1));
          numArray[7] = checked ((byte) (frmOptions.cmbSort_7.SelectedIndex - 1));
          numArray[8] = checked ((byte) (frmOptions.cmbSort_8.SelectedIndex - 1));
          _VARIABLES.meMailInfo[] meMailInfoArray = new _VARIABLES.meMailInfo[checked (Information.UBound((Array) _VARIABLES.MailInfo, 1) + 1)];
          int index1 = 0;
          int num2 = 1;
          int num3 = num1;
          int index2 = num2;
          while (index2 <= num3)
          {
            int num4 = 1;
            int num5 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
            int index3 = num4;
            while (index3 <= num5)
            {
              if ((int) _VARIABLES.MailInfo[index3].Registered == (int) numArray[index2])
              {
                checked { ++index1; }
                meMailInfoArray[index1] = _VARIABLES.MailInfo[index3];
              }
              checked { ++index3; }
            }
            checked { ++index2; }
          }
          if (index1 != Information.UBound((Array) _VARIABLES.MailInfo, 1))
          {
            int num6 = (int) Interaction.MsgBox((object) "Сработала функция безопасности.\r\nВо избежании потери аккаунтов, функция  безопасности заблокировала сортировку. \r\n'Сортировка' вернула неправильную контрольную сумму, что могло привести к потере аккаунтов.\r\nСообщите о данной ошибке разработчикам программы, приложив скриншот настроек сортировки.", MsgBoxStyle.Critical, (object) "Функция безопасности");
          }
          else
          {
            _VARIABLES.MailInfo = new _VARIABLES.meMailInfo[checked (index1 + 1)];
            _VARIABLES.MailInfo = meMailInfoArray;
            _LOADSAVE.SaveALL_MailInfo();
            MailRegUnicore._LV.LV_ADD_ALL();
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Отсортировано по Registered " + Conversions.ToString(index1) + " аккаунтов.";
            fn.TXT(ref sText);
          }
        }
        else
        {
          int num7 = (int) Interaction.MsgBox((object) "Неправильные настройки сортировки.\r\nЗадайте в опциях нужные параметры сортировки, либо установите всё по умолчанию.", MsgBoxStyle.Exclamation, (object) "Сортировка аккаунтов.");
        }
      }
    }

    private void tmrVPNReboot_Tick(object sender, EventArgs e)
    {
      if (this.tmrConnect.Enabled)
      {
        if (_VARIABLES.AC_NET.CapCounter.IsBusy > 0 | _VARIABLES.IsConnected.Counter > 0)
          return;
      }
      else if (this.tmrMailDownload.Enabled)
      {
        int num = 1;
        int threadWs = _VARIABLES.ThreadWS;
        int index = num;
        while (index <= threadWs)
        {
          if (this.BW_LoadMail[index].IsBusy)
            return;
          checked { ++index; }
        }
      }
      else
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Мониторинг статуса VPN подключения отключен, т.к. не найдено ни одной задачи.";
        fn.TXT(ref sText);
        this.tmrVPNReboot.Stop();
        return;
      }
      _VARIABLES.VPN_MD.MailCount = 0;
      _VARIABLES.VPN_MD.RegCount = 0;
      if (_VARIABLES.VPN_MD.StartWith1Account)
      {
        _FUNCTION.AccountSelect(1);
        _VARIABLES.CountUserInfo = this.LV.SelectedItems[0].Index;
      }
      MyProject.Forms.frmMain_RasDialex.RAS.Close();
      string sText1;
      if (!MyProject.Forms.frmMain_RasDialex.chReconnect.Checked)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        sText1 = "У вас не включено автоподключение в RasDialEx!";
        fn.TXT(ref sText1);
      }
      this.tmrVPNReboot.Enabled = false;
      if (_VARIABLES.OP.ViewResponse)
      {
        int num = 1;
        int threadWs = _VARIABLES.ThreadWS;
        int index = num;
        while (index <= threadWs)
        {
          this.LV.Items[checked (_VARIABLES.Mirror[index] - 1)].SubItems[6].Text = Conversions.ToString(0);
          this.LV.Items[checked (_VARIABLES.Mirror[index] - 1)].SubItems[7].Text = string.Empty;
          checked { ++index; }
        }
      }
      _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
      sText1 = "VPN Reboot - started!";
      fn1.TXT(ref sText1);
    }

    private void chCheckMail_WebFace_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chCheckMail_WebFace.Checked)
        _VARIABLES.ActionCurrent = _VARIABLES.Action.CheckMail_WebFace;
      else
        _VARIABLES.ActionCurrent = _VARIABLES.Action.RegMail;
    }

    private void btnSort_Turn_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "Перевернуть список?", MsgBoxStyle.OkCancel | MsgBoxStyle.Information, (object) "Сортировка") == MsgBoxResult.Cancel)
        return;
      int num = Information.UBound((Array) _VARIABLES.MailInfo, 1);
      _VARIABLES.meMailInfo[] meMailInfoArray = new _VARIABLES.meMailInfo[checked (num + 1)];
      int index1 = 0;
      int index2 = num;
      while (index2 >= 1)
      {
        checked { ++index1; }
        meMailInfoArray[index1] = _VARIABLES.MailInfo[index2];
        checked { index2 += -1; }
      }
      _VARIABLES.MailInfo = meMailInfoArray;
      MailRegUnicore._LV.LV_ADD_ALL();
      _LOADSAVE.SaveALL_MailInfo();
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Перевернуто списком аккаунтов: " + Conversions.ToString(index1);
      fn.TXT(ref sText);
    }

    private void btnSort_Random_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "Перемешать список?", MsgBoxStyle.OkCancel | MsgBoxStyle.Information, (object) "Сортировка") == MsgBoxResult.Cancel)
        return;
      int num1 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
      _VARIABLES.meMailInfo[] meMailInfoArray = new _VARIABLES.meMailInfo[checked (num1 + 1)];
      int num2 = 0;
      int num3 = 1;
      int num4 = num1;
      int index1 = num3;
      while (index1 <= num4)
      {
        int index2 = _FUNCTION.sRND.Next(1, checked (num1 + 1));
        int index3;
        if (!Information.IsNothing((object) meMailInfoArray[index2].login))
        {
          int num5 = checked (index2 + 1);
          int num6 = num1;
          index3 = num5;
          while (index3 <= num6 && !Information.IsNothing((object) meMailInfoArray[index3].login))
            checked { ++index3; }
          if (index3 > num1)
          {
            int num7 = 1;
            int num8 = checked (index2 - 1);
            index3 = num7;
            while (index3 <= num8 && !Information.IsNothing((object) meMailInfoArray[index3].login))
              checked { ++index3; }
          }
        }
        else
          index3 = index2;
        checked { ++num2; }
        meMailInfoArray[index3] = _VARIABLES.MailInfo[index1];
        checked { ++index1; }
      }
      _VARIABLES.MailInfo = meMailInfoArray;
      MailRegUnicore._LV.LV_ADD_ALL();
      _LOADSAVE.SaveALL_MailInfo();
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Перемешано аккаунтов: " + Conversions.ToString(num2);
      fn.TXT(ref sText);
    }

    private void Label2_Click(object sender, EventArgs e)
    {
    }

    private void btnSaveLog_Click(object sender, EventArgs e)
    {
      try
      {
        StringBuilder stringBuilder1 = new StringBuilder();
        stringBuilder1.AppendLine("===========================================================");
        stringBuilder1.AppendLine("Начало создания лога: " + Conversions.ToString(DateAndTime.Now));
        stringBuilder1.AppendLine("===========================================================");
        stringBuilder1.AppendLine(this.lbl1.Text + " " + this.INFO_1.Text);
        stringBuilder1.AppendLine(this.lbl2.Text + " " + this.INFO_2.Text);
        stringBuilder1.AppendLine(this.lbl3.Text + " " + this.INFO_3.Text);
        stringBuilder1.AppendLine(this.lbl4.Text + " " + this.INFO_4.Text);
        stringBuilder1.AppendLine(this.lbl5.Text + " " + this.INFO_5.Text);
        stringBuilder1.AppendLine(this.lbl6.Text + " " + this.INFO_6.Text);
        stringBuilder1.AppendLine(this.lbl7.Text + " " + this.INFO_7.Text);
        stringBuilder1.AppendLine(this.lbl8.Text + " личная информация не передается");
        stringBuilder1.AppendLine(this.lbl9.Text + " личная информация не передается");
        stringBuilder1.AppendLine(this.lbl10.Text + " личная информация не передается");
        stringBuilder1.AppendLine(this.lbl11.Text + " " + this.INFO_11.Text);
        stringBuilder1.AppendLine(this.lbl12.Text + " " + this.INFO_12.Text);
        stringBuilder1.AppendLine(this.lbl13.Text + " " + this.INFO_13.Text);
        stringBuilder1.AppendLine("===========================================================");
        stringBuilder1.AppendLine("Thread = " + this.cmbThread.Text);
        stringBuilder1.AppendLine("chAutoCaptcha = " + Conversions.ToString(this.chAutoCaptcha.Checked));
        stringBuilder1.AppendLine("chProxy = " + Conversions.ToString(this.chProxy.Checked));
        stringBuilder1.AppendLine("Update = " + Conversions.ToString(this.chAutoUpdate.Checked));
        stringBuilder1.AppendLine("DoWork_Reg = " + Conversions.ToString(_VARIABLES.DoWork_Reg));
        stringBuilder1.AppendLine("tmrConnect = " + Conversions.ToString(this.tmrConnect.Enabled));
        stringBuilder1.AppendLine("tmrMailDownload = " + Conversions.ToString(this.tmrMailDownload.Enabled));
        stringBuilder1.AppendLine("tmrNetworkReboot = " + Conversions.ToString(this.tmrNetworkReboot.Enabled));
        stringBuilder1.AppendLine("tmrVPNReboot = " + Conversions.ToString(this.tmrVPNReboot.Enabled));
        stringBuilder1.AppendLine("===========================================================");
        if (!Information.IsNothing((object) _VARIABLES.AC_NET))
        {
          int thread = _VARIABLES.AC_NET.GetThread();
          int num1 = 1;
          int num2 = thread;
          int Index = num1;
          while (Index <= num2)
          {
            stringBuilder1.AppendLine("AC Thread " + Conversions.ToString(Index) + ": " + Conversions.ToString(_VARIABLES.AC_NET.GetConnectTo(Index)));
            stringBuilder1.AppendLine("AC IsBusy " + Conversions.ToString(Index) + ": " + Conversions.ToString(_VARIABLES.AC_NET.IsBusy[Index]));
            checked { ++Index; }
          }
        }
        else
          stringBuilder1.AppendLine("AC_NET.IsNothing");
        stringBuilder1.AppendLine("===========================================================");
        if (!Information.IsNothing((object) _VARIABLES.WS))
        {
          int thread = _VARIABLES.AC_NET.GetThread();
          int num1 = 1;
          int num2 = thread;
          int index = num1;
          while (index <= num2)
          {
            stringBuilder1.AppendLine("WS FreeSocket " + Conversions.ToString(index) + ": " + Conversions.ToString(_VARIABLES.WS[index].FreeSocket));
            stringBuilder1.AppendLine("WS IsBusy " + Conversions.ToString(index) + ": " + Conversions.ToString(_VARIABLES.WS[index].IsBusy));
            stringBuilder1.AppendLine("WS IsConnected " + Conversions.ToString(index) + ": " + Conversions.ToString(_VARIABLES.WS[index].IsConnected()));
            stringBuilder1.AppendLine("WS Response " + Conversions.ToString(index) + ": " + Conversions.ToString(_VARIABLES.WS[index].Response));
            stringBuilder1.AppendLine("WS InFunction " + Conversions.ToString(index) + ": " + Conversions.ToString((int) _VARIABLES.WS[index].InFunction));
            stringBuilder1.AppendLine("-----------------------------------------------------------");
            checked { ++index; }
          }
        }
        else
          stringBuilder1.AppendLine("WS.IsNothing");
        stringBuilder1.AppendLine("===========================================================");
        stringBuilder1.AppendLine(this.chReport_1.Text + " = " + Conversions.ToString(this.chReport_1.Checked));
        stringBuilder1.AppendLine(this.chReport_2.Text + " = " + Conversions.ToString(this.chReport_2.Checked));
        stringBuilder1.AppendLine(this.chReport_3.Text + " = " + Conversions.ToString(this.chReport_3.Checked));
        stringBuilder1.AppendLine(this.chReport_4.Text + " = " + Conversions.ToString(this.chReport_4.Checked));
        stringBuilder1.AppendLine(this.chReport_5.Text + " = " + Conversions.ToString(this.chReport_5.Checked));
        stringBuilder1.AppendLine(this.chReport_6.Text + " = " + Conversions.ToString(this.chReport_6.Checked));
        stringBuilder1.AppendLine(this.chReport_7.Text + " = " + Conversions.ToString(this.chReport_7.Checked));
        stringBuilder1.AppendLine(this.chReport_8.Text + " = " + Conversions.ToString(this.chReport_8.Checked));
        stringBuilder1.AppendLine("===========================================================");
        stringBuilder1.AppendLine("Options.Global");
        stringBuilder1.AppendLine("===========================================================");
        try
        {
          foreach (object control in MyProject.Forms.frmOptions.Controls)
          {
            object objectValue = RuntimeHelpers.GetObjectValue(control);
            if ((object) objectValue.GetType() == (object) typeof (CheckBox))
              stringBuilder1.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue, (Type) null, "Text", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) " = "), NewLateBinding.LateGet(objectValue, (Type) null, "Checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null))));
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        stringBuilder1.AppendLine("===========================================================");
        RuntimeHelpers.GetObjectValue(new object());
        try
        {
          foreach (object control1 in MyProject.Forms.frmOptions.Controls)
          {
            object objectValue1 = RuntimeHelpers.GetObjectValue(control1);
            if ((object) objectValue1.GetType() == (object) typeof (GroupBox))
            {
              stringBuilder1.AppendLine("-----------------------------------------------------------");
              stringBuilder1.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue1, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) "."), NewLateBinding.LateGet(objectValue1, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null))));
              stringBuilder1.AppendLine("-----------------------------------------------------------");
              stringBuilder1.AppendLine("Checkbox");
              object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
              try
              {
                foreach (object obj in (IEnumerable) NewLateBinding.LateGet(objectValue1, (Type) null, "Controls", new object[0], (string[]) null, (Type[]) null, (bool[]) null))
                {
                  object objectValue3 = RuntimeHelpers.GetObjectValue(obj);
                  if ((object) objectValue3.GetType() == (object) typeof (CheckBox))
                    stringBuilder1.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue3, (Type) null, "Text", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) " = "), NewLateBinding.LateGet(objectValue3, (Type) null, "Checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null))));
                }
              }
              finally
              {
                IEnumerator enumerator;
                if (enumerator is IDisposable)
                  (enumerator as IDisposable).Dispose();
              }
              stringBuilder1.AppendLine("-----------------------------------------------------------");
              stringBuilder1.AppendLine("RadioButton");
              objectValue2 = RuntimeHelpers.GetObjectValue(new object());
              try
              {
                foreach (object control2 in MyProject.Forms.frmOptions.Controls)
                {
                  object objectValue3 = RuntimeHelpers.GetObjectValue(control2);
                  if ((object) objectValue3.GetType() == (object) typeof (RadioButton))
                    stringBuilder1.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue3, (Type) null, "Text", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) " = "), NewLateBinding.LateGet(objectValue3, (Type) null, "Checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null))));
                }
              }
              finally
              {
                IEnumerator enumerator;
                if (enumerator is IDisposable)
                  (enumerator as IDisposable).Dispose();
              }
              stringBuilder1.AppendLine("-----------------------------------------------------------");
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        stringBuilder1.AppendLine("===========================================================");
        string str1;
        if (File.Exists(Application.StartupPath + "\\Log.txt"))
        {
          StringBuilder stringBuilder2 = stringBuilder1;
          str1 = Application.StartupPath + "\\Log.txt";
          string str2 = _LOADSAVE.FileLoad(ref str1);
          stringBuilder2.AppendLine(str2);
          stringBuilder1.AppendLine("===========================================================");
        }
        stringBuilder1.AppendLine("txt.MON");
        stringBuilder1.AppendLine(this.txtMon.Text);
        stringBuilder1.AppendLine("===========================================================");
        stringBuilder1.AppendLine("Log.End");
        string str3 = Application.StartupPath + "\\LogForSupport.txt";
        str1 = stringBuilder1.ToString();
        _LOADSAVE.FileSave(ref str3, ref str1);
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        str1 = "Лог для техсаппорта готов. Путь сохранения:";
        fn.TXT(ref str1);
        _FUNCTION.FN.TXT(ref str3);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ошибка при подготовке лога: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    private void Button6_Click(object sender, EventArgs e)
    {
    }

    private void sTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
      object sOb = this.sOB;
      ObjectFlowControl.CheckForSyncLockOnValueType(sOb);
      bool lockTaken = false;
      try
      {
        Monitor.Enter(sOb, ref lockTaken);
        checked { ++this.sTimerCNT; }
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit(sOb);
      }
      if (this.sTimerCNT != 20000)
        return;
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Stop Timer: " + Conversions.ToString(_VARIABLES.SW.ElapsedMilliseconds);
      fn.TXT(ref sText);
    }

    private void btnSQL_Click(object sender, EventArgs e)
    {
      MyProject.Forms.frmSQL.Show();
    }

    private void LV_Dostupno_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
  }
}
