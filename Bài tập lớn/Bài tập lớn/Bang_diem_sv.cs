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
using Microsoft.VisualBasic;

namespace Bài_tập_lớn
{
    public partial class Bang_diem_sv : Form

    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=THIEN-AN;Initial Catalog=QUANLYSINHVIEN1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Bang_diem_sv()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT SinhVien.MaSV,SinhVien.Hoten,SinhVien.Tenkhoa,SinhVien.Khoahoc,SinhVien.Tenlop,BangDiem.Monhoc,BangDiem.Hocky,BangDiem.DiemX,BangDiem.DiemY,BangDiem.Diemtongket,BangDiem.Hanhkiem,BangDiem.Trangthai\r\nFROM SinhVien,BangDiem\r\nWHERE SinhVien.MaSV=BangDiem.MaSV;";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtGr_BangDiem.DataSource = table;
        }

        private void cbb_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT SinhVien.MaSV,SinhVien.Hoten,SinhVien.Tenkhoa,SinhVien.Khoahoc,SinhVien.Tenlop,BangDiem.Monhoc,BangDiem.Hocky,BangDiem.DiemX,BangDiem.DiemY,BangDiem.Diemtongket,BangDiem.Hanhkiem,BangDiem.Trangthai\r\nFROM SinhVien,BangDiem\r\nWHERE SinhVien.MaSV=BangDiem.MaSV WHERE MaSV = '" + txt_timkiem.Text + "' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtGr_BangDiem.DataSource = table;
        }
      

        private void btn_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO SinhVien(Hoten, MaSV, Tenlop, Tenkhoa, Khoahoc) VALUES(N'" + txt_hoten.Text + "', N'" + txt_masv.Text + "', N'" + cbb_lop.Text + "', N'" + cbb_khoa.Text + "', N'" + cbb_khoa_hoc.Text + "') ";
            command.CommandText = "INSERT INTO BangDiem(Monhoc, Hocky, DiemX, DiemY, Diemtongket, Hanhkiem, Trangthai) VALUES(N'" + cbb_mon_hoc.Text + "', N'" + cbb_hoc_ki.Text + "', N'" + txt_diemX.Text + "', N'" + txt_diemY.Text + "', N'" + txt_dtk.Text + "', N'" + cbb_hanh_kiem.Text + "', N'" + txt_trangthai.Text + "') ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void Bang_diem_sv_Load(object sender, EventArgs e)
        {

            connection = new SqlConnection(str);
            connection.Open();
            loaddata();          
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            txt_masv.Clear();
            txt_dtk.Clear();
            txt_hoten.Clear();
            txt_diemX.Clear();
            txt_diemY.Clear();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE SinhVien SET Hoten = N'" + txt_hoten.Text + "', Tenlop = N'" + cbb_lop.Text + "', Tenkhoa = N'" + cbb_khoa.Text + "', Khoahoc = N'" + cbb_khoa_hoc.Text + "' WHERE MaSV = '" + txt_masv.Text + "'  ";
            command.CommandText = "UPDATE BangDiem SET Monhoc = N'" + cbb_mon_hoc.Text + "', Hocky = N'" + cbb_hoc_ki.Text + "', DiemX = N'" + txt_diemX.Text + "', DiemY = N'" + txt_diemY.Text + "', Diemtongket = N'" + txt_dtk.Text + "', Trangthai = N'" + txt_trangthai.Text + "', Hanhkiem = N'" + cbb_hanh_kiem.Text + "' WHERE MaSV = '" + txt_masv.Text + "'  ";
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

        private void dtGr_BangDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masv.Text = dtGr_BangDiem.CurrentRow.Cells[0].Value.ToString();
            txt_hoten.Text = dtGr_BangDiem.CurrentRow.Cells[1].Value.ToString();
            cbb_khoa.Text = dtGr_BangDiem.CurrentRow.Cells[2].Value.ToString();
            cbb_khoa_hoc.Text = dtGr_BangDiem.CurrentRow.Cells[3].Value.ToString();
            cbb_lop.Text = dtGr_BangDiem.CurrentRow.Cells[4].Value.ToString();
            cbb_mon_hoc.Text = dtGr_BangDiem.CurrentRow.Cells[5].Value.ToString();
            cbb_hoc_ki.Text = dtGr_BangDiem.CurrentRow.Cells[6].Value.ToString();
            txt_diemX.Text = dtGr_BangDiem.CurrentRow.Cells[7].Value.ToString();
            txt_diemY.Text = dtGr_BangDiem.CurrentRow.Cells[8].Value.ToString();
            txt_dtk.Text = dtGr_BangDiem.CurrentRow.Cells[9].Value.ToString();
            cbb_hanh_kiem.Text = dtGr_BangDiem.CurrentRow.Cells[10].Value.ToString();
            txt_trangthai.Text = dtGr_BangDiem.CurrentRow.Cells[11].Value.ToString();
        }
    } 
}
