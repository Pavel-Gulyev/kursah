using System;
using System.Threading;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ГуляевКурсоваяРабота
{

    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Каршеринг.mdb;";
        private OleDbConnection myConnection;
        OleDbDataReader dataReader;

        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            timer1.Start();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Убираем кнопки свернуть, развернуть, закрыть.
            this.ControlBox = false;
            // Убираем заголовок.
            this.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Админы";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                string Логин = dataReader.GetString(0);
                string Пароль = dataReader.GetString(1);
                if (textBox1.Text == Логин && textBox2.Text ==Пароль)
                {
                    Form2 frm2 = new Form2();
                    frm2.Show();
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
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            myConnection.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) 
            {
                Opacity += 0.1d;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}