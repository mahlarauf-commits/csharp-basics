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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("salam", "Software", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                label1.Text = "The yes button was clicked.";
            }
            if (dialogResult == DialogResult.No)
            {
                label1.Text = "The no button was clicked.";
            }
            if (dialogResult == DialogResult.Cancel)
            {
                label1.Text = "The cancel button was clicked.";
            }
        }
    }
}
