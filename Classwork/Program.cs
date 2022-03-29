using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "BMW";
            car1.Model = "740";
            car1.Color = "Red";
            car1.MaxSpeed = 60;
            Console.WriteLine(car1.InfoAll());


            Bus bus1 = new Bus(20,"Daewo","Optima","Green",250);
            Console.WriteLine(bus1.InfoAll());


        }
    }
}
