namespace WinFormsAppTextAnzeigen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            lblReveal.Text = txtEingabe.Text;
        }
    }
}
