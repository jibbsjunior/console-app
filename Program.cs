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
            if (option == 1)
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

                    int registered_doctor = Convert.ToInt32(Console.ReadLine());

                    using (StreamReader sr = new StreamReader("c:/nottingham/registered_doctor.txt"))
                    {
                        string line = sr.ReadLine();
                        if (!line.Contains(Convert.ToString(registered_doctor)))
                        {
                            Console.WriteLine("You're not a registered doctor, please try again!");
                        }
                        //while ((line = sr.ReadLine()) != null)
                        //{
                        //    Console.WriteLine(line);
                        //}
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
                        string[] names = new string[] { Console.ReadLine() + "\n" };

                        using (StreamWriter sw = new StreamWriter("c:/nottingham/nurse_roster.txt"))
                        {
                            foreach (string s in names)
                            {
                                sw.WriteLine(s);
                            }
                        }

                        //show the Doctor the updated nurse roster
                        Console.WriteLine("Nurse roster updated successfully, please view the updated list below :)");
                        string line;
                        using (StreamReader sr = new StreamReader("c:/nottingham/nurse_roster.txt"))
                        {
                            //string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                //sr.WriteLine(line);
                                Console.WriteLine(line);
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
