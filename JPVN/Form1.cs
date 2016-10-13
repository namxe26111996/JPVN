using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using JPVN.DataAccess;

namespace JPVN
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

       

        private void btnLearnLetter_Click(object sender, EventArgs e)
        {   
            LetterForm letter = new LetterForm();
            this.Hide();
            letter.ShowDialog();
            this.Show();
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            Study study = new Study();
            this.Hide();
            study.ShowDialog();
            this.Show();
        }




    }
}
