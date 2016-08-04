using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using static DataLayer.ComputerMetricsEnum;

namespace DataLayer
{
    public abstract class DataManager
    {
        public virtual string GetMetric(ComputerMetricsEnum type)
        {
            var value = "";
            switch (type)
            {
                case CpuUsage:

                    value = GetValueFromWmi("Win32_PerfFormattedData_PerfOS_Processor", "PercentProcessorTime");
                    break;

                case ComputerName:

                    value = Environment.MachineName;
                    break;
                case UserName:

                    value = Environment.UserDomainName + @"\" + Environment.UserName;
                    break;

                case AvailableRam:

                    var availableRam = int.Parse(GetValueFromWmi("Win32_OperatingSystem", "TotalVisibleMemorySize"));
                    value = (availableRam / 1024).ToString();
                    break;

                case VideoCard:

                    value = GetValueFromWmi("Win32_VideoController", "Name");
                    break;

                case Ip:

                    var host = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (var ip in host.AddressList)
                    {
                        if (ip.AddressFamily == AddressFamily.InterNetwork)
                        {
                            value = ip.ToString();
                        }
                    }
                    break;

                case Cpu:

                    value = GetValueFromWmi("Win32_Processor", "Name");
                    break;

                case RamUsage:

                    var free = double.Parse(GetValueFromWmi("Win32_OperatingSystem", "FreePhysicalMemory"));
                    var total = double.Parse(GetValueFromWmi("Win32_OperatingSystem", "TotalVisibleMemorySize"));
                    var ramUsagePercent = (int)Math.Round((total - free) / total * 100);
                    value = ramUsagePercent.ToString();
                    break;

                case AvailableDiskSpaceGb:

                    var allDrives = DriveInfo.GetDrives();
                    long sum = 0;
                    foreach (var d in allDrives)
                    {
                        if (d.IsReady)
                        {
                            sum += d.TotalFreeSpace.BytesToGygabytes();
                        }
                    }

                    value = sum.ToString();
                    break;

                case AverageDiskQueueLength:

                    value = GetValueFromWmi("win32_perfformatteddata_perfdisk_physicaldisk", "AvgDiskQueueLength");
                    break;

                default:
                    value = "";
                    break;

            }

            return value;
        }

        private static string GetValueFromWmi(string queue, string paramater)
        {
            var searcher = new ManagementObjectSearcher("select * from " + queue);
            var value = "";
            foreach (var obj in searcher.Get().Cast<ManagementObject>())
            {
                value = obj[paramater]?.ToString();
                break;
            }

            return value;
        }

        public string GetAvailableDiskSpaceInPercent()
        {
            var allDrives = DriveInfo.GetDrives();
            long totalFreeSpaceSum = 0;
            long totalAvailableSpaceSum = 0;
            foreach (var d in allDrives)
            {
                if (d.IsReady)
                {
                    totalFreeSpaceSum += d.TotalFreeSpace.BytesToGygabytes();
                    totalAvailableSpaceSum += d.TotalSize.BytesToGygabytes();
                }
            }
            var value = (int)((totalAvailableSpaceSum - totalFreeSpaceSum) / totalAvailableSpaceSum * 100);
            return value.ToString();
        }

        public string GetBandwithUsage()
        {
            var performanceCounterCategory = new PerformanceCounterCategory("Network Interface");
            var instance = performanceCounterCategory.GetInstanceNames()[1];

            var totalUsedBandwith = new PerformanceCounter("Network Interface", "Bytes Total/sec", instance);
            var maxAvailableBandwidth = new PerformanceCounter("Network Interface", "Current Bandwidth", instance);
            var used = totalUsedBandwith.NextValue();
            var total = maxAvailableBandwidth.NextValue();
            for (int i = 0; i < 10; i++)
            {
                used += totalUsedBandwith.NextValue();
                Thread.Sleep(100);
            }
            used = used / 10;
            var value = (int)(used * 100 / total);
            if (value > 100)
                value = 100;
            else if (value < 0)
                value = 0;

            return value.ToString();
        }



        public abstract ComputerSummary GetComputerSummary();
        public abstract List<string> GetApplicationList();
        public abstract List<string> GetHardwareList();
    }

    public static class Extensions
    {
        public static long BytesToGygabytes(this long bytes)
        {
            return bytes / 1024 / 1024 / 1024;
        }
    }
}
