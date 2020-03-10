using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

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






                foreach( var line in lines)
                {
                    line.Split(",");
                   var Student = new Student();
                    Console.WriteLine(line);
                }


            }catch(Exception e)
            {
                if(e is FileNotFoundException)
                {
                    File.WriteAllText(@"C:\Users\playe\OneDrive\Pulpit\log.txt","Plik nazwa nie istnieje");
                    Console.Error.WriteLine("Plik nazwa nie istnieje");
                }
                if (e is ArgumentException)
                {
                    File.WriteAllTextAsync(@"C:\Users\playe\OneDrive\Pulpit\log.txt","Podana ścieżka jest niepoprawna");
                    Console.Error.WriteLine("Podana ścieżka jest niepoprawna");
                }
            }

             
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