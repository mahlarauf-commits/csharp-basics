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
            string name;
            string lastname;
            name = textBox1.Text;
            lastname = textBox2.Text;
            string message ="";
            message += "your name:" + name + lastname + Environment.NewLine;
            string SelectedItem = comboBox1.SelectedItem.ToString();
            message += "your city:" + SelectedItem + Environment.NewLine;
            string bime = checkBox1.Checked.ToString();
            message += "Insurance status:" + bime + Environment.NewLine;
            MessageBox.Show(message);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
