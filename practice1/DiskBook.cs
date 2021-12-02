using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace practice1
{
    class DiskBook : Book
    {

        public DiskBook(string name) : base(name)
        {

        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                
            }              
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            using(var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while(line != null){
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }     
            }
            return result;
        }
    }
}
