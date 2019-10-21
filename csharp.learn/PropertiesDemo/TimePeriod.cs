
using System;

namespace csharp.learn.PropertiesDemo
{
    public class TimePeriod
    {
        private double _seconds;

        public double Hours {
            get { return _seconds / 3600; }
            set
            {
                if (value < 0 || value > 24) {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 24.");
                }

                _seconds = value * 3600;
            }
        }
    }
}
