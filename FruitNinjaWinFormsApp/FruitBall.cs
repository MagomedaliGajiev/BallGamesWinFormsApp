using Balls.Common;

namespace FruitNinjaWinFormsApp
{
    public class FruitBall : RandomMoveBall
    {
        private float g = 0.2f;
        public FruitBall(Form form) : base(form)
        {
            brush = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            radius = 15;
            centerY = _form.ClientSize.Height + radius;
            vy = (float)random.NextDouble() * -6 - 7;
        }

        protected override void Go()
        {
            base.Go();

            vy += g;

            if (centerY > DownSide() + 2 * radius)
            {
                Stop();
            }
        }
    }
}
