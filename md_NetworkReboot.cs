// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.md_NetworkReboot
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Management;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class md_NetworkReboot
  {
    public static md_NetworkReboot.myNetworkReboot NetworkReboot;

    public static void RebootNetworkAdapter()
    {
      int numAdapter = md_NetworkReboot.NetworkReboot.NumAdapter;
      try
      {
        try
        {
          if (md_NetworkReboot.NetworkReboot.ChangeMAC)
          {
            string str1 = "00";
            string str2 = "00:";
            int num = 1;
            do
            {
              string upper = Strings.Right("0" + Conversion.Hex(_FUNCTION.sRND.Next(0, 256)), 2).ToUpper();
              str1 += upper;
              str2 = str2 + upper + ":";
              checked { ++num; }
            }
            while (num <= 5);
            string str3 = Strings.Left(str2, 17);
            Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}\\" + Strings.Right("000" + Conversions.ToString((int) md_NetworkReboot.NetworkReboot.NetworkAdapter[numAdapter].DeviceID), 4), true).SetValue("NetworkAddress", (object) str1);
            md_NetworkReboot.NetworkReboot.NetworkAdapter[numAdapter].MACAddress = str3;
            MyProject.Forms.frmOptions.lblNetworkReboot_MAC.Text = md_NetworkReboot.NetworkReboot.NetworkAdapter[numAdapter].MACAddress;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
          string sText1 = "NetworkReboot: Нет прав для смены MAC адреса.";
          fn1.TXT(ref sText1);
          _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
          string sText2 = "NetworkReboot: Запустите mailbox@reg с правами администратора.";
          fn2.TXT(ref sText2);
          ProjectData.ClearProjectError();
          return;
        }
        switch (md_NetworkReboot.NetworkReboot.MethodReboot)
        {
          case 0:
            try
            {
              ManagementObject managementObject = new ManagementObject("root\\CIMV2", "Win32_NetworkAdapter.DeviceID='" + Conversions.ToString((int) md_NetworkReboot.NetworkReboot.NetworkAdapter[numAdapter].DeviceID) + "'", (ObjectGetOptions) null);
              ManagementBaseObject managementBaseObject = managementObject.InvokeMethod("Disable", (ManagementBaseObject) null, (InvokeMethodOptions) null);
              if (checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(managementBaseObject["ReturnValue"])))) != 0)
              {
                _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
                string sText1 = "NetworkReboot: Произошла ошибка при отключении сетевого адаптера.";
                fn1.TXT(ref sText1);
                _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
                string sText2 = "NetworkReboot: Проверьте настройки, либо, выберите другой метод ReBoot.";
                fn2.TXT(ref sText2);
                break;
              }
              Application.DoEvents();
              Thread.Sleep(1000);
              Application.DoEvents();
              managementObject.InvokeMethod("Enable", (ManagementBaseObject) null, (InvokeMethodOptions) null);
              if (checked ((int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(managementBaseObject["ReturnValue"])))) != 0)
              {
                _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
                string sText1 = "NetworkReboot: Произошла ошибка при включении сетевого адаптера.";
                fn1.TXT(ref sText1);
                _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
                string sText2 = "NetworkReboot: Проверьте настройки, либо, выберите другой метод ReBoot.";
                fn2.TXT(ref sText2);
                break;
              }
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = "NetworkReboot(WMI): Сетевой адаптер перезагружен.";
              fn.TXT(ref sText);
              break;
            }
            catch (ManagementException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
              string sText1 = "NetworkReboot: Произошла ошибка при отключении сетевого адаптера (com WMI).";
              fn1.TXT(ref sText1);
              _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
              string sText2 = "NetworkReboot: Проверьте настройки, либо, выберите другой метод ReBoot.";
              fn2.TXT(ref sText2);
              ProjectData.ClearProjectError();
              break;
            }
          case 1:
            if (Interaction.Shell("netsh interface set interface " + md_NetworkReboot.NetworkReboot.NetworkAdapter[numAdapter].NetConnectionID + " DISABLED", AppWinStyle.Hide, true, 10000) != 0)
            {
              _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
              string sText1 = "NetworkReboot: Произошла ошибка при отключении сетевого адаптера.";
              fn1.TXT(ref sText1);
              _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
              string sText2 = "NetworkReboot: Проверьте настройки, либо, выберите другой метод ReBoot.";
              fn2.TXT(ref sText2);
              break;
            }
            Application.DoEvents();
            Thread.Sleep(1000);
            Application.DoEvents();
            if (Interaction.Shell("netsh interface set interface " + md_NetworkReboot.NetworkReboot.NetworkAdapter[numAdapter].NetConnectionID + " ENABLED", AppWinStyle.Hide, true, 10000) != 0)
            {
              _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
              string sText1 = "NetworkReboot: Произошла ошибка при включении сетевого адаптера.";
              fn1.TXT(ref sText1);
              _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
              string sText2 = "NetworkReboot: Проверьте настройки, либо, выберите другой метод ReBoot.";
              fn2.TXT(ref sText2);
              break;
            }
            _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
            string sText3 = "NetworkReboot(HARD): Сетевой адаптер перезагружен.";
            fn3.TXT(ref sText3);
            break;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        string sText = exception.Message;
        fn1.TXT(ref sText);
        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
        sText = "NetworkReboot: Ошибка в модуле ребута сетевого адаптера.";
        fn2.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public struct myNetworkReboot
    {
      public bool Use;
      public int NumAdapter;
      public bool ChangeMAC;
      public bool ReconnectRequired;
      public int MethodReboot;
      public md_NetworkReboot.myNetworkAdapter[] NetworkAdapter;
    }

    public struct myNetworkAdapter
    {
      public short DeviceID;
      public short NetConnectionStatus;
      public string NetConnectionID;
      public string Name;
      public string MACAddress;
    }
  }
}
