using System;

namespace WebApplication1.abc
{
    public static class MethodTimeLogger
    {
        public static void Log(System.Reflection.MethodBase methodBase, long milliseconds, string message)
        {
            Console.Write(milliseconds);

        }

        public static void Log(System.Reflection.MethodBase methodBase, TimeSpan elapsed, string message)
        {
            Console.Write(elapsed.TotalMilliseconds);
        }

    }
}
