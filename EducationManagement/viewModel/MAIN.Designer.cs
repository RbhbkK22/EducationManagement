namespace EducationManagement
{
    partial class MAIN
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
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            button2 = new Button();
            OpenAddForm = new Button();
            idTextBox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(984, 343);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(418, 24);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(410, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Студенты";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(410, 0);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Группы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(410, 0);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Предметы";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(410, 0);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Оценки";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(410, 0);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Работники";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(410, 0);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Должности";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(679, 13);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(115, 22);
            comboBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(800, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 22);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(921, 13);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Поиск";
            button2.UseVisualStyleBackColor = true;
            // 
            // OpenAddForm
            // 
            OpenAddForm.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OpenAddForm.Location = new Point(12, 385);
            OpenAddForm.Name = "OpenAddForm";
            OpenAddForm.Size = new Size(100, 40);
            OpenAddForm.TabIndex = 7;
            OpenAddForm.Text = "Добавить";
            OpenAddForm.UseVisualStyleBackColor = true;
            OpenAddForm.Click += OpenAddForm_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(12, 466);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 8;
            idTextBox.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(118, 385);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 9;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 501);
            Controls.Add(button1);
            Controls.Add(idTextBox);
            Controls.Add(OpenAddForm);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(dataGridView1);
            Controls.Add(tabControl1);
            Name = "MAIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAIN";
            FormClosed += MAIN_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Button button2;
        private Button OpenAddForm;
        private TextBox idTextBox;
        private Button button1;
    }
}