using System;

namespace CommandDemo
{
    public class Program1
    {
        public static void Run(string[] args)
        {
            if (args.Length != 0) return;
            PrintUsage();
            return;
        }

        private static void PrintUsage()
        {

        }
    }
}
