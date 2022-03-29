using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class Bus:Car
    {
        public byte passengerCount;

        public Bus(byte PassengerCount, string brand, string model):base(brand,model)
        {
            passengerCount = PassengerCount;
        }
        public override string  InfoAll()
        {
           return $"{base.InfoAll()} | PassengerCount :{passengerCount}";  
        }
    }
}
