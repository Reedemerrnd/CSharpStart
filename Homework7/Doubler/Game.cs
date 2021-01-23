using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
    class Game
    {
        public int Num { get; set; }
        public int Target { get; set; }
        public int Turns { get; set; }
        public bool Started { get; set; }
        Random r = new Random();
        public Game()
        {       
            Num = 0;
            Turns = 0;
        }
        public void NewTarget()
        {
            Started = true;
            Target = r.Next(10,100);
            Turns = 0;
        }
        public bool Check(int n)
        {
            if (Started)
            {
                ++Turns;
                if (n == Target)
                {
                    MessageBox.Show($"gratz, it taked you: {Turns} turns");
                    return true;
                }
                
            }
            return false;
        }
    }
}
