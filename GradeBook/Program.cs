using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Books("GD's Grade Book");
            book1.AddGrades(9.9);
            book1.AddGrades(7.8);
            book1.AddGrades(7.9);
            book1.AddGrades(8.5);
            book1.AddGrades(8.6);
            var stats=book1.GetStats();



            //var book2 = new Books("GK's Grade Book");
            //book2.AddGrades(9.7);
            //book2.AddGrades(8.7);
            //book2.AddGrades(7.7);
            //book2.AddGrades(9.5);
            //book2.AddGrades(7.9);
            //var stats=book2.GetStats();

            //var book3 = new Books("SS's Grade Book");
            //book3.AddGrades(9.99);
            //book3.AddGrades(8.9);
            //book3.AddGrades(9.6);
            //book3.AddGrades(8.7);
            //book3.AddGrades(8.9);
            //book3.ShowStats();


            Console.ReadLine();
        }
    }
}
