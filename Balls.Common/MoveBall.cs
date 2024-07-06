


namespace Balls.Common
{
    public class MoveBall : RandomPointBall
    {
        public MoveBall(Form form) : base(form)
        {
            vx = GenerateRandomProjection();
            vy = GenerateRandomProjection();
        }

        private int GenerateRandomProjection()
        {
            var rondomDouble = random.NextDouble();
            var sign = 1;
            if (rondomDouble < 0.5)
            {
                sign = -1;
            }
            return random.Next(2, 5) * sign;
        }
    }
}
