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

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Убираем кнопки свернуть, развернуть, закрыть.
            this.ControlBox = false;
            // Убираем заголовок.
            this.Text = "";

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каршерингDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.каршерингDataSet.Пользователи);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            пользователиBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var row = каршерингDataSet.Пользователи.NewRow();
            row[0] = Convert.ToString(UserTextBox.Text);
            row[1] = Convert.ToString(PasswordTextBox.Text);
            try
            {
                каршерингDataSet.Пользователи.Rows.Add(row);

            }
            catch
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован!");
            }
            this.пользователиTableAdapter.Update(this.каршерингDataSet.Пользователи);
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            пользователиTableAdapter.Update(каршерингDataSet.Пользователи);
            File.Delete(@"..\..\..\ГуляевКурсоваяРабота\Каршеринг.mdb");
            File.Copy("Каршеринг.mdb", @"..\..\..\ГуляевКурсоваяРабота\Каршеринг.mdb");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
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
    }
}


