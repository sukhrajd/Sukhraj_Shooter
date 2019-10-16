using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sukhraj_Shooter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukhraj_Shooter.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void mainTest()
        {
            Form1 obj = new Form1();

            
        }

        [TestMethod()]
        public void abstractTest() {
            abstractClass obj = new abstractClass();
        }
    }
}