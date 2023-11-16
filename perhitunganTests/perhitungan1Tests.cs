using Microsoft.VisualStudio.TestTools.UnitTesting;
using perhitungan;
using System;
using System.Collections.Generic;
using System.Text;

namespace perhitungan.Tests
{
    [TestClass()]
    public class perhitungan1Tests
    {
        [TestMethod()]
        public void AddTest()
        {
            perhitungan1 perhitungan = new perhitungan1();
            Assert.AreEqual(15, perhitungan.Add(7,8));
            
        }

        [TestMethod()]
        public void SubtractTest()
        {
            perhitungan1 perhitungan = new perhitungan1();
            Assert.AreEqual(15, perhitungan.Subtract(20,5));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            perhitungan1 perhitungan = new perhitungan1();
            Assert.AreEqual(15, perhitungan.Multiply(5,3));
        }

        [TestMethod()]
        public void DivideTest()
        {
            perhitungan1 perhitungan = new perhitungan1();
            Assert.AreEqual(15, perhitungan.Divide(120,8));
        }
    }
}