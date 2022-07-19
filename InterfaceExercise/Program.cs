using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;


            var suv = new SUV();
            var car = new Car();
            var truck = new Truck();



            suv.CargoHoldsize = "55";
            suv.EngineType = "big";
            suv.MaxSpeed = 130;
            suv.NumberOfSeats = 5;
            suv.NumberOfWheels = 4;
            suv.Owner = "Yes";
            suv.SeatRows = 2;
            suv.Logo = "Ford";
            suv.Model = "T";
            suv.Make = "Ford";
            suv.Year = 2018;




            car.TrunkSize = "55";
           
            car.EngineType = "big";
            car.MaxSpeed = 130;
            car.NumberOfSeats = 5;
            car.NumberOfWheels = 4;
            car.Owner = "Yes";
            car.SeatRows = 2;
            car.Logo = "Ford";
            car.Model = "T";
            car.Make = "Ford";
            car.Year = 2018;


            truck.BedSize = "55";
            truck.EngineType = "big";
            truck.MaxSpeed = 130;
            truck.NumberOfSeats = 5;
            truck.NumberOfWheels = 4;
            truck.Owner = "Yes";
           
            truck.Logo = "Ford";
            truck.Model = "T";
            truck.Make = "Ford";
            truck.Year = 2018;


            var myList = new List<ICompany>();

            myList.Add(suv);
            myList.Add(car);
            myList.Add(truck);

            foreach (var item in myList)
            {
                Console.WriteLine($"Max speed: {item.MaxSpeed}");
                Console.WriteLine($"EngineType: {item.EngineType}");
                Console.WriteLine($"Number of seats: {item.NumberOfSeats}");
                Console.WriteLine($"Number of wheels: {item.NumberOfWheels}");
                Console.WriteLine($"Owner: {item.Owner}");
                Console.WriteLine($"Logo: {item.Logo}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Year: {item.Year}");
                
                
            }

            





            //Creatively display and organize their values
        }
    }
}
