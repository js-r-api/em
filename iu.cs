using System;
using System.Net;
using System.Diagnostics;
using System.Reflection;
using System.Configuration.Install;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        //Do nothing
    }

}

[System.ComponentModel.RunInstaller(true)]
public class Sample : System.Configuration.Install.Installer
{
    public override void Uninstall(System.Collections.IDictionary savedState)
    {
        var process = new Process();
        process.StartInfo.UseShellExecute = true;
        process.StartInfo.FileName = "powershell.exe";
        process.Start();
        process.WaitForExit();
    }
}
