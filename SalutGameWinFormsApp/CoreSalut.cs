using BallsCommon;

namespace SalutGameWinFormsApp
{
    public class CoreSalut : MoveBall
    {
        private float g = 0.3f;
        public event EventHandler<BloownUpEventArgs> BlownUp;
        public CoreSalut(Label map) : base(map)
        {
            vY = random.Next(-14, -8);
            vX = 0;

            centerX = random.Next((int)(LeftSide() + 30), (int)RightSide() - 30);
            centerY = DownSide() + Radius;

            Radius = 5;
        }

        public override void Move()
        {
            base.Move();
            if (vY >= 0)
            {
                BlownUp.Invoke(this, new BloownUpEventArgs(centerX, centerY));
                Timer.Stop();
                Clear();
            }
            vY += g;
        }
    }
}
