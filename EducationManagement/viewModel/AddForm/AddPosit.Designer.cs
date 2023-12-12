namespace EducationManagement.viewModel.AddForm
{
    partial class AddPosit
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
            label1 = new Label();
            nameTextBox = new TextBox();
            AddBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(272, 28);
            label1.TabIndex = 5;
            label1.Text = "Добавление должности";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(50, 170);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 26);
            nameTextBox.TabIndex = 4;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(100, 350);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(100, 40);
            AddBtn.TabIndex = 3;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // AddPosit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 411);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(AddBtn);
            Name = "AddPosit";
            Text = "AddPosit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Button AddBtn;
    }
}