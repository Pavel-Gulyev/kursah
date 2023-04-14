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
using System.Data.OleDb;

namespace ГуляевКурсоваяРабота
{
    public partial class Form7 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Каршеринг.mdb;";
        private OleDbConnection myConnection;
        OleDbDataReader dataReader;
        public Form7()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Убираем кнопки свернуть, развернуть, закрыть.
            this.ControlBox = false;
            // Убираем заголовок.
            this.Text = "";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каршерингDataSet._Автомобили_клиенты_". При необходимости она может быть перемещена или удалена.
            this.автомобили_клиенты_TableAdapter.Fill(this.каршерингDataSet._Автомобили_клиенты_);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                MessageBox.Show("Автомобиль арендован!");

                if (textBox1.Text == "1")
                {

                    this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 0].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 0].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 0].Value = textBox2.Text;
                }

                if (textBox1.Text == "2")
                {
                    this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 1].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 1].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 1].Value = textBox2.Text;
                }

                if (textBox1.Text == "3")
                {
                    this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 2].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 2].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 2].Value = textBox2.Text;
                }

                if (textBox1.Text == "4")
                {
                    this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 3].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 3].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 3].Value = textBox2.Text;
                }

                if (textBox1.Text == "5")
                {
                    this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 4].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 4].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 4].Value = textBox2.Text;
                }

                if (textBox1.Text == "6")
                {
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 5].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 5].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 5].Value = textBox2.Text;

                }

                if (textBox1.Text == "7")
                {
                    this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 6].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 6].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 6].Value = textBox2.Text;
                }

                if (textBox1.Text == "8")
                {
                    this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 7].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 7].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 7].Value = textBox2.Text;
                }

                if (textBox1.Text == "9")
                {
                    this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 8].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 8].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 8].Value = textBox2.Text;
                }

                if (textBox1.Text == "10")
                {
                    this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 9].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 9].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 9].Value = textBox2.Text;
                }

                if (textBox1.Text == "11")
                {
                    this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 10].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 10].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 10].Value = textBox2.Text;
                }

                if (textBox1.Text == "12")
                {
                    this.автомобили_клиенты_TableAdapter.Update(this.каршерингDataSet._Автомобили_клиенты_);
                    автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                    dataGridView1[4, 11].Value = Convert.ToDateTime(dateTimePicker1.Text);
                    dataGridView1[5, 11].Value = Convert.ToDateTime(dateTimePicker2.Text);
                    dataGridView1[6, 11].Value = textBox2.Text;
                }

                автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
                File.Delete(@"..\..\..\ГуляевКурсоваяРабота\Каршеринг.mdb");
                File.Copy("Каршеринг.mdb", @"..\..\..\ГуляевКурсоваяРабота\Каршеринг.mdb");
            }
            else
            {
                MessageBox.Show("Проверьте заполнены ли все ключевые поля!");
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimeSpan y = dateTimePicker1.Value - dateTimePicker2.Value;
            TimeSpan z = dateTimePicker2.Value - dateTimePicker1.Value;
            int a = y.Days;
            int c = z.Days;
            int b;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    bool v = comboBox1.Text == "1";
                    if (y > z && v)
                    {
                        b = 4500 * (a + 1);
                        label1.Text = "Сумма аренды состсавляет " + Convert.ToString(b) + " рублей";
                    }

                    else if (y < z)
                    {
                        b = 4500 * (c + 1);
                        label1.Text = "Сумма аренды состсавляет " + Convert.ToString(b) + " рублей";
                    }

                    else
                    {
                        MessageBox.Show("ошибка!");

                    }

                    break;
                case 1:
                    if (y > z)
                    {
                        b = 3000 * (a + 1);
                        label1.Text = "Сумма аренды состсавляет " + Convert.ToString(b) + " рублей";
                    }

                    else
                    {
                        b = 3000 * (c + 1);
                        label1.Text = "Сумма аренды состсавляет " + Convert.ToString(b) + " рублей";
                    }
                    break;
                case 2:
                    if (y > z)
                    {
                        b = 4000 * (a + 1);
                        label1.Text = "Сумма аренды состсавляет " + Convert.ToString(b) + " рублей";
                    }

                    else
                    {
                        b = 4000 * (c + 1);
                        label1.Text = "Сумма аренды состсавляет " + Convert.ToString(b) + " рублей";
                    }
                    break;
                case 3:
                    if (y > z)
                    {
                        b = 5000 * (a + 1);
                        label1.Text = "Сумма аренды состсавляет " + Convert.ToString(b) + " рублей";
                    }

                    else
                    {
                        b = 5000 * (c + 1);
                        label1.Text = "Сумма аренды состсавляет " + Convert.ToString(b) + " рублей";
                    }

                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox4.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
     
        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch1 = e.KeyChar;
            textBox2.Clear();
            if (!Char.IsDigit(ch1) && ch1 != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }
    }
}