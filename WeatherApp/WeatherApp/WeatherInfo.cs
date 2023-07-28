﻿using System;
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
            public double lon { get; set; }
            public double lat { get; set; }
        }
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public int humidity { get; set; }
        }
        public class sys
        {
            public string country { get; set; }
        }
        public class root
        {
            public coord coord { get; set; }
            public List <weather> weather { get; set; }
            public main main { get; set; }
            public sys sys { get; set; }
            public string name { get; set; }
        }
    }
}
