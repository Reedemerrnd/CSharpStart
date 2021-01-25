using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{

    class CityList
    {

        public List<City> Data { get; }

        public CityList(/*ListBox lb*/)
        {
            try
            {
                Timer timer = new Timer();
                timer.Interval = 10000;
                Data = new List<City>();
                timer.Enabled = true;
                timer.Tick += Timer_Tick;
                MessageBox.Show("для отладки, исключение через 10 сек");
                string url = @"https://worldweather.wmo.int/ru/json/full_city_list.txt";

                var datas = Internet.cl
                                       .webClient
                                       .DownloadString(url)
                                       .Split('\n')
                                       ;
                //Console.WriteLine(datas.Length);

                for (int i = 1; i < datas.Length - 2; i++)
                {
                    var dataLine = datas[i].Replace("\"", "").Split(';');

                    var city = new City()
                    {
                        Country = dataLine[0],
                        Name = dataLine[1],
                        CityId = dataLine[2]
                    };
                    Data.Add(city);
                    //lb.Items.Add(city);
                    timer.Stop();
                }
            }
            catch (TimeoutException e)
            {
                MessageBox.Show("LoadTimeOut", "Error");
            }
            catch
            {
                MessageBox.Show("Cannot Load city list", "Error");
            }


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            throw new TimeoutException();

        }

    }
}
