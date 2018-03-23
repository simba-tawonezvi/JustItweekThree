using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Car
    {
        //creating a blueprint of cars

        //nono-static fields
        public string make = "";
        public string model = "";
        public string colour = "";
        public int price = 0;
        public bool sold = false;//good practice to set default values of variables

        //static fields
        public static int totalSold = 0;

        //method used to add a car object
        public void AddDetailsOfCar(string make, string model, string colour, int price, bool sold)
        {
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.price = price;
            this.sold = sold;

            totalSold++;//Car.totalSold not neccessary as already in class Car
        }

        //method used to display details of an object
        public void DisplayCarDetails()
        {

            //"in quotes determinds position to input value by index {0}
            Console.WriteLine("\n make:{0}\n model:{1}\n colour:{2}\n price:£{3:N0}", make, model, colour, price);

            //if statement used to indicate sold status
            if (sold)
            {
                Console.WriteLine("This car has been sold");
            }
            else
            {
                Console.WriteLine("This car is still available to buy");
            }
            Console.WriteLine();
        }

        //method used to change value of sold to true (int price sets actual sold price)
        public void SellCar(int price)
        {
            this.sold = true;
            this.price = price;

            Console.WriteLine("The {0} has been sold",this.make);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //sets default value of total cars sold
            Car.totalSold=0;

            // BMW object
            Car myCarA = new Car();
            myCarA.make = "BMW";
            myCarA.model = "One Series";
            myCarA.colour = "Red";
            myCarA.price = 30000;
            
            

            //Ford object
            Car myCarB = new Car();
            myCarB.make = "Ford";
            myCarB.model = "Fiesta";
            myCarB.colour = "Blue";
            myCarB.price = 15000;
            
            

            //Nissan object
            Car myCarC = new Car();
            myCarC.make = "Nissan";
            myCarC.model = "Micra";
            myCarC.colour = "Silver";
            myCarC.price = 25000;

            //adding a car object using method (Audi object)
            Car myCarD = new Car();
                myCarD.AddDetailsOfCar("Audi", "R8", "Black", 250000, false);

            //selling a car using method
            myCarB.SellCar(30000);


            //Displaying details of all the cars
            Console.WriteLine("These are the deatils of all the cars available");
            Console.WriteLine();

            //displaying car details/details using method
            myCarA.DisplayCarDetails();
            myCarB.DisplayCarDetails();
            myCarC.DisplayCarDetails();
            myCarD.DisplayCarDetails();

            
            

            //Displaying total number of cars sold
            


        }
    }
}
