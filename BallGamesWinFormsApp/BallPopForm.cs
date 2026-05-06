using PopBallGameWFApp;

namespace BallGamesWinFormsApp
{
    public partial class BallPopForm : Form
    {
        public List<BallPop> MoveBals = new List<BallPop>();
        public int hit = 0;

        public BallPopForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                var moveBall = new BallPop(MapLabel);
                MoveBals.Add(moveBall);
                moveBall.Timer.Start();
            }
        }

        private void startStopbutton_Click(object sender, EventArgs e)
        {
            foreach (var moveBall in MoveBals)
            {
                moveBall.Timer.Enabled = !moveBall.Timer.Enabled;
            }
        }

        private void MapLabel_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var moveBall in MoveBals)
            {
                if (moveBall.TryHit(e.X, e.Y))
                {
                    hit++;
                    Hitlabel.Text = hit.ToString();
                    break;
                }
            }

        }
    }
}
