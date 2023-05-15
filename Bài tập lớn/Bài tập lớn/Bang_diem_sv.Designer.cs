namespace Bài_tập_lớn
{
    partial class Bang_diem_sv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_mon_hoc = new System.Windows.Forms.ComboBox();
            this.cbb_hoc_ki = new System.Windows.Forms.ComboBox();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.cbb_khoa_hoc = new System.Windows.Forms.ComboBox();
            this.cbb_khoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_tk = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_trangthai = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_dtk = new System.Windows.Forms.TextBox();
            this.txt_diemY = new System.Windows.Forms.TextBox();
            this.txt_diemX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_hanh_kiem = new System.Windows.Forms.ComboBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtGr_BangDiem = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemtongket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hanhkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGr_BangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(519, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG ĐIỂM SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_mon_hoc);
            this.groupBox1.Controls.Add(this.cbb_hoc_ki);
            this.groupBox1.Controls.Add(this.cbb_lop);
            this.groupBox1.Controls.Add(this.cbb_khoa_hoc);
            this.groupBox1.Controls.Add(this.cbb_khoa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(696, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cbb_mon_hoc
            // 
            this.cbb_mon_hoc.FormattingEnabled = true;
            this.cbb_mon_hoc.Items.AddRange(new object[] {
            "Lập trình Windows",
            "Cơ sở dữ liệu",
            "Lập trình C"});
            this.cbb_mon_hoc.Location = new System.Drawing.Point(168, 229);
            this.cbb_mon_hoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_mon_hoc.Name = "cbb_mon_hoc";
            this.cbb_mon_hoc.Size = new System.Drawing.Size(500, 41);
            this.cbb_mon_hoc.TabIndex = 9;
            // 
            // cbb_hoc_ki
            // 
            this.cbb_hoc_ki.FormattingEnabled = true;
            this.cbb_hoc_ki.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbb_hoc_ki.Location = new System.Drawing.Point(546, 170);
            this.cbb_hoc_ki.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_hoc_ki.Name = "cbb_hoc_ki";
            this.cbb_hoc_ki.Size = new System.Drawing.Size(122, 41);
            this.cbb_hoc_ki.TabIndex = 8;
            // 
            // cbb_lop
            // 
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Items.AddRange(new object[] {
            "CNT62DH",
            "TTM62DH",
            "KPM62DH"});
            this.cbb_lop.Location = new System.Drawing.Point(168, 170);
            this.cbb_lop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(193, 41);
            this.cbb_lop.TabIndex = 7;
            // 
            // cbb_khoa_hoc
            // 
            this.cbb_khoa_hoc.FormattingEnabled = true;
            this.cbb_khoa_hoc.Items.AddRange(new object[] {
            "K59",
            "K60",
            "K61",
            "K62",
            "K63"});
            this.cbb_khoa_hoc.Location = new System.Drawing.Point(168, 110);
            this.cbb_khoa_hoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_khoa_hoc.Name = "cbb_khoa_hoc";
            this.cbb_khoa_hoc.Size = new System.Drawing.Size(500, 41);
            this.cbb_khoa_hoc.TabIndex = 6;
            // 
            // cbb_khoa
            // 
            this.cbb_khoa.FormattingEnabled = true;
            this.cbb_khoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Ngoại ngữ",
            "Hàng hải"});
            this.cbb_khoa.Location = new System.Drawing.Point(168, 41);
            this.cbb_khoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_khoa.Name = "cbb_khoa";
            this.cbb_khoa.Size = new System.Drawing.Size(500, 41);
            this.cbb_khoa.TabIndex = 5;
            this.cbb_khoa.SelectedIndexChanged += new System.EventHandler(this.cbb_khoa_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Học kì";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khoá học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoa";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_in);
            this.groupBox2.Controls.Add(this.btn_tk);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(731, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(760, 285);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btn_reset
            // 
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_reset.Image = global::Bài_tập_lớn.Properties.Resources.icons8_reset_32;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(46, 174);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(151, 75);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_in
            // 
            this.btn_in.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_in.Image = global::Bài_tập_lớn.Properties.Resources.icons8_print_32;
            this.btn_in.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_in.Location = new System.Drawing.Point(590, 170);
            this.btn_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(143, 75);
            this.btn_in.TabIndex = 4;
            this.btn_in.Text = "In ";
            this.btn_in.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_in.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // btn_tk
            // 
            this.btn_tk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_tk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_tk.Image = global::Bài_tập_lớn.Properties.Resources.icons8_search_32;
            this.btn_tk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tk.Location = new System.Drawing.Point(312, 170);
            this.btn_tk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(173, 75);
            this.btn_tk.TabIndex = 3;
            this.btn_tk.Text = "Tìm kiếm";
            this.btn_tk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tk.UseVisualStyleBackColor = true;
            this.btn_tk.Click += new System.EventHandler(this.btn_tk_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_xoa.Image = global::Bài_tập_lớn.Properties.Resources.icons8_delete_32;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(590, 54);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(143, 75);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_sua.Image = global::Bài_tập_lớn.Properties.Resources.icons8_hand_with_pen_32;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(312, 54);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(166, 75);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_them.Image = global::Bài_tập_lớn.Properties.Resources.icons8_add_new_32;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(46, 54);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(151, 75);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_trangthai);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_dtk);
            this.groupBox3.Controls.Add(this.txt_diemY);
            this.groupBox3.Controls.Add(this.txt_diemX);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbb_hanh_kiem);
            this.groupBox3.Controls.Add(this.txt_hoten);
            this.groupBox3.Controls.Add(this.txt_masv);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(9, 468);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1482, 176);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.Location = new System.Drawing.Point(1265, 120);
            this.txt_trangthai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(190, 39);
            this.txt_trangthai.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1106, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 33);
            this.label13.TabIndex = 12;
            this.label13.Text = "Trạng thái";
            // 
            // txt_dtk
            // 
            this.txt_dtk.Location = new System.Drawing.Point(964, 124);
            this.txt_dtk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dtk.Name = "txt_dtk";
            this.txt_dtk.Size = new System.Drawing.Size(96, 39);
            this.txt_dtk.TabIndex = 11;
            // 
            // txt_diemY
            // 
            this.txt_diemY.Location = new System.Drawing.Point(551, 127);
            this.txt_diemY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_diemY.Name = "txt_diemY";
            this.txt_diemY.Size = new System.Drawing.Size(117, 39);
            this.txt_diemY.TabIndex = 10;
            // 
            // txt_diemX
            // 
            this.txt_diemX.Location = new System.Drawing.Point(240, 120);
            this.txt_diemX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_diemX.Name = "txt_diemX";
            this.txt_diemX.Size = new System.Drawing.Size(140, 39);
            this.txt_diemX.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(747, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 33);
            this.label12.TabIndex = 8;
            this.label12.Text = "Điểm tổng kết";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Điểm Y";
            // 
            // cbb_hanh_kiem
            // 
            this.cbb_hanh_kiem.FormattingEnabled = true;
            this.cbb_hanh_kiem.Items.AddRange(new object[] {
            "Tốt",
            "Yếu",
            "Kém",
            "Trung bình"});
            this.cbb_hanh_kiem.Location = new System.Drawing.Point(1219, 43);
            this.cbb_hanh_kiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_hanh_kiem.Name = "cbb_hanh_kiem";
            this.cbb_hanh_kiem.Size = new System.Drawing.Size(236, 41);
            this.cbb_hanh_kiem.TabIndex = 6;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(655, 43);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(301, 39);
            this.txt_hoten.TabIndex = 5;
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(240, 43);
            this.txt_masv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(140, 39);
            this.txt_masv.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "Điểm X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 33);
            this.label9.TabIndex = 2;
            this.label9.Text = "Họ và tên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1028, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 33);
            this.label10.TabIndex = 1;
            this.label10.Text = "Hạnh kiểm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 33);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã sinh viên";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtGr_BangDiem);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.groupBox4.Location = new System.Drawing.Point(9, 652);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(1482, 299);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dtGr_BangDiem
            // 
            this.dtGr_BangDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtGr_BangDiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGr_BangDiem.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dtGr_BangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGr_BangDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.Hoten,
            this.Tenkhoa,
            this.Khoahoc,
            this.Tenlop,
            this.Monhoc,
            this.Hocky,
            this.DiemX,
            this.DiemY,
            this.Diemtongket,
            this.Hanhkiem,
            this.Trangthai});
            this.dtGr_BangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGr_BangDiem.Location = new System.Drawing.Point(3, 36);
            this.dtGr_BangDiem.Name = "dtGr_BangDiem";
            this.dtGr_BangDiem.RowHeadersWidth = 62;
            this.dtGr_BangDiem.Size = new System.Drawing.Size(1476, 259);
            this.dtGr_BangDiem.TabIndex = 0;
            this.dtGr_BangDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGr_BangDiem_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 8;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 195;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.MinimumWidth = 8;
            this.Hoten.Name = "Hoten";
            this.Hoten.Width = 125;
            // 
            // Tenkhoa
            // 
            this.Tenkhoa.DataPropertyName = "Tenkhoa";
            this.Tenkhoa.HeaderText = "Khoa";
            this.Tenkhoa.MinimumWidth = 8;
            this.Tenkhoa.Name = "Tenkhoa";
            this.Tenkhoa.Width = 110;
            // 
            // Khoahoc
            // 
            this.Khoahoc.DataPropertyName = "Khoahoc";
            this.Khoahoc.HeaderText = "Khóa học";
            this.Khoahoc.MinimumWidth = 8;
            this.Khoahoc.Name = "Khoahoc";
            this.Khoahoc.Width = 157;
            // 
            // Tenlop
            // 
            this.Tenlop.DataPropertyName = "Tenlop";
            this.Tenlop.HeaderText = "Lớp";
            this.Tenlop.MinimumWidth = 8;
            this.Tenlop.Name = "Tenlop";
            this.Tenlop.Width = 96;
            // 
            // Monhoc
            // 
            this.Monhoc.DataPropertyName = "Monhoc";
            this.Monhoc.HeaderText = "Môn học";
            this.Monhoc.MinimumWidth = 8;
            this.Monhoc.Name = "Monhoc";
            this.Monhoc.Width = 151;
            // 
            // Hocky
            // 
            this.Hocky.DataPropertyName = "Hocky";
            this.Hocky.HeaderText = "Học kỳ";
            this.Hocky.MinimumWidth = 8;
            this.Hocky.Name = "Hocky";
            this.Hocky.Width = 130;
            // 
            // DiemX
            // 
            this.DiemX.DataPropertyName = "DiemX";
            this.DiemX.HeaderText = "Điểm X";
            this.DiemX.MinimumWidth = 8;
            this.DiemX.Name = "DiemX";
            this.DiemX.Width = 138;
            // 
            // DiemY
            // 
            this.DiemY.DataPropertyName = "DiemY";
            this.DiemY.HeaderText = "Điểm Y";
            this.DiemY.MinimumWidth = 8;
            this.DiemY.Name = "DiemY";
            this.DiemY.Width = 137;
            // 
            // Diemtongket
            // 
            this.Diemtongket.DataPropertyName = "Diemtongket";
            this.Diemtongket.HeaderText = "Điểm tổng kết";
            this.Diemtongket.MinimumWidth = 8;
            this.Diemtongket.Name = "Diemtongket";
            this.Diemtongket.Width = 208;
            // 
            // Hanhkiem
            // 
            this.Hanhkiem.DataPropertyName = "Hanhkiem";
            this.Hanhkiem.HeaderText = "Hạnh kiểm";
            this.Hanhkiem.MinimumWidth = 8;
            this.Hanhkiem.Name = "Hanhkiem";
            this.Hanhkiem.Width = 171;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.MinimumWidth = 8;
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.Width = 163;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bài_tập_lớn.Properties.Resources.Biểu_trưng_Trường_đại_học_Hàng_hải_Việt_Nam_svg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(12, 386);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(1479, 75);
            this.txt_timkiem.TabIndex = 14;
            // 
            // Bang_diem_sv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1517, 990);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bang_diem_sv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bang_diem_sv";
            this.Load += new System.EventHandler(this.Bang_diem_sv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGr_BangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_mon_hoc;
        private System.Windows.Forms.ComboBox cbb_hoc_ki;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.ComboBox cbb_khoa_hoc;
        private System.Windows.Forms.ComboBox cbb_khoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_dtk;
        private System.Windows.Forms.TextBox txt_diemY;
        private System.Windows.Forms.TextBox txt_diemX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_hanh_kiem;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_tk;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DataGridView dtGr_BangDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoahoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemtongket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hanhkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.TextBox txt_trangthai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_timkiem;
    }
}