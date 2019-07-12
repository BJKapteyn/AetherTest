using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace AetherTest
{
    public class Class1
    {
        [Fact]
        public void DataTest()
        {

        }

        public static double PollutantAverages(List<PollutantData> PD, Func<PollutantData, IComparable> pollutant)
        {
            double pollutantAverage;
            double pollutantSum;

            PD.RemoveAll(x => (double)pollutant(x) == 0);

            if (PD.Count > 0)
            {
                pollutantSum = PD.Sum(x => (double)pollutant(x));
                pollutantAverage = Math.Round((pollutantSum / PD.Count), 3);
                return pollutantAverage;
            }

            return 0;
        }
    }

    public class PollutantData
    {
        public string Dev_id { get; set; }
        public DateTime Time { get; set; }
        public double? O3 { get; set; }
        public double? Pm25 { get; set; }
        public double? PM10 { get; set; }
        public double? CO { get; set; }
        public double? NO2 { get; set; }
        public double? SO2 { get; set; }
        public int Id { get; set; }

        public static List<PollutantData> Data ()
        {
            List<PollutantData> data = new List<PollutantData>();
            data.Add(
                new PollutantData
                {
                    Dev_id = "1",
                    O3 = 0,
                    Pm25 = 0,
                    NO2 = .04,
                    SO2 = .02
                });
            data.Add(
                new PollutantData
                {
                    Dev_id = "2",
                    O3 = .02,
                    Pm25 = .03,
                    NO2 = 0,
                    SO2 = .03
                });
            data.Add(
                new PollutantData
                {
                    Dev_id = "3",
                    O3 = .04,
                    Pm25 = 0,
                    NO2 = 0,
                    SO2 = .00
                });
                data.Add(
                new PollutantData
                {
                    Dev_id = "4",
                    O3 = .05,
                    Pm25 = .05,
                    NO2 = .03,
                    SO2 = .05
                }
                );
            return data;
        }


    }
}
