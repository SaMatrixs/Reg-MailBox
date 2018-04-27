// Decompiled with JetBrains decompiler
// Type: MailRegUnicore._INI
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class _INI
  {
    [DllImport("kernel32", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int WritePrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

    [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetPrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

    public static void RegCreateSubkey()
    {
      Registry.CurrentUser.CreateSubKey("Software\\Mailbox@Reg").Close();
    }

    public static void RegSave(string sKey, string sValue)
    {
      Registry.CurrentUser.OpenSubKey("Software\\Mailbox@Reg", true).SetValue(sKey, (object) sValue);
    }

    public static int RegLoad(string sKey)
    {
      return Conversions.ToInteger(Registry.CurrentUser.OpenSubKey("Software\\Mailbox@Reg").GetValue(sKey));
    }

    public static void SaveINI(string sSection, string sKey, string sValue)
    {
      string lpFileName = Application.StartupPath + "\\data\\option.ini";
      if (Operators.CompareString(sValue, "", false) == 0)
        sValue = (string) null;
      _INI.WritePrivateProfileString(ref sSection, ref sKey, ref sValue, ref lpFileName);
    }

    public static string LoadINI(string sSection, string sKey)
    {
      string lpFileName = Application.StartupPath + "\\data\\option.ini";
      string lpDefault = "";
      string lpReturnedString = Strings.Space(256);
      short privateProfileString = checked ((short) _INI.GetPrivateProfileString(ref sSection, ref sKey, ref lpDefault, ref lpReturnedString, (int) byte.MaxValue, ref lpFileName));
      if ((int) privateProfileString > 0)
        return Strings.Left(lpReturnedString, (int) privateProfileString);
      return string.Empty;
    }

    public static void SaveINI_Report(string sValue)
    {
      string lpApplicationName = Conversions.ToString(DateAndTime.Now.Date);
      string lpKeyName = "vote";
      string lpFileName = Application.StartupPath + "\\data\\Report.ini";
      if (Operators.CompareString(sValue, "", false) == 0)
        sValue = (string) null;
      _INI.WritePrivateProfileString(ref lpApplicationName, ref lpKeyName, ref sValue, ref lpFileName);
    }

    public static long LoadINI_Report()
    {
      string lpApplicationName = Conversions.ToString(DateAndTime.Now.Date);
      string lpKeyName = "vote";
      string lpFileName = Application.StartupPath + "\\data\\Report.ini";
      string lpDefault = "";
      string lpReturnedString = Strings.Space(256);
      int privateProfileString = _INI.GetPrivateProfileString(ref lpApplicationName, ref lpKeyName, ref lpDefault, ref lpReturnedString, (int) byte.MaxValue, ref lpFileName);
      return checked ((long) Math.Round(Conversion.Val(Strings.Left(lpReturnedString, privateProfileString))));
    }
  }
}
