using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_Unit_testing_01_Minimum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Unit_testing_01_Minimum.Tests
{
    [TestClass()]
    public class ToolsTests
    {
        [TestMethod()]
        public void FindMinTest()
        {
            int[] nums = [6, 1, 3, 12, 4, 7, 2];
            Assert.AreEqual(1, Tools.FindMin(nums));           
        }

        [TestMethod()]
        [ExpectedException(typeof(EmptyArrayException))]
        public void FindMinEmptyArrTest()
        {
            int[] nums = [];
            Tools.FindMin(nums);
        }
    }
}