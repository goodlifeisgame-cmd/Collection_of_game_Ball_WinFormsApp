using BallsCommon;

namespace SimulationGasWFApp
{

    public partial class SimulationGasForm : Form
    {
        public List<MoveBall> Balls;

        int countGas = 8;
        public SimulationGasForm()
        {
            InitializeComponent();
            Balls = new List<MoveBall>();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            for (int i = 0; i < countGas; i++)
            {
                var ball = new RandomMoveAndColorAndSpawn(MapLabel, i);
                ball.Timer.Start();
                ball.OnHited += Ball_OnHited;
                ball.IsLocation += Ball_IsLocation;
                Balls.Add(ball);
            }
        }

        private void Ball_IsLocation(object? sender, LocationEventArgs e)
        {
            MoveBall ball = (MoveBall)sender;

            if (e.LocationSide == LocationSide.Left)
            {
                if (ball.Brush == Brushes.Aqua)
                {
                    LeftBlueLocationlabel.Text = AddCount(LeftBlueLocationlabel.Text);
                    RightBlueLocationlabel.Text = SubtractCount(RightBlueLocationlabel.Text);
                }
                else
                {
                    LeftRedLocationlabel.Text = AddCount(LeftRedLocationlabel.Text);
                    RightRedLocationlabel.Text = SubtractCount(RightRedLocationlabel.Text);
                }
            }
            else
            {
                if (ball.Brush == Brushes.Aqua)
                {
                    RightBlueLocationlabel.Text = AddCount(RightBlueLocationlabel.Text);
                    LeftBlueLocationlabel.Text = SubtractCount(LeftBlueLocationlabel.Text);
                }
                else
                {
                    RightRedLocationlabel.Text = AddCount(RightRedLocationlabel.Text);
                    LeftRedLocationlabel.Text = SubtractCount(LeftRedLocationlabel.Text);
                }
            }

            if (int.Parse(LeftBlueLocationlabel.Text) == countGas / 4 && int.Parse(RightBlueLocationlabel.Text) == countGas / 4)
            {
                if (int.Parse(LeftRedLocationlabel.Text) == countGas / 4 && int.Parse(RightRedLocationlabel.Text) == countGas / 4)
                {
                    StopButton.PerformClick();
                }
            }
        }

        private string AddCount(string tex)
        {
            int Count = int.Parse(tex);
            Count++;
            return Count.ToString();
        }
        private string SubtractCount(string tex)
        {
            int Count = int.Parse(tex);
            if (Count > 0)
            {
                Count--;
            }
            return Count.ToString();
        }


        private void Ball_OnHited(object? sender, HitEventArgs e)
        {
            Ball ball = (Ball)sender;

            if (e.Side == Side.Left)
            {
                if (ball.Brush == Brushes.Aqua)
                {
                    leftBlueLabel.Text = AddCount(leftBlueLabel.Text);
                }
                else
                {
                    leftRedLabel.Text = AddCount(leftRedLabel.Text);
                }
            }
            else if (e.Side == Side.Right)
            {
                if (ball.Brush == Brushes.Aqua)
                {
                    rightBlueLabel.Text = AddCount(rightBlueLabel.Text);
                }
                else
                {
                    rightRedLabel.Text = AddCount(rightRedLabel.Text);
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            foreach (var ball in Balls)
            {
                ball.Show();
                ball.Timer.Stop();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Balls.Count; i++)
            {
                Balls[i].Timer.Stop();
                Balls[i].Clear();
            }
            Balls.Clear();

            LeftBlueLocationlabel.Text = "0";
            LeftRedLocationlabel.Text = "0";
            RightBlueLocationlabel.Text = "0";
            RightRedLocationlabel.Text = "0";

            leftBlueLabel.Text = "0";
            leftRedLabel.Text = "0";
            rightBlueLabel.Text = "0";
            rightRedLabel.Text = "0";
            StartButton.Enabled = true;
        }
    }
}
