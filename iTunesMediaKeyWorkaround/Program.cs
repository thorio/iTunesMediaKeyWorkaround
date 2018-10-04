using System;
using System.Diagnostics;
using iTunesLib;

namespace iTunesMediaKeyWorkaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] pname = Process.GetProcessesByName("iTunes");
            if (pname.Length == 0 || args.Length == 0) //iTunes process not found OR no arguments passed
            {
                Environment.Exit(1);
            }

            IiTunes iTunes = new iTunesApp();

            switch (args[0].ToLower())
            {
                case "playpause":
                    iTunes.PlayPause();
                    break;
                case "next":
                    iTunes.NextTrack();
                    break;
                case "prev:":
                    iTunes.PreviousTrack();
                    break;
            }

            Environment.Exit(0);
        }
    }
}
