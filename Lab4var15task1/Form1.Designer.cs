namespace Lab4var15task1
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
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.textBoxNewCity = new System.Windows.Forms.TextBox();
            this.buttonAddCity = new System.Windows.Forms.Button();
            this.buttonPlanTrip = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Items.AddRange(new object[] {
            "Київ",
            "Харків",
            "Одеса",
            "Дніпро",
            "Львів",
            "Кривий Ріг",
            "Миколаїв",
            "Вінниця",
            "Херсон",
            "Чернігі"});
            this.comboBoxCities.Location = new System.Drawing.Point(5, 26);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCities.TabIndex = 0;
            // 
            // textBoxNewCity
            // 
            this.textBoxNewCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxNewCity.Location = new System.Drawing.Point(5, 107);
            this.textBoxNewCity.Name = "textBoxNewCity";
            this.textBoxNewCity.Size = new System.Drawing.Size(168, 20);
            this.textBoxNewCity.TabIndex = 1;
            // 
            // buttonAddCity
            // 
            this.buttonAddCity.Location = new System.Drawing.Point(5, 133);
            this.buttonAddCity.Name = "buttonAddCity";
            this.buttonAddCity.Size = new System.Drawing.Size(168, 36);
            this.buttonAddCity.TabIndex = 2;
            this.buttonAddCity.Text = "Додати місто\r\nдо списку\r\n";
            this.buttonAddCity.UseVisualStyleBackColor = true;
            this.buttonAddCity.Click += new System.EventHandler(this.buttonAddCity_Click_1);
            // 
            // buttonPlanTrip
            // 
            this.buttonPlanTrip.Location = new System.Drawing.Point(5, 53);
            this.buttonPlanTrip.Name = "buttonPlanTrip";
            this.buttonPlanTrip.Size = new System.Drawing.Size(167, 23);
            this.buttonPlanTrip.TabIndex = 3;
            this.buttonPlanTrip.Text = "Запланувати подорож";
            this.buttonPlanTrip.UseVisualStyleBackColor = true;
            this.buttonPlanTrip.Click += new System.EventHandler(this.buttonPlanTrip_Click_1);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(178, 27);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(236, 20);
            this.outputTextBox.TabIndex = 4;
            this.outputTextBox.Text = "Оберіть місто зі списку!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Оберіть місто для подорожі";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введіть місто яке хочете додати";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 196);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.buttonPlanTrip);
            this.Controls.Add(this.buttonAddCity);
            this.Controls.Add(this.textBoxNewCity);
            this.Controls.Add(this.comboBoxCities);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.TextBox textBoxNewCity;
        private System.Windows.Forms.Button buttonAddCity;
        private System.Windows.Forms.Button buttonPlanTrip;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

