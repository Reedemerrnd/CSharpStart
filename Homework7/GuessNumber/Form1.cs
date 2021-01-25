using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Avdeev Roman
 * Используя Windows Forms, разработать игру «Угадай число». 
 * Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
 * Для ввода данных от человека используется элемент TextBox.
 * */
namespace GuessNumber
{
    public partial class Form1 : Form
    {
        int turns = 0;
        int target;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            label1.Text = "guess number";
            turns = 0;
            target = r.Next(0, 100);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                turns++;
                int answer=-1;
                int.TryParse(textBox1.Text, out answer);
                if (answer == target)
                {
                    MessageBox.Show($"gratz, you did it in {turns} turns");
                    turns = 0;
                    target = r.Next(0, 100);
                    label1.Text = "guess number";
                }
                else if (answer > target) label1.Text = "lower";
                else if (answer < target && answer >= 0) label1.Text = "higher";
                textBox1.Text = "";

            }
        }

    }
}
