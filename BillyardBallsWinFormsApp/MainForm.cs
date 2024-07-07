using Balls.Common;

namespace BillyardBallsWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var ball = new BillyardBall(this, Brushes.Blue);
                ball.OnHited += Ball_OnHited_1;
                ball.Start();

                ball = new BillyardBall(this, Brushes.Red);
                ball.OnHited += Ball_OnHited_2;
                ball.Start();
            }
        }

        private void Ball_OnHited_2(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabel_2.Text = (Convert.ToInt32(leftLabel_2.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel_2.Text = (Convert.ToInt32(rightLabel_2.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel_2.Text = (Convert.ToInt32(topLabel_2.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabel_2.Text = (Convert.ToInt32(downLabel_2.Text) + 1).ToString();
                    break;
            }
        }

        private void Ball_OnHited_1(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabel_1.Text = (Convert.ToInt32(leftLabel_1.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel_1.Text = (Convert.ToInt32(rightLabel_1.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel_1.Text = (Convert.ToInt32(topLabel_1.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabel_1.Text = (Convert.ToInt32(downLabel_1.Text) + 1).ToString();
                    break;
            }
        }
    }   
}
