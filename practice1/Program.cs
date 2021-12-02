using System;
using System.Collections.Generic;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradeInput = null;
            Book book = new DiskBook("Grade Book");
            gradeInput = EnterGrades(book);

        }

        private static string EnterGrades(Book book)
        {
            string gradeInput;
            do
            {
                Console.WriteLine("Please enter a grade. To exit, enter q:");
                gradeInput = Console.ReadLine();
                if (!gradeInput.Equals("q"))
                {
                    try
                    {
                        double grade = double.Parse(gradeInput);
                        book.AddGrade(grade);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Incorrect format");
                    }
                }
                else
                {
                    book.GetStatistics();
                    break;
                }

            } while (!gradeInput.Equals("q"));
            return gradeInput;
        }

    }


}
