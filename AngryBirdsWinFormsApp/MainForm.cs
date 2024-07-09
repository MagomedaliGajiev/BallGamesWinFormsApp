namespace AngryBirdsWinFormsApp
{
    public partial class MainForm : Form
    {
        private Bird bird;
        private Pig pig;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            bird = new Bird(this);
            bird.Show();

            pig = new Pig(this);
            pig.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            bird.SetVelocity(e.X, e.Y);
            bird.Start();
        }
    }
}
