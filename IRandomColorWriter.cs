using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4OOP
{
   public interface IRandomColorWriter
    {
        int Red { get; set; }
        int Green { get; set; }
        int Blue { get; set; }

        void ColorWrite();
    }
}
