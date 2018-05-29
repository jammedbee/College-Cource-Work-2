namespace TravelAgencyWinForms
{
    partial class WindowHotelActions
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNightCost = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.comboBoxFoodType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNightCost)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(83, 93);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(139, 25);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(83, 126);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(139, 25);
            this.textBoxAddress.TabIndex = 1;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.InitialImage = global::TravelAgencyWinForms.Properties.Resources.CharacterMap_20180529143059;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(228, 93);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(231, 222);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 2;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.Location = new System.Drawing.Point(177, 159);
            this.numericUpDownRating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRating.Name = "numericUpDownRating";
            this.numericUpDownRating.Size = new System.Drawing.Size(45, 25);
            this.numericUpDownRating.TabIndex = 3;
            // 
            // numericUpDownNightCost
            // 
            this.numericUpDownNightCost.DecimalPlaces = 2;
            this.numericUpDownNightCost.Location = new System.Drawing.Point(82, 192);
            this.numericUpDownNightCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownNightCost.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownNightCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNightCost.Name = "numericUpDownNightCost";
            this.numericUpDownNightCost.Size = new System.Drawing.Size(140, 25);
            this.numericUpDownNightCost.TabIndex = 4;
            this.numericUpDownNightCost.ThousandsSeparator = true;
            this.numericUpDownNightCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 457);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(216, 30);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(12, 457);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 30);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(244, 457);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(216, 30);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadImage.Location = new System.Drawing.Point(424, 323);
            this.buttonUploadImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(35, 30);
            this.buttonUploadImage.TabIndex = 8;
            this.buttonUploadImage.Text = "";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // comboBoxFoodType
            // 
            this.comboBoxFoodType.FormattingEnabled = true;
            this.comboBoxFoodType.Location = new System.Drawing.Point(98, 225);
            this.comboBoxFoodType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxFoodType.Name = "comboBoxFoodType";
            this.comboBoxFoodType.Size = new System.Drawing.Size(124, 25);
            this.comboBoxFoodType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Рейтинг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Тип питания";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(63, 258);
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(159, 25);
            this.comboBoxCity.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Город";
            // 
            // WindowHotelActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFoodType);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.numericUpDownNightCost);
            this.Controls.Add(this.numericUpDownRating);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WindowHotelActions";
            this.Text = "WindowHotelActions";
            this.Load += new System.EventHandler(this.WindowHotelActions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNightCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.NumericUpDown numericUpDownNightCost;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.ComboBox comboBoxFoodType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label6;
    }
}