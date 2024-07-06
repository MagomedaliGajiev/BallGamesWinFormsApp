using Timer = System.Windows.Forms.Timer;
namespace Balls.Common
{
    public class Ball
    {
        private Form _form;
        private Timer timer;

        protected static Random random = new Random();
        protected int vx = 5;
        protected int vy = 5;
        protected int centerX = 10;
        protected int centerY = 10;
        protected int radius = 25;
        public Ball(Form form)
        {
            _form = form;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }


        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        public bool IsMoveable()
        {
            return timer.Enabled;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Show()
        {
            var brush = Brushes.Aqua;
            Draw(brush);
           
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return _form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return _form.ClientSize.Height - radius;
        }

        public bool OnForm()
        {
            return centerX >= LeftSide() && centerY >= TopSide() && centerX <= RightSide() && centerY <= DownSide();
        }

        public bool Contains(int pointX, int pointY)
        {
            var dx = pointX - centerX;
            var dy = pointY - centerY;

            return Math.Pow(dx, 2) + Math.Pow(dy, 2) <= Math.Pow(radius, 2);
        }

        public void Clear()
        {
            var brush = new SolidBrush(_form.BackColor);
            Draw(brush);
        }

        private void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        private void Draw(Brush brush)
        {
            var graphics = _form.CreateGraphics();
            var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
