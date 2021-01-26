using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Updater
    {

        CityList list;
        IView view;
        public Updater(CityList list, IView view)
        {
            this.list = list;
            this.view = view;
            view.Data = list.Data;
        }

        public void GetTemp( )
        {
            var data = new WeatherInfo(view.CityID) ;
            view.TempMax = data.TempMax;
            view.TempMin = data.TempMin;
        }

    }
}
