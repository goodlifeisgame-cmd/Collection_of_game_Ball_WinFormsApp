namespace BallsCommon
{
    public class SalutBall : MoveBall
    {
        public SalutBall(Label map, float centerX, float centerY, Brush brush) : base(map)
        {
            this.centerX = centerX;
            this.centerY = centerY;

            vY = random.Next(-8, -3);
            Radius = random.Next(3, 6);
            Brush = brush;
        }

        public override void Move()
        {
            base.Move();
            vY += g;
        }
    }
}
