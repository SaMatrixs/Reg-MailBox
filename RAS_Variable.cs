// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.RAS_Variable
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class RAS_Variable
  {
    public static RAS_Variable.meVPN[] VPN;
    public static RAS_Variable.clsTXT_VPN FN_VPN;

    public struct meVPN
    {
      public string PhoneNumber;
      public string Login;
      public string Password;
    }

    public delegate void dTXTinThread_VPN(ref string sText);

    public delegate void dLBLinThread(ref string sText);

    public class clsTXT_VPN
    {
      private object _ref;

      public clsTXT_VPN(Form @ref)
      {
        this._ref = (object) MyProject.Forms.frmMain_RasDialex;
      }

      public void TXT(ref string sText)
      {
        object Instance = this._ref;
        // ISSUE: variable of the null type
        __Null local1 = null;
        string MemberName = nameof (TXT);
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

      public void LBL(ref string sText)
      {
        object Instance = this._ref;
        // ISSUE: variable of the null type
        __Null local1 = null;
        string MemberName = nameof (LBL);
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
