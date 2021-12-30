using System;
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
                    int docOption = Convert.ToInt32(Console.ReadLine());
                    if(docOption == 2)
                    {
                        using (StreamReader sr = new StreamReader("c:/nottingham/nurse_roster.txt"))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    } else if(docOption == 3)
                    {
                        using (StreamReader sr = new StreamReader("c:/nottingham/patient_list.txt"))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    } else if(docOption == 1)
                    {
                        Console.WriteLine("Please enter values in a format separated by commas");
                        string[] names = new string[] { Console.ReadLine() };

                        using (StreamWriter sw = new StreamWriter("c:/nottingham/nurse_roster.txt"))
                        {
                            foreach (string s in names)
                            {
                                sw.WriteLine(s);
                            }
                        }
                    }else
                    {
                        Console.WriteLine("Please enter an input between 1 - 3, please try again! :)");
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
                Console.WriteLine("You have enter a wrong input, we stongly advise you to try again! :)");
            }
        }
    }
}
