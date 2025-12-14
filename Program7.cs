{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string lastname;
            name = txtname.Text;
            lastname = txtlastname.Text;
            label3.Text = name + "   " + lastname;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             int n1 , n2 ;  
            n1 = int.Parse(textBox1.Text);
            n2= int.Parse(textBox2.Text);
            int result = n1 + n2;
            label6.Text = $" n1:{n1} + n2:{n2} = {result}";

        }
    }
}
