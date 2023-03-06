namespace DIP2023_Lvlanh
{
    partial class Frm
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Parameter = new System.Windows.Forms.GroupBox();
            this.lbbar = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.trkC = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBSrc = new System.Windows.Forms.TextBox();
            this.txtGSrc = new System.Windows.Forms.TextBox();
            this.txtRSrc = new System.Windows.Forms.TextBox();
            this.txtYSrc = new System.Windows.Forms.TextBox();
            this.txtXSrc = new System.Windows.Forms.TextBox();
            this.txtBRsl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRRsl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXRsl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYRsl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.picSource = new System.Windows.Forms.PictureBox();
            this.lblImgPath = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtGRsl = new System.Windows.Forms.TextBox();
            this.Image = new System.Windows.Forms.GroupBox();
            this.lbprocess = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdolaplace = new System.Windows.Forms.RadioButton();
            this.rdoloctheok = new System.Windows.Forms.RadioButton();
            this.rdoloctrungvi = new System.Windows.Forms.RadioButton();
            this.rdotrungbinh = new System.Windows.Forms.RadioButton();
            this.rdoamban = new System.Windows.Forms.RadioButton();
            this.rdotuongphan = new System.Windows.Forms.RadioButton();
            this.rdobocum = new System.Windows.Forms.RadioButton();
            this.rdoisodata = new System.Windows.Forms.RadioButton();
            this.rdotachnguong = new System.Windows.Forms.RadioButton();
            this.rdobienanh = new System.Windows.Forms.RadioButton();
            this.rdohistogram = new System.Windows.Forms.RadioButton();
            this.rdoconvert = new System.Windows.Forms.RadioButton();
            this.rdosang = new System.Windows.Forms.RadioButton();
            this.grbHistogram = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.picHistogram = new System.Windows.Forms.PictureBox();
            this.grbmatrix = new System.Windows.Forms.GroupBox();
            this.lbsize = new System.Windows.Forms.Label();
            this.btnrun = new System.Windows.Forms.Button();
            this.btndownsize = new System.Windows.Forms.Button();
            this.btnupsize = new System.Windows.Forms.Button();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.btndownk = new System.Windows.Forms.Button();
            this.btnupk = new System.Windows.Forms.Button();
            this.txtk = new System.Windows.Forms.TextBox();
            this.Parameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            this.Image.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbHistogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistogram)).BeginInit();
            this.grbmatrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // Parameter
            // 
            this.Parameter.Controls.Add(this.lbbar);
            this.Parameter.Controls.Add(this.lblC);
            this.Parameter.Controls.Add(this.trkC);
            this.Parameter.Location = new System.Drawing.Point(12, 482);
            this.Parameter.Name = "Parameter";
            this.Parameter.Size = new System.Drawing.Size(821, 64);
            this.Parameter.TabIndex = 33;
            this.Parameter.TabStop = false;
            // 
            // lbbar
            // 
            this.lbbar.AutoSize = true;
            this.lbbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbar.Location = new System.Drawing.Point(6, 24);
            this.lbbar.Name = "lbbar";
            this.lbbar.Size = new System.Drawing.Size(244, 20);
            this.lbbar.TabIndex = 32;
            this.lbbar.Text = "Trượt thanh độ sáng để thay đổi";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(341, 8);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(36, 38);
            this.lblC.TabIndex = 31;
            this.lblC.Text = "0";
            // 
            // trkC
            // 
            this.trkC.Location = new System.Drawing.Point(443, 8);
            this.trkC.Maximum = 255;
            this.trkC.Minimum = -255;
            this.trkC.Name = "trkC";
            this.trkC.Size = new System.Drawing.Size(310, 56);
            this.trkC.TabIndex = 30;
            this.trkC.ValueChanged += new System.EventHandler(this.trkC_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(746, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(746, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "G:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(746, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "R:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(746, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(746, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "X:";
            // 
            // txtBSrc
            // 
            this.txtBSrc.Location = new System.Drawing.Point(355, 231);
            this.txtBSrc.Name = "txtBSrc";
            this.txtBSrc.Size = new System.Drawing.Size(43, 22);
            this.txtBSrc.TabIndex = 24;
            // 
            // txtGSrc
            // 
            this.txtGSrc.Location = new System.Drawing.Point(355, 203);
            this.txtGSrc.Name = "txtGSrc";
            this.txtGSrc.Size = new System.Drawing.Size(43, 22);
            this.txtGSrc.TabIndex = 22;
            // 
            // txtRSrc
            // 
            this.txtRSrc.Location = new System.Drawing.Point(355, 175);
            this.txtRSrc.Name = "txtRSrc";
            this.txtRSrc.Size = new System.Drawing.Size(43, 22);
            this.txtRSrc.TabIndex = 20;
            // 
            // txtYSrc
            // 
            this.txtYSrc.Location = new System.Drawing.Point(355, 118);
            this.txtYSrc.Name = "txtYSrc";
            this.txtYSrc.Size = new System.Drawing.Size(43, 22);
            this.txtYSrc.TabIndex = 18;
            // 
            // txtXSrc
            // 
            this.txtXSrc.Location = new System.Drawing.Point(355, 90);
            this.txtXSrc.Name = "txtXSrc";
            this.txtXSrc.Size = new System.Drawing.Size(43, 22);
            this.txtXSrc.TabIndex = 16;
            // 
            // txtBRsl
            // 
            this.txtBRsl.Location = new System.Drawing.Point(770, 226);
            this.txtBRsl.Name = "txtBRsl";
            this.txtBRsl.Size = new System.Drawing.Size(43, 22);
            this.txtBRsl.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "G:";
            // 
            // txtRRsl
            // 
            this.txtRRsl.Location = new System.Drawing.Point(770, 170);
            this.txtRRsl.Name = "txtRRsl";
            this.txtRRsl.Size = new System.Drawing.Size(43, 22);
            this.txtRRsl.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "R:";
            // 
            // txtXRsl
            // 
            this.txtXRsl.Location = new System.Drawing.Point(770, 85);
            this.txtXRsl.Name = "txtXRsl";
            this.txtXRsl.Size = new System.Drawing.Size(43, 22);
            this.txtXRsl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y:";
            // 
            // txtYRsl
            // 
            this.txtYRsl.Location = new System.Drawing.Point(770, 113);
            this.txtYRsl.Name = "txtYRsl";
            this.txtYRsl.Size = new System.Drawing.Size(43, 22);
            this.txtYRsl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picResult.Location = new System.Drawing.Point(443, 82);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(278, 206);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 4;
            this.picResult.TabStop = false;
            this.picResult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picResult_MouseMove);
            // 
            // picSource
            // 
            this.picSource.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picSource.Location = new System.Drawing.Point(46, 82);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(278, 206);
            this.picSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSource.TabIndex = 3;
            this.picSource.TabStop = false;
            this.picSource.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picSource_MouseMove);
            // 
            // lblImgPath
            // 
            this.lblImgPath.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblImgPath.Location = new System.Drawing.Point(43, 32);
            this.lblImgPath.Name = "lblImgPath";
            this.lblImgPath.Size = new System.Drawing.Size(281, 23);
            this.lblImgPath.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(646, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(249, 305);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 36);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtGRsl
            // 
            this.txtGRsl.Location = new System.Drawing.Point(770, 198);
            this.txtGRsl.Name = "txtGRsl";
            this.txtGRsl.Size = new System.Drawing.Size(43, 22);
            this.txtGRsl.TabIndex = 12;
            // 
            // Image
            // 
            this.Image.Controls.Add(this.lbprocess);
            this.Image.Controls.Add(this.label6);
            this.Image.Controls.Add(this.label7);
            this.Image.Controls.Add(this.label8);
            this.Image.Controls.Add(this.label9);
            this.Image.Controls.Add(this.label10);
            this.Image.Controls.Add(this.txtBSrc);
            this.Image.Controls.Add(this.txtGSrc);
            this.Image.Controls.Add(this.txtRSrc);
            this.Image.Controls.Add(this.txtYSrc);
            this.Image.Controls.Add(this.txtXSrc);
            this.Image.Controls.Add(this.txtBRsl);
            this.Image.Controls.Add(this.label5);
            this.Image.Controls.Add(this.txtGRsl);
            this.Image.Controls.Add(this.label4);
            this.Image.Controls.Add(this.txtRRsl);
            this.Image.Controls.Add(this.label3);
            this.Image.Controls.Add(this.txtXRsl);
            this.Image.Controls.Add(this.label2);
            this.Image.Controls.Add(this.txtYRsl);
            this.Image.Controls.Add(this.label1);
            this.Image.Controls.Add(this.picResult);
            this.Image.Controls.Add(this.picSource);
            this.Image.Controls.Add(this.lblImgPath);
            this.Image.Controls.Add(this.btnSave);
            this.Image.Controls.Add(this.btnOpen);
            this.Image.Location = new System.Drawing.Point(12, 142);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(821, 345);
            this.Image.TabIndex = 32;
            this.Image.TabStop = false;
            // 
            // lbprocess
            // 
            this.lbprocess.AutoSize = true;
            this.lbprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprocess.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbprocess.Location = new System.Drawing.Point(439, 35);
            this.lbprocess.Name = "lbprocess";
            this.lbprocess.Size = new System.Drawing.Size(0, 20);
            this.lbprocess.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdolaplace);
            this.groupBox1.Controls.Add(this.rdoloctheok);
            this.groupBox1.Controls.Add(this.rdoloctrungvi);
            this.groupBox1.Controls.Add(this.rdotrungbinh);
            this.groupBox1.Controls.Add(this.rdoamban);
            this.groupBox1.Controls.Add(this.rdotuongphan);
            this.groupBox1.Controls.Add(this.rdobocum);
            this.groupBox1.Controls.Add(this.rdoisodata);
            this.groupBox1.Controls.Add(this.rdotachnguong);
            this.groupBox1.Controls.Add(this.rdobienanh);
            this.groupBox1.Controls.Add(this.rdohistogram);
            this.groupBox1.Controls.Add(this.rdoconvert);
            this.groupBox1.Controls.Add(this.rdosang);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1168, 112);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // rdolaplace
            // 
            this.rdolaplace.AutoSize = true;
            this.rdolaplace.Location = new System.Drawing.Point(978, 26);
            this.rdolaplace.Name = "rdolaplace";
            this.rdolaplace.Size = new System.Drawing.Size(135, 20);
            this.rdolaplace.TabIndex = 12;
            this.rdolaplace.Text = "Nổi biên(Laplace)";
            this.rdolaplace.UseVisualStyleBackColor = true;
            this.rdolaplace.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdoloctheok
            // 
            this.rdoloctheok.AutoSize = true;
            this.rdoloctheok.Location = new System.Drawing.Point(788, 52);
            this.rdoloctheok.Name = "rdoloctheok";
            this.rdoloctheok.Size = new System.Drawing.Size(143, 20);
            this.rdoloctheok.TabIndex = 11;
            this.rdoloctheok.Text = "Lọc theo k gần nhất";
            this.rdoloctheok.UseVisualStyleBackColor = true;
            this.rdoloctheok.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdoloctrungvi
            // 
            this.rdoloctrungvi.AutoSize = true;
            this.rdoloctrungvi.Location = new System.Drawing.Point(788, 26);
            this.rdoloctrungvi.Name = "rdoloctrungvi";
            this.rdoloctrungvi.Size = new System.Drawing.Size(91, 20);
            this.rdoloctrungvi.TabIndex = 10;
            this.rdoloctrungvi.Text = "lọc trung vị";
            this.rdoloctrungvi.UseVisualStyleBackColor = true;
            this.rdoloctrungvi.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdotrungbinh
            // 
            this.rdotrungbinh.AutoSize = true;
            this.rdotrungbinh.Location = new System.Drawing.Point(540, 78);
            this.rdotrungbinh.Name = "rdotrungbinh";
            this.rdotrungbinh.Size = new System.Drawing.Size(106, 20);
            this.rdotrungbinh.TabIndex = 9;
            this.rdotrungbinh.Text = "lọc trung bình";
            this.rdotrungbinh.UseVisualStyleBackColor = true;
            this.rdotrungbinh.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdoamban
            // 
            this.rdoamban.AutoSize = true;
            this.rdoamban.Location = new System.Drawing.Point(540, 52);
            this.rdoamban.Name = "rdoamban";
            this.rdoamban.Size = new System.Drawing.Size(126, 20);
            this.rdoamban.TabIndex = 8;
            this.rdoamban.Text = "Tạo ảnh âm bản";
            this.rdoamban.UseVisualStyleBackColor = true;
            this.rdoamban.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdotuongphan
            // 
            this.rdotuongphan.AutoSize = true;
            this.rdotuongphan.Location = new System.Drawing.Point(540, 26);
            this.rdotuongphan.Name = "rdotuongphan";
            this.rdotuongphan.Size = new System.Drawing.Size(148, 20);
            this.rdotuongphan.TabIndex = 7;
            this.rdotuongphan.Text = "Tăng độ tương phản";
            this.rdotuongphan.UseVisualStyleBackColor = true;
            this.rdotuongphan.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdobocum
            // 
            this.rdobocum.AutoSize = true;
            this.rdobocum.Location = new System.Drawing.Point(320, 78);
            this.rdobocum.Name = "rdobocum";
            this.rdobocum.Size = new System.Drawing.Size(73, 20);
            this.rdobocum.TabIndex = 6;
            this.rdobocum.Text = "Bó cụm";
            this.rdobocum.UseVisualStyleBackColor = true;
            this.rdobocum.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdoisodata
            // 
            this.rdoisodata.AutoSize = true;
            this.rdoisodata.Location = new System.Drawing.Point(320, 52);
            this.rdoisodata.Name = "rdoisodata";
            this.rdoisodata.Size = new System.Drawing.Size(207, 20);
            this.rdoisodata.TabIndex = 5;
            this.rdoisodata.Text = "Tách ngưỡng tự động(isodata)";
            this.rdoisodata.UseVisualStyleBackColor = true;
            this.rdoisodata.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdotachnguong
            // 
            this.rdotachnguong.AutoSize = true;
            this.rdotachnguong.Location = new System.Drawing.Point(320, 26);
            this.rdotachnguong.Name = "rdotachnguong";
            this.rdotachnguong.Size = new System.Drawing.Size(153, 20);
            this.rdotachnguong.TabIndex = 4;
            this.rdotachnguong.Text = "Tách ngưỡng cố định";
            this.rdotachnguong.UseVisualStyleBackColor = true;
            this.rdotachnguong.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdobienanh
            // 
            this.rdobienanh.AutoSize = true;
            this.rdobienanh.Location = new System.Drawing.Point(788, 78);
            this.rdobienanh.Name = "rdobienanh";
            this.rdobienanh.Size = new System.Drawing.Size(105, 20);
            this.rdobienanh.TabIndex = 3;
            this.rdobienanh.Text = "Tìm biên ảnh";
            this.rdobienanh.UseVisualStyleBackColor = true;
            this.rdobienanh.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdohistogram
            // 
            this.rdohistogram.AutoSize = true;
            this.rdohistogram.Location = new System.Drawing.Point(3, 78);
            this.rdohistogram.Name = "rdohistogram";
            this.rdohistogram.Size = new System.Drawing.Size(90, 20);
            this.rdohistogram.TabIndex = 2;
            this.rdohistogram.Text = "Histogram";
            this.rdohistogram.UseVisualStyleBackColor = true;
            this.rdohistogram.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdoconvert
            // 
            this.rdoconvert.AutoSize = true;
            this.rdoconvert.Location = new System.Drawing.Point(4, 52);
            this.rdoconvert.Name = "rdoconvert";
            this.rdoconvert.Size = new System.Drawing.Size(213, 20);
            this.rdoconvert.TabIndex = 1;
            this.rdoconvert.Text = "Chuyển ảnh màu sang ảnh xám";
            this.rdoconvert.UseVisualStyleBackColor = true;
            this.rdoconvert.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // rdosang
            // 
            this.rdosang.AutoSize = true;
            this.rdosang.Location = new System.Drawing.Point(3, 26);
            this.rdosang.Name = "rdosang";
            this.rdosang.Size = new System.Drawing.Size(145, 20);
            this.rdosang.TabIndex = 0;
            this.rdosang.Text = "Tăng giảm độ sáng";
            this.rdosang.UseVisualStyleBackColor = true;
            this.rdosang.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // grbHistogram
            // 
            this.grbHistogram.Controls.Add(this.label11);
            this.grbHistogram.Controls.Add(this.picHistogram);
            this.grbHistogram.Location = new System.Drawing.Point(839, 142);
            this.grbHistogram.Name = "grbHistogram";
            this.grbHistogram.Size = new System.Drawing.Size(271, 341);
            this.grbHistogram.TabIndex = 35;
            this.grbHistogram.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(99, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Histogram";
            // 
            // picHistogram
            // 
            this.picHistogram.Location = new System.Drawing.Point(6, 29);
            this.picHistogram.Name = "picHistogram";
            this.picHistogram.Size = new System.Drawing.Size(256, 300);
            this.picHistogram.TabIndex = 0;
            this.picHistogram.TabStop = false;
            // 
            // grbmatrix
            // 
            this.grbmatrix.Controls.Add(this.lbsize);
            this.grbmatrix.Controls.Add(this.btnrun);
            this.grbmatrix.Controls.Add(this.btndownsize);
            this.grbmatrix.Controls.Add(this.btnupsize);
            this.grbmatrix.Controls.Add(this.txtsize);
            this.grbmatrix.Controls.Add(this.btndownk);
            this.grbmatrix.Controls.Add(this.btnupk);
            this.grbmatrix.Controls.Add(this.txtk);
            this.grbmatrix.Location = new System.Drawing.Point(1121, 152);
            this.grbmatrix.Name = "grbmatrix";
            this.grbmatrix.Size = new System.Drawing.Size(174, 215);
            this.grbmatrix.TabIndex = 36;
            this.grbmatrix.TabStop = false;
            this.grbmatrix.Visible = false;
            // 
            // lbsize
            // 
            this.lbsize.AutoSize = true;
            this.lbsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsize.Location = new System.Drawing.Point(76, 58);
            this.lbsize.Name = "lbsize";
            this.lbsize.Size = new System.Drawing.Size(39, 22);
            this.lbsize.TabIndex = 8;
            this.lbsize.Text = "3x3";
            this.lbsize.TextChanged += new System.EventHandler(this.lbsize_TextChanged);
            // 
            // btnrun
            // 
            this.btnrun.Location = new System.Drawing.Point(80, 106);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(75, 23);
            this.btnrun.TabIndex = 7;
            this.btnrun.Text = "Run";
            this.btnrun.UseVisualStyleBackColor = true;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // btndownsize
            // 
            this.btndownsize.Location = new System.Drawing.Point(28, 72);
            this.btndownsize.Name = "btndownsize";
            this.btndownsize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btndownsize.Size = new System.Drawing.Size(31, 22);
            this.btndownsize.TabIndex = 6;
            this.btndownsize.Text = "-";
            this.btndownsize.UseVisualStyleBackColor = true;
            this.btndownsize.Click += new System.EventHandler(this.btndownsize_Click);
            // 
            // btnupsize
            // 
            this.btnupsize.Location = new System.Drawing.Point(28, 47);
            this.btnupsize.Name = "btnupsize";
            this.btnupsize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnupsize.Size = new System.Drawing.Size(31, 22);
            this.btnupsize.TabIndex = 5;
            this.btnupsize.Text = "+";
            this.btnupsize.UseVisualStyleBackColor = true;
            this.btnupsize.Click += new System.EventHandler(this.btnupsize_Click);
            // 
            // txtsize
            // 
            this.txtsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsize.Location = new System.Drawing.Point(0, 58);
            this.txtsize.Name = "txtsize";
            this.txtsize.ReadOnly = true;
            this.txtsize.Size = new System.Drawing.Size(16, 27);
            this.txtsize.TabIndex = 4;
            this.txtsize.Text = "1";
            this.txtsize.Visible = false;
            // 
            // btndownk
            // 
            this.btndownk.Location = new System.Drawing.Point(54, 165);
            this.btndownk.Name = "btndownk";
            this.btndownk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btndownk.Size = new System.Drawing.Size(31, 22);
            this.btndownk.TabIndex = 3;
            this.btndownk.Text = "-";
            this.btndownk.UseVisualStyleBackColor = true;
            this.btndownk.Click += new System.EventHandler(this.btndownk_Click);
            // 
            // btnupk
            // 
            this.btnupk.Location = new System.Drawing.Point(54, 134);
            this.btnupk.Name = "btnupk";
            this.btnupk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnupk.Size = new System.Drawing.Size(31, 22);
            this.btnupk.TabIndex = 2;
            this.btnupk.Text = "+";
            this.btnupk.UseVisualStyleBackColor = true;
            this.btnupk.Click += new System.EventHandler(this.btnupk_Click);
            // 
            // txtk
            // 
            this.txtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtk.Location = new System.Drawing.Point(0, 148);
            this.txtk.Name = "txtk";
            this.txtk.ReadOnly = true;
            this.txtk.Size = new System.Drawing.Size(48, 27);
            this.txtk.TabIndex = 1;
            this.txtk.Text = "1";
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1299, 558);
            this.Controls.Add(this.grbmatrix);
            this.Controls.Add(this.grbHistogram);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Parameter);
            this.Controls.Add(this.Image);
            this.Name = "Frm";
            this.Text = "Form1";
            this.Parameter.ResumeLayout(false);
            this.Parameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            this.Image.ResumeLayout(false);
            this.Image.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbHistogram.ResumeLayout(false);
            this.grbHistogram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistogram)).EndInit();
            this.grbmatrix.ResumeLayout(false);
            this.grbmatrix.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox Parameter;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TrackBar trkC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBSrc;
        private System.Windows.Forms.TextBox txtGSrc;
        private System.Windows.Forms.TextBox txtRSrc;
        private System.Windows.Forms.TextBox txtYSrc;
        private System.Windows.Forms.TextBox txtXSrc;
        private System.Windows.Forms.TextBox txtBRsl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRRsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXRsl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYRsl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.Label lblImgPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtGRsl;
        private System.Windows.Forms.GroupBox Image;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdohistogram;
        private System.Windows.Forms.RadioButton rdoconvert;
        private System.Windows.Forms.RadioButton rdosang;
        private System.Windows.Forms.GroupBox grbHistogram;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picHistogram;
        private System.Windows.Forms.RadioButton rdobienanh;
        private System.Windows.Forms.RadioButton rdotachnguong;
        private System.Windows.Forms.Label lbbar;
        private System.Windows.Forms.RadioButton rdoisodata;
        private System.Windows.Forms.RadioButton rdotuongphan;
        private System.Windows.Forms.RadioButton rdobocum;
        private System.Windows.Forms.RadioButton rdoamban;
        private System.Windows.Forms.RadioButton rdotrungbinh;
        private System.Windows.Forms.RadioButton rdoloctrungvi;
        private System.Windows.Forms.RadioButton rdoloctheok;
        private System.Windows.Forms.RadioButton rdolaplace;
        private System.Windows.Forms.Label lbprocess;
        private System.Windows.Forms.GroupBox grbmatrix;
        private System.Windows.Forms.Button btndownsize;
        private System.Windows.Forms.Button btnupsize;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.Button btndownk;
        private System.Windows.Forms.Button btnupk;
        private System.Windows.Forms.TextBox txtk;
        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.Label lbsize;
    }
}

