using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDQLTC
{
    public partial class QLDanhMuc : Form
    {
        //private QLDMChi qlyChi;
        public QLDanhMuc()
        {
            InitializeComponent();
        }

        private void QLDanhMuc_Load(object sender, EventArgs e)
        {

        }

        private void chiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide(); dataGridView1.Hide();  // Ẩn DataGridView1
            dataGridView2.Show();  // Hiện DataGridView2
        }

        private void thuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Hide();  // Ẩn DataGridView2
            dataGridView1.Show();  // Hiện DataGridView1
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
