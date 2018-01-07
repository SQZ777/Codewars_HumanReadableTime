using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_HumanReadableTime
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetHour_Input_0_Should_Be_0()
        {
            Assert.AreEqual(0, TimeFormat.GetHour(0));
        }

        [TestMethod]
        public void GetHour_Input_3600_Should_Be_1()
        {
            Assert.AreEqual(1, TimeFormat.GetHour(3600));
        }

        [TestMethod]
        public void GetMin_Input_0_Should_Be_0()
        {
            Assert.AreEqual(0, TimeFormat.GetMin(0));
        }

        [TestMethod]
        public void GetMin_Input_3600_Should_Be_0()
        {
            Assert.AreEqual(0, TimeFormat.GetMin(3600));
        }

        [TestMethod]
        public void GetMin_Input_100_Should_Be_1()
        {
            Assert.AreEqual(1, TimeFormat.GetMin(100));
        }

        [TestMethod]
        public void GetSec_Input_0_Should_Be_0()
        {
            Assert.AreEqual(0,TimeFormat.GetSec(0));
        }
    }

    public class TimeFormat
    {
        public static int GetHour(int num)
        {
            return num / 3600;
        }

        public static int GetMin(int num)
        {
            return num / 60 % 60;
        }

        public static int GetSec(int num)
        {
            return 0;
        }
    }
}
