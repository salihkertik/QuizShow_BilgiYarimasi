using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizShow_BilgiYarimasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;


            label5.Text = btnb.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                lbly.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;


            label5.Text = btnc.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                lbly.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;


            label5.Text = btnd.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                lbly.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;


            label5.Text = btna.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                lbly.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
        
        private void btns_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;
            lblsoru.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz?";
                btna.Text = "Konya";
                btnb.Text = "Aydın";
                btnc.Text = "İzmir";
                btnd.Text = "Manisa";
                label4.Text = "Konya";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir";
                btna.Text = "Sait Faik";
                btnb.Text = "Cemal Süreya";
                btnc.Text = "Atilla ilhan";
                btnd.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                btns.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btns.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: "+yanlis);
            }
        }
    }
}
