using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecifyingCommandLine
{
    class Program
    {
        static Int32 Main(string[] args)
        {
            foreach (String arg in args)
            {
                Console.WriteLine(arg);
            }
            ShowEnvironmentDetails();
            Console.ReadLine();
            return -1;
        }

        static void ShowEnvironmentDetails()
        {
            //print out the driver on this machene ant other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET version: {0}", Environment.Version);
            Console.WriteLine("Command line: {0}", Environment.CommandLine);
            Console.WriteLine("Current managed thead id: {0}", Environment.CurrentManagedThreadId);
            Console.WriteLine("Exit code: {0}", Environment.ExitCode);
            Console.WriteLine("Is this machine 64 -bit OS: {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine("Is this machine 64 -bit process: {0}", Environment.Is64BitProcess);
            Console.WriteLine("Machine's name: {0}", Environment.MachineName);
            Console.WriteLine("New line symbol for current environment: {0}", Environment.NewLine);
            Console.WriteLine("Full path to the system directory: {0}", Environment.SystemDirectory);
        }
    }
}
