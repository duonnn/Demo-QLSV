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
    public partial class Thongtinsinhvien : Form
    {
        //thiết lập kết nối tới nguồn dữ liệu
        SqlConnection connection;//Tạo đối tượng connection
        //thực thi các câu lệnh truy vấn với nguồn dữ liệu từ một Connection
        SqlCommand command;
        string str = @"Data Source=THIEN-AN;Initial Catalog=QUANLYSINHVIEN1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();//Khai báo đối tượng Adapter để Fill dữ liệu vào DataSet
        DataTable table = new DataTable();

        public Thongtinsinhvien()
        {
            InitializeComponent();
        }
       
       
        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SinhVien";//truyền vào câu lệnh SQL
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);//đổ dữ liệu từ nguồn dữ liệu vào DataSet
            dgvSinhVien.DataSource = table;//Gắn dữ liệu từ DataSet lên DataGridView
        }

        private void Thongtinsinhvien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Close();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtTen.Text = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            txtNgaysinh.Text = dgvSinhVien.CurrentRow.Cells[1].Value.ToString();
            txtMsv.Text = dgvSinhVien.CurrentRow.Cells[2].Value.ToString();
            cbbGioitinh.Text = dgvSinhVien.CurrentRow.Cells[3].Value.ToString();
            txtDienthoai.Text = dgvSinhVien.CurrentRow.Cells[4].Value.ToString();
            txtDiachi.Text = dgvSinhVien.CurrentRow.Cells[5].Value.ToString();
            txtTenlop.Text = dgvSinhVien.CurrentRow.Cells[6].Value.ToString();
            cbbTenkhoa.Text = dgvSinhVien.CurrentRow.Cells[7].Value.ToString();
            txtTennganh.Text = dgvSinhVien.CurrentRow.Cells[8].Value.ToString();
            cbbHedaotao.Text = dgvSinhVien.CurrentRow.Cells[9].Value.ToString();
            txtKhoahoc.Text = dgvSinhVien.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            //cung cấp chuỗi truy vấn
            command.CommandText = "INSERT INTO SinhVien(Hoten, Ngaysinh, MaSV, Gioitinh, Diachi, Dienthoai, Tenlop, Tenkhoa, Tennganh, Khoahoc, Hedaotao) VALUES(N'" + txtTen.Text + "', N'" + txtNgaysinh.Text + "', N'" + txtMsv.Text + "', N'" + cbbGioitinh.Text + "', N'" + txtDiachi.Text + "', N'" + txtDienthoai.Text + "', N'" + txtTenlop.Text + "', N'" + cbbTenkhoa.Text + "', N'" + txtTennganh.Text + "',  N'" + txtKhoahoc.Text + "', N'" + cbbHedaotao.Text + "') ";
            command.ExecuteNonQuery();//thi hành truy vấn - không cần trả về dữ liệu gì
            loaddata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM SinhVien WHERE MaSV = '" + txtMsv.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE SinhVien SET Hoten = N'" + txtTen.Text + "', Ngaysinh = N'" + txtNgaysinh.Text + "', Gioitinh = N'" + cbbGioitinh.Text + "', Diachi = N'" + txtDiachi.Text + "', Dienthoai = N'" + txtDienthoai.Text + "', Tenlop = N'" + txtTenlop.Text + "', Tenkhoa = N'" + cbbTenkhoa.Text + "', Tennganh = N'" + txtTennganh.Text + "', Hedaotao = N'" + cbbHedaotao.Text + "', Khoahoc = N'" + txtKhoahoc.Text + "' WHERE MaSV = '" + txtMsv.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();          
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SinhVien WHERE MaSV = '" + txt_timkiem.Text + "' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvSinhVien.DataSource = table;
            
        }
    }
}
