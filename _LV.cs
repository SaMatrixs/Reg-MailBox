// Decompiled with JetBrains decompiler
// Type: MailRegUnicore._LV
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using MailRegUnicore.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class _LV
  {
    public static void LV_ADD_ALL()
    {
      MyProject.Forms.frmMain.pbGenLogin.Maximum = Information.UBound((Array) _VARIABLES.MailInfo, 1);
      MyProject.Forms.frmMain.pbGenLogin.Value = 0;
      int num1 = Information.UBound((Array) _VARIABLES.MailInfo, 1) / 90;
      if (num1 == 0)
        num1 = 1;
      MyProject.Forms.frmMain.LV.BeginUpdate();
      MyProject.Forms.frmMain.LV.Items.Clear();
      if (Information.UBound((Array) _VARIABLES.MailInfo, 1) != 0)
      {
        ListViewItem[] listViewItemArray = new ListViewItem[checked (Information.UBound((Array) _VARIABLES.MailInfo, 1) - 1 + 1)];
        string[] items = new string[8];
        int num2 = 1;
        int num3 = Information.UBound((Array) _VARIABLES.MailInfo, 1);
        int index = num2;
        while (index <= num3)
        {
          if (index % num1 == 0)
          {
            MyProject.Forms.frmMain.pbGenLogin.Value = index;
            Application.DoEvents();
          }
          items[0] = Conversions.ToString(index);
          items[1] = _VARIABLES.MailInfo[index].login;
          items[2] = "@" + _VARIABLES.MailInfo[index].domain;
          items[3] = _VARIABLES.MailInfo[index].RegUserData.Name;
          items[4] = _VARIABLES.MailInfo[index].RegUserData.LastName;
          items[5] = _VARIABLES.MailInfo[index].DataCreateBox;
          items[6] = Conversions.ToString(_VARIABLES.MailInfo[index].MailAmount);
          items[7] = _VARIABLES.MailInfo[index].comment;
          listViewItemArray[checked (index - 1)] = new ListViewItem(items, (int) _VARIABLES.MailInfo[index].Registered);
          checked { ++index; }
        }
        MyProject.Forms.frmMain.LV.Items.AddRange(((IEnumerable<ListViewItem>) listViewItemArray).ToArray<ListViewItem>());
      }
      MyProject.Forms.frmMain.LV.EndUpdate();
      MyProject.Forms.frmMain.pbGenLogin.Value = MyProject.Forms.frmMain.pbGenLogin.Maximum;
    }
  }
}
