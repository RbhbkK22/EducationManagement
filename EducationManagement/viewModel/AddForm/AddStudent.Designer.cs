namespace EducationManagement.viewModel.AddForm
{
    partial class AddStudent
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
            AddBtn = new Button();
            label1 = new Label();
            nameTextBox = new TextBox();
            grupBox = new ComboBox();
            lastNameTextBox = new TextBox();
            streetTextBox = new TextBox();
            homeNumTextBox = new TextBox();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(100, 350);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(100, 40);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 3;
            label1.Text = "Добавление группы";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(50, 143);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 26);
            nameTextBox.TabIndex = 4;
            // 
            // grupBox
            // 
            grupBox.DropDownStyle = ComboBoxStyle.DropDownList;
            grupBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grupBox.FormattingEnabled = true;
            grupBox.Location = new Point(50, 110);
            grupBox.Name = "grupBox";
            grupBox.Size = new Size(200, 27);
            grupBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(50, 175);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(200, 26);
            lastNameTextBox.TabIndex = 6;
            // 
            // streetTextBox
            // 
            streetTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            streetTextBox.Location = new Point(50, 207);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(150, 26);
            streetTextBox.TabIndex = 7;
            // 
            // homeNumTextBox
            // 
            homeNumTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeNumTextBox.Location = new Point(200, 207);
            homeNumTextBox.Name = "homeNumTextBox";
            homeNumTextBox.Size = new Size(50, 26);
            homeNumTextBox.TabIndex = 8;
            // 
            // AddStudent
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
            Controls.Add(AddBtn);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private Label label1;
        private TextBox nameTextBox;
        private ComboBox grupBox;
        private TextBox lastNameTextBox;
        private TextBox streetTextBox;
        private TextBox homeNumTextBox;
    }
}