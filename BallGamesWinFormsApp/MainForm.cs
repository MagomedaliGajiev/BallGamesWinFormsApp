namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ballPaintButton_Click(object sender, EventArgs e)
        {
            var graphics = CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(150, 150, 100, 100);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
