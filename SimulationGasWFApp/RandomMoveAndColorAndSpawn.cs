using BallsCommon;

namespace SimulationGasWFApp
{

    public class RandomMoveAndColorAndSpawn : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public event EventHandler<LocationEventArgs> IsLocation;
        public LocationSide LocationSide;

        public RandomMoveAndColorAndSpawn(Label map, int number) : base(map)
        {
            vX = random.Next(5, 8);
            if (vX % 2 != 0)
            {
                vX = -vX;
            }

            vY = random.Next(5, 8);
            if (vY % 2 != 0)
            {
                vY = -vY;
            }


            if (centerX < map.Width / 2)
            {
                LocationSide = LocationSide.Left;
            }
            else
            {
                LocationSide = LocationSide.Right;
            }

            switch (number % 2)
            {
                case 0:
                    Brush = Brushes.Red;
                    centerX = random.Next((int)LeftSide(), (int)(map.Width / 2 - Radius));
                    break;
                default:
                    Brush = Brushes.Aqua;
                    centerX = random.Next((int)(map.Width / 2 + Radius), (int)RightSide());
                    break;
            }
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
            CheckingSide();
        }

        private void CheckingSide()
        {
            if (centerX < map.Width / 2)
            {
                if (LocationSide != LocationSide.Left)
                {
                    LocationSide = LocationSide.Left;
                    IsLocation.Invoke(this, new LocationEventArgs(LocationSide.Left));
                }
            }
            else
            {
                if (LocationSide != LocationSide.Right)
                {
                    LocationSide = LocationSide.Right;
                    IsLocation.Invoke(this, new LocationEventArgs(LocationSide.Right));
                }
            }
        }
    }
}
