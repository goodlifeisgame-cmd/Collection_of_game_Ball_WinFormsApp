namespace BallGamesWinFormsApp.Ball
{
    public class PointBall : BallMain
    {
        public PointBall(Label map, int x, int y) : base(map)
        {
            this.x = x;
            this.y = y;
        }
    }
}
