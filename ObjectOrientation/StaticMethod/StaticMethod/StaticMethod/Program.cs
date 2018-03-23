using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
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
        public string seatMaterial = "";
        //static fields
        public static int totalSold = 0;

        
        public Car(string make, string model, string colour, int price)
        {
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.price = price;
            this.sold = false;

            totalSold++;//Car.totalSold not neccessary as already in class Car
        }

        public Car(string seatMaterial)
        {
            this.seatMaterial = seatMaterial;
        }

        //non-static method used to display details of an object
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

        //non-static method used to change value of sold to true (int price sets actual sold price)
        public void SellCar(int price)
        {
            this.sold = true;
            this.price = price;

            Console.WriteLine("The {0} has been sold", this.make);
        }

        //static Methods
        public static void DisplayCars(List<Car> allCars)
        {
            //int totalAvail = 0;

            Console.WriteLine("This is a list of all the cars");


            //foreach (Car b in allCars)
            //{
            //    Console.WriteLine("\n make:{0}\n model:{1}\n colour:{2}\n price:£{3:N0}", b.make, b.model, b.colour, b.price);

            //    if (b.sold)
            //    {

            //    }

            //    else
            //    {

            //    }
            //}

        }

}

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> allCars = new List<Car>();
            //sets default value of total cars sold
            Car.totalSold = 0;

            // BMW object
            Car myCarA = new Car("leather");
            myCarA.make = "BMW";
            myCarA.model = "One Series";
            myCarA.colour = "Red";
            myCarA.price = 30000;
            myCarA.sold = false;




            ////Ford object
            //Car myCarB = new Car();
            //myCarB.make = "Ford";
            //myCarB.model = "Fiesta";
            //myCarB.colour = "Blue";
            //myCarB.price = 15000;
            //myCarB.sold = false;


            ////Nissan object
            //Car myCarC = new Car();
            //myCarC.make = "Nissan";
            //myCarC.model = "Micra";
            //myCarC.colour = "Silver";
            //myCarC.price = 25000;
            //myCarC.sold = false;

            ////adding a car object using method (Audi object)
            //Car myCarD = new Car();
            //myCarD.AddDetailsOfCar("Audi", "R8", "Black", 250000);

            //selling a car using method
            //myCarB.SellCar(30000);

            Car myCarE = new Car("Benz", "C2", "yellow", 340000);

            Console.WriteLine(myCarE.make);
            Console.WriteLine(myCarA.seatMaterial);
            //Displaying details of all the cars
            Console.WriteLine("These are the deatils of all the cars available");
            Console.WriteLine();

            //displaying car details/details using method
            




            //Displaying total number of cars sold


        }
    }
}