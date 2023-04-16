
namespace ГуляевКурсоваяРабота
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номеРпаркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автомобиликлиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каршерингDataSet = new ГуляевКурсоваяРабота.КаршерингDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодАвтомобиляDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаАрендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияАрендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиоКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.арендованыеАвтоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобили_клиенты_TableAdapter = new ГуляевКурсоваяРабота.КаршерингDataSetTableAdapters.Автомобили_клиенты_TableAdapter();
            this.арендованые_автоTableAdapter = new ГуляевКурсоваяРабота.КаршерингDataSetTableAdapters.Арендованые_автоTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобиликлиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каршерингDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендованыеАвтоBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1213, 685);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button18
            // 
            this.button18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button18.BackgroundImage")));
            this.button18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(44, 105);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(272, 61);
            this.button18.TabIndex = 35;
            this.button18.Text = "Добавить новых администраторов";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Red;
            this.button17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(879, 11);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(173, 38);
            this.button17.TabIndex = 34;
            this.button17.Text = "К авторизации";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(451, 64);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 37);
            this.button3.TabIndex = 25;
            this.button3.Text = "Обновить таблицу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1069, 11);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 38);
            this.button5.TabIndex = 27;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(729, 11);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 38);
            this.button9.TabIndex = 31;
            this.button9.Text = "Свернуть";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(304, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Введите данные в строку для поиска автомобиля";
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(44, 54);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(240, 42);
            this.button6.TabIndex = 28;
            this.button6.Text = "Удалить строку";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 22);
            this.textBox1.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(301, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 37);
            this.button2.TabIndex = 24;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(44, 7);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 42);
            this.button4.TabIndex = 26;
            this.button4.Text = "Сохранить таблицу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАвтомобиляDataGridViewTextBoxColumn,
            this.модельАвтомобиляDataGridViewTextBoxColumn,
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn,
            this.номеРпаркаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.автомобиликлиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(275, 170);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 233);
            this.dataGridView1.TabIndex = 36;
            // 
            // кодАвтомобиляDataGridViewTextBoxColumn
            // 
            this.кодАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Код автомобиля";
            this.кодАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Код автомобиля";
            this.кодАвтомобиляDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодАвтомобиляDataGridViewTextBoxColumn.Name = "кодАвтомобиляDataGridViewTextBoxColumn";
            this.кодАвтомобиляDataGridViewTextBoxColumn.Width = 125;
            // 
            // модельАвтомобиляDataGridViewTextBoxColumn
            // 
            this.модельАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Модель автомобиля";
            this.модельАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Модель автомобиля";
            this.модельАвтомобиляDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.модельАвтомобиляDataGridViewTextBoxColumn.Name = "модельАвтомобиляDataGridViewTextBoxColumn";
            this.модельАвтомобиляDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаПрокатазаСуткиDataGridViewTextBoxColumn
            // 
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn.DataPropertyName = "Цена проката(за сутки)";
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn.HeaderText = "Цена проката(за сутки)";
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn.Name = "ценаПрокатазаСуткиDataGridViewTextBoxColumn";
            this.ценаПрокатазаСуткиDataGridViewTextBoxColumn.Width = 125;
            // 
            // номеРпаркаDataGridViewTextBoxColumn
            // 
            this.номеРпаркаDataGridViewTextBoxColumn.DataPropertyName = "Номе рпарка";
            this.номеРпаркаDataGridViewTextBoxColumn.HeaderText = "Номе рпарка";
            this.номеРпаркаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номеРпаркаDataGridViewTextBoxColumn.Name = "номеРпаркаDataGridViewTextBoxColumn";
            this.номеРпаркаDataGridViewTextBoxColumn.Width = 125;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАвтомобиляDataGridViewTextBoxColumn1,
            this.датаНачалаАрендыDataGridViewTextBoxColumn,
            this.датаОкончанияАрендыDataGridViewTextBoxColumn,
            this.фиоКлиентаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.арендованыеАвтоBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(275, 426);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(762, 233);
            this.dataGridView2.TabIndex = 37;
            // 
            // кодАвтомобиляDataGridViewTextBoxColumn1
            // 
            this.кодАвтомобиляDataGridViewTextBoxColumn1.DataPropertyName = "Код автомобиля";
            this.кодАвтомобиляDataGridViewTextBoxColumn1.HeaderText = "Код автомобиля";
            this.кодАвтомобиляDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодАвтомобиляDataGridViewTextBoxColumn1.Name = "кодАвтомобиляDataGridViewTextBoxColumn1";
            this.кодАвтомобиляDataGridViewTextBoxColumn1.Width = 125;
            // 
            // датаНачалаАрендыDataGridViewTextBoxColumn
            // 
            this.датаНачалаАрендыDataGridViewTextBoxColumn.DataPropertyName = "Дата начала аренды";
            this.датаНачалаАрендыDataGridViewTextBoxColumn.HeaderText = "Дата начала аренды";
            this.датаНачалаАрендыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаНачалаАрендыDataGridViewTextBoxColumn.Name = "датаНачалаАрендыDataGridViewTextBoxColumn";
            this.датаНачалаАрендыDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаОкончанияАрендыDataGridViewTextBoxColumn
            // 
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания аренды";
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.HeaderText = "Дата окончания аренды";
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.Name = "датаОкончанияАрендыDataGridViewTextBoxColumn";
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.Width = 125;
            // 
            // фиоКлиентаDataGridViewTextBoxColumn
            // 
            this.фиоКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Фио клиента";
            this.фиоКлиентаDataGridViewTextBoxColumn.HeaderText = "Фио клиента";
            this.фиоКлиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фиоКлиентаDataGridViewTextBoxColumn.Name = "фиоКлиентаDataGridViewTextBoxColumn";
            this.фиоКлиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // арендованыеАвтоBindingSource
            // 
            this.арендованыеАвтоBindingSource.DataMember = "Арендованые авто";
            this.арендованыеАвтоBindingSource.DataSource = this.каршерингDataSet;
            // 
            // автомобили_клиенты_TableAdapter
            // 
            this.автомобили_клиенты_TableAdapter.ClearBeforeFill = true;
            // 
            // арендованые_автоTableAdapter
            // 
            this.арендованые_автоTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(729, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 46);
            this.button1.TabIndex = 38;
            this.button1.Text = "Добавить новый автомобиль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 670);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кабинет администратора";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобиликлиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каршерингDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендованыеАвтоBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private КаршерингDataSet каршерингDataSet;
        private System.Windows.Forms.BindingSource автомобиликлиентыBindingSource;
        private КаршерингDataSetTableAdapters.Автомобили_клиенты_TableAdapter автомобили_клиенты_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаПрокатазаСуткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеРпаркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource арендованыеАвтоBindingSource;
        private КаршерингDataSetTableAdapters.Арендованые_автоTableAdapter арендованые_автоTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвтомобиляDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаАрендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияАрендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}