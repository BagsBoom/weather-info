using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showTime();
            getDefaultCityWeather();
            getCurrentForecast();
        }
        string APIKey = "3467ab89a677299ca993ed1747d06166";
        double lon, lat;

        void showTime()
        {
            var date = DateTime.Now;
            timeLabel.Text = date.ToString("D");
            labelDayOfWeek.Text = date.ToString("dddd");
        }

        void getWeather()
        {
            using (WebClient webClient = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", textBoxCity.Text, APIKey);
                var json = webClient.DownloadString(url);
                WeatherInfo.root weatherInfo = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                pictureBoxIcon.ImageLocation = "https://openweathermap.org/img/w/" + weatherInfo.weather[0].icon + ".png";
                labelDesc.Text = weatherInfo.weather[0].main;
                labelCity.Text = weatherInfo.name + ", " + weatherInfo.sys.country;
                labelTemp.Text = Convert.ToInt32(weatherInfo.main.temp - 273.15).ToString() + " °C";

                lon = weatherInfo.coord.lon;
                lat = weatherInfo.coord.lat;
            }
        }

        void getDefaultCityWeather()
        {
            using (WebClient webClient = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=Kyiv&appid={0}", APIKey);
                var json = webClient.DownloadString(url);
                WeatherInfo.root weatherInfo = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                pictureBoxIcon.ImageLocation = "https://openweathermap.org/img/w/" + weatherInfo.weather[0].icon + ".png";
                labelDesc.Text = weatherInfo.weather[0].main;
                labelCity.Text = weatherInfo.name + ", " + weatherInfo.sys.country;
                labelTemp.Text = Convert.ToInt32(weatherInfo.main.temp - 273.15).ToString() + " °C";
            }
        }

        void getForecast()
        {
            using (WebClient webClient = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&cnt=3&appid={2}", lat, lon, APIKey);
                var json = webClient.DownloadString(url);
                Forecast.ForecastInfo forecastInfo = JsonConvert.DeserializeObject<Forecast.ForecastInfo>(json);

                FLPForecast.Controls.Clear();

                UserControlForecast userControlForecast;
                for (int i = 0; i < 3; i++)
                {
                    userControlForecast = new UserControlForecast();

                    userControlForecast.pictureBoxIconUC.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.list[i].weather[0].icon + ".png";
                    userControlForecast.labelTempUC.Text = Convert.ToInt32(forecastInfo.list[i].main.temp - 273.15).ToString()+ " °C";
                    userControlForecast.labelDescUC.Text = forecastInfo.list[i].weather[0].main.ToString();
                    userControlForecast.labelTimeUC.Text = forecastInfo.list[i].dt_txt.ToString();

                    FLPForecast.Controls.Add(userControlForecast);
                }


            }
        }

        void getCurrentForecast()
        {
            using(WebClient webClient = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat=50.4333&lon=30.5167&cnt=3&appid={0}", APIKey);
                var json = webClient.DownloadString(url);
                Forecast.ForecastInfo forecastInfo = JsonConvert.DeserializeObject<Forecast.ForecastInfo>(json);

                FLPForecast.Controls.Clear();

                UserControlForecast userControlForecast;
                for (int i = 0; i < 3; i++)
                {
                    userControlForecast = new UserControlForecast();

                    userControlForecast.pictureBoxIconUC.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.list[i].weather[0].icon + ".png";
                    userControlForecast.labelTempUC.Text = Convert.ToInt32(forecastInfo.list[i].main.temp - 273.15).ToString() + " °C";
                    userControlForecast.labelDescUC.Text = forecastInfo.list[i].weather[0].main.ToString();
                    userControlForecast.labelTimeUC.Text = forecastInfo.list[i].dt_txt.ToString();

                    FLPForecast.Controls.Add(userControlForecast);
                }
            }
        }

        private void changeLocButton_Click(object sender, EventArgs e)
        {
            getForecast();
            
            string cityName = textBoxCity.Text.Trim();
            if(string.IsNullOrEmpty(cityName))
            {
                MessageBox.Show("Please enter a city name.");
                return;
            }
            try
            {
                getWeather();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! Check the input data. " + ex.Message);
            }
        }
    }
}