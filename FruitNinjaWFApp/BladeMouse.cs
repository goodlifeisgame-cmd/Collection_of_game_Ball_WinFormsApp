using BallsCommon;

namespace FruitNinjaWFApp
{
    public class BladeMouse : MoveBall
    {
        public BladeMouse(Label map, float x, float y) : base(map)
        {
            centerX = x;
            centerY = y;
            Radius = 5;
            Brush = Brushes.Red;
        }

        public bool ReduceSize()
        {
            if (Radius > 0)
            {
                Radius -= 1;
                return true;
            }

            return false;
        }
    }
}
