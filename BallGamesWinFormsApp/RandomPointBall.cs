namespace BallGamesWinFormsApp
{
    public class RandomPointBall
    {
        private static Random random = new Random();
        public RandomPointBall(MainForm form)
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            var x = random.Next(0, form.ClientSize.Width);
            var y = random.Next(0, form.ClientSize.Height);
            var rectangle = new Rectangle(x, y, 100, 100);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
