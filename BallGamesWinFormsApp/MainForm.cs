namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        private RandomSizeAndPointBall randomSizeAndPointBall;
        private PointBall pointBall;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ballMoveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                randomSizeAndPointBall.Move();
            }
        }

        private void randomBallPointButton_Click(object sender, EventArgs e)
        {
            randomSizeAndPointBall = new RandomSizeAndPointBall(this);
            randomSizeAndPointBall.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void pointBallMoveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                pointBall.Move();
            }
        }
    }
}
