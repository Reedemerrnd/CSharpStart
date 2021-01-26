using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CsvToXmlStudents
{
    class Converter
    {
        public void Convert()
        {
            OpenFileDialog open = new OpenFileDialog();
            SaveFileDialog save = new SaveFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamReader read = new StreamReader(open.OpenFile());
                    XmlSerializer xml = new XmlSerializer(typeof(Student));
                    Stream write = save.OpenFile();
                    while (!read.EndOfStream)
                    {
                        var s = read.ReadLine().Split(';');
                        xml.Serialize(write, new Student(s[0],s[1],s[2],s[3],s[4],int.Parse(s[5]),int.Parse(s[6]),int.Parse(s[7]),s[8]));
                    }
                    write.Close();
                    read.Close();

                }
            }
        }
        
    }
}
