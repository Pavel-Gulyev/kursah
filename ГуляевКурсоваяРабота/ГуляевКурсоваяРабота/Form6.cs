using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ГуляевКурсоваяРабота
{
    public partial class Form6 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Каршеринг.mdb;";
        private OleDbConnection myConnection;
        OleDbDataReader dataReader;

        public Form6()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            timer1.Start();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Убираем кнопки свернуть, развернуть, закрыть.
            this.ControlBox = false;
            // Убираем заголовок.
            this.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) 
            {
                Opacity += 0.1d;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Пользователи";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                string Логин = dataReader.GetString(0);
                string Паррль = dataReader.GetString(1);
                if (textBox1.Text == Логин && textBox2.Text == Паррль)
                {
                    Form7 frm7 = new Form7();
                    frm7.Show();
                    this.Hide();
                    return;
                }


                else
                {


                }

            }
            Form4 form = new Form4();
            form.Show();
            dataReader.Close();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }

}