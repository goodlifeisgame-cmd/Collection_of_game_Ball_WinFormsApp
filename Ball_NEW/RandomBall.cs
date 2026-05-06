namespace BallGamesWinFormsApp.Ball
{
    public class RandomBall : BallMain
    {
        static Random random = new Random();
        public RandomBall(Label map) : base(map)
        {
            x = random.Next(size, map.ClientSize.Width - size);
            y = random.Next(size, map.ClientSize.Height - size);

            vx = random.Next(-15, 15);
            vy = random.Next(-15, 15);
        }
    }
}
