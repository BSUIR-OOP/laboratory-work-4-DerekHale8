using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4OOP
{
    public class RandomNumberColor : IRandomColorWriter
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public void ColorWrite()
        {
            Random random = new Random();
            Red = random.Next(0, 255);
            Green = random.Next(0, 255);
            Blue = random.Next(0, 255);
            //MessageBox.Show(Red.ToString(), Green.ToString(), Blue.ToString());
        }

    }
}
