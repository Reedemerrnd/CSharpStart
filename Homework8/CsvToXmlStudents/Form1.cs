using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
// Avdeev Roman
//. *Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
namespace CsvToXmlStudents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Convert();
        }
        public void Convert()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "csv Files (*.csv)|*.csv|Txt files (*.txt)|*.txt";
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "xml files (*.xml)|*.xml";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamReader read = new StreamReader(open.OpenFile());
                    XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
                    Stream write = save.OpenFile();
                    List<Student> data = new List<Student>();
                    while (!read.EndOfStream)
                    {
                        var s = read.ReadLine().Split(';');
                        data.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    }
                    xml.Serialize(write, data);
                    write.Close();
                    read.Close();
                    MessageBox.Show("Done");

                }
            }
        }
    }
}
