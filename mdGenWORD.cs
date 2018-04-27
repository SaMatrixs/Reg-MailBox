// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.mdGenWORD
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class mdGenWORD
  {
    public const string StrGlasnie = "aeuioy";
    public const string StrSoglasnie = "qwrtpsdfghjklzxcvbnm";
    public static mdGenWORD.MeGenWordOptions GenWordOptions;

    public static object GenPassword()
    {
      mdGenWORD.GenWordOptions.WordLenMin = (byte) 14;
      mdGenWORD.GenWordOptions.WordLenMax = (byte) 15;
      mdGenWORD.GenWordOptions.UseNUM = (byte) 103;
      mdGenWORD.GenWordOptions.UseNumPercent = (byte) 20;
      mdGenWORD.GenWordOptions.DblGlasnay = (byte) 0;
      mdGenWORD.GenWordOptions.DblSoglasnay = (byte) 0;
      mdGenWORD.GenWordOptions.DifferentRegister = (byte) 1;
      mdGenWORD.GenWordOptions.CapitalLetter = (byte) 0;
      mdGenWORD.GenWordOptions.CapitalAll = (byte) 0;
      return (object) mdGenWORD.GenWORD();
    }

    public static object GenFastLogin()
    {
      mdGenWORD.GenWordOptions.WordLenMin = (byte) 10;
      mdGenWORD.GenWordOptions.WordLenMax = (byte) 20;
      mdGenWORD.GenWordOptions.UseNUM = (byte) 11;
      mdGenWORD.GenWordOptions.UseNumPercent = (byte) 20;
      mdGenWORD.GenWordOptions.DblGlasnay = (byte) 1;
      mdGenWORD.GenWordOptions.DblSoglasnay = (byte) 1;
      mdGenWORD.GenWordOptions.DifferentRegister = (byte) 0;
      mdGenWORD.GenWordOptions.CapitalLetter = (byte) 0;
      mdGenWORD.GenWordOptions.CapitalAll = (byte) 0;
      return (object) mdGenWORD.GenWORD();
    }

    public static string GenWORD()
    {
      string Expression1 = "";
      string Expression2 = "";
      string str = "";
      byte num1;
      if ((int) mdGenWORD.GenWordOptions.WordLenMax == 0)
      {
        num1 = mdGenWORD.GenWordOptions.WordLenMin;
      }
      else
      {
        byte num2 = checked ((byte) ((int) (byte) unchecked ((int) mdGenWORD.GenWordOptions.WordLenMax - (int) mdGenWORD.GenWordOptions.WordLenMin) + 1));
        num1 = checked ((byte) ((int) mdGenWORD.GenWordOptions.WordLenMin + _FUNCTION.sRND.Next(0, (int) num2)));
      }
      if ((int) mdGenWORD.GenWordOptions.UseNUM > 0)
      {
        byte Slen1 = checked ((byte) Math.Round(unchecked ((double) num1 / 100.0 * (double) mdGenWORD.GenWordOptions.UseNumPercent)));
        switch (mdGenWORD.GenWordOptions.UseNUM)
        {
          case 1:
            Expression1 = mdGenWORD.GenNUM(ref Slen1);
            break;
          case 2:
            if (_FUNCTION.sRND.Next(0, 2) == 1)
            {
              Expression1 = mdGenWORD.GenNUM(ref Slen1);
              break;
            }
            break;
          case 11:
            Expression2 = mdGenWORD.GenNUM(ref Slen1);
            break;
          case 12:
            if (_FUNCTION.sRND.Next(0, 2) == 1)
            {
              Expression2 = mdGenWORD.GenNUM(ref Slen1);
              break;
            }
            break;
          case 101:
            byte Slen2 = checked ((byte) Math.Round(unchecked ((double) Slen1 / 2.0)));
            byte Slen3 = checked ((byte) unchecked ((int) Slen1 - (int) Slen2));
            Expression1 = mdGenWORD.GenNUM(ref Slen2);
            Expression2 = mdGenWORD.GenNUM(ref Slen3);
            break;
          case 102:
            if (_FUNCTION.sRND.Next(0, 2) == 1)
            {
              byte Slen4 = checked ((byte) Math.Round(unchecked ((double) Slen1 / 2.0)));
              byte Slen5 = checked ((byte) unchecked ((int) Slen1 - (int) Slen4));
              Expression1 = mdGenWORD.GenNUM(ref Slen4);
              Expression2 = mdGenWORD.GenNUM(ref Slen5);
              break;
            }
            break;
          case 103:
            if (_FUNCTION.sRND.Next(0, 2) == 1)
            {
              Expression1 = mdGenWORD.GenNUM(ref Slen1);
              break;
            }
            Expression2 = mdGenWORD.GenNUM(ref Slen1);
            break;
          case 104:
            switch (_FUNCTION.sRND.Next(0, 3))
            {
              case 0:
                Expression1 = mdGenWORD.GenNUM(ref Slen1);
                break;
              case 1:
                Expression2 = mdGenWORD.GenNUM(ref Slen1);
                break;
            }
          case 105:
            switch (_FUNCTION.sRND.Next(0, 3))
            {
              case 0:
                Expression1 = mdGenWORD.GenNUM(ref Slen1);
                break;
              case 1:
                Expression2 = mdGenWORD.GenNUM(ref Slen1);
                break;
              case 2:
                byte Slen6 = checked ((byte) Math.Round(unchecked ((double) Slen1 / 2.0)));
                byte Slen7 = checked ((byte) unchecked ((int) Slen1 - (int) Slen6));
                Expression1 = mdGenWORD.GenNUM(ref Slen6);
                Expression2 = mdGenWORD.GenNUM(ref Slen7);
                break;
            }
          case 106:
            switch (_FUNCTION.sRND.Next(0, 4))
            {
              case 0:
                Expression1 = mdGenWORD.GenNUM(ref Slen1);
                break;
              case 1:
                Expression2 = mdGenWORD.GenNUM(ref Slen1);
                break;
              case 2:
                byte Slen8 = checked ((byte) Math.Round(unchecked ((double) Slen1 / 2.0)));
                byte Slen9 = checked ((byte) unchecked ((int) Slen1 - (int) Slen8));
                Expression1 = mdGenWORD.GenNUM(ref Slen8);
                Expression2 = mdGenWORD.GenNUM(ref Slen9);
                break;
            }
        }
      }
      byte num3 = checked ((byte) _FUNCTION.sRND.Next(0, 2));
      byte num4 = checked ((byte) ((int) num1 - Strings.Len(Expression1) - Strings.Len(Expression2)));
      int num5 = 1;
      int num6 = (int) num4;
      int num7 = num5;
      while (num7 <= num6)
      {
        checked { ++num3; }
        if ((int) num3 == 2)
          num3 = (byte) 0;
        if ((int) num3 == 0)
        {
          byte num2 = checked ((byte) _FUNCTION.sRND.Next(1, 7));
          str += Strings.Mid("aeuioy", (int) num2, 1);
          if ((int) mdGenWORD.GenWordOptions.DblGlasnay > 0 && _FUNCTION.sRND.Next(1, 101) <= (int) mdGenWORD.GenWordOptions.DblGlasnay)
            str += Strings.Mid("aeuioy", (int) num2, 1);
        }
        else
        {
          byte num2 = checked ((byte) _FUNCTION.sRND.Next(1, 21));
          str += Strings.Mid("qwrtpsdfghjklzxcvbnm", (int) num2, 1);
          if ((int) mdGenWORD.GenWordOptions.DblSoglasnay > 0 && _FUNCTION.sRND.Next(1, 101) <= (int) mdGenWORD.GenWordOptions.DblSoglasnay)
            str += Strings.Mid("qwrtpsdfghjklzxcvbnm", (int) num2, 1);
        }
        checked { ++num7; }
      }
      string sDest = Strings.Left(str, (int) num4);
      if ((int) mdGenWORD.GenWordOptions.DifferentRegister == 1)
      {
        int num2;
        do
        {
          int num8 = 1;
          int num9 = (int) num4;
          int num10 = num8;
          while (num10 <= num9)
          {
            if (_FUNCTION.sRND.Next(0, 2) == 1)
            {
              StringType.MidStmtStr(ref sDest, num10, 1, Strings.UCase(Strings.Mid(sDest, num10, 1)));
              checked { ++num2; }
            }
            checked { ++num10; }
          }
        }
        while (num2 == 0 | num2 == (int) num4);
      }
      if ((int) mdGenWORD.GenWordOptions.CapitalLetter == 1)
        StringType.MidStmtStr(ref sDest, 1, 1, Strings.UCase(Strings.Mid(sDest, 1, 1)));
      if ((int) mdGenWORD.GenWordOptions.CapitalAll > 0 && _FUNCTION.sRND.Next(1, 101) <= (int) mdGenWORD.GenWordOptions.CapitalAll)
        sDest = Strings.UCase(sDest);
      return Expression1 + sDest + Expression2;
    }

    public static string GenNUM(ref byte Slen)
    {
      string str = "";
      int num1 = 1;
      int num2 = (int) Slen;
      int num3 = num1;
      while (num3 <= num2)
      {
        str += Conversions.ToString(_FUNCTION.sRND.Next(0, 10));
        checked { ++num3; }
      }
      return str;
    }

    public static string Translate(ref string sTextRus)
    {
      return sTextRus.ToLower().Replace("а", "a").Replace("б", "b").Replace("в", "v").Replace("г", "g").Replace("д", "d").Replace("е", "e").Replace("ё", "e").Replace("ж", "j").Replace("з", "z").Replace("и", "i").Replace("й", "y").Replace("к", "k").Replace("л", "l").Replace("м", "m").Replace("н", "n").Replace("о", "o").Replace("п", "p").Replace("р", "r").Replace("с", "s").Replace("т", "t").Replace("у", "u").Replace("ф", "f").Replace("х", "h").Replace("ц", "c").Replace("ч", "ch").Replace("ш", "sh").Replace("щ", "sh").Replace("ъ", "").Replace("ы", "y").Replace("ь", "").Replace("э", "e").Replace("ю", "yu").Replace("я", "ya");
    }

    public struct MeGenWordOptions
    {
      public byte WordLenMin;
      public byte WordLenMax;
      public byte UseNUM;
      public byte UseNumPercent;
      public byte DblGlasnay;
      public byte DblSoglasnay;
      public byte DifferentRegister;
      public byte CapitalLetter;
      public byte CapitalAll;
    }
  }
}
