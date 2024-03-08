using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_Unit_testing_02_RychlostniSkrin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _04_Unit_testing_02_RychlostniSkrin.Tests
{
    [TestClass()]
    public class RychlostniSkrinTests
    {
        [TestMethod()]
        public void StartNeutralTest()
        {
            RychlostniSkrin rs = new(1600);
            Assert.AreEqual(Stupen.Neutral, rs.Zarazeno);
        }

        [TestMethod()]
        public void NahoruTest()
        {
            RychlostniSkrin rs = new(1600);
            rs.Nahoru();
            Assert.AreEqual(Stupen.Jednicka, rs.Zarazeno);
        }

        [TestMethod()]
        public void AzNahoruTest()
        {
            RychlostniSkrin rs = new(1600);
            for (int i = 0; i < 7; i++)
            {
                rs.Nahoru();
            }            
            Assert.AreEqual(Stupen.Sestka, rs.Zarazeno);            
        }

        [TestMethod()]
        public void DoluTest()
        {
            RychlostniSkrin rs = new(1600);
            rs.Dolu();
            Assert.AreEqual(Stupen.Zpatecka, rs.Zarazeno);
        }

        [TestMethod()]
        public void AzDoluTest()
        {
            RychlostniSkrin rs = new(1600);
            rs.Dolu();
            rs.Dolu();
            Assert.AreEqual(Stupen.Zpatecka, rs.Zarazeno);
        }

        [TestMethod()]
        public void InitOtackyTest()
        {
            int otacky = 2000;
            RychlostniSkrin rs = new(otacky);
            Assert.AreEqual(otacky, rs.MaxOtackyRazeni);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InitNegOtackyTest()
        {
            RychlostniSkrin rs = new(-1600);
        }

        [TestMethod()]
        public void NahoruMaxOtackyTest()
        {
            int maxOtacky = 2000;
            RychlostniSkrin rs = new(maxOtacky);
            rs.Otacky = 2100;
            rs.Nahoru();
            Assert.AreEqual(Stupen.Neutral, rs.Zarazeno); //ověřím, že nezařadil při vysokých otáčkách
        }

        [TestMethod()]
        public void DoluMaxOtackyTest()
        {
            int maxOtacky = 2000;
            RychlostniSkrin rs = new(maxOtacky);
            rs.Otacky = 2100;
            rs.Dolu();
            Assert.AreEqual(Stupen.Neutral, rs.Zarazeno); //ověřím, že nezařadil při vysokých otáčkách
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AktualniOtackyNegTest()
        {
            int maxOtacky = 2000;
            RychlostniSkrin rs = new(maxOtacky);
            rs.Otacky = -2100;
        }
    }
}