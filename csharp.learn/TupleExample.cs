using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn
{
    public enum InstrumentType {
        guitar, 
        cello, 
        violin
    }
    public class TupleExample
    {
        public (string, int) GetGuitarType() {
            return ("Stairway to Heaven", 1);
        }

        public (string GuitarType, int StringCount) GetGuitarTypeWithSuggestedName()
        {
            return ("Les Paul Studio", 6);
        }

        public (string, int) PlayInstrument((string, int) instrumentToPlay)
        {
            return instrumentToPlay;
        }
    }
}
