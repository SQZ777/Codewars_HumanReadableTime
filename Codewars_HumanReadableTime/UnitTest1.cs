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
    }

    public class TimeFormat
    {
        public static int GetHour(int num)
        {
            throw new System.NotImplementedException();
        }
    }
}
