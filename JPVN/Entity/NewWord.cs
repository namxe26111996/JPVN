using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPVN.Entity
{
    class NewWord
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string symbol;

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        private string romanj;

        public string Romanj
        {
            get { return Romanj; }
            set { Romanj = value; }
        }

        private string urlImage;

        public string UrlImage
        {
            get { return urlImage; }
            set { urlImage = value; }
        }

        private string meaning;

        public string Meaning
        {
            get { return meaning; }
            set { meaning = value; }
        }

        private int idLession;

        public int IdLession
        {
            get { return idLession; }
            set { idLession = value; }
        }

        public NewWord(string id, string symbol, string romanj, string urlimage, string meaning, string idlession)
        {
            this.ID = int.Parse(id);
            this.Symbol = symbol;
            this.Romanj = romanj;
            this.UrlImage = urlimage;
            this.Meaning = meaning;
            this.IdLession = int.Parse(idlession);
        }

    }
}
