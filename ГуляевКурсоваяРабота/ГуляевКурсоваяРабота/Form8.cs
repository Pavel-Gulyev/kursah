using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ГуляевКурсоваяРабота
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            timer1.Start();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Убираем кнопки свернуть, развернуть, закрыть.
            this.ControlBox = false;
            // Убираем заголовок.
            this.Text = "";

        }
             private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каршерингDataSet.Админы". При необходимости она может быть перемещена или удалена.
            this.админыTableAdapter.Fill(this.каршерингDataSet.Админы);  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            админыBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var row =каршерингDataSet.Админы.NewRow();
            row[0] = Convert.ToInt32(UserTextBox.Text);
            row[1] = Convert.ToInt32(PasswordTextBox.Text);
            try
            {
                каршерингDataSet.Админы.Rows.Add(row);

            }
            catch
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован!");
            }
           
            this.админыTableAdapter.Update(this.каршерингDataSet.Админы);
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            админыTableAdapter.Update(каршерингDataSet.Админы);
            File.Delete(@"..\..\..\ГуляевКурсоваяРабота\Каршеринг.mdb");
            File.Copy("Каршеринг.mdb", @"..\..\..\ГуляевКурсоваяРабота\Каршеринг.mdb");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) 
            {
                Opacity += 0.1d;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }




    

     
      
}
