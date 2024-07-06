namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<RandomMoveBall> movetBalls;
        private PointBall ball;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ball = new PointBall(this, e.X, e.Y);
            ball.Show();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = true;
            startButton.Enabled = false;

            movetBalls = new List<RandomMoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new RandomMoveBall(this);
                movetBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            var countBalls = 0;
            for (int i = 0; i < 10; i++)
            {
                movetBalls[i].Stop();
                if (movetBalls[i].OnForm())
                {
                    countBalls++;
                }
            }
            MessageBox.Show(countBalls.ToString());
            stopButton.Enabled = false;
            clearButton.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                movetBalls[i].Move();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in movetBalls)
            {
                ball.Clear();
            }
            clearButton.Enabled = false;
            startButton.Enabled = true; 
        }
    }
}
