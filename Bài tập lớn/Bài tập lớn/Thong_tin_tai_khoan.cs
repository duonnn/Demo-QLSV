using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_lớn
{
    public partial class Thong_tin_tai_khoan : Form
    {
        public Thong_tin_tai_khoan()
        {
            InitializeComponent();
        }

        private void Thong_tin_tai_khoan_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Nguyễn Văn A";
            rbtn_nam.Checked = true;
            textBox2.Text = "Quản trị viên";
        }
    }
}
