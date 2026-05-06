using Timer = System.Windows.Forms.Timer;

namespace BallsCommon
{
    public class MoveBall : Ball
    {
        public Timer Timer;

        protected float vX = 5;
        protected float vY = 8;
        protected float g = 0.3f;

        public MoveBall(Label map) : base(map)
        {
            Timer = new Timer();
            Timer.Interval = 30;
            Timer.Tick += Timer_Tick;

            vX = random.Next(-5, 5);
            vY = random.Next(-3, 5);
        }

        public virtual void Move()
        {
            Clear();
            Go();
            Show();
        }

        protected virtual void Go()
        {
            centerX += vX;
            centerY += vY;
        }

        protected virtual void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }


    }
}
