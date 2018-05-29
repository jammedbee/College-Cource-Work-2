namespace TravelAgencyWinForms
{
    partial class WindowClientActions
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPassportNumber = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonEditPassport = new System.Windows.Forms.Button();
            this.buttonNewPassport = new System.Windows.Forms.Button();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(150, 68);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(233, 25);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(150, 273);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(233, 25);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(150, 136);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(233, 25);
            this.textBoxMiddleName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(150, 102);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(233, 25);
            this.textBoxLastName.TabIndex = 1;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(150, 204);
            this.comboBoxSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(233, 25);
            this.comboBoxSex.TabIndex = 4;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(150, 170);
            this.dateTimePickerBirthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(233, 25);
            this.dateTimePickerBirthDate.TabIndex = 3;
            // 
            // textBoxPassportNumber
            // 
            this.textBoxPassportNumber.Location = new System.Drawing.Point(150, 34);
            this.textBoxPassportNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassportNumber.MaxLength = 8;
            this.textBoxPassportNumber.Name = "textBoxPassportNumber";
            this.textBoxPassportNumber.Size = new System.Drawing.Size(234, 25);
            this.textBoxPassportNumber.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 402);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(179, 30);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 402);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(179, 30);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(197, 402);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(187, 30);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Паспорт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Пол";
            // 
            // buttonEditPassport
            // 
            this.buttonEditPassport.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditPassport.Location = new System.Drawing.Point(120, 34);
            this.buttonEditPassport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditPassport.Name = "buttonEditPassport";
            this.buttonEditPassport.Size = new System.Drawing.Size(29, 25);
            this.buttonEditPassport.TabIndex = 11;
            this.buttonEditPassport.Text = "";
            this.buttonEditPassport.UseVisualStyleBackColor = true;
            this.buttonEditPassport.Click += new System.EventHandler(this.buttonEditPassport_Click);
            // 
            // buttonNewPassport
            // 
            this.buttonNewPassport.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewPassport.Location = new System.Drawing.Point(85, 34);
            this.buttonNewPassport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNewPassport.Name = "buttonNewPassport";
            this.buttonNewPassport.Size = new System.Drawing.Size(29, 25);
            this.buttonNewPassport.TabIndex = 10;
            this.buttonNewPassport.Text = "";
            this.buttonNewPassport.UseVisualStyleBackColor = true;
            this.buttonNewPassport.Click += new System.EventHandler(this.buttonNewPassport_Click);
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(150, 240);
            this.maskedTextBoxPhone.Mask = "+0(000)000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(233, 25);
            this.maskedTextBoxPhone.TabIndex = 19;
            // 
            // WindowClientActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 445);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.buttonNewPassport);
            this.Controls.Add(this.buttonEditPassport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPassportNumber);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxFirstName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WindowClientActions";
            this.Text = "WindowClientActions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.TextBox textBoxPassportNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonEditPassport;
        private System.Windows.Forms.Button buttonNewPassport;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
    }
}