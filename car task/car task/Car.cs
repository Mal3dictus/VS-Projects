using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_task
{
    public class Car
    {
        private string carname;
        private string carmodel;
        private int millage;
        private string color;
        private short rimsize;
        private bool engineintact;
        
        public Car(string carname, string carmodel, int millage, string color, short rimsize, bool engineintact)
        {
            this.Carname = carname;
            this.Carmodel = carmodel;
            this.Millage = millage;
            this.Color = color;
            this.Rimsize = rimsize;
            this.Engineintact = engineintact;


        }
        public string Carname
        {
            get { return carname; } 
            set {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Wrong value!");
                }
                carname = value; 
                }
        }
        public string Carmodel
        {
            get { return carmodel; }
            set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Wrong value!");
                }
                carmodel = value; 
            
            }
        }
        public int Millage
        {
            get { return millage; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Wrong value!");
                }
                millage = value; 
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Wrong value!");
                }


                color = value; 
            }
        }
        public short Rimsize
        {
            get { return rimsize; }
            set 
            {
                if (value < 16 && value >22)
                {
                    throw new ArgumentException("Wrong value!");
                }



                rimsize = value;
            }
        }
        public bool Engineintact 
        {
            get { return engineintact; }
            set 
            { 
                if(value != true && value != false)
                {
                    throw new ArgumentException("Wrong value!");
                }
                
                
                engineintact = value; 
            }
        }
        public override string ToString()
        {
            string carresult;
            carresult = $"Car information:\n Car name - {this.Carname} \n brand - {this.Carmodel} \n Engine intact - {this.Engineintact} \n Mileage -{this.Millage}km. \n Color and rims size - {this.Color} and {this.Rimsize} size rims. ";
            return carresult; 
        }
    }
}
