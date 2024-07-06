namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<RandomMoveBall> moveBalls;
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

            moveBalls = new List<RandomMoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new RandomMoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            var countBalls = 0;
            for (int i = 0; i < 10; i++)
            {
                moveBalls[i].Stop();
                if (moveBalls[i].OnForm())
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
                moveBalls[i].Move();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                ball.Clear();
            }
            clearButton.Enabled = false;
            startButton.Enabled = true; 
        }
    }
}
