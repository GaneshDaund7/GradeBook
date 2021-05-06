using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook
{
   public class Books
    {
        List<double> Grades=new List<double>();
         string name;
         public Books(String name)
        {
            this.name = name;
            Console.WriteLine("Welome to " + name);
        }
        public void AddGrades(double grade)
        {
            Grades.Add(grade);
        }

        public Stats GetStats()
        {
            var res =new Stats();
            res.Average=0.0;
            res.LowGrade = Grades[0];
            res.HighGrade = Grades[0];
            foreach (var i in Grades)
            {
                if (res.HighGrade < i)
                    res.HighGrade = i;
                if (res.LowGrade> i)
                    res.LowGrade = i;
                res.Average += i;

                
            }
                
            res.Average /= Grades.Count;
            //Console.WriteLine("The HighestGarde is " + HighGrade);
            //Console.WriteLine("The LowestGrade is " + LowGrade);
            //Console.WriteLine("The Average Garde is "+ res);
            //Console.WriteLine();
            return res;
        }
        
    }
}
