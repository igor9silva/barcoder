using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.IO;
using System.Drawing.Imaging;

namespace BarcodeGenerator
{
    public enum SaveTypes : int { JPG, BMP, PNG, GIF, TIFF, UNSPECIFIED };

    public class Barcode : IDisposable
    {
        #region Variables
        private EAN13 ibarcode = null;
        private string Raw_Data = "";
        private string Encoded_Value = "";
        private Image _Encoded_Image = null;
        private Font LabelFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        private Color ForeColor = Color.Black;
        private Color BackColor = Color.White;        
        private const int Width = 300;
        private const int Height = 150;
        #endregion

        public Barcode() {}

        public string RawData
        {
            get { return Raw_Data; }
            set { Raw_Data = value; }
        }

        #region Encode
        public Image Encode(string StringToEncode)
        {
            Raw_Data = StringToEncode;

            this.Encoded_Value = "";

            ibarcode = new EAN13(Raw_Data);

            this.Encoded_Value = ibarcode.Encoded_Value;
            this.Raw_Data = ibarcode.RawData;

            return (Image)Generate_Image();
        }
        #endregion        

        #region Generate Image
        private Bitmap Generate_Image()
        {
            Bitmap b = null;

            b = new Bitmap(Width, Height);
            int iBarWidth = Width / Encoded_Value.Length;
            int shiftAdjustment = 0;
            int iBarWidthModifier = 1;

            shiftAdjustment = (Width % Encoded_Value.Length) / 2;

            int pos = 0;

            using (Graphics g = Graphics.FromImage(b))
            {
                g.Clear(BackColor);

                using (Pen backpen = new Pen(BackColor, iBarWidth / iBarWidthModifier))
                {
                    using (Pen pen = new Pen(ForeColor, iBarWidth / iBarWidthModifier))
                    {
                        while (pos < Encoded_Value.Length)
                        {
                            if (Encoded_Value[pos] == '1')
                                g.DrawLine(pen, new Point(pos * iBarWidth + shiftAdjustment + (int)(iBarWidth * 0.5), 0), new Point(pos * iBarWidth + shiftAdjustment + (int)(iBarWidth * 0.5), Height));

                            pos++;
                        }
                    }
                }
            }
            Label((Image)b);

            _Encoded_Image = (Image)b;

            return b;
        }
        #endregion

        #region Save Image
        public void SaveImage(string Filename, ImageFormat FileType)
        {
            if (_Encoded_Image != null)
            {
                ((Bitmap)_Encoded_Image).Save(Filename, FileType);
            }
        }
        #endregion

        #region Label Generation
        private Image Label(Image img)
        {
            System.Drawing.Font font = this.LabelFont;

            using (Graphics g = Graphics.FromImage(img))
            {
                g.DrawImage(img, (float)0, (float)0);

                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;

                StringFormat f = new StringFormat();
                f.Alignment = StringAlignment.Near;
                f.LineAlignment = StringAlignment.Near;
                int LabelX = 0;
                int LabelY = 0;

                LabelX = img.Width / 2;
                LabelY = img.Height - (font.Height);
                f.Alignment = StringAlignment.Center;

                //color a background color box at the bottom of the barcode to hold the string of data
                g.FillRectangle(new SolidBrush(this.BackColor), new RectangleF((float)0, (float)LabelY, (float)img.Width, (float)font.Height));

                //draw datastring under the barcode image
                g.DrawString(this.RawData, font, new SolidBrush(this.ForeColor), new RectangleF((float)0, (float)LabelY, (float)img.Width, (float)font.Height), f);

                g.Save();
            }
            return img;
        }

        #endregion

        public void Dispose()
        {
            try {}
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
