using Balls.Common;

namespace AngryBirdsWinFormsApp
{
    public class Bird : MoveBall
    {
        private float g = 0.2f;
        private float elastic = 0.4f;
        public Bird(Form form) : base(form)
        {
            centerX = LeftSide();
            centerY = DownSide();
            brush = Brushes.Green;
        }

        protected override void Go()
        {
            base.Go();
            if (centerY > DownSide())
            {
                vy = -vy;

                centerY = DownSide();

                vy *= elastic;
                vx *= elastic;
            }

            if (vy < 0.1 && vx < 0.1)
            {
                Stop();
            }

            vy += g;
        }

        public void SetVelocity(int x , int y)
        {
            vx = (x - centerX) / 20;
            vy = (y - centerY) / 20;
        }
    }
}
