namespace boga_io
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 2023; i >= 1950; i--)
                comboBox3.Items.Add(i.ToString());
            listBox3.Hide();

            radioButton3.Hide();
            radioButton2.Hide();
            radioButton1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex <= 6) MessageBox.Show("Bu oyunu 7 yaþ ve üzeri kiþiler oynayabilir...");

            else if (textBox1.Text == "") MessageBox.Show("Ýsim kýsmý boþ olamaz...");

            else if (comboBox2.SelectedIndex == -1) MessageBox.Show("Yaþ bilgileri eksik olamaz...");

            else if (comboBox1.SelectedIndex == -1) MessageBox.Show("Yaþ bilgileri eksik olamaz...");

            else listBox1.Items.Add(textBox1.Text +"#"+ comboBox3.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) MessageBox.Show("Kullanýcý seçilmelidir...");

            else if (listBox2.SelectedIndex == -1) MessageBox.Show("Oyun modu seçilmelidir...");

            else if (listBox2.SelectedIndex == 1)
            {
                

                if (radioButton1.Checked == true)
                {
                    for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        listBox3.Items.Add(listBox2.SelectedItems[i]);
                    }
                        Boga boga = new Boga();
                    this.Hide();
                    boga.Show();
                    
                }
                else if (radioButton2.Checked == true)
                {
                    boga2 Boga2 = new boga2();
                    this.Hide();
                    Boga2.Show();
                }
                else if (radioButton3.Checked == true)
                {
                    boga3 Boga3 = new boga3();
                    this.Hide();
                    Boga3.Show();
                }
                else MessageBox.Show("Lütfen zorluk seviyesini seçiniz...");

            }

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Hide();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 1)
            {

                radioButton1.Show();
                radioButton2.Show();
                radioButton3.Show();

            }
            else
            {

                radioButton1.Hide();
                radioButton2.Hide();
                radioButton3.Hide();

            }
        }
    }
}