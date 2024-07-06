namespace Balls.Common
{
    public class RandomPointBall : Ball
    {

        public RandomPointBall(Form form) : base(form)
        {
            centerX = random.Next(0, form.ClientSize.Width);
            centerY = random.Next(0, form.ClientSize.Height);
        }
    }
}
