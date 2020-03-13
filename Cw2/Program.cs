using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


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
            int infcount =0;
            int artcount = 0;
            var list = new List<Student>();
            //var path = @"C:\Users\s19027\Desktop\dane.csv";
            var path = @"C:\Users\playe\OneDrive\Pulpit\dane.csv";
            try
            {
                var lines = File.ReadLines(path);

                
                foreach( var line in lines)
                {
                    line.Split(",");
                  
                  string im = line.Split(",").GetValue(0).ToString();
                  string naz = line.Split(",").GetValue(1).ToString();
                  string kier = line.Split(",").GetValue(2).ToString();
                  string tr = line.Split(",").GetValue(3).ToString();
                  string ind = line.Split(",").GetValue(4).ToString();
                  string dat = line.Split(",").GetValue(5).ToString();
                  string mail = line.Split(",").GetValue(6).ToString();
                  string imiem = line.Split(",").GetValue(7).ToString();
                  string imieo = line.Split(",").GetValue(8).ToString();
                  
                  check = im + naz + ind;
                  
                  if (new Student()
                  {
                      imie = im.Replace(" ", ""),
                      nazwisko = naz.Replace(" ", ""),
                      kierunek = kier.Replace(" ", ""),
                      tryb = tr.Replace(" ", ""),
                      index = ind.Replace(" ", ""),
                      data = dat.Replace(" ", ""),
                      email = mail.Replace(" ", ""),
                      imie_matki = imiem.Replace(" ", ""),
                      imie_ojca = imieo.Replace(" ", ""),
                  }.validtofile())
                  {
                      if (!stdf.Contains(check))
                      {
                          list.Add(new Student(){imie = im.Replace(" ", ""),
                              nazwisko = naz.Replace(" ", ""),
                              kierunek = kier.Replace(" ", ""),
                              tryb = tr.Replace(" ", ""),
                              index = ind.Replace(" ", ""),
                              data = dat.Replace(" ", ""),
                              email = mail.Replace(" ", ""),
                              imie_matki = imiem.Replace(" ", ""),
                              imie_ojca = imieo.Replace(" ", ""),});
                          filedata += line + "\n";
                          stdf.Add(check);
                          
                          if (line.Split((",")).GetValue(2).ToString().Split(" ").GetValue(0).Equals("Informatyka"))
                          {
                              infcount++; 
                          }
                          if (line.Split((",")).GetValue(2).ToString().Split(" ").GetValue(0).Equals("Sztuka"))
                          {
                              artcount++;
                          }
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
                  
                }
                Console.WriteLine(infcount);
                Console.WriteLine("=========");
                Console.WriteLine(artcount);
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

            FileStream writer = new FileStream(@"C:\Users\playe\OneDrive\Pulpit\result.xml", FileMode.Create); 
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>),
                new XmlRootAttribute("uczelnia"));
            serializer.Serialize(writer, list);


            var parsedDate = DateTime.Parse("2020-03-09");
            
            var today = DateTime.Now;
          //  JsonConvert.SerializeObject();
            //Console.WriteLine(ParsedDate);
            //Console.WriteLine(today);
            //Console.WriteLine(today.ToShortDateString());
            if (string.IsNullOrEmpty(""))
            { }



        }
    }
}