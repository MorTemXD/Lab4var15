namespace Lab4var15task2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.jobListBox = new System.Windows.Forms.ListBox();
            this.salaryComboBox = new System.Windows.Forms.ComboBox();
            this.experienceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.displayButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.experienceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // jobListBox
            // 
            this.jobListBox.FormattingEnabled = true;
            this.jobListBox.Items.AddRange(new object[] {
            "Системний адміністратор",
            "Веб-програміст",
            "Веб-дизайнер",
            "Модератор сайтів"});
            this.jobListBox.Location = new System.Drawing.Point(12, 12);
            this.jobListBox.Name = "jobListBox";
            this.jobListBox.Size = new System.Drawing.Size(184, 121);
            this.jobListBox.TabIndex = 0;
            // 
            // salaryComboBox
            // 
            this.salaryComboBox.FormattingEnabled = true;
            this.salaryComboBox.Items.AddRange(new object[] {
            "20000",
            "25000",
            "30000",
            "35000",
            "40000"});
            this.salaryComboBox.Location = new System.Drawing.Point(12, 139);
            this.salaryComboBox.Name = "salaryComboBox";
            this.salaryComboBox.Size = new System.Drawing.Size(184, 21);
            this.salaryComboBox.TabIndex = 1;
            this.salaryComboBox.Text = "Виберіть початкову зарплату";
            // 
            // experienceNumericUpDown
            // 
            this.experienceNumericUpDown.Location = new System.Drawing.Point(129, 169);
            this.experienceNumericUpDown.Name = "experienceNumericUpDown";
            this.experienceNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.experienceNumericUpDown.TabIndex = 2;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(15, 195);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(181, 23);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "Вивести";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click_1);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(219, 12);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.Size = new System.Drawing.Size(188, 206);
            this.resultRichTextBox.TabIndex = 6;
            this.resultRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Виберіть стаж";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.experienceNumericUpDown);
            this.Controls.Add(this.salaryComboBox);
            this.Controls.Add(this.jobListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.experienceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox jobListBox;
        private System.Windows.Forms.ComboBox salaryComboBox;
        private System.Windows.Forms.NumericUpDown experienceNumericUpDown;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.Label label1;
    }
}

