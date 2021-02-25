using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_booking_assignH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_booking_assignH.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Controller.DatabaseClass db = new Controller.DatabaseClass();
            Boolean test = db.addClient("Aman", "12", "2345", "NZ");
            if (test)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void Form2Test()
        {
            Controller.DatabaseClass db = new Controller.DatabaseClass();
            Boolean test = db.addVideo("qw","2.3","2019","qwe","5","3","ok");
            if (test)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }


    }
}