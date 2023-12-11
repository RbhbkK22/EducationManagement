namespace EducationManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginTextBox = new TextBox();
            passTextBox = new TextBox();
            autorisBtn = new Button();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(55, 117);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(240, 23);
            loginTextBox.TabIndex = 1;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(55, 178);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(240, 23);
            passTextBox.TabIndex = 2;
            // 
            // autorisBtn
            // 
            autorisBtn.Location = new Point(100, 320);
            autorisBtn.Name = "autorisBtn";
            autorisBtn.Size = new Size(150, 50);
            autorisBtn.TabIndex = 0;
            autorisBtn.Text = "Вход";
            autorisBtn.UseVisualStyleBackColor = true;
            autorisBtn.Click += autorisBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(autorisBtn);
            Controls.Add(passTextBox);
            Controls.Add(loginTextBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "autorisation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passTextBox;
        private Button autorisBtn;
    }
}