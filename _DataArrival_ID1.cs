// Decompiled with JetBrains decompiler
// Type: MailRegUnicore._DataArrival_ID1
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class _DataArrival_ID1
  {
    public static void StartPage_ID_1(int Index, ref string sPacketFrom)
    {
      try
      {
        if (Strings.InStr(sPacketFrom, "<title>QIP.RU: регистрация", CompareMethod.Binary) == 0)
        {
          string str1;
          if (_VARIABLES.DebugOp.SavePacket_RegError)
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string str2 = "Save Packet to '" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_StartPage.QIPru.packet.log'";
            fn.TXT(ref str2);
            str2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "_StartPage.QIPru.packet.log";
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
          int Index1 = Index;
          str1 = "Unknown StartPage!";
          mdConnect.ErrorEvent(Index1, ref str1);
        }
        else
        {
          string empty = string.Empty;
          int Start1 = Strings.InStr(sPacketFrom, "return Reg.submit(this)", CompareMethod.Binary);
          string str;
          if (Start1 == 0)
          {
            str = "Нет формы 'Post'";
          }
          else
          {
            int num1 = Strings.InStr(Start1, sPacketFrom, "value=\"", CompareMethod.Binary);
            if (num1 == 0)
            {
              str = "Нет формы значения 'Post'";
            }
            else
            {
              int Start2 = checked (num1 + 7);
              int Start3 = Strings.InStr(Start2, sPacketFrom, "\"", CompareMethod.Binary);
              _VARIABLES.CurThreadData[Index].data_QIP.username.Name = Strings.Mid(sPacketFrom, Start2, checked (Start3 - Start2));
              _VARIABLES.CurThreadData[Index].data_QIP.username.Value = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login;
              int num2 = Strings.InStr(Start3, sPacketFrom, "pwd\" value=\"", CompareMethod.Binary);
              if (num2 == 0)
              {
                str = "Отсутствует поле 'Password1'";
              }
              else
              {
                int Start4 = checked (num2 + 12);
                int Start5 = Strings.InStr(Start4, sPacketFrom, "\"", CompareMethod.Binary);
                _VARIABLES.CurThreadData[Index].data_QIP.pwd.Name = Strings.Mid(sPacketFrom, Start4, checked (Start5 - Start4));
                _VARIABLES.CurThreadData[Index].data_QIP.pwd.Value = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password;
                int num3 = Strings.InStr(Start5, sPacketFrom, "pwd2\" value=\"", CompareMethod.Binary);
                if (num3 == 0)
                {
                  str = "Отсутствует поле 'Password2'";
                }
                else
                {
                  int Start6 = checked (num3 + 13);
                  int Start7 = Strings.InStr(Start6, sPacketFrom, "\"", CompareMethod.Binary);
                  _VARIABLES.CurThreadData[Index].data_QIP.pwd2.Name = Strings.Mid(sPacketFrom, Start6, checked (Start7 - Start6));
                  _VARIABLES.CurThreadData[Index].data_QIP.pwd2.Value = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password;
                  int num4 = Strings.InStr(Start7, sPacketFrom, "email\" value=\"", CompareMethod.Binary);
                  if (num4 == 0)
                  {
                    str = "Отсутствует поле 'email'";
                  }
                  else
                  {
                    int Start8 = checked (num4 + 14);
                    int Start9 = Strings.InStr(Start8, sPacketFrom, "\"", CompareMethod.Binary);
                    _VARIABLES.CurThreadData[Index].data_QIP.email.Name = Strings.Mid(sPacketFrom, Start8, checked (Start9 - Start8));
                    _VARIABLES.CurThreadData[Index].data_QIP.email.Value = string.Empty;
                    int num5 = Strings.InStr(Start9, sPacketFrom, "man_sex\" value=\"", CompareMethod.Binary);
                    if (num5 == 0)
                    {
                      str = "Отсутствует поле 'man_sex'";
                    }
                    else
                    {
                      int Start10 = checked (num5 + 16);
                      int Start11 = Strings.InStr(Start10, sPacketFrom, "\"", CompareMethod.Binary);
                      _VARIABLES.CurThreadData[Index].data_QIP.man_sex.Name = Strings.Mid(sPacketFrom, Start10, checked (Start11 - Start10));
                      _VARIABLES.CurThreadData[Index].data_QIP.man_sex.Value = Conversions.ToString((int) _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Sex);
                      int num6 = Strings.InStr(Start11, sPacketFrom, "captcha\" value=\"", CompareMethod.Binary);
                      if (num6 == 0)
                      {
                        str = "Отсутствует поле 'captcha'";
                      }
                      else
                      {
                        int Start12 = checked (num6 + 16);
                        int Start13 = Strings.InStr(Start12, sPacketFrom, "\"", CompareMethod.Binary);
                        _VARIABLES.CurThreadData[Index].data_QIP.captcha.Name = Strings.Mid(sPacketFrom, Start12, checked (Start13 - Start12));
                        _VARIABLES.CurThreadData[Index].data_QIP.captcha.Value = string.Empty;
                        if (!_DataArrival_ID1.FindEnum(Index, ref sPacketFrom))
                        {
                          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_1.0]: Не найдены ключи.";
                          _FUNCTION.SBTXT(ref sText);
                          _VARIABLES.WS[Index].FreeSocket = true;
                          return;
                        }
                        int Start14 = Strings.InStr(Start13, sPacketFrom, "/reg/regshelper?rnd=", CompareMethod.Binary);
                        int num7 = Strings.InStr(Start14, sPacketFrom, "\"", CompareMethod.Binary);
                        string set_URL = "http://qip.ru" + Strings.Mid(sPacketFrom, Start14, checked (num7 - Start14));
                        _VARIABLES.WS[Index].ConnectTo = "RegsHelper1";
                        SocketNET socketNet = _VARIABLES.WS[Index];
                        string set_Referer = "http://qip.ru/reg/register";
                        string set_PostData = (string) null;
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
                        socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
                        curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
          string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_1.1]: " + str;
          _FUNCTION.SBTXT(ref sText1);
          mdConnect.ErrorRegular(Index, ref sPacketFrom);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_1.2]: " + exception.Message;
        _FUNCTION.SBTXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void RegsHelper1_ID_1(int Index, ref string sPacketFrom)
    {
      try
      {
        if (!_DataArrival_ID1.ConvertEnum(Index, ref sPacketFrom))
        {
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_2.0]: ConvertEnum ret false";
          _FUNCTION.SBTXT(ref sText);
          mdConnect.ErrorRegular(Index, ref sPacketFrom);
        }
        else
        {
          string set_PostData = "username=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "&host=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain + "&first_name=" + _FUNCTION.ConvertSTRtoUnicode(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Name) + "&last_name=" + _FUNCTION.ConvertSTRtoUnicode(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.LastName);
          string set_URL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "http://qip.ru/reg/checkRegLoginz?PHPSESSID=", _VARIABLES.CurThreadData[Index].CookiesMail[(object) "PHPSESSID"]), (object) "&JsHttpRequest=1344292"), (object) _FUNCTION.sRND.Next(1111111, 9999999)), (object) "-xml"));
          _VARIABLES.WS[Index].ConnectTo = "CheckLogin";
          SocketNET socketNet = _VARIABLES.WS[Index];
          string set_Referer = "http://qip.ru/reg/register";
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
          socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
          curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_2.1]: " + exception.Message;
        _FUNCTION.SBTXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void CheckLogin_ID_1(int Index, ref string sPacketFrom)
    {
      try
      {
        MyProject.Forms.frmMain.LV_Dostupno.Items.Clear();
        MyProject.Forms.frmMain.LV_Dostupno.Items.Add("current");
        MyProject.Forms.frmMain.LV_Dostupno.Items[0].UseItemStyleForSubItems = false;
        MyProject.Forms.frmMain.LV_Dostupno.Items[0].SubItems.Add(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "@" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain);
        if (Strings.InStr(sPacketFrom, "\\u0441\\u0432\\u043e\\u0431\\u043e\\u0434\\u0435\\u043d", CompareMethod.Binary) > 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 1;
          _VARIABLES.CurThreadData[Index].CurrentMailToReg = _VARIABLES.CurThreadData[Index].FreeMailDomain[0];
          MyProject.Forms.frmMain.LV_Dostupno.Items[0].SubItems[0].BackColor = Color.LawnGreen;
          MyProject.Forms.frmMain.LV_Dostupno.Items[0].SubItems[1].BackColor = Color.LawnGreen;
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.txtCurrentMail.Text = _VARIABLES.CurThreadData[Index].CurrentMailToReg;
          StringBuilder stringBuilder = new StringBuilder();
          stringBuilder.Append("first_name=" + md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Name));
          stringBuilder.Append("&last_name=" + md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.LastName));
          stringBuilder.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.username.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.username.Value);
          stringBuilder.Append("&reg_host=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain);
          stringBuilder.Append("&name_helper=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "%40" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain);
          stringBuilder.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[0].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[0].Value);
          stringBuilder.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[1].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[1].Value);
          stringBuilder.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[2].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[2].Value);
          _VARIABLES.WS[Index].ConnectTo = "StartPage2";
          SocketNET socketNet = _VARIABLES.WS[Index];
          string set_URL = "http://qip.ru/reg/register";
          string set_Referer = "http://qip.ru/reg/register";
          string set_PostData = stringBuilder.ToString();
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
          socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
          curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
        }
        else if (Strings.InStr(sPacketFrom, "\\u041b\\u043e\\u0433\\u0438\\u043d \\u0437\\u0430\\u043d\\u044f\\u0442", CompareMethod.Binary) > 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 5;
          MyProject.Forms.frmMain.LV_Dostupno.Items[0].SubItems[0].BackColor = Color.Red;
          MyProject.Forms.frmMain.LV_Dostupno.Items[0].SubItems[1].BackColor = Color.Red;
          int num1 = Strings.InStr(sPacketFrom, "\"logins\":[\"", CompareMethod.Binary);
          if (num1 == 0)
          {
            _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 6;
            MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
            _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
            string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Error: Нет предложенных вариантов eMail.";
            _FUNCTION.SBTXT(ref sText);
            mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
          }
          else
          {
            int Start = checked (num1 + 11);
            int num2 = Strings.InStr(Start, sPacketFrom, "\"]", CompareMethod.Binary);
            string str = Strings.Mid(sPacketFrom, Start, checked (num2 - Start)).Replace("\"", string.Empty);
            _VARIABLES.CurThreadData[Index].FreeMailDomain = str.Split(',');
            int num3 = 0;
            int num4 = Information.UBound((Array) _VARIABLES.CurThreadData[Index].FreeMailDomain, 1);
            int index1 = num3;
            while (index1 <= num4)
            {
              MyProject.Forms.frmMain.LV_Dostupno.Items.Add(Conversions.ToString(checked (index1 + 1)));
              MyProject.Forms.frmMain.LV_Dostupno.Items[checked (index1 + 1)].SubItems.Add(_VARIABLES.CurThreadData[Index].FreeMailDomain[index1]);
              checked { ++index1; }
            }
            MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
            _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
            if (!_VARIABLES.OP.OpReg.LoginNotFree)
            {
              _VARIABLES.WS[Index].FreeSocket = true;
            }
            else
            {
              int index2 = 1;
              switch (_VARIABLES.OP.OpReg.ActionChoise)
              {
                case 0:
                  index2 = _FUNCTION.sRND.Next(0, checked (((IEnumerable<string>) _VARIABLES.CurThreadData[Index].FreeMailDomain).Count<string>() + 1));
                  break;
                case 1:
                  int num5 = 0;
                  short num6 = checked ((short) Information.UBound((Array) _VARIABLES.CurThreadData[Index].FreeMailDomain, 1));
                  short num7 = (short) num5;
                  while ((int) num7 <= (int) num6)
                  {
                    if (Operators.CompareString(Strings.Right(_VARIABLES.CurThreadData[Index].FreeMailDomain[(int) num7], _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain.Length), _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain, false) == 0 && Operators.CompareString(_VARIABLES.CurThreadData[Index].FreeMailDomain[(int) num7], _VARIABLES.CurThreadData[Index].FreeMailDomain[0], false) != 0)
                    {
                      index2 = (int) num7;
                      break;
                    }
                    checked { ++num7; }
                  }
                  if ((int) num7 > Information.UBound((Array) _VARIABLES.CurThreadData[Index].FreeMailDomain, 1))
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
              _VARIABLES.CurThreadData[Index].data_QIP.username.Value = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login;
              MyProject.Forms.frmMain.txtCurrentMail.Text = _VARIABLES.CurThreadData[Index].CurrentMailToReg;
              StringBuilder stringBuilder = new StringBuilder();
              stringBuilder.Append("first_name=" + md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Name));
              stringBuilder.Append("&last_name=" + md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.LastName));
              stringBuilder.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.username.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.username.Value);
              stringBuilder.Append("&reg_host=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain);
              stringBuilder.Append("&name_helper=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "%40" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain);
              stringBuilder.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[0].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[0].Value);
              stringBuilder.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[1].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[1].Value);
              stringBuilder.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[2].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[2].Value);
              _VARIABLES.WS[Index].ConnectTo = "StartPage2";
              SocketNET socketNet = _VARIABLES.WS[Index];
              string set_URL = "http://qip.ru/reg/register";
              string set_Referer = "http://qip.ru/reg/register";
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
            }
          }
        }
        else
        {
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Неизвестный ответ от CheckLogin - Copy To CB";
          _FUNCTION.SBTXT(ref sText);
          _FUNCTION.CLIP(ref sPacketFrom);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_3.0]: " + exception.Message;
        _FUNCTION.SBTXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void StartPage2_ID_1(int Index, ref string sPacketFrom)
    {
      if (Strings.InStr(sPacketFrom, "шаг 2 из 2", CompareMethod.Binary) > 0)
      {
        int Start1 = checked (Strings.InStr(sPacketFrom, "/api/captcha?", CompareMethod.Binary) + 30);
        int num1 = Strings.InStr(Start1, sPacketFrom, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].SpareUrl_1 = Strings.Mid(sPacketFrom, Start1, checked (num1 - Start1));
        int Start2 = Strings.InStr(sPacketFrom, "/reg/regshelper", CompareMethod.Binary);
        int num2 = Strings.InStr(Start2, sPacketFrom, "\"", CompareMethod.Binary);
        string set_URL = "http://qip.ru" + Strings.Mid(sPacketFrom, Start2, checked (num2 - Start2));
        if (!_DataArrival_ID1.FindEnum(Index, ref sPacketFrom))
        {
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_4.0]: Не найдены ключи.";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else
        {
          _VARIABLES.WS[Index].ConnectTo = "RegsHelper2";
          SocketNET socketNet = _VARIABLES.WS[Index];
          string set_Referer = "http://qip.ru/reg/register";
          string set_PostData = (string) null;
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
          socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
          curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
        }
      }
      else
      {
        string sText = "Нет 'шаг 2 из 2'";
        _FUNCTION.SBTXT(ref sText);
        string FullPath = Application.StartupPath + "\\Data\\" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_no_step2_2.html";
        _LOADSAVE.FileSave(ref FullPath, ref sPacketFrom);
        _VARIABLES.WS[Index].FreeSocket = true;
      }
    }

    public static void RegsHelper2_ID_1(int Index, ref string sPacketFrom)
    {
      try
      {
        if (!_DataArrival_ID1.ConvertEnum(Index, ref sPacketFrom))
        {
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_5.0]: ConvertEnum ret false";
          _FUNCTION.SBTXT(ref sText);
          mdConnect.ErrorRegular(Index, ref sPacketFrom);
        }
        else
        {
          _VARIABLES.WS[Index].ConnectTo = "Captcha";
          SocketNET socketNet = _VARIABLES.WS[Index];
          string set_URL = "http://qip.ru/api/captcha?n=register&k=" + _VARIABLES.CurThreadData[Index].SpareUrl_1;
          string set_Referer = "http://qip.ru/reg/register";
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
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_5.1]: " + exception.Message;
        _FUNCTION.SBTXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void Captcha_ID_1(int Index, ref string sPacketFrom)
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
        _FUNCTION.VisibleRequest(0);
        _FUNCTION.VisibleCapcta(1);
        byte[] bytes = Encoding.Default.GetBytes(sPacketFrom);
        MemoryStream memoryStream = new MemoryStream();
        memoryStream.Write(bytes, 0, bytes.Length);
        MyProject.Forms.frmMain.picVOTE_CAPTCHA_1.Image = Image.FromStream((Stream) memoryStream);
        MyProject.Forms.frmMain.picVOTE_CAPTCHA_1.Refresh();
        if (!MyProject.Forms.frmMain.txtCaptcha.CanFocus)
          return;
        MyProject.Forms.frmMain.txtCaptcha.Focus();
      }
    }

    public static void Reg_ID_1(int Index, ref string sPacketFrom)
    {
      try
      {
        if (_VARIABLES.WS[Index].ResponseNum == 302)
        {
          if (_VARIABLES.PlaySound.Use && _VARIABLES.PlaySound.Play[4])
            MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[4]);
          checked { ++_VARIABLES.AC_NET.CapCounter.Cap_OK; }
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 2;
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].DataCreateBox = Conversions.ToString(DateAndTime.Now);
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          string sText;
          if (_VARIABLES.OptionReport[7])
          {
            sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# QIP.RU: Registered - " + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "@" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain;
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
        else if (Strings.InStr(sPacketFrom, "<span class=\"msg\">Неверный код подтверждения</span>", CompareMethod.Binary) > 0)
        {
          if (!_DataArrival_ID1.FindEnum(Index, ref sPacketFrom))
          {
            string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_6.0]: Не найдены ключи.";
            _FUNCTION.SBTXT(ref sText);
            mdConnect.ErrorRegular(Index, ref sPacketFrom);
          }
          else
          {
            int Start1 = checked (Strings.InStr(sPacketFrom, "/api/captcha?", CompareMethod.Binary) + 30);
            int num1 = Strings.InStr(Start1, sPacketFrom, "\"", CompareMethod.Binary);
            _VARIABLES.CurThreadData[Index].SpareUrl_1 = Strings.Mid(sPacketFrom, Start1, checked (num1 - Start1));
            int Start2 = Strings.InStr(sPacketFrom, "/reg/regshelper", CompareMethod.Binary);
            int num2 = Strings.InStr(Start2, sPacketFrom, "\"", CompareMethod.Binary);
            _VARIABLES.CurThreadData[Index].SpareUrl_2 = "http://qip.ru" + Strings.Mid(sPacketFrom, Start2, checked (num2 - Start2));
            if (_VARIABLES.OP.AutoCAPTCHA && _VARIABLES.OP.OpAC.ReportBadCaptcha)
            {
              if (_VARIABLES.OptionReport[8])
              {
                string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# QIP.RU: Неверно указан код защиты.";
                _FUNCTION.SBTXT(ref sText);
              }
              _VARIABLES.AC_NET.BadCaptcha(Index);
            }
            else
            {
              string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# QIP.RU: Неверно указан код защиты.";
              _FUNCTION.SBTXT(ref sText);
              checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Wrong; }
              _VARIABLES.WS[Index].ConnectTo = "RegsHelper2";
              SocketNET socketNet = _VARIABLES.WS[Index];
              string set_Referer = "http://qip.ru/reg/register";
              string set_PostData = (string) null;
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
              socketNet.Connect(ref _VARIABLES.CurThreadData[Index].SpareUrl_2, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
              curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
            }
          }
        }
        else
        {
          checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Lost; }
          if (Strings.InStr(sPacketFrom, "<span class=\"controls\">Много регистраций с одного ip</span>", CompareMethod.Binary) > 0)
          {
            string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# QIP.RU: Превышен лимит регистраций с Вашего IP. " + _VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].IP + ":" + Conversions.ToString(_VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].Port);
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
            {
              _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy = 0;
              _VARIABLES.WS[Index].ConnectOptions.Proxy = mdConnect.SetProxy(Index);
              if (!_DataArrival_ID1.FindEnum(Index, ref sPacketFrom))
              {
                string sText2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_6.1]: Не найдены ключи.";
                _FUNCTION.SBTXT(ref sText2);
                mdConnect.ErrorRegular(Index, ref sPacketFrom);
              }
              else
              {
                int Start1 = checked (Strings.InStr(sPacketFrom, "/api/captcha?", CompareMethod.Binary) + 30);
                int num1 = Strings.InStr(Start1, sPacketFrom, "\"", CompareMethod.Binary);
                _VARIABLES.CurThreadData[Index].SpareUrl_1 = Strings.Mid(sPacketFrom, Start1, checked (num1 - Start1));
                int Start2 = Strings.InStr(sPacketFrom, "/reg/regshelper", CompareMethod.Binary);
                int num2 = Strings.InStr(Start2, sPacketFrom, "\"", CompareMethod.Binary);
                string set_URL = "http://qip.ru" + Strings.Mid(sPacketFrom, Start2, checked (num2 - Start2));
                _VARIABLES.WS[Index].ConnectTo = "RegsHelper2";
                SocketNET socketNet = _VARIABLES.WS[Index];
                string set_Referer = "http://qip.ru/reg/register";
                string set_PostData = (string) null;
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
                socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
                curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
              }
            }
          }
          else
          {
            if (Strings.InStr(sPacketFrom, "<label class=\"label\"></label><span class=\"controls\">Ошибка при регистрации</span>", CompareMethod.Binary) <= 0)
              return;
            if (!_DataArrival_ID1.FindEnum(Index, ref sPacketFrom))
            {
              string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_6.2]: Не найдены ключи.";
              _FUNCTION.SBTXT(ref sText);
              mdConnect.ErrorRegular(Index, ref sPacketFrom);
            }
            else
            {
              int Start1 = checked (Strings.InStr(sPacketFrom, "/api/captcha?", CompareMethod.Binary) + 30);
              int num1 = Strings.InStr(Start1, sPacketFrom, "\"", CompareMethod.Binary);
              _VARIABLES.CurThreadData[Index].SpareUrl_1 = Strings.Mid(sPacketFrom, Start1, checked (num1 - Start1));
              int Start2 = Strings.InStr(sPacketFrom, "/reg/regshelper", CompareMethod.Binary);
              int num2 = Strings.InStr(Start2, sPacketFrom, "\"", CompareMethod.Binary);
              string set_URL = "http://qip.ru" + Strings.Mid(sPacketFrom, Start2, checked (num2 - Start2));
              string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# QIP.RU: Неправильно преобразованы ключи.";
              _FUNCTION.SBTXT(ref sText);
              _VARIABLES.WS[Index].ConnectTo = "RegsHelper2";
              SocketNET socketNet = _VARIABLES.WS[Index];
              string set_Referer = "http://qip.ru/reg/register";
              string set_PostData = (string) null;
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
              socketNet.Connect(ref set_URL, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData, set_Proxy, ref curUserAgent, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
              curThreadData[index1].CurUserAgent = checked ((byte) curUserAgent);
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_6.3]: " + exception.Message;
        _FUNCTION.SBTXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    private static bool FindEnum(int Index, ref string sPacketFrom)
    {
      bool flag;
      try
      {
        _VARIABLES.CurThreadData[Index].data_QIP.Elem = new _DataArrival_ID1.myElem[3];
        int Start1 = checked (Strings.InStr(sPacketFrom, "<span><input id=\"", CompareMethod.Binary) + 17);
        int Start2 = Strings.InStr(Start1, sPacketFrom, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].data_QIP.Elem[0].ID = Strings.Mid(sPacketFrom, Start1, checked (Start2 - Start1));
        int Start3 = checked (Strings.InStr(Start2, sPacketFrom, "name=\"", CompareMethod.Binary) + 6);
        int Start4 = Strings.InStr(Start3, sPacketFrom, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].data_QIP.Elem[0].Name = Strings.Mid(sPacketFrom, Start3, checked (Start4 - Start3));
        int Start5 = checked (Strings.InStr(Start4, sPacketFrom, "value=\"", CompareMethod.Binary) + 7);
        int Start6 = Strings.InStr(Start5, sPacketFrom, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].data_QIP.Elem[0].Value = Strings.Mid(sPacketFrom, Start5, checked (Start6 - Start5));
        int Start7 = checked (Strings.InStr(Start6, sPacketFrom, "id=\"", CompareMethod.Binary) + 4);
        int Start8 = Strings.InStr(Start7, sPacketFrom, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].data_QIP.Elem[1].ID = Strings.Mid(sPacketFrom, Start7, checked (Start8 - Start7));
        int Start9 = checked (Strings.InStr(Start8, sPacketFrom, "name=\"", CompareMethod.Binary) + 6);
        int Start10 = Strings.InStr(Start9, sPacketFrom, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].data_QIP.Elem[1].Name = Strings.Mid(sPacketFrom, Start9, checked (Start10 - Start9));
        int Start11 = checked (Strings.InStr(Start10, sPacketFrom, "value=\"", CompareMethod.Binary) + 7);
        int Start12 = Strings.InStr(Start11, sPacketFrom, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].data_QIP.Elem[1].Value = Strings.Mid(sPacketFrom, Start11, checked (Start12 - Start11));
        int Start13 = checked (Strings.InStr(Start12, sPacketFrom, "id=\"", CompareMethod.Binary) + 4);
        int Start14 = Strings.InStr(Start13, sPacketFrom, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].data_QIP.Elem[2].ID = Strings.Mid(sPacketFrom, Start13, checked (Start14 - Start13));
        int Start15 = checked (Strings.InStr(Start14, sPacketFrom, "name=\"", CompareMethod.Binary) + 6);
        int Start16 = Strings.InStr(Start15, sPacketFrom, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].data_QIP.Elem[2].Name = Strings.Mid(sPacketFrom, Start15, checked (Start16 - Start15));
        int Start17 = checked (Strings.InStr(Start16, sPacketFrom, "value=\"", CompareMethod.Binary) + 7);
        int num = Strings.InStr(Start17, sPacketFrom, "\"", CompareMethod.Binary);
        _VARIABLES.CurThreadData[Index].data_QIP.Elem[2].Value = Strings.Mid(sPacketFrom, Start17, checked (num - Start17));
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private static bool ConvertEnum(int Index, ref string sPacketFrom)
    {
      bool flag;
      try
      {
        sPacketFrom = sPacketFrom.Replace("\r", string.Empty);
        sPacketFrom = sPacketFrom.Replace("\n", string.Empty);
        sPacketFrom = sPacketFrom.Replace("\t", string.Empty);
        string[] strArray = sPacketFrom.Split(';');
        int num1 = 0;
        int num2 = Information.UBound((Array) strArray, 1);
        int index1 = num1;
        while (index1 <= num2)
        {
          if (Strings.InStr(1, strArray[index1], "headloader", CompareMethod.Text) > 0)
          {
            strArray = (string[]) Utils.CopyArray((Array) strArray, (Array) new string[checked (index1 - 1 + 1)]);
            break;
          }
          checked { ++index1; }
        }
        _DataArrival_ID1.myElem sNewElem = new _DataArrival_ID1.myElem();
        short num3 = 0;
        int num4 = 0;
        int num5 = Information.UBound((Array) strArray, 1);
        int index2 = num4;
        while (index2 <= num5)
        {
          long elementById;
          if (Strings.InStr(1, strArray[index2], "getElementById", CompareMethod.Text) > 0)
          {
            elementById = (long) _DataArrival_ID1.getElementById(Index, ref strArray[index2]);
            if (elementById > -1L)
              num3 = (short) 1;
          }
          if ((int) num3 != 0)
          {
            if (Strings.InStr(1, strArray[index2], "appendChild", CompareMethod.Text) > 0)
              _VARIABLES.CurThreadData[Index].data_QIP.Elem[2] = sNewElem;
            else if (Strings.InStr(1, strArray[index2], "removeChild", CompareMethod.Text) > 0)
              _DataArrival_ID1.removeChild(Index, checked ((int) elementById));
            else if (Strings.InStr(1, strArray[index2], "newelem.id", CompareMethod.Text) > 0)
              sNewElem.ID = _DataArrival_ID1.TakeData(Index, ref strArray[index2]);
            else if (Strings.InStr(1, strArray[index2], "newelem.value", CompareMethod.Text) > 0)
              sNewElem.Value = _DataArrival_ID1.TakeData(Index, ref strArray[index2]);
            else if (Strings.InStr(1, strArray[index2], "newelem.name", CompareMethod.Text) > 0)
              sNewElem.Name = _DataArrival_ID1.TakeData(Index, ref strArray[index2]);
            else if (Strings.InStr(1, strArray[index2], "insertBefore(l[1], l[0])", CompareMethod.Text) > 0)
              _DataArrival_ID1.insertBefore_1_to_0(Index);
            else if (Strings.InStr(1, strArray[index2], "insertBefore(newelem, l[0])", CompareMethod.Text) > 0)
              _DataArrival_ID1.insertBefore_newelem_to_0(Index, ref sNewElem);
            else if (Strings.InStr(1, strArray[index2], "insertBefore(newelem, l[1])", CompareMethod.Text) > 0)
              _DataArrival_ID1.insertBefore_newelem_to_1(Index, ref sNewElem);
            else if (Strings.InStr(1, strArray[index2], "elem2.value =", CompareMethod.Text) > 0)
              _VARIABLES.CurThreadData[Index].data_QIP.Elem[checked ((int) elementById)].Value = _DataArrival_ID1.TakeData(Index, ref strArray[index2]);
          }
          checked { ++index2; }
        }
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private static void removeChild(int Index, int sNumLine)
    {
      long num = (long) sNumLine;
      while (num <= 1L)
      {
        _VARIABLES.CurThreadData[Index].data_QIP.Elem[checked ((int) num)] = _VARIABLES.CurThreadData[Index].data_QIP.Elem[checked ((int) (num + 1L))];
        checked { ++num; }
      }
    }

    private static void insertBefore_newelem_to_1(int Index, ref _DataArrival_ID1.myElem sNewElem)
    {
      _VARIABLES.CurThreadData[Index].data_QIP.Elem[2] = _VARIABLES.CurThreadData[Index].data_QIP.Elem[1];
      _VARIABLES.CurThreadData[Index].data_QIP.Elem[1] = sNewElem;
    }

    private static void insertBefore_newelem_to_0(int Index, ref _DataArrival_ID1.myElem sNewElem)
    {
      _VARIABLES.CurThreadData[Index].data_QIP.Elem[2] = _VARIABLES.CurThreadData[Index].data_QIP.Elem[1];
      _VARIABLES.CurThreadData[Index].data_QIP.Elem[1] = _VARIABLES.CurThreadData[Index].data_QIP.Elem[0];
      _VARIABLES.CurThreadData[Index].data_QIP.Elem[0] = sNewElem;
    }

    private static void insertBefore_1_to_0(int Index)
    {
      _DataArrival_ID1.myElem myElem = _VARIABLES.CurThreadData[Index].data_QIP.Elem[0];
      _VARIABLES.CurThreadData[Index].data_QIP.Elem[0] = _VARIABLES.CurThreadData[Index].data_QIP.Elem[1];
      _VARIABLES.CurThreadData[Index].data_QIP.Elem[1] = myElem;
    }

    private static string TakeData(int Index, ref string sLine)
    {
      long num1 = (long) checked (Strings.InStr(1, sLine, "'", CompareMethod.Text) + 1);
      long num2 = (long) Strings.InStr(checked ((int) num1), sLine, "'", CompareMethod.Text);
      return Strings.Mid(sLine, checked ((int) num1), checked ((int) (num2 - num1)));
    }

    private static int getElementById(int Index, ref string sLine)
    {
      string data = _DataArrival_ID1.TakeData(Index, ref sLine);
      long num = 0;
      while (Operators.CompareString(_VARIABLES.CurThreadData[Index].data_QIP.Elem[checked ((int) num)].ID, data, false) != 0)
      {
        checked { ++num; }
        if (num > 2L)
          return -1;
      }
      return checked ((int) num);
    }

    public static void CheckMail_WebFace_ID_1(int Index, ref string sPacketFrom)
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
        if (Strings.InStr(sPacketFrom, "JsHttpRequest.dataReady", CompareMethod.Binary) == 0)
        {
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Неправильные данные пакета на вход.";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else if (Strings.InStr(sPacketFrom, "\"code\":\"200\"", CompareMethod.Binary) > 0)
        {
          string str = string.Empty;
          int num1 = Strings.InStr(sPacketFrom, "fn\":\"", CompareMethod.Binary);
          string sText;
          if (num1 > 0)
          {
            int Start = checked (num1 + 5);
            int num2 = Strings.InStr(Start, sPacketFrom, "\"", CompareMethod.Binary);
            sText = Strings.Mid(sPacketFrom, Start, checked (num2 - Start));
            str = _FUNCTION.ConvertUnicodetoSTR(ref sText);
          }
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 3;
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# +OK Owner: " + str;
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else if (Strings.InStr(sPacketFrom, "\"code\":\"403\"", CompareMethod.Binary) > 0)
        {
          _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered = (short) 6;
          _LOADSAVE.SaveOne_MailInfo(_VARIABLES.Mirror[Index]);
          MyProject.Forms.frmMain.LV_Merge(_VARIABLES.Mirror[Index]);
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Bad Login/Password";
          _FUNCTION.SBTXT(ref sText);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
        else
        {
          if (_VARIABLES.DebugOp.SavePacket_RegError)
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Save Packet to '" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_Incorrect.packet.CheckWebInterface_QIPru.log'";
            fn.TXT(ref sText);
            string sFileName = Conversions.ToString(_VARIABLES.Mirror[Index]) + "_Incorrect.packet.CheckWebInterface_QIPru.log";
            string sData = _VARIABLES.WS[Index].PacketHEAD + "\r\n" + sPacketFrom;
            _LOADSAVE.Save(ref sFileName, ref sData);
          }
          _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
          string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Неизвестный пакет от qip.ru";
          fn1.TXT(ref sText1);
          _VARIABLES.WS[Index].FreeSocket = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Ex[qip.ru_7.0]: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public struct myQIP
    {
      public _DataArrival_ID1.myElem[] Elem;
      public _VARIABLES.myWebVar username;
      public _VARIABLES.myWebVar pwd;
      public _VARIABLES.myWebVar pwd2;
      public _VARIABLES.myWebVar email;
      public _VARIABLES.myWebVar man_sex;
      public _VARIABLES.myWebVar captcha;
    }

    public struct myElem
    {
      public string ID;
      public string Name;
      public string Value;
    }
  }
}
