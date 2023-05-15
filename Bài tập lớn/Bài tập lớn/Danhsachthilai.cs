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
    public partial class Danhsachthilai : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=THIEN-AN;Initial Catalog=QUANLYSINHVIEN1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Danhsachthilai()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select SinhVien.MaSV,SinhVien.Hoten,SinhVien.Tenkhoa,SinhVien.Khoahoc,SinhVien.Tenlop,BangDiem.Monhoc,Diemthilai,Lanthi\r\nfrom SinhVien inner join BangDiem \r\non SinhVien.MaSV = BangDiem.MaSV \r\ninner join ThiLai\r\non BangDiem.Mabangdiem = ThiLai.Mabangdiem;";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtGr_bang_diem.DataSource = table;
        }

        private void cbb_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

        }


        private void Danhsachthilai_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();          
        }

        private void dtGr_bang_diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masv.Text = dtGr_bang_diem.CurrentRow.Cells[0].Value.ToString();
            txt_hoten.Text = dtGr_bang_diem.CurrentRow.Cells[1].Value.ToString();
            cbb_khoa.Text = dtGr_bang_diem.CurrentRow.Cells[2].Value.ToString();
            cbb_khoa_hoc.Text = dtGr_bang_diem.CurrentRow.Cells[3].Value.ToString();
            cbb_lop.Text = dtGr_bang_diem.CurrentRow.Cells[4].Value.ToString();
            cbb_mon_hoc.Text = dtGr_bang_diem.CurrentRow.Cells[5].Value.ToString();
            txt_dthi.Text = dtGr_bang_diem.CurrentRow.Cells[6].Value.ToString();
            txt_lan_thi.Text = dtGr_bang_diem.CurrentRow.Cells[7].Value.ToString();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO SinhVien(MaSV, Hoten, Tenkhoa, Khoahoc, Tenlop) VALUES(N'" + txt_masv.Text + "', N'" + txt_hoten.Text + "', N'" + cbb_khoa.Text + "', N'" + cbb_khoa_hoc.Text + "', N'" + cbb_lop.Text + "') ";
            command.CommandText = "INSERT INTO BangDiem(Monhoc) VALUES(N'" + cbb_mon_hoc.Text + "') ";
            command.CommandText = "INSERT INTO Thilai(Diemthilai, Lanthi) VALUES(N'" + txt_dthi.Text + "', N'" + txt_lan_thi.Text + "') ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE SinhVien SET Hoten = N'" + txt_hoten.Text + "', Tenkhoa = N'" + cbb_khoa.Text + "', Khoahoc = N'" + cbb_khoa_hoc.Text + "', Tenlop = N'" + cbb_lop.Text + "' WHERE MaSV = '" + txt_masv.Text + "'  ";
            command.CommandText = "UPDATE BangDiem SET Monhoc = N'" + cbb_mon_hoc.Text + "' WHERE MaSV = '" + txt_masv.Text + "'  ";
            command.CommandText = "UPDATE ThiLai SET Diemthilai = N'" + txt_dthi.Text + "', Lanthi = N'" + txt_lan_thi.Text + "' WHERE MaSV = '" + txt_masv.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM SinhVien WHERE MaSV = '" + txt_masv.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_masv.Clear();
            txt_hoten.Clear();
            txt_dthi.Clear();
            txt_lan_thi.Clear();
            txtTimkiem.Clear();
            cbb_khoa.Text = "";
            cbb_khoa_hoc.Text = "";
            cbb_lop.Text = "";
            cbb_mon_hoc.Text = "";

        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select SinhVien.MaSV,SinhVien.Hoten,SinhVien.Tenkhoa,SinhVien.Khoahoc,SinhVien.Tenlop,BangDiem.Monhoc,Diemthilai,Lanthi\r\nfrom SinhVien inner join BangDiem \r\non SinhVien.MaSV = BangDiem.MaSV \r\ninner join ThiLai\r\non BangDiem.Mabangdiem = ThiLai.Mabangdiem; WHERE MaSV = '" + txtTimkiem.Text + "' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtGr_bang_diem.DataSource = table;
        }
    }
}
