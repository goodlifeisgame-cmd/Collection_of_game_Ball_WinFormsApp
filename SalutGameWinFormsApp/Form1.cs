using BallsCommon;

namespace SalutGameWinFormsApp
{
    public partial class SalutMainForm : Form
    {
        public List<SalutBall> SalutBalls;
        private Random random = new Random();
        public SalutMainForm()
        {
            InitializeComponent();
            SalutBalls = new List<SalutBall>();
        }


        private void MapLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Undermine(e.X, e.Y);
        }

        private void RunSalutButton_Click(object sender, EventArgs e)
        {
            var coreSalut = new CoreSalut(MapLabel);
            coreSalut.BlownUp += CoreSalut_BlownUp;
            coreSalut.Timer.Start();
        }

        private void CoreSalut_BlownUp(object? sender, BloownUpEventArgs e)
        {
            Undermine(e.X, e.Y);
        }

        public void Undermine(float x, float y)
        {
            var countBall = random.Next(10, 25);
            Brush brush = GetRandomColorBrush();
            for (int i = 0; i < countBall; i++)
            {
                var salutball = new SalutBall(MapLabel, x, y, brush);
                salutball.Timer.Start();
                SalutBalls.Add(salutball);
            }
        }

        public Brush GetRandomColorBrush()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 6);
            switch (number)
            {
                case 1: return Brushes.Red;
                case 2: return Brushes.Azure;
                case 3: return Brushes.Blue;
                case 4: return Brushes.Purple;
                default: return Brushes.Yellow;
            }
        }
    }
}
