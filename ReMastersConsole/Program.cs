using System;
using ReMastersLib;

namespace ReMastersConsole
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("Not a console app, really. Don't do that!");
                Console.ReadLine();
            }

            var paths = new GameDataPaths
            {
               C:\Users\CAA-User\Desktop\Masters\Pokémon Masters EX_v2.0.0_apkpure.com
            };

            var settings = new DumpSettings(paths)
            {
                DumpStringsDL = true,
                DumpStringsAPK = true,

                DumpResources = true,
                DumpProto = true,
            };

            settings.DumpGameData();
        }
    }
}
