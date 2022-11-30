using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boga_io
{
    public partial class Boga : Form
    {
        public Boga()
        {
            InitializeComponent();
        }


        int x = 100, y = 250, size1 = 125, size2 = 125, zaman = 0;

        string yon;
        
        int value = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(yon == "sag")
            {
                x = x + 50;
                pictureBox1.Location = new Point(x,y);

            }
            if (yon == "sol")
            {
                x = x - 50;
                pictureBox1.Location = new Point(x, y);

            }
            if (yon == "yukarı")
            {
                y = y - 50;
                pictureBox1.Location = new Point(x, y);

            }
            if (yon == "assagi")
            {
                y = y + 50;
                pictureBox1.Location = new Point(x, y);

            }



            if(pictureBox1.Location.X > 1250 || pictureBox1.Location.X < -50)
            {
                timer2.Stop();
                pictureBox1.Hide();
                pictureBox2.Hide();
                MessageBox.Show("Karakter dışarı çıktı");
                System.Threading.Thread.Sleep(2000);
                Form1 form = new Form1();
                this.Close();
                form.ShowDialog();

            }
            if (pictureBox1.Location.Y > 600 || pictureBox1.Location.Y < -50)
            {
                timer2.Stop();
                pictureBox1.Hide();
                pictureBox2.Hide();
                MessageBox.Show("Karakter dışarı çıktı");
                System.Threading.Thread.Sleep(2000);
                Form1 form = new Form1();
                this.Close();
                form.ShowDialog();

            }

        }

        Random rkonum = new Random();

        private void Boga_Load(object sender, EventArgs e)
        {

            timer2.Interval = 200;

            timer1.Interval = 10;

            pictureBox3.Hide();

            timer1.Start();
            timer2.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman++;

            timer1.Start();
            label1.Text = zaman.ToString();
        }

        public void Boga_KeyDown(object sender, KeyEventArgs e)
        {

            

                int p1x = pictureBox1.Location.X;
                int p1y = pictureBox1.Location.Y;
                int p2x = pictureBox2.Location.X;
                int p2y = pictureBox2.Location.Y;

                if (e.KeyCode == Keys.W) yon = "yukarı";
                if (e.KeyCode == Keys.S) yon = "assagi";
                if (e.KeyCode == Keys.D) yon = "sag";
                if (e.KeyCode == Keys.A) yon = "sol";

            if (p1x == p2x && p1y == p2y)
                {
                    int yemx, yemy;
                    while (true)
                    {

                        Random rastgele = new Random();
                        yemx = rastgele.Next(50, 1201);
                        yemy = rastgele.Next(50, 601);
                        if (yemx % 50 == 0 && yemy % 50 == 0) break;

                        if (yemy % 50 != 0) continue;
                        if (yemx % 50 != 0) continue;

                    }
                    pictureBox2.Location = new Point(yemx, yemy);
                    if (size1 >= 15 && size2 >= 15)
                    {
                        size1 = size1 - 10;
                        size2 = size2 - 10;
                        pictureBox1.Size = new Size(size1, size2);
                    }
                    if (size1 == 5)
                    {
                        pictureBox1.Hide();
                        pictureBox2.Hide();
                        pictureBox3.Show();
                        MessageBox.Show("Oyunu başarıyla tamamladınız...");
                        System.Threading.Thread.Sleep(2000);
                        Form1 form = new Form1();
                        this.Close();
                        form.ShowDialog();

                    }
                value += 10;
                if(value > 100) progressBar1.Value = 100;

                else progressBar1.Value = value;

            }
            
        }
    }
}
