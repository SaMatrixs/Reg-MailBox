// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.My.Resources.Resources
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MailRegUnicore.My.Resources
{
  [StandardModule]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [HideModuleName]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) MailRegUnicore.My.Resources.Resources.resourceMan, (object) null))
          MailRegUnicore.My.Resources.Resources.resourceMan = new ResourceManager("MailRegUnicore.Resources", typeof (MailRegUnicore.My.Resources.Resources).Assembly);
        return MailRegUnicore.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return MailRegUnicore.My.Resources.Resources.resourceCulture;
      }
      set
      {
        MailRegUnicore.My.Resources.Resources.resourceCulture = value;
      }
    }
  }
}
