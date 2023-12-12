namespace EducationManagement.viewModel.ChangeForm
{
    partial class ChangeStaff
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
            passTextBox = new TextBox();
            loginTextBox = new TextBox();
            AddBtn = new Button();
            salaryTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            positBox = new ComboBox();
            nameTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // passTextBox
            // 
            passTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passTextBox.Location = new Point(50, 271);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(200, 26);
            passTextBox.TabIndex = 14;
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginTextBox.Location = new Point(50, 239);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(200, 26);
            loginTextBox.TabIndex = 13;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(100, 350);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(100, 40);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Изменить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // salaryTextBox
            // 
            salaryTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            salaryTextBox.Location = new Point(50, 207);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(200, 26);
            salaryTextBox.TabIndex = 12;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(50, 142);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(200, 26);
            lastNameTextBox.TabIndex = 9;
            // 
            // positBox
            // 
            positBox.DropDownStyle = ComboBoxStyle.DropDownList;
            positBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            positBox.FormattingEnabled = true;
            positBox.Location = new Point(50, 174);
            positBox.Name = "positBox";
            positBox.Size = new Size(200, 27);
            positBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(50, 110);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 26);
            nameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(259, 28);
            label1.TabIndex = 11;
            label1.Text = "Изменение работника";
            // 
            // ChangeStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 411);
            Controls.Add(passTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(AddBtn);
            Controls.Add(salaryTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(positBox);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "ChangeStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeStaff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passTextBox;
        private TextBox loginTextBox;
        private Button AddBtn;
        private TextBox salaryTextBox;
        private TextBox lastNameTextBox;
        private ComboBox positBox;
        private TextBox nameTextBox;
        private Label label1;
    }
}