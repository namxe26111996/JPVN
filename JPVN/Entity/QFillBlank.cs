using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPVN.Entity
{
    class QFillBlank
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private string answer;

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        private int idType;

        public int IdType
        {
            get { return idType; }
            set { idType = value; }
        }
        private int idAudio;

        public int IdAudio
        {
            get { return idAudio; }
            set { idAudio = value; }
        }

        public QFillBlank(int id, string txt, string asw, int type, int audio)
        {
            this.ID = id;
            this.Text = txt;
            this.IdType = type;
            this.IdAudio = audio;
            this.Answer = asw;
        }

    }
}
