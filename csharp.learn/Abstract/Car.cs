using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.Abstract
{
    public class Car : Vehicle, IComparable<Car>
    {
        public override string VinNumber => _vinNumber;

        public override int EngineSize => _engineSize;

        public override int WheelCount => _wheelCount;

        public Car(string vinNumber, int engineSize, int wheelCount)
        {
            _vinNumber = vinNumber;
            _engineSize = engineSize;
            _wheelCount = wheelCount;
        }

        public bool VinNumberEqual(Car car)
        {
            return VinNumber.Equals(car.VinNumber);
        }
    }
}
