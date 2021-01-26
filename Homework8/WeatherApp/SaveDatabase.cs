using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace WeatherApp
{
    class SaveDatabase
    {
        List<CityForecast> ForecastDB = new List<CityForecast>();
        public SaveDatabase(int n)
        {
            
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Xml files (*.xml)|*.xml";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                CityList list = new CityList();
                for (int i = 0; i < (list.Data.Count < n ? list.Data.Count : n); i++)
                {
                    ForecastDB.Add(new CityForecast(list.Data[i].CityId, list.Data[i].Name));
                }
                Stream stream = saveDialog.OpenFile();
                XmlSerializer ser = new XmlSerializer(typeof(List<CityForecast>));
                ser.Serialize(stream, ForecastDB);
                stream.Close();
            }
        }
    }
}
