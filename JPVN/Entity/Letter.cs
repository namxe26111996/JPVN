using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPVN.Entity
{
    class Letter
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string romanj;

        public string ROMANJ
        {
            get { return romanj; }
            set { romanj = value; }
        }

        private string urlimage;

        public string URLIMAGE
        {
            get { return urlimage; }
            set { urlimage = value; }
        }

        private string urlAudio;

        public string URLAUDIO
        {
            get { return urlAudio; }
            set { urlAudio = value; }
        }

        private int type;

        public int TYPE
        {
            get { return type; }
            set { type = value; }
        }

        private string symbol;

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public Letter(int id, string symbol, string romanj, string urlimage, string urlaudio, int type)
        {
            this.ID = id;
            this.ROMANJ = romanj;
            this.Symbol = symbol;
            this.URLIMAGE = urlimage;
            this.URLAUDIO = urlaudio;
            this.TYPE = type;
        }

        public Letter(string id, string symbol, string romanj, string urlimage, string urlaudio, string type)
        {   
            this.ID = int.Parse(id);
            this.ROMANJ = romanj;
            this.Symbol = symbol;
            this.URLIMAGE = urlimage;
            this.URLAUDIO = urlaudio;
            this.TYPE = int.Parse(type);
        }
    }
}
