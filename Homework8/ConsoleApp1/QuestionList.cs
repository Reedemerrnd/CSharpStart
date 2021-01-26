using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrueFalseGame
{
    class QuestionList
    {
        List<Question> data;
        public Question this[int index]
        {
            get => data[index];
        }
        string path;
        public QuestionList()
        {
            
        }
        private void LoadFromCsv(Stream file)
        {
            StreamReader strRd = new StreamReader(file);              
            while  (!strRd.EndOfStream)
            {
                var s = strRd.ReadLine().Split('=');
                data.Add(new Question(s[0], (s[1] == "да" ? "true" : "false")));
            }
            strRd.Close();
            file.Close();
        }
        private void LoadFromXML(Stream file)
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<Question>));
            data = serial.Deserialize(file) as List<Question>;
            file.Close();
        }
        public void SaveToXml()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Xml files (*.xml)|*.xml";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveDialog.OpenFile();
                XmlSerializer ser = new XmlSerializer(typeof(List<Question>));
                ser.Serialize(stream, data);
                stream.Close();
            }
        }
        public void LoadDialog()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Xml files (*.xml)|*.xml|Txt files (*.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.InitialDirectory;
                if (openFile.FilterIndex == 0) LoadFromXML(openFile.OpenFile());
                else if (openFile.FilterIndex == 1) LoadFromCsv(openFile.OpenFile());

            }
        }
        public void AutoLoad()
        {

        }

    }
}
