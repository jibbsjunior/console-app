﻿using System;
using System.IO;

namespace mini_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("c:/nottingham/welcome.txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The given file could not be loaded:");
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            //read input from user
            //int option;
            Console.WriteLine("Please select an option from above!");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1 && option is int)
            {
                try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader sr = new StreamReader("c:/nottingham/doctor.txt"))
                    {
                        string line;

                        // Read and display lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                    catch (Exception e)
                    {
                        // Let the user know what went wrong.
                        Console.WriteLine("The given file could not be loaded:");
                        Console.WriteLine(e.Message);
                    }
                    Console.ReadKey();
            } else if (option == 2)
            {
                //Console.WriteLine("You have select an ");
                try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader sr = new StreamReader("c:/nottingham/patients_page.txt"))
                    {
                        string line;

                        // Read and display lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                    catch (Exception e)
                    {
                        // Let the user know what went wrong.
                        Console.WriteLine("The given file could not be loaded:");
                        Console.WriteLine(e.Message);
                    }
                    Console.ReadKey();
            }else
            {
                Console.WriteLine("You have select a wrong input, we stongly advise you to try again! :)");
            }
        }
    }
}