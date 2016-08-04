using DataLayer;
using System;
using System.Diagnostics;
using static System.Console;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataManager = new FullDataManager();
            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");
            String[] instancename = category.GetInstanceNames();

            foreach (string name in instancename)
            {
                Console.WriteLine(name);
            }
            WriteLine("If you want computer summary write 'CS' , \n" +
                      "if you want application list write 'AL', \n" +
                      "if you want hardware list write 'HL': \n");


            var option = ReadLine();
            WriteLine();

            switch (option)
            {
                case "CS":
                    PrintComputerSummary(dataManager);
                    break;
                case "HL":
                    PrintHardwareList(dataManager);
                    break;
                case "AL":
                    PrintApplicationList(dataManager);
                    break;
                default:
                    WriteLine("Wrong command please try again!");
                    break;
            }

            ReadLine();
        }

        private static void PrintHardwareList(DataManager dataManager)
        {
            var hardwareList = dataManager.GetHardwareList();
            foreach (var hardware in hardwareList)
            {
                WriteLine(hardware);
            }
        }

        private static void PrintApplicationList(DataManager dataManager)
        {
            foreach (var app in dataManager.GetApplicationList())
            {
                WriteLine(app);
            }
        }

        private static void PrintComputerSummary(DataManager dataManager)
        {
            var computerSummary = dataManager.GetComputerSummary();
            WriteLine($"Current user: {computerSummary.User}");
            WriteLine($"Computer Name: {computerSummary.Name}");
            WriteLine($"CPU name: {computerSummary.Cpu}");
            WriteLine($"Current CPU usage: {computerSummary.CpuUsage}%");
            WriteLine($"Current RAM available: {computerSummary.Ram} MB");
            WriteLine($"RAM usage: {computerSummary.RamUsage} %");
            WriteLine($"Current video card: {computerSummary.VideoCard} MB");
            WriteLine($"Current ip: {computerSummary.Ip}");
            WriteLine($"Available disk space: {computerSummary.AvailableDiskSpaceGb} GB");
            WriteLine($"Average disk queue length: {computerSummary.AverageDiskQueueLength}");
        }
    }
}
