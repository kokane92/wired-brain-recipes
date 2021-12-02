using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Statistics
    {

        public Statistics()
        {
            High = double.MinValue;
            Low = double.MinValue;
        }

        public void Add(double number)
        {
            Sum += number;
            Count++;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }

        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public int Count;
        public double Sum;
        public double High;
        public double Low;
    }
}
