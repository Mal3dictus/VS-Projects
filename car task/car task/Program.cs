using car_task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int max = 1;
            i = 0;
            int dnum;
            int input;
            List<Car> Carstorage = new List<Car>();
            int change;
            while (true)      
            {
                dnum = 0;
                Console.Clear();
                Console.WriteLine("CAR DATABASE: \n CHOOSE ONE OF THE NUMBER BELOW FOR THE GIVEN OPTION \n TYPE 0 TO CLOSE THE DATABASE \n 1 - Create a new car data \n 2 - Delete a car of the database \n 3 -Change the condtion of a car \n 4-Current car list  \n 5- Remove all cars");
                input = int.Parse(Console.ReadLine());

                if(input == 0)
                {
                    break;
                } 
                switch (input)
                {
                    case 1:
                        
                        try
                        {
                            
                            Console.WriteLine("Type in the following way: (Car name) (Car brand) (Color) (Engine running (True or False)) (mileage) (rimsize)");
                            string[] inputforcar =Console.ReadLine().Split(' ').ToArray();  
                            string name = inputforcar[0];
                            string model = inputforcar[1];
                            string color = inputforcar[2];
                            bool intact =bool.Parse(inputforcar[3]);
                            int mill = int.Parse(inputforcar[4]);
                            short rims = short.Parse(inputforcar[5]);
                            var car = new Car(name, model,mill,color,rims,intact); 
                            Carstorage.Add(car);
                            max++;
                        }   
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        } 
                        Console.ReadLine();
                        
                    break;
                    case 2:
                        Console.WriteLine("Write the index of the car you want to remove from the database");
                        i = int.Parse(Console.ReadLine());
                        if (i < max & i > -1)
                        {
                            Carstorage.RemoveAt(i);
                        }
                        
                    break;
                    case 3:
                        Console.WriteLine(" 1. Color \n 2.Engine intact \n 3.Mileage");
                        change = int.Parse(Console.ReadLine());
                        switch (change)
                        {
                         case 1:
                                Console.WriteLine("Write the index of the car");
                                i = int.Parse(Console.ReadLine());
                                
                                if (i < max & i > -1)
                                {
                                    Console.WriteLine("Write the new color of the car");
                                    Carstorage[i].Color = Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                }
                                Console.ReadLine();
                                break;
                         case 2:
                                Console.WriteLine("Write the index of the car");
                                i = int.Parse(Console.ReadLine());
                                if (i < max & i > -1)
                                {
                                    Console.WriteLine("Write the new engine state of the car");
                                    Carstorage[i].Engineintact =bool.Parse( Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                }
                                Console.ReadLine();
                                break;
                         case 3:
                                Console.WriteLine("Write the index of the car");
                                i = int.Parse(Console.ReadLine());
                                if (i < max & i > -1)
                                {
                                    Console.WriteLine("Write the new millage of the car");
                                    Carstorage[i].Millage = int.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                }
                                Console.ReadLine();
                                break;
                        }
                        break;
                    case 4:
                       
                       
                            Console.WriteLine("CURRENT CAR STORAGE");
                            foreach (var item in Carstorage)
                            {

                                dnum++;
                                Console.WriteLine("Number:" + dnum + " " + item.ToString());
                                Console.WriteLine();
                            }

                             Console.ReadLine();
                        break;
                        
                    case 5:
                        Console.WriteLine("Are you sure of this dessicion. Once done it cant be undone? \n Type Y or N if you wish to proceed.");
                        string confirm = Console.ReadLine();
                        if (confirm == "Y")
                        {
                            Console.WriteLine("Please wait...");
                            foreach (var item in Carstorage.ToList())
                            {
                                Carstorage.RemoveAt(0);
                            }
                            Thread.Sleep(1000);
                            Console.WriteLine("Database cleared!");
                            
                               

                            
                        }
                        else if(confirm == "N")
                        {
                            Console.WriteLine("Task cancelled...");
                            
                        }
                        
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Error");
                        Console.ReadLine();
                        break;

                }
                
            }
        }
    }
}