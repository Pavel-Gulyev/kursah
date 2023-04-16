using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ГуляевКурсоваяРабота
{
    public partial class Form9 : Form
    {


        public Form9()
        {
            InitializeComponent();
          
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Убираем кнопки свернуть, развернуть, закрыть.
            this.ControlBox = false;
            // Убираем заголовок.
            this.Text = "";
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каршерингDataSet._Автомобили_клиенты_". При необходимости она может быть перемещена или удалена.
            this.автомобили_клиенты_TableAdapter.Fill(this.каршерингDataSet._Автомобили_клиенты_);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var row = каршерингDataSet._Автомобили_клиенты_.NewRow();
            row[1] = Convert.ToInt32(textBox1.Text);
            row[2] = Convert.ToInt32(comboBox1.Text);
            row[3] = Convert.ToInt32(comboBox2.Text);
            каршерингDataSet.Арендованые_авто.Rows.Add(row);
            this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
            File.Delete(@"..\..\..\ГуляевКурсоваяРабота\Каршеринг.mdb");
            File.Copy("Каршеринг.mdb", @"..\..\..\ГуляевКурсоваяРабота\Каршеринг.mdb");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch1 = e.KeyChar;
            textBox1.Clear();

            if (!Char.IsDigit(ch1) && ch1 != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }
    }
}
