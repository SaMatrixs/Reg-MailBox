// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.frmSQL
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [DesignerGenerated]
  public class frmSQL : Form
  {
    private IContainer components;
    [AccessedThroughProperty("picStatus_DataBase")]
    private PictureBox _picStatus_DataBase;
    [AccessedThroughProperty("txtDB_Password")]
    private TextBox _txtDB_Password;
    [AccessedThroughProperty("txtDB_User")]
    private TextBox _txtDB_User;
    [AccessedThroughProperty("txtDB_Name")]
    private TextBox _txtDB_Name;
    [AccessedThroughProperty("PictureBox6")]
    private PictureBox _PictureBox6;
    [AccessedThroughProperty("PictureBox5")]
    private PictureBox _PictureBox5;
    [AccessedThroughProperty("PictureBox4")]
    private PictureBox _PictureBox4;
    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;
    [AccessedThroughProperty("txtDB_Host")]
    private TextBox _txtDB_Host;
    [AccessedThroughProperty("boxTab1")]
    private GroupBox _boxTab1;
    [AccessedThroughProperty("txtTableStorage")]
    private TextBox _txtTableStorage;
    [AccessedThroughProperty("boxTab2")]
    private GroupBox _boxTab2;
    [AccessedThroughProperty("txtTableBackup")]
    private TextBox _txtTableBackup;
    [AccessedThroughProperty("btnCreateTable")]
    private Button _btnCreateTable;
    [AccessedThroughProperty("btnUpload")]
    private Button _btnUpload;
    [AccessedThroughProperty("btnAmount")]
    private Button _btnAmount;
    [AccessedThroughProperty("chUpload")]
    private CheckBox _chUpload;
    [AccessedThroughProperty("chCreateTable")]
    private CheckBox _chCreateTable;
    [AccessedThroughProperty("boxMailRU")]
    private GroupBox _boxMailRU;
    [AccessedThroughProperty("lblMailRU_Count")]
    private Label _lblMailRU_Count;
    [AccessedThroughProperty("txtMailRU")]
    private TextBox _txtMailRU;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("lblInboxRU_Count")]
    private Label _lblInboxRU_Count;
    [AccessedThroughProperty("txtInboxRU")]
    private TextBox _txtInboxRU;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("lblListRU_Count")]
    private Label _lblListRU_Count;
    [AccessedThroughProperty("txtListRU")]
    private TextBox _txtListRU;
    [AccessedThroughProperty("GroupBox3")]
    private GroupBox _GroupBox3;
    [AccessedThroughProperty("lblBkRU_Count")]
    private Label _lblBkRU_Count;
    [AccessedThroughProperty("txtBkRU")]
    private TextBox _txtBkRU;
    [AccessedThroughProperty("boxItogo")]
    private GroupBox _boxItogo;
    [AccessedThroughProperty("lblItogo")]
    private Label _lblItogo;
    [AccessedThroughProperty("txtItogo")]
    private TextBox _txtItogo;
    [AccessedThroughProperty("btnDownload")]
    private Button _btnDownload;
    [AccessedThroughProperty("chAddMail")]
    private CheckBox _chAddMail;
    [AccessedThroughProperty("chAutoSave")]
    private CheckBox _chAutoSave;
    [AccessedThroughProperty("PB")]
    private ProgressBar _PB;
    [AccessedThroughProperty("boxSale")]
    private GroupBox _boxSale;
    [AccessedThroughProperty("lblSale")]
    private Label _lblSale;
    [AccessedThroughProperty("btnArj")]
    private Button _btnArj;
    [AccessedThroughProperty("chIgnoreSaleID")]
    private CheckBox _chIgnoreSaleID;
    [AccessedThroughProperty("btnLoadAndDel")]
    private Button _btnLoadAndDel;

    public frmSQL()
    {
      this.Load += new EventHandler(this.frmSQL_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSQL));
      this.picStatus_DataBase = new PictureBox();
      this.txtDB_Password = new TextBox();
      this.txtDB_User = new TextBox();
      this.txtDB_Name = new TextBox();
      this.PictureBox6 = new PictureBox();
      this.PictureBox5 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      this.PictureBox3 = new PictureBox();
      this.txtDB_Host = new TextBox();
      this.boxTab1 = new GroupBox();
      this.txtTableStorage = new TextBox();
      this.boxTab2 = new GroupBox();
      this.txtTableBackup = new TextBox();
      this.btnCreateTable = new Button();
      this.btnUpload = new Button();
      this.btnAmount = new Button();
      this.chUpload = new CheckBox();
      this.chCreateTable = new CheckBox();
      this.boxMailRU = new GroupBox();
      this.lblMailRU_Count = new Label();
      this.txtMailRU = new TextBox();
      this.GroupBox1 = new GroupBox();
      this.lblInboxRU_Count = new Label();
      this.txtInboxRU = new TextBox();
      this.GroupBox2 = new GroupBox();
      this.lblListRU_Count = new Label();
      this.txtListRU = new TextBox();
      this.GroupBox3 = new GroupBox();
      this.lblBkRU_Count = new Label();
      this.txtBkRU = new TextBox();
      this.boxItogo = new GroupBox();
      this.lblItogo = new Label();
      this.txtItogo = new TextBox();
      this.btnDownload = new Button();
      this.chAddMail = new CheckBox();
      this.chAutoSave = new CheckBox();
      this.PB = new ProgressBar();
      this.boxSale = new GroupBox();
      this.lblSale = new Label();
      this.btnArj = new Button();
      this.chIgnoreSaleID = new CheckBox();
      this.btnLoadAndDel = new Button();
      ((ISupportInitialize) this.picStatus_DataBase).BeginInit();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      ((ISupportInitialize) this.PictureBox3).BeginInit();
      this.boxTab1.SuspendLayout();
      this.boxTab2.SuspendLayout();
      this.boxMailRU.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.boxItogo.SuspendLayout();
      this.boxSale.SuspendLayout();
      this.SuspendLayout();
      this.picStatus_DataBase.Image = (Image) componentResourceManager.GetObject("picStatus_DataBase.Image");
      PictureBox picStatusDataBase1 = this.picStatus_DataBase;
      Point point1 = new Point(204, 11);
      Point point2 = point1;
      picStatusDataBase1.Location = point2;
      this.picStatus_DataBase.Name = "picStatus_DataBase";
      PictureBox picStatusDataBase2 = this.picStatus_DataBase;
      Size size1 = new Size(48, 48);
      Size size2 = size1;
      picStatusDataBase2.Size = size2;
      this.picStatus_DataBase.SizeMode = PictureBoxSizeMode.AutoSize;
      this.picStatus_DataBase.TabIndex = 153;
      this.picStatus_DataBase.TabStop = false;
      this.txtDB_Password.BackColor = Color.FromArgb((int) byte.MaxValue, 208, 208);
      this.txtDB_Password.BorderStyle = BorderStyle.FixedSingle;
      this.txtDB_Password.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtDB_Password.ForeColor = Color.Black;
      TextBox txtDbPassword1 = this.txtDB_Password;
      point1 = new Point(33, 102);
      Point point3 = point1;
      txtDbPassword1.Location = point3;
      this.txtDB_Password.MaxLength = 32;
      this.txtDB_Password.Name = "txtDB_Password";
      this.txtDB_Password.PasswordChar = '*';
      TextBox txtDbPassword2 = this.txtDB_Password;
      size1 = new Size(165, 21);
      Size size3 = size1;
      txtDbPassword2.Size = size3;
      this.txtDB_Password.TabIndex = 150;
      this.txtDB_Password.TabStop = false;
      this.txtDB_Password.TextAlign = HorizontalAlignment.Center;
      this.txtDB_User.BackColor = Color.FromArgb((int) byte.MaxValue, 208, 208);
      this.txtDB_User.BorderStyle = BorderStyle.FixedSingle;
      this.txtDB_User.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtDB_User.ForeColor = Color.Black;
      TextBox txtDbUser1 = this.txtDB_User;
      point1 = new Point(33, 72);
      Point point4 = point1;
      txtDbUser1.Location = point4;
      this.txtDB_User.MaxLength = 32;
      this.txtDB_User.Name = "txtDB_User";
      TextBox txtDbUser2 = this.txtDB_User;
      size1 = new Size(165, 22);
      Size size4 = size1;
      txtDbUser2.Size = size4;
      this.txtDB_User.TabIndex = 149;
      this.txtDB_User.TabStop = false;
      this.txtDB_User.TextAlign = HorizontalAlignment.Center;
      this.txtDB_Name.BackColor = Color.FromArgb((int) byte.MaxValue, 208, 208);
      this.txtDB_Name.BorderStyle = BorderStyle.FixedSingle;
      this.txtDB_Name.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtDB_Name.ForeColor = Color.Black;
      TextBox txtDbName1 = this.txtDB_Name;
      point1 = new Point(33, 42);
      Point point5 = point1;
      txtDbName1.Location = point5;
      this.txtDB_Name.MaxLength = 32;
      this.txtDB_Name.Name = "txtDB_Name";
      TextBox txtDbName2 = this.txtDB_Name;
      size1 = new Size(165, 22);
      Size size5 = size1;
      txtDbName2.Size = size5;
      this.txtDB_Name.TabIndex = 148;
      this.txtDB_Name.TabStop = false;
      this.txtDB_Name.TextAlign = HorizontalAlignment.Center;
      this.PictureBox6.Image = (Image) componentResourceManager.GetObject("PictureBox6.Image");
      PictureBox pictureBox6_1 = this.PictureBox6;
      point1 = new Point(5, 101);
      Point point6 = point1;
      pictureBox6_1.Location = point6;
      this.PictureBox6.Name = "PictureBox6";
      PictureBox pictureBox6_2 = this.PictureBox6;
      size1 = new Size(24, 24);
      Size size6 = size1;
      pictureBox6_2.Size = size6;
      this.PictureBox6.TabIndex = 147;
      this.PictureBox6.TabStop = false;
      this.PictureBox5.Image = (Image) componentResourceManager.GetObject("PictureBox5.Image");
      PictureBox pictureBox5_1 = this.PictureBox5;
      point1 = new Point(5, 71);
      Point point7 = point1;
      pictureBox5_1.Location = point7;
      this.PictureBox5.Name = "PictureBox5";
      PictureBox pictureBox5_2 = this.PictureBox5;
      size1 = new Size(24, 24);
      Size size7 = size1;
      pictureBox5_2.Size = size7;
      this.PictureBox5.TabIndex = 146;
      this.PictureBox5.TabStop = false;
      this.PictureBox4.Image = (Image) componentResourceManager.GetObject("PictureBox4.Image");
      PictureBox pictureBox4_1 = this.PictureBox4;
      point1 = new Point(5, 41);
      Point point8 = point1;
      pictureBox4_1.Location = point8;
      this.PictureBox4.Name = "PictureBox4";
      PictureBox pictureBox4_2 = this.PictureBox4;
      size1 = new Size(24, 24);
      Size size8 = size1;
      pictureBox4_2.Size = size8;
      this.PictureBox4.TabIndex = 145;
      this.PictureBox4.TabStop = false;
      this.PictureBox3.Image = (Image) componentResourceManager.GetObject("PictureBox3.Image");
      PictureBox pictureBox3_1 = this.PictureBox3;
      point1 = new Point(5, 11);
      Point point9 = point1;
      pictureBox3_1.Location = point9;
      this.PictureBox3.Name = "PictureBox3";
      PictureBox pictureBox3_2 = this.PictureBox3;
      size1 = new Size(24, 24);
      Size size9 = size1;
      pictureBox3_2.Size = size9;
      this.PictureBox3.TabIndex = 144;
      this.PictureBox3.TabStop = false;
      this.txtDB_Host.BackColor = Color.FromArgb((int) byte.MaxValue, 208, 208);
      this.txtDB_Host.BorderStyle = BorderStyle.FixedSingle;
      this.txtDB_Host.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtDB_Host.ForeColor = Color.Black;
      TextBox txtDbHost1 = this.txtDB_Host;
      point1 = new Point(33, 12);
      Point point10 = point1;
      txtDbHost1.Location = point10;
      this.txtDB_Host.MaxLength = 32;
      this.txtDB_Host.Name = "txtDB_Host";
      TextBox txtDbHost2 = this.txtDB_Host;
      size1 = new Size(165, 22);
      Size size10 = size1;
      txtDbHost2.Size = size10;
      this.txtDB_Host.TabIndex = 143;
      this.txtDB_Host.TabStop = false;
      this.txtDB_Host.TextAlign = HorizontalAlignment.Center;
      this.boxTab1.Controls.Add((Control) this.txtTableStorage);
      this.boxTab1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox boxTab1_1 = this.boxTab1;
      point1 = new Point(5, 131);
      Point point11 = point1;
      boxTab1_1.Location = point11;
      this.boxTab1.Name = "boxTab1";
      GroupBox boxTab1_2 = this.boxTab1;
      size1 = new Size(193, 38);
      Size size11 = size1;
      boxTab1_2.Size = size11;
      this.boxTab1.TabIndex = 154;
      this.boxTab1.TabStop = false;
      this.boxTab1.Text = "Table Storage";
      this.txtTableStorage.BackColor = Color.FromArgb((int) byte.MaxValue, 208, 208);
      this.txtTableStorage.BorderStyle = BorderStyle.None;
      this.txtTableStorage.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtTableStorage.ForeColor = Color.Black;
      TextBox txtTableStorage1 = this.txtTableStorage;
      point1 = new Point(7, 17);
      Point point12 = point1;
      txtTableStorage1.Location = point12;
      this.txtTableStorage.MaxLength = 32;
      this.txtTableStorage.Name = "txtTableStorage";
      TextBox txtTableStorage2 = this.txtTableStorage;
      size1 = new Size(180, 14);
      Size size12 = size1;
      txtTableStorage2.Size = size12;
      this.txtTableStorage.TabIndex = 156;
      this.txtTableStorage.TabStop = false;
      this.txtTableStorage.TextAlign = HorizontalAlignment.Center;
      this.boxTab2.Controls.Add((Control) this.txtTableBackup);
      this.boxTab2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox boxTab2_1 = this.boxTab2;
      point1 = new Point(5, 175);
      Point point13 = point1;
      boxTab2_1.Location = point13;
      this.boxTab2.Name = "boxTab2";
      GroupBox boxTab2_2 = this.boxTab2;
      size1 = new Size(193, 38);
      Size size13 = size1;
      boxTab2_2.Size = size13;
      this.boxTab2.TabIndex = 155;
      this.boxTab2.TabStop = false;
      this.boxTab2.Text = "Table Backup";
      this.txtTableBackup.BackColor = Color.FromArgb((int) byte.MaxValue, 208, 208);
      this.txtTableBackup.BorderStyle = BorderStyle.None;
      this.txtTableBackup.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtTableBackup.ForeColor = Color.Black;
      TextBox txtTableBackup1 = this.txtTableBackup;
      point1 = new Point(6, 18);
      Point point14 = point1;
      txtTableBackup1.Location = point14;
      this.txtTableBackup.MaxLength = 32;
      this.txtTableBackup.Name = "txtTableBackup";
      TextBox txtTableBackup2 = this.txtTableBackup;
      size1 = new Size(180, 14);
      Size size14 = size1;
      txtTableBackup2.Size = size14;
      this.txtTableBackup.TabIndex = 157;
      this.txtTableBackup.TabStop = false;
      this.txtTableBackup.TextAlign = HorizontalAlignment.Center;
      this.btnCreateTable.BackColor = Color.FromArgb(156, 175, 137);
      this.btnCreateTable.Enabled = false;
      this.btnCreateTable.FlatStyle = FlatStyle.Flat;
      this.btnCreateTable.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnCreateTable.ForeColor = Color.Black;
      this.btnCreateTable.Image = (Image) componentResourceManager.GetObject("btnCreateTable.Image");
      this.btnCreateTable.ImageAlign = ContentAlignment.MiddleLeft;
      Button btnCreateTable1 = this.btnCreateTable;
      point1 = new Point(258, 11);
      Point point15 = point1;
      btnCreateTable1.Location = point15;
      this.btnCreateTable.Name = "btnCreateTable";
      Button btnCreateTable2 = this.btnCreateTable;
      size1 = new Size(106, 48);
      Size size15 = size1;
      btnCreateTable2.Size = size15;
      this.btnCreateTable.TabIndex = 156;
      this.btnCreateTable.TabStop = false;
      this.btnCreateTable.Text = "Create \r\nTable ";
      this.btnCreateTable.TextAlign = ContentAlignment.MiddleRight;
      this.btnCreateTable.UseVisualStyleBackColor = false;
      this.btnUpload.BackColor = Color.FromArgb(156, 175, 137);
      this.btnUpload.Enabled = false;
      this.btnUpload.FlatStyle = FlatStyle.Flat;
      this.btnUpload.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnUpload.ForeColor = Color.Black;
      this.btnUpload.Image = (Image) componentResourceManager.GetObject("btnUpload.Image");
      this.btnUpload.ImageAlign = ContentAlignment.MiddleLeft;
      Button btnUpload1 = this.btnUpload;
      point1 = new Point(370, 11);
      Point point16 = point1;
      btnUpload1.Location = point16;
      this.btnUpload.Name = "btnUpload";
      Button btnUpload2 = this.btnUpload;
      size1 = new Size(106, 48);
      Size size16 = size1;
      btnUpload2.Size = size16;
      this.btnUpload.TabIndex = 157;
      this.btnUpload.TabStop = false;
      this.btnUpload.Text = "Upload ";
      this.btnUpload.TextAlign = ContentAlignment.MiddleRight;
      this.btnUpload.UseVisualStyleBackColor = false;
      this.btnAmount.BackColor = Color.FromArgb(156, 175, 137);
      this.btnAmount.Enabled = false;
      this.btnAmount.FlatStyle = FlatStyle.Flat;
      this.btnAmount.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnAmount.ForeColor = Color.Black;
      this.btnAmount.Image = (Image) componentResourceManager.GetObject("btnAmount.Image");
      this.btnAmount.ImageAlign = ContentAlignment.MiddleLeft;
      Button btnAmount1 = this.btnAmount;
      point1 = new Point(370, 210);
      Point point17 = point1;
      btnAmount1.Location = point17;
      this.btnAmount.Name = "btnAmount";
      Button btnAmount2 = this.btnAmount;
      size1 = new Size(106, 44);
      Size size17 = size1;
      btnAmount2.Size = size17;
      this.btnAmount.TabIndex = 158;
      this.btnAmount.TabStop = false;
      this.btnAmount.Text = "Amount";
      this.btnAmount.TextAlign = ContentAlignment.MiddleRight;
      this.btnAmount.UseVisualStyleBackColor = false;
      this.chUpload.FlatStyle = FlatStyle.Flat;
      CheckBox chUpload1 = this.chUpload;
      point1 = new Point(463, 13);
      Point point18 = point1;
      chUpload1.Location = point18;
      this.chUpload.Name = "chUpload";
      CheckBox chUpload2 = this.chUpload;
      size1 = new Size(11, 11);
      Size size18 = size1;
      chUpload2.Size = size18;
      this.chUpload.TabIndex = 159;
      this.chUpload.UseVisualStyleBackColor = true;
      this.chCreateTable.FlatStyle = FlatStyle.Flat;
      CheckBox chCreateTable1 = this.chCreateTable;
      point1 = new Point(351, 13);
      Point point19 = point1;
      chCreateTable1.Location = point19;
      this.chCreateTable.Name = "chCreateTable";
      CheckBox chCreateTable2 = this.chCreateTable;
      size1 = new Size(11, 11);
      Size size19 = size1;
      chCreateTable2.Size = size19;
      this.chCreateTable.TabIndex = 160;
      this.chCreateTable.UseVisualStyleBackColor = true;
      this.boxMailRU.Controls.Add((Control) this.lblMailRU_Count);
      this.boxMailRU.Controls.Add((Control) this.txtMailRU);
      this.boxMailRU.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.boxMailRU.ForeColor = Color.Green;
      GroupBox boxMailRu1 = this.boxMailRU;
      point1 = new Point(206, 72);
      Point point20 = point1;
      boxMailRu1.Location = point20;
      this.boxMailRU.Name = "boxMailRU";
      GroupBox boxMailRu2 = this.boxMailRU;
      size1 = new Size(158, 45);
      Size size20 = size1;
      boxMailRu2.Size = size20;
      this.boxMailRU.TabIndex = 161;
      this.boxMailRU.TabStop = false;
      this.boxMailRU.Text = "@mail.ru";
      this.lblMailRU_Count.ForeColor = Color.Black;
      Label lblMailRuCount1 = this.lblMailRU_Count;
      point1 = new Point(6, 17);
      Point point21 = point1;
      lblMailRuCount1.Location = point21;
      this.lblMailRU_Count.Name = "lblMailRU_Count";
      Label lblMailRuCount2 = this.lblMailRU_Count;
      size1 = new Size(70, 20);
      Size size21 = size1;
      lblMailRuCount2.Size = size21;
      this.lblMailRU_Count.TabIndex = 162;
      this.lblMailRU_Count.Text = "???";
      this.lblMailRU_Count.TextAlign = ContentAlignment.MiddleCenter;
      this.txtMailRU.BackColor = Color.FromArgb(181, 195, 168);
      this.txtMailRU.BorderStyle = BorderStyle.FixedSingle;
      this.txtMailRU.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtMailRU.ForeColor = Color.Black;
      TextBox txtMailRu1 = this.txtMailRU;
      point1 = new Point(76, 17);
      Point point22 = point1;
      txtMailRu1.Location = point22;
      this.txtMailRU.MaxLength = 32;
      this.txtMailRU.Name = "txtMailRU";
      TextBox txtMailRu2 = this.txtMailRU;
      size1 = new Size(76, 21);
      Size size22 = size1;
      txtMailRu2.Size = size22;
      this.txtMailRU.TabIndex = 1;
      this.txtMailRU.Text = "0";
      this.txtMailRU.TextAlign = HorizontalAlignment.Center;
      this.GroupBox1.Controls.Add((Control) this.lblInboxRU_Count);
      this.GroupBox1.Controls.Add((Control) this.txtInboxRU);
      this.GroupBox1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.GroupBox1.ForeColor = Color.Green;
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(206, 124);
      Point point23 = point1;
      groupBox1_1.Location = point23;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(158, 45);
      Size size23 = size1;
      groupBox1_2.Size = size23;
      this.GroupBox1.TabIndex = 162;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "@inbox.ru";
      this.lblInboxRU_Count.ForeColor = Color.Black;
      Label lblInboxRuCount1 = this.lblInboxRU_Count;
      point1 = new Point(6, 17);
      Point point24 = point1;
      lblInboxRuCount1.Location = point24;
      this.lblInboxRU_Count.Name = "lblInboxRU_Count";
      Label lblInboxRuCount2 = this.lblInboxRU_Count;
      size1 = new Size(70, 20);
      Size size24 = size1;
      lblInboxRuCount2.Size = size24;
      this.lblInboxRU_Count.TabIndex = 162;
      this.lblInboxRU_Count.Text = "???";
      this.lblInboxRU_Count.TextAlign = ContentAlignment.MiddleCenter;
      this.txtInboxRU.BackColor = Color.FromArgb(181, 195, 168);
      this.txtInboxRU.BorderStyle = BorderStyle.FixedSingle;
      this.txtInboxRU.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtInboxRU.ForeColor = Color.Black;
      TextBox txtInboxRu1 = this.txtInboxRU;
      point1 = new Point(76, 17);
      Point point25 = point1;
      txtInboxRu1.Location = point25;
      this.txtInboxRU.MaxLength = 32;
      this.txtInboxRU.Name = "txtInboxRU";
      TextBox txtInboxRu2 = this.txtInboxRU;
      size1 = new Size(76, 21);
      Size size25 = size1;
      txtInboxRu2.Size = size25;
      this.txtInboxRU.TabIndex = 2;
      this.txtInboxRU.Text = "0";
      this.txtInboxRU.TextAlign = HorizontalAlignment.Center;
      this.GroupBox2.Controls.Add((Control) this.lblListRU_Count);
      this.GroupBox2.Controls.Add((Control) this.txtListRU);
      this.GroupBox2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.GroupBox2.ForeColor = Color.Green;
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(206, 175);
      Point point26 = point1;
      groupBox2_1.Location = point26;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(158, 45);
      Size size26 = size1;
      groupBox2_2.Size = size26;
      this.GroupBox2.TabIndex = 163;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "@list.ru";
      this.lblListRU_Count.ForeColor = Color.Black;
      Label lblListRuCount1 = this.lblListRU_Count;
      point1 = new Point(6, 17);
      Point point27 = point1;
      lblListRuCount1.Location = point27;
      this.lblListRU_Count.Name = "lblListRU_Count";
      Label lblListRuCount2 = this.lblListRU_Count;
      size1 = new Size(70, 20);
      Size size27 = size1;
      lblListRuCount2.Size = size27;
      this.lblListRU_Count.TabIndex = 162;
      this.lblListRU_Count.Text = "???";
      this.lblListRU_Count.TextAlign = ContentAlignment.MiddleCenter;
      this.txtListRU.BackColor = Color.FromArgb(181, 195, 168);
      this.txtListRU.BorderStyle = BorderStyle.FixedSingle;
      this.txtListRU.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtListRU.ForeColor = Color.Black;
      TextBox txtListRu1 = this.txtListRU;
      point1 = new Point(76, 17);
      Point point28 = point1;
      txtListRu1.Location = point28;
      this.txtListRU.MaxLength = 32;
      this.txtListRU.Name = "txtListRU";
      TextBox txtListRu2 = this.txtListRU;
      size1 = new Size(76, 21);
      Size size28 = size1;
      txtListRu2.Size = size28;
      this.txtListRU.TabIndex = 3;
      this.txtListRU.Text = "0";
      this.txtListRU.TextAlign = HorizontalAlignment.Center;
      this.GroupBox3.Controls.Add((Control) this.lblBkRU_Count);
      this.GroupBox3.Controls.Add((Control) this.txtBkRU);
      this.GroupBox3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.GroupBox3.ForeColor = Color.Green;
      GroupBox groupBox3_1 = this.GroupBox3;
      point1 = new Point(206, 226);
      Point point29 = point1;
      groupBox3_1.Location = point29;
      this.GroupBox3.Name = "GroupBox3";
      GroupBox groupBox3_2 = this.GroupBox3;
      size1 = new Size(158, 45);
      Size size29 = size1;
      groupBox3_2.Size = size29;
      this.GroupBox3.TabIndex = 164;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "@bk.ru";
      this.lblBkRU_Count.ForeColor = Color.Black;
      Label lblBkRuCount1 = this.lblBkRU_Count;
      point1 = new Point(6, 17);
      Point point30 = point1;
      lblBkRuCount1.Location = point30;
      this.lblBkRU_Count.Name = "lblBkRU_Count";
      Label lblBkRuCount2 = this.lblBkRU_Count;
      size1 = new Size(70, 20);
      Size size30 = size1;
      lblBkRuCount2.Size = size30;
      this.lblBkRU_Count.TabIndex = 162;
      this.lblBkRU_Count.Text = "???";
      this.lblBkRU_Count.TextAlign = ContentAlignment.MiddleCenter;
      this.txtBkRU.BackColor = Color.FromArgb(181, 195, 168);
      this.txtBkRU.BorderStyle = BorderStyle.FixedSingle;
      this.txtBkRU.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtBkRU.ForeColor = Color.Black;
      TextBox txtBkRu1 = this.txtBkRU;
      point1 = new Point(76, 17);
      Point point31 = point1;
      txtBkRu1.Location = point31;
      this.txtBkRU.MaxLength = 32;
      this.txtBkRU.Name = "txtBkRU";
      TextBox txtBkRu2 = this.txtBkRU;
      size1 = new Size(76, 21);
      Size size31 = size1;
      txtBkRu2.Size = size31;
      this.txtBkRU.TabIndex = 4;
      this.txtBkRU.Text = "0";
      this.txtBkRU.TextAlign = HorizontalAlignment.Center;
      this.boxItogo.Controls.Add((Control) this.lblItogo);
      this.boxItogo.Controls.Add((Control) this.txtItogo);
      this.boxItogo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.boxItogo.ForeColor = Color.Blue;
      GroupBox boxItogo1 = this.boxItogo;
      point1 = new Point(206, 277);
      Point point32 = point1;
      boxItogo1.Location = point32;
      this.boxItogo.Name = "boxItogo";
      GroupBox boxItogo2 = this.boxItogo;
      size1 = new Size(158, 45);
      Size size32 = size1;
      boxItogo2.Size = size32;
      this.boxItogo.TabIndex = 166;
      this.boxItogo.TabStop = false;
      this.boxItogo.Text = "ИТОГО:";
      Label lblItogo1 = this.lblItogo;
      point1 = new Point(6, 17);
      Point point33 = point1;
      lblItogo1.Location = point33;
      this.lblItogo.Name = "lblItogo";
      Label lblItogo2 = this.lblItogo;
      size1 = new Size(70, 20);
      Size size33 = size1;
      lblItogo2.Size = size33;
      this.lblItogo.TabIndex = 162;
      this.lblItogo.Text = "???";
      this.lblItogo.TextAlign = ContentAlignment.MiddleCenter;
      this.txtItogo.BackColor = Color.FromArgb(181, 195, 168);
      this.txtItogo.BorderStyle = BorderStyle.FixedSingle;
      this.txtItogo.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.txtItogo.ForeColor = Color.Black;
      TextBox txtItogo1 = this.txtItogo;
      point1 = new Point(76, 17);
      Point point34 = point1;
      txtItogo1.Location = point34;
      this.txtItogo.MaxLength = 32;
      this.txtItogo.Name = "txtItogo";
      TextBox txtItogo2 = this.txtItogo;
      size1 = new Size(76, 21);
      Size size34 = size1;
      txtItogo2.Size = size34;
      this.txtItogo.TabIndex = 4;
      this.txtItogo.Text = "0";
      this.txtItogo.TextAlign = HorizontalAlignment.Center;
      this.btnDownload.BackColor = Color.FromArgb(0, 192, 192);
      this.btnDownload.Enabled = false;
      this.btnDownload.FlatStyle = FlatStyle.Flat;
      this.btnDownload.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnDownload.ForeColor = Color.Black;
      this.btnDownload.Image = (Image) componentResourceManager.GetObject("btnDownload.Image");
      this.btnDownload.ImageAlign = ContentAlignment.TopCenter;
      Button btnDownload1 = this.btnDownload;
      point1 = new Point(370, 260);
      Point point35 = point1;
      btnDownload1.Location = point35;
      this.btnDownload.Name = "btnDownload";
      Button btnDownload2 = this.btnDownload;
      size1 = new Size(106, 62);
      Size size35 = size1;
      btnDownload2.Size = size35;
      this.btnDownload.TabIndex = 167;
      this.btnDownload.TabStop = false;
      this.btnDownload.Text = "Download";
      this.btnDownload.TextAlign = ContentAlignment.BottomCenter;
      this.btnDownload.UseVisualStyleBackColor = false;
      this.chAddMail.AutoSize = true;
      this.chAddMail.FlatStyle = FlatStyle.Flat;
      CheckBox chAddMail1 = this.chAddMail;
      point1 = new Point(11, 226);
      Point point36 = point1;
      chAddMail1.Location = point36;
      this.chAddMail.Name = "chAddMail";
      CheckBox chAddMail2 = this.chAddMail;
      size1 = new Size(160, 17);
      Size size36 = size1;
      chAddMail2.Size = size36;
      this.chAddMail.TabIndex = 168;
      this.chAddMail.Text = "Добавлять в конец списка";
      this.chAddMail.UseVisualStyleBackColor = true;
      this.chAutoSave.AutoSize = true;
      this.chAutoSave.FlatStyle = FlatStyle.Flat;
      CheckBox chAutoSave1 = this.chAutoSave;
      point1 = new Point(11, 249);
      Point point37 = point1;
      chAutoSave1.Location = point37;
      this.chAutoSave.Name = "chAutoSave";
      CheckBox chAutoSave2 = this.chAutoSave;
      size1 = new Size(176, 17);
      Size size37 = size1;
      chAutoSave2.Size = size37;
      this.chAutoSave.TabIndex = 169;
      this.chAutoSave.Text = "Сохранять при остановке рег.";
      this.chAutoSave.UseVisualStyleBackColor = true;
      this.PB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      ProgressBar pb1 = this.PB;
      point1 = new Point(0, 325);
      Point point38 = point1;
      pb1.Location = point38;
      this.PB.Name = "PB";
      ProgressBar pb2 = this.PB;
      size1 = new Size(481, 16);
      Size size38 = size1;
      pb2.Size = size38;
      this.PB.TabIndex = 170;
      this.boxSale.Controls.Add((Control) this.lblSale);
      this.boxSale.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.boxSale.ForeColor = Color.FromArgb(64, 64, 64);
      GroupBox boxSale1 = this.boxSale;
      point1 = new Point(370, 159);
      Point point39 = point1;
      boxSale1.Location = point39;
      this.boxSale.Name = "boxSale";
      GroupBox boxSale2 = this.boxSale;
      size1 = new Size(106, 45);
      Size size39 = size1;
      boxSale2.Size = size39;
      this.boxSale.TabIndex = 171;
      this.boxSale.TabStop = false;
      this.boxSale.Text = "Sale";
      this.lblSale.ForeColor = Color.Black;
      Label lblSale1 = this.lblSale;
      point1 = new Point(6, 17);
      Point point40 = point1;
      lblSale1.Location = point40;
      this.lblSale.Name = "lblSale";
      Label lblSale2 = this.lblSale;
      size1 = new Size(93, 20);
      Size size40 = size1;
      lblSale2.Size = size40;
      this.lblSale.TabIndex = 162;
      this.lblSale.Text = "???";
      this.lblSale.TextAlign = ContentAlignment.MiddleCenter;
      this.btnArj.BackColor = Color.FromArgb(156, 175, 137);
      this.btnArj.Enabled = false;
      this.btnArj.FlatStyle = FlatStyle.Flat;
      this.btnArj.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.btnArj.ForeColor = Color.Black;
      this.btnArj.Image = (Image) componentResourceManager.GetObject("btnArj.Image");
      this.btnArj.ImageAlign = ContentAlignment.MiddleLeft;
      Button btnArj1 = this.btnArj;
      point1 = new Point(11, 271);
      Point point41 = point1;
      btnArj1.Location = point41;
      this.btnArj.Name = "btnArj";
      Button btnArj2 = this.btnArj;
      size1 = new Size(181, 44);
      Size size41 = size1;
      btnArj2.Size = size41;
      this.btnArj.TabIndex = 172;
      this.btnArj.TabStop = false;
      this.btnArj.Text = "Перевести проданные\r\nв архивную таблицу";
      this.btnArj.TextAlign = ContentAlignment.MiddleRight;
      this.btnArj.UseVisualStyleBackColor = false;
      this.chIgnoreSaleID.AutoSize = true;
      this.chIgnoreSaleID.Enabled = false;
      this.chIgnoreSaleID.FlatStyle = FlatStyle.Flat;
      CheckBox chIgnoreSaleId1 = this.chIgnoreSaleID;
      point1 = new Point(370, 72);
      Point point42 = point1;
      chIgnoreSaleId1.Location = point42;
      this.chIgnoreSaleID.Name = "chIgnoreSaleID";
      CheckBox chIgnoreSaleId2 = this.chIgnoreSaleID;
      size1 = new Size(88, 17);
      Size size42 = size1;
      chIgnoreSaleId2.Size = size42;
      this.chIgnoreSaleID.TabIndex = 173;
      this.chIgnoreSaleID.Text = "Ignore SaleID";
      this.chIgnoreSaleID.UseVisualStyleBackColor = true;
      this.btnLoadAndDel.BackColor = Color.FromArgb(0, 192, 192);
      this.btnLoadAndDel.FlatStyle = FlatStyle.Flat;
      this.btnLoadAndDel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnLoadAndDel.ForeColor = Color.Black;
      this.btnLoadAndDel.ImageAlign = ContentAlignment.TopCenter;
      Button btnLoadAndDel1 = this.btnLoadAndDel;
      point1 = new Point(370, 95);
      Point point43 = point1;
      btnLoadAndDel1.Location = point43;
      this.btnLoadAndDel.Name = "btnLoadAndDel";
      Button btnLoadAndDel2 = this.btnLoadAndDel;
      size1 = new Size(106, 62);
      Size size43 = size1;
      btnLoadAndDel2.Size = size43;
      this.btnLoadAndDel.TabIndex = 174;
      this.btnLoadAndDel.TabStop = false;
      this.btnLoadAndDel.Text = "Загрузить\r\nи удалить";
      this.btnLoadAndDel.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(181, 195, 168);
      size1 = new Size(481, 341);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.btnLoadAndDel);
      this.Controls.Add((Control) this.chIgnoreSaleID);
      this.Controls.Add((Control) this.btnArj);
      this.Controls.Add((Control) this.boxSale);
      this.Controls.Add((Control) this.PB);
      this.Controls.Add((Control) this.chAutoSave);
      this.Controls.Add((Control) this.chAddMail);
      this.Controls.Add((Control) this.btnDownload);
      this.Controls.Add((Control) this.boxItogo);
      this.Controls.Add((Control) this.GroupBox3);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.boxMailRU);
      this.Controls.Add((Control) this.chCreateTable);
      this.Controls.Add((Control) this.chUpload);
      this.Controls.Add((Control) this.btnAmount);
      this.Controls.Add((Control) this.btnUpload);
      this.Controls.Add((Control) this.btnCreateTable);
      this.Controls.Add((Control) this.boxTab2);
      this.Controls.Add((Control) this.boxTab1);
      this.Controls.Add((Control) this.picStatus_DataBase);
      this.Controls.Add((Control) this.txtDB_Password);
      this.Controls.Add((Control) this.txtDB_User);
      this.Controls.Add((Control) this.txtDB_Name);
      this.Controls.Add((Control) this.PictureBox6);
      this.Controls.Add((Control) this.PictureBox5);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.PictureBox3);
      this.Controls.Add((Control) this.txtDB_Host);
      this.ForeColor = Color.Black;
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (frmSQL);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "MySQL";
      ((ISupportInitialize) this.picStatus_DataBase).EndInit();
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((ISupportInitialize) this.PictureBox5).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      ((ISupportInitialize) this.PictureBox3).EndInit();
      this.boxTab1.ResumeLayout(false);
      this.boxTab1.PerformLayout();
      this.boxTab2.ResumeLayout(false);
      this.boxTab2.PerformLayout();
      this.boxMailRU.ResumeLayout(false);
      this.boxMailRU.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.boxItogo.ResumeLayout(false);
      this.boxItogo.PerformLayout();
      this.boxSale.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual PictureBox picStatus_DataBase
    {
      get
      {
        return this._picStatus_DataBase;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._picStatus_DataBase = value;
      }
    }

    internal virtual TextBox txtDB_Password
    {
      get
      {
        return this._txtDB_Password;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDB_Host_TextChanged);
        if (this._txtDB_Password != null)
          this._txtDB_Password.TextChanged -= eventHandler;
        this._txtDB_Password = value;
        if (this._txtDB_Password == null)
          return;
        this._txtDB_Password.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtDB_User
    {
      get
      {
        return this._txtDB_User;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDB_Host_TextChanged);
        if (this._txtDB_User != null)
          this._txtDB_User.TextChanged -= eventHandler;
        this._txtDB_User = value;
        if (this._txtDB_User == null)
          return;
        this._txtDB_User.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtDB_Name
    {
      get
      {
        return this._txtDB_Name;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDB_Host_TextChanged);
        if (this._txtDB_Name != null)
          this._txtDB_Name.TextChanged -= eventHandler;
        this._txtDB_Name = value;
        if (this._txtDB_Name == null)
          return;
        this._txtDB_Name.TextChanged += eventHandler;
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

    internal virtual TextBox txtDB_Host
    {
      get
      {
        return this._txtDB_Host;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDB_Host_TextChanged);
        if (this._txtDB_Host != null)
          this._txtDB_Host.TextChanged -= eventHandler;
        this._txtDB_Host = value;
        if (this._txtDB_Host == null)
          return;
        this._txtDB_Host.TextChanged += eventHandler;
      }
    }

    internal virtual GroupBox boxTab1
    {
      get
      {
        return this._boxTab1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxTab1 = value;
      }
    }

    internal virtual TextBox txtTableStorage
    {
      get
      {
        return this._txtTableStorage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDB_Host_TextChanged);
        if (this._txtTableStorage != null)
          this._txtTableStorage.TextChanged -= eventHandler;
        this._txtTableStorage = value;
        if (this._txtTableStorage == null)
          return;
        this._txtTableStorage.TextChanged += eventHandler;
      }
    }

    internal virtual GroupBox boxTab2
    {
      get
      {
        return this._boxTab2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxTab2 = value;
      }
    }

    internal virtual TextBox txtTableBackup
    {
      get
      {
        return this._txtTableBackup;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDB_Host_TextChanged);
        if (this._txtTableBackup != null)
          this._txtTableBackup.TextChanged -= eventHandler;
        this._txtTableBackup = value;
        if (this._txtTableBackup == null)
          return;
        this._txtTableBackup.TextChanged += eventHandler;
      }
    }

    internal virtual Button btnCreateTable
    {
      get
      {
        return this._btnCreateTable;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnCreateTable_Click);
        if (this._btnCreateTable != null)
          this._btnCreateTable.Click -= eventHandler;
        this._btnCreateTable = value;
        if (this._btnCreateTable == null)
          return;
        this._btnCreateTable.Click += eventHandler;
      }
    }

    internal virtual Button btnUpload
    {
      get
      {
        return this._btnUpload;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnUpload_Click);
        if (this._btnUpload != null)
          this._btnUpload.Click -= eventHandler;
        this._btnUpload = value;
        if (this._btnUpload == null)
          return;
        this._btnUpload.Click += eventHandler;
      }
    }

    internal virtual Button btnAmount
    {
      get
      {
        return this._btnAmount;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAmount_Click);
        if (this._btnAmount != null)
          this._btnAmount.Click -= eventHandler;
        this._btnAmount = value;
        if (this._btnAmount == null)
          return;
        this._btnAmount.Click += eventHandler;
      }
    }

    internal virtual CheckBox chUpload
    {
      get
      {
        return this._chUpload;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chUpload_CheckedChanged);
        if (this._chUpload != null)
          this._chUpload.CheckedChanged -= eventHandler;
        this._chUpload = value;
        if (this._chUpload == null)
          return;
        this._chUpload.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chCreateTable
    {
      get
      {
        return this._chCreateTable;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chCreateTable_CheckedChanged);
        if (this._chCreateTable != null)
          this._chCreateTable.CheckedChanged -= eventHandler;
        this._chCreateTable = value;
        if (this._chCreateTable == null)
          return;
        this._chCreateTable.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox boxMailRU
    {
      get
      {
        return this._boxMailRU;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxMailRU = value;
      }
    }

    internal virtual Label lblMailRU_Count
    {
      get
      {
        return this._lblMailRU_Count;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblMailRU_Count = value;
      }
    }

    internal virtual TextBox txtMailRU
    {
      get
      {
        return this._txtMailRU;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBkRU_KeyUp);
        if (this._txtMailRU != null)
          this._txtMailRU.KeyUp -= keyEventHandler;
        this._txtMailRU = value;
        if (this._txtMailRU == null)
          return;
        this._txtMailRU.KeyUp += keyEventHandler;
      }
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

    internal virtual Label lblInboxRU_Count
    {
      get
      {
        return this._lblInboxRU_Count;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblInboxRU_Count = value;
      }
    }

    internal virtual TextBox txtInboxRU
    {
      get
      {
        return this._txtInboxRU;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBkRU_KeyUp);
        if (this._txtInboxRU != null)
          this._txtInboxRU.KeyUp -= keyEventHandler;
        this._txtInboxRU = value;
        if (this._txtInboxRU == null)
          return;
        this._txtInboxRU.KeyUp += keyEventHandler;
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

    internal virtual Label lblListRU_Count
    {
      get
      {
        return this._lblListRU_Count;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblListRU_Count = value;
      }
    }

    internal virtual TextBox txtListRU
    {
      get
      {
        return this._txtListRU;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBkRU_KeyUp);
        if (this._txtListRU != null)
          this._txtListRU.KeyUp -= keyEventHandler;
        this._txtListRU = value;
        if (this._txtListRU == null)
          return;
        this._txtListRU.KeyUp += keyEventHandler;
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

    internal virtual Label lblBkRU_Count
    {
      get
      {
        return this._lblBkRU_Count;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblBkRU_Count = value;
      }
    }

    internal virtual TextBox txtBkRU
    {
      get
      {
        return this._txtBkRU;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBkRU_KeyUp);
        if (this._txtBkRU != null)
          this._txtBkRU.KeyUp -= keyEventHandler;
        this._txtBkRU = value;
        if (this._txtBkRU == null)
          return;
        this._txtBkRU.KeyUp += keyEventHandler;
      }
    }

    internal virtual GroupBox boxItogo
    {
      get
      {
        return this._boxItogo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxItogo = value;
      }
    }

    internal virtual Label lblItogo
    {
      get
      {
        return this._lblItogo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblItogo = value;
      }
    }

    internal virtual TextBox txtItogo
    {
      get
      {
        return this._txtItogo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtItogo_KeyUp);
        if (this._txtItogo != null)
          this._txtItogo.KeyUp -= keyEventHandler;
        this._txtItogo = value;
        if (this._txtItogo == null)
          return;
        this._txtItogo.KeyUp += keyEventHandler;
      }
    }

    internal virtual Button btnDownload
    {
      get
      {
        return this._btnDownload;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnDownload_Click);
        if (this._btnDownload != null)
          this._btnDownload.Click -= eventHandler;
        this._btnDownload = value;
        if (this._btnDownload == null)
          return;
        this._btnDownload.Click += eventHandler;
      }
    }

    internal virtual CheckBox chAddMail
    {
      get
      {
        return this._chAddMail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chAddMail_CheckedChanged);
        if (this._chAddMail != null)
          this._chAddMail.CheckedChanged -= eventHandler;
        this._chAddMail = value;
        if (this._chAddMail == null)
          return;
        this._chAddMail.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chAutoSave
    {
      get
      {
        return this._chAutoSave;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chAutoSave_CheckedChanged);
        if (this._chAutoSave != null)
          this._chAutoSave.CheckedChanged -= eventHandler;
        this._chAutoSave = value;
        if (this._chAutoSave == null)
          return;
        this._chAutoSave.CheckedChanged += eventHandler;
      }
    }

    internal virtual ProgressBar PB
    {
      get
      {
        return this._PB;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PB = value;
      }
    }

    internal virtual GroupBox boxSale
    {
      get
      {
        return this._boxSale;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._boxSale = value;
      }
    }

    internal virtual Label lblSale
    {
      get
      {
        return this._lblSale;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblSale = value;
      }
    }

    internal virtual Button btnArj
    {
      get
      {
        return this._btnArj;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnArj_Click);
        if (this._btnArj != null)
          this._btnArj.Click -= eventHandler;
        this._btnArj = value;
        if (this._btnArj == null)
          return;
        this._btnArj.Click += eventHandler;
      }
    }

    internal virtual CheckBox chIgnoreSaleID
    {
      get
      {
        return this._chIgnoreSaleID;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._chIgnoreSaleID = value;
      }
    }

    internal virtual Button btnLoadAndDel
    {
      get
      {
        return this._btnLoadAndDel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnLoadAndDel_Click);
        if (this._btnLoadAndDel != null)
          this._btnLoadAndDel.Click -= eventHandler;
        this._btnLoadAndDel = value;
        if (this._btnLoadAndDel == null)
          return;
        this._btnLoadAndDel.Click += eventHandler;
      }
    }

    private void txtDB_Host_TextChanged(object sender, EventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (Type) null, "Text", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Length", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 0, false))
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.FromArgb((int) byte.MaxValue, 208, 208)
        }, (string[]) null, (Type[]) null);
      else
        NewLateBinding.LateSet(sender, (Type) null, "BackColor", new object[1]
        {
          (object) Color.FromArgb(181, 195, 168)
        }, (string[]) null, (Type[]) null);
      _INI.SaveINI("SQL", Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)), Conversions.ToString(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      if (this.txtDB_Host.TextLength > 0 && this.txtDB_Name.TextLength > 0 && (this.txtDB_User.TextLength > 0 && this.txtDB_Password.TextLength > 0))
      {
        this.btnAmount.Enabled = true;
        this.chCreateTable.Enabled = true;
        this.chUpload.Enabled = true;
        this.btnArj.Enabled = true;
      }
      else
      {
        this.btnAmount.Enabled = false;
        this.chCreateTable.Enabled = false;
        this.chUpload.Enabled = false;
        this.btnArj.Enabled = false;
      }
    }

    private void frmSQL_Load(object sender, EventArgs e)
    {
      this.txtDB_Host.Text = _INI.LoadINI("SQL", "txtDB_Host");
      this.txtDB_Name.Text = _INI.LoadINI("SQL", "txtDB_Name");
      this.txtDB_User.Text = _INI.LoadINI("SQL", "txtDB_User");
      this.txtDB_Password.Text = _INI.LoadINI("SQL", "txtDB_Password");
      this.txtTableStorage.Text = _INI.LoadINI("SQL", "txtTableStorage");
      this.txtTableBackup.Text = _INI.LoadINI("SQL", "txtTableBackup");
      if (Operators.CompareString(_INI.LoadINI("SQL", "chAutoSave").ToLower(), "true", false) != 0)
        return;
      this.chAutoSave.Checked = true;
    }

    private void chCreateTable_CheckedChanged(object sender, EventArgs e)
    {
      this.btnCreateTable.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
    }

    private void chUpload_CheckedChanged(object sender, EventArgs e)
    {
      this.btnUpload.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.chIgnoreSaleID.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type) null, "checked", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
    }

    private void txtItogo_KeyUp(object sender, KeyEventArgs e)
    {
      int num1 = checked ((int) Math.Round(Conversion.Val(this.txtItogo.Text)));
      int num2 = num1 / 4;
      int num3 = checked (num1 - num2 * 4);
      this.txtMailRU.Text = Conversions.ToString(checked (num2 + num3));
      this.txtInboxRU.Text = Conversions.ToString(num2);
      this.txtListRU.Text = Conversions.ToString(num2);
      this.txtBkRU.Text = Conversions.ToString(num2);
    }

    private void txtBkRU_KeyUp(object sender, KeyEventArgs e)
    {
      this.txtItogo.Text = Conversions.ToString(checked ((int) Math.Round(unchecked (Conversion.Val(this.txtMailRU.Text) + Conversion.Val(this.txtInboxRU.Text) + Conversion.Val(this.txtListRU.Text) + Conversion.Val(this.txtBkRU.Text)))));
    }

    private void btnCreateTable_Click(object sender, EventArgs e)
    {
      try
      {
        MySqlConnection mySqlConnection = new MySqlConnection("Server=" + this.txtDB_Host.Text + ";User id=" + this.txtDB_User.Text + ";password=" + this.txtDB_Password.Text + ";database=" + this.txtDB_Name.Text + "; character set=utf8");
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        string sText1 = "MySQL: Connect...";
        fn1.TXT(ref sText1);
        mySqlConnection.Open();
        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
        string sText2 = "MySQL: Connected - OK";
        fn2.TXT(ref sText2);
        MySqlCommand mySqlCommand = new MySqlCommand();
        mySqlCommand.Connection = mySqlConnection;
        mySqlCommand.CommandText = "CREATE TABLE IF NOT EXISTS `" + this.txtTableStorage.Text + "`(`ID` INT(10) NOT NULL AUTO_INCREMENT,`login` varchar(64) NOT NULL DEFAULT '',`domain` varchar(16) NOT NULL DEFAULT '',`password` varchar(32) NOT NULL DEFAULT '',`Registered` TINYINT(10) NOT NULL DEFAULT '0',`RegUserData_Name` varchar(32) NOT NULL DEFAULT '',`RegUserData_LastName` varchar(32) NOT NULL DEFAULT '',`RegUserData_City` varchar(32) NOT NULL DEFAULT '',`RegUserData_BirthDay` varchar(32) NOT NULL DEFAULT '',`RegUserData_BirthMonth` varchar(32) NOT NULL DEFAULT '',`RegUserData_BirthYear` varchar(32) NOT NULL DEFAULT '',`RegUserData_SecretQuestion` varchar(64) NOT NULL DEFAULT '',`RegUserData_SecretAnswer` varchar(32) NOT NULL DEFAULT '',`RegUserData_ItsSecretQuestion` varchar(32) NOT NULL DEFAULT '',`RegUserData_Sex` TINYINT(10) NOT NULL DEFAULT '0',`MailAmount` INT(10) NOT NULL DEFAULT '0',`DataCreateBox` varchar(32) NOT NULL DEFAULT '',`comment` varchar(32) NOT NULL DEFAULT '',`DomainID` TINYINT(10) NOT NULL DEFAULT '0',`SaleID` TINYINT(10) NOT NULL DEFAULT '0',`DateAdd` varchar(32) NOT NULL DEFAULT '',`DateSale` varchar(32) NOT NULL DEFAULT '',PRIMARY KEY (`ID`)) ENGINE=MyISAM DEFAULT CHARSET=utf8 COMMENT='TableStorage' AUTO_INCREMENT=1;";
        int num = mySqlCommand.ExecuteNonQuery();
        _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
        string sText3 = "MySQL: Table storage - created";
        fn3.TXT(ref sText3);
        mySqlCommand.CommandText = "CREATE TABLE IF NOT EXISTS `" + this.txtTableBackup.Text + "`(`ID` INT(10) NOT NULL,`login` varchar(64) NOT NULL DEFAULT '',`domain` varchar(16) NOT NULL DEFAULT '',`password` varchar(32) NOT NULL DEFAULT '',`Registered` TINYINT(10) NOT NULL DEFAULT '0',`RegUserData_Name` varchar(32) NOT NULL DEFAULT '',`RegUserData_LastName` varchar(32) NOT NULL DEFAULT '',`RegUserData_City` varchar(32) NOT NULL DEFAULT '',`RegUserData_BirthDay` varchar(32) NOT NULL DEFAULT '',`RegUserData_BirthMonth` varchar(32) NOT NULL DEFAULT '',`RegUserData_BirthYear` varchar(32) NOT NULL DEFAULT '',`RegUserData_SecretQuestion` varchar(64) NOT NULL DEFAULT '',`RegUserData_SecretAnswer` varchar(32) NOT NULL DEFAULT '',`RegUserData_ItsSecretQuestion` varchar(32) NOT NULL DEFAULT '',`RegUserData_Sex` TINYINT(10) NOT NULL DEFAULT '0',`MailAmount` INT(10) NOT NULL DEFAULT '0',`DataCreateBox` varchar(32) NOT NULL DEFAULT '',`comment` varchar(32) NOT NULL DEFAULT '',`DomainID` TINYINT(10) NOT NULL DEFAULT '0',`SaleID` TINYINT(10) NOT NULL DEFAULT '0',`DateAdd` varchar(32) NOT NULL DEFAULT '',`DateSale` varchar(32) NOT NULL DEFAULT '',PRIMARY KEY (`ID`)) ENGINE=MyISAM DEFAULT CHARSET=utf8 COMMENT='TableBackup';";
        num = mySqlCommand.ExecuteNonQuery();
        _FUNCTION.clsTXT fn4 = _FUNCTION.FN;
        string sText4 = "MySQL: Table Backup - created";
        fn4.TXT(ref sText4);
        mySqlConnection.Close();
        _FUNCTION.clsTXT fn5 = _FUNCTION.FN;
        string sText5 = "MySQL: Close";
        fn5.TXT(ref sText5);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ex MySQL: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    private void btnUpload_Click(object sender, EventArgs e)
    {
      md_MySQL.UploadTo_MySQL();
    }

    private void btnAmount_Click(object sender, EventArgs e)
    {
      try
      {
        MySqlConnection mySqlConnection = new MySqlConnection("Server=" + this.txtDB_Host.Text + ";User id=" + this.txtDB_User.Text + ";password=" + this.txtDB_Password.Text + ";database=" + this.txtDB_Name.Text + "; character set=utf8");
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        string sText1 = "MySQL: Connect...";
        fn1.TXT(ref sText1);
        mySqlConnection.Open();
        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
        string sText2 = "MySQL: Connected - OK";
        fn2.TXT(ref sText2);
        MySqlCommand mySqlCommand = new MySqlCommand();
        mySqlCommand.Connection = mySqlConnection;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        string text1 = this.txtTableStorage.Text;
        string text2 = this.txtTableBackup.Text;
        mySqlCommand.CommandText = "SELECT domain, COUNT(*) FROM " + text1 + " WHERE `SaleID`='0' GROUP BY domain;";
        this.lblMailRU_Count.Text = Conversions.ToString(0);
        this.lblInboxRU_Count.Text = Conversions.ToString(0);
        this.lblListRU_Count.Text = Conversions.ToString(0);
        this.lblBkRU_Count.Text = Conversions.ToString(0);
        MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
        int num = 0;
        while (mySqlDataReader.Read())
        {
          string str = Conversions.ToString(mySqlDataReader.GetValue(0));
          int integer = Conversions.ToInteger(mySqlDataReader.GetValue(1));
          string Left = str;
          if (Operators.CompareString(Left, "mail.ru", false) == 0)
            this.lblMailRU_Count.Text = Conversions.ToString(integer);
          else if (Operators.CompareString(Left, "inbox.ru", false) == 0)
            this.lblInboxRU_Count.Text = Conversions.ToString(integer);
          else if (Operators.CompareString(Left, "list.ru", false) == 0)
            this.lblListRU_Count.Text = Conversions.ToString(integer);
          else if (Operators.CompareString(Left, "bk.ru", false) == 0)
            this.lblBkRU_Count.Text = Conversions.ToString(integer);
          checked { num += integer; }
        }
        mySqlDataReader.Close();
        this.lblItogo.Text = Conversions.ToString(num);
        mySqlCommand.CommandText = "SELECT COUNT(*) FROM " + text1 + " WHERE `SaleID`='1';";
        int integer1 = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
        mySqlCommand.CommandText = "SELECT COUNT(*) FROM " + text2 + " WHERE `SaleID`='1';";
        this.lblSale.Text = Conversions.ToString(Conversions.ToInteger(Operators.AddObject((object) integer1, mySqlCommand.ExecuteScalar())));
        mySqlConnection.Close();
        stopwatch.Stop();
        this.btnDownload.Enabled = true;
        _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
        string sText3 = "MySQL: Amount - OK " + Conversions.ToString(num) + " accounts [" + Conversions.ToString(stopwatch.ElapsedMilliseconds) + "ms]";
        fn3.TXT(ref sText3);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ex MySQL Amount: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    private void btnDownload_Click(object sender, EventArgs e)
    {
      try
      {
        int num1 = checked ((int) Math.Round(unchecked (Conversion.Val(this.txtMailRU.Text) + Conversion.Val(this.txtListRU.Text) + Conversion.Val(this.txtInboxRU.Text) + Conversion.Val(this.txtBkRU.Text))));
        if (num1 == 0)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "MySQL: Не задано кол-во для скачивания.";
          fn.TXT(ref sText);
        }
        else
        {
          int index1;
          if (this.chAddMail.Checked)
          {
            index1 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
            _VARIABLES.MailInfo = (_VARIABLES.meMailInfo[]) Utils.CopyArray((Array) _VARIABLES.MailInfo, (Array) new _VARIABLES.meMailInfo[checked (index1 + num1 + 1)]);
          }
          else
          {
            index1 = 0;
            _VARIABLES.MailInfo = new _VARIABLES.meMailInfo[checked (num1 + 1)];
          }
          string text1 = this.txtTableStorage.Text;
          string text2 = this.txtTableBackup.Text;
          MySqlConnection mySqlConnection = new MySqlConnection("Server=" + this.txtDB_Host.Text + ";User id=" + this.txtDB_User.Text + ";password=" + this.txtDB_Password.Text + ";database=" + this.txtDB_Name.Text + "; character set=utf8");
          _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
          string sText1 = "MySQL: Connect...";
          fn1.TXT(ref sText1);
          mySqlConnection.Open();
          _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
          string sText2 = "MySQL: Connected - OK";
          fn2.TXT(ref sText2);
          MySqlCommand mySqlCommand = new MySqlCommand();
          mySqlCommand.Connection = mySqlConnection;
          Stopwatch stopwatch = new Stopwatch();
          stopwatch.Start();
          int num2 = 0;
          string str1 = DateAndTime.Now.ToString();
          int num3 = checked ((int) Math.Round(Conversion.Val(this.txtMailRU.Text)));
          if (num3 > 0)
          {
            mySqlCommand.CommandText = "SELECT * FROM `" + text1 + "` WHERE `domain`='mail.ru' AND `saleid`=0 LIMIT " + Conversions.ToString(num3) + ";";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            num2 = 0;
            while (mySqlDataReader.Read())
            {
              checked { ++num2; }
              checked { ++index1; }
              _VARIABLES.MailInfo[index1].ID = Conversions.ToInteger(mySqlDataReader.GetValue(0));
              _VARIABLES.MailInfo[index1].login = Conversions.ToString(mySqlDataReader.GetValue(1));
              _VARIABLES.MailInfo[index1].domain = Conversions.ToString(mySqlDataReader.GetValue(2));
              _VARIABLES.MailInfo[index1].password = Conversions.ToString(mySqlDataReader.GetValue(3));
              _VARIABLES.MailInfo[index1].Registered = Conversions.ToShort(mySqlDataReader.GetValue(4));
              _VARIABLES.MailInfo[index1].RegUserData.Name = Conversions.ToString(mySqlDataReader.GetValue(5));
              _VARIABLES.MailInfo[index1].RegUserData.LastName = Conversions.ToString(mySqlDataReader.GetValue(6));
              _VARIABLES.MailInfo[index1].RegUserData.City = Conversions.ToString(mySqlDataReader.GetValue(7));
              _VARIABLES.MailInfo[index1].RegUserData.BirthDay = Conversions.ToString(mySqlDataReader.GetValue(8));
              _VARIABLES.MailInfo[index1].RegUserData.BirthMonth = Conversions.ToString(mySqlDataReader.GetValue(9));
              _VARIABLES.MailInfo[index1].RegUserData.BirthYear = Conversions.ToString(mySqlDataReader.GetValue(10));
              _VARIABLES.MailInfo[index1].RegUserData.SecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(11));
              _VARIABLES.MailInfo[index1].RegUserData.SecretAnswer = Conversions.ToString(mySqlDataReader.GetValue(12));
              _VARIABLES.MailInfo[index1].RegUserData.ItsSecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(13));
              _VARIABLES.MailInfo[index1].RegUserData.Sex = Conversions.ToShort(mySqlDataReader.GetValue(14));
              _VARIABLES.MailInfo[index1].MailAmount = Conversions.ToInteger(mySqlDataReader.GetValue(15));
              _VARIABLES.MailInfo[index1].DataCreateBox = Conversions.ToString(mySqlDataReader.GetValue(16));
              _VARIABLES.MailInfo[index1].comment = Conversions.ToString(mySqlDataReader.GetValue(17));
              _VARIABLES.MailInfo[index1].DomainID = Conversions.ToShort(mySqlDataReader.GetValue(18));
            }
            mySqlDataReader.Close();
          }
          int num4 = checked (index1 - num2 + 1);
          int num5 = index1;
          int index2 = num4;
          while (index2 <= num5)
          {
            mySqlCommand.CommandText = "UPDATE `" + text1 + "` SET `SaleId`='1', `DateSale`='" + str1 + "' WHERE `ID`=" + Conversions.ToString(_VARIABLES.MailInfo[index2].ID) + " LIMIT 1;";
            mySqlCommand.ExecuteNonQuery();
            checked { ++index2; }
          }
          _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
          string sText3 = "MySQL: [MAIL.RU] Download " + Conversions.ToString(num2) + " accounts";
          fn3.TXT(ref sText3);
          int num6 = checked ((int) Math.Round(Conversion.Val(this.txtInboxRU.Text)));
          if (num6 > 0)
          {
            mySqlCommand.CommandText = "SELECT * FROM `" + text1 + "` WHERE `domain`='inbox.ru' AND `saleid`=0 LIMIT " + Conversions.ToString(num6) + ";";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            num2 = 0;
            while (mySqlDataReader.Read())
            {
              checked { ++num2; }
              checked { ++index1; }
              _VARIABLES.MailInfo[index1].ID = Conversions.ToInteger(mySqlDataReader.GetValue(0));
              _VARIABLES.MailInfo[index1].login = Conversions.ToString(mySqlDataReader.GetValue(1));
              _VARIABLES.MailInfo[index1].domain = Conversions.ToString(mySqlDataReader.GetValue(2));
              _VARIABLES.MailInfo[index1].password = Conversions.ToString(mySqlDataReader.GetValue(3));
              _VARIABLES.MailInfo[index1].Registered = Conversions.ToShort(mySqlDataReader.GetValue(4));
              _VARIABLES.MailInfo[index1].RegUserData.Name = Conversions.ToString(mySqlDataReader.GetValue(5));
              _VARIABLES.MailInfo[index1].RegUserData.LastName = Conversions.ToString(mySqlDataReader.GetValue(6));
              _VARIABLES.MailInfo[index1].RegUserData.City = Conversions.ToString(mySqlDataReader.GetValue(7));
              _VARIABLES.MailInfo[index1].RegUserData.BirthDay = Conversions.ToString(mySqlDataReader.GetValue(8));
              _VARIABLES.MailInfo[index1].RegUserData.BirthMonth = Conversions.ToString(mySqlDataReader.GetValue(9));
              _VARIABLES.MailInfo[index1].RegUserData.BirthYear = Conversions.ToString(mySqlDataReader.GetValue(10));
              _VARIABLES.MailInfo[index1].RegUserData.SecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(11));
              _VARIABLES.MailInfo[index1].RegUserData.SecretAnswer = Conversions.ToString(mySqlDataReader.GetValue(12));
              _VARIABLES.MailInfo[index1].RegUserData.ItsSecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(13));
              _VARIABLES.MailInfo[index1].RegUserData.Sex = Conversions.ToShort(mySqlDataReader.GetValue(14));
              _VARIABLES.MailInfo[index1].MailAmount = Conversions.ToInteger(mySqlDataReader.GetValue(15));
              _VARIABLES.MailInfo[index1].DataCreateBox = Conversions.ToString(mySqlDataReader.GetValue(16));
              _VARIABLES.MailInfo[index1].comment = Conversions.ToString(mySqlDataReader.GetValue(17));
              _VARIABLES.MailInfo[index1].DomainID = Conversions.ToShort(mySqlDataReader.GetValue(18));
            }
            mySqlDataReader.Close();
          }
          int num7 = checked (index1 - num2 + 1);
          int num8 = index1;
          int index3 = num7;
          while (index3 <= num8)
          {
            mySqlCommand.CommandText = "UPDATE `" + text1 + "` SET `SaleId`='1', `DateSale`='" + str1 + "' WHERE `ID`=" + Conversions.ToString(_VARIABLES.MailInfo[index3].ID) + " LIMIT 1;";
            mySqlCommand.ExecuteNonQuery();
            checked { ++index3; }
          }
          _FUNCTION.clsTXT fn4 = _FUNCTION.FN;
          string sText4 = "MySQL: [INBOX.RU] Download " + Conversions.ToString(num2) + " accounts";
          fn4.TXT(ref sText4);
          int num9 = checked ((int) Math.Round(Conversion.Val(this.txtListRU.Text)));
          if (num9 > 0)
          {
            mySqlCommand.CommandText = "SELECT * FROM `" + text1 + "` WHERE `domain`='list.ru' AND `saleid`=0 LIMIT " + Conversions.ToString(num9) + ";";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            num2 = 0;
            while (mySqlDataReader.Read())
            {
              checked { ++num2; }
              checked { ++index1; }
              _VARIABLES.MailInfo[index1].ID = Conversions.ToInteger(mySqlDataReader.GetValue(0));
              _VARIABLES.MailInfo[index1].login = Conversions.ToString(mySqlDataReader.GetValue(1));
              _VARIABLES.MailInfo[index1].domain = Conversions.ToString(mySqlDataReader.GetValue(2));
              _VARIABLES.MailInfo[index1].password = Conversions.ToString(mySqlDataReader.GetValue(3));
              _VARIABLES.MailInfo[index1].Registered = Conversions.ToShort(mySqlDataReader.GetValue(4));
              _VARIABLES.MailInfo[index1].RegUserData.Name = Conversions.ToString(mySqlDataReader.GetValue(5));
              _VARIABLES.MailInfo[index1].RegUserData.LastName = Conversions.ToString(mySqlDataReader.GetValue(6));
              _VARIABLES.MailInfo[index1].RegUserData.City = Conversions.ToString(mySqlDataReader.GetValue(7));
              _VARIABLES.MailInfo[index1].RegUserData.BirthDay = Conversions.ToString(mySqlDataReader.GetValue(8));
              _VARIABLES.MailInfo[index1].RegUserData.BirthMonth = Conversions.ToString(mySqlDataReader.GetValue(9));
              _VARIABLES.MailInfo[index1].RegUserData.BirthYear = Conversions.ToString(mySqlDataReader.GetValue(10));
              _VARIABLES.MailInfo[index1].RegUserData.SecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(11));
              _VARIABLES.MailInfo[index1].RegUserData.SecretAnswer = Conversions.ToString(mySqlDataReader.GetValue(12));
              _VARIABLES.MailInfo[index1].RegUserData.ItsSecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(13));
              _VARIABLES.MailInfo[index1].RegUserData.Sex = Conversions.ToShort(mySqlDataReader.GetValue(14));
              _VARIABLES.MailInfo[index1].MailAmount = Conversions.ToInteger(mySqlDataReader.GetValue(15));
              _VARIABLES.MailInfo[index1].DataCreateBox = Conversions.ToString(mySqlDataReader.GetValue(16));
              _VARIABLES.MailInfo[index1].comment = Conversions.ToString(mySqlDataReader.GetValue(17));
              _VARIABLES.MailInfo[index1].DomainID = Conversions.ToShort(mySqlDataReader.GetValue(18));
            }
            mySqlDataReader.Close();
          }
          int num10 = checked (index1 - num2 + 1);
          int num11 = index1;
          int index4 = num10;
          while (index4 <= num11)
          {
            mySqlCommand.CommandText = "UPDATE `" + text1 + "` SET `SaleId`='1', `DateSale`='" + str1 + "' WHERE `ID`=" + Conversions.ToString(_VARIABLES.MailInfo[index4].ID) + " LIMIT 1;";
            mySqlCommand.ExecuteNonQuery();
            checked { ++index4; }
          }
          _FUNCTION.clsTXT fn5 = _FUNCTION.FN;
          string sText5 = "MySQL: [LIST.RU] Download " + Conversions.ToString(num2) + " accounts";
          fn5.TXT(ref sText5);
          int num12 = checked ((int) Math.Round(Conversion.Val(this.txtBkRU.Text)));
          if (num12 > 0)
          {
            mySqlCommand.CommandText = "SELECT * FROM `" + text1 + "` WHERE `domain`='bk.ru' AND `saleid`=0 LIMIT " + Conversions.ToString(num12) + ";";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            num2 = 0;
            while (mySqlDataReader.Read())
            {
              checked { ++num2; }
              checked { ++index1; }
              _VARIABLES.MailInfo[index1].ID = Conversions.ToInteger(mySqlDataReader.GetValue(0));
              _VARIABLES.MailInfo[index1].login = Conversions.ToString(mySqlDataReader.GetValue(1));
              _VARIABLES.MailInfo[index1].domain = Conversions.ToString(mySqlDataReader.GetValue(2));
              _VARIABLES.MailInfo[index1].password = Conversions.ToString(mySqlDataReader.GetValue(3));
              _VARIABLES.MailInfo[index1].Registered = Conversions.ToShort(mySqlDataReader.GetValue(4));
              _VARIABLES.MailInfo[index1].RegUserData.Name = Conversions.ToString(mySqlDataReader.GetValue(5));
              _VARIABLES.MailInfo[index1].RegUserData.LastName = Conversions.ToString(mySqlDataReader.GetValue(6));
              _VARIABLES.MailInfo[index1].RegUserData.City = Conversions.ToString(mySqlDataReader.GetValue(7));
              _VARIABLES.MailInfo[index1].RegUserData.BirthDay = Conversions.ToString(mySqlDataReader.GetValue(8));
              _VARIABLES.MailInfo[index1].RegUserData.BirthMonth = Conversions.ToString(mySqlDataReader.GetValue(9));
              _VARIABLES.MailInfo[index1].RegUserData.BirthYear = Conversions.ToString(mySqlDataReader.GetValue(10));
              _VARIABLES.MailInfo[index1].RegUserData.SecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(11));
              _VARIABLES.MailInfo[index1].RegUserData.SecretAnswer = Conversions.ToString(mySqlDataReader.GetValue(12));
              _VARIABLES.MailInfo[index1].RegUserData.ItsSecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(13));
              _VARIABLES.MailInfo[index1].RegUserData.Sex = Conversions.ToShort(mySqlDataReader.GetValue(14));
              _VARIABLES.MailInfo[index1].MailAmount = Conversions.ToInteger(mySqlDataReader.GetValue(15));
              _VARIABLES.MailInfo[index1].DataCreateBox = Conversions.ToString(mySqlDataReader.GetValue(16));
              _VARIABLES.MailInfo[index1].comment = Conversions.ToString(mySqlDataReader.GetValue(17));
              _VARIABLES.MailInfo[index1].DomainID = Conversions.ToShort(mySqlDataReader.GetValue(18));
            }
            mySqlDataReader.Close();
          }
          int num13 = checked (index1 - num2 + 1);
          int num14 = index1;
          int index5 = num13;
          while (index5 <= num14)
          {
            mySqlCommand.CommandText = "UPDATE `" + text1 + "` SET `SaleId`='1', `DateSale`='" + str1 + "' WHERE `ID`=" + Conversions.ToString(_VARIABLES.MailInfo[index5].ID) + " LIMIT 1;";
            mySqlCommand.ExecuteNonQuery();
            checked { ++index5; }
          }
          _FUNCTION.clsTXT fn6 = _FUNCTION.FN;
          string sText6 = "MySQL: [BK.RU] Download " + Conversions.ToString(num2) + " accounts";
          fn6.TXT(ref sText6);
          mySqlCommand.CommandText = "SELECT domain, COUNT(*) FROM " + text1 + " WHERE `SaleID`='0' GROUP BY domain;";
          this.lblMailRU_Count.Text = Conversions.ToString(0);
          this.lblInboxRU_Count.Text = Conversions.ToString(0);
          this.lblListRU_Count.Text = Conversions.ToString(0);
          this.lblBkRU_Count.Text = Conversions.ToString(0);
          MySqlDataReader mySqlDataReader1 = mySqlCommand.ExecuteReader();
          int num15 = 0;
          while (mySqlDataReader1.Read())
          {
            string str2 = Conversions.ToString(mySqlDataReader1.GetValue(0));
            int integer = Conversions.ToInteger(mySqlDataReader1.GetValue(1));
            string Left = str2;
            if (Operators.CompareString(Left, "mail.ru", false) == 0)
              this.lblMailRU_Count.Text = Conversions.ToString(integer);
            else if (Operators.CompareString(Left, "inbox.ru", false) == 0)
              this.lblInboxRU_Count.Text = Conversions.ToString(integer);
            else if (Operators.CompareString(Left, "list.ru", false) == 0)
              this.lblListRU_Count.Text = Conversions.ToString(integer);
            else if (Operators.CompareString(Left, "bk.ru", false) == 0)
              this.lblBkRU_Count.Text = Conversions.ToString(integer);
            checked { num15 += integer; }
          }
          mySqlDataReader1.Close();
          this.lblItogo.Text = Conversions.ToString(num15);
          mySqlCommand.CommandText = "SELECT COUNT(*) FROM " + text1 + " WHERE `SaleID`='1';";
          int integer1 = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
          mySqlCommand.CommandText = "SELECT COUNT(*) FROM " + text2 + " WHERE `SaleID`='1';";
          this.lblSale.Text = Conversions.ToString(Conversions.ToInteger(Operators.AddObject((object) integer1, mySqlCommand.ExecuteScalar())));
          mySqlConnection.Close();
          stopwatch.Stop();
          if (Information.UBound((Array) _VARIABLES.MailInfo, 1) != index1)
            _VARIABLES.MailInfo = (_VARIABLES.meMailInfo[]) Utils.CopyArray((Array) _VARIABLES.MailInfo, (Array) new _VARIABLES.meMailInfo[checked (index1 + 1)]);
          _LV.LV_ADD_ALL();
          _LOADSAVE.SaveALL_MailInfo();
          _FUNCTION.clsTXT fn7 = _FUNCTION.FN;
          string sText7 = "MySQL: All Download - OK [" + Conversions.ToString(stopwatch.ElapsedMilliseconds) + "ms]";
          fn7.TXT(ref sText7);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ex MySQL Download: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    private void btnArj_Click(object sender, EventArgs e)
    {
      try
      {
        string text1 = this.txtTableStorage.Text;
        string text2 = this.txtTableBackup.Text;
        MySqlConnection mySqlConnection = new MySqlConnection("Server=" + this.txtDB_Host.Text + ";User id=" + this.txtDB_User.Text + ";password=" + this.txtDB_Password.Text + ";database=" + this.txtDB_Name.Text + "; character set=utf8");
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        string sText1 = "MySQL: Connect...";
        fn1.TXT(ref sText1);
        mySqlConnection.Open();
        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
        string sText2 = "MySQL: Connected - OK";
        fn2.TXT(ref sText2);
        MySqlCommand mySqlCommand = new MySqlCommand();
        mySqlCommand.Connection = mySqlConnection;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        mySqlCommand.CommandText = "INSERT INTO `" + text2 + "` SELECT * FROM `" + text1 + "` WHERE `SaleID`='1';";
        mySqlCommand.ExecuteNonQuery();
        _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
        string sText3 = "MySQL: Copy FROM `" + text1 + "` INTO `" + text2 + "` - OK";
        fn3.TXT(ref sText3);
        mySqlCommand.CommandText = "DELETE FROM `" + text1 + "` WHERE `SaleID`='1';";
        mySqlCommand.ExecuteNonQuery();
        _FUNCTION.clsTXT fn4 = _FUNCTION.FN;
        string sText4 = "MySQL: Delete FROM `" + text1 + "` - OK";
        fn4.TXT(ref sText4);
        mySqlConnection.Close();
        stopwatch.Stop();
        _FUNCTION.clsTXT fn5 = _FUNCTION.FN;
        string sText5 = "MySQL: All Copy  - OK [" + Conversions.ToString(stopwatch.ElapsedMilliseconds) + "ms]";
        fn5.TXT(ref sText5);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ex MySQL Copy: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    private void chAddMail_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void chAutoSave_CheckedChanged(object sender, EventArgs e)
    {
      _INI.SaveINI("SQL", "chAutoSave", Conversions.ToString(this.chAutoSave.Checked));
    }

    private void btnLoadAndDel_Click(object sender, EventArgs e)
    {
      try
      {
        int num1 = checked ((int) Math.Round(unchecked (Conversion.Val(this.txtMailRU.Text) + Conversion.Val(this.txtListRU.Text) + Conversion.Val(this.txtInboxRU.Text) + Conversion.Val(this.txtBkRU.Text))));
        if (num1 == 0)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "MySQL: Не задано кол-во для скачивания.";
          fn.TXT(ref sText);
        }
        else
        {
          int index1;
          if (this.chAddMail.Checked)
          {
            index1 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
            _VARIABLES.MailInfo = (_VARIABLES.meMailInfo[]) Utils.CopyArray((Array) _VARIABLES.MailInfo, (Array) new _VARIABLES.meMailInfo[checked (index1 + num1 + 1)]);
          }
          else
          {
            index1 = 0;
            _VARIABLES.MailInfo = new _VARIABLES.meMailInfo[checked (num1 + 1)];
          }
          string text1 = this.txtTableStorage.Text;
          string text2 = this.txtTableBackup.Text;
          MySqlConnection mySqlConnection = new MySqlConnection("Server=" + this.txtDB_Host.Text + ";User id=" + this.txtDB_User.Text + ";password=" + this.txtDB_Password.Text + ";database=" + this.txtDB_Name.Text + "; character set=utf8");
          _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
          string sText1 = "MySQL: Connect...";
          fn1.TXT(ref sText1);
          mySqlConnection.Open();
          _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
          string sText2 = "MySQL: Connected - OK";
          fn2.TXT(ref sText2);
          MySqlCommand mySqlCommand = new MySqlCommand();
          mySqlCommand.Connection = mySqlConnection;
          Stopwatch stopwatch = new Stopwatch();
          stopwatch.Start();
          int num2 = 0;
          DateAndTime.Now.ToString();
          int num3 = checked ((int) Math.Round(Conversion.Val(this.txtMailRU.Text)));
          if (num3 > 0)
          {
            mySqlCommand.CommandText = "SELECT * FROM `" + text1 + "` WHERE `domain`='mail.ru' AND `saleid`=0 LIMIT " + Conversions.ToString(num3) + ";";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            num2 = 0;
            while (mySqlDataReader.Read())
            {
              checked { ++num2; }
              checked { ++index1; }
              _VARIABLES.MailInfo[index1].ID = Conversions.ToInteger(mySqlDataReader.GetValue(0));
              _VARIABLES.MailInfo[index1].login = Conversions.ToString(mySqlDataReader.GetValue(1));
              _VARIABLES.MailInfo[index1].domain = Conversions.ToString(mySqlDataReader.GetValue(2));
              _VARIABLES.MailInfo[index1].password = Conversions.ToString(mySqlDataReader.GetValue(3));
              _VARIABLES.MailInfo[index1].Registered = Conversions.ToShort(mySqlDataReader.GetValue(4));
              _VARIABLES.MailInfo[index1].RegUserData.Name = Conversions.ToString(mySqlDataReader.GetValue(5));
              _VARIABLES.MailInfo[index1].RegUserData.LastName = Conversions.ToString(mySqlDataReader.GetValue(6));
              _VARIABLES.MailInfo[index1].RegUserData.City = Conversions.ToString(mySqlDataReader.GetValue(7));
              _VARIABLES.MailInfo[index1].RegUserData.BirthDay = Conversions.ToString(mySqlDataReader.GetValue(8));
              _VARIABLES.MailInfo[index1].RegUserData.BirthMonth = Conversions.ToString(mySqlDataReader.GetValue(9));
              _VARIABLES.MailInfo[index1].RegUserData.BirthYear = Conversions.ToString(mySqlDataReader.GetValue(10));
              _VARIABLES.MailInfo[index1].RegUserData.SecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(11));
              _VARIABLES.MailInfo[index1].RegUserData.SecretAnswer = Conversions.ToString(mySqlDataReader.GetValue(12));
              _VARIABLES.MailInfo[index1].RegUserData.ItsSecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(13));
              _VARIABLES.MailInfo[index1].RegUserData.Sex = Conversions.ToShort(mySqlDataReader.GetValue(14));
              _VARIABLES.MailInfo[index1].MailAmount = Conversions.ToInteger(mySqlDataReader.GetValue(15));
              _VARIABLES.MailInfo[index1].DataCreateBox = Conversions.ToString(mySqlDataReader.GetValue(16));
              _VARIABLES.MailInfo[index1].comment = Conversions.ToString(mySqlDataReader.GetValue(17));
              _VARIABLES.MailInfo[index1].DomainID = Conversions.ToShort(mySqlDataReader.GetValue(18));
            }
            mySqlDataReader.Close();
          }
          int num4 = checked (index1 - num2 + 1);
          int num5 = index1;
          int index2 = num4;
          while (index2 <= num5)
          {
            mySqlCommand.CommandText = "DELETE FROM `" + text1 + "` WHERE `ID`=" + Conversions.ToString(_VARIABLES.MailInfo[index2].ID) + " LIMIT 1;";
            mySqlCommand.ExecuteNonQuery();
            checked { ++index2; }
          }
          _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
          string sText3 = "MySQL: [MAIL.RU] Download " + Conversions.ToString(num2) + " accounts";
          fn3.TXT(ref sText3);
          int num6 = checked ((int) Math.Round(Conversion.Val(this.txtInboxRU.Text)));
          if (num6 > 0)
          {
            mySqlCommand.CommandText = "SELECT * FROM `" + text1 + "` WHERE `domain`='inbox.ru' AND `saleid`=0 LIMIT " + Conversions.ToString(num6) + ";";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            num2 = 0;
            while (mySqlDataReader.Read())
            {
              checked { ++num2; }
              checked { ++index1; }
              _VARIABLES.MailInfo[index1].ID = Conversions.ToInteger(mySqlDataReader.GetValue(0));
              _VARIABLES.MailInfo[index1].login = Conversions.ToString(mySqlDataReader.GetValue(1));
              _VARIABLES.MailInfo[index1].domain = Conversions.ToString(mySqlDataReader.GetValue(2));
              _VARIABLES.MailInfo[index1].password = Conversions.ToString(mySqlDataReader.GetValue(3));
              _VARIABLES.MailInfo[index1].Registered = Conversions.ToShort(mySqlDataReader.GetValue(4));
              _VARIABLES.MailInfo[index1].RegUserData.Name = Conversions.ToString(mySqlDataReader.GetValue(5));
              _VARIABLES.MailInfo[index1].RegUserData.LastName = Conversions.ToString(mySqlDataReader.GetValue(6));
              _VARIABLES.MailInfo[index1].RegUserData.City = Conversions.ToString(mySqlDataReader.GetValue(7));
              _VARIABLES.MailInfo[index1].RegUserData.BirthDay = Conversions.ToString(mySqlDataReader.GetValue(8));
              _VARIABLES.MailInfo[index1].RegUserData.BirthMonth = Conversions.ToString(mySqlDataReader.GetValue(9));
              _VARIABLES.MailInfo[index1].RegUserData.BirthYear = Conversions.ToString(mySqlDataReader.GetValue(10));
              _VARIABLES.MailInfo[index1].RegUserData.SecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(11));
              _VARIABLES.MailInfo[index1].RegUserData.SecretAnswer = Conversions.ToString(mySqlDataReader.GetValue(12));
              _VARIABLES.MailInfo[index1].RegUserData.ItsSecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(13));
              _VARIABLES.MailInfo[index1].RegUserData.Sex = Conversions.ToShort(mySqlDataReader.GetValue(14));
              _VARIABLES.MailInfo[index1].MailAmount = Conversions.ToInteger(mySqlDataReader.GetValue(15));
              _VARIABLES.MailInfo[index1].DataCreateBox = Conversions.ToString(mySqlDataReader.GetValue(16));
              _VARIABLES.MailInfo[index1].comment = Conversions.ToString(mySqlDataReader.GetValue(17));
              _VARIABLES.MailInfo[index1].DomainID = Conversions.ToShort(mySqlDataReader.GetValue(18));
            }
            mySqlDataReader.Close();
          }
          int num7 = checked (index1 - num2 + 1);
          int num8 = index1;
          int index3 = num7;
          while (index3 <= num8)
          {
            mySqlCommand.CommandText = "DELETE FROM `" + text1 + "` WHERE `ID`=" + Conversions.ToString(_VARIABLES.MailInfo[index3].ID) + " LIMIT 1;";
            mySqlCommand.ExecuteNonQuery();
            checked { ++index3; }
          }
          _FUNCTION.clsTXT fn4 = _FUNCTION.FN;
          string sText4 = "MySQL: [INBOX.RU] Download " + Conversions.ToString(num2) + " accounts";
          fn4.TXT(ref sText4);
          int num9 = checked ((int) Math.Round(Conversion.Val(this.txtListRU.Text)));
          if (num9 > 0)
          {
            mySqlCommand.CommandText = "SELECT * FROM `" + text1 + "` WHERE `domain`='list.ru' AND `saleid`=0 LIMIT " + Conversions.ToString(num9) + ";";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            num2 = 0;
            while (mySqlDataReader.Read())
            {
              checked { ++num2; }
              checked { ++index1; }
              _VARIABLES.MailInfo[index1].ID = Conversions.ToInteger(mySqlDataReader.GetValue(0));
              _VARIABLES.MailInfo[index1].login = Conversions.ToString(mySqlDataReader.GetValue(1));
              _VARIABLES.MailInfo[index1].domain = Conversions.ToString(mySqlDataReader.GetValue(2));
              _VARIABLES.MailInfo[index1].password = Conversions.ToString(mySqlDataReader.GetValue(3));
              _VARIABLES.MailInfo[index1].Registered = Conversions.ToShort(mySqlDataReader.GetValue(4));
              _VARIABLES.MailInfo[index1].RegUserData.Name = Conversions.ToString(mySqlDataReader.GetValue(5));
              _VARIABLES.MailInfo[index1].RegUserData.LastName = Conversions.ToString(mySqlDataReader.GetValue(6));
              _VARIABLES.MailInfo[index1].RegUserData.City = Conversions.ToString(mySqlDataReader.GetValue(7));
              _VARIABLES.MailInfo[index1].RegUserData.BirthDay = Conversions.ToString(mySqlDataReader.GetValue(8));
              _VARIABLES.MailInfo[index1].RegUserData.BirthMonth = Conversions.ToString(mySqlDataReader.GetValue(9));
              _VARIABLES.MailInfo[index1].RegUserData.BirthYear = Conversions.ToString(mySqlDataReader.GetValue(10));
              _VARIABLES.MailInfo[index1].RegUserData.SecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(11));
              _VARIABLES.MailInfo[index1].RegUserData.SecretAnswer = Conversions.ToString(mySqlDataReader.GetValue(12));
              _VARIABLES.MailInfo[index1].RegUserData.ItsSecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(13));
              _VARIABLES.MailInfo[index1].RegUserData.Sex = Conversions.ToShort(mySqlDataReader.GetValue(14));
              _VARIABLES.MailInfo[index1].MailAmount = Conversions.ToInteger(mySqlDataReader.GetValue(15));
              _VARIABLES.MailInfo[index1].DataCreateBox = Conversions.ToString(mySqlDataReader.GetValue(16));
              _VARIABLES.MailInfo[index1].comment = Conversions.ToString(mySqlDataReader.GetValue(17));
              _VARIABLES.MailInfo[index1].DomainID = Conversions.ToShort(mySqlDataReader.GetValue(18));
            }
            mySqlDataReader.Close();
          }
          int num10 = checked (index1 - num2 + 1);
          int num11 = index1;
          int index4 = num10;
          while (index4 <= num11)
          {
            mySqlCommand.CommandText = "DELETE FROM `" + text1 + "` WHERE `ID`=" + Conversions.ToString(_VARIABLES.MailInfo[index4].ID) + " LIMIT 1;";
            mySqlCommand.ExecuteNonQuery();
            checked { ++index4; }
          }
          _FUNCTION.clsTXT fn5 = _FUNCTION.FN;
          string sText5 = "MySQL: [LIST.RU] Download " + Conversions.ToString(num2) + " accounts";
          fn5.TXT(ref sText5);
          int num12 = checked ((int) Math.Round(Conversion.Val(this.txtBkRU.Text)));
          if (num12 > 0)
          {
            mySqlCommand.CommandText = "SELECT * FROM `" + text1 + "` WHERE `domain`='bk.ru' AND `saleid`=0 LIMIT " + Conversions.ToString(num12) + ";";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            num2 = 0;
            while (mySqlDataReader.Read())
            {
              checked { ++num2; }
              checked { ++index1; }
              _VARIABLES.MailInfo[index1].ID = Conversions.ToInteger(mySqlDataReader.GetValue(0));
              _VARIABLES.MailInfo[index1].login = Conversions.ToString(mySqlDataReader.GetValue(1));
              _VARIABLES.MailInfo[index1].domain = Conversions.ToString(mySqlDataReader.GetValue(2));
              _VARIABLES.MailInfo[index1].password = Conversions.ToString(mySqlDataReader.GetValue(3));
              _VARIABLES.MailInfo[index1].Registered = Conversions.ToShort(mySqlDataReader.GetValue(4));
              _VARIABLES.MailInfo[index1].RegUserData.Name = Conversions.ToString(mySqlDataReader.GetValue(5));
              _VARIABLES.MailInfo[index1].RegUserData.LastName = Conversions.ToString(mySqlDataReader.GetValue(6));
              _VARIABLES.MailInfo[index1].RegUserData.City = Conversions.ToString(mySqlDataReader.GetValue(7));
              _VARIABLES.MailInfo[index1].RegUserData.BirthDay = Conversions.ToString(mySqlDataReader.GetValue(8));
              _VARIABLES.MailInfo[index1].RegUserData.BirthMonth = Conversions.ToString(mySqlDataReader.GetValue(9));
              _VARIABLES.MailInfo[index1].RegUserData.BirthYear = Conversions.ToString(mySqlDataReader.GetValue(10));
              _VARIABLES.MailInfo[index1].RegUserData.SecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(11));
              _VARIABLES.MailInfo[index1].RegUserData.SecretAnswer = Conversions.ToString(mySqlDataReader.GetValue(12));
              _VARIABLES.MailInfo[index1].RegUserData.ItsSecretQuestion = Conversions.ToString(mySqlDataReader.GetValue(13));
              _VARIABLES.MailInfo[index1].RegUserData.Sex = Conversions.ToShort(mySqlDataReader.GetValue(14));
              _VARIABLES.MailInfo[index1].MailAmount = Conversions.ToInteger(mySqlDataReader.GetValue(15));
              _VARIABLES.MailInfo[index1].DataCreateBox = Conversions.ToString(mySqlDataReader.GetValue(16));
              _VARIABLES.MailInfo[index1].comment = Conversions.ToString(mySqlDataReader.GetValue(17));
              _VARIABLES.MailInfo[index1].DomainID = Conversions.ToShort(mySqlDataReader.GetValue(18));
            }
            mySqlDataReader.Close();
          }
          int num13 = checked (index1 - num2 + 1);
          int num14 = index1;
          int index5 = num13;
          while (index5 <= num14)
          {
            mySqlCommand.CommandText = "DELETE FROM `" + text1 + "` WHERE `ID`=" + Conversions.ToString(_VARIABLES.MailInfo[index5].ID) + " LIMIT 1;";
            mySqlCommand.ExecuteNonQuery();
            checked { ++index5; }
          }
          _FUNCTION.clsTXT fn6 = _FUNCTION.FN;
          string sText6 = "MySQL: [BK.RU] Download " + Conversions.ToString(num2) + " accounts";
          fn6.TXT(ref sText6);
          mySqlCommand.CommandText = "SELECT domain, COUNT(*) FROM " + text1 + " WHERE `SaleID`='0' GROUP BY domain;";
          this.lblMailRU_Count.Text = Conversions.ToString(0);
          this.lblInboxRU_Count.Text = Conversions.ToString(0);
          this.lblListRU_Count.Text = Conversions.ToString(0);
          this.lblBkRU_Count.Text = Conversions.ToString(0);
          MySqlDataReader mySqlDataReader1 = mySqlCommand.ExecuteReader();
          int num15 = 0;
          while (mySqlDataReader1.Read())
          {
            string str = Conversions.ToString(mySqlDataReader1.GetValue(0));
            int integer = Conversions.ToInteger(mySqlDataReader1.GetValue(1));
            string Left = str;
            if (Operators.CompareString(Left, "mail.ru", false) == 0)
              this.lblMailRU_Count.Text = Conversions.ToString(integer);
            else if (Operators.CompareString(Left, "inbox.ru", false) == 0)
              this.lblInboxRU_Count.Text = Conversions.ToString(integer);
            else if (Operators.CompareString(Left, "list.ru", false) == 0)
              this.lblListRU_Count.Text = Conversions.ToString(integer);
            else if (Operators.CompareString(Left, "bk.ru", false) == 0)
              this.lblBkRU_Count.Text = Conversions.ToString(integer);
            checked { num15 += integer; }
          }
          mySqlDataReader1.Close();
          this.lblItogo.Text = Conversions.ToString(num15);
          mySqlCommand.CommandText = "SELECT COUNT(*) FROM " + text1 + " WHERE `SaleID`='1';";
          int integer1 = Conversions.ToInteger(mySqlCommand.ExecuteScalar());
          mySqlCommand.CommandText = "SELECT COUNT(*) FROM " + text2 + " WHERE `SaleID`='1';";
          this.lblSale.Text = Conversions.ToString(Conversions.ToInteger(Operators.AddObject((object) integer1, mySqlCommand.ExecuteScalar())));
          mySqlConnection.Close();
          stopwatch.Stop();
          if (Information.UBound((Array) _VARIABLES.MailInfo, 1) != index1)
            _VARIABLES.MailInfo = (_VARIABLES.meMailInfo[]) Utils.CopyArray((Array) _VARIABLES.MailInfo, (Array) new _VARIABLES.meMailInfo[checked (index1 + 1)]);
          _LV.LV_ADD_ALL();
          _LOADSAVE.SaveALL_MailInfo();
          _FUNCTION.clsTXT fn7 = _FUNCTION.FN;
          string sText7 = "MySQL: All Download - OK [" + Conversions.ToString(stopwatch.ElapsedMilliseconds) + "ms]";
          fn7.TXT(ref sText7);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ex MySQL Download: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }
  }
}
