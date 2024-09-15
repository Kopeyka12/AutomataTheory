using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Play
{
    public class Game
    {
        public Ant ant;
        public Point leaf;
        public Point home;
        private Random random;

        public Game(int width, int height)
        {
            random = new Random();
            ant = new Ant(random.Next(width), random.Next(height));
            leaf = new Point(random.Next(width), random.Next(height));
            home = new Point(random.Next(width), random.Next(height));
        }
    }
}
