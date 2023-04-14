
namespace ГуляевКурсоваяРабота
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номеРпаркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаАрендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияАрендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиоКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автомобиликлиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каршерингDataSet = new ГуляевКурсоваяРабота.КаршерингDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.автомобили_клиенты_TableAdapter = new ГуляевКурсоваяРабота.КаршерингDataSetTableAdapters.Автомобили_клиенты_TableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Аренда = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобиликлиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каршерингDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(939, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 294);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(225, 46);
            this.button7.TabIndex = 45;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Red;
            this.button17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(15, 434);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(223, 46);
            this.button17.TabIndex = 43;
            this.button17.Text = "К авторизации";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(15, 363);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 46);
            this.button6.TabIndex = 41;
            this.button6.Text = "Свернуть";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАвтомобиляDataGridViewTextBoxColumn,
            this.модельАвтомобиляDataGridViewTextBoxColumn,
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn,
            this.номеРпаркаDataGridViewTextBoxColumn,
            this.датаНачалаАрендыDataGridViewTextBoxColumn,
            this.датаОкончанияАрендыDataGridViewTextBoxColumn,
            this.фиоКлиентаDataGridViewTextBoxColumn,
            this.Аренда});
            this.dataGridView1.DataSource = this.автомобиликлиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(937, 247);
            this.dataGridView1.TabIndex = 40;
            // 
            // кодАвтомобиляDataGridViewTextBoxColumn
            // 
            this.кодАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Код автомобиля";
            this.кодАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Код автомобиля";
            this.кодАвтомобиляDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодАвтомобиляDataGridViewTextBoxColumn.Name = "кодАвтомобиляDataGridViewTextBoxColumn";
            this.кодАвтомобиляDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодАвтомобиляDataGridViewTextBoxColumn.Width = 125;
            // 
            // модельАвтомобиляDataGridViewTextBoxColumn
            // 
            this.модельАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Модель автомобиля";
            this.модельАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Модель автомобиля";
            this.модельАвтомобиляDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.модельАвтомобиляDataGridViewTextBoxColumn.Name = "модельАвтомобиляDataGridViewTextBoxColumn";
            this.модельАвтомобиляDataGridViewTextBoxColumn.ReadOnly = true;
            this.модельАвтомобиляDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаПрокатазаСуткиDataGridViewTextBoxColumn
            // 
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn.DataPropertyName = "Цена проката(за сутки)";
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn.HeaderText = "Цена проката(за сутки)";
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn.Name = "ценаПрокатазаСуткиDataGridViewTextBoxColumn";
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn.ReadOnly = true;
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn.Width = 125;
            // 
            // номеРпаркаDataGridViewTextBoxColumn
            // 
            this.номеРпаркаDataGridViewTextBoxColumn.DataPropertyName = "Номе рпарка";
            this.номеРпаркаDataGridViewTextBoxColumn.HeaderText = "Номе рпарка";
            this.номеРпаркаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номеРпаркаDataGridViewTextBoxColumn.Name = "номеРпаркаDataGridViewTextBoxColumn";
            this.номеРпаркаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номеРпаркаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаНачалаАрендыDataGridViewTextBoxColumn
            // 
            this.датаНачалаАрендыDataGridViewTextBoxColumn.DataPropertyName = "Дата начала аренды";
            this.датаНачалаАрендыDataGridViewTextBoxColumn.HeaderText = "Дата начала аренды";
            this.датаНачалаАрендыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаНачалаАрендыDataGridViewTextBoxColumn.Name = "датаНачалаАрендыDataGridViewTextBoxColumn";
            this.датаНачалаАрендыDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаНачалаАрендыDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаОкончанияАрендыDataGridViewTextBoxColumn
            // 
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания аренды";
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.HeaderText = "Дата окончания аренды";
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.Name = "датаОкончанияАрендыDataGridViewTextBoxColumn";
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.Width = 125;
            // 
            // фиоКлиентаDataGridViewTextBoxColumn
            // 
            this.фиоКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Фио клиента";
            this.фиоКлиентаDataGridViewTextBoxColumn.HeaderText = "Фио клиента";
            this.фиоКлиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фиоКлиентаDataGridViewTextBoxColumn.Name = "фиоКлиентаDataGridViewTextBoxColumn";
            this.фиоКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фиоКлиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // автомобиликлиентыBindingSource
            // 
            this.автомобиликлиентыBindingSource.DataMember = "Автомобили(клиенты)";
            this.автомобиликлиентыBindingSource.DataSource = this.каршерингDataSet;
            // 
            // каршерингDataSet
            // 
            this.каршерингDataSet.DataSetName = "КаршерингDataSet";
            this.каршерингDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 46);
            this.button1.TabIndex = 39;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(15, 570);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 46);
            this.button4.TabIndex = 54;
            this.button4.Text = "Расчет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(273, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "День окончания аренды";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(273, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "День аренды";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(272, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 29);
            this.label6.TabIndex = 55;
            this.label6.Text = "Код автомобиля";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(559, 552);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(652, 341);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 46);
            this.button2.TabIndex = 59;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(277, 403);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(277, 485);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 318);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 46;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(665, 274);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 22);
            this.textBox4.TabIndex = 65;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(665, 487);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 66;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(660, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 29);
            this.label2.TabIndex = 67;
            this.label2.Text = "Введите ваше ФИО";
            // 
            // автомобили_клиенты_TableAdapter
            // 
            this.автомобили_клиенты_TableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(278, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "Стоимость аренды (на сутки)";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(282, 552);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 70;
            // 
            // Аренда
            // 
            this.Аренда.DataPropertyName = "Код автомобиля";
            this.Аренда.HeaderText = "Аренда";
            this.Аренда.MinimumWidth = 6;
            this.Аренда.Name = "Аренда";
            this.Аренда.ReadOnly = true;
            this.Аренда.Width = 125;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 629);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кабинет пользователя";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобиликлиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каршерингDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private КаршерингDataSet каршерингDataSet;
        private System.Windows.Forms.BindingSource автомобиликлиентыBindingSource;
        private КаршерингDataSetTableAdapters.Автомобили_клиенты_TableAdapter автомобили_клиенты_TableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаПрокатазаСуткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеРпаркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаАрендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияАрендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Аренда;
    }
}