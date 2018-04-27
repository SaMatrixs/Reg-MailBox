// Decompiled with JetBrains decompiler
// Type: MailRegUnicore._LOADSAVE
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class _LOADSAVE
  {
    public const string RepCRLF = "©";
    public const string RepCELL = "®";
    public const string RepCELL_5 = "®®®®®";
    public const string RepCELL_Multi = "®®®®®®®®®";

    public static void Load_BD_Mail()
    {
      try
      {
        string FullPath = Application.StartupPath + "\\data\\login_mail.txt";
        if (!File.Exists(FullPath))
          return;
        string str = _LOADSAVE.FileLoad(ref FullPath).Replace("\r", "").Replace("\t", "").Replace(" ", "");
        if (string.IsNullOrEmpty(str))
          return;
        _VARIABLES.BD_Mail = str.Split('\n');
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Загружено: " + Conversions.ToString(checked (Information.UBound((Array) _VARIABLES.BD_Mail, 1) + 1)) + " логинов для генерации e-mail.";
        fn.TXT(ref sText);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ошибка загрузки login_mail.txt: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static void Load_HttpLoadProxy()
    {
      try
      {
        string FullPath = Application.StartupPath + "\\data\\HttpLoadProxy_URL.txt";
        md_HttpLoadProxy.HttpLoadProxy.VALUE = new md_HttpLoadProxy.myValue_HttpLoadProxy[1];
        string str1 = _LOADSAVE.FileLoad(ref FullPath);
        if (str1.Length == 0)
          return;
        string[] strArray = str1.Replace("\r", "").Split('\n');
        md_HttpLoadProxy.HttpLoadProxy.VALUE = new md_HttpLoadProxy.myValue_HttpLoadProxy[checked (Information.UBound((Array) strArray, 1) + 1 + 1)];
        string str2 = "HTTP";
        int index1 = 0;
        int num1 = 0;
        int num2 = Information.UBound((Array) strArray, 1);
        int index2 = num1;
        while (index2 <= num2)
        {
          strArray[index2] = strArray[index2].Replace(" ", "");
          strArray[index2] = strArray[index2].Replace("\t", "");
          int num3 = Strings.InStr(strArray[index2], "'", CompareMethod.Binary);
          if (num3 > 0)
            strArray[index2] = Strings.Left(strArray[index2], checked (num3 - 1));
          if (strArray[index2].Length != 0)
          {
            if (Operators.CompareString(Strings.Left(strArray[index2].ToLower(), 9), "protocol=", false) == 0)
            {
              str2 = Strings.Right(strArray[index2], checked (strArray[index2].Length - 9));
            }
            else
            {
              checked { ++index1; }
              md_HttpLoadProxy.HttpLoadProxy.VALUE[index1].URL = strArray[index2];
              md_HttpLoadProxy.HttpLoadProxy.VALUE[index1].Protocol = str2;
            }
          }
          checked { ++index2; }
        }
        md_HttpLoadProxy.HttpLoadProxy.VALUE = (md_HttpLoadProxy.myValue_HttpLoadProxy[]) Utils.CopyArray((Array) md_HttpLoadProxy.HttpLoadProxy.VALUE, (Array) new md_HttpLoadProxy.myValue_HttpLoadProxy[checked (index1 + 1)]);
        MyProject.Forms.frmOptions.lblHttpLoadProxy_UrlCount.Text = Conversions.ToString(index1);
        if (index1 == 0)
          return;
        MyProject.Forms.frmOptions.cmbHttpLoadProxy.Items.Clear();
        int num4 = 1;
        int num5 = index1;
        int index3 = num4;
        while (index3 <= num5)
        {
          MyProject.Forms.frmOptions.cmbHttpLoadProxy.Items.Add((object) md_HttpLoadProxy.HttpLoadProxy.VALUE[index3].URL);
          checked { ++index3; }
        }
        MyProject.Forms.frmOptions.cmbHttpLoadProxy.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ошибка загрузки HttpLoadProxy_URL.txt: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static void LoadAll_MailInfo()
    {
      try
      {
        string path = Application.StartupPath + "\\data\\baseMail.dat";
        _VARIABLES.MailInfo = new _VARIABLES.meMailInfo[1];
        if (!File.Exists(path))
          return;
        BinaryReader binaryReader = new BinaryReader((Stream) File.Open(path, FileMode.Open));
        binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
        byte[] bytes = binaryReader.ReadBytes(checked ((int) binaryReader.BaseStream.Length));
        binaryReader.Close();
        if (bytes.Length == 0)
          return;
        string[] strArray1 = Encoding.Default.GetString(bytes, 0, bytes.Length).Split('\n');
        _VARIABLES.MailInfo = new _VARIABLES.meMailInfo[checked (Information.UBound((Array) strArray1, 1) + 1)];
        int num1 = 1;
        int num2 = Information.UBound((Array) strArray1, 1);
        int index = num1;
        int num3;
        while (index <= num2)
        {
          string[] strArray2 = strArray1[checked (index - 1)].Split('®');
          _VARIABLES.MailInfo[index].login = strArray2[0];
          _VARIABLES.MailInfo[index].domain = strArray2[1];
          _VARIABLES.MailInfo[index].password = strArray2[2];
          _VARIABLES.MailInfo[index].Registered = Conversions.ToShort(strArray2[3]);
          if ((int) _VARIABLES.MailInfo[index].Registered == 2 | (int) _VARIABLES.MailInfo[index].Registered == 3)
            checked { ++num3; }
          _VARIABLES.MailInfo[index].RegUserData.Name = strArray2[4];
          _VARIABLES.MailInfo[index].RegUserData.LastName = strArray2[5];
          _VARIABLES.MailInfo[index].RegUserData.City = strArray2[6];
          _VARIABLES.MailInfo[index].RegUserData.BirthDay = strArray2[7];
          _VARIABLES.MailInfo[index].RegUserData.BirthMonth = strArray2[8];
          _VARIABLES.MailInfo[index].RegUserData.BirthYear = strArray2[9];
          _VARIABLES.MailInfo[index].RegUserData.SecretQuestion = strArray2[10];
          _VARIABLES.MailInfo[index].RegUserData.SecretAnswer = strArray2[11];
          _VARIABLES.MailInfo[index].RegUserData.ItsSecretQuestion = strArray2[12];
          _VARIABLES.MailInfo[index].RegUserData.Sex = Conversions.ToShort(strArray2[13]);
          _VARIABLES.MailInfo[index].MailAmount = checked ((int) Math.Round(Conversion.Val(strArray2[14])));
          _VARIABLES.MailInfo[index].DataCreateBox = strArray2[15];
          _VARIABLES.MailInfo[index].comment = strArray2[16];
          _VARIABLES.MailInfo[index].DomainID = checked ((short) Math.Round(Conversion.Val(strArray2[17])));
          _VARIABLES.MailInfo[index].ID = checked ((int) Math.Round(Conversion.Val(strArray2[18])));
          checked { ++index; }
        }
        string sText;
        if (num3 > 0)
        {
          _FUNCTION.clsTXT fn = _FUNCTION.FN;
          sText = "Загружено: " + Conversions.ToString(num3) + " зарегистрированных e-mail.";
          fn.TXT(ref sText);
        }
        if (checked (Information.UBound((Array) strArray1, 1) - num3) <= 0)
          return;
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        sText = "Загружено: " + Conversions.ToString(checked (Information.UBound((Array) strArray1, 1) - num3)) + " заготовок для регистрации.";
        fn1.TXT(ref sText);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ошибка загрузки baseMail.dat: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void SaveOne_MailInfo(int Index)
    {
      StringBuilder stringBuilder = new StringBuilder("");
      stringBuilder.Append(_VARIABLES.MailInfo[Index].login + "®" + _VARIABLES.MailInfo[Index].domain + "®" + _VARIABLES.MailInfo[Index].password + "®" + Conversions.ToString((int) _VARIABLES.MailInfo[Index].Registered) + "®" + _VARIABLES.MailInfo[Index].RegUserData.Name + "®" + _VARIABLES.MailInfo[Index].RegUserData.LastName + "®" + _VARIABLES.MailInfo[Index].RegUserData.City + "®" + _VARIABLES.MailInfo[Index].RegUserData.BirthDay + "®" + _VARIABLES.MailInfo[Index].RegUserData.BirthMonth + "®" + _VARIABLES.MailInfo[Index].RegUserData.BirthYear + "®" + _VARIABLES.MailInfo[Index].RegUserData.SecretQuestion + "®" + _VARIABLES.MailInfo[Index].RegUserData.SecretAnswer + "®" + _VARIABLES.MailInfo[Index].RegUserData.ItsSecretQuestion + "®" + Conversions.ToString((int) _VARIABLES.MailInfo[Index].RegUserData.Sex) + "®" + Conversions.ToString(_VARIABLES.MailInfo[Index].MailAmount) + "®" + _VARIABLES.MailInfo[Index].DataCreateBox + "®" + _VARIABLES.MailInfo[Index].comment + "®" + Conversions.ToString((int) _VARIABLES.MailInfo[Index].DomainID) + "®" + Conversions.ToString(_VARIABLES.MailInfo[Index].ID) + "®®®®®");
      stringBuilder.Append(Strings.Space(checked (999 - stringBuilder.Length)) + "\n");
      string FileName = Application.StartupPath + "\\data\\baseMail.dat";
      int FileNumber = FileSystem.FreeFile();
      FileSystem.FileOpen(FileNumber, FileName, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1);
      FileSystem.FilePut(FileNumber, stringBuilder.ToString(), (long) checked ((Index - 1) * 1000 + 1), false);
      FileSystem.FileClose(FileNumber);
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void SaveALL_MailInfo()
    {
      StringBuilder stringBuilder = new StringBuilder("");
      int num1 = 1;
      int num2 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
      int index = num1;
      while (index <= num2)
      {
        string str = _VARIABLES.MailInfo[index].login + "®" + _VARIABLES.MailInfo[index].domain + "®" + _VARIABLES.MailInfo[index].password + "®" + Conversions.ToString((int) _VARIABLES.MailInfo[index].Registered) + "®" + _VARIABLES.MailInfo[index].RegUserData.Name + "®" + _VARIABLES.MailInfo[index].RegUserData.LastName + "®" + _VARIABLES.MailInfo[index].RegUserData.City + "®" + _VARIABLES.MailInfo[index].RegUserData.BirthDay + "®" + _VARIABLES.MailInfo[index].RegUserData.BirthMonth + "®" + _VARIABLES.MailInfo[index].RegUserData.BirthYear + "®" + _VARIABLES.MailInfo[index].RegUserData.SecretQuestion + "®" + _VARIABLES.MailInfo[index].RegUserData.SecretAnswer + "®" + _VARIABLES.MailInfo[index].RegUserData.ItsSecretQuestion + "®" + Conversions.ToString((int) _VARIABLES.MailInfo[index].RegUserData.Sex) + "®" + Conversions.ToString(_VARIABLES.MailInfo[index].MailAmount) + "®" + _VARIABLES.MailInfo[index].DataCreateBox + "®" + _VARIABLES.MailInfo[index].comment + "®" + Conversions.ToString((int) _VARIABLES.MailInfo[index].DomainID) + "®" + Conversions.ToString(_VARIABLES.MailInfo[index].ID) + "®®®®®";
        stringBuilder.Append(str + Strings.Space(checked (999 - str.Length)) + "\n");
        checked { ++index; }
      }
      string str1 = Application.StartupPath + "\\data\\baseMail.dat";
      if (File.Exists(str1))
        FileSystem.Kill(str1);
      if (stringBuilder.Length == 0)
        return;
      byte[] bytes = Encoding.Default.GetBytes(stringBuilder.ToString());
      FileStream fileStream = new FileStream(str1, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
      fileStream.Seek(0L, SeekOrigin.Begin);
      fileStream.Write(bytes, 0, bytes.Length);
      fileStream.Close();
    }

    public static void LoadProxy()
    {
      try
      {
        string FullPath = Application.StartupPath + "\\data\\proxy.txt";
        _VARIABLES.Proxy = new myProxy[1];
        if (File.Exists(FullPath))
        {
          string str1 = _LOADSAVE.FileLoad(ref FullPath);
          if (str1 != null && str1.Length != 0)
          {
            string[] strArray1 = Strings.Split(str1.Replace("\r", ""), "\n", -1, CompareMethod.Binary);
            _VARIABLES.Proxy = new myProxy[checked (Information.UBound((Array) strArray1, 1) + 1 + 1)];
            int index1 = 0;
            string str2 = string.Empty;
            string str3 = string.Empty;
            int num1 = 8080;
            ProtocolProxy protocolProxy = ProtocolProxy.HTTP;
            int[] numArray1 = new int[5];
            int num2 = 0;
            int num3 = 0;
            int num4 = Information.UBound((Array) strArray1, 1);
            int index2 = num3;
            while (index2 <= num4)
            {
              if (strArray1[index2].Length != 0)
              {
                string[] strArray2 = strArray1[index2].Split('\'');
                if (strArray2[0].Length != 0)
                {
                  strArray2[0] = Strings.Replace(strArray2[0], " ", "", 1, -1, CompareMethod.Binary);
                  strArray2[0] = Strings.Replace(strArray2[0], "\t", "", 1, -1, CompareMethod.Binary);
                  if (!Information.IsNothing((object) strArray2[0]))
                  {
                    if (Operators.CompareString(Strings.LCase(Strings.Left(strArray2[0], 6)), "login=", false) == 0)
                      str2 = Strings.Right(strArray2[0], checked (Strings.Len(strArray2[0]) - 6));
                    else if (Operators.CompareString(Strings.LCase(Strings.Left(strArray2[0], 9)), "password=", false) == 0)
                      str3 = Strings.Right(strArray2[0], checked (Strings.Len(strArray2[0]) - 9));
                    else if (Operators.CompareString(Strings.LCase(Strings.Left(strArray2[0], 5)), "port=", false) == 0)
                      num1 = checked ((int) Math.Round(Conversion.Val(Strings.Right(strArray2[0], Strings.Len(strArray2[0]) - 5))));
                    else if (Operators.CompareString(Strings.LCase(Strings.Left(strArray2[0], 9)), "protocol=", false) == 0)
                    {
                      string lower = Strings.Right(strArray2[0], checked (Strings.Len(strArray2[0]) - 9)).ToLower();
                      string Left = lower;
                      if (Operators.CompareString(Left, "http", false) == 0)
                      {
                        protocolProxy = ProtocolProxy.HTTP;
                        num2 = 0;
                      }
                      else if (Operators.CompareString(Left, "https", false) == 0)
                      {
                        protocolProxy = ProtocolProxy.HTTPs;
                        num2 = 1;
                      }
                      else if (Operators.CompareString(Left, "socks4", false) == 0)
                      {
                        protocolProxy = ProtocolProxy.SOCKS4;
                        num2 = 2;
                      }
                      else if (Operators.CompareString(Left, "socks4a", false) == 0)
                      {
                        protocolProxy = ProtocolProxy.SOCKS4a;
                        num2 = 3;
                      }
                      else if (Operators.CompareString(Left, "socks5", false) == 0)
                      {
                        protocolProxy = ProtocolProxy.SOCKS5;
                        num2 = 4;
                      }
                      else
                      {
                        _FUNCTION.clsTXT fn = _FUNCTION.FN;
                        string sText = "Unknown protocol Proxy: " + lower;
                        fn.TXT(ref sText);
                        protocolProxy = ProtocolProxy.HTTP;
                        num2 = 0;
                      }
                    }
                    else if (Operators.CompareString(strArray2[0].ToLower(), "end", false) != 0)
                    {
                      if (Strings.InStr(strArray2[0], ".", CompareMethod.Binary) != 0)
                      {
                        string[] strArray3 = Strings.Split(strArray2[0], ":", -1, CompareMethod.Binary);
                        checked { ++index1; }
                        _VARIABLES.Proxy[index1] = new myProxy();
                        _VARIABLES.Proxy[index1].IP = strArray3[0];
                        _VARIABLES.Proxy[index1].Port = Information.UBound((Array) strArray3, 1) <= 0 ? num1 : checked ((int) Math.Round(Conversion.Val(strArray3[1])));
                        int[] numArray2 = numArray1;
                        int[] numArray3 = numArray2;
                        int index3 = num2;
                        int index4 = index3;
                        int num5 = checked (numArray2[index3] + 1);
                        numArray3[index4] = num5;
                        _VARIABLES.Proxy[index1].Login = str2;
                        _VARIABLES.Proxy[index1].Password = str3;
                        _VARIABLES.Proxy[index1].Protocol = protocolProxy;
                      }
                    }
                    else
                      break;
                  }
                }
              }
              checked { ++index2; }
            }
            _VARIABLES.Proxy = (myProxy[]) Utils.CopyArray((Array) _VARIABLES.Proxy, (Array) new myProxy[checked (index1 + 1)]);
            if (numArray1[0] > 0)
            {
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = "Загружено Proxy HTTP: " + Conversions.ToString(numArray1[0]);
              fn.TXT(ref sText);
            }
            if (numArray1[1] > 0)
            {
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = "Загружено Proxy HTTPs: " + Conversions.ToString(numArray1[1]);
              fn.TXT(ref sText);
            }
            if (numArray1[2] > 0)
            {
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = "Загружено Proxy SOCKS4: " + Conversions.ToString(numArray1[2]);
              fn.TXT(ref sText);
            }
            if (numArray1[3] > 0)
            {
              _FUNCTION.clsTXT fn = _FUNCTION.FN;
              string sText = "Загружено Proxy SOCKS4a: " + Conversions.ToString(numArray1[3]);
              fn.TXT(ref sText);
            }
            if (numArray1[4] <= 0)
              return;
            _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
            string sText1 = "Загружено Proxy SOCKS5: " + Conversions.ToString(numArray1[4]);
            fn1.TXT(ref sText1);
            return;
          }
        }
        _FUNCTION.clsTXT fn2 = _FUNCTION.FN;
        string sText2 = "Proxy list is empty.";
        fn2.TXT(ref sText2);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ошибка загрузки proxy.txt: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static void LoadBannedProxy()
    {
      try
      {
        string FullPath = Application.StartupPath + "\\data\\BannedProxy.txt";
        _VARIABLES.BannedProxy = new string[1];
        if (File.Exists(FullPath))
        {
          string str = _LOADSAVE.FileLoad(ref FullPath);
          if (str != null && str.Length != 0)
          {
            string[] strArray = Strings.Split(str.Replace("\r", ""), "\n", -1, CompareMethod.Binary);
            _VARIABLES.BannedProxy = new string[checked (Information.UBound((Array) strArray, 1) + 1 + 1)];
            int index1 = 0;
            int num1 = 0;
            int num2 = Information.UBound((Array) strArray, 1);
            int index2 = num1;
            while (index2 <= num2)
            {
              if (strArray[index2].Length > 0)
              {
                checked { ++index1; }
                _VARIABLES.BannedProxy[index1] = strArray[index2];
              }
              checked { ++index2; }
            }
            _VARIABLES.BannedProxy = (string[]) Utils.CopyArray((Array) _VARIABLES.BannedProxy, (Array) new string[checked (index1 + 1)]);
            _FUNCTION.clsTXT fn = _FUNCTION.FN;
            string sText = "Загружен список Banned Proxy: " + Conversions.ToString(index1);
            fn.TXT(ref sText);
            return;
          }
        }
        _FUNCTION.clsTXT fn1 = _FUNCTION.FN;
        string sText1 = "Banned Proxy list is empty.";
        fn1.TXT(ref sText1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ошибка загрузки proxy.txt: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static void LoadName_M()
    {
      try
      {
        _VARIABLES.M_UserName = new string[1];
        _VARIABLES.M_UserLastName = new string[1];
        string FullPath1 = Application.StartupPath + "\\data\\male-name.txt";
        if (File.Exists(FullPath1))
        {
          string[] strArray = Strings.Split(_LOADSAVE.FileLoad(ref FullPath1).Replace("\r", ""), "\n", -1, CompareMethod.Binary);
          _VARIABLES.M_UserName = new string[checked (Information.UBound((Array) strArray, 1) + 1)];
          int index1 = 0;
          int num1 = 1;
          int num2 = Information.UBound((Array) strArray, 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (Strings.Len(strArray[index2]) > 0)
            {
              checked { ++index1; }
              _VARIABLES.M_UserName[index1] = strArray[index2];
            }
            checked { ++index2; }
          }
          _VARIABLES.M_UserName = (string[]) Utils.CopyArray((Array) _VARIABLES.M_UserName, (Array) new string[checked (index1 + 1)]);
        }
        string FullPath2 = Application.StartupPath + "\\data\\male-lastname.txt";
        if (File.Exists(FullPath2))
        {
          string[] strArray = Strings.Split(_LOADSAVE.FileLoad(ref FullPath2).Replace("\r", ""), "\n", -1, CompareMethod.Binary);
          _VARIABLES.M_UserLastName = new string[checked (Information.UBound((Array) strArray, 1) + 1)];
          int index1 = 0;
          int num1 = 1;
          int num2 = Information.UBound((Array) strArray, 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (Strings.Len(strArray[index2]) > 0)
            {
              checked { ++index1; }
              _VARIABLES.M_UserLastName[index1] = strArray[index2];
            }
            checked { ++index2; }
          }
          _VARIABLES.M_UserLastName = (string[]) Utils.CopyArray((Array) _VARIABLES.M_UserLastName, (Array) new string[checked (index1 + 1)]);
        }
        MyProject.Forms.frmMain.stlbl_1.Text = "<M> Имен: " + Conversions.ToString(Information.UBound((Array) _VARIABLES.M_UserName, 1));
        MyProject.Forms.frmMain.stlbl_2.Text = "<M> Фамилий: " + Conversions.ToString(Information.UBound((Array) _VARIABLES.M_UserLastName, 1));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ошибка загрузки male-name.txt male-lastname.txt: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static void LoadName_J()
    {
      try
      {
        _VARIABLES.J_UserName = new string[1];
        _VARIABLES.J_UserLastName = new string[1];
        string FullPath1 = Application.StartupPath + "\\data\\female-name.txt";
        if (File.Exists(FullPath1))
        {
          string[] strArray = Strings.Split(_LOADSAVE.FileLoad(ref FullPath1).Replace("\r", ""), "\n", -1, CompareMethod.Binary);
          _VARIABLES.J_UserName = new string[checked (Information.UBound((Array) strArray, 1) + 1)];
          int index1 = 0;
          int num1 = 1;
          int num2 = Information.UBound((Array) strArray, 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (Strings.Len(strArray[index2]) > 0)
            {
              checked { ++index1; }
              _VARIABLES.J_UserName[index1] = strArray[index2];
            }
            checked { ++index2; }
          }
          _VARIABLES.J_UserName = (string[]) Utils.CopyArray((Array) _VARIABLES.J_UserName, (Array) new string[checked (index1 + 1)]);
        }
        string FullPath2 = Application.StartupPath + "\\data\\female-lastname.txt";
        if (File.Exists(FullPath2))
        {
          string[] strArray = Strings.Split(_LOADSAVE.FileLoad(ref FullPath2).Replace("\r", ""), "\n", -1, CompareMethod.Binary);
          _VARIABLES.J_UserLastName = new string[checked (Information.UBound((Array) strArray, 1) + 1)];
          int index1 = 0;
          int num1 = 1;
          int num2 = Information.UBound((Array) strArray, 1);
          int index2 = num1;
          while (index2 <= num2)
          {
            if (Strings.Len(strArray[index2]) > 0)
            {
              checked { ++index1; }
              _VARIABLES.J_UserLastName[index1] = strArray[index2];
            }
            checked { ++index2; }
          }
          _VARIABLES.J_UserLastName = (string[]) Utils.CopyArray((Array) _VARIABLES.J_UserLastName, (Array) new string[checked (index1 + 1)]);
        }
        MyProject.Forms.frmMain.stlbl_3.Text = "<Ж> Имен: " + Conversions.ToString(Information.UBound((Array) _VARIABLES.J_UserName, 1));
        MyProject.Forms.frmMain.stlbl_4.Text = "<Ж> Фамилий: " + Conversions.ToString(Information.UBound((Array) _VARIABLES.J_UserLastName, 1));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ошибка загрузки female-name.txt female-lastname.txt: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static void LoadVPN()
    {
      string FullPath = Application.StartupPath + "\\data\\VPN.txt";
      RAS_Variable.VPN = new RAS_Variable.meVPN[1];
      if (!File.Exists(FullPath))
        return;
      string[] strArray1 = Strings.Split(_LOADSAVE.FileLoad(ref FullPath).Replace("\r", ""), "\n", -1, CompareMethod.Binary);
      RAS_Variable.VPN = new RAS_Variable.meVPN[checked (Information.UBound((Array) strArray1, 1) + 1 + 1)];
      int index1 = 0;
      string str1 = "";
      string str2 = "";
      try
      {
        int num1 = 0;
        int num2 = Information.UBound((Array) strArray1, 1);
        int index2 = num1;
        while (index2 <= num2)
        {
          if (Strings.Len(strArray1[index2]) != 0)
          {
            string[] strArray2 = Strings.Split(strArray1[index2], "'", -1, CompareMethod.Binary);
            strArray2[0] = Strings.Replace(strArray2[0], " ", "", 1, -1, CompareMethod.Binary);
            strArray2[0] = Strings.Replace(strArray2[0], "\t", "", 1, -1, CompareMethod.Binary);
            if (Operators.CompareString(Strings.LCase(Strings.Left(strArray2[0], 6)), "login=", false) == 0)
              str1 = Strings.Right(strArray2[0], checked (Strings.Len(strArray2[0]) - 6));
            else if (Operators.CompareString(Strings.LCase(Strings.Left(strArray2[0], 9)), "password=", false) == 0)
              str2 = Strings.Right(strArray2[0], checked (Strings.Len(strArray2[0]) - 9));
            else if (Strings.InStr(strArray2[0], ".", CompareMethod.Binary) != 0)
            {
              checked { ++index1; }
              RAS_Variable.VPN[index1].PhoneNumber = strArray2[0];
              RAS_Variable.VPN[index1].Login = str1;
              RAS_Variable.VPN[index1].Password = str2;
            }
          }
          checked { ++index2; }
        }
        RAS_Variable.VPN = (RAS_Variable.meVPN[]) Utils.CopyArray((Array) RAS_Variable.VPN, (Array) new RAS_Variable.meVPN[checked (index1 + 1)]);
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Загружено VPN.txt: " + Conversions.ToString(index1);
        fn.TXT(ref sText);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string message = exception.Message;
        fn.TXT(ref message);
        ProjectData.ClearProjectError();
      }
    }

    public static string FileLoad(ref string FullPath)
    {
      string str = "";
      try
      {
        if (!File.Exists(FullPath))
          return str;
        FileStream fileStream = new FileStream(FullPath, FileMode.Open);
        fileStream.Seek(0L, SeekOrigin.Begin);
        byte[] numArray = new byte[checked ((int) (fileStream.Length - 1L) + 1)];
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        str = Encoding.Default.GetString(numArray, 0, numArray.Length);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "FileLoad Ex: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public static byte[] FileLoad_Byte(ref string FullPath)
    {
      try
      {
        if (!File.Exists(FullPath))
          return (byte[]) null;
        FileStream fileStream = new FileStream(FullPath, FileMode.Open);
        fileStream.Seek(0L, SeekOrigin.Begin);
        byte[] array = new byte[checked ((int) (fileStream.Length - 1L) + 1)];
        fileStream.Read(array, 0, array.Length);
        fileStream.Close();
        return array;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "FileLoad Ex: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
      return (byte[]) null;
    }

    public static void FileSave(ref string FullPath, ref string StrBuffer)
    {
      try
      {
        if (File.Exists(FullPath))
          File.Delete(FullPath);
        byte[] bytes = Encoding.Default.GetBytes(StrBuffer);
        FileStream fileStream = new FileStream(FullPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
        fileStream.Seek(0L, SeekOrigin.Begin);
        fileStream.Write(bytes, 0, bytes.Length);
        fileStream.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "FileSave Ex: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static void FileSave(ref string FullPath, ref byte[] byteBuffer)
    {
      try
      {
        if (File.Exists(FullPath))
          File.Delete(FullPath);
        FileStream fileStream = new FileStream(FullPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
        fileStream.Seek(0L, SeekOrigin.Begin);
        fileStream.Write(byteBuffer, 0, byteBuffer.Length);
        fileStream.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "FileSave Ex: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static void FileAppend(ref string FullPath, ref string StrBuffer)
    {
      try
      {
        byte[] bytes = Encoding.Default.GetBytes(StrBuffer);
        FileStream fileStream = new FileStream(FullPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
        fileStream.Seek(fileStream.Length, SeekOrigin.Begin);
        fileStream.Write(bytes, 0, bytes.Length);
        fileStream.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "FileAppend Ex: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static void FileAppend(ref string FullPath, ref byte[] byteBuffer)
    {
      try
      {
        FileStream fileStream = new FileStream(FullPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
        fileStream.Seek(fileStream.Length, SeekOrigin.Begin);
        fileStream.Write(byteBuffer, 0, byteBuffer.Length);
        fileStream.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "FileAppend Ex: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }

    public static void Save(ref string sFileName, ref string sData)
    {
      string str = Application.StartupPath + "\\data\\" + sFileName;
      _LOADSAVE.FileSave(ref sFileName, ref sData);
    }
  }
}
