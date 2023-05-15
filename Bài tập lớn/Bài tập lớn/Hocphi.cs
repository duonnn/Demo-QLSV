using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bài_tập_lớn
{
    public partial class Hocphi : Form
    {
        
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=THIEN-AN;Initial Catalog=QUANLYSINHVIEN1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select SinhVien.MaSV,SinhVien.Hoten,SinhVien.Tenlop,HocPhi.Hocky,Tinhtrang,Tongtien,Ghichu,TongSTC\r\nfrom HocPhi inner join SinhVien on HocPhi.MaSV = SinhVien.MaSV;\r\n";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridDanhsach.DataSource = table;           

        }

       
        public Hocphi()
        {
            InitializeComponent();
            
        }
      

        private void Hocphi_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO SinhVien(Hoten, MaSV, Tenlop) VALUES(N'" + txtTen.Text + "', N'" + txtMaSV.Text + "', N'" + txtLop.Text + "') ";     
            command.CommandText = "INSERT INTO HocPhi(TongSTC,Hocky,Tinhtrang,Tongtien,Ghichu) VALUES(N'" + txtSotin.Text + "', N'" + cbbHocki.Text + "',  N'" + txtTinhtrang.Text + "',  N'" + txtTongtien.Text + "',  N'" + txtGhichu.Text + "') ";
            command.ExecuteNonQuery();
            loaddata();
        }
        

        private void dataGridDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                txtMaSV.Text = dataGridDanhsach.CurrentRow.Cells[0].Value.ToString();
                txtTen.Text = dataGridDanhsach.CurrentRow.Cells[1].Value.ToString();
                txtLop.Text = dataGridDanhsach.CurrentRow.Cells[2].Value.ToString();
                txtSotin.Text = dataGridDanhsach.CurrentRow.Cells[3].Value.ToString();
                cbbHocki.Text = dataGridDanhsach.CurrentRow.Cells[4].Value.ToString();
                txtTinhtrang.Text = dataGridDanhsach.CurrentRow.Cells[5].Value.ToString();
                txtTongtien.Text = dataGridDanhsach.CurrentRow.Cells[6].Value.ToString();
                txtGhichu.Text = dataGridDanhsach.CurrentRow.Cells[7].Value.ToString();          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE SinhVien SET Hoten = N'" + txtTen.Text + "', Tenlop = N'" + txtLop.Text + "' WHERE MaSV = '" + txtMaSV.Text + "'  ";
            command.CommandText = "UPDATE HocPhi SET TongSTC = N'" + txtSotin.Text + "', Hocky = N'" + cbbHocki.Text + "', Tinhtrang = N'" + txtTinhtrang.Text + "', Ghichu = N'" + txtGhichu.Text + "' WHERE MaSV = '" + txtMaSV.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM HocPhi WHERE MaSV = '" + txtMaSV.Text + "'  ";
                command.ExecuteNonQuery();
                loaddata();
            }
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {

            command = connection.CreateCommand();
            command.CommandText = "select * from SinhVien WHERE MaSV = '" + txtTimkiem.Text + "' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridDanhsach.DataSource = table;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Close();
        }

      
    }
}
