// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.SocketNET
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Timers;

namespace MailRegUnicore
{
  public class SocketNET
  {
    public static bool NoUseFIP = false;
    public static string Const_EndPacketChunk = "\r\n0\r\n\r\n";
    public const string Version = "9.30";
    public static object GlobalOBJ;
    public static string[] UserAgent;
    public int Index;
    public int Mirror;
    public bool CloseSocketAtFree;
    private bool _FreeSocket;
    public string ConnectTo;
    public bool IsBusy;
    public mySocketConnectedCounter SocketConnectedCounter;
    public myIsBusyCounter IsBusyCounter;
    public short InFunction;
    private int TimeConnectStart;
    private System.Timers.Timer tmrTimeOut;
    public int ResponseNum;
    public string ResponseMessage;
    public SocketNET.myConnectOption ConnectOptions;
    public SocketNET.meOptionsSet Options;
    private SocketNET.myState _State;
    private myProxy Prev_Proxy;
    private ManualResetEvent connectDone;
    private const string vbCrLf2 = "\r\n\r\n";
    private const byte Cr = 13;
    private const byte Lf = 10;

    internal event SocketNET.DataArrivalEventHandler DataArrival;

    internal event SocketNET.ErrorEventEventHandler ErrorEvent;

    internal event SocketNET.DebugEventEventHandler DebugEvent;

    public SocketNET(int set_Index = 0, ref mySocketConnectedCounter set_SocketConnectedCounter = null, ref myIsBusyCounter set_IsBusyCounter = null)
    {
      this.CloseSocketAtFree = false;
      this._FreeSocket = false;
      this.TimeConnectStart = 0;
      this.Prev_Proxy = (myProxy) null;
      SocketNET.UserAgent = new string[18];
      Random random = new Random();
      SocketNET.UserAgent[0] = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:28.0) Gecko/20100101 Firefox/" + Conversions.ToString(random.Next(24, 29)) + ".0";
      SocketNET.UserAgent[1] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.57 Safari/537.36 OPR/" + Conversions.ToString(random.Next(16, 21)) + ".0." + Conversions.ToString(random.Next(1100, 1400)) + ".64";
      SocketNET.UserAgent[2] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.62 Safari/537.36";
      SocketNET.UserAgent[3] = "Mozilla/5.0 (Windows NT 6.2; rv:22.0) Gecko/20100101 Firefox/" + Conversions.ToString(random.Next(26, 29)) + ".0";
      SocketNET.UserAgent[4] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.1 (KHTML, like Gecko) Maxthon/4.0.6.2000";
      SocketNET.UserAgent[5] = "Mozilla/5.0 (Windows NT 5.1; rv:22.0) Gecko/20100101 Firefox/" + Conversions.ToString(random.Next(26, 29)) + ".0";
      SocketNET.UserAgent[6] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.22 (KHTML, like Gecko) Chrome/25.0.1364.172 YaBrowser/" + Conversions.ToString(random.Next(1, 15)) + "." + Conversions.ToString(random.Next(2, 8)) + "." + Conversions.ToString(random.Next(1300, 1701)) + "." + Conversions.ToString(random.Next(12000, 22000)) + " Safari/537." + Conversions.ToString(random.Next(22, 37));
      SocketNET.UserAgent[7] = "Mozilla/5.0 (Windows NT 6.1; rv:22.0) Gecko/20100101 Firefox/" + Conversions.ToString(random.Next(26, 29)) + ".0";
      SocketNET.UserAgent[8] = "Mozilla/5.0 (Windows NT 5.1; rv:22.0) Gecko/20100101 Firefox/" + Conversions.ToString(random.Next(24, 29)) + ".0";
      SocketNET.UserAgent[9] = "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.57 Safari/537.36 OPR/" + Conversions.ToString(random.Next(16, 21)) + ".0." + Conversions.ToString(random.Next(1100, 1400)) + ".64";
      SocketNET.UserAgent[10] = "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.62 Safari/537.36";
      SocketNET.UserAgent[11] = "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.1 (KHTML, like Gecko) Maxthon/4.0.6.2000";
      SocketNET.UserAgent[12] = "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.22 (KHTML, like Gecko) Chrome/25.0.1364.172 YaBrowser/" + Conversions.ToString(random.Next(1, 15)) + "." + Conversions.ToString(random.Next(2, 8)) + "." + Conversions.ToString(random.Next(1300, 1701)) + "." + Conversions.ToString(random.Next(12000, 22000)) + " Safari/537." + Conversions.ToString(random.Next(22, 37));
      SocketNET.UserAgent[13] = "Mozilla/5.0 (Windows NT 6.2; rv:22.0) Gecko/20100101 Firefox/" + Conversions.ToString(random.Next(26, 29)) + ".0";
      SocketNET.UserAgent[14] = "Mozilla/5.0 (Windows NT 6.2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.57 Safari/537.36 OPR/" + Conversions.ToString(random.Next(16, 21)) + ".0." + Conversions.ToString(random.Next(1100, 1400)) + ".64";
      SocketNET.UserAgent[15] = "Mozilla/5.0 (Windows NT 6.2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.62 Safari/537.36";
      SocketNET.UserAgent[16] = "Mozilla/5.0 (Windows NT 6.2) AppleWebKit/537.1 (KHTML, like Gecko) Maxthon/4.0.6.2000";
      SocketNET.UserAgent[17] = "Mozilla/5.0 (Windows NT 6.2) AppleWebKit/537.22 (KHTML, like Gecko) Chrome/25.0.1364.172 YaBrowser/" + Conversions.ToString(random.Next(1, 15)) + "." + Conversions.ToString(random.Next(2, 8)) + "." + Conversions.ToString(random.Next(1300, 1701)) + "." + Conversions.ToString(random.Next(12000, 22000)) + " Safari/537." + Conversions.ToString(random.Next(22, 37));
      this.Options.ProtocolVer = "1";
      this.Options.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
      this.Options.Accept_Language = "ru-ru,ru;q=0.8,en-us;q=0.5,en;q=0.3";
      this.Options.Accept_Charset = "windows-1251;q=0.5, utf-8, *;q=0.3";
      this.Options.Accept_Encoding = "gzip";
      this.Options.Keep_Alive = true;
      this.Options.TimeOut = 20000;
      this.Options.SizePacket = 8192;
      this.Options.NotUse_Accept = false;
      this.ConnectTo = (string) null;
      this.IsBusy = false;
      this.SocketConnectedCounter = set_SocketConnectedCounter;
      this.IsBusyCounter = set_IsBusyCounter;
      this.Mirror = -1;
      this.Index = set_Index;
      this._FreeSocket = true;
      if (!Information.IsNothing((object) SocketTimer.TimeSW))
        return;
      SocketTimer.TimeSW = new Stopwatch();
      SocketTimer.TimeSW.Start();
    }

    public void SocketClose()
    {
      try
      {
        if (this.IsBusy)
        {
          this.IsBusy = false;
          if (!Information.IsNothing((object) this.SocketConnectedCounter))
            checked { --this.SocketConnectedCounter.Counter; }
          this.TimeConnectStart = checked ((int) (SocketTimer.TimeSW.ElapsedMilliseconds - (long) this.TimeConnectStart));
        }
        if (!Information.IsNothing((object) this.tmrTimeOut))
        {
          this.tmrTimeOut.Stop();
          this.tmrTimeOut.Elapsed -= new ElapsedEventHandler(this.tmrTimeOut_Elapsed);
          this.tmrTimeOut.Dispose();
          this.tmrTimeOut = (System.Timers.Timer) null;
        }
        if (Information.IsNothing((object) this._State))
          return;
        this._State._receiveBuffer = (byte[]) null;
        if (!Information.IsNothing((object) this._State._TcpClient))
        {
          if (this._State._TcpClient.Client.Connected)
          {
            this._State._TcpClient.Client.Shutdown(SocketShutdown.Both);
            this._State._TcpClient.Client.Disconnect(false);
          }
          this._State._TcpClient.Close();
          this._State._TcpClient = (TcpClient) null;
        }
        if (!Information.IsNothing((object) this._State._memBuffer))
        {
          this._State._memBuffer.Close();
          this._State._memBuffer = (MemoryStream) null;
        }
        if (!Information.IsNothing((object) this._State.ntStream))
        {
          this._State.ntStream.Close();
          this._State.ntStream = (Stream) null;
        }
        this._State.PacketHEAD = (string) null;
        this._State.PacketBODY = (string) null;
        this._State.PacketTo = (StringBuilder) null;
        this._State.PacketBODY_B = (byte[]) null;
        this._State.CookiesFrom = (myCookies) null;
        this._State.Resp_Chunked = false;
        this._State.Resp_Gzip = false;
        this._State.Resp_ContentLenght = false;
        this._State.ContentLenght = 0;
        this._State.Resp_Location = (string) null;
        this._State.AuthenticationStep = (short) 0;
        this._State = (SocketNET.myState) null;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string Description = "Close: " + ex.Message;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
    }

    public void Connect(ref string set_URL = null, ref myCookies set_Cookies = null, ref string set_Referer = null, ref string set_PostData = null, myProxy set_Proxy = null, ref short set_UseBrowser = 0, ref string set_X_Forwarded_For = null, ref string set_ContentType = null, ref object set_Accept_Charset = 1251, ref string set_Headers_Add = null)
    {
      try
      {
        if (this.IsBusy)
        {
          string str = "<NoURL>";
          if (!Information.IsNothing((object) set_URL))
            str = "<" + set_URL + ">";
          string Description = "[Ex_1.0]: Current socket is busy! \r\n" + str;
          this.send_ErrorEvent(ref Description);
        }
        else
        {
          this.IsBusy = true;
          if (!Information.IsNothing((object) set_URL))
          {
            this.ConnectOptions.URL = set_URL;
            this.ConnectOptions.Cookies = set_Cookies;
            this.ConnectOptions.Referer = set_Referer;
            this.ConnectOptions.PostData = set_PostData;
            if (!Information.IsNothing((object) set_Proxy))
              this.ConnectOptions.Proxy = new myProxy()
              {
                IP = set_Proxy.IP,
                Login = set_Proxy.Login,
                Password = set_Proxy.Password,
                Port = set_Proxy.Port,
                Protocol = set_Proxy.Protocol,
                RealIP = set_Proxy.RealIP
              };
            else
              this.ConnectOptions.Proxy = (myProxy) null;
            this.ConnectOptions.NumUserAgent = set_UseBrowser;
            this.ConnectOptions.X_Forwarded_For = set_X_Forwarded_For;
            this.ConnectOptions.ContentType = set_ContentType;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            SocketNET.myConnectOption& local1 = @this.ConnectOptions;
            // ISSUE: variable of the null type
            __Null local2 = null;
            Type Type = typeof (Encoding);
            string MemberName = "GetEncoding";
            object[] objArray = new object[1]
            {
              RuntimeHelpers.GetObjectValue(set_Accept_Charset)
            };
            object[] Arguments = objArray;
            // ISSUE: variable of the null type
            __Null local3 = null;
            // ISSUE: variable of the null type
            __Null local4 = null;
            bool[] flagArray = new bool[1]{ true };
            bool[] CopyBack = flagArray;
            object obj = NewLateBinding.LateGet((object) local2, Type, MemberName, Arguments, (string[]) local3, (Type[]) local4, CopyBack);
            if (flagArray[0])
              set_Accept_Charset = RuntimeHelpers.GetObjectValue(objArray[0]);
            Encoding encoding = (Encoding) obj;
            // ISSUE: explicit reference operation
            (^local1).CodePage = encoding;
            this.ConnectOptions.Headers_Add = set_Headers_Add;
          }
          this.TimeConnectStart = checked ((int) SocketTimer.TimeSW.ElapsedMilliseconds);
          if (!Information.IsNothing((object) this.tmrTimeOut))
          {
            this.tmrTimeOut.Elapsed -= new ElapsedEventHandler(this.tmrTimeOut_Elapsed);
            this.tmrTimeOut.Dispose();
            this.tmrTimeOut = (System.Timers.Timer) null;
          }
          this.tmrTimeOut = new System.Timers.Timer();
          this.tmrTimeOut.Interval = (double) this.Options.TimeOut;
          this.tmrTimeOut.AutoReset = false;
          this.tmrTimeOut.Elapsed += new ElapsedEventHandler(this.tmrTimeOut_Elapsed);
          this.tmrTimeOut.Start();
          this.ResponseNum = 0;
          this.ResponseMessage = (string) null;
          if (!Information.IsNothing((object) this.SocketConnectedCounter))
            checked { ++this.SocketConnectedCounter.Counter; }
          if (!Information.IsNothing((object) this._State))
          {
            if (this.IsConnected())
            {
              this._State.PacketHEAD = (string) null;
              this._State.PacketBODY = (string) null;
              this._State.PacketTo = (StringBuilder) null;
              this._State.PacketBODY_B = (byte[]) null;
              this._State.CookiesFrom = (myCookies) null;
              this._State.Resp_Chunked = false;
              this._State.Resp_Gzip = false;
              this._State.Resp_ContentLenght = false;
              this._State.ContentLenght = 0;
              this._State.Resp_Location = (string) null;
              this._State.AuthenticationStep = (short) 0;
              this._State.Resp_Connection = SocketNET.connectionFromServer.Unknown;
              if (this.Options.Keep_Alive && (Operators.CompareString(new UriBuilder(this.ConnectOptions.URL).Host, this._State._Host, false) == 0 && new UriBuilder(this.ConnectOptions.URL).Port == this._State._Port && (Information.IsNothing((object) this.ConnectOptions.Proxy) && Information.IsNothing((object) this.Prev_Proxy) || !Information.IsNothing((object) this.ConnectOptions.Proxy) && !Information.IsNothing((object) this.Prev_Proxy) && (Operators.CompareString(this.ConnectOptions.Proxy.IP, this.Prev_Proxy.IP, false) == 0 && this.ConnectOptions.Proxy.Port == this.Prev_Proxy.Port) && this.ConnectOptions.Proxy.Protocol == this.Prev_Proxy.Protocol)))
              {
                if (Operators.CompareString(Strings.Left(this.ConnectOptions.URL.ToLower(), 5), "https", false) == 0)
                  this._State.SSL = true;
                this._State._memBuffer = new MemoryStream();
                this.Prev_Proxy = this.ConnectOptions.Proxy;
                this.Send();
                return;
              }
            }
            this._State._receiveBuffer = (byte[]) null;
            if (!Information.IsNothing((object) this._State._TcpClient))
            {
              if (this._State._TcpClient.Client.Connected)
              {
                this._State._TcpClient.Client.Shutdown(SocketShutdown.Both);
                this._State._TcpClient.Client.Disconnect(false);
              }
              this._State._TcpClient.Close();
              this._State._TcpClient = (TcpClient) null;
            }
            if (!Information.IsNothing((object) this._State._memBuffer))
            {
              this._State._memBuffer.Close();
              this._State._memBuffer = (MemoryStream) null;
            }
            if (!Information.IsNothing((object) this._State.ntStream))
            {
              this._State.ntStream.Close();
              this._State.ntStream = (Stream) null;
            }
            this._State = (SocketNET.myState) null;
          }
          this._State = new SocketNET.myState();
          this._State.Resp_Connection = SocketNET.connectionFromServer.Unknown;
          this._State._Host = new UriBuilder(this.ConnectOptions.URL).Host;
          this._State._Port = new UriBuilder(this.ConnectOptions.URL).Port;
          if (Operators.CompareString(Strings.Left(this.ConnectOptions.URL.ToLower(), 5), "https", false) == 0)
            this._State.SSL = true;
          this.Prev_Proxy = this.ConnectOptions.Proxy;
          Dns.BeginGetHostEntry(this._State._Host, new AsyncCallback(this.DNS_Callback), (object) null);
        }
      }
      catch (SocketException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        SocketException socketException = ex;
        string Description = "[Ex_1.1]: " + Conversions.ToString(socketException.ErrorCode) + " " + socketException.Message;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string Description = "[Ex_1.2]: " + ex.Message;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
    }

    private void DNS_Callback(IAsyncResult AR)
    {
      try
      {
        if (!this.IsBusy)
          return;
        this._State._IPHostEntry = Dns.EndGetHostEntry(AR);
        TcpClient tcpClient = new TcpClient(AddressFamily.InterNetwork);
        try
        {
          IAsyncResult asyncResult;
          if (Information.IsNothing((object) this.ConnectOptions.Proxy))
          {
            if (this._State._IPHostEntry.AddressList.Length > 0)
              asyncResult = tcpClient.BeginConnect(this._State._IPHostEntry.AddressList, this._State._Port, new AsyncCallback(this.DoConnect), (object) tcpClient);
            else
              asyncResult = tcpClient.BeginConnect(this._State._Host, this._State._Port, new AsyncCallback(this.DoConnect), (object) tcpClient);
          }
          else
          {
            if (this._State.SSL & this.ConnectOptions.Proxy.Protocol == ProtocolProxy.HTTP)
              this.ConnectOptions.Proxy.Protocol = ProtocolProxy.HTTPs;
            if (this.ConnectOptions.Proxy.Protocol == ProtocolProxy.HTTP)
              asyncResult = tcpClient.BeginConnect(this.ConnectOptions.Proxy.IP, this.ConnectOptions.Proxy.Port, new AsyncCallback(this.DoConnect), (object) tcpClient);
            else
              asyncResult = tcpClient.BeginConnect(this.ConnectOptions.Proxy.IP, this.ConnectOptions.Proxy.Port, new AsyncCallback(this.DoConnect_Proxy), (object) tcpClient);
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          string Description = "[Ex_2.0]: " + ex.Message;
          this.send_ErrorEvent(ref Description);
          ProjectData.ClearProjectError();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        string str = string.Empty;
        if (Operators.CompareString(exception.Message, "Этот хост неизвестен", false) == 0)
          str = " " + this.ConnectOptions.URL;
        string Description = "[Ex_2.1]: " + exception.Message + str;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
    }

    public bool SocketConnected
    {
      get
      {
        if (Information.IsNothing((object) this._State) || Information.IsNothing((object) this._State._TcpClient))
          return false;
        return this._State._TcpClient.Connected;
      }
    }

    private void DoConnect_Proxy(IAsyncResult AR)
    {
      try
      {
        if (!this.IsBusy)
          return;
        this._State._TcpClient = new TcpClient();
        this._State._TcpClient = (TcpClient) AR.AsyncState;
        this._State._TcpClient.EndConnect(AR);
        this._State.ntStream = (Stream) this._State._TcpClient.GetStream();
        switch (this.ConnectOptions.Proxy.Protocol)
        {
          case ProtocolProxy.HTTPs:
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("CONNECT " + this._State._Host + ":" + Conversions.ToString(this._State._Port) + " HTTP/1.1");
            stringBuilder.AppendLine("Host: " + this._State._Host);
            if (!Information.IsNothing((object) this.ConnectOptions.Proxy.Login) && this.ConnectOptions.Proxy.Login.Length > 0)
              stringBuilder.AppendLine("Proxy-Authorization: Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(this.ConnectOptions.Proxy.Login + ":" + this.ConnectOptions.Proxy.Password)));
            stringBuilder.AppendLine("Proxy-Connection: Keep-Alive");
            stringBuilder.Append("\r\n");
            byte[] bytes1 = Encoding.Default.GetBytes(stringBuilder.ToString());
            this._State.ntStream.BeginWrite(bytes1, 0, bytes1.Length, new AsyncCallback(this.DoSend_Proxy), (object) null);
            break;
          case ProtocolProxy.SOCKS4a:
            byte[] bytes2 = BitConverter.GetBytes(checked ((ushort) this._State._Port));
            byte[] bytes3 = BitConverter.GetBytes(16777216);
            byte[] bytes4 = Encoding.ASCII.GetBytes(this.ConnectOptions.Proxy.Login);
            byte[] bytes5 = Encoding.ASCII.GetBytes(this._State._Host);
            short num1 = checked ((short) (this.ConnectOptions.Proxy.Login.Length + 1));
            short num2 = checked ((short) (this._State._Host.Length + 1));
            byte[] buffer1 = new byte[checked (8 + (int) num1 + (int) num2 - 1 + 1)];
            buffer1[0] = (byte) 4;
            buffer1[1] = (byte) 1;
            buffer1[2] = bytes2[1];
            buffer1[3] = bytes2[0];
            int index1 = 0;
            do
            {
              buffer1[checked (4 + index1)] = bytes3[index1];
              checked { ++index1; }
            }
            while (index1 <= 3);
            int num3 = 0;
            int num4 = Information.UBound((Array) bytes4, 1);
            int index2 = num3;
            while (index2 <= num4)
            {
              buffer1[checked (8 + index2)] = bytes4[index2];
              checked { ++index2; }
            }
            buffer1[checked (8 + (int) num1 - 1)] = (byte) 0;
            int num5 = 0;
            int num6 = Information.UBound((Array) bytes5, 1);
            int index3 = num5;
            while (index3 <= num6)
            {
              buffer1[checked (8 + (int) num1 + index3)] = bytes5[index3];
              checked { ++index3; }
            }
            buffer1[checked (8 + (int) num1 + (int) num2 - 1)] = (byte) 0;
            this._State.ntStream.BeginWrite(buffer1, 0, buffer1.Length, new AsyncCallback(this.DoSend_Proxy), (object) null);
            break;
          case ProtocolProxy.SOCKS4:
            byte[] bytes6 = BitConverter.GetBytes(checked ((ushort) this._State._Port));
            byte[] bytes7 = BitConverter.GetBytes(this._State._IPHostEntry.AddressList[0].GetHashCode());
            byte[] bytes8 = Encoding.ASCII.GetBytes(this.ConnectOptions.Proxy.Login);
            short num7 = checked ((short) (this.ConnectOptions.Proxy.Login.Length + 1));
            byte[] buffer2 = new byte[checked (8 + (int) num7 - 1 + 1)];
            buffer2[0] = (byte) 4;
            buffer2[1] = (byte) 1;
            buffer2[2] = bytes6[1];
            buffer2[3] = bytes6[0];
            int index4 = 0;
            do
            {
              buffer2[checked (4 + index4)] = bytes7[index4];
              checked { ++index4; }
            }
            while (index4 <= 3);
            int num8 = 0;
            int num9 = Information.UBound((Array) bytes8, 1);
            int index5 = num8;
            while (index5 <= num9)
            {
              buffer2[checked (8 + index5)] = bytes8[index5];
              checked { ++index5; }
            }
            buffer2[checked (8 + (int) num7 - 1)] = (byte) 0;
            this._State.ntStream.BeginWrite(buffer2, 0, buffer2.Length, new AsyncCallback(this.DoSend_Proxy), (object) null);
            break;
          case ProtocolProxy.SOCKS5:
            byte[] buffer3;
            if (this.ConnectOptions.Proxy.Login == null || this.ConnectOptions.Proxy.Login.Length == 0)
              buffer3 = new byte[3]
              {
                (byte) 5,
                (byte) 1,
                (byte) 0
              };
            else
              buffer3 = new byte[4]
              {
                (byte) 5,
                (byte) 2,
                (byte) 0,
                (byte) 2
              };
            this._State.ntStream.BeginWrite(buffer3, 0, buffer3.Length, new AsyncCallback(this.DoSend_Proxy), (object) null);
            break;
        }
      }
      catch (SocketException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        string Description = "[Ex_3.5]: Proxy connection error #" + Conversions.ToString(ex.ErrorCode);
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string Description = "[Ex_3.6]: " + ex.Message;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
    }

    private void DoSend_Proxy(IAsyncResult AR)
    {
      try
      {
        if (!this.IsBusy)
          return;
        this._State.ntStream.EndWrite(AR);
        this._State._receiveBuffer = new byte[checked (this.Options.SizePacket - 1 + 1)];
        this._State.ntStream.BeginRead(this._State._receiveBuffer, 0, this.Options.SizePacket, new AsyncCallback(this.DoReceive_Proxy), (object) null);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string Description = "[Ex_4.1]: " + ex.Message;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
    }

    private void DoReceive_Proxy(IAsyncResult AR)
    {
      try
      {
        if (!this.IsBusy)
          return;
        if (Information.IsNothing((object) this._State.ntStream))
        {
          string Description = "[Ex_5.0]: Remote host connection aborted.";
          this.send_ErrorEvent(ref Description);
        }
        else
        {
          int num1 = this._State.ntStream.EndRead(AR);
          if (num1 > 0)
          {
            switch (this.ConnectOptions.Proxy.Protocol)
            {
              case ProtocolProxy.HTTPs:
                string[] strArray1 = Strings.Split(Encoding.ASCII.GetString(this._State._receiveBuffer), "\r\n", -1, CompareMethod.Binary);
                if (Operators.CompareString(Strings.Left(strArray1[0], 5), "HTTP/", false) != 0)
                {
                  string Description = "[Ex_5.1]: Proxy HTTPs wrong title in the response.";
                  this.send_ErrorEvent(ref Description);
                  return;
                }
                string empty = string.Empty;
                string[] strArray2 = Strings.Split(strArray1[0], " ", 3, CompareMethod.Binary);
                int integer = Conversions.ToInteger(strArray2[1]);
                if (integer != 200)
                {
                  string str = strArray2[2];
                  string Description = "[Ex_5.2]: Proxy HTTPs " + Conversions.ToString(integer) + " " + str;
                  this.send_ErrorEvent(ref Description);
                  return;
                }
                break;
              case (ProtocolProxy) 2:
                return;
              case ProtocolProxy.SOCKS4a:
                if (num1 != 8)
                {
                  string Description = "[Ex_5.3]: SOCKS4 Server wrong answer.";
                  this.send_ErrorEvent(ref Description);
                  return;
                }
                if ((int) this._State._receiveBuffer[1] != 90)
                {
                  string str = string.Empty;
                  switch (this._State._receiveBuffer[1])
                  {
                    case 91:
                      str = "SOCKS4 Server {0x5b запрос отклонён}";
                      break;
                    case 92:
                      str = "SOCKS4 Server {0x5c запрос не удался, потому что не запущен identd или не доступен с сервера}";
                      break;
                    case 93:
                      str = "SOCKS4 Server {0x5d = запрос не удался, поскольку клиентский identd не может подтвердить идентификатор пользователя в запросе}";
                      break;
                  }
                  string Description = "[Ex_5.4]: " + str;
                  this.send_ErrorEvent(ref Description);
                  return;
                }
                break;
              case ProtocolProxy.SOCKS4:
                if (num1 != 8)
                {
                  string Description = "[Ex_5.5]: SOCKS4 Server wrong answer.";
                  this.send_ErrorEvent(ref Description);
                  return;
                }
                if ((int) this._State._receiveBuffer[1] != 90)
                {
                  string str = string.Empty;
                  switch (this._State._receiveBuffer[1])
                  {
                    case 91:
                      str = "SOCKS4 Server {0x5b запрос отклонён}";
                      break;
                    case 92:
                      str = "SOCKS4 Server {0x5c запрос не удался, потому что не запущен identd или не доступен с сервера}";
                      break;
                    case 93:
                      str = "SOCKS4 Server {0x5d = запрос не удался, поскольку клиентский identd не может подтвердить идентификатор пользователя в запросе}";
                      break;
                  }
                  string Description = "[Ex_5.6]: " + str;
                  this.send_ErrorEvent(ref Description);
                  return;
                }
                break;
              case ProtocolProxy.SOCKS5:
                checked { ++this._State.AuthenticationStep; }
                switch (this._State.AuthenticationStep)
                {
                  case 1:
                    if ((int) this._State._receiveBuffer[0] != 5)
                    {
                      string Description = "[Ex_5.7]: SOCKS5 Server wrong answer.";
                      this.send_ErrorEvent(ref Description);
                      return;
                    }
                    byte[] buffer1;
                    switch (this._State._receiveBuffer[1])
                    {
                      case 0:
                        byte[] bytes1 = BitConverter.GetBytes(checked ((ushort) this._State._Port));
                        byte[] bytes2 = BitConverter.GetBytes(this._State._IPHostEntry.AddressList[0].GetHashCode());
                        buffer1 = new byte[10]
                        {
                          (byte) 5,
                          (byte) 1,
                          (byte) 0,
                          (byte) 1,
                          bytes2[0],
                          bytes2[1],
                          bytes2[2],
                          bytes2[3],
                          bytes1[1],
                          bytes1[0]
                        };
                        break;
                      case 2:
                        byte[] bytes3 = Encoding.ASCII.GetBytes(this.ConnectOptions.Proxy.Login);
                        byte[] bytes4 = Encoding.ASCII.GetBytes(this.ConnectOptions.Proxy.Password);
                        short num2 = checked ((short) (this.ConnectOptions.Proxy.Login.Length + 1));
                        short num3 = checked ((short) (this.ConnectOptions.Proxy.Password.Length + 1));
                        buffer1 = new byte[checked (1 + (int) num2 + (int) num3 - 1 + 1)];
                        buffer1[0] = (byte) 1;
                        buffer1[1] = checked ((byte) this.ConnectOptions.Proxy.Login.Length);
                        int num4 = 0;
                        int num5 = Information.UBound((Array) bytes3, 1);
                        int index1 = num4;
                        while (index1 <= num5)
                        {
                          buffer1[checked (2 + index1)] = bytes3[index1];
                          checked { ++index1; }
                        }
                        buffer1[checked (1 + (int) num2)] = checked ((byte) this.ConnectOptions.Proxy.Password.Length);
                        int num6 = 0;
                        int num7 = Information.UBound((Array) bytes4, 1);
                        int index2 = num6;
                        while (index2 <= num7)
                        {
                          buffer1[checked (2 + (int) num2 + index2)] = bytes4[index2];
                          checked { ++index2; }
                        }
                        break;
                      case byte.MaxValue:
                        string Description1 = "[Ex_5.8]: SOCKS5 Server {Не было предложено приемлемого метода авторизации}.";
                        this.send_ErrorEvent(ref Description1);
                        return;
                      default:
                        string Description2 = "[Ex_5.9]: SOCKS5 Server {Частный метод авторизации}.";
                        this.send_ErrorEvent(ref Description2);
                        return;
                    }
                    this._State.ntStream.BeginWrite(buffer1, 0, buffer1.Length, new AsyncCallback(this.DoSend_Proxy), (object) null);
                    return;
                  case 2:
                    if ((int) this._State._receiveBuffer[0] == 5)
                    {
                      string str;
                      switch (this._State._receiveBuffer[1])
                      {
                        case 0:
                          goto label_55;
                        case 1:
                          str = "SOCKS5 Server {ошибка SOCKS-сервера}";
                          break;
                        case 2:
                          str = "SOCKS5 Server {соединение запрещено набором правил}";
                          break;
                        case 3:
                          str = "SOCKS5 Server {сеть недоступна}";
                          break;
                        case 4:
                          str = "SOCKS5 Server {хост недоступен}";
                          break;
                        case 5:
                          str = "SOCKS5 Server {отказ в соединении}";
                          break;
                        case 6:
                          str = "SOCKS5 Server {истечение TTL}";
                          break;
                        case 7:
                          str = "SOCKS5 Server {команда не поддерживается / ошибка протокола}";
                          break;
                        case 8:
                          str = "SOCKS5 Server {тип адреса не поддерживается}";
                          break;
                        default:
                          str = "SOCKS5 Server {Частный метод идентификации}";
                          break;
                      }
                      string Description3 = "[Ex_5.11]: " + str;
                      this.send_ErrorEvent(ref Description3);
                      return;
                    }
                    if ((int) this._State._receiveBuffer[0] == 1)
                    {
                      byte[] bytes5 = BitConverter.GetBytes(checked ((ushort) this._State._Port));
                      byte[] bytes6 = BitConverter.GetBytes(this._State._IPHostEntry.AddressList[0].GetHashCode());
                      byte[] buffer2 = new byte[10]
                      {
                        (byte) 5,
                        (byte) 1,
                        (byte) 0,
                        (byte) 1,
                        bytes6[0],
                        bytes6[1],
                        bytes6[2],
                        bytes6[3],
                        bytes5[1],
                        bytes5[0]
                      };
                      checked { --this._State.AuthenticationStep; }
                      this._State.ntStream.BeginWrite(buffer2, 0, buffer2.Length, new AsyncCallback(this.DoSend_Proxy), (object) null);
                      return;
                    }
                    string Description4 = "[Ex_5.13]: SOCKS5 Server wrong answer.";
                    this.send_ErrorEvent(ref Description4);
                    return;
                  default:
                    return;
                }
              default:
                return;
            }
label_55:
            if (this._State.SSL)
            {
              SslStream sslStream = new SslStream((Stream) this._State._TcpClient.GetStream(), false, new RemoteCertificateValidationCallback(SocketNET.ValidateServerCertificate), (LocalCertificateSelectionCallback) null);
              sslStream.AuthenticateAsClient(this._State._Host);
              this._State.ntStream = (Stream) sslStream;
            }
            this.Send();
          }
          else
          {
            string Description = "[Ex_5.14]: Proxy server closed the connection.";
            this.send_ErrorEvent(ref Description);
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string Description = "[Ex_5.15]: Proxy connection error.";
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
    }

    private void DoConnect(IAsyncResult AR)
    {
      try
      {
        if (!this.IsBusy)
          return;
        this._State._TcpClient = new TcpClient();
        this._State._TcpClient = (TcpClient) AR.AsyncState;
        this._State._TcpClient.EndConnect(AR);
        if (!this._State.SSL)
        {
          this._State.ntStream = (Stream) this._State._TcpClient.GetStream();
        }
        else
        {
          try
          {
            SslStream sslStream = new SslStream((Stream) this._State._TcpClient.GetStream(), false, new RemoteCertificateValidationCallback(SocketNET.ValidateServerCertificate), (LocalCertificateSelectionCallback) null);
            sslStream.AuthenticateAsClient(this._State._Host);
            this._State.ntStream = (Stream) sslStream;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            if (exception.GetBaseException() is SocketException)
            {
              SocketException baseException = (SocketException) exception.GetBaseException();
              if (baseException.ErrorCode == 10004)
              {
                string Description = "[Ex_6.1]: SSL stream is closed.";
                this.send_ErrorEvent(ref Description);
              }
              else
              {
                string Description = "[Ex_6.2]: Connection SSL error #" + Conversions.ToString((int) baseException.SocketErrorCode);
                this.send_ErrorEvent(ref Description);
              }
              ProjectData.ClearProjectError();
              return;
            }
            string Description1 = "[Ex_6.3]: SSL Ex: " + exception.Message;
            this.send_ErrorEvent(ref Description1);
            ProjectData.ClearProjectError();
            return;
          }
        }
        this.Send();
      }
      catch (SocketException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        string Description = "[Ex_6.4]: Connection error #" + Conversions.ToString((int) ex.SocketErrorCode);
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.IsConnected();
        string Description = "[Ex_6.5]: " + exception.Message;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
    }

    public bool IsConnected()
    {
      return !Information.IsNothing((object) this._State) && !Information.IsNothing((object) this._State._TcpClient) && (this._State._TcpClient.Client.Connected && !(this._State._TcpClient.Client.Available == 0 & this._State._TcpClient.Client.Poll(1000, SelectMode.SelectRead)));
    }

    private void DoReceive(IAsyncResult AR)
    {
      try
      {
        if (!this.IsBusy)
          return;
        if (Information.IsNothing((object) this._State.ntStream))
        {
          string Description = "[Ex_7.1]: Remote host connection aborted.";
          this.send_ErrorEvent(ref Description);
        }
        else
        {
          int count = this._State.ntStream.EndRead(AR);
          if (count > 0)
          {
            this._State._memBuffer.Seek(0L, SeekOrigin.End);
            this._State._memBuffer.Write(this._State._receiveBuffer, 0, count);
            if (Information.IsNothing((object) this._State.PacketHEAD) && !this._DataArrival_Header())
              return;
            if (this._State.Resp_Chunked)
            {
              if (this._State._memBuffer.Length >= 7L)
              {
                byte[] numArray = new byte[7];
                this._State._memBuffer.Seek(-7L, SeekOrigin.End);
                this._State._memBuffer.Read(numArray, 0, 7);
                if (Operators.CompareString(Encoding.ASCII.GetString(numArray), SocketNET.Const_EndPacketChunk, false) == 0)
                {
                  this._DataArrival();
                  return;
                }
              }
            }
            else if (this._State.Resp_ContentLenght)
            {
              int contentLenght = this._State.ContentLenght;
              if ((long) checked (this._State.ContentLenght + this._State.PacketHEAD.Length) <= this._State._memBuffer.Length)
              {
                this._DataArrival();
                return;
              }
            }
            this._State._receiveBuffer = new byte[checked (this.Options.SizePacket - 1 + 1)];
            this._State.ntStream.BeginRead(this._State._receiveBuffer, 0, this.Options.SizePacket, new AsyncCallback(this.DoReceive), (object) null);
          }
          else if (Information.IsNothing((object) this._State._memBuffer) || this._State._memBuffer.Length == 0L)
          {
            this.SocketClose();
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
            this.Connect(ref set_URL, ref set_Cookies, ref set_Referer, ref set_PostData, (myProxy) local, ref set_UseBrowser, ref set_X_Forwarded_For, ref set_ContentType, ref set_Accept_Charset, ref set_Headers_Add);
          }
          else
            this._DataArrival();
        }
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        string Description = "[Ex_7.4]: Remote host connection has been closed.";
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string Description = "[Ex_7.5]: " + ex.Message;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
    }

    private void Send()
    {
      try
      {
        if (!this.IsBusy)
          return;
        this._State.PacketTo = new StringBuilder();
        if (Information.IsNothing((object) this.ConnectOptions.PostData))
          this._State.PacketTo.Append("GET ");
        else
          this._State.PacketTo.Append("POST ");
        this._State.PacketTo.Append(this.ConnectOptions.URL);
        this._State.PacketTo.AppendLine(" HTTP/1." + this.Options.ProtocolVer);
        this._State.PacketTo.AppendLine("Host: " + this._State._Host);
        if ((int) this.ConnectOptions.NumUserAgent >= 0)
          this._State.PacketTo.AppendLine("User-Agent: " + SocketNET.UserAgent[(int) this.ConnectOptions.NumUserAgent]);
        if (!this.Options.NotUse_Accept)
        {
          if (!Information.IsNothing((object) this.Options.Accept))
            this._State.PacketTo.AppendLine("Accept: " + this.Options.Accept);
          if (!Information.IsNothing((object) this.Options.Accept_Language))
            this._State.PacketTo.AppendLine("Accept-Language: " + this.Options.Accept_Language);
          if (!Information.IsNothing((object) this.Options.Accept_Charset))
            this._State.PacketTo.AppendLine("Accept-Charset: " + this.Options.Accept_Charset);
          if (!Information.IsNothing((object) this.Options.Accept_Encoding))
            this._State.PacketTo.AppendLine("Accept-Encoding: " + this.Options.Accept_Encoding);
        }
        if (!Information.IsNothing((object) this.ConnectOptions.Cookies) && this.ConnectOptions.Cookies.Count > 0)
        {
          this._State.PacketTo.Append("Cookie: ");
          int index = checked (this.ConnectOptions.Cookies.Count - 1);
          int num1 = 0;
          short num2 = checked ((short) (index - 1));
          short num3 = (short) num1;
          while ((int) num3 <= (int) num2)
          {
            this._State.PacketTo.Append(this.ConnectOptions.Cookies.Keys.Cast<object>().ElementAtOrDefault<object>((int) num3).ToString());
            this._State.PacketTo.Append("=");
            this._State.PacketTo.Append(this.ConnectOptions.Cookies.Values.Cast<object>().ElementAtOrDefault<object>((int) num3).ToString());
            this._State.PacketTo.Append("; ");
            checked { ++num3; }
          }
          this._State.PacketTo.Append(this.ConnectOptions.Cookies.Keys.Cast<object>().ElementAtOrDefault<object>(index).ToString());
          this._State.PacketTo.Append("=");
          this._State.PacketTo.AppendLine(this.ConnectOptions.Cookies.Values.Cast<object>().ElementAtOrDefault<object>(index).ToString());
        }
        if (!Information.IsNothing((object) this.ConnectOptions.Referer) && this.ConnectOptions.Referer.Length > 0)
          this._State.PacketTo.AppendLine("Referer: " + this.ConnectOptions.Referer);
        if (!SocketNET.NoUseFIP && !Information.IsNothing((object) this.ConnectOptions.X_Forwarded_For) && this.ConnectOptions.X_Forwarded_For.Length > 0)
          this._State.PacketTo.AppendLine("X-Forwarded-For: " + this.ConnectOptions.X_Forwarded_For);
        if (!Information.IsNothing((object) this.ConnectOptions.Headers_Add) && this.ConnectOptions.Headers_Add.Length > 0)
          this._State.PacketTo.AppendLine(this.ConnectOptions.Headers_Add);
        if (!Information.IsNothing((object) this.ConnectOptions.Proxy) && this.ConnectOptions.Proxy.Protocol == ProtocolProxy.HTTP && (!Information.IsNothing((object) this.ConnectOptions.Proxy.Login) && this.ConnectOptions.Proxy.Login.Length > 0))
          this._State.PacketTo.AppendLine("Proxy-Authorization: Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(this.ConnectOptions.Proxy.Login + ":" + this.ConnectOptions.Proxy.Password)));
        if (this.Options.Keep_Alive)
          this._State.PacketTo.AppendLine("Connection: Keep-alive");
        else
          this._State.PacketTo.AppendLine("Connection: Close");
        if (Information.IsNothing((object) this.ConnectOptions.PostData))
        {
          this._State.PacketTo.Append("\r\n");
        }
        else
        {
          if (Information.IsNothing((object) this.ConnectOptions.ContentType))
            this._State.PacketTo.AppendLine("Content-Type: application/x-www-form-urlencoded");
          else
            this._State.PacketTo.AppendLine("Content-Type: " + this.ConnectOptions.ContentType);
          this._State.PacketTo.AppendLine("Content-Length: " + Conversions.ToString(this.ConnectOptions.PostData.Length));
          this._State.PacketTo.Append("\r\n");
          this._State.PacketTo.Append(this.ConnectOptions.PostData);
        }
        byte[] bytes = Encoding.Default.GetBytes(this._State.PacketTo.ToString());
        this._State.ntStream.BeginWrite(bytes, 0, bytes.Length, new AsyncCallback(this.DoSend), (object) null);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string Description = "[Ex_8]: " + ex.Message;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
    }

    private void DoSend(IAsyncResult AR)
    {
      try
      {
        if (!this.IsBusy)
          return;
        this._State._receiveBuffer = new byte[checked (this.Options.SizePacket - 1 + 1)];
        this._State.ntStream.EndWrite(AR);
        this._State.ntStream.BeginRead(this._State._receiveBuffer, 0, this.Options.SizePacket, new AsyncCallback(this.DoReceive), (object) null);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string Description = "[Ex_9]: " + ex.Message;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
    }

    private bool _DataArrival_Header()
    {
      bool flag;
      try
      {
        byte[] array = this._State._memBuffer.ToArray();
        int startIndex = 0;
        if (array.Length >= 3)
        {
          do
          {
            int num = Array.IndexOf<byte>(array, (byte) 13, startIndex, checked (array.Length - startIndex - 3));
            if (num != -1)
            {
              if ((int) array[checked (num + 1)] == 10 && (int) array[checked (num + 2)] == 13 && (int) array[checked (num + 3)] == 10)
              {
                int count = checked (num + 4);
                this._State.PacketHEAD = Encoding.ASCII.GetString(array, 0, count);
                if (Operators.CompareString(Strings.Left(this._State.PacketHEAD, 5), "HTTP/", false) == 0)
                  goto label_6;
                else
                  goto label_5;
              }
              else
                startIndex = checked (num + 1);
            }
            else
              break;
          }
          while (startIndex < checked (array.Length - 3));
          goto label_28;
label_5:
          string Description = "HTTP wrong title in the response.";
          this.send_ErrorEvent(ref Description);
          _FUNCTION.FN.TXT(ref this._State.PacketHEAD);
          flag = false;
          goto label_30;
label_6:
          string[] strArray1 = Strings.Split(this._State.PacketHEAD, "\r\n", -1, CompareMethod.Binary);
          string[] strArray2 = Strings.Split(strArray1[0], " ", 3, CompareMethod.Binary);
          this.ResponseNum = Conversions.ToInteger(strArray2[1]);
          this.ResponseMessage = strArray2[2];
          int num1 = 0;
          int num2 = checked (Information.UBound((Array) strArray1, 1) - 2);
          int index = num1;
          while (index <= num2)
          {
            if (!this._State.Resp_Chunked && Operators.CompareString(strArray1[index].ToLower(), "transfer-encoding: chunked", false) == 0)
              this._State.Resp_Chunked = true;
            else if (!this._State.Resp_Gzip && Operators.CompareString(strArray1[index].ToLower(), "content-encoding: gzip", false) == 0)
              this._State.Resp_Gzip = true;
            else if (!this._State.Resp_ContentLenght && Operators.CompareString(Strings.Left(strArray1[index].ToLower(), 16), "content-length: ", false) == 0)
            {
              this._State.Resp_ContentLenght = true;
              this._State.ContentLenght = Conversions.ToInteger(Strings.Right(strArray1[index], checked (strArray1[index].Length - 16)));
            }
            else if (Operators.CompareString(Strings.Left(strArray1[index].ToLower(), 12), "set-cookie: ", false) == 0)
            {
              if (Information.IsNothing((object) this._State.CookiesFrom))
                this._State.CookiesFrom = new myCookies();
              int num3 = Strings.InStr(13, strArray1[index], "=", CompareMethod.Binary);
              string Name = Strings.Mid(strArray1[index], 13, checked (num3 - 13));
              int Start = checked (num3 + 1);
              int num4 = Strings.InStr(Start, strArray1[index], ";", CompareMethod.Binary);
              if (num4 == 0)
                num4 = checked (strArray1[index].Length + 1);
              string str = Strings.Mid(strArray1[index], Start, checked (num4 - Start));
              if (Operators.CompareString(str.ToLower(), "deleted", false) == 0)
                str = string.Empty;
              this._State.CookiesFrom.Add(Name, str);
            }
            else if (Information.IsNothing((object) this._State.Resp_Location) && Operators.CompareString(Strings.Left(strArray1[index].ToLower(), 10), "location: ", false) == 0)
            {
              this._State.Resp_Location = Strings.Right(strArray1[index], checked (strArray1[index].Length - 10));
              if (Operators.CompareString(Strings.Left(this._State.Resp_Location, 1), "/", false) == 0)
                this._State.Resp_Location = this._State._Port != 80 ? "https://" + this._State._Host + this._State.Resp_Location : "http://" + this._State._Host + this._State.Resp_Location;
            }
            else if (this._State.Resp_Connection == SocketNET.connectionFromServer.Unknown && Operators.CompareString(Strings.Left(strArray1[index].ToLower(), 12), "connection: ", false) == 0)
            {
              string lower = Strings.Right(strArray1[index], checked (strArray1[index].Length - 12)).ToLower();
              this._State.Resp_Connection = Operators.CompareString(lower, "close", false) != 0 ? (Operators.CompareString(lower, "keep-alive", false) != 0 ? SocketNET.connectionFromServer.Unknown : SocketNET.connectionFromServer.KeepAlive) : SocketNET.connectionFromServer.Close;
            }
            checked { ++index; }
          }
        }
label_28:
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string Description = "[Ex_10]: " + ex.Message;
        this.send_ErrorEvent(ref Description);
        flag = false;
        ProjectData.ClearProjectError();
      }
label_30:
      return flag;
    }

    private void _DataArrival()
    {
      try
      {
        if (!this.IsBusy)
          return;
        if (Information.IsNothing((object) this._State.PacketHEAD))
        {
          string Description = "[Ex_11.0]: Отсутствует заголовок пакета. Buffer.L=" + Conversions.ToString(this._State._memBuffer.Length) + " " + this.ConnectOptions.URL;
          this.send_ErrorEvent(ref Description);
        }
        else
        {
          int count1 = checked ((int) (this._State._memBuffer.Length - (long) this._State.PacketHEAD.Length));
          if (count1 != 0)
          {
            if (this._State.Resp_Chunked)
            {
              if (this._State._memBuffer.Length >= 7L)
              {
                byte[] numArray1 = new byte[7];
                this._State._memBuffer.Seek(-7L, SeekOrigin.End);
                this._State._memBuffer.Read(numArray1, 0, 7);
                if (Operators.CompareString(Encoding.ASCII.GetString(numArray1), SocketNET.Const_EndPacketChunk, false) != 0)
                {
                  string Description = "[Ex_11.1]: Incorrect packet length.";
                  this.send_ErrorEvent(ref Description);
                  return;
                }
                this._State._memBuffer.Seek((long) this._State.PacketHEAD.Length, SeekOrigin.Begin);
                byte[] numArray2 = new byte[checked (count1 - 1 + 1)];
                this._State._memBuffer.Read(numArray2, 0, count1);
                int num1 = 0;
                MemoryStream memoryStream1 = new MemoryStream();
                while (true)
                {
                  int num2 = Array.IndexOf<byte>(numArray2, (byte) 13, num1);
                  int count2 = checked (num2 - num1);
                  int count3 = int.Parse(Strings.RTrim(Encoding.ASCII.GetString(numArray2, num1, count2)), NumberStyles.AllowHexSpecifier);
                  if (count3 >= 1)
                  {
                    int offset = checked (num2 + 2);
                    memoryStream1.Write(numArray2, offset, count3);
                    num1 = checked (offset + count3 + 2);
                  }
                  else
                    break;
                }
                if (this._State.Resp_Gzip)
                {
                  memoryStream1.Seek(0L, SeekOrigin.Begin);
                  GZipStream gzipStream = new GZipStream((Stream) memoryStream1, CompressionMode.Decompress, false);
                  MemoryStream memoryStream2 = new MemoryStream();
                  gzipStream.CopyTo((Stream) memoryStream2);
                  this._State.PacketBODY_B = memoryStream2.ToArray();
                  gzipStream.Close();
                  memoryStream2.Close();
                }
                else
                {
                  this._State.PacketBODY_B = memoryStream1.ToArray();
                  memoryStream1.Close();
                }
              }
              else
              {
                string Description = "[Ex_11.2]: Incorrect packet length.";
                this.send_ErrorEvent(ref Description);
                return;
              }
            }
            else
            {
              if (this._State.Resp_ContentLenght && (long) this._State.ContentLenght != checked (this._State._memBuffer.Length - (long) this._State.PacketHEAD.Length))
              {
                string Description = "[Ex_11.3]: Incorrect packet length. " + Conversions.ToString(this._State.ContentLenght) + "<>" + Conversions.ToString(checked (this._State._memBuffer.Length - (long) this._State.PacketHEAD.Length));
                this.send_ErrorEvent(ref Description);
                return;
              }
              this._State._memBuffer.Seek((long) this._State.PacketHEAD.Length, SeekOrigin.Begin);
              if (!this._State.Resp_Gzip)
              {
                this._State.PacketBODY_B = new byte[checked (count1 - 1 + 1)];
                this._State._memBuffer.Read(this._State.PacketBODY_B, 0, count1);
              }
              else
              {
                using (GZipStream gzipStream = new GZipStream((Stream) this._State._memBuffer, CompressionMode.Decompress, false))
                {
                  MemoryStream memoryStream = new MemoryStream();
                  gzipStream.CopyTo((Stream) memoryStream);
                  this._State.PacketBODY_B = memoryStream.ToArray();
                  memoryStream.Close();
                }
              }
            }
          }
          this.send_DataArrival();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string Description = "[Ex_11.4]: " + ex.Message;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
      }
    }

    private void tmrTimeOut_Elapsed(object sender, ElapsedEventArgs e)
    {
      string Description = "[Ex_12.0]: Connection Timeout " + Conversions.ToString(this.Options.TimeOut);
      this.send_ErrorEvent(ref Description);
    }

    public bool FreeSocket
    {
      get
      {
        return this._FreeSocket;
      }
      set
      {
        if (!Information.IsNothing((object) this.IsBusyCounter))
        {
          if (value)
            checked { --this.IsBusyCounter.Counter; }
          else
            checked { ++this.IsBusyCounter.Counter; }
        }
        if (value)
        {
          this.Mirror = -1;
          if (this.CloseSocketAtFree)
            this.SocketClose();
        }
        this._FreeSocket = value;
      }
    }

    public string PacketHEAD
    {
      get
      {
        if (!Information.IsNothing((object) this._State.PacketHEAD))
          return this._State.PacketHEAD;
        return (string) null;
      }
    }

    public string PacketBODY
    {
      get
      {
        if (!Information.IsNothing((object) this._State.PacketBODY_B) && this._State.PacketBODY_B.Length > 0)
          return this.ConnectOptions.CodePage.GetString(this._State.PacketBODY_B);
        return (string) null;
      }
    }

    public string PacketTo
    {
      get
      {
        if (!Information.IsNothing((object) this._State.PacketTo) && this._State.PacketTo.Length > 0)
          return this._State.PacketTo.ToString();
        return (string) null;
      }
    }

    public byte[] PacketBODY_B
    {
      get
      {
        return this._State.PacketBODY_B;
      }
    }

    public string Location
    {
      get
      {
        return this._State.Resp_Location;
      }
    }

    public myCookies Cookies
    {
      get
      {
        return this._State.CookiesFrom;
      }
    }

    public int Response
    {
      get
      {
        if (!this.IsBusy)
          return this.TimeConnectStart;
        return checked ((int) (SocketTimer.TimeSW.ElapsedMilliseconds - (long) this.TimeConnectStart));
      }
    }

    public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors__1)
    {
      return true;
    }

    private void send_DataArrival_Safe()
    {
      SocketNET.DataArrivalEventHandler dataArrivalEvent = this.DataArrivalEvent;
      if (dataArrivalEvent == null)
        return;
      dataArrivalEvent(this.Index);
    }

    private void send_DataArrival()
    {
      try
      {
        if (!this.IsBusy)
          return;
        this.IsBusy = false;
        if (!Information.IsNothing((object) this.tmrTimeOut))
        {
          this.tmrTimeOut.Stop();
          this.tmrTimeOut.Elapsed -= new ElapsedEventHandler(this.tmrTimeOut_Elapsed);
          this.tmrTimeOut.Dispose();
          this.tmrTimeOut = (System.Timers.Timer) null;
        }
        if (!Information.IsNothing((object) this.SocketConnectedCounter))
          checked { --this.SocketConnectedCounter.Counter; }
        this._State._receiveBuffer = (byte[]) null;
        if (!this.Options.Keep_Alive && !Information.IsNothing((object) this._State._TcpClient))
        {
          if (this._State._TcpClient.Client.Connected)
          {
            this._State._TcpClient.Client.Shutdown(SocketShutdown.Both);
            this._State._TcpClient.Client.Disconnect(false);
          }
          this._State._TcpClient.Close();
          this._State._TcpClient = (TcpClient) null;
        }
        if (!Information.IsNothing((object) this._State._memBuffer))
        {
          this._State._memBuffer.Close();
          this._State._memBuffer = (MemoryStream) null;
        }
        if (!this.Options.Keep_Alive && !Information.IsNothing((object) this._State.ntStream))
        {
          this._State.ntStream.Close();
          this._State.ntStream = (Stream) null;
        }
        this.TimeConnectStart = checked ((int) (SocketTimer.TimeSW.ElapsedMilliseconds - (long) this.TimeConnectStart));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string Description = "DataArrival: " + ex.Message;
        this.send_ErrorEvent(ref Description);
        ProjectData.ClearProjectError();
        return;
      }
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(SocketNET.GlobalOBJ, (Type) null, "InvokeRequired", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
      {
        NewLateBinding.LateCall(SocketNET.GlobalOBJ, (Type) null, "BeginInvoke", new object[2]
        {
          (object) new SocketNET.d_DataArrival(this.send_DataArrival_Safe),
          (object) new object[0]
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
      }
      else
      {
        SocketNET.DataArrivalEventHandler dataArrivalEvent = this.DataArrivalEvent;
        if (dataArrivalEvent == null)
          return;
        dataArrivalEvent(this.Index);
      }
    }

    private void send_ErrorEvent_Safe(ref string Description)
    {
      SocketNET.ErrorEventEventHandler errorEventEvent = this.ErrorEventEvent;
      if (errorEventEvent == null)
        return;
      errorEventEvent(this.Index, ref Description);
    }

    private void send_ErrorEvent(ref string Description)
    {
      try
      {
        if (!this.IsBusy)
          return;
        this.IsBusy = false;
        if (!Information.IsNothing((object) this.tmrTimeOut))
        {
          this.tmrTimeOut.Stop();
          this.tmrTimeOut.Elapsed -= new ElapsedEventHandler(this.tmrTimeOut_Elapsed);
          this.tmrTimeOut.Dispose();
          this.tmrTimeOut = (System.Timers.Timer) null;
        }
        if (!Information.IsNothing((object) this.SocketConnectedCounter))
          checked { --this.SocketConnectedCounter.Counter; }
        if (!Information.IsNothing((object) this._State))
        {
          this._State._receiveBuffer = (byte[]) null;
          if (!Information.IsNothing((object) this._State._TcpClient))
          {
            if (this._State._TcpClient.Client.Connected)
            {
              this._State._TcpClient.Client.Shutdown(SocketShutdown.Both);
              this._State._TcpClient.Client.Disconnect(false);
            }
            this._State._TcpClient.Close();
            this._State._TcpClient = (TcpClient) null;
          }
          if (!Information.IsNothing((object) this._State._memBuffer))
          {
            this._State._memBuffer.Close();
            this._State._memBuffer = (MemoryStream) null;
          }
          if (!Information.IsNothing((object) this._State.ntStream))
          {
            this._State.ntStream.Close();
            this._State.ntStream = (Stream) null;
          }
          this.TimeConnectStart = checked ((int) (SocketTimer.TimeSW.ElapsedMilliseconds - (long) this.TimeConnectStart));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        Description = Description + "\r\nErrorEvent: " + exception.Message;
        ProjectData.ClearProjectError();
      }
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(SocketNET.GlobalOBJ, (Type) null, "InvokeRequired", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
      {
        NewLateBinding.LateCall(SocketNET.GlobalOBJ, (Type) null, "BeginInvoke", new object[2]
        {
          (object) new SocketNET.d_ErrorEvent(this.send_ErrorEvent_Safe),
          (object) new object[1]{ (object) Description }
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
      }
      else
      {
        SocketNET.ErrorEventEventHandler errorEventEvent = this.ErrorEventEvent;
        if (errorEventEvent == null)
          return;
        errorEventEvent(this.Index, ref Description);
      }
    }

    private void send_DebugEvent_Safe(ref object Value)
    {
      SocketNET.DebugEventEventHandler debugEventEvent = this.DebugEventEvent;
      if (debugEventEvent == null)
        return;
      debugEventEvent(this.Index, ref Value);
    }

    private void send_DebugEvent(ref object Value)
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(SocketNET.GlobalOBJ, (Type) null, "InvokeRequired", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
      {
        NewLateBinding.LateCall(SocketNET.GlobalOBJ, (Type) null, "BeginInvoke", new object[2]
        {
          (object) new SocketNET.d_DebugEvent(this.send_DebugEvent_Safe),
          (object) new object[1]
          {
            RuntimeHelpers.GetObjectValue(Value)
          }
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
      }
      else
      {
        SocketNET.DebugEventEventHandler debugEventEvent = this.DebugEventEvent;
        if (debugEventEvent == null)
          return;
        debugEventEvent(this.Index, ref Value);
      }
    }

    private enum connectionFromServer
    {
      Unknown = 1,
      Close = 2,
      KeepAlive = 3,
    }

    internal delegate void DataArrivalEventHandler(int Index);

    internal delegate void ErrorEventEventHandler(int Index, ref string Description);

    internal delegate void DebugEventEventHandler(int Index, ref object Value);

    public struct myConnectOption
    {
      public string URL;
      public myCookies Cookies;
      public string Referer;
      public string PostData;
      public myProxy Proxy;
      public short NumUserAgent;
      public string X_Forwarded_For;
      public string ContentType;
      public Encoding CodePage;
      public string Headers_Add;
    }

    public struct meOptionsSet
    {
      internal string ProtocolVer;
      internal string Accept;
      internal string Accept_Language;
      internal string Accept_Charset;
      internal string Accept_Encoding;
      internal bool Keep_Alive;
      internal int TimeOut;
      internal int SizePacket;
      internal bool NotUse_Accept;
    }

    private class myState
    {
      protected internal string _Host;
      protected internal int _Port;
      protected internal string PacketHEAD;
      protected internal string PacketBODY;
      protected internal byte[] PacketBODY_B;
      protected internal StringBuilder PacketTo;
      protected internal myCookies CookiesFrom;
      protected internal bool Resp_Chunked;
      protected internal bool Resp_Gzip;
      protected internal bool Resp_ContentLenght;
      protected internal string Resp_Location;
      protected internal SocketNET.connectionFromServer Resp_Connection;
      protected internal int ContentLenght;
      protected internal short AuthenticationStep;
      protected internal Stream ntStream;
      protected internal MemoryStream _memBuffer;
      protected internal byte[] _receiveBuffer;
      protected internal IPHostEntry _IPHostEntry;
      protected internal TcpClient _TcpClient;
      protected internal bool SSL;

      public myState()
      {
        this._Port = 80;
        this._memBuffer = new MemoryStream();
        this.SSL = false;
      }
    }

    private delegate void d_DataArrival();

    private delegate void d_ErrorEvent(ref string Description);

    private delegate void d_DebugEvent(ref object Value);
  }
}
