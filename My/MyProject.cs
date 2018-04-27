// Decompiled with JetBrains decompiler
// Type: MailRegUnicore.My.MyProject
// Assembly: Mailbox@Reg, Version=1.74.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1A797335-3842-4818-9AC2-BECDB7B3D956
// Assembly location: C:\Users\user\Desktop\Софтинушка\mails\mailbox@reg\Mailbox@Reg.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MailRegUnicore.My
{
  [StandardModule]
  [GeneratedCode("MyTemplate", "10.0.0.0")]
  [HideModuleName]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get
      {
        return MyProject.m_ComputerObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get
      {
        return MyProject.m_AppObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get
      {
        return MyProject.m_UserObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyFormsObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyWebServicesObjectProvider.GetInstance;
      }
    }

    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyForms
    {
      public AboutBox m_AboutBox;
      public frmGenBlank m_frmGenBlank;
      public frmMain m_frmMain;
      public frmMain_RasDialex m_frmMain_RasDialex;
      public frmMessafeQIP m_frmMessafeQIP;
      public frmNewCaptchaMailRU m_frmNewCaptchaMailRU;
      public frmOptions m_frmOptions;
      public frmSQL m_frmSQL;
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;

      public AboutBox AboutBox
      {
        get
        {
          this.m_AboutBox = MyProject.MyForms.Create__Instance__<AboutBox>(this.m_AboutBox);
          return this.m_AboutBox;
        }
        set
        {
          if (value == this.m_AboutBox)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<AboutBox>(ref this.m_AboutBox);
        }
      }

      public frmGenBlank frmGenBlank
      {
        get
        {
          this.m_frmGenBlank = MyProject.MyForms.Create__Instance__<frmGenBlank>(this.m_frmGenBlank);
          return this.m_frmGenBlank;
        }
        set
        {
          if (value == this.m_frmGenBlank)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<frmGenBlank>(ref this.m_frmGenBlank);
        }
      }

      public frmMain frmMain
      {
        get
        {
          this.m_frmMain = MyProject.MyForms.Create__Instance__<frmMain>(this.m_frmMain);
          return this.m_frmMain;
        }
        set
        {
          if (value == this.m_frmMain)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<frmMain>(ref this.m_frmMain);
        }
      }

      public frmMain_RasDialex frmMain_RasDialex
      {
        get
        {
          this.m_frmMain_RasDialex = MyProject.MyForms.Create__Instance__<frmMain_RasDialex>(this.m_frmMain_RasDialex);
          return this.m_frmMain_RasDialex;
        }
        set
        {
          if (value == this.m_frmMain_RasDialex)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<frmMain_RasDialex>(ref this.m_frmMain_RasDialex);
        }
      }

      public frmMessafeQIP frmMessafeQIP
      {
        get
        {
          this.m_frmMessafeQIP = MyProject.MyForms.Create__Instance__<frmMessafeQIP>(this.m_frmMessafeQIP);
          return this.m_frmMessafeQIP;
        }
        set
        {
          if (value == this.m_frmMessafeQIP)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<frmMessafeQIP>(ref this.m_frmMessafeQIP);
        }
      }

      public frmNewCaptchaMailRU frmNewCaptchaMailRU
      {
        get
        {
          this.m_frmNewCaptchaMailRU = MyProject.MyForms.Create__Instance__<frmNewCaptchaMailRU>(this.m_frmNewCaptchaMailRU);
          return this.m_frmNewCaptchaMailRU;
        }
        set
        {
          if (value == this.m_frmNewCaptchaMailRU)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<frmNewCaptchaMailRU>(ref this.m_frmNewCaptchaMailRU);
        }
      }

      public frmOptions frmOptions
      {
        get
        {
          this.m_frmOptions = MyProject.MyForms.Create__Instance__<frmOptions>(this.m_frmOptions);
          return this.m_frmOptions;
        }
        set
        {
          if (value == this.m_frmOptions)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<frmOptions>(ref this.m_frmOptions);
        }
      }

      public frmSQL frmSQL
      {
        get
        {
          this.m_frmSQL = MyProject.MyForms.Create__Instance__<frmSQL>(this.m_frmSQL);
          return this.m_frmSQL;
        }
        set
        {
          if (value == this.m_frmSQL)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<frmSQL>(ref this.m_frmSQL);
        }
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        if ((object) Instance != null && !Instance.IsDisposed)
          return Instance;
        if (MyProject.MyForms.m_FormBeingCreated != null)
        {
          if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
        }
        else
          MyProject.MyForms.m_FormBeingCreated = new Hashtable();
        MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
        try
        {
          return Activator.CreateInstance<T>();
        }
        catch (TargetInvocationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          if (ex.InnerException != null)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
        }
        finally
        {
          MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
        }
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public MyForms()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new Type GetType()
      {
        return typeof (MyProject.MyForms);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString()
      {
        return base.ToString();
      }
    }

    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyWebServices
    {
      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new Type GetType()
      {
        return typeof (MyProject.MyWebServices);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override string ToString()
      {
        return base.ToString();
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new()
      {
        if ((object) instance == null)
          return Activator.CreateInstance<T>();
        return instance;
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance)
      {
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyWebServices()
      {
      }
    }

    [ComVisible(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
