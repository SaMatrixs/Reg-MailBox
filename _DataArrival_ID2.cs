// Decompiled with JetBrains decompiler
// Type: MailRegUnicore._DataArrival_ID2
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class _DataArrival_ID2
  {
    public static void StartPage_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        if (!_DataArrival_ID2.GetValue_1_METAua(Index, ref sPacketFrom))
        {
          mdConnect.ErrorRegular(Index, ref sPacketFrom);
        }
        else
        {
          string set_PostData = "chField=" + _VARIABLES.CurThreadData[Index].data_METAua.Login.Name + "&chValue=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "&uniq=" + _VARIABLES.CurThreadData[Index].data_METAua.uniq + "&check=1";
          _VARIABLES.WS[Index].ConnectTo = "CheckLogin";
          SocketNET socketNet = _VARIABLES.WS[Index];
          string set_URL = "http://passport.meta.ua/reg/?" + _FUNCTION.MathRandom();
          myCookies set_Cookies = (myCookies) null;
          string set_Referer = "http://passport.meta.ua/?mode=reg&ref=main";
          myProxy set_Proxy = mdConnect.SetProxy(Index);
          _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
          _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
          int index1 = Index;
          int index2 = index1;
          short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
          string set_X_Forwarded_For = (string) null;
          string set_ContentType = (string) null;
          object set_Accept_Charset = (object) 1251;
          string set_Headers_Add = (string) null;
          socketNet.Connect(ref set_URL, ref set_Cookies, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
          curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_1.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void CheckLogin_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        string Left = Strings.Left(sPacketFrom, 8);
        if (Operators.CompareString(Left, "{\"er\":\"0", false) == 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 1;
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          _VARIABLES.WS[Index].ConnectTo = "Captcha";
          SocketNET socketNet = _VARIABLES.WS[Index];
          myCookies set_Cookies = (myCookies) null;
          string set_Referer = "http://passport.meta.ua/?mode=reg&ref=main";
          string set_PostData = (string) null;
          myProxy set_Proxy = mdConnect.SetProxy(Index);
          _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
          _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
          int index1 = Index;
          int index2 = index1;
          short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
          string set_X_Forwarded_For = (string) null;
          string set_ContentType = (string) null;
          object set_Accept_Charset = (object) 1251;
          string set_Headers_Add = (string) null;
          socketNet.Connect(ref _VARIABLES.CurThreadData[Index].data_METAua.captcha_Url, ref set_Cookies, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
          curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
        }
        else if (Operators.CompareString(Left, "{\"er\":\"1", false) == 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 5;
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_2.1]: логин занят";
          fn.TXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_2.2]: Неизвестный пакет проверки Login";
          fn.TXT(ref sText);
          mdConnect.ErrorRegular(Index, ref sPacketFrom);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_2.3]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void Captcha_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        if (_VARIABLES.OP.AutoCAPTCHA)
        {
          _VARIABLES.AC_NET.SendCaptcha(Index, sPacketFrom);
          if (!_VARIABLES.OptionReport[1])
            return;
          string sText = "Thread " + Conversions.ToString(Index) + " send captcha.";
          _FUNCTION.SBTXT(ref sText);
        }
        else
        {
          byte[] bytes = Encoding.Default.GetBytes(sPacketFrom);
          MemoryStream memoryStream = new MemoryStream();
          memoryStream.Write(bytes, 0, bytes.Length);
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_2.Image = Image.FromStream((Stream) memoryStream);
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_2.Refresh();
          if (MyProject.Forms.frmMain.txtCaptcha.CanFocus)
            MyProject.Forms.frmMain.txtCaptcha.Focus();
          _FUNCTION.VisibleRequest(0);
          _FUNCTION.VisibleCapcta(2);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_3.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void Reg_Step1_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        if (Strings.InStr(sPacketFrom, "error-message-short\">Вы ввели неправильные цифры", CompareMethod.Binary) > 0)
        {
          if (_VARIABLES.PlaySound.Use && _VARIABLES.PlaySound.Play[5])
            MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[5]);
          if (!_DataArrival_ID2.GetValue_1_METAua(Index, ref sPacketFrom))
            mdConnect.ErrorRegular(Index, ref sPacketFrom);
          else if (_VARIABLES.OP.AutoCAPTCHA && _VARIABLES.OP.OpAC.ReportBadCaptcha)
          {
            if (_VARIABLES.OptionReport[8])
            {
              string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# META.UA: Неверно указан код защиты.";
              _FUNCTION.SBTXT(ref sText);
            }
            _VARIABLES.AC_NET.BadCaptcha(Index);
          }
          else
          {
            string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# META.UA: Неверно указан код защиты.";
            _FUNCTION.SBTXT(ref sText);
            checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Wrong; }
            _VARIABLES.WS[Index].ConnectTo = "Captcha";
            SocketNET socketNet = _VARIABLES.WS[Index];
            string set_Referer = "http://passport.meta.ua/?mode=reg&ref=main";
            string set_PostData = (string) null;
            myProxy set_Proxy = mdConnect.SetProxy(Index);
            _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
            _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
            int index1 = Index;
            int index2 = index1;
            short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
            string set_X_Forwarded_For = (string) null;
            string set_ContentType = (string) null;
            object set_Accept_Charset = (object) 1251;
            string set_Headers_Add = (string) null;
            socketNet.Connect(ref _VARIABLES.CurThreadData[Index].data_METAua.captcha_Url, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
            curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
          }
        }
        else if (Strings.InStr(sPacketFrom, "error-main\">Регистрация с Вашего адреса временно запрещена", CompareMethod.Binary) > 0)
        {
          checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Lost; }
          string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# META.UA: Превышен лимит регистраций с Вашего IP. Ждите.";
          _FUNCTION.SBTXT(ref sText1);
          if (md_NetworkReboot.NetworkReboot.Use)
          {
            md_NetworkReboot.NetworkReboot.ReconnectRequired = true;
            _VARIABLES.PauseConnect = true;
            _VARIABLES.WS[Index].FreeSocket = true;
            if (MyProject.Forms.frmMain.tmrNetworkReboot.Enabled || !_VARIABLES.DoWork_Reg)
              return;
            string sText2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# NetworkReboot: Ждем завершения всех потоков.";
            _FUNCTION.SBTXT(ref sText2);
            _VARIABLES.AC_NET.StopSoft();
            MyProject.Forms.frmMain.tmrNetworkReboot.Start();
          }
          else if (_VARIABLES.VPN_MD.Use && _VARIABLES.VPN_MD.UseReg)
          {
            _VARIABLES.PauseConnect = true;
            _VARIABLES.WS[Index].FreeSocket = true;
            if (MyProject.Forms.frmMain.tmrVPNReboot.Enabled || !_VARIABLES.DoWork_Reg)
              return;
            MyProject.Forms.frmMain_RasDialex.picVPN_Reboot.Visible = true;
            string sText2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# VPN Reboot: Ждем завершения всех потоков.";
            _FUNCTION.SBTXT(ref sText2);
            _VARIABLES.AC_NET.StopSoft();
            MyProject.Forms.frmMain.tmrVPNReboot.Start();
          }
          else if ((int) _VARIABLES.OP.UsePoxy == 0)
          {
            string sText2 = "Опции безопасности - принудительная остановка регистрации.";
            _FUNCTION.SBTXT(ref sText2);
            MyProject.Forms.frmMain.StopReg();
          }
          else
            _VARIABLES.WS[Index].FreeSocket = true;
        }
        else if (_VARIABLES.WS[Index].ResponseNum != 302)
        {
          checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Lost; }
          if (_VARIABLES.PlaySound.Use && _VARIABLES.PlaySound.Play[3])
            MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[3]);
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_4.0]: нет редиректа";
          fn.TXT(ref sText);
          mdConnect.ErrorRegular(Index, ref sPacketFrom);
        }
        else
        {
          _VARIABLES.CurThreadData[Index].CookiesMail = _VARIABLES.WS[Index].Cookies;
          _VARIABLES.CurThreadData[Index].Referer = _VARIABLES.WS[Index].Location;
          _VARIABLES.WS[Index].ConnectTo = "Reg_Redirect_Step1";
          SocketNET socketNet = _VARIABLES.WS[Index];
          string set_Referer = "http://passport.meta.ua/?mode=reg&ref=main";
          string set_PostData = (string) null;
          myProxy set_Proxy = mdConnect.SetProxy(Index);
          _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
          _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
          int index1 = Index;
          int index2 = index1;
          short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
          string set_X_Forwarded_For = (string) null;
          string set_ContentType = (string) null;
          object set_Accept_Charset = (object) 1251;
          string set_Headers_Add = (string) null;
          socketNet.Connect(ref _VARIABLES.CurThreadData[Index].Referer, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
          curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_4.1]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void Reg_Redirect_Step1_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        if (Strings.InStr(sPacketFrom, "<h1>Дополнительная информация</h1>", CompareMethod.Binary) == 0)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_5.0]: Неизвестный пакет при RegStep1";
          fn.TXT(ref sText);
          checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Lost; }
          mdConnect.ErrorRegular(Index, ref sPacketFrom);
        }
        else
        {
          _VARIABLES.CurThreadData[Index].CookiesMail.Add(_VARIABLES.WS[Index].Cookies);
          int num1 = Strings.InStr(sPacketFrom, "ucrypt\" value=\"", CompareMethod.Binary);
          if (num1 == 0)
          {
            checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Lost; }
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_5.1]: Нет поля 'ucrypt'";
            fn.TXT(ref sText);
            mdConnect.ErrorRegular(Index, ref sPacketFrom);
          }
          else
          {
            int Start = checked (num1 + 15);
            int num2 = Strings.InStr(Start, sPacketFrom, "\"", CompareMethod.Binary);
            string str = _FUNCTION.BrowserDataEncode_Ascii(Strings.Mid(sPacketFrom, Start, checked (num2 - Start)));
            checked { ++_VARIABLES.AC_NET.CapCounter.Cap_OK; }
            _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 4;
            MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
            _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
            StringBuilder stringBuilder = new StringBuilder();
            if ((int) _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Sex == 1)
              stringBuilder.Append("sex=m");
            else
              stringBuilder.Append("sex=f");
            stringBuilder.Append("&birthday=" + Strings.Right("0" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthDay, 2) + "." + Strings.Right("0" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthMonth, 2) + "." + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthYear);
            stringBuilder.Append("&city=2");
            stringBuilder.Append("&register_email=1");
            stringBuilder.Append("&email=");
            stringBuilder.Append("&check_quest=0");
            stringBuilder.Append("&own_check_quest=" + _FUNCTION.ConvertSTRtoHexWeb1byte(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.SecretQuestion));
            stringBuilder.Append("&check_answer=" + _FUNCTION.ConvertSTRtoHexWeb1byte(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.SecretAnswer));
            stringBuilder.Append("&ucrypt=" + str.Replace("+", "%2B"));
            stringBuilder.Append("&subm=%D1%EE%F5%F0%E0%ED%E8%F2%FC");
            _VARIABLES.WS[Index].ConnectTo = "Reg_Step2";
            SocketNET socketNet = _VARIABLES.WS[Index];
            string set_URL = "http://passport.meta.ua/reg/";
            string set_PostData = stringBuilder.ToString();
            myProxy set_Proxy = mdConnect.SetProxy(Index);
            _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
            _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
            int index1 = Index;
            int index2 = index1;
            short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
            string set_X_Forwarded_For = (string) null;
            string set_ContentType = (string) null;
            object set_Accept_Charset = (object) 1251;
            string set_Headers_Add = (string) null;
            socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref _VARIABLES.CurThreadData[Index].Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
            curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Lost; }
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_5.2]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void Reg_Step2_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        _VARIABLES.WS_Data[Index].CaptchaText = "";
        if (Strings.InStr(sPacketFrom, "К сожалению, спам-фильтр определил,", CompareMethod.Binary) > 0)
        {
          string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# META.UA: Спам-фильтр требует дополнительный eMail.";
          _FUNCTION.SBTXT(ref sText1);
          if (md_NetworkReboot.NetworkReboot.Use)
          {
            md_NetworkReboot.NetworkReboot.ReconnectRequired = true;
            _VARIABLES.PauseConnect = true;
            _VARIABLES.WS[Index].FreeSocket = true;
            if (MyProject.Forms.frmMain.tmrNetworkReboot.Enabled || !_VARIABLES.DoWork_Reg)
              return;
            string sText2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# NetworkReboot: Ждем завершения всех потоков.";
            _FUNCTION.SBTXT(ref sText2);
            _VARIABLES.AC_NET.StopSoft();
            MyProject.Forms.frmMain.tmrNetworkReboot.Start();
          }
          else if (_VARIABLES.VPN_MD.Use && _VARIABLES.VPN_MD.UseReg)
          {
            _VARIABLES.PauseConnect = true;
            _VARIABLES.WS[Index].FreeSocket = true;
            if (MyProject.Forms.frmMain.tmrVPNReboot.Enabled || !_VARIABLES.DoWork_Reg)
              return;
            MyProject.Forms.frmMain_RasDialex.picVPN_Reboot.Visible = true;
            string sText2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# VPN Reboot: Ждем завершения всех потоков.";
            _FUNCTION.SBTXT(ref sText2);
            _VARIABLES.AC_NET.StopSoft();
            MyProject.Forms.frmMain.tmrVPNReboot.Start();
          }
          else if ((int) _VARIABLES.OP.UsePoxy == 0)
          {
            string sText2 = "Опции безопасности - принудительная остановка регистрации.";
            _FUNCTION.SBTXT(ref sText2);
            MyProject.Forms.frmMain.StopReg();
          }
          else
            _VARIABLES.WS[Index].FreeSocket = true;
        }
        else if (_VARIABLES.WS[Index].ResponseNum != 302)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_6.0]: Ошибка при подтверждении регистрации.";
          fn.TXT(ref sText);
          mdConnect.ErrorRegular(Index, ref sPacketFrom);
        }
        else
        {
          if (_VARIABLES.OptionReport[7])
          {
            string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# META.UA: Registered - " + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "@" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain;
            _FUNCTION.SBTXT(ref sText);
          }
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 2;
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          if (MyProject.Forms.frmGenBlank.cmbLoadData_Pole8.Enabled)
          {
            _VARIABLES.CurThreadData[Index].CookiesMail.Add(_VARIABLES.WS[Index].Cookies);
            _VARIABLES.WS[Index].ConnectTo = "Reg_EnterAccount_2";
            SocketNET socketNet = _VARIABLES.WS[Index];
            string location = _VARIABLES.WS[Index].Location;
            string set_Referer = "http://passport.meta.ua/reg/";
            string set_PostData = (string) null;
            myProxy set_Proxy = mdConnect.SetProxy(Index);
            _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
            _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
            int index1 = Index;
            int index2 = index1;
            short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
            string set_X_Forwarded_For = (string) null;
            string set_ContentType = (string) null;
            object set_Accept_Charset = (object) 1251;
            string set_Headers_Add = (string) null;
            socketNet.Connect(ref location, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
            curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
          }
          else
          {
            if (_VARIABLES.VPN_MD.RegisteredCount > 0)
            {
              checked { ++_VARIABLES.VPN_MD.RegCount; }
              if (_VARIABLES.VPN_MD.RegCount >= _VARIABLES.VPN_MD.RegisteredCount)
              {
                if (md_NetworkReboot.NetworkReboot.Use)
                {
                  md_NetworkReboot.NetworkReboot.ReconnectRequired = true;
                  _VARIABLES.PauseConnect = true;
                  _VARIABLES.WS[Index].FreeSocket = true;
                  string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# NetworkReboot: " + Conversions.ToString(_VARIABLES.VPN_MD.RegCount) + " MailBox registered. Reboot.";
                  _FUNCTION.SBTXT(ref sText1);
                  if (MyProject.Forms.frmMain.tmrNetworkReboot.Enabled || !_VARIABLES.DoWork_Reg)
                    return;
                  string sText2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# NetworkReboot: Ждем завершения всех потоков.";
                  _FUNCTION.SBTXT(ref sText2);
                  _VARIABLES.AC_NET.StopSoft();
                  MyProject.Forms.frmMain.tmrNetworkReboot.Start();
                  return;
                }
                if (_VARIABLES.VPN_MD.Use && _VARIABLES.VPN_MD.UseReg)
                {
                  _VARIABLES.PauseConnect = true;
                  _VARIABLES.WS[Index].FreeSocket = true;
                  string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# VPN Reboot: " + Conversions.ToString(_VARIABLES.VPN_MD.RegCount) + " MailBox registered. Reconnect.";
                  _FUNCTION.SBTXT(ref sText);
                  if (MyProject.Forms.frmMain.tmrVPNReboot.Enabled || !_VARIABLES.DoWork_Reg)
                    return;
                  MyProject.Forms.frmMain_RasDialex.picVPN_Reboot.Visible = true;
                  sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# VPN Reboot: Ждем завершения всех потоков.";
                  _FUNCTION.SBTXT(ref sText);
                  _VARIABLES.AC_NET.StopSoft();
                  MyProject.Forms.frmMain.tmrVPNReboot.Start();
                  return;
                }
              }
            }
            _VARIABLES.WS[Index].FreeSocket = true;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_6.1]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void EnterAccount_2_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        _VARIABLES.CurThreadData[Index].CookiesMail.Add(_VARIABLES.WS[Index].Cookies);
        _VARIABLES.WS[Index].ConnectTo = "Reg_EnterAccount_3";
        SocketNET socketNet = _VARIABLES.WS[Index];
        string location = _VARIABLES.WS[Index].Location;
        string set_PostData = (string) null;
        myProxy set_Proxy = mdConnect.SetProxy(Index);
        _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
        _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
        int index1 = Index;
        int index2 = index1;
        short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
        string set_X_Forwarded_For = (string) null;
        string set_ContentType = (string) null;
        object set_Accept_Charset = (object) 1251;
        string set_Headers_Add = (string) null;
        socketNet.Connect(ref location, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref _VARIABLES.WS[Index].ConnectOptions.URL, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
        curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_7.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void EnterAccount_3_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        _VARIABLES.CurThreadData[Index].CookiesMail.Add(_VARIABLES.WS[Index].Cookies);
        _VARIABLES.WS[Index].ConnectTo = "Reg_EnterAccount_4";
        SocketNET socketNet = _VARIABLES.WS[Index];
        string set_URL = "http://webmail.meta.ua/settings.php";
        string set_PostData = (string) null;
        myProxy set_Proxy = mdConnect.SetProxy(Index);
        _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
        _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
        int index1 = Index;
        int index2 = index1;
        short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
        string set_X_Forwarded_For = (string) null;
        string set_ContentType = (string) null;
        object set_Accept_Charset = (object) 1251;
        string set_Headers_Add = (string) null;
        socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref _VARIABLES.WS[Index].ConnectOptions.URL, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
        curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_8.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void EnterAccount_4_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        _VARIABLES.CurThreadData[Index].CookiesMail.Add(_VARIABLES.WS[Index].Cookies);
        _VARIABLES.WS[Index].ConnectTo = "Reg_EnterAccount_5";
        SocketNET socketNet = _VARIABLES.WS[Index];
        string location = _VARIABLES.WS[Index].Location;
        string set_PostData = (string) null;
        myProxy set_Proxy = mdConnect.SetProxy(Index);
        _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
        _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
        int index1 = Index;
        int index2 = index1;
        short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
        string set_X_Forwarded_For = (string) null;
        string set_ContentType = (string) null;
        object set_Accept_Charset = (object) 1251;
        string set_Headers_Add = (string) null;
        socketNet.Connect(ref location, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref _VARIABLES.WS[Index].ConnectOptions.URL, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
        curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_9.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void EnterAccount_5_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        _VARIABLES.CurThreadData[Index].CookiesMail.Add(_VARIABLES.WS[Index].Cookies);
        _VARIABLES.WS[Index].ConnectTo = "Reg_EnterAccount_6";
        SocketNET socketNet = _VARIABLES.WS[Index];
        string location = _VARIABLES.WS[Index].Location;
        string set_PostData = (string) null;
        myProxy set_Proxy = mdConnect.SetProxy(Index);
        _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
        _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
        int index1 = Index;
        int index2 = index1;
        short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
        string set_X_Forwarded_For = (string) null;
        string set_ContentType = (string) null;
        object set_Accept_Charset = (object) 1251;
        string set_Headers_Add = (string) null;
        socketNet.Connect(ref location, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref _VARIABLES.WS[Index].ConnectOptions.URL, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
        curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_10.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void EnterAccount_6_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        _VARIABLES.CurThreadData[Index].CookiesMail.Add(_VARIABLES.WS[Index].Cookies);
        _VARIABLES.WS[Index].ConnectTo = "Reg_EnterAccount_7";
        SocketNET socketNet = _VARIABLES.WS[Index];
        string location = _VARIABLES.WS[Index].Location;
        string set_PostData = (string) null;
        myProxy set_Proxy = mdConnect.SetProxy(Index);
        _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
        _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
        int index1 = Index;
        int index2 = index1;
        short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
        string set_X_Forwarded_For = (string) null;
        string set_ContentType = (string) null;
        object set_Accept_Charset = (object) 1251;
        string set_Headers_Add = (string) null;
        socketNet.Connect(ref location, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref _VARIABLES.WS[Index].ConnectOptions.URL, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
        curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_11.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void EnterAccount_7_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        _VARIABLES.CurThreadData[Index].CookiesMail.Add(_VARIABLES.WS[Index].Cookies);
        _VARIABLES.WS[Index].ConnectTo = "Reg_EnterAccount_8";
        SocketNET socketNet = _VARIABLES.WS[Index];
        string set_URL = "http://webmail.meta.ua/settings.php?optpage=POP3_server";
        string set_PostData = (string) null;
        myProxy set_Proxy = mdConnect.SetProxy(Index);
        _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
        _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
        int index1 = Index;
        int index2 = index1;
        short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
        string set_X_Forwarded_For = (string) null;
        string set_ContentType = (string) null;
        object set_Accept_Charset = (object) 1251;
        string set_Headers_Add = (string) null;
        socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref _VARIABLES.WS[Index].ConnectOptions.URL, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
        curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_12.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void EnterAccount_8_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        _VARIABLES.CurThreadData[Index].CookiesMail.Add(_VARIABLES.WS[Index].Cookies);
        string set_PostData = "optpage=POP3_server&optmode=submit&new_POP3_server=2&submit=%D1%EE%F5%F0%E0%ED%E8%F2%FC";
        _VARIABLES.WS[Index].ConnectTo = "Reg_EnterAccount_9";
        SocketNET socketNet = _VARIABLES.WS[Index];
        string set_URL = "http://webmail.meta.ua/settings.php";
        myProxy set_Proxy = mdConnect.SetProxy(Index);
        _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
        _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
        int index1 = Index;
        int index2 = index1;
        short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
        string set_X_Forwarded_For = (string) null;
        string set_ContentType = (string) null;
        object set_Accept_Charset = (object) 1251;
        string set_Headers_Add = (string) null;
        socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref _VARIABLES.CurThreadData[Index].Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
        curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_13.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void EnterAccount_9_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        if (Strings.InStr(sPacketFrom, "<b>Настройки успешно сохранены: Настройка POP3/SMTP сервера</b>", CompareMethod.Binary) > 0)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + " META.UA: POP3/SMTP разблокировано";
          fn.TXT(ref sText);
          if (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].comment.Length == 0)
            _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].comment = "POP3/SMTP unlocked";
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
        }
        else
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + " META.UA: Unlock failed (step 9)";
          fn.TXT(ref sText);
        }
        _VARIABLES.WS[Index].FreeSocket = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_14.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void CheckMail_WebFace_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        if (_VARIABLES.VPN_MD.Use && _VARIABLES.VPN_MD.UseDownloadMail)
        {
          checked { ++_VARIABLES.VPN_MD.MailCount; }
          if (_VARIABLES.VPN_MD.MailCount >= _VARIABLES.VPN_MD.DownloadMailCount)
          {
            _VARIABLES.PauseConnect = true;
            MyProject.Forms.frmMain.tmrVPNReboot.Start();
          }
        }
        int num = !Information.IsNothing((object) _VARIABLES.WS[Index].Cookies) ? _VARIABLES.WS[Index].Cookies.Count : 0;
        if (_VARIABLES.WS[Index].ResponseNum == 302 && num > 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 3;
          if (Operators.CompareString(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].comment, "Antispam Banned", false) == 0)
            _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].comment = "";
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# +OK";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else if (_VARIABLES.WS[Index].ResponseNum == 302 && num == 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 4;
          if (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].comment.Length == 0)
            _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].comment = "Antispam Banned";
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# !Antispam Banned";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else if (_VARIABLES.WS[Index].ResponseNum == 200 && Strings.InStr(sPacketFrom, "не существует в нашей системе", CompareMethod.Binary) > 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 6;
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Bad Login/Password";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else if (_VARIABLES.WS[Index].ResponseNum == 200 && Strings.InStr(sPacketFrom, "Вам запрещен вход на сайт", CompareMethod.Binary) > 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 6;
          if (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].comment.Length == 0)
            _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].comment = "SpamBot";
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Подозрение на спамбот.";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else
        {
          string str;
          if (_VARIABLES.DebugOp.SavePacket_RegError)
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Save Packet to '" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_Incorrect.packet.CheckWebInterface_METAua.log'";
            fn.TXT(ref sText);
            string sFileName = Conversions.ToString(_VARIABLES.Mirror[Index]) + "_Incorrect.packet.CheckWebInterface_METAua.log";
            str = _VARIABLES.WS[Index].PacketHEAD + "\r\n" + sPacketFrom;
            _LOADSAVE.Save(ref sFileName, ref str);
          }
          _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
          str = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Неизвестный пакет от meta.ua";
          fn1.TXT(ref str);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_15.0]" + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void ReloadCaptcha_ID_2(int Index, ref string sPacketFrom)
    {
      try
      {
        int Start1 = checked (Strings.InStr(sPacketFrom, "\"", CompareMethod.Binary) + 1);
        int num1 = Strings.InStr(Start1, sPacketFrom, "\"", CompareMethod.Binary);
        string set_URL = Strings.Mid(sPacketFrom, Start1, checked (num1 - Start1)).Replace("\\/", "/");
        int Start2 = checked (Strings.InStr(num1 + 1, sPacketFrom, "\"", CompareMethod.Binary) + 1);
        int num2 = Strings.InStr(Start2, sPacketFrom, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].data_METAua.rand_digit = Strings.Mid(sPacketFrom, Start2, checked (num2 - Start2));
        _VARIABLES.WS[Index].ConnectTo = "Captcha";
        SocketNET socketNet = _VARIABLES.WS[Index];
        string set_Referer = "http://passport.meta.ua/?mode=reg&ref=main";
        string set_PostData = (string) null;
        myProxy set_Proxy = mdConnect.SetProxy(Index);
        _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
        _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
        int index1 = Index;
        int index2 = index1;
        short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
        string set_X_Forwarded_For = (string) null;
        string set_ContentType = (string) null;
        object set_Accept_Charset = (object) 1251;
        string set_Headers_Add = (string) null;
        socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
        curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_16.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    private static bool GetValue_1_METAua(int Index, ref string sPacketFrom)
    {
      bool flag;
      try
      {
        string empty = string.Empty;
        int Start1 = Strings.InStr(sPacketFrom, "class=\"fields", CompareMethod.Binary);
        string str;
        if (Start1 == 0)
        {
          str = "Нет формы 'Post'";
        }
        else
        {
          int num1 = Strings.InStr(Start1, sPacketFrom, "name=\"", CompareMethod.Binary);
          if (num1 == 0)
          {
            str = "Отсутствует поле 'Name'";
          }
          else
          {
            int Start2 = checked (num1 + 6);
            int Start3 = Strings.InStr(Start2, sPacketFrom, "\"", CompareMethod.Binary);
            _VARIABLES.CurThreadData[Index].data_METAua.Name.Name = Strings.Mid(sPacketFrom, Start2, checked (Start3 - Start2));
            _VARIABLES.CurThreadData[Index].data_METAua.Name.Value = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Name;
            int num2 = Strings.InStr(Start3, sPacketFrom, "name=\"", CompareMethod.Binary);
            if (num2 == 0)
            {
              str = "Отсутствует поле 'LastName'";
            }
            else
            {
              int Start4 = checked (num2 + 6);
              int Start5 = Strings.InStr(Start4, sPacketFrom, "\"", CompareMethod.Binary);
              _VARIABLES.CurThreadData[Index].data_METAua.Lastname.Name = Strings.Mid(sPacketFrom, Start4, checked (Start5 - Start4));
              _VARIABLES.CurThreadData[Index].data_METAua.Lastname.Value = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.LastName;
              int num3 = Strings.InStr(Start5, sPacketFrom, "name=\"", CompareMethod.Binary);
              if (num3 == 0)
              {
                str = "Отсутствует поле 'Login'";
              }
              else
              {
                int Start6 = checked (num3 + 6);
                int Start7 = Strings.InStr(Start6, sPacketFrom, "\"", CompareMethod.Binary);
                _VARIABLES.CurThreadData[Index].data_METAua.Login.Name = Strings.Mid(sPacketFrom, Start6, checked (Start7 - Start6));
                _VARIABLES.CurThreadData[Index].data_METAua.Login.Value = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login;
                int num4 = Strings.InStr(Start7, sPacketFrom, "name=\"", CompareMethod.Binary);
                if (num4 == 0)
                {
                  str = "Отсутствует поле 'Password1'";
                }
                else
                {
                  int Start8 = checked (num4 + 6);
                  int Start9 = Strings.InStr(Start8, sPacketFrom, "\"", CompareMethod.Binary);
                  _VARIABLES.CurThreadData[Index].data_METAua.Password1.Name = Strings.Mid(sPacketFrom, Start8, checked (Start9 - Start8));
                  _VARIABLES.CurThreadData[Index].data_METAua.Password1.Value = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password;
                  int num5 = Strings.InStr(Start9, sPacketFrom, "name=\"", CompareMethod.Binary);
                  if (num5 == 0)
                  {
                    str = "Отсутствует поле 'Password2'";
                  }
                  else
                  {
                    int Start10 = checked (num5 + 6);
                    int Start11 = Strings.InStr(Start10, sPacketFrom, "\"", CompareMethod.Binary);
                    _VARIABLES.CurThreadData[Index].data_METAua.Password2.Name = Strings.Mid(sPacketFrom, Start10, checked (Start11 - Start10));
                    _VARIABLES.CurThreadData[Index].data_METAua.Password2.Value = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password;
                    int num6 = Strings.InStr(Start11, sPacketFrom, "uniq\" value=\"", CompareMethod.Binary);
                    if (num6 == 0)
                    {
                      str = "Отсутствует поле 'uniq'";
                    }
                    else
                    {
                      int Start12 = checked (num6 + 13);
                      int Start13 = Strings.InStr(Start12, sPacketFrom, "\"", CompareMethod.Binary);
                      _VARIABLES.CurThreadData[Index].data_METAua.uniq = Strings.Mid(sPacketFrom, Start12, checked (Start13 - Start12));
                      int Start14 = Strings.InStr(Start13, sPacketFrom, "http://static.meta.ua/captcha", CompareMethod.Binary);
                      if (Start14 == 0)
                      {
                        str = "Нет ссылки на CAPTCHA!";
                      }
                      else
                      {
                        int Start15 = Strings.InStr(Start14, sPacketFrom, "\"", CompareMethod.Binary);
                        _VARIABLES.CurThreadData[Index].data_METAua.captcha_Url = Strings.Mid(sPacketFrom, Start14, checked (Start15 - Start14));
                        int num7 = Strings.InStr(Start15, sPacketFrom, "rand_digit\" value=\"", CompareMethod.Binary);
                        if (num7 == 0)
                        {
                          str = "Отсутствует поле 'uniq'";
                        }
                        else
                        {
                          int Start16 = checked (num7 + 19);
                          int num8 = Strings.InStr(Start16, sPacketFrom, "\"", CompareMethod.Binary);
                          _VARIABLES.CurThreadData[Index].data_METAua.rand_digit = Strings.Mid(sPacketFrom, Start16, checked (num8 - Start16));
                          flag = true;
                          goto label_21;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_20.0]: " + str;
        _FUNCTION.SBTXT(ref sText);
        flag = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[meta.ua_20.1]: " + exception.Message;
        fn.TXT(ref sText);
        flag = false;
        ProjectData.ClearProjectError();
      }
label_21:
      return flag;
    }

    public struct myMETAua
    {
      public _VARIABLES.myWebVar Name;
      public _VARIABLES.myWebVar Lastname;
      public _VARIABLES.myWebVar Login;
      public _VARIABLES.myWebVar Password1;
      public _VARIABLES.myWebVar Password2;
      public string captcha_Url;
      public string uniq;
      public string rand_digit;
    }
  }
}
