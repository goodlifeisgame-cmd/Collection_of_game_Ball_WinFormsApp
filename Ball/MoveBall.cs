//using Timer = System.Windows.Forms.Timer;

using System.Reflection.Emit;

namespace BallGamesWinFormsApp.Ball
{
    public class MoveBall : RandomBall
    {
        public Timer timer;
        public MoveBall(Label map) : base(map)
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }



        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (Hit)
            {
                MoveEnd();
                return;
            }
            Move();
        }

        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
    }
}
