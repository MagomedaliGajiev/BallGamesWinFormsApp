namespace BallGamesWinFormsApp
{
    public class RandomMoveBall : MoveBall
    {
        public RandomMoveBall(MainForm form) : base(form)
        {
            vx = random.Next(-5, 6);
            vy = random.Next(-5, 5);
        }
    }
}
