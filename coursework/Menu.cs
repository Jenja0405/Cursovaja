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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void FillData()
        {
            dataGridView1.DataSource = FILE_WORK.ReadTable();
            dataGridView1.AutoSize = false;
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }
        private void adrFile_Click(object sender, EventArgs e)
        {
            DialogResult rez = openFileDialog1.ShowDialog();
            if (rez == DialogResult.OK)
            {
                adres_file.Text = openFileDialog1.FileName;
                FILE_WORK.adr_file = openFileDialog1.FileName;
                FillData();

            }
            Delete.Visible = true;
        }
       
        private void Poisk_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataView).RowFilter = String.Format("[Название] LIKE '%{0}%'", Poisk.Text.Trim());
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Vid novoe = new Vid(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            novoe.ShowDialog();
            FillData();
        }
        private void New_Click(object sender, EventArgs e)
        {
            Vid novoe = new Vid();
            novoe.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int ind = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            FILE_WORK.Delete(ind);
            dataGridView1.DataSource = FILE_WORK.ReadTable();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FILE_WORK.ReadTable();
        }
    }
}
