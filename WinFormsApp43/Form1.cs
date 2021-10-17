using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Visible = true;

            int birinciatgenisligi = pictureBox1.Width;
            int ikinciatgenisligi = pictureBox2.Width;
            int ucuncuatgenisligi = pictureBox3.Width;

            int bitisuzakligi = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5,16);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 16);

            if(pictureBox1.Left >pictureBox2.Left+5&&pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "1 NUMARALI AT ÖNDE";
            }

            if(pictureBox2.Left >pictureBox1.Left+5&&pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2 NUMARALI AT ÖNDE";
            }

            if(pictureBox3.Left >pictureBox1.Left+5&&pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "3 NUMARALI AT ÖNDE";
            }

            if(birinciatgenisligi+pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 NUMARALI AT YARIŞI KAZANDI!");
                
            }

            if(ikinciatgenisligi+pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 NUMARALI AT YARIŞI KAZANDI!");
            }

            if(ucuncuatgenisligi+pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 NUMARALI AT YARIŞI KAZANDI!");
            }


        }

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }
    }
}
