using System;
using System.IO;

namespace workspaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "/Users/furkhan/Documents/index.txt";
            FileInfo file = new FileInfo(path);

            if(! file.Exists)
            {
                file.Create();
            }
            else
            {
                // Write data
                using(StreamWriter sw = file.CreateText())
                {
                    sw.WriteLine("Shang chi");
                    sw.WriteLine("Eternals");
                }

                // Append data
                using(StreamWriter sw = file.AppendText())
                {
                    sw.WriteLine("Loki");
                    sw.WriteLine("Wanda vision");
                }

                // Reading data
                using(StreamReader sr = file.OpenText())
                {
                    string s = "";
                    while((s = sr.ReadLine()) != null)
                        Console.WriteLine(s);
                }
                Console.WriteLine(file.Length);
            }
        }
    }
}
/*
Shang chi
Eternals
Loki
Wanda vision
37
*/