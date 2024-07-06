namespace Balls.Common
{
    public class Ball
    {
        protected static Random random = new Random();
        private Form _form;
        protected int vx = 5;
        protected int vy = 5;
        protected int centerX = 10;
        protected int centerY = 10;
        protected int radius = 25;
        public Ball(Form form)
        {
            _form = form;
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
            return centerX >= 0 && centerY >= 0 && centerX + radius <= _form.ClientSize.Width
                && centerY + radius <= _form.ClientSize.Height;

        }

        public bool Contains(int pointX, int pointY)
        {
            var radius = this.radius / 2;
            var centerX = this.centerX + radius;
            var centerY = this.centerY + radius;

            return Math.Pow(centerX - pointX, 2) + Math.Pow(centerY - pointY, 2) <= Math.Pow(radius, 2);
        }

        public void Clear()
        {
            var brush = new SolidBrush(_form.BackColor);
            Draw(brush)
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
