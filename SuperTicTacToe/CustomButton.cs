using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTicTacToe
{
    public class CustomButton : Button
    {
        public string? Checked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Table { get; set; }
        public int NextTable { get; set; }
    }

}
