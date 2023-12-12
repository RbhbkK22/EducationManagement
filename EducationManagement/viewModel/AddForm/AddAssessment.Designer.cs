﻿namespace EducationManagement.viewModel.AddForm
{
    partial class AddAssessment
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
            StudentBox = new ComboBox();
            assessmentTextBox = new TextBox();
            subBox = new ComboBox();
            label1 = new Label();
            grupBox = new ComboBox();
            SuspendLayout();
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
            // StudentBox
            // 
            StudentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudentBox.FormattingEnabled = true;
            StudentBox.Location = new Point(50, 143);
            StudentBox.Name = "StudentBox";
            StudentBox.Size = new Size(200, 27);
            StudentBox.TabIndex = 7;
            // 
            // assessmentTextBox
            // 
            assessmentTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            assessmentTextBox.Location = new Point(50, 209);
            assessmentTextBox.Name = "assessmentTextBox";
            assessmentTextBox.Size = new Size(200, 26);
            assessmentTextBox.TabIndex = 8;
            // 
            // subBox
            // 
            subBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subBox.FormattingEnabled = true;
            subBox.Location = new Point(50, 176);
            subBox.Name = "subBox";
            subBox.Size = new Size(200, 27);
            subBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 15);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 10;
            label1.Text = "Добавление оценки";
            // 
            // grupBox
            // 
            grupBox.DropDownStyle = ComboBoxStyle.DropDownList;
            grupBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grupBox.FormattingEnabled = true;
            grupBox.Location = new Point(50, 110);
            grupBox.Name = "grupBox";
            grupBox.Size = new Size(200, 27);
            grupBox.TabIndex = 11;
            grupBox.SelectedIndexChanged += grupBox_SelectedIndexChanged;
            // 
            // AddAssessment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 411);
            Controls.Add(grupBox);
            Controls.Add(label1);
            Controls.Add(subBox);
            Controls.Add(assessmentTextBox);
            Controls.Add(StudentBox);
            Controls.Add(AddBtn);
            Name = "AddAssessment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAssessment";
            Load += AddAssessment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private ComboBox StudentBox;
        private TextBox assessmentTextBox;
        private ComboBox subBox;
        private Label label1;
        private ComboBox grupBox;
    }
}