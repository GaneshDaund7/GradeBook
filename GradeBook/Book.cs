using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook
{
    class Book
    {
         List<double> Grades=new List<double>();
         string name;
         public Book(String name)
        {
            this.name = name;
            Console.WriteLine("Welome to " + name);
        }
        public void AddGrades(double grade)
        {
            Grades.Add(grade);
        }

        public void ShowStats()
        {
            var res = 0.0;
            var LowGrade = Grades[0];
            var HighGrade = Grades[0];
            foreach (var i in Grades)
            {
                if (HighGrade < i)
                    HighGrade = i;
                if (LowGrade> i)
                    LowGrade = i;
                res += i;
            }
                
            res /= Grades.Count;
            Console.WriteLine("The HighestGarde is " + HighGrade);
            Console.WriteLine("The LowestGrade is " + LowGrade);
            Console.WriteLine("The Average Garde is "+ res);
            Console.WriteLine();
           
        }
        

    }


}
