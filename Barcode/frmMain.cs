using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Collections.Specialized;
using System.IO;

namespace BarcodeGenerator
{
    public partial class frmGeradorEtiqueta : Form
    {
        Barcode barcode;
        Settings settings;

        #region Constructor
        public frmGeradorEtiqueta()
        {
            InitializeComponent();
            barcode = new Barcode();
            settings = new Settings();

            txtCodigo.Focus();
            txtCodigo.SelectAll();
        }
        #endregion

        #region Generate Image
        private void Encode()
        {
            try 
            { 
                picBarcode.Image = barcode.Encode(txtCodigo.Text);
                barcode.SaveImage(this.settings.AutoSaveLocation + txtCodigo.Text + FormatToString(this.settings.DefaultImageFormat), this.settings.DefaultImageFormat);
                txtCodigo.Focus();
                txtCodigo.SelectAll();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        #endregion

        #region Events

        #region Save Click
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (picBarcode.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = txtCodigo.Text;
                sfd.InitialDirectory = this.settings.DefaultSaveLocation;
                sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
                
                ImageFormat format = this.settings.DefaultImageFormat;

                if (format == ImageFormat.Bmp)
                    sfd.FilterIndex = 1;
                else if (format == ImageFormat.Gif)
                    sfd.FilterIndex = 2;
                else if (format == ImageFormat.Jpeg)
                    sfd.FilterIndex = 3;
                else if (format == ImageFormat.Png)
                    sfd.FilterIndex = 4;
                else
                    sfd.FilterIndex = 5;

                sfd.AddExtension = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1: format = ImageFormat.Bmp; break;
                        case 2: format = ImageFormat.Gif; break;
                        case 3: format = ImageFormat.Jpeg; break;
                        case 4: format = ImageFormat.Png; break;
                        case 5: format = ImageFormat.Tiff; break;
                    }
                    barcode.SaveImage(sfd.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Gere um código de barras antes de salvá-lo!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                txtCodigo.SelectAll();
            }
        }
        #endregion

        #region Settings Click
        private void btnSettings_Click(object sender, EventArgs e)
        {
            new frmSettings(this.settings).ShowDialog();
        }
        #endregion

        #region Right Mouse Save Click
        private void itemSaveImageAs_Click(object sender, EventArgs e)
        {
            btnSaveFile_Click(sender, e);
        }
        #endregion

        #region Text Código TextChanged
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 13)
                this.Encode();
        }
        #endregion

        #endregion

        #region Data Consistancy

        #region TextBox Código KeyPress
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ModifierKeys.HasFlag(Keys.Control))
            {
                if (!((e.KeyChar > 47 && e.KeyChar < 58) || (e.KeyChar == 8)))
                    e.Handled = true;
            }
            else if (e.KeyChar == 32)
                e.Handled = true;
        }
        #endregion

        #region TextBox Código KeyDown
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCodigo.Text.Length < 13)
                {
                    string text = txtCodigo.Text;
                    while (text.Length < 13)
                        text = "0" + text;
                    txtCodigo.Text = text;
                    this.Encode();
                }
                else
                    btnSaveFile_Click(sender, e);
            }
        }
        #endregion

        #region FormatToString
        private string FormatToString(ImageFormat format)
        {
            if (format == ImageFormat.Jpeg)
                return ".jpg";
            else if (format == ImageFormat.Bmp)
                return ".bmp";
            else if (format == ImageFormat.Gif)
                return ".gif";
            else if (format == ImageFormat.Png)
                return ".png";
            else
                return ".tif";
        }
        #endregion

        #endregion

        #region Drag Out
        private void picBarcode_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender != null && e.Button == MouseButtons.Left)
            {
                if (picBarcode.Image != null)
                {
                    if (!File.Exists(this.settings.AutoSaveLocation + txtCodigo.Text + FormatToString(this.settings.DefaultImageFormat)))
                        barcode.SaveImage(this.settings.AutoSaveLocation + txtCodigo.Text + FormatToString(this.settings.DefaultImageFormat), this.settings.DefaultImageFormat);

                    var stringCol = new StringCollection();
                    stringCol.Add(this.settings.AutoSaveLocation + txtCodigo.Text + FormatToString(this.settings.DefaultImageFormat));
                    DataObject data = new DataObject();
                    data.SetFileDropList(stringCol);

                    picBarcode.DoDragDrop(data, DragDropEffects.Copy);
                }
            }
        }
        #endregion

        #region UI
        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            txtCodigo.Focus();
            txtCodigo.SelectAll();
        }

        private void btnSettings_Enter(object sender, EventArgs e)
        {
            (sender as Button).FlatAppearance.BorderSize = 1;
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            (sender as Button).FlatAppearance.BorderSize = 0;
        }
        #endregion
    }
}
