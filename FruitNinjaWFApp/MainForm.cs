namespace FruitNinjaWFApp
{
    public partial class FruitNinjaForm : Form
    {
        public Random Random;

        private List<BallFruit> ballFruits;
        private List<BladeMouse> mouseMoves;
        private int core = 0;
        private int secondTime = 0;


        public FruitNinjaForm()
        {
            InitializeComponent();

            ballFruits = new List<BallFruit>();
            mouseMoves = new List<BladeMouse>();
            Random = new Random();

            SpawnBall();
            TimerSpawnFruit.Start();

            Secondtimer.Start();
        }

        public void SpawnBall()
        {
            var rnd = Random.Next(1, 101);
            BallType ballType;
            switch (rnd)
            {
                case < 10: ballType = BallType.Bomb; break;
                case < 20: ballType = BallType.Banana; break;
                default: ballType = BallType.Fruit; break;
            }

            var fruit = new BallFruit(MapLabel, ballType);
            fruit.Timer.Start();
            ballFruits.Add(fruit);
        }

        private void TimerSpawnFruit_Tick(object sender, EventArgs e)
        {
            SpawnBall();

            for (int i = 0; i < ballFruits.Count; i++)
            {
                var downside = ballFruits[i].DownSide();
                var positionFruit = ballFruits[i].GetPositionY();

                if (downside + 50 < positionFruit)
                {
                    ballFruits.RemoveAt(i);
                }
            }

            LifeBallLabel.Text = ballFruits.Count.ToString();
        }

        private void MapLabel_MouseMove(object sender, MouseEventArgs e)
        {
            var mouse = new BladeMouse(MapLabel, e.X, e.Y);
            mouseMoves.Add(mouse);
            mouse.Show();

            for (int i = 0; i < ballFruits.Count; i++)
            {
                if (ballFruits[i].TryHit(e.X, e.Y))
                {
                    if (ballFruits[i].BallType == BallType.Bomb)
                    {
                        foreach (var fruit in ballFruits)
                        {
                            fruit.Timer.Stop();
                            fruit.Clear();
                        }
                        TimerSpawnFruit.Stop();
                        MessageBox.Show("Ты проиграл");
                        return;
                    }
                    if (ballFruits[i].BallType == BallType.Banana)
                    {
                        secondTime = 50;
                        SlowMoTimelabel.Text = (secondTime / 10).ToString();
                        Secondtimer.Start();
                    }

                    if (ballFruits[i].GetRadius() > 10)
                    {
                        var ballL = new MoveToSideBall(MapLabel, e.X, e.Y, -5, (int)ballFruits[i].GetRadius());
                        var ballR = new MoveToSideBall(MapLabel, e.X, e.Y, 5, (int)ballFruits[i].GetRadius());
                        ballR.Timer.Start();
                        ballL.Timer.Start();
                        ballFruits.Add(ballL);
                        ballFruits.Add(ballR);
                    }

                    core += (40 / (int)ballFruits[i].GetRadius()) * 2;
                    CountCoreLabel.Text = core.ToString();

                    ballFruits[i].Clear();
                    ballFruits[i].Timer.Stop();
                    ballFruits.RemoveAt(i);
                    break;
                }
            }
        }

        private void CursorSizeTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < mouseMoves.Count; i++)
            {
                mouseMoves[i].Clear();

                if (!mouseMoves[i].ReduceSize())
                {
                    mouseMoves.RemoveAt(i);
                    continue;
                }

                mouseMoves[i].Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var fruit in ballFruits)
            {
                fruit.Timer.Stop();
                fruit.Clear();
            }

            TimerSpawnFruit.Start();
            ballFruits = new List<BallFruit>();
            core = 0;
            CountCoreLabel.Text = core.ToString();
        }

        private void Secondtimer_Tick(object sender, EventArgs e)
        {
            if (secondTime > 0)
            {
                secondTime--;
                SlowMoTimelabel.Text = (secondTime / 10).ToString();
                foreach (var fruit in ballFruits)
                {
                    fruit.IsSlowMo = true;
                }
            }
            else
            {
                foreach (var fruit in ballFruits)
                {
                    fruit.IsSlowMo = false;
                }
                Secondtimer.Stop();
            }
        }
    }
}
