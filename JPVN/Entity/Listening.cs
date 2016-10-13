using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPVN.Entity
{
    class Listening
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string link;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        private int idLession;

        public int IdLession
        {
            get { return idLession; }
            set { idLession = value; }
        }

        public Listening(int id, string title, string link, string text, int idLession)
        {
            this.ID = id;
            this.Title = title;
            this.Link = link;
            this.Text = text;
            this.IdLession = idLession;
        }
        
    }
}
