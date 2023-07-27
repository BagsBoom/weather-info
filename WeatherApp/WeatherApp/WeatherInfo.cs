using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class WeatherInfo
    {
        public class coord
        {
            double lon { get; set; }
            double lat { get; set; }
        }
        public class weather
        {
            string main { get; set; }
            string description { get; set; }
            string icon { get; set; }
        }
        public class main
        {
            double temp { get; set; }
            double feels_like { get; set; }
            int humidity { get; set; }
        }
        public class root
        {
            public coord coord { get; set; }
            public List <weather> weather { get; set; }
            public main main { get; set; }
        }
    }
}
