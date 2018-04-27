// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.frmMain_RasDialex
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [DesignerGenerated]
  public class frmMain_RasDialex : Form
  {
    private IContainer components;
    [AccessedThroughProperty("txtMon")]
    private TextBox _txtMon;
    [AccessedThroughProperty("Timer1")]
    private System.Windows.Forms.Timer _Timer1;
    [AccessedThroughProperty("btnConnect")]
    private Button _btnConnect;
    [AccessedThroughProperty("btnClose")]
    private Button _btnClose;
    [AccessedThroughProperty("Button9")]
    private Button _Button9;
    [AccessedThroughProperty("lblMon")]
    private Label _lblMon;
    [AccessedThroughProperty("lblIP")]
    private Label _lblIP;
    [AccessedThroughProperty("chReconnect")]
    private CheckBox _chReconnect;
    [AccessedThroughProperty("lblIP_OLD")]
    private Label _lblIP_OLD;
    [AccessedThroughProperty("chTimeReconnect")]
    private CheckBox _chTimeReconnect;
    [AccessedThroughProperty("txtTimeReconnect")]
    private TextBox _txtTimeReconnect;
    [AccessedThroughProperty("tmrTimeReconnect")]
    private System.Windows.Forms.Timer _tmrTimeReconnect;
    [AccessedThroughProperty("box1")]
    private GroupBox _box1;
    [AccessedThroughProperty("txtEntryName")]
    private TextBox _txtEntryName;
    [AccessedThroughProperty("box2")]
    private GroupBox _box2;
    [AccessedThroughProperty("txtPhoneNumber")]
    private TextBox _txtPhoneNumber;
    [AccessedThroughProperty("box3")]
    private GroupBox _box3;
    [AccessedThroughProperty("txtUserName")]
    private TextBox _txtUserName;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("txtPassword")]
    private TextBox _txtPassword;
    [AccessedThroughProperty("cmbPhoneNumber")]
    private ComboBox _cmbPhoneNumber;
    [AccessedThroughProperty("tmrSleep")]
    private System.Windows.Forms.Timer _tmrSleep;
    [AccessedThroughProperty("lbl1")]
    private Label _lbl1;
    [AccessedThroughProperty("cmbMethod")]
    private ComboBox _cmbMethod;
    [AccessedThroughProperty("chGetIP")]
    private CheckBox _chGetIP;
    [AccessedThroughProperty("txtWaitAfterConnect")]
    private TextBox _txtWaitAfterConnect;
    [AccessedThroughProperty("lbl2")]
    private Label _lbl2;
    [AccessedThroughProperty("chOnlyMisc")]
    private CheckBox _chOnlyMisc;
    [AccessedThroughProperty("picVPN_Reboot")]
    private PictureBox _picVPN_Reboot;
    [AccessedThroughProperty("txtExternalProgram")]
    private TextBox _txtExternalProgram;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("boxExternalProgram")]
    private GroupBox _boxExternalProgram;
    [AccessedThroughProperty("txtIntervalReCnt")]
    private TextBox _txtIntervalReCnt;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("txtExternalProgram_ParamConnect")]
    private TextBox _txtExternalProgram_ParamConnect;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("txtExternalProgram_ParamDisconnect")]
    private TextBox _txtExternalProgram_ParamDisconnect;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("chVisibleCMD")]
    private CheckBox _chVisibleCMD;
    [AccessedThroughProperty("txtWaitConnected")]
    private TextBox _txtWaitConnected;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    public RasDialUC RAS;
    public bool AutoConnectRasDial;
    public int WaitAfterConnect;
    public int IntervalReCnt;
    public bool VisibleCMD;
    public string ExternalProgram;
    public string ExternalProgram_ParamDisconnect;
    public string ExternalProgram_ParamConnect;
    public const long EVENT_MODIFY_STATE = 2;
    private System.Timers.Timer tmrDoConnect;

    public frmMain_RasDialex()
    {
      this.FormClosing += new FormClosingEventHandler(this.frmMain_RasDialex_FormClosing);
      this.Load += new EventHandler(this.frmMain_RasDialex_Load);
      this.AutoConnectRasDial = false;
      this.VisibleCMD = false;
      this.ExternalProgram = string.Empty;
      this.ExternalProgram_ParamDisconnect = string.Empty;
      this.ExternalProgram_ParamConnect = string.Empty;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMain_RasDialex));
      this.txtMon = new TextBox();
      this.Timer1 = new System.Windows.Forms.Timer(this.components);
      this.btnConnect = new Button();
      this.btnClose = new Button();
      this.Button9 = new Button();
      this.lblMon = new Label();
      this.lblIP = new Label();
      this.chReconnect = new CheckBox();
      this.lblIP_OLD = new Label();
      this.chTimeReconnect = new CheckBox();
      this.txtTimeReconnect = new TextBox();
      this.tmrTimeReconnect = new System.Windows.Forms.Timer(this.components);
      this.box1 = new GroupBox();
      this.txtEntryName = new TextBox();
      this.box2 = new GroupBox();
      this.txtPhoneNumber = new TextBox();
      this.box3 = new GroupBox();
      this.txtUserName = new TextBox();
      this.GroupBox2 = new GroupBox();
      this.txtPassword = new TextBox();
      this.cmbPhoneNumber = new ComboBox();
      this.tmrSleep = new System.Windows.Forms.Timer(this.components);
      this.lbl1 = new Label();
      this.cmbMethod = new ComboBox();
      this.chGetIP = new CheckBox();
      this.txtWaitAfterConnect = new TextBox();
      this.lbl2 = new Label();
      this.chOnlyMisc = new CheckBox();
      this.picVPN_Reboot = new PictureBox();
      this.txtExternalProgram = new TextBox();
      this.PictureBox1 = new PictureBox();
      this.boxExternalProgram = new GroupBox();
      this.txtExternalProgram_ParamConnect = new TextBox();
      this.Label3 = new Label();
      this.txtExternalProgram_ParamDisconnect = new TextBox();
      this.Label2 = new Label();
      this.txtIntervalReCnt = new TextBox();
      this.Label1 = new Label();
      this.chVisibleCMD = new CheckBox();
      this.txtWaitConnected = new TextBox();
      this.Label4 = new Label();
      this.box1.SuspendLayout();
      this.box2.SuspendLayout();
      this.box3.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      ((ISupportInitialize) this.picVPN_Reboot).BeginInit();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.boxExternalProgram.SuspendLayout();
      this.SuspendLayout();
      this.txtMon.BackColor = Color.Red;
      this.txtMon.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.txtMon.ForeColor = Color.Black;
      TextBox txtMon1 = this.txtMon;
      Point point1 = new Point(6, 5);
      Point point2 = point1;
      txtMon1.Location = point2;
      this.txtMon.Multiline = true;
      this.txtMon.Name = "txtMon";
      this.txtMon.ScrollBars = ScrollBars.Vertical;
      TextBox txtMon2 = this.txtMon;
      Size size1 = new Size(648, 270);
      Size size2 = size1;
      txtMon2.Size = size2;
      this.txtMon.TabIndex = 59;
      this.txtMon.TabStop = false;
      this.Timer1.Interval = 1000;
      this.btnConnect.BackColor = Color.FromArgb(0, 192, 0);
      this.btnConnect.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnConnect.ForeColor = Color.Black;
      Button btnConnect1 = this.btnConnect;
      point1 = new Point(6, 300);
      Point point3 = point1;
      btnConnect1.Location = point3;
      this.btnConnect.Name = "btnConnect";
      Button btnConnect2 = this.btnConnect;
      size1 = new Size(138, 28);
      Size size3 = size1;
      btnConnect2.Size = size3;
      this.btnConnect.TabIndex = 60;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = false;
      this.btnClose.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.btnClose.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnClose.ForeColor = Color.Black;
      Button btnClose1 = this.btnClose;
      point1 = new Point(6, 328);
      Point point4 = point1;
      btnClose1.Location = point4;
      this.btnClose.Name = "btnClose";
      Button btnClose2 = this.btnClose;
      size1 = new Size(138, 28);
      Size size4 = size1;
      btnClose2.Size = size4;
      this.btnClose.TabIndex = 63;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = false;
      this.Button9.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Button9.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Button9.ForeColor = Color.Black;
      Button button9_1 = this.Button9;
      point1 = new Point(486, 210);
      Point point5 = point1;
      button9_1.Location = point5;
      this.Button9.Name = "Button9";
      Button button9_2 = this.Button9;
      size1 = new Size(138, 54);
      Size size5 = size1;
      button9_2.Size = size5;
      this.Button9.TabIndex = 65;
      this.Button9.Text = "Get IP";
      this.Button9.UseVisualStyleBackColor = false;
      this.Button9.Visible = false;
      this.lblMon.BackColor = Color.FromArgb(0, 192, 192);
      this.lblMon.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lblMon.ForeColor = Color.FromArgb(64, 64, 64);
      Label lblMon1 = this.lblMon;
      point1 = new Point(6, 280);
      Point point6 = point1;
      lblMon1.Location = point6;
      this.lblMon.Name = "lblMon";
      Label lblMon2 = this.lblMon;
      size1 = new Size(646, 16);
      Size size6 = size1;
      lblMon2.Size = size6;
      this.lblMon.TabIndex = 66;
      this.lblMon.Text = "Started OK";
      this.lblIP.BackColor = Color.FromArgb(48, 48, 48);
      this.lblIP.Font = new Font("Book Antiqua", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lblIP.ForeColor = Color.Yellow;
      Label lblIp1 = this.lblIP;
      point1 = new Point(473, 324);
      Point point7 = point1;
      lblIp1.Location = point7;
      this.lblIP.Name = "lblIP";
      Label lblIp2 = this.lblIP;
      size1 = new Size(175, 30);
      Size size7 = size1;
      lblIp2.Size = size7;
      this.lblIP.TabIndex = 67;
      this.lblIP.Text = "255.255.255.255";
      this.lblIP.TextAlign = ContentAlignment.MiddleCenter;
      this.chReconnect.FlatStyle = FlatStyle.Flat;
      this.chReconnect.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.chReconnect.ForeColor = Color.Red;
      CheckBox chReconnect1 = this.chReconnect;
      point1 = new Point(556, 367);
      Point point8 = point1;
      chReconnect1.Location = point8;
      this.chReconnect.Name = "chReconnect";
      CheckBox chReconnect2 = this.chReconnect;
      size1 = new Size(102, 33);
      Size size8 = size1;
      chReconnect2.Size = size8;
      this.chReconnect.TabIndex = 68;
      this.chReconnect.Text = "Auto Connect";
      this.chReconnect.UseVisualStyleBackColor = true;
      this.lblIP_OLD.BackColor = Color.FromArgb(48, 48, 48);
      this.lblIP_OLD.Font = new Font("Book Antiqua", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lblIP_OLD.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      Label lblIpOld1 = this.lblIP_OLD;
      point1 = new Point(473, 300);
      Point point9 = point1;
      lblIpOld1.Location = point9;
      this.lblIP_OLD.Name = "lblIP_OLD";
      Label lblIpOld2 = this.lblIP_OLD;
      size1 = new Size(175, 22);
      Size size9 = size1;
      lblIpOld2.Size = size9;
      this.lblIP_OLD.TabIndex = 69;
      this.lblIP_OLD.Text = "?.?.?.?";
      this.lblIP_OLD.TextAlign = ContentAlignment.MiddleCenter;
      this.chTimeReconnect.AutoSize = true;
      this.chTimeReconnect.Enabled = false;
      this.chTimeReconnect.ForeColor = Color.FromArgb(224, 224, 224);
      CheckBox chTimeReconnect1 = this.chTimeReconnect;
      point1 = new Point(480, 139);
      Point point10 = point1;
      chTimeReconnect1.Location = point10;
      this.chTimeReconnect.Name = "chTimeReconnect";
      CheckBox chTimeReconnect2 = this.chTimeReconnect;
      size1 = new Size(77, 17);
      Size size10 = size1;
      chTimeReconnect2.Size = size10;
      this.chTimeReconnect.TabIndex = 70;
      this.chTimeReconnect.Text = "Reconnect";
      this.chTimeReconnect.UseVisualStyleBackColor = true;
      this.chTimeReconnect.Visible = false;
      this.txtTimeReconnect.Enabled = false;
      this.txtTimeReconnect.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtTimeReconnect1 = this.txtTimeReconnect;
      point1 = new Point(556, 135);
      Point point11 = point1;
      txtTimeReconnect1.Location = point11;
      this.txtTimeReconnect.Name = "txtTimeReconnect";
      TextBox txtTimeReconnect2 = this.txtTimeReconnect;
      size1 = new Size(66, 22);
      Size size11 = size1;
      txtTimeReconnect2.Size = size11;
      this.txtTimeReconnect.TabIndex = 71;
      this.txtTimeReconnect.TabStop = false;
      this.txtTimeReconnect.TextAlign = HorizontalAlignment.Center;
      this.txtTimeReconnect.Visible = false;
      this.box1.Controls.Add((Control) this.txtEntryName);
      this.box1.ForeColor = Color.FromArgb(224, 224, 224);
      GroupBox box1_1 = this.box1;
      point1 = new Point(6, 360);
      Point point12 = point1;
      box1_1.Location = point12;
      this.box1.Name = "box1";
      GroupBox box1_2 = this.box1;
      size1 = new Size(136, 36);
      Size size12 = size1;
      box1_2.Size = size12;
      this.box1.TabIndex = 72;
      this.box1.TabStop = false;
      this.box1.Text = "Entry Name";
      this.txtEntryName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.txtEntryName.BackColor = Color.FromArgb(48, 48, 48);
      this.txtEntryName.BorderStyle = BorderStyle.None;
      this.txtEntryName.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtEntryName.ForeColor = Color.FromArgb(224, 224, 224);
      TextBox txtEntryName1 = this.txtEntryName;
      point1 = new Point(4, 16);
      Point point13 = point1;
      txtEntryName1.Location = point13;
      this.txtEntryName.Name = "txtEntryName";
      TextBox txtEntryName2 = this.txtEntryName;
      size1 = new Size(128, 14);
      Size size13 = size1;
      txtEntryName2.Size = size13;
      this.txtEntryName.TabIndex = 0;
      this.txtEntryName.TextAlign = HorizontalAlignment.Center;
      this.box2.Controls.Add((Control) this.txtPhoneNumber);
      this.box2.ForeColor = Color.FromArgb(224, 224, 224);
      GroupBox box2_1 = this.box2;
      point1 = new Point(142, 360);
      Point point14 = point1;
      box2_1.Location = point14;
      this.box2.Name = "box2";
      GroupBox box2_2 = this.box2;
      size1 = new Size(136, 36);
      Size size14 = size1;
      box2_2.Size = size14;
      this.box2.TabIndex = 73;
      this.box2.TabStop = false;
      this.box2.Text = "Phone Number / URI";
      this.txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.txtPhoneNumber.BackColor = Color.FromArgb(48, 48, 48);
      this.txtPhoneNumber.BorderStyle = BorderStyle.None;
      this.txtPhoneNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtPhoneNumber.ForeColor = Color.FromArgb(224, 224, 224);
      TextBox txtPhoneNumber1 = this.txtPhoneNumber;
      point1 = new Point(4, 16);
      Point point15 = point1;
      txtPhoneNumber1.Location = point15;
      this.txtPhoneNumber.Name = "txtPhoneNumber";
      TextBox txtPhoneNumber2 = this.txtPhoneNumber;
      size1 = new Size(128, 14);
      Size size15 = size1;
      txtPhoneNumber2.Size = size15;
      this.txtPhoneNumber.TabIndex = 0;
      this.txtPhoneNumber.TextAlign = HorizontalAlignment.Center;
      this.box3.Controls.Add((Control) this.txtUserName);
      this.box3.ForeColor = Color.FromArgb(224, 224, 224);
      GroupBox box3_1 = this.box3;
      point1 = new Point(278, 360);
      Point point16 = point1;
      box3_1.Location = point16;
      this.box3.Name = "box3";
      GroupBox box3_2 = this.box3;
      size1 = new Size(136, 36);
      Size size16 = size1;
      box3_2.Size = size16;
      this.box3.TabIndex = 74;
      this.box3.TabStop = false;
      this.box3.Text = "User Name";
      this.txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.txtUserName.BackColor = Color.FromArgb(48, 48, 48);
      this.txtUserName.BorderStyle = BorderStyle.None;
      this.txtUserName.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtUserName.ForeColor = Color.FromArgb(224, 224, 224);
      TextBox txtUserName1 = this.txtUserName;
      point1 = new Point(4, 16);
      Point point17 = point1;
      txtUserName1.Location = point17;
      this.txtUserName.Name = "txtUserName";
      TextBox txtUserName2 = this.txtUserName;
      size1 = new Size(128, 14);
      Size size17 = size1;
      txtUserName2.Size = size17;
      this.txtUserName.TabIndex = 0;
      this.txtUserName.TextAlign = HorizontalAlignment.Center;
      this.GroupBox2.Controls.Add((Control) this.txtPassword);
      this.GroupBox2.ForeColor = Color.FromArgb(224, 224, 224);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(414, 360);
      Point point18 = point1;
      groupBox2_1.Location = point18;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(136, 36);
      Size size18 = size1;
      groupBox2_2.Size = size18;
      this.GroupBox2.TabIndex = 75;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Password";
      this.txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.txtPassword.BackColor = Color.FromArgb(48, 48, 48);
      this.txtPassword.BorderStyle = BorderStyle.None;
      this.txtPassword.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtPassword.ForeColor = Color.FromArgb(224, 224, 224);
      TextBox txtPassword1 = this.txtPassword;
      point1 = new Point(4, 16);
      Point point19 = point1;
      txtPassword1.Location = point19;
      this.txtPassword.Name = "txtPassword";
      TextBox txtPassword2 = this.txtPassword;
      size1 = new Size(128, 14);
      Size size19 = size1;
      txtPassword2.Size = size19;
      this.txtPassword.TabIndex = 0;
      this.txtPassword.TextAlign = HorizontalAlignment.Center;
      this.cmbPhoneNumber.BackColor = Color.White;
      this.cmbPhoneNumber.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbPhoneNumber.ForeColor = Color.Black;
      this.cmbPhoneNumber.FormattingEnabled = true;
      ComboBox cmbPhoneNumber1 = this.cmbPhoneNumber;
      point1 = new Point(524, 336);
      Point point20 = point1;
      cmbPhoneNumber1.Location = point20;
      this.cmbPhoneNumber.Name = "cmbPhoneNumber";
      ComboBox cmbPhoneNumber2 = this.cmbPhoneNumber;
      size1 = new Size(128, 21);
      Size size20 = size1;
      cmbPhoneNumber2.Size = size20;
      this.cmbPhoneNumber.TabIndex = 77;
      this.cmbPhoneNumber.Visible = false;
      this.lbl1.AutoSize = true;
      this.lbl1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl1.ForeColor = Color.Silver;
      Label lbl1_1 = this.lbl1;
      point1 = new Point(581, 398);
      Point point21 = point1;
      lbl1_1.Location = point21;
      this.lbl1.Name = "lbl1";
      Label lbl1_2 = this.lbl1;
      size1 = new Size(47, 13);
      Size size21 = size1;
      lbl1_2.Size = size21;
      this.lbl1.TabIndex = 99;
      this.lbl1.Text = "Method:";
      this.lbl1.TextAlign = ContentAlignment.MiddleRight;
      this.cmbMethod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmbMethod.BackColor = Color.White;
      this.cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbMethod.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbMethod.ForeColor = Color.Black;
      this.cmbMethod.FormattingEnabled = true;
      this.cmbMethod.Items.AddRange(new object[3]
      {
        (object) "SOFT",
        (object) "HARD",
        (object) "ExtProg"
      });
      ComboBox cmbMethod1 = this.cmbMethod;
      point1 = new Point(556, 414);
      Point point22 = point1;
      cmbMethod1.Location = point22;
      this.cmbMethod.Name = "cmbMethod";
      ComboBox cmbMethod2 = this.cmbMethod;
      size1 = new Size(96, 21);
      Size size22 = size1;
      cmbMethod2.Size = size22;
      this.cmbMethod.TabIndex = 100;
      this.cmbMethod.TabStop = false;
      this.cmbMethod.Tag = (object) "";
      this.chGetIP.AutoSize = true;
      this.chGetIP.FlatStyle = FlatStyle.Flat;
      this.chGetIP.ForeColor = Color.FromArgb(224, 224, 224);
      CheckBox chGetIp1 = this.chGetIP;
      point1 = new Point(150, 307);
      Point point23 = point1;
      chGetIp1.Location = point23;
      this.chGetIP.Name = "chGetIP";
      CheckBox chGetIp2 = this.chGetIP;
      size1 = new Size(53, 17);
      Size size23 = size1;
      chGetIp2.Size = size23;
      this.chGetIP.TabIndex = 102;
      this.chGetIP.Text = "Get IP";
      this.chGetIP.UseVisualStyleBackColor = true;
      this.txtWaitAfterConnect.BackColor = Color.FromArgb(32, 32, 32);
      this.txtWaitAfterConnect.BorderStyle = BorderStyle.FixedSingle;
      this.txtWaitAfterConnect.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtWaitAfterConnect.ForeColor = Color.Silver;
      TextBox waitAfterConnect1 = this.txtWaitAfterConnect;
      point1 = new Point(396, 328);
      Point point24 = point1;
      waitAfterConnect1.Location = point24;
      this.txtWaitAfterConnect.Name = "txtWaitAfterConnect";
      TextBox waitAfterConnect2 = this.txtWaitAfterConnect;
      size1 = new Size(70, 22);
      Size size24 = size1;
      waitAfterConnect2.Size = size24;
      this.txtWaitAfterConnect.TabIndex = 103;
      this.txtWaitAfterConnect.TabStop = false;
      this.txtWaitAfterConnect.TextAlign = HorizontalAlignment.Center;
      this.lbl2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lbl2.ForeColor = Color.Silver;
      Label lbl2_1 = this.lbl2;
      point1 = new Point(309, 333);
      Point point25 = point1;
      lbl2_1.Location = point25;
      this.lbl2.Name = "lbl2";
      Label lbl2_2 = this.lbl2;
      size1 = new Size(88, 13);
      Size size25 = size1;
      lbl2_2.Size = size25;
      this.lbl2.TabIndex = 104;
      this.lbl2.Text = "Wait After Cnt:";
      this.lbl2.TextAlign = ContentAlignment.MiddleRight;
      this.chOnlyMisc.AutoSize = true;
      this.chOnlyMisc.FlatStyle = FlatStyle.Flat;
      this.chOnlyMisc.ForeColor = Color.FromArgb(224, 224, 224);
      CheckBox chOnlyMisc1 = this.chOnlyMisc;
      point1 = new Point(212, 307);
      Point point26 = point1;
      chOnlyMisc1.Location = point26;
      this.chOnlyMisc.Name = "chOnlyMisc";
      CheckBox chOnlyMisc2 = this.chOnlyMisc;
      size1 = new Size(72, 17);
      Size size26 = size1;
      chOnlyMisc2.Size = size26;
      this.chOnlyMisc.TabIndex = 105;
      this.chOnlyMisc.Text = "Only Misc.";
      this.chOnlyMisc.UseVisualStyleBackColor = true;
      this.picVPN_Reboot.Image = (Image) componentResourceManager.GetObject("picVPN_Reboot.Image");
      PictureBox picVpnReboot1 = this.picVPN_Reboot;
      point1 = new Point(628, 300);
      Point point27 = point1;
      picVpnReboot1.Location = point27;
      this.picVPN_Reboot.Name = "picVPN_Reboot";
      PictureBox picVpnReboot2 = this.picVPN_Reboot;
      size1 = new Size(24, 24);
      Size size27 = size1;
      picVpnReboot2.Size = size27;
      this.picVPN_Reboot.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picVPN_Reboot.TabIndex = 108;
      this.picVPN_Reboot.TabStop = false;
      this.picVPN_Reboot.Visible = false;
      this.txtExternalProgram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtExternalProgram.BackColor = Color.FromArgb(32, 32, 32);
      this.txtExternalProgram.BorderStyle = BorderStyle.FixedSingle;
      this.txtExternalProgram.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtExternalProgram.ForeColor = Color.FromArgb(224, 224, 224);
      TextBox txtExternalProgram1 = this.txtExternalProgram;
      point1 = new Point(34, 15);
      Point point28 = point1;
      txtExternalProgram1.Location = point28;
      this.txtExternalProgram.Name = "txtExternalProgram";
      TextBox txtExternalProgram2 = this.txtExternalProgram;
      size1 = new Size(504, 21);
      Size size28 = size1;
      txtExternalProgram2.Size = size28;
      this.txtExternalProgram.TabIndex = 109;
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(4, 15);
      Point point29 = point1;
      pictureBox1_1.Location = point29;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(26, 20);
      Size size29 = size1;
      pictureBox1_2.Size = size29;
      this.PictureBox1.TabIndex = 110;
      this.PictureBox1.TabStop = false;
      this.boxExternalProgram.Controls.Add((Control) this.txtExternalProgram_ParamConnect);
      this.boxExternalProgram.Controls.Add((Control) this.Label3);
      this.boxExternalProgram.Controls.Add((Control) this.txtExternalProgram_ParamDisconnect);
      this.boxExternalProgram.Controls.Add((Control) this.Label2);
      this.boxExternalProgram.Controls.Add((Control) this.PictureBox1);
      this.boxExternalProgram.Controls.Add((Control) this.txtExternalProgram);
      this.boxExternalProgram.ForeColor = Color.White;
      GroupBox boxExternalProgram1 = this.boxExternalProgram;
      point1 = new Point(6, 398);
      Point point30 = point1;
      boxExternalProgram1.Location = point30;
      this.boxExternalProgram.Name = "boxExternalProgram";
      GroupBox boxExternalProgram2 = this.boxExternalProgram;
      size1 = new Size(544, 70);
      Size size30 = size1;
      boxExternalProgram2.Size = size30;
      this.boxExternalProgram.TabIndex = 111;
      this.boxExternalProgram.TabStop = false;
      this.boxExternalProgram.Text = "External Program";
      this.txtExternalProgram_ParamConnect.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtExternalProgram_ParamConnect.BackColor = Color.FromArgb(32, 32, 32);
      this.txtExternalProgram_ParamConnect.BorderStyle = BorderStyle.FixedSingle;
      this.txtExternalProgram_ParamConnect.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtExternalProgram_ParamConnect.ForeColor = Color.FromArgb(224, 224, 224);
      TextBox programParamConnect1 = this.txtExternalProgram_ParamConnect;
      point1 = new Point(297, 43);
      Point point31 = point1;
      programParamConnect1.Location = point31;
      this.txtExternalProgram_ParamConnect.Name = "txtExternalProgram_ParamConnect";
      TextBox programParamConnect2 = this.txtExternalProgram_ParamConnect;
      size1 = new Size(241, 21);
      Size size31 = size1;
      programParamConnect2.Size = size31;
      this.txtExternalProgram_ParamConnect.TabIndex = 116;
      this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label3.ForeColor = Color.Silver;
      Label label3_1 = this.Label3;
      point1 = new Point(233, 38);
      Point point32 = point1;
      label3_1.Location = point32;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(68, 29);
      Size size32 = size1;
      label3_2.Size = size32;
      this.Label3.TabIndex = 115;
      this.Label3.Text = "параметры Connect";
      this.Label3.TextAlign = ContentAlignment.MiddleCenter;
      this.txtExternalProgram_ParamDisconnect.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtExternalProgram_ParamDisconnect.BackColor = Color.FromArgb(32, 32, 32);
      this.txtExternalProgram_ParamDisconnect.BorderStyle = BorderStyle.FixedSingle;
      this.txtExternalProgram_ParamDisconnect.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtExternalProgram_ParamDisconnect.ForeColor = Color.FromArgb(224, 224, 224);
      TextBox programParamDisconnect1 = this.txtExternalProgram_ParamDisconnect;
      point1 = new Point(70, 43);
      Point point33 = point1;
      programParamDisconnect1.Location = point33;
      this.txtExternalProgram_ParamDisconnect.Name = "txtExternalProgram_ParamDisconnect";
      TextBox programParamDisconnect2 = this.txtExternalProgram_ParamDisconnect;
      size1 = new Size(157, 21);
      Size size33 = size1;
      programParamDisconnect2.Size = size33;
      this.txtExternalProgram_ParamDisconnect.TabIndex = 111;
      this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label2.ForeColor = Color.Silver;
      Label label2_1 = this.Label2;
      point1 = new Point(6, 38);
      Point point34 = point1;
      label2_1.Location = point34;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(68, 29);
      Size size34 = size1;
      label2_2.Size = size34;
      this.Label2.TabIndex = 114;
      this.Label2.Text = "параметры Disconnect";
      this.Label2.TextAlign = ContentAlignment.MiddleCenter;
      this.txtIntervalReCnt.BackColor = Color.FromArgb(32, 32, 32);
      this.txtIntervalReCnt.BorderStyle = BorderStyle.FixedSingle;
      this.txtIntervalReCnt.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtIntervalReCnt.ForeColor = Color.Silver;
      TextBox txtIntervalReCnt1 = this.txtIntervalReCnt;
      point1 = new Point(396, 304);
      Point point35 = point1;
      txtIntervalReCnt1.Location = point35;
      this.txtIntervalReCnt.Name = "txtIntervalReCnt";
      TextBox txtIntervalReCnt2 = this.txtIntervalReCnt;
      size1 = new Size(70, 22);
      Size size35 = size1;
      txtIntervalReCnt2.Size = size35;
      this.txtIntervalReCnt.TabIndex = 112;
      this.txtIntervalReCnt.TabStop = false;
      this.txtIntervalReCnt.TextAlign = HorizontalAlignment.Center;
      this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label1.ForeColor = Color.Silver;
      Label label1_1 = this.Label1;
      point1 = new Point(309, 309);
      Point point36 = point1;
      label1_1.Location = point36;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(88, 13);
      Size size36 = size1;
      label1_2.Size = size36;
      this.Label1.TabIndex = 113;
      this.Label1.Text = "Interval ReCnt:";
      this.Label1.TextAlign = ContentAlignment.MiddleRight;
      this.chVisibleCMD.FlatStyle = FlatStyle.Flat;
      this.chVisibleCMD.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.chVisibleCMD.ForeColor = Color.Silver;
      CheckBox chVisibleCmd1 = this.chVisibleCMD;
      point1 = new Point(556, 446);
      Point point37 = point1;
      chVisibleCmd1.Location = point37;
      this.chVisibleCMD.Name = "chVisibleCMD";
      CheckBox chVisibleCmd2 = this.chVisibleCMD;
      size1 = new Size(98, 17);
      Size size37 = size1;
      chVisibleCmd2.Size = size37;
      this.chVisibleCMD.TabIndex = 114;
      this.chVisibleCMD.Text = "Visible CMD";
      this.chVisibleCMD.UseVisualStyleBackColor = true;
      this.txtWaitConnected.BackColor = Color.FromArgb(32, 32, 32);
      this.txtWaitConnected.BorderStyle = BorderStyle.FixedSingle;
      this.txtWaitConnected.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtWaitConnected.ForeColor = Color.Silver;
      TextBox txtWaitConnected1 = this.txtWaitConnected;
      point1 = new Point(237, 328);
      Point point38 = point1;
      txtWaitConnected1.Location = point38;
      this.txtWaitConnected.Name = "txtWaitConnected";
      TextBox txtWaitConnected2 = this.txtWaitConnected;
      size1 = new Size(70, 22);
      Size size38 = size1;
      txtWaitConnected2.Size = size38;
      this.txtWaitConnected.TabIndex = 115;
      this.txtWaitConnected.TabStop = false;
      this.txtWaitConnected.TextAlign = HorizontalAlignment.Center;
      this.Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label4.ForeColor = Color.Silver;
      Label label4_1 = this.Label4;
      point1 = new Point(150, 333);
      Point point39 = point1;
      label4_1.Location = point39;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(88, 13);
      Size size39 = size1;
      label4_2.Size = size39;
      this.Label4.TabIndex = 116;
      this.Label4.Text = "Wait Connected:";
      this.Label4.TextAlign = ContentAlignment.MiddleRight;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(48, 48, 48);
      size1 = new Size(660, 475);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.txtWaitConnected);
      this.Controls.Add((Control) this.chVisibleCMD);
      this.Controls.Add((Control) this.txtIntervalReCnt);
      this.Controls.Add((Control) this.boxExternalProgram);
      this.Controls.Add((Control) this.picVPN_Reboot);
      this.Controls.Add((Control) this.chOnlyMisc);
      this.Controls.Add((Control) this.txtWaitAfterConnect);
      this.Controls.Add((Control) this.lbl2);
      this.Controls.Add((Control) this.chGetIP);
      this.Controls.Add((Control) this.txtTimeReconnect);
      this.Controls.Add((Control) this.chTimeReconnect);
      this.Controls.Add((Control) this.lbl1);
      this.Controls.Add((Control) this.cmbMethod);
      this.Controls.Add((Control) this.cmbPhoneNumber);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.box3);
      this.Controls.Add((Control) this.box2);
      this.Controls.Add((Control) this.box1);
      this.Controls.Add((Control) this.lblIP_OLD);
      this.Controls.Add((Control) this.chReconnect);
      this.Controls.Add((Control) this.lblIP);
      this.Controls.Add((Control) this.lblMon);
      this.Controls.Add((Control) this.Button9);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.btnConnect);
      this.Controls.Add((Control) this.txtMon);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label4);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.ForeColor = Color.FromArgb(224, 224, 224);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (frmMain_RasDialex);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "RasDialEx";
      this.box1.ResumeLayout(false);
      this.box1.PerformLayout();
      this.box2.ResumeLayout(false);
      this.box2.PerformLayout();
      this.box3.ResumeLayout(false);
      this.box3.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      ((ISupportInitialize) this.picVPN_Reboot).EndInit();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.boxExternalProgram.ResumeLayout(false);
      this.boxExternalProgram.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
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

    internal virtual System.Windows.Forms.Timer Timer1
    {
      get
      {
        return this._Timer1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        if (this._Timer1 != null)
          this._Timer1.Tick -= eventHandler;
        this._Timer1 = value;
        if (this._Timer1 == null)
          return;
        this._Timer1.Tick += eventHandler;
      }
    }

    internal virtual Button btnConnect
    {
      get
      {
        return this._btnConnect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnConnect_Click);
        if (this._btnConnect != null)
          this._btnConnect.Click -= eventHandler;
        this._btnConnect = value;
        if (this._btnConnect == null)
          return;
        this._btnConnect.Click += eventHandler;
      }
    }

    internal virtual Button btnClose
    {
      get
      {
        return this._btnClose;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnClose_Click);
        if (this._btnClose != null)
          this._btnClose.Click -= eventHandler;
        this._btnClose = value;
        if (this._btnClose == null)
          return;
        this._btnClose.Click += eventHandler;
      }
    }

    internal virtual Button Button9
    {
      get
      {
        return this._Button9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button9_Click);
        if (this._Button9 != null)
          this._Button9.Click -= eventHandler;
        this._Button9 = value;
        if (this._Button9 == null)
          return;
        this._Button9.Click += eventHandler;
      }
    }

    internal virtual Label lblMon
    {
      get
      {
        return this._lblMon;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblMon = value;
      }
    }

    internal virtual Label lblIP
    {
      get
      {
        return this._lblIP;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblIP = value;
      }
    }

    internal virtual CheckBox chReconnect
    {
      get
      {
        return this._chReconnect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chReconnect_CheckedChanged);
        if (this._chReconnect != null)
          this._chReconnect.CheckedChanged -= eventHandler;
        this._chReconnect = value;
        if (this._chReconnect == null)
          return;
        this._chReconnect.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label lblIP_OLD
    {
      get
      {
        return this._lblIP_OLD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblIP_OLD = value;
      }
    }

    internal virtual CheckBox chTimeReconnect
    {
      get
      {
        return this._chTimeReconnect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chTimeReconnect_CheckedChanged);
        if (this._chTimeReconnect != null)
          this._chTimeReconnect.CheckedChanged -= eventHandler;
        this._chTimeReconnect = value;
        if (this._chTimeReconnect == null)
          return;
        this._chTimeReconnect.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox txtTimeReconnect
    {
      get
      {
        return this._txtTimeReconnect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtTimeReconnect_TextChanged);
        if (this._txtTimeReconnect != null)
          this._txtTimeReconnect.TextChanged -= eventHandler;
        this._txtTimeReconnect = value;
        if (this._txtTimeReconnect == null)
          return;
        this._txtTimeReconnect.TextChanged += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer tmrTimeReconnect
    {
      get
      {
        return this._tmrTimeReconnect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrTimeReconnect_Tick);
        if (this._tmrTimeReconnect != null)
          this._tmrTimeReconnect.Tick -= eventHandler;
        this._tmrTimeReconnect = value;
        if (this._tmrTimeReconnect == null)
          return;
        this._tmrTimeReconnect.Tick += eventHandler;
      }
    }

    internal virtual GroupBox box1
    {
      get
      {
        return this._box1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._box1 = value;
      }
    }

    internal virtual TextBox txtEntryName
    {
      get
      {
        return this._txtEntryName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtEntryName_TextChanged);
        if (this._txtEntryName != null)
          this._txtEntryName.TextChanged -= eventHandler;
        this._txtEntryName = value;
        if (this._txtEntryName == null)
          return;
        this._txtEntryName.TextChanged += eventHandler;
      }
    }

    internal virtual GroupBox box2
    {
      get
      {
        return this._box2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._box2 = value;
      }
    }

    internal virtual TextBox txtPhoneNumber
    {
      get
      {
        return this._txtPhoneNumber;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtUserData_TextChanged);
        if (this._txtPhoneNumber != null)
          this._txtPhoneNumber.TextChanged -= eventHandler;
        this._txtPhoneNumber = value;
        if (this._txtPhoneNumber == null)
          return;
        this._txtPhoneNumber.TextChanged += eventHandler;
      }
    }

    internal virtual GroupBox box3
    {
      get
      {
        return this._box3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._box3 = value;
      }
    }

    internal virtual TextBox txtUserName
    {
      get
      {
        return this._txtUserName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtUserData_TextChanged);
        if (this._txtUserName != null)
          this._txtUserName.TextChanged -= eventHandler;
        this._txtUserName = value;
        if (this._txtUserName == null)
          return;
        this._txtUserName.TextChanged += eventHandler;
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

    internal virtual TextBox txtPassword
    {
      get
      {
        return this._txtPassword;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtUserData_TextChanged);
        if (this._txtPassword != null)
          this._txtPassword.TextChanged -= eventHandler;
        this._txtPassword = value;
        if (this._txtPassword == null)
          return;
        this._txtPassword.TextChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbPhoneNumber
    {
      get
      {
        return this._cmbPhoneNumber;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbPhoneNumber_SelectedIndexChanged);
        if (this._cmbPhoneNumber != null)
          this._cmbPhoneNumber.SelectedIndexChanged -= eventHandler;
        this._cmbPhoneNumber = value;
        if (this._cmbPhoneNumber == null)
          return;
        this._cmbPhoneNumber.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer tmrSleep
    {
      get
      {
        return this._tmrSleep;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tmrSleep_Tick);
        if (this._tmrSleep != null)
          this._tmrSleep.Tick -= eventHandler;
        this._tmrSleep = value;
        if (this._tmrSleep == null)
          return;
        this._tmrSleep.Tick += eventHandler;
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

    internal virtual ComboBox cmbMethod
    {
      get
      {
        return this._cmbMethod;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbMethod_SelectedIndexChanged);
        if (this._cmbMethod != null)
          this._cmbMethod.SelectedIndexChanged -= eventHandler;
        this._cmbMethod = value;
        if (this._cmbMethod == null)
          return;
        this._cmbMethod.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chGetIP
    {
      get
      {
        return this._chGetIP;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chGetIP_CheckedChanged);
        if (this._chGetIP != null)
          this._chGetIP.CheckedChanged -= eventHandler;
        this._chGetIP = value;
        if (this._chGetIP == null)
          return;
        this._chGetIP.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox txtWaitAfterConnect
    {
      get
      {
        return this._txtWaitAfterConnect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtWaitAfterConnect_TextChanged);
        if (this._txtWaitAfterConnect != null)
          this._txtWaitAfterConnect.TextChanged -= eventHandler;
        this._txtWaitAfterConnect = value;
        if (this._txtWaitAfterConnect == null)
          return;
        this._txtWaitAfterConnect.TextChanged += eventHandler;
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

    internal virtual CheckBox chOnlyMisc
    {
      get
      {
        return this._chOnlyMisc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chOnlyMisc_CheckedChanged);
        if (this._chOnlyMisc != null)
          this._chOnlyMisc.CheckedChanged -= eventHandler;
        this._chOnlyMisc = value;
        if (this._chOnlyMisc == null)
          return;
        this._chOnlyMisc.CheckedChanged += eventHandler;
      }
    }

    internal virtual PictureBox picVPN_Reboot
    {
      get
      {
        return this._picVPN_Reboot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picVPN_Reboot = value;
      }
    }

    internal virtual TextBox txtExternalProgram
    {
      get
      {
        return this._txtExternalProgram;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtExternalProgram_TextChanged);
        if (this._txtExternalProgram != null)
          this._txtExternalProgram.TextChanged -= eventHandler;
        this._txtExternalProgram = value;
        if (this._txtExternalProgram == null)
          return;
        this._txtExternalProgram.TextChanged += eventHandler;
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

    internal virtual GroupBox boxExternalProgram
    {
      get
      {
        return this._boxExternalProgram;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxExternalProgram = value;
      }
    }

    internal virtual TextBox txtIntervalReCnt
    {
      get
      {
        return this._txtIntervalReCnt;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtIntervalReCnt_TextChanged);
        if (this._txtIntervalReCnt != null)
          this._txtIntervalReCnt.TextChanged -= eventHandler;
        this._txtIntervalReCnt = value;
        if (this._txtIntervalReCnt == null)
          return;
        this._txtIntervalReCnt.TextChanged += eventHandler;
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

    internal virtual TextBox txtExternalProgram_ParamConnect
    {
      get
      {
        return this._txtExternalProgram_ParamConnect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtExternalProgram_ParamConnect_TextChanged);
        if (this._txtExternalProgram_ParamConnect != null)
          this._txtExternalProgram_ParamConnect.TextChanged -= eventHandler;
        this._txtExternalProgram_ParamConnect = value;
        if (this._txtExternalProgram_ParamConnect == null)
          return;
        this._txtExternalProgram_ParamConnect.TextChanged += eventHandler;
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

    internal virtual TextBox txtExternalProgram_ParamDisconnect
    {
      get
      {
        return this._txtExternalProgram_ParamDisconnect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtExternalProgram_ParamDisconnect_TextChanged);
        if (this._txtExternalProgram_ParamDisconnect != null)
          this._txtExternalProgram_ParamDisconnect.TextChanged -= eventHandler;
        this._txtExternalProgram_ParamDisconnect = value;
        if (this._txtExternalProgram_ParamDisconnect == null)
          return;
        this._txtExternalProgram_ParamDisconnect.TextChanged += eventHandler;
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

    internal virtual CheckBox chVisibleCMD
    {
      get
      {
        return this._chVisibleCMD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chVisibleCMD_CheckedChanged);
        if (this._chVisibleCMD != null)
          this._chVisibleCMD.CheckedChanged -= eventHandler;
        this._chVisibleCMD = value;
        if (this._chVisibleCMD == null)
          return;
        this._chVisibleCMD.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox txtWaitConnected
    {
      get
      {
        return this._txtWaitConnected;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtWaitConnected_TextChanged);
        if (this._txtWaitConnected != null)
          this._txtWaitConnected.TextChanged -= eventHandler;
        this._txtWaitConnected = value;
        if (this._txtWaitConnected == null)
          return;
        this._txtWaitConnected.TextChanged += eventHandler;
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

    public void TXT(ref string sText)
    {
      if (this.txtMon.InvokeRequired)
      {
        this.txtMon.BeginInvoke((Delegate) new RAS_Variable.dTXTinThread_VPN(this.TXT), (object) sText);
      }
      else
      {
        DateTime date = Conversions.ToDate(DateAndTime.Now.TimeOfDay.ToString());
        TextBox txtMon = this.txtMon;
        if (txtMon.TextLength > 30000)
        {
          txtMon.Clear();
          txtMon.AppendText("LOG.Clear\r\n");
        }
        txtMon.AppendText("[" + Conversions.ToString(date) + "] " + sText + "\r\n");
        txtMon.Select(checked (txtMon.TextLength - 1), 0);
        txtMon.ScrollToCaret();
      }
    }

    public void LBL(ref string sText)
    {
      if (this.lblMon.InvokeRequired)
        this.lblMon.BeginInvoke((Delegate) new RAS_Variable.dLBLinThread(this.LBL), (object) sText);
      else
        this.lblMon.Text = "[" + Conversions.ToString(Conversions.ToDate(DateAndTime.Now.TimeOfDay.ToString())) + "] " + sText;
    }

    private void frmMain_RasDialex_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.RAS.Unload();
    }

    private void frmMain_RasDialex_Load(object sender, EventArgs e)
    {
      RAS_Variable.FN_VPN = new RAS_Variable.clsTXT_VPN((Form) this);
      object setGlobalOBJ = (object) this;
      this.RAS = new RasDialUC(ref setGlobalOBJ);
      this.RAS.Connected += new RasDialUC.ConnectedEventHandler(this.RAS_Connected);
      this.RAS.ConnectionStatus += new RasDialUC.ConnectionStatusEventHandler(this.RAS_ConnectionStatus);
      this.RAS.Disconnected += new RasDialUC.DisconnectedEventHandler(this.RAS_Disconnected);
      this.RAS.ErrorRAS += new RasDialUC.ErrorRASEventHandler(this.RAS_ErrorRAS);
      int num1 = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI(nameof (frmMain_RasDialex), "txtIntervalReCnt"))));
      if (num1 == 0)
        num1 = 7000;
      if (num1 < 1000)
        num1 = 1000;
      this.txtIntervalReCnt.Text = Conversions.ToString(num1);
      int num2 = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI(nameof (frmMain_RasDialex), "txtWaitAfterConnect"))));
      if (num2 < 500)
        num2 = 3000;
      this.txtWaitAfterConnect.Text = Conversions.ToString(num2);
      int num3 = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI(nameof (frmMain_RasDialex), "txtWaitConnected"))));
      if (num3 == 0)
        num3 = 15000;
      if (num3 < 5000)
        num3 = 5000;
      this.txtWaitConnected.Text = Conversions.ToString(num3);
      if (Operators.CompareString(Strings.LCase(_INI.LoadINI(nameof (frmMain_RasDialex), "chVisibleCMD")), "true", false) == 0)
        this.chVisibleCMD.Checked = true;
      if (Operators.CompareString(Strings.LCase(_INI.LoadINI(nameof (frmMain_RasDialex), "chOnlyMisc")), "true", false) == 0)
        this.chOnlyMisc.Checked = true;
      if (Operators.CompareString(Strings.LCase(_INI.LoadINI(nameof (frmMain_RasDialex), "chGetIP")), "true", false) == 0)
        this.chGetIP.Checked = true;
      if (!this.chGetIP.Checked)
      {
        this.chOnlyMisc.Checked = false;
        this.chOnlyMisc.Enabled = false;
      }
      this.txtTimeReconnect.Text = Conversions.ToString(Conversion.Val(_INI.LoadINI(nameof (frmMain_RasDialex), "txtTimeReconnect")));
      this.txtExternalProgram.Text = _INI.LoadINI(nameof (frmMain_RasDialex), "txtExternalProgram");
      if (this.txtExternalProgram.Text.Length == 0)
        this.txtExternalProgram.Text = Application.StartupPath + "\\myProgRasApi.exe";
      this.txtExternalProgram_ParamDisconnect.Text = _INI.LoadINI(nameof (frmMain_RasDialex), "txtExternalProgram_ParamDisconnect");
      this.txtExternalProgram_ParamConnect.Text = _INI.LoadINI(nameof (frmMain_RasDialex), "txtExternalProgram_ParamConnect");
      _LOADSAVE.LoadVPN();
      this.cmbPhoneNumber.Items.Clear();
      this.cmbPhoneNumber.Items.Add((object) "Свои настройки");
      int num4 = 1;
      int num5 = checked (((IEnumerable<RAS_Variable.meVPN>) RAS_Variable.VPN).Count<RAS_Variable.meVPN>() - 1);
      int index = num4;
      while (index <= num5)
      {
        this.cmbPhoneNumber.Items.Add((object) RAS_Variable.VPN[index].PhoneNumber);
        checked { ++index; }
      }
      this.cmbPhoneNumber.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI(nameof (frmMain_RasDialex), "cmbPhoneNumber"))));
      this.txtEntryName.Text = _INI.LoadINI("Connection Data", this.txtEntryName.Name);
      if (this.cmbPhoneNumber.SelectedIndex == 0)
      {
        this.txtPhoneNumber.Text = _INI.LoadINI("Connection Data", this.txtPhoneNumber.Name);
        this.txtUserName.Text = _INI.LoadINI("Connection Data", this.txtUserName.Name);
        this.txtPassword.Text = _INI.LoadINI("Connection Data", this.txtPassword.Name);
      }
      if (Operators.CompareString(Strings.LCase(_INI.LoadINI(nameof (frmMain_RasDialex), "chReconnect")), "true", false) == 0)
        this.chReconnect.Checked = true;
      this.cmbMethod.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI(nameof (frmMain_RasDialex), "cmbMethod"))));
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
    }

    public void btnConnect_Click(object sender, EventArgs e)
    {
      if (this.txtEntryName.Text.Length > 0 && this.txtPhoneNumber.Text.Length > 0 && (this.txtUserName.Text.Length > 0 && this.txtPassword.Text.Length > 0))
      {
        this.RAS.SetOptions(this.txtEntryName.Text, this.txtPhoneNumber.Text, this.txtUserName.Text, this.txtPassword.Text);
        this.RAS.Connect();
      }
      else
      {
        RAS_Variable.clsTXT_VPN fnVpn = RAS_Variable.FN_VPN;
        string sText = "VPN settings are not set.";
        fnVpn.TXT(ref sText);
      }
    }

    private void DoConnect(object sender, ElapsedEventArgs e)
    {
      string sText1;
      if (this.chGetIP.Checked)
      {
        string[] ip = this.RAS.GetIP();
        if (Information.IsNothing((object) ip))
        {
          RAS_Variable.clsTXT_VPN fnVpn = RAS_Variable.FN_VPN;
          string sText2 = "Error connecting to 2ip.ru! Reconnect...";
          fnVpn.TXT(ref sText2);
          this.btnConnect_Click((object) null, (EventArgs) null);
          return;
        }
        this.lblIP_OLD.Text = this.lblIP.Text;
        this.lblIP.Text = ip[0];
        if (Operators.CompareString(this.lblIP_OLD.Text, this.lblIP.Text, false) == 0)
        {
          this.lblIP.ForeColor = Color.Red;
          if (this.chOnlyMisc.Checked)
          {
            RAS_Variable.clsTXT_VPN fnVpn1 = RAS_Variable.FN_VPN;
            string sText2 = "Connected - OK";
            fnVpn1.TXT(ref sText2);
            RAS_Variable.clsTXT_VPN fnVpn2 = RAS_Variable.FN_VPN;
            sText2 = "Coincide IP addresses!";
            fnVpn2.TXT(ref sText2);
            Thread.Sleep(1000);
            this.RAS.Close();
            return;
          }
        }
        else
          this.lblIP.ForeColor = Color.Yellow;
        RAS_Variable.clsTXT_VPN fnVpn3 = RAS_Variable.FN_VPN;
        sText1 = ip[0] + " [" + ip[2] + "]";
        fnVpn3.TXT(ref sText1);
      }
      this.txtMon.BackColor = Color.Black;
      this.txtMon.ForeColor = Color.Lime;
      this.txtMon.Refresh();
      RAS_Variable.clsTXT_VPN fnVpn4 = RAS_Variable.FN_VPN;
      sText1 = "Connected - OK";
      fnVpn4.TXT(ref sText1);
      if (!Information.IsNothing((object) _VARIABLES.AC_NET))
        _VARIABLES.AC_NET.StartSoft();
      this.picVPN_Reboot.Visible = false;
      _VARIABLES.PauseConnect = false;
    }

    private void RAS_Connected()
    {
      this.tmrDoConnect = new System.Timers.Timer();
      this.tmrDoConnect.AutoReset = false;
      this.tmrDoConnect.Elapsed += new ElapsedEventHandler(this.DoConnect);
      this.tmrDoConnect.Interval = (double) this.WaitAfterConnect;
      this.tmrDoConnect.Start();
    }

    private void RAS_ConnectionStatus(int StatusNumber, string Message)
    {
      RAS_Variable.clsTXT_VPN fnVpn = RAS_Variable.FN_VPN;
      string sText = "Status: [" + Conversions.ToString(StatusNumber) + "] " + Message;
      fnVpn.LBL(ref sText);
    }

    private void RAS_Disconnected()
    {
      _VARIABLES.PauseConnect = true;
      this.txtMon.BackColor = Color.Red;
      this.txtMon.ForeColor = Color.Black;
      this.txtMon.Refresh();
      RAS_Variable.clsTXT_VPN fnVpn = RAS_Variable.FN_VPN;
      string sText = "Disconnected";
      fnVpn.TXT(ref sText);
      if (!this.AutoConnectRasDial)
        return;
      this.tmrSleep.Stop();
      this.tmrSleep.Interval = this.IntervalReCnt;
      this.tmrSleep.Start();
    }

    private void tmrSleep_Tick(object sender, EventArgs e)
    {
      this.tmrSleep.Interval = this.IntervalReCnt;
      this.tmrSleep.Stop();
      switch (this.RAS.GetStatus())
      {
        case 0:
          RAS_Variable.clsTXT_VPN fnVpn = RAS_Variable.FN_VPN;
          string sText = "Reconnect...";
          fnVpn.TXT(ref sText);
          this.btnConnect_Click((object) null, (EventArgs) null);
          break;
        default:
          this.btnClose_Click((object) null, (EventArgs) null);
          break;
      }
    }

    private void RAS_ErrorRAS(int ErrNumber, string Message)
    {
      RAS_Variable.clsTXT_VPN fnVpn = RAS_Variable.FN_VPN;
      string sText = "Error: [" + Conversions.ToString(ErrNumber) + "] " + Message;
      fnVpn.TXT(ref sText);
      if (!this.AutoConnectRasDial)
        return;
      System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
      timer.Tick += new EventHandler(this.sTmrWaitClose_Tick);
      timer.Interval = 1000;
      timer.Start();
    }

    private void sTmrWaitClose_Tick(object sender, EventArgs e)
    {
      NewLateBinding.LateCall(sender, (Type) null, "stop", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
      this.picVPN_Reboot.Visible = true;
      this.RAS.Close();
    }

    public void btnClose_Click(object sender, EventArgs e)
    {
      this.picVPN_Reboot.Visible = true;
      this.RAS.Close();
    }

    private void Button9_Click(object sender, EventArgs e)
    {
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = Conversions.ToString(this.RAS.GetStatus());
      fn.TXT(ref sText);
    }

    private void chReconnect_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "chReconnect", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      this.AutoConnectRasDial = this.chReconnect.Checked;
      if (this.chReconnect.Checked)
      {
        NewLateBinding.LateSet(sender, (Type) null, "forecolor", new object[1]
        {
          (object) Color.Lime
        }, (string[]) null, (Type[]) null);
        if (this.RAS.GetStatus() != 0)
          return;
        this.btnConnect_Click((object) null, (EventArgs) null);
      }
      else
      {
        NewLateBinding.LateSet(sender, (Type) null, "forecolor", new object[1]
        {
          (object) Color.Red
        }, (string[]) null, (Type[]) null);
        this.tmrSleep.Stop();
      }
    }

    private void chTimeReconnect_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        if (this.chTimeReconnect.Checked)
        {
          this.tmrTimeReconnect.Interval = checked ((int) Math.Round(Conversion.Val(this.txtTimeReconnect.Text)));
          if (this.tmrTimeReconnect.Interval < 3000)
            this.tmrTimeReconnect.Interval = 3000;
          checked { this.tmrTimeReconnect.Interval += 5000; }
          this.tmrTimeReconnect.Start();
        }
        else
          this.tmrTimeReconnect.Stop();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        RAS_Variable.clsTXT_VPN fnVpn = RAS_Variable.FN_VPN;
        string message = exception.Message;
        fnVpn.TXT(ref message);
        ProjectData.ClearProjectError();
      }
    }

    private void txtTimeReconnect_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "txtTimeReconnect", this.txtTimeReconnect.Text);
    }

    private void tmrTimeReconnect_Tick(object sender, EventArgs e)
    {
      this.RAS.Close();
    }

    private void txtUserData_TextChanged(object sender, EventArgs e)
    {
      if (this.cmbPhoneNumber.SelectedIndex == 0)
        _INI.SaveINI("Connection Data", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (this.txtEntryName.Text.Length <= 0 || this.txtPhoneNumber.Text.Length <= 0 || (this.txtUserName.Text.Length <= 0 || this.txtPassword.Text.Length <= 0))
        return;
      this.RAS.SetOptions(this.txtEntryName.Text, this.txtPhoneNumber.Text, this.txtUserName.Text, this.txtPassword.Text);
    }

    private void txtEntryName_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Connection Data", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (this.txtEntryName.Text.Length <= 0 || this.txtPhoneNumber.Text.Length <= 0 || (this.txtUserName.Text.Length <= 0 || this.txtPassword.Text.Length <= 0))
        return;
      this.RAS.SetOptions(this.txtEntryName.Text, this.txtPhoneNumber.Text, this.txtUserName.Text, this.txtPassword.Text);
    }

    private void cmbPhoneNumber_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "cmbPhoneNumber", Conversions.ToString(this.cmbPhoneNumber.SelectedIndex));
      if (this.cmbPhoneNumber.SelectedIndex <= 0)
        return;
      int selectedIndex = this.cmbPhoneNumber.SelectedIndex;
      this.txtPhoneNumber.Text = RAS_Variable.VPN[selectedIndex].PhoneNumber;
      this.txtUserName.Text = RAS_Variable.VPN[selectedIndex].Login;
      this.txtPassword.Text = RAS_Variable.VPN[selectedIndex].Password;
    }

    private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "cmbMethod", Conversions.ToString(this.cmbMethod.SelectedIndex));
      this.RAS.VPN_Reboot_Method = checked ((short) this.cmbMethod.SelectedIndex);
      switch (this.cmbMethod.SelectedIndex)
      {
        case 0:
          this.chVisibleCMD.Enabled = false;
          this.boxExternalProgram.Enabled = false;
          break;
        case 1:
          this.chVisibleCMD.Enabled = true;
          this.boxExternalProgram.Enabled = false;
          break;
        case 2:
          this.chVisibleCMD.Enabled = true;
          this.boxExternalProgram.Enabled = true;
          break;
      }
    }

    private void chGetIP_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "chGetIP", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (!this.chGetIP.Checked)
      {
        this.chOnlyMisc.Checked = false;
        this.chOnlyMisc.Enabled = false;
      }
      else
        this.chOnlyMisc.Enabled = true;
      this.RAS._CheckIP = this.chGetIP.Checked;
    }

    private void chOnlyMisc_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "chOnlyMisc", Conversions.ToString(this.chOnlyMisc.Checked));
    }

    private void txtIntervalReCnt_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "txtIntervalReCnt", this.txtIntervalReCnt.Text);
      this.IntervalReCnt = checked ((int) Math.Round(Conversion.Val(this.txtIntervalReCnt.Text)));
      if (this.IntervalReCnt >= 500)
        return;
      this.IntervalReCnt = 500;
    }

    private void txtWaitAfterConnect_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "txtWaitAfterConnect", this.txtWaitAfterConnect.Text);
      this.WaitAfterConnect = checked ((int) Math.Round(Conversion.Val(this.txtWaitAfterConnect.Text)));
      if (this.WaitAfterConnect >= 500)
        return;
      this.WaitAfterConnect = 500;
    }

    private void txtExternalProgram_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "txtExternalProgram", this.txtExternalProgram.Text);
      this.ExternalProgram = this.txtExternalProgram.Text;
    }

    private void txtExternalProgram_ParamDisconnect_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "txtExternalProgram_ParamDisconnect", this.txtExternalProgram_ParamDisconnect.Text);
      this.ExternalProgram_ParamDisconnect = this.txtExternalProgram_ParamDisconnect.Text;
    }

    private void txtExternalProgram_ParamConnect_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "txtExternalProgram_ParamConnect", this.txtExternalProgram_ParamConnect.Text);
      this.ExternalProgram_ParamConnect = this.txtExternalProgram_ParamConnect.Text;
    }

    private void chVisibleCMD_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "chVisibleCMD", Conversions.ToString(this.chVisibleCMD.Checked));
      this.VisibleCMD = this.chVisibleCMD.Checked;
    }

    private void txtWaitConnected_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI(nameof (frmMain_RasDialex), "txtWaitConnected", this.txtWaitConnected.Text);
      this.RAS.WaitConnected = checked ((int) Math.Round(Conversion.Val(this.txtWaitConnected.Text)));
      if (this.RAS.WaitConnected >= 5000)
        return;
      this.WaitAfterConnect = 5000;
    }
  }
}
