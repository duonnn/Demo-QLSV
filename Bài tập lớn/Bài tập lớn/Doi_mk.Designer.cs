namespace Bài_tập_lớn
{
    partial class Doi_mk
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_pass_cu = new System.Windows.Forms.TextBox();
            this.ptb_pass = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_pass_moi = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_pass_xn = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.ptb_user = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bài_tập_lớn.Properties.Resources.Biểu_trưng_Trường_đại_học_Hàng_hải_Việt_Nam_svg;
            this.pictureBox1.Location = new System.Drawing.Point(226, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(114, 444);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 1);
            this.panel2.TabIndex = 10;
            // 
            // txt_pass_cu
            // 
            this.txt_pass_cu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_pass_cu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass_cu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_cu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pass_cu.Location = new System.Drawing.Point(161, 402);
            this.txt_pass_cu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pass_cu.Multiline = true;
            this.txt_pass_cu.Name = "txt_pass_cu";
            this.txt_pass_cu.Size = new System.Drawing.Size(361, 42);
            this.txt_pass_cu.TabIndex = 9;
            this.txt_pass_cu.Text = "Mật khẩu cũ";
            this.txt_pass_cu.Click += new System.EventHandler(this.txt_pass_cu_Click);
            // 
            // ptb_pass
            // 
            this.ptb_pass.Image = global::Bài_tập_lớn.Properties.Resources.icons8_padlock_32;
            this.ptb_pass.Location = new System.Drawing.Point(114, 394);
            this.ptb_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_pass.Name = "ptb_pass";
            this.ptb_pass.Size = new System.Drawing.Size(40, 42);
            this.ptb_pass.TabIndex = 8;
            this.ptb_pass.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(114, 549);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 1);
            this.panel1.TabIndex = 13;
            // 
            // txt_pass_moi
            // 
            this.txt_pass_moi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_pass_moi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass_moi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_moi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pass_moi.Location = new System.Drawing.Point(161, 508);
            this.txt_pass_moi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pass_moi.Multiline = true;
            this.txt_pass_moi.Name = "txt_pass_moi";
            this.txt_pass_moi.Size = new System.Drawing.Size(361, 42);
            this.txt_pass_moi.TabIndex = 12;
            this.txt_pass_moi.Text = "Mật khẩu mới";
            this.txt_pass_moi.Click += new System.EventHandler(this.txt_pass_moi_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bài_tập_lớn.Properties.Resources.icons8_padlock_32;
            this.pictureBox2.Location = new System.Drawing.Point(114, 499);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 42);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(190, 721);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(238, 86);
            this.btn_ok.TabIndex = 14;
            this.btn_ok.Text = "Cập nhật";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_cancel.Location = new System.Drawing.Point(190, 856);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(238, 86);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Hủy bỏ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(114, 655);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 1);
            this.panel3.TabIndex = 16;
            // 
            // txt_pass_xn
            // 
            this.txt_pass_xn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_pass_xn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass_xn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_xn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pass_xn.Location = new System.Drawing.Point(161, 614);
            this.txt_pass_xn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pass_xn.Multiline = true;
            this.txt_pass_xn.Name = "txt_pass_xn";
            this.txt_pass_xn.Size = new System.Drawing.Size(361, 42);
            this.txt_pass_xn.TabIndex = 15;
            this.txt_pass_xn.Text = "Nhập lại mật khẩu";
            this.txt_pass_xn.Click += new System.EventHandler(this.txt_pass_xn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bài_tập_lớn.Properties.Resources.icons8_padlock_32;
            this.pictureBox3.Location = new System.Drawing.Point(114, 605);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 42);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(114, 354);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 1);
            this.panel4.TabIndex = 19;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_user.Location = new System.Drawing.Point(161, 312);
            this.txt_user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(361, 42);
            this.txt_user.TabIndex = 18;
            this.txt_user.Text = "Tên đăng nhập";
            this.txt_user.Click += new System.EventHandler(this.txt_user_Click);
            // 
            // ptb_user
            // 
            this.ptb_user.Image = global::Bài_tập_lớn.Properties.Resources.icons8_user_32;
            this.ptb_user.Location = new System.Drawing.Point(114, 304);
            this.ptb_user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_user.Name = "ptb_user";
            this.ptb_user.Size = new System.Drawing.Size(40, 42);
            this.ptb_user.TabIndex = 17;
            this.ptb_user.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Doi_mk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(637, 1006);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.ptb_user);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_pass_xn);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_pass_moi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_pass_cu);
            this.Controls.Add(this.ptb_pass);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Doi_mk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doi_mk";
            this.Load += new System.EventHandler(this.Doi_mk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_pass_cu;
        private System.Windows.Forms.PictureBox ptb_pass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_pass_moi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_pass_xn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.PictureBox ptb_user;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}