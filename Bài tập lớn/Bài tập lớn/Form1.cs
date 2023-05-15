using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Bài_tập_lớn
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            custom();
            random = new Random();
        }

        private Button currentButton;
        private Random random;
        private int tmpIndex;

        private Color SelectColor()
        {
            int index = random.Next(ColorTheme.colorList.Count);
            while (tmpIndex == index)
            {
                random.Next(ColorTheme.colorList.Count);
            }
            tmpIndex = index;
            string color = ColorTheme.colorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousButton in pnl_menu_qltt.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(35, 32, 39);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control previousButton in pnl_diem.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(35, 32, 39);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            hidePanl();
            DisableButton();
            DialogResult rl = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rl == DialogResult.Yes)
            {
                Login fmlogin = new Login();
                fmlogin.Show();
                this.Hide();
            }
        }
        private void custom()
        {
            pnl_menu_qltt.Visible = false;
            pnl_diem.Visible = false;
        }
        private void hidePanl()
        {
            if (pnl_menu_qltt.Visible == true)
            {
                pnl_menu_qltt.Visible = false;
            }
            if (pnl_diem.Visible == true)
            {
                pnl_diem.Visible = false;
            }
        }
        private void showPanl(Panel pnl)
        {
            if (pnl.Visible == false)
            {
                hidePanl();
                pnl.Visible = true;
            }
            else
            {
                pnl.Visible = false;
            }
        }
        private Form activeForm = null;
        private void openchildform(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnl_hien_thi_ttin.Controls.Add(childform);
            pnl_hien_thi_ttin.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void btn_qltt_Click(object sender, EventArgs e)
        {
            showPanl(pnl_menu_qltt);
            DisableButton();
        }

        private void btn_bdiem_Click(object sender, EventArgs e)
        {
            showPanl(pnl_diem);
            DisableButton();
        }

        private void btn_hphi_Click(object sender, EventArgs e)
        {
            DisableButton();
            openchildform(new Hocphi());

        }

        private void btn_qltt_sv_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openchildform(new Thongtinsinhvien());
        }
        private void cNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openchildform(new Thong_tin_tai_khoan());
        }

        private void btn_qltt_gv_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openchildform(new Quanlygiangvien());
        }

        private void btn_qltt_khoa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openchildform(new Danhmuckhoa());
        }

        private void btn_diem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openchildform(new Bang_diem_sv());
        }


        private void btn_diem_tlai_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            openchildform(new Danhsachthilai());
        }

        private void btn_no_hphi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void maxiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.btn_logout_Click(sender, e);
        }

        private void bảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openchildform(new Bang_diem_sv());
        }

        private void kPMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openchildform(new Doi_mk());
        }


        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openchildform(new Thongtinsinhvien());
        }

        private void nNAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openchildform(new Monhoc());
        }

        private void aTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openchildform(new Danhmuckhoa());
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openchildform(new Quanlygiangvien());
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openchildform(new ThongkeSV());
        }

        private void côngNghệThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
