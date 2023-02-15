using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONECreate a seperate class file called Car 
            //DONECar shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable 
            //DONECar shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //DONENow that the Car class is created we can instanciate 3 new cars
            //DONESet the properties for each of the cars
            //DONECall each of the methods for each car

            CarLot lot = new CarLot();


            //Instantiation 1
            var gtr = new Car();

            lot.CarList.Add(gtr);

            gtr.Make = "Nissan";
            gtr.Model = "GTR";
            gtr.Year = 2009;
            gtr.EngineNoise = "sputter";
            gtr.HonkNoise = "wimpy";
            gtr.IsDriveable = true;

            gtr.MakeEngineNoise();
            gtr.MakeHonkNoise();

            //Instantiation 2
            var myCar = new Car(2010, "Mazda", "3", "purr", "girly asf", true);
            lot.CarList.Add(myCar);

            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();

            //Instantiation 3
            var dreamCar = new Car()
            {
                Year = 2009,
                Make = "Nissan",
                Model = "370z",
                EngineNoise = "sporty",
                HonkNoise = "quiet",
                IsDriveable = true

            };
            lot.CarList.Add(dreamCar);
            dreamCar.MakeEngineNoise();
            dreamCar.MakeHonkNoise();
            //*************BONUS*************//

            // DONESet the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");

                //Create a CarLot class
                //It should have at least one property: a List of cars
                //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
                //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            }
        }
    }
}
