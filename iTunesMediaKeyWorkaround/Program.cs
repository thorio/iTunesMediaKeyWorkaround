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

            var app = new iTunesApp();

			var p = app.SoundVolume;

			switch (args[0].ToLower())
            {
                case "playpause":
                    app.PlayPause();
                    break;
                case "next":
                    app.NextTrack();
                    break;
                case "prev:":
                    app.PreviousTrack();
                    break;
				case "volup":
					app.SoundVolume = Math.Min(100, app.SoundVolume + 5);
					break;
				case "voldown":
					app.SoundVolume = Math.Max(0, app.SoundVolume - 5);
					break;
			}
			
            Environment.Exit(0);
        }
    }
}
