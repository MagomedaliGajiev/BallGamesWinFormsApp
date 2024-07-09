using Timer = System.Windows.Forms.Timer;

namespace AngryBirdsWinFormsApp
{
    public partial class MainForm : Form
    {
        private Bird bird;
        private Pig pig;
        private Timer timer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (bird.Intersect(pig))
            {
                CreateNewBird();
                CreateNewPig();
            }
            if (!bird.IsMoveable())
            {
                CreateNewBird();
            }

            if (bird.IsOutSide())
            {
                CreateNewBird();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            CreateNewBird();
            CreateNewPig();
        }

        private void CreateNewPig()
        {
            if (pig != null)
            {
                pig.Clear();
            }
            pig = new Pig(this);
            pig.Show();
        }

        private void CreateNewBird()
        {
            timer.Stop();
            if (bird != null)
            {
                bird.Stop();
                bird.Clear();
            }
            bird = new Bird(this);
            bird.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            bird.SetVelocity(e.X, e.Y);
            timer.Start();
            bird.Start();
        }
    }
}
