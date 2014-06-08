namespace ExtensionMethods
{
    using System;
    using System.Diagnostics;

    public class Timer
    {
        public delegate void delegateTimer(int tSeconds);

        public static void Interval(int seconds)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            while (true)
            {
                if (time.Elapsed.TotalSeconds == 10)
                {
                    Console.WriteLine("Total time - 10 seconds!");
                    return;
                }
                if (time.Elapsed.TotalSeconds % seconds == 0)
                {
                    Console.WriteLine("In every {0} seconds this will be created!", seconds);
                }
            }
        }
    }
}
