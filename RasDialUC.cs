// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.RasDialUC
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;

namespace MailRegUnicore
{
  public class RasDialUC
  {
    private Hashtable RASCONNSTATE_HT;
    private RasDialUC.RASDIALPARAMS MainOptions;
    private IntPtr MainHeader;
    private int PreviousStatus;
    private bool OptionsOK;
    public int ConnectionCount;
    public bool _CheckIP;
    public int WaitConnected;
    private Timer TimerStatus;
    private Timer TimerIP;
    private RasDialUC.myMonitorDisconnect MonitorDisconnect;
    private object GlobalOBJ;
    private const int RAS_MaxDeviceName = 128;
    private const int RAS_MaxDeviceType = 16;
    private Timer tmrMonitorConnected;
    private Timer tmrMonitorDisconnect;
    public short VPN_Reboot_Method;
    private RasDialUC.d_RasDialFunc1 del;

    public event RasDialUC.ErrorRASEventHandler ErrorRAS;

    public event RasDialUC.ConnectionStatusEventHandler ConnectionStatus;

    public event RasDialUC.ConnectedEventHandler Connected;

    public event RasDialUC.DisconnectedEventHandler Disconnected;

    public void Unload()
    {
      if (!Information.IsNothing((object) this.TimerStatus))
      {
        this.TimerStatus.Stop();
        this.TimerStatus = (Timer) null;
      }
      if (Information.IsNothing((object) this.TimerIP))
        return;
      this.TimerIP.Stop();
      this.TimerIP = (Timer) null;
    }

    private void send_ErrorRAS(int ErrNumber, string Message)
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.GlobalOBJ, (Type) null, "InvokeRequired", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
      {
        NewLateBinding.LateCall(this.GlobalOBJ, (Type) null, "BeginInvoke", new object[2]
        {
          (object) new RasDialUC.d_ErrorRAS(this.send_ErrorRAS),
          (object) new object[2]
          {
            (object) ErrNumber,
            (object) Message
          }
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
      }
      else
      {
        if (!Information.IsNothing((object) this.tmrMonitorDisconnect))
        {
          this.tmrMonitorDisconnect.Stop();
          this.tmrMonitorDisconnect.Elapsed -= new ElapsedEventHandler(this.tmrMonitorDisconnect_Elapsed);
          this.tmrMonitorDisconnect = (Timer) null;
        }
        if (!Information.IsNothing((object) this.tmrMonitorConnected))
        {
          this.tmrMonitorConnected.Stop();
          this.tmrMonitorConnected.Elapsed -= new ElapsedEventHandler(this.tmrMonitorConnected_Elapsed);
          this.tmrMonitorConnected = (Timer) null;
        }
        RasDialUC.ErrorRASEventHandler errorRasEvent = this.ErrorRASEvent;
        if (errorRasEvent == null)
          return;
        errorRasEvent(ErrNumber, Message);
      }
    }

    private void send_ConnectionStatus(int StatusNumber, string Message)
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.GlobalOBJ, (Type) null, "InvokeRequired", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
      {
        NewLateBinding.LateCall(this.GlobalOBJ, (Type) null, "BeginInvoke", new object[2]
        {
          (object) new RasDialUC.d_ConnectionStatus(this.send_ConnectionStatus),
          (object) new object[2]
          {
            (object) StatusNumber,
            (object) Message
          }
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
      }
      else
      {
        RasDialUC.ConnectionStatusEventHandler connectionStatusEvent = this.ConnectionStatusEvent;
        if (connectionStatusEvent == null)
          return;
        connectionStatusEvent(StatusNumber, Message);
      }
    }

    private void send_Connected()
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.GlobalOBJ, (Type) null, "InvokeRequired", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
      {
        NewLateBinding.LateCall(this.GlobalOBJ, (Type) null, "BeginInvoke", new object[2]
        {
          (object) new RasDialUC.d_Connected(this.send_Connected),
          (object) new object[0]
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
      }
      else
      {
        if (!Information.IsNothing((object) this.tmrMonitorConnected))
        {
          this.tmrMonitorConnected.Stop();
          this.tmrMonitorConnected.Elapsed -= new ElapsedEventHandler(this.tmrMonitorConnected_Elapsed);
          this.tmrMonitorConnected = (Timer) null;
        }
        this.MonitorDisconnect = RasDialUC.myMonitorDisconnect.ConnectOK;
        RasDialUC.ConnectedEventHandler connectedEvent = this.ConnectedEvent;
        if (connectedEvent == null)
          return;
        connectedEvent();
      }
    }

    private void send_Disconnected()
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.GlobalOBJ, (Type) null, "InvokeRequired", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
      {
        NewLateBinding.LateCall(this.GlobalOBJ, (Type) null, "BeginInvoke", new object[2]
        {
          (object) new RasDialUC.d_Disconnected(this.send_Disconnected),
          (object) new object[0]
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
      }
      else
      {
        if (!Information.IsNothing((object) this.tmrMonitorDisconnect))
        {
          this.tmrMonitorDisconnect.Stop();
          this.tmrMonitorDisconnect.Dispose();
          this.tmrMonitorDisconnect = (Timer) null;
        }
        this.MonitorDisconnect = RasDialUC.myMonitorDisconnect.DisconnectOK;
        RasDialUC.DisconnectedEventHandler disconnectedEvent = this.DisconnectedEvent;
        if (disconnectedEvent == null)
          return;
        disconnectedEvent();
      }
    }

    [DllImport("RasApi32.dll", CharSet = CharSet.Unicode)]
    private static extern int RasDial(IntPtr lprasDialExtensions, string lpszPhoneBook, ref RasDialUC.RASDIALPARAMS lpRasDialParams, uint dwNotifierType, Delegate hwndNotifier, ref IntPtr lphRasConn);

    [DllImport("rasapi32.dll", CharSet = CharSet.Unicode)]
    private static extern int RasGetEntryDialParams(string lpszPhonebook, [In, Out] ref RasDialUC.RASDIALPARAMS lprasdialparams, out bool lpfPassword);

    [DllImport("rasapi32.dll", CharSet = CharSet.Unicode)]
    private static extern int RasEnumConnections([In, Out] RasDialUC.RASCONN[] lpRasconn, ref int lpcb, ref int lpcConnections);

    [DllImport("rasapi32.dll", CharSet = CharSet.Auto)]
    private static extern int RasHangUp(IntPtr hRasConn);

    [DllImport("rasapi32.dll", CharSet = CharSet.Unicode)]
    private static extern int RasGetConnectStatus(IntPtr hRasConn, [In, Out] ref RasDialUC.RASCONNSTATUS lpRasConnStatus);

    [DllImport("rasapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern int RasEnumDevices([MarshalAs(UnmanagedType.LPArray), In, Out] RasDialUC.RASDEVINFO[] TLPRASDEVINFOA, ref int lpcb, ref int lpDevices);

    public RasDialUC(ref object setGlobalOBJ)
    {
      this.RASCONNSTATE_HT = new Hashtable();
      this.MainHeader = IntPtr.Zero;
      this.PreviousStatus = -1;
      this.OptionsOK = false;
      this.ConnectionCount = 0;
      this._CheckIP = false;
      this.tmrMonitorConnected = (Timer) null;
      this.tmrMonitorDisconnect = (Timer) null;
      this.VPN_Reboot_Method = (short) 0;
      this.del = new RasDialUC.d_RasDialFunc1(this.RasDialFunc1);
      this.RASCONNSTATE_HT.Add((object) 0, (object) "Port is about to be opened.");
      this.RASCONNSTATE_HT.Add((object) 1, (object) "Port has been opened.");
      this.RASCONNSTATE_HT.Add((object) 2, (object) "A device is about to be connected.");
      this.RASCONNSTATE_HT.Add((object) 3, (object) "A device has connected successfully.");
      this.RASCONNSTATE_HT.Add((object) 4, (object) "All devices in the device chain have successfully connected.");
      this.RASCONNSTATE_HT.Add((object) 19, (object) "User authentication is being initiated or retried.");
      this.RASCONNSTATE_HT.Add((object) 5, (object) "The authentication process is starting.");
      this.RASCONNSTATE_HT.Add((object) 6, (object) "An authentication event has occurred.");
      this.RASCONNSTATE_HT.Add((object) 7, (object) "The client has requested another validation attempt with a new user name/password/domain.");
      this.RASCONNSTATE_HT.Add((object) 8, (object) "The remote access server has requested a callback number.");
      this.RASCONNSTATE_HT.Add((object) 9, (object) "The client has requested to change the password on the account.");
      this.RASCONNSTATE_HT.Add((object) 10, (object) "The projection phase is starting.");
      this.RASCONNSTATE_HT.Add((object) 11, (object) "The link-speed calculation phase is starting.");
      this.RASCONNSTATE_HT.Add((object) 12, (object) "An authentication request is being acknowledged.");
      this.RASCONNSTATE_HT.Add((object) 13, (object) "Reauthentication (cint(after callback) is starting.");
      this.RASCONNSTATE_HT.Add((object) 14, (object) "The client has successfully completed authentication.");
      this.RASCONNSTATE_HT.Add((object) 15, (object) "The line is about to disconnect in preparation for callback.");
      this.RASCONNSTATE_HT.Add((object) 17, (object) "The client is waiting for an incoming call from the remote access server.");
      this.RASCONNSTATE_HT.Add((object) 20, (object) "Client has been called back and is about to resume authentication.");
      this.RASCONNSTATE_HT.Add((object) 16, (object) "The client is delaying in order to give the modem time to reset itself in preparation for callback.");
      this.RASCONNSTATE_HT.Add((object) 18, (object) "Projection result information is available.");
      this.RASCONNSTATE_HT.Add((object) 24, (object) "Apply setting.");
      this.RASCONNSTATE_HT.Add((object) 21, (object) "Client is logging on to the network.");
      this.RASCONNSTATE_HT.Add((object) 4096, (object) "Terminal state supported by RASPHONE.EXE.");
      this.RASCONNSTATE_HT.Add((object) 4097, (object) "Retry authentication state supported by RASPHONE.EXE.");
      this.RASCONNSTATE_HT.Add((object) 4098, (object) "Callback state supported by RASPHONE.EXE.");
      this.RASCONNSTATE_HT.Add((object) 4099, (object) "Change password state supported by RASPHONE.EXE.");
      this.RASCONNSTATE_HT.Add((object) 8192, (object) "Connected.");
      this.RASCONNSTATE_HT.Add((object) 8193, (object) "Disconnected.");
      this.RASCONNSTATE_HT.Add((object) 22, (object) "Subentry has been connected during the dialing process.");
      this.RASCONNSTATE_HT.Add((object) 23, (object) "Subentry has been disconnected during the dialing process.");
      this.GlobalOBJ = RuntimeHelpers.GetObjectValue(setGlobalOBJ);
    }

    private void ChangeDisconnect()
    {
      this.PreviousStatus = 0;
      this.MainHeader = IntPtr.Zero;
      this.send_ConnectionStatus(8193, Conversions.ToString(this.RASCONNSTATE_HT[(object) 8193]));
      this.send_Disconnected();
    }

    private void TimerStatus_Tick(object sender, ElapsedEventArgs e)
    {
      RasDialUC.RASCONN[] lpRasconn = new RasDialUC.RASCONN[1];
      int lpcb = Marshal.SizeOf(typeof (RasDialUC.RASCONN));
      lpRasconn[0].dwSize = checked ((uint) lpcb);
      int num1;
      while (true)
      {
        num1 = RasDialUC.RasEnumConnections(lpRasconn, ref lpcb, ref this.ConnectionCount);
        switch (num1)
        {
          case 0:
            goto label_9;
          case 603:
            lpRasconn = new RasDialUC.RASCONN[checked (this.ConnectionCount - 1 + 1)];
            int num2 = Marshal.SizeOf(typeof (RasDialUC.RASCONN));
            int num3 = 0;
            int num4 = checked (this.ConnectionCount - 1);
            int index = num3;
            while (index <= num4)
            {
              lpRasconn[index].dwSize = checked ((uint) num2);
              checked { ++index; }
            }
            lpcb = checked (num2 * this.ConnectionCount);
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      int num5 = checked (num1 + 60000);
      if (this.PreviousStatus != 8192 && this.PreviousStatus != -1)
        return;
      this.ChangeDisconnect();
      return;
label_9:
      if (this.ConnectionCount == 0)
      {
        if (this.PreviousStatus != 8192 && this.PreviousStatus != -1)
          return;
        this.ChangeDisconnect();
      }
      else
      {
        int num2 = 0;
        int num3 = checked (this.ConnectionCount - 1);
        int index = num2;
        while (index <= num3 && Operators.CompareString(lpRasconn[index].szEntryName, this.MainOptions.EntryName, false) != 0)
          checked { ++index; }
        if (index == this.ConnectionCount)
        {
          if (this.PreviousStatus != 8192 && this.PreviousStatus != -1)
            return;
          this.ChangeDisconnect();
        }
        else
        {
          RasDialUC.RASCONNSTATUS lpRasConnStatus = new RasDialUC.RASCONNSTATUS();
          lpRasConnStatus.dwSize = Marshal.SizeOf(typeof (RasDialUC.RASCONNSTATUS));
          RasDialUC.RasGetConnectStatus(lpRasconn[index].hRasConn, out lpRasConnStatus);
          if (lpRasConnStatus.rasconnstate == (RasDialUC.RASCONNSTATE) this.PreviousStatus)
            return;
          switch (lpRasConnStatus.rasconnstate)
          {
            case RasDialUC.RASCONNSTATE.RASCS_Connected:
              this.PreviousStatus = (int) lpRasConnStatus.rasconnstate;
              this.send_Connected();
              break;
            case RasDialUC.RASCONNSTATE.RASCS_Disconnected:
              this.ChangeDisconnect();
              break;
          }
        }
      }
    }

    public void SetOptions(string EntryName, string PhoneNumber, string UserName, string Password)
    {
      this.OptionsOK = false;
      if (EntryName.Length == 0)
        this.ErrorSend(100000);
      else if (PhoneNumber.Length == 0)
        this.ErrorSend(100010);
      else if (UserName.Length == 0)
        this.ErrorSend(100020);
      else if (Password.Length == 0)
      {
        this.ErrorSend(100030);
      }
      else
      {
        this.OptionsOK = true;
        this.MainOptions.EntryName = EntryName;
        this.MainOptions.PhoneNumber = PhoneNumber;
        this.MainOptions.UserName = UserName;
        this.MainOptions.Password = Password;
        this.MainOptions.dwSize = checked ((uint) Marshal.SizeOf((object) this.MainOptions));
        if (this.TimerStatus != null)
          return;
        this.TimerStatus = new Timer();
        this.TimerStatus.Elapsed += new ElapsedEventHandler(this.TimerStatus_Tick);
        this.TimerStatus.AutoReset = true;
        this.TimerStatus.Interval = 100.0;
        this.TimerStatus.Start();
      }
    }

    private void tmrMonitorConnected_Elapsed(object sender, ElapsedEventArgs e)
    {
      this.tmrMonitorConnected.Stop();
      RAS_Variable.clsTXT_VPN fnVpn = RAS_Variable.FN_VPN;
      string sText = "Connected - failed! Retrip.";
      fnVpn.TXT(ref sText);
      this.Connect();
    }

    public void Connect()
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.GlobalOBJ, (Type) null, "InvokeRequired", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
        NewLateBinding.LateCall(this.GlobalOBJ, (Type) null, "BeginInvoke", new object[2]
        {
          (object) new RasDialUC.d_Connect(this.Connect),
          (object) new object[0]
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
      else if (this.GetStatus() == 8192)
      {
        RAS_Variable.clsTXT_VPN fnVpn = RAS_Variable.FN_VPN;
        string sText = "You are already connected.";
        fnVpn.TXT(ref sText);
      }
      else
      {
        if (!Information.IsNothing((object) this.tmrMonitorConnected))
        {
          this.tmrMonitorConnected.Stop();
          this.tmrMonitorConnected.Elapsed -= new ElapsedEventHandler(this.tmrMonitorConnected_Elapsed);
          this.tmrMonitorConnected = (Timer) null;
        }
        if (MyProject.Forms.frmMain_RasDialex.AutoConnectRasDial)
        {
          this.tmrMonitorConnected = new Timer();
          this.tmrMonitorConnected.AutoReset = false;
          this.tmrMonitorConnected.Elapsed += new ElapsedEventHandler(this.tmrMonitorConnected_Elapsed);
          this.tmrMonitorConnected.Interval = (double) this.WaitConnected;
          this.tmrMonitorConnected.Start();
        }
        switch (this.VPN_Reboot_Method)
        {
          case 0:
            if (!this.OptionsOK)
            {
              this.ErrorSend(100040);
              break;
            }
            IntPtr lprasDialExtensions;
            IntPtr lphRasConn;
            int num = RasDialUC.RasDial(lprasDialExtensions, (string) null, ref this.MainOptions, 1U, (Delegate) this.del, ref lphRasConn);
            if (num != 0)
            {
              this.ErrorSend(checked (num + 50000));
              break;
            }
            this.MainHeader = lphRasConn;
            break;
          case 1:
            try
            {
              MyProject.Forms.frmMain_RasDialex.lblMon.Text = "Hard Connect";
              string str1 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\rasdial.exe";
              Process process = new Process();
              process.StartInfo.FileName = str1;
              string str2 = Strings.Trim(MyProject.Forms.frmMain_RasDialex.txtEntryName.Text) + " " + Strings.Trim(MyProject.Forms.frmMain_RasDialex.txtUserName.Text) + " " + Strings.Trim(MyProject.Forms.frmMain_RasDialex.txtPassword.Text) + " /PHONE:" + Strings.Trim(MyProject.Forms.frmMain_RasDialex.txtPhoneNumber.Text);
              process.StartInfo.Arguments = str2;
              process.StartInfo.WindowStyle = !MyProject.Forms.frmMain_RasDialex.VisibleCMD ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal;
              process.Start();
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = str1 + " " + str2;
              fn.TXT(ref sText);
              break;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = "RasDialEx Error: " + exception.Message;
              fn.TXT(ref sText);
              this.ErrorSend(100041);
              ProjectData.ClearProjectError();
              break;
            }
          case 2:
            try
            {
              string externalProgram = MyProject.Forms.frmMain_RasDialex.ExternalProgram;
              new Process()
              {
                StartInfo = {
                  FileName = externalProgram,
                  Arguments = MyProject.Forms.frmMain_RasDialex.ExternalProgram_ParamConnect,
                  WindowStyle = (!MyProject.Forms.frmMain_RasDialex.VisibleCMD ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal)
                }
              }.Start();
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = externalProgram + " " + MyProject.Forms.frmMain_RasDialex.ExternalProgram_ParamConnect;
              fn.TXT(ref sText);
              break;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = "RasDialEx Error: " + exception.Message;
              fn.TXT(ref sText);
              this.ErrorSend(100041);
              ProjectData.ClearProjectError();
              break;
            }
        }
      }
    }

    private void tmrMonitorDisconnect_Elapsed(object sender, ElapsedEventArgs e)
    {
      this.tmrMonitorDisconnect.Stop();
      if (this.MonitorDisconnect != RasDialUC.myMonitorDisconnect.StartDisconnect)
        return;
      RAS_Variable.clsTXT_VPN fnVpn = RAS_Variable.FN_VPN;
      string sText = "Disconnect - failed! Retrip.";
      fnVpn.TXT(ref sText);
      this.Close();
    }

    public void Close()
    {
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.GlobalOBJ, (Type) null, "InvokeRequired", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) true, false))
      {
        NewLateBinding.LateCall(this.GlobalOBJ, (Type) null, "BeginInvoke", new object[2]
        {
          (object) new RasDialUC.d_Close(this.Close),
          (object) new object[0]
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
      }
      else
      {
        this.MonitorDisconnect = RasDialUC.myMonitorDisconnect.StartDisconnect;
        if (!Information.IsNothing((object) this.tmrMonitorDisconnect))
        {
          this.tmrMonitorDisconnect.Stop();
          this.tmrMonitorDisconnect.Elapsed -= new ElapsedEventHandler(this.tmrMonitorDisconnect_Elapsed);
          this.tmrMonitorDisconnect = (Timer) null;
        }
        if (MyProject.Forms.frmMain_RasDialex.AutoConnectRasDial)
        {
          this.tmrMonitorDisconnect = new Timer();
          this.tmrMonitorDisconnect.AutoReset = false;
          this.tmrMonitorDisconnect.Elapsed += new ElapsedEventHandler(this.tmrMonitorDisconnect_Elapsed);
          this.tmrMonitorDisconnect.Interval = 15000.0;
          this.tmrMonitorDisconnect.Start();
        }
        switch (this.VPN_Reboot_Method)
        {
          case 0:
            if (!this.OptionsOK)
            {
              this.ErrorSend(100040);
              break;
            }
            if (this.GetStatus() == 0)
            {
              this.send_Disconnected();
              break;
            }
            if (this.MainHeader == IntPtr.Zero)
            {
              this.send_Disconnected();
              break;
            }
            int num = RasDialUC.RasHangUp(this.MainHeader);
            if (num == 0)
              break;
            this.ErrorSend(checked (num + 70000));
            break;
          case 1:
            try
            {
              string str1 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\rasdial.exe";
              Process process = new Process();
              process.StartInfo.FileName = str1;
              string str2 = Strings.Trim(MyProject.Forms.frmMain_RasDialex.txtEntryName.Text) + " /disconnect";
              process.StartInfo.Arguments = str2;
              process.StartInfo.WindowStyle = !MyProject.Forms.frmMain_RasDialex.VisibleCMD ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal;
              process.Start();
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = str1 + " " + str2;
              fn.TXT(ref sText);
              break;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = "RasDialEx Error: " + exception.Message;
              fn.TXT(ref sText);
              ProjectData.ClearProjectError();
              break;
            }
          case 2:
            try
            {
              string externalProgram = MyProject.Forms.frmMain_RasDialex.ExternalProgram;
              new Process()
              {
                StartInfo = {
                  FileName = externalProgram,
                  Arguments = MyProject.Forms.frmMain_RasDialex.ExternalProgram_ParamDisconnect,
                  WindowStyle = (!MyProject.Forms.frmMain_RasDialex.VisibleCMD ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal)
                }
              }.Start();
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = externalProgram + " " + MyProject.Forms.frmMain_RasDialex.ExternalProgram_ParamDisconnect;
              fn.TXT(ref sText);
              break;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = "RasDialEx Error: " + exception.Message;
              fn.TXT(ref sText);
              ProjectData.ClearProjectError();
              break;
            }
        }
      }
    }

    private void RasDialFunc1(int hRasCon, int unMsg, int dwRascOnState, int dwError, int dwExtendedError)
    {
      if (this.PreviousStatus != dwRascOnState)
      {
        this.PreviousStatus = dwRascOnState;
        if (dwRascOnState == 8192)
          this.send_Connected();
      }
      if (dwError > 0)
        this.ErrorSend(checked (dwError + 30000));
      else if (dwExtendedError > 0)
      {
        this.ErrorSend(checked (dwError + 40000));
      }
      else
      {
        string Message = Conversions.ToString(this.RASCONNSTATE_HT[(object) dwRascOnState]) ?? "Unknown Connect status";
        this.send_ConnectionStatus(dwRascOnState, Message);
      }
    }

    public int GetStatus()
    {
      RasDialUC.RASCONN[] lpRasconn = new RasDialUC.RASCONN[1];
      int lpcb = Marshal.SizeOf(typeof (RasDialUC.RASCONN));
      int lpcConnections = 0;
      lpRasconn[0].dwSize = checked ((uint) lpcb);
      while (true)
      {
        int num1 = RasDialUC.RasEnumConnections(lpRasconn, ref lpcb, ref lpcConnections);
        if (lpcConnections != 0)
        {
          switch (num1)
          {
            case 0:
              goto label_8;
            case 603:
              lpRasconn = new RasDialUC.RASCONN[checked (lpcConnections - 1 + 1)];
              int num2 = Marshal.SizeOf(typeof (RasDialUC.RASCONN));
              int num3 = 0;
              int num4 = checked (lpcConnections - 1);
              int index = num3;
              while (index <= num4)
              {
                lpRasconn[index].dwSize = checked ((uint) num2);
                checked { ++index; }
              }
              lpcb = checked (num2 * lpcConnections);
              continue;
            default:
              goto label_7;
          }
        }
        else
          goto label_14;
      }
label_7:
      lpcConnections = 0;
      goto label_14;
label_8:
      int num5 = 0;
      int num6 = checked (lpcConnections - 1);
      int index1 = num5;
      while (index1 <= num6 && Operators.CompareString(lpRasconn[index1].szEntryName, this.MainOptions.EntryName, false) != 0)
        checked { ++index1; }
      if (index1 == lpcConnections)
      {
        lpcConnections = 0;
      }
      else
      {
        this.MainHeader = lpRasconn[index1].hRasConn;
        RasDialUC.RASCONNSTATUS lpRasConnStatus = new RasDialUC.RASCONNSTATUS();
        lpRasConnStatus.dwSize = Marshal.SizeOf(typeof (RasDialUC.RASCONNSTATUS));
        RasDialUC.RasGetConnectStatus(lpRasconn[index1].hRasConn, out lpRasConnStatus);
        lpcConnections = (int) lpRasConnStatus.rasconnstate;
      }
label_14:
      return lpcConnections;
    }

    public string[] GetIP()
    {
      string[] strArray;
      try
      {
        WebClient webClient = new WebClient();
        webClient.Encoding = Encoding.UTF8;
        string str1 = "";
        string str2 = "";
        string str3 = "";
        string str4 = "";
        string str5;
        try
        {
          str5 = webClient.DownloadString("http://2ip.ru/");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          str1 = "Error when reading IP address.";
          ProjectData.ClearProjectError();
          goto label_11;
        }
        if (str5.Length != 0)
        {
          int num1 = Strings.InStr(str5, "clip.setText( '", CompareMethod.Binary);
          if (num1 != 0)
          {
            int Start1 = checked (num1 + 15);
            int Start2 = Strings.InStr(Start1, str5, "'", CompareMethod.Binary);
            str1 = Strings.Mid(str5, Start1, checked (Start2 - Start1));
            int num2 = Strings.InStr(Start2, str5, "/flags/", CompareMethod.Binary);
            if (num2 != 0)
            {
              int Start3 = checked (num2 + 7);
              int Start4 = Strings.InStr(Start3, str5, "\"", CompareMethod.Binary);
              str2 = Strings.Mid(str5, Start3, checked (Start4 - Start3));
              int num3 = Strings.InStr(Start4, str5, "/geoip/", CompareMethod.Binary);
              if (num3 != 0)
              {
                int num4 = Strings.InStr(checked (num3 + 7), str5, ">", CompareMethod.Binary);
                if (num4 != 0)
                {
                  int Start5 = checked (num4 + 1);
                  int Start6 = Strings.InStr(Start5, str5, "<", CompareMethod.Binary);
                  str3 = Strings.Mid(str5, Start5, checked (Start6 - Start5));
                  int num5 = Strings.InStr(Start6, str5, "<a href", CompareMethod.Binary);
                  if (num5 != 0)
                  {
                    int num6 = Strings.InStr(checked (num5 + 7), str5, ">", CompareMethod.Binary);
                    if (num6 != 0)
                    {
                      int Start7 = checked (num6 + 1);
                      int num7 = Strings.InStr(Start7, str5, "<", CompareMethod.Binary);
                      str4 = Strings.Trim(Strings.Mid(str5, Start7, checked (num7 - Start7)).Replace("\t", "").Replace("\r", "").Replace("\n", ""));
                    }
                  }
                }
              }
            }
          }
        }
label_11:
        strArray = new string[4]{ str1, str2, str3, str4 };
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        strArray = (string[]) null;
        ProjectData.ClearProjectError();
      }
      return strArray;
    }

    private void ErrorSend(int ErrorNumber)
    {
      int num = ErrorNumber;
      string Message = num != 100000 ? (num != 100010 ? (num != 100020 ? (num != 100030 ? (num != 100040 ? (num < 70000 ? (num < 60000 ? (num < 50000 ? (num < 40000 ? (num < 30000 ? "Unknown" : "dwError") : "dwExtendedError") : "Function connect rtn=" + Conversions.ToString(checked (ErrorNumber - 50000))) : "Timer Status rtn=" + Conversions.ToString(checked (ErrorNumber - 60000))) : "Error in close rtn=" + Conversions.ToString(checked (ErrorNumber - 70000))) : "Нет данных для начала работы.") : "Ввод параметров. Не задано пароль <Password>.") : "Ввод параметров. Не указан логин <UserName>.") : "Ввод параметров. Не задано направление коннекта HOST/IP <PhoneNumber>.") : "Ввод параметров. Не задано название соединения <EntryName>.";
      this.send_ErrorRAS(ErrorNumber, Message);
    }

    private enum myMonitorDisconnect
    {
      StartDisconnect = 1,
      DisconnectOK = 2,
      ConnectOK = 3,
    }

    public delegate void ErrorRASEventHandler(int ErrNumber, string Message);

    public delegate void ConnectionStatusEventHandler(int StatusNumber, string Message);

    public delegate void ConnectedEventHandler();

    public delegate void DisconnectedEventHandler();

    private delegate void d_ErrorRAS(int ErrNumber, string Message);

    private delegate void d_ConnectionStatus(int StatusNumber, string Message);

    private delegate void d_Connected();

    private delegate void d_Disconnected();

    private delegate void d_Close();

    private delegate void d_Connect();

    private enum RASCONNSTATE
    {
      RASCS_OpenPort = 0,
      RASCS_PortOpened = 1,
      RASCS_ConnectDevice = 2,
      RASCS_DeviceConnected = 3,
      RASCS_AllDevicesConnected = 4,
      RASCS_Authenticate = 5,
      RASCS_AuthNotify = 6,
      RASCS_AuthRetry = 7,
      RASCS_AuthCallback = 8,
      RASCS_AuthChangePassword = 9,
      RASCS_AuthProject = 10, // 0x0000000A
      RASCS_AuthLinkSpeed = 11, // 0x0000000B
      RASCS_AuthAck = 12, // 0x0000000C
      RASCS_ReAuthenticate = 13, // 0x0000000D
      RASCS_Authenticated = 14, // 0x0000000E
      RASCS_PrepareForCallback = 15, // 0x0000000F
      RASCS_WaitForModemReset = 16, // 0x00000010
      RASCS_WaitForCallback = 17, // 0x00000011
      RASCS_Projected = 18, // 0x00000012
      RASCS_StartAuthentication = 19, // 0x00000013
      RASCS_CallbackComplete = 20, // 0x00000014
      RASCS_LogonNetwork = 21, // 0x00000015
      RASCS_SubEntryConnected = 22, // 0x00000016
      RASCS_SubEntryDisconnected = 23, // 0x00000017
      RASCS_ApplySettings = 24, // 0x00000018
      RASCS_Interactive = 4096, // 0x00001000
      RASCS_RetryAuthentication = 4097, // 0x00001001
      RASCS_CallbackSetByCaller = 4098, // 0x00001002
      RASCS_PasswordExpired = 4099, // 0x00001003
      RASCS_InvokeEapUI = 4100, // 0x00001004
      RASCS_Connected = 8192, // 0x00002000
      RASCS_Disconnected = 8193, // 0x00002001
    }

    private enum RASFieldSizeConstants
    {
      RAS_MaxDomain = 15, // 0x0000000F
      RAS_MaxDeviceType = 16, // 0x00000010
      RAS_MaxCallbackNumber = 128, // 0x00000080
      RAS_MaxDeviceName = 128, // 0x00000080
      RAS_MaxPhoneNumber = 128, // 0x00000080
      RAS_MaxEntryName = 256, // 0x00000100
      RAS_MaxPassword = 256, // 0x00000100
      RAS_MaxUserName = 256, // 0x00000100
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Auto)]
    private struct RASDIALPARAMS
    {
      public uint dwSize;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
      public string EntryName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
      public string PhoneNumber;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
      public string CallBackNumber;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
      public string UserName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
      public string Password;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
      public string Domain;
      public int dwSubEntry;
      public IntPtr dwCallBackID;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    private struct RASDIALEXTENSIONS
    {
      public int dwSize;
      public int dwfOptions;
      public int hwndParent;
      public int Reserved;
      public int Reserved1;
      public RasDialUC.RASEAPINFO RasEapINfo;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    private struct RASEAPINFO
    {
      public int dwSizeofEAPInfo;
      public int pbEapInfo;
    }

    private struct GUID
    {
      public uint Data1;
      public ushort Data2;
      public ushort Data3;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public byte[] data4;
    }

    private struct LUID
    {
      public int LowPart;
      public int HighPart;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    private struct RASCONN
    {
      public uint dwSize;
      public IntPtr hRasConn;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
      public string szEntryName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
      public string szDeviceType;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
      public string szDeviceName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
      public string szPhonebook;
      public uint dwSubEntry;
      public RasDialUC.GUID guidEntry;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    private struct RASCONNSTATUS
    {
      public int dwSize;
      public RasDialUC.RASCONNSTATE rasconnstate;
      public int dwError;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
      public string szDeviceType;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
      public string szDeviceName;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Auto)]
    private struct RASDEVINFO
    {
      public int dwSize;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
      public string szDeviceType;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
      public string szDeviceName;
    }

    private delegate void d_RasDialFunc1(int hRasCon, int unMsg, int dwRascOnState, int dwError, int dwExtendedError);
  }
}
