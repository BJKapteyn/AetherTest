using System;
using Xunit;

namespace AetherTest
{
    public class AetherTest1
    {
        [Fact]
        public void Test1()
        {
            string rightTime = "2019-07-09";

            Assert.Equal(rightTime, GetEarlierTime(-24));
        }

        public static string GetEarlierTime(int hour)
        {
            DateTime now = new DateTime();
            int minusHours = 0;
            int minusDays = 0;
            if((double)hour/24 >= 0)
            {
                minusHours = hour % 24;
                minusDays = hour / 24;

            }

            string dateHour = now.AddHours(-minusHours).ToString("HH");

            return before;
        }
    }
}
