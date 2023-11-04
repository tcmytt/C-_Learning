using System;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ListDrive = DriveInfo.GetDrives();
            foreach (var i in ListDrive){
                Console.WriteLine(i.Name);
                Console.WriteLine(i.DriveType);
                Console.WriteLine(i.TotalSize);
                Console.WriteLine(i.AvailableFreeSpace);
                Console.WriteLine("---------------------------");
            }

                Console.WriteLine("a");
        }
    }
}

