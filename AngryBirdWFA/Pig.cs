using BallsCommon;

namespace AngryBirdWFA
{
    public class Pig : BallBird
    {
        public Pig(Label map, float x, float y) : base(map)
        {
            centerX = x;
            centerY = y;
            Brush = Brushes.Green;
        }

        public override bool TryHit(int pointX, int pointY)
        {
            if (!IsHit)
            {
                float dX = (float)pointX - centerX;
                float dY = (float)pointY - centerY;

                if (dX * dX + dY * dY <= (Radius * Radius))
                {
                    IsHit = true;
                    Clear();

                    return true;
                }
            }
            return false;
        }

        public bool IsTouching(Ball otherBall)
        {
            if (!IsHit)
            {
                var dX = centerX - otherBall.GetPositionX();
                var dY = centerY - otherBall.GetPositionY();

                var radiusSum = Radius + otherBall.Radius;
                if (dX * dX + dY * dY <= radiusSum * radiusSum)
                {
                    IsHit = true;
                    Clear();

                    return true;
                }
            }

            return false;
        }

    }
}
