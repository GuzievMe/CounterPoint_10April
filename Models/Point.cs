using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10AprilHomeworkCs4.cs.point
{
   
        class ClassCounter
        {
            
             public ClassCounter () { Min = 0; Max = 0; Count = 0; }
            public ClassCounter(int min, int max, int count = 0)
            {
                Min = min; Max = max;
                if (count > min && count < max) Count = count;
            }
            //fields
            private int _max, _min, _count;
            //property
            public int Max { get { return _max; } init { _max = value; } }
            public int Min { get { return _min; } init { _min = value; } }
            public int Count { get { return _count; } set { if (value < Max && value >= Min) _count = value; else _count = 0; } }

            //eleBele method
            public int Increment()
            {
                if (Count < this.Max) Count++; else Count = 0;               ////////property  bunu zaten edir !!!
                return this.Count;
            }

            //stringOverloading
            public override string ToString()
            {
                return $"Count is {Count} . There is {Max - Count} empty space yet .";
            }
        }
}
