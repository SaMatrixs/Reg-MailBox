// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.POP3
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace MailRegUnicore
{
  public class POP3
  {
    private TcpClient TCP;
    private Stream POP3Stream;
    private StreamReader inStream;
    private string strDataIn;
    private string[] strNumMains;
    private int intNoEmails;

    public POP3()
    {
      this.strNumMains = new string[3];
    }

    public void POPConnect(string strServer, string strUserName, string strPassword)
    {
      try
      {
        this.TCP = new TcpClient();
        this.TCP.Connect(strServer, 110);
        this.POP3Stream = (Stream) this.TCP.GetStream();
        this.inStream = new StreamReader(this.POP3Stream, Encoding.Default);
        if (!this.WaitFor("+OK"))
          this.POPErrors(this.strDataIn);
        this.SendData("USER " + strUserName);
        if (!this.WaitFor("+OK"))
          this.POPErrors(this.strDataIn);
        this.SendData("PASS " + strPassword);
        if (this.WaitFor("+OK"))
          return;
        this.POPErrors(this.strDataIn);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new POP3Exception(ex.Message);
      }
    }

    public int STAT()
    {
      int integer;
      try
      {
        this.SendData(nameof (STAT));
        if (!this.WaitFor("+OK"))
          throw new POP3Exception(this.strDataIn);
        this.strNumMains = Strings.Split(this.strDataIn, " ", -1, CompareMethod.Binary);
        integer = Conversions.ToInteger(this.strNumMains[1]);
        this.intNoEmails = Conversions.ToInteger(this.strNumMains[1]);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.intNoEmails = 0;
        throw new POP3Exception(exception.Message);
      }
      return integer;
    }

    public void POPErrors(string strMsg)
    {
      throw new POP3Exception("POP3 ERROR: " + strMsg);
    }

    public bool WaitFor(string strTarget)
    {
      this.strDataIn = this.inStream.ReadLine();
      return !Information.IsNothing((object) this.strDataIn) && (uint) Strings.InStr(this.strDataIn, strTarget, CompareMethod.Binary) > 0U;
    }

    public string RETR(int intNum)
    {
      StringBuilder stringBuilder = new StringBuilder();
      string str;
      try
      {
        this.SendData("RETR " + Conversions.ToString(intNum));
        if (!this.WaitFor("+OK"))
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Unexpected Response from mail server getting email body\r\n" + this.strDataIn;
          fn.TXT(ref sText);
          str = "No Email was Retrived";
        }
        else
        {
          for (string Left = this.inStream.ReadLine(); Operators.CompareString(Left, ".", false) != 0; Left = this.inStream.ReadLine())
            stringBuilder.Append(Left + "\r\n");
          str = stringBuilder.ToString();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "No Email was Retrived";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public my_eMail RETR_Full(int intNum)
    {
      StringBuilder stringBuilder = new StringBuilder();
      my_eMail myEMail1;
      try
      {
        this.SendData("RETR " + Conversions.ToString(intNum));
        if (!this.WaitFor("+OK"))
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          string sText = "Unexpected Response from mail server getting email body\r\n" + this.strDataIn;
          fn.TXT(ref sText);
          myEMail1 = (my_eMail) null;
        }
        else
        {
          for (string Left = this.inStream.ReadLine(); Operators.CompareString(Left, ".", false) != 0; Left = this.inStream.ReadLine())
            stringBuilder.Append(Left + "\r\n");
          string[] strArray1 = Strings.Split(stringBuilder.ToString(), "\r\n\r\n", 2, CompareMethod.Binary);
          if (strArray1.Length != 2)
          {
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Ex POP3.RETR_Full: Split.Len<>2";
            fn.TXT(ref sText);
            myEMail1 = (my_eMail) null;
          }
          else
          {
            my_eMail myEMail2 = new my_eMail();
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            string str1 = strArray1[0];
            string s1 = strArray1[1];
            myEMail2._Head = str1;
            myEMail2._HeadLine = new Hashtable();
            string[] strArray2 = str1.Replace("\r", string.Empty).Replace("\n\t", " ").Replace("\n  ", string.Empty).Replace("\n ", string.Empty).Replace(";\n", "; ").Split('\n');
            int num1 = 0;
            int num2 = Information.UBound((Array) strArray2, 1);
            int index1 = num1;
            while (index1 <= num2)
            {
              if (strArray2[index1].Length != 0)
              {
                string[] strArray3 = Strings.Split(strArray2[index1], ":", 2, CompareMethod.Binary);
                if (strArray3.Length == 2)
                {
                  string str2 = Strings.Trim(strArray3[0].ToLower());
                  string str3 = Strings.Trim(strArray3[1]);
                  if (myEMail2._HeadLine.ContainsKey((object) str2))
                    myEMail2._HeadLine.Add((object) (str2 + "_" + Conversions.ToString(_FUNCTION.sRND.Next(111, 999))), (object) str3);
                  else
                    myEMail2._HeadLine.Add((object) str2, (object) str3);
                  string Left = str2;
                  if (Operators.CompareString(Left, "from", false) == 0)
                  {
                    string str4 = md_MailFunctions.Convert_StrBase64AndCharset(str3);
                    int Start = Strings.InStr(str4, "<", CompareMethod.Binary);
                    if (Start == 0)
                    {
                      myEMail2._From_Address = str4;
                      myEMail2._From_DisplayName = string.Empty;
                    }
                    else
                    {
                      int num3 = Strings.InStr(Start, str4, ">", CompareMethod.Binary);
                      myEMail2._From_Address = Strings.Mid(str4, checked (Start + 1), checked (num3 - Start - 1));
                      myEMail2._From_DisplayName = Strings.Trim(str4.Remove(checked (Start - 1), checked (num3 - Start + 1)));
                    }
                  }
                  else if (Operators.CompareString(Left, "to", false) == 0)
                  {
                    string str4 = md_MailFunctions.Convert_StrBase64AndCharset(str3);
                    int Start = Strings.InStr(str4, "<", CompareMethod.Binary);
                    if (Start == 0)
                    {
                      myEMail2._To_Address = str4;
                      myEMail2._To_DisplayName = string.Empty;
                    }
                    else
                    {
                      int num3 = Strings.InStr(Start, str4, ">", CompareMethod.Binary);
                      myEMail2._To_Address = Strings.Mid(str4, checked (Start + 1), checked (num3 - Start - 1));
                      myEMail2._To_DisplayName = Strings.Trim(str4.Remove(checked (Start - 1), checked (num3 - Start + 1)));
                    }
                  }
                  else if (Operators.CompareString(Left, "return-path", false) == 0)
                    myEMail2._Return_path = md_MailFunctions.Remove_sidewall(str3);
                  else if (Operators.CompareString(Left, "subject", false) == 0)
                    myEMail2._Subject = md_MailFunctions.Convert_StrBase64AndCharset(str3);
                  else if (Operators.CompareString(Left, "date", false) == 0)
                  {
                    if (!DateTime.TryParse(str3, out myEMail2._Date))
                      myEMail2._Date = _VARIABLES.EmptyDate;
                  }
                  else if (Operators.CompareString(Left, "content-transfer-encoding", false) == 0)
                    myEMail2._Content_Transfer_Encoding = str3.ToLower();
                  else if (Operators.CompareString(Left, "content-type", false) == 0)
                  {
                    string[] strArray4 = str3.ToLower().Split(';');
                    if (strArray4.Length == 1)
                    {
                      myEMail2._Content_Type = str3.ToLower();
                      myEMail2._CT_Boundary = (string) null;
                      myEMail2._CT_Charset = (Encoding) null;
                    }
                    else
                    {
                      myEMail2._Content_Type = Strings.Trim(strArray4[0]);
                      int num3 = 1;
                      int num4 = Information.UBound((Array) strArray4, 1);
                      int index2 = num3;
                      while (index2 <= num4)
                      {
                        string[] strArray5 = Strings.Split(Strings.Trim(strArray4[index2]), "=", 2, CompareMethod.Binary);
                        if (strArray5.Length == 2)
                        {
                          strArray5[0] = Strings.Trim(strArray5[0]);
                          strArray5[1] = Strings.Trim(strArray5[1]);
                          if (Operators.CompareString(strArray5[0], "boundary", false) == 0)
                            myEMail2._CT_Boundary = strArray5[1];
                          else if (Operators.CompareString(strArray5[0], "charset", false) == 0)
                          {
                            string empty3 = string.Empty;
                            string str4 = strArray5[1].ToLower();
                            if (Operators.CompareString(str4, "cp1251", false) == 0)
                              str4 = "windows-1251";
                            myEMail2._CT_Charset = Encoding.GetEncoding(str4);
                          }
                        }
                        checked { ++index2; }
                      }
                    }
                  }
                  else if (Operators.CompareString(Left, "message-id", false) == 0)
                    myEMail2._Message_ID = md_MailFunctions.Remove_sidewall(str3);
                }
              }
              checked { ++index1; }
            }
            string transferEncoding = myEMail2._Content_Transfer_Encoding;
            if (Operators.CompareString(transferEncoding, "base64", false) == 0)
            {
              string s2 = s1.Replace("\r\n", string.Empty);
              myEMail2._Body = !Information.IsNothing((object) myEMail2._CT_Charset) ? myEMail2._CT_Charset.GetString(Convert.FromBase64String(s2)) : Encoding.UTF8.GetString(Convert.FromBase64String(s2));
            }
            else
              myEMail2._Body = Operators.CompareString(transferEncoding, "8bit", false) != 0 ? (Information.IsNothing((object) myEMail2._CT_Charset) ? s1 : myEMail2._CT_Charset.GetString(Encoding.Default.GetBytes(s1))) : (Information.IsNothing((object) myEMail2._CT_Charset) ? s1 : myEMail2._CT_Charset.GetString(Encoding.Default.GetBytes(s1)));
            myEMail1 = myEMail2;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ex POP3.RETR_Full: " + exception.Message;
        fn.TXT(ref sText);
        myEMail1 = (my_eMail) null;
        ProjectData.ClearProjectError();
      }
      return myEMail1;
    }

    public void DELE(int intMailItem)
    {
      try
      {
        this.SendData("DELE " + Conversions.ToString(intMailItem));
        if (this.WaitFor("+OK"))
          return;
        this.POPErrors("Unexpected Response Marking email for deletion: " + this.strDataIn);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new POP3Exception(ex.Message);
      }
    }

    public void QUIT()
    {
      try
      {
        this.SendData(nameof (QUIT));
        this.inStream.Close();
        this.POP3Stream.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new POP3Exception(ex.Message);
      }
    }

    public void SendData(string strCommand)
    {
      try
      {
        this.POP3Stream.Write(POP3.ConvertStringToByteArray(strCommand + "\r\n"), 0, checked (strCommand.Length + 2));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Mail no send";
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static byte[] ConvertStringToByteArray(string stringToConvert)
    {
      return new ASCIIEncoding().GetBytes(stringToConvert);
    }
  }
}
