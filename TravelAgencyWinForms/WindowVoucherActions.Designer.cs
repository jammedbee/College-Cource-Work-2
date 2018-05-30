namespace TravelAgencyWinForms
{
    partial class WindowVoucherActions
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
            this.dateTimePickerDepart = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRouteID = new System.Windows.Forms.ComboBox();
            this.comboBoxHotelID = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerDepart
            // 
            this.dateTimePickerDepart.Location = new System.Drawing.Point(133, 93);
            this.dateTimePickerDepart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDepart.Name = "dateTimePickerDepart";
            this.dateTimePickerDepart.Size = new System.Drawing.Size(233, 25);
            this.dateTimePickerDepart.TabIndex = 0;
            // 
            // comboBoxRouteID
            // 
            this.comboBoxRouteID.FormattingEnabled = true;
            this.comboBoxRouteID.Location = new System.Drawing.Point(133, 141);
            this.comboBoxRouteID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxRouteID.Name = "comboBoxRouteID";
            this.comboBoxRouteID.Size = new System.Drawing.Size(233, 25);
            this.comboBoxRouteID.TabIndex = 1;
            this.comboBoxRouteID.SelectionChangeCommitted += new System.EventHandler(this.comboBoxRouteID_SelectionChangeCommitted);
            // 
            // comboBoxHotelID
            // 
            this.comboBoxHotelID.FormattingEnabled = true;
            this.comboBoxHotelID.Location = new System.Drawing.Point(133, 177);
            this.comboBoxHotelID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxHotelID.Name = "comboBoxHotelID";
            this.comboBoxHotelID.Size = new System.Drawing.Size(233, 25);
            this.comboBoxHotelID.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(133, 220);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(233, 25);
            this.textBoxPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата отправления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Код маршрута";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Код отеля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цена";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(14, 303);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(350, 34);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(14, 303);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(350, 35);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(14, 347);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(350, 35);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // WindowVoucherActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 398);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxHotelID);
            this.Controls.Add(this.comboBoxRouteID);
            this.Controls.Add(this.dateTimePickerDepart);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowVoucherActions";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDepart;
        private System.Windows.Forms.ComboBox comboBoxRouteID;
        private System.Windows.Forms.ComboBox comboBoxHotelID;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}