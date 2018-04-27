// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.md_HttpLoadProxy
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class md_HttpLoadProxy
  {
    public static md_HttpLoadProxy.myHttpLoadProxy HttpLoadProxy;
    public static SocketNET WS_HttpLoadProxy;
    public static int HttpLoadProxy_Step;
    public static StringBuilder SB_HttpLoadProxy;

    public static void Start_HttpLoadProxy()
    {
      if (Information.UBound((Array) md_HttpLoadProxy.HttpLoadProxy.VALUE, 1) == 0)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Загрузка прокси-листов с удаленных сайтов, невозможна, т.к. не задано ни одного URL.";
        fn.TXT(ref sText);
      }
      else
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Загрузка прокси-листов с URL.";
        fn.TXT(ref sText);
        md_HttpLoadProxy.HttpLoadProxy_Step = 0;
        md_HttpLoadProxy.SB_HttpLoadProxy = new StringBuilder();
        if (!Information.IsNothing((object) md_HttpLoadProxy.WS_HttpLoadProxy))
        {
          md_HttpLoadProxy.WS_HttpLoadProxy.DataArrival -= new SocketNET.DataArrivalEventHandler(md_HttpLoadProxy.WS_HttpLoadProxy_DataArrival);
          md_HttpLoadProxy.WS_HttpLoadProxy.ErrorEvent -= new SocketNET.ErrorEventEventHandler(md_HttpLoadProxy.WS_HttpLoadProxy_ErrorEvent);
          md_HttpLoadProxy.WS_HttpLoadProxy.DebugEvent -= new SocketNET.DebugEventEventHandler(md_HttpLoadProxy.WS_HttpLoadProxy_DebugEvent);
          md_HttpLoadProxy.WS_HttpLoadProxy = (SocketNET) null;
        }
        int set_Index = 0;
        mySocketConnectedCounter set_SocketConnectedCounter = (mySocketConnectedCounter) null;
        myIsBusyCounter set_IsBusyCounter = (myIsBusyCounter) null;
        md_HttpLoadProxy.WS_HttpLoadProxy = new SocketNET(set_Index, ref set_SocketConnectedCounter, ref set_IsBusyCounter);
        md_HttpLoadProxy.WS_HttpLoadProxy.DataArrival += new SocketNET.DataArrivalEventHandler(md_HttpLoadProxy.WS_HttpLoadProxy_DataArrival);
        md_HttpLoadProxy.WS_HttpLoadProxy.ErrorEvent += new SocketNET.ErrorEventEventHandler(md_HttpLoadProxy.WS_HttpLoadProxy_ErrorEvent);
        md_HttpLoadProxy.WS_HttpLoadProxy.DebugEvent += new SocketNET.DebugEventEventHandler(md_HttpLoadProxy.WS_HttpLoadProxy_DebugEvent);
        md_HttpLoadProxy.NextStep_HttpLoadProxy();
      }
    }

    private static void NextStep_HttpLoadProxy()
    {
      checked { ++md_HttpLoadProxy.HttpLoadProxy_Step; }
      if (md_HttpLoadProxy.HttpLoadProxy_Step > Information.UBound((Array) md_HttpLoadProxy.HttpLoadProxy.VALUE, 1))
      {
        string StrBuffer = md_HttpLoadProxy.SB_HttpLoadProxy.ToString().Replace("\r", "");
        md_HttpLoadProxy.SB_HttpLoadProxy = (StringBuilder) null;
        if (md_HttpLoadProxy.HttpLoadProxy.RegEx_Use)
        {
          MatchCollection matchCollection = new Regex(md_HttpLoadProxy.HttpLoadProxy.RegEx_Text).Matches(StrBuffer);
          int count = matchCollection.Count;
          string[] SourceArray = new string[checked (count - 1 + 1)];
          int num1 = 0;
          int num2 = checked (count - 1);
          int index = num1;
          while (index <= num2)
          {
            SourceArray[index] = matchCollection[index].Value;
            checked { ++index; }
          }
          StrBuffer = "\n" + Strings.Join(SourceArray, "\n");
        }
        string str;
        if (md_HttpLoadProxy.HttpLoadProxy.Append)
        {
          str = Application.StartupPath + "\\data\\proxy.txt";
          _LOADSAVE.FileAppend(ref str, ref StrBuffer);
        }
        else
        {
          str = Application.StartupPath + "\\data\\proxy.txt";
          _LOADSAVE.FileSave(ref str, ref StrBuffer);
        }
        StrBuffer = (string) null;
        _LOADSAVE.LoadProxy();
        MyProject.Forms.frmOptions.lblHttpLoadProxy_Count.Text = Conversions.ToString(Information.UBound((Array) _VARIABLES.Proxy, 1));
        if (!md_HttpLoadProxy.HttpLoadProxy.LoadRequired)
          return;
        md_HttpLoadProxy.HttpLoadProxy.LoadRequired = false;
        if (md_HttpLoadProxy.HttpLoadProxy.AfterLoadStartOne)
        {
          _FUNCTION.AccountSelect(1);
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          str = "Согласно настройкам, выбираю первый аккаунт.";
          fn.TXT(ref str);
        }
        if (md_HttpLoadProxy.HttpLoadProxy.Append)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          str = "Согласно настройкам, продолжаю проверку proxy с " + Conversions.ToString(checked (mdConnect.ProxCNT + 1));
          fn.TXT(ref str);
        }
        else
        {
          mdConnect.ProxCNT = 0;
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          str = "Согласно настройкам, начинаю проверку proxy с первой.";
          fn.TXT(ref str);
        }
        MyProject.Forms.frmMain.btmStart_Click((object) null, (EventArgs) null);
      }
      else
      {
        SocketNET wsHttpLoadProxy = md_HttpLoadProxy.WS_HttpLoadProxy;
        string set_URL = _FUNCTION.UrlEncode(ref md_HttpLoadProxy.HttpLoadProxy.VALUE[md_HttpLoadProxy.HttpLoadProxy_Step].URL);
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
        wsHttpLoadProxy.Connect(ref set_URL, ref set_Cookies, ref set_Referer, ref set_PostData, (myProxy) local, ref set_UseBrowser, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
      }
    }

    private static void WS_HttpLoadProxy_DataArrival(int Index)
    {
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Загрузка proxy URL #" + Conversions.ToString(md_HttpLoadProxy.HttpLoadProxy_Step) + " - OK";
      fn.TXT(ref sText);
      md_HttpLoadProxy.SB_HttpLoadProxy.Append("\r\nProtocol=" + md_HttpLoadProxy.HttpLoadProxy.VALUE[md_HttpLoadProxy.HttpLoadProxy_Step].Protocol + "\r\n" + md_HttpLoadProxy.WS_HttpLoadProxy.PacketBODY);
      md_HttpLoadProxy.NextStep_HttpLoadProxy();
    }

    private static void WS_HttpLoadProxy_ErrorEvent(int Index, ref string Description)
    {
      _FUNCTION.clsTXT fn = _FUNCTION.FN;
      string sText = "Ошибка загрузки Proxy-List по URL:" + Conversions.ToString(md_HttpLoadProxy.HttpLoadProxy_Step);
      fn.TXT(ref sText);
      md_HttpLoadProxy.NextStep_HttpLoadProxy();
    }

    private static void WS_HttpLoadProxy_DebugEvent(int Index, ref object Value)
    {
    }

    public struct myHttpLoadProxy
    {
      public bool Use;
      public bool LoadRequired;
      public bool RegEx_Use;
      public string RegEx_Text;
      public bool Append;
      public bool LoadInStart;
      public bool AfterLoadStartOne;
      public md_HttpLoadProxy.myValue_HttpLoadProxy[] VALUE;
    }

    public struct myValue_HttpLoadProxy
    {
      public string URL;
      public string Protocol;
    }
  }
}
