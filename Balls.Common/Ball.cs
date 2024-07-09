using Timer = System.Windows.Forms.Timer;
namespace Balls.Common
{
    public class Ball
    {
        protected Form _form;
        protected Timer timer;

        protected static Random random = new Random();
        protected float vx = 5;
        protected float vy = 5;
        protected float centerX = 10;
        protected float centerY = 10;
        protected int radius = 25;
        protected Brush brush = Brushes.Aqua;
        public Ball(Form form)
        {
            _form = form;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        public Ball(Form form, Brush brush)
        {
            _form = form;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            this.brush = brush;
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

        public Brush GetBrush()
        {
            return brush;
        }

        public void Show()
        {
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

        public bool Intersect(Ball other)
        {
            var dx = centerX - other.centerX;
            var dy = centerY - other.centerY;
            return dx * dx + dy * dy <= Math.Pow(radius + other.radius, 2);
        }

        public void Clear()
        {
            var brush = new SolidBrush(_form.BackColor);
            Draw(brush);
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        private void Draw(Brush brush)
        {
            var graphics = _form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
