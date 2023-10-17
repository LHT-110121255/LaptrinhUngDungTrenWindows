namespace TTSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            dgvNhanvien = new DataGridView();
            maNV = new DataGridViewTextBoxColumn();
            hoten = new DataGridViewTextBoxColumn();
            namsinh = new DataGridViewTextBoxColumn();
            gioitinh = new DataGridViewTextBoxColumn();
            diachi = new DataGridViewTextBoxColumn();
            dienthoai = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhanvien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(325, 36);
            label1.Name = "label1";
            label1.Size = new Size(458, 42);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN  NHÂN VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 98);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 1;
            label2.Text = "Mã NV";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(452, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(348, 96);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 3;
            label3.Text = "Năm sinh";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(157, 27);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 144);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 5;
            label4.Text = "Họ và tên";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(821, 144);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 27);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(704, 144);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 7;
            label5.Text = "Điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(348, 142);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 9;
            label6.Text = "Giới tính";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            comboBox1.Location = new Point(452, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 31);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Nam";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(821, 98);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(206, 28);
            comboBox2.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(704, 98);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 11;
            label7.Text = "Địa chỉ";
            // 
            // dgvNhanvien
            // 
            dgvNhanvien.AllowUserToAddRows = false;
            dgvNhanvien.AllowUserToDeleteRows = false;
            dgvNhanvien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanvien.Columns.AddRange(new DataGridViewColumn[] { maNV, hoten, namsinh, gioitinh, diachi, dienthoai });
            dgvNhanvien.Location = new Point(12, 191);
            dgvNhanvien.MultiSelect = false;
            dgvNhanvien.Name = "dgvNhanvien";
            dgvNhanvien.ReadOnly = true;
            dgvNhanvien.RowHeadersWidth = 51;
            dgvNhanvien.RowTemplate.Height = 29;
            dgvNhanvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanvien.Size = new Size(1030, 360);
            dgvNhanvien.TabIndex = 13;
            dgvNhanvien.CellContentClick += dgvNhanvien_CellContentClick;
            // 
            // maNV
            // 
            maNV.HeaderText = "Mã NV";
            maNV.MinimumWidth = 6;
            maNV.Name = "maNV";
            maNV.ReadOnly = true;
            maNV.Width = 125;
            // 
            // hoten
            // 
            hoten.HeaderText = "Họ và Tên";
            hoten.MinimumWidth = 6;
            hoten.Name = "hoten";
            hoten.ReadOnly = true;
            hoten.Width = 200;
            // 
            // namsinh
            // 
            namsinh.HeaderText = "Năm Sinh";
            namsinh.MinimumWidth = 6;
            namsinh.Name = "namsinh";
            namsinh.ReadOnly = true;
            namsinh.Width = 125;
            // 
            // gioitinh
            // 
            gioitinh.HeaderText = "Giới Tính";
            gioitinh.MinimumWidth = 6;
            gioitinh.Name = "gioitinh";
            gioitinh.ReadOnly = true;
            gioitinh.Width = 125;
            // 
            // diachi
            // 
            diachi.HeaderText = "Địa Chỉ";
            diachi.MinimumWidth = 6;
            diachi.Name = "diachi";
            diachi.ReadOnly = true;
            diachi.Width = 300;
            // 
            // dienthoai
            // 
            dienthoai.HeaderText = "Điện Thoại";
            dienthoai.MinimumWidth = 6;
            dienthoai.Name = "dienthoai";
            dienthoai.ReadOnly = true;
            dienthoai.Width = 255;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(41, 574);
            button1.Name = "button1";
            button1.Size = new Size(125, 48);
            button1.TabIndex = 14;
            button1.Text = "Tìm Mã";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(182, 574);
            button2.Name = "button2";
            button2.Size = new Size(134, 48);
            button2.TabIndex = 15;
            button2.Text = "Tìm Tên";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(340, 574);
            button3.Name = "button3";
            button3.Size = new Size(125, 48);
            button3.TabIndex = 16;
            button3.Text = "Đếm SL";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(763, 574);
            button4.Name = "button4";
            button4.Size = new Size(103, 48);
            button4.TabIndex = 19;
            button4.Text = "Sửa";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(635, 574);
            button5.Name = "button5";
            button5.Size = new Size(107, 48);
            button5.TabIndex = 18;
            button5.Text = "Xóa";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLight;
            button6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(487, 574);
            button6.Name = "button6";
            button6.Size = new Size(118, 48);
            button6.TabIndex = 17;
            button6.Text = "Thêm";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLight;
            button7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(888, 574);
            button7.Name = "button7";
            button7.Size = new Size(130, 48);
            button7.TabIndex = 20;
            button7.Text = "Thoát";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 574);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(888, 574);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 48);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(763, 574);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 48);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(635, 574);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 48);
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(487, 574);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 48);
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(339, 574);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(49, 48);
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(182, 574);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(51, 48);
            pictureBox7.TabIndex = 27;
            pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 645);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvNhanvien);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Thông tin nhân viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanvien).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label7;
        private DataGridView dgvNhanvien;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private DataGridViewTextBoxColumn maNV;
        private DataGridViewTextBoxColumn hoten;
        private DataGridViewTextBoxColumn namsinh;
        private DataGridViewTextBoxColumn gioitinh;
        private DataGridViewTextBoxColumn diachi;
        private DataGridViewTextBoxColumn dienthoai;
    }
}