using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
namespace DBun
{
    public class MacOS_Terminal
    {
        public static void OpenTerm()
        {
            Console.WriteLine("MacOS Terminal Example");
            OpenTerminalWithCommand(string.Empty );
        }
        public static void OpenTerminal()
        {
            string terminalPath = "/System/Applications/Utilities/Terminal.app";
            Process.Start(new ProcessStartInfo
            {
                FileName = terminalPath,
                UseShellExecute = true
            });
        }
        public static void OpenTerminalWithCommand(string command )
        {
            command = "@echo 'Hello World'";
            string terminalPath = "/System/Applications/Utilities/Terminal.app";
            Process.Start(new ProcessStartInfo
            {
                FileName = terminalPath,
                //Arguments = $"-e \"{command}\"",
                Arguments = $"-e \"{command}\"",
                UseShellExecute = true
            });
        }
    }
}    