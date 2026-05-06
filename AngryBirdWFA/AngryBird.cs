using BallsCommon;

namespace AngryBirdWFA
{
    public partial class MainForm : Form
    {
        private Random rnd;

        private BallBird ballStartPosition;
        private BallBirdMove birdMove;
        private BallBird ballpoint; //вот сейчас подумал наверно это лишнее можно обыграть через ballStartPosition
        private Pig pig;

        private bool isMoveMouse = false;
        private bool isClickMouse = false;
        private bool isMovingBall = false;

        private float centerStartPointX;
        private float centerStartPointY;

        private List<BallBird> ballsTrajectory;
        private int numberBallsTrajectory = 10;
        private float timeStep = 1f;
        private const float gravity = 2f;

        private int score = 0;

        private List<SalutBall> SalutBalls;


        public MainForm()
        {
            InitializeComponent();
            ballpoint = new BallBird(MapLabel);
            ballStartPosition = new BallBird(MapLabel);
            rnd = new Random();

            centerStartPointX = (StartPointLabel.Location.X + StartPointLabel.Width / 2) - MapLabel.Location.X;
            centerStartPointY = (StartPointLabel.Location.Y + StartPointLabel.Height / 2) - MapLabel.Location.Y;

            ballsTrajectory = new List<BallBird>();
            for (int i = 0; i < numberBallsTrajectory; i++)
            {
                var ball = new BallBird(MapLabel);
                ball.Brush = Brushes.Azure;
                ballsTrajectory.Add(ball);
            }

            ScoreLabel.Text = score.ToString();
            SalutBalls = new List<SalutBall>();
        }

        private void BirdMove_Stopped(BallsCommon.Ball obj)
        {
            MoveBall ball = (MoveBall)obj;
            ball.Clear();
            isMovingBall = false;
            SpawnTimerBall.Enabled = true;
            SpawnPigTimer.Start();

            Undermine(ball.GetPositionX(), ball.GetPositionY());
        }

        private void MapLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (ballStartPosition.TryHit(e.X, e.Y) && !isMovingBall)
            {
                isClickMouse = true;
                ballStartPosition.Clear();
            }
        }

        private void MapLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMoveMouse)
            {
                ballpoint.Clear();

                float dx = e.X - centerStartPointX;
                float dy = e.Y - centerStartPointY;

                birdMove = new BallBirdMove(MapLabel, (int)centerStartPointX, (int)centerStartPointY, e.X, e.Y);
                birdMove.Timer.Start();
                CollisionCheckTimer.Start();
                birdMove.Stopped += BirdMove_Stopped;

                isMoveMouse = false;
                isClickMouse = false;

                isMovingBall = true;
            }
        }

        private void MapLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClickMouse)
            {
                ballpoint.MovePoint(e.X, e.Y);
                isMoveMouse = true;

                DrawTraectory(e);
            }
        }

        //я к сожалению не математик, поэтому попросил математическую формулу для расчета траектории
        //просто хотел сделать красиво)
        private void DrawTraectory(MouseEventArgs e)
        {
            float powerFactor = 0.32f;

            float dx = centerStartPointX - e.X;
            float dy = centerStartPointY - e.Y;

            float vx = (dx * powerFactor);
            float vy = dy * powerFactor;

            for (int i = 0; i < ballsTrajectory.Count; i++)
            {
                float t = i + 1 * timeStep;

                float x = e.X + vx * t;
                float y = e.Y + vy * t + gravity * t * t / 2;

                float radius = 5 - (5 - 1) * (float)i / (ballsTrajectory.Count - 1);

                ballsTrajectory[i].Radius = radius;
                ballsTrajectory[i].MovePoint((int)x, (int)y);
            }
        }


        private void SpawnTimerBall_Tick(object sender, EventArgs e)
        {
            ballStartPosition.MovePoint(centerStartPointX - 5, centerStartPointY + 3);
            ballStartPosition.IsHit = false;
            SpawnTimerBall.Enabled = false;
        }

        private void SpawnPigTimer_Tick(object sender, EventArgs e)
        {
            if (pig == null)
            {
                var leftSide = MapLabel.Width / 3;
                var rightSide = MapLabel.Width - (MapLabel.Width / 5);
                var topSide = 0 + MapLabel.Height / 10;
                var downSide = MapLabel.Height - (MapLabel.Height / 5);

                var x = rnd.Next(leftSide, rightSide);
                var y = rnd.Next(topSide, downSide);
                //тестирование на попадание что бы было поближе целиться :)
                //var x = 350;
                //var y = 500;

                SpawnPigTimer.Stop();
                pig = new Pig(MapLabel, x, y);
                pig.Show();
            }
        }

        private void CheckState(object sender, EventArgs e)
        {
            CheckCollision();
            InView();
        }

        private void CheckCollision()
        {
            var birdCenterX = birdMove.GetPositionX();
            var birdCenterY = birdMove.GetPositionY();

            if (pig.IsTouching(birdMove))
            {
                CollisionCheckTimer.Stop();
                pig = null;

                score++;
                ScoreLabel.Text = score.ToString();

                ResetSpawnBird();
                Undermine(birdCenterX, birdCenterY);
            }
        }

        private void InView()
        {
            var bR = birdMove.RightSide();
            var mR = MapLabel.Width;

            var birdPositionX = birdMove.GetPositionX();
            if (birdPositionX > MapLabel.Width)
            {
                CollisionCheckTimer.Stop();
                ResetSpawnBird();
            }
        }

        private void ResetSpawnBird()
        {
            birdMove.Timer.Stop();
            birdMove.Clear();

            isMovingBall = false;
            SpawnTimerBall.Enabled = true;
            SpawnPigTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            ScoreLabel.Text = score.ToString();
        }

        private void Undermine(float x, float y)
        {
            var countBall = rnd.Next(10, 25);
            Brush brush = Brushes.White;
            for (int i = 0; i < countBall; i++)
            {
                var salutball = new SalutBall(MapLabel, x, y, brush);
                salutball.Timer.Start();
                SalutBalls.Add(salutball);
            }
        }
    }
}
