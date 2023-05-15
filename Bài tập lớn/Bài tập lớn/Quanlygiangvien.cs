using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_lớn
{
    public partial class Quanlygiangvien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=THIEN-AN;Initial Catalog=QUANLYSINHVIEN1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Quanlygiangvien()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from GiangVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgrDSGV.DataSource = table;
        }
        private void Quanlygiangvien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }


        private void dgrDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.Text = dgrDSGV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgrDSGV.CurrentRow.Cells[1].Value.ToString();
            cboGioiTinh.Text = dgrDSGV.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgrDSGV.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgrDSGV.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO GiangVien(MaGV,Hoten,Gioitinh,Dienthoai,Email) VALUES(N'" + txtMaGV.Text + "', N'" + txtHoTen.Text + "', N'" + cboGioiTinh.Text + "', N'" + txtSDT.Text + "', N'" + txtEmail.Text + "') ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE GiangVien SET Hoten = N'" + txtHoTen.Text + "', Gioitinh = N'" + cboGioiTinh.Text + "', Dienthoai = N'" + txtSDT.Text + "',  Emaili = N'" + txtEmail.Text + "' WHERE MaGV = '" + txtMaGV.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM SinhVien WHERE MaGV = '" + txtMaGV.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Close();
        }
    }
}
