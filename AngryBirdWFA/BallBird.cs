using BallsCommon;

namespace AngryBirdWFA
{

    public class BallBird : Ball
    {
        public BallBird(Label map) : base(map)
        {
            Brush = Brushes.Red;
        }

        public void MovePoint(float x, float y)
        {
            Clear();
            centerX = x;
            centerY = y;
            Show();
        }


    }
}
