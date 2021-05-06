using System;
using GradeBook;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class BooksTests
    {
        [TestMethod]
        public void ShowStatTests()
        {
            //var x = 10.1;
            //var y = 5.2;
            //var expee = 15.3;
            //var actu = x + y;
            //Assert.AreEqual(expee, actu);

            // Arrange
            var book = new Books("");
            book.AddGrades(90.6);
            book.AddGrades(87.2);
            book.AddGrades(93.2);

           



            //act

            var res = book.GetStats();
            
                
            //assert

            Assert.AreEqual(90.3, res.Average,1);
            Assert.AreEqual(87.2, res.LowGrade, 1);
            Assert.AreEqual(93.2, res.HighGrade, 1);

            
        }
    }
}
