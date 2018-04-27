// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.AntiCaptchaNET
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;

namespace MailRegUnicore
{
  public class AntiCaptchaNET : IDisposable
  {
    public bool[] IsBusy;
    private mySocketConnectedCounter IsConnected_AC;
    private myProxy loc_Proxy_AC;
    private System.Timers.Timer tmrBL;
    public AntiCaptchaNET.myCapCounter CapCounter;
    private AntiCaptchaNET.myOptionsAntigate OptionsAntigate;
    private bool loc_Cancel;
    private int loc_Thread;
    private AntiCaptchaNET.myCommonSets CommonSets;
    private const string Divider = "---------7UniCore1TRF2uNcT5";
    private string SamplePacket;
    private SocketNET[] WS_AntiCaptcha;
    private SocketNET WS_ACbalance;
    private AntiCaptchaNET.ConnectTo_Enum[] ConnectTo;
    public bool[] NO_SLOT_AVAILABLE_Socket;
    private long[] CaptchaID;
    public Stopwatch globalSW;
    private long[] TL_ForThread;
    private System.Timers.Timer[] tmrReconnect;
    private object SyncLockOBJ;
    private bool disposedValue;

    public event AntiCaptchaNET.ErrorEvent_SocketEventHandler ErrorEvent_Socket;

    public event AntiCaptchaNET.ErrorEvent_AСEventHandler ErrorEvent_AС;

    public event AntiCaptchaNET.ErrorEvent_CAPCHA_NOT_READYEventHandler ErrorEvent_CAPCHA_NOT_READY;

    public event AntiCaptchaNET.ErrorEvent_ERROR_NO_SLOT_AVAILABLEEventHandler ErrorEvent_ERROR_NO_SLOT_AVAILABLE;

    public event AntiCaptchaNET.ErrorEvent_BalanceEventHandler ErrorEvent_Balance;

    public event AntiCaptchaNET.CaptchaSolvedEventHandler CaptchaSolved;

    public event AntiCaptchaNET.BadReportOKEventHandler BadReportOK;

    public event AntiCaptchaNET.InfoReportEventHandler InfoReport;

    public int ThreadWork
    {
      get
      {
        return this.loc_Thread;
      }
    }

    public AntiCaptchaNET(ref object set_GlobalOBJ, int set_Thread, string Key, int PauseError = 30000, int PauseNoSlot = 25000, int PauseGetBalance = 0, int PauseAfterSending = 10000, int NextGetCaptcha = 5000, int TimeLimit = 90000, int SocketTimeOut = 20000, string HostOrIP = "antigate.com", int SoftID = 281, AntiCaptchaNET.ContentType set_ContentType = AntiCaptchaNET.ContentType.jpg, string Set_Proxy = null)
    {
      if (string.IsNullOrEmpty(HostOrIP))
        HostOrIP = "antigate.com";
      this.loc_Thread = set_Thread;
      this.loc_Cancel = false;
      this.IsBusy = new bool[checked (set_Thread + 1)];
      this.SyncLockOBJ = RuntimeHelpers.GetObjectValue(new object());
      if (!Information.IsNothing((object) Set_Proxy))
      {
        this.loc_Proxy_AC = new myProxy();
        Set_Proxy = Set_Proxy.Replace(" ", string.Empty);
        Set_Proxy = Set_Proxy.Replace("\t", string.Empty);
        Set_Proxy = Set_Proxy.Replace(";", ":");
        string[] strArray = Set_Proxy.Split(':');
        switch (((IEnumerable<string>) strArray).Count<string>())
        {
          case 2:
            this.loc_Proxy_AC.IP = strArray[0];
            this.loc_Proxy_AC.Port = Conversions.ToInteger(strArray[1]);
            this.loc_Proxy_AC.Login = string.Empty;
            this.loc_Proxy_AC.Password = string.Empty;
            this.loc_Proxy_AC.Protocol = ProtocolProxy.HTTP;
            break;
          case 4:
            this.loc_Proxy_AC.IP = strArray[0];
            this.loc_Proxy_AC.Port = Conversions.ToInteger(strArray[1]);
            this.loc_Proxy_AC.Login = strArray[2];
            this.loc_Proxy_AC.Password = strArray[3];
            this.loc_Proxy_AC.Protocol = ProtocolProxy.HTTP;
            break;
          case 5:
            this.loc_Proxy_AC.IP = strArray[0];
            this.loc_Proxy_AC.Port = Conversions.ToInteger(strArray[1]);
            this.loc_Proxy_AC.Login = strArray[2];
            this.loc_Proxy_AC.Password = strArray[3];
            string lower = strArray[4].ToLower();
            ProtocolProxy protocolProxy;
            if (Operators.CompareString(lower, "http", false) == 0)
              protocolProxy = ProtocolProxy.HTTP;
            else if (Operators.CompareString(lower, "https", false) == 0)
              protocolProxy = ProtocolProxy.HTTPs;
            else if (Operators.CompareString(lower, "socks4", false) == 0)
              protocolProxy = ProtocolProxy.SOCKS4;
            else if (Operators.CompareString(lower, "socks4a", false) == 0)
              protocolProxy = ProtocolProxy.SOCKS4a;
            else if (Operators.CompareString(lower, "socks5", false) == 0)
            {
              protocolProxy = ProtocolProxy.SOCKS5;
            }
            else
            {
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = "Unknown protocol Proxy: " + strArray[4];
              fn.TXT(ref sText);
              protocolProxy = ProtocolProxy.HTTP;
            }
            this.loc_Proxy_AC.Protocol = protocolProxy;
            break;
          default:
            this.loc_Proxy_AC = (myProxy) null;
            break;
        }
      }
      else
        this.loc_Proxy_AC = (myProxy) null;
      this.CommonSets.KEY = Key;
      this.CommonSets.PauseError = PauseError;
      this.CommonSets.PauseNoSlot = PauseNoSlot;
      this.CommonSets.PauseGetBalance = PauseGetBalance;
      this.CommonSets.TimeLimit = TimeLimit;
      this.CommonSets.HostOrIP = "http://" + new UriBuilder(HostOrIP).Host + "/";
      this.CommonSets.SoftID = SoftID;
      this.CommonSets.PauseAfterSending = PauseAfterSending;
      this.CommonSets.NextGetCaptcha = NextGetCaptcha;
      this.CommonSets.SocketTimeOut = SocketTimeOut;
      switch (set_ContentType)
      {
        case AntiCaptchaNET.ContentType.jpg:
          this.CommonSets.ImageFileName = "captcha.jpg";
          this.CommonSets.ContentType = "image/pjpeg";
          break;
        case AntiCaptchaNET.ContentType.gif:
          this.CommonSets.ImageFileName = "captcha.gif";
          this.CommonSets.ContentType = "image/gif";
          break;
        case AntiCaptchaNET.ContentType.png:
          this.CommonSets.ImageFileName = "captcha.png";
          this.CommonSets.ContentType = "image/png";
          break;
      }
      if (!Information.IsNothing((object) this.WS_AntiCaptcha))
      {
        int num1 = 1;
        int num2 = Information.UBound((Array) this.WS_AntiCaptcha, 1);
        int index = num1;
        while (index <= num2)
        {
          this.WS_AntiCaptcha[index].DataArrival -= new SocketNET.DataArrivalEventHandler(this.AC_DataArrival);
          this.WS_AntiCaptcha[index].ErrorEvent -= new SocketNET.ErrorEventEventHandler(this.AC_ErrorEvent);
          this.WS_AntiCaptcha[index] = (SocketNET) null;
          checked { ++index; }
        }
        this.WS_AntiCaptcha = (SocketNET[]) null;
      }
      this.IsConnected_AC = new mySocketConnectedCounter()
      {
        Counter = 0
      };
      this.WS_AntiCaptcha = new SocketNET[checked (this.loc_Thread + 1)];
      int num3 = 1;
      int locThread1 = this.loc_Thread;
      int index1 = num3;
      while (index1 <= locThread1)
      {
        SocketNET[] wsAntiCaptcha = this.WS_AntiCaptcha;
        int index2 = index1;
        int set_Index = index1;
        myIsBusyCounter set_IsBusyCounter = (myIsBusyCounter) null;
        SocketNET socketNet = new SocketNET(set_Index, ref this.IsConnected_AC, ref set_IsBusyCounter);
        wsAntiCaptcha[index2] = socketNet;
        this.WS_AntiCaptcha[index1].DataArrival += new SocketNET.DataArrivalEventHandler(this.AC_DataArrival);
        this.WS_AntiCaptcha[index1].ErrorEvent += new SocketNET.ErrorEventEventHandler(this.AC_ErrorEvent);
        this.WS_AntiCaptcha[index1].Options.TimeOut = this.CommonSets.SocketTimeOut;
        this.WS_AntiCaptcha[index1].Options.Accept = (string) null;
        this.WS_AntiCaptcha[index1].Options.Accept_Charset = (string) null;
        this.WS_AntiCaptcha[index1].Options.Accept_Language = (string) null;
        this.WS_AntiCaptcha[index1].Options.Accept_Encoding = (string) null;
        this.WS_AntiCaptcha[index1].Options.Keep_Alive = false;
        this.WS_AntiCaptcha[index1].Options.TimeOut = SocketTimeOut;
        this.WS_AntiCaptcha[index1].CloseSocketAtFree = true;
        checked { ++index1; }
      }
      if (!Information.IsNothing((object) this.WS_ACbalance))
      {
        this.WS_ACbalance.DataArrival -= new SocketNET.DataArrivalEventHandler(this.AC_DataArrival_balance);
        this.WS_ACbalance.ErrorEvent -= new SocketNET.ErrorEventEventHandler(this.AC_ErrorEvent_balance);
        this.WS_ACbalance = (SocketNET) null;
      }
      int set_Index1 = 1;
      myIsBusyCounter set_IsBusyCounter1 = (myIsBusyCounter) null;
      this.WS_ACbalance = new SocketNET(set_Index1, ref this.IsConnected_AC, ref set_IsBusyCounter1);
      this.WS_ACbalance.DataArrival += new SocketNET.DataArrivalEventHandler(this.AC_DataArrival_balance);
      this.WS_ACbalance.ErrorEvent += new SocketNET.ErrorEventEventHandler(this.AC_ErrorEvent_balance);
      this.WS_ACbalance.Options.TimeOut = this.CommonSets.SocketTimeOut;
      this.WS_ACbalance.Options.Accept = (string) null;
      this.WS_ACbalance.Options.Accept_Charset = (string) null;
      this.WS_ACbalance.Options.Accept_Language = (string) null;
      this.WS_ACbalance.Options.Accept_Encoding = (string) null;
      this.WS_ACbalance.Options.Keep_Alive = false;
      this.CapCounter = new AntiCaptchaNET.myCapCounter();
      this.CapCounter.Init();
      string InfoData;
      if (PauseGetBalance > 0)
      {
        if (PauseGetBalance < 10000)
        {
          AntiCaptchaNET.InfoReportEventHandler infoReportEvent = this.InfoReportEvent;
          if (infoReportEvent != null)
          {
            AntiCaptchaNET.InfoReportEventHandler reportEventHandler = infoReportEvent;
            AntiCaptchaNET.ConnectTo_Enum InfoConnectTo = AntiCaptchaNET.ConnectTo_Enum.InternalError;
            InfoData = "Пауза GetBalance < 10с! Увеличина до 10с.";
            reportEventHandler(ref InfoConnectTo, ref InfoData);
          }
          PauseGetBalance = 10000;
        }
        this.tmrBL = new System.Timers.Timer();
        this.tmrBL.AutoReset = true;
        this.tmrBL.Elapsed += new ElapsedEventHandler(this.Tick_tmrBL);
        this.tmrBL.Interval = 1000.0;
        this.tmrBL.Start();
      }
      this.ConnectTo = new AntiCaptchaNET.ConnectTo_Enum[checked (this.loc_Thread + 1)];
      this.NO_SLOT_AVAILABLE_Socket = new bool[checked (this.loc_Thread + 1)];
      this.CaptchaID = new long[checked (this.loc_Thread + 1)];
      this.tmrReconnect = new System.Timers.Timer[checked (this.loc_Thread + 1)];
      if (this.CommonSets.TimeLimit > 0)
      {
        if (this.CommonSets.TimeLimit < 10000)
        {
          AntiCaptchaNET.InfoReportEventHandler infoReportEvent = this.InfoReportEvent;
          if (infoReportEvent != null)
          {
            AntiCaptchaNET.InfoReportEventHandler reportEventHandler = infoReportEvent;
            AntiCaptchaNET.ConnectTo_Enum InfoConnectTo = AntiCaptchaNET.ConnectTo_Enum.InternalError;
            InfoData = "TimeLimit < 10с! Увеличин до 10с.";
            reportEventHandler(ref InfoConnectTo, ref InfoData);
          }
          this.CommonSets.TimeLimit = 10000;
        }
        this.TL_ForThread = new long[checked (this.loc_Thread + 1)];
      }
      this.globalSW = new Stopwatch();
      this.globalSW.Start();
      int num4 = 0;
      int locThread2 = this.loc_Thread;
      int index3 = num4;
      while (index3 <= locThread2)
      {
        this.tmrReconnect[index3] = new System.Timers.Timer();
        this.tmrReconnect[index3].AutoReset = false;
        this.tmrReconnect[index3].Elapsed += new ElapsedEventHandler(this.Tick_tmrReconnect);
        this.ConnectTo[index3] = AntiCaptchaNET.ConnectTo_Enum.NothingAction;
        this.NO_SLOT_AVAILABLE_Socket[index3] = false;
        checked { ++index3; }
      }
    }

    public void SetOptions(int phrase = 0, int regsense = 0, int numeric = 0, int calc = 0, int min_len = 0, int max_len = 0, int is_russian = 0)
    {
      this.OptionsAntigate.phrase = phrase;
      this.OptionsAntigate.regsense = regsense;
      this.OptionsAntigate.numeric = numeric;
      this.OptionsAntigate.calc = calc;
      this.OptionsAntigate.min_len = min_len;
      this.OptionsAntigate.max_len = max_len;
      this.OptionsAntigate.is_russian = is_russian;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("-----------7UniCore1TRF2uNcT5\r\nContent-Disposition: form-data; name=\"method\"\r\n\r\npost\r\n");
      if (this.CommonSets.SoftID > 0)
        stringBuilder.Append("-----------7UniCore1TRF2uNcT5\r\nContent-Disposition: form-data; name=\"soft_id\"\r\n\r\n" + Conversions.ToString(this.CommonSets.SoftID) + "\r\n");
      stringBuilder.Append("-----------7UniCore1TRF2uNcT5\r\nContent-Disposition: form-data; name=\"key\"\r\n\r\n" + this.CommonSets.KEY + "\r\n");
      if (phrase > 0)
        stringBuilder.Append("-----------7UniCore1TRF2uNcT5\r\nContent-Disposition: form-data; name=\"phrase\"\r\n\r\n" + Conversions.ToString(phrase) + "\r\n");
      if (regsense > 0)
        stringBuilder.Append("-----------7UniCore1TRF2uNcT5\r\nContent-Disposition: form-data; name=\"regsense\"\r\n\r\n" + Conversions.ToString(regsense) + "\r\n");
      if (numeric > 0)
        stringBuilder.Append("-----------7UniCore1TRF2uNcT5\r\nContent-Disposition: form-data; name=\"numeric\"\r\n\r\n" + Conversions.ToString(numeric) + "\r\n");
      if (calc > 0)
        stringBuilder.Append("-----------7UniCore1TRF2uNcT5\r\nContent-Disposition: form-data; name=\"calc\"\r\n\r\n" + Conversions.ToString(calc) + "\r\n");
      stringBuilder.Append("-----------7UniCore1TRF2uNcT5\r\nContent-Disposition: form-data; name=\"min_len\"\r\n\r\n" + Conversions.ToString(min_len) + "\r\n");
      stringBuilder.Append("-----------7UniCore1TRF2uNcT5\r\nContent-Disposition: form-data; name=\"max_len\"\r\n\r\n" + Conversions.ToString(max_len) + "\r\n");
      if (is_russian > 0)
        stringBuilder.Append("-----------7UniCore1TRF2uNcT5\r\nContent-Disposition: form-data; name=\"is_russian\"\r\n\r\n" + Conversions.ToString(is_russian) + "\r\n");
      stringBuilder.Append("-----------7UniCore1TRF2uNcT5\r\nContent-Disposition: form-data; name=\"file\"; filename=\"" + this.CommonSets.ImageFileName + "\"\r\n");
      stringBuilder.Append("Content-Type: " + this.CommonSets.ContentType + "\r\n\r\n");
      this.SamplePacket = stringBuilder.ToString();
    }

    public void StopSoft()
    {
      this.loc_Cancel = true;
    }

    public void StartSoft()
    {
      this.loc_Cancel = false;
    }

    private myProxy SetProxyFiddler()
    {
      return this.loc_Proxy_AC;
    }

    public void SendCaptcha(int Index, string CaptchaData)
    {
      if (CaptchaData == null || CaptchaData.Length == 0)
      {
        int Index1 = Index;
        string Description = "Captcha.Length = 0";
        this.send_ErrorEvent_AС(Index1, ref Description);
      }
      else if (this.IsBusy[Index])
      {
        int Index1 = Index;
        string Description = "Socket Busy!";
        this.send_ErrorEvent_AС(Index1, ref Description);
      }
      else
      {
        object syncLockObj = this.SyncLockOBJ;
        ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
        bool lockTaken = false;
        try
        {
          Monitor.Enter(syncLockObj, ref lockTaken);
          checked { ++this.CapCounter.IsBusy; }
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit(syncLockObj);
        }
        this.IsBusy[Index] = true;
        this.tmrReconnect[Index].Stop();
        this.ConnectTo[Index] = AntiCaptchaNET.ConnectTo_Enum.SendCaptcha;
        this.CaptchaID[Index] = 0L;
        string set_PostData = this.SamplePacket + CaptchaData + "\r\n-----------7UniCore1TRF2uNcT5--";
        SocketNET socketNet = this.WS_AntiCaptcha[Index];
        string set_URL = this.CommonSets.HostOrIP + "in.php";
        myCookies set_Cookies = (myCookies) null;
        string set_Referer = (string) null;
        myProxy set_Proxy = this.SetProxyFiddler();
        short set_UseBrowser = -1;
        string set_X_Forwarded_For = (string) null;
        string set_ContentType = "multipart/form-data; boundary=---------7UniCore1TRF2uNcT5";
        object set_Accept_Charset = (object) 1251;
        string set_Headers_Add = (string) null;
        socketNet.Connect(ref set_URL, ref set_Cookies, ref set_Referer, ref set_PostData, set_Proxy, ref set_UseBrowser, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
      }
    }

    public void BadCaptcha(int Index)
    {
      if (this.CaptchaID[Index] == 0L)
      {
        int Index1 = Index;
        string Description = "CaptchaID = 0";
        this.send_ErrorEvent_AС(Index1, ref Description);
      }
      else
      {
        object syncLockObj = this.SyncLockOBJ;
        ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
        bool lockTaken = false;
        try
        {
          Monitor.Enter(syncLockObj, ref lockTaken);
          checked { ++this.CapCounter.IsBusy; }
          checked { ++this.CapCounter.Cap_Wrong; }
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit(syncLockObj);
        }
        this.IsBusy[Index] = true;
        this.ConnectTo[Index] = AntiCaptchaNET.ConnectTo_Enum.BadCaptcha;
        SocketNET socketNet = this.WS_AntiCaptcha[Index];
        string set_URL = this.CommonSets.HostOrIP + "res.php?key=" + this.CommonSets.KEY + "&action=reportbad&id=" + Conversions.ToString(this.CaptchaID[Index]);
        myCookies set_Cookies = (myCookies) null;
        string set_Referer = (string) null;
        string set_PostData = (string) null;
        myProxy set_Proxy = this.SetProxyFiddler();
        short set_UseBrowser = -1;
        string set_X_Forwarded_For = (string) null;
        string set_ContentType = (string) null;
        object set_Accept_Charset = (object) 1251;
        string set_Headers_Add = (string) null;
        socketNet.Connect(ref set_URL, ref set_Cookies, ref set_Referer, ref set_PostData, set_Proxy, ref set_UseBrowser, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
      }
    }

    public void GetBalance()
    {
      SocketNET wsAcbalance = this.WS_ACbalance;
      string set_URL = this.CommonSets.HostOrIP + "res.php?key=" + this.CommonSets.KEY + "&action=getbalance";
      myCookies set_Cookies = (myCookies) null;
      string set_Referer = (string) null;
      string set_PostData = (string) null;
      myProxy set_Proxy = this.SetProxyFiddler();
      short set_UseBrowser = -1;
      string set_X_Forwarded_For = (string) null;
      string set_ContentType = (string) null;
      object set_Accept_Charset = (object) 1251;
      string set_Headers_Add = (string) null;
      wsAcbalance.Connect(ref set_URL, ref set_Cookies, ref set_Referer, ref set_PostData, set_Proxy, ref set_UseBrowser, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
    }

    private void GetCaptcha(int Index)
    {
      this.ConnectTo[Index] = AntiCaptchaNET.ConnectTo_Enum.GetCaptcha;
      SocketNET socketNet = this.WS_AntiCaptcha[Index];
      string set_URL = this.CommonSets.HostOrIP + "res.php?key=" + this.CommonSets.KEY + "&action=get&id=" + Conversions.ToString(this.CaptchaID[Index]);
      myCookies set_Cookies = (myCookies) null;
      string set_Referer = (string) null;
      string set_PostData = (string) null;
      myProxy set_Proxy = this.SetProxyFiddler();
      short set_UseBrowser = -1;
      string set_X_Forwarded_For = (string) null;
      string set_ContentType = (string) null;
      object set_Accept_Charset = (object) 1251;
      string set_Headers_Add = (string) null;
      socketNet.Connect(ref set_URL, ref set_Cookies, ref set_Referer, ref set_PostData, set_Proxy, ref set_UseBrowser, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
    }

    public int GetConnectTo(int Index)
    {
      return (int) this.ConnectTo[Index];
    }

    public int GetThread()
    {
      return this.loc_Thread;
    }

    private void Tick_tmrReconnect(object sender, ElapsedEventArgs e)
    {
      int Index = Array.IndexOf((Array) this.tmrReconnect, RuntimeHelpers.GetObjectValue(sender));
      if (this.ConnectTo[Index] == AntiCaptchaNET.ConnectTo_Enum.GetCaptcha)
      {
        this.GetCaptcha(Index);
      }
      else
      {
        SocketNET socketNet = this.WS_AntiCaptcha[Index];
        string set_URL = (string) null;
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
        socketNet.Connect(ref set_URL, ref set_Cookies, ref set_Referer, ref set_PostData, (myProxy) local, ref set_UseBrowser, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
      }
    }

    private void Tick_tmrBL(object sender, ElapsedEventArgs e)
    {
      this.tmrBL.Interval = (double) this.CommonSets.PauseGetBalance;
      this.GetBalance();
    }

    private void AC_DataArrival(int Index)
    {
      try
      {
        if (this.NO_SLOT_AVAILABLE_Socket[Index])
        {
          this.NO_SLOT_AVAILABLE_Socket[Index] = false;
          object syncLockObj = this.SyncLockOBJ;
          ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
          bool lockTaken = false;
          try
          {
            Monitor.Enter(syncLockObj, ref lockTaken);
            checked { --this.CapCounter.NO_SLOT_AVAILABLE; }
          }
          finally
          {
            if (lockTaken)
              Monitor.Exit(syncLockObj);
          }
        }
        string packetBody = this.WS_AntiCaptcha[Index].PacketBODY;
        switch (this.ConnectTo[Index])
        {
          case AntiCaptchaNET.ConnectTo_Enum.SendCaptcha:
            if (Operators.CompareString(packetBody.Substring(0, 2), "OK", false) == 0)
            {
              if (this.CommonSets.TimeLimit > 0)
                this.TL_ForThread[Index] = this.globalSW.ElapsedMilliseconds;
              object syncLockObj = this.SyncLockOBJ;
              ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
              bool lockTaken = false;
              try
              {
                Monitor.Enter(syncLockObj, ref lockTaken);
                checked { ++this.CapCounter.Cap_Loaded; }
              }
              finally
              {
                if (lockTaken)
                  Monitor.Exit(syncLockObj);
              }
              this.CaptchaID[Index] = Conversions.ToLong(packetBody.Substring(3, checked (packetBody.Length - 3)));
              this.ConnectTo[Index] = AntiCaptchaNET.ConnectTo_Enum.GetCaptcha;
              this.tmrReconnect[Index].Interval = (double) this.CommonSets.PauseAfterSending;
              this.tmrReconnect[Index].Start();
              break;
            }
            if (Operators.CompareString(packetBody, "ERROR_NO_SLOT_AVAILABLE", false) == 0)
            {
              this.send_ErrorEvent_ERROR_NO_SLOT_AVAILABLE(Index);
              break;
            }
            this.send_ErrorEvent_AС(Index, ref packetBody);
            break;
          case AntiCaptchaNET.ConnectTo_Enum.GetCaptcha:
            if (Operators.CompareString(packetBody.Substring(0, 2), "OK", false) == 0)
            {
              int Index1 = Index;
              string CaptchaText = packetBody.Substring(3, checked (packetBody.Length - 3));
              this.send_CaptchaSolved(Index1, ref CaptchaText);
              break;
            }
            if (Operators.CompareString(packetBody, "CAPCHA_NOT_READY", false) == 0)
            {
              this.send_ErrorEvent_CAPCHA_NOT_READY(Index);
              break;
            }
            this.send_ErrorEvent_AС(Index, ref packetBody);
            break;
          case AntiCaptchaNET.ConnectTo_Enum.BadCaptcha:
            this.send_BadReportOK(Index);
            break;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        int Index1 = Index;
        string message = exception.Message;
        this.send_ErrorEvent_AС(Index1, ref message);
        ProjectData.ClearProjectError();
      }
    }

    private void AC_ErrorEvent(int Index, ref string Description)
    {
      if (this.ConnectTo[Index] == AntiCaptchaNET.ConnectTo_Enum.GetCaptcha)
      {
        object syncLockObj = this.SyncLockOBJ;
        ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
        bool lockTaken = false;
        try
        {
          Monitor.Enter(syncLockObj, ref lockTaken);
          checked { ++this.CapCounter.Cap_ERROR_; }
          checked { --this.CapCounter.IsBusy; }
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit(syncLockObj);
        }
      }
      else
      {
        object syncLockObj = this.SyncLockOBJ;
        ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
        bool lockTaken = false;
        try
        {
          Monitor.Enter(syncLockObj, ref lockTaken);
          checked { --this.CapCounter.IsBusy; }
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit(syncLockObj);
        }
      }
      this.IsBusy[Index] = false;
      this.ConnectTo[Index] = AntiCaptchaNET.ConnectTo_Enum.AfterSendError_Socket;
      AntiCaptchaNET.ErrorEvent_SocketEventHandler eventSocketEvent = this.ErrorEvent_SocketEvent;
      if (eventSocketEvent == null)
        return;
      eventSocketEvent(Index, ref Description, true);
    }

    private void send_ErrorEvent_AС(int Index, ref string Description)
    {
      this.ConnectTo[Index] = AntiCaptchaNET.ConnectTo_Enum.AfterSendError_AC;
      object syncLockObj = this.SyncLockOBJ;
      ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
      bool lockTaken = false;
      try
      {
        Monitor.Enter(syncLockObj, ref lockTaken);
        checked { ++this.CapCounter.Cap_ERROR_; }
        checked { --this.CapCounter.IsBusy; }
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit(syncLockObj);
      }
      this.IsBusy[Index] = false;
      AntiCaptchaNET.ErrorEvent_AСEventHandler errorEventAсEvent = this.ErrorEvent_AСEvent;
      if (errorEventAсEvent == null)
        return;
      errorEventAсEvent(Index, ref Description);
    }

    private void send_ErrorEvent_CAPCHA_NOT_READY(int Index)
    {
      if (this.CommonSets.TimeLimit > 0 && checked (this.globalSW.ElapsedMilliseconds - this.TL_ForThread[Index]) > (long) this.CommonSets.TimeLimit)
      {
        object syncLockObj = this.SyncLockOBJ;
        ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
        bool lockTaken = false;
        try
        {
          Monitor.Enter(syncLockObj, ref lockTaken);
          checked { ++this.CapCounter.Cap_TimeLimit; }
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit(syncLockObj);
        }
        int Index1 = Index;
        string Description = "ERROR_TIME_LIMIT";
        this.send_ErrorEvent_AС(Index1, ref Description);
      }
      else
      {
        this.tmrReconnect[Index].Interval = (double) this.CommonSets.NextGetCaptcha;
        this.tmrReconnect[Index].Start();
        AntiCaptchaNET.ErrorEvent_CAPCHA_NOT_READYEventHandler capchaNotReadyEvent = this.ErrorEvent_CAPCHA_NOT_READYEvent;
        if (capchaNotReadyEvent == null)
          return;
        capchaNotReadyEvent(Index);
      }
    }

    private void send_ErrorEvent_ERROR_NO_SLOT_AVAILABLE(int Index)
    {
      if (!this.loc_Cancel)
      {
        if (this.CommonSets.PauseNoSlot > 0)
        {
          this.NO_SLOT_AVAILABLE_Socket[Index] = true;
          object syncLockObj = this.SyncLockOBJ;
          ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
          bool lockTaken = false;
          try
          {
            Monitor.Enter(syncLockObj, ref lockTaken);
            checked { ++this.CapCounter.NO_SLOT_AVAILABLE; }
          }
          finally
          {
            if (lockTaken)
              Monitor.Exit(syncLockObj);
          }
          this.ConnectTo[Index] = AntiCaptchaNET.ConnectTo_Enum.SendCaptcha;
          this.tmrReconnect[Index].Interval = (double) this.CommonSets.PauseNoSlot;
          this.tmrReconnect[Index].Start();
          AntiCaptchaNET.ErrorEvent_ERROR_NO_SLOT_AVAILABLEEventHandler slotAvailableEvent = this.ErrorEvent_ERROR_NO_SLOT_AVAILABLEEvent;
          if (slotAvailableEvent == null)
            return;
          slotAvailableEvent(Index, false);
        }
        else
        {
          this.ConnectTo[Index] = AntiCaptchaNET.ConnectTo_Enum.AfterSendError_ERROR_NO_SLOT_AVAILABLE;
          object syncLockObj = this.SyncLockOBJ;
          ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
          bool lockTaken = false;
          try
          {
            Monitor.Enter(syncLockObj, ref lockTaken);
            checked { --this.CapCounter.IsBusy; }
          }
          finally
          {
            if (lockTaken)
              Monitor.Exit(syncLockObj);
          }
          this.IsBusy[Index] = false;
          AntiCaptchaNET.ErrorEvent_ERROR_NO_SLOT_AVAILABLEEventHandler slotAvailableEvent = this.ErrorEvent_ERROR_NO_SLOT_AVAILABLEEvent;
          if (slotAvailableEvent == null)
            return;
          slotAvailableEvent(Index, true);
        }
      }
      else
      {
        this.ConnectTo[Index] = AntiCaptchaNET.ConnectTo_Enum.AfterSendError_ERROR_NO_SLOT_AVAILABLE;
        object syncLockObj = this.SyncLockOBJ;
        ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
        bool lockTaken = false;
        try
        {
          Monitor.Enter(syncLockObj, ref lockTaken);
          checked { --this.CapCounter.IsBusy; }
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit(syncLockObj);
        }
        this.IsBusy[Index] = false;
        AntiCaptchaNET.ErrorEvent_ERROR_NO_SLOT_AVAILABLEEventHandler slotAvailableEvent = this.ErrorEvent_ERROR_NO_SLOT_AVAILABLEEvent;
        if (slotAvailableEvent == null)
          return;
        slotAvailableEvent(Index, true);
      }
    }

    private void send_CaptchaSolved(int Index, ref string CaptchaText)
    {
      this.ConnectTo[Index] = AntiCaptchaNET.ConnectTo_Enum.AfterSend_CaptchaSolved;
      object syncLockObj = this.SyncLockOBJ;
      ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
      bool lockTaken = false;
      try
      {
        Monitor.Enter(syncLockObj, ref lockTaken);
        checked { ++this.CapCounter.Cap_Solved; }
        checked { --this.CapCounter.IsBusy; }
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit(syncLockObj);
      }
      this.IsBusy[Index] = false;
      AntiCaptchaNET.CaptchaSolvedEventHandler captchaSolvedEvent = this.CaptchaSolvedEvent;
      if (captchaSolvedEvent == null)
        return;
      captchaSolvedEvent(Index, ref CaptchaText);
    }

    private void send_BadReportOK(int Index)
    {
      this.ConnectTo[Index] = AntiCaptchaNET.ConnectTo_Enum.AfterSend_BadCaptcha;
      object syncLockObj = this.SyncLockOBJ;
      ObjectFlowControl.CheckForSyncLockOnValueType(syncLockObj);
      bool lockTaken = false;
      try
      {
        Monitor.Enter(syncLockObj, ref lockTaken);
        checked { --this.CapCounter.IsBusy; }
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit(syncLockObj);
      }
      this.IsBusy[Index] = false;
      AntiCaptchaNET.BadReportOKEventHandler badReportOkEvent = this.BadReportOKEvent;
      if (badReportOkEvent == null)
        return;
      badReportOkEvent(Index);
    }

    protected virtual void Dispose(bool disposing)
    {
      try
      {
        if (this.globalSW != null)
        {
          this.globalSW.Stop();
          this.globalSW = (Stopwatch) null;
        }
        if (!Information.IsNothing((object) this.WS_AntiCaptcha[1]))
        {
          int num1 = 1;
          int num2 = Information.UBound((Array) this.WS_AntiCaptcha, 1);
          int index = num1;
          while (index <= num2)
          {
            this.WS_AntiCaptcha[index].DataArrival -= new SocketNET.DataArrivalEventHandler(this.AC_DataArrival);
            this.WS_AntiCaptcha[index].ErrorEvent -= new SocketNET.ErrorEventEventHandler(this.AC_ErrorEvent);
            this.WS_AntiCaptcha[index] = (SocketNET) null;
            checked { ++index; }
          }
        }
        int num3 = 0;
        int locThread = this.loc_Thread;
        int index1 = num3;
        while (index1 <= locThread)
        {
          this.tmrReconnect[index1].Stop();
          this.tmrReconnect[index1].Elapsed -= new ElapsedEventHandler(this.Tick_tmrReconnect);
          this.tmrReconnect[index1] = (System.Timers.Timer) null;
          this.ConnectTo[index1] = AntiCaptchaNET.ConnectTo_Enum.NothingAction;
          this.CaptchaID[index1] = 0L;
          checked { ++index1; }
        }
        this.tmrReconnect = (System.Timers.Timer[]) null;
        this.ConnectTo = (AntiCaptchaNET.ConnectTo_Enum[]) null;
        this.CaptchaID = (long[]) null;
        this.SamplePacket = (string) null;
        this.CapCounter = new AntiCaptchaNET.myCapCounter();
        this.OptionsAntigate = new AntiCaptchaNET.myOptionsAntigate();
        this.loc_Cancel = false;
        this.loc_Thread = 0;
        this.CommonSets = new AntiCaptchaNET.myCommonSets();
        if (this.tmrBL != null)
        {
          this.tmrBL.Stop();
          this.tmrBL.Elapsed -= new ElapsedEventHandler(this.Tick_tmrBL);
          this.tmrBL.Dispose();
          this.tmrBL = (System.Timers.Timer) null;
        }
        if (!this.disposedValue)
        {
          int num4 = disposing ? 1 : 0;
        }
        this.disposedValue = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        AntiCaptchaNET.InfoReportEventHandler infoReportEvent = this.InfoReportEvent;
        if (infoReportEvent != null)
        {
          AntiCaptchaNET.InfoReportEventHandler reportEventHandler = infoReportEvent;
          AntiCaptchaNET.ConnectTo_Enum InfoConnectTo = AntiCaptchaNET.ConnectTo_Enum.InternalError;
          string InfoData = "Dispose: " + exception.Message;
          reportEventHandler(ref InfoConnectTo, ref InfoData);
        }
        ProjectData.ClearProjectError();
      }
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    private void AC_DataArrival_balance(int Index)
    {
      string Description1 = this.WS_ACbalance.PacketBODY;
      try
      {
        if (Information.IsNothing((object) Description1) || Description1.Length == 0)
        {
          AntiCaptchaNET.ErrorEvent_BalanceEventHandler eventBalanceEvent = this.ErrorEvent_BalanceEvent;
          if (eventBalanceEvent == null)
            return;
          AntiCaptchaNET.ErrorEvent_BalanceEventHandler balanceEventHandler = eventBalanceEvent;
          string Description2 = "ERROR_BL_LEN_0";
          balanceEventHandler(ref Description2);
        }
        else if (Operators.CompareString(Strings.Left(Description1, 6), "ERROR_", false) == 0)
        {
          AntiCaptchaNET.ErrorEvent_BalanceEventHandler eventBalanceEvent = this.ErrorEvent_BalanceEvent;
          if (eventBalanceEvent == null)
            return;
          eventBalanceEvent(ref Description1);
        }
        else
        {
          double num;
          try
          {
            Description1 = Description1.Replace(".", ",");
            num = double.Parse(Description1);
          }
          catch (FormatException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            AntiCaptchaNET.ErrorEvent_BalanceEventHandler eventBalanceEvent = this.ErrorEvent_BalanceEvent;
            if (eventBalanceEvent != null)
            {
              AntiCaptchaNET.ErrorEvent_BalanceEventHandler balanceEventHandler = eventBalanceEvent;
              string Description2 = "AutoCaptcha bad response GetBalance.";
              balanceEventHandler(ref Description2);
            }
            ProjectData.ClearProjectError();
            return;
          }
          if (this.CapCounter.Cap_BL_Start == 0.0)
          {
            this.CapCounter.Cap_BL_Start = num;
            this.CapCounter.Cap_BL_Current = num;
          }
          else
          {
            this.CapCounter.Cap_BL_Current = num;
            this.CapCounter.Cap_BL_Expense = Math.Round(this.CapCounter.Cap_BL_Start - this.CapCounter.Cap_BL_Current, 4);
          }
          if (this.CommonSets.PauseGetBalance > 0)
            return;
          AntiCaptchaNET.InfoReportEventHandler infoReportEvent = this.InfoReportEvent;
          if (infoReportEvent == null)
            return;
          AntiCaptchaNET.InfoReportEventHandler reportEventHandler = infoReportEvent;
          AntiCaptchaNET.ConnectTo_Enum InfoConnectTo = AntiCaptchaNET.ConnectTo_Enum.GetBalance;
          string InfoData = Conversions.ToString(num);
          reportEventHandler(ref InfoConnectTo, ref InfoData);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        AntiCaptchaNET.ErrorEvent_BalanceEventHandler eventBalanceEvent = this.ErrorEvent_BalanceEvent;
        if (eventBalanceEvent != null)
        {
          AntiCaptchaNET.ErrorEvent_BalanceEventHandler balanceEventHandler = eventBalanceEvent;
          string Description2 = "ErrBL: " + Description1 + "\r\n" + exception.Message;
          balanceEventHandler(ref Description2);
        }
        ProjectData.ClearProjectError();
      }
    }

    private void AC_ErrorEvent_balance(int Index, ref string Description)
    {
      AntiCaptchaNET.ErrorEvent_BalanceEventHandler eventBalanceEvent = this.ErrorEvent_BalanceEvent;
      if (eventBalanceEvent == null)
        return;
      eventBalanceEvent(ref Description);
    }

    public delegate void ErrorEvent_SocketEventHandler(int Index, ref string Description, bool ThreadStop);

    public delegate void ErrorEvent_AСEventHandler(int Index, ref string Description);

    public delegate void ErrorEvent_CAPCHA_NOT_READYEventHandler(int Index);

    public delegate void ErrorEvent_ERROR_NO_SLOT_AVAILABLEEventHandler(int Index, bool ThreadStop);

    public delegate void ErrorEvent_BalanceEventHandler(ref string Description);

    public delegate void CaptchaSolvedEventHandler(int Index, ref string CaptchaText);

    public delegate void BadReportOKEventHandler(int Index);

    public delegate void InfoReportEventHandler(ref AntiCaptchaNET.ConnectTo_Enum InfoConnectTo, ref string InfoData);

    public enum ErrorType
    {
      ServiceEx,
      ConnectEx,
      ModuleEx,
    }

    public enum ConnectTo_Enum
    {
      NothingAction = 0,
      SendCaptcha = 1,
      GetCaptcha = 2,
      BadCaptcha = 3,
      GetBalance = 4,
      AfterSend_BadCaptcha = 5,
      AfterSend_CaptchaSolved = 10, // 0x0000000A
      AfterSendError_Socket = 20, // 0x00000014
      AfterSendError_AC = 21, // 0x00000015
      AfterSendError_CAPCHA_NOT_READY = 22, // 0x00000016
      AfterSendError_ERROR_NO_SLOT_AVAILABLE = 23, // 0x00000017
      InternalError = 30, // 0x0000001E
    }

    public struct myCapCounter
    {
      public int Cap_Loaded;
      public int Cap_Solved;
      public int Cap_OK;
      public int Cap_Wrong;
      public int Cap_Lost;
      public int Cap_TimeLimit;
      public int Cap_ERROR_;
      public double Cap_BL_Start;
      public double Cap_BL_Current;
      public double Cap_BL_Expense;
      public int IsBusy;
      public int NO_SLOT_AVAILABLE;

      public void Init()
      {
        this.Cap_Loaded = 0;
        this.Cap_Solved = 0;
        this.Cap_OK = 0;
        this.Cap_Wrong = 0;
        this.Cap_Lost = 0;
        this.Cap_TimeLimit = 0;
        this.Cap_ERROR_ = 0;
        this.Cap_BL_Start = 0.0;
        this.Cap_BL_Current = 0.0;
        this.Cap_BL_Expense = 0.0;
        this.IsBusy = 0;
        this.NO_SLOT_AVAILABLE = 0;
      }
    }

    internal struct myOptionsAntigate
    {
      public int phrase;
      public int regsense;
      public int numeric;
      public int calc;
      public int min_len;
      public int max_len;
      public int is_russian;
    }

    private struct myCommonSets
    {
      public string KEY;
      public int PauseError;
      public int PauseNoSlot;
      public int PauseGetBalance;
      public int TimeLimit;
      public string HostOrIP;
      public int SoftID;
      public int PauseAfterSending;
      public int NextGetCaptcha;
      public int SocketTimeOut;
      public string ImageFileName;
      public string ContentType;
    }

    public enum ContentType
    {
      jpg,
      gif,
      png,
    }
  }
}
