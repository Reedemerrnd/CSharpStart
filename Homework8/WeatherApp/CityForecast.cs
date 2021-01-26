using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class CityForecast
    {
        public string CityId { get; set; }
        public string Name { get; set; }
        public string MinT { get; set; }
        public string MaxT { get; set; }
        public string DateStamp { get; }
        public CityForecast(string id, string name)
        {
            CityId = id;
            Name = name;
            WeatherInfo weatherInfo = new WeatherInfo(CityId);
            MinT = weatherInfo.TempMin;
            MaxT = weatherInfo.TempMax;
            DateStamp = DateTime.Now.ToShortDateString();
        }
        public CityForecast()
        {

        }
    }
}
