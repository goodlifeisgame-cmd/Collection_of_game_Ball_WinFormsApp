using BallsCommon;

namespace PopBallGameWFApp
{
    public class BallPop : MoveBall
    {
        public BallPop(Label map) : base(map)
        {

        }

        override public void Move()
        {
            if (centerX < LeftSide() || centerX > RightSide())
            {
                vX = -vX;
            }

            if (centerY < TopSide() || centerY > DownSide())
            {
                vY = -vY;
            }
            base.Move();
        }



        override protected void Timer_Tick(object? sender, EventArgs e)
        {
            if (IsHit)
            {
                MoveEnd();
                return;
            }
            Move();
        }

        protected void MoveEnd()
        {
            if (centerY < DownSide())
            {
                Clear();
                vX = 0;
                vY = 2;
                Go();
            }
            Show();
        }
    }
}
