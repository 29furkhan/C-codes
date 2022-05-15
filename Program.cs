using System;
using System.IO;

namespace TSLP
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/Users/furkhan/Documents/index.txt";
            FileInfo file = new FileInfo(path);

            if (!file.Exists)
                file.Create();
            else
            {
                using (StreamWriter sw = file.CreateText())
                {
                    sw.WriteLine("Iron man");
                    sw.WriteLine("Hulk");
                    sw.WriteLine("Thor");
                    sw.WriteLine("Captain america");
                }

                using (StreamReader sr = file.OpenText())
                {
                    string s = "";
                    while((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

                Console.WriteLine(file.Length);
                Console.WriteLine(file.Name);
                Console.WriteLine(file.DirectoryName);

                file.Delete();
            }
        }
    }
}

/*
Hulk
Thor
Captain america
0
index.txt
/Users/furkhan/Documents
*/