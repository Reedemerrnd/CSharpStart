using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    class WeatherInfo
    {

        public WeatherInfo(string cityId)
        {
            try
            {
                var r = Internet.cl.webClient
                    .DownloadString($"https://worldweather.wmo.int/ru/json/{cityId}_ru.xml");
                dynamic c = JObject.Parse(r);



                //Console.WriteLine(c); Console.WriteLine("----------");
                //return;


                TempMin = $"{c.city.forecast.forecastDay[0].minTemp} °c";
                TempMax = $"{c.city.forecast.forecastDay[0].maxTemp} °c";

            }
            catch (ArgumentOutOfRangeException)
            {
                TempMin = "N/A";
                TempMax = "N/A";
            }
            catch
            {
                MessageBox.Show("Cannot load forecast","Error");
            }
        



        }
        public string TempMax { get; }
        public string TempMin { get; }
    }
}
