
using BallsCommon;

namespace BallWindowPopWinFormApp
{
    public partial class BallWindowForm : Form
    {
        public List<MoveBall> MoveBals;

        public BallWindowForm()
        {
            InitializeComponent();
            MoveBals = new List<MoveBall>();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StopButton.Enabled = true;
            StartButton.Enabled = false;

            foreach (var moveBall in MoveBals)
            {
                moveBall.Clear();
                moveBall.Timer.Stop();
            }
            MoveBals = new List<MoveBall>();

            for (int i = 0; i < 2; i++)
            {
                var moveBall = new MoveBall(Maplabel);
                MoveBals.Add(moveBall);
                MoveBals[i].Timer.Start();
            }

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            CountBalllabel.Text = "0";
            foreach (var moveBall in MoveBals)
            {
                moveBall.Timer.Stop();
                if (moveBall.WindowSave())
                {
                    int countball = int.Parse(CountBalllabel.Text);
                    countball++;
                    CountBalllabel.Text = countball.ToString();
                }
            }
            StopButton.Enabled = false;
            StartButton.Enabled = true;

        }
    }
}
