using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputingCars
{
  public class Vehicle
    {
        public string make;
        public string model;
        public int price;
        public bool sold;

        public static int totalVh = 0;

        public Vehicle(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;

        }

        public void DisplayAllVehicles(List<Vehicle> allVh)
        {
            foreach (Vehicle a in allVh)

            {
                Console.WriteLine("This is a list of all the vehicles available");
                Console.WriteLine();

                Console.WriteLine("\n make: {0} \n model: {1} \n price: £{2:N0} \n", make, model, price);
            }
        }

    }// end of vehicle class

    public class Car : Vehicle
    {
        public int doors= 0;

        

        public Car(string make, string model, int price, int doors) : base(make, model, price)
        {
            this.doors = doors;
            //this.model = model;
            //this.price = price;
            //this.sold = false;

            totalVh++;
        }


        

    }//end of car class

    public class Mcycle : Vehicle

    {
        public bool storage;

        public Mcycle(string make, string model, int price, bool storage) :base(make, model, price)
        {
            this.storage = storage;

            totalVh++;
        }
    }// end of Mcycle class

   

        class Program
    {
        static void Main(string[] args)
        {


            //Car.totalCars = 0;

            //string carToAdd = "";
            //string make = "";
            //string model = "";
            //int price = 0;

            //List<Car> carsForSale = new List<Car>();

            //do
            //{

            //    Console.WriteLine("Please enter A to add a car and X to exit");
            //    carToAdd = Console.ReadLine().ToUpper();

            //    if (carToAdd == "A")
            //    {
            //        //prompting the user
            //        Console.WriteLine("Please enter Make");
            //        make = Console.ReadLine();

            //        Console.WriteLine("Please enter a model");
            //        model = Console.ReadLine();

            //        Console.WriteLine("Please enter Price");
            //        price = Convert.ToInt32(Console.ReadLine());

            //        //creates a new object 
            //        Car newCars = new Car(make, model, price);

            //        //adds car to list
            //        carsForSale.Add(newCars);

            //        Console.WriteLine("Here is a current list of Car");

            //        //displays cars added
            //        foreach (Car c in carsForSale)
            //        {
            //            Console.WriteLine("\n make: {0} \n model: {1} \n price: £{2:N0} \n", c.make, c.model, c.price);
            //        }
            //    }

                


            //} while (carToAdd != "X");

            Console.WriteLine("All Done!!");
        }
    }
}
