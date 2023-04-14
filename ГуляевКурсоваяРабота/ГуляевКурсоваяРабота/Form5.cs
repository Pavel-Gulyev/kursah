using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ГуляевКурсоваяРабота
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            timer1.Start();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Убираем кнопки свернуть, развернуть, закрыть.
            this.ControlBox = false;
            // Убираем заголовок.
            this.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) 
            {
                Opacity += 0.1d;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}