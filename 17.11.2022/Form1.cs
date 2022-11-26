namespace _17._11._2022
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

        private void btnTopla_Click(object sender, EventArgs e)
        {
            // evente baðlý metod
            lblSonuc.Text = ((int.Parse(txtSayi2.Text) + int.Parse(txtSayi1.Text)).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            radioButton1.Checked = true;
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\SABAH YAZILIM\Desktop\C# NOTE\2.jpg";
        }
    }
}