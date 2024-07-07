﻿namespace Balls.Common
{
    public class RandomPointBall : Ball
    {

        public RandomPointBall(Form form) : base(form)
        {
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
        }

        public RandomPointBall(Form form, Brush brush) : base(form, brush)
        {
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
        }
    }
}
