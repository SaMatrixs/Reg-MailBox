// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.km_ru
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class km_ru
  {
    public static bool ParsePacket_KM_RU(int Index, ref string sPacketFrom)
    {
      try
      {
        if (Strings.Len(sPacketFrom) != 0)
        {
          _VARIABLES.CurThreadData[Index].PostDataLine = new string[41];
          _VARIABLES.CurThreadData[Index].PostDataVariable = new string[41];
          _VARIABLES.CurThreadData[Index].PostDataLine[0] = "sgenfield";
          _VARIABLES.CurThreadData[Index].PostDataVariable[0] = "";
          _VARIABLES.CurThreadData[Index].PostDataLine[1] = "userFirstName";
          _VARIABLES.CurThreadData[Index].PostDataVariable[1] = _FUNCTION.URLEncode_Ascii(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Name);
          _VARIABLES.CurThreadData[Index].PostDataLine[2] = "userLastName";
          _VARIABLES.CurThreadData[Index].PostDataVariable[2] = _FUNCTION.URLEncode_Ascii(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.LastName);
          _VARIABLES.CurThreadData[Index].PostDataLine[3] = "userGender";
          _VARIABLES.CurThreadData[Index].PostDataVariable[3] = (int) _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Sex != 1 ? Conversions.ToString(0) : Conversions.ToString(1);
          _VARIABLES.CurThreadData[Index].PostDataLine[4] = "userDayBirth";
          _VARIABLES.CurThreadData[Index].PostDataVariable[4] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthDay;
          _VARIABLES.CurThreadData[Index].PostDataLine[5] = "userMonthBirth";
          _VARIABLES.CurThreadData[Index].PostDataVariable[5] = Strings.Right("0" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthMonth, 2);
          _VARIABLES.CurThreadData[Index].PostDataLine[6] = "userYearBirth";
          _VARIABLES.CurThreadData[Index].PostDataVariable[6] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthYear;
          _VARIABLES.CurThreadData[Index].PostDataLine[7] = "userBirthday";
          _VARIABLES.CurThreadData[Index].PostDataVariable[7] = _VARIABLES.CurThreadData[Index].PostDataVariable[4] + "." + _VARIABLES.CurThreadData[Index].PostDataVariable[5] + "." + _VARIABLES.CurThreadData[Index].PostDataVariable[6];
          _VARIABLES.CurThreadData[Index].PostDataLine[8] = "userLoginName";
          _VARIABLES.CurThreadData[Index].PostDataVariable[8] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login;
          _VARIABLES.CurThreadData[Index].PostDataLine[9] = "userDomainName";
          _VARIABLES.CurThreadData[Index].PostDataVariable[9] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain;
          _VARIABLES.CurThreadData[Index].PostDataLine[10] = "userPassword";
          _VARIABLES.CurThreadData[Index].PostDataVariable[10] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password;
          _VARIABLES.CurThreadData[Index].PostDataLine[11] = "userPasswordRet";
          _VARIABLES.CurThreadData[Index].PostDataVariable[11] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password;
          _VARIABLES.CurThreadData[Index].PostDataLine[12] = "userQuestionMenu";
          _VARIABLES.CurThreadData[Index].PostDataVariable[12] = "%3F";
          _VARIABLES.CurThreadData[Index].PostDataLine[13] = "userQuestion";
          _VARIABLES.CurThreadData[Index].PostDataVariable[13] = _FUNCTION.URLEncode_Ascii(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.SecretQuestion);
          _VARIABLES.CurThreadData[Index].PostDataLine[14] = "userAnswer";
          _VARIABLES.CurThreadData[Index].PostDataVariable[14] = _FUNCTION.URLEncode_Ascii(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.SecretAnswer);
          _VARIABLES.CurThreadData[Index].PostDataLine[15] = "userAltMail";
          _VARIABLES.CurThreadData[Index].PostDataVariable[15] = "";
          _VARIABLES.CurThreadData[Index].PostDataLine[16] = "submitreg";
          _VARIABLES.CurThreadData[Index].PostDataVariable[16] = "%C4%E0.+%C7%E0%E2%E5%F0%F8%E8%F2%FC+%F0%E5%E3%E8%F1%F2%F0%E0%F6%E8%FE";
          int Start1 = 1;
          int index = 16;
          while (true)
          {
            int num1 = Strings.InStr(Start1, sPacketFrom, "type=\"hidden\" name=\"", CompareMethod.Binary);
            if (num1 != 0)
            {
              checked { ++index; }
              int Start2 = checked (num1 + 20);
              int Start3 = Strings.InStr(Start2, sPacketFrom, "\"", CompareMethod.Binary);
              _VARIABLES.CurThreadData[Index].PostDataLine[index] = Strings.Mid(sPacketFrom, Start2, checked (Start3 - Start2));
              int num2 = Strings.InStr(Start3, sPacketFrom, "value=\"", CompareMethod.Binary);
              if (num2 != 0)
              {
                Start1 = checked (num2 + 7);
                int num3 = Strings.InStr(Start1, sPacketFrom, "\"", CompareMethod.Binary);
                _VARIABLES.CurThreadData[Index].PostDataVariable[index] = _FUNCTION.URLEncode_Ascii(Strings.Mid(sPacketFrom, Start1, checked (num3 - Start1)));
              }
              else
                break;
            }
            else
              break;
          }
          _VARIABLES.CurThreadData[Index].PostDataLine = (string[]) Utils.CopyArray((Array) _VARIABLES.CurThreadData[Index].PostDataLine, (Array) new string[checked (index + 1)]);
          _VARIABLES.CurThreadData[Index].PostDataVariable = (string[]) Utils.CopyArray((Array) _VARIABLES.CurThreadData[Index].PostDataVariable, (Array) new string[checked (index + 1)]);
        }
        else
          goto label_8;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = Conversions.ToString(_VARIABLES.Mirror[Index]) + "# Parse packet error";
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
        goto label_8;
      }
      return true;
label_8:
      return false;
    }

    public static bool ParsePacket_KM_RU2(int Index, string sPacketFrom)
    {
      if (Strings.Len(sPacketFrom) != 0)
      {
        _VARIABLES.CurThreadData[Index].PostDataLine = new string[41];
        _VARIABLES.CurThreadData[Index].PostDataVariable = new string[41];
        int Start1 = Strings.InStr(sPacketFrom, "__EVENTTARGET", CompareMethod.Binary);
        if (Start1 != 0)
        {
          int Start2 = checked (Strings.InStr(Start1, sPacketFrom, "value=", CompareMethod.Binary) + 7);
          int Start3 = Strings.InStr(Start2, sPacketFrom, "\"", CompareMethod.Binary);
          _VARIABLES.CurThreadData[Index].PostDataLine[1] = "__EVENTTARGET";
          _VARIABLES.CurThreadData[Index].PostDataVariable[1] = _FUNCTION.URLEncode_Ascii(Strings.Mid(sPacketFrom, Start2, checked (Start3 - Start2)));
          int Start4 = Strings.InStr(Start3, sPacketFrom, "__EVENTARGUMENT", CompareMethod.Binary);
          if (Start4 != 0)
          {
            int Start5 = checked (Strings.InStr(Start4, sPacketFrom, "value=", CompareMethod.Binary) + 7);
            int Start6 = Strings.InStr(Start5, sPacketFrom, "\"", CompareMethod.Binary);
            _VARIABLES.CurThreadData[Index].PostDataLine[2] = "__EVENTARGUMENT";
            _VARIABLES.CurThreadData[Index].PostDataVariable[2] = _FUNCTION.URLEncode_Ascii(Strings.Mid(sPacketFrom, Start5, checked (Start6 - Start5)));
            int Start7 = Strings.InStr(Start6, sPacketFrom, "__VIEWSTATE", CompareMethod.Binary);
            if (Start7 != 0)
            {
              int Start8 = checked (Strings.InStr(Start7, sPacketFrom, "value=", CompareMethod.Binary) + 7);
              int Start9 = Strings.InStr(Start8, sPacketFrom, "\"", CompareMethod.Binary);
              _VARIABLES.CurThreadData[Index].PostDataLine[3] = "__VIEWSTATE";
              _VARIABLES.CurThreadData[Index].PostDataVariable[3] = _FUNCTION.URLEncode_Ascii(Strings.Mid(sPacketFrom, Start8, checked (Start9 - Start8)));
              int index1 = 3;
              int Start10 = Strings.InStr(Start9, sPacketFrom, ">Имя:<", CompareMethod.Binary);
              if (Start10 != 0)
              {
                int Start11 = Strings.InStr(Start10, sPacketFrom, "</tr>", CompareMethod.Binary);
                string str1 = Strings.Mid(sPacketFrom, Start10, checked (Start11 - Start10));
                int Start12 = 1;
                while (true)
                {
                  int num = Strings.InStr(Start12, str1, "name=", CompareMethod.Binary);
                  if (num != 0)
                  {
                    int Start13 = checked (num + 6);
                    Start11 = Strings.InStr(Start13, str1, "\"", CompareMethod.Binary);
                    checked { ++index1; }
                    _VARIABLES.CurThreadData[Index].PostDataLine[index1] = Strings.Mid(str1, Start13, checked (Start11 - Start13));
                    if (Operators.CompareString(_VARIABLES.CurThreadData[Index].PostDataLine[index1], "userFirstName", false) == 0)
                    {
                      _VARIABLES.CurThreadData[Index].PostDataVariable[index1] = _FUNCTION.URLEncode_Ascii(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Name);
                    }
                    else
                    {
                      int Start14 = checked (Strings.InStr(Start11, str1, "value=", CompareMethod.Binary) + 7);
                      Start11 = Strings.InStr(Start14, str1, "\"", CompareMethod.Binary);
                      _VARIABLES.CurThreadData[Index].PostDataVariable[index1] = Strings.Mid(str1, Start14, checked (Start11 - Start14));
                    }
                    Start12 = Start11;
                  }
                  else
                    break;
                }
                int Start15 = Strings.InStr(Start11, sPacketFrom, ">Фамилия:<", CompareMethod.Binary);
                if (Start15 != 0)
                {
                  int Start13 = Strings.InStr(Start15, sPacketFrom, "</tr>", CompareMethod.Binary);
                  string str2 = Strings.Mid(sPacketFrom, Start15, checked (Start13 - Start15));
                  int Start14 = 1;
                  while (true)
                  {
                    int num = Strings.InStr(Start14, str2, "name=", CompareMethod.Binary);
                    if (num != 0)
                    {
                      int Start16 = checked (num + 6);
                      Start13 = Strings.InStr(Start16, str2, "\"", CompareMethod.Binary);
                      checked { ++index1; }
                      _VARIABLES.CurThreadData[Index].PostDataLine[index1] = Strings.Mid(str2, Start16, checked (Start13 - Start16));
                      if (Operators.CompareString(_VARIABLES.CurThreadData[Index].PostDataLine[index1], "userLastName", false) == 0)
                      {
                        _VARIABLES.CurThreadData[Index].PostDataVariable[index1] = _FUNCTION.URLEncode_Ascii(_VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.LastName);
                      }
                      else
                      {
                        int Start17 = checked (Strings.InStr(Start13, str2, "value=", CompareMethod.Binary) + 7);
                        Start13 = Strings.InStr(Start17, str2, "\"", CompareMethod.Binary);
                        _VARIABLES.CurThreadData[Index].PostDataVariable[index1] = Strings.Mid(str2, Start17, checked (Start13 - Start17));
                      }
                      Start14 = Start13;
                    }
                    else
                      break;
                  }
                  int Start18 = Strings.InStr(Start13, sPacketFrom, ">Пол:<", CompareMethod.Binary);
                  if (Start18 != 0)
                  {
                    int Start16 = Strings.InStr(checked (Strings.InStr(Start18, sPacketFrom, "</tr>", CompareMethod.Binary) + 5), sPacketFrom, "</tr>", CompareMethod.Binary);
                    string str3 = Strings.Mid(sPacketFrom, Start18, checked (Start16 - Start18));
                    int num1 = 0;
                    int Start17 = 1;
                    while (true)
                    {
                      int num2 = Strings.InStr(Start17, str3, "name=", CompareMethod.Binary);
                      if (num2 != 0)
                      {
                        int Start19 = checked (num2 + 6);
                        Start16 = Strings.InStr(Start19, str3, "\"", CompareMethod.Binary);
                        checked { ++index1; }
                        _VARIABLES.CurThreadData[Index].PostDataLine[index1] = Strings.Mid(str3, Start19, checked (Start16 - Start19));
                        if (Operators.CompareString(_VARIABLES.CurThreadData[Index].PostDataLine[index1], "userGender", false) == 0)
                        {
                          if (num1 == 0)
                          {
                            num1 = 1;
                            _VARIABLES.CurThreadData[Index].PostDataVariable[index1] = (int) _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.Sex != 1 ? Conversions.ToString(0) : Conversions.ToString(1);
                          }
                          else
                            checked { --index1; }
                        }
                        else
                        {
                          int Start20 = checked (Strings.InStr(Start16, str3, "value=", CompareMethod.Binary) + 7);
                          Start16 = Strings.InStr(Start20, str3, "\"", CompareMethod.Binary);
                          _VARIABLES.CurThreadData[Index].PostDataVariable[index1] = Strings.Mid(str3, Start20, checked (Start16 - Start20));
                        }
                        Start17 = Start16;
                      }
                      else
                        break;
                    }
                    int Start21 = Strings.InStr(Start16, sPacketFrom, ">Дата рождения:<", CompareMethod.Binary);
                    if (Start21 != 0)
                    {
                      int Start19 = Strings.InStr(Start21, sPacketFrom, "</tr>", CompareMethod.Binary);
                      string str4 = Strings.Mid(sPacketFrom, Start21, checked (Start19 - Start21));
                      string birthDay = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthDay;
                      string str5 = Strings.Right("0" + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthMonth, 2);
                      int Start20 = 1;
                      while (true)
                      {
                        int num2 = Strings.InStr(Start20, str4, "name=", CompareMethod.Binary);
                        if (num2 != 0)
                        {
                          int Start22 = checked (num2 + 6);
                          Start19 = Strings.InStr(Start22, str4, "\"", CompareMethod.Binary);
                          checked { ++index1; }
                          _VARIABLES.CurThreadData[Index].PostDataLine[index1] = Strings.Mid(str4, Start22, checked (Start19 - Start22));
                          string Left = _VARIABLES.CurThreadData[Index].PostDataLine[index1];
                          if (Operators.CompareString(Left, "userDayBirth", false) == 0)
                            _VARIABLES.CurThreadData[Index].PostDataVariable[index1] = birthDay;
                          else if (Operators.CompareString(Left, "userMonthBirth", false) == 0)
                            _VARIABLES.CurThreadData[Index].PostDataVariable[index1] = str5;
                          else if (Operators.CompareString(Left, "userYearBirth", false) == 0)
                            _VARIABLES.CurThreadData[Index].PostDataVariable[index1] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthYear;
                          else if (Operators.CompareString(Left, "userBirthday", false) == 0)
                          {
                            _VARIABLES.CurThreadData[Index].PostDataVariable[index1] = birthDay + "." + str5 + "." + _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.BirthYear;
                          }
                          else
                          {
                            int Start23 = checked (Strings.InStr(Start19, str4, "value=", CompareMethod.Binary) + 7);
                            Start19 = Strings.InStr(Start23, str4, "\"", CompareMethod.Binary);
                            _VARIABLES.CurThreadData[Index].PostDataVariable[index1] = Strings.Mid(str4, Start23, checked (Start19 - Start23));
                          }
                          Start20 = Start19;
                        }
                        else
                          break;
                      }
                      int index2 = checked (index1 + 1);
                      _VARIABLES.CurThreadData[Index].PostDataLine[index2] = "userLoginName";
                      _VARIABLES.CurThreadData[Index].PostDataVariable[index2] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].login;
                      int index3 = checked (index2 + 1);
                      _VARIABLES.CurThreadData[Index].PostDataLine[index3] = "userDomainName";
                      _VARIABLES.CurThreadData[Index].PostDataVariable[index3] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].domain;
                      int Start24 = Strings.InStr(Start19, sPacketFrom, ">Пароль:<", CompareMethod.Binary);
                      if (Start24 != 0)
                      {
                        int num2 = Strings.InStr(Start24, sPacketFrom, "</tr>", CompareMethod.Binary);
                        string str6 = Strings.Mid(sPacketFrom, Start24, checked (num2 - Start24));
                        int Start22 = 1;
                        while (true)
                        {
                          int num3 = Strings.InStr(Start22, str6, "name=", CompareMethod.Binary);
                          if (num3 != 0)
                          {
                            int Start23 = checked (num3 + 6);
                            int Start25 = Strings.InStr(Start23, str6, "\"", CompareMethod.Binary);
                            checked { ++index3; }
                            _VARIABLES.CurThreadData[Index].PostDataLine[index3] = Strings.Mid(str6, Start23, checked (Start25 - Start23));
                            if (Operators.CompareString(_VARIABLES.CurThreadData[Index].PostDataLine[index3], "userPassword", false) == 0)
                            {
                              _VARIABLES.CurThreadData[Index].PostDataVariable[index3] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password;
                              checked { ++index3; }
                              _VARIABLES.CurThreadData[Index].PostDataLine[index3] = "userPasswordRet";
                              _VARIABLES.CurThreadData[Index].PostDataVariable[index3] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].password;
                            }
                            else
                            {
                              int Start26 = checked (Strings.InStr(Start25, str6, "value=", CompareMethod.Binary) + 7);
                              Start25 = Strings.InStr(Start26, str6, "\"", CompareMethod.Binary);
                              _VARIABLES.CurThreadData[Index].PostDataVariable[index3] = Strings.Mid(str6, Start26, checked (Start25 - Start26));
                            }
                            Start22 = Start25;
                          }
                          else
                            break;
                        }
                        int index4 = checked (index3 + 1);
                        _VARIABLES.CurThreadData[Index].PostDataLine[index4] = "userQuestionMenu";
                        _VARIABLES.CurThreadData[Index].PostDataLine[checked (index4 + 1)] = "userQuestion";
                        _FUNCTION.sRND.Next(1, 6);
                        _VARIABLES.CurThreadData[Index].PostDataVariable[index4] = "%CC%EE%E9+%C8%CD%CD+%ED%EE%EC%E5%F0";
                        _VARIABLES.CurThreadData[Index].PostDataVariable[checked (index4 + 1)] = _VARIABLES.CurThreadData[Index].PostDataVariable[index4];
                        int index5 = checked (index4 + 1 + 1);
                        _VARIABLES.CurThreadData[Index].PostDataLine[index5] = "userAnswer";
                        _VARIABLES.CurThreadData[Index].PostDataVariable[index5] = _VARIABLES.MailInfo[_VARIABLES.Mirror[Index]].RegUserData.SecretAnswer;
                        int index6 = checked (index5 + 1);
                        _VARIABLES.CurThreadData[Index].PostDataLine[index6] = "userAltMail";
                        _VARIABLES.CurThreadData[Index].PostDataVariable[index6] = "";
                        int index7 = checked (index6 + 1);
                        _VARIABLES.CurThreadData[Index].PostDataLine[index7] = "sgenfield";
                        _VARIABLES.CurThreadData[Index].PostDataVariable[index7] = "capthca";
                        int index8 = checked (index7 + 1);
                        _VARIABLES.CurThreadData[Index].PostDataLine[index8] = "submitreg";
                        _VARIABLES.CurThreadData[Index].PostDataVariable[index8] = "%C4%E0.+%C7%E0%E2%E5%F0%F8%E8%F2%FC+%F0%E5%E3%E8%F1%F2%F0%E0%F6%E8%FE";
                        int index9 = checked (index8 + 1);
                        int Start27 = Strings.InStr(sPacketFrom, "__VIEWSTATEENCRYPTED", CompareMethod.Binary);
                        if (Start27 != 0)
                        {
                          int Start23 = checked (Strings.InStr(Start27, sPacketFrom, "value=", CompareMethod.Binary) + 7);
                          int Start25 = Strings.InStr(Start23, sPacketFrom, "\"", CompareMethod.Binary);
                          _VARIABLES.CurThreadData[Index].PostDataLine[index9] = "__VIEWSTATEENCRYPTED";
                          _VARIABLES.CurThreadData[Index].PostDataVariable[index9] = _FUNCTION.URLEncode_Ascii(Strings.Mid(sPacketFrom, Start23, checked (Start25 - Start23)));
                          int index10 = checked (index9 + 1);
                          int Start26 = Strings.InStr(Start25, sPacketFrom, "__EVENTVALIDATION", CompareMethod.Binary);
                          if (Start26 != 0)
                          {
                            int Start28 = checked (Strings.InStr(Start26, sPacketFrom, "value=", CompareMethod.Binary) + 7);
                            int num3 = Strings.InStr(Start28, sPacketFrom, "\"", CompareMethod.Binary);
                            _VARIABLES.CurThreadData[Index].PostDataLine[index10] = "__EVENTVALIDATION";
                            _VARIABLES.CurThreadData[Index].PostDataVariable[index10] = _FUNCTION.URLEncode_Ascii(Strings.Mid(sPacketFrom, Start28, checked (num3 - Start28)));
                            _VARIABLES.CurThreadData[Index].PostDataLine = (string[]) Utils.CopyArray((Array) _VARIABLES.CurThreadData[Index].PostDataLine, (Array) new string[checked (index10 + 1)]);
                            _VARIABLES.CurThreadData[Index].PostDataVariable = (string[]) Utils.CopyArray((Array) _VARIABLES.CurThreadData[Index].PostDataVariable, (Array) new string[checked (index10 + 1)]);
                            return true;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
      return false;
    }
  }
}
