using System;
using System.IO;
namespace PswordGn // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            //Passowrd generator and storage via note file
            int size;
            string name;

            int count = 1;
            string temppass =null;
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";

            string projectFolder = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(projectFolder, "PassStorage", "passwords.txt");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Wellcome to PswordGn! \n Created by Mal");
                Console.WriteLine("1:Pasword generator");
                Console.WriteLine("2: Store current password");
                int input =int.Parse(Console.ReadLine());
                if (input == 0) break;
                switch (input)
                {
                    case 1:
                        Console.WriteLine("How long should it be?");
                        Console.WriteLine("Enter 0 for random length");
                        size = int.Parse(Console.ReadLine());
                        if (size == 0)
                        {
                            temppass = CreateRandomPasswordWithRandomLength( validChars);
                            Console.WriteLine("Passowrd created!");
                            Console.WriteLine($"password:{temppass}");
                            Console.WriteLine("Please save it by picking the second option.");
                           
                        }
                        else if (size != null)
                        {

                            temppass = CreateRandomPassword(validChars,size);
                            Console.WriteLine("Passowrd created!");
                            Console.WriteLine($"password :{temppass}");
                            Console.WriteLine("Please save it by picking the second option.");
                        }
                        else Console.WriteLine("Error: no value entered!");
   
                        Console.ReadLine();

                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Write the website or account you use:");
                            name = Console.ReadLine();
                            if (name == null)
                            {
                                Console.WriteLine("Error: No webiste or account name entered!");
                            }
                            else if (temppass == "nopass") Console.WriteLine("Error: no new password created!");
                            else
                            {
                                Console.WriteLine( path);
                                Directory.CreateDirectory(Path.GetDirectoryName(path));
                                TextWriter text = new StreamWriter(path, true);
                                text.WriteLine($"{count} - {name}: {temppass}");
                                text.Close();
                                count++;
                                temppass = null;
                                Console.WriteLine("Done!");
                            }
                        }
                        catch (Exception ex) { Console.WriteLine(ex); }
                        Console.ReadLine(); 
                        break;  
                    default: Console.WriteLine("Error, wrong option!"); Console.ReadLine ();
                    break;

                }               
            }
        }
        private static string CreateRandomPassword(string validChars,int length = 15)
        { 
            Random random = new Random();
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }

        private static string CreateRandomPasswordWithRandomLength(string validChars)
        {        
            Random random = new Random();       
            int size = random.Next(8, validChars.Length);
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
    }
}
