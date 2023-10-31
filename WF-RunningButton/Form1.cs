namespace WF_RunningButton
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Location = new Point(rand.Next(0, this.Width - 150), rand.Next(0, this.Height - 100));
        }
    }
}