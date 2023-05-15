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
    public partial class Monhoc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=THIEN-AN;Initial Catalog=QUANLYSINHVIEN1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Monhoc()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select Mamon,Tenmon,Sotinchi,BangDiem.Hocky,Khoa.Makhoa,GiangVien.MaGV\r\nfrom MonHoc\r\ninner join BangDiem on MonHoc.Mabangdiem = BangDiem.Mabangdiem\r\ninner join Khoa on MonHoc.Makhoa = Khoa.Makhoa\r\ninner join GiangVien on MonHoc.MaGV = GiangVien.MaGV;";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgrMON.DataSource = table;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO MonHoc(Mamon, Tenmon, Sotinchi) VALUES(N'" + txtMaMon.Text + "', N'" + txtTenMon.Text + "', N'" + txtSTC.Text + "') ";
            command.CommandText = "INSERT INTO BangDiem(Hocky) VALUES(N'" + cbbHocky.Text + "') ";
            command.CommandText = "INSERT INTO Khoa(Makhoa) VALUES(N'" + txtKhoa.Text + "') "; 
            command.CommandText = "INSERT INTO GiangVien(MaGV) VALUES(N'" + txtGV.Text + "') ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void Monhoc_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }


        private void dgrMON_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Text = dgrMON.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = dgrMON.CurrentRow.Cells[1].Value.ToString();
            txtSTC.Text = dgrMON.CurrentRow.Cells[2].Value.ToString();
            txtGV.Text = dgrMON.CurrentRow.Cells[5].Value.ToString();
            cbbHocky.Text = dgrMON.CurrentRow.Cells[3].Value.ToString();
            txtKhoa.Text = dgrMON.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE MonHoc SET Tenmon = N'" + txtTenMon.Text + "', Sotinchi = N'" + txtSTC.Text + "' WHERE Mamon = '" + txtMaMon.Text + "'  ";
            command.CommandText = "UPDATE BangDiem SET Hocky = N'" + cbbHocky.Text +  "' WHERE Mamon = '" + txtMaMon.Text + "'  ";
            command.CommandText = "UPDATE Khoa SET Makhoa = N'" + txtKhoa.Text + "' WHERE Mamon = '" + txtMaMon.Text + "'  ";
            command.CommandText = "UPDATE GiangVien SET MaGV = N'" + txtGV.Text + "' WHERE Mamon = '" + txtMaMon.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM MonHoc WHERE Mamon = '" + txtMaMon.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Close();
        }
    }
}
