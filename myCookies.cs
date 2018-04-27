// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.myCookies
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Linq;

namespace MailRegUnicore
{
  public class myCookies : Hashtable
  {
    public void Add(string Name, string Value)
    {
      if (this.ContainsKey((object) Name))
        this.Remove((object) Name);
      this.Add((object) Name, (object) Value);
    }

    public void Add(myCookies _myCookies)
    {
      if (Information.IsNothing((object) _myCookies))
        return;
      try
      {
        int num1 = 0;
        int num2 = checked (_myCookies.Count - 1);
        int index = num1;
        while (index <= num2)
        {
          string str1 = _myCookies.Values.Cast<object>().ElementAtOrDefault<object>(index).ToString();
          if (str1.Length > 0)
          {
            this.Add(_myCookies.Keys.Cast<object>().ElementAtOrDefault<object>(index).ToString(), str1);
          }
          else
          {
            string str2 = _myCookies.Keys.Cast<object>().ElementAtOrDefault<object>(index).ToString();
            if (this.ContainsKey((object) str2))
              this.Remove((object) str2);
          }
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        _FUNCTION.clsTXT fn = _FUNCTION.FN;
        string sText = "Ex myCookies.Add: " + exception.Message;
        fn.TXT(ref sText);
        ProjectData.ClearProjectError();
      }
    }
  }
}
