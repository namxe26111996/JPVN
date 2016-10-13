using JPVN.Bussiness;
using JPVN.DataAccess;
using JPVN.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPVN
{
    public partial class Study : Form
    {
        private DataConnect _da;
        private ArrayList _lstLession;
        private ManageFunction _manage;
        public Study()
        {
            InitializeComponent();
            _da = new DataConnect();
            _lstLession = new ArrayList();
            _manage = new ManageFunction();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void Study_Load(object sender, EventArgs e)
        {
            if (_da.connect())
            {
                MessageBox.Show("Connect success!");
                _lstLession = _da.getAllLession();
            }
            else
            {
                MessageBox.Show("Please connect with internet or change proxy");
                return;
            }

            // load data lession

            loadListView();
          

        }

        public void loadListView()
        {
            for (int i = 0; i < _lstLession.Count; i++)
            {
                Lession less = (Lession)_lstLession[i];
                int id = less.ID;
                string urlImage = less.UrlImage;
                 Bitmap img = _manage.getImageFromUrl(urlImage);

                
                ListViewItem item = new ListViewItem();
               
                item.Text = "Bài " + id;
                item.SubItems.Add(less.Content);
                if (img == null)
                {
                    MessageBox.Show("Cannot connect internet!");
                    return;
                }
                imageList1.Images.Add(img);
                item.ImageIndex = i;
                   

                
               

                listView1.Items.Add(item);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection itemlist =
        this.listView1.SelectedItems;

            int index = 0;
            foreach (ListViewItem item in itemlist)
            {
                index = item.Index;
                index++;
                if (index == 0)
                    return;
            }
           
            DetailLession detailess = new DetailLession(index);
            this.Hide();
            detailess.ShowDialog();
            this.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }
    }
}
