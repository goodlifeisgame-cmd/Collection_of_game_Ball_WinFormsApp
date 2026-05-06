using System.Drawing;
using System.Reflection.Emit;

namespace BallGamesWinFormsApp.Ball
{
    public class BallMain
    {
        protected Label map;
        private Graphics graphics;
        protected Brush brush = Brushes.Aqua;
        protected int x = 150;
        protected int y = 150;
        protected int vx = 10;
        protected int vy = 15;
        protected int size = 70;
        public bool Hit = false;


        public BallMain(Label map)
        {
            this.map = map;
        }

        public void Move()
        {
            Clear();

            int radius = size / 2;
            if (x - radius <= 0)
            {
                vx = -vx;
            }
            if (x + radius >= map.Width)
            {
                vx = -vx;
            }
            if (y - radius <= 0)
            {
                vy = -vy;
            }
            if (y + radius >= map.Height)
            {
                vy = -vy;
            }

            Go();
            Show();
        }

        public void MoveEnd()
        {
            int radius = size / 2;
            if (y + radius <= map.Height)
            {
                Clear();
                vx = 0;
                vy = 2;
                Go();
            }
            Show();
        }

        public bool ClickMe(int X, int Y)
        {
            int radius = size / 2;

            if (x - radius < X && X < x + radius)
            {
                if (y - radius < Y && Y < y + radius)
                {
                    Hit = true;
                    brush = Brushes.Red;
                    return true;
                }
            }
            return false;
        }

        public void Show()
        {
            graphics = map.CreateGraphics();
            var rectangle = new Rectangle(x - size / 2, y - size / 2, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        private void Go()
        {
            x += vx;
            y += vy;
        }

        private void Clear()
        {
            graphics = map.CreateGraphics();
            var brush = new SolidBrush(map.BackColor);
            var rectangle = new Rectangle(x - size / 2, y - size / 2, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

    }
}
