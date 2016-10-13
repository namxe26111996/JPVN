using JPVN.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPVN.Bussiness
{
    class ManageFunction
    {
        /// <summary>
        /// save Data into config .
        /// </summary>
        /// <param name="letter"></param>
        public void saveConfig(ArrayList _lst)
        {   //save all letter in the config
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            for (int i = 0; i < _lst.Count; i++)
            {
                Letter letter = (Letter)_lst[i];
                config.AppSettings.Settings.Remove("ID" + i);
                config.AppSettings.Settings.Add("ID" + i, letter.ID + "");
                config.AppSettings.Settings.Remove("Romanj" + i);
                config.AppSettings.Settings.Add("Romanj" + i, letter.ROMANJ + "");
                config.AppSettings.Settings.Remove("Symbol" + i);
                config.AppSettings.Settings.Add("Symbol" + i, letter.Symbol + "");
                config.AppSettings.Settings.Remove("UrlImage" + i);
                config.AppSettings.Settings.Add("UrlImage" + i, letter.URLIMAGE + "");
                config.AppSettings.Settings.Remove("UrlAudio" + i);
                config.AppSettings.Settings.Add("UrlAudio" + i, letter.URLAUDIO + "");
                config.AppSettings.Settings.Remove("Type" + i);
                config.AppSettings.Settings.Add("Type" + i, letter.TYPE + "");

                config.Save(ConfigurationSaveMode.Modified);
            }

            config.AppSettings.Settings.Remove("NumberLetter");
            config.AppSettings.Settings.Add("NumberLetter", _lst.Count + "");
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);

        }

        /// <summary>
        /// Load data from config
        /// </summary>
        /// <returns></returns>
        public ArrayList loadConfig(int typeLetter)
        {
            ArrayList lstLetter = new ArrayList();
            string numberLetter = ConfigurationManager.AppSettings["NumberLetter"].ToString();
            int num = int.Parse(numberLetter);
            for (int i = 0; i < num; i++)
            {
                string id = ConfigurationManager.AppSettings["ID" + i].ToString();
                string romanj = ConfigurationManager.AppSettings["Romanj" + i].ToString();
                string symbol = ConfigurationManager.AppSettings["Symbol" + i].ToString();
                string urlImage = ConfigurationManager.AppSettings["UrlImage" + i].ToString();
                string urlAudio = ConfigurationManager.AppSettings["UrlAudio" + i].ToString();
                string type = ConfigurationManager.AppSettings["Type" + i].ToString();
                int checkType = int.Parse(type);
                if (typeLetter == checkType)
                {
                    Letter letter = new Letter(id, symbol, romanj, urlImage, urlAudio, type);
                    lstLetter.Add(letter);
                }
            }
            return lstLetter;
        }

        /// <summary>
        /// get bitmap form url
        /// </summary>
        /// <param name="url"></param>
        /// <returns>bitmap</returns>
        public Bitmap getImageFromUrl(string url)
        {
            Bitmap image ;           
            try
            {
                var request = WebRequest.Create(url);
                
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    image = (Bitmap)Bitmap.FromStream(stream);
                }

            }
            catch
            {
                return null;
            }
            return image;
        }


    }
}
