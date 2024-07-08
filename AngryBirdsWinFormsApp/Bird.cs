using Balls.Common;

namespace AngryBirdsWinFormsApp
{
    public class Bird : MoveBall
    {
        private float g = 0.2f;
        private float elastic = 2;
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
            }

            vy += g;

            
        }
    }
}
