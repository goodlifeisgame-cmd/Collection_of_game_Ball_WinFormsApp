using BallsCommon;

namespace AngryBirdWFA
{

    public class BallBirdMove : MoveBall
    {
        public event Action<Ball> Stopped;

        private float energy;


        public BallBirdMove(Label map, int startX, int startY, int mouseX, int mouseY) : base(map)
        {
            centerX = mouseX;
            centerY = mouseY;

            float dx = startX - mouseX;
            float dy = startY - mouseY;

            float powerFactor = 0.3f;

            vX = dx * powerFactor;
            vY = dy * powerFactor;
            energy = vY;

            g = 2;

            Brush = Brushes.Red;
        }

        public override void Move()
        {
            if (DownSide() < centerY)
            {
                if (vY < 7)
                {
                    Timer.Stop();
                    Stopped.Invoke(this);
                    return;
                }

                vY = (float)(-vY * 0.5);
                Clear();
                centerY = DownSide();
            }

            vX = vX * 0.98f;
            base.Move();
            vY += g;
        }

        public bool IsMoving()
        {
            return vY < 7;
        }
    }
}
