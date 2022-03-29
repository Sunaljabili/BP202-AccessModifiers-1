using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;
        public Car()
        {
            Console.WriteLine("Car Created");
        }
        public Car(string brand , string model)
        {
            Brand = brand;
            Model = model;
        }
        public Car(string brand, string model,string color, int maxSpeed):this(brand,model)
        {
            Color = color;
            MaxSpeed = maxSpeed;
        }

        public virtual string  InfoAll()
        {
         return  $"Brand : {Brand} | Model : {Model} | Color : {Color} | MaxSpeed : {MaxSpeed} ";
        }
    }
}
