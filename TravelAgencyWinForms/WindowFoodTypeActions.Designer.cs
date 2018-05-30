namespace TravelAgencyWinForms
{
    partial class WindowFoodTypeActions
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxTransName = new System.Windows.Forms.TextBox();
            this.textBoxSymbolicName = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 48);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 25);
            this.textBoxName.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 343);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(214, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 343);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(214, 30);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 381);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(215, 30);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxTransName
            // 
            this.textBoxTransName.Location = new System.Drawing.Point(87, 83);
            this.textBoxTransName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTransName.Name = "textBoxTransName";
            this.textBoxTransName.Size = new System.Drawing.Size(140, 25);
            this.textBoxTransName.TabIndex = 4;
            // 
            // textBoxSymbolicName
            // 
            this.textBoxSymbolicName.Location = new System.Drawing.Point(111, 117);
            this.textBoxSymbolicName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSymbolicName.Name = "textBoxSymbolicName";
            this.textBoxSymbolicName.Size = new System.Drawing.Size(116, 25);
            this.textBoxSymbolicName.TabIndex = 5;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(15, 176);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxDescription.MaxLength = 144;
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(212, 97);
            this.richTextBoxDescription.TabIndex = 6;
            this.richTextBoxDescription.Text = "";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 17);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Перевод";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Обозначение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Описание";
            // 
            // WindowFoodTypeActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxSymbolicName);
            this.Controls.Add(this.textBoxTransName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowFoodTypeActions";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowFoodTypeActions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxTransName;
        private System.Windows.Forms.TextBox textBoxSymbolicName;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}