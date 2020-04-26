using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    class Details
    {
        public int id;
        public string nazv;
        public string vid;
        public string opisanie;

        public Details()
        {
            id = 0;
            nazv = "";
            vid = "";
            opisanie = "";

        }
        public Details(int _id)
        {
            string st = FILE_WORK.ReadLine(_id);
            string[] ss = st.Split(';');
            id = Convert.ToInt32(ss[0]);
            nazv = ss[1];
            vid = ss[2];
            opisanie = (ss[3]);
        }
        public void Save()
        {
            FILE_WORK.UpDate(id, nazv, vid, opisanie);
        }
    }
}
