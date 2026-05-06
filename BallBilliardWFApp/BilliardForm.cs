using BallsCommon;

namespace BallBilliardWFApp
{
    public partial class BilliardForm : Form
    {
        public List<MoveBall> MoveBalls;
        public BilliardForm()
        {
            InitializeComponent();
            MoveBalls = new List<MoveBall>();
        }

        private void SpawnButton_Click(object sender, EventArgs e)
        {
            var moveBall = new BilliardBall(MapLabel);
            moveBall.OnHited += MoveBall_OnHited;
            moveBall.Timer.Start();
            MoveBalls.Add(moveBall);
        }

        private void MoveBall_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    int lL = int.Parse(leftLabel.Text);
                    leftLabel.Text = (++lL).ToString(); break;
                case Side.Right:
                    int rL = int.Parse(rightLabel.Text);
                    rightLabel.Text = (++rL).ToString(); break;
                case Side.Top:
                    int tL = int.Parse(topLabel.Text);
                    topLabel.Text = (++tL).ToString(); break;
                case Side.Down:
                    int dL = int.Parse(downLabel.Text);
                    downLabel.Text = (++dL).ToString(); break;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MoveBalls.Count; i++)
            {
                MoveBalls[i].Timer.Stop();
                MoveBalls[i].Clear();
            }
            MoveBalls.Clear();
        }

        private void ResecScpreButton_Click(object sender, EventArgs e)
        {
            leftLabel.Text = "0";
            rightLabel.Text = "0";
            topLabel.Text = "0";
            downLabel.Text = "0";
        }
    }
}
