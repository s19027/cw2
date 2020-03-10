using System;
using System.IO;

namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            //git status -> git add .->git status -> git commit -m <nazwa> ->git push

            //var path = @"C:\Users\s19027\Desktop\dane.csv";
            var path = @"C:\Users\playe\OneDrive\Pulpit\dane.csv";
            try
            {
                var lines = File.ReadLines(path);












            }catch(Exception e)
            {
                if (e is IOException)
                {
                    Console.Error.WriteLine("Podana ścieżka jest niepoprawna");
                }
                if(e is FileNotFoundException)
                {
                    Console.Error.WriteLine("Plik nazwa nie istnieje");
                }
            }

            // foreach( var line in lines)
            //     {
            //         Console.WriteLine(line);
            //    }
            var parsedDate = DateTime.Parse("2020-03-09");

            var today = DateTime.Now;
            //Console.WriteLine(ParsedDate);
            //Console.WriteLine(today);
            //Console.WriteLine(today.ToShortDateString());
            if (string.IsNullOrEmpty(""))
            { }



        }
    }
}