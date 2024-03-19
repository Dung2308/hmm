using hmm.Models;

namespace hmm
{
    public partial class Form1 : Form
    {
        private hmmContext dbcontext = new hmmContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup signup = new signup();
            signup.ShowDialog();
        }

        private void fgpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fgpass fapass = new fgpass();
            fapass.ShowDialog();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {

            bool found = false; 
            List<Taikhoan> danhsachtaikhoan = dbcontext.Taikhoans.ToList();
            foreach (Taikhoan taikhoan in danhsachtaikhoan)
            {
                if (txtus.Text == taikhoan.Usn && txtpass.Text == taikhoan.Pass)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    found = true; 
                    break; 
                }
            }

            if (!found) 
            {
                MessageBox.Show("Đăng nhập thất bại");
            }


        }

        private void txtus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}