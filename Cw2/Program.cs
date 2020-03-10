﻿using System;
using System.Collections;
using System.Collections.Generic;
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
            ArrayList stdf = new ArrayList();
            string filedata = "";
            string logdata="";
            string check = "";
            //var path = @"C:\Users\s19027\Desktop\dane.csv";
            var path = @"C:\Users\playe\OneDrive\Pulpit\dane.csv";
            try
            {
                var lines = File.ReadLines(path);

                
                foreach( var line in lines)
                {
                    line.Split(",");
                  
                  string imie = line.Split(",").GetValue(0).ToString();
                  string nazwisko = line.Split(",").GetValue(1).ToString();
                  string kier = line.Split(",").GetValue(2).ToString();
                  string tryb = line.Split(",").GetValue(3).ToString();
                  string index = line.Split(",").GetValue(4).ToString();
                  string data = line.Split(",").GetValue(5).ToString();
                  string mail = line.Split(",").GetValue(6).ToString();
                  string imiem = line.Split(",").GetValue(7).ToString();
                  string imieo = line.Split(",").GetValue(8).ToString();
                  
                  Student std = new Student(imie, nazwisko, kier, tryb, index, data, mail, imiem, imieo);
                  check = imie + nazwisko + index;
                  if (std.validtofile())
                  {
                      if (!stdf.Contains(check))
                      {
                          filedata += line + "\n";
                          stdf.Add(check);
                      }
                      else
                      {
                          logdata += line + "\n";
                      }
                  }
                  else
                  {
                      logdata += line + "\n";
                  }
                  Console.WriteLine(line);
                }
                File.WriteAllText(@"C:\Users\playe\OneDrive\Pulpit\result.xml",filedata);
                File.WriteAllText(@"C:\Users\playe\OneDrive\Pulpit\log.txt",logdata);
            }catch(Exception e)
            {
                if(e is FileNotFoundException)
                {
                    File.WriteAllText(@"C:\Users\playe\OneDrive\Pulpit\log.txt","Plik nazwa nie istnieje");
                    Console.Error.WriteLine("Plik nazwa nie istnieje");
                }
                if (e is ArgumentException)
                {
                    File.WriteAllText(@"C:\Users\playe\OneDrive\Pulpit\log.txt","Podana ścieżka jest niepoprawna");
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