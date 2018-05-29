namespace TravelAgencyWinForms
{
    partial class WindowPositionActions
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
            this.textBoxPositionName = new System.Windows.Forms.TextBox();
            this.numericUpDownPositionOverheadPercentage = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionOverheadPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPositionName
            // 
            this.textBoxPositionName.Location = new System.Drawing.Point(121, 62);
            this.textBoxPositionName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPositionName.Name = "textBoxPositionName";
            this.textBoxPositionName.Size = new System.Drawing.Size(139, 25);
            this.textBoxPositionName.TabIndex = 0;
            // 
            // numericUpDownPositionOverheadPercentage
            // 
            this.numericUpDownPositionOverheadPercentage.Location = new System.Drawing.Point(121, 96);
            this.numericUpDownPositionOverheadPercentage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownPositionOverheadPercentage.Name = "numericUpDownPositionOverheadPercentage";
            this.numericUpDownPositionOverheadPercentage.Size = new System.Drawing.Size(62, 25);
            this.numericUpDownPositionOverheadPercentage.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 258);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(304, 30);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 258);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(304, 30);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 296);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(304, 30);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Премиальные";
            // 
            // WindowPositionActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.numericUpDownPositionOverheadPercentage);
            this.Controls.Add(this.textBoxPositionName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WindowPositionActions";
            this.Text = "WindowPositionActions";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionOverheadPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPositionName;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionOverheadPercentage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}