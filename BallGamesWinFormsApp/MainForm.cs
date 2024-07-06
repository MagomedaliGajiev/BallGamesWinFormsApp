namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveBall> movetBalls;
        private PointBall pointBall;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ballMoveButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void ballMoveStopButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                movetBalls[i].Stop();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                movetBalls[i].Move();
            }
        }

        private void manyBallsButton_Click(object sender, EventArgs e)
        {
            movetBalls = new List<MoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                movetBalls.Add(moveBall);
                moveBall.Start();
            }
        }
    }
}
