// Decompiled with JetBrains decompiler
// Type: MailRegUnicore._DataArrival_ID0
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class _DataArrival_ID0
  {
    public static _DataArrival_ID0.myMailRu_City MailRu_City = new _DataArrival_ID0.myMailRu_City();

    public static void StartPage_ID_0(int Index, ref string sPacketFrom)
    {
      try
      {
        if (Strings.InStr(sPacketFrom, "<title>Регистрация -", CompareMethod.Binary) == 0)
        {
          string str1;
          if (_VARIABLES.DebugOp.SavePacket_RegError)
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string str2 = "Save Packet to '" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_StartPage.packet.log'";
            fn.TXT(ref str2);
            str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "_StartPage.packet.log";
            str1 = _VARIABLES.WS[Index].PacketHEAD + "\r\n" + sPacketFrom;
            _LOADSAVE.Save(ref str2, ref str1);
          }
          if (_VARIABLES.UseErrorCount)
          {
            checked { ++_VARIABLES.ErrorCountInWork; }
            if (_VARIABLES.ErrorCountInWork > _VARIABLES.ErrorCount)
            {
              str1 = "Счетчик ошибок превысил лимит (настройки регистрации).";
              _FUNCTION.SBTXT(ref str1);
              str1 = "Опции безопасности - принудительная остановка регистрации.";
              _FUNCTION.SBTXT(ref str1);
              MyProject.Forms.frmMain.StopReg();
              return;
            }
          }
          if (Information.IsNothing((object) sPacketFrom) || sPacketFrom.Length < 20)
          {
            int Index1 = Index;
            str1 = "Empty packet from Proxy.";
            mdConnect.ErrorEvent(Index1, ref str1);
          }
          else
          {
            int Index1 = Index;
            str1 = "Unknown StartPage!";
            mdConnect.ErrorEvent(Index1, ref str1);
          }
        }
        else if (Strings.InStr(sPacketFrom, "У меня нет мобильного телефона", CompareMethod.Binary) == 0)
        {
          if (md_NetworkReboot.NetworkReboot.Use)
          {
            md_NetworkReboot.NetworkReboot.ReconnectRequired = true;
            _VARIABLES.PauseConnect = true;
            _VARIABLES.WS[Index].FreeSocket = true;
            string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: Много регистраций с текущего IP.";
            _FUNCTION.SBTXT(ref sText1);
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
            string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: Много регистраций с текущего IP.";
            _FUNCTION.SBTXT(ref sText1);
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
            string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: Много регистраций с текущего IP.";
            _FUNCTION.SBTXT(ref sText1);
            string sText2 = "Принудительная остановка регистрации.";
            _FUNCTION.SBTXT(ref sText2);
            sText2 = "Вы используете прямой коннект, mail.ru запрашивает обязательное указание номера телефона.";
            _FUNCTION.SBTXT(ref sText2);
            sText2 = "Включите использование прокси или подождите ~30 минут.";
            _FUNCTION.SBTXT(ref sText2);
            string sText3 = "Если у Вас динамический IP, включите и настройте функцию NetWork Reboot или RasDialEx.";
            _FUNCTION.SBTXT(ref sText3);
            MyProject.Forms.frmMain.StopReg();
            _VARIABLES.WS[Index].FreeSocket = true;
          }
          else
          {
            int Index1 = Index;
            string Description = "Много регистраций с текущего IP.";
            mdConnect.ErrorEvent(Index1, ref Description);
          }
        }
        else if (!_DataArrival_ID0.UnmakePacket_MailRU(ref sPacketFrom, Index))
        {
          if (_VARIABLES.UseErrorCount)
          {
            checked { ++_VARIABLES.ErrorCountInWork; }
            if (_VARIABLES.ErrorCountInWork > _VARIABLES.ErrorCount)
            {
              string sText1 = "Счетчик ошибок превысил лимит (настройки регистрации).";
              _FUNCTION.SBTXT(ref sText1);
              string sText2 = "Опции безопасности - принудительная остановка регистрации.";
              _FUNCTION.SBTXT(ref sText2);
              MyProject.Forms.frmMain.StopReg();
              return;
            }
          }
          string str;
          if (_VARIABLES.DebugOp.SavePacket_RegError)
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            str = "Save Packet to '" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_ErrorRegular.unknown.log'";
            fn.TXT(ref str);
            str = Conversions.ToString(_VARIABLES.Mirror[Index]) + "_ErrorRegular.unknown.log";
            string sData = _VARIABLES.WS[Index].PacketHEAD + "\r\n" + sPacketFrom;
            _LOADSAVE.Save(ref str, ref sData);
          }
          int Index1 = Index;
          str = "Неправильные данные пакета.";
          mdConnect.ErrorEvent(Index1, ref str);
        }
        else
        {
          _VARIABLES.CurThreadData[Index].CookiesMail = _VARIABLES.WS[Index].Cookies;
          string set_PostData = _VARIABLES.CurThreadData[Index].PostDataLine[26] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[26] + "&" + _VARIABLES.CurThreadData[Index].PostDataLine[25] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[25] + "&" + _VARIABLES.CurThreadData[Index].PostDataLine[10] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[10] + "&" + _VARIABLES.CurThreadData[Index].PostDataLine[22] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[22] + "&" + _VARIABLES.CurThreadData[Index].PostDataLine[21] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[21] + "&" + _VARIABLES.CurThreadData[Index].PostDataLine[20] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[20] + "&" + _VARIABLES.CurThreadData[Index].PostDataLine[18] + "=" + md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Name) + "&" + _VARIABLES.CurThreadData[Index].PostDataLine[19] + "=" + md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.LastName) + "&" + _VARIABLES.CurThreadData[Index].PostDataLine[24] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[24] + "&Signup_utf8=1&LANG=ru_RU";
          _VARIABLES.WS[Index].ConnectTo = "check_mail";
          SocketNET socketNet = _VARIABLES.WS[Index];
          string set_URL = "https://e.mail.ru/cgi-bin/checklogin";
          string set_Referer = (string) null;
          myProxy set_Proxy = mdConnect.SetProxy(Index);
          _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
          _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
          int index1 = Index;
          int index2 = index1;
          short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
          string set_X_Forwarded_For = (string) null;
          string set_ContentType = (string) null;
          object set_Accept_Charset = (object) "utf-8";
          string set_Headers_Add = "X-Requested-With: XMLHttpRequest";
          socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
          curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[mail.ru_1.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void CheckMail_ID_0(int Index, ref string sPacketFrom)
    {
      try
      {
        MyProject.Forms.frmMain.LV_Dostupno.Items.Clear();
        if (sPacketFrom.Length == 0)
        {
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Check login no response!";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else
        {
          _VARIABLES.CurThreadData[Index].FreeMailDomain = Strings.Split(sPacketFrom, "\n", -1, CompareMethod.Binary);
          string str = _VARIABLES.CurThreadData[Index].FreeMailDomain[0];
          if (Operators.CompareString(str, "EX_USEREXIST", false) == 0)
            str = "101";
          int num1 = checked ((int) Math.Round(Conversion.Val(str)));
          _VARIABLES.CurThreadData[Index].FreeMailDomain[0] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "@" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain;
          ListViewItem[] listViewItemArray = new ListViewItem[checked (Information.UBound((Array) _VARIABLES.CurThreadData[Index].FreeMailDomain, 1) + 1)];
          string[] items = new string[2]
          {
            "current",
            _VARIABLES.CurThreadData[Index].FreeMailDomain[0]
          };
          listViewItemArray[0] = new ListViewItem(items);
          int num2 = 1;
          int num3 = Information.UBound((Array) _VARIABLES.CurThreadData[Index].FreeMailDomain, 1);
          int index1 = num2;
          while (index1 <= num3)
          {
            items[0] = Conversions.ToString(index1);
            items[1] = _VARIABLES.CurThreadData[Index].FreeMailDomain[index1];
            listViewItemArray[index1] = new ListViewItem(items);
            checked { ++index1; }
          }
          MyProject.Forms.frmMain.LV_Dostupno.Items.AddRange(((IEnumerable<ListViewItem>) listViewItemArray).ToArray<ListViewItem>());
          MyProject.Forms.frmMain.LV_Dostupno.Items[0].UseItemStyleForSubItems = false;
          switch (num1)
          {
            case 0:
              _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 1;
              _VARIABLES.CurThreadData[Index].CurrentMailToReg = _VARIABLES.CurThreadData[Index].FreeMailDomain[0];
              MyProject.Forms.frmMain.LV_Dostupno.Items[0].SubItems[0].BackColor = Color.LawnGreen;
              MyProject.Forms.frmMain.LV_Dostupno.Items[0].SubItems[1].BackColor = Color.LawnGreen;
              break;
            case 101:
              _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 5;
              MyProject.Forms.frmMain.LV_Dostupno.Items[0].SubItems[0].BackColor = Color.Red;
              MyProject.Forms.frmMain.LV_Dostupno.Items[0].SubItems[1].BackColor = Color.Red;
              if (Information.UBound((Array) _VARIABLES.CurThreadData[Index].FreeMailDomain, 1) == 0)
              {
                string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Нет доступных вариантов для регистрации.";
                _FUNCTION.SBTXT(ref sText);
                _VARIABLES.WS[Index].FreeSocket = true;
                return;
              }
              if (!_VARIABLES.OP.OpReg.LoginNotFree)
              {
                _VARIABLES.WS[Index].FreeSocket = true;
                return;
              }
              int index2 = 1;
              switch (_VARIABLES.OP.OpReg.ActionChoise)
              {
                case 0:
                  index2 = _FUNCTION.sRND.Next(1, ((IEnumerable<string>) _VARIABLES.CurThreadData[Index].FreeMailDomain).Count<string>());
                  break;
                case 1:
                  int num4 = 1;
                  short num5 = checked ((short) Information.UBound((Array) _VARIABLES.CurThreadData[Index].FreeMailDomain, 1));
                  short num6 = (short) num4;
                  while ((int) num6 <= (int) num5)
                  {
                    if (Operators.CompareString(Strings.Right(_VARIABLES.CurThreadData[Index].FreeMailDomain[(int) num6], Strings.Len(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain)), _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain, false) == 0 && Operators.CompareString(_VARIABLES.CurThreadData[Index].FreeMailDomain[(int) num6], _VARIABLES.CurThreadData[Index].FreeMailDomain[0], false) != 0)
                    {
                      index2 = (int) num6;
                      break;
                    }
                    checked { ++num6; }
                  }
                  if ((int) num6 > Information.UBound((Array) _VARIABLES.CurThreadData[Index].FreeMailDomain, 1))
                  {
                    string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Для текущего домена нет вариантов.";
                    _FUNCTION.SBTXT(ref sText);
                    _VARIABLES.WS[Index].FreeSocket = true;
                    return;
                  }
                  break;
                case 2:
                  index2 = (int) _VARIABLES.OP.OpReg.NumSelectAccount;
                  break;
              }
              _VARIABLES.CurThreadData[Index].CurrentMailToReg = _VARIABLES.CurThreadData[Index].FreeMailDomain[index2];
              string[] strArray = _VARIABLES.CurThreadData[Index].CurrentMailToReg.Split('@');
              _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login = strArray[0];
              _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain = strArray[1];
              break;
            case 102:
            case 109:
              if (!_VARIABLES.OP.OpReg.LoginNotFree)
              {
                string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Forbidden login." + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login;
                _FUNCTION.SBTXT(ref sText);
                _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 6;
                _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
                MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
                _VARIABLES.WS[Index].FreeSocket = true;
                return;
              }
              string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Запрещенный логин " + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login;
              _FUNCTION.SBTXT(ref sText1);
              _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login = Conversions.ToString(mdGenWORD.GenFastLogin());
              string sText2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Логин заменен на: <" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + ">";
              _FUNCTION.SBTXT(ref sText2);
              mdConnect.StartPage(Index);
              return;
            case 108:
              if (!_VARIABLES.OP.OpReg.LoginNotFree)
              {
                string sText3 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Bad name&lastname." + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login;
                _FUNCTION.SBTXT(ref sText3);
                _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 5;
                _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
                MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
                _VARIABLES.WS[Index].FreeSocket = true;
                return;
              }
              string sText4 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Login already in use and a bad name&lastname." + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login;
              _FUNCTION.SBTXT(ref sText4);
              _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login = Conversions.ToString(mdGenWORD.GenFastLogin());
              string sText5 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Логин заменен на: <" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + ">";
              _FUNCTION.SBTXT(ref sText5);
              mdConnect.StartPage(Index);
              return;
            default:
              string sText6 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Unknown code Mail Check <" + Conversions.ToString(num1) + ">";
              _FUNCTION.SBTXT(ref sText6);
              _VARIABLES.WS[Index].FreeSocket = true;
              return;
          }
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.txtCurrentMail.Text = _VARIABLES.CurThreadData[Index].CurrentMailToReg;
          _VARIABLES.CurThreadData[Index].PostDataVariable[25] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login;
          _VARIABLES.CurThreadData[Index].PostDataVariable[26] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain;
          _VARIABLES.WS[Index].ConnectTo = "captcha_1_domain1";
          SocketNET socketNet = _VARIABLES.WS[Index];
          string set_Referer = "https://e.mail.ru/signup?from=main_noc";
          string set_PostData = (string) null;
          myProxy set_Proxy = mdConnect.SetProxy(Index);
          _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
          _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
          int index3 = Index;
          int index4 = index3;
          short curUserAgent = (short) meCurThreadDataArray[index4].CurUserAgent;
          string set_X_Forwarded_For = (string) null;
          string set_ContentType = (string) null;
          object set_Accept_Charset = (object) 1251;
          string set_Headers_Add = (string) null;
          socketNet.Connect(ref _VARIABLES.CurThreadData[Index].CaptchaRef_1, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
          curThreadData[index3].CurUserAgent = checked ((byte) curUserAgent);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[mail.ru_2.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void Captcha1_ID_0(int Index, ref string sPacketFrom)
    {
      try
      {
        if (_VARIABLES.CurThreadData[Index].CaptchaRef_2.Length == 0)
        {
          if (_VARIABLES.PlaySound.Use && _VARIABLES.PlaySound.Play[1])
            MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[1]);
          string sText;
          if (_VARIABLES.OptionReport[5])
          {
            sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Новая капча mail.ru";
            _FUNCTION.SBTXT(ref sText);
          }
          if (_VARIABLES.OP.AutoCAPTCHA)
          {
            _VARIABLES.AC_NET.SendCaptcha(Index, sPacketFrom);
            if (!_VARIABLES.OptionReport[1])
              return;
            sText = "Thread " + Conversions.ToString(Index) + " send captcha.";
            _FUNCTION.SBTXT(ref sText);
          }
          else
          {
            if (!MyProject.Forms.frmNewCaptchaMailRU.Visible)
            {
              MyProject.Forms.frmNewCaptchaMailRU.WindowState = FormWindowState.Normal;
              MyProject.Forms.frmNewCaptchaMailRU.Show();
            }
            _FUNCTION.VisibleRequest(0);
            _FUNCTION.VisibleCapcta(0);
            byte[] bytes = Encoding.Default.GetBytes(sPacketFrom);
            MemoryStream memoryStream = new MemoryStream();
            memoryStream.Write(bytes, 0, bytes.Length);
            MyProject.Forms.frmNewCaptchaMailRU.picVOTE_CAPTCHA_0.Image = Image.FromStream((Stream) memoryStream);
            MyProject.Forms.frmNewCaptchaMailRU.picVOTE_CAPTCHA_0.Refresh();
            if (!MyProject.Forms.frmMain.txtCaptcha.CanFocus)
              return;
            MyProject.Forms.frmMain.txtCaptcha.Focus();
          }
        }
        else
        {
          byte[] bytes = Encoding.Default.GetBytes(sPacketFrom);
          MemoryStream memoryStream = new MemoryStream();
          memoryStream.Write(bytes, 0, bytes.Length);
          _VARIABLES.CurThreadData[Index].BitmapBuffer = new Bitmap(225, 51);
          Graphics graphics = Graphics.FromImage((Image) _VARIABLES.CurThreadData[Index].BitmapBuffer);
          graphics.DrawImage(Image.FromStream((Stream) memoryStream), 0, 0);
          graphics.Dispose();
          _VARIABLES.WS[Index].ConnectTo = "captcha_2_domain1";
          SocketNET socketNet = _VARIABLES.WS[Index];
          string set_Referer = "https://e.mail.ru/signup?from=main_noc";
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
          socketNet.Connect(ref _VARIABLES.CurThreadData[Index].CaptchaRef_2, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
          curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[mail.ru_3.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void Captcha2_ID_0(int Index, ref string sPacketFrom)
    {
      try
      {
        byte[] bytes = Encoding.Default.GetBytes(sPacketFrom);
        MemoryStream memoryStream = new MemoryStream();
        memoryStream.Write(bytes, 0, bytes.Length);
        Graphics graphics = Graphics.FromImage((Image) _VARIABLES.CurThreadData[Index].BitmapBuffer);
        graphics.DrawImage(Image.FromStream((Stream) memoryStream), 75, 0);
        graphics.Dispose();
        _VARIABLES.WS[Index].ConnectTo = "captcha_3_domain1";
        SocketNET socketNet = _VARIABLES.WS[Index];
        string set_Referer = "https://e.mail.ru/signup?from=main_noc";
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
        socketNet.Connect(ref _VARIABLES.CurThreadData[Index].CaptchaRef_3, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
        curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[mail.ru_4.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void Captcha3_ID_0(int Index, ref string sPacketFrom)
    {
      try
      {
        byte[] bytes = Encoding.Default.GetBytes(sPacketFrom);
        MemoryStream memoryStream1 = new MemoryStream();
        memoryStream1.Write(bytes, 0, bytes.Length);
        Graphics graphics = Graphics.FromImage((Image) _VARIABLES.CurThreadData[Index].BitmapBuffer);
        graphics.DrawImage(Image.FromStream((Stream) memoryStream1), 150, 0);
        graphics.Dispose();
        if (_VARIABLES.PlaySound.Use && _VARIABLES.PlaySound.Play[1])
          MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[1]);
        if (_VARIABLES.OP.AutoCAPTCHA)
        {
          MemoryStream memoryStream2 = new MemoryStream();
          _VARIABLES.CurThreadData[Index].BitmapBuffer.Save((Stream) memoryStream2, ImageFormat.Jpeg);
          string CaptchaData = Encoding.Default.GetString(memoryStream2.GetBuffer());
          _VARIABLES.AC_NET.SendCaptcha(Index, CaptchaData);
          if (!_VARIABLES.OptionReport[1])
            return;
          string sText = "Thread " + Conversions.ToString(Index) + " send captcha.";
          _FUNCTION.SBTXT(ref sText);
        }
        else
        {
          _FUNCTION.VisibleRequest(0);
          _FUNCTION.VisibleCapcta(0);
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_0.Image = (Image) _VARIABLES.CurThreadData[Index].BitmapBuffer;
          MyProject.Forms.frmMain.picVOTE_CAPTCHA_0.Refresh();
          if (!MyProject.Forms.frmMain.txtCaptcha.CanFocus)
            return;
          MyProject.Forms.frmMain.txtCaptcha.Focus();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[mail.ru_5.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void AjaxCaptchaCheck_ID_0(int Index, ref string sPacketFrom)
    {
      try
      {
        if (Strings.InStr(sPacketFrom, "AjaxResponse", CompareMethod.Binary) != 0)
        {
          sPacketFrom = Strings.Mid(sPacketFrom, 2, checked (sPacketFrom.Length - 2));
          sPacketFrom = sPacketFrom.Replace("\"", string.Empty);
          sPacketFrom = sPacketFrom.Replace(" ", string.Empty);
          string[] strArray = sPacketFrom.Split(',');
          if (Information.UBound((Array) strArray, 1) == 2)
          {
            short integer = checked ((short) Conversions.ToInteger(strArray[2]));
            StringBuilder stringBuilder = new StringBuilder();
            int index1 = Information.UBound((Array) _VARIABLES.CurThreadData[Index].PostDataLine, 1);
            int num1 = 1;
            int num2 = checked (index1 - 1);
            int index2 = num1;
            while (index2 <= num2)
            {
              stringBuilder.Append(_VARIABLES.CurThreadData[Index].PostDataLine[index2] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[index2] + "&");
              checked { ++index2; }
            }
            stringBuilder.Append(_VARIABLES.CurThreadData[Index].PostDataLine[index1] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[index1]);
            _VARIABLES.WS[Index].ConnectTo = "reg_domain1";
            SocketNET socketNet = _VARIABLES.WS[Index];
            string set_URL = "https://e.mail.ru/reg?from=main_noc";
            string set_Referer = "https://e.mail.ru/signup?from=main";
            string set_PostData = stringBuilder.ToString();
            myProxy set_Proxy = mdConnect.SetProxy(Index);
            _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
            _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
            int index3 = Index;
            int index4 = index3;
            short curUserAgent = (short) meCurThreadDataArray[index4].CurUserAgent;
            string set_X_Forwarded_For = (string) null;
            string set_ContentType = (string) null;
            object set_Accept_Charset = (object) "utf-8";
            string set_Headers_Add = (string) null;
            socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
            curThreadData[index3].CurUserAgent = checked ((byte) curUserAgent);
            return;
          }
        }
        checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Lost; }
        if (_VARIABLES.PlaySound.Use && _VARIABLES.PlaySound.Play[3])
          MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[3]);
        string sText1;
        if (_VARIABLES.DebugOp.SavePacket_RegError)
        {
          string sText2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Unknown packet at '" + _VARIABLES.WS[Index].ConnectTo + "' save to _unknown.packet.checkCaptcha.log";
          _FUNCTION.SBTXT(ref sText2);
          string sFileName = Conversions.ToString(_VARIABLES.Mirror[Index]) + "_unknown.packet.checkCaptcha.log";
          string sData = _VARIABLES.WS[Index].PacketHEAD + "\r\n" + sPacketFrom;
          _LOADSAVE.Save(ref sFileName, ref sData);
        }
        else
        {
          sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Unknown packet at '" + _VARIABLES.WS[Index].ConnectTo + "'";
          _FUNCTION.SBTXT(ref sText1);
        }
        if (_VARIABLES.UseErrorCount)
        {
          checked { ++_VARIABLES.ErrorCountInWork; }
          if (_VARIABLES.ErrorCountInWork > _VARIABLES.ErrorCount)
          {
            sText1 = "Счетчик ошибок превысил лимит (настройки регистрации).";
            _FUNCTION.SBTXT(ref sText1);
            sText1 = "Опции безопасности - принудительная остановка регистрации.";
            _FUNCTION.SBTXT(ref sText1);
            MyProject.Forms.frmMain.StopReg();
            return;
          }
        }
        if (md_NetworkReboot.NetworkReboot.Use)
        {
          md_NetworkReboot.NetworkReboot.ReconnectRequired = true;
          _VARIABLES.PauseConnect = true;
          _VARIABLES.WS[Index].FreeSocket = true;
          if (MyProject.Forms.frmMain.tmrNetworkReboot.Enabled || !_VARIABLES.DoWork_Reg)
            return;
          sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# NetworkReboot: Ждем завершения всех потоков.";
          _FUNCTION.SBTXT(ref sText1);
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
          sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# VPN Reboot: Ждем завершения всех потоков.";
          _FUNCTION.SBTXT(ref sText1);
          _VARIABLES.AC_NET.StopSoft();
          MyProject.Forms.frmMain.tmrVPNReboot.Start();
        }
        else if (_VARIABLES.OP.OpReg.ReconnectUnknownPacket)
        {
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else
        {
          sText1 = "У вас выключен реконнект при Unknown Packet.";
          _FUNCTION.SBTXT(ref sText1);
          sText1 = "Опции безопасности - принудительная остановка регистрации.";
          _FUNCTION.SBTXT(ref sText1);
          MyProject.Forms.frmMain.StopReg();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[mail.ru_6.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void Reg_ID_0(int Index, ref string sPacketFrom)
    {
      try
      {
        _VARIABLES.WS_Data[Index].CaptchaText = "";
        if (!Information.IsNothing((object) _VARIABLES.WS[Index].Location))
        {
          if (_VARIABLES.PlaySound.Use && _VARIABLES.PlaySound.Play[4])
            MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[4]);
          checked { ++_VARIABLES.AC_NET.CapCounter.Cap_OK; }
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login = _VARIABLES.CurThreadData[Index].PostDataVariable[25];
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain = _VARIABLES.CurThreadData[Index].PostDataVariable[26];
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 2;
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].DataCreateBox = Conversions.ToString(DateAndTime.Now);
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          if (_VARIABLES.OptionReport[7])
          {
            string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: Registered - " + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "@" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain;
            _FUNCTION.SBTXT(ref sText);
          }
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
        else if (Strings.InStr(sPacketFrom, "Неверно указан код</td></tr></", CompareMethod.Binary) > 0)
        {
          if (_VARIABLES.PlaySound.Use && _VARIABLES.PlaySound.Play[5])
            MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[5]);
          if (_VARIABLES.OP.AutoCAPTCHA && _VARIABLES.OP.OpAC.ReportBadCaptcha)
          {
            if (_VARIABLES.OptionReport[8])
            {
              string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: Неверно указан код защиты.";
              _FUNCTION.SBTXT(ref sText);
            }
            _VARIABLES.AC_NET.BadCaptcha(Index);
          }
          else
          {
            string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: Неверно указан код защиты.";
            _FUNCTION.SBTXT(ref sText);
            checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Wrong; }
            _VARIABLES.WS[Index].FreeSocket = true;
          }
        }
        else
        {
          string str1;
          string str2;
          if (_VARIABLES.UseBannedProxy)
          {
            str1 = Application.StartupPath + "\\data\\BannedProxy.txt";
            str2 = _VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].IP + ":" + Conversions.ToString(_VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].Port) + "\n";
            _LOADSAVE.FileAppend(ref str1, ref str2);
          }
          checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Lost; }
          if (_VARIABLES.DebugOp.SaveBadIP)
          {
            string StrBuffer = _VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].IP + ":" + Conversions.ToString(_VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].Port) + "\n";
            str2 = Application.StartupPath + "\\BadIP_LostCaptcha.log";
            _LOADSAVE.FileAppend(ref str2, ref StrBuffer);
          }
          if (_VARIABLES.DebugOp.FullSessionLog)
          {
            str2 = Application.StartupPath + "\\" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_session_LostCaptcha.log";
            str1 = _VARIABLES.CurThreadData[Index].SessionLog.ToString();
            _LOADSAVE.FileSave(ref str2, ref str1);
            _VARIABLES.CurThreadData[Index].SessionLog = (StringBuilder) null;
          }
          if (_VARIABLES.PlaySound.Use && _VARIABLES.PlaySound.Play[3])
            MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[3]);
          if (_VARIABLES.UseErrorCount)
          {
            checked { ++_VARIABLES.ErrorCountInWork; }
            if (_VARIABLES.ErrorCountInWork > _VARIABLES.ErrorCount)
            {
              str2 = "Счетчик ошибок превысил лимит (настройки регистрации).";
              _FUNCTION.SBTXT(ref str2);
              str2 = "Опции безопасности - принудительная остановка регистрации.";
              _FUNCTION.SBTXT(ref str2);
              MyProject.Forms.frmMain.StopReg();
              return;
            }
          }
          if (Strings.InStr(sPacketFrom, "Регистрация в данном домене невозможна", CompareMethod.Binary) > 0)
          {
            str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: Регистрация в данном домене невозможна.";
            _FUNCTION.SBTXT(ref str2);
            _VARIABLES.WS[Index].FreeSocket = true;
          }
          else if (Strings.InStr(sPacketFrom, "Регистрация с Вашего IP адреса невозможна", CompareMethod.Binary) > 0)
          {
            str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: IP заблокирован.";
            _FUNCTION.SBTXT(ref str2);
            if (md_NetworkReboot.NetworkReboot.Use)
            {
              md_NetworkReboot.NetworkReboot.ReconnectRequired = true;
              _VARIABLES.PauseConnect = true;
              _VARIABLES.WS[Index].FreeSocket = true;
              if (MyProject.Forms.frmMain.tmrNetworkReboot.Enabled || !_VARIABLES.DoWork_Reg)
                return;
              str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# NetworkReboot: Ждем завершения всех потоков.";
              _FUNCTION.SBTXT(ref str2);
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
              str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# VPN Reboot: Ждем завершения всех потоков.";
              _FUNCTION.SBTXT(ref str2);
              _VARIABLES.AC_NET.StopSoft();
              MyProject.Forms.frmMain.tmrVPNReboot.Start();
            }
            else
              _VARIABLES.WS[Index].FreeSocket = true;
          }
          else if (Strings.InStr(sPacketFrom, "Превышен лимит регистраций с Вашего IP", CompareMethod.Binary) > 0)
          {
            str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: Превышен лимит регистраций с Вашего IP. Ждите.";
            _FUNCTION.SBTXT(ref str2);
            if (md_NetworkReboot.NetworkReboot.Use)
            {
              md_NetworkReboot.NetworkReboot.ReconnectRequired = true;
              _VARIABLES.PauseConnect = true;
              _VARIABLES.WS[Index].FreeSocket = true;
              if (MyProject.Forms.frmMain.tmrNetworkReboot.Enabled || !_VARIABLES.DoWork_Reg)
                return;
              str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# NetworkReboot: Ждем завершения всех потоков.";
              _FUNCTION.SBTXT(ref str2);
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
              str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# VPN Reboot: Ждем завершения всех потоков.";
              _FUNCTION.SBTXT(ref str2);
              _VARIABLES.AC_NET.StopSoft();
              MyProject.Forms.frmMain.tmrVPNReboot.Start();
            }
            else if ((int) _VARIABLES.OP.UsePoxy == 0)
            {
              str2 = "Опции безопасности - принудительная остановка регистрации.";
              _FUNCTION.SBTXT(ref str2);
              MyProject.Forms.frmMain.StopReg();
            }
            else
              _VARIABLES.WS[Index].FreeSocket = true;
          }
          else if (Strings.InStr(sPacketFrom, "Домен неизвестен системе", CompareMethod.Binary) > 0)
          {
            str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: Домен неизвестен системе.";
            _FUNCTION.SBTXT(ref str2);
            _VARIABLES.WS[Index].FreeSocket = true;
          }
          else if (Strings.InStr(sPacketFrom, "Пользователь с таким именем уже зарегистрирован", CompareMethod.Binary) > 0)
          {
            str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: Пользователь с таким именем уже зарегистрирован.";
            _FUNCTION.SBTXT(ref str2);
            _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 6;
            _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
            MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
            _VARIABLES.WS[Index].FreeSocket = true;
          }
          else if (Strings.InStr(sPacketFrom, "E-mail Имя почтового ящика должно состоять из латинских букв, цифр, символа", CompareMethod.Binary) > 0)
          {
            str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: Логин не соответствует стандарту.";
            _FUNCTION.SBTXT(ref str2);
            _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 6;
            _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
            MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
            _VARIABLES.WS[Index].FreeSocket = true;
          }
          else
          {
            int num1 = Strings.InStr(sPacketFrom, "<b>Ошибка регистрации</b>", CompareMethod.Binary);
            if (num1 > 0)
            {
              int num2 = Strings.InStr(checked (num1 + 32), sPacketFrom, "<td>", CompareMethod.Binary);
              if (num2 > 0)
              {
                int Start = checked (num2 + 4);
                int num3 = Strings.InStr(Start, sPacketFrom, "</td>", CompareMethod.Binary);
                if (num3 > 0 && checked (num3 - Start) < 200)
                {
                  string str3 = Strings.Trim(Strings.Mid(sPacketFrom, Start, checked (num3 - Start)).Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace("<b>", "").Replace("</b>", "").Replace("<br>", "\r\n"));
                  if (_VARIABLES.DebugOp.SavePacket_RegError)
                  {
                    str2 = Application.StartupPath + "\\data\\" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_Ошибка регистрации.html";
                    _LOADSAVE.FileSave(ref str2, ref sPacketFrom);
                  }
                  str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# MAIL.RU: " + str3;
                  _FUNCTION.SBTXT(ref str2);
                  if (md_NetworkReboot.NetworkReboot.Use)
                  {
                    md_NetworkReboot.NetworkReboot.ReconnectRequired = true;
                    _VARIABLES.PauseConnect = true;
                    _VARIABLES.WS[Index].FreeSocket = true;
                    if (MyProject.Forms.frmMain.tmrNetworkReboot.Enabled || !_VARIABLES.DoWork_Reg)
                      return;
                    str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# NetworkReboot: Ждем завершения всех потоков.";
                    _FUNCTION.SBTXT(ref str2);
                    _VARIABLES.AC_NET.StopSoft();
                    MyProject.Forms.frmMain.tmrNetworkReboot.Start();
                    return;
                  }
                  if (_VARIABLES.VPN_MD.Use && _VARIABLES.VPN_MD.UseReg)
                  {
                    _VARIABLES.PauseConnect = true;
                    _VARIABLES.WS[Index].FreeSocket = true;
                    if (MyProject.Forms.frmMain.tmrVPNReboot.Enabled || !_VARIABLES.DoWork_Reg)
                      return;
                    MyProject.Forms.frmMain_RasDialex.picVPN_Reboot.Visible = true;
                    str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# VPN Reboot: Ждем завершения всех потоков.";
                    _FUNCTION.SBTXT(ref str2);
                    _VARIABLES.AC_NET.StopSoft();
                    MyProject.Forms.frmMain.tmrVPNReboot.Start();
                    return;
                  }
                  _VARIABLES.WS[Index].FreeSocket = true;
                  return;
                }
              }
            }
            if (_VARIABLES.DebugOp.SavePacket_RegError)
            {
              str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Неизвестный пакет. Сохранен в лог " + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_unknown.packet.afterreg.log ";
              _FUNCTION.SBTXT(ref str2);
              str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "_unknown.packet.afterreg.log";
              str1 = _VARIABLES.WS[Index].PacketHEAD + "\r\n" + sPacketFrom;
              _LOADSAVE.Save(ref str2, ref str1);
            }
            else
            {
              str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Unknown packet at '" + _VARIABLES.WS[Index].ConnectTo + "'";
              _FUNCTION.SBTXT(ref str2);
            }
            if (_VARIABLES.OP.OpReg.ReconnectUnknownPacket)
            {
              _VARIABLES.WS[Index].FreeSocket = true;
            }
            else
            {
              str2 = "У вас выключен реконнект при Unknown Packet.";
              _FUNCTION.SBTXT(ref str2);
              str2 = "Опции безопасности - принудительная остановка регистрации.";
              _FUNCTION.SBTXT(ref str2);
              MyProject.Forms.frmMain.StopReg();
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[mail.ru_7.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void CheckMail_WebFace_ID_0(int Index, ref string sPacketFrom)
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
        if (Strings.InStr(sPacketFrom, "e.mail.ru/cgi-bin/msglist?back=1", CompareMethod.Binary) > 0 || Strings.InStr(sPacketFrom, "e.mail.ru/messages/inbox/?back=1", CompareMethod.Binary) > 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 2;
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# +OK";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else if (Strings.InStr(sPacketFrom, "&fail=1\">", CompareMethod.Binary) > 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 6;
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Bad Login/Password";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else if (Strings.InStr(sPacketFrom, "e.mail.ru/cgi-bin/editpass", CompareMethod.Binary) > 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 4;
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# !BANNED";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else if (Strings.InStr(sPacketFrom, "&fail=1&at=1\">", CompareMethod.Binary) > 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 7;
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Закрыт за неиспользование";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else
        {
          if (_VARIABLES.DebugOp.SavePacket_RegError)
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Save Packet to '" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_Incorrect.packet.CheckWebInterface_MAILru.log'";
            fn.TXT(ref sText);
            string sFileName = Conversions.ToString(_VARIABLES.Mirror[Index]) + "_Incorrect.packet.CheckWebInterface_MAILru.log";
            string sData = _VARIABLES.WS[Index].PacketHEAD + "\r\n" + sPacketFrom;
            _LOADSAVE.Save(ref sFileName, ref sData);
          }
          _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
          string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Неправильные данные пакета на вход, Mail.ru изменил ход аутентификации.";
          fn1.TXT(ref sText1);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[mail.ru_8.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static bool UnmakePacket_MailRU(ref string sPacket, int Index)
    {
      int index = _DataArrival_ID0.MailRu_City.Return_Num_City(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.City);
      _VARIABLES.CurThreadData[Index].PostDataLine[1] = "signup_b";
      _VARIABLES.CurThreadData[Index].PostDataVariable[1] = "1";
      _VARIABLES.CurThreadData[Index].PostDataLine[2] = "sms";
      _VARIABLES.CurThreadData[Index].PostDataVariable[2] = "1";
      _VARIABLES.CurThreadData[Index].PostDataLine[3] = "no_mobile";
      _VARIABLES.CurThreadData[Index].PostDataVariable[3] = "1";
      _VARIABLES.CurThreadData[Index].PostDataLine[4] = "ID";
      int Start1 = checked (Strings.InStr(sPacket, "name=\"ID", CompareMethod.Binary) + 17);
      if (Start1 != 0)
      {
        int Start2 = Strings.InStr(Start1, sPacket, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].PostDataVariable[4] = Strings.Mid(sPacket, Start1, checked (Start2 - Start1));
        _VARIABLES.CurThreadData[Index].PostDataLine[5] = "Count";
        _VARIABLES.CurThreadData[Index].PostDataVariable[5] = "1";
        _VARIABLES.CurThreadData[Index].PostDataLine[6] = "back";
        _VARIABLES.CurThreadData[Index].PostDataVariable[6] = "";
        _VARIABLES.CurThreadData[Index].PostDataLine[7] = "browserData";
        _VARIABLES.CurThreadData[Index].PostDataVariable[7] = "NoJS";
        _VARIABLES.CurThreadData[Index].PostDataLine[8] = "Mrim.Country";
        _VARIABLES.CurThreadData[Index].PostDataVariable[8] = Conversions.ToString((int) _DataArrival_ID0.MailRu_City.Mrim_Country[index]);
        _VARIABLES.CurThreadData[Index].PostDataLine[9] = "Mrim.Region";
        _VARIABLES.CurThreadData[Index].PostDataVariable[9] = Conversions.ToString((int) _DataArrival_ID0.MailRu_City.Mrim_Region[index]);
        _VARIABLES.CurThreadData[Index].PostDataLine[10] = "x_reg_id";
        int Start3 = checked (Strings.InStr(Start2, sPacket, "name=\"x_reg_id", CompareMethod.Binary) + 23);
        if (Start3 != 0)
        {
          int Start4 = Strings.InStr(Start3, sPacket, "\"", CompareMethod.Binary);
          _VARIABLES.CurThreadData[Index].PostDataVariable[10] = Strings.Mid(sPacket, Start3, checked (Start4 - Start3));
          _VARIABLES.CurThreadData[Index].PostDataLine[11] = "security_image_id";
          _VARIABLES.CurThreadData[Index].PostDataVariable[11] = "";
          _VARIABLES.CurThreadData[Index].PostDataLine[12] = "geo_countryId";
          _VARIABLES.CurThreadData[Index].PostDataVariable[12] = _DataArrival_ID0.MailRu_City.country_id[index];
          _VARIABLES.CurThreadData[Index].PostDataLine[13] = "geo_cityId";
          _VARIABLES.CurThreadData[Index].PostDataVariable[13] = _DataArrival_ID0.MailRu_City.city_id[index];
          _VARIABLES.CurThreadData[Index].PostDataLine[14] = "geo_regionId";
          _VARIABLES.CurThreadData[Index].PostDataVariable[14] = _DataArrival_ID0.MailRu_City.region_id[index];
          _VARIABLES.CurThreadData[Index].PostDataLine[15] = "geo_country";
          _VARIABLES.CurThreadData[Index].PostDataVariable[15] = "";
          _VARIABLES.CurThreadData[Index].PostDataLine[16] = "geo_place";
          _VARIABLES.CurThreadData[Index].PostDataVariable[16] = "";
          _VARIABLES.CurThreadData[Index].PostDataLine[17] = "lang";
          _VARIABLES.CurThreadData[Index].PostDataVariable[17] = "ru_RU";
          int Start5 = Strings.InStr(Start4, sPacket, ">Имя</", CompareMethod.Binary);
          if (Start5 != 0)
          {
            int Start6 = checked (Strings.InStr(Start5, sPacket, "name=\"", CompareMethod.Binary) + 6);
            int Start7 = Strings.InStr(Start6, sPacket, "\"", CompareMethod.Binary);
            _VARIABLES.CurThreadData[Index].PostDataLine[18] = Strings.Mid(sPacket, Start6, checked (Start7 - Start6));
            _VARIABLES.CurThreadData[Index].PostDataVariable[18] = md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Name);
            int Start8 = Strings.InStr(Start7, sPacket, ">Фамилия</", CompareMethod.Binary);
            if (Start8 != 0)
            {
              int Start9 = checked (Strings.InStr(Start8, sPacket, "name=\"", CompareMethod.Binary) + 6);
              int Start10 = Strings.InStr(Start9, sPacket, "\"", CompareMethod.Binary);
              _VARIABLES.CurThreadData[Index].PostDataLine[19] = Strings.Mid(sPacket, Start9, checked (Start10 - Start9));
              _VARIABLES.CurThreadData[Index].PostDataVariable[19] = md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.LastName);
              int Start11 = Strings.InStr(Start10, sPacket, "День рождения", CompareMethod.Binary);
              if (Start11 != 0)
              {
                int Start12 = checked (Strings.InStr(Start11, sPacket, "name=\"", CompareMethod.Binary) + 6);
                int Start13 = Strings.InStr(Start12, sPacket, "\"", CompareMethod.Binary);
                _VARIABLES.CurThreadData[Index].PostDataLine[20] = Strings.Mid(sPacket, Start12, checked (Start13 - Start12));
                _VARIABLES.CurThreadData[Index].PostDataVariable[20] = Conversions.ToString(Conversion.Val(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthDay));
                _VARIABLES.CurThreadData[Index].PostDataLine[21] = "BirthMonth";
                _VARIABLES.CurThreadData[Index].PostDataVariable[21] = Conversions.ToString(Conversion.Val(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthMonth));
                int Start14 = checked (Strings.InStr(Start13, sPacket, "name=\"", CompareMethod.Binary) + 6);
                if (Start14 != 0)
                {
                  int Start15 = checked (Strings.InStr(Start14, sPacket, "name=\"", CompareMethod.Binary) + 6);
                  int Start16 = Strings.InStr(Start15, sPacket, "\"", CompareMethod.Binary);
                  _VARIABLES.CurThreadData[Index].PostDataLine[22] = Strings.Mid(sPacket, Start15, checked (Start16 - Start15));
                  _VARIABLES.CurThreadData[Index].PostDataVariable[22] = Conversions.ToString(Conversion.Val(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthYear));
                  _VARIABLES.CurThreadData[Index].PostDataLine[23] = "your_town";
                  _VARIABLES.CurThreadData[Index].PostDataVariable[23] = md_MailFunctions.ConvertSTRtoUTF8(ref _DataArrival_ID0.MailRu_City.full_path[index]);
                  int Start17 = Strings.InStr(Start16, sPacket, ">Пол<", CompareMethod.Binary);
                  if (Start17 != 0)
                  {
                    int Start18 = checked (Strings.InStr(Start17, sPacket, "name=\"", CompareMethod.Binary) + 6);
                    int Start19 = Strings.InStr(Start18, sPacket, "\"", CompareMethod.Binary);
                    _VARIABLES.CurThreadData[Index].PostDataLine[24] = Strings.Mid(sPacket, Start18, checked (Start19 - Start18));
                    _VARIABLES.CurThreadData[Index].PostDataVariable[24] = Conversions.ToString((int) _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Sex);
                    int Start20 = Strings.InStr(Start19, sPacket, ">Почтовый ящик<", CompareMethod.Binary);
                    if (Start20 != 0)
                    {
                      int Start21 = checked (Strings.InStr(Start20, sPacket, "name=\"", CompareMethod.Binary) + 6);
                      int Start22 = Strings.InStr(Start21, sPacket, "\"", CompareMethod.Binary);
                      _VARIABLES.CurThreadData[Index].PostDataLine[25] = Strings.Mid(sPacket, Start21, checked (Start22 - Start21));
                      _VARIABLES.CurThreadData[Index].PostDataVariable[25] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login;
                      if (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login.Length < 4 | _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login.Length > 31)
                      {
                        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
                        string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Имя почтового ящика должно быть длиной от 4 до 31 символа.";
                        fn1.TXT(ref sText1);
                        _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login.Length >= 4 ? Strings.Left(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login, 30) : _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + Conversions.ToString(_FUNCTION.sRND.Next(111111111, 999999999));
                        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
                        string sText2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Логин исправлен на <" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + ">";
                        fn2.TXT(ref sText2);
                      }
                      _VARIABLES.CurThreadData[Index].PostDataLine[26] = "RegistrationDomain";
                      _VARIABLES.CurThreadData[Index].PostDataVariable[26] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain;
                      int Start23 = Strings.InStr(Start22, sPacket, ">Пароль</", CompareMethod.Binary);
                      if (Start23 != 0)
                      {
                        int Start24 = checked (Strings.InStr(Start23, sPacket, "name=\"", CompareMethod.Binary) + 6);
                        int Start25 = Strings.InStr(Start24, sPacket, "\"", CompareMethod.Binary);
                        _VARIABLES.CurThreadData[Index].PostDataLine[27] = Strings.Mid(sPacket, Start24, checked (Start25 - Start24));
                        _VARIABLES.CurThreadData[Index].PostDataVariable[27] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password;
                        int Start26 = Strings.InStr(Start25, sPacket, ">Повторите пароль</", CompareMethod.Binary);
                        if (Start26 != 0)
                        {
                          int Start27 = checked (Strings.InStr(Start26, sPacket, "name=\"", CompareMethod.Binary) + 6);
                          int Start28 = Strings.InStr(Start27, sPacket, "\"", CompareMethod.Binary);
                          _VARIABLES.CurThreadData[Index].PostDataLine[28] = Strings.Mid(sPacket, Start27, checked (Start28 - Start27));
                          _VARIABLES.CurThreadData[Index].PostDataVariable[28] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password;
                          _VARIABLES.CurThreadData[Index].PostDataLine[29] = "RemindPhoneCode";
                          _VARIABLES.CurThreadData[Index].PostDataVariable[29] = "7";
                          _VARIABLES.CurThreadData[Index].PostDataLine[30] = "RemindPhone";
                          _VARIABLES.CurThreadData[Index].PostDataVariable[30] = "";
                          _VARIABLES.CurThreadData[Index].PostDataLine[31] = "Password_Question";
                          _VARIABLES.CurThreadData[Index].PostDataVariable[31] = "Custom";
                          int Start29 = Strings.InStr(Start28, sPacket, ">Свой вопрос</", CompareMethod.Binary);
                          if (Start29 != 0)
                          {
                            int Start30 = checked (Strings.InStr(Start29, sPacket, "name=\"", CompareMethod.Binary) + 6);
                            int Start31 = Strings.InStr(Start30, sPacket, "\"", CompareMethod.Binary);
                            _VARIABLES.CurThreadData[Index].PostDataLine[32] = Strings.Mid(sPacket, Start30, checked (Start31 - Start30));
                            _VARIABLES.CurThreadData[Index].PostDataVariable[32] = md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.SecretQuestion);
                            int Start32 = Strings.InStr(Start31, sPacket, ">Ответ</", CompareMethod.Binary);
                            if (Start32 != 0)
                            {
                              int Start33 = checked (Strings.InStr(Start32, sPacket, "name=\"", CompareMethod.Binary) + 6);
                              int Start34 = Strings.InStr(Start33, sPacket, "\"", CompareMethod.Binary);
                              _VARIABLES.CurThreadData[Index].PostDataLine[33] = Strings.Mid(sPacket, Start33, checked (Start34 - Start33));
                              _VARIABLES.CurThreadData[Index].PostDataVariable[33] = md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.SecretAnswer);
                              int Start35 = Strings.InStr(Start34, sPacket, ">Дополнительный", CompareMethod.Binary);
                              if (Start35 != 0)
                              {
                                int Start36 = checked (Strings.InStr(Start35, sPacket, "name=\"", CompareMethod.Binary) + 6);
                                int Start37 = Strings.InStr(Start36, sPacket, "\"", CompareMethod.Binary);
                                _VARIABLES.CurThreadData[Index].PostDataLine[34] = Strings.Mid(sPacket, Start36, checked (Start37 - Start36));
                                _VARIABLES.CurThreadData[Index].PostDataVariable[34] = "";
                                int Start38 = Strings.InStr(Start37, sPacket, "c.mail.ru/", CompareMethod.Binary);
                                if (Start38 == 0)
                                {
                                  int Start39 = Strings.InStr(Start37, sPacket, "x_image?", CompareMethod.Binary);
                                  if (Start39 > 0)
                                  {
                                    int Start40 = Strings.InStr(Start39, sPacket, "\"", CompareMethod.Binary);
                                    _VARIABLES.CurThreadData[Index].CaptchaRef_1 = "http://e.mail.ru/cgi-bin/" + Strings.Mid(sPacket, Start39, checked (Start40 - Start39)) + "&r=" + _FUNCTION.TimeForRandom((short) -4);
                                    int Start41 = Strings.InStr(Start40, sPacket, "x_image?", CompareMethod.Binary);
                                    if (Start41 != 0)
                                    {
                                      int Start42 = Strings.InStr(Start41, sPacket, "\"", CompareMethod.Binary);
                                      _VARIABLES.CurThreadData[Index].CaptchaRef_2 = "http://e.mail.ru/cgi-bin/" + Strings.Mid(sPacket, Start41, checked (Start42 - Start41)) + "&r=" + _FUNCTION.TimeForRandom((short) -4);
                                      int Start43 = Strings.InStr(Start42, sPacket, "x_image?", CompareMethod.Binary);
                                      if (Start43 != 0)
                                      {
                                        Start37 = Strings.InStr(Start43, sPacket, "\"", CompareMethod.Binary);
                                        _VARIABLES.CurThreadData[Index].CaptchaRef_3 = "http://e.mail.ru/cgi-bin/" + Strings.Mid(sPacket, Start43, checked (Start37 - Start43)) + "&r=" + _FUNCTION.TimeForRandom((short) -4);
                                      }
                                      else
                                        goto label_26;
                                    }
                                    else
                                      goto label_26;
                                  }
                                  else if (Operators.CompareString(Strings.Left(_VARIABLES.CurThreadData[Index].PostDataVariable[10], 6), "regV3_", false) == 0)
                                  {
                                    _VARIABLES.CurThreadData[Index].CaptchaRef_1 = "http://e.mail.ru/cgi-bin/x_image?num=1&x_reg_id=" + _VARIABLES.CurThreadData[Index].PostDataVariable[10] + "&r=" + _FUNCTION.TimeForRandom((short) -4);
                                    _VARIABLES.CurThreadData[Index].CaptchaRef_2 = "http://e.mail.ru/cgi-bin/x_image?num=2&x_reg_id=" + _VARIABLES.CurThreadData[Index].PostDataVariable[10] + "&r=" + _FUNCTION.TimeForRandom((short) -4);
                                    _VARIABLES.CurThreadData[Index].CaptchaRef_3 = "http://e.mail.ru/cgi-bin/x_image?num=3&x_reg_id=" + _VARIABLES.CurThreadData[Index].PostDataVariable[10] + "&r=" + _FUNCTION.TimeForRandom((short) -4);
                                  }
                                  else
                                  {
                                    _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
                                    string str = "Старый метод, нет ссылки на капчу.";
                                    fn1.TXT(ref str);
                                    _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
                                    str = "Сохранен лог в файл log_" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_nourlcaptcha.html";
                                    fn2.TXT(ref str);
                                    str = Application.StartupPath + "\\data\\log_" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_nourlcaptcha.html";
                                    _LOADSAVE.FileSave(ref str, ref sPacket);
                                    return false;
                                  }
                                }
                                else
                                {
                                  Start37 = Strings.InStr(Start38, sPacket, "\"", CompareMethod.Binary);
                                  _VARIABLES.CurThreadData[Index].CaptchaRef_1 = "http://" + Strings.Mid(sPacket, Start38, checked (Start37 - Start38));
                                  _VARIABLES.CurThreadData[Index].CaptchaRef_2 = string.Empty;
                                  _VARIABLES.CurThreadData[Index].CaptchaRef_3 = string.Empty;
                                }
                                int Start44 = Strings.InStr(Start37, sPacket, ">Код на картинке</", CompareMethod.Binary);
                                if (Start44 != 0)
                                {
                                  int Start39 = checked (Strings.InStr(Start44, sPacket, "name=\"", CompareMethod.Binary) + 6);
                                  int num = Strings.InStr(Start39, sPacket, "\"", CompareMethod.Binary);
                                  _VARIABLES.CurThreadData[Index].PostDataLine[35] = Strings.Mid(sPacket, Start39, checked (num - Start39));
                                  _VARIABLES.CurThreadData[Index].PostDataVariable[35] = "";
                                  return true;
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
label_26:
      return false;
    }

    public static void Mail_ru_Refresh_Captcha(int Index)
    {
      int Length = Strings.InStrRev(_VARIABLES.CurThreadData[Index].CaptchaRef_1, "=", -1, CompareMethod.Binary);
      _VARIABLES.CurThreadData[Index].CaptchaRef_1 = Strings.Left(_VARIABLES.CurThreadData[Index].CaptchaRef_1, Length);
      _VARIABLES.meCurThreadData[] curThreadData1 = _VARIABLES.CurThreadData;
      _VARIABLES.meCurThreadData[] meCurThreadDataArray1 = curThreadData1;
      int index1 = Index;
      int index2 = index1;
      meCurThreadDataArray1[index2].CaptchaRef_1 = curThreadData1[index1].CaptchaRef_1 + _FUNCTION.TimeForRandom((short) -4);
      if (_VARIABLES.CurThreadData[Index].CaptchaRef_2.Length > 0)
      {
        _VARIABLES.CurThreadData[Index].CaptchaRef_2 = Strings.Left(_VARIABLES.CurThreadData[Index].CaptchaRef_2, Length);
        _VARIABLES.meCurThreadData[] curThreadData2 = _VARIABLES.CurThreadData;
        _VARIABLES.meCurThreadData[] meCurThreadDataArray2 = curThreadData2;
        int index3 = Index;
        int index4 = index3;
        meCurThreadDataArray2[index4].CaptchaRef_2 = curThreadData2[index3].CaptchaRef_2 + _FUNCTION.TimeForRandom((short) -4);
        _VARIABLES.CurThreadData[Index].CaptchaRef_3 = Strings.Left(_VARIABLES.CurThreadData[Index].CaptchaRef_3, Length);
        _VARIABLES.meCurThreadData[] curThreadData3 = _VARIABLES.CurThreadData;
        _VARIABLES.meCurThreadData[] meCurThreadDataArray3 = curThreadData3;
        int index5 = Index;
        int index6 = index5;
        meCurThreadDataArray3[index6].CaptchaRef_3 = curThreadData3[index5].CaptchaRef_3 + _FUNCTION.TimeForRandom((short) -4);
      }
      _VARIABLES.WS[Index].ConnectTo = "captcha_1_domain1";
      SocketNET socketNet = _VARIABLES.WS[Index];
      string set_Referer = "https://e.mail.ru/signup?from=main_noc";
      string set_PostData = (string) null;
      myProxy set_Proxy = mdConnect.SetProxy(Index);
      _VARIABLES.meCurThreadData[] curThreadData4 = _VARIABLES.CurThreadData;
      _VARIABLES.meCurThreadData[] meCurThreadDataArray4 = curThreadData4;
      int index7 = Index;
      int index8 = index7;
      short curUserAgent = (short) meCurThreadDataArray4[index8].CurUserAgent;
      string set_X_Forwarded_For = (string) null;
      string set_ContentType = (string) null;
      object set_Accept_Charset = (object) 1251;
      string set_Headers_Add = (string) null;
      socketNet.Connect(ref _VARIABLES.CurThreadData[Index].CaptchaRef_1, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
      curThreadData4[index7].CurUserAgent = checked ((byte) curUserAgent);
    }

    public static void UnCloseAccEnter_ID_0(int Index, string sPacketFrom)
    {
      if (Strings.InStr(sPacketFrom, "Адрес " + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "@" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain + " не заблокирован", CompareMethod.Binary) > 0)
      {
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# eMail не заблокирован.";
        _FUNCTION.SBTXT(ref sText);
        _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 2;
        _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
        MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
        _VARIABLES.WS[Index].FreeSocket = true;
      }
      else if (Strings.InStr(sPacketFrom, "введите пароль от ящика", CompareMethod.Binary) == 0)
      {
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Отсутствует страница для восстановления.";
        _FUNCTION.SBTXT(ref sText);
        _VARIABLES.WS[Index].FreeSocket = true;
      }
      else
      {
        _VARIABLES.WS[Index].ConnectTo = "UnClose Acc Final";
        string set_URL = "https://e.mail.ru/cgi-bin/enableuser";
        string set_PostData = "login=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "&domain=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain + "&Password=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password;
        SocketNET socketNet = _VARIABLES.WS[Index];
        myCookies set_Cookies = (myCookies) null;
        string set_Referer = "http://mail.ru/";
        myProxy set_Proxy = mdConnect.SetProxy(Index);
        _VARIABLES.meCurThreadData[] curThreadData = _VARIABLES.CurThreadData;
        _VARIABLES.meCurThreadData[] meCurThreadDataArray = curThreadData;
        int index1 = Index;
        int index2 = index1;
        short curUserAgent = (short) meCurThreadDataArray[index2].CurUserAgent;
        string set_X_Forwarded_For = (string) null;
        string set_ContentType = (string) null;
        object set_Accept_Charset = (object) "utf-8";
        string set_Headers_Add = (string) null;
        socketNet.Connect(ref set_URL, ref set_Cookies, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
        curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
      }
    }

    public static void UnCloseAccFinal_ID_0(int Index, string sPacketFrom)
    {
      if (Strings.InStr(sPacketFrom, "Неверный пароль от почтового ящика", CompareMethod.Binary) > 0)
      {
        _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 4;
        _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
        MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Неверный пароль от почтового ящика.";
        _FUNCTION.SBTXT(ref sText);
        _VARIABLES.WS[Index].FreeSocket = true;
      }
      else if (Strings.InStr(sPacketFrom, "Redirect to ", CompareMethod.Binary) > 0)
      {
        _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 2;
        _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
        MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Разблокирован.";
        _FUNCTION.SBTXT(ref sText);
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
              sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# NetworkReboot: " + Conversions.ToString(_VARIABLES.VPN_MD.RegCount) + " MailBox registered. Reboot.";
              _FUNCTION.SBTXT(ref sText);
              if (MyProject.Forms.frmMain.tmrNetworkReboot.Enabled || !_VARIABLES.DoWork_Reg)
                return;
              sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# NetworkReboot: Ждем завершения всех потоков.";
              _FUNCTION.SBTXT(ref sText);
              _VARIABLES.AC_NET.StopSoft();
              MyProject.Forms.frmMain.tmrNetworkReboot.Start();
              return;
            }
            if (_VARIABLES.VPN_MD.Use && _VARIABLES.VPN_MD.UseReg)
            {
              _VARIABLES.PauseConnect = true;
              _VARIABLES.WS[Index].FreeSocket = true;
              sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# VPN Reboot: " + Conversions.ToString(_VARIABLES.VPN_MD.RegCount) + " MailBox registered. Reconnect.";
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
      else
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
    }

    public struct myMAILru
    {
      public string strDebug;
      public string Captcha;
    }

    public class myMailRu_City
    {
      public short[] Mrim_Country;
      public short[] Mrim_Region;
      public string[] country_id;
      public string[] city_id;
      public string[] region_id;
      public string[] name;
      public string[] full_path;

      public myMailRu_City()
      {
        this.Mrim_Country = new short[14];
        this.Mrim_Region = new short[14];
        this.city_id = new string[14];
        this.country_id = new string[14];
        this.name = new string[14];
        this.full_path = new string[14];
        this.region_id = new string[14];
        this.Mrim_Country[1] = (short) 24;
        this.Mrim_Region[1] = (short) 226;
        this.city_id[1] = Conversions.ToString(226);
        this.country_id[1] = Conversions.ToString(24);
        this.name[1] = "Санкт-Петербург";
        this.full_path[1] = "Санкт-Петербург, Россия";
        this.region_id[1] = Conversions.ToString(999998);
        this.Mrim_Country[2] = (short) 24;
        this.Mrim_Region[2] = (short) 25;
        this.city_id[2] = Conversions.ToString(25);
        this.country_id[2] = Conversions.ToString(24);
        this.name[2] = "Москва";
        this.full_path[2] = "Москва, Россия";
        this.region_id[2] = Conversions.ToString(999999);
        this.Mrim_Country[3] = (short) 24;
        this.Mrim_Region[3] = (short) 1479;
        this.city_id[3] = Conversions.ToString(1479);
        this.country_id[3] = Conversions.ToString(24);
        this.name[3] = "Новосибирск";
        this.full_path[3] = "Новосибирск, Новосибирская обл., Россия";
        this.region_id[3] = Conversions.ToString(269);
        this.Mrim_Country[4] = (short) 24;
        this.Mrim_Region[4] = (short) 1576;
        this.city_id[4] = Conversions.ToString(1576);
        this.country_id[4] = Conversions.ToString(24);
        this.name[4] = "Челябинск";
        this.full_path[4] = "Челябинск, Челябинская обл., Россия";
        this.region_id[4] = Conversions.ToString(282);
        this.Mrim_Country[5] = (short) 24;
        this.Mrim_Region[5] = (short) 575;
        this.city_id[5] = Conversions.ToString(575);
        this.country_id[5] = Conversions.ToString(24);
        this.name[5] = "Казань";
        this.full_path[5] = "Казань, Татарстан, Россия";
        this.region_id[5] = Conversions.ToString(248);
        this.Mrim_Country[6] = (short) 24;
        this.Mrim_Region[6] = (short) 1533;
        this.city_id[6] = Conversions.ToString(1533);
        this.country_id[6] = Conversions.ToString(24);
        this.name[6] = "Екатеринбург";
        this.full_path[6] = "Екатеринбург, Свердловская обл., Россия";
        this.region_id[6] = Conversions.ToString(279);
        this.Mrim_Country[7] = (short) 24;
        this.Mrim_Region[7] = (short) 1471;
        this.city_id[7] = Conversions.ToString(1471);
        this.country_id[7] = Conversions.ToString(24);
        this.name[7] = "Красноярск";
        this.full_path[7] = "Красноярск, Красноярский край, Россия";
        this.region_id[7] = Conversions.ToString(268);
        this.Mrim_Country[8] = (short) 24;
        this.Mrim_Region[8] = (short) 501;
        this.city_id[8] = Conversions.ToString(501);
        this.country_id[8] = Conversions.ToString(24);
        this.name[8] = "Уфа";
        this.full_path[8] = "Уфа, Башкортостан, Россия";
        this.region_id[8] = Conversions.ToString(237);
        this.Mrim_Country[9] = (short) 24;
        this.Mrim_Region[9] = (short) 559;
        this.city_id[9] = Conversions.ToString(559);
        this.country_id[9] = Conversions.ToString(24);
        this.name[9] = "Самара";
        this.full_path[9] = "Самара, Самарская обл., Россия";
        this.region_id[9] = Conversions.ToString(246);
        this.Mrim_Country[10] = (short) 24;
        this.Mrim_Region[10] = (short) 526;
        this.city_id[10] = Conversions.ToString(526);
        this.country_id[10] = Conversions.ToString(24);
        this.name[10] = "Нижний Новгород";
        this.full_path[10] = "Нижний Новгород, Нижегородская обл., Россия";
        this.region_id[10] = Conversions.ToString(242);
        this.Mrim_Country[11] = (short) 24;
        this.Mrim_Region[11] = (short) 1808;
        this.city_id[11] = Conversions.ToString(1808);
        this.country_id[11] = Conversions.ToString(24);
        this.name[11] = "Краснодар";
        this.full_path[11] = "Краснодар, Краснодарский край, Россия";
        this.region_id[11] = Conversions.ToString(309);
        this.Mrim_Country[12] = (short) 24;
        this.Mrim_Region[12] = (short) 1833;
        this.city_id[12] = Conversions.ToString(1833);
        this.country_id[12] = Conversions.ToString(24);
        this.name[12] = "Ростов-на-Дону";
        this.full_path[12] = "Ростов-на-Дону, Ростовская обл., Россия";
        this.region_id[12] = Conversions.ToString(310);
        this.Mrim_Country[13] = (short) 0;
        this.Mrim_Region[13] = (short) 0;
        this.city_id[13] = "undefined";
        this.country_id[13] = "undefined";
        this.name[13] = string.Empty;
        this.full_path[13] = string.Empty;
        this.region_id[13] = "undefined";
      }

      public int Return_Num_City(ref string CityName)
      {
        int num = 13;
        int length = CityName.Length;
        int index = 1;
        while (Operators.CompareString(CityName, Strings.Left(this.full_path[index], length), false) != 0)
        {
          checked { ++index; }
          if (index > 12)
            goto label_4;
        }
        num = index;
label_4:
        return num;
      }
    }
  }
}
