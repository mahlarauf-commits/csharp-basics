namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Image file;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            { 
                file.Save(openFileDialog2.FileName);
            }
        }
    }
}
