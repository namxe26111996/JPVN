using JPVN.Bussiness;
using JPVN.DataAccess;
using JPVN.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPVN
{
    public partial class LetterForm : Form
    {
        private WMPLib.WindowsMediaPlayer playerH = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer playerK = new WMPLib.WindowsMediaPlayer();
        private DataConnect _da = new DataConnect();
        private ArrayList _lstHira = new ArrayList();
        private ArrayList _lstKata = new ArrayList();
        private int _indexH = 0 , _indexK=0;
        private int numberLetter = 0;  //number letter begin
        private ManageFunction management = new ManageFunction();
        public LetterForm()
        {
            InitializeComponent();
            //get number letter in config if ==0  load from database else skip connect
            string numberLetterString = ConfigurationManager.AppSettings["NumberLetter"].ToString();
            numberLetter = int.Parse(numberLetterString);
            if (_da.connect())
            {
                MessageBox.Show("Connect success!");  
                _lstHira = _da.getAllLeter(1);               
                _lstKata = _da.getAllLeter(2);
              
                             
            }
            else
                MessageBox.Show("Please connect with internet or change proxy");
            //if (numberLetter != 0)
            //{
               
            //}
            //else
            //{
            //    _lstHira.Clear();
            //    _lstHira.AddRange(management.loadConfig(1));
            //    _lstKata.Clear();
            //    _lstKata.AddRange(management.loadConfig(2));
            //}

            //first will load data to list from database ... then use list to fill data to form
            //1 is load hiragana   indexH is index of letter
            management.saveConfig(_lstHira);
            management.saveConfig(_lstKata);
        }



        private void LetterForm_Load(object sender, EventArgs e)
        {
            loadData(_indexH,_lstHira);
            loadData(_indexK,_lstKata);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






        /// <summary>
        /// Load data form Letter Hiragana of list 
        /// </summary>
        /// <param name="index">index of letter in list</param>
        public void loadData(int index,ArrayList lst)
        {
            //if coder input index outof range size ... this method will be return
            if (index < 0 || index >= lst.Count)
                return;

            Letter letter = (Letter)lst[index];

            //1 is hiragana 2 katakana
            if (letter.TYPE == 1)
            {
                txtSymbolH.Text = letter.Symbol;
                txtRomanjH.Text = letter.ROMANJ;
                picImageH.ImageLocation = letter.URLIMAGE;
                picImageH.SizeMode = PictureBoxSizeMode.StretchImage;
                playerH.URL = letter.URLAUDIO; // Đường dẫn đến file cần chơi
            }
            else if (letter.TYPE == 2)
            {
                txtSymbolK.Text = letter.Symbol;
                txtRomanjK.Text = letter.ROMANJ;
                pictureImageK.ImageLocation = letter.URLIMAGE;
                pictureImageK.SizeMode = PictureBoxSizeMode.StretchImage;
                playerK.URL = letter.URLAUDIO; // Đường dẫn đến file cần chơi
            }
            Refresh();
        }


    


        private void btnNextH_Click(object sender, EventArgs e)
        {   //increament index by 1 and check index in range if size list or NOT
            _indexH++;
            if (_indexH < 0)
                _indexH = 0;
            if (_indexH >= _lstHira.Count)
            {
                _indexH = _lstHira.Count - 1;
            }


            loadData(_indexH,_lstHira);
        }

        private void btnPrevH_Click(object sender, EventArgs e)
        {
            //Decreament index by 1 and check index in range if size list or NOT
            _indexH--;
            if (_indexH < 0)
                _indexH = 0;
            if (_indexH >= _lstHira.Count)
            {
                _indexH = _lstHira.Count - 1;
            }


            loadData(_indexH,_lstHira);
        }

        private void pictureSpeaker_Click(object sender, EventArgs e)
        {
            playerH.controls.play();
        }

        private void pictureSpeakerK_Click(object sender, EventArgs e)
        {
            playerK.controls.play();
        }

        private void btnPrevK_Click(object sender, EventArgs e)
        {
            _indexK--;
            if (_indexK < 0)
                _indexK = 0;
            if (_indexK >= _lstKata.Count)
            {
                _indexK = _lstKata.Count - 1;
            }


            loadData(_indexK, _lstKata);
        }

        private void btnNextK_Click(object sender, EventArgs e)
        {
            _indexK++;
            if (_indexK < 0)
                _indexK = 0;
            if (_indexK >= _lstKata.Count)
            {
                _indexK = _lstKata.Count - 1;
            }


            loadData(_indexK, _lstKata);
        }
    }
}
