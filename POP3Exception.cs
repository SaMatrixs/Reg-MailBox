// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.POP3Exception
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using System;

namespace MailRegUnicore
{
  [Serializable]
  public class POP3Exception : ApplicationException
  {
    public POP3Exception(string str)
      : base(str)
    {
    }
  }
}
