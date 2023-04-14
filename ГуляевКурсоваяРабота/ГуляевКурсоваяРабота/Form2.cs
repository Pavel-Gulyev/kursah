using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ГуляевКурсоваяРабота
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Убираем кнопки свернуть, развернуть, закрыть.
            this.ControlBox = false;
            // Убираем заголовок.
            this.Text = "";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каршерингDataSet._Автомобили_клиенты_". При необходимости она может быть перемещена или удалена.
            this.автомобили_клиенты_TableAdapter.Fill(this.каршерингDataSet._Автомобили_клиенты_);
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            dataGridView1.ClearSelection();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            автомобили_клиенты_TableAdapter.Update(каршерингDataSet._Автомобили_клиенты_);
            File.Delete(@"..\..\..\ГуляевКурсоваяРабота\Каршеринг.mdb");
            File.Copy("Каршеринг.mdb", @"..\..\..\ГуляевКУрсоваяРабота\Каршеринг.mdb");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            автомобиликлиентыBindingSource.RemoveCurrent();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button18_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button2_Click_(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.CurrentCell = null; dataGridView1.Rows[i].Visible = true;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = false;
                            break;
                        }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
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
