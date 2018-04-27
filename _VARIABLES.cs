// Decompiled with JetBrains decompiler
// Type: MailRegUnicore._VARIABLES
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class _VARIABLES
  {
    public static bool UseBannedProxy = false;
    public static DateTime EmptyDate = new DateTime();
    public static DateTime Time1970 = Conversions.ToDate("01.01.1970 00:00:01");
    public static bool DeBug = false;
    public static _VARIABLES.Action ActionCurrent = _VARIABLES.Action.RegMail;
    public static string Proxy_AC = string.Empty;
    public static StringBuilder TXT_SB = new StringBuilder();
    public static bool ProxyBlock_1_Is = false;
    public static bool ProxyBlock_2_Is = false;
    public static int ProxySpeed = 0;
    public static int DebugVar = 0;
    public static int ErrorCountInWork = 0;
    public static int DownloadMailCount = 0;
    public static bool DoWork_Reg = false;
    public static int NetBuffer = 24031976;
    public static int MethodGenLogin = 0;
    public static int MethodGenLoginDop = 0;
    public static bool[] OptionReport = new bool[9];
    public const int ProgramVer = 174;
    public static string[] BannedProxy;
    public static string ServiceNameAC;
    public static bool PauseConnect;
    public static int IntervalConnect;
    public static Stopwatch SW;
    public static mySocketConnectedCounter IsConnected;
    public static _VARIABLES.myVPN_MD VPN_MD;
    public static _VARIABLES.myWS_Data[] WS_Data;
    public static int[] ProxyBlock_1;
    public static int[] ProxyBlock_2;
    public static _VARIABLES.myDebug DebugOp;
    public static bool UseErrorCount;
    public static int ErrorCount;
    public static int DomainSelect;
    public static _VARIABLES.meMailService[] MailService;
    public static _VARIABLES.meMailInfo[] MailInfo;
    public static myProxy[] Proxy;
    public static string[] BD_Mail;
    public static _VARIABLES.MeOptions OP;
    public static AntiCaptchaNET.myOptionsAntigate OptionsAntigateProg;
    public static int ThreadWS;
    public static _VARIABLES.meCurThreadData[] CurThreadData;
    public static int Progress_MaxValue_Reg;
    public static int CountUserInfo;
    public static int[] Mirror;
    public static SocketNET WSupdate;
    public static _VARIABLES.myPlaySound PlaySound;
    public static SocketNET[] WS;
    public static AntiCaptchaNET AC_NET;
    public static string[] M_UserName;
    public static string[] M_UserLastName;
    public static string[] J_UserName;
    public static string[] J_UserLastName;

    public static string VER(int sProgVer = 174)
    {
      return Strings.Replace(Strings.Format((object) ((double) sProgVer / 100.0), "###.00"), ",", ".", 1, -1, CompareMethod.Binary);
    }

    public enum Action
    {
      RegMail,
      CheckMail_WebFace,
    }

    public struct myVPN_MD
    {
      public bool Use;
      public bool UseReg;
      public bool UseDownloadMail;
      public int DownloadMailCount;
      public int MailCount;
      public int RegisteredCount;
      public int RegCount;
      public bool StartWith1Account;
    }

    public struct myWS_Data
    {
      public string CaptchaText;
      public string CaptchaPic;
    }

    public struct myDebug
    {
      public bool SavePacket_RegError;
      public bool SaveLog;
      public bool FullDebug;
      public bool SaveBadIP;
      public bool FullSessionLog;
    }

    public struct meMailService
    {
      public string Name;
      public string[] domain;
      public int DomainCNT;
      public string[] SecretQuestion;
    }

    public struct meMailInfo
    {
      public string login;
      public string domain;
      public string password;
      public _VARIABLES.meRegUserData RegUserData;
      public short Registered;
      public int Proxy;
      public int MailAmount;
      public string DataCreateBox;
      public string comment;
      public short DomainID;
      public int ID;
    }

    public struct meRegUserData
    {
      public string Name;
      public string LastName;
      public string City;
      public string BirthDay;
      public string BirthMonth;
      public string BirthYear;
      public short Sex;
      public string ItsSecretQuestion;
      public string SecretQuestion;
      public string SecretAnswer;
    }

    public struct MeOptions
    {
      public bool AutoCAPTCHA;
      public short UsePoxy;
      public int SocketTimeOut;
      public int MethodConnect;
      public bool ViewResponse;
      public short HardCheck;
      public _VARIABLES.MeOptAutoCaptcha OpAC;
      public _VARIABLES.MeOptReg OpReg;
      public _VARIABLES.MeOptSaveList OpSaveList;
      public _VARIABLES.MeOptMail OptMail;
    }

    public struct MeOptAutoCaptcha
    {
      public string Key;
      public string HostOrIP;
      public bool ReportBadCaptcha;
      public bool ReportBadCaptchaFast;
      public int PauseError;
      public int PauseNoSlot;
      public int PauseGetBalance;
      public int TimeLimit;
      public int SoftID;
      public int PauseAfterSending;
      public int NextGetCaptcha;
      public int SocketTimeOut;
    }

    public struct MeOptReg
    {
      public bool LoginNotFree;
      public short ActionChoise;
      public short NumSelectAccount;
      public bool Reconnect;
      public bool AutoGenLogin;
      public int ReconnectPause;
      public bool ReconnectUnknownPacket;
    }

    public struct MeOptSaveList
    {
      public string SeparatorInLine;
      public string SeparatorLine;
      public int SaveToAll;
      public bool AppendFile;
      public bool SaveDomain;
      public bool SaveSecretAnswer;
      public bool SaveLastnameName;
    }

    public struct MeOptMail
    {
      public bool DeleteMail;
      public int SaveMailOneFile;
      public bool AppendMail;
    }

    public struct meCurThreadData
    {
      public byte CurUserAgent;
      public myCookies CookiesMail;
      public Bitmap BitmapBuffer;
      public string CaptchaRef_1;
      public string CaptchaRef_2;
      public string CaptchaRef_3;
      public string Referer;
      public string CurrentMailToReg;
      public string[] PostDataLine;
      public string[] PostDataVariable;
      public string[] FreeMailDomain;
      public DateTime StartRegistration;
      public _DataArrival_ID1.myQIP data_QIP;
      public _DataArrival_ID2.myMETAua data_METAua;
      public _DataArrival_ID0.myMAILru data_MAILru;
      public string SpareUrl_1;
      public string SpareUrl_2;
      public StringBuilder SessionLog;
    }

    public struct myWebVar
    {
      public string Name;
      public string Value;
    }

    public struct myPlaySound
    {
      public bool Use;
      public string[] Path;
      public bool[] Play;
    }
  }
}
