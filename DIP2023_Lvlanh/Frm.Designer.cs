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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdohistogram = new System.Windows.Forms.RadioButton();
            this.rdoconvert = new System.Windows.Forms.RadioButton();
            this.rdosang = new System.Windows.Forms.RadioButton();
            this.grbHistogram = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.picHistogram = new System.Windows.Forms.PictureBox();
            this.rdobienanh = new System.Windows.Forms.RadioButton();
            this.Parameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            this.Image.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbHistogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // Parameter
            // 
            this.Parameter.Controls.Add(this.lblC);
            this.Parameter.Controls.Add(this.trkC);
            this.Parameter.Location = new System.Drawing.Point(12, 482);
            this.Parameter.Name = "Parameter";
            this.Parameter.Size = new System.Drawing.Size(821, 64);
            this.Parameter.TabIndex = 33;
            this.Parameter.TabStop = false;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(210, 8);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(36, 38);
            this.lblC.TabIndex = 31;
            this.lblC.Text = "0";
            // 
            // trkC
            // 
            this.trkC.Location = new System.Drawing.Point(280, 8);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobienanh);
            this.groupBox1.Controls.Add(this.rdohistogram);
            this.groupBox1.Controls.Add(this.rdoconvert);
            this.groupBox1.Controls.Add(this.rdosang);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 112);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // rdohistogram
            // 
            this.rdohistogram.AutoSize = true;
            this.rdohistogram.Location = new System.Drawing.Point(3, 78);
            this.rdohistogram.Name = "rdohistogram";
            this.rdohistogram.Size = new System.Drawing.Size(90, 20);
            this.rdohistogram.TabIndex = 2;
            this.rdohistogram.TabStop = true;
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
            this.rdoconvert.TabStop = true;
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
            this.rdosang.TabStop = true;
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
            // rdobienanh
            // 
            this.rdobienanh.AutoSize = true;
            this.rdobienanh.Location = new System.Drawing.Point(320, 26);
            this.rdobienanh.Name = "rdobienanh";
            this.rdobienanh.Size = new System.Drawing.Size(105, 20);
            this.rdobienanh.TabIndex = 3;
            this.rdobienanh.TabStop = true;
            this.rdobienanh.Text = "Tìm biên ảnh";
            this.rdobienanh.UseVisualStyleBackColor = true;
            this.rdobienanh.CheckedChanged += new System.EventHandler(this.rdosang_CheckedChanged);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1261, 558);
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
    }
}

