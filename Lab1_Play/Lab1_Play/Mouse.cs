using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Play
{
    public class Mouse
    {
        public PointF Position { get; set; }

        public Mouse(PointF position)
        {
            Position = position;
        }
    }
}
