namespace TravelAgencyWinForms
{
    partial class WindowRoutes
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
            this.dataGridViewRoutes = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRoutes
            // 
            this.dataGridViewRoutes.AllowUserToAddRows = false;
            this.dataGridViewRoutes.AllowUserToDeleteRows = false;
            this.dataGridViewRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRoutes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoutes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRoutes.Location = new System.Drawing.Point(14, 16);
            this.dataGridViewRoutes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewRoutes.Name = "dataGridViewRoutes";
            this.dataGridViewRoutes.Size = new System.Drawing.Size(735, 313);
            this.dataGridViewRoutes.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(631, 336);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(36, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(673, 336);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(36, 30);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(715, 336);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(36, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // WindowRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 417);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewRoutes);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WindowRoutes";
            this.Text = "Маршруты";
            this.Load += new System.EventHandler(this.WindowRoutes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRoutes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}