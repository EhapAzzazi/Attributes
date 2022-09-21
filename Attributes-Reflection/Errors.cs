using System;

namespace Assembilies
{
    public class Errors
    {

        private string Filed { get; }
        private string Details { get; }

        public Errors(string filed, string details)
        {
            Filed = filed;
            Details = details;
        }
        public static void PrintingErrors()
        {
            if (Players.errors.Count > 0)
            {
                foreach (var e in Players.errors)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Info is valid.");
            }
        }
        public override string ToString()
        {
            return $"[{Filed}] -- [{Details}]";
        }
    }
}
