using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.Abstract
{
    public class SUV : Vehicle, IComparable<SUV>, IDiffLockable
    {
        public override string VinNumber => _vinNumber;

        public override int EngineSize => _engineSize;

        public override int WheelCount => _wheelCount;

        public bool AutomaticDiff { get; } = false;

        public SUV(string vinNumber, int engineSize, int wheelCount)
        {
            _vinNumber = vinNumber;
            _engineSize = engineSize;
            _wheelCount = wheelCount;
        }

        public bool VinNumberEqual(SUV suv)
        {
            return VinNumber.Equals(suv.VinNumber);
        }
    }
}
