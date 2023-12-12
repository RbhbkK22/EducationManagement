namespace EducationManagement.viewModel.AddForm
{
    partial class AddGrup
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
            numberGrupTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(100, 350);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(100, 40);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // numberGrupTextBox
            // 
            numberGrupTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numberGrupTextBox.Location = new Point(50, 170);
            numberGrupTextBox.Name = "numberGrupTextBox";
            numberGrupTextBox.Size = new Size(200, 26);
            numberGrupTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 2;
            label1.Text = "Добавление группы";
            // 
            // AddGrup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 411);
            Controls.Add(label1);
            Controls.Add(numberGrupTextBox);
            Controls.Add(AddBtn);
            Name = "AddGrup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddGrup";
            Load += AddGrup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private TextBox numberGrupTextBox;
        private Label label1;
    }
}