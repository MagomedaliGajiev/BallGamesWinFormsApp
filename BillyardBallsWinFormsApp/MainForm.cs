using Timer = System.Windows.Forms.Timer;

namespace BillyardBallsWinFormsApp
{
    public partial class MainForm : Form
    {
        private Timer timer = new Timer();
        private List<BillyardBall> balls = new List<BillyardBall>();
        int ballsCount = 20;
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            ShowVerticalCenterLine();

            int leftOfCenterBlueCount = 0;
            int rightOfCenterBlueCount = 0;

            var leftOfCenterRedCount = 0;
            var rightOfCenterRedCount = 0;
            foreach (var ball in balls)
            {
                if (ball.LeftOfCenter())
                {
                    if (ball.GetBrush() == Brushes.Red)
                    {
                        leftOfCenterRedCount++;
                    }
                    else
                    {
                        leftOfCenterBlueCount++;
                    }
                }
                if (ball.RightOfCenter())
                {
                    if (ball.GetBrush() == Brushes.Red)
                    {
                        rightOfCenterRedCount++;
                    }
                    else
                    {
                        rightOfCenterBlueCount++;
                    }
                }
            }

            if (leftOfCenterRedCount == leftOfCenterBlueCount && rightOfCenterRedCount == rightOfCenterBlueCount && leftOfCenterBlueCount == rightOfCenterRedCount
                && leftOfCenterRedCount + leftOfCenterBlueCount + rightOfCenterRedCount + rightOfCenterBlueCount == ballsCount)
            {
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ballsCount / 2; i++)
            {
                var ball = new BillyardBall(this, Brushes.Blue);
                ball.OnHited += Ball_OnHited_1;
                ball.Start();
                balls.Add(ball);

                ball = new BillyardBall(this, Brushes.Red);
                ball.OnHited += Ball_OnHited_2;
                ball.Start();
                balls.Add(ball);
            }
        }

        private void ShowVerticalCenterLine()
        {
            var graphics = CreateGraphics();
            graphics.DrawLine(Pens.Black, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
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
