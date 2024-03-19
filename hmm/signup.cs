using hmm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hmm
{
    public partial class signup : Form
    {
        
        private hmmContext dbcontext = new hmmContext();
        
        public signup()
        {
            InitializeComponent();
            
        }

        private void btnsu_Click(object sender, EventArgs e)
        {
            Infor infor = new Infor();
            Taikhoan taikhoan = new Taikhoan();
            taikhoan.Usn = txtusns.Text;
            taikhoan.Pass = txtpasss.Text;
            taikhoan.Email = txtemail.Text;
            if(txtpasss.Text != txtpasscheck.Text )
            {
                chck.Text = " password doesnt match!!";
            }
            else
            {
                chck.Text = "";
            }
            dbcontext.Add(taikhoan);
            dbcontext.SaveChanges();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void form1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
