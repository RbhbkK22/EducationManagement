namespace EducationManagement.viewModel.ChangeForm
{
    partial class ChangeStudent
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
            homeNumTextBox = new TextBox();
            streetTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            grupBox = new ComboBox();
            nameTextBox = new TextBox();
            label1 = new Label();
            ChangeBtn = new Button();
            SuspendLayout();
            // 
            // homeNumTextBox
            // 
            homeNumTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeNumTextBox.Location = new Point(200, 207);
            homeNumTextBox.Name = "homeNumTextBox";
            homeNumTextBox.Size = new Size(50, 26);
            homeNumTextBox.TabIndex = 12;
            // 
            // streetTextBox
            // 
            streetTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            streetTextBox.Location = new Point(50, 207);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(150, 26);
            streetTextBox.TabIndex = 11;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(50, 175);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(200, 26);
            lastNameTextBox.TabIndex = 9;
            // 
            // grupBox
            // 
            grupBox.DropDownStyle = ComboBoxStyle.DropDownList;
            grupBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grupBox.FormattingEnabled = true;
            grupBox.Location = new Point(50, 110);
            grupBox.Name = "grupBox";
            grupBox.Size = new Size(200, 27);
            grupBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(50, 143);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 26);
            nameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(246, 28);
            label1.TabIndex = 10;
            label1.Text = "Изменение студента";
            // 
            // ChangeBtn
            // 
            ChangeBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeBtn.Location = new Point(100, 350);
            ChangeBtn.Name = "ChangeBtn";
            ChangeBtn.Size = new Size(100, 40);
            ChangeBtn.TabIndex = 6;
            ChangeBtn.Text = "Изменить";
            ChangeBtn.UseVisualStyleBackColor = true;
            ChangeBtn.Click += ChangeBtn_Click;
            // 
            // ChangeStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 411);
            Controls.Add(homeNumTextBox);
            Controls.Add(streetTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(grupBox);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(ChangeBtn);
            Name = "ChangeStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeStudent";
            Load += ChangeStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox homeNumTextBox;
        private TextBox streetTextBox;
        private TextBox lastNameTextBox;
        private ComboBox grupBox;
        private TextBox nameTextBox;
        private Label label1;
        private Button ChangeBtn;
    }
}