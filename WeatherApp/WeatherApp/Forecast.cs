using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class Forecast
    {
        public class list
        {
            public long dt { get; set; }
            public main main { get; set; }
            public List<weather> weather { get; set; }
            public string dt_txt { get; set; }
        }
        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double humidity { get; set; }
        }
        public class weather
        {
            public string main { get; set; }
            public string icon { get; set; }
        }

        public class ForecastInfo
        {
            public List<list> list { get; set; }
        }
    }
}
