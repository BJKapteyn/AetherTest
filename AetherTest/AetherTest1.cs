using System;
using System.Diagnostics;
using Xunit;

namespace AetherTest
{
    public class AetherTest1
    {
        [Fact]
        public void Test1()
        {
            string rightTime = "2019-07-09 15:21";
           
            Assert.Equal(rightTime, GetEarlierTime(-23));
        }

        [Fact]
        public void Test2()
        {
            string rightTime = "2019-07-08 14:21";

            Assert.Equal(rightTime, GetEarlierTime(-48));
        }

        public static string GetEarlierTime(int hours)
        {
            DateTime date = DateTime.Now.AddHours(hours);
            string pastDate = date.ToString("yyyy-MM-dd");
            string pastTime = date.ToString("HH:mm");
            return $"{pastDate} {pastTime}";

        }

    }
}
