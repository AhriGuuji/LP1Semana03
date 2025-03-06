using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s.Length>7)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                else if (s.Length>3)
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}
