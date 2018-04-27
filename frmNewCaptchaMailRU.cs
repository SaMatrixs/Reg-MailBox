// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.frmNewCaptchaMailRU
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [DesignerGenerated]
  public class frmNewCaptchaMailRU : Form
  {
    private IContainer components;
    [AccessedThroughProperty("picVOTE_CAPTCHA_0")]
    private PictureBox _picVOTE_CAPTCHA_0;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    public frmNewCaptchaMailRU()
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
      this.picVOTE_CAPTCHA_0 = new PictureBox();
      this.Label1 = new Label();
      ((ISupportInitialize) this.picVOTE_CAPTCHA_0).BeginInit();
      this.SuspendLayout();
      this.picVOTE_CAPTCHA_0.BackColor = Color.FromArgb(0, 64, 0);
      this.picVOTE_CAPTCHA_0.BorderStyle = BorderStyle.FixedSingle;
      PictureBox picVoteCaptcha0_1 = this.picVOTE_CAPTCHA_0;
      Point point1 = new Point(2, 0);
      Point point2 = point1;
      picVoteCaptcha0_1.Location = point2;
      this.picVOTE_CAPTCHA_0.Name = "picVOTE_CAPTCHA_0";
      PictureBox picVoteCaptcha0_2 = this.picVOTE_CAPTCHA_0;
      Size size1 = new Size(300, 100);
      Size size2 = size1;
      picVoteCaptcha0_2.Size = size2;
      this.picVOTE_CAPTCHA_0.TabIndex = 88;
      this.picVOTE_CAPTCHA_0.TabStop = false;
      Label label1_1 = this.Label1;
      point1 = new Point(12, 103);
      Point point3 = point1;
      label1_1.Location = point3;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(274, 18);
      Size size3 = size1;
      label1_2.Size = size3;
      this.Label1.TabIndex = 89;
      this.Label1.Text = "Новая альтернативная капча MAIL.RU";
      this.Label1.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(303, 125);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.picVOTE_CAPTCHA_0);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.Name = nameof (frmNewCaptchaMailRU);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Mail.ru New Captcha";
      this.TopMost = true;
      ((ISupportInitialize) this.picVOTE_CAPTCHA_0).EndInit();
      this.ResumeLayout(false);
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
  }
}
