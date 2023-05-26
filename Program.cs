



// Source code of DDS Fixer
// Made by Ondra907
// https://github.com/Ondra9071/Drug-Dealer-Simulator-1-Fixer




using System;
using System.Diagnostics;
using Microsoft.Win32;

class Program
{
    static void Main()
    {
        string name = "OPENSSL_ia32cap";
        string _value = "~0x200000200000000";
        Console.Title = "Drug Dealer Simulator Fixer";
        SetSystemEnvironmentVariableWindows(name, _value);
    }

    static void SetSystemEnvironmentVariableWindows(string variableName, string variableValue)
    {
        string logs = "logs.txt";
        try
        {
            using (var envKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Environment", true))
            {
                if (envKey == null)
                {
                    Console.WriteLine("Failed to open system environment key.");
                    WriteLog(logs, "Failed to open system environment key.");
                    return;
                }

                envKey.SetValue(variableName, variableValue);
                envKey.Close();
            }
            WriteLog(logs, "System environment variable set on Windows.");
            Console.WriteLine(@"Drug Dealer Simulator 1 was successfully fixed.
If you still can't start your game, try restarting PC.

Press anything to close the application.");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            WriteLog(logs, ex.Message);
            CallError(logs, ex);
        }
    }

    static void WriteLog(string filePath, string message)
    {
        try
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                string logEntry = $"[{(DateTime.Now).ToString().Replace(" ", ", ")}]: {message}";
                writer.WriteLine(logEntry);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }
    static void CallError(string logs, Exception ex)
    {
        WriteLog(logs, ex.Message);
        Console.WriteLine("An error occurred, see more in the logs. Press 1 to see logs, anything else to end application");
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1) Process.Start("notepad.exe", logs);
        Environment.Exit(0);
    }
}
