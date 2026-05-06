namespace FruitNinjaWFApp
{
    public class MoveToSideBall : BallFruit
    {
        //время защиты(что бы игрок не смог сразу же сбить шар после сбития предыдущего шара)
        //не придумал как подругому
        private int timeDefence = 5;
        public MoveToSideBall(Label map, int x, int y, float vX, int radius) : base(map)
        {
            centerX = x;
            centerY = y - radius;
            this.vX = vX;
            vY = -7;
            this.Radius = radius / 1.5f;
            g = 0.5f;
            IsHit = true;
        }

        public override void Move()
        {
            timeDefence--;
            if (timeDefence == 0)
            {
                IsHit = false;
            }

            base.Move();
            vY += g;
        }
    }
}
