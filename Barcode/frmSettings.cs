using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeGenerator
{
    public partial class frmSettings : Form
    {
        Settings settings;

        #region Constructor
        public frmSettings(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;

            this.txtAutoSaveLocation.Text = settings.AutoSaveLocation;
            this.txtDefaultSaveLocation.Text = settings.DefaultSaveLocation;
            if (this.settings.DefaultImageFormat == ImageFormat.Jpeg)
                cmbDefaultImageFormat.SelectedIndex = 0;
            else if (this.settings.DefaultImageFormat == ImageFormat.Bmp)
                cmbDefaultImageFormat.SelectedIndex = 1;
            else if (this.settings.DefaultImageFormat == ImageFormat.Png)
                cmbDefaultImageFormat.SelectedIndex = 2;
            else if (this.settings.DefaultImageFormat == ImageFormat.Tiff)
                cmbDefaultImageFormat.SelectedIndex = 3;
            else
                cmbDefaultImageFormat.SelectedIndex = 4;
        }
        #endregion

        #region Events

        #region Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.settings.SaveSettings();
            this.Close();
        }
        #endregion

        #region Cancel Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.settings.LoadSettings();
            this.Close();
        }
        #endregion

        #region Form Closing
        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                if (MessageBox.Show("Deseja salvar as preferências?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    this.settings.SaveSettings();
                else
                    this.settings.LoadSettings();
        }
        #endregion

        #region TextBox AutoSaveLocation TextChanged
        private void txtAutoSaveLocation_TextChanged(object sender, EventArgs e)
        {
            this.settings.AutoSaveLocation = txtAutoSaveLocation.Text;
        }
        #endregion

        #region TextBox DefaultSaveLocation TextChanged
        private void txtDefaultSaveLocation_TextChanged(object sender, EventArgs e)
        {
            this.settings.DefaultSaveLocation = txtDefaultSaveLocation.Text;
        }
        #endregion

        #region TextBox DefaultImageFormat TextChanged
        private void cmbDefaultImageFormat_TextChanged(object sender, EventArgs e)
        {
            switch (cmbDefaultImageFormat.SelectedIndex)
            {
                case 0: // JPG
                    this.settings.DefaultImageFormat = ImageFormat.Jpeg;
                    break;
                case 1: // BMP
                    this.settings.DefaultImageFormat = ImageFormat.Bmp;
                    break;
                case 2: // PNG
                    this.settings.DefaultImageFormat = ImageFormat.Png;
                    break;
                case 3: // TIFF
                    this.settings.DefaultImageFormat = ImageFormat.Tiff;
                    break;
                case 4: // GIF
                    this.settings.DefaultImageFormat = ImageFormat.Gif;
                    break;
            }
        }
        #endregion

        #region AutoSaveLocationLoad Button Click
        private void btnAutoSaveLocationLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = txtAutoSaveLocation.Text;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtAutoSaveLocation.Text = dialog.SelectedPath + "\\";
        }
        #endregion

        #region DefaultSaveLocationLoad Button Click
        private void btnDefaultSaveLocationLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = txtDefaultSaveLocation.Text;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtDefaultSaveLocation.Text = dialog.SelectedPath + "\\";
        }
        #endregion

        #endregion
    }
}
