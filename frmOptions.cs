// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.frmOptions
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [DesignerGenerated]
  public class frmOptions : Form
  {
    private IContainer components;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("txtAutoCaptchaKEY")]
    private TextBox _txtAutoCaptchaKEY;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("txtAutoCaptchaURL")]
    private TextBox _txtAutoCaptchaURL;
    [AccessedThroughProperty("chOpAC_3")]
    private CheckBox _chOpAC_3;
    [AccessedThroughProperty("chOpAC_2")]
    private CheckBox _chOpAC_2;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("chOpMailDownload_1")]
    private CheckBox _chOpMailDownload_1;
    [AccessedThroughProperty("GroupBox3")]
    private GroupBox _GroupBox3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("rbOP_2")]
    private RadioButton _rbOP_2;
    [AccessedThroughProperty("rbOP_1")]
    private RadioButton _rbOP_1;
    [AccessedThroughProperty("cmbOP_1")]
    private ComboBox _cmbOP_1;
    [AccessedThroughProperty("txtOP_1")]
    private TextBox _txtOP_1;
    [AccessedThroughProperty("GroupBox4")]
    private GroupBox _GroupBox4;
    [AccessedThroughProperty("chOPSaveList_2")]
    private CheckBox _chOPSaveList_2;
    [AccessedThroughProperty("cmbOPSaveList_1")]
    private ComboBox _cmbOPSaveList_1;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("txtOPSaveList_1")]
    private TextBox _txtOPSaveList_1;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("chOPSaveList_3")]
    private CheckBox _chOPSaveList_3;
    [AccessedThroughProperty("txtOP_2")]
    private TextBox _txtOP_2;
    [AccessedThroughProperty("chOP_1")]
    private CheckBox _chOP_1;
    [AccessedThroughProperty("chOPSaveList_1")]
    private CheckBox _chOPSaveList_1;
    [AccessedThroughProperty("chOPSaveList_4")]
    private CheckBox _chOPSaveList_4;
    [AccessedThroughProperty("chOpMailDownload_2")]
    private CheckBox _chOpMailDownload_2;
    [AccessedThroughProperty("cmbOPSaveList_2")]
    private ComboBox _cmbOPSaveList_2;
    [AccessedThroughProperty("cmbOpMailDownload_1")]
    private ComboBox _cmbOpMailDownload_1;
    [AccessedThroughProperty("chOP_2")]
    private CheckBox _chOP_2;
    [AccessedThroughProperty("chOP_3")]
    private CheckBox _chOP_3;
    [AccessedThroughProperty("chUseErrorCount")]
    private CheckBox _chUseErrorCount;
    [AccessedThroughProperty("txtErrorCount")]
    private TextBox _txtErrorCount;
    [AccessedThroughProperty("chdebugOp_SaveBadCaptcha")]
    private CheckBox _chdebugOp_SaveBadCaptcha;
    [AccessedThroughProperty("txtIntervalConnect")]
    private TextBox _txtIntervalConnect;
    [AccessedThroughProperty("txtSocketTimeOut")]
    private TextBox _txtSocketTimeOut;
    [AccessedThroughProperty("chSocketTimeOut")]
    private CheckBox _chSocketTimeOut;
    [AccessedThroughProperty("chSavePacket_RegError")]
    private CheckBox _chSavePacket_RegError;
    [AccessedThroughProperty("chSaveLog")]
    private CheckBox _chSaveLog;
    [AccessedThroughProperty("GroupBox5")]
    private GroupBox _GroupBox5;
    [AccessedThroughProperty("boxHttpLoadProxy")]
    private GroupBox _boxHttpLoadProxy;
    [AccessedThroughProperty("lblInfoProxyLoad")]
    private Label _lblInfoProxyLoad;
    [AccessedThroughProperty("chHttpLoadProxy_UseRegEx")]
    private CheckBox _chHttpLoadProxy_UseRegEx;
    [AccessedThroughProperty("txtHttpLoadProxy_RegEx")]
    private TextBox _txtHttpLoadProxy_RegEx;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("lblHttpLoadProxy_UrlCount")]
    private Label _lblHttpLoadProxy_UrlCount;
    [AccessedThroughProperty("cmbHttpLoadProxy")]
    private ComboBox _cmbHttpLoadProxy;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("btnOpenProxy")]
    private Button _btnOpenProxy;
    [AccessedThroughProperty("chHttpLoadProxy_Append")]
    private CheckBox _chHttpLoadProxy_Append;
    [AccessedThroughProperty("chHttpLoadProxy_LoadInStart")]
    private CheckBox _chHttpLoadProxy_LoadInStart;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("lblHttpLoadProxy_Count")]
    private Label _lblHttpLoadProxy_Count;
    [AccessedThroughProperty("chHttpLoadProxy")]
    private CheckBox _chHttpLoadProxy;
    [AccessedThroughProperty("chAfterLoadStartOne")]
    private CheckBox _chAfterLoadStartOne;
    [AccessedThroughProperty("boxNetworkReboot")]
    private GroupBox _boxNetworkReboot;
    [AccessedThroughProperty("chNetWorkReboot")]
    private CheckBox _chNetWorkReboot;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("cmbNetworkReboot_Adapter")]
    private ComboBox _cmbNetworkReboot_Adapter;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("cmbNetworkReboot_Filtr")]
    private ComboBox _cmbNetworkReboot_Filtr;
    [AccessedThroughProperty("Button4")]
    private Button _Button4;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("lblNetworkReboot_NetConnectionID")]
    private Label _lblNetworkReboot_NetConnectionID;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("cmbNetworkReboot_Method")]
    private ComboBox _cmbNetworkReboot_Method;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("lblNetworkReboot_MAC")]
    private Label _lblNetworkReboot_MAC;
    [AccessedThroughProperty("GroupBox6")]
    private GroupBox _GroupBox6;
    [AccessedThroughProperty("picLine_2")]
    private PictureBox _picLine_2;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("cmbOpAC_1")]
    private ComboBox _cmbOpAC_1;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("cmbOpAC_7")]
    private ComboBox _cmbOpAC_7;
    [AccessedThroughProperty("Label21")]
    private Label _Label21;
    [AccessedThroughProperty("cmbOpAC_6")]
    private ComboBox _cmbOpAC_6;
    [AccessedThroughProperty("Label20")]
    private Label _Label20;
    [AccessedThroughProperty("cmbOpAC_5")]
    private ComboBox _cmbOpAC_5;
    [AccessedThroughProperty("Label19")]
    private Label _Label19;
    [AccessedThroughProperty("cmbOpAC_4")]
    private ComboBox _cmbOpAC_4;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("cmbOpAC_3")]
    private ComboBox _cmbOpAC_3;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("cmbOpAC_2")]
    private ComboBox _cmbOpAC_2;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("GroupBox7")]
    private GroupBox _GroupBox7;
    [AccessedThroughProperty("txtOpAC_1")]
    private TextBox _txtOpAC_1;
    [AccessedThroughProperty("GroupBox11")]
    private GroupBox _GroupBox11;
    [AccessedThroughProperty("txtOpAC_5")]
    private TextBox _txtOpAC_5;
    [AccessedThroughProperty("GroupBox10")]
    private GroupBox _GroupBox10;
    [AccessedThroughProperty("txtOpAC_4")]
    private TextBox _txtOpAC_4;
    [AccessedThroughProperty("GroupBox9")]
    private GroupBox _GroupBox9;
    [AccessedThroughProperty("txtOpAC_3")]
    private TextBox _txtOpAC_3;
    [AccessedThroughProperty("GroupBox8")]
    private GroupBox _GroupBox8;
    [AccessedThroughProperty("txtOpAC_2")]
    private TextBox _txtOpAC_2;
    [AccessedThroughProperty("btnAC_Default")]
    private Button _btnAC_Default;
    [AccessedThroughProperty("Label22")]
    private Label _Label22;
    [AccessedThroughProperty("GroupBox13")]
    private GroupBox _GroupBox13;
    [AccessedThroughProperty("txtOpAC_7")]
    private TextBox _txtOpAC_7;
    [AccessedThroughProperty("GroupBox12")]
    private GroupBox _GroupBox12;
    [AccessedThroughProperty("txtOpAC_6")]
    private TextBox _txtOpAC_6;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("boxPlaySound")]
    private GroupBox _boxPlaySound;
    [AccessedThroughProperty("chPlaySound")]
    private CheckBox _chPlaySound;
    [AccessedThroughProperty("Label23")]
    private Label _Label23;
    [AccessedThroughProperty("GroupBox15")]
    private GroupBox _GroupBox15;
    [AccessedThroughProperty("btnPlaySound_1")]
    private Button _btnPlaySound_1;
    [AccessedThroughProperty("txtPlaySound_1")]
    private TextBox _txtPlaySound_1;
    [AccessedThroughProperty("GroupBox20")]
    private GroupBox _GroupBox20;
    [AccessedThroughProperty("btnPlaySound_6")]
    private Button _btnPlaySound_6;
    [AccessedThroughProperty("txtPlaySound_6")]
    private TextBox _txtPlaySound_6;
    [AccessedThroughProperty("GroupBox19")]
    private GroupBox _GroupBox19;
    [AccessedThroughProperty("btnPlaySound_3")]
    private Button _btnPlaySound_3;
    [AccessedThroughProperty("txtPlaySound_3")]
    private TextBox _txtPlaySound_3;
    [AccessedThroughProperty("GroupBox18")]
    private GroupBox _GroupBox18;
    [AccessedThroughProperty("btnPlaySound_5")]
    private Button _btnPlaySound_5;
    [AccessedThroughProperty("txtPlaySound_5")]
    private TextBox _txtPlaySound_5;
    [AccessedThroughProperty("GroupBox17")]
    private GroupBox _GroupBox17;
    [AccessedThroughProperty("btnPlaySound_4")]
    private Button _btnPlaySound_4;
    [AccessedThroughProperty("txtPlaySound_4")]
    private TextBox _txtPlaySound_4;
    [AccessedThroughProperty("GroupBox16")]
    private GroupBox _GroupBox16;
    [AccessedThroughProperty("btnPlaySound_2")]
    private Button _btnPlaySound_2;
    [AccessedThroughProperty("txtPlaySound_2")]
    private TextBox _txtPlaySound_2;
    [AccessedThroughProperty("chPlaySound_6")]
    private CheckBox _chPlaySound_6;
    [AccessedThroughProperty("chPlaySound_3")]
    private CheckBox _chPlaySound_3;
    [AccessedThroughProperty("chPlaySound_5")]
    private CheckBox _chPlaySound_5;
    [AccessedThroughProperty("chPlaySound_4")]
    private CheckBox _chPlaySound_4;
    [AccessedThroughProperty("chPlaySound_2")]
    private CheckBox _chPlaySound_2;
    [AccessedThroughProperty("chPlaySound_1")]
    private CheckBox _chPlaySound_1;
    [AccessedThroughProperty("chdebugOp_FullSessionLog")]
    private CheckBox _chdebugOp_FullSessionLog;
    [AccessedThroughProperty("chdebugOp_SaveBadIP")]
    private CheckBox _chdebugOp_SaveBadIP;
    [AccessedThroughProperty("chNetworkReboot_MacChange")]
    private CheckBox _chNetworkReboot_MacChange;
    [AccessedThroughProperty("GroupBox14")]
    private GroupBox _GroupBox14;
    [AccessedThroughProperty("cmbSort_1")]
    private ComboBox _cmbSort_1;
    [AccessedThroughProperty("cmbSort_7")]
    private ComboBox _cmbSort_7;
    [AccessedThroughProperty("cmbSort_6")]
    private ComboBox _cmbSort_6;
    [AccessedThroughProperty("cmbSort_5")]
    private ComboBox _cmbSort_5;
    [AccessedThroughProperty("cmbSort_4")]
    private ComboBox _cmbSort_4;
    [AccessedThroughProperty("cmbSort_3")]
    private ComboBox _cmbSort_3;
    [AccessedThroughProperty("cmbSort_2")]
    private ComboBox _cmbSort_2;
    [AccessedThroughProperty("btnOpSort_Default")]
    private Button _btnOpSort_Default;
    [AccessedThroughProperty("boxVPN")]
    private GroupBox _boxVPN;
    [AccessedThroughProperty("chVPN_UseDownloadMail")]
    private CheckBox _chVPN_UseDownloadMail;
    [AccessedThroughProperty("Label24")]
    private Label _Label24;
    [AccessedThroughProperty("chVPN_UseReg")]
    private CheckBox _chVPN_UseReg;
    [AccessedThroughProperty("chVPN")]
    private CheckBox _chVPN;
    [AccessedThroughProperty("Label25")]
    private Label _Label25;
    [AccessedThroughProperty("txtVPN_UseDownloadMail")]
    private TextBox _txtVPN_UseDownloadMail;
    [AccessedThroughProperty("Label26")]
    private Label _Label26;
    [AccessedThroughProperty("picSort_BAD")]
    private PictureBox _picSort_BAD;
    [AccessedThroughProperty("picSort_OK")]
    private PictureBox _picSort_OK;
    [AccessedThroughProperty("chVPN_StartWith1Account")]
    private CheckBox _chVPN_StartWith1Account;
    [AccessedThroughProperty("txtVPN_UseRegistered")]
    private TextBox _txtVPN_UseRegistered;
    [AccessedThroughProperty("Label29")]
    private Label _Label29;
    [AccessedThroughProperty("txtProxy_AC")]
    private TextBox _txtProxy_AC;
    [AccessedThroughProperty("Label27")]
    private Label _Label27;
    [AccessedThroughProperty("Label28")]
    private Label _Label28;
    [AccessedThroughProperty("rbServiceAC_1")]
    private RadioButton _rbServiceAC_1;
    [AccessedThroughProperty("rbServiceAC_2")]
    private RadioButton _rbServiceAC_2;
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("chVPN_HardStop")]
    private CheckBox _chVPN_HardStop;
    [AccessedThroughProperty("txtHardStop")]
    private TextBox _txtHardStop;
    [AccessedThroughProperty("lblSocketTimeOut")]
    private Label _lblSocketTimeOut;
    [AccessedThroughProperty("cmbConnectMethod")]
    private ComboBox _cmbConnectMethod;
    [AccessedThroughProperty("Label30")]
    private Label _Label30;
    [AccessedThroughProperty("lblAutoCaptcha_Supported")]
    private Label _lblAutoCaptcha_Supported;
    [AccessedThroughProperty("chBannedProxy")]
    private CheckBox _chBannedProxy;
    [AccessedThroughProperty("btnSQL")]
    private Button _btnSQL;
    [AccessedThroughProperty("cmbSort_8")]
    private ComboBox _cmbSort_8;

    public frmOptions()
    {
      this.Load += new EventHandler(this.frmOptions_Load);
      this.HandleDestroyed += new EventHandler(this.frmOptions_HandleDestroyed);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmOptions));
      this.GroupBox1 = new GroupBox();
      this.lblAutoCaptcha_Supported = new Label();
      this.PictureBox2 = new PictureBox();
      this.PictureBox1 = new PictureBox();
      this.Label27 = new Label();
      this.txtProxy_AC = new TextBox();
      this.btnAC_Default = new Button();
      this.Label22 = new Label();
      this.GroupBox13 = new GroupBox();
      this.txtOpAC_7 = new TextBox();
      this.GroupBox12 = new GroupBox();
      this.txtOpAC_6 = new TextBox();
      this.Label3 = new Label();
      this.GroupBox11 = new GroupBox();
      this.txtOpAC_5 = new TextBox();
      this.GroupBox10 = new GroupBox();
      this.txtOpAC_4 = new TextBox();
      this.GroupBox9 = new GroupBox();
      this.txtOpAC_3 = new TextBox();
      this.GroupBox8 = new GroupBox();
      this.txtOpAC_2 = new TextBox();
      this.GroupBox7 = new GroupBox();
      this.txtOpAC_1 = new TextBox();
      this.cmbOpAC_7 = new ComboBox();
      this.Label21 = new Label();
      this.cmbOpAC_6 = new ComboBox();
      this.txtAutoCaptchaURL = new TextBox();
      this.Label20 = new Label();
      this.cmbOpAC_5 = new ComboBox();
      this.Label19 = new Label();
      this.cmbOpAC_4 = new ComboBox();
      this.Label18 = new Label();
      this.cmbOpAC_3 = new ComboBox();
      this.Label17 = new Label();
      this.cmbOpAC_2 = new ComboBox();
      this.Label16 = new Label();
      this.cmbOpAC_1 = new ComboBox();
      this.Label15 = new Label();
      this.picLine_2 = new PictureBox();
      this.Label2 = new Label();
      this.chOpAC_2 = new CheckBox();
      this.Label1 = new Label();
      this.txtAutoCaptchaKEY = new TextBox();
      this.Label14 = new Label();
      this.rbServiceAC_2 = new RadioButton();
      this.rbServiceAC_1 = new RadioButton();
      this.chOpAC_3 = new CheckBox();
      this.GroupBox2 = new GroupBox();
      this.cmbOpMailDownload_1 = new ComboBox();
      this.chOpMailDownload_2 = new CheckBox();
      this.chOpMailDownload_1 = new CheckBox();
      this.GroupBox3 = new GroupBox();
      this.Label30 = new Label();
      this.cmbConnectMethod = new ComboBox();
      this.lblSocketTimeOut = new Label();
      this.chSocketTimeOut = new CheckBox();
      this.Label28 = new Label();
      this.txtErrorCount = new TextBox();
      this.chUseErrorCount = new CheckBox();
      this.txtIntervalConnect = new TextBox();
      this.txtSocketTimeOut = new TextBox();
      this.txtOP_2 = new TextBox();
      this.chOP_3 = new CheckBox();
      this.chOP_2 = new CheckBox();
      this.chOP_1 = new CheckBox();
      this.cmbOP_1 = new ComboBox();
      this.txtOP_1 = new TextBox();
      this.Label4 = new Label();
      this.rbOP_2 = new RadioButton();
      this.rbOP_1 = new RadioButton();
      this.GroupBox4 = new GroupBox();
      this.cmbOPSaveList_2 = new ComboBox();
      this.chOPSaveList_4 = new CheckBox();
      this.chOPSaveList_1 = new CheckBox();
      this.chOPSaveList_3 = new CheckBox();
      this.cmbOPSaveList_1 = new ComboBox();
      this.Label6 = new Label();
      this.txtOPSaveList_1 = new TextBox();
      this.Label5 = new Label();
      this.chOPSaveList_2 = new CheckBox();
      this.chdebugOp_SaveBadCaptcha = new CheckBox();
      this.chSavePacket_RegError = new CheckBox();
      this.chSaveLog = new CheckBox();
      this.GroupBox5 = new GroupBox();
      this.chBannedProxy = new CheckBox();
      this.chdebugOp_FullSessionLog = new CheckBox();
      this.chdebugOp_SaveBadIP = new CheckBox();
      this.boxHttpLoadProxy = new GroupBox();
      this.chAfterLoadStartOne = new CheckBox();
      this.lblHttpLoadProxy_Count = new Label();
      this.chHttpLoadProxy_Append = new CheckBox();
      this.chHttpLoadProxy_LoadInStart = new CheckBox();
      this.Label9 = new Label();
      this.Button2 = new Button();
      this.btnOpenProxy = new Button();
      this.Button1 = new Button();
      this.lblHttpLoadProxy_UrlCount = new Label();
      this.cmbHttpLoadProxy = new ComboBox();
      this.Label7 = new Label();
      this.txtHttpLoadProxy_RegEx = new TextBox();
      this.chHttpLoadProxy_UseRegEx = new CheckBox();
      this.lblInfoProxyLoad = new Label();
      this.chHttpLoadProxy = new CheckBox();
      this.boxNetworkReboot = new GroupBox();
      this.Label13 = new Label();
      this.chNetworkReboot_MacChange = new CheckBox();
      this.GroupBox6 = new GroupBox();
      this.lblNetworkReboot_MAC = new Label();
      this.cmbNetworkReboot_Method = new ComboBox();
      this.lblNetworkReboot_NetConnectionID = new Label();
      this.Label12 = new Label();
      this.cmbNetworkReboot_Filtr = new ComboBox();
      this.Button4 = new Button();
      this.Label11 = new Label();
      this.cmbNetworkReboot_Adapter = new ComboBox();
      this.Label10 = new Label();
      this.Label8 = new Label();
      this.chNetWorkReboot = new CheckBox();
      this.boxPlaySound = new GroupBox();
      this.GroupBox20 = new GroupBox();
      this.chPlaySound_6 = new CheckBox();
      this.btnPlaySound_6 = new Button();
      this.txtPlaySound_6 = new TextBox();
      this.GroupBox19 = new GroupBox();
      this.chPlaySound_3 = new CheckBox();
      this.btnPlaySound_3 = new Button();
      this.txtPlaySound_3 = new TextBox();
      this.GroupBox18 = new GroupBox();
      this.chPlaySound_5 = new CheckBox();
      this.btnPlaySound_5 = new Button();
      this.txtPlaySound_5 = new TextBox();
      this.GroupBox17 = new GroupBox();
      this.chPlaySound_4 = new CheckBox();
      this.btnPlaySound_4 = new Button();
      this.txtPlaySound_4 = new TextBox();
      this.GroupBox16 = new GroupBox();
      this.chPlaySound_2 = new CheckBox();
      this.btnPlaySound_2 = new Button();
      this.txtPlaySound_2 = new TextBox();
      this.GroupBox15 = new GroupBox();
      this.chPlaySound_1 = new CheckBox();
      this.btnPlaySound_1 = new Button();
      this.txtPlaySound_1 = new TextBox();
      this.Label23 = new Label();
      this.chPlaySound = new CheckBox();
      this.GroupBox14 = new GroupBox();
      this.cmbSort_8 = new ComboBox();
      this.picSort_BAD = new PictureBox();
      this.picSort_OK = new PictureBox();
      this.btnOpSort_Default = new Button();
      this.cmbSort_7 = new ComboBox();
      this.cmbSort_6 = new ComboBox();
      this.cmbSort_5 = new ComboBox();
      this.cmbSort_4 = new ComboBox();
      this.cmbSort_3 = new ComboBox();
      this.cmbSort_2 = new ComboBox();
      this.cmbSort_1 = new ComboBox();
      this.boxVPN = new GroupBox();
      this.txtHardStop = new TextBox();
      this.chVPN_HardStop = new CheckBox();
      this.txtVPN_UseRegistered = new TextBox();
      this.Label29 = new Label();
      this.chVPN_StartWith1Account = new CheckBox();
      this.txtVPN_UseDownloadMail = new TextBox();
      this.Label26 = new Label();
      this.Label25 = new Label();
      this.chVPN_UseDownloadMail = new CheckBox();
      this.Label24 = new Label();
      this.chVPN_UseReg = new CheckBox();
      this.chVPN = new CheckBox();
      this.btnSQL = new Button();
      this.GroupBox1.SuspendLayout();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.GroupBox13.SuspendLayout();
      this.GroupBox12.SuspendLayout();
      this.GroupBox11.SuspendLayout();
      this.GroupBox10.SuspendLayout();
      this.GroupBox9.SuspendLayout();
      this.GroupBox8.SuspendLayout();
      this.GroupBox7.SuspendLayout();
      ((ISupportInitialize) this.picLine_2).BeginInit();
      this.GroupBox2.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.boxHttpLoadProxy.SuspendLayout();
      this.boxNetworkReboot.SuspendLayout();
      this.boxPlaySound.SuspendLayout();
      this.GroupBox20.SuspendLayout();
      this.GroupBox19.SuspendLayout();
      this.GroupBox18.SuspendLayout();
      this.GroupBox17.SuspendLayout();
      this.GroupBox16.SuspendLayout();
      this.GroupBox15.SuspendLayout();
      this.GroupBox14.SuspendLayout();
      ((ISupportInitialize) this.picSort_BAD).BeginInit();
      ((ISupportInitialize) this.picSort_OK).BeginInit();
      this.boxVPN.SuspendLayout();
      this.SuspendLayout();
      this.GroupBox1.Controls.Add((Control) this.lblAutoCaptcha_Supported);
      this.GroupBox1.Controls.Add((Control) this.PictureBox2);
      this.GroupBox1.Controls.Add((Control) this.PictureBox1);
      this.GroupBox1.Controls.Add((Control) this.Label27);
      this.GroupBox1.Controls.Add((Control) this.txtProxy_AC);
      this.GroupBox1.Controls.Add((Control) this.btnAC_Default);
      this.GroupBox1.Controls.Add((Control) this.Label22);
      this.GroupBox1.Controls.Add((Control) this.GroupBox13);
      this.GroupBox1.Controls.Add((Control) this.GroupBox12);
      this.GroupBox1.Controls.Add((Control) this.Label3);
      this.GroupBox1.Controls.Add((Control) this.GroupBox11);
      this.GroupBox1.Controls.Add((Control) this.GroupBox10);
      this.GroupBox1.Controls.Add((Control) this.GroupBox9);
      this.GroupBox1.Controls.Add((Control) this.GroupBox8);
      this.GroupBox1.Controls.Add((Control) this.GroupBox7);
      this.GroupBox1.Controls.Add((Control) this.cmbOpAC_7);
      this.GroupBox1.Controls.Add((Control) this.Label21);
      this.GroupBox1.Controls.Add((Control) this.cmbOpAC_6);
      this.GroupBox1.Controls.Add((Control) this.txtAutoCaptchaURL);
      this.GroupBox1.Controls.Add((Control) this.Label20);
      this.GroupBox1.Controls.Add((Control) this.cmbOpAC_5);
      this.GroupBox1.Controls.Add((Control) this.Label19);
      this.GroupBox1.Controls.Add((Control) this.cmbOpAC_4);
      this.GroupBox1.Controls.Add((Control) this.Label18);
      this.GroupBox1.Controls.Add((Control) this.cmbOpAC_3);
      this.GroupBox1.Controls.Add((Control) this.Label17);
      this.GroupBox1.Controls.Add((Control) this.cmbOpAC_2);
      this.GroupBox1.Controls.Add((Control) this.Label16);
      this.GroupBox1.Controls.Add((Control) this.cmbOpAC_1);
      this.GroupBox1.Controls.Add((Control) this.Label15);
      this.GroupBox1.Controls.Add((Control) this.picLine_2);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Controls.Add((Control) this.chOpAC_2);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.txtAutoCaptchaKEY);
      this.GroupBox1.Controls.Add((Control) this.Label14);
      this.GroupBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.GroupBox1.ForeColor = Color.Magenta;
      GroupBox groupBox1_1 = this.GroupBox1;
      Point point1 = new Point(254, 8);
      Point point2 = point1;
      groupBox1_1.Location = point2;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      Size size1 = new Size(240, 431);
      Size size2 = size1;
      groupBox1_2.Size = size2;
      this.GroupBox1.TabIndex = 0;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Опции AutoCaptcha";
      this.lblAutoCaptcha_Supported.ForeColor = Color.Red;
      Label captchaSupported1 = this.lblAutoCaptcha_Supported;
      point1 = new Point(9, 74);
      Point point3 = point1;
      captchaSupported1.Location = point3;
      this.lblAutoCaptcha_Supported.Name = "lblAutoCaptcha_Supported";
      Label captchaSupported2 = this.lblAutoCaptcha_Supported;
      size1 = new Size(189, 19);
      Size size3 = size1;
      captchaSupported2.Size = size3;
      this.lblAutoCaptcha_Supported.TabIndex = 126;
      this.lblAutoCaptcha_Supported.Text = "Service: not specified";
      this.PictureBox2.Image = (Image) componentResourceManager.GetObject("PictureBox2.Image");
      PictureBox pictureBox2_1 = this.PictureBox2;
      point1 = new Point(21, 47);
      Point point4 = point1;
      pictureBox2_1.Location = point4;
      this.PictureBox2.Name = "PictureBox2";
      PictureBox pictureBox2_2 = this.PictureBox2;
      size1 = new Size(69, 24);
      Size size4 = size1;
      pictureBox2_2.Size = size4;
      this.PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox2.TabIndex = 125;
      this.PictureBox2.TabStop = false;
      this.PictureBox2.Visible = false;
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(12, 43);
      Point point5 = point1;
      pictureBox1_1.Location = point5;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(69, 24);
      Size size5 = size1;
      pictureBox1_2.Size = size5;
      this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox1.TabIndex = 124;
      this.PictureBox1.TabStop = false;
      this.PictureBox1.Visible = false;
      this.Label27.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label27.ForeColor = Color.Gray;
      Label label27_1 = this.Label27;
      point1 = new Point(9, 408);
      Point point6 = point1;
      label27_1.Location = point6;
      this.Label27.Name = "Label27";
      Label label27_2 = this.Label27;
      size1 = new Size(91, 13);
      Size size6 = size1;
      label27_2.Size = size6;
      this.Label27.TabIndex = 123;
      this.Label27.Text = "use Proxy";
      this.Label27.TextAlign = ContentAlignment.MiddleCenter;
      this.txtProxy_AC.BorderStyle = BorderStyle.FixedSingle;
      this.txtProxy_AC.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtProxyAc1 = this.txtProxy_AC;
      point1 = new Point(106, 402);
      Point point7 = point1;
      txtProxyAc1.Location = point7;
      this.txtProxy_AC.Name = "txtProxy_AC";
      TextBox txtProxyAc2 = this.txtProxy_AC;
      size1 = new Size(126, 21);
      Size size7 = size1;
      txtProxyAc2.Size = size7;
      this.txtProxy_AC.TabIndex = 122;
      this.txtProxy_AC.TextAlign = HorizontalAlignment.Center;
      this.btnAC_Default.BackColor = Color.FromArgb(224, 224, 224);
      this.btnAC_Default.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnAC_Default.ForeColor = Color.Black;
      Button btnAcDefault1 = this.btnAC_Default;
      point1 = new Point(8, 367);
      Point point8 = point1;
      btnAcDefault1.Location = point8;
      this.btnAC_Default.Name = "btnAC_Default";
      Button btnAcDefault2 = this.btnAC_Default;
      size1 = new Size(94, 33);
      Size size8 = size1;
      btnAcDefault2.Size = size8;
      this.btnAC_Default.TabIndex = 121;
      this.btnAC_Default.Text = "DEFAULT";
      this.btnAC_Default.UseVisualStyleBackColor = false;
      this.Label22.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label22.ForeColor = Color.FromArgb(0, 0, 192);
      Label label22_1 = this.Label22;
      point1 = new Point(9, 144);
      Point point9 = point1;
      label22_1.Location = point9;
      this.Label22.Name = "Label22";
      Label label22_2 = this.Label22;
      size1 = new Size(93, 30);
      Size size9 = size1;
      label22_2.Size = size9;
      this.Label22.TabIndex = 120;
      this.Label22.Text = "опциональные поля";
      this.Label22.TextAlign = ContentAlignment.MiddleCenter;
      this.GroupBox13.Controls.Add((Control) this.txtOpAC_7);
      this.GroupBox13.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.GroupBox13.ForeColor = Color.Black;
      GroupBox groupBox13_1 = this.GroupBox13;
      point1 = new Point(106, 367);
      Point point10 = point1;
      groupBox13_1.Location = point10;
      this.GroupBox13.Name = "GroupBox13";
      GroupBox groupBox13_2 = this.GroupBox13;
      size1 = new Size(126, 33);
      Size size10 = size1;
      groupBox13_2.Size = size10;
      this.GroupBox13.TabIndex = 119;
      this.GroupBox13.TabStop = false;
      this.GroupBox13.Text = "Socket TimeOut";
      this.txtOpAC_7.BackColor = Color.WhiteSmoke;
      this.txtOpAC_7.BorderStyle = BorderStyle.None;
      this.txtOpAC_7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtOpAc7_1 = this.txtOpAC_7;
      point1 = new Point(6, 15);
      Point point11 = point1;
      txtOpAc7_1.Location = point11;
      this.txtOpAC_7.MaxLength = 9;
      this.txtOpAC_7.Name = "txtOpAC_7";
      TextBox txtOpAc7_2 = this.txtOpAC_7;
      size1 = new Size(114, 14);
      Size size11 = size1;
      txtOpAc7_2.Size = size11;
      this.txtOpAC_7.TabIndex = 0;
      this.txtOpAC_7.TabStop = false;
      this.txtOpAC_7.TextAlign = HorizontalAlignment.Center;
      this.GroupBox12.Controls.Add((Control) this.txtOpAC_6);
      this.GroupBox12.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.GroupBox12.ForeColor = Color.Black;
      GroupBox groupBox12_1 = this.GroupBox12;
      point1 = new Point(106, 334);
      Point point12 = point1;
      groupBox12_1.Location = point12;
      this.GroupBox12.Name = "GroupBox12";
      GroupBox groupBox12_2 = this.GroupBox12;
      size1 = new Size(126, 33);
      Size size12 = size1;
      groupBox12_2.Size = size12;
      this.GroupBox12.TabIndex = 118;
      this.GroupBox12.TabStop = false;
      this.GroupBox12.Text = "Reconnect with Error";
      this.txtOpAC_6.BackColor = Color.WhiteSmoke;
      this.txtOpAC_6.BorderStyle = BorderStyle.None;
      this.txtOpAC_6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtOpAc6_1 = this.txtOpAC_6;
      point1 = new Point(6, 15);
      Point point13 = point1;
      txtOpAc6_1.Location = point13;
      this.txtOpAC_6.MaxLength = 9;
      this.txtOpAC_6.Name = "txtOpAC_6";
      TextBox txtOpAc6_2 = this.txtOpAC_6;
      size1 = new Size(114, 14);
      Size size13 = size1;
      txtOpAc6_2.Size = size13;
      this.txtOpAC_6.TabIndex = 0;
      this.txtOpAC_6.TabStop = false;
      this.txtOpAC_6.TextAlign = HorizontalAlignment.Center;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label3.ForeColor = Color.FromArgb(0, 0, 192);
      Label label3_1 = this.Label3;
      point1 = new Point(135, 150);
      Point point14 = point1;
      label3_1.Location = point14;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(66, 13);
      Size size14 = size1;
      label3_2.Size = size14;
      this.Label3.TabIndex = 117;
      this.Label3.Text = "паузы (млс)";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.GroupBox11.Controls.Add((Control) this.txtOpAC_5);
      this.GroupBox11.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.GroupBox11.ForeColor = Color.Black;
      GroupBox groupBox11_1 = this.GroupBox11;
      point1 = new Point(106, 301);
      Point point15 = point1;
      groupBox11_1.Location = point15;
      this.GroupBox11.Name = "GroupBox11";
      GroupBox groupBox11_2 = this.GroupBox11;
      size1 = new Size(126, 33);
      Size size15 = size1;
      groupBox11_2.Size = size15;
      this.GroupBox11.TabIndex = 116;
      this.GroupBox11.TabStop = false;
      this.GroupBox11.Text = "Time Limit";
      this.txtOpAC_5.BackColor = Color.WhiteSmoke;
      this.txtOpAC_5.BorderStyle = BorderStyle.None;
      this.txtOpAC_5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtOpAc5_1 = this.txtOpAC_5;
      point1 = new Point(6, 15);
      Point point16 = point1;
      txtOpAc5_1.Location = point16;
      this.txtOpAC_5.MaxLength = 9;
      this.txtOpAC_5.Name = "txtOpAC_5";
      TextBox txtOpAc5_2 = this.txtOpAC_5;
      size1 = new Size(114, 14);
      Size size16 = size1;
      txtOpAc5_2.Size = size16;
      this.txtOpAC_5.TabIndex = 0;
      this.txtOpAC_5.TabStop = false;
      this.txtOpAC_5.TextAlign = HorizontalAlignment.Center;
      this.GroupBox10.Controls.Add((Control) this.txtOpAC_4);
      this.GroupBox10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.GroupBox10.ForeColor = Color.Black;
      GroupBox groupBox10_1 = this.GroupBox10;
      point1 = new Point(106, 268);
      Point point17 = point1;
      groupBox10_1.Location = point17;
      this.GroupBox10.Name = "GroupBox10";
      GroupBox groupBox10_2 = this.GroupBox10;
      size1 = new Size(126, 33);
      Size size17 = size1;
      groupBox10_2.Size = size17;
      this.GroupBox10.TabIndex = 115;
      this.GroupBox10.TabStop = false;
      this.GroupBox10.Text = "Next GetCaptcha";
      this.txtOpAC_4.BackColor = Color.WhiteSmoke;
      this.txtOpAC_4.BorderStyle = BorderStyle.None;
      this.txtOpAC_4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtOpAc4_1 = this.txtOpAC_4;
      point1 = new Point(6, 15);
      Point point18 = point1;
      txtOpAc4_1.Location = point18;
      this.txtOpAC_4.MaxLength = 9;
      this.txtOpAC_4.Name = "txtOpAC_4";
      TextBox txtOpAc4_2 = this.txtOpAC_4;
      size1 = new Size(114, 14);
      Size size18 = size1;
      txtOpAc4_2.Size = size18;
      this.txtOpAC_4.TabIndex = 0;
      this.txtOpAC_4.TabStop = false;
      this.txtOpAC_4.TextAlign = HorizontalAlignment.Center;
      this.GroupBox9.Controls.Add((Control) this.txtOpAC_3);
      this.GroupBox9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.GroupBox9.ForeColor = Color.Black;
      GroupBox groupBox9_1 = this.GroupBox9;
      point1 = new Point(106, 235);
      Point point19 = point1;
      groupBox9_1.Location = point19;
      this.GroupBox9.Name = "GroupBox9";
      GroupBox groupBox9_2 = this.GroupBox9;
      size1 = new Size(126, 33);
      Size size19 = size1;
      groupBox9_2.Size = size19;
      this.GroupBox9.TabIndex = 114;
      this.GroupBox9.TabStop = false;
      this.GroupBox9.Text = "After Sending";
      this.txtOpAC_3.BackColor = Color.WhiteSmoke;
      this.txtOpAC_3.BorderStyle = BorderStyle.None;
      this.txtOpAC_3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtOpAc3_1 = this.txtOpAC_3;
      point1 = new Point(6, 15);
      Point point20 = point1;
      txtOpAc3_1.Location = point20;
      this.txtOpAC_3.MaxLength = 9;
      this.txtOpAC_3.Name = "txtOpAC_3";
      TextBox txtOpAc3_2 = this.txtOpAC_3;
      size1 = new Size(114, 14);
      Size size20 = size1;
      txtOpAc3_2.Size = size20;
      this.txtOpAC_3.TabIndex = 0;
      this.txtOpAC_3.TabStop = false;
      this.txtOpAC_3.TextAlign = HorizontalAlignment.Center;
      this.GroupBox8.Controls.Add((Control) this.txtOpAC_2);
      this.GroupBox8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.GroupBox8.ForeColor = Color.Black;
      GroupBox groupBox8_1 = this.GroupBox8;
      point1 = new Point(106, 202);
      Point point21 = point1;
      groupBox8_1.Location = point21;
      this.GroupBox8.Name = "GroupBox8";
      GroupBox groupBox8_2 = this.GroupBox8;
      size1 = new Size(126, 33);
      Size size21 = size1;
      groupBox8_2.Size = size21;
      this.GroupBox8.TabIndex = 113;
      this.GroupBox8.TabStop = false;
      this.GroupBox8.Text = "No Slot Available";
      this.txtOpAC_2.BackColor = Color.WhiteSmoke;
      this.txtOpAC_2.BorderStyle = BorderStyle.None;
      this.txtOpAC_2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtOpAc2_1 = this.txtOpAC_2;
      point1 = new Point(6, 15);
      Point point22 = point1;
      txtOpAc2_1.Location = point22;
      this.txtOpAC_2.MaxLength = 9;
      this.txtOpAC_2.Name = "txtOpAC_2";
      TextBox txtOpAc2_2 = this.txtOpAC_2;
      size1 = new Size(114, 14);
      Size size22 = size1;
      txtOpAc2_2.Size = size22;
      this.txtOpAC_2.TabIndex = 0;
      this.txtOpAC_2.TabStop = false;
      this.txtOpAC_2.TextAlign = HorizontalAlignment.Center;
      this.GroupBox7.Controls.Add((Control) this.txtOpAC_1);
      this.GroupBox7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.GroupBox7.ForeColor = Color.Black;
      GroupBox groupBox7_1 = this.GroupBox7;
      point1 = new Point(106, 169);
      Point point23 = point1;
      groupBox7_1.Location = point23;
      this.GroupBox7.Name = "GroupBox7";
      GroupBox groupBox7_2 = this.GroupBox7;
      size1 = new Size(126, 33);
      Size size23 = size1;
      groupBox7_2.Size = size23;
      this.GroupBox7.TabIndex = 112;
      this.GroupBox7.TabStop = false;
      this.GroupBox7.Text = "Get Balance";
      this.txtOpAC_1.BackColor = Color.WhiteSmoke;
      this.txtOpAC_1.BorderStyle = BorderStyle.None;
      this.txtOpAC_1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtOpAc1_1 = this.txtOpAC_1;
      point1 = new Point(6, 15);
      Point point24 = point1;
      txtOpAc1_1.Location = point24;
      this.txtOpAC_1.MaxLength = 9;
      this.txtOpAC_1.Name = "txtOpAC_1";
      TextBox txtOpAc1_2 = this.txtOpAC_1;
      size1 = new Size(114, 14);
      Size size24 = size1;
      txtOpAc1_2.Size = size24;
      this.txtOpAC_1.TabIndex = 0;
      this.txtOpAC_1.TabStop = false;
      this.txtOpAC_1.TextAlign = HorizontalAlignment.Center;
      this.cmbOpAC_7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbOpAC_7.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbOpAC_7.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOpAC_7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbOpAC_7.FormattingEnabled = true;
      this.cmbOpAC_7.Items.AddRange(new object[2]
      {
        (object) "0",
        (object) "1"
      });
      ComboBox cmbOpAc7_1 = this.cmbOpAC_7;
      point1 = new Point(63, 339);
      Point point25 = point1;
      cmbOpAc7_1.Location = point25;
      this.cmbOpAC_7.Name = "cmbOpAC_7";
      ComboBox cmbOpAc7_2 = this.cmbOpAC_7;
      size1 = new Size(39, 21);
      Size size25 = size1;
      cmbOpAc7_2.Size = size25;
      this.cmbOpAC_7.TabIndex = 110;
      this.cmbOpAC_7.TabStop = false;
      this.cmbOpAC_7.Tag = (object) "cmbOP_1";
      this.Label21.AutoSize = true;
      this.Label21.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label21.ForeColor = Color.Gray;
      Label label21_1 = this.Label21;
      point1 = new Point(9, 343);
      Point point26 = point1;
      label21_1.Location = point26;
      this.Label21.Name = "Label21";
      Label label21_2 = this.Label21;
      size1 = new Size(54, 13);
      Size size26 = size1;
      label21_2.Size = size26;
      this.Label21.TabIndex = 111;
      this.Label21.Text = "is_russian";
      this.Label21.TextAlign = ContentAlignment.MiddleLeft;
      this.cmbOpAC_6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbOpAC_6.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbOpAC_6.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOpAC_6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbOpAC_6.FormattingEnabled = true;
      this.cmbOpAC_6.Items.AddRange(new object[21]
      {
        (object) "0",
        (object) "1",
        (object) "2",
        (object) "3",
        (object) "4",
        (object) "5",
        (object) "6",
        (object) "7",
        (object) "8",
        (object) "9",
        (object) "10",
        (object) "11",
        (object) "12",
        (object) "13",
        (object) "14",
        (object) "15",
        (object) "16",
        (object) "17",
        (object) "18",
        (object) "19",
        (object) "20"
      });
      ComboBox cmbOpAc6_1 = this.cmbOpAC_6;
      point1 = new Point(63, 312);
      Point point27 = point1;
      cmbOpAc6_1.Location = point27;
      this.cmbOpAC_6.Name = "cmbOpAC_6";
      ComboBox cmbOpAc6_2 = this.cmbOpAC_6;
      size1 = new Size(39, 21);
      Size size27 = size1;
      cmbOpAc6_2.Size = size27;
      this.cmbOpAC_6.TabIndex = 108;
      this.cmbOpAC_6.TabStop = false;
      this.cmbOpAC_6.Tag = (object) "cmbOP_1";
      this.txtAutoCaptchaURL.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 204);
      this.txtAutoCaptchaURL.ForeColor = Color.FromArgb(0, 0, 192);
      TextBox txtAutoCaptchaUrl1 = this.txtAutoCaptchaURL;
      point1 = new Point(12, 46);
      Point point28 = point1;
      txtAutoCaptchaUrl1.Location = point28;
      this.txtAutoCaptchaURL.Name = "txtAutoCaptchaURL";
      TextBox txtAutoCaptchaUrl2 = this.txtAutoCaptchaURL;
      size1 = new Size(186, 21);
      Size size28 = size1;
      txtAutoCaptchaUrl2.Size = size28;
      this.txtAutoCaptchaURL.TabIndex = 6;
      this.txtAutoCaptchaURL.TextAlign = HorizontalAlignment.Center;
      this.Label20.AutoSize = true;
      this.Label20.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label20.ForeColor = Color.Gray;
      Label label20_1 = this.Label20;
      point1 = new Point(9, 316);
      Point point29 = point1;
      label20_1.Location = point29;
      this.Label20.Name = "Label20";
      Label label20_2 = this.Label20;
      size1 = new Size(47, 13);
      Size size29 = size1;
      label20_2.Size = size29;
      this.Label20.TabIndex = 109;
      this.Label20.Text = "max_len";
      this.Label20.TextAlign = ContentAlignment.MiddleLeft;
      this.cmbOpAC_5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbOpAC_5.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbOpAC_5.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOpAC_5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbOpAC_5.FormattingEnabled = true;
      this.cmbOpAC_5.Items.AddRange(new object[21]
      {
        (object) "0",
        (object) "1",
        (object) "2",
        (object) "3",
        (object) "4",
        (object) "5",
        (object) "6",
        (object) "7",
        (object) "8",
        (object) "9",
        (object) "10",
        (object) "11",
        (object) "12",
        (object) "13",
        (object) "14",
        (object) "15",
        (object) "16",
        (object) "17",
        (object) "18",
        (object) "19",
        (object) "20"
      });
      ComboBox cmbOpAc5_1 = this.cmbOpAC_5;
      point1 = new Point(63, 285);
      Point point30 = point1;
      cmbOpAc5_1.Location = point30;
      this.cmbOpAC_5.Name = "cmbOpAC_5";
      ComboBox cmbOpAc5_2 = this.cmbOpAC_5;
      size1 = new Size(39, 21);
      Size size30 = size1;
      cmbOpAc5_2.Size = size30;
      this.cmbOpAC_5.TabIndex = 106;
      this.cmbOpAC_5.TabStop = false;
      this.cmbOpAC_5.Tag = (object) "cmbOP_1";
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label19.ForeColor = Color.Gray;
      Label label19_1 = this.Label19;
      point1 = new Point(9, 289);
      Point point31 = point1;
      label19_1.Location = point31;
      this.Label19.Name = "Label19";
      Label label19_2 = this.Label19;
      size1 = new Size(43, 13);
      Size size31 = size1;
      label19_2.Size = size31;
      this.Label19.TabIndex = 107;
      this.Label19.Text = "min_len";
      this.Label19.TextAlign = ContentAlignment.MiddleLeft;
      this.cmbOpAC_4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbOpAC_4.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbOpAC_4.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOpAC_4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbOpAC_4.FormattingEnabled = true;
      this.cmbOpAC_4.Items.AddRange(new object[2]
      {
        (object) "0",
        (object) "1"
      });
      ComboBox cmbOpAc4_1 = this.cmbOpAC_4;
      point1 = new Point(63, 258);
      Point point32 = point1;
      cmbOpAc4_1.Location = point32;
      this.cmbOpAC_4.Name = "cmbOpAC_4";
      ComboBox cmbOpAc4_2 = this.cmbOpAC_4;
      size1 = new Size(39, 21);
      Size size32 = size1;
      cmbOpAc4_2.Size = size32;
      this.cmbOpAC_4.TabIndex = 104;
      this.cmbOpAC_4.TabStop = false;
      this.cmbOpAC_4.Tag = (object) "cmbOP_1";
      this.Label18.AutoSize = true;
      this.Label18.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label18.ForeColor = Color.Gray;
      Label label18_1 = this.Label18;
      point1 = new Point(9, 262);
      Point point33 = point1;
      label18_1.Location = point33;
      this.Label18.Name = "Label18";
      Label label18_2 = this.Label18;
      size1 = new Size(25, 13);
      Size size33 = size1;
      label18_2.Size = size33;
      this.Label18.TabIndex = 105;
      this.Label18.Text = "calc";
      this.Label18.TextAlign = ContentAlignment.MiddleLeft;
      this.cmbOpAC_3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbOpAC_3.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbOpAC_3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOpAC_3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbOpAC_3.FormattingEnabled = true;
      this.cmbOpAC_3.Items.AddRange(new object[2]
      {
        (object) "0",
        (object) "1"
      });
      ComboBox cmbOpAc3_1 = this.cmbOpAC_3;
      point1 = new Point(63, 231);
      Point point34 = point1;
      cmbOpAc3_1.Location = point34;
      this.cmbOpAC_3.Name = "cmbOpAC_3";
      ComboBox cmbOpAc3_2 = this.cmbOpAC_3;
      size1 = new Size(39, 21);
      Size size34 = size1;
      cmbOpAc3_2.Size = size34;
      this.cmbOpAC_3.TabIndex = 102;
      this.cmbOpAC_3.TabStop = false;
      this.cmbOpAC_3.Tag = (object) "cmbOP_1";
      this.Label17.AutoSize = true;
      this.Label17.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label17.ForeColor = Color.Gray;
      Label label17_1 = this.Label17;
      point1 = new Point(9, 235);
      Point point35 = point1;
      label17_1.Location = point35;
      this.Label17.Name = "Label17";
      Label label17_2 = this.Label17;
      size1 = new Size(44, 13);
      Size size35 = size1;
      label17_2.Size = size35;
      this.Label17.TabIndex = 103;
      this.Label17.Text = "numeric";
      this.Label17.TextAlign = ContentAlignment.MiddleLeft;
      this.cmbOpAC_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbOpAC_2.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbOpAC_2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOpAC_2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbOpAC_2.FormattingEnabled = true;
      this.cmbOpAC_2.Items.AddRange(new object[2]
      {
        (object) "0",
        (object) "1"
      });
      ComboBox cmbOpAc2_1 = this.cmbOpAC_2;
      point1 = new Point(63, 204);
      Point point36 = point1;
      cmbOpAc2_1.Location = point36;
      this.cmbOpAC_2.Name = "cmbOpAC_2";
      ComboBox cmbOpAc2_2 = this.cmbOpAC_2;
      size1 = new Size(39, 21);
      Size size36 = size1;
      cmbOpAc2_2.Size = size36;
      this.cmbOpAC_2.TabIndex = 100;
      this.cmbOpAC_2.TabStop = false;
      this.cmbOpAC_2.Tag = (object) "cmbOP_1";
      this.Label16.AutoSize = true;
      this.Label16.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label16.ForeColor = Color.Gray;
      Label label16_1 = this.Label16;
      point1 = new Point(9, 208);
      Point point37 = point1;
      label16_1.Location = point37;
      this.Label16.Name = "Label16";
      Label label16_2 = this.Label16;
      size1 = new Size(51, 13);
      Size size37 = size1;
      label16_2.Size = size37;
      this.Label16.TabIndex = 101;
      this.Label16.Text = "regsense";
      this.Label16.TextAlign = ContentAlignment.MiddleLeft;
      this.cmbOpAC_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbOpAC_1.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbOpAC_1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOpAC_1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbOpAC_1.FormattingEnabled = true;
      this.cmbOpAC_1.Items.AddRange(new object[2]
      {
        (object) "0",
        (object) "1"
      });
      ComboBox cmbOpAc1_1 = this.cmbOpAC_1;
      point1 = new Point(63, 177);
      Point point38 = point1;
      cmbOpAc1_1.Location = point38;
      this.cmbOpAC_1.Name = "cmbOpAC_1";
      ComboBox cmbOpAc1_2 = this.cmbOpAC_1;
      size1 = new Size(39, 21);
      Size size38 = size1;
      cmbOpAc1_2.Size = size38;
      this.cmbOpAC_1.TabIndex = 98;
      this.cmbOpAC_1.TabStop = false;
      this.cmbOpAC_1.Tag = (object) "cmbOP_1";
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label15.ForeColor = Color.Gray;
      Label label15_1 = this.Label15;
      point1 = new Point(9, 181);
      Point point39 = point1;
      label15_1.Location = point39;
      this.Label15.Name = "Label15";
      Label label15_2 = this.Label15;
      size1 = new Size(40, 13);
      Size size39 = size1;
      label15_2.Size = size39;
      this.Label15.TabIndex = 99;
      this.Label15.Text = "phrase";
      this.Label15.TextAlign = ContentAlignment.MiddleLeft;
      this.picLine_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.picLine_2.Image = (Image) componentResourceManager.GetObject("picLine_2.Image");
      PictureBox picLine2_1 = this.picLine_2;
      point1 = new Point(20, 121);
      Point point40 = point1;
      picLine2_1.Location = point40;
      this.picLine_2.Name = "picLine_2";
      PictureBox picLine2_2 = this.picLine_2;
      size1 = new Size(200, 9);
      Size size40 = size1;
      picLine2_2.Size = size40;
      this.picLine_2.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picLine_2.TabIndex = 74;
      this.picLine_2.TabStop = false;
      this.Label2.AutoSize = true;
      this.Label2.ForeColor = Color.FromArgb(0, 64, 64);
      Label label2_1 = this.Label2;
      point1 = new Point(199, 51);
      Point point41 = point1;
      label2_1.Location = point41;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(41, 16);
      Size size41 = size1;
      label2_2.Size = size41;
      this.Label2.TabIndex = 7;
      this.Label2.Text = "HOST";
      this.chOpAC_2.AutoSize = true;
      this.chOpAC_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chOpAC_2.ForeColor = Color.Black;
      CheckBox chOpAc2_1 = this.chOpAC_2;
      point1 = new Point(10, 96);
      Point point42 = point1;
      chOpAc2_1.Location = point42;
      this.chOpAC_2.Name = "chOpAC_2";
      CheckBox chOpAc2_2 = this.chOpAC_2;
      size1 = new Size(224, 17);
      Size size42 = size1;
      chOpAc2_2.Size = size42;
      this.chOpAC_2.TabIndex = 3;
      this.chOpAC_2.Text = "сообщать о неправильно разгаданных";
      this.chOpAC_2.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.ForeColor = Color.FromArgb(0, 64, 64);
      Label label1_1 = this.Label1;
      point1 = new Point(204, 22);
      Point point43 = point1;
      label1_1.Location = point43;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(32, 16);
      Size size43 = size1;
      label1_2.Size = size43;
      this.Label1.TabIndex = 1;
      this.Label1.Text = "KEY";
      this.txtAutoCaptchaKEY.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtAutoCaptchaKey1 = this.txtAutoCaptchaKEY;
      point1 = new Point(10, 20);
      Point point44 = point1;
      txtAutoCaptchaKey1.Location = point44;
      this.txtAutoCaptchaKEY.Name = "txtAutoCaptchaKEY";
      TextBox txtAutoCaptchaKey2 = this.txtAutoCaptchaKEY;
      size1 = new Size(188, 21);
      Size size44 = size1;
      txtAutoCaptchaKey2.Size = size44;
      this.txtAutoCaptchaKEY.TabIndex = 0;
      this.txtAutoCaptchaKEY.TextAlign = HorizontalAlignment.Center;
      this.Label14.AutoSize = true;
      this.Label14.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label14.ForeColor = Color.Silver;
      Label label14_1 = this.Label14;
      point1 = new Point(39, 128);
      Point point45 = point1;
      label14_1.Location = point45;
      this.Label14.Name = "Label14";
      Label label14_2 = this.Label14;
      size1 = new Size(162, 13);
      Size size45 = size1;
      label14_2.Size = size45;
      this.Label14.TabIndex = 97;
      this.Label14.Text = "тонкая настройка параметров";
      this.Label14.TextAlign = ContentAlignment.MiddleLeft;
      this.rbServiceAC_2.AutoSize = true;
      this.rbServiceAC_2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.rbServiceAC_2.ForeColor = Color.Black;
      RadioButton rbServiceAc2_1 = this.rbServiceAC_2;
      point1 = new Point(944, 291);
      Point point46 = point1;
      rbServiceAc2_1.Location = point46;
      this.rbServiceAC_2.Name = "rbServiceAC_2";
      RadioButton rbServiceAc2_2 = this.rbServiceAC_2;
      size1 = new Size(97, 18);
      Size size46 = size1;
      rbServiceAc2_2.Size = size46;
      this.rbServiceAC_2.TabIndex = 107;
      this.rbServiceAC_2.TabStop = true;
      this.rbServiceAC_2.Text = "Captchabot";
      this.rbServiceAC_2.UseVisualStyleBackColor = true;
      this.rbServiceAC_2.Visible = false;
      this.rbServiceAC_1.AutoSize = true;
      this.rbServiceAC_1.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.rbServiceAC_1.ForeColor = Color.Black;
      RadioButton rbServiceAc1_1 = this.rbServiceAC_1;
      point1 = new Point(955, 273);
      Point point47 = point1;
      rbServiceAc1_1.Location = point47;
      this.rbServiceAC_1.Name = "rbServiceAC_1";
      RadioButton rbServiceAc1_2 = this.rbServiceAC_1;
      size1 = new Size(79, 18);
      Size size47 = size1;
      rbServiceAc1_2.Size = size47;
      this.rbServiceAC_1.TabIndex = 106;
      this.rbServiceAC_1.TabStop = true;
      this.rbServiceAC_1.Text = "Antigate";
      this.rbServiceAC_1.UseVisualStyleBackColor = true;
      this.rbServiceAC_1.Visible = false;
      this.chOpAC_3.AutoSize = true;
      this.chOpAC_3.Enabled = false;
      this.chOpAC_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chOpAC_3.ForeColor = Color.Black;
      CheckBox chOpAc3_1 = this.chOpAC_3;
      point1 = new Point(944, 276);
      Point point48 = point1;
      chOpAc3_1.Location = point48;
      this.chOpAC_3.Name = "chOpAC_3";
      CheckBox chOpAc3_2 = this.chOpAC_3;
      size1 = new Size(186, 17);
      Size size48 = size1;
      chOpAc3_2.Size = size48;
      this.chOpAC_3.TabIndex = 4;
      this.chOpAC_3.Text = "сообщать сразу, если LEN <> 6";
      this.chOpAC_3.UseVisualStyleBackColor = true;
      this.chOpAC_3.Visible = false;
      this.GroupBox2.Controls.Add((Control) this.cmbOpMailDownload_1);
      this.GroupBox2.Controls.Add((Control) this.chOpMailDownload_2);
      this.GroupBox2.Controls.Add((Control) this.chOpMailDownload_1);
      this.GroupBox2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.GroupBox2.ForeColor = Color.Magenta;
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(8, 475);
      Point point49 = point1;
      groupBox2_1.Location = point49;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(240, 88);
      Size size49 = size1;
      groupBox2_2.Size = size49;
      this.GroupBox2.TabIndex = 3;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Опции загрузки писем";
      this.cmbOpMailDownload_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbOpMailDownload_1.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbOpMailDownload_1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOpMailDownload_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbOpMailDownload_1.FormattingEnabled = true;
      this.cmbOpMailDownload_1.Items.AddRange(new object[3]
      {
        (object) "сохранять все письма в 1 файл",
        (object) "1 ящик = 1 файлу  'xxxx@xxx.ru'",
        (object) "удалять"
      });
      ComboBox cmbOpMailDownload1_1 = this.cmbOpMailDownload_1;
      point1 = new Point(8, 41);
      Point point50 = point1;
      cmbOpMailDownload1_1.Location = point50;
      this.cmbOpMailDownload_1.Name = "cmbOpMailDownload_1";
      ComboBox cmbOpMailDownload1_2 = this.cmbOpMailDownload_1;
      size1 = new Size(218, 21);
      Size size50 = size1;
      cmbOpMailDownload1_2.Size = size50;
      this.cmbOpMailDownload_1.TabIndex = 64;
      this.cmbOpMailDownload_1.TabStop = false;
      this.cmbOpMailDownload_1.Tag = (object) "cmbOP_1";
      this.chOpMailDownload_2.AutoSize = true;
      this.chOpMailDownload_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chOpMailDownload_2.ForeColor = Color.Black;
      CheckBox chOpMailDownload2_1 = this.chOpMailDownload_2;
      point1 = new Point(8, 67);
      Point point51 = point1;
      chOpMailDownload2_1.Location = point51;
      this.chOpMailDownload_2.Name = "chOpMailDownload_2";
      CheckBox chOpMailDownload2_2 = this.chOpMailDownload_2;
      size1 = new Size(158, 17);
      Size size51 = size1;
      chOpMailDownload2_2.Size = size51;
      this.chOpMailDownload_2.TabIndex = 63;
      this.chOpMailDownload_2.Text = "добавлять в конец файла";
      this.chOpMailDownload_2.UseVisualStyleBackColor = true;
      this.chOpMailDownload_1.AutoSize = true;
      this.chOpMailDownload_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chOpMailDownload_1.ForeColor = Color.Black;
      CheckBox chOpMailDownload1_1 = this.chOpMailDownload_1;
      point1 = new Point(8, 24);
      Point point52 = point1;
      chOpMailDownload1_1.Location = point52;
      this.chOpMailDownload_1.Name = "chOpMailDownload_1";
      CheckBox chOpMailDownload1_2 = this.chOpMailDownload_1;
      size1 = new Size(208, 17);
      Size size52 = size1;
      chOpMailDownload1_2.Size = size52;
      this.chOpMailDownload_1.TabIndex = 5;
      this.chOpMailDownload_1.Text = "после загрузки удалять на сервере";
      this.chOpMailDownload_1.UseVisualStyleBackColor = true;
      this.GroupBox3.Controls.Add((Control) this.Label30);
      this.GroupBox3.Controls.Add((Control) this.cmbConnectMethod);
      this.GroupBox3.Controls.Add((Control) this.lblSocketTimeOut);
      this.GroupBox3.Controls.Add((Control) this.chSocketTimeOut);
      this.GroupBox3.Controls.Add((Control) this.Label28);
      this.GroupBox3.Controls.Add((Control) this.txtErrorCount);
      this.GroupBox3.Controls.Add((Control) this.chUseErrorCount);
      this.GroupBox3.Controls.Add((Control) this.txtIntervalConnect);
      this.GroupBox3.Controls.Add((Control) this.txtSocketTimeOut);
      this.GroupBox3.Controls.Add((Control) this.txtOP_2);
      this.GroupBox3.Controls.Add((Control) this.chOP_3);
      this.GroupBox3.Controls.Add((Control) this.chOP_2);
      this.GroupBox3.Controls.Add((Control) this.chOP_1);
      this.GroupBox3.Controls.Add((Control) this.cmbOP_1);
      this.GroupBox3.Controls.Add((Control) this.txtOP_1);
      this.GroupBox3.Controls.Add((Control) this.Label4);
      this.GroupBox3.Controls.Add((Control) this.rbOP_2);
      this.GroupBox3.Controls.Add((Control) this.rbOP_1);
      this.GroupBox3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.GroupBox3.ForeColor = Color.Magenta;
      GroupBox groupBox3_1 = this.GroupBox3;
      point1 = new Point(8, 8);
      Point point53 = point1;
      groupBox3_1.Location = point53;
      this.GroupBox3.Name = "GroupBox3";
      GroupBox groupBox3_2 = this.GroupBox3;
      size1 = new Size(240, 283);
      Size size53 = size1;
      groupBox3_2.Size = size53;
      this.GroupBox3.TabIndex = 4;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Опции регистрации";
      this.Label30.AutoSize = true;
      this.Label30.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Label30.ForeColor = Color.Black;
      Label label30_1 = this.Label30;
      point1 = new Point(9, 246);
      Point point54 = point1;
      label30_1.Location = point54;
      this.Label30.Name = "Label30";
      Label label30_2 = this.Label30;
      size1 = new Size(53, 26);
      Size size54 = size1;
      label30_2.Size = size54;
      this.Label30.TabIndex = (int) sbyte.MaxValue;
      this.Label30.Text = "Connect\r\nmethod";
      this.Label30.TextAlign = ContentAlignment.MiddleCenter;
      this.cmbConnectMethod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbConnectMethod.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbConnectMethod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbConnectMethod.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbConnectMethod.FormattingEnabled = true;
      this.cmbConnectMethod.Items.AddRange(new object[2]
      {
        (object) "Hard (Faster)",
        (object) "Light (Slow)"
      });
      ComboBox cmbConnectMethod1 = this.cmbConnectMethod;
      point1 = new Point(78, 246);
      Point point55 = point1;
      cmbConnectMethod1.Location = point55;
      this.cmbConnectMethod.Name = "cmbConnectMethod";
      ComboBox cmbConnectMethod2 = this.cmbConnectMethod;
      size1 = new Size(152, 24);
      Size size55 = size1;
      cmbConnectMethod2.Size = size55;
      this.cmbConnectMethod.TabIndex = 126;
      this.cmbConnectMethod.TabStop = false;
      this.cmbConnectMethod.Tag = (object) "cmbOP_1";
      this.lblSocketTimeOut.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lblSocketTimeOut.ForeColor = Color.Black;
      Label lblSocketTimeOut1 = this.lblSocketTimeOut;
      point1 = new Point(10, 173);
      Point point56 = point1;
      lblSocketTimeOut1.Location = point56;
      this.lblSocketTimeOut.Name = "lblSocketTimeOut";
      Label lblSocketTimeOut2 = this.lblSocketTimeOut;
      size1 = new Size(148, 13);
      Size size56 = size1;
      lblSocketTimeOut2.Size = size56;
      this.lblSocketTimeOut.TabIndex = 125;
      this.lblSocketTimeOut.Text = "Socket TimeOut (ms)";
      this.chSocketTimeOut.AutoSize = true;
      this.chSocketTimeOut.Enabled = false;
      this.chSocketTimeOut.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chSocketTimeOut.ForeColor = Color.Black;
      CheckBox chSocketTimeOut1 = this.chSocketTimeOut;
      point1 = new Point(181, 19);
      Point point57 = point1;
      chSocketTimeOut1.Location = point57;
      this.chSocketTimeOut.Name = "chSocketTimeOut";
      CheckBox chSocketTimeOut2 = this.chSocketTimeOut;
      size1 = new Size(125, 17);
      Size size57 = size1;
      chSocketTimeOut2.Size = size57;
      this.chSocketTimeOut.TabIndex = 65;
      this.chSocketTimeOut.Tag = (object) "chOP_1";
      this.chSocketTimeOut.Text = "Socket TimeOut (ms)";
      this.chSocketTimeOut.UseVisualStyleBackColor = true;
      this.chSocketTimeOut.Visible = false;
      this.Label28.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Label28.ForeColor = Color.Black;
      Label label28_1 = this.Label28;
      point1 = new Point(6, 196);
      Point point58 = point1;
      label28_1.Location = point58;
      this.Label28.Name = "Label28";
      Label label28_2 = this.Label28;
      size1 = new Size(167, 13);
      Size size58 = size1;
      label28_2.Size = size58;
      this.Label28.TabIndex = 124;
      this.Label28.Text = "Интервал коннектов (мс)";
      this.Label28.TextAlign = ContentAlignment.MiddleCenter;
      this.txtErrorCount.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtErrorCount1 = this.txtErrorCount;
      point1 = new Point(183, 219);
      Point point59 = point1;
      txtErrorCount1.Location = point59;
      this.txtErrorCount.MaxLength = 7;
      this.txtErrorCount.Name = "txtErrorCount";
      TextBox txtErrorCount2 = this.txtErrorCount;
      size1 = new Size(47, 21);
      Size size59 = size1;
      txtErrorCount2.Size = size59;
      this.txtErrorCount.TabIndex = 62;
      this.txtErrorCount.Tag = (object) "txtOP_2";
      this.txtErrorCount.TextAlign = HorizontalAlignment.Center;
      this.chUseErrorCount.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chUseErrorCount.ForeColor = Color.Navy;
      CheckBox chUseErrorCount1 = this.chUseErrorCount;
      point1 = new Point(6, 219);
      Point point60 = point1;
      chUseErrorCount1.Location = point60;
      this.chUseErrorCount.Name = "chUseErrorCount";
      CheckBox chUseErrorCount2 = this.chUseErrorCount;
      size1 = new Size(174, 20);
      Size size60 = size1;
      chUseErrorCount2.Size = size60;
      this.chUseErrorCount.TabIndex = 61;
      this.chUseErrorCount.Tag = (object) "chOP_1";
      this.chUseErrorCount.Text = "контроль кол-ва ошибок:";
      this.chUseErrorCount.UseVisualStyleBackColor = true;
      this.txtIntervalConnect.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtIntervalConnect1 = this.txtIntervalConnect;
      point1 = new Point(174, 192);
      Point point61 = point1;
      txtIntervalConnect1.Location = point61;
      this.txtIntervalConnect.MaxLength = 7;
      this.txtIntervalConnect.Name = "txtIntervalConnect";
      TextBox txtIntervalConnect2 = this.txtIntervalConnect;
      size1 = new Size(56, 21);
      Size size61 = size1;
      txtIntervalConnect2.Size = size61;
      this.txtIntervalConnect.TabIndex = 68;
      this.txtIntervalConnect.Tag = (object) "txtOP_2";
      this.txtIntervalConnect.TextAlign = HorizontalAlignment.Center;
      this.txtIntervalConnect.WordWrap = false;
      this.txtSocketTimeOut.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtSocketTimeOut1 = this.txtSocketTimeOut;
      point1 = new Point(174, 169);
      Point point62 = point1;
      txtSocketTimeOut1.Location = point62;
      this.txtSocketTimeOut.MaxLength = 6;
      this.txtSocketTimeOut.Name = "txtSocketTimeOut";
      TextBox txtSocketTimeOut2 = this.txtSocketTimeOut;
      size1 = new Size(56, 21);
      Size size62 = size1;
      txtSocketTimeOut2.Size = size62;
      this.txtSocketTimeOut.TabIndex = 67;
      this.txtSocketTimeOut.Tag = (object) "txtOP_2";
      this.txtSocketTimeOut.TextAlign = HorizontalAlignment.Center;
      this.txtOP_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtOp2_1 = this.txtOP_2;
      point1 = new Point(174, 144);
      Point point63 = point1;
      txtOp2_1.Location = point63;
      this.txtOP_2.MaxLength = 7;
      this.txtOP_2.Name = "txtOP_2";
      TextBox txtOp2_2 = this.txtOP_2;
      size1 = new Size(56, 21);
      Size size63 = size1;
      txtOp2_2.Size = size63;
      this.txtOP_2.TabIndex = 62;
      this.txtOP_2.Tag = (object) "txtOP_2";
      this.txtOP_2.TextAlign = HorizontalAlignment.Center;
      this.chOP_3.AutoSize = true;
      this.chOP_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chOP_3.ForeColor = Color.Black;
      CheckBox chOp3_1 = this.chOP_3;
      point1 = new Point(8, 128);
      Point point64 = point1;
      chOp3_1.Location = point64;
      this.chOP_3.Name = "chOP_3";
      CheckBox chOp3_2 = this.chOP_3;
      size1 = new Size(183, 17);
      Size size64 = size1;
      chOp3_2.Size = size64;
      this.chOP_3.TabIndex = 64;
      this.chOP_3.Tag = (object) "chOP_3";
      this.chOP_3.Text = "реконнект при Unknown Packet";
      this.chOP_3.UseVisualStyleBackColor = true;
      this.chOP_2.AutoSize = true;
      this.chOP_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chOP_2.ForeColor = Color.Black;
      CheckBox chOp2_1 = this.chOP_2;
      point1 = new Point(8, 110);
      Point point65 = point1;
      chOp2_1.Location = point65;
      this.chOP_2.Name = "chOP_2";
      CheckBox chOp2_2 = this.chOP_2;
      size1 = new Size(217, 17);
      Size size65 = size1;
      chOp2_2.Size = size65;
      this.chOP_2.TabIndex = 63;
      this.chOP_2.Tag = (object) "chOP_2";
      this.chOP_2.Text = "автоматически генерировать логины";
      this.chOP_2.UseVisualStyleBackColor = true;
      this.chOP_1.AutoSize = true;
      this.chOP_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chOP_1.ForeColor = Color.Black;
      CheckBox chOp1_1 = this.chOP_1;
      point1 = new Point(8, 146);
      Point point66 = point1;
      chOp1_1.Location = point66;
      this.chOP_1.Name = "chOP_1";
      CheckBox chOp1_2 = this.chOP_1;
      size1 = new Size(164, 17);
      Size size66 = size1;
      chOp1_2.Size = size66;
      this.chOP_1.TabIndex = 61;
      this.chOP_1.Tag = (object) "chOP_1";
      this.chOP_1.Text = "реконнект при ошибке (мс)";
      this.chOP_1.UseVisualStyleBackColor = true;
      this.cmbOP_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbOP_1.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbOP_1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOP_1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbOP_1.FormattingEnabled = true;
      this.cmbOP_1.Items.AddRange(new object[3]
      {
        (object) "random",
        (object) "в том же домене",
        (object) "№ (1 - 8)"
      });
      ComboBox cmbOp1_1 = this.cmbOP_1;
      point1 = new Point(78, 82);
      Point point67 = point1;
      cmbOp1_1.Location = point67;
      this.cmbOP_1.Name = "cmbOP_1";
      ComboBox cmbOp1_2 = this.cmbOP_1;
      size1 = new Size(152, 24);
      Size size67 = size1;
      cmbOp1_2.Size = size67;
      this.cmbOP_1.TabIndex = 55;
      this.cmbOP_1.TabStop = false;
      this.cmbOP_1.Tag = (object) "cmbOP_1";
      this.txtOP_1.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtOp1_1 = this.txtOP_1;
      point1 = new Point(50, 83);
      Point point68 = point1;
      txtOp1_1.Location = point68;
      this.txtOP_1.MaxLength = 1;
      this.txtOP_1.Name = "txtOP_1";
      TextBox txtOp1_2 = this.txtOP_1;
      size1 = new Size(24, 22);
      Size size68 = size1;
      txtOp1_2.Size = size68;
      this.txtOP_1.TabIndex = 56;
      this.txtOP_1.Tag = (object) "txtOP_1";
      this.txtOP_1.TextAlign = HorizontalAlignment.Center;
      this.txtOP_1.Visible = false;
      this.txtOP_1.WordWrap = false;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label4.ForeColor = Color.Black;
      Label label4_1 = this.Label4;
      point1 = new Point(8, 22);
      Point point69 = point1;
      label4_1.Location = point69;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(110, 14);
      Size size69 = size1;
      label4_2.Size = size69;
      this.Label4.TabIndex = 14;
      this.Label4.Text = "Если логин занят:";
      this.rbOP_2.AutoSize = true;
      this.rbOP_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.rbOP_2.ForeColor = Color.Black;
      RadioButton rbOp2_1 = this.rbOP_2;
      point1 = new Point(28, 60);
      Point point70 = point1;
      rbOp2_1.Location = point70;
      this.rbOP_2.Name = "rbOP_2";
      RadioButton rbOp2_2 = this.rbOP_2;
      size1 = new Size(178, 17);
      Size size70 = size1;
      rbOp2_2.Size = size70;
      this.rbOP_2.TabIndex = 13;
      this.rbOP_2.Tag = (object) "rbOP_2";
      this.rbOP_2.Text = "выбрать из предоставленных";
      this.rbOP_2.UseVisualStyleBackColor = true;
      this.rbOP_1.AutoSize = true;
      this.rbOP_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.rbOP_1.ForeColor = Color.Black;
      RadioButton rbOp1_1 = this.rbOP_1;
      point1 = new Point(28, 40);
      Point point71 = point1;
      rbOp1_1.Location = point71;
      this.rbOP_1.Name = "rbOP_1";
      RadioButton rbOp1_2 = this.rbOP_1;
      size1 = new Size(145, 17);
      Size size71 = size1;
      rbOp1_2.Size = size71;
      this.rbOP_1.TabIndex = 12;
      this.rbOP_1.Tag = (object) "rbOP_1";
      this.rbOP_1.Text = "перейти к следующему";
      this.rbOP_1.UseVisualStyleBackColor = true;
      this.GroupBox4.Controls.Add((Control) this.cmbOPSaveList_2);
      this.GroupBox4.Controls.Add((Control) this.chOPSaveList_4);
      this.GroupBox4.Controls.Add((Control) this.chOPSaveList_1);
      this.GroupBox4.Controls.Add((Control) this.chOPSaveList_3);
      this.GroupBox4.Controls.Add((Control) this.cmbOPSaveList_1);
      this.GroupBox4.Controls.Add((Control) this.Label6);
      this.GroupBox4.Controls.Add((Control) this.txtOPSaveList_1);
      this.GroupBox4.Controls.Add((Control) this.Label5);
      this.GroupBox4.Controls.Add((Control) this.chOPSaveList_2);
      this.GroupBox4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.GroupBox4.ForeColor = Color.Magenta;
      GroupBox groupBox4_1 = this.GroupBox4;
      point1 = new Point(8, 297);
      Point point72 = point1;
      groupBox4_1.Location = point72;
      this.GroupBox4.Name = "GroupBox4";
      GroupBox groupBox4_2 = this.GroupBox4;
      size1 = new Size(240, 176);
      Size size72 = size1;
      groupBox4_2.Size = size72;
      this.GroupBox4.TabIndex = 5;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Опции сохранения списка";
      this.cmbOPSaveList_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbOPSaveList_2.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbOPSaveList_2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOPSaveList_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbOPSaveList_2.FormattingEnabled = true;
      this.cmbOPSaveList_2.Items.AddRange(new object[2]
      {
        (object) "сохранять весь список (registered)",
        (object) "сохранять только выделенные"
      });
      ComboBox cmbOpSaveList2_1 = this.cmbOPSaveList_2;
      point1 = new Point(8, 72);
      Point point73 = point1;
      cmbOpSaveList2_1.Location = point73;
      this.cmbOPSaveList_2.Name = "cmbOPSaveList_2";
      ComboBox cmbOpSaveList2_2 = this.cmbOPSaveList_2;
      size1 = new Size(218, 21);
      Size size73 = size1;
      cmbOpSaveList2_2.Size = size73;
      this.cmbOPSaveList_2.TabIndex = 63;
      this.cmbOPSaveList_2.TabStop = false;
      this.cmbOPSaveList_2.Tag = (object) "cmbOP_1";
      this.chOPSaveList_4.AutoSize = true;
      this.chOPSaveList_4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chOPSaveList_4.ForeColor = Color.Black;
      CheckBox chOpSaveList4_1 = this.chOPSaveList_4;
      point1 = new Point(68, 99);
      Point point74 = point1;
      chOpSaveList4_1.Location = point74;
      this.chOPSaveList_4.Name = "chOPSaveList_4";
      CheckBox chOpSaveList4_2 = this.chOPSaveList_4;
      size1 = new Size(158, 17);
      Size size74 = size1;
      chOpSaveList4_2.Size = size74;
      this.chOPSaveList_4.TabIndex = 62;
      this.chOPSaveList_4.Text = "добавлять в конец файла";
      this.chOPSaveList_4.UseVisualStyleBackColor = true;
      this.chOPSaveList_1.AutoSize = true;
      this.chOPSaveList_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chOPSaveList_1.ForeColor = Color.Black;
      CheckBox chOpSaveList1_1 = this.chOPSaveList_1;
      point1 = new Point(8, 117);
      Point point75 = point1;
      chOpSaveList1_1.Location = point75;
      this.chOPSaveList_1.Name = "chOPSaveList_1";
      CheckBox chOpSaveList1_2 = this.chOPSaveList_1;
      size1 = new Size(126, 17);
      Size size75 = size1;
      chOpSaveList1_2.Size = size75;
      this.chOPSaveList_1.TabIndex = 61;
      this.chOPSaveList_1.Text = "сохранять @domain";
      this.chOPSaveList_1.UseVisualStyleBackColor = true;
      this.chOPSaveList_3.AutoSize = true;
      this.chOPSaveList_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chOPSaveList_3.ForeColor = Color.Black;
      CheckBox chOpSaveList3_1 = this.chOPSaveList_3;
      point1 = new Point(8, 155);
      Point point76 = point1;
      chOpSaveList3_1.Location = point76;
      this.chOPSaveList_3.Name = "chOPSaveList_3";
      CheckBox chOpSaveList3_2 = this.chOPSaveList_3;
      size1 = new Size(149, 17);
      Size size76 = size1;
      chOpSaveList3_2.Size = size76;
      this.chOPSaveList_3.TabIndex = 60;
      this.chOPSaveList_3.Text = "сохранять Фамилия/Имя";
      this.chOPSaveList_3.UseVisualStyleBackColor = true;
      this.cmbOPSaveList_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbOPSaveList_1.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbOPSaveList_1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOPSaveList_1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbOPSaveList_1.FormattingEnabled = true;
      this.cmbOPSaveList_1.Items.AddRange(new object[2]
      {
        (object) "CrLf",
        (object) "Lf"
      });
      ComboBox cmbOpSaveList1_1 = this.cmbOPSaveList_1;
      point1 = new Point(170, 46);
      Point point77 = point1;
      cmbOpSaveList1_1.Location = point77;
      this.cmbOPSaveList_1.Name = "cmbOPSaveList_1";
      ComboBox cmbOpSaveList1_2 = this.cmbOPSaveList_1;
      size1 = new Size(56, 24);
      Size size77 = size1;
      cmbOpSaveList1_2.Size = size77;
      this.cmbOPSaveList_1.TabIndex = 59;
      this.cmbOPSaveList_1.TabStop = false;
      this.Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label6.ForeColor = Color.Black;
      Label label6_1 = this.Label6;
      point1 = new Point(10, 52);
      Point point78 = point1;
      label6_1.Location = point78;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(114, 13);
      Size size78 = size1;
      label6_2.Size = size78;
      this.Label6.TabIndex = 58;
      this.Label6.Text = "разделитель строк";
      this.txtOPSaveList_1.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtOpSaveList1_1 = this.txtOPSaveList_1;
      point1 = new Point(184, 20);
      Point point79 = point1;
      txtOpSaveList1_1.Location = point79;
      this.txtOPSaveList_1.MaxLength = 5;
      this.txtOPSaveList_1.Name = "txtOPSaveList_1";
      TextBox txtOpSaveList1_2 = this.txtOPSaveList_1;
      size1 = new Size(42, 22);
      Size size79 = size1;
      txtOpSaveList1_2.Size = size79;
      this.txtOPSaveList_1.TabIndex = 57;
      this.txtOPSaveList_1.TextAlign = HorizontalAlignment.Center;
      this.Label5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label5.ForeColor = Color.Black;
      Label label5_1 = this.Label5;
      point1 = new Point(10, 24);
      Point point80 = point1;
      label5_1.Location = point80;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(186, 13);
      Size size80 = size1;
      label5_2.Size = size80;
      this.Label5.TabIndex = 14;
      this.Label5.Text = "разделитель в строке (1-5 зн.)";
      this.chOPSaveList_2.AutoSize = true;
      this.chOPSaveList_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chOPSaveList_2.ForeColor = Color.Black;
      CheckBox chOpSaveList2_1 = this.chOPSaveList_2;
      point1 = new Point(8, 135);
      Point point81 = point1;
      chOpSaveList2_1.Location = point81;
      this.chOPSaveList_2.Name = "chOPSaveList_2";
      CheckBox chOpSaveList2_2 = this.chOPSaveList_2;
      size1 = new Size(172, 17);
      Size size81 = size1;
      chOpSaveList2_2.Size = size81;
      this.chOPSaveList_2.TabIndex = 5;
      this.chOPSaveList_2.Text = "сохранять Секретный ответ";
      this.chOPSaveList_2.UseVisualStyleBackColor = true;
      this.chdebugOp_SaveBadCaptcha.AutoSize = true;
      this.chdebugOp_SaveBadCaptcha.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chdebugOp_SaveBadCaptcha.ForeColor = Color.Black;
      CheckBox opSaveBadCaptcha1 = this.chdebugOp_SaveBadCaptcha;
      point1 = new Point(6, 60);
      Point point82 = point1;
      opSaveBadCaptcha1.Location = point82;
      this.chdebugOp_SaveBadCaptcha.Name = "chdebugOp_SaveBadCaptcha";
      CheckBox opSaveBadCaptcha2 = this.chdebugOp_SaveBadCaptcha;
      size1 = new Size(95, 17);
      Size size82 = size1;
      opSaveBadCaptcha2.Size = size82;
      this.chdebugOp_SaveBadCaptcha.TabIndex = 63;
      this.chdebugOp_SaveBadCaptcha.Text = "Full debugging";
      this.chdebugOp_SaveBadCaptcha.UseVisualStyleBackColor = true;
      this.chSavePacket_RegError.AutoSize = true;
      this.chSavePacket_RegError.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chSavePacket_RegError.ForeColor = Color.Black;
      CheckBox savePacketRegError1 = this.chSavePacket_RegError;
      point1 = new Point(6, 41);
      Point point83 = point1;
      savePacketRegError1.Location = point83;
      this.chSavePacket_RegError.Name = "chSavePacket_RegError";
      CheckBox savePacketRegError2 = this.chSavePacket_RegError;
      size1 = new Size(112, 17);
      Size size83 = size1;
      savePacketRegError2.Size = size83;
      this.chSavePacket_RegError.TabIndex = 64;
      this.chSavePacket_RegError.Text = "Save Error Packet";
      this.chSavePacket_RegError.UseVisualStyleBackColor = true;
      this.chSaveLog.AutoSize = true;
      this.chSaveLog.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chSaveLog.ForeColor = Color.Black;
      CheckBox chSaveLog1 = this.chSaveLog;
      point1 = new Point(6, 22);
      Point point84 = point1;
      chSaveLog1.Location = point84;
      this.chSaveLog.Name = "chSaveLog";
      CheckBox chSaveLog2 = this.chSaveLog;
      size1 = new Size(141, 17);
      Size size84 = size1;
      chSaveLog2.Size = size84;
      this.chSaveLog.TabIndex = 65;
      this.chSaveLog.Text = "Save Main TextBox  Log";
      this.chSaveLog.UseVisualStyleBackColor = true;
      this.GroupBox5.Controls.Add((Control) this.chBannedProxy);
      this.GroupBox5.Controls.Add((Control) this.chdebugOp_FullSessionLog);
      this.GroupBox5.Controls.Add((Control) this.chdebugOp_SaveBadIP);
      this.GroupBox5.Controls.Add((Control) this.chdebugOp_SaveBadCaptcha);
      this.GroupBox5.Controls.Add((Control) this.chSaveLog);
      this.GroupBox5.Controls.Add((Control) this.chSavePacket_RegError);
      this.GroupBox5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.GroupBox5.ForeColor = Color.Purple;
      GroupBox groupBox5_1 = this.GroupBox5;
      point1 = new Point(254, 445);
      Point point85 = point1;
      groupBox5_1.Location = point85;
      this.GroupBox5.Name = "GroupBox5";
      GroupBox groupBox5_2 = this.GroupBox5;
      size1 = new Size(240, 118);
      Size size85 = size1;
      groupBox5_2.Size = size85;
      this.GroupBox5.TabIndex = 66;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "debug";
      this.chBannedProxy.AutoSize = true;
      this.chBannedProxy.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chBannedProxy.ForeColor = Color.Black;
      CheckBox chBannedProxy1 = this.chBannedProxy;
      point1 = new Point(159, 92);
      Point point86 = point1;
      chBannedProxy1.Location = point86;
      this.chBannedProxy.Name = "chBannedProxy";
      CheckBox chBannedProxy2 = this.chBannedProxy;
      size1 = new Size(75, 17);
      Size size86 = size1;
      chBannedProxy2.Size = size86;
      this.chBannedProxy.TabIndex = 68;
      this.chBannedProxy.Text = "Ban Proxy";
      this.chBannedProxy.UseVisualStyleBackColor = true;
      this.chdebugOp_FullSessionLog.AutoSize = true;
      this.chdebugOp_FullSessionLog.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chdebugOp_FullSessionLog.ForeColor = Color.Black;
      CheckBox opFullSessionLog1 = this.chdebugOp_FullSessionLog;
      point1 = new Point(6, 98);
      Point point87 = point1;
      opFullSessionLog1.Location = point87;
      this.chdebugOp_FullSessionLog.Name = "chdebugOp_FullSessionLog";
      CheckBox opFullSessionLog2 = this.chdebugOp_FullSessionLog;
      size1 = new Size(101, 17);
      Size size87 = size1;
      opFullSessionLog2.Size = size87;
      this.chdebugOp_FullSessionLog.TabIndex = 67;
      this.chdebugOp_FullSessionLog.Text = "dbg break error";
      this.chdebugOp_FullSessionLog.UseVisualStyleBackColor = true;
      this.chdebugOp_SaveBadIP.AutoSize = true;
      this.chdebugOp_SaveBadIP.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chdebugOp_SaveBadIP.ForeColor = Color.Black;
      CheckBox chdebugOpSaveBadIp1 = this.chdebugOp_SaveBadIP;
      point1 = new Point(6, 79);
      Point point88 = point1;
      chdebugOpSaveBadIp1.Location = point88;
      this.chdebugOp_SaveBadIP.Name = "chdebugOp_SaveBadIP";
      CheckBox chdebugOpSaveBadIp2 = this.chdebugOp_SaveBadIP;
      size1 = new Size(84, 17);
      Size size88 = size1;
      chdebugOpSaveBadIp2.Size = size88;
      this.chdebugOp_SaveBadIP.TabIndex = 66;
      this.chdebugOp_SaveBadIP.Text = "Save bad IP";
      this.chdebugOp_SaveBadIP.UseVisualStyleBackColor = true;
      this.boxHttpLoadProxy.Controls.Add((Control) this.chAfterLoadStartOne);
      this.boxHttpLoadProxy.Controls.Add((Control) this.lblHttpLoadProxy_Count);
      this.boxHttpLoadProxy.Controls.Add((Control) this.chHttpLoadProxy_Append);
      this.boxHttpLoadProxy.Controls.Add((Control) this.chHttpLoadProxy_LoadInStart);
      this.boxHttpLoadProxy.Controls.Add((Control) this.Label9);
      this.boxHttpLoadProxy.Controls.Add((Control) this.Button2);
      this.boxHttpLoadProxy.Controls.Add((Control) this.btnOpenProxy);
      this.boxHttpLoadProxy.Controls.Add((Control) this.Button1);
      this.boxHttpLoadProxy.Controls.Add((Control) this.lblHttpLoadProxy_UrlCount);
      this.boxHttpLoadProxy.Controls.Add((Control) this.cmbHttpLoadProxy);
      this.boxHttpLoadProxy.Controls.Add((Control) this.Label7);
      this.boxHttpLoadProxy.Controls.Add((Control) this.txtHttpLoadProxy_RegEx);
      this.boxHttpLoadProxy.Controls.Add((Control) this.chHttpLoadProxy_UseRegEx);
      this.boxHttpLoadProxy.Controls.Add((Control) this.lblInfoProxyLoad);
      this.boxHttpLoadProxy.Enabled = false;
      this.boxHttpLoadProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.boxHttpLoadProxy.ForeColor = Color.Black;
      GroupBox boxHttpLoadProxy1 = this.boxHttpLoadProxy;
      point1 = new Point(500, 10);
      Point point89 = point1;
      boxHttpLoadProxy1.Location = point89;
      this.boxHttpLoadProxy.Name = "boxHttpLoadProxy";
      GroupBox boxHttpLoadProxy2 = this.boxHttpLoadProxy;
      size1 = new Size(394, 240);
      Size size89 = size1;
      boxHttpLoadProxy2.Size = size89;
      this.boxHttpLoadProxy.TabIndex = 67;
      this.boxHttpLoadProxy.TabStop = false;
      this.chAfterLoadStartOne.AutoSize = true;
      this.chAfterLoadStartOne.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chAfterLoadStartOne.ForeColor = Color.Black;
      CheckBox afterLoadStartOne1 = this.chAfterLoadStartOne;
      point1 = new Point(9, 190);
      Point point90 = point1;
      afterLoadStartOne1.Location = point90;
      this.chAfterLoadStartOne.Name = "chAfterLoadStartOne";
      CheckBox afterLoadStartOne2 = this.chAfterLoadStartOne;
      size1 = new Size(230, 17);
      Size size90 = size1;
      afterLoadStartOne2.Size = size90;
      this.chAfterLoadStartOne.TabIndex = 98;
      this.chAfterLoadStartOne.Text = "После загрузки начинать с 1 акк. (рек.)";
      this.chAfterLoadStartOne.UseVisualStyleBackColor = true;
      this.lblHttpLoadProxy_Count.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label httpLoadProxyCount1 = this.lblHttpLoadProxy_Count;
      point1 = new Point(188, 214);
      Point point91 = point1;
      httpLoadProxyCount1.Location = point91;
      this.lblHttpLoadProxy_Count.Name = "lblHttpLoadProxy_Count";
      Label httpLoadProxyCount2 = this.lblHttpLoadProxy_Count;
      size1 = new Size(55, 14);
      Size size91 = size1;
      httpLoadProxyCount2.Size = size91;
      this.lblHttpLoadProxy_Count.TabIndex = 97;
      this.lblHttpLoadProxy_Count.Text = "0";
      this.lblHttpLoadProxy_Count.TextAlign = ContentAlignment.MiddleCenter;
      this.chHttpLoadProxy_Append.AutoSize = true;
      this.chHttpLoadProxy_Append.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chHttpLoadProxy_Append.ForeColor = Color.Black;
      CheckBox httpLoadProxyAppend1 = this.chHttpLoadProxy_Append;
      point1 = new Point(9, 170);
      Point point92 = point1;
      httpLoadProxyAppend1.Location = point92;
      this.chHttpLoadProxy_Append.Name = "chHttpLoadProxy_Append";
      CheckBox httpLoadProxyAppend2 = this.chHttpLoadProxy_Append;
      size1 = new Size(161, 17);
      Size size92 = size1;
      httpLoadProxyAppend2.Size = size92;
      this.chHttpLoadProxy_Append.TabIndex = 96;
      this.chHttpLoadProxy_Append.Text = "Добавлять в конец списка";
      this.chHttpLoadProxy_Append.UseVisualStyleBackColor = true;
      this.chHttpLoadProxy_LoadInStart.AutoSize = true;
      this.chHttpLoadProxy_LoadInStart.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chHttpLoadProxy_LoadInStart.ForeColor = Color.Black;
      CheckBox proxyLoadInStart1 = this.chHttpLoadProxy_LoadInStart;
      point1 = new Point(9, 151);
      Point point93 = point1;
      proxyLoadInStart1.Location = point93;
      this.chHttpLoadProxy_LoadInStart.Name = "chHttpLoadProxy_LoadInStart";
      CheckBox proxyLoadInStart2 = this.chHttpLoadProxy_LoadInStart;
      size1 = new Size(198, 17);
      Size size93 = size1;
      proxyLoadInStart2.Size = size93;
      this.chHttpLoadProxy_LoadInStart.TabIndex = 95;
      this.chHttpLoadProxy_LoadInStart.Text = "Загружать при старте программы";
      this.chHttpLoadProxy_LoadInStart.UseVisualStyleBackColor = true;
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label9_1 = this.Label9;
      point1 = new Point(6, 214);
      Point point94 = point1;
      label9_1.Location = point94;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(81, 14);
      Size size94 = size1;
      label9_2.Size = size94;
      this.Label9.TabIndex = 94;
      this.Label9.Text = "Загружено:";
      this.Button2.BackColor = Color.FromArgb(224, 224, 224);
      this.Button2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button button2_1 = this.Button2;
      point1 = new Point(249, 186);
      Point point95 = point1;
      button2_1.Location = point95;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(139, 47);
      Size size95 = size1;
      button2_2.Size = size95;
      this.Button2.TabIndex = 93;
      this.Button2.Text = "Загрузить немедленно";
      this.Button2.UseVisualStyleBackColor = false;
      this.btnOpenProxy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnOpenProxy.BackColor = Color.FromArgb(224, 224, 224);
      this.btnOpenProxy.Image = (Image) componentResourceManager.GetObject("btnOpenProxy.Image");
      this.btnOpenProxy.ImageAlign = ContentAlignment.BottomRight;
      Button btnOpenProxy1 = this.btnOpenProxy;
      point1 = new Point(362, 129);
      Point point96 = point1;
      btnOpenProxy1.Location = point96;
      this.btnOpenProxy.Name = "btnOpenProxy";
      Button btnOpenProxy2 = this.btnOpenProxy;
      size1 = new Size(26, 25);
      Size size96 = size1;
      btnOpenProxy2.Size = size96;
      this.btnOpenProxy.TabIndex = 92;
      this.btnOpenProxy.TabStop = false;
      this.btnOpenProxy.TextAlign = ContentAlignment.MiddleRight;
      this.btnOpenProxy.UseVisualStyleBackColor = false;
      this.Button1.BackColor = Color.FromArgb(224, 224, 224);
      this.Button1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      Button button1_1 = this.Button1;
      point1 = new Point(249, 129);
      Point point97 = point1;
      button1_1.Location = point97;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(107, 25);
      Size size97 = size1;
      button1_2.Size = size97;
      this.Button1.TabIndex = 66;
      this.Button1.Text = "Обновить список";
      this.Button1.UseVisualStyleBackColor = false;
      this.lblHttpLoadProxy_UrlCount.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label loadProxyUrlCount1 = this.lblHttpLoadProxy_UrlCount;
      point1 = new Point(188, 134);
      Point point98 = point1;
      loadProxyUrlCount1.Location = point98;
      this.lblHttpLoadProxy_UrlCount.Name = "lblHttpLoadProxy_UrlCount";
      Label loadProxyUrlCount2 = this.lblHttpLoadProxy_UrlCount;
      size1 = new Size(55, 14);
      Size size98 = size1;
      loadProxyUrlCount2.Size = size98;
      this.lblHttpLoadProxy_UrlCount.TabIndex = 65;
      this.lblHttpLoadProxy_UrlCount.Text = "0";
      this.lblHttpLoadProxy_UrlCount.TextAlign = ContentAlignment.MiddleCenter;
      this.cmbHttpLoadProxy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbHttpLoadProxy.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbHttpLoadProxy.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbHttpLoadProxy.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbHttpLoadProxy.FormattingEnabled = true;
      ComboBox cmbHttpLoadProxy1 = this.cmbHttpLoadProxy;
      point1 = new Point(9, 105);
      Point point99 = point1;
      cmbHttpLoadProxy1.Location = point99;
      this.cmbHttpLoadProxy.Name = "cmbHttpLoadProxy";
      ComboBox cmbHttpLoadProxy2 = this.cmbHttpLoadProxy;
      size1 = new Size(379, 21);
      Size size99 = size1;
      cmbHttpLoadProxy2.Size = size99;
      this.cmbHttpLoadProxy.TabIndex = 64;
      this.cmbHttpLoadProxy.TabStop = false;
      this.cmbHttpLoadProxy.Tag = (object) "";
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label7_1 = this.Label7;
      point1 = new Point(6, 134);
      Point point100 = point1;
      label7_1.Location = point100;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(176, 14);
      Size size100 = size1;
      label7_2.Size = size100;
      this.Label7.TabIndex = 3;
      this.Label7.Text = "Всего URL для скачивания:";
      this.txtHttpLoadProxy_RegEx.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox httpLoadProxyRegEx1 = this.txtHttpLoadProxy_RegEx;
      point1 = new Point(9, 78);
      Point point101 = point1;
      httpLoadProxyRegEx1.Location = point101;
      this.txtHttpLoadProxy_RegEx.Name = "txtHttpLoadProxy_RegEx";
      TextBox httpLoadProxyRegEx2 = this.txtHttpLoadProxy_RegEx;
      size1 = new Size(379, 21);
      Size size101 = size1;
      httpLoadProxyRegEx2.Size = size101;
      this.txtHttpLoadProxy_RegEx.TabIndex = 2;
      this.chHttpLoadProxy_UseRegEx.AutoSize = true;
      this.chHttpLoadProxy_UseRegEx.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chHttpLoadProxy_UseRegEx.ForeColor = Color.Black;
      CheckBox loadProxyUseRegEx1 = this.chHttpLoadProxy_UseRegEx;
      point1 = new Point(9, 60);
      Point point102 = point1;
      loadProxyUseRegEx1.Location = point102;
      this.chHttpLoadProxy_UseRegEx.Name = "chHttpLoadProxy_UseRegEx";
      CheckBox loadProxyUseRegEx2 = this.chHttpLoadProxy_UseRegEx;
      size1 = new Size(193, 17);
      Size size102 = size1;
      loadProxyUseRegEx2.Size = size102;
      this.chHttpLoadProxy_UseRegEx.TabIndex = 1;
      this.chHttpLoadProxy_UseRegEx.Text = "Регулярные выражения (RegEx) ";
      this.chHttpLoadProxy_UseRegEx.UseVisualStyleBackColor = true;
      this.lblInfoProxyLoad.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lblInfoProxyLoad.ForeColor = Color.Black;
      Label lblInfoProxyLoad1 = this.lblInfoProxyLoad;
      point1 = new Point(6, 19);
      Point point103 = point1;
      lblInfoProxyLoad1.Location = point103;
      this.lblInfoProxyLoad.Name = "lblInfoProxyLoad";
      Label lblInfoProxyLoad2 = this.lblInfoProxyLoad;
      size1 = new Size(382, 32);
      Size size103 = size1;
      lblInfoProxyLoad2.Size = size103;
      this.lblInfoProxyLoad.TabIndex = 0;
      this.lblInfoProxyLoad.Text = "Внимание! Если страница с прокси-листом отличается от стандартной выдачи IP:Port используйте 'Регулярные выражения'";
      this.lblInfoProxyLoad.TextAlign = ContentAlignment.MiddleLeft;
      this.chHttpLoadProxy.AutoSize = true;
      this.chHttpLoadProxy.BackColor = Color.WhiteSmoke;
      this.chHttpLoadProxy.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.chHttpLoadProxy.ForeColor = Color.Magenta;
      CheckBox chHttpLoadProxy1 = this.chHttpLoadProxy;
      point1 = new Point(510, 8);
      Point point104 = point1;
      chHttpLoadProxy1.Location = point104;
      this.chHttpLoadProxy.Name = "chHttpLoadProxy";
      CheckBox chHttpLoadProxy2 = this.chHttpLoadProxy;
      size1 = new Size(216, 18);
      Size size104 = size1;
      chHttpLoadProxy2.Size = size104;
      this.chHttpLoadProxy.TabIndex = 98;
      this.chHttpLoadProxy.Text = "Загрузка (http) списков Proxy";
      this.chHttpLoadProxy.UseVisualStyleBackColor = false;
      this.boxNetworkReboot.Controls.Add((Control) this.Label13);
      this.boxNetworkReboot.Controls.Add((Control) this.chNetworkReboot_MacChange);
      this.boxNetworkReboot.Controls.Add((Control) this.GroupBox6);
      this.boxNetworkReboot.Controls.Add((Control) this.lblNetworkReboot_MAC);
      this.boxNetworkReboot.Controls.Add((Control) this.cmbNetworkReboot_Method);
      this.boxNetworkReboot.Controls.Add((Control) this.lblNetworkReboot_NetConnectionID);
      this.boxNetworkReboot.Controls.Add((Control) this.Label12);
      this.boxNetworkReboot.Controls.Add((Control) this.cmbNetworkReboot_Filtr);
      this.boxNetworkReboot.Controls.Add((Control) this.Button4);
      this.boxNetworkReboot.Controls.Add((Control) this.Label11);
      this.boxNetworkReboot.Controls.Add((Control) this.cmbNetworkReboot_Adapter);
      this.boxNetworkReboot.Controls.Add((Control) this.Label10);
      this.boxNetworkReboot.Controls.Add((Control) this.Label8);
      this.boxNetworkReboot.Enabled = false;
      this.boxNetworkReboot.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.boxNetworkReboot.ForeColor = Color.Black;
      GroupBox boxNetworkReboot1 = this.boxNetworkReboot;
      point1 = new Point(500, 260);
      Point point105 = point1;
      boxNetworkReboot1.Location = point105;
      this.boxNetworkReboot.Name = "boxNetworkReboot";
      GroupBox boxNetworkReboot2 = this.boxNetworkReboot;
      size1 = new Size(394, 151);
      Size size105 = size1;
      boxNetworkReboot2.Size = size105;
      this.boxNetworkReboot.TabIndex = 99;
      this.boxNetworkReboot.TabStop = false;
      this.Label13.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label13.ForeColor = Color.Black;
      Label label13_1 = this.Label13;
      point1 = new Point(253, 120);
      Point point106 = point1;
      label13_1.Location = point106;
      this.Label13.Name = "Label13";
      Label label13_2 = this.Label13;
      size1 = new Size(46, 28);
      Size size106 = size1;
      label13_2.Size = size106;
      this.Label13.TabIndex = 97;
      this.Label13.Text = "Method Reboot";
      this.Label13.TextAlign = ContentAlignment.MiddleRight;
      this.chNetworkReboot_MacChange.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chNetworkReboot_MacChange.ForeColor = Color.Black;
      CheckBox networkRebootMacChange1 = this.chNetworkReboot_MacChange;
      point1 = new Point(164, 126);
      Point point107 = point1;
      networkRebootMacChange1.Location = point107;
      this.chNetworkReboot_MacChange.Name = "chNetworkReboot_MacChange";
      CheckBox networkRebootMacChange2 = this.chNetworkReboot_MacChange;
      size1 = new Size(95, 17);
      Size size107 = size1;
      networkRebootMacChange2.Size = size107;
      this.chNetworkReboot_MacChange.TabIndex = 102;
      this.chNetworkReboot_MacChange.Text = "менять MAC";
      this.chNetworkReboot_MacChange.UseVisualStyleBackColor = true;
      this.GroupBox6.Enabled = false;
      this.GroupBox6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.GroupBox6.ForeColor = Color.Black;
      GroupBox groupBox6_1 = this.GroupBox6;
      point1 = new Point(0, 157);
      Point point108 = point1;
      groupBox6_1.Location = point108;
      this.GroupBox6.Name = "GroupBox6";
      GroupBox groupBox6_2 = this.GroupBox6;
      size1 = new Size(394, 41);
      Size size108 = size1;
      groupBox6_2.Size = size108;
      this.GroupBox6.TabIndex = 101;
      this.GroupBox6.TabStop = false;
      this.lblNetworkReboot_MAC.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lblNetworkReboot_MAC.ForeColor = Color.Green;
      Label networkRebootMac1 = this.lblNetworkReboot_MAC;
      point1 = new Point(3, 124);
      Point point109 = point1;
      networkRebootMac1.Location = point109;
      this.lblNetworkReboot_MAC.Name = "lblNetworkReboot_MAC";
      Label networkRebootMac2 = this.lblNetworkReboot_MAC;
      size1 = new Size(159, 21);
      Size size109 = size1;
      networkRebootMac2.Size = size109;
      this.lblNetworkReboot_MAC.TabIndex = 99;
      this.lblNetworkReboot_MAC.Text = "Not Present";
      this.lblNetworkReboot_MAC.TextAlign = ContentAlignment.MiddleCenter;
      this.cmbNetworkReboot_Method.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbNetworkReboot_Method.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbNetworkReboot_Method.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbNetworkReboot_Method.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbNetworkReboot_Method.FormattingEnabled = true;
      this.cmbNetworkReboot_Method.Items.AddRange(new object[2]
      {
        (object) "WMI",
        (object) "HARD"
      });
      ComboBox networkRebootMethod1 = this.cmbNetworkReboot_Method;
      point1 = new Point(300, 122);
      Point point110 = point1;
      networkRebootMethod1.Location = point110;
      this.cmbNetworkReboot_Method.Name = "cmbNetworkReboot_Method";
      ComboBox networkRebootMethod2 = this.cmbNetworkReboot_Method;
      size1 = new Size(87, 21);
      Size size110 = size1;
      networkRebootMethod2.Size = size110;
      this.cmbNetworkReboot_Method.TabIndex = 98;
      this.cmbNetworkReboot_Method.TabStop = false;
      this.cmbNetworkReboot_Method.Tag = (object) "";
      this.lblNetworkReboot_NetConnectionID.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lblNetworkReboot_NetConnectionID.ForeColor = Color.FromArgb(0, 0, 192);
      Label rebootNetConnectionId1 = this.lblNetworkReboot_NetConnectionID;
      point1 = new Point(129, 102);
      Point point111 = point1;
      rebootNetConnectionId1.Location = point111;
      this.lblNetworkReboot_NetConnectionID.Name = "lblNetworkReboot_NetConnectionID";
      Label rebootNetConnectionId2 = this.lblNetworkReboot_NetConnectionID;
      size1 = new Size(258, 21);
      Size size111 = size1;
      rebootNetConnectionId2.Size = size111;
      this.lblNetworkReboot_NetConnectionID.TabIndex = 95;
      this.lblNetworkReboot_NetConnectionID.Text = "n/a";
      this.lblNetworkReboot_NetConnectionID.TextAlign = ContentAlignment.MiddleLeft;
      this.Label12.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label12.ForeColor = Color.Black;
      Label label12_1 = this.Label12;
      point1 = new Point(6, 102);
      Point point112 = point1;
      label12_1.Location = point112;
      this.Label12.Name = "Label12";
      Label label12_2 = this.Label12;
      size1 = new Size((int) sbyte.MaxValue, 21);
      Size size112 = size1;
      label12_2.Size = size112;
      this.Label12.TabIndex = 96;
      this.Label12.Text = "Сетевое подключение: ";
      this.Label12.TextAlign = ContentAlignment.MiddleLeft;
      this.cmbNetworkReboot_Filtr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbNetworkReboot_Filtr.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbNetworkReboot_Filtr.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbNetworkReboot_Filtr.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 204);
      this.cmbNetworkReboot_Filtr.FormattingEnabled = true;
      this.cmbNetworkReboot_Filtr.Items.AddRange(new object[5]
      {
        (object) "NetConnectionID>0",
        (object) "PNPDeviceID LIKE 'PCI%'",
        (object) "MACAddress>0",
        (object) "GUID>0",
        (object) "нет"
      });
      ComboBox networkRebootFiltr1 = this.cmbNetworkReboot_Filtr;
      point1 = new Point(164, 77);
      Point point113 = point1;
      networkRebootFiltr1.Location = point113;
      this.cmbNetworkReboot_Filtr.Name = "cmbNetworkReboot_Filtr";
      ComboBox networkRebootFiltr2 = this.cmbNetworkReboot_Filtr;
      size1 = new Size(135, 21);
      Size size113 = size1;
      networkRebootFiltr2.Size = size113;
      this.cmbNetworkReboot_Filtr.TabIndex = 66;
      this.cmbNetworkReboot_Filtr.TabStop = false;
      this.cmbNetworkReboot_Filtr.Tag = (object) "";
      this.Button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Button4.BackColor = Color.FromArgb(224, 224, 224);
      this.Button4.Image = (Image) componentResourceManager.GetObject("Button4.Image");
      this.Button4.ImageAlign = ContentAlignment.MiddleLeft;
      Button button4_1 = this.Button4;
      point1 = new Point(300, 75);
      Point point114 = point1;
      button4_1.Location = point114;
      this.Button4.Name = "Button4";
      Button button4_2 = this.Button4;
      size1 = new Size(88, 25);
      Size size114 = size1;
      button4_2.Size = size114;
      this.Button4.TabIndex = 93;
      this.Button4.TabStop = false;
      this.Button4.Text = "Test Reboot";
      this.Button4.TextAlign = ContentAlignment.MiddleRight;
      this.Button4.UseVisualStyleBackColor = false;
      this.Label11.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label11.ForeColor = Color.Black;
      Label label11_1 = this.Label11;
      point1 = new Point(6, 77);
      Point point115 = point1;
      label11_1.Location = point115;
      this.Label11.Name = "Label11";
      Label label11_2 = this.Label11;
      size1 = new Size(164, 21);
      Size size115 = size1;
      label11_2.Size = size115;
      this.Label11.TabIndex = 94;
      this.Label11.Text = "Фильтр WMI Network Adapter:";
      this.Label11.TextAlign = ContentAlignment.MiddleLeft;
      this.cmbNetworkReboot_Adapter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbNetworkReboot_Adapter.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbNetworkReboot_Adapter.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbNetworkReboot_Adapter.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbNetworkReboot_Adapter.FormattingEnabled = true;
      ComboBox networkRebootAdapter1 = this.cmbNetworkReboot_Adapter;
      point1 = new Point(9, 50);
      Point point116 = point1;
      networkRebootAdapter1.Location = point116;
      this.cmbNetworkReboot_Adapter.Name = "cmbNetworkReboot_Adapter";
      ComboBox networkRebootAdapter2 = this.cmbNetworkReboot_Adapter;
      size1 = new Size(379, 21);
      Size size116 = size1;
      networkRebootAdapter2.Size = size116;
      this.cmbNetworkReboot_Adapter.TabIndex = 65;
      this.cmbNetworkReboot_Adapter.TabStop = false;
      this.cmbNetworkReboot_Adapter.Tag = (object) "";
      this.Label10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label10.ForeColor = Color.Black;
      Label label10_1 = this.Label10;
      point1 = new Point(6, 27);
      Point point117 = point1;
      label10_1.Location = point117;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(382, 19);
      Size size117 = size1;
      label10_2.Size = size117;
      this.Label10.TabIndex = 2;
      this.Label10.Text = "Настоятельно рекомендуется, при регистрации использовать 1 поток.";
      this.Label10.TextAlign = ContentAlignment.MiddleLeft;
      this.Label8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label8.ForeColor = Color.Black;
      Label label8_1 = this.Label8;
      point1 = new Point(6, 10);
      Point point118 = point1;
      label8_1.Location = point118;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(382, 19);
      Size size118 = size1;
      label8_2.Size = size118;
      this.Label8.TabIndex = 1;
      this.Label8.Text = "Опция для регистрации почтовых ящиков используя динамический IP.";
      this.Label8.TextAlign = ContentAlignment.MiddleLeft;
      this.chNetWorkReboot.AutoSize = true;
      this.chNetWorkReboot.BackColor = Color.WhiteSmoke;
      this.chNetWorkReboot.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.chNetWorkReboot.ForeColor = Color.Magenta;
      CheckBox chNetWorkReboot1 = this.chNetWorkReboot;
      point1 = new Point(510, 256);
      Point point119 = point1;
      chNetWorkReboot1.Location = point119;
      this.chNetWorkReboot.Name = "chNetWorkReboot";
      CheckBox chNetWorkReboot2 = this.chNetWorkReboot;
      size1 = new Size(180, 18);
      Size size119 = size1;
      chNetWorkReboot2.Size = size119;
      this.chNetWorkReboot.TabIndex = 100;
      this.chNetWorkReboot.Text = "NetWork Reboot (at reg)";
      this.chNetWorkReboot.UseVisualStyleBackColor = false;
      this.boxPlaySound.Controls.Add((Control) this.GroupBox20);
      this.boxPlaySound.Controls.Add((Control) this.GroupBox19);
      this.boxPlaySound.Controls.Add((Control) this.GroupBox18);
      this.boxPlaySound.Controls.Add((Control) this.GroupBox17);
      this.boxPlaySound.Controls.Add((Control) this.GroupBox16);
      this.boxPlaySound.Controls.Add((Control) this.GroupBox15);
      this.boxPlaySound.Controls.Add((Control) this.Label23);
      this.boxPlaySound.Enabled = false;
      this.boxPlaySound.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.boxPlaySound.ForeColor = Color.Black;
      GroupBox boxPlaySound1 = this.boxPlaySound;
      point1 = new Point(500, 421);
      Point point120 = point1;
      boxPlaySound1.Location = point120;
      this.boxPlaySound.Name = "boxPlaySound";
      GroupBox boxPlaySound2 = this.boxPlaySound;
      size1 = new Size(394, 142);
      Size size120 = size1;
      boxPlaySound2.Size = size120;
      this.boxPlaySound.TabIndex = 101;
      this.boxPlaySound.TabStop = false;
      this.GroupBox20.Controls.Add((Control) this.chPlaySound_6);
      this.GroupBox20.Controls.Add((Control) this.btnPlaySound_6);
      this.GroupBox20.Controls.Add((Control) this.txtPlaySound_6);
      this.GroupBox20.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox20_1 = this.GroupBox20;
      point1 = new Point(198, 103);
      Point point121 = point1;
      groupBox20_1.Location = point121;
      this.GroupBox20.Name = "GroupBox20";
      GroupBox groupBox20_2 = this.GroupBox20;
      size1 = new Size(192, 33);
      Size size121 = size1;
      groupBox20_2.Size = size121;
      this.GroupBox20.TabIndex = 121;
      this.GroupBox20.TabStop = false;
      this.GroupBox20.Text = "Регистрация остановлена";
      this.chPlaySound_6.AutoSize = true;
      this.chPlaySound_6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chPlaySound_6.ForeColor = Color.Black;
      CheckBox chPlaySound6_1 = this.chPlaySound_6;
      point1 = new Point(4, 15);
      Point point122 = point1;
      chPlaySound6_1.Location = point122;
      this.chPlaySound_6.Name = "chPlaySound_6";
      CheckBox chPlaySound6_2 = this.chPlaySound_6;
      size1 = new Size(15, 14);
      Size size122 = size1;
      chPlaySound6_2.Size = size122;
      this.chPlaySound_6.TabIndex = 98;
      this.chPlaySound_6.Tag = (object) "6";
      this.chPlaySound_6.UseVisualStyleBackColor = true;
      this.btnPlaySound_6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnPlaySound_6.BackColor = Color.FromArgb(224, 224, 224);
      this.btnPlaySound_6.Image = (Image) componentResourceManager.GetObject("btnPlaySound_6.Image");
      Button btnPlaySound6_1 = this.btnPlaySound_6;
      point1 = new Point(170, 9);
      Point point123 = point1;
      btnPlaySound6_1.Location = point123;
      this.btnPlaySound_6.Name = "btnPlaySound_6";
      Button btnPlaySound6_2 = this.btnPlaySound_6;
      size1 = new Size(20, 21);
      Size size123 = size1;
      btnPlaySound6_2.Size = size123;
      this.btnPlaySound_6.TabIndex = 93;
      this.btnPlaySound_6.TabStop = false;
      this.btnPlaySound_6.Tag = (object) "6";
      this.btnPlaySound_6.TextAlign = ContentAlignment.MiddleRight;
      this.btnPlaySound_6.UseVisualStyleBackColor = false;
      this.txtPlaySound_6.BackColor = Color.WhiteSmoke;
      this.txtPlaySound_6.BorderStyle = BorderStyle.None;
      this.txtPlaySound_6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtPlaySound6_1 = this.txtPlaySound_6;
      point1 = new Point(24, 15);
      Point point124 = point1;
      txtPlaySound6_1.Location = point124;
      this.txtPlaySound_6.MaxLength = 9;
      this.txtPlaySound_6.Name = "txtPlaySound_6";
      TextBox txtPlaySound6_2 = this.txtPlaySound_6;
      size1 = new Size(140, 14);
      Size size124 = size1;
      txtPlaySound6_2.Size = size124;
      this.txtPlaySound_6.TabIndex = 0;
      this.txtPlaySound_6.TabStop = false;
      this.txtPlaySound_6.Text = "\\Sound\\stop_reg.wav";
      this.GroupBox19.Controls.Add((Control) this.chPlaySound_3);
      this.GroupBox19.Controls.Add((Control) this.btnPlaySound_3);
      this.GroupBox19.Controls.Add((Control) this.txtPlaySound_3);
      this.GroupBox19.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox19_1 = this.GroupBox19;
      point1 = new Point(6, 103);
      Point point125 = point1;
      groupBox19_1.Location = point125;
      this.GroupBox19.Name = "GroupBox19";
      GroupBox groupBox19_2 = this.GroupBox19;
      size1 = new Size(192, 33);
      Size size125 = size1;
      groupBox19_2.Size = size125;
      this.GroupBox19.TabIndex = 120;
      this.GroupBox19.TabStop = false;
      this.GroupBox19.Text = "CAPTCHA Lost";
      this.chPlaySound_3.AutoSize = true;
      this.chPlaySound_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chPlaySound_3.ForeColor = Color.Black;
      CheckBox chPlaySound3_1 = this.chPlaySound_3;
      point1 = new Point(4, 15);
      Point point126 = point1;
      chPlaySound3_1.Location = point126;
      this.chPlaySound_3.Name = "chPlaySound_3";
      CheckBox chPlaySound3_2 = this.chPlaySound_3;
      size1 = new Size(15, 14);
      Size size126 = size1;
      chPlaySound3_2.Size = size126;
      this.chPlaySound_3.TabIndex = 98;
      this.chPlaySound_3.Tag = (object) "3";
      this.chPlaySound_3.UseVisualStyleBackColor = true;
      this.btnPlaySound_3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnPlaySound_3.BackColor = Color.FromArgb(224, 224, 224);
      this.btnPlaySound_3.Image = (Image) componentResourceManager.GetObject("btnPlaySound_3.Image");
      Button btnPlaySound3_1 = this.btnPlaySound_3;
      point1 = new Point(170, 9);
      Point point127 = point1;
      btnPlaySound3_1.Location = point127;
      this.btnPlaySound_3.Name = "btnPlaySound_3";
      Button btnPlaySound3_2 = this.btnPlaySound_3;
      size1 = new Size(20, 21);
      Size size127 = size1;
      btnPlaySound3_2.Size = size127;
      this.btnPlaySound_3.TabIndex = 93;
      this.btnPlaySound_3.TabStop = false;
      this.btnPlaySound_3.Tag = (object) "3";
      this.btnPlaySound_3.TextAlign = ContentAlignment.MiddleRight;
      this.btnPlaySound_3.UseVisualStyleBackColor = false;
      this.txtPlaySound_3.BackColor = Color.WhiteSmoke;
      this.txtPlaySound_3.BorderStyle = BorderStyle.None;
      this.txtPlaySound_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtPlaySound3_1 = this.txtPlaySound_3;
      point1 = new Point(24, 15);
      Point point128 = point1;
      txtPlaySound3_1.Location = point128;
      this.txtPlaySound_3.MaxLength = 9;
      this.txtPlaySound_3.Name = "txtPlaySound_3";
      TextBox txtPlaySound3_2 = this.txtPlaySound_3;
      size1 = new Size(140, 14);
      Size size128 = size1;
      txtPlaySound3_2.Size = size128;
      this.txtPlaySound_3.TabIndex = 0;
      this.txtPlaySound_3.TabStop = false;
      this.txtPlaySound_3.Text = "\\Sound\\error.wav";
      this.GroupBox18.Controls.Add((Control) this.chPlaySound_5);
      this.GroupBox18.Controls.Add((Control) this.btnPlaySound_5);
      this.GroupBox18.Controls.Add((Control) this.txtPlaySound_5);
      this.GroupBox18.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox18_1 = this.GroupBox18;
      point1 = new Point(198, 67);
      Point point129 = point1;
      groupBox18_1.Location = point129;
      this.GroupBox18.Name = "GroupBox18";
      GroupBox groupBox18_2 = this.GroupBox18;
      size1 = new Size(192, 33);
      Size size129 = size1;
      groupBox18_2.Size = size129;
      this.GroupBox18.TabIndex = 119;
      this.GroupBox18.TabStop = false;
      this.GroupBox18.Text = "Регистрация BAD";
      this.chPlaySound_5.AutoSize = true;
      this.chPlaySound_5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chPlaySound_5.ForeColor = Color.Black;
      CheckBox chPlaySound5_1 = this.chPlaySound_5;
      point1 = new Point(4, 15);
      Point point130 = point1;
      chPlaySound5_1.Location = point130;
      this.chPlaySound_5.Name = "chPlaySound_5";
      CheckBox chPlaySound5_2 = this.chPlaySound_5;
      size1 = new Size(15, 14);
      Size size130 = size1;
      chPlaySound5_2.Size = size130;
      this.chPlaySound_5.TabIndex = 98;
      this.chPlaySound_5.Tag = (object) "5";
      this.chPlaySound_5.UseVisualStyleBackColor = true;
      this.btnPlaySound_5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnPlaySound_5.BackColor = Color.FromArgb(224, 224, 224);
      this.btnPlaySound_5.Image = (Image) componentResourceManager.GetObject("btnPlaySound_5.Image");
      Button btnPlaySound5_1 = this.btnPlaySound_5;
      point1 = new Point(170, 9);
      Point point131 = point1;
      btnPlaySound5_1.Location = point131;
      this.btnPlaySound_5.Name = "btnPlaySound_5";
      Button btnPlaySound5_2 = this.btnPlaySound_5;
      size1 = new Size(20, 21);
      Size size131 = size1;
      btnPlaySound5_2.Size = size131;
      this.btnPlaySound_5.TabIndex = 93;
      this.btnPlaySound_5.TabStop = false;
      this.btnPlaySound_5.Tag = (object) "5";
      this.btnPlaySound_5.TextAlign = ContentAlignment.MiddleRight;
      this.btnPlaySound_5.UseVisualStyleBackColor = false;
      this.txtPlaySound_5.BackColor = Color.WhiteSmoke;
      this.txtPlaySound_5.BorderStyle = BorderStyle.None;
      this.txtPlaySound_5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtPlaySound5_1 = this.txtPlaySound_5;
      point1 = new Point(24, 15);
      Point point132 = point1;
      txtPlaySound5_1.Location = point132;
      this.txtPlaySound_5.MaxLength = 9;
      this.txtPlaySound_5.Name = "txtPlaySound_5";
      TextBox txtPlaySound5_2 = this.txtPlaySound_5;
      size1 = new Size(140, 14);
      Size size132 = size1;
      txtPlaySound5_2.Size = size132;
      this.txtPlaySound_5.TabIndex = 0;
      this.txtPlaySound_5.TabStop = false;
      this.txtPlaySound_5.Text = "\\Sound\\reg_bad.wav";
      this.GroupBox17.Controls.Add((Control) this.chPlaySound_4);
      this.GroupBox17.Controls.Add((Control) this.btnPlaySound_4);
      this.GroupBox17.Controls.Add((Control) this.txtPlaySound_4);
      this.GroupBox17.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox17_1 = this.GroupBox17;
      point1 = new Point(198, 28);
      Point point133 = point1;
      groupBox17_1.Location = point133;
      this.GroupBox17.Name = "GroupBox17";
      GroupBox groupBox17_2 = this.GroupBox17;
      size1 = new Size(192, 33);
      Size size133 = size1;
      groupBox17_2.Size = size133;
      this.GroupBox17.TabIndex = 118;
      this.GroupBox17.TabStop = false;
      this.GroupBox17.Text = "Регистрация OK";
      this.chPlaySound_4.AutoSize = true;
      this.chPlaySound_4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chPlaySound_4.ForeColor = Color.Black;
      CheckBox chPlaySound4_1 = this.chPlaySound_4;
      point1 = new Point(4, 15);
      Point point134 = point1;
      chPlaySound4_1.Location = point134;
      this.chPlaySound_4.Name = "chPlaySound_4";
      CheckBox chPlaySound4_2 = this.chPlaySound_4;
      size1 = new Size(15, 14);
      Size size134 = size1;
      chPlaySound4_2.Size = size134;
      this.chPlaySound_4.TabIndex = 98;
      this.chPlaySound_4.Tag = (object) "4";
      this.chPlaySound_4.UseVisualStyleBackColor = true;
      this.btnPlaySound_4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnPlaySound_4.BackColor = Color.FromArgb(224, 224, 224);
      this.btnPlaySound_4.Image = (Image) componentResourceManager.GetObject("btnPlaySound_4.Image");
      Button btnPlaySound4_1 = this.btnPlaySound_4;
      point1 = new Point(170, 9);
      Point point135 = point1;
      btnPlaySound4_1.Location = point135;
      this.btnPlaySound_4.Name = "btnPlaySound_4";
      Button btnPlaySound4_2 = this.btnPlaySound_4;
      size1 = new Size(20, 21);
      Size size135 = size1;
      btnPlaySound4_2.Size = size135;
      this.btnPlaySound_4.TabIndex = 93;
      this.btnPlaySound_4.TabStop = false;
      this.btnPlaySound_4.Tag = (object) "4";
      this.btnPlaySound_4.TextAlign = ContentAlignment.MiddleRight;
      this.btnPlaySound_4.UseVisualStyleBackColor = false;
      this.txtPlaySound_4.BackColor = Color.WhiteSmoke;
      this.txtPlaySound_4.BorderStyle = BorderStyle.None;
      this.txtPlaySound_4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtPlaySound4_1 = this.txtPlaySound_4;
      point1 = new Point(24, 15);
      Point point136 = point1;
      txtPlaySound4_1.Location = point136;
      this.txtPlaySound_4.MaxLength = 9;
      this.txtPlaySound_4.Name = "txtPlaySound_4";
      TextBox txtPlaySound4_2 = this.txtPlaySound_4;
      size1 = new Size(140, 14);
      Size size136 = size1;
      txtPlaySound4_2.Size = size136;
      this.txtPlaySound_4.TabIndex = 0;
      this.txtPlaySound_4.TabStop = false;
      this.txtPlaySound_4.Text = "\\Sound\\reg_ok.wav";
      this.GroupBox16.Controls.Add((Control) this.chPlaySound_2);
      this.GroupBox16.Controls.Add((Control) this.btnPlaySound_2);
      this.GroupBox16.Controls.Add((Control) this.txtPlaySound_2);
      this.GroupBox16.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox16_1 = this.GroupBox16;
      point1 = new Point(6, 67);
      Point point137 = point1;
      groupBox16_1.Location = point137;
      this.GroupBox16.Name = "GroupBox16";
      GroupBox groupBox16_2 = this.GroupBox16;
      size1 = new Size(192, 33);
      Size size137 = size1;
      groupBox16_2.Size = size137;
      this.GroupBox16.TabIndex = 117;
      this.GroupBox16.TabStop = false;
      this.GroupBox16.Text = "Отправлена CAPTCHA";
      this.chPlaySound_2.AutoSize = true;
      this.chPlaySound_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chPlaySound_2.ForeColor = Color.Black;
      CheckBox chPlaySound2_1 = this.chPlaySound_2;
      point1 = new Point(4, 15);
      Point point138 = point1;
      chPlaySound2_1.Location = point138;
      this.chPlaySound_2.Name = "chPlaySound_2";
      CheckBox chPlaySound2_2 = this.chPlaySound_2;
      size1 = new Size(15, 14);
      Size size138 = size1;
      chPlaySound2_2.Size = size138;
      this.chPlaySound_2.TabIndex = 98;
      this.chPlaySound_2.Tag = (object) "2";
      this.chPlaySound_2.UseVisualStyleBackColor = true;
      this.btnPlaySound_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnPlaySound_2.BackColor = Color.FromArgb(224, 224, 224);
      this.btnPlaySound_2.Image = (Image) componentResourceManager.GetObject("btnPlaySound_2.Image");
      Button btnPlaySound2_1 = this.btnPlaySound_2;
      point1 = new Point(170, 9);
      Point point139 = point1;
      btnPlaySound2_1.Location = point139;
      this.btnPlaySound_2.Name = "btnPlaySound_2";
      Button btnPlaySound2_2 = this.btnPlaySound_2;
      size1 = new Size(20, 21);
      Size size139 = size1;
      btnPlaySound2_2.Size = size139;
      this.btnPlaySound_2.TabIndex = 93;
      this.btnPlaySound_2.TabStop = false;
      this.btnPlaySound_2.Tag = (object) "2";
      this.btnPlaySound_2.TextAlign = ContentAlignment.MiddleRight;
      this.btnPlaySound_2.UseVisualStyleBackColor = false;
      this.txtPlaySound_2.BackColor = Color.WhiteSmoke;
      this.txtPlaySound_2.BorderStyle = BorderStyle.None;
      this.txtPlaySound_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtPlaySound2_1 = this.txtPlaySound_2;
      point1 = new Point(24, 15);
      Point point140 = point1;
      txtPlaySound2_1.Location = point140;
      this.txtPlaySound_2.MaxLength = 9;
      this.txtPlaySound_2.Name = "txtPlaySound_2";
      TextBox txtPlaySound2_2 = this.txtPlaySound_2;
      size1 = new Size(140, 14);
      Size size140 = size1;
      txtPlaySound2_2.Size = size140;
      this.txtPlaySound_2.TabIndex = 0;
      this.txtPlaySound_2.TabStop = false;
      this.txtPlaySound_2.Text = "\\Sound\\type.wav";
      this.GroupBox15.Controls.Add((Control) this.chPlaySound_1);
      this.GroupBox15.Controls.Add((Control) this.btnPlaySound_1);
      this.GroupBox15.Controls.Add((Control) this.txtPlaySound_1);
      this.GroupBox15.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox15_1 = this.GroupBox15;
      point1 = new Point(6, 28);
      Point point141 = point1;
      groupBox15_1.Location = point141;
      this.GroupBox15.Name = "GroupBox15";
      GroupBox groupBox15_2 = this.GroupBox15;
      size1 = new Size(192, 33);
      Size size141 = size1;
      groupBox15_2.Size = size141;
      this.GroupBox15.TabIndex = 116;
      this.GroupBox15.TabStop = false;
      this.GroupBox15.Text = "Получена CAPTCHA";
      this.chPlaySound_1.AutoSize = true;
      this.chPlaySound_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chPlaySound_1.ForeColor = Color.Black;
      CheckBox chPlaySound1_1 = this.chPlaySound_1;
      point1 = new Point(4, 15);
      Point point142 = point1;
      chPlaySound1_1.Location = point142;
      this.chPlaySound_1.Name = "chPlaySound_1";
      CheckBox chPlaySound1_2 = this.chPlaySound_1;
      size1 = new Size(15, 14);
      Size size142 = size1;
      chPlaySound1_2.Size = size142;
      this.chPlaySound_1.TabIndex = 97;
      this.chPlaySound_1.Tag = (object) "1";
      this.chPlaySound_1.UseVisualStyleBackColor = true;
      this.btnPlaySound_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnPlaySound_1.BackColor = Color.FromArgb(224, 224, 224);
      this.btnPlaySound_1.Image = (Image) componentResourceManager.GetObject("btnPlaySound_1.Image");
      Button btnPlaySound1_1 = this.btnPlaySound_1;
      point1 = new Point(170, 9);
      Point point143 = point1;
      btnPlaySound1_1.Location = point143;
      this.btnPlaySound_1.Name = "btnPlaySound_1";
      Button btnPlaySound1_2 = this.btnPlaySound_1;
      size1 = new Size(20, 21);
      Size size143 = size1;
      btnPlaySound1_2.Size = size143;
      this.btnPlaySound_1.TabIndex = 93;
      this.btnPlaySound_1.TabStop = false;
      this.btnPlaySound_1.Tag = (object) "1";
      this.btnPlaySound_1.TextAlign = ContentAlignment.MiddleRight;
      this.btnPlaySound_1.UseVisualStyleBackColor = false;
      this.txtPlaySound_1.BackColor = Color.WhiteSmoke;
      this.txtPlaySound_1.BorderStyle = BorderStyle.None;
      this.txtPlaySound_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.txtPlaySound_1.ForeColor = Color.Black;
      TextBox txtPlaySound1_1 = this.txtPlaySound_1;
      point1 = new Point(24, 15);
      Point point144 = point1;
      txtPlaySound1_1.Location = point144;
      this.txtPlaySound_1.MaxLength = 9;
      this.txtPlaySound_1.Name = "txtPlaySound_1";
      TextBox txtPlaySound1_2 = this.txtPlaySound_1;
      size1 = new Size(140, 14);
      Size size144 = size1;
      txtPlaySound1_2.Size = size144;
      this.txtPlaySound_1.TabIndex = 0;
      this.txtPlaySound_1.TabStop = false;
      this.txtPlaySound_1.Text = "\\Sound\\captcha.wav";
      this.Label23.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label23.ForeColor = Color.Gray;
      Label label23_1 = this.Label23;
      point1 = new Point(7, 13);
      Point point145 = point1;
      label23_1.Location = point145;
      this.Label23.Name = "Label23";
      Label label23_2 = this.Label23;
      size1 = new Size(382, 21);
      Size size145 = size1;
      label23_2.Size = size145;
      this.Label23.TabIndex = 1;
      this.Label23.Text = "Задействовать, только, в случае крайней необходимости.\r\n";
      this.Label23.TextAlign = ContentAlignment.MiddleCenter;
      this.chPlaySound.AutoSize = true;
      this.chPlaySound.BackColor = Color.WhiteSmoke;
      this.chPlaySound.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.chPlaySound.ForeColor = Color.Magenta;
      CheckBox chPlaySound1 = this.chPlaySound;
      point1 = new Point(510, 417);
      Point point146 = point1;
      chPlaySound1.Location = point146;
      this.chPlaySound.Name = "chPlaySound";
      CheckBox chPlaySound2 = this.chPlaySound;
      size1 = new Size(55, 18);
      Size size146 = size1;
      chPlaySound2.Size = size146;
      this.chPlaySound.TabIndex = 102;
      this.chPlaySound.Text = "Звук";
      this.chPlaySound.UseVisualStyleBackColor = false;
      this.GroupBox14.Controls.Add((Control) this.cmbSort_8);
      this.GroupBox14.Controls.Add((Control) this.picSort_BAD);
      this.GroupBox14.Controls.Add((Control) this.picSort_OK);
      this.GroupBox14.Controls.Add((Control) this.btnOpSort_Default);
      this.GroupBox14.Controls.Add((Control) this.cmbSort_7);
      this.GroupBox14.Controls.Add((Control) this.cmbSort_6);
      this.GroupBox14.Controls.Add((Control) this.cmbSort_5);
      this.GroupBox14.Controls.Add((Control) this.cmbSort_4);
      this.GroupBox14.Controls.Add((Control) this.cmbSort_3);
      this.GroupBox14.Controls.Add((Control) this.cmbSort_2);
      this.GroupBox14.Controls.Add((Control) this.cmbSort_1);
      this.GroupBox14.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.GroupBox14.ForeColor = Color.Magenta;
      GroupBox groupBox14_1 = this.GroupBox14;
      point1 = new Point(900, 10);
      Point point147 = point1;
      groupBox14_1.Location = point147;
      this.GroupBox14.Name = "GroupBox14";
      GroupBox groupBox14_2 = this.GroupBox14;
      size1 = new Size(166, 257);
      Size size147 = size1;
      groupBox14_2.Size = size147;
      this.GroupBox14.TabIndex = 103;
      this.GroupBox14.TabStop = false;
      this.GroupBox14.Text = "Опции сортировки";
      this.cmbSort_8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbSort_8.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbSort_8.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSort_8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbSort_8.FormattingEnabled = true;
      this.cmbSort_8.Items.AddRange(new object[9]
      {
        (object) "0 не задано",
        (object) "1 Not Registered",
        (object) "2 Login checked",
        (object) "3 Registered",
        (object) "4 Reg & Download Mail",
        (object) "5 Error downloading email",
        (object) "6 Login NotFree",
        (object) "7 Bad Login",
        (object) "8 Is Closed/unused"
      });
      ComboBox cmbSort8_1 = this.cmbSort_8;
      point1 = new Point(6, 183);
      Point point148 = point1;
      cmbSort8_1.Location = point148;
      this.cmbSort_8.Name = "cmbSort_8";
      ComboBox cmbSort8_2 = this.cmbSort_8;
      size1 = new Size(156, 21);
      Size size148 = size1;
      cmbSort8_2.Size = size148;
      this.cmbSort_8.TabIndex = 125;
      this.cmbSort_8.TabStop = false;
      this.cmbSort_8.Tag = (object) "7";
      this.picSort_BAD.Image = (Image) componentResourceManager.GetObject("picSort_BAD.Image");
      PictureBox picSortBad1 = this.picSort_BAD;
      point1 = new Point(20, 217);
      Point point149 = point1;
      picSortBad1.Location = point149;
      this.picSort_BAD.Name = "picSort_BAD";
      PictureBox picSortBad2 = this.picSort_BAD;
      size1 = new Size(32, 32);
      Size size149 = size1;
      picSortBad2.Size = size149;
      this.picSort_BAD.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picSort_BAD.TabIndex = 124;
      this.picSort_BAD.TabStop = false;
      this.picSort_BAD.Visible = false;
      this.picSort_OK.Image = (Image) componentResourceManager.GetObject("picSort_OK.Image");
      PictureBox picSortOk1 = this.picSort_OK;
      point1 = new Point(20, 217);
      Point point150 = point1;
      picSortOk1.Location = point150;
      this.picSort_OK.Name = "picSort_OK";
      PictureBox picSortOk2 = this.picSort_OK;
      size1 = new Size(32, 32);
      Size size150 = size1;
      picSortOk2.Size = size150;
      this.picSort_OK.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picSort_OK.TabIndex = 123;
      this.picSort_OK.TabStop = false;
      this.picSort_OK.Visible = false;
      this.btnOpSort_Default.BackColor = Color.FromArgb(224, 224, 224);
      this.btnOpSort_Default.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnOpSort_Default.ForeColor = Color.Black;
      Button btnOpSortDefault1 = this.btnOpSort_Default;
      point1 = new Point(67, 215);
      Point point151 = point1;
      btnOpSortDefault1.Location = point151;
      this.btnOpSort_Default.Name = "btnOpSort_Default";
      Button btnOpSortDefault2 = this.btnOpSort_Default;
      size1 = new Size(94, 33);
      Size size151 = size1;
      btnOpSortDefault2.Size = size151;
      this.btnOpSort_Default.TabIndex = 122;
      this.btnOpSort_Default.Text = "DEFAULT";
      this.btnOpSort_Default.UseVisualStyleBackColor = false;
      this.cmbSort_7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbSort_7.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbSort_7.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSort_7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbSort_7.FormattingEnabled = true;
      this.cmbSort_7.Items.AddRange(new object[9]
      {
        (object) "0 не задано",
        (object) "1 Not Registered",
        (object) "2 Login checked",
        (object) "3 Registered",
        (object) "4 Reg & Download Mail",
        (object) "5 Error downloading email",
        (object) "6 Login NotFree",
        (object) "7 Bad Login",
        (object) "8 Is Closed/unused"
      });
      ComboBox cmbSort7_1 = this.cmbSort_7;
      point1 = new Point(6, 160);
      Point point152 = point1;
      cmbSort7_1.Location = point152;
      this.cmbSort_7.Name = "cmbSort_7";
      ComboBox cmbSort7_2 = this.cmbSort_7;
      size1 = new Size(156, 21);
      Size size152 = size1;
      cmbSort7_2.Size = size152;
      this.cmbSort_7.TabIndex = 67;
      this.cmbSort_7.TabStop = false;
      this.cmbSort_7.Tag = (object) "7";
      this.cmbSort_6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbSort_6.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbSort_6.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSort_6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbSort_6.FormattingEnabled = true;
      this.cmbSort_6.Items.AddRange(new object[9]
      {
        (object) "0 не задано",
        (object) "1 Not Registered",
        (object) "2 Login checked",
        (object) "3 Registered",
        (object) "4 Reg & Download Mail",
        (object) "5 Error downloading email",
        (object) "6 Login NotFree",
        (object) "7 Bad Login",
        (object) "8 Is Closed/unused"
      });
      ComboBox cmbSort6_1 = this.cmbSort_6;
      point1 = new Point(6, 137);
      Point point153 = point1;
      cmbSort6_1.Location = point153;
      this.cmbSort_6.Name = "cmbSort_6";
      ComboBox cmbSort6_2 = this.cmbSort_6;
      size1 = new Size(156, 21);
      Size size153 = size1;
      cmbSort6_2.Size = size153;
      this.cmbSort_6.TabIndex = 67;
      this.cmbSort_6.TabStop = false;
      this.cmbSort_6.Tag = (object) "6";
      this.cmbSort_5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbSort_5.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbSort_5.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSort_5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbSort_5.FormattingEnabled = true;
      this.cmbSort_5.Items.AddRange(new object[9]
      {
        (object) "0 не задано",
        (object) "1 Not Registered",
        (object) "2 Login checked",
        (object) "3 Registered",
        (object) "4 Reg & Download Mail",
        (object) "5 Error downloading email",
        (object) "6 Login NotFree",
        (object) "7 Bad Login",
        (object) "8 Is Closed/unused"
      });
      ComboBox cmbSort5_1 = this.cmbSort_5;
      point1 = new Point(6, 114);
      Point point154 = point1;
      cmbSort5_1.Location = point154;
      this.cmbSort_5.Name = "cmbSort_5";
      ComboBox cmbSort5_2 = this.cmbSort_5;
      size1 = new Size(156, 21);
      Size size154 = size1;
      cmbSort5_2.Size = size154;
      this.cmbSort_5.TabIndex = 67;
      this.cmbSort_5.TabStop = false;
      this.cmbSort_5.Tag = (object) "5";
      this.cmbSort_4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbSort_4.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbSort_4.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSort_4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbSort_4.FormattingEnabled = true;
      this.cmbSort_4.Items.AddRange(new object[9]
      {
        (object) "0 не задано",
        (object) "1 Not Registered",
        (object) "2 Login checked",
        (object) "3 Registered",
        (object) "4 Reg & Download Mail",
        (object) "5 Error downloading email",
        (object) "6 Login NotFree",
        (object) "7 Bad Login",
        (object) "8 Is Closed/unused"
      });
      ComboBox cmbSort4_1 = this.cmbSort_4;
      point1 = new Point(6, 91);
      Point point155 = point1;
      cmbSort4_1.Location = point155;
      this.cmbSort_4.Name = "cmbSort_4";
      ComboBox cmbSort4_2 = this.cmbSort_4;
      size1 = new Size(156, 21);
      Size size155 = size1;
      cmbSort4_2.Size = size155;
      this.cmbSort_4.TabIndex = 67;
      this.cmbSort_4.TabStop = false;
      this.cmbSort_4.Tag = (object) "4";
      this.cmbSort_3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbSort_3.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbSort_3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSort_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbSort_3.FormattingEnabled = true;
      this.cmbSort_3.Items.AddRange(new object[9]
      {
        (object) "0 не задано",
        (object) "1 Not Registered",
        (object) "2 Login checked",
        (object) "3 Registered",
        (object) "4 Reg & Download Mail",
        (object) "5 Error downloading email",
        (object) "6 Login NotFree",
        (object) "7 Bad Login",
        (object) "8 Is Closed/unused"
      });
      ComboBox cmbSort3_1 = this.cmbSort_3;
      point1 = new Point(6, 68);
      Point point156 = point1;
      cmbSort3_1.Location = point156;
      this.cmbSort_3.Name = "cmbSort_3";
      ComboBox cmbSort3_2 = this.cmbSort_3;
      size1 = new Size(156, 21);
      Size size156 = size1;
      cmbSort3_2.Size = size156;
      this.cmbSort_3.TabIndex = 67;
      this.cmbSort_3.TabStop = false;
      this.cmbSort_3.Tag = (object) "3";
      this.cmbSort_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbSort_2.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbSort_2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSort_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbSort_2.FormattingEnabled = true;
      this.cmbSort_2.Items.AddRange(new object[9]
      {
        (object) "0 не задано",
        (object) "1 Not Registered",
        (object) "2 Login checked",
        (object) "3 Registered",
        (object) "4 Reg & Download Mail",
        (object) "5 Error downloading email",
        (object) "6 Login NotFree",
        (object) "7 Bad Login",
        (object) "8 Is Closed/unused"
      });
      ComboBox cmbSort2_1 = this.cmbSort_2;
      point1 = new Point(6, 45);
      Point point157 = point1;
      cmbSort2_1.Location = point157;
      this.cmbSort_2.Name = "cmbSort_2";
      ComboBox cmbSort2_2 = this.cmbSort_2;
      size1 = new Size(156, 21);
      Size size157 = size1;
      cmbSort2_2.Size = size157;
      this.cmbSort_2.TabIndex = 67;
      this.cmbSort_2.TabStop = false;
      this.cmbSort_2.Tag = (object) "2";
      this.cmbSort_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbSort_1.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbSort_1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSort_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbSort_1.FormattingEnabled = true;
      this.cmbSort_1.Items.AddRange(new object[9]
      {
        (object) "0 не задано",
        (object) "1 Not Registered",
        (object) "2 Login checked",
        (object) "3 Registered",
        (object) "4 Reg & Download Mail",
        (object) "5 Error downloading email",
        (object) "6 Login NotFree",
        (object) "7 Bad Login",
        (object) "8 Is Closed/unused"
      });
      ComboBox cmbSort1_1 = this.cmbSort_1;
      point1 = new Point(6, 22);
      Point point158 = point1;
      cmbSort1_1.Location = point158;
      this.cmbSort_1.Name = "cmbSort_1";
      ComboBox cmbSort1_2 = this.cmbSort_1;
      size1 = new Size(156, 21);
      Size size158 = size1;
      cmbSort1_2.Size = size158;
      this.cmbSort_1.TabIndex = 67;
      this.cmbSort_1.TabStop = false;
      this.cmbSort_1.Tag = (object) "1";
      this.boxVPN.Controls.Add((Control) this.txtHardStop);
      this.boxVPN.Controls.Add((Control) this.chVPN_HardStop);
      this.boxVPN.Controls.Add((Control) this.txtVPN_UseRegistered);
      this.boxVPN.Controls.Add((Control) this.Label29);
      this.boxVPN.Controls.Add((Control) this.chVPN_StartWith1Account);
      this.boxVPN.Controls.Add((Control) this.txtVPN_UseDownloadMail);
      this.boxVPN.Controls.Add((Control) this.Label26);
      this.boxVPN.Controls.Add((Control) this.Label25);
      this.boxVPN.Controls.Add((Control) this.chVPN_UseDownloadMail);
      this.boxVPN.Controls.Add((Control) this.Label24);
      this.boxVPN.Controls.Add((Control) this.chVPN_UseReg);
      this.boxVPN.Enabled = false;
      this.boxVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.boxVPN.ForeColor = Color.Magenta;
      GroupBox boxVpn1 = this.boxVPN;
      point1 = new Point(900, 309);
      Point point159 = point1;
      boxVpn1.Location = point159;
      this.boxVPN.Name = "boxVPN";
      GroupBox boxVpn2 = this.boxVPN;
      size1 = new Size(166, 254);
      Size size159 = size1;
      boxVpn2.Size = size159;
      this.boxVPN.TabIndex = 104;
      this.boxVPN.TabStop = false;
      this.txtHardStop.Enabled = false;
      this.txtHardStop.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtHardStop1 = this.txtHardStop;
      point1 = new Point(91, 103);
      Point point160 = point1;
      txtHardStop1.Location = point160;
      this.txtHardStop.MaxLength = 7;
      this.txtHardStop.Name = "txtHardStop";
      TextBox txtHardStop2 = this.txtHardStop;
      size1 = new Size(71, 21);
      Size size160 = size1;
      txtHardStop2.Size = size160;
      this.txtHardStop.TabIndex = 111;
      this.txtHardStop.Tag = (object) "";
      this.txtHardStop.TextAlign = HorizontalAlignment.Center;
      this.chVPN_HardStop.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.chVPN_HardStop.ForeColor = Color.Black;
      CheckBox chVpnHardStop1 = this.chVPN_HardStop;
      point1 = new Point(9, 102);
      Point point161 = point1;
      chVpnHardStop1.Location = point161;
      this.chVPN_HardStop.Name = "chVPN_HardStop";
      CheckBox chVpnHardStop2 = this.chVPN_HardStop;
      size1 = new Size(148, 22);
      Size size161 = size1;
      chVpnHardStop2.Size = size161;
      this.chVPN_HardStop.TabIndex = 110;
      this.chVPN_HardStop.Text = "Hard Stop";
      this.chVPN_HardStop.UseVisualStyleBackColor = true;
      this.txtVPN_UseRegistered.Enabled = false;
      this.txtVPN_UseRegistered.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox vpnUseRegistered1 = this.txtVPN_UseRegistered;
      point1 = new Point(44, 75);
      Point point162 = point1;
      vpnUseRegistered1.Location = point162;
      this.txtVPN_UseRegistered.MaxLength = 7;
      this.txtVPN_UseRegistered.Name = "txtVPN_UseRegistered";
      TextBox vpnUseRegistered2 = this.txtVPN_UseRegistered;
      size1 = new Size(50, 21);
      Size size162 = size1;
      vpnUseRegistered2.Size = size162;
      this.txtVPN_UseRegistered.TabIndex = 108;
      this.txtVPN_UseRegistered.Tag = (object) "";
      this.txtVPN_UseRegistered.TextAlign = HorizontalAlignment.Center;
      this.Label29.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label29.ForeColor = Color.Black;
      Label label29_1 = this.Label29;
      point1 = new Point(6, 75);
      Point point163 = point1;
      label29_1.Location = point163;
      this.Label29.Name = "Label29";
      Label label29_2 = this.Label29;
      size1 = new Size(156, 21);
      Size size163 = size1;
      label29_2.Size = size163;
      this.Label29.TabIndex = 109;
      this.Label29.Text = "Через                    аккаунтов.";
      this.Label29.TextAlign = ContentAlignment.MiddleLeft;
      this.chVPN_StartWith1Account.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chVPN_StartWith1Account.ForeColor = Color.Black;
      CheckBox startWith1Account1 = this.chVPN_StartWith1Account;
      point1 = new Point(8, 195);
      Point point164 = point1;
      startWith1Account1.Location = point164;
      this.chVPN_StartWith1Account.Name = "chVPN_StartWith1Account";
      CheckBox startWith1Account2 = this.chVPN_StartWith1Account;
      size1 = new Size(153, 17);
      Size size164 = size1;
      startWith1Account2.Size = size164;
      this.chVPN_StartWith1Account.TabIndex = 107;
      this.chVPN_StartWith1Account.Text = "Начинать с 1 аккаунта";
      this.chVPN_StartWith1Account.UseVisualStyleBackColor = true;
      this.txtVPN_UseDownloadMail.Enabled = false;
      this.txtVPN_UseDownloadMail.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox vpnUseDownloadMail1 = this.txtVPN_UseDownloadMail;
      point1 = new Point(43, 168);
      Point point165 = point1;
      vpnUseDownloadMail1.Location = point165;
      this.txtVPN_UseDownloadMail.MaxLength = 7;
      this.txtVPN_UseDownloadMail.Name = "txtVPN_UseDownloadMail";
      TextBox vpnUseDownloadMail2 = this.txtVPN_UseDownloadMail;
      size1 = new Size(50, 21);
      Size size165 = size1;
      vpnUseDownloadMail2.Size = size165;
      this.txtVPN_UseDownloadMail.TabIndex = 100;
      this.txtVPN_UseDownloadMail.Tag = (object) "";
      this.txtVPN_UseDownloadMail.TextAlign = HorizontalAlignment.Center;
      this.Label26.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label26.ForeColor = Color.Black;
      Label label26_1 = this.Label26;
      point1 = new Point(5, 168);
      Point point166 = point1;
      label26_1.Location = point166;
      this.Label26.Name = "Label26";
      Label label26_2 = this.Label26;
      size1 = new Size(156, 21);
      Size size166 = size1;
      label26_2.Size = size166;
      this.Label26.TabIndex = 101;
      this.Label26.Text = "Через                    аккаунтов.";
      this.Label26.TextAlign = ContentAlignment.MiddleLeft;
      this.Label25.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label25.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      Label label25_1 = this.Label25;
      point1 = new Point(5, 215);
      Point point167 = point1;
      label25_1.Location = point167;
      this.Label25.Name = "Label25";
      Label label25_2 = this.Label25;
      size1 = new Size(156, 28);
      Size size167 = size1;
      label25_2.Size = size167;
      this.Label25.TabIndex = 99;
      this.Label25.Text = "Не забудьте отключить использование proxy";
      this.Label25.TextAlign = ContentAlignment.MiddleCenter;
      this.chVPN_UseDownloadMail.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.chVPN_UseDownloadMail.ForeColor = Color.Black;
      CheckBox vpnUseDownloadMail3 = this.chVPN_UseDownloadMail;
      point1 = new Point(8, 147);
      Point point168 = point1;
      vpnUseDownloadMail3.Location = point168;
      this.chVPN_UseDownloadMail.Name = "chVPN_UseDownloadMail";
      CheckBox vpnUseDownloadMail4 = this.chVPN_UseDownloadMail;
      size1 = new Size(152, 22);
      Size size168 = size1;
      vpnUseDownloadMail4.Size = size168;
      this.chVPN_UseDownloadMail.TabIndex = 98;
      this.chVPN_UseDownloadMail.Text = "при скачивании писем";
      this.chVPN_UseDownloadMail.UseVisualStyleBackColor = true;
      this.Label24.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label24.ForeColor = Color.Black;
      Label label24_1 = this.Label24;
      point1 = new Point(6, 17);
      Point point169 = point1;
      label24_1.Location = point169;
      this.Label24.Name = "Label24";
      Label label24_2 = this.Label24;
      size1 = new Size(156, 29);
      Size size169 = size1;
      label24_2.Size = size169;
      this.Label24.TabIndex = 97;
      this.Label24.Text = "Будет подгружен модуль RasDialEx";
      this.Label24.TextAlign = ContentAlignment.MiddleCenter;
      this.chVPN_UseReg.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.chVPN_UseReg.ForeColor = Color.Black;
      CheckBox chVpnUseReg1 = this.chVPN_UseReg;
      point1 = new Point(9, 49);
      Point point170 = point1;
      chVpnUseReg1.Location = point170;
      this.chVPN_UseReg.Name = "chVPN_UseReg";
      CheckBox chVpnUseReg2 = this.chVPN_UseReg;
      size1 = new Size(148, 22);
      Size size170 = size1;
      chVpnUseReg2.Size = size170;
      this.chVPN_UseReg.TabIndex = 96;
      this.chVPN_UseReg.Text = "при регистрации";
      this.chVPN_UseReg.UseVisualStyleBackColor = true;
      this.chVPN.AutoSize = true;
      this.chVPN.BackColor = Color.WhiteSmoke;
      this.chVPN.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.chVPN.ForeColor = Color.Magenta;
      CheckBox chVpn1 = this.chVPN;
      point1 = new Point(906, 308);
      Point point171 = point1;
      chVpn1.Location = point171;
      this.chVPN.Name = "chVPN";
      CheckBox chVpn2 = this.chVPN;
      size1 = new Size(147, 18);
      Size size171 = size1;
      chVpn2.Size = size171;
      this.chVPN.TabIndex = 105;
      this.chVPN.Text = "RAS (VPN, PPPoE)+";
      this.chVPN.UseVisualStyleBackColor = false;
      this.btnSQL.BackColor = Color.FromArgb(224, 224, 224);
      this.btnSQL.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnSQL.ForeColor = Color.Blue;
      Button btnSql1 = this.btnSQL;
      point1 = new Point(900, 270);
      Point point172 = point1;
      btnSql1.Location = point172;
      this.btnSQL.Name = "btnSQL";
      Button btnSql2 = this.btnSQL;
      size1 = new Size(166, 33);
      Size size172 = size1;
      btnSql2.Size = size172;
      this.btnSQL.TabIndex = 123;
      this.btnSQL.Text = "SQL [test]";
      this.btnSQL.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.WhiteSmoke;
      size1 = new Size(1069, 572);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.btnSQL);
      this.Controls.Add((Control) this.chVPN);
      this.Controls.Add((Control) this.boxVPN);
      this.Controls.Add((Control) this.rbServiceAC_2);
      this.Controls.Add((Control) this.GroupBox14);
      this.Controls.Add((Control) this.chPlaySound);
      this.Controls.Add((Control) this.rbServiceAC_1);
      this.Controls.Add((Control) this.boxPlaySound);
      this.Controls.Add((Control) this.chNetWorkReboot);
      this.Controls.Add((Control) this.boxNetworkReboot);
      this.Controls.Add((Control) this.chHttpLoadProxy);
      this.Controls.Add((Control) this.boxHttpLoadProxy);
      this.Controls.Add((Control) this.GroupBox5);
      this.Controls.Add((Control) this.GroupBox4);
      this.Controls.Add((Control) this.GroupBox3);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.chOpAC_3);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name = nameof (frmOptions);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Опции программы";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      ((ISupportInitialize) this.PictureBox2).EndInit();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.GroupBox13.ResumeLayout(false);
      this.GroupBox13.PerformLayout();
      this.GroupBox12.ResumeLayout(false);
      this.GroupBox12.PerformLayout();
      this.GroupBox11.ResumeLayout(false);
      this.GroupBox11.PerformLayout();
      this.GroupBox10.ResumeLayout(false);
      this.GroupBox10.PerformLayout();
      this.GroupBox9.ResumeLayout(false);
      this.GroupBox9.PerformLayout();
      this.GroupBox8.ResumeLayout(false);
      this.GroupBox8.PerformLayout();
      this.GroupBox7.ResumeLayout(false);
      this.GroupBox7.PerformLayout();
      ((ISupportInitialize) this.picLine_2).EndInit();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      this.boxHttpLoadProxy.ResumeLayout(false);
      this.boxHttpLoadProxy.PerformLayout();
      this.boxNetworkReboot.ResumeLayout(false);
      this.boxPlaySound.ResumeLayout(false);
      this.GroupBox20.ResumeLayout(false);
      this.GroupBox20.PerformLayout();
      this.GroupBox19.ResumeLayout(false);
      this.GroupBox19.PerformLayout();
      this.GroupBox18.ResumeLayout(false);
      this.GroupBox18.PerformLayout();
      this.GroupBox17.ResumeLayout(false);
      this.GroupBox17.PerformLayout();
      this.GroupBox16.ResumeLayout(false);
      this.GroupBox16.PerformLayout();
      this.GroupBox15.ResumeLayout(false);
      this.GroupBox15.PerformLayout();
      this.GroupBox14.ResumeLayout(false);
      this.GroupBox14.PerformLayout();
      ((ISupportInitialize) this.picSort_BAD).EndInit();
      ((ISupportInitialize) this.picSort_OK).EndInit();
      this.boxVPN.ResumeLayout(false);
      this.boxVPN.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual GroupBox GroupBox1
    {
      get
      {
        return this._GroupBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox1 = value;
      }
    }

    internal virtual TextBox txtAutoCaptchaKEY
    {
      get
      {
        return this._txtAutoCaptchaKEY;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtAutoCaptchaKEY_TextChanged);
        if (this._txtAutoCaptchaKEY != null)
          this._txtAutoCaptchaKEY.TextChanged -= eventHandler;
        this._txtAutoCaptchaKEY = value;
        if (this._txtAutoCaptchaKEY == null)
          return;
        this._txtAutoCaptchaKEY.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
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
        this._Label2 = value;
      }
    }

    internal virtual TextBox txtAutoCaptchaURL
    {
      get
      {
        return this._txtAutoCaptchaURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtAutoCaptchaURL_TextChanged);
        if (this._txtAutoCaptchaURL != null)
          this._txtAutoCaptchaURL.TextChanged -= eventHandler;
        this._txtAutoCaptchaURL = value;
        if (this._txtAutoCaptchaURL == null)
          return;
        this._txtAutoCaptchaURL.TextChanged += eventHandler;
      }
    }

    internal virtual CheckBox chOpAC_3
    {
      get
      {
        return this._chOpAC_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chOpAC_3_CheckedChanged);
        if (this._chOpAC_3 != null)
          this._chOpAC_3.CheckedChanged -= eventHandler;
        this._chOpAC_3 = value;
        if (this._chOpAC_3 == null)
          return;
        this._chOpAC_3.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chOpAC_2
    {
      get
      {
        return this._chOpAC_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chOpAC_2_CheckedChanged);
        if (this._chOpAC_2 != null)
          this._chOpAC_2.CheckedChanged -= eventHandler;
        this._chOpAC_2 = value;
        if (this._chOpAC_2 == null)
          return;
        this._chOpAC_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox2
    {
      get
      {
        return this._GroupBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox2 = value;
      }
    }

    internal virtual CheckBox chOpMailDownload_1
    {
      get
      {
        return this._chOpMailDownload_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chOpMailDownload_1_CheckedChanged);
        if (this._chOpMailDownload_1 != null)
          this._chOpMailDownload_1.CheckedChanged -= eventHandler;
        this._chOpMailDownload_1 = value;
        if (this._chOpMailDownload_1 == null)
          return;
        this._chOpMailDownload_1.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox3
    {
      get
      {
        return this._GroupBox3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox3 = value;
      }
    }

    internal virtual Label Label4
    {
      get
      {
        return this._Label4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label4 = value;
      }
    }

    internal virtual RadioButton rbOP_2
    {
      get
      {
        return this._rbOP_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOP_1_SelectedIndexChanged);
        if (this._rbOP_2 != null)
          this._rbOP_2.CheckedChanged -= eventHandler;
        this._rbOP_2 = value;
        if (this._rbOP_2 == null)
          return;
        this._rbOP_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbOP_1
    {
      get
      {
        return this._rbOP_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOP_1_SelectedIndexChanged);
        if (this._rbOP_1 != null)
          this._rbOP_1.CheckedChanged -= eventHandler;
        this._rbOP_1 = value;
        if (this._rbOP_1 == null)
          return;
        this._rbOP_1.CheckedChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbOP_1
    {
      get
      {
        return this._cmbOP_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOP_1_SelectedIndexChanged);
        if (this._cmbOP_1 != null)
          this._cmbOP_1.SelectedIndexChanged -= eventHandler;
        this._cmbOP_1 = value;
        if (this._cmbOP_1 == null)
          return;
        this._cmbOP_1.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual TextBox txtOP_1
    {
      get
      {
        return this._txtOP_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOP_1_SelectedIndexChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtOP_1_KeyPress);
        if (this._txtOP_1 != null)
        {
          this._txtOP_1.TextChanged -= eventHandler;
          this._txtOP_1.KeyPress -= pressEventHandler;
        }
        this._txtOP_1 = value;
        if (this._txtOP_1 == null)
          return;
        this._txtOP_1.TextChanged += eventHandler;
        this._txtOP_1.KeyPress += pressEventHandler;
      }
    }

    internal virtual GroupBox GroupBox4
    {
      get
      {
        return this._GroupBox4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox4 = value;
      }
    }

    internal virtual CheckBox chOPSaveList_2
    {
      get
      {
        return this._chOPSaveList_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chOPSaveList_2_CheckedChanged);
        if (this._chOPSaveList_2 != null)
          this._chOPSaveList_2.CheckedChanged -= eventHandler;
        this._chOPSaveList_2 = value;
        if (this._chOPSaveList_2 == null)
          return;
        this._chOPSaveList_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbOPSaveList_1
    {
      get
      {
        return this._cmbOPSaveList_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOPSaveList_1_SelectedIndexChanged);
        if (this._cmbOPSaveList_1 != null)
          this._cmbOPSaveList_1.SelectedIndexChanged -= eventHandler;
        this._cmbOPSaveList_1 = value;
        if (this._cmbOPSaveList_1 == null)
          return;
        this._cmbOPSaveList_1.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label6
    {
      get
      {
        return this._Label6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label6 = value;
      }
    }

    internal virtual TextBox txtOPSaveList_1
    {
      get
      {
        return this._txtOPSaveList_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtOPSaveList_1_TextChanged);
        if (this._txtOPSaveList_1 != null)
          this._txtOPSaveList_1.TextChanged -= eventHandler;
        this._txtOPSaveList_1 = value;
        if (this._txtOPSaveList_1 == null)
          return;
        this._txtOPSaveList_1.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label5
    {
      get
      {
        return this._Label5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label5 = value;
      }
    }

    internal virtual CheckBox chOPSaveList_3
    {
      get
      {
        return this._chOPSaveList_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chOPSaveList_3_CheckedChanged);
        if (this._chOPSaveList_3 != null)
          this._chOPSaveList_3.CheckedChanged -= eventHandler;
        this._chOPSaveList_3 = value;
        if (this._chOPSaveList_3 == null)
          return;
        this._chOPSaveList_3.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox txtOP_2
    {
      get
      {
        return this._txtOP_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOP_1_SelectedIndexChanged);
        if (this._txtOP_2 != null)
          this._txtOP_2.TextChanged -= eventHandler;
        this._txtOP_2 = value;
        if (this._txtOP_2 == null)
          return;
        this._txtOP_2.TextChanged += eventHandler;
      }
    }

    internal virtual CheckBox chOP_1
    {
      get
      {
        return this._chOP_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOP_1_SelectedIndexChanged);
        if (this._chOP_1 != null)
          this._chOP_1.CheckedChanged -= eventHandler;
        this._chOP_1 = value;
        if (this._chOP_1 == null)
          return;
        this._chOP_1.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chOPSaveList_1
    {
      get
      {
        return this._chOPSaveList_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chOPSaveList_1_CheckedChanged);
        if (this._chOPSaveList_1 != null)
          this._chOPSaveList_1.CheckedChanged -= eventHandler;
        this._chOPSaveList_1 = value;
        if (this._chOPSaveList_1 == null)
          return;
        this._chOPSaveList_1.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chOPSaveList_4
    {
      get
      {
        return this._chOPSaveList_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chOPSaveList_4_CheckedChanged);
        if (this._chOPSaveList_4 != null)
          this._chOPSaveList_4.CheckedChanged -= eventHandler;
        this._chOPSaveList_4 = value;
        if (this._chOPSaveList_4 == null)
          return;
        this._chOPSaveList_4.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chOpMailDownload_2
    {
      get
      {
        return this._chOpMailDownload_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chOpMailDownload_2_CheckedChanged);
        if (this._chOpMailDownload_2 != null)
          this._chOpMailDownload_2.CheckedChanged -= eventHandler;
        this._chOpMailDownload_2 = value;
        if (this._chOpMailDownload_2 == null)
          return;
        this._chOpMailDownload_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbOPSaveList_2
    {
      get
      {
        return this._cmbOPSaveList_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOPSaveList_2_SelectedIndexChanged);
        if (this._cmbOPSaveList_2 != null)
          this._cmbOPSaveList_2.SelectedIndexChanged -= eventHandler;
        this._cmbOPSaveList_2 = value;
        if (this._cmbOPSaveList_2 == null)
          return;
        this._cmbOPSaveList_2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbOpMailDownload_1
    {
      get
      {
        return this._cmbOpMailDownload_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOpMailDownload_1_SelectedIndexChanged);
        if (this._cmbOpMailDownload_1 != null)
          this._cmbOpMailDownload_1.SelectedIndexChanged -= eventHandler;
        this._cmbOpMailDownload_1 = value;
        if (this._cmbOpMailDownload_1 == null)
          return;
        this._cmbOpMailDownload_1.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chOP_2
    {
      get
      {
        return this._chOP_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOP_1_SelectedIndexChanged);
        if (this._chOP_2 != null)
          this._chOP_2.CheckedChanged -= eventHandler;
        this._chOP_2 = value;
        if (this._chOP_2 == null)
          return;
        this._chOP_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chOP_3
    {
      get
      {
        return this._chOP_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmbOP_1_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.chOP_3_CheckedChanged);
        if (this._chOP_3 != null)
        {
          this._chOP_3.CheckedChanged -= eventHandler1;
          this._chOP_3.CheckedChanged -= eventHandler2;
        }
        this._chOP_3 = value;
        if (this._chOP_3 == null)
          return;
        this._chOP_3.CheckedChanged += eventHandler1;
        this._chOP_3.CheckedChanged += eventHandler2;
      }
    }

    internal virtual CheckBox chUseErrorCount
    {
      get
      {
        return this._chUseErrorCount;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chUseErrorCount_CheckedChanged);
        if (this._chUseErrorCount != null)
          this._chUseErrorCount.CheckedChanged -= eventHandler;
        this._chUseErrorCount = value;
        if (this._chUseErrorCount == null)
          return;
        this._chUseErrorCount.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox txtErrorCount
    {
      get
      {
        return this._txtErrorCount;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtErrorCount_TextChanged);
        if (this._txtErrorCount != null)
          this._txtErrorCount.TextChanged -= eventHandler;
        this._txtErrorCount = value;
        if (this._txtErrorCount == null)
          return;
        this._txtErrorCount.TextChanged += eventHandler;
      }
    }

    internal virtual CheckBox chdebugOp_SaveBadCaptcha
    {
      get
      {
        return this._chdebugOp_SaveBadCaptcha;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chdebugOp_SaveBadCaptcha_CheckedChanged);
        if (this._chdebugOp_SaveBadCaptcha != null)
          this._chdebugOp_SaveBadCaptcha.CheckedChanged -= eventHandler;
        this._chdebugOp_SaveBadCaptcha = value;
        if (this._chdebugOp_SaveBadCaptcha == null)
          return;
        this._chdebugOp_SaveBadCaptcha.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox txtIntervalConnect
    {
      get
      {
        return this._txtIntervalConnect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtIntervalConnect_TextChanged);
        if (this._txtIntervalConnect != null)
          this._txtIntervalConnect.TextChanged -= eventHandler;
        this._txtIntervalConnect = value;
        if (this._txtIntervalConnect == null)
          return;
        this._txtIntervalConnect.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtSocketTimeOut
    {
      get
      {
        return this._txtSocketTimeOut;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSocketTimeOut_TextChanged);
        if (this._txtSocketTimeOut != null)
          this._txtSocketTimeOut.TextChanged -= eventHandler;
        this._txtSocketTimeOut = value;
        if (this._txtSocketTimeOut == null)
          return;
        this._txtSocketTimeOut.TextChanged += eventHandler;
      }
    }

    internal virtual CheckBox chSocketTimeOut
    {
      get
      {
        return this._chSocketTimeOut;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._chSocketTimeOut = value;
      }
    }

    internal virtual CheckBox chSavePacket_RegError
    {
      get
      {
        return this._chSavePacket_RegError;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chSavePacket_RegError_CheckedChanged);
        if (this._chSavePacket_RegError != null)
          this._chSavePacket_RegError.CheckedChanged -= eventHandler;
        this._chSavePacket_RegError = value;
        if (this._chSavePacket_RegError == null)
          return;
        this._chSavePacket_RegError.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chSaveLog
    {
      get
      {
        return this._chSaveLog;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chSaveLog_CheckedChanged);
        if (this._chSaveLog != null)
          this._chSaveLog.CheckedChanged -= eventHandler;
        this._chSaveLog = value;
        if (this._chSaveLog == null)
          return;
        this._chSaveLog.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox5
    {
      get
      {
        return this._GroupBox5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox5 = value;
      }
    }

    internal virtual GroupBox boxHttpLoadProxy
    {
      get
      {
        return this._boxHttpLoadProxy;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxHttpLoadProxy = value;
      }
    }

    internal virtual Label lblInfoProxyLoad
    {
      get
      {
        return this._lblInfoProxyLoad;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblInfoProxyLoad = value;
      }
    }

    internal virtual CheckBox chHttpLoadProxy_UseRegEx
    {
      get
      {
        return this._chHttpLoadProxy_UseRegEx;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
        if (this._chHttpLoadProxy_UseRegEx != null)
          this._chHttpLoadProxy_UseRegEx.CheckedChanged -= eventHandler;
        this._chHttpLoadProxy_UseRegEx = value;
        if (this._chHttpLoadProxy_UseRegEx == null)
          return;
        this._chHttpLoadProxy_UseRegEx.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox txtHttpLoadProxy_RegEx
    {
      get
      {
        return this._txtHttpLoadProxy_RegEx;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtHttpLoadProxy_RegEx_TextChanged);
        if (this._txtHttpLoadProxy_RegEx != null)
          this._txtHttpLoadProxy_RegEx.TextChanged -= eventHandler;
        this._txtHttpLoadProxy_RegEx = value;
        if (this._txtHttpLoadProxy_RegEx == null)
          return;
        this._txtHttpLoadProxy_RegEx.TextChanged += eventHandler;
      }
    }

    internal virtual Button Button1
    {
      get
      {
        return this._Button1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
    }

    internal virtual Label lblHttpLoadProxy_UrlCount
    {
      get
      {
        return this._lblHttpLoadProxy_UrlCount;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblHttpLoadProxy_UrlCount = value;
      }
    }

    internal virtual ComboBox cmbHttpLoadProxy
    {
      get
      {
        return this._cmbHttpLoadProxy;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._cmbHttpLoadProxy = value;
      }
    }

    internal virtual Label Label7
    {
      get
      {
        return this._Label7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label7 = value;
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

    internal virtual CheckBox chHttpLoadProxy_Append
    {
      get
      {
        return this._chHttpLoadProxy_Append;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chHttpLoadProxy_Append_CheckedChanged);
        if (this._chHttpLoadProxy_Append != null)
          this._chHttpLoadProxy_Append.CheckedChanged -= eventHandler;
        this._chHttpLoadProxy_Append = value;
        if (this._chHttpLoadProxy_Append == null)
          return;
        this._chHttpLoadProxy_Append.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chHttpLoadProxy_LoadInStart
    {
      get
      {
        return this._chHttpLoadProxy_LoadInStart;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chHttpLoadProxy_LoadInStart_CheckedChanged);
        if (this._chHttpLoadProxy_LoadInStart != null)
          this._chHttpLoadProxy_LoadInStart.CheckedChanged -= eventHandler;
        this._chHttpLoadProxy_LoadInStart = value;
        if (this._chHttpLoadProxy_LoadInStart == null)
          return;
        this._chHttpLoadProxy_LoadInStart.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label9
    {
      get
      {
        return this._Label9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label9 = value;
      }
    }

    internal virtual Button Button2
    {
      get
      {
        return this._Button2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        if (this._Button2 != null)
          this._Button2.Click -= eventHandler;
        this._Button2 = value;
        if (this._Button2 == null)
          return;
        this._Button2.Click += eventHandler;
      }
    }

    internal virtual Label lblHttpLoadProxy_Count
    {
      get
      {
        return this._lblHttpLoadProxy_Count;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblHttpLoadProxy_Count = value;
      }
    }

    internal virtual CheckBox chHttpLoadProxy
    {
      get
      {
        return this._chHttpLoadProxy;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this._CheckedChanged);
        if (this._chHttpLoadProxy != null)
          this._chHttpLoadProxy.CheckedChanged -= eventHandler;
        this._chHttpLoadProxy = value;
        if (this._chHttpLoadProxy == null)
          return;
        this._chHttpLoadProxy.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chAfterLoadStartOne
    {
      get
      {
        return this._chAfterLoadStartOne;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chAfterLoadStartOne_CheckedChanged_1);
        if (this._chAfterLoadStartOne != null)
          this._chAfterLoadStartOne.CheckedChanged -= eventHandler;
        this._chAfterLoadStartOne = value;
        if (this._chAfterLoadStartOne == null)
          return;
        this._chAfterLoadStartOne.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox boxNetworkReboot
    {
      get
      {
        return this._boxNetworkReboot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxNetworkReboot = value;
      }
    }

    internal virtual CheckBox chNetWorkReboot
    {
      get
      {
        return this._chNetWorkReboot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chNetWorkReboot_CheckedChanged);
        if (this._chNetWorkReboot != null)
          this._chNetWorkReboot.CheckedChanged -= eventHandler;
        this._chNetWorkReboot = value;
        if (this._chNetWorkReboot == null)
          return;
        this._chNetWorkReboot.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label8
    {
      get
      {
        return this._Label8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label8 = value;
      }
    }

    internal virtual ComboBox cmbNetworkReboot_Adapter
    {
      get
      {
        return this._cmbNetworkReboot_Adapter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbNetworkReboot_Adapter_SelectedIndexChanged);
        if (this._cmbNetworkReboot_Adapter != null)
          this._cmbNetworkReboot_Adapter.SelectedIndexChanged -= eventHandler;
        this._cmbNetworkReboot_Adapter = value;
        if (this._cmbNetworkReboot_Adapter == null)
          return;
        this._cmbNetworkReboot_Adapter.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label10
    {
      get
      {
        return this._Label10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label10 = value;
      }
    }

    internal virtual ComboBox cmbNetworkReboot_Filtr
    {
      get
      {
        return this._cmbNetworkReboot_Filtr;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbNetworkReboot_Filtr_SelectedIndexChanged);
        if (this._cmbNetworkReboot_Filtr != null)
          this._cmbNetworkReboot_Filtr.SelectedIndexChanged -= eventHandler;
        this._cmbNetworkReboot_Filtr = value;
        if (this._cmbNetworkReboot_Filtr == null)
          return;
        this._cmbNetworkReboot_Filtr.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Button Button4
    {
      get
      {
        return this._Button4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        if (this._Button4 != null)
          this._Button4.Click -= eventHandler;
        this._Button4 = value;
        if (this._Button4 == null)
          return;
        this._Button4.Click += eventHandler;
      }
    }

    internal virtual Label Label11
    {
      get
      {
        return this._Label11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label11 = value;
      }
    }

    internal virtual Label lblNetworkReboot_NetConnectionID
    {
      get
      {
        return this._lblNetworkReboot_NetConnectionID;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblNetworkReboot_NetConnectionID = value;
      }
    }

    internal virtual Label Label12
    {
      get
      {
        return this._Label12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label12 = value;
      }
    }

    internal virtual ComboBox cmbNetworkReboot_Method
    {
      get
      {
        return this._cmbNetworkReboot_Method;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbNetworkReboot_Method_SelectedIndexChanged);
        if (this._cmbNetworkReboot_Method != null)
          this._cmbNetworkReboot_Method.SelectedIndexChanged -= eventHandler;
        this._cmbNetworkReboot_Method = value;
        if (this._cmbNetworkReboot_Method == null)
          return;
        this._cmbNetworkReboot_Method.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label13
    {
      get
      {
        return this._Label13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label13 = value;
      }
    }

    internal virtual Label lblNetworkReboot_MAC
    {
      get
      {
        return this._lblNetworkReboot_MAC;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblNetworkReboot_MAC = value;
      }
    }

    internal virtual GroupBox GroupBox6
    {
      get
      {
        return this._GroupBox6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox6 = value;
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

    internal virtual Label Label14
    {
      get
      {
        return this._Label14;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label14 = value;
      }
    }

    internal virtual ComboBox cmbOpAC_1
    {
      get
      {
        return this._cmbOpAC_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOpAC_1_SelectedIndexChanged);
        if (this._cmbOpAC_1 != null)
          this._cmbOpAC_1.SelectedIndexChanged -= eventHandler;
        this._cmbOpAC_1 = value;
        if (this._cmbOpAC_1 == null)
          return;
        this._cmbOpAC_1.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label15
    {
      get
      {
        return this._Label15;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label15 = value;
      }
    }

    internal virtual ComboBox cmbOpAC_7
    {
      get
      {
        return this._cmbOpAC_7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOpAC_7_SelectedIndexChanged);
        if (this._cmbOpAC_7 != null)
          this._cmbOpAC_7.SelectedIndexChanged -= eventHandler;
        this._cmbOpAC_7 = value;
        if (this._cmbOpAC_7 == null)
          return;
        this._cmbOpAC_7.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label21
    {
      get
      {
        return this._Label21;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label21 = value;
      }
    }

    internal virtual ComboBox cmbOpAC_6
    {
      get
      {
        return this._cmbOpAC_6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOpAC_6_SelectedIndexChanged);
        if (this._cmbOpAC_6 != null)
          this._cmbOpAC_6.SelectedIndexChanged -= eventHandler;
        this._cmbOpAC_6 = value;
        if (this._cmbOpAC_6 == null)
          return;
        this._cmbOpAC_6.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label20
    {
      get
      {
        return this._Label20;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label20 = value;
      }
    }

    internal virtual ComboBox cmbOpAC_5
    {
      get
      {
        return this._cmbOpAC_5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOpAC_5_SelectedIndexChanged);
        if (this._cmbOpAC_5 != null)
          this._cmbOpAC_5.SelectedIndexChanged -= eventHandler;
        this._cmbOpAC_5 = value;
        if (this._cmbOpAC_5 == null)
          return;
        this._cmbOpAC_5.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label19
    {
      get
      {
        return this._Label19;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label19 = value;
      }
    }

    internal virtual ComboBox cmbOpAC_4
    {
      get
      {
        return this._cmbOpAC_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOpAC_4_SelectedIndexChanged);
        if (this._cmbOpAC_4 != null)
          this._cmbOpAC_4.SelectedIndexChanged -= eventHandler;
        this._cmbOpAC_4 = value;
        if (this._cmbOpAC_4 == null)
          return;
        this._cmbOpAC_4.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label18
    {
      get
      {
        return this._Label18;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label18 = value;
      }
    }

    internal virtual ComboBox cmbOpAC_3
    {
      get
      {
        return this._cmbOpAC_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOpAC_3_SelectedIndexChanged);
        if (this._cmbOpAC_3 != null)
          this._cmbOpAC_3.SelectedIndexChanged -= eventHandler;
        this._cmbOpAC_3 = value;
        if (this._cmbOpAC_3 == null)
          return;
        this._cmbOpAC_3.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label17
    {
      get
      {
        return this._Label17;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label17 = value;
      }
    }

    internal virtual ComboBox cmbOpAC_2
    {
      get
      {
        return this._cmbOpAC_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbOpAC_2_SelectedIndexChanged);
        if (this._cmbOpAC_2 != null)
          this._cmbOpAC_2.SelectedIndexChanged -= eventHandler;
        this._cmbOpAC_2 = value;
        if (this._cmbOpAC_2 == null)
          return;
        this._cmbOpAC_2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label16
    {
      get
      {
        return this._Label16;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label16 = value;
      }
    }

    internal virtual GroupBox GroupBox7
    {
      get
      {
        return this._GroupBox7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox7 = value;
      }
    }

    internal virtual TextBox txtOpAC_1
    {
      get
      {
        return this._txtOpAC_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtOpAC_1_TextChanged);
        if (this._txtOpAC_1 != null)
          this._txtOpAC_1.TextChanged -= eventHandler;
        this._txtOpAC_1 = value;
        if (this._txtOpAC_1 == null)
          return;
        this._txtOpAC_1.TextChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox11
    {
      get
      {
        return this._GroupBox11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox11 = value;
      }
    }

    internal virtual TextBox txtOpAC_5
    {
      get
      {
        return this._txtOpAC_5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtOpAC_5_TextChanged);
        if (this._txtOpAC_5 != null)
          this._txtOpAC_5.TextChanged -= eventHandler;
        this._txtOpAC_5 = value;
        if (this._txtOpAC_5 == null)
          return;
        this._txtOpAC_5.TextChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox10
    {
      get
      {
        return this._GroupBox10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox10 = value;
      }
    }

    internal virtual TextBox txtOpAC_4
    {
      get
      {
        return this._txtOpAC_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtOpAC_4_TextChanged);
        if (this._txtOpAC_4 != null)
          this._txtOpAC_4.TextChanged -= eventHandler;
        this._txtOpAC_4 = value;
        if (this._txtOpAC_4 == null)
          return;
        this._txtOpAC_4.TextChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox9
    {
      get
      {
        return this._GroupBox9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox9 = value;
      }
    }

    internal virtual TextBox txtOpAC_3
    {
      get
      {
        return this._txtOpAC_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtOpAC_3_TextChanged);
        if (this._txtOpAC_3 != null)
          this._txtOpAC_3.TextChanged -= eventHandler;
        this._txtOpAC_3 = value;
        if (this._txtOpAC_3 == null)
          return;
        this._txtOpAC_3.TextChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox8
    {
      get
      {
        return this._GroupBox8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox8 = value;
      }
    }

    internal virtual TextBox txtOpAC_2
    {
      get
      {
        return this._txtOpAC_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtOpAC_2_TextChanged);
        if (this._txtOpAC_2 != null)
          this._txtOpAC_2.TextChanged -= eventHandler;
        this._txtOpAC_2 = value;
        if (this._txtOpAC_2 == null)
          return;
        this._txtOpAC_2.TextChanged += eventHandler;
      }
    }

    internal virtual Button btnAC_Default
    {
      get
      {
        return this._btnAC_Default;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAC_Default_Click);
        if (this._btnAC_Default != null)
          this._btnAC_Default.Click -= eventHandler;
        this._btnAC_Default = value;
        if (this._btnAC_Default == null)
          return;
        this._btnAC_Default.Click += eventHandler;
      }
    }

    internal virtual Label Label22
    {
      get
      {
        return this._Label22;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label22 = value;
      }
    }

    internal virtual GroupBox GroupBox13
    {
      get
      {
        return this._GroupBox13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox13 = value;
      }
    }

    internal virtual TextBox txtOpAC_7
    {
      get
      {
        return this._txtOpAC_7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtOpAC_7_TextChanged);
        if (this._txtOpAC_7 != null)
          this._txtOpAC_7.TextChanged -= eventHandler;
        this._txtOpAC_7 = value;
        if (this._txtOpAC_7 == null)
          return;
        this._txtOpAC_7.TextChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox12
    {
      get
      {
        return this._GroupBox12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox12 = value;
      }
    }

    internal virtual TextBox txtOpAC_6
    {
      get
      {
        return this._txtOpAC_6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtOpAC_6_TextChanged);
        if (this._txtOpAC_6 != null)
          this._txtOpAC_6.TextChanged -= eventHandler;
        this._txtOpAC_6 = value;
        if (this._txtOpAC_6 == null)
          return;
        this._txtOpAC_6.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label3
    {
      get
      {
        return this._Label3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label3 = value;
      }
    }

    internal virtual GroupBox boxPlaySound
    {
      get
      {
        return this._boxPlaySound;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxPlaySound = value;
      }
    }

    internal virtual CheckBox chPlaySound
    {
      get
      {
        return this._chPlaySound;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chPlaySound_CheckedChanged);
        if (this._chPlaySound != null)
          this._chPlaySound.CheckedChanged -= eventHandler;
        this._chPlaySound = value;
        if (this._chPlaySound == null)
          return;
        this._chPlaySound.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label23
    {
      get
      {
        return this._Label23;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label23 = value;
      }
    }

    internal virtual GroupBox GroupBox15
    {
      get
      {
        return this._GroupBox15;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox15 = value;
      }
    }

    internal virtual Button btnPlaySound_1
    {
      get
      {
        return this._btnPlaySound_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPlaySound_1_Click);
        if (this._btnPlaySound_1 != null)
          this._btnPlaySound_1.Click -= eventHandler;
        this._btnPlaySound_1 = value;
        if (this._btnPlaySound_1 == null)
          return;
        this._btnPlaySound_1.Click += eventHandler;
      }
    }

    internal virtual TextBox txtPlaySound_1
    {
      get
      {
        return this._txtPlaySound_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtPlaySound_1 = value;
      }
    }

    internal virtual GroupBox GroupBox20
    {
      get
      {
        return this._GroupBox20;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox20 = value;
      }
    }

    internal virtual Button btnPlaySound_6
    {
      get
      {
        return this._btnPlaySound_6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPlaySound_1_Click);
        if (this._btnPlaySound_6 != null)
          this._btnPlaySound_6.Click -= eventHandler;
        this._btnPlaySound_6 = value;
        if (this._btnPlaySound_6 == null)
          return;
        this._btnPlaySound_6.Click += eventHandler;
      }
    }

    internal virtual TextBox txtPlaySound_6
    {
      get
      {
        return this._txtPlaySound_6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtPlaySound_6 = value;
      }
    }

    internal virtual GroupBox GroupBox19
    {
      get
      {
        return this._GroupBox19;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox19 = value;
      }
    }

    internal virtual Button btnPlaySound_3
    {
      get
      {
        return this._btnPlaySound_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPlaySound_1_Click);
        if (this._btnPlaySound_3 != null)
          this._btnPlaySound_3.Click -= eventHandler;
        this._btnPlaySound_3 = value;
        if (this._btnPlaySound_3 == null)
          return;
        this._btnPlaySound_3.Click += eventHandler;
      }
    }

    internal virtual TextBox txtPlaySound_3
    {
      get
      {
        return this._txtPlaySound_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtPlaySound_3 = value;
      }
    }

    internal virtual GroupBox GroupBox18
    {
      get
      {
        return this._GroupBox18;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox18 = value;
      }
    }

    internal virtual Button btnPlaySound_5
    {
      get
      {
        return this._btnPlaySound_5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPlaySound_1_Click);
        if (this._btnPlaySound_5 != null)
          this._btnPlaySound_5.Click -= eventHandler;
        this._btnPlaySound_5 = value;
        if (this._btnPlaySound_5 == null)
          return;
        this._btnPlaySound_5.Click += eventHandler;
      }
    }

    internal virtual TextBox txtPlaySound_5
    {
      get
      {
        return this._txtPlaySound_5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtPlaySound_5 = value;
      }
    }

    internal virtual GroupBox GroupBox17
    {
      get
      {
        return this._GroupBox17;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox17 = value;
      }
    }

    internal virtual Button btnPlaySound_4
    {
      get
      {
        return this._btnPlaySound_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPlaySound_1_Click);
        if (this._btnPlaySound_4 != null)
          this._btnPlaySound_4.Click -= eventHandler;
        this._btnPlaySound_4 = value;
        if (this._btnPlaySound_4 == null)
          return;
        this._btnPlaySound_4.Click += eventHandler;
      }
    }

    internal virtual TextBox txtPlaySound_4
    {
      get
      {
        return this._txtPlaySound_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtPlaySound_4 = value;
      }
    }

    internal virtual GroupBox GroupBox16
    {
      get
      {
        return this._GroupBox16;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox16 = value;
      }
    }

    internal virtual Button btnPlaySound_2
    {
      get
      {
        return this._btnPlaySound_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPlaySound_1_Click);
        if (this._btnPlaySound_2 != null)
          this._btnPlaySound_2.Click -= eventHandler;
        this._btnPlaySound_2 = value;
        if (this._btnPlaySound_2 == null)
          return;
        this._btnPlaySound_2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtPlaySound_2
    {
      get
      {
        return this._txtPlaySound_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtPlaySound_2 = value;
      }
    }

    internal virtual CheckBox chPlaySound_6
    {
      get
      {
        return this._chPlaySound_6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chPlaySound_1_CheckedChanged);
        if (this._chPlaySound_6 != null)
          this._chPlaySound_6.CheckedChanged -= eventHandler;
        this._chPlaySound_6 = value;
        if (this._chPlaySound_6 == null)
          return;
        this._chPlaySound_6.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chPlaySound_3
    {
      get
      {
        return this._chPlaySound_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chPlaySound_1_CheckedChanged);
        if (this._chPlaySound_3 != null)
          this._chPlaySound_3.CheckedChanged -= eventHandler;
        this._chPlaySound_3 = value;
        if (this._chPlaySound_3 == null)
          return;
        this._chPlaySound_3.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chPlaySound_5
    {
      get
      {
        return this._chPlaySound_5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chPlaySound_1_CheckedChanged);
        if (this._chPlaySound_5 != null)
          this._chPlaySound_5.CheckedChanged -= eventHandler;
        this._chPlaySound_5 = value;
        if (this._chPlaySound_5 == null)
          return;
        this._chPlaySound_5.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chPlaySound_4
    {
      get
      {
        return this._chPlaySound_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chPlaySound_1_CheckedChanged);
        if (this._chPlaySound_4 != null)
          this._chPlaySound_4.CheckedChanged -= eventHandler;
        this._chPlaySound_4 = value;
        if (this._chPlaySound_4 == null)
          return;
        this._chPlaySound_4.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chPlaySound_2
    {
      get
      {
        return this._chPlaySound_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chPlaySound_1_CheckedChanged);
        if (this._chPlaySound_2 != null)
          this._chPlaySound_2.CheckedChanged -= eventHandler;
        this._chPlaySound_2 = value;
        if (this._chPlaySound_2 == null)
          return;
        this._chPlaySound_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chPlaySound_1
    {
      get
      {
        return this._chPlaySound_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chPlaySound_1_CheckedChanged);
        if (this._chPlaySound_1 != null)
          this._chPlaySound_1.CheckedChanged -= eventHandler;
        this._chPlaySound_1 = value;
        if (this._chPlaySound_1 == null)
          return;
        this._chPlaySound_1.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chdebugOp_FullSessionLog
    {
      get
      {
        return this._chdebugOp_FullSessionLog;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chdebugOp_FullSessionLog_CheckedChanged);
        if (this._chdebugOp_FullSessionLog != null)
          this._chdebugOp_FullSessionLog.CheckedChanged -= eventHandler;
        this._chdebugOp_FullSessionLog = value;
        if (this._chdebugOp_FullSessionLog == null)
          return;
        this._chdebugOp_FullSessionLog.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chdebugOp_SaveBadIP
    {
      get
      {
        return this._chdebugOp_SaveBadIP;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chdebugOp_SaveBadIP_CheckedChanged);
        if (this._chdebugOp_SaveBadIP != null)
          this._chdebugOp_SaveBadIP.CheckedChanged -= eventHandler;
        this._chdebugOp_SaveBadIP = value;
        if (this._chdebugOp_SaveBadIP == null)
          return;
        this._chdebugOp_SaveBadIP.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chNetworkReboot_MacChange
    {
      get
      {
        return this._chNetworkReboot_MacChange;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chNetworkReboot_MacChange_CheckedChanged);
        if (this._chNetworkReboot_MacChange != null)
          this._chNetworkReboot_MacChange.CheckedChanged -= eventHandler;
        this._chNetworkReboot_MacChange = value;
        if (this._chNetworkReboot_MacChange == null)
          return;
        this._chNetworkReboot_MacChange.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox14
    {
      get
      {
        return this._GroupBox14;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox14 = value;
      }
    }

    internal virtual ComboBox cmbSort_1
    {
      get
      {
        return this._cmbSort_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbSort_1_SelectedIndexChanged);
        if (this._cmbSort_1 != null)
          this._cmbSort_1.SelectedIndexChanged -= eventHandler;
        this._cmbSort_1 = value;
        if (this._cmbSort_1 == null)
          return;
        this._cmbSort_1.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbSort_7
    {
      get
      {
        return this._cmbSort_7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbSort_1_SelectedIndexChanged);
        if (this._cmbSort_7 != null)
          this._cmbSort_7.SelectedIndexChanged -= eventHandler;
        this._cmbSort_7 = value;
        if (this._cmbSort_7 == null)
          return;
        this._cmbSort_7.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbSort_6
    {
      get
      {
        return this._cmbSort_6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbSort_1_SelectedIndexChanged);
        if (this._cmbSort_6 != null)
          this._cmbSort_6.SelectedIndexChanged -= eventHandler;
        this._cmbSort_6 = value;
        if (this._cmbSort_6 == null)
          return;
        this._cmbSort_6.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbSort_5
    {
      get
      {
        return this._cmbSort_5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbSort_1_SelectedIndexChanged);
        if (this._cmbSort_5 != null)
          this._cmbSort_5.SelectedIndexChanged -= eventHandler;
        this._cmbSort_5 = value;
        if (this._cmbSort_5 == null)
          return;
        this._cmbSort_5.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbSort_4
    {
      get
      {
        return this._cmbSort_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbSort_1_SelectedIndexChanged);
        if (this._cmbSort_4 != null)
          this._cmbSort_4.SelectedIndexChanged -= eventHandler;
        this._cmbSort_4 = value;
        if (this._cmbSort_4 == null)
          return;
        this._cmbSort_4.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbSort_3
    {
      get
      {
        return this._cmbSort_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbSort_1_SelectedIndexChanged);
        if (this._cmbSort_3 != null)
          this._cmbSort_3.SelectedIndexChanged -= eventHandler;
        this._cmbSort_3 = value;
        if (this._cmbSort_3 == null)
          return;
        this._cmbSort_3.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbSort_2
    {
      get
      {
        return this._cmbSort_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbSort_1_SelectedIndexChanged);
        if (this._cmbSort_2 != null)
          this._cmbSort_2.SelectedIndexChanged -= eventHandler;
        this._cmbSort_2 = value;
        if (this._cmbSort_2 == null)
          return;
        this._cmbSort_2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Button btnOpSort_Default
    {
      get
      {
        return this._btnOpSort_Default;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnOpSort_Default_Click);
        if (this._btnOpSort_Default != null)
          this._btnOpSort_Default.Click -= eventHandler;
        this._btnOpSort_Default = value;
        if (this._btnOpSort_Default == null)
          return;
        this._btnOpSort_Default.Click += eventHandler;
      }
    }

    internal virtual GroupBox boxVPN
    {
      get
      {
        return this._boxVPN;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxVPN = value;
      }
    }

    internal virtual CheckBox chVPN_UseDownloadMail
    {
      get
      {
        return this._chVPN_UseDownloadMail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chVPN_UseDownloadMail_CheckedChanged);
        if (this._chVPN_UseDownloadMail != null)
          this._chVPN_UseDownloadMail.CheckedChanged -= eventHandler;
        this._chVPN_UseDownloadMail = value;
        if (this._chVPN_UseDownloadMail == null)
          return;
        this._chVPN_UseDownloadMail.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label24
    {
      get
      {
        return this._Label24;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label24 = value;
      }
    }

    internal virtual CheckBox chVPN_UseReg
    {
      get
      {
        return this._chVPN_UseReg;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chVPN_UseReg_CheckedChanged);
        if (this._chVPN_UseReg != null)
          this._chVPN_UseReg.CheckedChanged -= eventHandler;
        this._chVPN_UseReg = value;
        if (this._chVPN_UseReg == null)
          return;
        this._chVPN_UseReg.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chVPN
    {
      get
      {
        return this._chVPN;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chVPN_CheckedChanged);
        if (this._chVPN != null)
          this._chVPN.CheckedChanged -= eventHandler;
        this._chVPN = value;
        if (this._chVPN == null)
          return;
        this._chVPN.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label25
    {
      get
      {
        return this._Label25;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label25 = value;
      }
    }

    internal virtual TextBox txtVPN_UseDownloadMail
    {
      get
      {
        return this._txtVPN_UseDownloadMail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtVPN_UseDownloadMail_TextChanged);
        if (this._txtVPN_UseDownloadMail != null)
          this._txtVPN_UseDownloadMail.TextChanged -= eventHandler;
        this._txtVPN_UseDownloadMail = value;
        if (this._txtVPN_UseDownloadMail == null)
          return;
        this._txtVPN_UseDownloadMail.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label26
    {
      get
      {
        return this._Label26;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label26 = value;
      }
    }

    internal virtual PictureBox picSort_BAD
    {
      get
      {
        return this._picSort_BAD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picSort_BAD = value;
      }
    }

    internal virtual PictureBox picSort_OK
    {
      get
      {
        return this._picSort_OK;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picSort_OK = value;
      }
    }

    internal virtual CheckBox chVPN_StartWith1Account
    {
      get
      {
        return this._chVPN_StartWith1Account;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chVPN_StartWith1Account_CheckedChanged);
        if (this._chVPN_StartWith1Account != null)
          this._chVPN_StartWith1Account.CheckedChanged -= eventHandler;
        this._chVPN_StartWith1Account = value;
        if (this._chVPN_StartWith1Account == null)
          return;
        this._chVPN_StartWith1Account.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox txtVPN_UseRegistered
    {
      get
      {
        return this._txtVPN_UseRegistered;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtVPN_UseRegistered_TextChanged);
        if (this._txtVPN_UseRegistered != null)
          this._txtVPN_UseRegistered.TextChanged -= eventHandler;
        this._txtVPN_UseRegistered = value;
        if (this._txtVPN_UseRegistered == null)
          return;
        this._txtVPN_UseRegistered.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label29
    {
      get
      {
        return this._Label29;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label29 = value;
      }
    }

    internal virtual TextBox txtProxy_AC
    {
      get
      {
        return this._txtProxy_AC;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtProxy_AC_TextChanged);
        if (this._txtProxy_AC != null)
          this._txtProxy_AC.TextChanged -= eventHandler;
        this._txtProxy_AC = value;
        if (this._txtProxy_AC == null)
          return;
        this._txtProxy_AC.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label27
    {
      get
      {
        return this._Label27;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label27 = value;
      }
    }

    internal virtual Label Label28
    {
      get
      {
        return this._Label28;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label28 = value;
      }
    }

    internal virtual RadioButton rbServiceAC_1
    {
      get
      {
        return this._rbServiceAC_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbServiceAC_1_CheckedChanged);
        if (this._rbServiceAC_1 != null)
          this._rbServiceAC_1.CheckedChanged -= eventHandler;
        this._rbServiceAC_1 = value;
        if (this._rbServiceAC_1 == null)
          return;
        this._rbServiceAC_1.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbServiceAC_2
    {
      get
      {
        return this._rbServiceAC_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbServiceAC_2_CheckedChanged);
        if (this._rbServiceAC_2 != null)
          this._rbServiceAC_2.CheckedChanged -= eventHandler;
        this._rbServiceAC_2 = value;
        if (this._rbServiceAC_2 == null)
          return;
        this._rbServiceAC_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox2
    {
      get
      {
        return this._PictureBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox2 = value;
      }
    }

    internal virtual PictureBox PictureBox1
    {
      get
      {
        return this._PictureBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox1 = value;
      }
    }

    internal virtual CheckBox chVPN_HardStop
    {
      get
      {
        return this._chVPN_HardStop;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chVPN_HardStop_CheckedChanged);
        if (this._chVPN_HardStop != null)
          this._chVPN_HardStop.CheckedChanged -= eventHandler;
        this._chVPN_HardStop = value;
        if (this._chVPN_HardStop == null)
          return;
        this._chVPN_HardStop.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox txtHardStop
    {
      get
      {
        return this._txtHardStop;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtHardStop_TextChanged);
        if (this._txtHardStop != null)
          this._txtHardStop.TextChanged -= eventHandler;
        this._txtHardStop = value;
        if (this._txtHardStop == null)
          return;
        this._txtHardStop.TextChanged += eventHandler;
      }
    }

    internal virtual Label lblSocketTimeOut
    {
      get
      {
        return this._lblSocketTimeOut;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblSocketTimeOut = value;
      }
    }

    internal virtual ComboBox cmbConnectMethod
    {
      get
      {
        return this._cmbConnectMethod;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbConnectMethod_SelectedIndexChanged);
        if (this._cmbConnectMethod != null)
          this._cmbConnectMethod.SelectedIndexChanged -= eventHandler;
        this._cmbConnectMethod = value;
        if (this._cmbConnectMethod == null)
          return;
        this._cmbConnectMethod.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label30
    {
      get
      {
        return this._Label30;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label30 = value;
      }
    }

    internal virtual Label lblAutoCaptcha_Supported
    {
      get
      {
        return this._lblAutoCaptcha_Supported;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblAutoCaptcha_Supported = value;
      }
    }

    internal virtual CheckBox chBannedProxy
    {
      get
      {
        return this._chBannedProxy;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chBannedProxy_CheckedChanged);
        if (this._chBannedProxy != null)
          this._chBannedProxy.CheckedChanged -= eventHandler;
        this._chBannedProxy = value;
        if (this._chBannedProxy == null)
          return;
        this._chBannedProxy.CheckedChanged += eventHandler;
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

    internal virtual ComboBox cmbSort_8
    {
      get
      {
        return this._cmbSort_8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbSort_1_SelectedIndexChanged);
        if (this._cmbSort_8 != null)
          this._cmbSort_8.SelectedIndexChanged -= eventHandler;
        this._cmbSort_8 = value;
        if (this._cmbSort_8 == null)
          return;
        this._cmbSort_8.SelectedIndexChanged += eventHandler;
      }
    }

    private void txtOP_1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Strings.InStr("\b12345678", Conversions.ToString(e.KeyChar), CompareMethod.Binary) != 0)
        return;
      e.KeyChar = char.MinValue;
    }

    private void cmbOP_1_SelectedIndexChanged(object sender, EventArgs e)
    {
      object Left = NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
      if (Operators.ConditionalCompareObjectEqual(Left, (object) "rbOP_1", false))
      {
        _INI.SaveINI("Option_Reg", "rbOP_1", Conversions.ToString(this.rbOP_1.Checked));
        if (this.rbOP_1.Checked)
        {
          this.cmbOP_1.Enabled = false;
          this.txtOP_1.Enabled = false;
        }
        else
        {
          this.cmbOP_1.Enabled = true;
          this.txtOP_1.Enabled = true;
        }
        _INI.SaveINI("Option_Reg", "rbOP_2", Conversions.ToString(!this.rbOP_1.Checked));
        _VARIABLES.OP.OpReg.LoginNotFree = !this.rbOP_1.Checked;
      }
      else if (Operators.ConditionalCompareObjectEqual(Left, (object) "rbOP_2", false))
      {
        _INI.SaveINI("Option_Reg", "rbOP_2", Conversions.ToString(this.rbOP_2.Checked));
        _VARIABLES.OP.OpReg.LoginNotFree = this.rbOP_2.Checked;
        if (!_VARIABLES.OP.OpReg.LoginNotFree)
        {
          MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: пропустить";
        }
        else
        {
          switch (_VARIABLES.OP.OpReg.ActionChoise)
          {
            case 0:
              MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: выбрать random";
              break;
            case 1:
              MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: выбрать в том же домене";
              break;
            case 2:
              MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: выбрать №" + Conversions.ToString((int) _VARIABLES.OP.OpReg.NumSelectAccount);
              break;
          }
        }
      }
      else if (Operators.ConditionalCompareObjectEqual(Left, (object) "cmbOP_1", false))
      {
        _INI.SaveINI("Option_Reg", "cmbOP_1", Conversions.ToString(this.cmbOP_1.SelectedIndex));
        if (this.cmbOP_1.SelectedIndex == 2)
          this.txtOP_1.Visible = true;
        else
          this.txtOP_1.Visible = false;
        _VARIABLES.OP.OpReg.ActionChoise = checked ((short) this.cmbOP_1.SelectedIndex);
        if (!_VARIABLES.OP.OpReg.LoginNotFree)
        {
          MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: пропустить";
        }
        else
        {
          switch (_VARIABLES.OP.OpReg.ActionChoise)
          {
            case 0:
              MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: выбрать random";
              break;
            case 1:
              MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: выбрать в том же домене";
              break;
            case 2:
              MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: выбрать №" + Conversions.ToString((int) _VARIABLES.OP.OpReg.NumSelectAccount);
              break;
          }
        }
      }
      else if (Operators.ConditionalCompareObjectEqual(Left, (object) "chOP_1", false))
      {
        _INI.SaveINI("Option_Reg", "chOP_1", Conversions.ToString(this.chOP_1.Checked));
        _VARIABLES.OP.OpReg.Reconnect = this.chOP_1.Checked;
      }
      else if (Operators.ConditionalCompareObjectEqual(Left, (object) "chOP_2", false))
      {
        _INI.SaveINI("Option_Reg", "chOP_2", Conversions.ToString(this.chOP_2.Checked));
        _VARIABLES.OP.OpReg.AutoGenLogin = this.chOP_2.Checked;
      }
      else if (Operators.ConditionalCompareObjectEqual(Left, (object) "chOP_3", false))
      {
        _INI.SaveINI("Option_Reg", "chOP_3", Conversions.ToString(this.chOP_3.Checked));
        _VARIABLES.OP.OpReg.ReconnectUnknownPacket = this.chOP_3.Checked;
      }
      else if (Operators.ConditionalCompareObjectEqual(Left, (object) "txtOP_1", false))
      {
        _INI.SaveINI("Option_Reg", "txtOP_1", this.txtOP_1.Text);
        _VARIABLES.OP.OpReg.NumSelectAccount = checked ((short) Math.Round(Conversion.Val(this.txtOP_1.Text)));
        if (!_VARIABLES.OP.OpReg.LoginNotFree)
        {
          MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: пропустить";
        }
        else
        {
          switch (_VARIABLES.OP.OpReg.ActionChoise)
          {
            case 0:
              MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: выбрать random";
              break;
            case 1:
              MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: выбрать в том же домене";
              break;
            case 2:
              MyProject.Forms.frmMain.lblActionInSelect.Text = "Если занят: выбрать №" + Conversions.ToString((int) _VARIABLES.OP.OpReg.NumSelectAccount);
              break;
          }
        }
      }
      else
      {
        if (!Operators.ConditionalCompareObjectEqual(Left, (object) "txtOP_2", false))
          return;
        _INI.SaveINI("Option_Reg", "txtOP_2", this.txtOP_2.Text);
        _VARIABLES.OP.OpReg.ReconnectPause = checked ((int) Math.Round(Conversion.Val(this.txtOP_2.Text)));
      }
    }

    private void frmOptions_HandleDestroyed(object sender, EventArgs e)
    {
      if (Conversion.Val(this.txtOP_1.Text) != 0.0)
        return;
      this.txtOP_1.Text = Conversions.ToString(1);
    }

    private void txtAutoCaptchaKEY_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_AC", "txtAutoCaptchaKEY", this.txtAutoCaptchaKEY.Text);
      _VARIABLES.OP.OpAC.Key = this.txtAutoCaptchaKEY.Text;
    }

    private void txtAutoCaptchaURL_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_AC", "txtAutoCaptchaURL", this.txtAutoCaptchaURL.Text);
      _VARIABLES.OP.OpAC.HostOrIP = this.txtAutoCaptchaURL.Text;
      if (string.IsNullOrEmpty(_VARIABLES.OP.OpAC.HostOrIP))
      {
        this.lblAutoCaptcha_Supported.ForeColor = Color.Red;
        this.lblAutoCaptcha_Supported.Text = "Service: not specified";
      }
      else
      {
        string host = new UriBuilder(_VARIABLES.OP.OpAC.HostOrIP).Host;
        string str1 = "Service: ";
        string lower = host.ToLower();
        string str2;
        if (Operators.CompareString(lower, "antigate.com", false) == 0 || Operators.CompareString(lower, "captchabot.com", false) == 0 || (Operators.CompareString(lower, "api.dbcapi.me", false) == 0 || Operators.CompareString(lower, "109.206.172.194", false) == 0))
        {
          str2 = str1 + "supported";
          this.lblAutoCaptcha_Supported.ForeColor = Color.Green;
        }
        else
        {
          str2 = str1 + "unknown";
          this.lblAutoCaptcha_Supported.ForeColor = Color.Red;
        }
        this.lblAutoCaptcha_Supported.Text = str2;
      }
    }

    private void chOpAC_2_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_AC", "chOpAC_2", Conversions.ToString(this.chOpAC_2.Checked));
      _VARIABLES.OP.OpAC.ReportBadCaptcha = this.chOpAC_2.Checked;
    }

    private void chOpAC_3_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void chOpMailDownload_1_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_MailDownload", "chOpMailDownload_1", Conversions.ToString(this.chOpMailDownload_1.Checked));
      _VARIABLES.OP.OptMail.DeleteMail = this.chOpMailDownload_1.Checked;
    }

    private void cmbOpMailDownload_1_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_MailDownload", "cmbOpMailDownload_1", Conversions.ToString(this.cmbOpMailDownload_1.SelectedIndex));
      _VARIABLES.OP.OptMail.SaveMailOneFile = this.cmbOpMailDownload_1.SelectedIndex;
    }

    private void chOpMailDownload_2_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_MailDownload", "chOpMailDownload_2", Conversions.ToString(this.chOpMailDownload_2.Checked));
      _VARIABLES.OP.OptMail.AppendMail = this.chOpMailDownload_2.Checked;
    }

    private void txtOPSaveList_1_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_SaveList", "txtOPSaveList_1", this.txtOPSaveList_1.Text);
      _VARIABLES.OP.OpSaveList.SeparatorInLine = this.txtOPSaveList_1.Text;
    }

    private void cmbOPSaveList_1_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_SaveList", "cmbOPSaveList_1", Conversions.ToString(this.cmbOPSaveList_1.SelectedIndex));
      switch (this.cmbOPSaveList_1.SelectedIndex)
      {
        case 0:
          _VARIABLES.OP.OpSaveList.SeparatorLine = "\r\n";
          break;
        case 1:
          _VARIABLES.OP.OpSaveList.SeparatorLine = "\n";
          break;
      }
    }

    private void cmbOPSaveList_2_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_SaveList", "cmbOPSaveList_2", Conversions.ToString(this.cmbOPSaveList_2.SelectedIndex));
      _VARIABLES.OP.OpSaveList.SaveToAll = this.cmbOPSaveList_2.SelectedIndex;
    }

    private void chOPSaveList_4_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_SaveList", "chOPSaveList_4", Conversions.ToString(this.chOPSaveList_4.Checked));
      _VARIABLES.OP.OpSaveList.AppendFile = this.chOPSaveList_4.Checked;
    }

    private void chOPSaveList_1_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_SaveList", "chOPSaveList_1", Conversions.ToString(this.chOPSaveList_1.Checked));
      _VARIABLES.OP.OpSaveList.SaveDomain = this.chOPSaveList_1.Checked;
    }

    private void chOPSaveList_2_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_SaveList", "chOPSaveList_2", Conversions.ToString(this.chOPSaveList_2.Checked));
      _VARIABLES.OP.OpSaveList.SaveSecretAnswer = this.chOPSaveList_2.Checked;
    }

    private void chOPSaveList_3_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_SaveList", "chOPSaveList_3", Conversions.ToString(this.chOPSaveList_3.Checked));
      _VARIABLES.OP.OpSaveList.SaveLastnameName = this.chOPSaveList_3.Checked;
    }

    private void chOP_3_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void chUseErrorCount_CheckedChanged(object sender, EventArgs e)
    {
      _VARIABLES.UseErrorCount = this.chUseErrorCount.Checked;
      _INI.SaveINI("Options", "chUseErrorCount", Conversions.ToString(_VARIABLES.UseErrorCount));
    }

    private void txtErrorCount_TextChanged(object sender, EventArgs e)
    {
      _VARIABLES.ErrorCount = checked ((int) Math.Round(Conversion.Val(this.txtErrorCount.Text)));
      _INI.SaveINI("Options", "txtErrorCount", Conversions.ToString(_VARIABLES.ErrorCount));
    }

    private void chdebugOp_SaveBadCaptcha_CheckedChanged(object sender, EventArgs e)
    {
      _VARIABLES.DebugOp.FullDebug = this.chdebugOp_SaveBadCaptcha.Checked;
      _INI.SaveINI("Options.Debug", "FullDebug", Conversions.ToString(_VARIABLES.DebugOp.FullDebug));
      if (!_VARIABLES.DebugOp.FullDebug)
        return;
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Debug: Полная отладка Socket - включена!";
      fn.TXT(ref sText);
    }

    private void chSavePacket_RegError_CheckedChanged(object sender, EventArgs e)
    {
      _VARIABLES.DebugOp.SavePacket_RegError = this.chSavePacket_RegError.Checked;
    }

    private void chSaveLog_CheckedChanged(object sender, EventArgs e)
    {
      _VARIABLES.DebugOp.SaveLog = this.chSaveLog.Checked;
      _INI.SaveINI("Options.Debug", "SaveLog", Conversions.ToString(_VARIABLES.DebugOp.SaveLog));
      if (!_VARIABLES.DebugOp.SaveLog)
        return;
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Debug: Лог включен!";
      fn.TXT(ref sText);
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("HttpLoadProxy", "chHttpLoadProxy_UseRegEx", Conversions.ToString(this.chHttpLoadProxy_UseRegEx.Checked));
      md_HttpLoadProxy.HttpLoadProxy.RegEx_Use = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
    }

    private void _CheckedChanged(object sender, EventArgs e)
    {
      md_HttpLoadProxy.HttpLoadProxy.Use = this.chHttpLoadProxy.Checked;
      this.boxHttpLoadProxy.Enabled = md_HttpLoadProxy.HttpLoadProxy.Use;
      this.chHttpLoadProxy.Enabled = true;
      _INI.SaveINI("HttpLoadProxy", "chHttpLoadProxy", Conversions.ToString(this.chHttpLoadProxy.Checked));
      if (md_HttpLoadProxy.HttpLoadProxy.Use)
        return;
      this.chHttpLoadProxy_UseRegEx.Checked = false;
      this.chHttpLoadProxy_LoadInStart.Checked = false;
      this.chHttpLoadProxy_Append.Checked = false;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      _LOADSAVE.Load_HttpLoadProxy();
    }

    private void btnOpenProxy_Click(object sender, EventArgs e)
    {
      string path = Application.StartupPath + "\\data\\HttpLoadProxy_URL.txt";
      if (!File.Exists(path))
      {
        File.Create(path);
      }
      else
      {
        try
        {
          new Process() { StartInfo = { FileName = path } }.Start();
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Для принятия изменений, нажмите кнопку 'Обновить список'.";
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

    private void chHttpLoadProxy_LoadInStart_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("HttpLoadProxy", "chHttpLoadProxy_LoadInStart", Conversions.ToString(this.chHttpLoadProxy_LoadInStart.Checked));
      md_HttpLoadProxy.HttpLoadProxy.LoadInStart = this.chHttpLoadProxy_LoadInStart.Checked;
    }

    private void chHttpLoadProxy_Append_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("HttpLoadProxy", "chHttpLoadProxy_Append", Conversions.ToString(this.chHttpLoadProxy_Append.Checked));
      md_HttpLoadProxy.HttpLoadProxy.Append = this.chHttpLoadProxy_Append.Checked;
    }

    private void txtHttpLoadProxy_RegEx_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("HttpLoadProxy", "txtHttpLoadProxy_RegEx", this.txtHttpLoadProxy_RegEx.Text);
      md_HttpLoadProxy.HttpLoadProxy.RegEx_Text = this.txtHttpLoadProxy_RegEx.Text;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      md_HttpLoadProxy.Start_HttpLoadProxy();
    }

    private void chAfterLoadStartOne_CheckedChanged_1(object sender, EventArgs e)
    {
      _INI.SaveINI("HttpLoadProxy", "chAfterLoadStartOne", Conversions.ToString(this.chAfterLoadStartOne.Checked));
      md_HttpLoadProxy.HttpLoadProxy.AfterLoadStartOne = this.chAfterLoadStartOne.Checked;
    }

    private void Button3_Click(object sender, EventArgs e)
    {
    }

    private void chNetWorkReboot_CheckedChanged(object sender, EventArgs e)
    {
      md_NetworkReboot.NetworkReboot.Use = this.chNetWorkReboot.Checked;
      this.chNetWorkReboot.Refresh();
      Application.DoEvents();
      if (md_NetworkReboot.NetworkReboot.Use)
      {
        this.boxNetworkReboot.Enabled = true;
        this.cmbNetworkReboot_Filtr.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("NetworkReboot", "cmbNetworkReboot_Filtr"))));
        this.cmbNetworkReboot_Method.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("NetworkReboot", "cmbNetworkReboot_Method"))));
        if (Operators.CompareString(_INI.LoadINI("NetworkReboot", "chNetworkReboot_MacChange").ToLower(), "true", false) == 0)
          this.chNetworkReboot_MacChange.Checked = true;
      }
      else
        this.boxNetworkReboot.Enabled = false;
      _INI.SaveINI("NetworkReboot", "chNetWorkReboot", Conversions.ToString(this.chNetWorkReboot.Checked));
    }

    private void cmbNetworkReboot_Filtr_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapter" + (this.cmbNetworkReboot_Filtr.SelectedIndex != 4 ? " where " + this.cmbNetworkReboot_Filtr.Text : ""));
        int index = 0;
        this.cmbNetworkReboot_Adapter.Items.Clear();
        ManagementObjectCollection.ManagementObjectEnumerator enumerator;
        try
        {
          enumerator = managementObjectSearcher.Get().GetEnumerator();
          while (enumerator.MoveNext())
          {
            ManagementObject current = (ManagementObject) enumerator.Current;
            checked { ++index; }
            md_NetworkReboot.NetworkReboot.NetworkAdapter = (md_NetworkReboot.myNetworkAdapter[]) Utils.CopyArray((Array) md_NetworkReboot.NetworkReboot.NetworkAdapter, (Array) new md_NetworkReboot.myNetworkAdapter[checked (index + 1)]);
            md_NetworkReboot.NetworkReboot.NetworkAdapter[index].DeviceID = Conversions.ToShort(current["DeviceID"]);
            md_NetworkReboot.NetworkReboot.NetworkAdapter[index].NetConnectionStatus = Conversions.ToShort(current["NetConnectionStatus"]);
            md_NetworkReboot.NetworkReboot.NetworkAdapter[index].NetConnectionID = Conversions.ToString(current["NetConnectionID"]);
            md_NetworkReboot.NetworkReboot.NetworkAdapter[index].Name = Conversions.ToString(current["Name"]);
            md_NetworkReboot.NetworkReboot.NetworkAdapter[index].MACAddress = Conversions.ToString(current["MACAddress"]);
            this.cmbNetworkReboot_Adapter.Items.Add((object) md_NetworkReboot.NetworkReboot.NetworkAdapter[index].Name);
          }
        }
        finally
        {
          if (enumerator != null)
            enumerator.Dispose();
        }
        int num = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("NetworkReboot", "cmbNetworkReboot_Adapter"))));
        if (num > checked (this.cmbNetworkReboot_Adapter.Items.Count - 1))
          num = checked (this.cmbNetworkReboot_Adapter.Items.Count - 1);
        this.cmbNetworkReboot_Adapter.SelectedIndex = num;
        _INI.SaveINI("NetworkReboot", "cmbNetworkReboot_Filtr", Conversions.ToString(this.cmbNetworkReboot_Filtr.SelectedIndex));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        string sText = "Произошла ошибка при инициализации WMI!";
        fn1.TXT(ref sText);
        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
        sText = "Обратитесь в техподдержку.";
        fn2.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    private void cmbNetworkReboot_Adapter_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("NetworkReboot", "cmbNetworkReboot_Adapter", Conversions.ToString(this.cmbNetworkReboot_Adapter.SelectedIndex));
      md_NetworkReboot.NetworkReboot.NumAdapter = checked (this.cmbNetworkReboot_Adapter.SelectedIndex + 1);
      this.lblNetworkReboot_NetConnectionID.Text = !Information.IsNothing((object) md_NetworkReboot.NetworkReboot.NetworkAdapter[md_NetworkReboot.NetworkReboot.NumAdapter].NetConnectionID) ? md_NetworkReboot.NetworkReboot.NetworkAdapter[md_NetworkReboot.NetworkReboot.NumAdapter].NetConnectionID : "n/a";
      this.lblNetworkReboot_MAC.Text = !Information.IsNothing((object) md_NetworkReboot.NetworkReboot.NetworkAdapter[md_NetworkReboot.NetworkReboot.NumAdapter].MACAddress) ? md_NetworkReboot.NetworkReboot.NetworkAdapter[md_NetworkReboot.NetworkReboot.NumAdapter].MACAddress : "Not Present";
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      md_NetworkReboot.RebootNetworkAdapter();
    }

    private void cmbNetworkReboot_Method_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("NetworkReboot", "cmbNetworkReboot_Method", Conversions.ToString(this.cmbNetworkReboot_Method.SelectedIndex));
      md_NetworkReboot.NetworkReboot.MethodReboot = this.cmbNetworkReboot_Method.SelectedIndex;
    }

    private void cmbOpAC_1_SelectedIndexChanged(object sender, EventArgs e)
    {
      _VARIABLES.OptionsAntigateProg.phrase = Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      _INI.SaveINI("OptionsAntigateProg", "phrase", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
    }

    private void cmbOpAC_2_SelectedIndexChanged(object sender, EventArgs e)
    {
      _VARIABLES.OptionsAntigateProg.regsense = Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      _INI.SaveINI("OptionsAntigateProg", "regsense", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
    }

    private void cmbOpAC_3_SelectedIndexChanged(object sender, EventArgs e)
    {
      _VARIABLES.OptionsAntigateProg.numeric = Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      _INI.SaveINI("OptionsAntigateProg", "numeric", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
    }

    private void cmbOpAC_4_SelectedIndexChanged(object sender, EventArgs e)
    {
      _VARIABLES.OptionsAntigateProg.calc = Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      _INI.SaveINI("OptionsAntigateProg", "calc", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
    }

    private void cmbOpAC_5_SelectedIndexChanged(object sender, EventArgs e)
    {
      _VARIABLES.OptionsAntigateProg.min_len = Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      _INI.SaveINI("OptionsAntigateProg", "min_len", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
    }

    private void cmbOpAC_6_SelectedIndexChanged(object sender, EventArgs e)
    {
      _VARIABLES.OptionsAntigateProg.max_len = Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      _INI.SaveINI("OptionsAntigateProg", "max_len", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
    }

    private void cmbOpAC_7_SelectedIndexChanged(object sender, EventArgs e)
    {
      _VARIABLES.OptionsAntigateProg.is_russian = Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      _INI.SaveINI("OptionsAntigateProg", "is_russian", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
    }

    private void txtOpAC_1_TextChanged(object sender, EventArgs e)
    {
      _VARIABLES.OP.OpAC.PauseGetBalance = checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))));
      _INI.SaveINI("OP.OpAC", "txtOpAC_1", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (_VARIABLES.OP.OpAC.PauseGetBalance > 0 & _VARIABLES.OP.OpAC.PauseGetBalance < 60000)
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.OrangeRed
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.WhiteSmoke
        }, (string[]) null, (Type[]) null);
    }

    private void txtOpAC_2_TextChanged(object sender, EventArgs e)
    {
      _VARIABLES.OP.OpAC.PauseNoSlot = checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))));
      _INI.SaveINI("OP.OpAC", "txtOpAC_2", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (_VARIABLES.OP.OpAC.PauseNoSlot < 20000)
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.OrangeRed
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.WhiteSmoke
        }, (string[]) null, (Type[]) null);
    }

    private void txtOpAC_3_TextChanged(object sender, EventArgs e)
    {
      _VARIABLES.OP.OpAC.PauseAfterSending = checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))));
      _INI.SaveINI("OP.OpAC", "txtOpAC_3", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (_VARIABLES.OP.OpAC.PauseAfterSending < 10000)
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.OrangeRed
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.WhiteSmoke
        }, (string[]) null, (Type[]) null);
    }

    private void txtOpAC_4_TextChanged(object sender, EventArgs e)
    {
      _VARIABLES.OP.OpAC.NextGetCaptcha = checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))));
      _INI.SaveINI("OP.OpAC", "txtOpAC_4", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (_VARIABLES.OP.OpAC.NextGetCaptcha < 5000)
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.OrangeRed
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.WhiteSmoke
        }, (string[]) null, (Type[]) null);
    }

    private void txtOpAC_5_TextChanged(object sender, EventArgs e)
    {
      _VARIABLES.OP.OpAC.TimeLimit = checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))));
      _INI.SaveINI("OP.OpAC", "txtOpAC_5", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (_VARIABLES.OP.OpAC.TimeLimit < 60000)
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.OrangeRed
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.WhiteSmoke
        }, (string[]) null, (Type[]) null);
    }

    private void txtOpAC_6_TextChanged(object sender, EventArgs e)
    {
      _VARIABLES.OP.OpAC.PauseError = checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))));
      _INI.SaveINI("OP.OpAC", "txtOpAC_6", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (_VARIABLES.OP.OpAC.PauseError < 10000)
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.OrangeRed
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.WhiteSmoke
        }, (string[]) null, (Type[]) null);
    }

    private void txtOpAC_7_TextChanged(object sender, EventArgs e)
    {
      _VARIABLES.OP.OpAC.SocketTimeOut = checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))));
      _INI.SaveINI("OP.OpAC", "txtOpAC_7", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (_VARIABLES.OP.OpAC.SocketTimeOut < 20000)
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.OrangeRed
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.WhiteSmoke
        }, (string[]) null, (Type[]) null);
    }

    internal void btnAC_Default_Click(object sender, EventArgs e)
    {
      this.chOpAC_2.Checked = true;
      this.cmbOpAC_1.SelectedIndex = 0;
      this.cmbOpAC_2.SelectedIndex = 0;
      this.cmbOpAC_3.SelectedIndex = 0;
      this.cmbOpAC_4.SelectedIndex = 0;
      this.cmbOpAC_5.SelectedIndex = 0;
      this.cmbOpAC_6.SelectedIndex = 0;
      this.cmbOpAC_7.SelectedIndex = 0;
      this.txtOpAC_1.Text = "300000";
      this.txtOpAC_2.Text = "30000";
      this.txtOpAC_3.Text = "10000";
      this.txtOpAC_4.Text = "5000";
      this.txtOpAC_5.Text = "90000";
      this.txtOpAC_6.Text = "30000";
      this.txtOpAC_7.Text = "60000";
    }

    private void btnPlaySound_1_Click(object sender, EventArgs e)
    {
      Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null))]);
    }

    private void chPlaySound_CheckedChanged(object sender, EventArgs e)
    {
      _VARIABLES.PlaySound.Use = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.boxPlaySound.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      if (_VARIABLES.PlaySound.Use)
      {
        _VARIABLES.PlaySound.Path = new string[7];
        _VARIABLES.PlaySound.Play = new bool[7];
        _VARIABLES.PlaySound.Path[1] = Application.StartupPath + this.txtPlaySound_1.Text;
        _VARIABLES.PlaySound.Path[2] = Application.StartupPath + this.txtPlaySound_2.Text;
        _VARIABLES.PlaySound.Path[3] = Application.StartupPath + this.txtPlaySound_3.Text;
        _VARIABLES.PlaySound.Path[4] = Application.StartupPath + this.txtPlaySound_4.Text;
        _VARIABLES.PlaySound.Path[5] = Application.StartupPath + this.txtPlaySound_5.Text;
        _VARIABLES.PlaySound.Path[6] = Application.StartupPath + this.txtPlaySound_6.Text;
        if (!File.Exists(_VARIABLES.PlaySound.Path[1]) || !File.Exists(_VARIABLES.PlaySound.Path[1]) || (!File.Exists(_VARIABLES.PlaySound.Path[1]) || !File.Exists(_VARIABLES.PlaySound.Path[1])) || (!File.Exists(_VARIABLES.PlaySound.Path[1]) || !File.Exists(_VARIABLES.PlaySound.Path[1])))
        {
          int num = (int) Interaction.MsgBox((object) "При обновлении программы, Вы скачали только исполняемый файл. \r\nДля работы звуковой схемы, следует обновить полностью каталог программы.", MsgBoxStyle.Critical, (object) "Ошибка");
          this.chPlaySound.Checked = false;
        }
        if (Operators.CompareString(_INI.LoadINI("PlaySound", "chPlaySound_1").ToLower(), "true", false) == 0)
          this.chPlaySound_1.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("PlaySound", "chPlaySound_2").ToLower(), "true", false) == 0)
          this.chPlaySound_2.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("PlaySound", "chPlaySound_3").ToLower(), "true", false) == 0)
          this.chPlaySound_3.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("PlaySound", "chPlaySound_4").ToLower(), "true", false) == 0)
          this.chPlaySound_4.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("PlaySound", "chPlaySound_5").ToLower(), "true", false) == 0)
          this.chPlaySound_5.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("PlaySound", "chPlaySound_6").ToLower(), "true", false) == 0)
          this.chPlaySound_6.Checked = true;
      }
      _INI.SaveINI("PlaySound", "chPlaySound", Conversions.ToString(this.chPlaySound.Checked));
    }

    private void chPlaySound_1_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("PlaySound", Conversions.ToString(Operators.ConcatenateObject((object) "chPlaySound_", NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null))), Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      _VARIABLES.PlaySound.Play[Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null))] = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
    }

    private void chNetworkReboot_MacChange_CheckedChanged(object sender, EventArgs e)
    {
      md_NetworkReboot.NetworkReboot.ChangeMAC = this.chNetworkReboot_MacChange.Checked;
      _INI.SaveINI("NetworkReboot", "chNetworkReboot_MacChange", Conversions.ToString(this.chNetworkReboot_MacChange.Checked));
    }

    private void chVPN_CheckedChanged(object sender, EventArgs e)
    {
      _VARIABLES.VPN_MD.Use = this.chVPN.Checked;
      _INI.SaveINI("VPN", "chVPN", Conversions.ToString(this.chVPN.Checked));
      if (this.chVPN.Checked)
      {
        this.boxVPN.Enabled = true;
        if (Operators.CompareString(_INI.LoadINI("VPN", "chVPN_UseReg").ToLower(), "true", false) == 0)
          this.chVPN_UseReg.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("VPN", "chVPN_UseDownloadMail").ToLower(), "true", false) == 0)
          this.chVPN_UseDownloadMail.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("VPN", "chVPN_StartWith1Account").ToLower(), "true", false) == 0)
          this.chVPN_StartWith1Account.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("VPN", "chVPN_HardStop").ToLower(), "true", false) == 0)
          this.chVPN_HardStop.Checked = true;
        MyProject.Forms.frmMain_RasDialex.Show();
        MyProject.Forms.frmMain_RasDialex.WindowState = FormWindowState.Normal;
        MyProject.Forms.frmMain_RasDialex.Enabled = true;
      }
      else
      {
        this.boxVPN.Enabled = false;
        MyProject.Forms.frmMain_RasDialex.Close();
      }
    }

    private void chVPN_UseReg_CheckedChanged(object sender, EventArgs e)
    {
      _VARIABLES.VPN_MD.UseReg = this.chVPN_UseReg.Checked;
      _INI.SaveINI("VPN", "chVPN_UseReg", Conversions.ToString(this.chVPN_UseReg.Checked));
      if (this.chVPN_UseReg.Checked)
      {
        this.txtVPN_UseRegistered.Enabled = true;
        this.txtVPN_UseRegistered.Text = Conversions.ToString(Conversion.Val(_INI.LoadINI("VPN", "txtVPN_UseRegistered")));
      }
      else
        this.txtVPN_UseRegistered.Enabled = false;
    }

    private void chVPN_UseDownloadMail_CheckedChanged(object sender, EventArgs e)
    {
      _VARIABLES.VPN_MD.UseDownloadMail = this.chVPN_UseDownloadMail.Checked;
      _INI.SaveINI("VPN", "chVPN_UseDownloadMail", Conversions.ToString(this.chVPN_UseDownloadMail.Checked));
      if (this.chVPN_UseDownloadMail.Checked)
      {
        this.txtVPN_UseDownloadMail.Enabled = true;
        this.txtVPN_UseDownloadMail.Text = Conversions.ToString(Conversion.Val(_INI.LoadINI("VPN", "txtVPN_UseDownloadMail")));
      }
      else
        this.txtVPN_UseDownloadMail.Enabled = false;
    }

    private void txtVPN_UseDownloadMail_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("VPN", "txtVPN_UseDownloadMail", this.txtVPN_UseDownloadMail.Text);
      _VARIABLES.VPN_MD.DownloadMailCount = checked ((int) Math.Round(Conversion.Val(this.txtVPN_UseDownloadMail.Text)));
      if (_VARIABLES.VPN_MD.DownloadMailCount == 0 | _VARIABLES.VPN_MD.DownloadMailCount > 1000)
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.OrangeRed
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.WhiteSmoke
        }, (string[]) null, (Type[]) null);
    }

    private void cmbSort_1_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("OptionSort", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "SelectedIndex", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked ((double) checked ((int) Math.Round(unchecked (0.0 + Math.Pow(2.0, (double) this.cmbSort_1.SelectedIndex)))) + Math.Pow(2.0, (double) this.cmbSort_2.SelectedIndex)))) + Math.Pow(2.0, (double) this.cmbSort_3.SelectedIndex)))) + Math.Pow(2.0, (double) this.cmbSort_4.SelectedIndex)))) + Math.Pow(2.0, (double) this.cmbSort_5.SelectedIndex)))) + Math.Pow(2.0, (double) this.cmbSort_6.SelectedIndex)))) + Math.Pow(2.0, (double) this.cmbSort_7.SelectedIndex)))) + Math.Pow(2.0, (double) this.cmbSort_8.SelectedIndex)))) == 510)
      {
        this.picSort_OK.Visible = true;
        this.picSort_BAD.Visible = false;
      }
      else
      {
        this.picSort_OK.Visible = false;
        this.picSort_BAD.Visible = true;
      }
    }

    internal void btnOpSort_Default_Click(object sender, EventArgs e)
    {
      this.cmbSort_1.SelectedIndex = 5;
      this.cmbSort_2.SelectedIndex = 4;
      this.cmbSort_3.SelectedIndex = 3;
      this.cmbSort_4.SelectedIndex = 7;
      this.cmbSort_5.SelectedIndex = 6;
      this.cmbSort_6.SelectedIndex = 2;
      this.cmbSort_7.SelectedIndex = 1;
      this.cmbSort_8.SelectedIndex = 8;
    }

    private void txtVPN_UseRegistered_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("VPN", "txtVPN_UseRegistered", this.txtVPN_UseRegistered.Text);
      _VARIABLES.VPN_MD.RegisteredCount = checked ((int) Math.Round(Conversion.Val(this.txtVPN_UseRegistered.Text)));
      if (_VARIABLES.VPN_MD.RegisteredCount == 0 | _VARIABLES.VPN_MD.RegisteredCount > 10)
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.OrangeRed
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.WhiteSmoke
        }, (string[]) null, (Type[]) null);
    }

    private void chVPN_StartWith1Account_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("VPN", "chVPN_StartWith1Account", Conversions.ToString(this.chVPN_StartWith1Account.Checked));
      _VARIABLES.VPN_MD.StartWith1Account = this.chVPN_StartWith1Account.Checked;
    }

    private void rbSortMethod_1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void txtProxy_AC_TextChanged(object sender, EventArgs e)
    {
      _VARIABLES.Proxy_AC = this.txtProxy_AC.Text;
      _INI.SaveINI(nameof (frmOptions), "txtProxy_AC", this.txtProxy_AC.Text);
    }

    private void txtIntervalConnect_TextChanged(object sender, EventArgs e)
    {
      _VARIABLES.IntervalConnect = checked ((int) Math.Round(Conversion.Val(this.txtIntervalConnect.Text)));
      if (_VARIABLES.IntervalConnect < 33)
        _VARIABLES.IntervalConnect = 33;
      _INI.SaveINI(nameof (frmOptions), "txtIntervalConnect", this.txtIntervalConnect.Text);
    }

    private void rbServiceAC_1_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_AC", "selService", Conversions.ToString(0));
      _VARIABLES.OP.OpAC.HostOrIP = "109.206.172.194";
    }

    private void rbServiceAC_2_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_AC", "selService", Conversions.ToString(1));
      _VARIABLES.OP.OpAC.HostOrIP = "captchabot.com";
    }

    private void chVPN_HardStop_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("VPN", "chVPN_HardStop", Conversions.ToString(this.chVPN_HardStop.Checked));
      if (this.chVPN_UseReg.Checked)
      {
        this.txtHardStop.Enabled = true;
        this.txtHardStop.Text = Conversions.ToString(Conversion.Val(_INI.LoadINI("VPN", "txtHardStop")));
      }
      else
        this.txtHardStop.Enabled = false;
    }

    private void txtHardStop_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("VPN", "txtHardStop", this.txtHardStop.Text);
      if (Conversion.Val(this.txtHardStop.Text) < 60000.0)
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.OrangeRed
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.WhiteSmoke
        }, (string[]) null, (Type[]) null);
    }

    private void txtSocketTimeOut_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_Reg", "txtSocketTimeOut", this.txtSocketTimeOut.Text);
      _VARIABLES.OP.SocketTimeOut = checked ((int) Math.Round(Conversion.Val(this.txtSocketTimeOut.Text)));
      if (_VARIABLES.OP.SocketTimeOut < 5000 | _VARIABLES.OP.SocketTimeOut > 120000)
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.OrangeRed
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.White
        }, (string[]) null, (Type[]) null);
    }

    private void cmbConnectMethod_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_Reg", "cmbConnectMethod", Conversions.ToString(this.cmbConnectMethod.SelectedIndex));
      _VARIABLES.OP.MethodConnect = this.cmbConnectMethod.SelectedIndex;
    }

    private void chdebugOp_SaveBadIP_CheckedChanged(object sender, EventArgs e)
    {
      _VARIABLES.DebugOp.SaveBadIP = this.chdebugOp_SaveBadIP.Checked;
      _INI.SaveINI("Options.Debug", "SaveBadIP", Conversions.ToString(_VARIABLES.DebugOp.SaveBadIP));
      if (!_VARIABLES.DebugOp.SaveBadIP)
        return;
      _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
      string sText1 = "Debug: Включено сохранение в лог всех прокси, при 'Lost Captcha'";
      fn1.TXT(ref sText1);
      _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
      string sText2 = "Debug: при Captcha '000000000' в файл BadIP_000000000.log";
      fn2.TXT(ref sText2);
      _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
      string sText3 = "Debug: при Lost Captcha в файл BadIP_LostCaptcha.log";
      fn3.TXT(ref sText3);
    }

    private void chdebugOp_FullSessionLog_CheckedChanged(object sender, EventArgs e)
    {
      _VARIABLES.DebugOp.FullSessionLog = this.chdebugOp_FullSessionLog.Checked;
      _INI.SaveINI("Options.Debug", "FullSessionLog", Conversions.ToString(_VARIABLES.DebugOp.FullSessionLog));
      if (!_VARIABLES.DebugOp.FullSessionLog)
        return;
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Debug: Полный лог сессии включен.";
      fn.TXT(ref sText);
    }

    private void chBannedProxy_CheckedChanged(object sender, EventArgs e)
    {
      _VARIABLES.UseBannedProxy = this.chBannedProxy.Checked;
      _INI.SaveINI(nameof (frmOptions), "chBannedProxy", Conversions.ToString(this.chBannedProxy.Checked));
    }

    private void btnSQL_Click(object sender, EventArgs e)
    {
      MyProject.Forms.frmSQL.Show();
    }

    private void frmOptions_Load(object sender, EventArgs e)
    {
    }
  }
}
