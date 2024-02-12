namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        int user = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = Convert.ToInt32(textBox1.Text);
            user = user * 400;
            textBox2.Text = user.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = new Bitmap(@"C:\Users\annas\Downloads\11e65a55bdcfde43f8cb75690e59b9b4.jpg");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}