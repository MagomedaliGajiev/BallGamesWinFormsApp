using System.Windows.Forms;

namespace BallGamesWinFormsApp
{
    public class Ball
    {
        private MainForm _form;
        protected int x = 150;
        protected int y = 150;
        public Ball(MainForm form)
        {
            _form = form;
        }

        public void Show()
        {
            var graphics = _form.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(x, y, 70, 70);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
