// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.Examples.System.Net.SslTcpClient
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MailRegUnicore.Examples.System.Net
{
  public class SslTcpClient
  {
    private static Hashtable certificateErrors = new Hashtable();

    public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors__1)
    {
      if (sslPolicyErrors__1 == SslPolicyErrors.None)
        return true;
      Console.WriteLine("Certificate error: {0}", (object) sslPolicyErrors__1);
      return false;
    }

    public static void RunClient(string machineName, string serverName)
    {
      TcpClient tcpClient = new TcpClient(machineName, 443);
      Console.WriteLine("Client connected.");
      SslStream sslStream = new SslStream((Stream) tcpClient.GetStream(), false, new RemoteCertificateValidationCallback(SslTcpClient.ValidateServerCertificate), (LocalCertificateSelectionCallback) null);
      try
      {
        sslStream.AuthenticateAsClient(serverName);
      }
      catch (AuthenticationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        AuthenticationException authenticationException = ex;
        Console.WriteLine("Exception: {0}", (object) authenticationException.Message);
        if (authenticationException.InnerException != null)
          Console.WriteLine("Inner exception: {0}", (object) authenticationException.InnerException.Message);
        Console.WriteLine("Authentication failed - closing the connection.");
        tcpClient.Close();
        ProjectData.ClearProjectError();
        return;
      }
      byte[] bytes = Encoding.UTF8.GetBytes("Hello from the client.<EOF>");
      sslStream.Write(bytes);
      sslStream.Flush();
      Console.WriteLine("Server says: {0}", (object) SslTcpClient.ReadMessage(sslStream));
      tcpClient.Close();
      Console.WriteLine("Client closed.");
    }

    private static string ReadMessage(SslStream sslStream)
    {
      byte[] numArray = new byte[2048];
      StringBuilder stringBuilder = new StringBuilder();
      int num;
      do
      {
        num = sslStream.Read(numArray, 0, numArray.Length);
        Decoder decoder = Encoding.UTF8.GetDecoder();
        char[] chars = new char[checked (decoder.GetCharCount(numArray, 0, num) - 1 + 1)];
        decoder.GetChars(numArray, 0, num, chars, 0);
        stringBuilder.Append(chars);
      }
      while (stringBuilder.ToString().IndexOf("<EOF>") == -1 && num != 0);
      return stringBuilder.ToString();
    }

    private static void DisplayUsage()
    {
      Console.WriteLine("To start the client specify:");
      Console.WriteLine("clientSync machineName [serverName]");
      Environment.Exit(1);
    }

    public static int Main(string[] args)
    {
      if (args == null || args.Length < 1)
        SslTcpClient.DisplayUsage();
      string machineName = args[0];
      string serverName = args.Length >= 2 ? args[1] : machineName;
      SslTcpClient.RunClient(machineName, serverName);
      return 0;
    }
  }
}
