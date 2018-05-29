namespace TravelAgencyWinForms
{
    partial class WindowPassportActions
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
            this.textBoxPassportNumber = new System.Windows.Forms.TextBox();
            this.textBoxAuthority = new System.Windows.Forms.TextBox();
            this.dateTimePickerIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxAuthorityCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonEditNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassportNumber
            // 
            this.textBoxPassportNumber.Location = new System.Drawing.Point(119, 88);
            this.textBoxPassportNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassportNumber.Name = "textBoxPassportNumber";
            this.textBoxPassportNumber.Size = new System.Drawing.Size(233, 25);
            this.textBoxPassportNumber.TabIndex = 0;
            // 
            // textBoxAuthority
            // 
            this.textBoxAuthority.Location = new System.Drawing.Point(119, 130);
            this.textBoxAuthority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAuthority.Name = "textBoxAuthority";
            this.textBoxAuthority.Size = new System.Drawing.Size(233, 25);
            this.textBoxAuthority.TabIndex = 1;
            // 
            // dateTimePickerIssueDate
            // 
            this.dateTimePickerIssueDate.Location = new System.Drawing.Point(119, 182);
            this.dateTimePickerIssueDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
            this.dateTimePickerIssueDate.Size = new System.Drawing.Size(233, 25);
            this.dateTimePickerIssueDate.TabIndex = 2;
            // 
            // dateTimePickerExpirationDate
            // 
            this.dateTimePickerExpirationDate.Location = new System.Drawing.Point(119, 238);
            this.dateTimePickerExpirationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerExpirationDate.Name = "dateTimePickerExpirationDate";
            this.dateTimePickerExpirationDate.Size = new System.Drawing.Size(233, 25);
            this.dateTimePickerExpirationDate.TabIndex = 3;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(119, 297);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(233, 25);
            this.comboBoxType.TabIndex = 4;
            // 
            // comboBoxAuthorityCountry
            // 
            this.comboBoxAuthorityCountry.FormattingEnabled = true;
            this.comboBoxAuthorityCountry.Location = new System.Drawing.Point(119, 344);
            this.comboBoxAuthorityCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAuthorityCountry.Name = "comboBoxAuthorityCountry";
            this.comboBoxAuthorityCountry.Size = new System.Drawing.Size(233, 25);
            this.comboBoxAuthorityCountry.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кем выдан";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Действителен с";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Действителен до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Гос-во выдачи";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 456);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(340, 30);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 456);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(340, 30);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 494);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(340, 30);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonEditNumber
            // 
            this.buttonEditNumber.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditNumber.Location = new System.Drawing.Point(93, 88);
            this.buttonEditNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditNumber.Name = "buttonEditNumber";
            this.buttonEditNumber.Size = new System.Drawing.Size(20, 26);
            this.buttonEditNumber.TabIndex = 15;
            this.buttonEditNumber.Text = "";
            this.buttonEditNumber.UseVisualStyleBackColor = true;
            this.buttonEditNumber.Click += new System.EventHandler(this.buttonEditNumber_Click);
            // 
            // WindowPassportActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 537);
            this.Controls.Add(this.buttonEditNumber);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAuthorityCountry);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.dateTimePickerExpirationDate);
            this.Controls.Add(this.dateTimePickerIssueDate);
            this.Controls.Add(this.textBoxAuthority);
            this.Controls.Add(this.textBoxPassportNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WindowPassportActions";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassportNumber;
        private System.Windows.Forms.TextBox textBoxAuthority;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpirationDate;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxAuthorityCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonEditNumber;
    }
}