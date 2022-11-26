namespace WindowsUygulamasi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (!comboBox1.Items.Contains(textBox1.Text))
                comboBox1.Items.Add(textBox1.Text);
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba","Uyarý",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);
        }
    }
}