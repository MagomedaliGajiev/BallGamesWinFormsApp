namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ballPaintButton_Click(object sender, EventArgs e)
        {
            var ball = new Ball(this);
        }

        private void randomBallPaintButton_Click(object sender, EventArgs e)
        {
            var randomPointBall = new RandomPointBall(this);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var pointBall = new PointBall(this, e.X, e.Y);
        }
    }
}
