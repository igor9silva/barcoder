using System;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BarcodeGenerator
{
    public class Settings
    {
        private string settingsFileName = Application.StartupPath + "\\settings";    
        private JavaScriptSerializer serializer;

        #region Constructor
        public Settings()
        {
            this.serializer = new JavaScriptSerializer();
            bool successfullyLoaded = this.LoadSettings();

            if (!Directory.Exists(autoSaveLocation))
                Directory.CreateDirectory(autoSaveLocation);

            if (!Directory.Exists(defaultSaveLocation))
                Directory.CreateDirectory(defaultSaveLocation);

            if (!successfullyLoaded)
            {
                MessageBox.Show("Erro ao ler as configurações... Voltando para o padrão.");

                this.SaveSettings();
            }
        }
        #endregion

        #region Properties
        private string autoSaveLocation = Application.StartupPath + "\\autosaves\\";
        public string AutoSaveLocation
        {
            get { return autoSaveLocation; }
            set { autoSaveLocation = value; }
        }

        private string defaultSaveLocation = Application.StartupPath + "\\autosaves\\";
        public string DefaultSaveLocation
        {
            get { return defaultSaveLocation; }
            set { defaultSaveLocation = value; }
        }
        
        private ImageFormat defaultImageFormat = ImageFormat.Jpeg;
        public ImageFormat DefaultImageFormat
        {
            get { return defaultImageFormat; }
            set { defaultImageFormat = value; }
        }
        #endregion

        #region Load Settings
        public bool LoadSettings()
        {
            try
            {
                string fileContent = File.ReadAllText(settingsFileName);

                if (fileContent == "missing")
                    this.SaveSettings();
                else
                {
                    List<object> data = this.serializer.Deserialize<List<object>>(fileContent);

                    this.autoSaveLocation = data[0].ToString();
                    this.defaultSaveLocation = data[1].ToString();
                    this.defaultImageFormat = (ImageFormat)(new ImageFormatConverter().ConvertFrom(data[2]));                    
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Save Settings
        public bool SaveSettings()
        {
            try
            {
                object data = new object[] { autoSaveLocation, defaultSaveLocation, defaultImageFormat.ToString() };
                File.WriteAllText(settingsFileName, this.serializer.Serialize(data));

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
