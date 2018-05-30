namespace TravelAgencyWinForms
{
    partial class WindowVouchers
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
            this.dataGridViewVouchers = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVouchers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVouchers
            // 
            this.dataGridViewVouchers.AllowUserToAddRows = false;
            this.dataGridViewVouchers.AllowUserToDeleteRows = false;
            this.dataGridViewVouchers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVouchers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVouchers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewVouchers.Location = new System.Drawing.Point(14, 16);
            this.dataGridViewVouchers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewVouchers.Name = "dataGridViewVouchers";
            this.dataGridViewVouchers.ReadOnly = true;
            this.dataGridViewVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVouchers.Size = new System.Drawing.Size(905, 375);
            this.dataGridViewVouchers.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(801, 399);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(36, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(843, 399);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(36, 30);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(885, 399);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(36, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // WindowVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewVouchers);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WindowVouchers";
            this.Text = "Путёвки";
            this.Load += new System.EventHandler(this.WindowVouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVouchers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVouchers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
    }
}