namespace EducationManagement.viewModel.ChengeForm
{
    partial class ChangeGrup
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
            numberGrupTextBox = new TextBox();
            ChangeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(220, 28);
            label1.TabIndex = 5;
            label1.Text = "Изменение группы";
            // 
            // numberGrupTextBox
            // 
            numberGrupTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numberGrupTextBox.Location = new Point(50, 170);
            numberGrupTextBox.Name = "numberGrupTextBox";
            numberGrupTextBox.Size = new Size(200, 26);
            numberGrupTextBox.TabIndex = 4;
            // 
            // ChangeBtn
            // 
            ChangeBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeBtn.Location = new Point(100, 350);
            ChangeBtn.Name = "ChangeBtn";
            ChangeBtn.Size = new Size(100, 40);
            ChangeBtn.TabIndex = 3;
            ChangeBtn.Text = "Изменить";
            ChangeBtn.UseVisualStyleBackColor = true;
            ChangeBtn.Click += ChangeBtn_Click;
            // 
            // ChangeGrup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 411);
            Controls.Add(label1);
            Controls.Add(numberGrupTextBox);
            Controls.Add(ChangeBtn);
            Name = "ChangeGrup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChengeGrup";
            Load += ChangeGrup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numberGrupTextBox;
        private Button ChangeBtn;
    }
}