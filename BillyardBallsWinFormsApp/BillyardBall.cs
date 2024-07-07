using Balls.Common;

namespace BillyardBallsWinFormsApp
{

    public class BillyardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public BillyardBall(Form form) : base(form)
        {
            radius = 10;
        }

        public BillyardBall(Form form, Brush brush) : base(form, brush)
        {

        }

        public bool LeftOfCenter()
        {
            return centerX + radius < _form.ClientSize.Width / 2;
        }

        public bool RightOfCenter()
        {
            return centerX - radius > _form.ClientSize.Width / 2;
        }

        protected override void Go()
        {
            base.Go();

            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }

            if (centerX >= RightSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (centerY <= TopSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }

            if (centerY >= DownSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
    }
}
