using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
/* Avdeev Roman
 * а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия,авторские права и др.).
г) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
д) Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
*/
namespace WeatherApp
{
    public partial class Form1 : Form, IView
    {
        public IEnumerable<City> Data
        {
            set
            {
                foreach (var item in value)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        public string CityID 
        { get 
            {
                if (listBox2.SelectedItem == null)
                    return (listBox1.SelectedItem as City).CityId;
                else
                   return (listBox1.Items[listBox1.FindStringExact(listBox2.SelectedItem.ToString())] as City).CityId ;
            } 
        }

        public string TempMin { set => label1.Text = value; }
        public string TempMax { set => label2.Text = value; }

        Updater updater;
        public Form1()
        {
            InitializeComponent();
            
            updater = new Updater(new CityList(), this);
            listBox1.SelectedIndexChanged += delegate
            {
                updater.GetTemp();
            };


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updater.GetTemp();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            foreach (var item in listBox1.Items)
            {
                if ((item as City).Name.ToLower().IndexOf(textBox1.Text) != -1)
                    listBox2.Items.Add(item);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = @"Автор: Сергей Камянецкий
Рюшечки: Роман Авдеев
2021 ГикБрейнс";
            MessageBox.Show(about, "Info");
        }

        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SaveDatabase(10);
        }
    }
}
