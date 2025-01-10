namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int zahl = random.Next(1, 101);
            lblZahl.Text = "Zufallszahl: " + zahl;
        }
    }
}
