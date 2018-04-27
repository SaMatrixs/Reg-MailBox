// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.frmGenBlank
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [DesignerGenerated]
  public class frmGenBlank : Form
  {
    private IContainer components;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("txtLoadLogDIV")]
    private TextBox _txtLoadLogDIV;
    [AccessedThroughProperty("OpenFileDialog1")]
    private OpenFileDialog _OpenFileDialog1;
    [AccessedThroughProperty("GroupBox5")]
    private GroupBox _GroupBox5;
    [AccessedThroughProperty("txtLastName")]
    private TextBox _txtLastName;
    [AccessedThroughProperty("txtName")]
    private TextBox _txtName;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("chRND_1")]
    private CheckBox _chRND_1;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("cmbUserSex")]
    private ComboBox _cmbUserSex;
    [AccessedThroughProperty("chRND_2")]
    private CheckBox _chRND_2;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("cmbTown")]
    private ComboBox _cmbTown;
    [AccessedThroughProperty("txtTown")]
    private TextBox _txtTown;
    [AccessedThroughProperty("chRND_3")]
    private CheckBox _chRND_3;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("cmbAccSel_Domain")]
    private ComboBox _cmbAccSel_Domain;
    [AccessedThroughProperty("chRND_4")]
    private CheckBox _chRND_4;
    [AccessedThroughProperty("GroupBox4")]
    private GroupBox _GroupBox4;
    [AccessedThroughProperty("txtUserGenPass")]
    private TextBox _txtUserGenPass;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("PictureBox4")]
    private PictureBox _PictureBox4;
    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;
    [AccessedThroughProperty("chRND_5")]
    private CheckBox _chRND_5;
    [AccessedThroughProperty("PictureBox7")]
    private PictureBox _PictureBox7;
    [AccessedThroughProperty("PictureBox6")]
    private PictureBox _PictureBox6;
    [AccessedThroughProperty("PictureBox5")]
    private PictureBox _PictureBox5;
    [AccessedThroughProperty("PictureBox8")]
    private PictureBox _PictureBox8;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("txtAnswer")]
    private TextBox _txtAnswer;
    [AccessedThroughProperty("cmbUserQuest")]
    private ComboBox _cmbUserQuest;
    [AccessedThroughProperty("chRND_6")]
    private CheckBox _chRND_6;
    [AccessedThroughProperty("cmbUserYearBD")]
    private ComboBox _cmbUserYearBD;
    [AccessedThroughProperty("cmbUserMonthBD")]
    private ComboBox _cmbUserMonthBD;
    [AccessedThroughProperty("cmbUserDayBD")]
    private ComboBox _cmbUserDayBD;
    [AccessedThroughProperty("chRND_7")]
    private CheckBox _chRND_7;
    [AccessedThroughProperty("chRND_8")]
    private CheckBox _chRND_8;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("chDopMethod_1")]
    private CheckBox _chDopMethod_1;
    [AccessedThroughProperty("chMethod_3")]
    private CheckBox _chMethod_3;
    [AccessedThroughProperty("chUseAllMethod")]
    private CheckBox _chUseAllMethod;
    [AccessedThroughProperty("chDopMethod_3")]
    private CheckBox _chDopMethod_3;
    [AccessedThroughProperty("chMethod_1")]
    private CheckBox _chMethod_1;
    [AccessedThroughProperty("chDopMethod_2")]
    private CheckBox _chDopMethod_2;
    [AccessedThroughProperty("chMethod_2")]
    private CheckBox _chMethod_2;
    [AccessedThroughProperty("chMethod_4")]
    private CheckBox _chMethod_4;
    [AccessedThroughProperty("grOpWordGen")]
    private GroupBox _grOpWordGen;
    [AccessedThroughProperty("txtGenMaxLen")]
    private TextBox _txtGenMaxLen;
    [AccessedThroughProperty("txtGenMinLen")]
    private TextBox _txtGenMinLen;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("lblChanse_4")]
    private Label _lblChanse_4;
    [AccessedThroughProperty("lblChanse_3")]
    private Label _lblChanse_3;
    [AccessedThroughProperty("lblChanse_2")]
    private Label _lblChanse_2;
    [AccessedThroughProperty("lblChanse_1")]
    private Label _lblChanse_1;
    [AccessedThroughProperty("cmbDoubleSOglas")]
    private ComboBox _cmbDoubleSOglas;
    [AccessedThroughProperty("cmbDoubleGlas")]
    private ComboBox _cmbDoubleGlas;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("cmbUseNum")]
    private ComboBox _cmbUseNum;
    [AccessedThroughProperty("chDoubleSOglas")]
    private CheckBox _chDoubleSOglas;
    [AccessedThroughProperty("chDoubleGlas")]
    private CheckBox _chDoubleGlas;
    [AccessedThroughProperty("picWarning")]
    private PictureBox _picWarning;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("lblInfo")]
    private Label _lblInfo;
    [AccessedThroughProperty("chDopMethod_4")]
    private CheckBox _chDopMethod_4;
    [AccessedThroughProperty("PictureBox9")]
    private PictureBox _PictureBox9;
    [AccessedThroughProperty("GroupBox6")]
    private GroupBox _GroupBox6;
    [AccessedThroughProperty("btmTestGen")]
    private Button _btmTestGen;
    [AccessedThroughProperty("txtTestLogin")]
    private TextBox _txtTestLogin;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("txtGenCount")]
    private TextBox _txtGenCount;
    [AccessedThroughProperty("cmbUseNumPercent")]
    private ComboBox _cmbUseNumPercent;
    [AccessedThroughProperty("cmbDopPercent_4")]
    private ComboBox _cmbDopPercent_4;
    [AccessedThroughProperty("cmbDopPercent_3")]
    private ComboBox _cmbDopPercent_3;
    [AccessedThroughProperty("cmbDopPercent_2")]
    private ComboBox _cmbDopPercent_2;
    [AccessedThroughProperty("cmbDopPercent_1")]
    private ComboBox _cmbDopPercent_1;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("lblBUSY")]
    private Label _lblBUSY;
    [AccessedThroughProperty("rbSelectMail_0")]
    private RadioButton _rbSelectMail_0;
    [AccessedThroughProperty("rbSelectMail_2")]
    private RadioButton _rbSelectMail_2;
    [AccessedThroughProperty("rbSelectMail_1")]
    private RadioButton _rbSelectMail_1;
    [AccessedThroughProperty("RadioButton3")]
    private RadioButton _RadioButton3;
    [AccessedThroughProperty("RadioButton4")]
    private RadioButton _RadioButton4;
    [AccessedThroughProperty("rbSelectMail_3")]
    private RadioButton _rbSelectMail_3;
    [AccessedThroughProperty("RadioButton6")]
    private RadioButton _RadioButton6;
    [AccessedThroughProperty("RadioButton7")]
    private RadioButton _RadioButton7;
    [AccessedThroughProperty("RadioButton8")]
    private RadioButton _RadioButton8;
    [AccessedThroughProperty("RadioButton9")]
    private RadioButton _RadioButton9;
    [AccessedThroughProperty("RadioButton10")]
    private RadioButton _RadioButton10;
    [AccessedThroughProperty("RadioButton11")]
    private RadioButton _RadioButton11;
    [AccessedThroughProperty("Label19")]
    private Label _Label19;
    [AccessedThroughProperty("сhYandexPause")]
    private CheckBox _сhYandexPause;
    [AccessedThroughProperty("chHardCheck")]
    private CheckBox _chHardCheck;
    [AccessedThroughProperty("Label20")]
    private Label _Label20;
    [AccessedThroughProperty("GroupBox7")]
    private GroupBox _GroupBox7;
    [AccessedThroughProperty("PictureBox10")]
    private PictureBox _PictureBox10;
    [AccessedThroughProperty("btnLoadData")]
    private Button _btnLoadData;
    [AccessedThroughProperty("cmbLoadLogOtherData")]
    private ComboBox _cmbLoadLogOtherData;
    [AccessedThroughProperty("Label22")]
    private Label _Label22;
    [AccessedThroughProperty("boxLoadData_Pole1")]
    private GroupBox _boxLoadData_Pole1;
    [AccessedThroughProperty("cmbLoadData_Pole1")]
    private ComboBox _cmbLoadData_Pole1;
    [AccessedThroughProperty("chLoadData_Pole1")]
    private CheckBox _chLoadData_Pole1;
    [AccessedThroughProperty("GroupBox16")]
    private GroupBox _GroupBox16;
    [AccessedThroughProperty("lblLoadData_Example")]
    private Label _lblLoadData_Example;
    [AccessedThroughProperty("boxLoadData_Pole8")]
    private GroupBox _boxLoadData_Pole8;
    [AccessedThroughProperty("cmbLoadData_Pole8")]
    private ComboBox _cmbLoadData_Pole8;
    [AccessedThroughProperty("chLoadData_Pole8")]
    private CheckBox _chLoadData_Pole8;
    [AccessedThroughProperty("boxLoadData_Pole7")]
    private GroupBox _boxLoadData_Pole7;
    [AccessedThroughProperty("cmbLoadData_Pole7")]
    private ComboBox _cmbLoadData_Pole7;
    [AccessedThroughProperty("chLoadData_Pole7")]
    private CheckBox _chLoadData_Pole7;
    [AccessedThroughProperty("boxLoadData_Pole6")]
    private GroupBox _boxLoadData_Pole6;
    [AccessedThroughProperty("cmbLoadData_Pole6")]
    private ComboBox _cmbLoadData_Pole6;
    [AccessedThroughProperty("chLoadData_Pole6")]
    private CheckBox _chLoadData_Pole6;
    [AccessedThroughProperty("boxLoadData_Pole5")]
    private GroupBox _boxLoadData_Pole5;
    [AccessedThroughProperty("cmbLoadData_Pole5")]
    private ComboBox _cmbLoadData_Pole5;
    [AccessedThroughProperty("chLoadData_Pole5")]
    private CheckBox _chLoadData_Pole5;
    [AccessedThroughProperty("boxLoadData_Pole4")]
    private GroupBox _boxLoadData_Pole4;
    [AccessedThroughProperty("cmbLoadData_Pole4")]
    private ComboBox _cmbLoadData_Pole4;
    [AccessedThroughProperty("chLoadData_Pole4")]
    private CheckBox _chLoadData_Pole4;
    [AccessedThroughProperty("boxLoadData_Pole3")]
    private GroupBox _boxLoadData_Pole3;
    [AccessedThroughProperty("cmbLoadData_Pole3")]
    private ComboBox _cmbLoadData_Pole3;
    [AccessedThroughProperty("chLoadData_Pole3")]
    private CheckBox _chLoadData_Pole3;
    [AccessedThroughProperty("boxLoadData_Pole2")]
    private GroupBox _boxLoadData_Pole2;
    [AccessedThroughProperty("cmbLoadData_Pole2")]
    private ComboBox _cmbLoadData_Pole2;
    [AccessedThroughProperty("chLoadData_Pole2")]
    private CheckBox _chLoadData_Pole2;
    [AccessedThroughProperty("pbGenLogin")]
    private ProgressBar _pbGenLogin;

    public frmGenBlank()
    {
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmGenBlank));
      this.GroupBox2 = new GroupBox();
      this.txtLoadLogDIV = new TextBox();
      this.OpenFileDialog1 = new OpenFileDialog();
      this.GroupBox5 = new GroupBox();
      this.txtName = new TextBox();
      this.txtLastName = new TextBox();
      this.Label10 = new Label();
      this.chRND_1 = new CheckBox();
      this.Label7 = new Label();
      this.PictureBox1 = new PictureBox();
      this.cmbUserSex = new ComboBox();
      this.chRND_2 = new CheckBox();
      this.Label4 = new Label();
      this.ImageList1 = new ImageList(this.components);
      this.Label5 = new Label();
      this.cmbTown = new ComboBox();
      this.txtTown = new TextBox();
      this.chRND_3 = new CheckBox();
      this.Label8 = new Label();
      this.cmbAccSel_Domain = new ComboBox();
      this.chRND_4 = new CheckBox();
      this.GroupBox4 = new GroupBox();
      this.lblBUSY = new Label();
      this.Label18 = new Label();
      this.Label6 = new Label();
      this.cmbDopPercent_4 = new ComboBox();
      this.cmbDopPercent_3 = new ComboBox();
      this.cmbDopPercent_2 = new ComboBox();
      this.cmbDopPercent_1 = new ComboBox();
      this.cmbUseNumPercent = new ComboBox();
      this.chDopMethod_4 = new CheckBox();
      this.Label17 = new Label();
      this.picWarning = new PictureBox();
      this.lblChanse_4 = new Label();
      this.lblChanse_3 = new Label();
      this.lblChanse_2 = new Label();
      this.lblChanse_1 = new Label();
      this.grOpWordGen = new GroupBox();
      this.cmbDoubleSOglas = new ComboBox();
      this.cmbDoubleGlas = new ComboBox();
      this.Label16 = new Label();
      this.cmbUseNum = new ComboBox();
      this.chDoubleSOglas = new CheckBox();
      this.chDoubleGlas = new CheckBox();
      this.txtGenMaxLen = new TextBox();
      this.txtGenMinLen = new TextBox();
      this.Label15 = new Label();
      this.Label14 = new Label();
      this.chMethod_4 = new CheckBox();
      this.chMethod_3 = new CheckBox();
      this.chUseAllMethod = new CheckBox();
      this.chDopMethod_3 = new CheckBox();
      this.chMethod_1 = new CheckBox();
      this.chDopMethod_2 = new CheckBox();
      this.chMethod_2 = new CheckBox();
      this.Label13 = new Label();
      this.chDopMethod_1 = new CheckBox();
      this.chRND_7 = new CheckBox();
      this.chRND_8 = new CheckBox();
      this.PictureBox8 = new PictureBox();
      this.Label12 = new Label();
      this.Label11 = new Label();
      this.txtAnswer = new TextBox();
      this.cmbUserQuest = new ComboBox();
      this.chRND_6 = new CheckBox();
      this.cmbUserYearBD = new ComboBox();
      this.cmbUserMonthBD = new ComboBox();
      this.cmbUserDayBD = new ComboBox();
      this.chRND_5 = new CheckBox();
      this.PictureBox7 = new PictureBox();
      this.PictureBox6 = new PictureBox();
      this.PictureBox5 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      this.PictureBox3 = new PictureBox();
      this.txtUserGenPass = new TextBox();
      this.Label9 = new Label();
      this.lblInfo = new Label();
      this.PictureBox9 = new PictureBox();
      this.GroupBox6 = new GroupBox();
      this.btmTestGen = new Button();
      this.txtTestLogin = new TextBox();
      this.Button2 = new Button();
      this.txtGenCount = new TextBox();
      this.rbSelectMail_0 = new RadioButton();
      this.rbSelectMail_2 = new RadioButton();
      this.rbSelectMail_1 = new RadioButton();
      this.RadioButton3 = new RadioButton();
      this.RadioButton4 = new RadioButton();
      this.rbSelectMail_3 = new RadioButton();
      this.RadioButton6 = new RadioButton();
      this.RadioButton7 = new RadioButton();
      this.RadioButton8 = new RadioButton();
      this.RadioButton9 = new RadioButton();
      this.RadioButton10 = new RadioButton();
      this.RadioButton11 = new RadioButton();
      this.Label19 = new Label();
      this.сhYandexPause = new CheckBox();
      this.chHardCheck = new CheckBox();
      this.Label20 = new Label();
      this.GroupBox7 = new GroupBox();
      this.boxLoadData_Pole8 = new GroupBox();
      this.cmbLoadData_Pole8 = new ComboBox();
      this.chLoadData_Pole8 = new CheckBox();
      this.boxLoadData_Pole7 = new GroupBox();
      this.cmbLoadData_Pole7 = new ComboBox();
      this.chLoadData_Pole7 = new CheckBox();
      this.boxLoadData_Pole6 = new GroupBox();
      this.cmbLoadData_Pole6 = new ComboBox();
      this.chLoadData_Pole6 = new CheckBox();
      this.boxLoadData_Pole5 = new GroupBox();
      this.cmbLoadData_Pole5 = new ComboBox();
      this.chLoadData_Pole5 = new CheckBox();
      this.boxLoadData_Pole4 = new GroupBox();
      this.cmbLoadData_Pole4 = new ComboBox();
      this.chLoadData_Pole4 = new CheckBox();
      this.boxLoadData_Pole3 = new GroupBox();
      this.cmbLoadData_Pole3 = new ComboBox();
      this.chLoadData_Pole3 = new CheckBox();
      this.boxLoadData_Pole2 = new GroupBox();
      this.cmbLoadData_Pole2 = new ComboBox();
      this.chLoadData_Pole2 = new CheckBox();
      this.GroupBox16 = new GroupBox();
      this.lblLoadData_Example = new Label();
      this.boxLoadData_Pole1 = new GroupBox();
      this.cmbLoadData_Pole1 = new ComboBox();
      this.chLoadData_Pole1 = new CheckBox();
      this.PictureBox10 = new PictureBox();
      this.btnLoadData = new Button();
      this.cmbLoadLogOtherData = new ComboBox();
      this.Label22 = new Label();
      this.pbGenLogin = new ProgressBar();
      this.GroupBox2.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.GroupBox4.SuspendLayout();
      ((ISupportInitialize) this.picWarning).BeginInit();
      this.grOpWordGen.SuspendLayout();
      ((ISupportInitialize) this.PictureBox8).BeginInit();
      ((ISupportInitialize) this.PictureBox7).BeginInit();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      ((ISupportInitialize) this.PictureBox3).BeginInit();
      ((ISupportInitialize) this.PictureBox9).BeginInit();
      this.GroupBox6.SuspendLayout();
      this.GroupBox7.SuspendLayout();
      this.boxLoadData_Pole8.SuspendLayout();
      this.boxLoadData_Pole7.SuspendLayout();
      this.boxLoadData_Pole6.SuspendLayout();
      this.boxLoadData_Pole5.SuspendLayout();
      this.boxLoadData_Pole4.SuspendLayout();
      this.boxLoadData_Pole3.SuspendLayout();
      this.boxLoadData_Pole2.SuspendLayout();
      this.GroupBox16.SuspendLayout();
      this.boxLoadData_Pole1.SuspendLayout();
      ((ISupportInitialize) this.PictureBox10).BeginInit();
      this.SuspendLayout();
      this.GroupBox2.Controls.Add((Control) this.txtLoadLogDIV);
      this.GroupBox2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox2_1 = this.GroupBox2;
      Point point1 = new Point(52, 22);
      Point point2 = point1;
      groupBox2_1.Location = point2;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      Size size1 = new Size(90, 46);
      Size size2 = size1;
      groupBox2_2.Size = size2;
      this.GroupBox2.TabIndex = 0;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "разделитель";
      this.txtLoadLogDIV.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtLoadLogDiv1 = this.txtLoadLogDIV;
      point1 = new Point(4, 18);
      Point point3 = point1;
      txtLoadLogDiv1.Location = point3;
      this.txtLoadLogDIV.MaxLength = 1;
      this.txtLoadLogDIV.Name = "txtLoadLogDIV";
      TextBox txtLoadLogDiv2 = this.txtLoadLogDIV;
      size1 = new Size(82, 23);
      Size size3 = size1;
      txtLoadLogDiv2.Size = size3;
      this.txtLoadLogDIV.TabIndex = 0;
      this.txtLoadLogDIV.TextAlign = HorizontalAlignment.Center;
      this.OpenFileDialog1.ShowReadOnly = true;
      this.OpenFileDialog1.SupportMultiDottedExtensions = true;
      this.OpenFileDialog1.Title = "Загрузить список заготовок e-Mail";
      this.GroupBox5.Controls.Add((Control) this.txtName);
      this.GroupBox5.Controls.Add((Control) this.txtLastName);
      this.GroupBox5.Controls.Add((Control) this.Label10);
      this.GroupBox5.Controls.Add((Control) this.chRND_1);
      this.GroupBox5.Controls.Add((Control) this.Label7);
      GroupBox groupBox5_1 = this.GroupBox5;
      point1 = new Point(75, 26);
      Point point4 = point1;
      groupBox5_1.Location = point4;
      this.GroupBox5.Name = "GroupBox5";
      GroupBox groupBox5_2 = this.GroupBox5;
      size1 = new Size(166, 94);
      Size size4 = size1;
      groupBox5_2.Size = size4;
      this.GroupBox5.TabIndex = 91;
      this.GroupBox5.TabStop = false;
      this.txtName.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtName1 = this.txtName;
      point1 = new Point(2, 30);
      Point point5 = point1;
      txtName1.Location = point5;
      this.txtName.Name = "txtName";
      TextBox txtName2 = this.txtName;
      size1 = new Size(160, 22);
      Size size5 = size1;
      txtName2.Size = size5;
      this.txtName.TabIndex = 79;
      this.txtName.TextAlign = HorizontalAlignment.Center;
      this.txtName.WordWrap = false;
      this.txtLastName.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtLastName1 = this.txtLastName;
      point1 = new Point(2, 64);
      Point point6 = point1;
      txtLastName1.Location = point6;
      this.txtLastName.Name = "txtLastName";
      TextBox txtLastName2 = this.txtLastName;
      size1 = new Size(160, 22);
      Size size6 = size1;
      txtLastName2.Size = size6;
      this.txtLastName.TabIndex = 80;
      this.txtLastName.TextAlign = HorizontalAlignment.Center;
      this.txtLastName.WordWrap = false;
      this.Label10.Font = new Font("Tahoma", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label10.ForeColor = Color.Black;
      Label label10_1 = this.Label10;
      point1 = new Point(2, 54);
      Point point7 = point1;
      label10_1.Location = point7;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(46, 13);
      Size size7 = size1;
      label10_2.Size = size7;
      this.Label10.TabIndex = 82;
      this.Label10.Text = "ФАМИЛИЯ";
      this.chRND_1.AutoSize = true;
      this.chRND_1.CheckAlign = ContentAlignment.MiddleRight;
      this.chRND_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chRND_1.ForeColor = Color.Black;
      CheckBox chRnd1_1 = this.chRND_1;
      point1 = new Point(88, 12);
      Point point8 = point1;
      chRnd1_1.Location = point8;
      this.chRND_1.Name = "chRND_1";
      CheckBox chRnd1_2 = this.chRND_1;
      size1 = new Size(73, 17);
      Size size8 = size1;
      chRnd1_2.Size = size8;
      this.chRND_1.TabIndex = 84;
      this.chRND_1.Text = "случайно";
      this.chRND_1.TextAlign = ContentAlignment.MiddleCenter;
      this.chRND_1.UseVisualStyleBackColor = true;
      this.Label7.Font = new Font("Tahoma", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label7.ForeColor = Color.Black;
      Label label7_1 = this.Label7;
      point1 = new Point(2, 18);
      Point point9 = point1;
      label7_1.Location = point9;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(34, 13);
      Size size9 = size1;
      label7_2.Size = size9;
      this.Label7.TabIndex = 81;
      this.Label7.Text = "ИМЯ";
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(10, 40);
      Point point10 = point1;
      pictureBox1_1.Location = point10;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(64, 64);
      Size size10 = size1;
      pictureBox1_2.Size = size10;
      this.PictureBox1.TabIndex = 95;
      this.PictureBox1.TabStop = false;
      this.cmbUserSex.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbUserSex.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbUserSex.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbUserSex.ForeColor = Color.Black;
      this.cmbUserSex.FormattingEnabled = true;
      this.cmbUserSex.Items.AddRange(new object[2]
      {
        (object) "мужской",
        (object) "женский"
      });
      ComboBox cmbUserSex1 = this.cmbUserSex;
      point1 = new Point(74, 130);
      Point point11 = point1;
      cmbUserSex1.Location = point11;
      this.cmbUserSex.Name = "cmbUserSex";
      ComboBox cmbUserSex2 = this.cmbUserSex;
      size1 = new Size(88, 21);
      Size size11 = size1;
      cmbUserSex2.Size = size11;
      this.cmbUserSex.TabIndex = 96;
      this.cmbUserSex.TabStop = false;
      this.chRND_2.AutoSize = true;
      this.chRND_2.CheckAlign = ContentAlignment.MiddleRight;
      this.chRND_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chRND_2.ForeColor = Color.Black;
      CheckBox chRnd2_1 = this.chRND_2;
      point1 = new Point(168, 132);
      Point point12 = point1;
      chRnd2_1.Location = point12;
      this.chRND_2.Name = "chRND_2";
      CheckBox chRnd2_2 = this.chRND_2;
      size1 = new Size(73, 17);
      Size size12 = size1;
      chRnd2_2.Size = size12;
      this.chRND_2.TabIndex = 97;
      this.chRND_2.Text = "случайно";
      this.chRND_2.TextAlign = ContentAlignment.MiddleCenter;
      this.chRND_2.UseVisualStyleBackColor = true;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Label4.ForeColor = Color.Black;
      Label label4_1 = this.Label4;
      point1 = new Point(19, 133);
      Point point13 = point1;
      label4_1.Location = point13;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(38, 14);
      Size size13 = size1;
      label4_2.Size = size13;
      this.Label4.TabIndex = 98;
      this.Label4.Text = "ПОЛ:";
      this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.ImageList1.Images.SetKeyName(0, "user_male.png");
      this.ImageList1.Images.SetKeyName(1, "user_female.png");
      this.ImageList1.Images.SetKeyName(2, "loginmanager.png");
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Label5.ForeColor = Color.Black;
      Label label5_1 = this.Label5;
      point1 = new Point(14, 173);
      Point point14 = point1;
      label5_1.Location = point14;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(54, 14);
      Size size14 = size1;
      label5_2.Size = size14;
      this.Label5.TabIndex = 99;
      this.Label5.Text = "ГОРОД:";
      this.cmbTown.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbTown.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbTown.DropDownWidth = 260;
      this.cmbTown.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbTown.ForeColor = Color.Black;
      this.cmbTown.FormattingEnabled = true;
      this.cmbTown.Items.AddRange(new object[12]
      {
        (object) "Санкт-Петербург",
        (object) "Москва",
        (object) "Новосибирск",
        (object) "Челябинск",
        (object) "Казань",
        (object) "Екатеринбург",
        (object) "Красноярск",
        (object) "Уфа",
        (object) "Самара",
        (object) "Нижний Новгород",
        (object) "Краснодар",
        (object) "Ростов-на-Дону"
      });
      ComboBox cmbTown1 = this.cmbTown;
      point1 = new Point(75, 161);
      Point point15 = point1;
      cmbTown1.Location = point15;
      this.cmbTown.Name = "cmbTown";
      ComboBox cmbTown2 = this.cmbTown;
      size1 = new Size(147, 21);
      Size size15 = size1;
      cmbTown2.Size = size15;
      this.cmbTown.TabIndex = 100;
      this.cmbTown.TabStop = false;
      this.txtTown.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtTown1 = this.txtTown;
      point1 = new Point(74, 182);
      Point point16 = point1;
      txtTown1.Location = point16;
      this.txtTown.Name = "txtTown";
      TextBox txtTown2 = this.txtTown;
      size1 = new Size(148, 21);
      Size size16 = size1;
      txtTown2.Size = size16;
      this.txtTown.TabIndex = 101;
      this.txtTown.TextAlign = HorizontalAlignment.Center;
      this.txtTown.WordWrap = false;
      this.chRND_3.AutoSize = true;
      this.chRND_3.CheckAlign = ContentAlignment.MiddleRight;
      this.chRND_3.ForeColor = Color.Black;
      CheckBox chRnd3_1 = this.chRND_3;
      point1 = new Point(226, 173);
      Point point17 = point1;
      chRnd3_1.Location = point17;
      this.chRND_3.Name = "chRND_3";
      CheckBox chRnd3_2 = this.chRND_3;
      size1 = new Size(15, 14);
      Size size17 = size1;
      chRnd3_2.Size = size17;
      this.chRND_3.TabIndex = 102;
      this.chRND_3.TextAlign = ContentAlignment.MiddleCenter;
      this.chRND_3.UseVisualStyleBackColor = true;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Label8.ForeColor = Color.Black;
      Label label8_1 = this.Label8;
      point1 = new Point(12, 216);
      Point point18 = point1;
      label8_1.Location = point18;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(57, 14);
      Size size18 = size1;
      label8_2.Size = size18;
      this.Label8.TabIndex = 104;
      this.Label8.Text = "ДОМЕН:";
      this.cmbAccSel_Domain.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbAccSel_Domain.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbAccSel_Domain.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.cmbAccSel_Domain.FormattingEnabled = true;
      this.cmbAccSel_Domain.Items.AddRange(new object[5]
      {
        (object) "@mail.ru",
        (object) "@inbox.ru",
        (object) "@bk.ru",
        (object) "@list.ru",
        (object) "@mail.ua"
      });
      ComboBox cmbAccSelDomain1 = this.cmbAccSel_Domain;
      point1 = new Point(75, 213);
      Point point19 = point1;
      cmbAccSelDomain1.Location = point19;
      this.cmbAccSel_Domain.Name = "cmbAccSel_Domain";
      ComboBox cmbAccSelDomain2 = this.cmbAccSel_Domain;
      size1 = new Size(94, 21);
      Size size19 = size1;
      cmbAccSelDomain2.Size = size19;
      this.cmbAccSel_Domain.TabIndex = 105;
      this.cmbAccSel_Domain.TabStop = false;
      this.chRND_4.AutoSize = true;
      this.chRND_4.CheckAlign = ContentAlignment.MiddleRight;
      this.chRND_4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chRND_4.ForeColor = Color.Black;
      CheckBox chRnd4_1 = this.chRND_4;
      point1 = new Point(168, 215);
      Point point20 = point1;
      chRnd4_1.Location = point20;
      this.chRND_4.Name = "chRND_4";
      CheckBox chRnd4_2 = this.chRND_4;
      size1 = new Size(73, 17);
      Size size20 = size1;
      chRnd4_2.Size = size20;
      this.chRND_4.TabIndex = 106;
      this.chRND_4.Text = "случайно";
      this.chRND_4.TextAlign = ContentAlignment.MiddleCenter;
      this.chRND_4.UseVisualStyleBackColor = true;
      this.GroupBox4.Controls.Add((Control) this.lblBUSY);
      this.GroupBox4.Controls.Add((Control) this.Label18);
      this.GroupBox4.Controls.Add((Control) this.Label6);
      this.GroupBox4.Controls.Add((Control) this.cmbDopPercent_4);
      this.GroupBox4.Controls.Add((Control) this.cmbDopPercent_3);
      this.GroupBox4.Controls.Add((Control) this.cmbDopPercent_2);
      this.GroupBox4.Controls.Add((Control) this.cmbDopPercent_1);
      this.GroupBox4.Controls.Add((Control) this.cmbUseNumPercent);
      this.GroupBox4.Controls.Add((Control) this.chDopMethod_4);
      this.GroupBox4.Controls.Add((Control) this.Label17);
      this.GroupBox4.Controls.Add((Control) this.picWarning);
      this.GroupBox4.Controls.Add((Control) this.lblChanse_4);
      this.GroupBox4.Controls.Add((Control) this.lblChanse_3);
      this.GroupBox4.Controls.Add((Control) this.lblChanse_2);
      this.GroupBox4.Controls.Add((Control) this.lblChanse_1);
      this.GroupBox4.Controls.Add((Control) this.grOpWordGen);
      this.GroupBox4.Controls.Add((Control) this.chMethod_4);
      this.GroupBox4.Controls.Add((Control) this.chMethod_3);
      this.GroupBox4.Controls.Add((Control) this.chUseAllMethod);
      this.GroupBox4.Controls.Add((Control) this.chDopMethod_3);
      this.GroupBox4.Controls.Add((Control) this.chMethod_1);
      this.GroupBox4.Controls.Add((Control) this.chDopMethod_2);
      this.GroupBox4.Controls.Add((Control) this.chMethod_2);
      this.GroupBox4.Controls.Add((Control) this.Label13);
      this.GroupBox4.Controls.Add((Control) this.chDopMethod_1);
      this.GroupBox4.Controls.Add((Control) this.chRND_7);
      this.GroupBox4.Controls.Add((Control) this.chRND_8);
      this.GroupBox4.Controls.Add((Control) this.PictureBox8);
      this.GroupBox4.Controls.Add((Control) this.Label12);
      this.GroupBox4.Controls.Add((Control) this.Label11);
      this.GroupBox4.Controls.Add((Control) this.txtAnswer);
      this.GroupBox4.Controls.Add((Control) this.cmbUserQuest);
      this.GroupBox4.Controls.Add((Control) this.chRND_6);
      this.GroupBox4.Controls.Add((Control) this.cmbUserYearBD);
      this.GroupBox4.Controls.Add((Control) this.cmbUserMonthBD);
      this.GroupBox4.Controls.Add((Control) this.cmbUserDayBD);
      this.GroupBox4.Controls.Add((Control) this.chRND_5);
      this.GroupBox4.Controls.Add((Control) this.PictureBox7);
      this.GroupBox4.Controls.Add((Control) this.PictureBox6);
      this.GroupBox4.Controls.Add((Control) this.PictureBox5);
      this.GroupBox4.Controls.Add((Control) this.PictureBox4);
      this.GroupBox4.Controls.Add((Control) this.PictureBox3);
      this.GroupBox4.Controls.Add((Control) this.txtUserGenPass);
      this.GroupBox4.Controls.Add((Control) this.Label9);
      this.GroupBox4.Controls.Add((Control) this.PictureBox1);
      this.GroupBox4.Controls.Add((Control) this.chRND_2);
      this.GroupBox4.Controls.Add((Control) this.cmbAccSel_Domain);
      this.GroupBox4.Controls.Add((Control) this.GroupBox5);
      this.GroupBox4.Controls.Add((Control) this.Label8);
      this.GroupBox4.Controls.Add((Control) this.cmbUserSex);
      this.GroupBox4.Controls.Add((Control) this.Label4);
      this.GroupBox4.Controls.Add((Control) this.chRND_3);
      this.GroupBox4.Controls.Add((Control) this.Label5);
      this.GroupBox4.Controls.Add((Control) this.txtTown);
      this.GroupBox4.Controls.Add((Control) this.cmbTown);
      this.GroupBox4.Controls.Add((Control) this.chRND_4);
      this.GroupBox4.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.GroupBox4.ForeColor = Color.FromArgb(0, 64, 64);
      GroupBox groupBox4_1 = this.GroupBox4;
      point1 = new Point(121, 121);
      Point point21 = point1;
      groupBox4_1.Location = point21;
      this.GroupBox4.Name = "GroupBox4";
      GroupBox groupBox4_2 = this.GroupBox4;
      size1 = new Size(490, 350);
      Size size21 = size1;
      groupBox4_2.Size = size21;
      this.GroupBox4.TabIndex = 107;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Генерировать";
      this.lblBUSY.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lblBUSY.BackColor = Color.White;
      this.lblBUSY.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lblBUSY.ForeColor = Color.Red;
      Label lblBusy1 = this.lblBUSY;
      point1 = new Point(176, 0);
      Point point22 = point1;
      lblBusy1.Location = point22;
      this.lblBUSY.Name = "lblBUSY";
      Label lblBusy2 = this.lblBUSY;
      size1 = new Size(332, 30);
      Size size22 = size1;
      lblBusy2.Size = size22;
      this.lblBUSY.TabIndex = 132;
      this.lblBUSY.Text = "Идет загрузка и парсинг";
      this.lblBUSY.TextAlign = ContentAlignment.MiddleCenter;
      this.lblBUSY.Visible = false;
      this.Label18.AutoSize = true;
      this.Label18.Font = new Font("Tahoma", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label18.ForeColor = Color.Black;
      Label label18_1 = this.Label18;
      point1 = new Point(449, 250);
      Point point23 = point1;
      label18_1.Location = point23;
      this.Label18.Name = "Label18";
      Label label18_2 = this.Label18;
      size1 = new Size(28, 10);
      Size size23 = size1;
      label18_2.Size = size23;
      this.Label18.TabIndex = 152;
      this.Label18.Text = "ШАНС";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Tahoma", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Label6.ForeColor = Color.Black;
      Label label6_1 = this.Label6;
      point1 = new Point(447, 206);
      Point point24 = point1;
      label6_1.Location = point24;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(30, 10);
      Size size24 = size1;
      label6_2.Size = size24;
      this.Label6.TabIndex = 151;
      this.Label6.Text = "ДЛИНА";
      this.cmbDopPercent_4.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbDopPercent_4.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbDopPercent_4.Enabled = false;
      this.cmbDopPercent_4.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbDopPercent_4.ForeColor = Color.Black;
      this.cmbDopPercent_4.FormattingEnabled = true;
      ComboBox cmbDopPercent4_1 = this.cmbDopPercent_4;
      point1 = new Point(440, 329);
      Point point25 = point1;
      cmbDopPercent4_1.Location = point25;
      this.cmbDopPercent_4.Name = "cmbDopPercent_4";
      ComboBox cmbDopPercent4_2 = this.cmbDopPercent_4;
      size1 = new Size(46, 19);
      Size size25 = size1;
      cmbDopPercent4_2.Size = size25;
      this.cmbDopPercent_4.TabIndex = 150;
      this.cmbDopPercent_4.TabStop = false;
      this.cmbDopPercent_3.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbDopPercent_3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbDopPercent_3.Enabled = false;
      this.cmbDopPercent_3.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbDopPercent_3.ForeColor = Color.Black;
      this.cmbDopPercent_3.FormattingEnabled = true;
      ComboBox cmbDopPercent3_1 = this.cmbDopPercent_3;
      point1 = new Point(440, 306);
      Point point26 = point1;
      cmbDopPercent3_1.Location = point26;
      this.cmbDopPercent_3.Name = "cmbDopPercent_3";
      ComboBox cmbDopPercent3_2 = this.cmbDopPercent_3;
      size1 = new Size(46, 19);
      Size size26 = size1;
      cmbDopPercent3_2.Size = size26;
      this.cmbDopPercent_3.TabIndex = 149;
      this.cmbDopPercent_3.TabStop = false;
      this.cmbDopPercent_2.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbDopPercent_2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbDopPercent_2.Enabled = false;
      this.cmbDopPercent_2.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbDopPercent_2.ForeColor = Color.Black;
      this.cmbDopPercent_2.FormattingEnabled = true;
      ComboBox cmbDopPercent2_1 = this.cmbDopPercent_2;
      point1 = new Point(440, 284);
      Point point27 = point1;
      cmbDopPercent2_1.Location = point27;
      this.cmbDopPercent_2.Name = "cmbDopPercent_2";
      ComboBox cmbDopPercent2_2 = this.cmbDopPercent_2;
      size1 = new Size(46, 19);
      Size size27 = size1;
      cmbDopPercent2_2.Size = size27;
      this.cmbDopPercent_2.TabIndex = 148;
      this.cmbDopPercent_2.TabStop = false;
      this.cmbDopPercent_1.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbDopPercent_1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbDopPercent_1.Enabled = false;
      this.cmbDopPercent_1.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbDopPercent_1.ForeColor = Color.Black;
      this.cmbDopPercent_1.FormattingEnabled = true;
      ComboBox cmbDopPercent1_1 = this.cmbDopPercent_1;
      point1 = new Point(440, 262);
      Point point28 = point1;
      cmbDopPercent1_1.Location = point28;
      this.cmbDopPercent_1.Name = "cmbDopPercent_1";
      ComboBox cmbDopPercent1_2 = this.cmbDopPercent_1;
      size1 = new Size(46, 19);
      Size size28 = size1;
      cmbDopPercent1_2.Size = size28;
      this.cmbDopPercent_1.TabIndex = 147;
      this.cmbDopPercent_1.TabStop = false;
      this.cmbUseNumPercent.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbUseNumPercent.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbUseNumPercent.Enabled = false;
      this.cmbUseNumPercent.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbUseNumPercent.ForeColor = Color.Black;
      this.cmbUseNumPercent.FormattingEnabled = true;
      ComboBox cmbUseNumPercent1 = this.cmbUseNumPercent;
      point1 = new Point(438, 220);
      Point point29 = point1;
      cmbUseNumPercent1.Location = point29;
      this.cmbUseNumPercent.Name = "cmbUseNumPercent";
      ComboBox cmbUseNumPercent2 = this.cmbUseNumPercent;
      size1 = new Size(48, 19);
      Size size29 = size1;
      cmbUseNumPercent2.Size = size29;
      this.cmbUseNumPercent.TabIndex = 146;
      this.cmbUseNumPercent.TabStop = false;
      this.chDopMethod_4.CheckAlign = ContentAlignment.MiddleRight;
      this.chDopMethod_4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chDopMethod_4.ForeColor = Color.Black;
      CheckBox chDopMethod4_1 = this.chDopMethod_4;
      point1 = new Point(250, 330);
      Point point30 = point1;
      chDopMethod4_1.Location = point30;
      this.chDopMethod_4.Name = "chDopMethod_4";
      CheckBox chDopMethod4_2 = this.chDopMethod_4;
      size1 = new Size(189, 17);
      Size size30 = size1;
      chDopMethod4_2.Size = size30;
      this.chDopMethod_4.TabIndex = 144;
      this.chDopMethod_4.Tag = (object) "4";
      this.chDopMethod_4.Text = "разрешить знаки  [ . ] [ - ] [ _ ]";
      this.chDopMethod_4.TextAlign = ContentAlignment.MiddleRight;
      this.chDopMethod_4.UseVisualStyleBackColor = true;
      this.Label17.AutoSize = true;
      this.Label17.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Label17.ForeColor = Color.FromArgb(64, 0, 0);
      Label label17_1 = this.Label17;
      point1 = new Point(286, 12);
      Point point31 = point1;
      label17_1.Location = point31;
      this.Label17.Name = "Label17";
      Label label17_2 = this.Label17;
      size1 = new Size(146, 18);
      Size size31 = size1;
      label17_2.Size = size31;
      this.Label17.TabIndex = 143;
      this.Label17.Text = "Генерация логина";
      this.picWarning.Image = (Image) componentResourceManager.GetObject("picWarning.Image");
      PictureBox picWarning1 = this.picWarning;
      point1 = new Point(256, 84);
      Point point32 = point1;
      picWarning1.Location = point32;
      this.picWarning.Name = "picWarning";
      PictureBox picWarning2 = this.picWarning;
      size1 = new Size(32, 32);
      Size size32 = size1;
      picWarning2.Size = size32;
      this.picWarning.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picWarning.TabIndex = (int) sbyte.MaxValue;
      this.picWarning.TabStop = false;
      this.lblChanse_4.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lblChanse_4.ForeColor = Color.Red;
      Label lblChanse4_1 = this.lblChanse_4;
      point1 = new Point(444, 117);
      Point point33 = point1;
      lblChanse4_1.Location = point33;
      this.lblChanse_4.Name = "lblChanse_4";
      Label lblChanse4_2 = this.lblChanse_4;
      size1 = new Size(38, 13);
      Size size33 = size1;
      lblChanse4_2.Size = size33;
      this.lblChanse_4.TabIndex = 139;
      this.lblChanse_4.Text = "0 %";
      this.lblChanse_4.TextAlign = ContentAlignment.TopCenter;
      this.lblChanse_3.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lblChanse_3.ForeColor = Color.Red;
      Label lblChanse3_1 = this.lblChanse_3;
      point1 = new Point(444, 100);
      Point point34 = point1;
      lblChanse3_1.Location = point34;
      this.lblChanse_3.Name = "lblChanse_3";
      Label lblChanse3_2 = this.lblChanse_3;
      size1 = new Size(38, 13);
      Size size34 = size1;
      lblChanse3_2.Size = size34;
      this.lblChanse_3.TabIndex = 138;
      this.lblChanse_3.Text = "0 %";
      this.lblChanse_3.TextAlign = ContentAlignment.TopCenter;
      this.lblChanse_2.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lblChanse_2.ForeColor = Color.Red;
      Label lblChanse2_1 = this.lblChanse_2;
      point1 = new Point(444, 81);
      Point point35 = point1;
      lblChanse2_1.Location = point35;
      this.lblChanse_2.Name = "lblChanse_2";
      Label lblChanse2_2 = this.lblChanse_2;
      size1 = new Size(38, 13);
      Size size35 = size1;
      lblChanse2_2.Size = size35;
      this.lblChanse_2.TabIndex = 137;
      this.lblChanse_2.Text = "0 %";
      this.lblChanse_2.TextAlign = ContentAlignment.TopCenter;
      this.lblChanse_1.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lblChanse_1.ForeColor = Color.Red;
      Label lblChanse1_1 = this.lblChanse_1;
      point1 = new Point(444, 62);
      Point point36 = point1;
      lblChanse1_1.Location = point36;
      this.lblChanse_1.Name = "lblChanse_1";
      Label lblChanse1_2 = this.lblChanse_1;
      size1 = new Size(38, 13);
      Size size36 = size1;
      lblChanse1_2.Size = size36;
      this.lblChanse_1.TabIndex = 136;
      this.lblChanse_1.Text = "0 %";
      this.lblChanse_1.TextAlign = ContentAlignment.TopCenter;
      this.grOpWordGen.Controls.Add((Control) this.cmbDoubleSOglas);
      this.grOpWordGen.Controls.Add((Control) this.cmbDoubleGlas);
      this.grOpWordGen.Controls.Add((Control) this.Label16);
      this.grOpWordGen.Controls.Add((Control) this.cmbUseNum);
      this.grOpWordGen.Controls.Add((Control) this.chDoubleSOglas);
      this.grOpWordGen.Controls.Add((Control) this.chDoubleGlas);
      this.grOpWordGen.Controls.Add((Control) this.txtGenMaxLen);
      this.grOpWordGen.Controls.Add((Control) this.txtGenMinLen);
      this.grOpWordGen.Controls.Add((Control) this.Label15);
      this.grOpWordGen.Controls.Add((Control) this.Label14);
      this.grOpWordGen.Enabled = false;
      this.grOpWordGen.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      GroupBox grOpWordGen1 = this.grOpWordGen;
      point1 = new Point(246, 132);
      Point point37 = point1;
      grOpWordGen1.Location = point37;
      this.grOpWordGen.Name = "grOpWordGen";
      GroupBox grOpWordGen2 = this.grOpWordGen;
      size1 = new Size(186, 116);
      Size size37 = size1;
      grOpWordGen2.Size = size37;
      this.grOpWordGen.TabIndex = 135;
      this.grOpWordGen.TabStop = false;
      this.cmbDoubleSOglas.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbDoubleSOglas.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbDoubleSOglas.Enabled = false;
      this.cmbDoubleSOglas.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbDoubleSOglas.ForeColor = Color.Black;
      this.cmbDoubleSOglas.FormattingEnabled = true;
      ComboBox cmbDoubleSoglas1 = this.cmbDoubleSOglas;
      point1 = new Point(8, 62);
      Point point38 = point1;
      cmbDoubleSoglas1.Location = point38;
      this.cmbDoubleSOglas.Name = "cmbDoubleSOglas";
      ComboBox cmbDoubleSoglas2 = this.cmbDoubleSOglas;
      size1 = new Size(42, 17);
      Size size38 = size1;
      cmbDoubleSoglas2.Size = size38;
      this.cmbDoubleSOglas.TabIndex = 144;
      this.cmbDoubleSOglas.TabStop = false;
      this.cmbDoubleGlas.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbDoubleGlas.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbDoubleGlas.Enabled = false;
      this.cmbDoubleGlas.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbDoubleGlas.ForeColor = Color.Black;
      this.cmbDoubleGlas.FormattingEnabled = true;
      ComboBox cmbDoubleGlas1 = this.cmbDoubleGlas;
      point1 = new Point(8, 40);
      Point point39 = point1;
      cmbDoubleGlas1.Location = point39;
      this.cmbDoubleGlas.Name = "cmbDoubleGlas";
      ComboBox cmbDoubleGlas2 = this.cmbDoubleGlas;
      size1 = new Size(42, 17);
      Size size39 = size1;
      cmbDoubleGlas2.Size = size39;
      this.cmbDoubleGlas.TabIndex = 143;
      this.cmbDoubleGlas.TabStop = false;
      this.Label16.AutoSize = true;
      this.Label16.ForeColor = Color.Black;
      Label label16_1 = this.Label16;
      point1 = new Point(10, 90);
      Point point40 = point1;
      label16_1.Location = point40;
      this.Label16.Name = "Label16";
      Label label16_2 = this.Label16;
      size1 = new Size(114, 13);
      Size size40 = size1;
      label16_2.Size = size40;
      this.Label16.TabIndex = 142;
      this.Label16.Text = "использовать цифры";
      this.cmbUseNum.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbUseNum.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbUseNum.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbUseNum.ForeColor = Color.Black;
      this.cmbUseNum.FormattingEnabled = true;
      ComboBox cmbUseNum1 = this.cmbUseNum;
      point1 = new Point(126, 86);
      Point point41 = point1;
      cmbUseNum1.Location = point41;
      this.cmbUseNum.Name = "cmbUseNum";
      ComboBox cmbUseNum2 = this.cmbUseNum;
      size1 = new Size(50, 21);
      Size size41 = size1;
      cmbUseNum2.Size = size41;
      this.cmbUseNum.TabIndex = 141;
      this.cmbUseNum.TabStop = false;
      this.chDoubleSOglas.AutoSize = true;
      this.chDoubleSOglas.CheckAlign = ContentAlignment.MiddleRight;
      this.chDoubleSOglas.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chDoubleSOglas.ForeColor = Color.Black;
      CheckBox chDoubleSoglas1 = this.chDoubleSOglas;
      point1 = new Point(49, 62);
      Point point42 = point1;
      chDoubleSoglas1.Location = point42;
      this.chDoubleSOglas.Name = "chDoubleSOglas";
      CheckBox chDoubleSoglas2 = this.chDoubleSOglas;
      size1 = new Size((int) sbyte.MaxValue, 17);
      Size size42 = size1;
      chDoubleSoglas2.Size = size42;
      this.chDoubleSOglas.TabIndex = 140;
      this.chDoubleSOglas.Text = "двойные согласные";
      this.chDoubleSOglas.TextAlign = ContentAlignment.MiddleCenter;
      this.chDoubleSOglas.UseVisualStyleBackColor = true;
      this.chDoubleGlas.AutoSize = true;
      this.chDoubleGlas.CheckAlign = ContentAlignment.MiddleRight;
      this.chDoubleGlas.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chDoubleGlas.ForeColor = Color.Black;
      CheckBox chDoubleGlas1 = this.chDoubleGlas;
      point1 = new Point(60, 40);
      Point point43 = point1;
      chDoubleGlas1.Location = point43;
      this.chDoubleGlas.Name = "chDoubleGlas";
      CheckBox chDoubleGlas2 = this.chDoubleGlas;
      size1 = new Size(116, 17);
      Size size43 = size1;
      chDoubleGlas2.Size = size43;
      this.chDoubleGlas.TabIndex = 139;
      this.chDoubleGlas.Text = "двойные гласные";
      this.chDoubleGlas.TextAlign = ContentAlignment.MiddleCenter;
      this.chDoubleGlas.UseVisualStyleBackColor = true;
      this.txtGenMaxLen.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtGenMaxLen1 = this.txtGenMaxLen;
      point1 = new Point(144, 12);
      Point point44 = point1;
      txtGenMaxLen1.Location = point44;
      this.txtGenMaxLen.MaxLength = 2;
      this.txtGenMaxLen.Name = "txtGenMaxLen";
      TextBox txtGenMaxLen2 = this.txtGenMaxLen;
      size1 = new Size(32, 21);
      Size size44 = size1;
      txtGenMaxLen2.Size = size44;
      this.txtGenMaxLen.TabIndex = 138;
      this.txtGenMaxLen.TextAlign = HorizontalAlignment.Center;
      this.txtGenMaxLen.WordWrap = false;
      this.txtGenMinLen.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtGenMinLen1 = this.txtGenMinLen;
      point1 = new Point(60, 12);
      Point point45 = point1;
      txtGenMinLen1.Location = point45;
      this.txtGenMinLen.MaxLength = 2;
      this.txtGenMinLen.Name = "txtGenMinLen";
      TextBox txtGenMinLen2 = this.txtGenMinLen;
      size1 = new Size(32, 21);
      Size size45 = size1;
      txtGenMinLen2.Size = size45;
      this.txtGenMinLen.TabIndex = 137;
      this.txtGenMinLen.TextAlign = HorizontalAlignment.Center;
      this.txtGenMinLen.WordWrap = false;
      this.Label15.AutoSize = true;
      Label label15_1 = this.Label15;
      point1 = new Point(96, 16);
      Point point46 = point1;
      label15_1.Location = point46;
      this.Label15.Name = "Label15";
      Label label15_2 = this.Label15;
      size1 = new Size(47, 13);
      Size size46 = size1;
      label15_2.Size = size46;
      this.Label15.TabIndex = 136;
      this.Label15.Text = "max Len";
      this.Label14.AutoSize = true;
      Label label14_1 = this.Label14;
      point1 = new Point(14, 16);
      Point point47 = point1;
      label14_1.Location = point47;
      this.Label14.Name = "Label14";
      Label label14_2 = this.Label14;
      size1 = new Size(43, 13);
      Size size47 = size1;
      label14_2.Size = size47;
      this.Label14.TabIndex = 135;
      this.Label14.Text = "min Len";
      this.chMethod_4.AutoSize = true;
      this.chMethod_4.CheckAlign = ContentAlignment.MiddleRight;
      this.chMethod_4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chMethod_4.ForeColor = Color.Black;
      CheckBox chMethod4_1 = this.chMethod_4;
      point1 = new Point(293, 115);
      Point point48 = point1;
      chMethod4_1.Location = point48;
      this.chMethod_4.Name = "chMethod_4";
      CheckBox chMethod4_2 = this.chMethod_4;
      size1 = new Size(149, 17);
      Size size48 = size1;
      chMethod4_2.Size = size48;
      this.chMethod_4.TabIndex = 134;
      this.chMethod_4.Tag = (object) "4";
      this.chMethod_4.Text = "генерировать по слогам";
      this.chMethod_4.TextAlign = ContentAlignment.MiddleCenter;
      this.chMethod_4.UseVisualStyleBackColor = true;
      this.chMethod_3.AutoSize = true;
      this.chMethod_3.CheckAlign = ContentAlignment.MiddleRight;
      this.chMethod_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chMethod_3.ForeColor = Color.Black;
      CheckBox chMethod3_1 = this.chMethod_3;
      point1 = new Point(296, 98);
      Point point49 = point1;
      chMethod3_1.Location = point49;
      this.chMethod_3.Name = "chMethod_3";
      CheckBox chMethod3_2 = this.chMethod_3;
      size1 = new Size(146, 17);
      Size size49 = size1;
      chMethod3_2.Size = size49;
      this.chMethod_3.TabIndex = 133;
      this.chMethod_3.Tag = (object) "3";
      this.chMethod_3.Text = "использовать фамилию";
      this.chMethod_3.TextAlign = ContentAlignment.MiddleCenter;
      this.chMethod_3.UseVisualStyleBackColor = true;
      this.chUseAllMethod.AutoSize = true;
      this.chUseAllMethod.CheckAlign = ContentAlignment.MiddleRight;
      this.chUseAllMethod.Enabled = false;
      this.chUseAllMethod.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.chUseAllMethod.ForeColor = Color.Black;
      CheckBox chUseAllMethod1 = this.chUseAllMethod;
      point1 = new Point(286, 32);
      Point point50 = point1;
      chUseAllMethod1.Location = point50;
      this.chUseAllMethod.Name = "chUseAllMethod";
      CheckBox chUseAllMethod2 = this.chUseAllMethod;
      size1 = new Size(196, 18);
      Size size50 = size1;
      chUseAllMethod2.Size = size50;
      this.chUseAllMethod.TabIndex = 132;
      this.chUseAllMethod.Text = "задействовать все методы";
      this.chUseAllMethod.TextAlign = ContentAlignment.MiddleCenter;
      this.chUseAllMethod.UseVisualStyleBackColor = true;
      this.chDopMethod_3.CheckAlign = ContentAlignment.MiddleRight;
      this.chDopMethod_3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chDopMethod_3.ForeColor = Color.Black;
      CheckBox chDopMethod3_1 = this.chDopMethod_3;
      point1 = new Point(276, 308);
      Point point51 = point1;
      chDopMethod3_1.Location = point51;
      this.chDopMethod_3.Name = "chDopMethod_3";
      CheckBox chDopMethod3_2 = this.chDopMethod_3;
      size1 = new Size(163, 17);
      Size size51 = size1;
      chDopMethod3_2.Size = size51;
      this.chDopMethod_3.TabIndex = 131;
      this.chDopMethod_3.Tag = (object) "3";
      this.chDopMethod_3.Text = "псевдосимволы (1=i 0=о)";
      this.chDopMethod_3.TextAlign = ContentAlignment.MiddleRight;
      this.chDopMethod_3.UseVisualStyleBackColor = true;
      this.chMethod_1.AutoSize = true;
      this.chMethod_1.CheckAlign = ContentAlignment.MiddleRight;
      this.chMethod_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chMethod_1.ForeColor = Color.Black;
      CheckBox chMethod1_1 = this.chMethod_1;
      point1 = new Point(276, 60);
      Point point52 = point1;
      chMethod1_1.Location = point52;
      this.chMethod_1.Name = "chMethod_1";
      CheckBox chMethod1_2 = this.chMethod_1;
      size1 = new Size(166, 17);
      Size size52 = size1;
      chMethod1_2.Size = size52;
      this.chMethod_1.TabIndex = 130;
      this.chMethod_1.Tag = (object) "1";
      this.chMethod_1.Text = "использовать базу логинов";
      this.chMethod_1.TextAlign = ContentAlignment.MiddleCenter;
      this.chMethod_1.UseVisualStyleBackColor = true;
      this.chDopMethod_2.CheckAlign = ContentAlignment.MiddleRight;
      this.chDopMethod_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chDopMethod_2.ForeColor = Color.Black;
      CheckBox chDopMethod2_1 = this.chDopMethod_2;
      point1 = new Point(268, 286);
      Point point53 = point1;
      chDopMethod2_1.Location = point53;
      this.chDopMethod_2.Name = "chDopMethod_2";
      CheckBox chDopMethod2_2 = this.chDopMethod_2;
      size1 = new Size(171, 17);
      Size size53 = size1;
      chDopMethod2_2.Size = size53;
      this.chDopMethod_2.TabIndex = 129;
      this.chDopMethod_2.Tag = (object) "2";
      this.chDopMethod_2.Text = "добавлять дату рождения";
      this.chDopMethod_2.TextAlign = ContentAlignment.MiddleRight;
      this.chDopMethod_2.UseVisualStyleBackColor = true;
      this.chMethod_2.AutoSize = true;
      this.chMethod_2.CheckAlign = ContentAlignment.MiddleRight;
      this.chMethod_2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chMethod_2.ForeColor = Color.Black;
      CheckBox chMethod2_1 = this.chMethod_2;
      point1 = new Point(325, 79);
      Point point54 = point1;
      chMethod2_1.Location = point54;
      this.chMethod_2.Name = "chMethod_2";
      CheckBox chMethod2_2 = this.chMethod_2;
      size1 = new Size(117, 17);
      Size size54 = size1;
      chMethod2_2.Size = size54;
      this.chMethod_2.TabIndex = 128;
      this.chMethod_2.Tag = (object) "2";
      this.chMethod_2.Text = "использовать имя";
      this.chMethod_2.TextAlign = ContentAlignment.MiddleCenter;
      this.chMethod_2.UseVisualStyleBackColor = true;
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      Label label13_1 = this.Label13;
      point1 = new Point(263, 250);
      Point point55 = point1;
      label13_1.Location = point55;
      this.Label13.Name = "Label13";
      Label label13_2 = this.Label13;
      size1 = new Size(157, 11);
      Size size55 = size1;
      label13_2.Size = size55;
      this.Label13.TabIndex = (int) sbyte.MaxValue;
      this.Label13.Text = "mr. boss. miss. lady. ms. mega. vip.";
      this.chDopMethod_1.CheckAlign = ContentAlignment.MiddleRight;
      this.chDopMethod_1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chDopMethod_1.ForeColor = Color.Black;
      CheckBox chDopMethod1_1 = this.chDopMethod_1;
      point1 = new Point(302, 264);
      Point point56 = point1;
      chDopMethod1_1.Location = point56;
      this.chDopMethod_1.Name = "chDopMethod_1";
      CheckBox chDopMethod1_2 = this.chDopMethod_1;
      size1 = new Size(137, 17);
      Size size56 = size1;
      chDopMethod1_2.Size = size56;
      this.chDopMethod_1.TabIndex = 126;
      this.chDopMethod_1.Tag = (object) "1";
      this.chDopMethod_1.Text = "добавлять приставки";
      this.chDopMethod_1.TextAlign = ContentAlignment.MiddleRight;
      this.chDopMethod_1.UseVisualStyleBackColor = true;
      this.chRND_7.AutoSize = true;
      this.chRND_7.CheckAlign = ContentAlignment.MiddleRight;
      this.chRND_7.ForeColor = Color.Black;
      CheckBox chRnd7_1 = this.chRND_7;
      point1 = new Point(226, 309);
      Point point57 = point1;
      chRnd7_1.Location = point57;
      this.chRND_7.Name = "chRND_7";
      CheckBox chRnd7_2 = this.chRND_7;
      size1 = new Size(15, 14);
      Size size57 = size1;
      chRnd7_2.Size = size57;
      this.chRND_7.TabIndex = 125;
      this.chRND_7.TextAlign = ContentAlignment.MiddleCenter;
      this.chRND_7.UseVisualStyleBackColor = true;
      this.chRND_8.AutoSize = true;
      this.chRND_8.CheckAlign = ContentAlignment.MiddleRight;
      this.chRND_8.ForeColor = Color.Black;
      CheckBox chRnd8_1 = this.chRND_8;
      point1 = new Point(226, 330);
      Point point58 = point1;
      chRnd8_1.Location = point58;
      this.chRND_8.Name = "chRND_8";
      CheckBox chRnd8_2 = this.chRND_8;
      size1 = new Size(15, 14);
      Size size58 = size1;
      chRnd8_2.Size = size58;
      this.chRND_8.TabIndex = 124;
      this.chRND_8.TextAlign = ContentAlignment.MiddleCenter;
      this.chRND_8.UseVisualStyleBackColor = true;
      this.PictureBox8.Image = (Image) componentResourceManager.GetObject("PictureBox8.Image");
      PictureBox pictureBox8_1 = this.PictureBox8;
      point1 = new Point(34, 296);
      Point point59 = point1;
      pictureBox8_1.Location = point59;
      this.PictureBox8.Name = "PictureBox8";
      PictureBox pictureBox8_2 = this.PictureBox8;
      size1 = new Size(171, 10);
      Size size59 = size1;
      pictureBox8_2.Size = size59;
      this.PictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox8.TabIndex = 123;
      this.PictureBox8.TabStop = false;
      this.Label12.AutoSize = true;
      this.Label12.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Label12.ForeColor = Color.Black;
      Label label12_1 = this.Label12;
      point1 = new Point(4, 309);
      Point point60 = point1;
      label12_1.Location = point60;
      this.Label12.Name = "Label12";
      Label label12_2 = this.Label12;
      size1 = new Size(56, 14);
      Size size60 = size1;
      label12_2.Size = size60;
      this.Label12.TabIndex = 122;
      this.Label12.Text = "вопрос:";
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Label11.ForeColor = Color.Black;
      Label label11_1 = this.Label11;
      point1 = new Point(12, 330);
      Point point61 = point1;
      label11_1.Location = point61;
      this.Label11.Name = "Label11";
      Label label11_2 = this.Label11;
      size1 = new Size(47, 14);
      Size size61 = size1;
      label11_2.Size = size61;
      this.Label11.TabIndex = 121;
      this.Label11.Text = "ответ:";
      this.txtAnswer.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtAnswer1 = this.txtAnswer;
      point1 = new Point(74, 327);
      Point point62 = point1;
      txtAnswer1.Location = point62;
      this.txtAnswer.Name = "txtAnswer";
      TextBox txtAnswer2 = this.txtAnswer;
      size1 = new Size(148, 21);
      Size size62 = size1;
      txtAnswer2.Size = size62;
      this.txtAnswer.TabIndex = 120;
      this.txtAnswer.TextAlign = HorizontalAlignment.Center;
      this.txtAnswer.WordWrap = false;
      this.cmbUserQuest.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbUserQuest.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbUserQuest.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbUserQuest.ForeColor = Color.Black;
      this.cmbUserQuest.FormattingEnabled = true;
      this.cmbUserQuest.Items.AddRange(new object[9]
      {
        (object) "Девичья фамилия матери",
        (object) "Номер паспортa",
        (object) "Как звали Вашего первого домашнего питомца",
        (object) "Имя и отчество Вашей бабушки",
        (object) "Имя и отчество Вашего дедушки",
        (object) "Номер телефона друга или подруги",
        (object) "Прозвище лучшего друга или подруги",
        (object) "Название Вашей любимой книги",
        (object) "Почтовый индекс родителей"
      });
      ComboBox cmbUserQuest1 = this.cmbUserQuest;
      point1 = new Point(74, 306);
      Point point63 = point1;
      cmbUserQuest1.Location = point63;
      this.cmbUserQuest.Name = "cmbUserQuest";
      ComboBox cmbUserQuest2 = this.cmbUserQuest;
      size1 = new Size(148, 21);
      Size size63 = size1;
      cmbUserQuest2.Size = size63;
      this.cmbUserQuest.TabIndex = 119;
      this.cmbUserQuest.TabStop = false;
      this.chRND_6.AutoSize = true;
      this.chRND_6.CheckAlign = ContentAlignment.MiddleRight;
      this.chRND_6.ForeColor = Color.Black;
      CheckBox chRnd6_1 = this.chRND_6;
      point1 = new Point(226, 277);
      Point point64 = point1;
      chRnd6_1.Location = point64;
      this.chRND_6.Name = "chRND_6";
      CheckBox chRnd6_2 = this.chRND_6;
      size1 = new Size(15, 14);
      Size size64 = size1;
      chRnd6_2.Size = size64;
      this.chRND_6.TabIndex = 118;
      this.chRND_6.TextAlign = ContentAlignment.MiddleCenter;
      this.chRND_6.UseVisualStyleBackColor = true;
      this.cmbUserYearBD.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbUserYearBD.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbUserYearBD.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbUserYearBD.ForeColor = Color.Black;
      this.cmbUserYearBD.FormattingEnabled = true;
      ComboBox cmbUserYearBd1 = this.cmbUserYearBD;
      point1 = new Point(160, 274);
      Point point65 = point1;
      cmbUserYearBd1.Location = point65;
      this.cmbUserYearBD.Name = "cmbUserYearBD";
      ComboBox cmbUserYearBd2 = this.cmbUserYearBD;
      size1 = new Size(62, 21);
      Size size65 = size1;
      cmbUserYearBd2.Size = size65;
      this.cmbUserYearBD.TabIndex = 117;
      this.cmbUserYearBD.TabStop = false;
      this.cmbUserMonthBD.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbUserMonthBD.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbUserMonthBD.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbUserMonthBD.ForeColor = Color.Black;
      this.cmbUserMonthBD.FormattingEnabled = true;
      this.cmbUserMonthBD.Items.AddRange(new object[12]
      {
        (object) "Январь",
        (object) "Февраль",
        (object) "Март",
        (object) "Апрель",
        (object) "Май",
        (object) "Июнь",
        (object) "Июль",
        (object) "Август",
        (object) "Сентябрь",
        (object) "Октябрь",
        (object) "Ноябрь",
        (object) "Декабрь"
      });
      ComboBox cmbUserMonthBd1 = this.cmbUserMonthBD;
      point1 = new Point(74, 274);
      Point point66 = point1;
      cmbUserMonthBd1.Location = point66;
      this.cmbUserMonthBD.Name = "cmbUserMonthBD";
      ComboBox cmbUserMonthBd2 = this.cmbUserMonthBD;
      size1 = new Size(86, 21);
      Size size66 = size1;
      cmbUserMonthBd2.Size = size66;
      this.cmbUserMonthBD.TabIndex = 116;
      this.cmbUserMonthBD.TabStop = false;
      this.cmbUserDayBD.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbUserDayBD.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbUserDayBD.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbUserDayBD.ForeColor = Color.Black;
      this.cmbUserDayBD.FormattingEnabled = true;
      this.cmbUserDayBD.Items.AddRange(new object[31]
      {
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
        (object) "20",
        (object) "21",
        (object) "22",
        (object) "23",
        (object) "24",
        (object) "25",
        (object) "26",
        (object) "27",
        (object) "28",
        (object) "29",
        (object) "30",
        (object) "31"
      });
      ComboBox cmbUserDayBd1 = this.cmbUserDayBD;
      point1 = new Point(24, 274);
      Point point67 = point1;
      cmbUserDayBd1.Location = point67;
      this.cmbUserDayBD.Name = "cmbUserDayBD";
      ComboBox cmbUserDayBd2 = this.cmbUserDayBD;
      size1 = new Size(50, 21);
      Size size67 = size1;
      cmbUserDayBd2.Size = size67;
      this.cmbUserDayBD.TabIndex = 115;
      this.cmbUserDayBD.TabStop = false;
      this.chRND_5.AutoSize = true;
      this.chRND_5.CheckAlign = ContentAlignment.MiddleRight;
      this.chRND_5.ForeColor = Color.Black;
      CheckBox chRnd5_1 = this.chRND_5;
      point1 = new Point(226, 247);
      Point point68 = point1;
      chRnd5_1.Location = point68;
      this.chRND_5.Name = "chRND_5";
      CheckBox chRnd5_2 = this.chRND_5;
      size1 = new Size(15, 14);
      Size size68 = size1;
      chRnd5_2.Size = size68;
      this.chRND_5.TabIndex = 114;
      this.chRND_5.TextAlign = ContentAlignment.MiddleCenter;
      this.chRND_5.UseVisualStyleBackColor = true;
      this.PictureBox7.Image = (Image) componentResourceManager.GetObject("PictureBox7.Image");
      PictureBox pictureBox7_1 = this.PictureBox7;
      point1 = new Point(34, 265);
      Point point69 = point1;
      pictureBox7_1.Location = point69;
      this.PictureBox7.Name = "PictureBox7";
      PictureBox pictureBox7_2 = this.PictureBox7;
      size1 = new Size(171, 10);
      Size size69 = size1;
      pictureBox7_2.Size = size69;
      this.PictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox7.TabIndex = 113;
      this.PictureBox7.TabStop = false;
      this.PictureBox6.Image = (Image) componentResourceManager.GetObject("PictureBox6.Image");
      PictureBox pictureBox6_1 = this.PictureBox6;
      point1 = new Point(34, 234);
      Point point70 = point1;
      pictureBox6_1.Location = point70;
      this.PictureBox6.Name = "PictureBox6";
      PictureBox pictureBox6_2 = this.PictureBox6;
      size1 = new Size(171, 10);
      Size size70 = size1;
      pictureBox6_2.Size = size70;
      this.PictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox6.TabIndex = 112;
      this.PictureBox6.TabStop = false;
      this.PictureBox5.Image = (Image) componentResourceManager.GetObject("PictureBox5.Image");
      PictureBox pictureBox5_1 = this.PictureBox5;
      point1 = new Point(34, 203);
      Point point71 = point1;
      pictureBox5_1.Location = point71;
      this.PictureBox5.Name = "PictureBox5";
      PictureBox pictureBox5_2 = this.PictureBox5;
      size1 = new Size(171, 10);
      Size size71 = size1;
      pictureBox5_2.Size = size71;
      this.PictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox5.TabIndex = 111;
      this.PictureBox5.TabStop = false;
      this.PictureBox4.Image = (Image) componentResourceManager.GetObject("PictureBox4.Image");
      PictureBox pictureBox4_1 = this.PictureBox4;
      point1 = new Point(34, 151);
      Point point72 = point1;
      pictureBox4_1.Location = point72;
      this.PictureBox4.Name = "PictureBox4";
      PictureBox pictureBox4_2 = this.PictureBox4;
      size1 = new Size(171, 10);
      Size size72 = size1;
      pictureBox4_2.Size = size72;
      this.PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox4.TabIndex = 110;
      this.PictureBox4.TabStop = false;
      this.PictureBox3.Image = (Image) componentResourceManager.GetObject("PictureBox3.Image");
      PictureBox pictureBox3_1 = this.PictureBox3;
      point1 = new Point(34, 120);
      Point point73 = point1;
      pictureBox3_1.Location = point73;
      this.PictureBox3.Name = "PictureBox3";
      PictureBox pictureBox3_2 = this.PictureBox3;
      size1 = new Size(171, 10);
      Size size73 = size1;
      pictureBox3_2.Size = size73;
      this.PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox3.TabIndex = 109;
      this.PictureBox3.TabStop = false;
      this.txtUserGenPass.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtUserGenPass1 = this.txtUserGenPass;
      point1 = new Point(74, 244);
      Point point74 = point1;
      txtUserGenPass1.Location = point74;
      this.txtUserGenPass.Name = "txtUserGenPass";
      TextBox txtUserGenPass2 = this.txtUserGenPass;
      size1 = new Size(148, 21);
      Size size74 = size1;
      txtUserGenPass2.Size = size74;
      this.txtUserGenPass.TabIndex = 108;
      this.txtUserGenPass.TextAlign = HorizontalAlignment.Center;
      this.txtUserGenPass.WordWrap = false;
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Label9.ForeColor = Color.Black;
      Label label9_1 = this.Label9;
      point1 = new Point(4, 247);
      Point point75 = point1;
      label9_1.Location = point75;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(63, 14);
      Size size75 = size1;
      label9_2.Size = size75;
      this.Label9.TabIndex = 107;
      this.Label9.Text = "ПАРОЛЬ:";
      this.lblInfo.BorderStyle = BorderStyle.FixedSingle;
      Label lblInfo1 = this.lblInfo;
      point1 = new Point(615, 133);
      Point point76 = point1;
      lblInfo1.Location = point76;
      this.lblInfo.Name = "lblInfo";
      Label lblInfo2 = this.lblInfo;
      size1 = new Size(220, 226);
      Size size76 = size1;
      lblInfo2.Size = size76;
      this.lblInfo.TabIndex = (int) sbyte.MaxValue;
      this.lblInfo.Text = componentResourceManager.GetString("lblInfo.Text");
      this.PictureBox9.Image = (Image) componentResourceManager.GetObject("PictureBox9.Image");
      PictureBox pictureBox9_1 = this.PictureBox9;
      point1 = new Point(799, 137);
      Point point77 = point1;
      pictureBox9_1.Location = point77;
      this.PictureBox9.Name = "PictureBox9";
      PictureBox pictureBox9_2 = this.PictureBox9;
      size1 = new Size(32, 32);
      Size size77 = size1;
      pictureBox9_2.Size = size77;
      this.PictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox9.TabIndex = 128;
      this.PictureBox9.TabStop = false;
      this.GroupBox6.Controls.Add((Control) this.btmTestGen);
      this.GroupBox6.Controls.Add((Control) this.txtTestLogin);
      GroupBox groupBox6_1 = this.GroupBox6;
      point1 = new Point(615, 365);
      Point point78 = point1;
      groupBox6_1.Location = point78;
      this.GroupBox6.Name = "GroupBox6";
      GroupBox groupBox6_2 = this.GroupBox6;
      size1 = new Size(220, 42);
      Size size78 = size1;
      groupBox6_2.Size = size78;
      this.GroupBox6.TabIndex = 129;
      this.GroupBox6.TabStop = false;
      this.GroupBox6.Text = "Результат генерации логина";
      this.btmTestGen.BackColor = Color.FromArgb(224, 224, 224);
      this.btmTestGen.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btmTestGen.ForeColor = Color.Black;
      Button btmTestGen1 = this.btmTestGen;
      point1 = new Point(156, 14);
      Point point79 = point1;
      btmTestGen1.Location = point79;
      this.btmTestGen.Name = "btmTestGen";
      Button btmTestGen2 = this.btmTestGen;
      size1 = new Size(60, 23);
      Size size79 = size1;
      btmTestGen2.Size = size79;
      this.btmTestGen.TabIndex = 130;
      this.btmTestGen.Text = "тест";
      this.btmTestGen.UseVisualStyleBackColor = false;
      this.txtTestLogin.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      TextBox txtTestLogin1 = this.txtTestLogin;
      point1 = new Point(4, 16);
      Point point80 = point1;
      txtTestLogin1.Location = point80;
      this.txtTestLogin.Name = "txtTestLogin";
      TextBox txtTestLogin2 = this.txtTestLogin;
      size1 = new Size(152, 21);
      Size size80 = size1;
      txtTestLogin2.Size = size80;
      this.txtTestLogin.TabIndex = 102;
      this.txtTestLogin.TextAlign = HorizontalAlignment.Center;
      this.txtTestLogin.WordWrap = false;
      this.Button2.BackColor = Color.FromArgb(224, 224, 224);
      this.Button2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Button2.ForeColor = Color.Black;
      Button button2_1 = this.Button2;
      point1 = new Point(617, 413);
      Point point81 = point1;
      button2_1.Location = point81;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(138, 54);
      Size size81 = size1;
      button2_2.Size = size81;
      this.Button2.TabIndex = 130;
      this.Button2.Text = "Генерировать заготовки e-Mail регистраций";
      this.Button2.UseVisualStyleBackColor = false;
      this.txtGenCount.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtGenCount1 = this.txtGenCount;
      point1 = new Point(751, 415);
      Point point82 = point1;
      txtGenCount1.Location = point82;
      this.txtGenCount.Name = "txtGenCount";
      TextBox txtGenCount2 = this.txtGenCount;
      size1 = new Size(84, 23);
      Size size82 = size1;
      txtGenCount2.Size = size82;
      this.txtGenCount.TabIndex = 131;
      this.txtGenCount.TextAlign = HorizontalAlignment.Center;
      this.txtGenCount.WordWrap = false;
      this.rbSelectMail_0.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.rbSelectMail_0.ForeColor = Color.Blue;
      this.rbSelectMail_0.Image = (Image) componentResourceManager.GetObject("rbSelectMail_0.Image");
      this.rbSelectMail_0.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton rbSelectMail0_1 = this.rbSelectMail_0;
      point1 = new Point(3, 123);
      Point point83 = point1;
      rbSelectMail0_1.Location = point83;
      this.rbSelectMail_0.Name = "rbSelectMail_0";
      RadioButton rbSelectMail0_2 = this.rbSelectMail_0;
      size1 = new Size(112, 24);
      Size size83 = size1;
      rbSelectMail0_2.Size = size83;
      this.rbSelectMail_0.TabIndex = 153;
      this.rbSelectMail_0.TabStop = true;
      this.rbSelectMail_0.Tag = (object) "mail.ru";
      this.rbSelectMail_0.Text = "    mail.ru";
      this.rbSelectMail_0.UseVisualStyleBackColor = true;
      this.rbSelectMail_2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.rbSelectMail_2.ForeColor = Color.Blue;
      this.rbSelectMail_2.Image = (Image) componentResourceManager.GetObject("rbSelectMail_2.Image");
      this.rbSelectMail_2.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton rbSelectMail2_1 = this.rbSelectMail_2;
      point1 = new Point(3, 171);
      Point point84 = point1;
      rbSelectMail2_1.Location = point84;
      this.rbSelectMail_2.Name = "rbSelectMail_2";
      RadioButton rbSelectMail2_2 = this.rbSelectMail_2;
      size1 = new Size(112, 24);
      Size size84 = size1;
      rbSelectMail2_2.Size = size84;
      this.rbSelectMail_2.TabIndex = 154;
      this.rbSelectMail_2.TabStop = true;
      this.rbSelectMail_2.Tag = (object) "meta.ua";
      this.rbSelectMail_2.Text = "    meta.ua";
      this.rbSelectMail_2.UseVisualStyleBackColor = true;
      this.rbSelectMail_1.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.rbSelectMail_1.ForeColor = Color.Blue;
      this.rbSelectMail_1.Image = (Image) componentResourceManager.GetObject("rbSelectMail_1.Image");
      this.rbSelectMail_1.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton rbSelectMail1_1 = this.rbSelectMail_1;
      point1 = new Point(3, 147);
      Point point85 = point1;
      rbSelectMail1_1.Location = point85;
      this.rbSelectMail_1.Name = "rbSelectMail_1";
      RadioButton rbSelectMail1_2 = this.rbSelectMail_1;
      size1 = new Size(116, 24);
      Size size85 = size1;
      rbSelectMail1_2.Size = size85;
      this.rbSelectMail_1.TabIndex = 155;
      this.rbSelectMail_1.TabStop = true;
      this.rbSelectMail_1.Tag = (object) "qip.ru";
      this.rbSelectMail_1.Text = "    qip.ru";
      this.rbSelectMail_1.UseVisualStyleBackColor = true;
      this.RadioButton3.Enabled = false;
      this.RadioButton3.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.RadioButton3.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.RadioButton3.Image = (Image) componentResourceManager.GetObject("RadioButton3.Image");
      this.RadioButton3.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton radioButton3_1 = this.RadioButton3;
      point1 = new Point(3, 265);
      Point point86 = point1;
      radioButton3_1.Location = point86;
      this.RadioButton3.Name = "RadioButton3";
      RadioButton radioButton3_2 = this.RadioButton3;
      size1 = new Size(116, 24);
      Size size86 = size1;
      radioButton3_2.Size = size86;
      this.RadioButton3.TabIndex = 156;
      this.RadioButton3.TabStop = true;
      this.RadioButton3.Text = "    rambler.ru";
      this.RadioButton3.UseVisualStyleBackColor = true;
      this.RadioButton4.Enabled = false;
      this.RadioButton4.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.RadioButton4.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.RadioButton4.Image = (Image) componentResourceManager.GetObject("RadioButton4.Image");
      this.RadioButton4.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton radioButton4_1 = this.RadioButton4;
      point1 = new Point(3, 291);
      Point point87 = point1;
      radioButton4_1.Location = point87;
      this.RadioButton4.Name = "RadioButton4";
      RadioButton radioButton4_2 = this.RadioButton4;
      size1 = new Size(116, 24);
      Size size87 = size1;
      radioButton4_2.Size = size87;
      this.RadioButton4.TabIndex = 157;
      this.RadioButton4.TabStop = true;
      this.RadioButton4.Text = "    yahoo.com";
      this.RadioButton4.UseVisualStyleBackColor = true;
      this.rbSelectMail_3.Enabled = false;
      this.rbSelectMail_3.Font = new Font("Tahoma", 9f, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point, (byte) 204);
      this.rbSelectMail_3.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.rbSelectMail_3.Image = (Image) componentResourceManager.GetObject("rbSelectMail_3.Image");
      this.rbSelectMail_3.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton rbSelectMail3_1 = this.rbSelectMail_3;
      point1 = new Point(3, 241);
      Point point88 = point1;
      rbSelectMail3_1.Location = point88;
      this.rbSelectMail_3.Name = "rbSelectMail_3";
      RadioButton rbSelectMail3_2 = this.rbSelectMail_3;
      size1 = new Size(116, 24);
      Size size88 = size1;
      rbSelectMail3_2.Size = size88;
      this.rbSelectMail_3.TabIndex = 158;
      this.rbSelectMail_3.TabStop = true;
      this.rbSelectMail_3.Tag = (object) "km.ru";
      this.rbSelectMail_3.Text = "    km.ru";
      this.rbSelectMail_3.UseVisualStyleBackColor = true;
      this.RadioButton6.Enabled = false;
      this.RadioButton6.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.RadioButton6.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.RadioButton6.Image = (Image) componentResourceManager.GetObject("RadioButton6.Image");
      this.RadioButton6.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton radioButton6_1 = this.RadioButton6;
      point1 = new Point(3, 311);
      Point point89 = point1;
      radioButton6_1.Location = point89;
      this.RadioButton6.Name = "RadioButton6";
      RadioButton radioButton6_2 = this.RadioButton6;
      size1 = new Size(116, 24);
      Size size89 = size1;
      radioButton6_2.Size = size89;
      this.RadioButton6.TabIndex = 159;
      this.RadioButton6.TabStop = true;
      this.RadioButton6.Text = "    email.ru";
      this.RadioButton6.UseVisualStyleBackColor = true;
      this.RadioButton7.Enabled = false;
      this.RadioButton7.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.RadioButton7.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.RadioButton7.Image = (Image) componentResourceManager.GetObject("RadioButton7.Image");
      this.RadioButton7.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton radioButton7_1 = this.RadioButton7;
      point1 = new Point(3, 337);
      Point point90 = point1;
      radioButton7_1.Location = point90;
      this.RadioButton7.Name = "RadioButton7";
      RadioButton radioButton7_2 = this.RadioButton7;
      size1 = new Size(116, 24);
      Size size90 = size1;
      radioButton7_2.Size = size90;
      this.RadioButton7.TabIndex = 160;
      this.RadioButton7.TabStop = true;
      this.RadioButton7.Text = "    hotmail.com";
      this.RadioButton7.UseVisualStyleBackColor = true;
      this.RadioButton8.Enabled = false;
      this.RadioButton8.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.RadioButton8.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.RadioButton8.Image = (Image) componentResourceManager.GetObject("RadioButton8.Image");
      this.RadioButton8.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton radioButton8_1 = this.RadioButton8;
      point1 = new Point(3, 363);
      Point point91 = point1;
      radioButton8_1.Location = point91;
      this.RadioButton8.Name = "RadioButton8";
      RadioButton radioButton8_2 = this.RadioButton8;
      size1 = new Size(116, 24);
      Size size91 = size1;
      radioButton8_2.Size = size91;
      this.RadioButton8.TabIndex = 161;
      this.RadioButton8.TabStop = true;
      this.RadioButton8.Text = "    nextmail.ru";
      this.RadioButton8.UseVisualStyleBackColor = true;
      this.RadioButton9.Enabled = false;
      this.RadioButton9.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.RadioButton9.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.RadioButton9.Image = (Image) componentResourceManager.GetObject("RadioButton9.Image");
      this.RadioButton9.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton radioButton9_1 = this.RadioButton9;
      point1 = new Point(3, 389);
      Point point92 = point1;
      radioButton9_1.Location = point92;
      this.RadioButton9.Name = "RadioButton9";
      RadioButton radioButton9_2 = this.RadioButton9;
      size1 = new Size(116, 24);
      Size size92 = size1;
      radioButton9_2.Size = size92;
      this.RadioButton9.TabIndex = 162;
      this.RadioButton9.TabStop = true;
      this.RadioButton9.Text = "    mail.com";
      this.RadioButton9.UseVisualStyleBackColor = true;
      this.RadioButton10.Enabled = false;
      this.RadioButton10.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.RadioButton10.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.RadioButton10.Image = (Image) componentResourceManager.GetObject("RadioButton10.Image");
      this.RadioButton10.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton radioButton10_1 = this.RadioButton10;
      point1 = new Point(3, 415);
      Point point93 = point1;
      radioButton10_1.Location = point93;
      this.RadioButton10.Name = "RadioButton10";
      RadioButton radioButton10_2 = this.RadioButton10;
      size1 = new Size(116, 24);
      Size size93 = size1;
      radioButton10_2.Size = size93;
      this.RadioButton10.TabIndex = 163;
      this.RadioButton10.TabStop = true;
      this.RadioButton10.Text = "    bigmir.net";
      this.RadioButton10.UseVisualStyleBackColor = true;
      this.RadioButton11.Enabled = false;
      this.RadioButton11.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.RadioButton11.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.RadioButton11.Image = (Image) componentResourceManager.GetObject("RadioButton11.Image");
      this.RadioButton11.ImageAlign = ContentAlignment.MiddleLeft;
      RadioButton radioButton11_1 = this.RadioButton11;
      point1 = new Point(3, 441);
      Point point94 = point1;
      radioButton11_1.Location = point94;
      this.RadioButton11.Name = "RadioButton11";
      RadioButton radioButton11_2 = this.RadioButton11;
      size1 = new Size(116, 24);
      Size size94 = size1;
      radioButton11_2.Size = size94;
      this.RadioButton11.TabIndex = 164;
      this.RadioButton11.TabStop = true;
      this.RadioButton11.Text = "    gmail.com";
      this.RadioButton11.UseVisualStyleBackColor = true;
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Label19.ForeColor = Color.Gray;
      Label label19_1 = this.Label19;
      point1 = new Point(11, 218);
      Point point95 = point1;
      label19_1.Location = point95;
      this.Label19.Name = "Label19";
      Label label19_2 = this.Label19;
      size1 = new Size(100, 14);
      Size size95 = size1;
      label19_2.Size = size95;
      this.Label19.TabIndex = 165;
      this.Label19.Text = "В РАЗРАБОТКЕ";
      this.сhYandexPause.AutoSize = true;
      this.сhYandexPause.Checked = true;
      this.сhYandexPause.CheckState = CheckState.Checked;
      this.сhYandexPause.ForeColor = Color.FromArgb(64, 64, 64);
      CheckBox сhYandexPause1 = this.сhYandexPause;
      point1 = new Point(84, 183);
      Point point96 = point1;
      сhYandexPause1.Location = point96;
      this.сhYandexPause.Name = "сhYandexPause";
      CheckBox сhYandexPause2 = this.сhYandexPause;
      size1 = new Size(94, 17);
      Size size96 = size1;
      сhYandexPause2.Size = size96;
      this.сhYandexPause.TabIndex = 166;
      this.сhYandexPause.Text = "пауза 51 сек.";
      this.сhYandexPause.UseVisualStyleBackColor = true;
      this.сhYandexPause.Visible = false;
      this.chHardCheck.CheckAlign = ContentAlignment.MiddleRight;
      this.chHardCheck.ForeColor = Color.Red;
      CheckBox chHardCheck1 = this.chHardCheck;
      point1 = new Point(759, 435);
      Point point97 = point1;
      chHardCheck1.Location = point97;
      this.chHardCheck.Name = "chHardCheck";
      CheckBox chHardCheck2 = this.chHardCheck;
      size1 = new Size(76, 32);
      Size size97 = size1;
      chHardCheck2.Size = size97;
      this.chHardCheck.TabIndex = 167;
      this.chHardCheck.Text = "тяжелая проверка";
      this.chHardCheck.TextAlign = ContentAlignment.MiddleCenter;
      this.chHardCheck.UseVisualStyleBackColor = true;
      this.Label20.AutoSize = true;
      this.Label20.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Label20.ForeColor = Color.Red;
      Label label20_1 = this.Label20;
      point1 = new Point(126, 107);
      Point point98 = point1;
      label20_1.Location = point98;
      this.Label20.Name = "Label20";
      Label label20_2 = this.Label20;
      size1 = new Size(83, 14);
      Size size98 = size1;
      label20_2.Size = size98;
      this.Label20.TabIndex = 168;
      this.Label20.Text = "тестируется";
      this.Label20.Visible = false;
      this.GroupBox7.Controls.Add((Control) this.boxLoadData_Pole8);
      this.GroupBox7.Controls.Add((Control) this.boxLoadData_Pole7);
      this.GroupBox7.Controls.Add((Control) this.boxLoadData_Pole6);
      this.GroupBox7.Controls.Add((Control) this.GroupBox2);
      this.GroupBox7.Controls.Add((Control) this.boxLoadData_Pole5);
      this.GroupBox7.Controls.Add((Control) this.boxLoadData_Pole4);
      this.GroupBox7.Controls.Add((Control) this.boxLoadData_Pole3);
      this.GroupBox7.Controls.Add((Control) this.boxLoadData_Pole2);
      this.GroupBox7.Controls.Add((Control) this.GroupBox16);
      this.GroupBox7.Controls.Add((Control) this.boxLoadData_Pole1);
      this.GroupBox7.Controls.Add((Control) this.PictureBox10);
      this.GroupBox7.Controls.Add((Control) this.btnLoadData);
      this.GroupBox7.Controls.Add((Control) this.cmbLoadLogOtherData);
      this.GroupBox7.Controls.Add((Control) this.Label22);
      this.GroupBox7.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.GroupBox7.ForeColor = Color.FromArgb(0, 64, 64);
      GroupBox groupBox7_1 = this.GroupBox7;
      point1 = new Point(7, 3);
      Point point99 = point1;
      groupBox7_1.Location = point99;
      this.GroupBox7.Name = "GroupBox7";
      GroupBox groupBox7_2 = this.GroupBox7;
      size1 = new Size(828, 114);
      Size size99 = size1;
      groupBox7_2.Size = size99;
      this.GroupBox7.TabIndex = 169;
      this.GroupBox7.TabStop = false;
      this.GroupBox7.Text = "Загрузить списком";
      this.boxLoadData_Pole8.Controls.Add((Control) this.cmbLoadData_Pole8);
      this.boxLoadData_Pole8.Controls.Add((Control) this.chLoadData_Pole8);
      this.boxLoadData_Pole8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.boxLoadData_Pole8.ForeColor = Color.Black;
      GroupBox boxLoadDataPole8_1 = this.boxLoadData_Pole8;
      point1 = new Point(720, 70);
      Point point100 = point1;
      boxLoadDataPole8_1.Location = point100;
      this.boxLoadData_Pole8.Name = "boxLoadData_Pole8";
      GroupBox boxLoadDataPole8_2 = this.boxLoadData_Pole8;
      size1 = new Size(102, 39);
      Size size100 = size1;
      boxLoadDataPole8_2.Size = size100;
      this.boxLoadData_Pole8.TabIndex = 151;
      this.boxLoadData_Pole8.TabStop = false;
      this.boxLoadData_Pole8.Text = "Data 8";
      this.cmbLoadData_Pole8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.cmbLoadData_Pole8.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbLoadData_Pole8.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbLoadData_Pole8.Enabled = false;
      this.cmbLoadData_Pole8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbLoadData_Pole8.ForeColor = Color.Black;
      this.cmbLoadData_Pole8.FormattingEnabled = true;
      this.cmbLoadData_Pole8.Items.AddRange(new object[9]
      {
        (object) "LOGIN",
        (object) "@domain",
        (object) "DOMAIN",
        (object) "Пароль",
        (object) "Сек. ответ",
        (object) "Имя",
        (object) "Фамилия",
        (object) "Пол (M / F)",
        (object) "Город"
      });
      ComboBox cmbLoadDataPole8_1 = this.cmbLoadData_Pole8;
      point1 = new Point(17, 14);
      Point point101 = point1;
      cmbLoadDataPole8_1.Location = point101;
      this.cmbLoadData_Pole8.Name = "cmbLoadData_Pole8";
      ComboBox cmbLoadDataPole8_2 = this.cmbLoadData_Pole8;
      size1 = new Size(82, 21);
      Size size101 = size1;
      cmbLoadDataPole8_2.Size = size101;
      this.cmbLoadData_Pole8.TabIndex = 135;
      this.cmbLoadData_Pole8.TabStop = false;
      this.cmbLoadData_Pole8.Tag = (object) "8";
      this.chLoadData_Pole8.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      CheckBox chLoadDataPole8_1 = this.chLoadData_Pole8;
      point1 = new Point(3, 18);
      Point point102 = point1;
      chLoadDataPole8_1.Location = point102;
      this.chLoadData_Pole8.Name = "chLoadData_Pole8";
      CheckBox chLoadDataPole8_2 = this.chLoadData_Pole8;
      size1 = new Size(13, 13);
      Size size102 = size1;
      chLoadDataPole8_2.Size = size102;
      this.chLoadData_Pole8.TabIndex = 136;
      this.chLoadData_Pole8.Tag = (object) "8";
      this.chLoadData_Pole8.UseVisualStyleBackColor = true;
      this.boxLoadData_Pole7.Controls.Add((Control) this.cmbLoadData_Pole7);
      this.boxLoadData_Pole7.Controls.Add((Control) this.chLoadData_Pole7);
      this.boxLoadData_Pole7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.boxLoadData_Pole7.ForeColor = Color.Black;
      GroupBox boxLoadDataPole7_1 = this.boxLoadData_Pole7;
      point1 = new Point(618, 70);
      Point point103 = point1;
      boxLoadDataPole7_1.Location = point103;
      this.boxLoadData_Pole7.Name = "boxLoadData_Pole7";
      GroupBox boxLoadDataPole7_2 = this.boxLoadData_Pole7;
      size1 = new Size(102, 39);
      Size size103 = size1;
      boxLoadDataPole7_2.Size = size103;
      this.boxLoadData_Pole7.TabIndex = 150;
      this.boxLoadData_Pole7.TabStop = false;
      this.boxLoadData_Pole7.Text = "Data 7";
      this.cmbLoadData_Pole7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.cmbLoadData_Pole7.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbLoadData_Pole7.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbLoadData_Pole7.Enabled = false;
      this.cmbLoadData_Pole7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbLoadData_Pole7.ForeColor = Color.Black;
      this.cmbLoadData_Pole7.FormattingEnabled = true;
      this.cmbLoadData_Pole7.Items.AddRange(new object[9]
      {
        (object) "LOGIN",
        (object) "@domain",
        (object) "DOMAIN",
        (object) "Пароль",
        (object) "Сек. ответ",
        (object) "Имя",
        (object) "Фамилия",
        (object) "Пол (M / F)",
        (object) "Город"
      });
      ComboBox cmbLoadDataPole7_1 = this.cmbLoadData_Pole7;
      point1 = new Point(17, 14);
      Point point104 = point1;
      cmbLoadDataPole7_1.Location = point104;
      this.cmbLoadData_Pole7.Name = "cmbLoadData_Pole7";
      ComboBox cmbLoadDataPole7_2 = this.cmbLoadData_Pole7;
      size1 = new Size(82, 21);
      Size size104 = size1;
      cmbLoadDataPole7_2.Size = size104;
      this.cmbLoadData_Pole7.TabIndex = 135;
      this.cmbLoadData_Pole7.TabStop = false;
      this.cmbLoadData_Pole7.Tag = (object) "7";
      this.chLoadData_Pole7.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      CheckBox chLoadDataPole7_1 = this.chLoadData_Pole7;
      point1 = new Point(3, 18);
      Point point105 = point1;
      chLoadDataPole7_1.Location = point105;
      this.chLoadData_Pole7.Name = "chLoadData_Pole7";
      CheckBox chLoadDataPole7_2 = this.chLoadData_Pole7;
      size1 = new Size(13, 13);
      Size size105 = size1;
      chLoadDataPole7_2.Size = size105;
      this.chLoadData_Pole7.TabIndex = 136;
      this.chLoadData_Pole7.Tag = (object) "7";
      this.chLoadData_Pole7.UseVisualStyleBackColor = true;
      this.boxLoadData_Pole6.Controls.Add((Control) this.cmbLoadData_Pole6);
      this.boxLoadData_Pole6.Controls.Add((Control) this.chLoadData_Pole6);
      this.boxLoadData_Pole6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.boxLoadData_Pole6.ForeColor = Color.Black;
      GroupBox boxLoadDataPole6_1 = this.boxLoadData_Pole6;
      point1 = new Point(516, 70);
      Point point106 = point1;
      boxLoadDataPole6_1.Location = point106;
      this.boxLoadData_Pole6.Name = "boxLoadData_Pole6";
      GroupBox boxLoadDataPole6_2 = this.boxLoadData_Pole6;
      size1 = new Size(102, 39);
      Size size106 = size1;
      boxLoadDataPole6_2.Size = size106;
      this.boxLoadData_Pole6.TabIndex = 149;
      this.boxLoadData_Pole6.TabStop = false;
      this.boxLoadData_Pole6.Text = "Data 6";
      this.cmbLoadData_Pole6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.cmbLoadData_Pole6.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbLoadData_Pole6.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbLoadData_Pole6.Enabled = false;
      this.cmbLoadData_Pole6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbLoadData_Pole6.ForeColor = Color.Black;
      this.cmbLoadData_Pole6.FormattingEnabled = true;
      this.cmbLoadData_Pole6.Items.AddRange(new object[9]
      {
        (object) "LOGIN",
        (object) "@domain",
        (object) "DOMAIN",
        (object) "Пароль",
        (object) "Сек. ответ",
        (object) "Имя",
        (object) "Фамилия",
        (object) "Пол (M / F)",
        (object) "Город"
      });
      ComboBox cmbLoadDataPole6_1 = this.cmbLoadData_Pole6;
      point1 = new Point(17, 14);
      Point point107 = point1;
      cmbLoadDataPole6_1.Location = point107;
      this.cmbLoadData_Pole6.Name = "cmbLoadData_Pole6";
      ComboBox cmbLoadDataPole6_2 = this.cmbLoadData_Pole6;
      size1 = new Size(82, 21);
      Size size107 = size1;
      cmbLoadDataPole6_2.Size = size107;
      this.cmbLoadData_Pole6.TabIndex = 135;
      this.cmbLoadData_Pole6.TabStop = false;
      this.cmbLoadData_Pole6.Tag = (object) "6";
      this.chLoadData_Pole6.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      CheckBox chLoadDataPole6_1 = this.chLoadData_Pole6;
      point1 = new Point(3, 18);
      Point point108 = point1;
      chLoadDataPole6_1.Location = point108;
      this.chLoadData_Pole6.Name = "chLoadData_Pole6";
      CheckBox chLoadDataPole6_2 = this.chLoadData_Pole6;
      size1 = new Size(13, 13);
      Size size108 = size1;
      chLoadDataPole6_2.Size = size108;
      this.chLoadData_Pole6.TabIndex = 136;
      this.chLoadData_Pole6.Tag = (object) "6";
      this.chLoadData_Pole6.UseVisualStyleBackColor = true;
      this.boxLoadData_Pole5.Controls.Add((Control) this.cmbLoadData_Pole5);
      this.boxLoadData_Pole5.Controls.Add((Control) this.chLoadData_Pole5);
      this.boxLoadData_Pole5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.boxLoadData_Pole5.ForeColor = Color.Black;
      GroupBox boxLoadDataPole5_1 = this.boxLoadData_Pole5;
      point1 = new Point(414, 70);
      Point point109 = point1;
      boxLoadDataPole5_1.Location = point109;
      this.boxLoadData_Pole5.Name = "boxLoadData_Pole5";
      GroupBox boxLoadDataPole5_2 = this.boxLoadData_Pole5;
      size1 = new Size(102, 39);
      Size size109 = size1;
      boxLoadDataPole5_2.Size = size109;
      this.boxLoadData_Pole5.TabIndex = 148;
      this.boxLoadData_Pole5.TabStop = false;
      this.boxLoadData_Pole5.Text = "Data 5";
      this.cmbLoadData_Pole5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.cmbLoadData_Pole5.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbLoadData_Pole5.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbLoadData_Pole5.Enabled = false;
      this.cmbLoadData_Pole5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbLoadData_Pole5.ForeColor = Color.Black;
      this.cmbLoadData_Pole5.FormattingEnabled = true;
      this.cmbLoadData_Pole5.Items.AddRange(new object[9]
      {
        (object) "LOGIN",
        (object) "@domain",
        (object) "DOMAIN",
        (object) "Пароль",
        (object) "Сек. ответ",
        (object) "Имя",
        (object) "Фамилия",
        (object) "Пол (M / F)",
        (object) "Город"
      });
      ComboBox cmbLoadDataPole5_1 = this.cmbLoadData_Pole5;
      point1 = new Point(17, 14);
      Point point110 = point1;
      cmbLoadDataPole5_1.Location = point110;
      this.cmbLoadData_Pole5.Name = "cmbLoadData_Pole5";
      ComboBox cmbLoadDataPole5_2 = this.cmbLoadData_Pole5;
      size1 = new Size(82, 21);
      Size size110 = size1;
      cmbLoadDataPole5_2.Size = size110;
      this.cmbLoadData_Pole5.TabIndex = 135;
      this.cmbLoadData_Pole5.TabStop = false;
      this.cmbLoadData_Pole5.Tag = (object) "5";
      this.chLoadData_Pole5.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      CheckBox chLoadDataPole5_1 = this.chLoadData_Pole5;
      point1 = new Point(3, 18);
      Point point111 = point1;
      chLoadDataPole5_1.Location = point111;
      this.chLoadData_Pole5.Name = "chLoadData_Pole5";
      CheckBox chLoadDataPole5_2 = this.chLoadData_Pole5;
      size1 = new Size(13, 13);
      Size size111 = size1;
      chLoadDataPole5_2.Size = size111;
      this.chLoadData_Pole5.TabIndex = 136;
      this.chLoadData_Pole5.Tag = (object) "5";
      this.chLoadData_Pole5.UseVisualStyleBackColor = true;
      this.boxLoadData_Pole4.Controls.Add((Control) this.cmbLoadData_Pole4);
      this.boxLoadData_Pole4.Controls.Add((Control) this.chLoadData_Pole4);
      this.boxLoadData_Pole4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.boxLoadData_Pole4.ForeColor = Color.Black;
      GroupBox boxLoadDataPole4_1 = this.boxLoadData_Pole4;
      point1 = new Point(312, 70);
      Point point112 = point1;
      boxLoadDataPole4_1.Location = point112;
      this.boxLoadData_Pole4.Name = "boxLoadData_Pole4";
      GroupBox boxLoadDataPole4_2 = this.boxLoadData_Pole4;
      size1 = new Size(102, 39);
      Size size112 = size1;
      boxLoadDataPole4_2.Size = size112;
      this.boxLoadData_Pole4.TabIndex = 147;
      this.boxLoadData_Pole4.TabStop = false;
      this.boxLoadData_Pole4.Text = "Data 4";
      this.cmbLoadData_Pole4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.cmbLoadData_Pole4.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbLoadData_Pole4.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbLoadData_Pole4.Enabled = false;
      this.cmbLoadData_Pole4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbLoadData_Pole4.ForeColor = Color.Black;
      this.cmbLoadData_Pole4.FormattingEnabled = true;
      this.cmbLoadData_Pole4.Items.AddRange(new object[9]
      {
        (object) "LOGIN",
        (object) "@domain",
        (object) "DOMAIN",
        (object) "Пароль",
        (object) "Сек. ответ",
        (object) "Имя",
        (object) "Фамилия",
        (object) "Пол (M / F)",
        (object) "Город"
      });
      ComboBox cmbLoadDataPole4_1 = this.cmbLoadData_Pole4;
      point1 = new Point(17, 14);
      Point point113 = point1;
      cmbLoadDataPole4_1.Location = point113;
      this.cmbLoadData_Pole4.Name = "cmbLoadData_Pole4";
      ComboBox cmbLoadDataPole4_2 = this.cmbLoadData_Pole4;
      size1 = new Size(82, 21);
      Size size113 = size1;
      cmbLoadDataPole4_2.Size = size113;
      this.cmbLoadData_Pole4.TabIndex = 135;
      this.cmbLoadData_Pole4.TabStop = false;
      this.cmbLoadData_Pole4.Tag = (object) "4";
      this.chLoadData_Pole4.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      CheckBox chLoadDataPole4_1 = this.chLoadData_Pole4;
      point1 = new Point(3, 18);
      Point point114 = point1;
      chLoadDataPole4_1.Location = point114;
      this.chLoadData_Pole4.Name = "chLoadData_Pole4";
      CheckBox chLoadDataPole4_2 = this.chLoadData_Pole4;
      size1 = new Size(13, 13);
      Size size114 = size1;
      chLoadDataPole4_2.Size = size114;
      this.chLoadData_Pole4.TabIndex = 136;
      this.chLoadData_Pole4.Tag = (object) "4";
      this.chLoadData_Pole4.UseVisualStyleBackColor = true;
      this.boxLoadData_Pole3.Controls.Add((Control) this.cmbLoadData_Pole3);
      this.boxLoadData_Pole3.Controls.Add((Control) this.chLoadData_Pole3);
      this.boxLoadData_Pole3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.boxLoadData_Pole3.ForeColor = Color.Black;
      GroupBox boxLoadDataPole3_1 = this.boxLoadData_Pole3;
      point1 = new Point(210, 70);
      Point point115 = point1;
      boxLoadDataPole3_1.Location = point115;
      this.boxLoadData_Pole3.Name = "boxLoadData_Pole3";
      GroupBox boxLoadDataPole3_2 = this.boxLoadData_Pole3;
      size1 = new Size(102, 39);
      Size size115 = size1;
      boxLoadDataPole3_2.Size = size115;
      this.boxLoadData_Pole3.TabIndex = 146;
      this.boxLoadData_Pole3.TabStop = false;
      this.boxLoadData_Pole3.Text = "Data 3";
      this.cmbLoadData_Pole3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.cmbLoadData_Pole3.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbLoadData_Pole3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbLoadData_Pole3.Enabled = false;
      this.cmbLoadData_Pole3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbLoadData_Pole3.ForeColor = Color.Black;
      this.cmbLoadData_Pole3.FormattingEnabled = true;
      this.cmbLoadData_Pole3.Items.AddRange(new object[9]
      {
        (object) "LOGIN",
        (object) "@domain",
        (object) "DOMAIN",
        (object) "Пароль",
        (object) "Сек. ответ",
        (object) "Имя",
        (object) "Фамилия",
        (object) "Пол (M / F)",
        (object) "Город"
      });
      ComboBox cmbLoadDataPole3_1 = this.cmbLoadData_Pole3;
      point1 = new Point(17, 14);
      Point point116 = point1;
      cmbLoadDataPole3_1.Location = point116;
      this.cmbLoadData_Pole3.Name = "cmbLoadData_Pole3";
      ComboBox cmbLoadDataPole3_2 = this.cmbLoadData_Pole3;
      size1 = new Size(82, 21);
      Size size116 = size1;
      cmbLoadDataPole3_2.Size = size116;
      this.cmbLoadData_Pole3.TabIndex = 135;
      this.cmbLoadData_Pole3.TabStop = false;
      this.cmbLoadData_Pole3.Tag = (object) "3";
      this.chLoadData_Pole3.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      CheckBox chLoadDataPole3_1 = this.chLoadData_Pole3;
      point1 = new Point(3, 18);
      Point point117 = point1;
      chLoadDataPole3_1.Location = point117;
      this.chLoadData_Pole3.Name = "chLoadData_Pole3";
      CheckBox chLoadDataPole3_2 = this.chLoadData_Pole3;
      size1 = new Size(13, 13);
      Size size117 = size1;
      chLoadDataPole3_2.Size = size117;
      this.chLoadData_Pole3.TabIndex = 136;
      this.chLoadData_Pole3.Tag = (object) "3";
      this.chLoadData_Pole3.UseVisualStyleBackColor = true;
      this.boxLoadData_Pole2.Controls.Add((Control) this.cmbLoadData_Pole2);
      this.boxLoadData_Pole2.Controls.Add((Control) this.chLoadData_Pole2);
      this.boxLoadData_Pole2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.boxLoadData_Pole2.ForeColor = Color.Black;
      GroupBox boxLoadDataPole2_1 = this.boxLoadData_Pole2;
      point1 = new Point(108, 70);
      Point point118 = point1;
      boxLoadDataPole2_1.Location = point118;
      this.boxLoadData_Pole2.Name = "boxLoadData_Pole2";
      GroupBox boxLoadDataPole2_2 = this.boxLoadData_Pole2;
      size1 = new Size(102, 39);
      Size size118 = size1;
      boxLoadDataPole2_2.Size = size118;
      this.boxLoadData_Pole2.TabIndex = 145;
      this.boxLoadData_Pole2.TabStop = false;
      this.boxLoadData_Pole2.Text = "Data 2";
      this.cmbLoadData_Pole2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.cmbLoadData_Pole2.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbLoadData_Pole2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbLoadData_Pole2.Enabled = false;
      this.cmbLoadData_Pole2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbLoadData_Pole2.ForeColor = Color.Black;
      this.cmbLoadData_Pole2.FormattingEnabled = true;
      this.cmbLoadData_Pole2.Items.AddRange(new object[9]
      {
        (object) "LOGIN",
        (object) "@domain",
        (object) "DOMAIN",
        (object) "Пароль",
        (object) "Сек. ответ",
        (object) "Имя",
        (object) "Фамилия",
        (object) "Пол (M / F)",
        (object) "Город"
      });
      ComboBox cmbLoadDataPole2_1 = this.cmbLoadData_Pole2;
      point1 = new Point(17, 14);
      Point point119 = point1;
      cmbLoadDataPole2_1.Location = point119;
      this.cmbLoadData_Pole2.Name = "cmbLoadData_Pole2";
      ComboBox cmbLoadDataPole2_2 = this.cmbLoadData_Pole2;
      size1 = new Size(82, 21);
      Size size119 = size1;
      cmbLoadDataPole2_2.Size = size119;
      this.cmbLoadData_Pole2.TabIndex = 135;
      this.cmbLoadData_Pole2.TabStop = false;
      this.cmbLoadData_Pole2.Tag = (object) "2";
      this.chLoadData_Pole2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      CheckBox chLoadDataPole2_1 = this.chLoadData_Pole2;
      point1 = new Point(3, 18);
      Point point120 = point1;
      chLoadDataPole2_1.Location = point120;
      this.chLoadData_Pole2.Name = "chLoadData_Pole2";
      CheckBox chLoadDataPole2_2 = this.chLoadData_Pole2;
      size1 = new Size(13, 13);
      Size size120 = size1;
      chLoadDataPole2_2.Size = size120;
      this.chLoadData_Pole2.TabIndex = 136;
      this.chLoadData_Pole2.Tag = (object) "2";
      this.chLoadData_Pole2.UseVisualStyleBackColor = true;
      this.GroupBox16.Controls.Add((Control) this.lblLoadData_Example);
      this.GroupBox16.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox16_1 = this.GroupBox16;
      point1 = new Point(145, 22);
      Point point121 = point1;
      groupBox16_1.Location = point121;
      this.GroupBox16.Name = "GroupBox16";
      GroupBox groupBox16_2 = this.GroupBox16;
      size1 = new Size(445, 46);
      Size size121 = size1;
      groupBox16_2.Size = size121;
      this.GroupBox16.TabIndex = 144;
      this.GroupBox16.TabStop = false;
      this.GroupBox16.Text = "Формат данных для загрузки:";
      this.lblLoadData_Example.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.lblLoadData_Example.BackColor = Color.White;
      this.lblLoadData_Example.BorderStyle = BorderStyle.Fixed3D;
      this.lblLoadData_Example.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lblLoadData_Example.ForeColor = Color.Blue;
      Label lblLoadDataExample1 = this.lblLoadData_Example;
      point1 = new Point(3, 18);
      Point point122 = point1;
      lblLoadDataExample1.Location = point122;
      this.lblLoadData_Example.Name = "lblLoadData_Example";
      Label lblLoadDataExample2 = this.lblLoadData_Example;
      size1 = new Size(439, 22);
      Size size122 = size1;
      lblLoadDataExample2.Size = size122;
      this.lblLoadData_Example.TabIndex = 0;
      this.lblLoadData_Example.Text = "string example";
      this.boxLoadData_Pole1.BackColor = Color.WhiteSmoke;
      this.boxLoadData_Pole1.Controls.Add((Control) this.cmbLoadData_Pole1);
      this.boxLoadData_Pole1.Controls.Add((Control) this.chLoadData_Pole1);
      this.boxLoadData_Pole1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.boxLoadData_Pole1.ForeColor = Color.Black;
      GroupBox boxLoadDataPole1_1 = this.boxLoadData_Pole1;
      point1 = new Point(6, 70);
      Point point123 = point1;
      boxLoadDataPole1_1.Location = point123;
      this.boxLoadData_Pole1.Name = "boxLoadData_Pole1";
      GroupBox boxLoadDataPole1_2 = this.boxLoadData_Pole1;
      size1 = new Size(102, 39);
      Size size123 = size1;
      boxLoadDataPole1_2.Size = size123;
      this.boxLoadData_Pole1.TabIndex = 136;
      this.boxLoadData_Pole1.TabStop = false;
      this.boxLoadData_Pole1.Text = "Data 1";
      this.cmbLoadData_Pole1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.cmbLoadData_Pole1.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbLoadData_Pole1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbLoadData_Pole1.Enabled = false;
      this.cmbLoadData_Pole1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbLoadData_Pole1.ForeColor = Color.Black;
      this.cmbLoadData_Pole1.FormattingEnabled = true;
      this.cmbLoadData_Pole1.Items.AddRange(new object[9]
      {
        (object) "LOGIN",
        (object) "@domain",
        (object) "DOMAIN",
        (object) "Пароль",
        (object) "Сек. ответ",
        (object) "Имя",
        (object) "Фамилия",
        (object) "Пол (M / F)",
        (object) "Город"
      });
      ComboBox cmbLoadDataPole1_1 = this.cmbLoadData_Pole1;
      point1 = new Point(17, 14);
      Point point124 = point1;
      cmbLoadDataPole1_1.Location = point124;
      this.cmbLoadData_Pole1.Name = "cmbLoadData_Pole1";
      ComboBox cmbLoadDataPole1_2 = this.cmbLoadData_Pole1;
      size1 = new Size(82, 21);
      Size size124 = size1;
      cmbLoadDataPole1_2.Size = size124;
      this.cmbLoadData_Pole1.TabIndex = 135;
      this.cmbLoadData_Pole1.TabStop = false;
      this.cmbLoadData_Pole1.Tag = (object) "1";
      this.chLoadData_Pole1.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      CheckBox chLoadDataPole1_1 = this.chLoadData_Pole1;
      point1 = new Point(3, 18);
      Point point125 = point1;
      chLoadDataPole1_1.Location = point125;
      this.chLoadData_Pole1.Name = "chLoadData_Pole1";
      CheckBox chLoadDataPole1_2 = this.chLoadData_Pole1;
      size1 = new Size(13, 13);
      Size size125 = size1;
      chLoadDataPole1_2.Size = size125;
      this.chLoadData_Pole1.TabIndex = 136;
      this.chLoadData_Pole1.Tag = (object) "1";
      this.chLoadData_Pole1.UseVisualStyleBackColor = true;
      this.PictureBox10.Image = (Image) componentResourceManager.GetObject("PictureBox10.Image");
      PictureBox pictureBox10_1 = this.PictureBox10;
      point1 = new Point(3, 21);
      Point point126 = point1;
      pictureBox10_1.Location = point126;
      this.PictureBox10.Name = "PictureBox10";
      PictureBox pictureBox10_2 = this.PictureBox10;
      size1 = new Size(48, 48);
      Size size126 = size1;
      pictureBox10_2.Size = size126;
      this.PictureBox10.TabIndex = 99;
      this.PictureBox10.TabStop = false;
      this.btnLoadData.BackColor = Color.FromArgb(224, 224, 224);
      this.btnLoadData.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnLoadData.ForeColor = Color.Black;
      Button btnLoadData1 = this.btnLoadData;
      point1 = new Point(732, 25);
      Point point127 = point1;
      btnLoadData1.Location = point127;
      this.btnLoadData.Name = "btnLoadData";
      Button btnLoadData2 = this.btnLoadData;
      size1 = new Size(90, 40);
      Size size127 = size1;
      btnLoadData2.Size = size127;
      this.btnLoadData.TabIndex = 11;
      this.btnLoadData.Text = "Загрузить";
      this.btnLoadData.UseVisualStyleBackColor = false;
      this.cmbLoadLogOtherData.BackColor = Color.FromArgb(224, 224, 224);
      this.cmbLoadLogOtherData.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbLoadLogOtherData.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.cmbLoadLogOtherData.FormattingEnabled = true;
      this.cmbLoadLogOtherData.Items.AddRange(new object[2]
      {
        (object) "генерировать",
        (object) "оставить пустыми"
      });
      ComboBox loadLogOtherData1 = this.cmbLoadLogOtherData;
      point1 = new Point(592, 44);
      Point point128 = point1;
      loadLogOtherData1.Location = point128;
      this.cmbLoadLogOtherData.Name = "cmbLoadLogOtherData";
      ComboBox loadLogOtherData2 = this.cmbLoadLogOtherData;
      size1 = new Size(138, 21);
      Size size128 = size1;
      loadLogOtherData2.Size = size128;
      this.cmbLoadLogOtherData.TabIndex = 8;
      this.cmbLoadLogOtherData.TabStop = false;
      this.Label22.AutoSize = true;
      this.Label22.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      Label label22_1 = this.Label22;
      point1 = new Point(600, 25);
      Point point129 = point1;
      label22_1.Location = point129;
      this.Label22.Name = "Label22";
      Label label22_2 = this.Label22;
      size1 = new Size(121, 13);
      Size size129 = size1;
      label22_2.Size = size129;
      this.Label22.TabIndex = 2;
      this.Label22.Text = "недостающие данные";
      ProgressBar pbGenLogin1 = this.pbGenLogin;
      point1 = new Point(3, 474);
      Point point130 = point1;
      pbGenLogin1.Location = point130;
      this.pbGenLogin.Name = "pbGenLogin";
      ProgressBar pbGenLogin2 = this.pbGenLogin;
      size1 = new Size(832, 10);
      Size size130 = size1;
      pbGenLogin2.Size = size130;
      this.pbGenLogin.TabIndex = 170;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.WhiteSmoke;
      size1 = new Size(836, 485);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.pbGenLogin);
      this.Controls.Add((Control) this.GroupBox7);
      this.Controls.Add((Control) this.Label20);
      this.Controls.Add((Control) this.chHardCheck);
      this.Controls.Add((Control) this.сhYandexPause);
      this.Controls.Add((Control) this.Label19);
      this.Controls.Add((Control) this.RadioButton11);
      this.Controls.Add((Control) this.RadioButton10);
      this.Controls.Add((Control) this.RadioButton9);
      this.Controls.Add((Control) this.RadioButton8);
      this.Controls.Add((Control) this.RadioButton7);
      this.Controls.Add((Control) this.RadioButton6);
      this.Controls.Add((Control) this.rbSelectMail_3);
      this.Controls.Add((Control) this.RadioButton4);
      this.Controls.Add((Control) this.RadioButton3);
      this.Controls.Add((Control) this.rbSelectMail_1);
      this.Controls.Add((Control) this.rbSelectMail_2);
      this.Controls.Add((Control) this.rbSelectMail_0);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.GroupBox6);
      this.Controls.Add((Control) this.PictureBox9);
      this.Controls.Add((Control) this.lblInfo);
      this.Controls.Add((Control) this.GroupBox4);
      this.Controls.Add((Control) this.txtGenCount);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (frmGenBlank);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Генерация заготовок e-Mail";
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      ((ISupportInitialize) this.picWarning).EndInit();
      this.grOpWordGen.ResumeLayout(false);
      this.grOpWordGen.PerformLayout();
      ((ISupportInitialize) this.PictureBox8).EndInit();
      ((ISupportInitialize) this.PictureBox7).EndInit();
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((ISupportInitialize) this.PictureBox5).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      ((ISupportInitialize) this.PictureBox3).EndInit();
      ((ISupportInitialize) this.PictureBox9).EndInit();
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox6.PerformLayout();
      this.GroupBox7.ResumeLayout(false);
      this.GroupBox7.PerformLayout();
      this.boxLoadData_Pole8.ResumeLayout(false);
      this.boxLoadData_Pole7.ResumeLayout(false);
      this.boxLoadData_Pole6.ResumeLayout(false);
      this.boxLoadData_Pole5.ResumeLayout(false);
      this.boxLoadData_Pole4.ResumeLayout(false);
      this.boxLoadData_Pole3.ResumeLayout(false);
      this.boxLoadData_Pole2.ResumeLayout(false);
      this.GroupBox16.ResumeLayout(false);
      this.boxLoadData_Pole1.ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox10).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
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

    internal virtual TextBox txtLoadLogDIV
    {
      get
      {
        return this._txtLoadLogDIV;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLoadLogDIV_TextChanged);
        if (this._txtLoadLogDIV != null)
          this._txtLoadLogDIV.TextChanged -= eventHandler;
        this._txtLoadLogDIV = value;
        if (this._txtLoadLogDIV == null)
          return;
        this._txtLoadLogDIV.TextChanged += eventHandler;
      }
    }

    internal virtual OpenFileDialog OpenFileDialog1
    {
      get
      {
        return this._OpenFileDialog1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._OpenFileDialog1 = value;
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

    internal virtual TextBox txtLastName
    {
      get
      {
        return this._txtLastName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLastName_TextChanged);
        if (this._txtLastName != null)
          this._txtLastName.TextChanged -= eventHandler;
        this._txtLastName = value;
        if (this._txtLastName == null)
          return;
        this._txtLastName.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtName
    {
      get
      {
        return this._txtName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtName_TextChanged);
        if (this._txtName != null)
          this._txtName.TextChanged -= eventHandler;
        this._txtName = value;
        if (this._txtName == null)
          return;
        this._txtName.TextChanged += eventHandler;
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

    internal virtual CheckBox chRND_1
    {
      get
      {
        return this._chRND_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chRND_1_CheckedChanged);
        if (this._chRND_1 != null)
          this._chRND_1.CheckedChanged -= eventHandler;
        this._chRND_1 = value;
        if (this._chRND_1 == null)
          return;
        this._chRND_1.CheckedChanged += eventHandler;
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

    internal virtual ComboBox cmbUserSex
    {
      get
      {
        return this._cmbUserSex;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbUserSex_SelectedIndexChanged);
        if (this._cmbUserSex != null)
          this._cmbUserSex.SelectedIndexChanged -= eventHandler;
        this._cmbUserSex = value;
        if (this._cmbUserSex == null)
          return;
        this._cmbUserSex.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chRND_2
    {
      get
      {
        return this._chRND_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chRND_2_CheckedChanged);
        if (this._chRND_2 != null)
          this._chRND_2.CheckedChanged -= eventHandler;
        this._chRND_2 = value;
        if (this._chRND_2 == null)
          return;
        this._chRND_2.CheckedChanged += eventHandler;
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

    internal virtual ImageList ImageList1
    {
      get
      {
        return this._ImageList1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ImageList1 = value;
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

    internal virtual ComboBox cmbTown
    {
      get
      {
        return this._cmbTown;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbTown_SelectedIndexChanged);
        if (this._cmbTown != null)
          this._cmbTown.SelectedIndexChanged -= eventHandler;
        this._cmbTown = value;
        if (this._cmbTown == null)
          return;
        this._cmbTown.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual TextBox txtTown
    {
      get
      {
        return this._txtTown;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtTown_TextChanged);
        if (this._txtTown != null)
          this._txtTown.TextChanged -= eventHandler;
        this._txtTown = value;
        if (this._txtTown == null)
          return;
        this._txtTown.TextChanged += eventHandler;
      }
    }

    internal virtual CheckBox chRND_3
    {
      get
      {
        return this._chRND_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chRND_3_CheckedChanged);
        if (this._chRND_3 != null)
          this._chRND_3.CheckedChanged -= eventHandler;
        this._chRND_3 = value;
        if (this._chRND_3 == null)
          return;
        this._chRND_3.CheckedChanged += eventHandler;
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

    internal virtual ComboBox cmbAccSel_Domain
    {
      get
      {
        return this._cmbAccSel_Domain;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbAccSel_Domain_SelectedIndexChanged);
        if (this._cmbAccSel_Domain != null)
          this._cmbAccSel_Domain.SelectedIndexChanged -= eventHandler;
        this._cmbAccSel_Domain = value;
        if (this._cmbAccSel_Domain == null)
          return;
        this._cmbAccSel_Domain.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chRND_4
    {
      get
      {
        return this._chRND_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chRND_4_CheckedChanged);
        if (this._chRND_4 != null)
          this._chRND_4.CheckedChanged -= eventHandler;
        this._chRND_4 = value;
        if (this._chRND_4 == null)
          return;
        this._chRND_4.CheckedChanged += eventHandler;
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

    internal virtual TextBox txtUserGenPass
    {
      get
      {
        return this._txtUserGenPass;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtUserGenPass_TextChanged);
        if (this._txtUserGenPass != null)
          this._txtUserGenPass.TextChanged -= eventHandler;
        this._txtUserGenPass = value;
        if (this._txtUserGenPass == null)
          return;
        this._txtUserGenPass.TextChanged += eventHandler;
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

    internal virtual PictureBox PictureBox4
    {
      get
      {
        return this._PictureBox4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox4 = value;
      }
    }

    internal virtual PictureBox PictureBox3
    {
      get
      {
        return this._PictureBox3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox3 = value;
      }
    }

    internal virtual CheckBox chRND_5
    {
      get
      {
        return this._chRND_5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chRND_5_CheckedChanged);
        if (this._chRND_5 != null)
          this._chRND_5.CheckedChanged -= eventHandler;
        this._chRND_5 = value;
        if (this._chRND_5 == null)
          return;
        this._chRND_5.CheckedChanged += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox7
    {
      get
      {
        return this._PictureBox7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox7 = value;
      }
    }

    internal virtual PictureBox PictureBox6
    {
      get
      {
        return this._PictureBox6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox6 = value;
      }
    }

    internal virtual PictureBox PictureBox5
    {
      get
      {
        return this._PictureBox5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox5 = value;
      }
    }

    internal virtual PictureBox PictureBox8
    {
      get
      {
        return this._PictureBox8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox8 = value;
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

    internal virtual TextBox txtAnswer
    {
      get
      {
        return this._txtAnswer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtAnswer_TextChanged);
        if (this._txtAnswer != null)
          this._txtAnswer.TextChanged -= eventHandler;
        this._txtAnswer = value;
        if (this._txtAnswer == null)
          return;
        this._txtAnswer.TextChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbUserQuest
    {
      get
      {
        return this._cmbUserQuest;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbUserQuest_SelectedIndexChanged);
        if (this._cmbUserQuest != null)
          this._cmbUserQuest.SelectedIndexChanged -= eventHandler;
        this._cmbUserQuest = value;
        if (this._cmbUserQuest == null)
          return;
        this._cmbUserQuest.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chRND_6
    {
      get
      {
        return this._chRND_6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chRND_6_CheckedChanged);
        if (this._chRND_6 != null)
          this._chRND_6.CheckedChanged -= eventHandler;
        this._chRND_6 = value;
        if (this._chRND_6 == null)
          return;
        this._chRND_6.CheckedChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbUserYearBD
    {
      get
      {
        return this._cmbUserYearBD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbUserYearBD_SelectedIndexChanged);
        if (this._cmbUserYearBD != null)
          this._cmbUserYearBD.SelectedIndexChanged -= eventHandler;
        this._cmbUserYearBD = value;
        if (this._cmbUserYearBD == null)
          return;
        this._cmbUserYearBD.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbUserMonthBD
    {
      get
      {
        return this._cmbUserMonthBD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbUserMonthBD_SelectedIndexChanged);
        if (this._cmbUserMonthBD != null)
          this._cmbUserMonthBD.SelectedIndexChanged -= eventHandler;
        this._cmbUserMonthBD = value;
        if (this._cmbUserMonthBD == null)
          return;
        this._cmbUserMonthBD.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbUserDayBD
    {
      get
      {
        return this._cmbUserDayBD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbUserDayBD_SelectedIndexChanged);
        if (this._cmbUserDayBD != null)
          this._cmbUserDayBD.SelectedIndexChanged -= eventHandler;
        this._cmbUserDayBD = value;
        if (this._cmbUserDayBD == null)
          return;
        this._cmbUserDayBD.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chRND_7
    {
      get
      {
        return this._chRND_7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chRND_7_CheckedChanged);
        if (this._chRND_7 != null)
          this._chRND_7.CheckedChanged -= eventHandler;
        this._chRND_7 = value;
        if (this._chRND_7 == null)
          return;
        this._chRND_7.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chRND_8
    {
      get
      {
        return this._chRND_8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chRND_8_CheckedChanged);
        if (this._chRND_8 != null)
          this._chRND_8.CheckedChanged -= eventHandler;
        this._chRND_8 = value;
        if (this._chRND_8 == null)
          return;
        this._chRND_8.CheckedChanged += eventHandler;
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

    internal virtual CheckBox chDopMethod_1
    {
      get
      {
        return this._chDopMethod_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chDopMethod_1_CheckedChanged);
        if (this._chDopMethod_1 != null)
          this._chDopMethod_1.CheckedChanged -= eventHandler;
        this._chDopMethod_1 = value;
        if (this._chDopMethod_1 == null)
          return;
        this._chDopMethod_1.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chMethod_3
    {
      get
      {
        return this._chMethod_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chMethod_1_CheckedChanged);
        if (this._chMethod_3 != null)
          this._chMethod_3.CheckedChanged -= eventHandler;
        this._chMethod_3 = value;
        if (this._chMethod_3 == null)
          return;
        this._chMethod_3.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chUseAllMethod
    {
      get
      {
        return this._chUseAllMethod;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._chUseAllMethod = value;
      }
    }

    internal virtual CheckBox chDopMethod_3
    {
      get
      {
        return this._chDopMethod_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chDopMethod_1_CheckedChanged);
        if (this._chDopMethod_3 != null)
          this._chDopMethod_3.CheckedChanged -= eventHandler;
        this._chDopMethod_3 = value;
        if (this._chDopMethod_3 == null)
          return;
        this._chDopMethod_3.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chMethod_1
    {
      get
      {
        return this._chMethod_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chMethod_1_CheckedChanged);
        if (this._chMethod_1 != null)
          this._chMethod_1.CheckedChanged -= eventHandler;
        this._chMethod_1 = value;
        if (this._chMethod_1 == null)
          return;
        this._chMethod_1.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chDopMethod_2
    {
      get
      {
        return this._chDopMethod_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chDopMethod_1_CheckedChanged);
        if (this._chDopMethod_2 != null)
          this._chDopMethod_2.CheckedChanged -= eventHandler;
        this._chDopMethod_2 = value;
        if (this._chDopMethod_2 == null)
          return;
        this._chDopMethod_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chMethod_2
    {
      get
      {
        return this._chMethod_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chMethod_1_CheckedChanged);
        if (this._chMethod_2 != null)
          this._chMethod_2.CheckedChanged -= eventHandler;
        this._chMethod_2 = value;
        if (this._chMethod_2 == null)
          return;
        this._chMethod_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chMethod_4
    {
      get
      {
        return this._chMethod_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chMethod_1_CheckedChanged);
        if (this._chMethod_4 != null)
          this._chMethod_4.CheckedChanged -= eventHandler;
        this._chMethod_4 = value;
        if (this._chMethod_4 == null)
          return;
        this._chMethod_4.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox grOpWordGen
    {
      get
      {
        return this._grOpWordGen;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._grOpWordGen = value;
      }
    }

    internal virtual TextBox txtGenMaxLen
    {
      get
      {
        return this._txtGenMaxLen;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtGenMaxLen_TextChanged);
        if (this._txtGenMaxLen != null)
          this._txtGenMaxLen.TextChanged -= eventHandler;
        this._txtGenMaxLen = value;
        if (this._txtGenMaxLen == null)
          return;
        this._txtGenMaxLen.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtGenMinLen
    {
      get
      {
        return this._txtGenMinLen;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtGenMinLen_TextChanged);
        if (this._txtGenMinLen != null)
          this._txtGenMinLen.TextChanged -= eventHandler;
        this._txtGenMinLen = value;
        if (this._txtGenMinLen == null)
          return;
        this._txtGenMinLen.TextChanged += eventHandler;
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

    internal virtual Label lblChanse_4
    {
      get
      {
        return this._lblChanse_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblChanse_4 = value;
      }
    }

    internal virtual Label lblChanse_3
    {
      get
      {
        return this._lblChanse_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblChanse_3 = value;
      }
    }

    internal virtual Label lblChanse_2
    {
      get
      {
        return this._lblChanse_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblChanse_2 = value;
      }
    }

    internal virtual Label lblChanse_1
    {
      get
      {
        return this._lblChanse_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblChanse_1 = value;
      }
    }

    internal virtual ComboBox cmbDoubleSOglas
    {
      get
      {
        return this._cmbDoubleSOglas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbDoubleSOglas_SelectedIndexChanged);
        if (this._cmbDoubleSOglas != null)
          this._cmbDoubleSOglas.SelectedIndexChanged -= eventHandler;
        this._cmbDoubleSOglas = value;
        if (this._cmbDoubleSOglas == null)
          return;
        this._cmbDoubleSOglas.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbDoubleGlas
    {
      get
      {
        return this._cmbDoubleGlas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbDoubleGlas_SelectedIndexChanged);
        if (this._cmbDoubleGlas != null)
          this._cmbDoubleGlas.SelectedIndexChanged -= eventHandler;
        this._cmbDoubleGlas = value;
        if (this._cmbDoubleGlas == null)
          return;
        this._cmbDoubleGlas.SelectedIndexChanged += eventHandler;
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

    internal virtual ComboBox cmbUseNum
    {
      get
      {
        return this._cmbUseNum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbUseNum_SelectedIndexChanged);
        if (this._cmbUseNum != null)
          this._cmbUseNum.SelectedIndexChanged -= eventHandler;
        this._cmbUseNum = value;
        if (this._cmbUseNum == null)
          return;
        this._cmbUseNum.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chDoubleSOglas
    {
      get
      {
        return this._chDoubleSOglas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chDoubleSOglas_CheckedChanged);
        if (this._chDoubleSOglas != null)
          this._chDoubleSOglas.CheckedChanged -= eventHandler;
        this._chDoubleSOglas = value;
        if (this._chDoubleSOglas == null)
          return;
        this._chDoubleSOglas.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chDoubleGlas
    {
      get
      {
        return this._chDoubleGlas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chDoubleGlas_CheckedChanged);
        if (this._chDoubleGlas != null)
          this._chDoubleGlas.CheckedChanged -= eventHandler;
        this._chDoubleGlas = value;
        if (this._chDoubleGlas == null)
          return;
        this._chDoubleGlas.CheckedChanged += eventHandler;
      }
    }

    internal virtual PictureBox picWarning
    {
      get
      {
        return this._picWarning;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picWarning = value;
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

    internal virtual Label lblInfo
    {
      get
      {
        return this._lblInfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblInfo = value;
      }
    }

    internal virtual CheckBox chDopMethod_4
    {
      get
      {
        return this._chDopMethod_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chDopMethod_1_CheckedChanged);
        if (this._chDopMethod_4 != null)
          this._chDopMethod_4.CheckedChanged -= eventHandler;
        this._chDopMethod_4 = value;
        if (this._chDopMethod_4 == null)
          return;
        this._chDopMethod_4.CheckedChanged += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox9
    {
      get
      {
        return this._PictureBox9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox9 = value;
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

    internal virtual Button btmTestGen
    {
      get
      {
        return this._btmTestGen;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btmTestGen_Click);
        if (this._btmTestGen != null)
          this._btmTestGen.Click -= eventHandler;
        this._btmTestGen = value;
        if (this._btmTestGen == null)
          return;
        this._btmTestGen.Click += eventHandler;
      }
    }

    internal virtual TextBox txtTestLogin
    {
      get
      {
        return this._txtTestLogin;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtTestLogin = value;
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

    internal virtual TextBox txtGenCount
    {
      get
      {
        return this._txtGenCount;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtGenCount_TextChanged);
        if (this._txtGenCount != null)
          this._txtGenCount.TextChanged -= eventHandler;
        this._txtGenCount = value;
        if (this._txtGenCount == null)
          return;
        this._txtGenCount.TextChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbUseNumPercent
    {
      get
      {
        return this._cmbUseNumPercent;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbUseNumPercent_SelectedIndexChanged);
        if (this._cmbUseNumPercent != null)
          this._cmbUseNumPercent.SelectedIndexChanged -= eventHandler;
        this._cmbUseNumPercent = value;
        if (this._cmbUseNumPercent == null)
          return;
        this._cmbUseNumPercent.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbDopPercent_4
    {
      get
      {
        return this._cmbDopPercent_4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbDopPercent_4_SelectedIndexChanged);
        if (this._cmbDopPercent_4 != null)
          this._cmbDopPercent_4.SelectedIndexChanged -= eventHandler;
        this._cmbDopPercent_4 = value;
        if (this._cmbDopPercent_4 == null)
          return;
        this._cmbDopPercent_4.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbDopPercent_3
    {
      get
      {
        return this._cmbDopPercent_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbDopPercent_3_SelectedIndexChanged);
        if (this._cmbDopPercent_3 != null)
          this._cmbDopPercent_3.SelectedIndexChanged -= eventHandler;
        this._cmbDopPercent_3 = value;
        if (this._cmbDopPercent_3 == null)
          return;
        this._cmbDopPercent_3.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbDopPercent_2
    {
      get
      {
        return this._cmbDopPercent_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbDopPercent_2_SelectedIndexChanged);
        if (this._cmbDopPercent_2 != null)
          this._cmbDopPercent_2.SelectedIndexChanged -= eventHandler;
        this._cmbDopPercent_2 = value;
        if (this._cmbDopPercent_2 == null)
          return;
        this._cmbDopPercent_2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cmbDopPercent_1
    {
      get
      {
        return this._cmbDopPercent_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbDopPercent_1_SelectedIndexChanged);
        if (this._cmbDopPercent_1 != null)
          this._cmbDopPercent_1.SelectedIndexChanged -= eventHandler;
        this._cmbDopPercent_1 = value;
        if (this._cmbDopPercent_1 == null)
          return;
        this._cmbDopPercent_1.SelectedIndexChanged += eventHandler;
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

    internal virtual RadioButton rbSelectMail_0
    {
      get
      {
        return this._rbSelectMail_0;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbSelectMail_1_CheckedChanged);
        if (this._rbSelectMail_0 != null)
          this._rbSelectMail_0.CheckedChanged -= eventHandler;
        this._rbSelectMail_0 = value;
        if (this._rbSelectMail_0 == null)
          return;
        this._rbSelectMail_0.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbSelectMail_2
    {
      get
      {
        return this._rbSelectMail_2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbSelectMail_1_CheckedChanged);
        if (this._rbSelectMail_2 != null)
          this._rbSelectMail_2.CheckedChanged -= eventHandler;
        this._rbSelectMail_2 = value;
        if (this._rbSelectMail_2 == null)
          return;
        this._rbSelectMail_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbSelectMail_1
    {
      get
      {
        return this._rbSelectMail_1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbSelectMail_1_CheckedChanged);
        if (this._rbSelectMail_1 != null)
          this._rbSelectMail_1.CheckedChanged -= eventHandler;
        this._rbSelectMail_1 = value;
        if (this._rbSelectMail_1 == null)
          return;
        this._rbSelectMail_1.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton3
    {
      get
      {
        return this._RadioButton3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton3 = value;
      }
    }

    internal virtual RadioButton RadioButton4
    {
      get
      {
        return this._RadioButton4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton4 = value;
      }
    }

    internal virtual RadioButton rbSelectMail_3
    {
      get
      {
        return this._rbSelectMail_3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbSelectMail_1_CheckedChanged);
        if (this._rbSelectMail_3 != null)
          this._rbSelectMail_3.CheckedChanged -= eventHandler;
        this._rbSelectMail_3 = value;
        if (this._rbSelectMail_3 == null)
          return;
        this._rbSelectMail_3.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton6
    {
      get
      {
        return this._RadioButton6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton6 = value;
      }
    }

    internal virtual RadioButton RadioButton7
    {
      get
      {
        return this._RadioButton7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton7 = value;
      }
    }

    internal virtual RadioButton RadioButton8
    {
      get
      {
        return this._RadioButton8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton8 = value;
      }
    }

    internal virtual RadioButton RadioButton9
    {
      get
      {
        return this._RadioButton9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton9 = value;
      }
    }

    internal virtual RadioButton RadioButton10
    {
      get
      {
        return this._RadioButton10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton10 = value;
      }
    }

    internal virtual RadioButton RadioButton11
    {
      get
      {
        return this._RadioButton11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton11 = value;
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

    internal virtual CheckBox сhYandexPause
    {
      get
      {
        return this._сhYandexPause;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.сhYandexPause_CheckedChanged);
        if (this._сhYandexPause != null)
          this._сhYandexPause.CheckedChanged -= eventHandler;
        this._сhYandexPause = value;
        if (this._сhYandexPause == null)
          return;
        this._сhYandexPause.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chHardCheck
    {
      get
      {
        return this._chHardCheck;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chHardCheck_CheckedChanged);
        if (this._chHardCheck != null)
          this._chHardCheck.CheckedChanged -= eventHandler;
        this._chHardCheck = value;
        if (this._chHardCheck == null)
          return;
        this._chHardCheck.CheckedChanged += eventHandler;
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

    internal virtual PictureBox PictureBox10
    {
      get
      {
        return this._PictureBox10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox10 = value;
      }
    }

    internal virtual Button btnLoadData
    {
      get
      {
        return this._btnLoadData;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnLoadData_Click);
        if (this._btnLoadData != null)
          this._btnLoadData.Click -= eventHandler;
        this._btnLoadData = value;
        if (this._btnLoadData == null)
          return;
        this._btnLoadData.Click += eventHandler;
      }
    }

    internal virtual ComboBox cmbLoadLogOtherData
    {
      get
      {
        return this._cmbLoadLogOtherData;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbLoadLogOtherData_SelectedIndexChanged);
        if (this._cmbLoadLogOtherData != null)
          this._cmbLoadLogOtherData.SelectedIndexChanged -= eventHandler;
        this._cmbLoadLogOtherData = value;
        if (this._cmbLoadLogOtherData == null)
          return;
        this._cmbLoadLogOtherData.SelectedIndexChanged += eventHandler;
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

    internal virtual GroupBox boxLoadData_Pole1
    {
      get
      {
        return this._boxLoadData_Pole1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxLoadData_Pole1 = value;
      }
    }

    internal virtual ComboBox cmbLoadData_Pole1
    {
      get
      {
        return this._cmbLoadData_Pole1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbLoadData_Pole1_SelectedIndexChanged);
        if (this._cmbLoadData_Pole1 != null)
          this._cmbLoadData_Pole1.SelectedIndexChanged -= eventHandler;
        this._cmbLoadData_Pole1 = value;
        if (this._cmbLoadData_Pole1 == null)
          return;
        this._cmbLoadData_Pole1.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chLoadData_Pole1
    {
      get
      {
        return this._chLoadData_Pole1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chLoadData_Pole1_CheckedChanged);
        if (this._chLoadData_Pole1 != null)
          this._chLoadData_Pole1.CheckedChanged -= eventHandler;
        this._chLoadData_Pole1 = value;
        if (this._chLoadData_Pole1 == null)
          return;
        this._chLoadData_Pole1.CheckedChanged += eventHandler;
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

    internal virtual Label lblLoadData_Example
    {
      get
      {
        return this._lblLoadData_Example;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblLoadData_Example = value;
      }
    }

    internal virtual GroupBox boxLoadData_Pole8
    {
      get
      {
        return this._boxLoadData_Pole8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxLoadData_Pole8 = value;
      }
    }

    internal virtual ComboBox cmbLoadData_Pole8
    {
      get
      {
        return this._cmbLoadData_Pole8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbLoadData_Pole1_SelectedIndexChanged);
        if (this._cmbLoadData_Pole8 != null)
          this._cmbLoadData_Pole8.SelectedIndexChanged -= eventHandler;
        this._cmbLoadData_Pole8 = value;
        if (this._cmbLoadData_Pole8 == null)
          return;
        this._cmbLoadData_Pole8.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chLoadData_Pole8
    {
      get
      {
        return this._chLoadData_Pole8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chLoadData_Pole1_CheckedChanged);
        if (this._chLoadData_Pole8 != null)
          this._chLoadData_Pole8.CheckedChanged -= eventHandler;
        this._chLoadData_Pole8 = value;
        if (this._chLoadData_Pole8 == null)
          return;
        this._chLoadData_Pole8.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox boxLoadData_Pole7
    {
      get
      {
        return this._boxLoadData_Pole7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxLoadData_Pole7 = value;
      }
    }

    internal virtual ComboBox cmbLoadData_Pole7
    {
      get
      {
        return this._cmbLoadData_Pole7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbLoadData_Pole1_SelectedIndexChanged);
        if (this._cmbLoadData_Pole7 != null)
          this._cmbLoadData_Pole7.SelectedIndexChanged -= eventHandler;
        this._cmbLoadData_Pole7 = value;
        if (this._cmbLoadData_Pole7 == null)
          return;
        this._cmbLoadData_Pole7.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chLoadData_Pole7
    {
      get
      {
        return this._chLoadData_Pole7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chLoadData_Pole1_CheckedChanged);
        if (this._chLoadData_Pole7 != null)
          this._chLoadData_Pole7.CheckedChanged -= eventHandler;
        this._chLoadData_Pole7 = value;
        if (this._chLoadData_Pole7 == null)
          return;
        this._chLoadData_Pole7.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox boxLoadData_Pole6
    {
      get
      {
        return this._boxLoadData_Pole6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxLoadData_Pole6 = value;
      }
    }

    internal virtual ComboBox cmbLoadData_Pole6
    {
      get
      {
        return this._cmbLoadData_Pole6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbLoadData_Pole1_SelectedIndexChanged);
        if (this._cmbLoadData_Pole6 != null)
          this._cmbLoadData_Pole6.SelectedIndexChanged -= eventHandler;
        this._cmbLoadData_Pole6 = value;
        if (this._cmbLoadData_Pole6 == null)
          return;
        this._cmbLoadData_Pole6.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chLoadData_Pole6
    {
      get
      {
        return this._chLoadData_Pole6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chLoadData_Pole1_CheckedChanged);
        if (this._chLoadData_Pole6 != null)
          this._chLoadData_Pole6.CheckedChanged -= eventHandler;
        this._chLoadData_Pole6 = value;
        if (this._chLoadData_Pole6 == null)
          return;
        this._chLoadData_Pole6.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox boxLoadData_Pole5
    {
      get
      {
        return this._boxLoadData_Pole5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxLoadData_Pole5 = value;
      }
    }

    internal virtual ComboBox cmbLoadData_Pole5
    {
      get
      {
        return this._cmbLoadData_Pole5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbLoadData_Pole1_SelectedIndexChanged);
        if (this._cmbLoadData_Pole5 != null)
          this._cmbLoadData_Pole5.SelectedIndexChanged -= eventHandler;
        this._cmbLoadData_Pole5 = value;
        if (this._cmbLoadData_Pole5 == null)
          return;
        this._cmbLoadData_Pole5.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chLoadData_Pole5
    {
      get
      {
        return this._chLoadData_Pole5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chLoadData_Pole1_CheckedChanged);
        if (this._chLoadData_Pole5 != null)
          this._chLoadData_Pole5.CheckedChanged -= eventHandler;
        this._chLoadData_Pole5 = value;
        if (this._chLoadData_Pole5 == null)
          return;
        this._chLoadData_Pole5.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox boxLoadData_Pole4
    {
      get
      {
        return this._boxLoadData_Pole4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxLoadData_Pole4 = value;
      }
    }

    internal virtual ComboBox cmbLoadData_Pole4
    {
      get
      {
        return this._cmbLoadData_Pole4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbLoadData_Pole1_SelectedIndexChanged);
        if (this._cmbLoadData_Pole4 != null)
          this._cmbLoadData_Pole4.SelectedIndexChanged -= eventHandler;
        this._cmbLoadData_Pole4 = value;
        if (this._cmbLoadData_Pole4 == null)
          return;
        this._cmbLoadData_Pole4.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chLoadData_Pole4
    {
      get
      {
        return this._chLoadData_Pole4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chLoadData_Pole1_CheckedChanged);
        if (this._chLoadData_Pole4 != null)
          this._chLoadData_Pole4.CheckedChanged -= eventHandler;
        this._chLoadData_Pole4 = value;
        if (this._chLoadData_Pole4 == null)
          return;
        this._chLoadData_Pole4.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox boxLoadData_Pole3
    {
      get
      {
        return this._boxLoadData_Pole3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxLoadData_Pole3 = value;
      }
    }

    internal virtual ComboBox cmbLoadData_Pole3
    {
      get
      {
        return this._cmbLoadData_Pole3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbLoadData_Pole1_SelectedIndexChanged);
        if (this._cmbLoadData_Pole3 != null)
          this._cmbLoadData_Pole3.SelectedIndexChanged -= eventHandler;
        this._cmbLoadData_Pole3 = value;
        if (this._cmbLoadData_Pole3 == null)
          return;
        this._cmbLoadData_Pole3.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chLoadData_Pole3
    {
      get
      {
        return this._chLoadData_Pole3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chLoadData_Pole1_CheckedChanged);
        if (this._chLoadData_Pole3 != null)
          this._chLoadData_Pole3.CheckedChanged -= eventHandler;
        this._chLoadData_Pole3 = value;
        if (this._chLoadData_Pole3 == null)
          return;
        this._chLoadData_Pole3.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox boxLoadData_Pole2
    {
      get
      {
        return this._boxLoadData_Pole2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxLoadData_Pole2 = value;
      }
    }

    internal virtual ComboBox cmbLoadData_Pole2
    {
      get
      {
        return this._cmbLoadData_Pole2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmbLoadData_Pole1_SelectedIndexChanged);
        if (this._cmbLoadData_Pole2 != null)
          this._cmbLoadData_Pole2.SelectedIndexChanged -= eventHandler;
        this._cmbLoadData_Pole2 = value;
        if (this._cmbLoadData_Pole2 == null)
          return;
        this._cmbLoadData_Pole2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chLoadData_Pole2
    {
      get
      {
        return this._chLoadData_Pole2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chLoadData_Pole1_CheckedChanged);
        if (this._chLoadData_Pole2 != null)
          this._chLoadData_Pole2.CheckedChanged -= eventHandler;
        this._chLoadData_Pole2 = value;
        if (this._chLoadData_Pole2 == null)
          return;
        this._chLoadData_Pole2.CheckedChanged += eventHandler;
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

    private void chMethodEnableDisable()
    {
      int num1 = 0;
      if (this.chMethod_1.Checked)
        checked { ++num1; }
      if (this.chMethod_2.Checked)
        checked { ++num1; }
      if (this.chMethod_3.Checked)
        checked { ++num1; }
      if (this.chMethod_4.Checked)
        checked { ++num1; }
      _VARIABLES.MethodGenLogin = num1;
      if (num1 == 0)
        this.picWarning.Visible = true;
      else
        this.picWarning.Visible = false;
      if (num1 == 0)
      {
        this.lblChanse_1.Text = "0 %";
        this.lblChanse_2.Text = "0 %";
        this.lblChanse_3.Text = "0 %";
        this.lblChanse_4.Text = "0 %";
        this.lblChanse_1.ForeColor = Color.Red;
        this.lblChanse_2.ForeColor = Color.Red;
        this.lblChanse_3.ForeColor = Color.Red;
        this.lblChanse_4.ForeColor = Color.Red;
      }
      else
      {
        this.lblChanse_1.ForeColor = Color.Gray;
        this.lblChanse_2.ForeColor = Color.Gray;
        this.lblChanse_3.ForeColor = Color.Gray;
        this.lblChanse_4.ForeColor = Color.Gray;
        int num2 = checked ((int) Math.Round(unchecked (100.0 / (double) num1)));
        this.lblChanse_1.Text = !this.chMethod_1.Checked ? "0 %" : Conversions.ToString(num2) + " %";
        this.lblChanse_2.Text = !this.chMethod_2.Checked ? "0 %" : Conversions.ToString(num2) + " %";
        this.lblChanse_3.Text = !this.chMethod_3.Checked ? "0 %" : Conversions.ToString(num2) + " %";
        if (this.chMethod_4.Checked)
          this.lblChanse_4.Text = Conversions.ToString(num2) + " %";
        else
          this.lblChanse_4.Text = "0 %";
      }
    }

    private void txtLoadLogDIV_TextChanged(object sender, EventArgs e)
    {
      this.ViewExample_LoadData();
      _INI.SaveINI("Option_LoadUserLogin", "txtLoadLogDIV", this.txtLoadLogDIV.Text);
    }

    private void chRND_1_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "chRND_1", Conversions.ToString(this.chRND_1.Checked));
      if (this.chRND_1.Checked)
      {
        this.txtName.Enabled = false;
        this.txtLastName.Enabled = false;
        this.txtName.Text = "генерация из базы";
        this.txtLastName.Text = "генерация из базы";
      }
      else
      {
        this.txtName.Enabled = true;
        this.txtLastName.Enabled = true;
        this.txtName.Text = _INI.LoadINI("Option_UserDataGen", "txtName");
        this.txtLastName.Text = _INI.LoadINI("Option_UserDataGen", "txtLastName");
      }
    }

    private void txtName_TextChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtName.Text, "генерация из базы", false) == 0)
        return;
      _INI.SaveINI("Option_UserDataGen", "txtName", this.txtName.Text);
    }

    private void txtLastName_TextChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtLastName.Text, "генерация из базы", false) == 0)
        return;
      _INI.SaveINI("Option_UserDataGen", "txtLastName", this.txtLastName.Text);
    }

    private void chRND_2_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "chRND_2", Conversions.ToString(this.chRND_2.Checked));
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
      {
        this.cmbUserSex.Enabled = false;
        this.PictureBox1.Image = this.ImageList1.Images[2];
      }
      else
      {
        this.cmbUserSex.Enabled = true;
        this.PictureBox1.Image = this.ImageList1.Images[this.cmbUserSex.SelectedIndex];
      }
    }

    private void cmbUserSex_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "cmbUserSex", Conversions.ToString(this.cmbUserSex.SelectedIndex));
      this.PictureBox1.Image = this.ImageList1.Images[this.cmbUserSex.SelectedIndex];
    }

    private void chRND_3_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "chRND_3", Conversions.ToString(this.chRND_3.Checked));
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
      {
        this.cmbTown.Enabled = false;
        this.txtTown.Enabled = false;
      }
      else
      {
        this.cmbTown.Enabled = true;
        this.txtTown.Enabled = true;
      }
    }

    private void cmbTown_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "cmbTown", Conversions.ToString(this.cmbTown.SelectedIndex));
      this.txtTown.Text = this.cmbTown.Text;
    }

    private void txtTown_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "txtTown", this.txtTown.Text);
    }

    private void chRND_4_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "chRND_4", Conversions.ToString(this.chRND_4.Checked));
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
        this.cmbAccSel_Domain.Enabled = false;
      else
        this.cmbAccSel_Domain.Enabled = true;
    }

    private void cmbAccSel_Domain_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "cmbAccSel_Domain", Conversions.ToString(this.cmbAccSel_Domain.SelectedIndex));
    }

    private void chRND_5_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "chRND_5", Conversions.ToString(this.chRND_5.Checked));
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
        this.txtUserGenPass.Enabled = false;
      else
        this.txtUserGenPass.Enabled = true;
    }

    private void txtUserGenPass_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "txtUserGenPass", this.txtUserGenPass.Text);
    }

    private void chRND_6_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "chRND_6", Conversions.ToString(this.chRND_6.Checked));
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
      {
        this.cmbUserDayBD.Enabled = false;
        this.cmbUserMonthBD.Enabled = false;
        this.cmbUserYearBD.Enabled = false;
      }
      else
      {
        this.cmbUserDayBD.Enabled = true;
        this.cmbUserMonthBD.Enabled = true;
        this.cmbUserYearBD.Enabled = true;
      }
    }

    private void cmbUserDayBD_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "cmbUserDayBD", Conversions.ToString(this.cmbUserDayBD.SelectedIndex));
    }

    private void cmbUserMonthBD_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "cmbUserMonthBD", Conversions.ToString(this.cmbUserMonthBD.SelectedIndex));
    }

    private void cmbUserYearBD_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "cmbUserYearBD", Conversions.ToString(this.cmbUserYearBD.SelectedIndex));
    }

    private void chRND_7_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "chRND_7", Conversions.ToString(this.chRND_7.Checked));
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
        this.cmbUserQuest.Enabled = false;
      else
        this.cmbUserQuest.Enabled = true;
    }

    private void cmbUserQuest_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "cmbUserQuest", Conversions.ToString(this.cmbUserQuest.SelectedIndex));
    }

    private void chRND_8_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "chRND_8", Conversions.ToString(this.chRND_8.Checked));
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
        this.txtAnswer.Enabled = false;
      else
        this.txtAnswer.Enabled = true;
    }

    private void txtAnswer_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_UserDataGen", "txtAnswer", this.txtAnswer.Text);
    }

    private void chMethod_1_CheckedChanged(object sender, EventArgs e)
    {
      this.chMethodEnableDisable();
      _INI.SaveINI("Option_ParamGenLogin", Conversions.ToString(Operators.ConcatenateObject((object) "chMethod_", NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null))), Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "Checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      object Left = NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
      if (Operators.ConditionalCompareObjectEqual(Left, (object) "1", false) || Operators.ConditionalCompareObjectEqual(Left, (object) "2", false) || (Operators.ConditionalCompareObjectEqual(Left, (object) "3", false) || !Operators.ConditionalCompareObjectEqual(Left, (object) "4", false)))
        return;
      if (this.chMethod_4.Checked)
      {
        this.grOpWordGen.Enabled = true;
        this.cmbUseNumPercent.Enabled = true;
      }
      else
      {
        this.grOpWordGen.Enabled = false;
        this.cmbUseNumPercent.Enabled = false;
      }
    }

    private void txtGenMinLen_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "txtGenMinLen", this.txtGenMinLen.Text);
    }

    private void txtGenMaxLen_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "txtGenMaxLen", this.txtGenMaxLen.Text);
    }

    private void chDoubleGlas_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "chDoubleGlas", Conversions.ToString(this.chDoubleGlas.Checked));
      this.cmbDoubleGlas.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
    }

    private void chDoubleSOglas_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "chDoubleSOglas", Conversions.ToString(this.chDoubleSOglas.Checked));
      this.cmbDoubleSOglas.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
    }

    private void cmbDoubleGlas_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "cmbDoubleGlas", Conversions.ToString(this.cmbDoubleGlas.SelectedIndex));
    }

    private void cmbDoubleSOglas_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "cmbDoubleSOglas", Conversions.ToString(this.cmbDoubleSOglas.SelectedIndex));
    }

    private void cmbUseNum_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "cmbUseNum", Conversions.ToString(this.cmbUseNum.SelectedIndex));
      if (this.cmbUseNum.SelectedIndex == 0)
      {
        this.cmbUseNumPercent.Enabled = false;
      }
      else
      {
        if (!this.chMethod_4.Checked)
          return;
        this.cmbUseNumPercent.Enabled = true;
      }
    }

    private void cmbUseNumPercent_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "cmbUseNumPercent", Conversions.ToString(this.cmbUseNumPercent.SelectedIndex));
    }

    private void chDopMethod_1_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", Conversions.ToString(Operators.ConcatenateObject((object) "chDopMethod_", NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null))), Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "Checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
        checked { ++_VARIABLES.MethodGenLoginDop; }
      else
        checked { --_VARIABLES.MethodGenLoginDop; }
      object Left = NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null);
      if (Operators.ConditionalCompareObjectEqual(Left, (object) "1", false))
        this.cmbDopPercent_1.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      else if (Operators.ConditionalCompareObjectEqual(Left, (object) "2", false))
        this.cmbDopPercent_2.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      else if (Operators.ConditionalCompareObjectEqual(Left, (object) "3", false))
      {
        this.cmbDopPercent_3.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      }
      else
      {
        if (!Operators.ConditionalCompareObjectEqual(Left, (object) "4", false))
          return;
        this.cmbDopPercent_4.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      }
    }

    private void cmbDopPercent_1_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "cmbDopPercent_1", Conversions.ToString(this.cmbDopPercent_1.SelectedIndex));
    }

    private void cmbDopPercent_2_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "cmbDopPercent_2", Conversions.ToString(this.cmbDopPercent_2.SelectedIndex));
    }

    private void cmbDopPercent_3_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "cmbDopPercent_3", Conversions.ToString(this.cmbDopPercent_3.SelectedIndex));
    }

    private void cmbDopPercent_4_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_ParamGenLogin", "cmbDopPercent_4", Conversions.ToString(this.cmbDopPercent_4.SelectedIndex));
    }

    private void txtGenCount_TextChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("general", "CountGenLogin", this.txtGenCount.Text);
    }

    private void btmTestGen_Click(object sender, EventArgs e)
    {
      _FUNCTION.GenLogin(1, true, false, false, false, false);
    }

    internal void Button2_Click(object sender, EventArgs e)
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      this.pbGenLogin.Value = 0;
      MyProject.Forms.frmMain.pbGenLogin.Value = 0;
      _FUNCTION.GenLogin(checked ((int) Math.Round(Conversion.Val(this.txtGenCount.Text))), false, false, false, false, false);
      stopwatch.Stop();
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Скорость генерации [" + Conversions.ToString(Conversion.Val(this.txtGenCount.Text)) + " blanks]: " + Conversions.ToString(stopwatch.ElapsedMilliseconds) + " ms";
      fn.TXT(ref sText);
    }

    private void rbSelectMail_1_CheckedChanged(object sender, EventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) false, false))
        return;
      _INI.SaveINI("Option_Domain", "Domain", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      string Left = Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      if (Operators.CompareString(Left, "mail.ru", false) == 0)
        _VARIABLES.DomainSelect = 0;
      else if (Operators.CompareString(Left, "qip.ru", false) == 0)
      {
        _VARIABLES.DomainSelect = 1;
        if (Conversion.Val(_INI.LoadINI("qip.ru", "ub")) == 0.0)
          MyProject.Forms.frmMessafeQIP.Show();
      }
      else if (Operators.CompareString(Left, "meta.ua", false) == 0)
        _VARIABLES.DomainSelect = 2;
      else if (Operators.CompareString(Left, "yandex.ru", false) == 0)
      {
        this.rbSelectMail_2.Checked = true;
        _VARIABLES.DomainSelect = 3;
        int num = (int) Interaction.MsgBox((object) "Внимание! У вас выбрана генерация логинов на Yandex.ru.\r\nДанный сервис в данный момент находится на стадии тестирования.\r\nНе рекомендуется использовать как полноценную регистрацию аккаунтов.", MsgBoxStyle.Exclamation, (object) "Тестовая регистрация.");
      }
      else if (Operators.CompareString(Left, "km.ru", false) == 0)
      {
        this.rbSelectMail_3.Checked = true;
        _VARIABLES.DomainSelect = 4;
      }
      else
      {
        this.rbSelectMail_0.Checked = true;
        _VARIABLES.DomainSelect = 0;
      }
      this.cmbAccSel_Domain.Items.Clear();
      int num1 = 0;
      int domainCnt = _VARIABLES.MailService[_VARIABLES.DomainSelect].DomainCNT;
      int index = num1;
      while (index <= domainCnt)
      {
        this.cmbAccSel_Domain.Items.Add((object) _VARIABLES.MailService[_VARIABLES.DomainSelect].domain[index]);
        checked { ++index; }
      }
      int num2 = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_UserDataGen", "cmbAccSel_Domain"))));
      if (num2 > _VARIABLES.MailService[_VARIABLES.DomainSelect].DomainCNT)
        num2 = 0;
      this.cmbAccSel_Domain.SelectedIndex = num2;
    }

    private void сhYandexPause_CheckedChanged(object sender, EventArgs e)
    {
      if (this.сhYandexPause.Checked)
        return;
      int num = (int) Interaction.MsgBox((object) "Данную опцию невозможно отключить, т.к. на почтовом сервисе Yandex, если время начала регистрации и окончания, менее 51 секунды, то аккаунт регистрируется, но требует подтверждения через указание номера Вашего мобильного телефона.\r\nБез такого подтверждения нет допуска к работе с почтой.\r\nПотому, Mailbox@Reg будет выжидать рандомную паузу 51+ секунд, имитируя ручную регистрацию.", MsgBoxStyle.Exclamation, (object) "Капризный Yandex");
      this.сhYandexPause.Checked = true;
    }

    private void chHardCheck_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_GenLogin", "chHardCheck", Conversions.ToString(this.chHardCheck.Checked));
      if (!this.chHardCheck.Checked)
        _VARIABLES.OP.HardCheck = (short) 0;
      else
        _VARIABLES.OP.HardCheck = (short) 1;
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void chLoadData_Pole1_CheckedChanged(object sender, EventArgs e)
    {
      int integer = Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      bool boolean = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      switch (integer)
      {
        case 1:
          this.cmbLoadData_Pole1.Enabled = boolean;
          break;
        case 2:
          this.cmbLoadData_Pole2.Enabled = boolean;
          break;
        case 3:
          this.cmbLoadData_Pole3.Enabled = boolean;
          break;
        case 4:
          this.cmbLoadData_Pole4.Enabled = boolean;
          break;
        case 5:
          this.cmbLoadData_Pole5.Enabled = boolean;
          break;
        case 6:
          this.cmbLoadData_Pole6.Enabled = boolean;
          break;
        case 7:
          this.cmbLoadData_Pole7.Enabled = boolean;
          break;
        case 8:
          this.cmbLoadData_Pole8.Enabled = boolean;
          break;
      }
      this.ViewExample_LoadData();
      _INI.SaveINI("Option_LoadUserLogin", "chLoadData_Pole" + Conversions.ToString(integer), Conversions.ToString(boolean));
    }

    private void cmbLoadData_Pole1_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_LoadUserLogin", "cmbLoadData_Pole" + Conversions.ToString(Conversions.ToInteger(NewLateBinding.LateGet(sender, (Type) null, "tag", new object[0], (string[]) null, (Type[]) null, (bool[]) null))), Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "selectedindex", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      this.ViewExample_LoadData();
    }

    private void ViewExample_LoadData()
    {
      string[] strArray = new string[9]
      {
        "Login",
        "@domain",
        "Domain",
        "Password",
        "Answer",
        "Name",
        "Lastname",
        "Gender",
        "City"
      };
      string str = string.Empty;
      string text = this.txtLoadLogDIV.Text;
      if (this.chLoadData_Pole1.Checked)
        str = str + strArray[this.cmbLoadData_Pole1.SelectedIndex] + text;
      if (this.chLoadData_Pole2.Checked)
        str = str + strArray[this.cmbLoadData_Pole2.SelectedIndex] + text;
      if (this.chLoadData_Pole3.Checked)
        str = str + strArray[this.cmbLoadData_Pole3.SelectedIndex] + text;
      if (this.chLoadData_Pole4.Checked)
        str = str + strArray[this.cmbLoadData_Pole4.SelectedIndex] + text;
      if (this.chLoadData_Pole5.Checked)
        str = str + strArray[this.cmbLoadData_Pole5.SelectedIndex] + text;
      if (this.chLoadData_Pole6.Checked)
        str = str + strArray[this.cmbLoadData_Pole6.SelectedIndex] + text;
      if (this.chLoadData_Pole7.Checked)
        str = str + strArray[this.cmbLoadData_Pole7.SelectedIndex] + text;
      if (this.chLoadData_Pole8.Checked)
        str = str + strArray[this.cmbLoadData_Pole8.SelectedIndex] + text;
      if (str.Length == 0)
        this.lblLoadData_Example.Text = string.Empty;
      else if (text.Length == 0)
      {
        this.lblLoadData_Example.Text = str;
      }
      else
      {
        if (Operators.CompareString(Strings.Right(str, text.Length), text, false) == 0)
          str = Strings.Left(str, checked (str.Length - text.Length));
        this.lblLoadData_Example.Text = str.Replace(text + "@", "@");
      }
    }

    private void cmbLoadLogOtherData_SelectedIndexChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("Option_LoadUserLogin", "cmbLoadLogOtherData", Conversions.ToString(this.cmbLoadLogOtherData.SelectedIndex));
    }

    private void btnLoadData_Click(object sender, EventArgs e)
    {
      try
      {
        this.pbGenLogin.Value = 0;
        MyProject.Forms.frmMain.pbGenLogin.Value = 0;
        int[] numArray1 = new int[9];
        int index1 = 0;
        if (this.chLoadData_Pole1.Checked)
        {
          checked { ++index1; }
          numArray1[index1] = this.cmbLoadData_Pole1.SelectedIndex;
        }
        if (this.chLoadData_Pole2.Checked)
        {
          checked { ++index1; }
          numArray1[index1] = this.cmbLoadData_Pole2.SelectedIndex;
        }
        if (this.chLoadData_Pole3.Checked)
        {
          checked { ++index1; }
          numArray1[index1] = this.cmbLoadData_Pole3.SelectedIndex;
        }
        if (this.chLoadData_Pole4.Checked)
        {
          checked { ++index1; }
          numArray1[index1] = this.cmbLoadData_Pole4.SelectedIndex;
        }
        if (this.chLoadData_Pole5.Checked)
        {
          checked { ++index1; }
          numArray1[index1] = this.cmbLoadData_Pole5.SelectedIndex;
        }
        if (this.chLoadData_Pole6.Checked)
        {
          checked { ++index1; }
          numArray1[index1] = this.cmbLoadData_Pole6.SelectedIndex;
        }
        if (this.chLoadData_Pole7.Checked)
        {
          checked { ++index1; }
          numArray1[index1] = this.cmbLoadData_Pole7.SelectedIndex;
        }
        if (this.chLoadData_Pole8.Checked)
        {
          checked { ++index1; }
          numArray1[index1] = this.cmbLoadData_Pole8.SelectedIndex;
        }
        int[] numArray2 = (int[]) Utils.CopyArray((Array) numArray1, (Array) new int[checked (index1 + 1)]);
        int num1 = checked (index1 - 1);
        if (num1 == -1)
        {
          int num2 = (int) Interaction.MsgBox((object) "Не выбраны данные для загрузки!\r\nХотя бы один параметр для загрузки должен быть активным.", MsgBoxStyle.Exclamation, (object) "Ошибка загрузки");
        }
        else
        {
          this.OpenFileDialog1.FileName = "";
          this.OpenFileDialog1.InitialDirectory = _INI.LoadINI("Option_LoadUserLogin", "OpenFileDialog");
          int num3 = (int) this.OpenFileDialog1.ShowDialog();
          string fileName = this.OpenFileDialog1.FileName;
          _INI.SaveINI("Option_LoadUserLogin", "OpenFileDialog", fileName);
          if (Strings.Len(fileName) == 0)
          {
            int num4 = (int) Interaction.MsgBox((object) "Не выбран файл для загрузки.", MsgBoxStyle.Exclamation, (object) "Ошибка загрузки");
          }
          else if (Strings.Len(this.txtLoadLogDIV.Text) == 0)
          {
            int num5 = (int) Interaction.MsgBox((object) "У вас не задан делиметр.", MsgBoxStyle.Exclamation, (object) "Ошибка загрузки");
          }
          else
          {
            if (!File.Exists(fileName))
              return;
            string Expression = _LOADSAVE.FileLoad(ref fileName);
            if (Strings.Len(Expression) == 0)
            {
              int num6 = (int) Interaction.MsgBox((object) "Пустой файл.", MsgBoxStyle.Exclamation, (object) "Ошибка загрузки");
            }
            else
            {
              string str = Expression.Replace("\r", string.Empty);
              string text = this.txtLoadLogDIV.Text;
              if (text.Length != 1)
              {
                int num7 = (int) Interaction.MsgBox((object) "Неправильно задан резделитель данных!\r\nДлина должна быть 1 символ.", MsgBoxStyle.Exclamation, (object) "Ошибка загрузки");
              }
              else
              {
                string[] strArray1 = str.Replace("@", text).Split('\n');
                if (string.IsNullOrEmpty(strArray1[Information.UBound((Array) strArray1, 1)]))
                  strArray1 = (string[]) Utils.CopyArray((Array) strArray1, (Array) new string[checked (Information.UBound((Array) strArray1, 1) - 1 + 1)]);
                int sGenCount = checked (Information.UBound((Array) strArray1, 1) + 1);
                _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
                string sText1 = "[Загрузка данных] найдено строк: " + Conversions.ToString(sGenCount);
                fn1.TXT(ref sText1);
                int num8 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
                if (this.cmbLoadLogOtherData.SelectedIndex == 0)
                  _FUNCTION.GenLogin(sGenCount, false, true, false, false, false);
                else
                  _VARIABLES.MailInfo = (_VARIABLES.meMailInfo[]) Utils.CopyArray((Array) _VARIABLES.MailInfo, (Array) new _VARIABLES.meMailInfo[checked (num8 + sGenCount + 1)]);
                this.pbGenLogin.Value = 0;
                this.pbGenLogin.Maximum = sGenCount;
                int num9 = sGenCount / 100;
                if (num9 == 0)
                  num9 = 1;
                int num10 = 0;
                int num11 = 0;
                int num12 = 0;
                int num13 = 0;
                int num14 = Information.UBound((Array) strArray1, 1);
                int index2 = num13;
                while (index2 <= num14)
                {
                  if (index2 % num9 == 0)
                  {
                    this.pbGenLogin.Value = index2;
                    Application.DoEvents();
                  }
                  if (strArray1[index2].Length == 0)
                  {
                    checked { ++num10; }
                  }
                  else
                  {
                    string[] strArray2 = strArray1[index2].Split(Conversions.ToChar(text));
                    if (num1 > Information.UBound((Array) strArray2, 1))
                    {
                      checked { ++num11; }
                    }
                    else
                    {
                      string[] strArray3 = new string[9];
                      int num15 = 0;
                      int num16 = num1;
                      int index3 = num15;
                      while (index3 <= num16)
                      {
                        strArray3[numArray2[checked (index3 + 1)]] = strArray2[index3];
                        checked { ++index3; }
                      }
                      checked { ++num12; }
                      if (!Information.IsNothing((object) strArray3[0]))
                        _VARIABLES.MailInfo[checked (num8 + num12)].login = strArray3[0];
                      if (!Information.IsNothing((object) strArray3[1]))
                      {
                        _VARIABLES.MailInfo[checked (num8 + num12)].domain = strArray3[1].ToLower();
                        string domain = _VARIABLES.MailInfo[checked (num8 + num12)].domain;
                        _VARIABLES.MailInfo[checked (num8 + num12)].DomainID = Operators.CompareString(domain, "mail.ru", false) == 0 || Operators.CompareString(domain, "inbox.ru", false) == 0 || (Operators.CompareString(domain, "bk.ru", false) == 0 || Operators.CompareString(domain, "list.ru", false) == 0) || Operators.CompareString(domain, "mail.ua", false) == 0 ? (short) 0 : (Operators.CompareString(domain, "qip.ru", false) == 0 || Operators.CompareString(domain, "pochta.ru", false) == 0 || (Operators.CompareString(domain, "fromru.com", false) == 0 || Operators.CompareString(domain, "front.ru", false) == 0) || (Operators.CompareString(domain, "hotbox.ru", false) == 0 || Operators.CompareString(domain, "hotmail.ru", false) == 0 || (Operators.CompareString(domain, "krovatka.su", false) == 0 || Operators.CompareString(domain, "land.ru", false) == 0)) || (Operators.CompareString(domain, "mail15.com", false) == 0 || Operators.CompareString(domain, "mail333.com", false) == 0 || (Operators.CompareString(domain, "newmail.ru", false) == 0 || Operators.CompareString(domain, "nightmail.ru", false) == 0) || (Operators.CompareString(domain, "nm.ru", false) == 0 || Operators.CompareString(domain, "pisem.net", false) == 0 || (Operators.CompareString(domain, "pochtamt.ru", false) == 0 || Operators.CompareString(domain, "pop3.ru", false) == 0))) || (Operators.CompareString(domain, "rbcmail.ru", false) == 0 || Operators.CompareString(domain, "smtp.ru", false) == 0 || (Operators.CompareString(domain, "5ballov.ru", false) == 0 || Operators.CompareString(domain, "aeterna.ru", false) == 0) || (Operators.CompareString(domain, "ziza.ru", false) == 0 || Operators.CompareString(domain, "memori.ru", false) == 0 || (Operators.CompareString(domain, "photofile.ru", false) == 0 || Operators.CompareString(domain, "fotoplenka.ru", false) == 0)) || Operators.CompareString(domain, "pochta.com", false) == 0) ? (short) 1 : (Operators.CompareString(domain, "meta.ua", false) != 0 ? (short) 100 : (short) 2));
                      }
                      if (!Information.IsNothing((object) strArray3[2]))
                      {
                        _VARIABLES.MailInfo[checked (num8 + num12)].domain = strArray3[2].ToLower();
                        string domain = _VARIABLES.MailInfo[checked (num8 + num12)].domain;
                        _VARIABLES.MailInfo[checked (num8 + num12)].DomainID = Operators.CompareString(domain, "mail.ru", false) == 0 || Operators.CompareString(domain, "inbox.ru", false) == 0 || (Operators.CompareString(domain, "bk.ru", false) == 0 || Operators.CompareString(domain, "list.ru", false) == 0) || Operators.CompareString(domain, "mail.ua", false) == 0 ? (short) 0 : (Operators.CompareString(domain, "qip.ru", false) == 0 || Operators.CompareString(domain, "pochta.ru", false) == 0 || (Operators.CompareString(domain, "fromru.com", false) == 0 || Operators.CompareString(domain, "front.ru", false) == 0) || (Operators.CompareString(domain, "hotbox.ru", false) == 0 || Operators.CompareString(domain, "hotmail.ru", false) == 0 || (Operators.CompareString(domain, "krovatka.su", false) == 0 || Operators.CompareString(domain, "land.ru", false) == 0)) || (Operators.CompareString(domain, "mail15.com", false) == 0 || Operators.CompareString(domain, "mail333.com", false) == 0 || (Operators.CompareString(domain, "newmail.ru", false) == 0 || Operators.CompareString(domain, "nightmail.ru", false) == 0) || (Operators.CompareString(domain, "nm.ru", false) == 0 || Operators.CompareString(domain, "pisem.net", false) == 0 || (Operators.CompareString(domain, "pochtamt.ru", false) == 0 || Operators.CompareString(domain, "pop3.ru", false) == 0))) || (Operators.CompareString(domain, "rbcmail.ru", false) == 0 || Operators.CompareString(domain, "smtp.ru", false) == 0 || (Operators.CompareString(domain, "5ballov.ru", false) == 0 || Operators.CompareString(domain, "aeterna.ru", false) == 0) || (Operators.CompareString(domain, "ziza.ru", false) == 0 || Operators.CompareString(domain, "memori.ru", false) == 0 || (Operators.CompareString(domain, "photofile.ru", false) == 0 || Operators.CompareString(domain, "fotoplenka.ru", false) == 0)) || Operators.CompareString(domain, "pochta.com", false) == 0) ? (short) 1 : (Operators.CompareString(domain, "meta.ua", false) != 0 ? (short) 100 : (short) 2));
                      }
                      if (!Information.IsNothing((object) strArray3[3]))
                        _VARIABLES.MailInfo[checked (num8 + num12)].password = strArray3[3];
                      if (!Information.IsNothing((object) strArray3[4]))
                        _VARIABLES.MailInfo[checked (num8 + num12)].RegUserData.SecretAnswer = strArray3[4];
                      if (!Information.IsNothing((object) strArray3[5]))
                        _VARIABLES.MailInfo[checked (num8 + num12)].RegUserData.Name = strArray3[5];
                      if (!Information.IsNothing((object) strArray3[6]))
                        _VARIABLES.MailInfo[checked (num8 + num12)].RegUserData.LastName = strArray3[6];
                      if (!Information.IsNothing((object) strArray3[7]))
                        _VARIABLES.MailInfo[index2].RegUserData.Sex = Operators.CompareString(strArray3[7].ToLower(), "m", false) == 0 || Operators.CompareString(strArray3[7].ToLower(), "м", false) == 0 ? (short) 1 : (short) 2;
                      if (!Information.IsNothing((object) strArray3[8]))
                        _VARIABLES.MailInfo[checked (num8 + num12)].RegUserData.City = strArray3[8];
                    }
                  }
                  checked { ++index2; }
                }
                if (Information.UBound((Array) _VARIABLES.MailInfo, 1) != checked (num12 + num8))
                  _VARIABLES.MailInfo = (_VARIABLES.meMailInfo[]) Utils.CopyArray((Array) _VARIABLES.MailInfo, (Array) new _VARIABLES.meMailInfo[checked (num12 + num8 + 1)]);
                _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
                string sText2 = "[Загрузка данных] Пустых строк: " + Conversions.ToString(num10);
                fn2.TXT(ref sText2);
                _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
                string sText3 = "[Загрузка данных] Не соответсвуют формату: " + Conversions.ToString(num11);
                fn3.TXT(ref sText3);
                _FUNCTION.clsTXT fn4 = _FUNCTION.FN;
                string sText4 = "[Загрузка данных] Добавлено: " + Conversions.ToString(num12);
                fn4.TXT(ref sText4);
                this.pbGenLogin.Value = this.pbGenLogin.Maximum;
                _LV.LV_ADD_ALL();
                _LOADSAVE.SaveALL_MailInfo();
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        string sText1 = "Ex: " + exception.Message;
        fn1.TXT(ref sText1);
        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
        string sText2 = "Ошибка загрузки пользовательского списка.";
        fn2.TXT(ref sText2);
        ProjectData.ClearProjectError();
      }
    }
  }
}
