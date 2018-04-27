// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.md_MySQL
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class md_MySQL
  {
    public static void UploadTo_MySQL()
    {
      try
      {
        string str1 = _INI.LoadINI("SQL", "txtDB_Host");
        string str2 = _INI.LoadINI("SQL", "txtDB_User");
        string str3 = _INI.LoadINI("SQL", "txtDB_Password");
        string str4 = _INI.LoadINI("SQL", "txtDB_Name");
        string str5 = _INI.LoadINI("SQL", "txtTableStorage");
        _INI.LoadINI("SQL", "txtTableBackup");
        MySqlConnection mySqlConnection = new MySqlConnection("Server=" + str1 + ";User id=" + str2 + ";password=" + str3 + ";database=" + str4 + "; character set=utf8");
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        string sText1 = "MySQL: Connect...";
        fn1.TXT(ref sText1);
        mySqlConnection.Open();
        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
        string sText2 = "MySQL: Connected - OK";
        fn2.TXT(ref sText2);
        int num1 = -(MyProject.Forms.frmSQL.chIgnoreSaleID.Checked ? 1 : 0);
        MySqlCommand mySqlCommand = new MySqlCommand();
        mySqlCommand.Connection = mySqlConnection;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int num2 = 0;
        string str6 = DateAndTime.Now.ToString();
        byte num3 = 0;
        MyProject.Forms.frmSQL.PB.Maximum = Information.UBound((Array) _VARIABLES.MailInfo, 1);
        MyProject.Forms.frmSQL.PB.Value = 0;
        StringBuilder stringBuilder = new StringBuilder();
        int num4 = 1;
        int num5 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
        int index = num4;
        while (index <= num5)
        {
          if (index % 500 == 0)
          {
            MyProject.Forms.frmSQL.PB.Value = index;
            Application.DoEvents();
          }
          if ((_VARIABLES.MailInfo[index].ID == 0 || num1 != 0) && ((int) _VARIABLES.MailInfo[index].Registered == 2 || (int) _VARIABLES.MailInfo[index].Registered == 3))
          {
            checked { ++num2; }
            _VARIABLES.MailInfo[index].ID = 1;
            stringBuilder.Append("INSERT INTO `" + str5 + "` (`ID`, `login`, `domain`, `password`, `Registered`, `RegUserData_Name`, `RegUserData_LastName`, `RegUserData_City`, `RegUserData_BirthDay`, `RegUserData_BirthMonth`, `RegUserData_BirthYear`, `RegUserData_SecretQuestion`, `RegUserData_SecretAnswer`, `RegUserData_ItsSecretQuestion`, `RegUserData_Sex`, `MailAmount`, `DataCreateBox`, `comment`, `DomainID`, `SaleID`, `DateAdd`, `DateSale`) VALUES (NULL , '" + _VARIABLES.MailInfo[index].login + "', '" + _VARIABLES.MailInfo[index].domain + "', '" + _VARIABLES.MailInfo[index].password + "', '" + Conversions.ToString((int) _VARIABLES.MailInfo[index].Registered) + "', '" + _VARIABLES.MailInfo[index].RegUserData.Name + "', '" + _VARIABLES.MailInfo[index].RegUserData.LastName + "', '" + _VARIABLES.MailInfo[index].RegUserData.City + "', '" + _VARIABLES.MailInfo[index].RegUserData.BirthDay + "', '" + _VARIABLES.MailInfo[index].RegUserData.BirthMonth + "', '" + _VARIABLES.MailInfo[index].RegUserData.BirthYear + "', '" + _VARIABLES.MailInfo[index].RegUserData.SecretQuestion + "', '" + _VARIABLES.MailInfo[index].RegUserData.SecretAnswer + "', '" + _VARIABLES.MailInfo[index].RegUserData.ItsSecretQuestion + "', '" + Conversions.ToString((int) _VARIABLES.MailInfo[index].RegUserData.Sex) + "', '" + Conversions.ToString(_VARIABLES.MailInfo[index].MailAmount) + "', '" + _VARIABLES.MailInfo[index].DataCreateBox + "', '" + _VARIABLES.MailInfo[index].comment + "', '" + Conversions.ToString((int) _VARIABLES.MailInfo[index].DomainID) + "', '" + Conversions.ToString(num3) + "', '" + str6 + "', '" + string.Empty + "');");
            if (stringBuilder.Length > 900000)
            {
              mySqlCommand.CommandText = stringBuilder.ToString();
              mySqlCommand.ExecuteNonQuery();
              stringBuilder = new StringBuilder();
            }
          }
          checked { ++index; }
        }
        if (stringBuilder.Length > 0)
        {
          mySqlCommand.CommandText = stringBuilder.ToString();
          mySqlCommand.ExecuteNonQuery();
        }
        MyProject.Forms.frmSQL.PB.Value = 0;
        mySqlConnection.Close();
        stopwatch.Stop();
        _LOADSAVE.SaveALL_MailInfo();
        MyProject.Forms.frmSQL.PB.Value = Information.UBound((Array) _VARIABLES.MailInfo, 1);
        _FUNCTION.clsTXT fn3 = _FUNCTION.FN;
        string sText3 = "MySQL: Uploaded - OK " + Conversions.ToString(num2) + " accounts [" + Conversions.ToString(stopwatch.ElapsedMilliseconds) + "ms]";
        fn3.TXT(ref sText3);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ex MySQL Upload: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }
  }
}
