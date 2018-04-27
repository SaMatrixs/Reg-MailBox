// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.mdConnect
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class mdConnect
  {
    public static int ProxCNT;

    public static myProxy SetProxy(int Index)
    {
      if ((int) _VARIABLES.OP.UsePoxy == 0)
      {
        if (MyProject.Forms.frmMain.lblProxy.BackColor != Color.Red)
          MyProject.Forms.frmMain.lblProxy.BackColor = Color.Red;
        MyProject.Forms.frmMain.lblProxy.Text = "DIRECT";
        return (myProxy) null;
      }
      if (Information.UBound((Array) _VARIABLES.Proxy, 1) == 0)
      {
        if (MyProject.Forms.frmMain.lblProxy.BackColor != Color.Red)
          MyProject.Forms.frmMain.lblProxy.BackColor = Color.Red;
        MyProject.Forms.frmMain.lblProxy.Text = "DIRECT";
        return (myProxy) null;
      }
      myProxy myProxy = new myProxy();
      if (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy > Information.UBound((Array) _VARIABLES.Proxy, 1))
        _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy = 0;
      if (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy == 0)
      {
        string sText;
        while (true)
        {
          checked { ++mdConnect.ProxCNT; }
          checked { ++_VARIABLES.ProxySpeed; }
          if (mdConnect.ProxCNT > Information.UBound((Array) _VARIABLES.Proxy, 1))
            mdConnect.ProxCNT = 1;
          if (mdConnect.ProxCNT == 1 && _VARIABLES.UseBannedProxy)
          {
            _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
            sText = "Включена опция удаления Banned Proxy.";
            fn1.TXT(ref sText);
            _LOADSAVE.LoadBannedProxy();
            int num1 = 0;
            int num2 = 1;
            int num3 = Information.UBound((Array) _VARIABLES.BannedProxy, 1);
            int index1 = num2;
            while (index1 <= num3)
            {
              int num4 = 1;
              int num5 = Information.UBound((Array) _VARIABLES.Proxy, 1);
              int index2 = num4;
              while (index2 <= num5)
              {
                if (Operators.CompareString(_VARIABLES.Proxy[index2].IP + ":" + Conversions.ToString(_VARIABLES.Proxy[index2].Port), _VARIABLES.BannedProxy[index1], false) == 0)
                {
                  _VARIABLES.Proxy[index2].IP = string.Empty;
                  checked { ++num1; }
                }
                checked { ++index2; }
              }
              checked { ++index1; }
            }
            _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
            sText = "Удалено Banned Proxy: " + Conversions.ToString(num1);
            fn2.TXT(ref sText);
            if (mdConnect.ProxCNT == Information.UBound((Array) _VARIABLES.Proxy, 1))
              break;
          }
          if (_VARIABLES.Proxy[mdConnect.ProxCNT].IP.Length == 0)
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Banned Proxy №" + Conversions.ToString(mdConnect.ProxCNT);
            fn.TXT(ref sText);
          }
          else
            goto label_26;
        }
        _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
        sText = "Все прокси помечены как Banned, регистрация остановлена.";
        fn3.TXT(ref sText);
        MyProject.Forms.frmMain.StopReg();
        return (myProxy) null;
label_26:
        _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy = mdConnect.ProxCNT;
      }
      myProxy.IP = _VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].IP;
      myProxy.Port = _VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].Port;
      myProxy.Login = _VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].Login;
      myProxy.Password = _VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].Password;
      myProxy.Protocol = _VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].Protocol;
      if (MyProject.Forms.frmMain.lblProxy.BackColor != Color.Green)
        MyProject.Forms.frmMain.lblProxy.BackColor = Color.Green;
      MyProject.Forms.frmMain.lblProxy.Text = myProxy.IP;
      return myProxy;
    }

    public static void StartPage(int Index)
    {
      if (!_VARIABLES.DoWork_Reg)
      {
        if (!_VARIABLES.OptionReport[3])
          return;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Thread " + Conversions.ToString(Index) + " - STOP";
        _FUNCTION.SBTXT(ref sText);
      }
      else
      {
        _VARIABLES.CurThreadData[Index] = new _VARIABLES.meCurThreadData();
        if (_VARIABLES.DebugOp.FullSessionLog)
          _VARIABLES.CurThreadData[Index].SessionLog = new StringBuilder();
        if (_VARIABLES.Mirror[Index] > _VARIABLES.Progress_MaxValue_Reg)
        {
          _VARIABLES.Progress_MaxValue_Reg = _VARIABLES.Mirror[Index];
          MyProject.Forms.frmMain.pbGenLogin.Value = _VARIABLES.Progress_MaxValue_Reg;
        }
        _VARIABLES.CurThreadData[Index].CurUserAgent = checked ((byte) _FUNCTION.sRND.Next(0, 8));
        switch (_VARIABLES.ActionCurrent)
        {
          case _VARIABLES.Action.RegMail:
            if (!_VARIABLES.OP.AutoCAPTCHA)
              _FUNCTION.VisibleRequest(1);
            _VARIABLES.WS[Index].ConnectTo = "start_page";
            MyProject.Forms.frmMain.LV_Dostupno.Items.Clear();
            _VARIABLES.CurThreadData[Index].FreeMailDomain = new string[1];
            switch (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].DomainID)
            {
              case 0:
                _VARIABLES.CurThreadData[Index].PostDataLine = new string[36];
                _VARIABLES.CurThreadData[Index].PostDataVariable = new string[36];
                if (Operators.CompareString(Strings.Right(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain, 2), "ua", false) == 0)
                  _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login.Replace(".", "_");
                SocketNET socketNet1 = _VARIABLES.WS[Index];
                string set_URL1 = "https://e.mail.ru/signup?from=main_noc";
                myCookies set_Cookies1 = (myCookies) null;
                string set_Referer1 = "http://mail.ru/";
                string set_PostData1 = (string) null;
                myProxy set_Proxy1 = mdConnect.SetProxy(Index);
                _VARIABLES.meCurThreadData[] curThreadData1 = _VARIABLES.CurThreadData;
                _VARIABLES.meCurThreadData[] meCurThreadDataArray1 = curThreadData1;
                int index1 = Index;
                int index2 = index1;
                short curUserAgent1 = (short) meCurThreadDataArray1[index2].CurUserAgent;
                string set_X_Forwarded_For1 = (string) null;
                string set_ContentType1 = (string) null;
                object set_Accept_Charset1 = (object) "utf-8";
                string set_Headers_Add1 = (string) null;
                socketNet1.Connect(ref set_URL1, ref set_Cookies1, ref set_Referer1, ref set_PostData1, set_Proxy1, ref curUserAgent1, ref set_X_Forwarded_For1, ref set_ContentType1, ref set_Accept_Charset1, ref set_Headers_Add1);
                curThreadData1[index1].CurUserAgent = checked ((byte) curUserAgent1);
                return;
              case 1:
                if (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login.Length > 20)
                {
                  string sText1 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# [Login > 20] последние символы игнорируются.";
                  _FUNCTION.SBTXT(ref sText1);
                  _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login = Strings.Left(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login, 20);
                  string Left = Strings.Right(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login, 1);
                  if (Operators.CompareString(Left, "-", false) == 0 || Operators.CompareString(Left, ".", false) == 0 || Operators.CompareString(Left, "_", false) == 0)
                  {
                    string sText2 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Запрещенный завершающий символ в логине.";
                    _FUNCTION.SBTXT(ref sText2);
                    _VARIABLES.WS[Index].FreeSocket = true;
                    return;
                  }
                }
                _VARIABLES.CurThreadData[Index].CookiesMail = new myCookies();
                SocketNET socketNet2 = _VARIABLES.WS[Index];
                string set_URL2 = "http://qip.ru/reg/register";
                myCookies set_Cookies2 = (myCookies) null;
                string set_Referer2 = "http://qip.ru/";
                string set_PostData2 = (string) null;
                myProxy set_Proxy2 = mdConnect.SetProxy(Index);
                _VARIABLES.meCurThreadData[] curThreadData2 = _VARIABLES.CurThreadData;
                _VARIABLES.meCurThreadData[] meCurThreadDataArray2 = curThreadData2;
                int index3 = Index;
                int index4 = index3;
                short curUserAgent2 = (short) meCurThreadDataArray2[index4].CurUserAgent;
                string set_X_Forwarded_For2 = (string) null;
                string set_ContentType2 = (string) null;
                object set_Accept_Charset2 = (object) "utf-8";
                string set_Headers_Add2 = (string) null;
                socketNet2.Connect(ref set_URL2, ref set_Cookies2, ref set_Referer2, ref set_PostData2, set_Proxy2, ref curUserAgent2, ref set_X_Forwarded_For2, ref set_ContentType2, ref set_Accept_Charset2, ref set_Headers_Add2);
                curThreadData2[index3].CurUserAgent = checked ((byte) curUserAgent2);
                return;
              case 2:
                SocketNET socketNet3 = _VARIABLES.WS[Index];
                string set_URL3 = "http://passport.meta.ua/?mode=reg&ref=main";
                myCookies set_Cookies3 = (myCookies) null;
                string set_Referer3 = "http://meta.ua/";
                string set_PostData3 = (string) null;
                myProxy set_Proxy3 = mdConnect.SetProxy(Index);
                _VARIABLES.meCurThreadData[] curThreadData3 = _VARIABLES.CurThreadData;
                _VARIABLES.meCurThreadData[] meCurThreadDataArray3 = curThreadData3;
                int index5 = Index;
                int index6 = index5;
                short curUserAgent3 = (short) meCurThreadDataArray3[index6].CurUserAgent;
                string set_X_Forwarded_For3 = (string) null;
                string set_ContentType3 = (string) null;
                object set_Accept_Charset3 = (object) 1251;
                string set_Headers_Add3 = (string) null;
                socketNet3.Connect(ref set_URL3, ref set_Cookies3, ref set_Referer3, ref set_PostData3, set_Proxy3, ref curUserAgent3, ref set_X_Forwarded_For3, ref set_ContentType3, ref set_Accept_Charset3, ref set_Headers_Add3);
                curThreadData3[index5].CurUserAgent = checked ((byte) curUserAgent3);
                return;
              default:
                _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
                string sText3 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Домен <" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain + "> не поддерживается.";
                fn1.TXT(ref sText3);
                _VARIABLES.WS[Index].FreeSocket = true;
                return;
            }
          case _VARIABLES.Action.CheckMail_WebFace:
            switch (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].DomainID)
            {
              case 0:
                if ((int) _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Registered != 7)
                {
                  _VARIABLES.WS[Index].ConnectTo = "CheckMail_WebFace";
                  string set_PostData4 = "Domain=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain + "&Login=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "&Password=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password + "&new_auth_form=1&saveauth=1";
                  SocketNET socketNet4 = _VARIABLES.WS[Index];
                  string set_URL4 = "https://auth.mail.ru/cgi-bin/auth?from=splash";
                  myCookies set_Cookies4 = (myCookies) null;
                  string set_Referer4 = "http://mail.ru/";
                  myProxy set_Proxy4 = mdConnect.SetProxy(Index);
                  _VARIABLES.meCurThreadData[] curThreadData4 = _VARIABLES.CurThreadData;
                  _VARIABLES.meCurThreadData[] meCurThreadDataArray4 = curThreadData4;
                  int index7 = Index;
                  int index8 = index7;
                  short curUserAgent4 = (short) meCurThreadDataArray4[index8].CurUserAgent;
                  string set_X_Forwarded_For4 = (string) null;
                  string set_ContentType4 = (string) null;
                  object set_Accept_Charset4 = (object) "utf-8";
                  string set_Headers_Add4 = (string) null;
                  socketNet4.Connect(ref set_URL4, ref set_Cookies4, ref set_Referer4, ref set_PostData4, set_Proxy4, ref curUserAgent4, ref set_X_Forwarded_For4, ref set_ContentType4, ref set_Accept_Charset4, ref set_Headers_Add4);
                  curThreadData4[index7].CurUserAgent = checked ((byte) curUserAgent4);
                  return;
                }
                _VARIABLES.WS[Index].ConnectTo = "UnClose Acc Enter";
                string set_URL5 = "https://e.mail.ru/cgi-bin/enableuser?login=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "&domain=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain;
                SocketNET socketNet5 = _VARIABLES.WS[Index];
                myCookies set_Cookies5 = (myCookies) null;
                string set_Referer5 = "http://mail.ru/";
                string set_PostData5 = (string) null;
                myProxy set_Proxy5 = mdConnect.SetProxy(Index);
                _VARIABLES.meCurThreadData[] curThreadData5 = _VARIABLES.CurThreadData;
                _VARIABLES.meCurThreadData[] meCurThreadDataArray5 = curThreadData5;
                int index9 = Index;
                int index10 = index9;
                short curUserAgent5 = (short) meCurThreadDataArray5[index10].CurUserAgent;
                string set_X_Forwarded_For5 = (string) null;
                string set_ContentType5 = (string) null;
                object set_Accept_Charset5 = (object) "utf-8";
                string set_Headers_Add5 = (string) null;
                socketNet5.Connect(ref set_URL5, ref set_Cookies5, ref set_Referer5, ref set_PostData5, set_Proxy5, ref curUserAgent5, ref set_X_Forwarded_For5, ref set_ContentType5, ref set_Accept_Charset5, ref set_Headers_Add5);
                curThreadData5[index9].CurUserAgent = checked ((byte) curUserAgent5);
                return;
              case 1:
                _VARIABLES.WS[Index].ConnectTo = "CheckMail_WebFace";
                string set_URL6 = "http://api.qip.ru/api/test?r=" + _FUNCTION.MathRandom() + "&user=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "&pass=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password + "&host=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain + "&alien=1&time=-240&JsHttpRequest=134588" + Conversions.ToString(_FUNCTION.sRND.Next(11111111, 99999999)) + "-script";
                SocketNET socketNet6 = _VARIABLES.WS[Index];
                myCookies set_Cookies6 = (myCookies) null;
                string set_Referer6 = "http://qip.ru/";
                string set_PostData6 = (string) null;
                myProxy set_Proxy6 = mdConnect.SetProxy(Index);
                _VARIABLES.meCurThreadData[] curThreadData6 = _VARIABLES.CurThreadData;
                _VARIABLES.meCurThreadData[] meCurThreadDataArray6 = curThreadData6;
                int index11 = Index;
                int index12 = index11;
                short curUserAgent6 = (short) meCurThreadDataArray6[index12].CurUserAgent;
                string set_X_Forwarded_For6 = (string) null;
                string set_ContentType6 = (string) null;
                object set_Accept_Charset6 = (object) "utf-8";
                string set_Headers_Add6 = (string) null;
                socketNet6.Connect(ref set_URL6, ref set_Cookies6, ref set_Referer6, ref set_PostData6, set_Proxy6, ref curUserAgent6, ref set_X_Forwarded_For6, ref set_ContentType6, ref set_Accept_Charset6, ref set_Headers_Add6);
                curThreadData6[index11].CurUserAgent = checked ((byte) curUserAgent6);
                return;
              case 2:
                _VARIABLES.WS[Index].ConnectTo = "CheckMail_WebFace";
                string set_PostData7 = "from=mail&login=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login + "&password=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password + "&subm=%C2%EE%E9%F2%E8&redirect=http%3A%2F%2Fwebmail.meta.ua%2F&mode=login&oauthsid=";
                SocketNET socketNet7 = _VARIABLES.WS[Index];
                string set_URL7 = "https://passport.meta.ua/login/";
                myCookies set_Cookies7 = (myCookies) null;
                string set_Referer7 = "https://passport.meta.ua/login/";
                myProxy set_Proxy7 = mdConnect.SetProxy(Index);
                _VARIABLES.meCurThreadData[] curThreadData7 = _VARIABLES.CurThreadData;
                _VARIABLES.meCurThreadData[] meCurThreadDataArray7 = curThreadData7;
                int index13 = Index;
                int index14 = index13;
                short curUserAgent7 = (short) meCurThreadDataArray7[index14].CurUserAgent;
                string set_X_Forwarded_For7 = (string) null;
                string set_ContentType7 = (string) null;
                object set_Accept_Charset7 = (object) 1251;
                string set_Headers_Add7 = (string) null;
                socketNet7.Connect(ref set_URL7, ref set_Cookies7, ref set_Referer7, ref set_PostData7, set_Proxy7, ref curUserAgent7, ref set_X_Forwarded_For7, ref set_ContentType7, ref set_Accept_Charset7, ref set_Headers_Add7);
                curThreadData7[index13].CurUserAgent = checked ((byte) curUserAgent7);
                return;
              default:
                _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
                string sText4 = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Домен <" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain + "> не поддерживается.";
                fn2.TXT(ref sText4);
                _VARIABLES.WS[Index].FreeSocket = true;
                return;
            }
        }
      }
    }

    public static void DataArrival(int Index)
    {
      string sPacketFrom = string.Empty;
      try
      {
        if (_VARIABLES.OP.ViewResponse)
        {
          MyProject.Forms.frmMain.LV.Items[checked (_VARIABLES.Mirror[Index] - 1)].SubItems[6].Text = Conversions.ToString(_VARIABLES.WS[Index].Response);
          MyProject.Forms.frmMain.LV.Items[checked (_VARIABLES.Mirror[Index] - 1)].SubItems[7].Text = "+Packet OK";
        }
        if (!_VARIABLES.DoWork_Reg && Operators.CompareString(Strings.Left(_VARIABLES.WS[Index].ConnectTo.ToLower(), 4), "reg_", false) != 0)
        {
          if (!_VARIABLES.OptionReport[3])
            return;
          string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Thread " + Conversions.ToString(Index) + " - STOP";
          _FUNCTION.SBTXT(ref sText);
        }
        else if (_VARIABLES.WS[Index].ResponseNum != 302 & _VARIABLES.WS[Index].ResponseNum != 200)
        {
          switch (_VARIABLES.WS[Index].ResponseNum)
          {
            case 307:
              if (!Information.IsNothing((object) _VARIABLES.WS[Index].Location))
              {
                int Length = Strings.InStr(9, _VARIABLES.WS[Index].Location, "/", CompareMethod.Binary);
                if (Length == 0)
                  Length = _VARIABLES.WS[Index].Location.Length;
                int Index1 = Index;
                string Description = Conversions.ToString(_VARIABLES.WS[Index].ResponseNum) + " Proxy Redirect: " + Strings.Mid(_VARIABLES.WS[Index].Location, 1, Length);
                mdConnect.ErrorEvent(Index1, ref Description);
                break;
              }
              int Index2 = Index;
              string Description1 = Conversions.ToString(_VARIABLES.WS[Index].ResponseNum) + " " + _VARIABLES.WS[Index].ResponseMessage;
              mdConnect.ErrorEvent(Index2, ref Description1);
              break;
            case 400:
            case 404:
            case 500:
            case 503:
              int Index3 = Index;
              string Description2 = "Bad proxy <" + Conversions.ToString(_VARIABLES.WS[Index].ResponseNum) + ">";
              mdConnect.ErrorEvent(Index3, ref Description2);
              break;
            case 504:
              int Index4 = Index;
              string Description3 = "Proxy could not connect to remote host <" + Conversions.ToString(_VARIABLES.WS[Index].ResponseNum) + ">";
              mdConnect.ErrorEvent(Index4, ref Description3);
              break;
            default:
              int Index5 = Index;
              string Description4 = Conversions.ToString(_VARIABLES.WS[Index].ResponseNum) + " " + _VARIABLES.WS[Index].ResponseMessage;
              mdConnect.ErrorEvent(Index5, ref Description4);
              break;
          }
        }
        else
        {
          sPacketFrom = _VARIABLES.WS[Index].PacketBODY;
          if (_VARIABLES.DebugOp.FullSessionLog)
          {
            _VARIABLES.CurThreadData[Index].SessionLog.AppendLine("===================================================================================================================================");
            _VARIABLES.CurThreadData[Index].SessionLog.AppendLine("=== NEW SESSION ===================================================================================================================");
            _VARIABLES.CurThreadData[Index].SessionLog.AppendLine("ConnectTo = " + _VARIABLES.WS[Index].ConnectTo);
            _VARIABLES.CurThreadData[Index].SessionLog.AppendLine("===================================================================================================================================");
            if (Strings.InStr(_VARIABLES.WS[Index].PacketHEAD.ToLower(), "content-type: image/", CompareMethod.Binary) == 0)
            {
              _VARIABLES.CurThreadData[Index].SessionLog.AppendLine(_VARIABLES.WS[Index].PacketTo);
              _VARIABLES.CurThreadData[Index].SessionLog.AppendLine("-----------------------------------------------------------------------------------------------------------------------------------");
              _VARIABLES.CurThreadData[Index].SessionLog.AppendLine(_VARIABLES.WS[Index].PacketHEAD);
              _VARIABLES.CurThreadData[Index].SessionLog.AppendLine("-----------------------------------------------------------------------------------------------------------------------------------");
              _VARIABLES.CurThreadData[Index].SessionLog.AppendLine(sPacketFrom);
            }
            else
            {
              _VARIABLES.CurThreadData[Index].SessionLog.AppendLine(_VARIABLES.WS[Index].PacketTo);
              _VARIABLES.CurThreadData[Index].SessionLog.AppendLine("-----------------------------------------------------------------------------------------------------------------------------------");
              _VARIABLES.CurThreadData[Index].SessionLog.AppendLine(_VARIABLES.WS[Index].PacketHEAD);
              _VARIABLES.CurThreadData[Index].SessionLog.AppendLine("-----------------------------------------------------------------------------------------------------------------------------------");
              _VARIABLES.CurThreadData[Index].SessionLog.AppendLine(" ~ IMAGE ~");
            }
            _VARIABLES.CurThreadData[Index].SessionLog.AppendLine("===================================================================================================================================");
          }
          switch (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].DomainID)
          {
            case 0:
              string connectTo1 = _VARIABLES.WS[Index].ConnectTo;
              if (Operators.CompareString(connectTo1, "start_page", false) == 0)
              {
                _DataArrival_ID0.StartPage_ID_0(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo1, "check_mail", false) == 0)
              {
                _DataArrival_ID0.CheckMail_ID_0(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo1, "captcha_1_domain1", false) == 0)
              {
                _DataArrival_ID0.Captcha1_ID_0(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo1, "captcha_2_domain1", false) == 0)
              {
                _DataArrival_ID0.Captcha2_ID_0(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo1, "captcha_3_domain1", false) == 0)
              {
                _DataArrival_ID0.Captcha3_ID_0(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo1, "reg_domain1_mail_ajax_img", false) == 0)
              {
                _DataArrival_ID0.AjaxCaptchaCheck_ID_0(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo1, "reg_domain1", false) == 0)
              {
                _DataArrival_ID0.Reg_ID_0(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo1, "CheckMail_WebFace", false) == 0)
              {
                _DataArrival_ID0.CheckMail_WebFace_ID_0(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo1, "UnClose Acc Enter", false) == 0)
              {
                _DataArrival_ID0.UnCloseAccEnter_ID_0(Index, sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo1, "UnClose Acc Final", false) != 0)
                break;
              _DataArrival_ID0.UnCloseAccFinal_ID_0(Index, sPacketFrom);
              break;
            case 1:
              _VARIABLES.CurThreadData[Index].CookiesMail.Add(_VARIABLES.WS[Index].Cookies);
              string connectTo2 = _VARIABLES.WS[Index].ConnectTo;
              if (Operators.CompareString(connectTo2, "start_page", false) == 0)
              {
                _DataArrival_ID1.StartPage_ID_1(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo2, "RegsHelper1", false) == 0)
              {
                _DataArrival_ID1.RegsHelper1_ID_1(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo2, "CheckLogin", false) == 0)
              {
                _DataArrival_ID1.CheckLogin_ID_1(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo2, "StartPage2", false) == 0)
              {
                _DataArrival_ID1.StartPage2_ID_1(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo2, "RegsHelper2", false) == 0)
              {
                _DataArrival_ID1.RegsHelper2_ID_1(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo2, "Captcha", false) == 0)
              {
                _DataArrival_ID1.Captcha_ID_1(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo2, "Reg_", false) == 0)
              {
                _DataArrival_ID1.Reg_ID_1(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo2, "CheckMail_WebFace", false) != 0)
                break;
              _DataArrival_ID1.CheckMail_WebFace_ID_1(Index, ref sPacketFrom);
              break;
            case 2:
              string connectTo3 = _VARIABLES.WS[Index].ConnectTo;
              if (Operators.CompareString(connectTo3, "start_page", false) == 0)
              {
                _DataArrival_ID2.StartPage_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "CheckLogin", false) == 0)
              {
                _DataArrival_ID2.CheckLogin_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Captcha", false) == 0)
              {
                _DataArrival_ID2.Captcha_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Reg_Step1", false) == 0)
              {
                _DataArrival_ID2.Reg_Step1_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Reg_Redirect_Step1", false) == 0)
              {
                _DataArrival_ID2.Reg_Redirect_Step1_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Reg_Step2", false) == 0)
              {
                _DataArrival_ID2.Reg_Step2_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "ReloadCaptcha", false) == 0)
              {
                _DataArrival_ID2.ReloadCaptcha_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Reg_EnterAccount_2", false) == 0)
              {
                _DataArrival_ID2.EnterAccount_2_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Reg_EnterAccount_3", false) == 0)
              {
                _DataArrival_ID2.EnterAccount_3_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Reg_EnterAccount_4", false) == 0)
              {
                _DataArrival_ID2.EnterAccount_4_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Reg_EnterAccount_5", false) == 0)
              {
                _DataArrival_ID2.EnterAccount_5_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Reg_EnterAccount_6", false) == 0)
              {
                _DataArrival_ID2.EnterAccount_6_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Reg_EnterAccount_7", false) == 0)
              {
                _DataArrival_ID2.EnterAccount_7_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Reg_EnterAccount_8", false) == 0)
              {
                _DataArrival_ID2.EnterAccount_8_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "Reg_EnterAccount_9", false) == 0)
              {
                _DataArrival_ID2.EnterAccount_9_ID_2(Index, ref sPacketFrom);
                break;
              }
              if (Operators.CompareString(connectTo3, "CheckMail_WebFace", false) != 0)
                break;
              _DataArrival_ID2.CheckMail_WebFace_ID_2(Index, ref sPacketFrom);
              break;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# ErrorMD: " + exception.Message;
        fn.TXT(ref sText);
        mdConnect.ErrorOnEnd(Index, ref sPacketFrom);
        ProjectData.ClearProjectError();
      }
    }

    public static void ErrorOnEnd(int Index, ref string sPacketFrom)
    {
      if (_VARIABLES.UseErrorCount)
      {
        checked { ++_VARIABLES.ErrorCountInWork; }
        if (_VARIABLES.ErrorCountInWork > _VARIABLES.ErrorCount)
        {
          string sText = "Счетчик ошибок превысил лимит (настройки регистрации).";
          _FUNCTION.SBTXT(ref sText);
          sText = "Опции безопасности - принудительная остановка регистрации.";
          _FUNCTION.SBTXT(ref sText);
          MyProject.Forms.frmMain.StopReg();
          return;
        }
      }
      string str;
      if (_VARIABLES.DebugOp.SavePacket_RegError)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Save Packet to '" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_Incorrect.packet.log'";
        fn.TXT(ref sText);
        string sFileName = Conversions.ToString(_VARIABLES.Mirror[Index]) + "_Incorrect.packet.log";
        str = _VARIABLES.WS[Index].PacketHEAD + "\r\n" + sPacketFrom;
        _LOADSAVE.Save(ref sFileName, ref str);
      }
      str = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Incorrect response from the server.";
      _FUNCTION.SBTXT(ref str);
      _VARIABLES.WS[Index].FreeSocket = true;
    }

    public static void ErrorRegular(int Index, ref string sPacketFrom)
    {
      if (_VARIABLES.UseErrorCount)
      {
        checked { ++_VARIABLES.ErrorCountInWork; }
        if (_VARIABLES.ErrorCountInWork > _VARIABLES.ErrorCount)
        {
          string sText = "Счетчик ошибок превысил лимит (настройки регистрации).";
          _FUNCTION.SBTXT(ref sText);
          sText = "Опции безопасности - принудительная остановка регистрации.";
          _FUNCTION.SBTXT(ref sText);
          MyProject.Forms.frmMain.StopReg();
          return;
        }
      }
      if (_VARIABLES.DebugOp.SavePacket_RegError)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Save Packet to '" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_ErrorRegular.packet.log'";
        fn.TXT(ref sText);
        string sFileName = Conversions.ToString(_VARIABLES.Mirror[Index]) + "_ErrorRegular.packet.log";
        string sData = _VARIABLES.WS[Index].PacketHEAD + "\r\n" + sPacketFrom;
        _LOADSAVE.Save(ref sFileName, ref sData);
      }
      _VARIABLES.WS[Index].FreeSocket = true;
    }

    public static void ErrorEvent(int Index, ref string Description)
    {
      string str;
      if (_VARIABLES.OptionReport[6])
      {
        str = "Error Th#" + Conversions.ToString(Index) + ": " + Description;
        _FUNCTION.SBTXT(ref str);
      }
      if (!_VARIABLES.DoWork_Reg)
      {
        if (_VARIABLES.OptionReport[3])
        {
          str = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Thread " + Conversions.ToString(Index) + " - STOP";
          _FUNCTION.SBTXT(ref str);
        }
        if (_VARIABLES.WS_Data[Index].CaptchaText == null || _VARIABLES.WS_Data[Index].CaptchaText.Length <= 0)
          return;
        str = "Th#" + Conversions.ToString(Index) + " Из-за ошибки коннекта после остановки утрачена CAPTCHA: '" + _VARIABLES.WS_Data[Index].CaptchaText + "'";
        _FUNCTION.SBTXT(ref str);
        checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Lost; }
      }
      else if (mdConnect.ProxCNT == Information.UBound((Array) _VARIABLES.Proxy, 1) && md_HttpLoadProxy.HttpLoadProxy.Use)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        str = "Сработала функция загрузки proxy с URL";
        fn.TXT(ref str);
        md_HttpLoadProxy.HttpLoadProxy.LoadRequired = true;
        MyProject.Forms.frmMain.StopReg();
      }
      else
      {
        _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy = 0;
        if (_VARIABLES.OP.OpReg.Reconnect)
        {
          _VARIABLES.WS[Index].ConnectOptions.Proxy = mdConnect.SetProxy(Index);
          SocketNET socketNet = _VARIABLES.WS[Index];
          str = (string) null;
          myCookies set_Cookies = (myCookies) null;
          string set_Referer = (string) null;
          string set_PostData = (string) null;
          // ISSUE: variable of the null type
          __Null local = null;
          short set_UseBrowser = 0;
          string set_X_Forwarded_For = (string) null;
          string set_ContentType = (string) null;
          object set_Accept_Charset = (object) 1251;
          string set_Headers_Add = (string) null;
          socketNet.Connect(ref str, ref set_Cookies, ref set_Referer, ref set_PostData, (myProxy) local, ref set_UseBrowser, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
        }
        else
        {
          string sText = "Error Th#" + Conversions.ToString(Index) + ":  У потока не задан reconnect. Поток остановлен.";
          _FUNCTION.SBTXT(ref sText);
        }
      }
    }

    public static void DebugEvent(int Index, ref object Value)
    {
      string sText = Conversions.ToString(Operators.ConcatenateObject((object) (Conversions.ToString(Index) + " Value="), Value));
      _FUNCTION.SBTXT(ref sText);
    }

    public static void AC_NET_CaptchaSolved(int Index, ref string CaptchaText)
    {
      if (_VARIABLES.DoWork_Reg)
        MyProject.Forms.frmMain.picNoSlot.Image = MyProject.Forms.frmMain.IL_16.Images[1];
      string str;
      if (_VARIABLES.OptionReport[2])
      {
        str = "Th#" + Conversions.ToString(Index) + " " + _VARIABLES.ServiceNameAC + ": Captcha solved = " + CaptchaText;
        _FUNCTION.SBTXT(ref str);
      }
      CaptchaText = Strings.Replace(CaptchaText, " ", "", 1, -1, CompareMethod.Binary);
      if (_VARIABLES.PlaySound.Use && _VARIABLES.PlaySound.Play[2])
        MyProject.Computer.Audio.Play(_VARIABLES.PlaySound.Path[2]);
      switch (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].DomainID)
      {
        case 0:
          CaptchaText = CaptchaText.ToLower();
          _VARIABLES.WS_Data[Index].CaptchaText = CaptchaText;
          if (Operators.CompareString(CaptchaText, "000000000", false) == 0 || Operators.CompareString(CaptchaText, "ooooooooo", false) == 0)
          {
            checked { ++_VARIABLES.AC_NET.CapCounter.Cap_Lost; }
            if (_VARIABLES.OptionReport[8])
            {
              str = "Th#" + Conversions.ToString(Index) + " " + _VARIABLES.ServiceNameAC + ": Bad IP Captcha '" + CaptchaText + "'";
              _FUNCTION.SBTXT(ref str);
            }
            if (_VARIABLES.DebugOp.SaveBadIP)
            {
              string StrBuffer = _VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].IP + ":" + Conversions.ToString(_VARIABLES.Proxy[_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].Proxy].Port) + "\n";
              str = Application.StartupPath + "\\BadIP_000000000.log";
              _LOADSAVE.FileAppend(ref str, ref StrBuffer);
            }
            if (_VARIABLES.DebugOp.FullSessionLog)
            {
              str = Application.StartupPath + "\\" + Conversions.ToString(_VARIABLES.Mirror[Index]) + "_session_cap_000000000.log";
              string StrBuffer = _VARIABLES.CurThreadData[Index].SessionLog.ToString();
              _LOADSAVE.FileSave(ref str, ref StrBuffer);
              _VARIABLES.CurThreadData[Index].SessionLog = (StringBuilder) null;
            }
            _VARIABLES.WS[Index].FreeSocket = true;
            break;
          }
          _VARIABLES.CurThreadData[Index].PostDataVariable[35] = CaptchaText;
          StringBuilder stringBuilder1 = new StringBuilder();
          int index1 = Information.UBound((Array) _VARIABLES.CurThreadData[Index].PostDataLine, 1);
          int num1 = 1;
          int num2 = checked (index1 - 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            stringBuilder1.Append(_VARIABLES.CurThreadData[Index].PostDataLine[index2] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[index2] + "&");
            checked { ++index2; }
          }
          stringBuilder1.Append(_VARIABLES.CurThreadData[Index].PostDataLine[index1] + "=" + _VARIABLES.CurThreadData[Index].PostDataVariable[index1]);
          if (_VARIABLES.CurThreadData[Index].CaptchaRef_2.Length == 0)
            stringBuilder1.Append("&new_captcha=1");
          _VARIABLES.WS[Index].ConnectTo = "reg_domain1";
          SocketNET socketNet1 = _VARIABLES.WS[Index];
          string set_URL1 = "https://e.mail.ru/reg?from=main_noc";
          str = "https://e.mail.ru/signup?from=main";
          string set_PostData1 = stringBuilder1.ToString();
          myProxy set_Proxy1 = mdConnect.SetProxy(Index);
          _VARIABLES.meCurThreadData[] curThreadData1 = _VARIABLES.CurThreadData;
          _VARIABLES.meCurThreadData[] meCurThreadDataArray1 = curThreadData1;
          int index3 = Index;
          int index4 = index3;
          short curUserAgent1 = (short) meCurThreadDataArray1[index4].CurUserAgent;
          string set_X_Forwarded_For1 = (string) null;
          string set_ContentType1 = (string) null;
          object set_Accept_Charset1 = (object) "utf-8";
          string set_Headers_Add = (string) null;
          socketNet1.Connect(ref set_URL1, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref str, ref set_PostData1, set_Proxy1, ref curUserAgent1, ref set_X_Forwarded_For1, ref set_ContentType1, ref set_Accept_Charset1, ref set_Headers_Add);
          curThreadData1[index3].CurUserAgent = checked ((byte) curUserAgent1);
          break;
        case 1:
          _VARIABLES.WS_Data[Index].CaptchaText = CaptchaText;
          StringBuilder stringBuilder2 = new StringBuilder();
          stringBuilder2.Append("first_name=" + md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Name));
          stringBuilder2.Append("&last_name=" + md_MailFunctions.ConvertSTRtoUTF8(ref _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.LastName));
          stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.username.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.username.Value);
          stringBuilder2.Append("&reg_host=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain);
          stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.pwd.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.pwd.Value);
          stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.pwd2.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.pwd2.Value);
          stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.email.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.email.Value);
          stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.man_sex.Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.man_sex.Value);
          stringBuilder2.Append("&bday=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthDay);
          stringBuilder2.Append("&bmonth=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthMonth);
          stringBuilder2.Append("&byear=" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthYear);
          stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.captcha.Name + "=" + CaptchaText);
          stringBuilder2.Append("&agree=on");
          stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[0].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[0].Value);
          stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[1].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[1].Value);
          stringBuilder2.Append("&" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[2].Name + "=" + _VARIABLES.CurThreadData[Index].data_QIP.Elem[2].Value);
          _VARIABLES.WS[Index].ConnectTo = "Reg_";
          SocketNET socketNet2 = _VARIABLES.WS[Index];
          string set_URL2 = "http://qip.ru/reg/register";
          string set_Referer1 = "http://qip.ru/reg/register";
          string set_PostData2 = stringBuilder2.ToString();
          myProxy set_Proxy2 = mdConnect.SetProxy(Index);
          _VARIABLES.meCurThreadData[] curThreadData2 = _VARIABLES.CurThreadData;
          _VARIABLES.meCurThreadData[] meCurThreadDataArray2 = curThreadData2;
          int index5 = Index;
          int index6 = index5;
          short curUserAgent2 = (short) meCurThreadDataArray2[index6].CurUserAgent;
          string set_X_Forwarded_For2 = (string) null;
          string set_ContentType2 = (string) null;
          object set_Accept_Charset2 = (object) "utf-8";
          str = (string) null;
          socketNet2.Connect(ref set_URL2, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer1, ref set_PostData2, set_Proxy2, ref curUserAgent2, ref set_X_Forwarded_For2, ref set_ContentType2, ref set_Accept_Charset2, ref str);
          curThreadData2[index5].CurUserAgent = checked ((byte) curUserAgent2);
          break;
        case 2:
          _VARIABLES.WS_Data[Index].CaptchaText = CaptchaText;
          StringBuilder stringBuilder3 = new StringBuilder();
          stringBuilder3.Append(_VARIABLES.CurThreadData[Index].data_METAua.Name.Name + "=" + _FUNCTION.ConvertSTRtoHexWeb1byte(ref _VARIABLES.CurThreadData[Index].data_METAua.Name.Value));
          stringBuilder3.Append("&" + _VARIABLES.CurThreadData[Index].data_METAua.Lastname.Name + "=" + _FUNCTION.ConvertSTRtoHexWeb1byte(ref _VARIABLES.CurThreadData[Index].data_METAua.Lastname.Value));
          stringBuilder3.Append("&" + _VARIABLES.CurThreadData[Index].data_METAua.Login.Name + "=" + _VARIABLES.CurThreadData[Index].data_METAua.Login.Value);
          stringBuilder3.Append("&" + _VARIABLES.CurThreadData[Index].data_METAua.Password1.Name + "=" + _VARIABLES.CurThreadData[Index].data_METAua.Password1.Value);
          stringBuilder3.Append("&" + _VARIABLES.CurThreadData[Index].data_METAua.Password2.Name + "=" + _VARIABLES.CurThreadData[Index].data_METAua.Password2.Value);
          stringBuilder3.Append("&uniq=" + _VARIABLES.CurThreadData[Index].data_METAua.uniq);
          stringBuilder3.Append("&captcha=" + CaptchaText);
          stringBuilder3.Append("&redirect=");
          stringBuilder3.Append("&from=passport");
          stringBuilder3.Append("&portable=0");
          stringBuilder3.Append("&ref=");
          stringBuilder3.Append("&rand_digit=" + _VARIABLES.CurThreadData[Index].data_METAua.rand_digit);
          _VARIABLES.WS[Index].ConnectTo = "Reg_Step1";
          SocketNET socketNet3 = _VARIABLES.WS[Index];
          string set_URL3 = "http://passport.meta.ua/reg/";
          myCookies set_Cookies = (myCookies) null;
          string set_Referer2 = "http://passport.meta.ua/?mode=reg&ref=main";
          string set_PostData3 = stringBuilder3.ToString();
          myProxy set_Proxy3 = mdConnect.SetProxy(Index);
          _VARIABLES.meCurThreadData[] curThreadData3 = _VARIABLES.CurThreadData;
          _VARIABLES.meCurThreadData[] meCurThreadDataArray3 = curThreadData3;
          int index7 = Index;
          int index8 = index7;
          short curUserAgent3 = (short) meCurThreadDataArray3[index8].CurUserAgent;
          string set_X_Forwarded_For3 = (string) null;
          string set_ContentType3 = (string) null;
          object set_Accept_Charset3 = (object) 1251;
          str = (string) null;
          socketNet3.Connect(ref set_URL3, ref set_Cookies, ref set_Referer2, ref set_PostData3, set_Proxy3, ref curUserAgent3, ref set_X_Forwarded_For3, ref set_ContentType3, ref set_Accept_Charset3, ref str);
          curThreadData3[index7].CurUserAgent = checked ((byte) curUserAgent3);
          break;
      }
    }

    public static void AC_NET_InfoReport(ref AntiCaptchaNET.ConnectTo_Enum InfoConnectTo, ref string InfoData)
    {
      if (!_VARIABLES.OptionReport[8])
        return;
      string sText = "AC InfoData: " + InfoData;
      _FUNCTION.SBTXT(ref sText);
    }

    public static void AC_NET_ErrorEvent_Socket(int Index, ref string Description, bool ThreadStop)
    {
      if (_VARIABLES.OptionReport[8])
      {
        string sText = "Th#" + Conversions.ToString(Index) + " " + _VARIABLES.ServiceNameAC + ": " + Description;
        _FUNCTION.SBTXT(ref sText);
      }
      _VARIABLES.WS[Index].FreeSocket = true;
    }

    public static void AC_NET_ErrorEvent_AС(int Index, ref string Description)
    {
      string str;
      if (_VARIABLES.OptionReport[8])
      {
        str = "Th#" + Conversions.ToString(Index) + " " + _VARIABLES.ServiceNameAC + ": " + Description;
        _FUNCTION.SBTXT(ref str);
      }
      if (_VARIABLES.PauseConnect)
        _VARIABLES.WS[Index].FreeSocket = true;
      else if (!_VARIABLES.DoWork_Reg)
      {
        _VARIABLES.WS[Index].FreeSocket = true;
      }
      else
      {
        switch (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].DomainID)
        {
          case 0:
            _DataArrival_ID0.Mail_ru_Refresh_Captcha(Index);
            break;
          case 1:
            _VARIABLES.WS[Index].ConnectTo = "RegsHelper2";
            SocketNET socketNet1 = _VARIABLES.WS[Index];
            str = "http://qip.ru/reg/register";
            string set_PostData1 = (string) null;
            myProxy set_Proxy1 = mdConnect.SetProxy(Index);
            _VARIABLES.meCurThreadData[] curThreadData1 = _VARIABLES.CurThreadData;
            _VARIABLES.meCurThreadData[] meCurThreadDataArray1 = curThreadData1;
            int index1 = Index;
            int index2 = index1;
            short curUserAgent1 = (short) meCurThreadDataArray1[index2].CurUserAgent;
            string set_X_Forwarded_For1 = (string) null;
            string set_ContentType1 = (string) null;
            object set_Accept_Charset1 = (object) "utf-8";
            string set_Headers_Add = (string) null;
            socketNet1.Connect(ref _VARIABLES.CurThreadData[Index].SpareUrl_2, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref str, ref set_PostData1, set_Proxy1, ref curUserAgent1, ref set_X_Forwarded_For1, ref set_ContentType1, ref set_Accept_Charset1, ref set_Headers_Add);
            curThreadData1[index1].CurUserAgent = checked ((byte) curUserAgent1);
            break;
          case 2:
            _VARIABLES.WS[Index].ConnectTo = "Captcha";
            SocketNET socketNet2 = _VARIABLES.WS[Index];
            string set_Referer = "http://passport.meta.ua/?mode=reg&ref=main";
            string set_PostData2 = (string) null;
            myProxy set_Proxy2 = mdConnect.SetProxy(Index);
            _VARIABLES.meCurThreadData[] curThreadData2 = _VARIABLES.CurThreadData;
            _VARIABLES.meCurThreadData[] meCurThreadDataArray2 = curThreadData2;
            int index3 = Index;
            int index4 = index3;
            short curUserAgent2 = (short) meCurThreadDataArray2[index4].CurUserAgent;
            string set_X_Forwarded_For2 = (string) null;
            string set_ContentType2 = (string) null;
            object set_Accept_Charset2 = (object) 1251;
            str = (string) null;
            socketNet2.Connect(ref _VARIABLES.CurThreadData[Index].data_METAua.captcha_Url, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData2, set_Proxy2, ref curUserAgent2, ref set_X_Forwarded_For2, ref set_ContentType2, ref set_Accept_Charset2, ref str);
            curThreadData2[index3].CurUserAgent = checked ((byte) curUserAgent2);
            break;
        }
      }
    }

    public static void AC_NET_ErrorEvent_CAPCHA_NOT_READY(int Index)
    {
    }

    public static void AC_NET_ErrorEvent_ERROR_NO_SLOT_AVAILABLE(int Index, bool ThreadStop)
    {
      if (_VARIABLES.DoWork_Reg)
        MyProject.Forms.frmMain.picNoSlot.Image = MyProject.Forms.frmMain.IL_16.Images[2];
      if (_VARIABLES.OptionReport[4])
      {
        string sText = "Th#" + Conversions.ToString(Index) + " " + _VARIABLES.ServiceNameAC + ": ERROR_NO_SLOT_AVAILABLE";
        _FUNCTION.SBTXT(ref sText);
      }
      if (!ThreadStop)
        return;
      _VARIABLES.WS[Index].FreeSocket = true;
    }

    public static void AC_NET_BadReportOK(int Index)
    {
      string str;
      if (_VARIABLES.OptionReport[8])
      {
        str = "Th#" + Conversions.ToString(Index) + " " + _VARIABLES.ServiceNameAC + ": Bad Report - OK";
        _FUNCTION.SBTXT(ref str);
      }
      if (!_VARIABLES.DoWork_Reg)
        _VARIABLES.WS[Index].FreeSocket = true;
      else if (_VARIABLES.PauseConnect)
      {
        _VARIABLES.WS[Index].FreeSocket = true;
      }
      else
      {
        switch (_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].DomainID)
        {
          case 0:
            _VARIABLES.WS[Index].FreeSocket = true;
            break;
          case 1:
            _VARIABLES.WS[Index].ConnectTo = "RegsHelper2";
            SocketNET socketNet1 = _VARIABLES.WS[Index];
            str = "http://qip.ru/reg/register";
            string set_PostData1 = (string) null;
            myProxy set_Proxy1 = mdConnect.SetProxy(Index);
            _VARIABLES.meCurThreadData[] curThreadData1 = _VARIABLES.CurThreadData;
            _VARIABLES.meCurThreadData[] meCurThreadDataArray1 = curThreadData1;
            int index1 = Index;
            int index2 = index1;
            short curUserAgent1 = (short) meCurThreadDataArray1[index2].CurUserAgent;
            string set_X_Forwarded_For1 = (string) null;
            string set_ContentType1 = (string) null;
            object set_Accept_Charset1 = (object) "utf-8";
            string set_Headers_Add = (string) null;
            socketNet1.Connect(ref _VARIABLES.CurThreadData[Index].SpareUrl_2, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref str, ref set_PostData1, set_Proxy1, ref curUserAgent1, ref set_X_Forwarded_For1, ref set_ContentType1, ref set_Accept_Charset1, ref set_Headers_Add);
            curThreadData1[index1].CurUserAgent = checked ((byte) curUserAgent1);
            break;
          case 2:
            _VARIABLES.WS[Index].ConnectTo = "Captcha";
            SocketNET socketNet2 = _VARIABLES.WS[Index];
            string set_Referer = "http://passport.meta.ua/?mode=reg&ref=main";
            string set_PostData2 = (string) null;
            myProxy set_Proxy2 = mdConnect.SetProxy(Index);
            _VARIABLES.meCurThreadData[] curThreadData2 = _VARIABLES.CurThreadData;
            _VARIABLES.meCurThreadData[] meCurThreadDataArray2 = curThreadData2;
            int index3 = Index;
            int index4 = index3;
            short curUserAgent2 = (short) meCurThreadDataArray2[index4].CurUserAgent;
            string set_X_Forwarded_For2 = (string) null;
            string set_ContentType2 = (string) null;
            object set_Accept_Charset2 = (object) 1251;
            str = (string) null;
            socketNet2.Connect(ref _VARIABLES.CurThreadData[Index].data_METAua.captcha_Url, ref _VARIABLES.CurThreadData[Index].CookiesMail, ref set_Referer, ref set_PostData2, set_Proxy2, ref curUserAgent2, ref set_X_Forwarded_For2, ref set_ContentType2, ref set_Accept_Charset2, ref str);
            curThreadData2[index3].CurUserAgent = checked ((byte) curUserAgent2);
            break;
        }
      }
    }

    public static void AC_NET_ErrorEvent_Balance(ref string Description)
    {
      if (!_VARIABLES.OptionReport[8])
        return;
      string sText = _VARIABLES.ServiceNameAC + " Balance Ex: " + Description;
      _FUNCTION.SBTXT(ref sText);
    }
  }
}
