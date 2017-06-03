using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NLog;

namespace NLogViewerNLog4
{
    class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private static void Main(string[] args)
        {
            Parallel.For(0, 1000, i =>
            {
                Logger.Debug($"#{i}");
            });

            Console.WriteLine("done, press key");
            Console.ReadLine();
        }
    }
}
