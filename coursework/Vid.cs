using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class Vid : Form
    {
        Details one;
        public Vid()
        {
            InitializeComponent();
            one = new Details();
            vid_new.Visible = true;
            label1.Visible = true;
            Sohr.Click += Sohr_ClicSohr;
        }
        public Vid(int id)
        {
            InitializeComponent();
            vid_form.Visible = true;
            _id.Visible = true;         
            one = new Details(id);
            _id.Text = one.id.ToString();
            name.Text = one.nazv;
            vid_form.Text = one.vid;
            opisanie_.Text = one.opisanie;
            Sohr.Click += Redakt_Click;
        }

        private void Sohr_ClicSohr(object sender, EventArgs e)
        {
            one.nazv = name.Text;
            string v= vid_new.Text;
            one.vid = v;
            one.opisanie = opisanie_.Text;
            one.Save();
        }

        private void Redakt_Click(object sender, EventArgs e)
        {
            one.id = Convert.ToInt32(_id.Text);
            one.nazv = name.Text;
            one.vid = vid_form.Text;
            one.opisanie = opisanie_.Text;
            one.Save();
        }
    }
}
