using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDQLTC
{
    public partial class Setting : Form
    {
        private Account account;
        private QLDanhMuc qLDanhMuc;
        public Setting()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (qLDanhMuc != null && qLDanhMuc.Visible)
            {
                qLDanhMuc.Hide();
            }    
            if (account == null || !account.Visible)
            {
                account = new Account();
                account.TopLevel = false;
                account.FormBorderStyle = FormBorderStyle.None;
                account.Location = new Point(0, 50);
                this.Controls.Add(account);
                account.Show();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (account != null && account.Visible)
            {
                account.Hide();
            } 

            if (qLDanhMuc == null || !qLDanhMuc.Visible)
            {
                qLDanhMuc = new QLDanhMuc();
                qLDanhMuc.TopLevel = false;
                qLDanhMuc.FormBorderStyle = FormBorderStyle.None;
                qLDanhMuc.Location = new Point(0, 50);
                this.Controls.Add(qLDanhMuc);
                qLDanhMuc.Show();
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }
    }
}
