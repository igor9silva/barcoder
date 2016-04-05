namespace BarcodeGenerator
{
    partial class frmGeradorEtiqueta
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
            this.components = new System.ComponentModel.Container();
            this.stripStatus = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblStatus = new System.Windows.Forms.ToolStripLabel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.menuImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemSaveImageAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.stripStatus.SuspendLayout();
            this.menuImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // stripStatus
            // 
            this.stripStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.lblStatus});
            this.stripStatus.Location = new System.Drawing.Point(0, 266);
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(364, 25);
            this.stripStatus.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(150, 22);
            this.toolStripLabel1.Text = "Versão 1.0.0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 22);
            this.lblStatus.Text = "         Escrito por Igor Silva";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Moire", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(40, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(300, 32);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código do produto";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Moire", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(88, 56);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 30);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // menuImage
            // 
            this.menuImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSaveImageAs});
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(196, 26);
            // 
            // itemSaveImageAs
            // 
            this.itemSaveImageAs.Image = global::BarcodeGenerator.Properties.Resources.save;
            this.itemSaveImageAs.Name = "itemSaveImageAs";
            this.itemSaveImageAs.Size = new System.Drawing.Size(195, 22);
            this.itemSaveImageAs.Text = "Salvar imagem como...";
            this.itemSaveImageAs.Click += new System.EventHandler(this.itemSaveImageAs_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::BarcodeGenerator.Properties.Resources.settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(336, 8);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(20, 20);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Enter += new System.EventHandler(this.btnSettings_Enter);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackgroundImage = global::BarcodeGenerator.Properties.Resources.save;
            this.btnSaveFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFile.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSaveFile.FlatAppearance.BorderSize = 0;
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFile.Location = new System.Drawing.Point(12, 8);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(20, 20);
            this.btnSaveFile.TabIndex = 0;
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            this.btnSaveFile.Enter += new System.EventHandler(this.btnSettings_Enter);
            this.btnSaveFile.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // picBarcode
            // 
            this.picBarcode.ContextMenuStrip = this.menuImage;
            this.picBarcode.Location = new System.Drawing.Point(40, 105);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(300, 150);
            this.picBarcode.TabIndex = 0;
            this.picBarcode.TabStop = false;
            this.picBarcode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBarcode_MouseMove);
            // 
            // frmGeradorEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 291);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.stripStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGeradorEtiqueta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de código de barras";
            this.stripStatus.ResumeLayout(false);
            this.stripStatus.PerformLayout();
            this.menuImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip stripStatus;
        private System.Windows.Forms.ToolStripLabel lblStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.ContextMenuStrip menuImage;
        private System.Windows.Forms.ToolStripMenuItem itemSaveImageAs;
        private System.Windows.Forms.Button btnSettings;


    }
}

