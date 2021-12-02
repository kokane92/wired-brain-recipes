using System;
using System.IO;
using System.Collections.Generic;

namespace practice1
{
    class InMemoryBook : Book
    {
        private List<double> grades;

        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        public string Name{get;set;}

        private string name;

        public override void AddGrade(double grade)
        {
            if(grade > 0 && grade < 100)
            {
                grades.Add(grade);
                
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Invalid {nameof(grade)}");
            }
        }

        public List<double> GetGrades()
        {
            return grades;
        }

        public void ShowStats()
        {
            double average = 0.0;
            double highest = double.MinValue;
            double lowest = double.MaxValue;
            foreach (double grade in grades)
            {
                average += grade;
                
            }

            average /= grades.Count;

            if (grades.Count > 0)
            {
                Console.WriteLine($"The average grade is {average}");
                Console.WriteLine($"The highest grade is {highest}");
                Console.WriteLine($"The lowest grade is {lowest}");
            } else
            {
                Console.WriteLine("Insufficent data to produce stats");
            }

            
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            using (var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }
            return result;
        }
    }

}
