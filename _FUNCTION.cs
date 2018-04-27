// Decompiled with JetBrains decompiler
// Type: MailRegUnicore._FUNCTION
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class _FUNCTION
  {
    private static DateTime const_Date1970 = Conversions.ToDate("01.01.1970 0:00:00");
    public static Random sRND = new Random();
    public static bool Locked = false;
    [SpecialName]
    private static StaticLocalInitFlag \u0024STATIC\u0024SpeedTest\u00240182\u0024sSpeedTestCounter\u0024Init = new StaticLocalInitFlag();
    [SpecialName]
    private static StaticLocalInitFlag \u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map\u0024Init = new StaticLocalInitFlag();
    [SpecialName]
    private static StaticLocalInitFlag \u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map\u0024Init = new StaticLocalInitFlag();
    public static _FUNCTION.clsTXT FN;
    public const string char_ru = "ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
    [SpecialName]
    private static bool \u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024flagTableInited;
    [SpecialName]
    private static bool \u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024flagTableInited;
    [SpecialName]
    private static int \u0024STATIC\u0024SpeedTest\u00240182\u0024sSpeedTestCounter;
    [SpecialName]
    private static string[] \u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map;
    [SpecialName]
    private static string[] \u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map;

    public static string MathRandom()
    {
      return Conversions.ToString(_FUNCTION.sRND.NextDouble()).Replace(",", ".");
    }

    public static string Get_MsCount_1970()
    {
      return Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, _FUNCTION.const_Date1970, DateTime.UtcNow, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) + string.Format("{0:d3}", (object) DateAndTime.Now.TimeOfDay.Milliseconds);
    }

    public static string TimeForRandom(short TimeZone = -4)
    {
      return Conversions.ToString(DateAndTime.DateDiff(DateInterval.Second, _VARIABLES.Time1970, DateAndTime.Now.AddHours((double) TimeZone), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) + Strings.Right("00" + Conversions.ToString(DateAndTime.Now.Millisecond), 3);
    }

    public static void LoadData()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      _LOADSAVE.LoadAll_MailInfo();
      _LOADSAVE.LoadProxy();
      _LOADSAVE.LoadName_M();
      _LOADSAVE.LoadName_J();
      _LOADSAVE.Load_BD_Mail();
      _LV.LV_ADD_ALL();
      try
      {
        frmOptions frmOptions = MyProject.Forms.frmOptions;
        frmOptions.cmbOP_1.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_Reg", "cmbOP_1"))));
        if (Operators.CompareString(_INI.LoadINI("Option_Reg", "rbOP_1").ToLower(), "true", false) == 0)
          frmOptions.rbOP_1.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_Reg", "rbOP_2").ToLower(), "true", false) == 0)
          frmOptions.rbOP_2.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_Reg", "chOP_1").ToLower(), "true", false) == 0)
          frmOptions.chOP_1.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_Reg", "chOP_2").ToLower(), "true", false) == 0)
          frmOptions.chOP_2.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_Reg", "chOP_3").ToLower(), "true", false) == 0)
          frmOptions.chOP_3.Checked = true;
        frmOptions.txtOP_1.Text = _INI.LoadINI("Option_Reg", "txtOP_1");
        frmOptions.txtOP_2.Text = _INI.LoadINI("Option_Reg", "txtOP_2");
        int num1 = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_Reg", "txtSocketTimeOut"))));
        if (num1 < 5000)
          num1 = 60000;
        frmOptions.txtSocketTimeOut.Text = Conversions.ToString(num1);
        frmOptions.cmbConnectMethod.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_Reg", "cmbConnectMethod"))));
        frmOptions.txtAutoCaptchaKEY.Text = _INI.LoadINI("Option_AC", "txtAutoCaptchaKEY");
        frmOptions.txtAutoCaptchaURL.Text = _INI.LoadINI("Option_AC", "txtAutoCaptchaURL");
        if (Operators.CompareString(_INI.LoadINI("Option_AC", "chOpAC_2").ToLower(), "true", false) == 0)
          frmOptions.chOpAC_2.Checked = true;
        string str1 = _INI.LoadINI("OptionsAntigateProg", "phrase");
        string sText;
        if (Information.IsNothing((object) str1) || Operators.CompareString(str1, string.Empty, false) == 0)
        {
          frmOptions.btnAC_Default_Click((object) null, (EventArgs) null);
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          sText = "Для АвтоКапчи установлены параметры 'Default'";
          fn.TXT(ref sText);
        }
        else
        {
          frmOptions.cmbOpAC_1.SelectedIndex = checked ((int) Math.Round(Conversion.Val(str1)));
          frmOptions.cmbOpAC_2.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionsAntigateProg", "regsense"))));
          frmOptions.cmbOpAC_3.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionsAntigateProg", "numeric"))));
          frmOptions.cmbOpAC_4.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionsAntigateProg", "calc"))));
          frmOptions.cmbOpAC_5.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionsAntigateProg", "min_len"))));
          frmOptions.cmbOpAC_6.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionsAntigateProg", "max_len"))));
          frmOptions.cmbOpAC_7.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionsAntigateProg", "is_russian"))));
          frmOptions.txtOpAC_1.Text = _INI.LoadINI("OP.OpAC", "txtOpAC_1");
          frmOptions.txtOpAC_2.Text = _INI.LoadINI("OP.OpAC", "txtOpAC_2");
          frmOptions.txtOpAC_3.Text = _INI.LoadINI("OP.OpAC", "txtOpAC_3");
          frmOptions.txtOpAC_4.Text = _INI.LoadINI("OP.OpAC", "txtOpAC_4");
          frmOptions.txtOpAC_5.Text = _INI.LoadINI("OP.OpAC", "txtOpAC_5");
          frmOptions.txtOpAC_6.Text = _INI.LoadINI("OP.OpAC", "txtOpAC_6");
          frmOptions.txtOpAC_7.Text = _INI.LoadINI("OP.OpAC", "txtOpAC_7");
        }
        string str2 = _INI.LoadINI("OptionSort", "cmbSort_1");
        if (Information.IsNothing((object) str2) || Operators.CompareString(str2, string.Empty, false) == 0)
        {
          frmOptions.btnOpSort_Default_Click((object) null, (EventArgs) null);
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          sText = "Для сортировки установлены параметры 'Default'";
          fn.TXT(ref sText);
        }
        else
        {
          frmOptions.cmbSort_1.SelectedIndex = checked ((int) Math.Round(Conversion.Val(str2)));
          frmOptions.cmbSort_2.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionSort", "cmbSort_2"))));
          frmOptions.cmbSort_3.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionSort", "cmbSort_3"))));
          frmOptions.cmbSort_4.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionSort", "cmbSort_4"))));
          frmOptions.cmbSort_5.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionSort", "cmbSort_5"))));
          frmOptions.cmbSort_6.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionSort", "cmbSort_6"))));
          frmOptions.cmbSort_7.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionSort", "cmbSort_7"))));
          frmOptions.cmbSort_8.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("OptionSort", "cmbSort_8"))));
        }
        if (Operators.CompareString(_INI.LoadINI("Option_MailDownload", "chOpMailDownload_1").ToLower(), "true", false) == 0)
          frmOptions.chOpMailDownload_1.Checked = true;
        frmOptions.cmbOpMailDownload_1.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_MailDownload", "cmbOpMailDownload_1"))));
        if (Operators.CompareString(_INI.LoadINI("Option_MailDownload", "chOpMailDownload_2").ToLower(), "true", false) == 0)
          frmOptions.chOpMailDownload_2.Checked = true;
        frmOptions.txtOPSaveList_1.Text = _INI.LoadINI("Option_SaveList", "txtOPSaveList_1");
        frmOptions.cmbOPSaveList_1.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_SaveList", "cmbOPSaveList_1"))));
        frmOptions.cmbOPSaveList_2.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_SaveList", "cmbOPSaveList_2"))));
        if (Operators.CompareString(_INI.LoadINI("Option_SaveList", "chOPSaveList_4").ToLower(), "true", false) == 0)
          frmOptions.chOPSaveList_4.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_SaveList", "chOPSaveList_1").ToLower(), "true", false) == 0)
          frmOptions.chOPSaveList_1.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_SaveList", "chOPSaveList_2").ToLower(), "true", false) == 0)
          frmOptions.chOPSaveList_2.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_SaveList", "chOPSaveList_3").ToLower(), "true", false) == 0)
          frmOptions.chOPSaveList_3.Checked = true;
        if (Operators.CompareString(Strings.LCase(_INI.LoadINI("Options", "chUseErrorCount")), "true", false) == 0)
          frmOptions.chUseErrorCount.Checked = true;
        frmOptions.txtErrorCount.Text = Conversions.ToString(Conversion.Val(_INI.LoadINI("Options", "txtErrorCount")));
        if (Operators.CompareString(_INI.LoadINI("HttpLoadProxy", "chHttpLoadProxy").ToLower(), "true", false) == 0)
          frmOptions.chHttpLoadProxy.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("HttpLoadProxy", "chHttpLoadProxy_UseRegEx").ToLower(), "true", false) == 0)
          frmOptions.chHttpLoadProxy_UseRegEx.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("HttpLoadProxy", "chHttpLoadProxy_LoadInStart").ToLower(), "true", false) == 0)
          frmOptions.chHttpLoadProxy_LoadInStart.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("HttpLoadProxy", "chHttpLoadProxy_Append").ToLower(), "true", false) == 0)
          frmOptions.chHttpLoadProxy_Append.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("HttpLoadProxy", "chAfterLoadStartOne").ToLower(), "true", false) == 0)
          frmOptions.chAfterLoadStartOne.Checked = true;
        frmOptions.txtProxy_AC.Text = _INI.LoadINI("frmOptions", "txtProxy_AC");
        int num2 = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("frmOptions", "txtIntervalConnect"))));
        if (num2 < 33)
          num2 = 33;
        frmOptions.txtIntervalConnect.Text = Conversions.ToString(num2);
        frmOptions.txtHttpLoadProxy_RegEx.Text = _INI.LoadINI("HttpLoadProxy", "txtHttpLoadProxy_RegEx");
        if (Operators.CompareString(frmOptions.txtHttpLoadProxy_RegEx.Text, "", false) == 0)
          frmOptions.txtHttpLoadProxy_RegEx.Text = "\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\:\\d{1,5}";
        _LOADSAVE.Load_HttpLoadProxy();
        if (Operators.CompareString(_INI.LoadINI("PlaySound", "chPlaySound").ToLower(), "true", false) == 0)
          frmOptions.chPlaySound.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Options.Debug", "FullDebug").ToLower(), "true", false) == 0)
          frmOptions.chdebugOp_SaveBadCaptcha.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Options.Debug", "SaveLog").ToLower(), "true", false) == 0)
          frmOptions.chSaveLog.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Options.Debug", "SaveBadIP").ToLower(), "true", false) == 0)
          frmOptions.chdebugOp_SaveBadIP.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("frmOptions", "chBannedProxy").ToLower(), "true", false) == 0)
          frmOptions.chBannedProxy.Checked = true;
        frmGenBlank frmGenBlank = MyProject.Forms.frmGenBlank;
        string Left = _INI.LoadINI("Option_Domain", "Domain");
        if (Operators.CompareString(Left, "mail.ru", false) == 0)
        {
          frmGenBlank.rbSelectMail_0.Checked = true;
          _VARIABLES.DomainSelect = 0;
        }
        else if (Operators.CompareString(Left, "qip.ru", false) == 0)
        {
          frmGenBlank.rbSelectMail_1.Checked = true;
          _VARIABLES.DomainSelect = 1;
        }
        else if (Operators.CompareString(Left, "meta.ua", false) == 0)
        {
          frmGenBlank.rbSelectMail_2.Checked = true;
          _VARIABLES.DomainSelect = 2;
        }
        else if (Operators.CompareString(Left, "km.ru", false) == 0)
        {
          frmGenBlank.rbSelectMail_3.Checked = true;
          _VARIABLES.DomainSelect = 3;
        }
        else
        {
          frmGenBlank.rbSelectMail_0.Checked = true;
          _VARIABLES.DomainSelect = 0;
        }
        frmGenBlank.txtLoadLogDIV.Text = _INI.LoadINI("Option_LoadUserLogin", "txtLoadLogDIV");
        frmGenBlank.cmbLoadLogOtherData.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_LoadUserLogin", "cmbLoadLogOtherData"))));
        string empty = string.Empty;
        if (string.IsNullOrEmpty(_INI.LoadINI("Option_LoadUserLogin", "cmbLoadData_Pole1")))
        {
          frmGenBlank.cmbLoadData_Pole1.SelectedIndex = 0;
          frmGenBlank.cmbLoadData_Pole2.SelectedIndex = 1;
          frmGenBlank.cmbLoadData_Pole3.SelectedIndex = 3;
          frmGenBlank.cmbLoadData_Pole4.SelectedIndex = 4;
          frmGenBlank.cmbLoadData_Pole5.SelectedIndex = 5;
          frmGenBlank.cmbLoadData_Pole6.SelectedIndex = 6;
          frmGenBlank.cmbLoadData_Pole7.SelectedIndex = 7;
          frmGenBlank.cmbLoadData_Pole8.SelectedIndex = 8;
          frmGenBlank.chLoadData_Pole1.Checked = true;
          frmGenBlank.chLoadData_Pole2.Checked = true;
          frmGenBlank.chLoadData_Pole3.Checked = true;
          frmGenBlank.chLoadData_Pole4.Checked = false;
          frmGenBlank.chLoadData_Pole5.Checked = false;
          frmGenBlank.chLoadData_Pole6.Checked = false;
          frmGenBlank.chLoadData_Pole7.Checked = false;
          frmGenBlank.chLoadData_Pole8.Checked = false;
        }
        else
        {
          frmGenBlank.cmbLoadData_Pole1.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_LoadUserLogin", "cmbLoadData_Pole1"))));
          frmGenBlank.cmbLoadData_Pole2.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_LoadUserLogin", "cmbLoadData_Pole2"))));
          frmGenBlank.cmbLoadData_Pole3.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_LoadUserLogin", "cmbLoadData_Pole3"))));
          frmGenBlank.cmbLoadData_Pole4.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_LoadUserLogin", "cmbLoadData_Pole4"))));
          frmGenBlank.cmbLoadData_Pole5.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_LoadUserLogin", "cmbLoadData_Pole5"))));
          frmGenBlank.cmbLoadData_Pole6.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_LoadUserLogin", "cmbLoadData_Pole6"))));
          frmGenBlank.cmbLoadData_Pole7.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_LoadUserLogin", "cmbLoadData_Pole7"))));
          frmGenBlank.cmbLoadData_Pole8.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_LoadUserLogin", "cmbLoadData_Pole8"))));
          if (Operators.CompareString(_INI.LoadINI("Option_LoadUserLogin", "chLoadData_Pole1").ToLower(), "true", false) == 0)
            frmGenBlank.chLoadData_Pole1.Checked = true;
          if (Operators.CompareString(_INI.LoadINI("Option_LoadUserLogin", "chLoadData_Pole2").ToLower(), "true", false) == 0)
            frmGenBlank.chLoadData_Pole2.Checked = true;
          if (Operators.CompareString(_INI.LoadINI("Option_LoadUserLogin", "chLoadData_Pole3").ToLower(), "true", false) == 0)
            frmGenBlank.chLoadData_Pole3.Checked = true;
          if (Operators.CompareString(_INI.LoadINI("Option_LoadUserLogin", "chLoadData_Pole4").ToLower(), "true", false) == 0)
            frmGenBlank.chLoadData_Pole4.Checked = true;
          if (Operators.CompareString(_INI.LoadINI("Option_LoadUserLogin", "chLoadData_Pole5").ToLower(), "true", false) == 0)
            frmGenBlank.chLoadData_Pole5.Checked = true;
          if (Operators.CompareString(_INI.LoadINI("Option_LoadUserLogin", "chLoadData_Pole6").ToLower(), "true", false) == 0)
            frmGenBlank.chLoadData_Pole6.Checked = true;
          if (Operators.CompareString(_INI.LoadINI("Option_LoadUserLogin", "chLoadData_Pole7").ToLower(), "true", false) == 0)
            frmGenBlank.chLoadData_Pole7.Checked = true;
          if (Operators.CompareString(_INI.LoadINI("Option_LoadUserLogin", "chLoadData_Pole8").ToLower(), "true", false) == 0)
            frmGenBlank.chLoadData_Pole8.Checked = true;
        }
        frmGenBlank.txtName.Text = _INI.LoadINI("Option_UserDataGen", "txtName");
        frmGenBlank.txtLastName.Text = _INI.LoadINI("Option_UserDataGen", "txtLastName");
        if (Operators.CompareString(_INI.LoadINI("Option_UserDataGen", "chRND_1").ToLower(), "true", false) == 0)
          frmGenBlank.chRND_1.Checked = true;
        frmGenBlank.cmbUserSex.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_UserDataGen", "cmbUserSex"))));
        if (Operators.CompareString(_INI.LoadINI("Option_UserDataGen", "chRND_2").ToLower(), "true", false) == 0)
          frmGenBlank.chRND_2.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_UserDataGen", "chRND_3").ToLower(), "true", false) == 0)
          frmGenBlank.chRND_3.Checked = true;
        frmGenBlank.cmbTown.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_UserDataGen", "cmbTown"))));
        frmGenBlank.txtTown.Text = _INI.LoadINI("Option_UserDataGen", "txtTown");
        if (Operators.CompareString(_INI.LoadINI("Option_UserDataGen", "chRND_4").ToLower(), "true", false) == 0)
          frmGenBlank.chRND_4.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_UserDataGen", "chRND_5").ToLower(), "true", false) == 0)
          frmGenBlank.chRND_5.Checked = true;
        frmGenBlank.txtUserGenPass.Text = _INI.LoadINI("Option_UserDataGen", "txtUserGenPass");
        if (Operators.CompareString(_INI.LoadINI("Option_UserDataGen", "chRND_6").ToLower(), "true", false) == 0)
          frmGenBlank.chRND_6.Checked = true;
        frmGenBlank.cmbUserDayBD.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_UserDataGen", "cmbUserDayBD"))));
        frmGenBlank.cmbUserMonthBD.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_UserDataGen", "cmbUserMonthBD"))));
        frmGenBlank.cmbUserYearBD.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_UserDataGen", "cmbUserYearBD"))));
        if (Operators.CompareString(_INI.LoadINI("Option_UserDataGen", "chRND_7").ToLower(), "true", false) == 0)
          frmGenBlank.chRND_7.Checked = true;
        frmGenBlank.cmbUserQuest.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_UserDataGen", "cmbUserQuest"))));
        if (Operators.CompareString(_INI.LoadINI("Option_UserDataGen", "chRND_8").ToLower(), "true", false) == 0)
          frmGenBlank.chRND_8.Checked = true;
        frmGenBlank.txtAnswer.Text = _INI.LoadINI("Option_UserDataGen", "txtAnswer");
        if (Operators.CompareString(_INI.LoadINI("Option_ParamGenLogin", "chMethod_1").ToLower(), "true", false) == 0)
          frmGenBlank.chMethod_1.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_ParamGenLogin", "chMethod_2").ToLower(), "true", false) == 0)
          frmGenBlank.chMethod_2.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_ParamGenLogin", "chMethod_3").ToLower(), "true", false) == 0)
          frmGenBlank.chMethod_3.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_ParamGenLogin", "chMethod_4").ToLower(), "true", false) == 0)
          frmGenBlank.chMethod_4.Checked = true;
        frmGenBlank.txtGenMinLen.Text = _INI.LoadINI("Option_ParamGenLogin", "txtGenMinLen");
        frmGenBlank.txtGenMaxLen.Text = _INI.LoadINI("Option_ParamGenLogin", "txtGenMaxLen");
        if (Operators.CompareString(_INI.LoadINI("Option_ParamGenLogin", "chDoubleGlas").ToLower(), "true", false) == 0)
          frmGenBlank.chDoubleGlas.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_ParamGenLogin", "chDoubleSOglas").ToLower(), "true", false) == 0)
          frmGenBlank.chDoubleSOglas.Checked = true;
        frmGenBlank.cmbDoubleGlas.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_ParamGenLogin", "cmbDoubleGlas"))));
        frmGenBlank.cmbDoubleSOglas.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_ParamGenLogin", "cmbDoubleSOglas"))));
        frmGenBlank.cmbUseNum.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_ParamGenLogin", "cmbUseNum"))));
        frmGenBlank.cmbUseNumPercent.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_ParamGenLogin", "cmbUseNumPercent"))));
        if (Operators.CompareString(_INI.LoadINI("Option_ParamGenLogin", "chDopMethod_1").ToLower(), "true", false) == 0)
          frmGenBlank.chDopMethod_1.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_ParamGenLogin", "chDopMethod_2").ToLower(), "true", false) == 0)
          frmGenBlank.chDopMethod_2.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_ParamGenLogin", "chDopMethod_3").ToLower(), "true", false) == 0)
          frmGenBlank.chDopMethod_3.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Option_ParamGenLogin", "chDopMethod_4").ToLower(), "true", false) == 0)
          frmGenBlank.chDopMethod_4.Checked = true;
        frmGenBlank.cmbDopPercent_1.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_ParamGenLogin", "cmbDopPercent_1"))));
        frmGenBlank.cmbDopPercent_2.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_ParamGenLogin", "cmbDopPercent_2"))));
        frmGenBlank.cmbDopPercent_3.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_ParamGenLogin", "cmbDopPercent_3"))));
        frmGenBlank.cmbDopPercent_4.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Option_ParamGenLogin", "cmbDopPercent_4"))));
        if (Operators.CompareString(_INI.LoadINI("Option_GenLogin", "chHardCheck").ToLower(), "true", false) == 0)
          frmGenBlank.chHardCheck.Checked = true;
        frmGenBlank.txtGenCount.Text = _INI.LoadINI("general", "CountGenLogin");
        frmMain frmMain = MyProject.Forms.frmMain;
        if (Operators.CompareString(_INI.LoadINI("Globals", "chAutoCaptcha").ToLower(), "true", false) == 0)
          frmMain.chAutoCaptcha.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Globals", "chAutoUpdate").ToLower(), "true", false) == 0)
          frmMain.chAutoUpdate.Checked = true;
        frmMain.cmbThread.SelectedIndex = checked ((int) Math.Round(Conversion.Val(_INI.LoadINI("Globals", "cmbThread"))));
        if (Operators.CompareString(_INI.LoadINI("Globals", "chProxy").ToLower(), "true", false) == 0)
          frmMain.chProxy.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Globals", "chAllMail").ToLower(), "true", false) == 0)
          frmMain.chAllMail.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Globals", "chAutoUpdate").ToLower(), "true", false) == 0)
          frmMain.chAutoUpdate.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Report", "chReport_1").ToLower(), "true", false) == 0)
          frmMain.chReport_1.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Report", "chReport_2").ToLower(), "true", false) == 0)
          frmMain.chReport_2.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Report", "chReport_3").ToLower(), "true", false) == 0)
          frmMain.chReport_3.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Report", "chReport_4").ToLower(), "true", false) == 0)
          frmMain.chReport_4.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Report", "chReport_5").ToLower(), "true", false) == 0)
          frmMain.chReport_5.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Report", "chReport_6").ToLower(), "true", false) == 0)
          frmMain.chReport_6.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Report", "chReport_7").ToLower(), "true", false) == 0)
          frmMain.chReport_7.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("Report", "chReport_8").ToLower(), "true", false) == 0)
          frmMain.chReport_8.Checked = true;
        if (Operators.CompareString(_INI.LoadINI("NetworkReboot", "chNetWorkReboot").ToLower(), "true", false) == 0)
          MyProject.Forms.frmOptions.chNetWorkReboot.Checked = true;
        stopwatch.Stop();
        if (Operators.CompareString(_INI.LoadINI("VPN", "chVPN").ToLower(), "true", false) == 0)
          MyProject.Forms.frmOptions.chVPN.Checked = true;
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        sText = "Опции программы успешно загружены.";
        fn1.TXT(ref sText);
        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
        sText = "Скорость загрузки данных: " + Conversions.ToString(stopwatch.ElapsedMilliseconds) + " мс";
        fn2.TXT(ref sText);
        if (!md_HttpLoadProxy.HttpLoadProxy.LoadInStart)
          return;
        md_HttpLoadProxy.Start_HttpLoadProxy();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ошибка загрузки дополнительных данных: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static void VisibleCapcta(int Index)
    {
      switch (Index)
      {
        case -2:
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_0.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_1.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_2.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_3.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_4.Visible = false;
          break;
        case -1:
          int num = _FUNCTION.sRND.Next(0, 5);
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_0.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_1.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_2.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_3.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_4.Visible = false;
          switch (num)
          {
            case 0:
              MyProject.Forms.frmMain.picVOTE_CAPTCHA_0.Visible = true;
              return;
            case 1:
              MyProject.Forms.frmMain.picVOTE_CAPTCHA_1.Visible = true;
              return;
            case 2:
              MyProject.Forms.frmMain.picVOTE_CAPTCHA_2.Visible = true;
              return;
            case 3:
              MyProject.Forms.frmMain.picVOTE_CAPTCHA_3.Visible = true;
              return;
            case 4:
              MyProject.Forms.frmMain.picVOTE_CAPTCHA_3.Visible = true;
              return;
            default:
              return;
          }
        case 0:
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_0.Visible = true;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_1.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_2.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_3.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_4.Visible = false;
          break;
        case 1:
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_1.Visible = true;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_0.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_2.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_3.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_4.Visible = false;
          break;
        case 2:
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_2.Visible = true;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_0.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_1.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_3.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_4.Visible = false;
          break;
        case 3:
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_3.Visible = true;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_0.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_1.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_2.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_4.Visible = false;
          break;
        case 4:
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_4.Visible = true;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_0.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_1.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_2.Visible = false;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_3.Visible = false;
          break;
      }
    }

    public static void VisibleRequest(int Value)
    {
      if (Value == 0)
      {
        MyProject.Forms.frmMain.picRequestCaptcha.Visible = false;
      }
      else
      {
        MyProject.Forms.frmMain.picRequestCaptcha.Visible = true;
        MyProject.Forms.frmMain.picVOTE_CAPTCHA_0.Visible = false;
        MyProject.Forms.frmMain.picVOTE_CAPTCHA_1.Visible = false;
        MyProject.Forms.frmMain.picVOTE_CAPTCHA_2.Visible = false;
        MyProject.Forms.frmMain.picVOTE_CAPTCHA_3.Visible = false;
        MyProject.Forms.frmMain.picVOTE_CAPTCHA_4.Visible = false;
      }
    }

    public static void ReloadAllCaptcha()
    {
      frmMain frmMain = MyProject.Forms.frmMain;
      frmMain.picVOTE_CAPTCHA_0.Image = frmMain.picCollection0.Image;
      frmMain.picVOTE_CAPTCHA_1.Image = frmMain.picCollection1.Image;
      frmMain.picVOTE_CAPTCHA_2.Image = frmMain.picCollection2.Image;
      frmMain.picVOTE_CAPTCHA_3.Image = frmMain.picCollection3.Image;
      frmMain.picVOTE_CAPTCHA_4.Image = frmMain.picCollection4.Image;
    }

    public static int SpeedTest(bool ThisStart = false)
    {
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) _FUNCTION.\u0024STATIC\u0024SpeedTest\u00240182\u0024sSpeedTestCounter\u0024Init, ref lockTaken);
        if ((int) _FUNCTION.\u0024STATIC\u0024SpeedTest\u00240182\u0024sSpeedTestCounter\u0024Init.State == 0)
        {
          _FUNCTION.\u0024STATIC\u0024SpeedTest\u00240182\u0024sSpeedTestCounter\u0024Init.State = (short) 2;
          _FUNCTION.\u0024STATIC\u0024SpeedTest\u00240182\u0024sSpeedTestCounter = 0;
        }
        else if ((int) _FUNCTION.\u0024STATIC\u0024SpeedTest\u00240182\u0024sSpeedTestCounter\u0024Init.State == 2)
          throw new IncompleteInitialization();
      }
      finally
      {
        _FUNCTION.\u0024STATIC\u0024SpeedTest\u00240182\u0024sSpeedTestCounter\u0024Init.State = (short) 1;
        if (lockTaken)
          Monitor.Exit((object) _FUNCTION.\u0024STATIC\u0024SpeedTest\u00240182\u0024sSpeedTestCounter\u0024Init);
      }
      if (!ThisStart)
        return checked ((int) Math.Round(DateAndTime.Now.TimeOfDay.TotalMilliseconds) - _FUNCTION.\u0024STATIC\u0024SpeedTest\u00240182\u0024sSpeedTestCounter);
      _FUNCTION.\u0024STATIC\u0024SpeedTest\u00240182\u0024sSpeedTestCounter = checked ((int) Math.Round(DateAndTime.Now.TimeOfDay.TotalMilliseconds));
      return 0;
    }

    public static string DelRightNUM(ref string sText)
    {
      string str = sText;
      int Start = Strings.Len(sText);
      while (Start >= 1 && Strings.InStr("0123456789", Strings.Mid(str, Start), CompareMethod.Binary) > 0)
      {
        str = Strings.Left(str, checked (str.Length - 1));
        checked { Start += -1; }
      }
      return str;
    }

    public static void GenLogin(int sGenCount, bool sTest = false, bool sNoSaveNoAdd = false, bool sNoLogin = false, bool sNoDomain = false, bool sNoPassword = false)
    {
      if (_VARIABLES.MethodGenLogin == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "У вас не выбрано ни одного метода для генерации логина.", MsgBoxStyle.Critical, (object) "Ошибка генерации логинов");
      }
      else if (Conversion.Val((object) sGenCount) < 1.0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Неправильно задано количество логинов для генерации.", MsgBoxStyle.Critical, (object) "Ошибка генерации логинов");
      }
      else
      {
        MyProject.Forms.frmGenBlank.pbGenLogin.Value = 0;
        MyProject.Forms.frmGenBlank.pbGenLogin.Maximum = sGenCount;
        int num3 = sGenCount / 100;
        if (num3 == 0)
          num3 = 1;
        switch (_VARIABLES.DomainSelect)
        {
          case 1:
            if (Conversion.Val(MyProject.Forms.frmGenBlank.txtGenMaxLen.Text) > 20.0)
            {
              int num4 = (int) Interaction.MsgBox((object) "Максимальная длина логина на qip.ru 20 символов!", MsgBoxStyle.Exclamation, (object) "QIP.RU");
              return;
            }
            break;
          case 2:
            if (MyProject.Forms.frmGenBlank.chMethod_4.Checked)
            {
              switch (MyProject.Forms.frmGenBlank.cmbUseNum.SelectedIndex)
              {
                case 0:
                case 3:
                case 4:
                  break;
                default:
                  int num5 = (int) Interaction.MsgBox((object) "В логинах Meta.ua запрещено использование цифр в начале логина.\r\nДля генерации логинов meta.ua, при использовании цифр, доступны только следующие методы:\r\nmd0\r\nmd3\r\nmd4\r\nВыберите один из указанных методов, либо отключите использование цифр при генерации.\r\n", MsgBoxStyle.Exclamation, (object) "META.UA");
                  return;
              }
            }
            if (Conversion.Val(MyProject.Forms.frmGenBlank.txtGenMinLen.Text) < 4.0)
            {
              int num4 = (int) Interaction.MsgBox((object) "Минимальная длина логина на meta.ua 4 символа!", MsgBoxStyle.Exclamation, (object) "META.UA");
              return;
            }
            if (Conversion.Val(MyProject.Forms.frmGenBlank.txtGenMaxLen.Text) > 20.0)
            {
              int num4 = (int) Interaction.MsgBox((object) "Максимальная длина логина на meta.ua 20 символов!", MsgBoxStyle.Exclamation, (object) "META.UA");
              return;
            }
            break;
          case 3:
            if (MyProject.Forms.frmGenBlank.chMethod_4.Checked)
            {
              switch (MyProject.Forms.frmGenBlank.cmbUseNum.SelectedIndex)
              {
                case 0:
                case 3:
                case 4:
                  break;
                default:
                  int num6 = (int) Interaction.MsgBox((object) "В логинах Yandex.ru запрещено использование цифр в начале логина.\r\nДля генерации логинов yandex, при использовании цифр, доступны только следующие методы:\r\nmd0\r\nmd3\r\nmd4\r\nВыберите один из указанных методов, либо отключите использование цифр при генерации.\r\n", MsgBoxStyle.Exclamation, (object) "Капризный Yandex");
                  return;
              }
            }
            else
              break;
          case 4:
            if (MyProject.Forms.frmGenBlank.chMethod_4.Checked)
            {
              switch (MyProject.Forms.frmGenBlank.cmbUseNum.SelectedIndex)
              {
                case 0:
                case 3:
                case 4:
                  break;
                default:
                  int num7 = (int) Interaction.MsgBox((object) "В логинах KM.ru запрещено использование цифр в начале логина.\r\nДля генерации логинов KM, при использовании цифр, доступны только следующие методы:\r\nmd0\r\nmd3\r\nmd4\r\nВыберите один из указанных методов, либо отключите использование цифр при генерации.\r\n", MsgBoxStyle.Exclamation, (object) "Капризный KM");
                  return;
              }
            }
            else
              break;
        }
        string sText;
        if ((int) _VARIABLES.OP.HardCheck == 1)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          sText = "Тяжелая проверка генерируемых логинов (v2): Включена";
          fn.TXT(ref sText);
        }
        CheckBox chRnd1 = MyProject.Forms.frmGenBlank.chRND_1;
        bool flag1 = MyProject.Forms.frmGenBlank.chRND_1.Checked;
        bool flag2 = MyProject.Forms.frmGenBlank.chRND_2.Checked;
        bool flag3 = MyProject.Forms.frmGenBlank.chRND_3.Checked;
        bool flag4 = MyProject.Forms.frmGenBlank.chRND_4.Checked;
        bool flag5 = MyProject.Forms.frmGenBlank.chRND_5.Checked;
        bool flag6 = MyProject.Forms.frmGenBlank.chRND_6.Checked;
        bool flag7 = MyProject.Forms.frmGenBlank.chRND_7.Checked;
        bool flag8 = MyProject.Forms.frmGenBlank.chRND_8.Checked;
        frmGenBlank frmGenBlank = MyProject.Forms.frmGenBlank;
        _VARIABLES.meMailInfo[] meMailInfoArray = new _VARIABLES.meMailInfo[checked (sGenCount + 1)];
        int num8 = 1;
        int num9 = sGenCount;
        int index1 = num8;
        while (index1 <= num9)
        {
          if (index1 % num3 == 0)
          {
            MyProject.Forms.frmGenBlank.pbGenLogin.Value = index1;
            Application.DoEvents();
          }
          meMailInfoArray[index1].RegUserData.Sex = flag2 ? checked ((short) _FUNCTION.sRND.Next(1, 3)) : checked ((short) (frmGenBlank.cmbUserSex.SelectedIndex + 1));
          if (!flag1)
          {
            meMailInfoArray[index1].RegUserData.Name = frmGenBlank.txtName.Text;
            meMailInfoArray[index1].RegUserData.LastName = frmGenBlank.txtLastName.Text;
          }
          else if ((int) meMailInfoArray[index1].RegUserData.Sex == 1)
          {
            meMailInfoArray[index1].RegUserData.Name = _VARIABLES.M_UserName[_FUNCTION.sRND.Next(1, checked (Information.UBound((Array) _VARIABLES.M_UserName, 1) + 1))];
            meMailInfoArray[index1].RegUserData.LastName = _VARIABLES.M_UserLastName[_FUNCTION.sRND.Next(1, checked (Information.UBound((Array) _VARIABLES.M_UserLastName, 1) + 1))];
          }
          else
          {
            meMailInfoArray[index1].RegUserData.Name = _VARIABLES.J_UserName[_FUNCTION.sRND.Next(1, checked (Information.UBound((Array) _VARIABLES.J_UserName, 1) + 1))];
            meMailInfoArray[index1].RegUserData.LastName = _VARIABLES.J_UserLastName[_FUNCTION.sRND.Next(1, checked (Information.UBound((Array) _VARIABLES.J_UserLastName, 1) + 1))];
          }
          switch (_VARIABLES.DomainSelect)
          {
            case 0:
              meMailInfoArray[index1].RegUserData.City = flag3 ? Conversions.ToString(frmGenBlank.cmbTown.Items[_FUNCTION.sRND.Next(0, 12)]) : frmGenBlank.txtTown.Text;
              break;
            case 1:
              meMailInfoArray[index1].RegUserData.City = string.Empty;
              break;
            case 2:
              meMailInfoArray[index1].RegUserData.City = "Украина -> Киев";
              break;
          }
          if (!sNoDomain)
          {
            meMailInfoArray[index1].domain = flag4 ? _VARIABLES.MailService[_VARIABLES.DomainSelect].domain[_FUNCTION.sRND.Next(0, checked (_VARIABLES.MailService[_VARIABLES.DomainSelect].DomainCNT + 1))] : _VARIABLES.MailService[_VARIABLES.DomainSelect].domain[frmGenBlank.cmbAccSel_Domain.SelectedIndex];
            meMailInfoArray[index1].DomainID = checked ((short) _VARIABLES.DomainSelect);
          }
          if (!sNoPassword)
            meMailInfoArray[index1].password = flag5 ? Conversions.ToString(mdGenWORD.GenPassword()) : frmGenBlank.txtUserGenPass.Text;
          if (!flag6)
          {
            meMailInfoArray[index1].RegUserData.BirthDay = Strings.Right("0" + frmGenBlank.cmbUserDayBD.Text, 2);
            meMailInfoArray[index1].RegUserData.BirthMonth = Conversions.ToString(checked (frmGenBlank.cmbUserMonthBD.SelectedIndex + 1));
            meMailInfoArray[index1].RegUserData.BirthYear = frmGenBlank.cmbUserYearBD.Text;
          }
          else
          {
            meMailInfoArray[index1].RegUserData.BirthDay = Strings.Right("0" + Conversions.ToString(_FUNCTION.sRND.Next(1, 29)), 2);
            meMailInfoArray[index1].RegUserData.BirthMonth = Conversions.ToString(_FUNCTION.sRND.Next(1, 13));
            meMailInfoArray[index1].RegUserData.BirthYear = Conversions.ToString(_FUNCTION.sRND.Next(1970, 1998));
          }
          meMailInfoArray[index1].RegUserData.SecretQuestion = flag7 ? Conversions.ToString(frmGenBlank.cmbUserQuest.Items[_FUNCTION.sRND.Next(0, 9)]) : frmGenBlank.cmbUserQuest.Text;
          meMailInfoArray[index1].RegUserData.SecretAnswer = flag8 ? Conversions.ToString(mdGenWORD.GenPassword()) : frmGenBlank.txtAnswer.Text;
          checked { ++index1; }
        }
        string str1 = "";
        if (!sNoLogin)
        {
          if (frmGenBlank.chMethod_4.Checked)
          {
            mdGenWORD.GenWordOptions.WordLenMin = checked ((byte) Math.Round(Conversion.Val(frmGenBlank.txtGenMinLen.Text)));
            mdGenWORD.GenWordOptions.WordLenMax = checked ((byte) Math.Round(Conversion.Val(frmGenBlank.txtGenMaxLen.Text)));
            switch (frmGenBlank.cmbUseNum.SelectedIndex)
            {
              case 0:
                mdGenWORD.GenWordOptions.UseNUM = (byte) 0;
                break;
              case 1:
                mdGenWORD.GenWordOptions.UseNUM = (byte) 1;
                break;
              case 2:
                mdGenWORD.GenWordOptions.UseNUM = (byte) 2;
                break;
              case 3:
                mdGenWORD.GenWordOptions.UseNUM = (byte) 11;
                break;
              case 4:
                mdGenWORD.GenWordOptions.UseNUM = (byte) 12;
                break;
              case 5:
                mdGenWORD.GenWordOptions.UseNUM = (byte) 101;
                break;
              case 6:
                mdGenWORD.GenWordOptions.UseNUM = (byte) 102;
                break;
              case 7:
                mdGenWORD.GenWordOptions.UseNUM = (byte) 103;
                break;
              case 8:
                mdGenWORD.GenWordOptions.UseNUM = (byte) 104;
                break;
              case 9:
                mdGenWORD.GenWordOptions.UseNUM = (byte) 105;
                break;
              case 10:
                mdGenWORD.GenWordOptions.UseNUM = (byte) 106;
                break;
            }
            mdGenWORD.GenWordOptions.UseNumPercent = checked ((byte) (frmGenBlank.cmbUseNumPercent.SelectedIndex + 1));
            mdGenWORD.GenWordOptions.DblGlasnay = !frmGenBlank.chDoubleGlas.Checked ? (byte) 0 : checked ((byte) (frmGenBlank.cmbDoubleGlas.SelectedIndex + 1));
            mdGenWORD.GenWordOptions.DblSoglasnay = !frmGenBlank.chDoubleSOglas.Checked ? (byte) 0 : checked ((byte) (frmGenBlank.cmbDoubleSOglas.SelectedIndex + 1));
            mdGenWORD.GenWordOptions.DifferentRegister = (byte) 0;
            mdGenWORD.GenWordOptions.CapitalLetter = (byte) 0;
            mdGenWORD.GenWordOptions.CapitalAll = (byte) 0;
          }
          int[] numArray = new int[5];
          if (frmGenBlank.chDopMethod_1.Checked)
            numArray[1] = checked (frmGenBlank.cmbDopPercent_1.SelectedIndex + 1);
          if (frmGenBlank.chDopMethod_2.Checked)
            numArray[2] = checked (frmGenBlank.cmbDopPercent_2.SelectedIndex + 1);
          if (frmGenBlank.chDopMethod_3.Checked)
            numArray[3] = checked (frmGenBlank.cmbDopPercent_3.SelectedIndex + 1);
          if (frmGenBlank.chDopMethod_4.Checked)
            numArray[4] = checked (frmGenBlank.cmbDopPercent_4.SelectedIndex + 1);
          string[] strArray1 = new string[8]
          {
            null,
            "mr",
            "boss",
            "mega",
            "vip",
            "miss",
            "lady",
            "ms"
          };
          string[] strArray2 = new string[4];
          if (numArray[4] > 0)
          {
            switch (_VARIABLES.DomainSelect)
            {
              case 0:
                strArray2[1] = ".";
                strArray2[2] = "-";
                strArray2[3] = "_";
                break;
              case 1:
                strArray2[1] = ".";
                strArray2[2] = "-";
                strArray2[3] = "-";
                break;
              case 2:
                strArray2[1] = ".";
                strArray2[2] = "-";
                strArray2[3] = "_";
                break;
              case 3:
                strArray2[1] = ".";
                strArray2[2] = "-";
                strArray2[3] = ".";
                break;
              case 4:
                strArray2[1] = ".";
                strArray2[2] = "-";
                strArray2[3] = "_";
                break;
            }
          }
          int num4 = 1;
          int num10 = sGenCount;
          int index2 = num4;
          while (index2 <= num10)
          {
label_76:
            string String2;
            do
            {
              do
              {
                do
                {
                  do
                  {
                    do
                    {
                      int num11;
                      do
                      {
                        checked { ++num11; }
                        if (num11 == 5)
                          num11 = 1;
                      }
                      while (num11 == 1 & !frmGenBlank.chMethod_1.Checked || num11 == 2 & !frmGenBlank.chMethod_2.Checked || (num11 == 3 & !frmGenBlank.chMethod_3.Checked || num11 == 4 & !frmGenBlank.chMethod_4.Checked));
                      switch (num11)
                      {
                        case 1:
                          if (frmGenBlank.chMethod_1.Checked)
                          {
                            str1 = _VARIABLES.BD_Mail[_FUNCTION.sRND.Next(1, checked (Information.UBound((Array) _VARIABLES.BD_Mail, 1) + 1))];
                            break;
                          }
                          break;
                        case 2:
                          if (frmGenBlank.chMethod_2.Checked)
                          {
                            str1 = mdGenWORD.Translate(ref meMailInfoArray[index2].RegUserData.Name);
                            break;
                          }
                          break;
                        case 3:
                          if (frmGenBlank.chMethod_3.Checked)
                          {
                            str1 = mdGenWORD.Translate(ref meMailInfoArray[index2].RegUserData.LastName);
                            break;
                          }
                          break;
                        case 4:
                          if (frmGenBlank.chMethod_4.Checked)
                          {
                            str1 = mdGenWORD.GenWORD();
                            break;
                          }
                          break;
                      }
                      str1 = str1.ToLower();
                      if (numArray[1] > 0 && _FUNCTION.sRND.Next(1, 101) <= numArray[1])
                        str1 = (int) meMailInfoArray[index2].RegUserData.Sex != 1 ? strArray1[_FUNCTION.sRND.Next(3, 8)] + strArray2[_FUNCTION.sRND.Next(1, 4)] + str1 : strArray1[_FUNCTION.sRND.Next(1, 5)] + strArray2[_FUNCTION.sRND.Next(1, 4)] + str1;
                      if (numArray[2] > 0 && _FUNCTION.sRND.Next(1, 101) <= numArray[2])
                      {
                        str1 = _FUNCTION.DelRightNUM(ref str1);
                        string str2 = "";
                        switch (checked ((short) _FUNCTION.sRND.Next(1, 5)))
                        {
                          case 1:
                            str2 = Strings.Right("0" + meMailInfoArray[index2].RegUserData.BirthDay, 2) + Strings.Right("0" + meMailInfoArray[index2].RegUserData.BirthMonth, 2) + Strings.Right(meMailInfoArray[index2].RegUserData.BirthYear, 2);
                            break;
                          case 2:
                            str2 = Strings.Right("0" + meMailInfoArray[index2].RegUserData.BirthDay, 2) + Strings.Right("0" + meMailInfoArray[index2].RegUserData.BirthMonth, 2);
                            break;
                          case 3:
                            str2 = meMailInfoArray[index2].RegUserData.BirthYear;
                            break;
                          case 4:
                            str2 = Strings.Right(meMailInfoArray[index2].RegUserData.BirthYear, 2);
                            break;
                        }
                        str1 = _FUNCTION.sRND.Next(1, 101) > numArray[1] ? str1 + str2 : str1 + strArray2[_FUNCTION.sRND.Next(1, 4)] + str2;
                      }
                      if (numArray[3] > 0 && _FUNCTION.sRND.Next(1, 101) <= numArray[3])
                      {
                        if (Strings.InStr(2, str1, "i", CompareMethod.Binary) > 0)
                          StringType.MidStmtStr(ref str1, Strings.InStr(str1, "i", CompareMethod.Binary), 1, "1");
                        else if (Strings.InStr(2, str1, "l", CompareMethod.Binary) > 0)
                          StringType.MidStmtStr(ref str1, Strings.InStr(str1, "l", CompareMethod.Binary), 1, "1");
                        else if (Strings.InStr(2, str1, "o", CompareMethod.Binary) > 0)
                          StringType.MidStmtStr(ref str1, Strings.InStr(str1, "o", CompareMethod.Binary), 1, "0");
                        else if (Strings.InStr(2, str1, "ch", CompareMethod.Binary) > 0)
                        {
                          StringType.MidStmtStr(ref str1, Strings.InStr(str1, "ch", CompareMethod.Binary), 2, "4 ");
                          str1 = str1.Replace(" ", "");
                        }
                      }
                      if (numArray[4] <= 0)
                        ;
                      if ((int) _VARIABLES.OP.HardCheck == 1)
                        String2 = Strings.Mid(str1, 1, 1);
                      else
                        goto label_120;
                    }
                    while (Strings.InStr(".-_", String2, CompareMethod.Binary) > 0 || Strings.InStr(".-_", Strings.Right(str1, 1), CompareMethod.Binary) > 0 || (Strings.InStr(str1, "..", CompareMethod.Binary) > 0 || Strings.InStr(str1, ".-", CompareMethod.Binary) > 0) || (Strings.InStr(str1, "._", CompareMethod.Binary) > 0 || Strings.InStr(str1, "--", CompareMethod.Binary) > 0 || (Strings.InStr(str1, "-.", CompareMethod.Binary) > 0 || Strings.InStr(str1, "-_", CompareMethod.Binary) > 0)) || (Strings.InStr(str1, "__", CompareMethod.Binary) > 0 || Strings.InStr(str1, "_.", CompareMethod.Binary) > 0 || (Strings.InStr(str1, "_-", CompareMethod.Binary) > 0 || Strings.InStr(str1, " ", CompareMethod.Binary) > 0) || Strings.InStr(str1, "\t", CompareMethod.Binary) > 0));
                    switch (_VARIABLES.DomainSelect)
                    {
                      case 0:
                        continue;
                      case 1:
                        goto label_111;
                      case 2:
                        goto label_112;
                      case 3:
                        goto label_115;
                      case 4:
                        goto label_118;
                      default:
                        goto label_120;
                    }
                  }
                  while (Strings.InStr(str1, "admin", CompareMethod.Binary) > 0 || Strings.InStr(str1, "mail.ru", CompareMethod.Binary) > 0 || Strings.InStr(str1, "support", CompareMethod.Binary) > 0);
                  break;
label_111:;
                }
                while (str1.Length < 3 | str1.Length > 20);
                break;
label_112:
                if (Strings.InStr("0123456789", String2, CompareMethod.Binary) > 0)
                  str1 = Strings.Mid("qwertyuiopasdfghjklzxcvbnm", _FUNCTION.sRND.Next(1, 27), 1) + str1;
              }
              while (str1.Length < 3 | str1.Length > 20);
              goto label_120;
label_115:;
            }
            while (Strings.InStr(str1, "_", CompareMethod.Binary) > 0);
            if (Strings.InStr("0123456789", String2, CompareMethod.Binary) > 0)
            {
              str1 = Strings.Mid("qwertyuiopasdfghjklzxcvbnm", _FUNCTION.sRND.Next(1, 27), 1) + str1;
              goto label_120;
            }
            else
              goto label_120;
label_118:
            if (Strings.InStr("0123456789", String2, CompareMethod.Binary) > 0)
              str1 = Strings.Mid("qwertyuiopasdfghjklzxcvbnm", _FUNCTION.sRND.Next(1, 27), 1) + str1;
label_120:
            int num12 = 1;
            int num13 = checked (index2 - 1);
            int index3 = num12;
            while (index3 <= num13)
            {
              if (Operators.CompareString(meMailInfoArray[index3].login, str1, false) != 0)
                checked { ++index3; }
              else
                goto label_76;
            }
            int num14 = 1;
            int num15 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
            int index4 = num14;
            while (index4 <= num15)
            {
              if (Operators.CompareString(_VARIABLES.MailInfo[index4].login, str1, false) != 0)
                checked { ++index4; }
              else
                goto label_76;
            }
            meMailInfoArray[index2].login = str1;
            checked { ++index2; }
          }
        }
        if (sTest)
        {
          frmGenBlank.txtTestLogin.Text = str1;
        }
        else
        {
          int num4 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
          _VARIABLES.MailInfo = (_VARIABLES.meMailInfo[]) Utils.CopyArray((Array) _VARIABLES.MailInfo, (Array) new _VARIABLES.meMailInfo[checked (num4 + sGenCount + 1)]);
          if (!sNoSaveNoAdd)
          {
            ListViewItem[] listViewItemArray = new ListViewItem[checked (sGenCount - 1 + 1)];
            string[] items = new string[8];
            int num10 = checked (num4 + 1);
            int num11 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
            int index2 = num10;
            while (index2 <= num11)
            {
              _VARIABLES.MailInfo[index2] = meMailInfoArray[checked (index2 - num4)];
              items[0] = Conversions.ToString(index2);
              items[1] = _VARIABLES.MailInfo[index2].login;
              items[2] = "@" + _VARIABLES.MailInfo[index2].domain;
              items[3] = _VARIABLES.MailInfo[index2].RegUserData.Name;
              items[4] = _VARIABLES.MailInfo[index2].RegUserData.LastName;
              items[5] = _VARIABLES.MailInfo[index2].DataCreateBox;
              items[6] = Conversions.ToString(_VARIABLES.MailInfo[index2].MailAmount);
              items[7] = _VARIABLES.MailInfo[index2].comment;
              listViewItemArray[checked (index2 - num4 - 1)] = new ListViewItem(items, (int) _VARIABLES.MailInfo[index2].Registered);
              checked { ++index2; }
            }
            _LOADSAVE.SaveALL_MailInfo();
            MyProject.Forms.frmMain.pbGenLogin.Maximum = Information.UBound((Array) _VARIABLES.MailInfo, 1);
            MyProject.Forms.frmMain.LV.Items.AddRange(((IEnumerable<ListViewItem>) listViewItemArray).ToArray<ListViewItem>());
          }
          else
          {
            int num10 = checked (num4 + 1);
            int num11 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
            int index2 = num10;
            while (index2 <= num11)
            {
              _VARIABLES.MailInfo[index2] = meMailInfoArray[checked (index2 - num4)];
              checked { ++index2; }
            }
          }
          MyProject.Forms.frmGenBlank.pbGenLogin.Value = MyProject.Forms.frmGenBlank.pbGenLogin.Maximum;
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          sText = "Сгенерировано " + Conversions.ToString(sGenCount) + " заготовок для регистрации.";
          fn.TXT(ref sText);
        }
      }
    }

    public static void LockedALL()
    {
      frmMain frmMain = MyProject.Forms.frmMain;
      frmMain.grAccountEdit.Enabled = false;
      frmMain.cmbThread.Enabled = false;
      frmMain.btmGlobalOptions.Enabled = false;
      frmMain.btmSaveList.Enabled = false;
      frmMain.btmLoadMail.Enabled = false;
      frmMain.chAllMail.Enabled = false;
      frmMain.btmGenMailOptions.Enabled = false;
      frmMain.btmAbout.Enabled = false;
      frmMain.chAutoCaptcha.Enabled = false;
      frmMain.chProxy.Enabled = false;
      frmMain.chAutoUpdate.Enabled = false;
      frmMain.btnOpenMail.Enabled = false;
      frmMain.btnOpenProxy.Enabled = false;
      frmMain.chCheckMail_WebFace.Enabled = false;
      _FUNCTION.Locked = true;
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Управление заблокировано.";
      fn.TXT(ref sText);
    }

    public static void UnLockedALL()
    {
      frmMain frmMain = MyProject.Forms.frmMain;
      frmMain.grAccountEdit.Enabled = true;
      frmMain.cmbThread.Enabled = true;
      frmMain.btmGlobalOptions.Enabled = true;
      frmMain.btmSaveList.Enabled = true;
      frmMain.btmLoadMail.Enabled = true;
      frmMain.chAllMail.Enabled = true;
      frmMain.btmGenMailOptions.Enabled = true;
      frmMain.btmAbout.Enabled = true;
      frmMain.chAutoCaptcha.Enabled = true;
      frmMain.chProxy.Enabled = true;
      frmMain.chAutoUpdate.Enabled = true;
      frmMain.btnOpenMail.Enabled = true;
      frmMain.btnOpenProxy.Enabled = true;
      frmMain.chCheckMail_WebFace.Enabled = true;
      _FUNCTION.Locked = false;
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Управление разблокировано.";
      fn.TXT(ref sText);
    }

    public static void LockedALL_MailDownload()
    {
      frmMain frmMain = MyProject.Forms.frmMain;
      frmMain.grAccountEdit.Enabled = false;
      frmMain.cmbThread.Enabled = false;
      frmMain.btmGlobalOptions.Enabled = false;
      frmMain.btmSaveList.Enabled = false;
      frmMain.chAllMail.Enabled = false;
      frmMain.btmGenMailOptions.Enabled = false;
      frmMain.btmAbout.Enabled = false;
      frmMain.btmStart.Enabled = false;
      frmMain.chAutoCaptcha.Enabled = false;
      frmMain.chProxy.Enabled = false;
      frmMain.chAutoUpdate.Enabled = false;
      frmMain.btnOpenMail.Enabled = false;
      frmMain.btnOpenProxy.Enabled = false;
      frmMain.chCheckMail_WebFace.Enabled = false;
    }

    public static void UnLockedALL_MailDownload()
    {
      frmMain frmMain = MyProject.Forms.frmMain;
      frmMain.grAccountEdit.Enabled = true;
      frmMain.cmbThread.Enabled = true;
      frmMain.btmGlobalOptions.Enabled = true;
      frmMain.btmSaveList.Enabled = true;
      frmMain.chAllMail.Enabled = true;
      frmMain.btmGenMailOptions.Enabled = true;
      frmMain.btmAbout.Enabled = true;
      frmMain.btmStart.Enabled = true;
      frmMain.chAutoCaptcha.Enabled = true;
      frmMain.chProxy.Enabled = true;
      frmMain.chAutoUpdate.Enabled = true;
      frmMain.btnOpenMail.Enabled = true;
      frmMain.btnOpenProxy.Enabled = true;
      frmMain.chCheckMail_WebFace.Enabled = true;
    }

    public static void SBTXT(ref string sText)
    {
      DateTime date = Conversions.ToDate(DateAndTime.Now.TimeOfDay.ToString());
      _VARIABLES.TXT_SB.AppendLine("[" + Conversions.ToString(date) + "] " + sText);
    }

    public static void AccountSelect(int sNum)
    {
      ListView lv = MyProject.Forms.frmMain.LV;
      if (lv.Items.Count == 0)
        return;
      if (sNum == 0)
        sNum = 1;
      if (sNum > lv.Items.Count)
        sNum = lv.Items.Count;
      if (lv.SelectedItems.Count == 1)
        lv.SelectedItems[0].Selected = false;
      lv.Items[checked (sNum - 1)].Selected = true;
      lv.EnsureVisible(checked (sNum - 1));
    }

    public static string Ret_AC_HostName(string ServiceName)
    {
      if (string.IsNullOrEmpty(ServiceName))
        return "UNKNOWN";
      string empty = string.Empty;
      string str;
      try
      {
        string ipString = ServiceName;
        IPAddress address = (IPAddress) null;
        if (IPAddress.TryParse(ipString, out address))
          return ServiceName;
        string host = new UriBuilder(ServiceName).Host;
        int num = Strings.InStrRev(host, ".", -1, CompareMethod.Binary);
        if (num != 0)
          return Strings.Left(host, checked (num - 1)).ToUpper();
        str = host.ToUpper();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Error: FN Return name AC: " + exception.Message;
        fn.TXT(ref sText);
        str = "UNKNOWN";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public static void CLIP(ref string sData)
    {
      Clipboard.Clear();
      if (Information.IsNothing((object) sData) || sData.Length == 0)
        return;
      Clipboard.SetText(sData);
    }

    public static string URLEncode_Ascii(string plain_text)
    {
      if (Strings.Len(plain_text) == 0)
        return "";
      string str1 = "";
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map\u0024Init, ref lockTaken);
        if ((int) _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map\u0024Init.State == 0)
        {
          _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map\u0024Init.State = (short) 2;
          _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map = new string[256];
        }
        else if ((int) _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map\u0024Init.State == 2)
          throw new IncompleteInitialization();
      }
      finally
      {
        _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map\u0024Init.State = (short) 1;
        if (lockTaken)
          Monitor.Exit((object) _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map\u0024Init);
      }
      if (!_FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024flagTableInited)
      {
        string str2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        long num1 = 1;
        long num2 = (long) Strings.Len(str2);
        long num3 = num1;
        while (num3 <= num2)
        {
          _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map[Strings.Asc(Strings.Mid(str2, checked ((int) num3), 1))] = Strings.Mid(str2, checked ((int) num3), 1);
          checked { ++num3; }
        }
        string str3 = "";
        long num4 = 1;
        long num5 = (long) Strings.Len(str3);
        long num6 = num4;
        while (num6 <= num5)
        {
          _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map[Strings.Asc(Strings.Mid(str3, checked ((int) num6), 1))] = Strings.Mid(str3, checked ((int) num6), 1);
          checked { ++num6; }
        }
        long Number = 0;
        do
        {
          if (Number < 16L)
            _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map[checked ((int) Number)] = "%0" + Conversion.Hex(Number);
          else if (Strings.Len(_FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map[checked ((int) Number)]) == 0)
            _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map[checked ((int) Number)] = "%" + Conversion.Hex(Number);
          checked { ++Number; }
        }
        while (Number <= (long) byte.MaxValue);
        _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024flagTableInited = true;
      }
      long num7 = 1;
      long num8 = (long) Strings.Len(plain_text);
      long num9 = num7;
      while (num9 <= num8)
      {
        str1 += _FUNCTION.\u0024STATIC\u0024URLEncode_Ascii\u002401EE\u0024ascii_map[Strings.Asc(Strings.Mid(plain_text, checked ((int) num9), 1))];
        checked { ++num9; }
      }
      return str1;
    }

    public static string URLDecode_Ascii(string urlencoded_text)
    {
      if (Strings.Len(urlencoded_text) == 0)
        return "";
      string str = "";
      long num1 = 1;
      long num2 = (long) Strings.Len(urlencoded_text);
      long num3 = num1;
      while (num3 <= num2)
      {
        if (Strings.Asc(Strings.Mid(urlencoded_text, checked ((int) num3), 1)) == 37)
        {
          if (checked (num3 + 2L) <= (long) Strings.Len(urlencoded_text))
          {
            str += Conversions.ToString(Strings.Chr(checked ((int) Math.Round(Conversion.Val("&h" + Strings.Mid(urlencoded_text, (int) (num3 + 1L), 2))))));
            checked { num3 += 2L; }
          }
        }
        else
          str += Strings.Mid(urlencoded_text, checked ((int) num3), 1);
        checked { ++num3; }
      }
      return str;
    }

    public static string ConvertSTRtoUnicode(ref string sText)
    {
      if (Strings.Len(sText) == 0)
        return string.Empty;
      string str = "";
      byte[] bytes = Encoding.Unicode.GetBytes(sText);
      int num1 = 0;
      int num2 = Information.UBound((Array) bytes, 1);
      int index = num1;
      while (index <= num2)
      {
        str = str + "%u04" + Strings.Right("0" + Conversion.Hex(bytes[index]), 2);
        checked { index += 2; }
      }
      return str;
    }

    public static string ConvertUnicodetoSTR(ref string sText)
    {
      if (Strings.Len(sText) == 0)
        return string.Empty;
      string empty = string.Empty;
      byte[] bytes = new byte[2];
      int num = 1;
      int length = sText.Length;
      int Start = num;
      while (Start <= length)
      {
        if (Operators.CompareString(Strings.Mid(sText, Start, 2), "\\u", false) == 0)
        {
          bytes[1] = Conversions.ToByte("&h" + Strings.Mid(sText, checked (Start + 2), 2));
          bytes[0] = Conversions.ToByte("&h" + Strings.Mid(sText, checked (Start + 4), 2));
          empty += Encoding.Unicode.GetString(bytes);
          checked { Start += 5; }
        }
        else
          empty += Strings.Mid(sText, Start, 1);
        checked { ++Start; }
      }
      return empty;
    }

    public static string ConvertSTRtoHexWeb1byte(ref string sText)
    {
      if (Information.IsNothing((object) sText) || sText.Length == 0)
        return string.Empty;
      string str = string.Empty;
      int num1 = 1;
      short length = checked ((short) sText.Length);
      short num2 = (short) num1;
      while ((int) num2 <= (int) length)
      {
        char String = Conversions.ToChar(Strings.Mid(sText, (int) num2, 1));
        str = Strings.InStr("ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ", Conversions.ToString(String), CompareMethod.Binary) <= 0 ? str + Conversions.ToString(String) : str + "%" + Conversion.Hex(Strings.Asc(String));
        checked { ++num2; }
      }
      return str;
    }

    public static string ConvertHexWeb1byteToStr(ref string sText)
    {
      if (Information.IsNothing((object) sText) || sText.Length == 0)
        return string.Empty;
      string empty = string.Empty;
      int num1 = 1;
      short length = checked ((short) sText.Length);
      short num2 = (short) num1;
      while ((int) num2 <= (int) length)
      {
        if (Operators.CompareString(Strings.Mid(sText, (int) num2, 1), "%", false) == 0)
        {
          empty += Conversions.ToString(Strings.Chr((int) Convert.ToByte(Strings.Mid(sText, checked ((int) num2 + 1), 2), 16)));
          checked { num2 += (short) 2; }
        }
        else
          empty += Strings.Mid(sText, (int) num2, 1);
        checked { ++num2; }
      }
      return empty;
    }

    public static string BrowserDataEncode_Ascii(string plain_text)
    {
      if (Strings.Len(plain_text) == 0)
        return "";
      string str1 = "";
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map\u0024Init, ref lockTaken);
        if ((int) _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map\u0024Init.State == 0)
        {
          _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map\u0024Init.State = (short) 2;
          _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map = new string[256];
        }
        else if ((int) _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map\u0024Init.State == 2)
          throw new IncompleteInitialization();
      }
      finally
      {
        _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map\u0024Init.State = (short) 1;
        if (lockTaken)
          Monitor.Exit((object) _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map\u0024Init);
      }
      if (!_FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024flagTableInited)
      {
        string str2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-.+";
        long num1 = 1;
        long num2 = (long) Strings.Len(str2);
        long num3 = num1;
        while (num3 <= num2)
        {
          _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map[Strings.Asc(Strings.Mid(str2, checked ((int) num3), 1))] = Strings.Mid(str2, checked ((int) num3), 1);
          checked { ++num3; }
        }
        string str3 = "";
        long num4 = 1;
        long num5 = (long) Strings.Len(str3);
        long num6 = num4;
        while (num6 <= num5)
        {
          _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map[Strings.Asc(Strings.Mid(str3, checked ((int) num6), 1))] = Strings.Mid(str3, checked ((int) num6), 1);
          checked { ++num6; }
        }
        long Number = 0;
        do
        {
          if (Number < 16L)
            _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map[checked ((int) Number)] = "%0" + Conversion.Hex(Number);
          else if (Strings.Len(_FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map[checked ((int) Number)]) == 0)
            _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map[checked ((int) Number)] = "%" + Conversion.Hex(Number);
          checked { ++Number; }
        }
        while (Number <= (long) byte.MaxValue);
        _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024flagTableInited = true;
      }
      long num7 = 1;
      long num8 = (long) Strings.Len(plain_text);
      long num9 = num7;
      while (num9 <= num8)
      {
        str1 += _FUNCTION.\u0024STATIC\u0024BrowserDataEncode_Ascii\u002401EE\u0024ascii_map[Strings.Asc(Strings.Mid(plain_text, checked ((int) num9), 1))];
        checked { ++num9; }
      }
      return str1;
    }

    public static string UrlEncode(ref string sText)
    {
      if (Information.IsNothing((object) sText) || sText.Length == 0)
        return string.Empty;
      string str = "";
      int num = 1;
      int length = sText.Length;
      int Start = num;
      while (Start <= length)
      {
        if (Strings.InStr("ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ", Strings.Mid(sText, Start, 1), CompareMethod.Binary) > 0)
        {
          byte[] bytes = Encoding.UTF8.GetBytes(Strings.Mid(sText, Start, 1));
          str = str + "%" + Strings.Right("0" + Conversion.Hex(bytes[0]), 2) + "%" + Strings.Right("0" + Conversion.Hex(bytes[1]), 2);
        }
        else
          str += Strings.Mid(sText, Start, 1);
        checked { ++Start; }
      }
      return str;
    }

    public delegate void dTXTinThread(ref string sText);

    public delegate void dLBL(ref string sText);

    public delegate void dLBL2(ref string sText);

    public class clsTXT
    {
      private object _ref;

      public clsTXT(Form @ref)
      {
        this._ref = (object) @ref;
      }

      public void TXT(ref string sText)
      {
        object Instance = this._ref;
        // ISSUE: variable of the null type
        __Null local1 = null;
        string MemberName = "TXTinThread";
        object[] objArray = new object[1]{ (object) sText };
        object[] Arguments = objArray;
        // ISSUE: variable of the null type
        __Null local2 = null;
        // ISSUE: variable of the null type
        __Null local3 = null;
        bool[] flagArray = new bool[1]{ true };
        bool[] CopyBack = flagArray;
        int num = 1;
        NewLateBinding.LateCall(Instance, (Type) local1, MemberName, Arguments, (string[]) local2, (Type[]) local3, CopyBack, num != 0);
        if (!flagArray[0])
          return;
        sText = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (string));
      }
    }
  }
}
