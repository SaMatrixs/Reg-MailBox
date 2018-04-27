// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.mdDebug
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic.CompilerServices;

namespace MailRegUnicore
{
  [StandardModule]
  internal sealed class mdDebug
  {
    public static SocketNET[] Debug_WS;
    private static object s;
    public static int DebVar;

    public static void Debug_WS_DataArrival(int Index)
    {
      checked { ++mdDebug.DebVar; }
      string sText = Conversions.ToString(Index) + "# Debug_WS Debug_WS_DataArrival " + Conversions.ToString(mdDebug.DebVar);
      _FUNCTION.SBTXT(ref sText);
    }

    public static void Debug_WS_ErrorEvent(int Index, ref string Description)
    {
      checked { ++mdDebug.DebVar; }
      string sText = Conversions.ToString(Index) + "# Debug_WS Ex: " + Description + "  DebVar: " + Conversions.ToString(mdDebug.DebVar);
      _FUNCTION.SBTXT(ref sText);
    }

    public static void Debug_WS_DebugEvent(int Index, ref object Value)
    {
    }
  }
}
