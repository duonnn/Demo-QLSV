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
    public partial class Danhmuckhoa : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=THIEN-AN;Initial Catalog=QUANLYSINHVIEN1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Danhmuckhoa()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Khoa";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgrKHOA.DataSource = table;
        }

        private void Danhmuckhoa_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }



        private void dgrKHOA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.Text = dgrKHOA.CurrentRow.Cells[0].Value.ToString();
            txtTenKhoa.Text = dgrKHOA.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Khoa(Makhoa,Tenkhoa) VALUES(N'" + txtMaKhoa.Text + "', N'" + txtTenKhoa.Text + "') ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE Khoa SET Tenkhoa = N'" + txtTenKhoa.Text + "' WHERE Makhoa = '" + txtMaKhoa.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Khoa WHERE Makhoa = '" + txtMaKhoa.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
