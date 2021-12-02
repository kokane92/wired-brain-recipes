using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    abstract class Book : NamedObject, IBook
    {
        public Book(string name): base(name)
        {

        }

        public abstract void AddGrade(double grade);
        public abstract Statistics GetStatistics();

    }
    
}
