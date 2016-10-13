using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPVN.Entity
{
    class Lession
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string urlImage;

        public string UrlImage
        {
            get { return urlImage; }
            set { urlImage = value; }
        }

        public Lession(int id,string content,string url)
        {
            this.ID = id;
            this.Content = content;
            this.UrlImage = url;
        }
        
    }
}
