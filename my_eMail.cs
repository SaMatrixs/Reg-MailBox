// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.my_eMail
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using System;
using System.Collections;
using System.Text;

namespace MailRegUnicore
{
  public class my_eMail
  {
    public string _Head;
    public string _Body;
    public string _From_Address;
    public string _From_DisplayName;
    public string _To_Address;
    public string _To_DisplayName;
    public string _Return_path;
    public string _Subject;
    public DateTime _Date;
    public string _Content_Transfer_Encoding;
    public string _Content_Type;
    public Encoding _CT_Charset;
    public string _CT_Boundary;
    public string _Message_ID;
    public Hashtable _HeadLine;

    public my_eMail()
    {
      this._Head = (string) null;
      this._Body = (string) null;
      this._From_Address = (string) null;
      this._From_DisplayName = (string) null;
      this._To_Address = (string) null;
      this._To_DisplayName = (string) null;
      this._Subject = (string) null;
      this._Date = new DateTime();
      this._Content_Transfer_Encoding = (string) null;
      this._Content_Type = (string) null;
      this._CT_Charset = (Encoding) null;
      this._CT_Boundary = (string) null;
      this._Message_ID = (string) null;
      this._HeadLine = (Hashtable) null;
    }
  }
}
