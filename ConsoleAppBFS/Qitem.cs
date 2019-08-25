using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBFS
{
    public class Qitem
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Dist { get; set; }

        public Qitem(int row, int col, int dist)
        {
            this.Col = col;
            this.Row = row;
            this.Dist = dist;
        }
    }
}
