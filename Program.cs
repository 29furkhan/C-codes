using System;
using System.IO;

namespace workspaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "/Users/furkhan/Documents/index.txt";
            
            if(! File.Exists(path))
            {
                File.Create(path);
            }
            else{
                // Write data
                string data = "Shang chi";
                File.WriteAllText(path, data);

                using(StreamWriter sw = File.CreateText(path)) 
                {
                    sw.WriteLine("Wanda vision");
                    sw.WriteLine("Falcon and WS");
                    sw.WriteLine("Loki");
                    sw.WriteLine("Moon knight");
                }
                string[] dt = {"Shang chi", "Eternals"};
                File.WriteAllLines(path, dt);

                // Append data
                data = "What if..?\n";
                File.AppendAllText(path, data);
                dt = new string[]{"Loki 2", "Dr Strange 2"};
                File.AppendAllLines(path, dt);

                using(StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Ms. Marvel");
                }

                // Read the data
                foreach(var line in File.ReadLines(path))
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine(new string('-',50));

                foreach(var line in File.ReadAllLines(path))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
