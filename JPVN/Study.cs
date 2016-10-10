using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPVN
{
    public partial class Study : Form
    {
        public Study()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Study_Load(object sender, EventArgs e)
        {
            ImageList iList = new ImageList();
            iList.ImageSize = new Size(70, 70);
            iList.ColorDepth = ColorDepth.Depth32Bit;

            listView1.LargeImageList = iList;
        }
    }
}
