// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.md_MailFunctions
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;

namespace MailRegUnicore
{
  [StandardModule]
  public sealed class md_MailFunctions
  {
    public static string Convert_StrBase64AndCharset(string sString)
    {
      if (!Information.IsNothing((object) sString))
      {
        if (sString.Length != 0)
        {
          string str1;
          try
          {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            string empty3 = string.Empty;
            int Start1 = 1;
            while (true)
            {
              int num = Strings.InStr(Start1, sString, "=?", CompareMethod.Binary);
              if (num != 0)
              {
                empty2 += Strings.Mid(sString, Start1, checked (num - Start1));
                int Start2 = checked (num + 2);
                Start1 = Strings.InStr(Start2, sString, "?", CompareMethod.Binary);
                if (Start1 != 0)
                {
                  string str2 = Strings.Mid(sString, Start2, checked (Start1 - Start2)).ToLower();
                  if (Operators.CompareString(str2, "cp1251", false) == 0)
                    str2 = "windows-1251";
                  Encoding encoding = Encoding.GetEncoding(str2);
                  string lower = Strings.Mid(sString, checked (Start1 + 1), 1).ToLower();
                  int Start3 = checked (Start1 + 3);
                  Start1 = Strings.InStr(Start3, sString, "?=", CompareMethod.Binary);
                  if (Start1 != 0)
                  {
                    string sText = Strings.Mid(sString, Start3, checked (Start1 - Start3));
                    if (Operators.CompareString(lower, "b", false) == 0)
                    {
                      string str3 = encoding.GetString(Convert.FromBase64String(sText));
                      empty2 += str3;
                    }
                    else
                      empty2 += md_MailFunctions.ConvertUTF8toSTR(ref sText);
                    checked { Start1 += 2; }
                  }
                  else
                    break;
                }
                else
                  break;
              }
              else
                break;
            }
            sString = empty2 + Strings.Right(sString, checked (sString.Length - Start1 + 1));
            str1 = sString;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Ex Convert_StrBase64AndCharset:" + exception.Message;
            fn.TXT(ref sText);
            str1 = sString;
            ProjectData.ClearProjectError();
          }
          return str1;
        }
      }
      return string.Empty;
    }

    public static string ConvertSTRtoUTF8(ref string sText)
    {
      if (Strings.Len(sText) == 0)
        return string.Empty;
      string str = "";
      byte[] bytes = Encoding.UTF8.GetBytes(sText);
      int num1 = 0;
      int num2 = Information.UBound((Array) bytes, 1);
      int index = num1;
      while (index <= num2)
      {
        str = (int) bytes[index] != 32 ? str + "%" + Strings.Right("0" + Conversion.Hex(bytes[index]), 2) : str + " ";
        checked { ++index; }
      }
      return str;
    }

    public static string ConvertUTF8toSTR(ref string sText)
    {
      byte[] numArray = new byte[checked (sText.Length - 1 + 1)];
      int index = -1;
      sText = sText.Replace("=", "%");
      int num1 = 1;
      int length = sText.Length;
      int Start = num1;
      while (Start <= length)
      {
        if (Operators.CompareString(Strings.Mid(sText, Start, 1), "%", false) == 0)
        {
          checked { ++index; }
          numArray[index] = Convert.ToByte(Strings.Mid(sText, checked (Start + 1), 2), 16);
          checked { Start += 2; }
        }
        else
        {
          checked { ++index; }
          if (Strings.Asc(Strings.Mid(sText, Start, 1)) == 43)
            ;
          int num2 = 32;
          numArray[index] = checked ((byte) num2);
        }
        checked { ++Start; }
      }
      return Encoding.UTF8.GetString((byte[]) Utils.CopyArray((Array) numArray, (Array) new byte[checked (index + 1)]));
    }

    public static string Remove_sidewall(string sText)
    {
      sText = sText.Replace("<", string.Empty);
      sText = sText.Replace(">", string.Empty);
      return sText;
    }
  }
}
