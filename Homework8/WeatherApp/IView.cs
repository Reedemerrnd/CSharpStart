using System.Collections.Generic;

namespace WeatherApp
{
    internal interface IView
    {
        IEnumerable<City> Data { set; }
        string Name { get; }
        string CityID { get; }
        string TempMin { set; }
        string TempMax { set; }

    }
}