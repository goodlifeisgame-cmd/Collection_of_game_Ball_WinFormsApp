
namespace BallsCommon
{
    public class Ball
    {
        public Brush Brush = Brushes.Aqua;
        public bool IsHit = false;

        protected Label map;
        protected float centerX = 50;
        protected float centerY = 50;
        public float Radius = 15;
        protected static Random random = new Random();

        private Graphics graphics;


        public Ball(Label map)
        {
            this.map = map;
            graphics = map.CreateGraphics();

            centerX = random.Next((int)LeftSide(), (int)RightSide());
            centerY = random.Next((int)TopSide(), (int)DownSide());
        }

        public bool WindowSave()
        {
            return centerX > LeftSide() && centerX < RightSide() && centerY > TopSide() && centerY < DownSide();
        }

        public void Show()
        {
            Draw(Brush);
        }

        public void Clear()
        {
            Draw(new SolidBrush(map.BackColor));
        }

        public float LeftSide()
        {
            return Radius;
        }
        public float RightSide()
        {
            return map.Width - Radius;
        }
        public float TopSide()
        {
            return Radius;
        }
        public float DownSide()
        {
            return map.Height - Radius;
        }

        public float GetPositionX()
        {
            return centerX;
        }
        public float GetPositionY()
        {
            return centerY;
        }

        public float GetRadius()
        {
            return Radius;
        }

        public virtual bool TryHit(int pointX, int pointY)
        {
            if (!IsHit)
            {
                float dX = (float)pointX - centerX;
                float dY = (float)pointY - centerY;

                if (dX * dX + dY * dY <= Radius * Radius)
                {
                    IsHit = true;
                    Brush = Brushes.Red;
                    return true;
                }
            }
            return false;
        }

        private void Draw(Brush brush)
        {
            var rectangle = new RectangleF((centerX - Radius), centerY - Radius, Radius * 2, Radius * 2);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
