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
            var ball = new RandomPointBall(this);
        }
    }
}
