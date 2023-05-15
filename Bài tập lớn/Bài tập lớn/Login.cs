using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;


namespace Bài_tập_lớn
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanBLL tkbll = new TaiKhoanBLL();
        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_user.Text = "Username";
            txt_pass.Text= "Password";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                this.Close();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            taikhoan.Tendangnhap = txt_user.Text;
            taikhoan.Matkhau = txt_pass.Text;
            string getuser = tkbll.CheckLogicBLL(taikhoan);
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "requeid_pass":
                    MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 fmain = new Form1();
            fmain.Show();
            this.Hide();
        }

        private void txt_user_Click(object sender, EventArgs e)
        {
            txt_user.Clear();
            ptb_user.Image = Properties.Resources.icons8_user_32__1_;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txt_user.ForeColor = Color.FromArgb(78, 184, 206);

            ptb_pass.Image = Properties.Resources.icons8_padlock_32;
            panel2.BackColor = Color.WhiteSmoke;
            txt_pass.ForeColor = Color.WhiteSmoke;
        }

        private void txt_pass_Click(object sender, EventArgs e)
        {
            txt_pass.Clear();
            txt_pass.PasswordChar = '*';
            ptb_pass.Image = Properties.Resources.icons8_padlock_32__1_;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txt_pass.ForeColor = Color.FromArgb(78, 184, 206);

            ptb_user.Image = Properties.Resources.icons8_user_32;
            panel1.BackColor = Color.WhiteSmoke;
            txt_user.ForeColor = Color.WhiteSmoke;
        }

    }
}
