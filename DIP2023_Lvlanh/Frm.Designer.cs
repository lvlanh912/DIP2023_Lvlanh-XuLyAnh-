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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm));
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
            this.lblImgPath = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtGRsl = new System.Windows.Forms.TextBox();
            this.Image = new System.Windows.Forms.GroupBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.picSource = new System.Windows.Forms.PictureBox();
            this.lbprocess = new System.Windows.Forms.Label();
            this.grbHistogram = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.picHistogram = new System.Windows.Forms.PictureBox();
            this.grbmatrix = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbsize = new System.Windows.Forms.Label();
            this.btndownsize = new System.Windows.Forms.Button();
            this.btnupsize = new System.Windows.Forms.Button();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.btndownk = new System.Windows.Forms.Button();
            this.btnupk = new System.Windows.Forms.Button();
            this.txtk = new System.Windows.Forms.TextBox();
            this.btnrun = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnlaplace = new System.Windows.Forms.Button();
            this.btnsobel = new System.Windows.Forms.Button();
            this.btnloctheok = new System.Windows.Forms.Button();
            this.btntrungvi = new System.Windows.Forms.Button();
            this.btntrungbinh = new System.Windows.Forms.Button();
            this.btnamban = new System.Windows.Forms.Button();
            this.btntuongphan = new System.Windows.Forms.Button();
            this.btnbocum = new System.Windows.Forms.Button();
            this.btniso = new System.Windows.Forms.Button();
            this.btntachnguong = new System.Windows.Forms.Button();
            this.btnhistogram = new System.Windows.Forms.Button();
            this.btncovert = new System.Windows.Forms.Button();
            this.btndosang = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbchosen = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Parameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkC)).BeginInit();
            this.Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            this.grbHistogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistogram)).BeginInit();
            this.grbmatrix.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Parameter
            // 
            this.Parameter.Controls.Add(this.lbbar);
            this.Parameter.Controls.Add(this.lblC);
            this.Parameter.Controls.Add(this.trkC);
            this.Parameter.Location = new System.Drawing.Point(277, 480);
            this.Parameter.Name = "Parameter";
            this.Parameter.Size = new System.Drawing.Size(646, 98);
            this.Parameter.TabIndex = 33;
            this.Parameter.TabStop = false;
            // 
            // lbbar
            // 
            this.lbbar.AutoSize = true;
            this.lbbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbar.Location = new System.Drawing.Point(21, 40);
            this.lbbar.Name = "lbbar";
            this.lbbar.Size = new System.Drawing.Size(244, 20);
            this.lbbar.TabIndex = 32;
            this.lbbar.Text = "Trượt thanh độ sáng để thay đổi";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(464, 57);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(36, 38);
            this.lblC.TabIndex = 31;
            this.lblC.Text = "0";
            // 
            // trkC
            // 
            this.trkC.Location = new System.Drawing.Point(330, 11);
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
            // lblImgPath
            // 
            this.lblImgPath.BackColor = System.Drawing.SystemColors.Control;
            this.lblImgPath.Location = new System.Drawing.Point(43, 22);
            this.lblImgPath.Name = "lblImgPath";
            this.lblImgPath.Size = new System.Drawing.Size(281, 33);
            this.lblImgPath.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(721, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "      Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(341, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(112, 36);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "     Open...";
            this.btnOpen.UseVisualStyleBackColor = false;
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
            this.Image.BackColor = System.Drawing.Color.White;
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
            this.Image.Location = new System.Drawing.Point(283, 133);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(821, 341);
            this.Image.TabIndex = 32;
            this.Image.TabStop = false;
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
            // lbprocess
            // 
            this.lbprocess.AutoSize = true;
            this.lbprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprocess.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbprocess.Location = new System.Drawing.Point(722, 113);
            this.lbprocess.Name = "lbprocess";
            this.lbprocess.Size = new System.Drawing.Size(0, 20);
            this.lbprocess.TabIndex = 30;
            // 
            // grbHistogram
            // 
            this.grbHistogram.BackColor = System.Drawing.Color.White;
            this.grbHistogram.Controls.Add(this.label11);
            this.grbHistogram.Controls.Add(this.picHistogram);
            this.grbHistogram.Location = new System.Drawing.Point(1107, 133);
            this.grbHistogram.Name = "grbHistogram";
            this.grbHistogram.Size = new System.Drawing.Size(271, 345);
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
            this.picHistogram.BackColor = System.Drawing.Color.White;
            this.picHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHistogram.Location = new System.Drawing.Point(6, 29);
            this.picHistogram.Name = "picHistogram";
            this.picHistogram.Size = new System.Drawing.Size(256, 300);
            this.picHistogram.TabIndex = 0;
            this.picHistogram.TabStop = false;
            // 
            // grbmatrix
            // 
            this.grbmatrix.Controls.Add(this.label13);
            this.grbmatrix.Controls.Add(this.label12);
            this.grbmatrix.Controls.Add(this.lbsize);
            this.grbmatrix.Controls.Add(this.btndownsize);
            this.grbmatrix.Controls.Add(this.btnupsize);
            this.grbmatrix.Controls.Add(this.txtsize);
            this.grbmatrix.Controls.Add(this.btndownk);
            this.grbmatrix.Controls.Add(this.btnupk);
            this.grbmatrix.Controls.Add(this.txtk);
            this.grbmatrix.Location = new System.Drawing.Point(951, 484);
            this.grbmatrix.Name = "grbmatrix";
            this.grbmatrix.Size = new System.Drawing.Size(266, 94);
            this.grbmatrix.TabIndex = 100;
            this.grbmatrix.TabStop = false;
            this.grbmatrix.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Giá trị k";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "kích thước ma trận";
            // 
            // lbsize
            // 
            this.lbsize.AutoSize = true;
            this.lbsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsize.Location = new System.Drawing.Point(76, 53);
            this.lbsize.Name = "lbsize";
            this.lbsize.Size = new System.Drawing.Size(39, 22);
            this.lbsize.TabIndex = 8;
            this.lbsize.Text = "3x3";
            this.lbsize.TextChanged += new System.EventHandler(this.lbsize_TextChanged);
            // 
            // btndownsize
            // 
            this.btndownsize.BackColor = System.Drawing.Color.IndianRed;
            this.btndownsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndownsize.ForeColor = System.Drawing.Color.White;
            this.btndownsize.Location = new System.Drawing.Point(28, 67);
            this.btndownsize.Name = "btndownsize";
            this.btndownsize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btndownsize.Size = new System.Drawing.Size(31, 22);
            this.btndownsize.TabIndex = 6;
            this.btndownsize.Text = "-";
            this.btndownsize.UseVisualStyleBackColor = false;
            this.btndownsize.Click += new System.EventHandler(this.btndownsize_Click);
            // 
            // btnupsize
            // 
            this.btnupsize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnupsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupsize.ForeColor = System.Drawing.Color.White;
            this.btnupsize.Location = new System.Drawing.Point(28, 42);
            this.btnupsize.Name = "btnupsize";
            this.btnupsize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnupsize.Size = new System.Drawing.Size(31, 22);
            this.btnupsize.TabIndex = 5;
            this.btnupsize.Text = "+";
            this.btnupsize.UseVisualStyleBackColor = false;
            this.btnupsize.Click += new System.EventHandler(this.btnupsize_Click);
            // 
            // txtsize
            // 
            this.txtsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsize.Location = new System.Drawing.Point(0, 53);
            this.txtsize.Name = "txtsize";
            this.txtsize.ReadOnly = true;
            this.txtsize.Size = new System.Drawing.Size(22, 27);
            this.txtsize.TabIndex = 4;
            this.txtsize.Text = "1";
            this.txtsize.Visible = false;
            // 
            // btndownk
            // 
            this.btndownk.BackColor = System.Drawing.Color.IndianRed;
            this.btndownk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndownk.ForeColor = System.Drawing.Color.White;
            this.btndownk.Location = new System.Drawing.Point(210, 67);
            this.btndownk.Name = "btndownk";
            this.btndownk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btndownk.Size = new System.Drawing.Size(31, 22);
            this.btndownk.TabIndex = 3;
            this.btndownk.Text = "-";
            this.btndownk.UseVisualStyleBackColor = false;
            this.btndownk.Click += new System.EventHandler(this.btndownk_Click);
            // 
            // btnupk
            // 
            this.btnupk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnupk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupk.ForeColor = System.Drawing.Color.White;
            this.btnupk.Location = new System.Drawing.Point(210, 41);
            this.btnupk.Name = "btnupk";
            this.btnupk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnupk.Size = new System.Drawing.Size(31, 22);
            this.btnupk.TabIndex = 2;
            this.btnupk.Text = "+";
            this.btnupk.UseVisualStyleBackColor = false;
            this.btnupk.Click += new System.EventHandler(this.btnupk_Click);
            // 
            // txtk
            // 
            this.txtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtk.Location = new System.Drawing.Point(165, 56);
            this.txtk.Name = "txtk";
            this.txtk.ReadOnly = true;
            this.txtk.Size = new System.Drawing.Size(39, 27);
            this.txtk.TabIndex = 1;
            this.txtk.Text = "1";
            // 
            // btnrun
            // 
            this.btnrun.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrun.ForeColor = System.Drawing.Color.White;
            this.btnrun.Image = ((System.Drawing.Image)(resources.GetObject("btnrun.Image")));
            this.btnrun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrun.Location = new System.Drawing.Point(726, 628);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(138, 43);
            this.btnrun.TabIndex = 7;
            this.btnrun.Text = "Run";
            this.btnrun.UseVisualStyleBackColor = false;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelmenu.Controls.Add(this.btnlaplace);
            this.panelmenu.Controls.Add(this.btnsobel);
            this.panelmenu.Controls.Add(this.btnloctheok);
            this.panelmenu.Controls.Add(this.btntrungvi);
            this.panelmenu.Controls.Add(this.btntrungbinh);
            this.panelmenu.Controls.Add(this.btnamban);
            this.panelmenu.Controls.Add(this.btntuongphan);
            this.panelmenu.Controls.Add(this.btnbocum);
            this.panelmenu.Controls.Add(this.btniso);
            this.panelmenu.Controls.Add(this.btntachnguong);
            this.panelmenu.Controls.Add(this.btnhistogram);
            this.panelmenu.Controls.Add(this.btncovert);
            this.panelmenu.Controls.Add(this.btndosang);
            this.panelmenu.Controls.Add(this.panellogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(270, 687);
            this.panelmenu.TabIndex = 101;
            // 
            // btnlaplace
            // 
            this.btnlaplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlaplace.FlatAppearance.BorderSize = 0;
            this.btnlaplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlaplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlaplace.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnlaplace.Image = ((System.Drawing.Image)(resources.GetObject("btnlaplace.Image")));
            this.btnlaplace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlaplace.Location = new System.Drawing.Point(0, 628);
            this.btnlaplace.Name = "btnlaplace";
            this.btnlaplace.Size = new System.Drawing.Size(270, 45);
            this.btnlaplace.TabIndex = 13;
            this.btnlaplace.Text = "   Nổi Biên (LapLace)";
            this.btnlaplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlaplace.UseVisualStyleBackColor = true;
            this.btnlaplace.Click += new System.EventHandler(this.btnlaplace_Click);
            // 
            // btnsobel
            // 
            this.btnsobel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsobel.FlatAppearance.BorderSize = 0;
            this.btnsobel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsobel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnsobel.Image = ((System.Drawing.Image)(resources.GetObject("btnsobel.Image")));
            this.btnsobel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsobel.Location = new System.Drawing.Point(0, 583);
            this.btnsobel.Name = "btnsobel";
            this.btnsobel.Size = new System.Drawing.Size(270, 45);
            this.btnsobel.TabIndex = 12;
            this.btnsobel.Text = "   Nổi biên (Sobel)";
            this.btnsobel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsobel.UseVisualStyleBackColor = true;
            this.btnsobel.Click += new System.EventHandler(this.btnsobel_Click);
            // 
            // btnloctheok
            // 
            this.btnloctheok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnloctheok.FlatAppearance.BorderSize = 0;
            this.btnloctheok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloctheok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloctheok.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnloctheok.Image = ((System.Drawing.Image)(resources.GetObject("btnloctheok.Image")));
            this.btnloctheok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnloctheok.Location = new System.Drawing.Point(0, 538);
            this.btnloctheok.Name = "btnloctheok";
            this.btnloctheok.Size = new System.Drawing.Size(270, 45);
            this.btnloctheok.TabIndex = 11;
            this.btnloctheok.Text = "   Lọc theo k";
            this.btnloctheok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnloctheok.UseVisualStyleBackColor = true;
            this.btnloctheok.Click += new System.EventHandler(this.btnloctheok_Click);
            // 
            // btntrungvi
            // 
            this.btntrungvi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntrungvi.FlatAppearance.BorderSize = 0;
            this.btntrungvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrungvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrungvi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btntrungvi.Image = ((System.Drawing.Image)(resources.GetObject("btntrungvi.Image")));
            this.btntrungvi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntrungvi.Location = new System.Drawing.Point(0, 493);
            this.btntrungvi.Name = "btntrungvi";
            this.btntrungvi.Size = new System.Drawing.Size(270, 45);
            this.btntrungvi.TabIndex = 10;
            this.btntrungvi.Text = "   Lọc trung vị";
            this.btntrungvi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntrungvi.UseVisualStyleBackColor = true;
            this.btntrungvi.Click += new System.EventHandler(this.btntrungvi_Click);
            // 
            // btntrungbinh
            // 
            this.btntrungbinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntrungbinh.FlatAppearance.BorderSize = 0;
            this.btntrungbinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrungbinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrungbinh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btntrungbinh.Image = ((System.Drawing.Image)(resources.GetObject("btntrungbinh.Image")));
            this.btntrungbinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntrungbinh.Location = new System.Drawing.Point(0, 448);
            this.btntrungbinh.Name = "btntrungbinh";
            this.btntrungbinh.Size = new System.Drawing.Size(270, 45);
            this.btntrungbinh.TabIndex = 9;
            this.btntrungbinh.Text = "   Lọc trung bình";
            this.btntrungbinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntrungbinh.UseVisualStyleBackColor = true;
            this.btntrungbinh.Click += new System.EventHandler(this.btntrungbinh_Click);
            // 
            // btnamban
            // 
            this.btnamban.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnamban.FlatAppearance.BorderSize = 0;
            this.btnamban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnamban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnamban.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnamban.Image = ((System.Drawing.Image)(resources.GetObject("btnamban.Image")));
            this.btnamban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnamban.Location = new System.Drawing.Point(0, 403);
            this.btnamban.Name = "btnamban";
            this.btnamban.Size = new System.Drawing.Size(270, 45);
            this.btnamban.TabIndex = 8;
            this.btnamban.Text = "   Tạo ảnh âm bản";
            this.btnamban.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnamban.UseVisualStyleBackColor = true;
            this.btnamban.Click += new System.EventHandler(this.btnamban_Click);
            // 
            // btntuongphan
            // 
            this.btntuongphan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntuongphan.FlatAppearance.BorderSize = 0;
            this.btntuongphan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntuongphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntuongphan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btntuongphan.Image = ((System.Drawing.Image)(resources.GetObject("btntuongphan.Image")));
            this.btntuongphan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntuongphan.Location = new System.Drawing.Point(0, 358);
            this.btntuongphan.Name = "btntuongphan";
            this.btntuongphan.Size = new System.Drawing.Size(270, 45);
            this.btntuongphan.TabIndex = 7;
            this.btntuongphan.Text = "   Tăng độ tương phản";
            this.btntuongphan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntuongphan.UseVisualStyleBackColor = true;
            this.btntuongphan.Click += new System.EventHandler(this.btntuongphan_Click);
            // 
            // btnbocum
            // 
            this.btnbocum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnbocum.FlatAppearance.BorderSize = 0;
            this.btnbocum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbocum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbocum.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnbocum.Image = ((System.Drawing.Image)(resources.GetObject("btnbocum.Image")));
            this.btnbocum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbocum.Location = new System.Drawing.Point(0, 313);
            this.btnbocum.Name = "btnbocum";
            this.btnbocum.Size = new System.Drawing.Size(270, 45);
            this.btnbocum.TabIndex = 6;
            this.btnbocum.Text = "   Bó cụm";
            this.btnbocum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbocum.UseVisualStyleBackColor = true;
            this.btnbocum.Click += new System.EventHandler(this.btnbocum_Click);
            // 
            // btniso
            // 
            this.btniso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btniso.FlatAppearance.BorderSize = 0;
            this.btniso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniso.ForeColor = System.Drawing.Color.Gainsboro;
            this.btniso.Image = ((System.Drawing.Image)(resources.GetObject("btniso.Image")));
            this.btniso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btniso.Location = new System.Drawing.Point(0, 268);
            this.btniso.Name = "btniso";
            this.btniso.Size = new System.Drawing.Size(270, 45);
            this.btniso.TabIndex = 5;
            this.btniso.Text = "   Tách ngưỡng tự động(Isodata)";
            this.btniso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btniso.UseVisualStyleBackColor = true;
            this.btniso.Click += new System.EventHandler(this.btniso_Click);
            // 
            // btntachnguong
            // 
            this.btntachnguong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntachnguong.FlatAppearance.BorderSize = 0;
            this.btntachnguong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntachnguong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntachnguong.ForeColor = System.Drawing.Color.Gainsboro;
            this.btntachnguong.Image = ((System.Drawing.Image)(resources.GetObject("btntachnguong.Image")));
            this.btntachnguong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntachnguong.Location = new System.Drawing.Point(0, 223);
            this.btntachnguong.Name = "btntachnguong";
            this.btntachnguong.Size = new System.Drawing.Size(270, 45);
            this.btntachnguong.TabIndex = 4;
            this.btntachnguong.Text = "   Tách ngưỡng cố định";
            this.btntachnguong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntachnguong.UseVisualStyleBackColor = true;
            this.btntachnguong.Click += new System.EventHandler(this.btntachnguong_Click);
            // 
            // btnhistogram
            // 
            this.btnhistogram.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhistogram.FlatAppearance.BorderSize = 0;
            this.btnhistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistogram.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnhistogram.Image = ((System.Drawing.Image)(resources.GetObject("btnhistogram.Image")));
            this.btnhistogram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhistogram.Location = new System.Drawing.Point(0, 178);
            this.btnhistogram.Name = "btnhistogram";
            this.btnhistogram.Size = new System.Drawing.Size(270, 45);
            this.btnhistogram.TabIndex = 3;
            this.btnhistogram.Text = "   Vẽ histogram";
            this.btnhistogram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhistogram.UseVisualStyleBackColor = true;
            this.btnhistogram.Click += new System.EventHandler(this.btnhistogram_Click);
            // 
            // btncovert
            // 
            this.btncovert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncovert.FlatAppearance.BorderSize = 0;
            this.btncovert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncovert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncovert.ForeColor = System.Drawing.Color.Gainsboro;
            this.btncovert.Image = ((System.Drawing.Image)(resources.GetObject("btncovert.Image")));
            this.btncovert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncovert.Location = new System.Drawing.Point(0, 133);
            this.btncovert.Name = "btncovert";
            this.btncovert.Size = new System.Drawing.Size(270, 45);
            this.btncovert.TabIndex = 2;
            this.btncovert.Text = "   Chuyển ảnh xám";
            this.btncovert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncovert.UseVisualStyleBackColor = true;
            this.btncovert.Click += new System.EventHandler(this.btncovert_Click);
            // 
            // btndosang
            // 
            this.btndosang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndosang.FlatAppearance.BorderSize = 0;
            this.btndosang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndosang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndosang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btndosang.Image = ((System.Drawing.Image)(resources.GetObject("btndosang.Image")));
            this.btndosang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndosang.Location = new System.Drawing.Point(0, 88);
            this.btndosang.Name = "btndosang";
            this.btndosang.Size = new System.Drawing.Size(270, 45);
            this.btndosang.TabIndex = 1;
            this.btndosang.Text = "   Độ sáng";
            this.btndosang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndosang.UseVisualStyleBackColor = true;
            this.btndosang.Click += new System.EventHandler(this.btndosang_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panellogo.Controls.Add(this.pictureBox1);
            this.panellogo.Controls.Add(this.label14);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(270, 88);
            this.panellogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(100, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Code by LvLanh";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.lbchosen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(270, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 88);
            this.panel1.TabIndex = 102;
            // 
            // lbchosen
            // 
            this.lbchosen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbchosen.AutoSize = true;
            this.lbchosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchosen.ForeColor = System.Drawing.Color.White;
            this.lbchosen.Location = new System.Drawing.Point(377, 30);
            this.lbchosen.Margin = new System.Windows.Forms.Padding(0);
            this.lbchosen.Name = "lbchosen";
            this.lbchosen.Size = new System.Drawing.Size(191, 25);
            this.lbchosen.TabIndex = 0;
            this.lbchosen.Text = "Đã chọn : Độ sáng";
            this.lbchosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1388, 687);
            this.Controls.Add(this.lbprocess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.grbmatrix);
            this.Controls.Add(this.btnrun);
            this.Controls.Add(this.grbHistogram);
            this.Controls.Add(this.Parameter);
            this.Controls.Add(this.Image);
            this.Name = "Frm";
            this.Text = "Form1";
            this.Parameter.ResumeLayout(false);
            this.Parameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkC)).EndInit();
            this.Image.ResumeLayout(false);
            this.Image.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            this.grbHistogram.ResumeLayout(false);
            this.grbHistogram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistogram)).EndInit();
            this.grbmatrix.ResumeLayout(false);
            this.grbmatrix.PerformLayout();
            this.panelmenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox grbHistogram;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picHistogram;
        private System.Windows.Forms.Label lbbar;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btndosang;
        private System.Windows.Forms.Button btnlaplace;
        private System.Windows.Forms.Button btnsobel;
        private System.Windows.Forms.Button btnloctheok;
        private System.Windows.Forms.Button btntrungvi;
        private System.Windows.Forms.Button btntrungbinh;
        private System.Windows.Forms.Button btnamban;
        private System.Windows.Forms.Button btntuongphan;
        private System.Windows.Forms.Button btnbocum;
        private System.Windows.Forms.Button btniso;
        private System.Windows.Forms.Button btntachnguong;
        private System.Windows.Forms.Button btnhistogram;
        private System.Windows.Forms.Button btncovert;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbchosen;
    }
}

