using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;

namespace Bài_tập_lớn
{
    public partial class Doi_mk : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=THIEN-AN;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True");

        public Doi_mk()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_user.Text = "Tên đăng nhập";
            txt_pass_cu.Text = "Mật khẩu cũ";
            txt_pass_moi.Text = "Mật khẩu mới";
            txt_pass_xn.Text = "Nhập lại mật khẩu";
        }
        
        private void btn_ok_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from TaiKhoan where Tendangnhap = '" + txt_user.Text + "' and Matkhau = N'" + txt_pass_cu.Text + "' ", cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if(txt_pass_moi.Text == txt_pass_xn.Text)
                {
                    SqlDataAdapter adapter1 = new SqlDataAdapter("update TaiKhoan set Matkhau = N'" + txt_pass_moi.Text + "' where Tendangnhap = N'"+ txt_user.Text + "' and Matkhau = N'"+ txt_pass_cu.Text +"' " ,cn);
                    DataTable dtb1 = new DataTable();
                    DataTable dt1 = new DataTable();
                    adapter1.Fill(dtb1);
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.SetError(txt_pass_moi, "Bạn chưa điền mật khẩu");
                    errorProvider1.SetError(txt_pass_xn, "Mật khẩu nhập lại chưa đúng");
                }
            }
            else
            {
                errorProvider1.SetError(txt_user, "Tên người dùng không đúng");
                errorProvider1.SetError(txt_pass_cu, "Mật khẩu cũ không đúng");
            }
        }

        private void txt_user_Click(object sender, EventArgs e)
        {
            txt_user.Clear();
        }

        private void txt_pass_cu_Click(object sender, EventArgs e)
        {
            txt_pass_cu.Clear();
        }

        private void txt_pass_moi_Click(object sender, EventArgs e)
        {
            txt_pass_moi.Clear();
        }

        private void txt_pass_xn_Click(object sender, EventArgs e)
        {
            txt_pass_xn.Clear();
        }

        private void Doi_mk_Load(object sender, EventArgs e)
        {
        }
    }
}
