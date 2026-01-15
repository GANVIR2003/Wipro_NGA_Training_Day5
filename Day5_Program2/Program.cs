// See https://aka.ms/new-console-template for more information
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wipro_Day5_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "demo.txt";
            using (FileStream fs = File.Create(filePath))
            {
                if (File.Exists(filePath))
                {
                    Console.WriteLine("File created successfully.");
                }
                else
                {
                    Console.WriteLine("File creation failed.");
                }
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, this is a test file.");
                writer.WriteLine("This file is created using FileStream and StreamWriter." + DateTime.Now);
            }

        }

        static void ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("Here are the File Content:");
                    Console.WriteLine(content);
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }






    }
}
