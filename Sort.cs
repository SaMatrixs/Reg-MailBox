// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.Sort
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class Sort
  {
    public static void SortByDomain()
    {
      if (Information.UBound((Array) _VARIABLES.MailInfo, 1) == 0)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Нет аккаунтов для сортировки!";
        fn.TXT(ref sText);
      }
      else
      {
        if (Interaction.MsgBox((object) "Сортировать аккаунты по 'Domain'?", MsgBoxStyle.OkCancel | MsgBoxStyle.Question, (object) "Sorting") == MsgBoxResult.Cancel)
          return;
        _VARIABLES.meMailInfo[] meMailInfoArray = new _VARIABLES.meMailInfo[checked (Information.UBound((Array) _VARIABLES.MailInfo, 1) + 1)];
        string[] strArray = new string[1];
        int num1 = 1;
        int num2 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
        int index1 = num1;
        while (index1 <= num2)
        {
          int num3 = 1;
          int num4 = Information.UBound((Array) strArray, 1);
          int index2 = num3;
          while (index2 <= num4 && Operators.CompareString(strArray[index2], _VARIABLES.MailInfo[index1].domain, false) != 0)
            checked { ++index2; }
          if (index2 > Information.UBound((Array) strArray, 1))
          {
            strArray = (string[]) Utils.CopyArray((Array) strArray, (Array) new string[checked (Information.UBound((Array) strArray, 1) + 1 + 1)]);
            strArray[Information.UBound((Array) strArray, 1)] = _VARIABLES.MailInfo[index1].domain;
          }
          checked { ++index1; }
        }
        int index3 = 0;
        int[] numArray1 = new int[checked (Information.UBound((Array) strArray, 1) + 1)];
        int num5 = 1;
        int num6 = Information.UBound((Array) strArray, 1);
        int index4 = num5;
        while (index4 <= num6)
        {
          int num3 = 1;
          int num4 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
          int index2 = num3;
          while (index2 <= num4)
          {
            if (Operators.CompareString(strArray[index4], _VARIABLES.MailInfo[index2].domain, false) == 0)
            {
              checked { ++index3; }
              int[] numArray2 = numArray1;
              int[] numArray3 = numArray2;
              int index5 = index4;
              int index6 = index5;
              int num7 = checked (numArray2[index5] + 1);
              numArray3[index6] = num7;
              meMailInfoArray[index3] = _VARIABLES.MailInfo[index2];
            }
            checked { ++index2; }
          }
          checked { ++index4; }
        }
        _VARIABLES.MailInfo = meMailInfoArray;
        int num8 = 1;
        int num9 = Information.UBound((Array) strArray, 1);
        int index7 = num8;
        while (index7 <= num9)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "@" + strArray[index7] + ": " + Conversions.ToString(numArray1[index7]);
          fn.TXT(ref sText);
          checked { ++index7; }
        }
        _LOADSAVE.SaveALL_MailInfo();
        _LV.LV_ADD_ALL();
      }
    }

    public static void SortByLogin()
    {
      int num1 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
      if (num1 == 0)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Нет аккаунтов для сортировки!";
        fn.TXT(ref sText);
      }
      else
      {
        if (Interaction.MsgBox((object) "Сортировать аккаунты по 'Login'?", MsgBoxStyle.OkCancel | MsgBoxStyle.Question, (object) "Sorting") == MsgBoxResult.Cancel)
          return;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        string[] array = new string[checked (num1 + 1)];
        int num2 = 1;
        int num3 = num1;
        int index1 = num2;
        while (index1 <= num3)
        {
          array[index1] = _VARIABLES.MailInfo[index1].login;
          checked { ++index1; }
        }
        Array.Sort<string>(array);
        _VARIABLES.meMailInfo[] meMailInfoArray = new _VARIABLES.meMailInfo[checked (num1 + 1)];
        int num4 = 0;
        int num5 = 1;
        int num6 = num1;
        int index2 = num5;
        while (index2 <= num6)
        {
          int num7 = 1;
          int num8 = num1;
          int index3 = num7;
          while (index3 <= num8)
          {
            if (!Information.IsNothing((object) _VARIABLES.MailInfo[index3].login) && Operators.CompareString(_VARIABLES.MailInfo[index3].login, array[index2], false) == 0)
            {
              meMailInfoArray[index2] = _VARIABLES.MailInfo[index3];
              _VARIABLES.MailInfo[index3].login = (string) null;
              checked { ++num4; }
              break;
            }
            checked { ++index3; }
          }
          checked { ++index2; }
        }
        _VARIABLES.MailInfo = meMailInfoArray;
        _LV.LV_ADD_ALL();
        _LOADSAVE.SaveALL_MailInfo();
        stopwatch.Stop();
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Успешно отсортировано " + Conversions.ToString(num4) + " аккаунтов за " + Conversions.ToString(stopwatch.ElapsedMilliseconds) + "ms.";
        fn.TXT(ref sText);
      }
    }

    public static void SortByName()
    {
      int num1 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
      if (num1 == 0)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Нет аккаунтов для сортировки!";
        fn.TXT(ref sText);
      }
      else
      {
        if (Interaction.MsgBox((object) "Сортировать аккаунты по 'Name'?", MsgBoxStyle.OkCancel | MsgBoxStyle.Question, (object) "Sorting") == MsgBoxResult.Cancel)
          return;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        string[] array = new string[checked (num1 + 1)];
        int num2 = 1;
        int num3 = num1;
        int index1 = num2;
        while (index1 <= num3)
        {
          array[index1] = _VARIABLES.MailInfo[index1].RegUserData.Name;
          checked { ++index1; }
        }
        Array.Sort<string>(array);
        _VARIABLES.meMailInfo[] meMailInfoArray = new _VARIABLES.meMailInfo[checked (num1 + 1)];
        int num4 = 0;
        int num5 = 1;
        int num6 = num1;
        int index2 = num5;
        while (index2 <= num6)
        {
          int num7 = 1;
          int num8 = num1;
          int index3 = num7;
          while (index3 <= num8)
          {
            if (!Information.IsNothing((object) _VARIABLES.MailInfo[index3].RegUserData.Name) && Operators.CompareString(_VARIABLES.MailInfo[index3].RegUserData.Name, array[index2], false) == 0)
            {
              meMailInfoArray[index2] = _VARIABLES.MailInfo[index3];
              _VARIABLES.MailInfo[index3].RegUserData.Name = (string) null;
              checked { ++num4; }
              break;
            }
            checked { ++index3; }
          }
          checked { ++index2; }
        }
        _VARIABLES.MailInfo = meMailInfoArray;
        _LV.LV_ADD_ALL();
        _LOADSAVE.SaveALL_MailInfo();
        stopwatch.Stop();
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Успешно отсортировано " + Conversions.ToString(num4) + " аккаунтов за " + Conversions.ToString(stopwatch.ElapsedMilliseconds) + "ms.";
        fn.TXT(ref sText);
      }
    }

    public static void SortByLastName()
    {
      int num1 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
      if (num1 == 0)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Нет аккаунтов для сортировки!";
        fn.TXT(ref sText);
      }
      else
      {
        if (Interaction.MsgBox((object) "Сортировать аккаунты по 'LastName'?", MsgBoxStyle.OkCancel | MsgBoxStyle.Question, (object) "Sorting") == MsgBoxResult.Cancel)
          return;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        string[] array = new string[checked (num1 + 1)];
        int num2 = 1;
        int num3 = num1;
        int index1 = num2;
        while (index1 <= num3)
        {
          array[index1] = _VARIABLES.MailInfo[index1].RegUserData.LastName;
          checked { ++index1; }
        }
        Array.Sort<string>(array);
        _VARIABLES.meMailInfo[] meMailInfoArray = new _VARIABLES.meMailInfo[checked (num1 + 1)];
        int num4 = 0;
        int num5 = 1;
        int num6 = num1;
        int index2 = num5;
        while (index2 <= num6)
        {
          int num7 = 1;
          int num8 = num1;
          int index3 = num7;
          while (index3 <= num8)
          {
            if (!Information.IsNothing((object) _VARIABLES.MailInfo[index3].RegUserData.LastName) && Operators.CompareString(_VARIABLES.MailInfo[index3].RegUserData.LastName, array[index2], false) == 0)
            {
              meMailInfoArray[index2] = _VARIABLES.MailInfo[index3];
              _VARIABLES.MailInfo[index3].RegUserData.LastName = (string) null;
              checked { ++num4; }
              break;
            }
            checked { ++index3; }
          }
          checked { ++index2; }
        }
        _VARIABLES.MailInfo = meMailInfoArray;
        _LV.LV_ADD_ALL();
        _LOADSAVE.SaveALL_MailInfo();
        stopwatch.Stop();
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Успешно отсортировано " + Conversions.ToString(num4) + " аккаунтов за " + Conversions.ToString(stopwatch.ElapsedMilliseconds) + "ms.";
        fn.TXT(ref sText);
      }
    }

    public static void SortByCreationDate()
    {
      int num1 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
      if (num1 == 0)
      {
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Нет аккаунтов для сортировки!";
        fn.TXT(ref sText);
      }
      else
      {
        if (Interaction.MsgBox((object) "Сортировать аккаунты по 'Creation Date'?", MsgBoxStyle.OkCancel | MsgBoxStyle.Question, (object) "Sorting") == MsgBoxResult.Cancel)
          return;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        string[] strArray = new string[checked (num1 + 1)];
        DateTime[] array = new DateTime[checked (num1 + 1)];
        DateTime date = Conversions.ToDate("31.12.3000");
        int num2 = 0;
        int num3 = 0;
        int num4 = 1;
        int num5 = num1;
        int index1 = num4;
        while (index1 <= num5)
        {
          if (Operators.CompareString(_VARIABLES.MailInfo[index1].DataCreateBox, string.Empty, false) != 0)
          {
            array[index1] = Conversions.ToDate(_VARIABLES.MailInfo[index1].DataCreateBox);
            checked { ++num2; }
          }
          else
          {
            array[index1] = date;
            checked { ++num3; }
          }
          checked { ++index1; }
        }
        int num6 = 0;
        int num7 = 0;
        Array.Sort<DateTime>(array);
        int num8 = 1;
        int num9 = num1;
        int index2 = num8;
        while (index2 <= num9)
        {
          if (DateTime.Compare(array[index2], date) != 0)
          {
            strArray[index2] = Conversions.ToString(array[index2]);
            checked { ++num6; }
          }
          else
          {
            strArray[index2] = string.Empty;
            checked { ++num7; }
          }
          checked { ++index2; }
        }
        _VARIABLES.meMailInfo[] meMailInfoArray = new _VARIABLES.meMailInfo[checked (num1 + 1)];
        int num10 = 0;
        int num11 = 1;
        int num12 = num1;
        int index3 = num11;
        while (index3 <= num12)
        {
          int num13 = 1;
          int num14 = num1;
          int index4 = num13;
          while (index4 <= num14)
          {
            if (!Information.IsNothing((object) _VARIABLES.MailInfo[index4].DataCreateBox) && Operators.CompareString(_VARIABLES.MailInfo[index4].DataCreateBox, strArray[index3], false) == 0)
            {
              meMailInfoArray[index3] = _VARIABLES.MailInfo[index4];
              _VARIABLES.MailInfo[index4].DataCreateBox = (string) null;
              checked { ++num10; }
              break;
            }
            checked { ++index4; }
          }
          checked { ++index3; }
        }
        _VARIABLES.MailInfo = meMailInfoArray;
        _LV.LV_ADD_ALL();
        _LOADSAVE.SaveALL_MailInfo();
        stopwatch.Stop();
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Успешно отсортировано " + Conversions.ToString(num10) + " аккаунтов за " + Conversions.ToString(stopwatch.ElapsedMilliseconds) + "ms.";
        fn.TXT(ref sText);
      }
    }
  }
}
