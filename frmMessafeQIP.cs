// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.frmMessafeQIP
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [DesignerGenerated]
  public class frmMessafeQIP : Form
  {
    private IContainer components;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("lblMessage")]
    private Label _lblMessage;
    [AccessedThroughProperty("txtMessage")]
    private TextBox _txtMessage;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("txtCode")]
    private TextBox _txtCode;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    private int CheckCode;

    public frmMessafeQIP()
    {
      this.FormClosing += new FormClosingEventHandler(this.frmMessafeQIP_FormClosing);
      this.Load += new EventHandler(this.frmMessafeQIP_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMessafeQIP));
      this.PictureBox1 = new PictureBox();
      this.lblMessage = new Label();
      this.txtMessage = new TextBox();
      this.Label1 = new Label();
      this.txtCode = new TextBox();
      this.btnOK = new Button();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = this.PictureBox1;
      Point point1 = new Point(2, 3);
      Point point2 = point1;
      pictureBox1_1.Location = point2;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      Size size1 = new Size(48, 48);
      Size size2 = size1;
      pictureBox1_2.Size = size2;
      this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      this.PictureBox1.TabIndex = 0;
      this.PictureBox1.TabStop = false;
      this.lblMessage.AutoSize = true;
      this.lblMessage.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lblMessage.ForeColor = Color.Red;
      Label lblMessage1 = this.lblMessage;
      point1 = new Point(56, 9);
      Point point3 = point1;
      lblMessage1.Location = point3;
      this.lblMessage.Name = "lblMessage";
      Label lblMessage2 = this.lblMessage;
      size1 = new Size(278, 24);
      Size size3 = size1;
      lblMessage2.Size = size3;
      this.lblMessage.TabIndex = 1;
      this.lblMessage.Text = "Обязательно к прочтению!";
      this.txtMessage.BackColor = Color.WhiteSmoke;
      this.txtMessage.BorderStyle = BorderStyle.None;
      this.txtMessage.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtMessage1 = this.txtMessage;
      point1 = new Point(60, 36);
      Point point4 = point1;
      txtMessage1.Location = point4;
      this.txtMessage.Multiline = true;
      this.txtMessage.Name = "txtMessage";
      TextBox txtMessage2 = this.txtMessage;
      size1 = new Size(641, 188);
      Size size4 = size1;
      txtMessage2.Size = size4;
      this.txtMessage.TabIndex = 2;
      this.txtMessage.TabStop = false;
      this.txtMessage.Text = componentResourceManager.GetString("txtMessage.Text");
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(80, 227);
      Point point5 = point1;
      label1_1.Location = point5;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(463, 13);
      Size size5 = size1;
      label1_2.Size = size5;
      this.Label1.TabIndex = 3;
      this.Label1.Text = "Ввод кода означает, что Вы внимательно прочитали и до Вас дошел смысл написанного.";
      this.txtCode.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.txtCode.BorderStyle = BorderStyle.FixedSingle;
      this.txtCode.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox txtCode1 = this.txtCode;
      point1 = new Point(540, 220);
      Point point6 = point1;
      txtCode1.Location = point6;
      this.txtCode.Name = "txtCode";
      TextBox txtCode2 = this.txtCode;
      size1 = new Size(100, 27);
      Size size6 = size1;
      txtCode2.Size = size6;
      this.txtCode.TabIndex = 4;
      this.txtCode.TextAlign = HorizontalAlignment.Center;
      this.btnOK.BackColor = Color.FromArgb(224, 224, 224);
      this.btnOK.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.btnOK.ForeColor = Color.Black;
      this.btnOK.Image = (Image) componentResourceManager.GetObject("btnOK.Image");
      Button btnOk1 = this.btnOK;
      point1 = new Point(646, 215);
      Point point7 = point1;
      btnOk1.Location = point7;
      this.btnOK.Name = "btnOK";
      Button btnOk2 = this.btnOK;
      size1 = new Size(55, 36);
      Size size7 = size1;
      btnOk2.Size = size7;
      this.btnOK.TabIndex = 123;
      this.btnOK.TabStop = false;
      this.btnOK.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.WhiteSmoke;
      size1 = new Size(706, 260);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.txtCode);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.txtMessage);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.PictureBox1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (frmMessafeQIP);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Сообщение!";
      this.TopMost = true;
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
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

    internal virtual Label lblMessage
    {
      get
      {
        return this._lblMessage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblMessage = value;
      }
    }

    internal virtual TextBox txtMessage
    {
      get
      {
        return this._txtMessage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtMessage = value;
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

    internal virtual TextBox txtCode
    {
      get
      {
        return this._txtCode;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtCode_TextChanged);
        if (this._txtCode != null)
          this._txtCode.TextChanged -= eventHandler;
        this._txtCode = value;
        if (this._txtCode == null)
          return;
        this._txtCode.TextChanged += eventHandler;
      }
    }

    internal virtual Button btnOK
    {
      get
      {
        return this._btnOK;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnOK_Click);
        if (this._btnOK != null)
          this._btnOK.Click -= eventHandler;
        this._btnOK = value;
        if (this._btnOK == null)
          return;
        this._btnOK.Click += eventHandler;
      }
    }

    private void frmMessafeQIP_FormClosing(object sender, FormClosingEventArgs e)
    {
      MyProject.Forms.frmGenBlank.rbSelectMail_0.Checked = true;
    }

    private void frmMessafeQIP_Load(object sender, EventArgs e)
    {
      this.CheckCode = _FUNCTION.sRND.Next(111, 999);
      this.txtMessage.AppendText(Conversions.ToString(this.CheckCode));
    }

    private void txtCode_TextChanged(object sender, EventArgs e)
    {
      if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, (Type) null, "text", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) Conversions.ToString(this.CheckCode), false))
        this.txtCode.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      else
        this.txtCode.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      if (this.txtCode.Text.Length == 0)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Вы отказались от использования регистрации на сервисе QIP.RU";
        fn.TXT(ref sText);
        MyProject.Forms.frmGenBlank.rbSelectMail_0.Checked = true;
        this.Hide();
      }
      else
      {
        if (Operators.CompareString(this.txtCode.Text, Conversions.ToString(this.CheckCode), false) != 0)
        {
          MyProject.Forms.frmGenBlank.rbSelectMail_0.Checked = true;
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Неправильный код. Прочтите внимательно сообщение.";
          fn.TXT(ref sText);
        }
        else
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Функция регистрации на сервисе QIP.RU разблокирована.";
          fn.TXT(ref sText);
          _INI.SaveINI("qip.ru", "ub", "1");
        }
        this.txtCode.Text = string.Empty;
        this.Hide();
      }
    }
  }
}
