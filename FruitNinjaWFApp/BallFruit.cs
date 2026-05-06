using BallsCommon;

namespace FruitNinjaWFApp
{
    public class BallFruit : MoveBall
    {
        public BallType BallType;
        public bool IsSlowMo = false;


        public BallFruit(Label map, BallType iam = BallType.Fruit) : base(map)
        {
            BallType = iam;
            switch (BallType)
            {
                case BallType.Banana:
                    Brush = Brushes.Yellow;
                    break;
                case BallType.Bomb:
                    Brush = Brushes.Black;
                    break;
                default:
                    Brush = Brushes.Green;
                    break;
            }

            vY = random.Next(-15, -10);
            vX = random.Next(-4, 4);

            var numberSwitch = random.Next(1, 5);
            switch (numberSwitch)
            {
                case 1: Radius = 10; break;
                case 2: Radius = 20; break;
                case 3: Radius = 30; break;
                case 4: Radius = 40; break;
            }

            centerX = random.Next(map.Width / 4, (int)(RightSide() - (map.Width / 4)));
            centerY = DownSide() + Radius;
        }

        public override void Move()
        {
            base.Move();
            vY += g / SpeedSlowMo();
        }

        protected override void Go()
        {
            centerX += vX / SpeedSlowMo();
            centerY += vY / SpeedSlowMo();
        }

        private int SpeedSlowMo()
        {
            return IsSlowMo ? 6 : 1;
        }
    }
}
