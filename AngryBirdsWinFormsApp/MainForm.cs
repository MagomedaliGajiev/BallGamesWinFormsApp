namespace AngryBirdsWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            var bird = new Bird(this);
            bird.Show();

            var pig = new Pig(this);
            pig.Show();
        }
    }
}
