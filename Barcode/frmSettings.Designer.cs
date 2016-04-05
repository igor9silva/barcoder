namespace BarcodeGenerator
{
    partial class frmSettings
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
            this.txtAutoSaveLocation = new System.Windows.Forms.TextBox();
            this.txtDefaultSaveLocation = new System.Windows.Forms.TextBox();
            this.cmbDefaultImageFormat = new System.Windows.Forms.ComboBox();
            this.lblDefaultImageFormat = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAutoSaveLocationLoad = new System.Windows.Forms.Button();
            this.btnDefaultSaveLocationLoad = new System.Windows.Forms.Button();
            this.lblAutoSaveLocation = new System.Windows.Forms.Label();
            this.lblDefaultSaveLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAutoSaveLocation
            // 
            this.txtAutoSaveLocation.Font = new System.Drawing.Font("Moire Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSaveLocation.Location = new System.Drawing.Point(12, 39);
            this.txtAutoSaveLocation.MaxLength = 0;
            this.txtAutoSaveLocation.Name = "txtAutoSaveLocation";
            this.txtAutoSaveLocation.ReadOnly = true;
            this.txtAutoSaveLocation.Size = new System.Drawing.Size(313, 30);
            this.txtAutoSaveLocation.TabIndex = 3;
            this.txtAutoSaveLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAutoSaveLocation.TextChanged += new System.EventHandler(this.txtAutoSaveLocation_TextChanged);
            // 
            // txtDefaultSaveLocation
            // 
            this.txtDefaultSaveLocation.Font = new System.Drawing.Font("Moire Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultSaveLocation.Location = new System.Drawing.Point(12, 107);
            this.txtDefaultSaveLocation.MaxLength = 0;
            this.txtDefaultSaveLocation.Name = "txtDefaultSaveLocation";
            this.txtDefaultSaveLocation.ReadOnly = true;
            this.txtDefaultSaveLocation.Size = new System.Drawing.Size(313, 30);
            this.txtDefaultSaveLocation.TabIndex = 4;
            this.txtDefaultSaveLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDefaultSaveLocation.TextChanged += new System.EventHandler(this.txtDefaultSaveLocation_TextChanged);
            // 
            // cmbDefaultImageFormat
            // 
            this.cmbDefaultImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefaultImageFormat.Font = new System.Drawing.Font("Moire Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDefaultImageFormat.FormattingEnabled = true;
            this.cmbDefaultImageFormat.Items.AddRange(new object[] {
            ".jpg (JPEG)",
            ".bmp (BITMAP)",
            ".png (PNG)",
            ".tif (TIFF)",
            ".gif (GIF)"});
            this.cmbDefaultImageFormat.Location = new System.Drawing.Point(172, 167);
            this.cmbDefaultImageFormat.Name = "cmbDefaultImageFormat";
            this.cmbDefaultImageFormat.Size = new System.Drawing.Size(180, 31);
            this.cmbDefaultImageFormat.TabIndex = 6;
            this.cmbDefaultImageFormat.TextChanged += new System.EventHandler(this.cmbDefaultImageFormat_TextChanged);
            // 
            // lblDefaultImageFormat
            // 
            this.lblDefaultImageFormat.Font = new System.Drawing.Font("Miramonte", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultImageFormat.Location = new System.Drawing.Point(9, 167);
            this.lblDefaultImageFormat.Name = "lblDefaultImageFormat";
            this.lblDefaultImageFormat.Size = new System.Drawing.Size(157, 31);
            this.lblDefaultImageFormat.TabIndex = 7;
            this.lblDefaultImageFormat.Text = "Tipo de imagem:";
            this.lblDefaultImageFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.Font = new System.Drawing.Font("Miramonte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(187, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Font = new System.Drawing.Font("Miramonte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAutoSaveLocationLoad
            // 
            this.btnAutoSaveLocationLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoSaveLocationLoad.Location = new System.Drawing.Point(332, 39);
            this.btnAutoSaveLocationLoad.Name = "btnAutoSaveLocationLoad";
            this.btnAutoSaveLocationLoad.Size = new System.Drawing.Size(25, 30);
            this.btnAutoSaveLocationLoad.TabIndex = 10;
            this.btnAutoSaveLocationLoad.Text = "...";
            this.btnAutoSaveLocationLoad.UseVisualStyleBackColor = true;
            this.btnAutoSaveLocationLoad.Click += new System.EventHandler(this.btnAutoSaveLocationLoad_Click);
            // 
            // btnDefaultSaveLocationLoad
            // 
            this.btnDefaultSaveLocationLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaultSaveLocationLoad.Location = new System.Drawing.Point(332, 107);
            this.btnDefaultSaveLocationLoad.Name = "btnDefaultSaveLocationLoad";
            this.btnDefaultSaveLocationLoad.Size = new System.Drawing.Size(25, 30);
            this.btnDefaultSaveLocationLoad.TabIndex = 11;
            this.btnDefaultSaveLocationLoad.Text = "...";
            this.btnDefaultSaveLocationLoad.UseVisualStyleBackColor = true;
            this.btnDefaultSaveLocationLoad.Click += new System.EventHandler(this.btnDefaultSaveLocationLoad_Click);
            // 
            // lblAutoSaveLocation
            // 
            this.lblAutoSaveLocation.Font = new System.Drawing.Font("Miramonte", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoSaveLocation.Location = new System.Drawing.Point(9, 9);
            this.lblAutoSaveLocation.Name = "lblAutoSaveLocation";
            this.lblAutoSaveLocation.Size = new System.Drawing.Size(344, 31);
            this.lblAutoSaveLocation.TabIndex = 12;
            this.lblAutoSaveLocation.Text = "Salvamento automático em:";
            this.lblAutoSaveLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDefaultSaveLocation
            // 
            this.lblDefaultSaveLocation.Font = new System.Drawing.Font("Miramonte", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultSaveLocation.Location = new System.Drawing.Point(9, 78);
            this.lblDefaultSaveLocation.Name = "lblDefaultSaveLocation";
            this.lblDefaultSaveLocation.Size = new System.Drawing.Size(344, 31);
            this.lblDefaultSaveLocation.TabIndex = 13;
            this.lblDefaultSaveLocation.Text = "Local padrão para salvar manualmente:";
            this.lblDefaultSaveLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 291);
            this.Controls.Add(this.txtAutoSaveLocation);
            this.Controls.Add(this.lblAutoSaveLocation);
            this.Controls.Add(this.btnDefaultSaveLocationLoad);
            this.Controls.Add(this.btnAutoSaveLocationLoad);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDefaultImageFormat);
            this.Controls.Add(this.cmbDefaultImageFormat);
            this.Controls.Add(this.txtDefaultSaveLocation);
            this.Controls.Add(this.lblDefaultSaveLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferências";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAutoSaveLocation;
        private System.Windows.Forms.TextBox txtDefaultSaveLocation;
        private System.Windows.Forms.ComboBox cmbDefaultImageFormat;
        private System.Windows.Forms.Label lblDefaultImageFormat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAutoSaveLocationLoad;
        private System.Windows.Forms.Button btnDefaultSaveLocationLoad;
        private System.Windows.Forms.Label lblAutoSaveLocation;
        private System.Windows.Forms.Label lblDefaultSaveLocation;
    }
}