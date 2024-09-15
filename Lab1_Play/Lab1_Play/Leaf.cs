using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Play
{
    public class Leaf
    {
        public PointF Position { get; private set; }

        private static Random random = new Random();

        public Leaf(PointF position)
        {
            Position = position;
        }

        // Устанавливаем новую случайную позицию
        public void SetRandomPosition()
        {
            Position = new PointF(random.Next(20, 400), random.Next(20, 400)); // Задаём границы формы
        }

    }
}
