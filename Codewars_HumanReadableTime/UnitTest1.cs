using System;
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
            Assert.AreEqual(0, TimeFormat.GetSec(0));
        }

        [TestMethod]
        public void GetSec_Input_100_Should_Be_40()
        {
            Assert.AreEqual(40, TimeFormat.GetSec(100));
        }

        [TestMethod]
        public void GetSec_Input_3600_Should_Be_0()
        {
            Assert.AreEqual(0, TimeFormat.GetSec(3600));
        }

        [TestMethod]
        public void Input_0_Should_Be_00_00_00()
        {
            Assert.AreEqual("00:00:00", TimeFormat.GetReadableTime(0));
        }

        [TestMethod]
        public void Input_5_Should_Be_00_00_05()
        {
            Assert.AreEqual("00:00:05", TimeFormat.GetReadableTime(5));
        }

        [TestMethod]
        public void Input_60_Should_Be_00_01_00()
        {
            Assert.AreEqual("00:01:00", TimeFormat.GetReadableTime(60));
        }

        [TestMethod]
        public void Input_86399_Should_Be_23_59_59()
        {
            Assert.AreEqual("23:59:59", TimeFormat.GetReadableTime(86399));
        }

        [TestMethod]
        public void Input_359999_Should_Be_99_99_99()
        {
            Assert.AreEqual("99:59:59", TimeFormat.GetReadableTime(359999));
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
            return num % 60;
        }

        public static string GetReadableTime(int num)
        {
            var hour = GetHour(num).ToString();
            var min = GetMin(num).ToString();
            var sec = GetSec(num).ToString();
            if (Convert.ToInt32(hour) < 10)
                hour = "0" + hour;
            if (Convert.ToInt32(min) < 10)
                min = "0" + min;
            if (GetSec(num) < 10)
                sec = "0" + sec;
            return hour + ":" + min + ":" + sec;
        }
    }
}
