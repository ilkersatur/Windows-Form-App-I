namespace Ornek
{
    public partial class Form1 : Form
    {
        //string a;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //a = "Ticari";
        }

        private void btn_ResimYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation =openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string str = null;
            //foreach (var item in listBox2.Items)
            //{
            //    str += $"\n{item}\n";
            //}
            //MessageBox.Show($"Model {txt_Model.Text}" +
            //    $"\nMarka {cmb_Marka.SelectedItem}" +
            //    $"\nPlaka {txt_Plaka.Text}" +
            //    $"\nAksesuarlar {str}"+
            //    $"\nAraç Tipi {a}");
            string strData = "";
            strData += txt_Plaka.Text + ";";
            strData += cmb_Marka.SelectedItem + ";";
            strData += txt_Model.Text + ";";
            if (rdb_Binek.Checked)
            {
                strData += rdb_Binek.Text;
            }
            if (rdb_Ticari.Checked)
            {
                strData += rdb_Ticari.Text;
            }
            foreach (var item in listBox2.Items)
            {
                strData += item+",";
            }
            strData += pictureBox1.ImageLocation;
            MessageBox.Show(strData);
        }

        

        private void cmb_Marka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                {

                }
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btn_Cikar_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {

                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void rdb_Binek_CheckedChanged(object sender, EventArgs e)
        {
            //a = "Binek";
        }

        private void Model_Click(object sender, EventArgs e)
        {

        }
    }
}