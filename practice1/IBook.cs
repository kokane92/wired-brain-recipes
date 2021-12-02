using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    interface IBook
    {
        void AddGrade(double grade);
        string Name { get;  }
    }
}
