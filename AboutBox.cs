// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.AboutBox
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
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
  public sealed class AboutBox : Form
  {
    [AccessedThroughProperty("TableLayoutPanel")]
    private TableLayoutPanel _TableLayoutPanel;
    [AccessedThroughProperty("LogoPictureBox")]
    private PictureBox _LogoPictureBox;
    [AccessedThroughProperty("LabelProductName")]
    private Label _LabelProductName;
    [AccessedThroughProperty("LabelVersion")]
    private Label _LabelVersion;
    [AccessedThroughProperty("LabelCompanyName")]
    private Label _LabelCompanyName;
    [AccessedThroughProperty("TextBoxDescription")]
    private TextBox _TextBoxDescription;
    [AccessedThroughProperty("OKButton")]
    private Button _OKButton;
    [AccessedThroughProperty("LabelCopyright")]
    private Label _LabelCopyright;
    private IContainer components;

    public AboutBox()
    {
      this.Load += new EventHandler(this.AboutBox1_Load);
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

    internal virtual TableLayoutPanel TableLayoutPanel
    {
      get
      {
        return this._TableLayoutPanel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TableLayoutPanel = value;
      }
    }

    internal virtual PictureBox LogoPictureBox
    {
      get
      {
        return this._LogoPictureBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._LogoPictureBox = value;
      }
    }

    internal virtual Label LabelProductName
    {
      get
      {
        return this._LabelProductName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._LabelProductName = value;
      }
    }

    internal virtual Label LabelVersion
    {
      get
      {
        return this._LabelVersion;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._LabelVersion = value;
      }
    }

    internal virtual Label LabelCompanyName
    {
      get
      {
        return this._LabelCompanyName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._LabelCompanyName = value;
      }
    }

    internal virtual TextBox TextBoxDescription
    {
      get
      {
        return this._TextBoxDescription;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBoxDescription = value;
      }
    }

    internal virtual Button OKButton
    {
      get
      {
        return this._OKButton;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OKButton_Click);
        if (this._OKButton != null)
          this._OKButton.Click -= eventHandler;
        this._OKButton = value;
        if (this._OKButton == null)
          return;
        this._OKButton.Click += eventHandler;
      }
    }

    internal virtual Label LabelCopyright
    {
      get
      {
        return this._LabelCopyright;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._LabelCopyright = value;
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AboutBox));
      this.TableLayoutPanel = new TableLayoutPanel();
      this.LogoPictureBox = new PictureBox();
      this.LabelProductName = new Label();
      this.LabelVersion = new Label();
      this.LabelCopyright = new Label();
      this.LabelCompanyName = new Label();
      this.TextBoxDescription = new TextBox();
      this.OKButton = new Button();
      this.TableLayoutPanel.SuspendLayout();
      ((ISupportInitialize) this.LogoPictureBox).BeginInit();
      this.SuspendLayout();
      this.TableLayoutPanel.ColumnCount = 2;
      this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33f));
      this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67f));
      this.TableLayoutPanel.Controls.Add((Control) this.LogoPictureBox, 0, 0);
      this.TableLayoutPanel.Controls.Add((Control) this.LabelProductName, 1, 0);
      this.TableLayoutPanel.Controls.Add((Control) this.LabelVersion, 1, 1);
      this.TableLayoutPanel.Controls.Add((Control) this.LabelCopyright, 1, 2);
      this.TableLayoutPanel.Controls.Add((Control) this.LabelCompanyName, 1, 3);
      this.TableLayoutPanel.Controls.Add((Control) this.TextBoxDescription, 1, 4);
      this.TableLayoutPanel.Controls.Add((Control) this.OKButton, 1, 5);
      this.TableLayoutPanel.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanel1 = this.TableLayoutPanel;
      Point point1 = new Point(9, 9);
      Point point2 = point1;
      tableLayoutPanel1.Location = point2;
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 6;
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
      TableLayoutPanel tableLayoutPanel2 = this.TableLayoutPanel;
      Size size1 = new Size(396, 258);
      Size size2 = size1;
      tableLayoutPanel2.Size = size2;
      this.TableLayoutPanel.TabIndex = 0;
      this.LogoPictureBox.Dock = DockStyle.Fill;
      this.LogoPictureBox.Image = (Image) componentResourceManager.GetObject("LogoPictureBox.Image");
      PictureBox logoPictureBox1 = this.LogoPictureBox;
      point1 = new Point(3, 3);
      Point point3 = point1;
      logoPictureBox1.Location = point3;
      this.LogoPictureBox.Name = "LogoPictureBox";
      this.TableLayoutPanel.SetRowSpan((Control) this.LogoPictureBox, 6);
      PictureBox logoPictureBox2 = this.LogoPictureBox;
      size1 = new Size(124, 252);
      Size size3 = size1;
      logoPictureBox2.Size = size3;
      this.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
      this.LogoPictureBox.TabIndex = 0;
      this.LogoPictureBox.TabStop = false;
      this.LabelProductName.Dock = DockStyle.Fill;
      Label labelProductName1 = this.LabelProductName;
      point1 = new Point(136, 0);
      Point point4 = point1;
      labelProductName1.Location = point4;
      Label labelProductName2 = this.LabelProductName;
      Padding padding1 = new Padding(6, 0, 3, 0);
      Padding padding2 = padding1;
      labelProductName2.Margin = padding2;
      Label labelProductName3 = this.LabelProductName;
      size1 = new Size(0, 17);
      Size size4 = size1;
      labelProductName3.MaximumSize = size4;
      this.LabelProductName.Name = "LabelProductName";
      Label labelProductName4 = this.LabelProductName;
      size1 = new Size(257, 17);
      Size size5 = size1;
      labelProductName4.Size = size5;
      this.LabelProductName.TabIndex = 0;
      this.LabelProductName.Text = "Имя продукта";
      this.LabelProductName.TextAlign = ContentAlignment.MiddleLeft;
      this.LabelVersion.Dock = DockStyle.Fill;
      Label labelVersion1 = this.LabelVersion;
      point1 = new Point(136, 25);
      Point point5 = point1;
      labelVersion1.Location = point5;
      Label labelVersion2 = this.LabelVersion;
      padding1 = new Padding(6, 0, 3, 0);
      Padding padding3 = padding1;
      labelVersion2.Margin = padding3;
      Label labelVersion3 = this.LabelVersion;
      size1 = new Size(0, 17);
      Size size6 = size1;
      labelVersion3.MaximumSize = size6;
      this.LabelVersion.Name = "LabelVersion";
      Label labelVersion4 = this.LabelVersion;
      size1 = new Size(257, 17);
      Size size7 = size1;
      labelVersion4.Size = size7;
      this.LabelVersion.TabIndex = 0;
      this.LabelVersion.Text = "Версия";
      this.LabelVersion.TextAlign = ContentAlignment.MiddleLeft;
      this.LabelCopyright.Dock = DockStyle.Fill;
      Label labelCopyright1 = this.LabelCopyright;
      point1 = new Point(136, 50);
      Point point6 = point1;
      labelCopyright1.Location = point6;
      Label labelCopyright2 = this.LabelCopyright;
      padding1 = new Padding(6, 0, 3, 0);
      Padding padding4 = padding1;
      labelCopyright2.Margin = padding4;
      Label labelCopyright3 = this.LabelCopyright;
      size1 = new Size(0, 17);
      Size size8 = size1;
      labelCopyright3.MaximumSize = size8;
      this.LabelCopyright.Name = "LabelCopyright";
      Label labelCopyright4 = this.LabelCopyright;
      size1 = new Size(257, 17);
      Size size9 = size1;
      labelCopyright4.Size = size9;
      this.LabelCopyright.TabIndex = 0;
      this.LabelCopyright.Text = "Авторские права";
      this.LabelCopyright.TextAlign = ContentAlignment.MiddleLeft;
      this.LabelCompanyName.Dock = DockStyle.Fill;
      Label labelCompanyName1 = this.LabelCompanyName;
      point1 = new Point(136, 75);
      Point point7 = point1;
      labelCompanyName1.Location = point7;
      Label labelCompanyName2 = this.LabelCompanyName;
      padding1 = new Padding(6, 0, 3, 0);
      Padding padding5 = padding1;
      labelCompanyName2.Margin = padding5;
      Label labelCompanyName3 = this.LabelCompanyName;
      size1 = new Size(0, 17);
      Size size10 = size1;
      labelCompanyName3.MaximumSize = size10;
      this.LabelCompanyName.Name = "LabelCompanyName";
      Label labelCompanyName4 = this.LabelCompanyName;
      size1 = new Size(257, 17);
      Size size11 = size1;
      labelCompanyName4.Size = size11;
      this.LabelCompanyName.TabIndex = 0;
      this.LabelCompanyName.Text = "Название организации";
      this.LabelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
      this.TextBoxDescription.Dock = DockStyle.Fill;
      TextBox textBoxDescription1 = this.TextBoxDescription;
      point1 = new Point(136, 103);
      Point point8 = point1;
      textBoxDescription1.Location = point8;
      TextBox textBoxDescription2 = this.TextBoxDescription;
      padding1 = new Padding(6, 3, 3, 3);
      Padding padding6 = padding1;
      textBoxDescription2.Margin = padding6;
      this.TextBoxDescription.Multiline = true;
      this.TextBoxDescription.Name = "TextBoxDescription";
      this.TextBoxDescription.ReadOnly = true;
      this.TextBoxDescription.ScrollBars = ScrollBars.Both;
      TextBox textBoxDescription3 = this.TextBoxDescription;
      size1 = new Size(257, 123);
      Size size12 = size1;
      textBoxDescription3.Size = size12;
      this.TextBoxDescription.TabIndex = 0;
      this.TextBoxDescription.TabStop = false;
      this.TextBoxDescription.Text = "Описание:\r\n\r\n(Во время выполнения текст подписи будет заменен информацией о сборке приложения.\r\nНастроить эту информацию можно в области ";
      this.OKButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.OKButton.DialogResult = DialogResult.Cancel;
      Button okButton1 = this.OKButton;
      point1 = new Point(318, 232);
      Point point9 = point1;
      okButton1.Location = point9;
      this.OKButton.Name = "OKButton";
      Button okButton2 = this.OKButton;
      size1 = new Size(75, 23);
      Size size13 = size1;
      okButton2.Size = size13;
      this.OKButton.TabIndex = 0;
      this.OKButton.Text = "&ОК";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.OKButton;
      size1 = new Size(414, 276);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.TableLayoutPanel);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (AboutBox);
      padding1 = new Padding(9);
      this.Padding = padding1;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "О программе MailBox@Reg";
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      ((ISupportInitialize) this.LogoPictureBox).EndInit();
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void AboutBox1_Load(object sender, EventArgs e)
    {
      this.Text = string.Format("О программе {0}", Operators.CompareString(MyProject.Application.Info.Title, "", false) == 0 ? (object) Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName) : (object) MyProject.Application.Info.Title);
      this.LabelProductName.Text = MyProject.Application.Info.ProductName;
      this.LabelVersion.Text = string.Format("Версия {0}", (object) MyProject.Application.Info.Version.ToString());
      this.LabelCopyright.Text = MyProject.Application.Info.Copyright;
      this.LabelCompanyName.Text = MyProject.Application.Info.CompanyName;
      this.TextBoxDescription.Text = MyProject.Application.Info.Description + "\r\nMailBox@Reg создан при финансовой поддержке www.L2-RU.COM\r\n  Контактная информация:\r\n     support@unicore.su\r\n     bugreport@l2-ru.com\r\n     administrator@l2-ru.com\r\n     tech@l2-ru.com";
    }

    private void OKButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
