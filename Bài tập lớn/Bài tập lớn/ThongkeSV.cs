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
    public partial class ThongkeSV : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=THIEN-AN;Initial Catalog=QUANLYSINHVIEN1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select SinhVien.MaSV,Hoten,Tenkhoa,Tennganh,Khoahoc,Tenlop,HocPhi.Tinhtrang,HocPhi.Ghichu\r\nfrom SinhVien inner join HocPhi on SinhVien.MaSV = HocPhi.MaSV;";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridDanhsach.DataSource = table;
        }

        public ThongkeSV()
        {
            InitializeComponent();
        }

        private void TimkiemSV_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Close();
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select SinhVien.MaSV,Hoten,Tenkhoa,Tennganh,Khoahoc,Tenlop,HocPhi.Tinhtrang,HocPhi.Ghichu\r\nfrom SinhVien inner join HocPhi on SinhVien.MaSV = HocPhi.MaSV WHERE MaSV = '" + txt_timkiem.Text + "' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridDanhsach.DataSource = table;
        }
    }
}
