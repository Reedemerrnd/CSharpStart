using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Avdeev Roman
/*а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. 
Игрок должен постараться получить это число за минимальное количество ходов.
в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
*/
namespace Doubler
{
    public partial class Form1 : Form
    {
        int buttonCounter=0;
        Stack<int> last = new Stack<int>();
        Game g = new Game();
        public Form1()
        {
            InitializeComponent();
            CommandsCount.Text = "Commands count: 0";
            Increment.Text = "+1";
            Multiplyer.Text = "x2";
            Reset.Text = "Reset";
            Undo.Text = "Undo";
            Target.Text = "";
            Turns.Text = "";
            last.Push(0);
            Score.Text = last.Peek().ToString();
           
        }
        private void IncCounter()
        {
            buttonCounter++;
            CommandsCount.Text = "Commands count: "+buttonCounter.ToString();
        }
        private void Update()
        {

            Score.Text = last.Peek().ToString();
            if (g.Started)
            {
                Target.Text = "get " + g.Target;
                Turns.Text = "Turns :" + g.Turns;
            }
            IncCounter();
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Increment_Click(object sender, EventArgs e)
        {
            last.Push(last.Peek()+1);
            if (g.Check(last.Peek())) ResetAll();
            Update();
        }

        private void Multiplyer_Click(object sender, EventArgs e)
        {
            last.Push(last.Peek()*2);
            if (g.Check(last.Peek())) ResetAll() ;
            Update();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (last.Count > 1)
            {
                last.Pop();
                Update();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            last.Clear();
            last.Push(0);
            g.NewTarget();
            Update();

        }

        private void counterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetAll();
        }
        private void ResetAll()
        {
            last.Clear();
            last.Push(0);
            Update();
            Target.Text = "";
            Turns.Text = "";
            g.Started = false;
        }
    }
}
