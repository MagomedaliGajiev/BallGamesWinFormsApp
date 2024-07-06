using System.Windows.Forms;

namespace BallGamesWinFormsApp
{
    public class Ball
    {
        protected static Random random = new Random();
        private MainForm _form;
        protected int vx = 5;
        protected int vy = 5;
        protected int x = 150;
        protected int y = 150;
        protected int size = 50;
        public Ball(MainForm form)
        {
            _form = form;
        }

        public void Show()
        {
            var graphics = _form.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public bool OnForm()
        {
            return x >= 0 && y >= 0 && x + size <= _form.ClientSize.Width
                && y + size <= _form.ClientSize.Height;
            
        }

        public void Clear()
        {
            var graphics = _form.CreateGraphics();
            var brush = new SolidBrush(_form.BackColor);
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        private void Go()
        {
            x += vx;
            y += vy;
        }
    }
}
