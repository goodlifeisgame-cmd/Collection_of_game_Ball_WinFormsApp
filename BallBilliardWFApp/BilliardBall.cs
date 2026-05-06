using BallsCommon;
namespace BallBilliardWFApp
{

    public class BilliardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;

        public BilliardBall(Label map) : base(map)
        {
            vX = random.Next(-15, 15);
            vY = random.Next(-15, 15);
        }
        override public void Move()
        {
            if (centerX <= LeftSide())
            {
                vX = -vX;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                vX = -vX;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (centerY <= TopSide())
            {
                vY = -vY;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                vY = -vY;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
            base.Move();
        }
    }
}
