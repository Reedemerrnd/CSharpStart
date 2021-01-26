using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Avdeev Roman
// Используя полученные знания и класс TrueFalse, разработать игру «Верю — не верю».
namespace TrueFalseGame
{
    public partial class Form1 : Form
    {
        QuestionList list = new QuestionList();
        Random r = new Random();
        int ind;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            list.AutoLoad();
            RandomQ();
            Score.Text = "Score: " + 0;
        }
        private void RandomQ()
        {
            ind = r.Next(0, list.Count);
            Questions.Text= list[ind].Quest;
        }
        private void Check(string ans)
        {
            if (ans == list[ind].Answer)
            {
                score++;
                Score.Text = "Score: " + score.ToString();
                RandomQ();
            }
            else RandomQ();
        }
        private void True_Click(object sender, EventArgs e)
        {
            Check("true");
        }

        private void False_Click(object sender, EventArgs e)
        {
            Check("false");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            RandomQ();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.SaveToXml();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.LoadDialog();
        }
    
        }
    }

