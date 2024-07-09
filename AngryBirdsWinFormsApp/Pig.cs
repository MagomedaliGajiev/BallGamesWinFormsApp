using Balls.Common;

namespace AngryBirdsWinFormsApp
{
    public class Pig : MoveBall
    {
        public Pig(Form form) : base(form)
        {
            brush = Brushes.Pink;
            radius = 30;
        }
    }
}
