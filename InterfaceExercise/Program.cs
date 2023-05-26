using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

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
            //Creatively display and organize their values
            #endregion
            var car = new Car();

            car.IsSmall = false;
            car.HasTrunk = true;
            car.NumOfSeats = 5;
            car.NumOfDoors = 4;
            car.NumOfWheels = 4;
            car.HasAirbags = true;
            car.NumOfSales = 5;
            car.Logo = "Subaru";
            car.Name = "Car";

            var truck = new Truck();

            truck.IsBig = true;
            truck.HasBed = true;
            truck.NumOfSeats = 2;
            truck.NumOfDoors = 2;
            truck.NumOfWheels = 4;
            truck.HasAirbags = false;
            truck.NumOfSales = 8;
            truck.Logo = "Ford";
            truck.Name = "truck";

            var suv = new Suv();

            suv.IsMed = true;
            suv.HasCargo = false;
            suv.NumOfSeats = 7;
            suv.NumOfDoors = 4;
            suv.NumOfWheels = 4;
            suv.HasAirbags = true;
            suv.NumOfSales = 2;
            suv.Logo = "Nissan";
            suv.Name = "SUV";

            // var vehicles = new List<

            var vehicles = new List<IVehicle>();

            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(suv);

            var companies = new List<ICompany>();

            companies.Add(car);
            companies.Add(truck);
            companies.Add(suv);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Name}s have:\n {vehicle.NumOfDoors} doors," +
                    $" {vehicle.NumOfSeats} seats, {vehicle.NumOfWheels} wheels, and it is {vehicle.HasAirbags} they have airbags.\n");
            }


        }
    }
}
