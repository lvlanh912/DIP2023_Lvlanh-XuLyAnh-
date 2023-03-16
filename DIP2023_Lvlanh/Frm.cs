using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DIP2023_Lvlanh
{
    public partial class Frm : Form
    {
        private Button currenButton;
        clsmanage _manager = new clsmanage();
        Bitmap _imgSource = null;
        Bitmap _imgResult = null;
        byte choose;
        public Frm()
        {
            InitializeComponent();
        }
        private void activebutton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currenButton != (Button)btnsender)
                {
                    Disactivebutton();
                    currenButton = (Button)btnsender;
                    currenButton.BackColor = Color.Indigo;
                    currenButton.ForeColor = Color.White;
                }
            }
        }
        private void Disactivebutton()
        {
            foreach (Control btn in panelmenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(51, 51, 76);
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Bitmap file |*.bmp| JEPG files|*.jpg| PNG files|*.png";
            openFileDialog.FileName = "";
            DialogResult r = openFileDialog.ShowDialog();
            if (r == DialogResult.OK && openFileDialog.FileName != "")
            {
                lblImgPath.Text = openFileDialog.FileName;
                _imgSource = new Bitmap(openFileDialog.FileName);
                picSource.Image = _imgSource;
                _imgResult = new Bitmap(_imgSource);
            }
        }
        private async void trkC_ValueChanged(object sender, EventArgs e)
        {
            Xulianh _obj = new Xulianh(_imgSource);
            lblC.Text = trkC.Value.ToString();
            switch (choose)
            {
                case 1:// thay đổi độ sáng
                    lblC.Text = trkC.Value.ToString();
                    lbprocess.Text = "Đang xử lý";
                    this.Refresh();
                    picResult.Image = await _obj.thaydoidosang(trkC.Value);
                    lbprocess.Text = "";
                    break;
                case 6:// Bó cụm
                    lblC.Text = trkC.Value.ToString();
                    lbprocess.Text = "Đang xử lý";
                    this.Refresh();
                    picResult.Image = await _obj.Bocum(trkC.Value);
                    lbprocess.Text = "";
                    break;
            }
        }
        private void picSource_MouseMove(object sender, MouseEventArgs e)
        {
            txtXSrc.Text = e.X.ToString();
            txtYSrc.Text = e.Y.ToString();
            if (_imgSource == null)
                return;
            if (e.X < picSource.Width && e.Y < picSource.Height)
            {
                Bitmap bmp = new Bitmap(picSource.Image, picSource.Width, picSource.Height);//khởi tạo 1 bitmap bằng ảnh đã chọn với kích thước đã điều chỉnh 
                Color c = bmp.GetPixel(e.X, e.Y);
                txtRSrc.Text = c.R.ToString();
                txtGSrc.Text = c.G.ToString();
                txtBSrc.Text = c.B.ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Bitmap file |*.bmp| JEPG files|*.jpg| PNG files|*.png";
            saveFileDialog.FileName = "";
            DialogResult r = saveFileDialog.ShowDialog();
            if (r == DialogResult.OK && saveFileDialog.FileName != "" && _imgResult != null)
            {
                _imgResult.Save(saveFileDialog.FileName);
            }
        }
        private void picResult_MouseMove(object sender, MouseEventArgs e)
        {
            txtXRsl.Text = e.X.ToString();
            txtYRsl.Text = e.Y.ToString();
            if (_imgResult == null || picResult.Image == null)
                return;
            if (e.X < picResult.Width && e.Y < picResult.Height)
            {
                Bitmap bmp = new Bitmap(picResult.Image, picResult.Width, picResult.Height);//khởi tạo 1 bitmap bằng ảnh đã chọn với kích thước đã điều chỉnh 
                Color c = bmp.GetPixel(e.X, e.Y);
                txtRRsl.Text = c.R.ToString();
                txtGRsl.Text = c.G.ToString();
                txtBRsl.Text = c.B.ToString();
            }
        }
        private async void btnrun_Click(object sender, EventArgs e)
        {
            Xulianh _obj = new Xulianh(_imgSource);
            int nguong;
            switch (choose)
            {
                case 2://convert ảnh xám
                    lbprocess.Text = "Đang xử lý";
                    this.Refresh();
                    picResult.Image = _obj.Convertanhxam();
                    lbprocess.Text = "";
                    break;
                case 3://histogram
                    btnrun.Enabled = false;
                    picSource.Enabled = false;
                    lbprocess.Text = "Đang xử lý";
                    this.Refresh();
                    var t3 = Task.Run(() => _obj.Vehistogram());
                    while (!t3.IsCompleted)
                        await Task.Delay(100);
                    picResult.Image = t3.Result;
                    lbprocess.Text = "";
                    btnrun.Enabled = true;
                    picSource.Enabled = true;
                    break;
                case 4:// tách ngưỡng
                    picSource.Enabled = false;
                    nguong = trkC.Value;
                    btnrun.Enabled = false;
                    lbprocess.Text = "Đang xử lý";
                    this.Refresh();
                    var t4 = Task.Run(() => _obj.Tachnguong(nguong));
                    while (!t4.IsCompleted)
                        await Task.Delay(100);
                    picResult.Image = t4.Result;
                    lbprocess.Text = "";
                    btnrun.Enabled = true;
                    picSource.Enabled = true;
                    break;
                case 5://tách ngưỡng tự động (iso data)
                    btnrun.Enabled = false;
                    picSource.Enabled = false;
                    lbprocess.Text = "Đang xử lý";
                    this.Refresh();
                    var t5 = Task.Run(() => _obj.TachnguongIso());
                    while (!t5.IsCompleted)
                        await Task.Delay(100);
                    picResult.Image = t5.Result;
                    lbprocess.Text = "";
                    btnrun.Enabled = true;
                    picSource.Enabled = true;
                    break;
                case 7://Tăng độ tương phản
                    btnrun.Enabled = false;
                    picSource.Enabled = false;
                    lbprocess.Text = "Đang xử lý";
                    this.Refresh();
                    var t7 = Task.Run(() => _obj.Tangdotuongphan());
                    while (!t7.IsCompleted)
                        await Task.Delay(100);
                    picResult.Image = t7.Result;
                    lbprocess.Text = "";
                    btnrun.Enabled = true;
                    picSource.Enabled = true;
                    break;
                case 8://âm bản
                    btnrun.Enabled = false;
                    picSource.Enabled = false;
                    lbprocess.Text = "Đang xử lý";
                    this.Refresh();
                    var t8 = Task.Run(() => _obj.Amban());
                    while (!t8.IsCompleted)
                        await Task.Delay(100);
                    picResult.Image = t8.Result;
                    lbprocess.Text = "";
                    btnrun.Enabled = true;
                    picSource.Enabled = true;
                    break;
                case 9://lọc trung bình
                    int size = Convert.ToInt16(txtsize.Text);
                    picSource.Enabled = false;
                    btnrun.Enabled = false;
                    lbprocess.Text = "Đang xử lý";
                    this.Refresh();
                    var t9 = Task.Run(() => _obj.Loctrungbinh(size));
                    while (!t9.IsCompleted)
                        await Task.Delay(100);
                    picResult.Image = t9.Result;
                    lbprocess.Text = "";
                    btnrun.Enabled = true;
                    picSource.Enabled = true;
                    break;
                case 10://lọc trung vị
                    size = Convert.ToInt16(txtsize.Text);
                    picSource.Enabled = false;
                    btnrun.Enabled = false;
                    lbprocess.Text = "Đang xử lý";
                    this.Refresh();
                    var t10 = Task.Run(() => _obj.Loctrungvi(size));
                    while (!t10.IsCompleted)
                        await Task.Delay(100);
                    picResult.Image = t10.Result;
                    lbprocess.Text = "";
                    btnrun.Enabled = true;
                    picSource.Enabled = true;
                    break;
                case 11://lọc theo k
                    size = Convert.ToInt16(txtsize.Text);
                    int k = Convert.ToInt16(txtk.Text);
                    picSource.Enabled = false;
                    btnrun.Enabled = false;
                    lbprocess.Text = "Đang xử lý";
                    this.Refresh();
                    var t11 = Task.Run(() => _obj.LoctheoK(k, size));
                    while (!t11.IsCompleted)
                        await Task.Delay(100);
                    picResult.Image = t11.Result;
                    lbprocess.Text = "";
                    btnrun.Enabled = true;
                    picSource.Enabled = true;
                    break;
                case 12:// sobel
                    {
                        nguong = trkC.Value;
                        picSource.Enabled = false;
                        btnrun.Enabled = false;
                        lbprocess.Text = "Đang xử lý, vui lòng chờ";
                        this.Refresh();
                        var _task = Task.Run(() => _obj.Timbienanh(nguong));//chạy tác vụ trong luồng mới;
                        while (!_task.IsCompleted)//kiểm tra tác vụ đã hoàn thành hay chưa
                            await Task.Delay(100);// Nếu task chưa hoàn thành thì đợi 100ms trước khi kiểm tra lại.
                        picResult.Image = _task.Result;
                        lbprocess.Text = "";
                        btnrun.Enabled = true;
                        picSource.Enabled = true;
                        break;
                    }
                case 13:// laplace
                    nguong = trkC.Value;
                    picSource.Enabled = false;
                    btnrun.Enabled = false;
                    lbprocess.Text = "Đang xử lý, vui lòng chờ";
                    this.Refresh();
                    var _t = Task.Run(() => _obj.Laplace(nguong));//chạy tác vụ trong luồng mới;
                    while (!_t.IsCompleted)//kiểm tra tác vụ đã hoàn thành hay chưa
                        await Task.Delay(100);// Nếu task chưa hoàn thành thì đợi 100ms trước khi kiểm tra lại.
                    picResult.Image = _t.Result;
                    lbprocess.Text = "";
                    btnrun.Enabled = true;
                    picSource.Enabled = true;
                    break;
            }
        }
        //-------//
        private void lbsize_TextChanged(object sender, EventArgs e)
        {
            int size = int.Parse(txtsize.Text) * 2 + 1;
            if (int.Parse(txtk.Text) >= size * size)
            {
                txtk.Text = (size * size - 1).ToString();
            }
        }
        private void btnupsize_Click(object sender, EventArgs e)
        {
            int value = int.Parse(txtsize.Text);
            int newvalue = value + 1;
            txtsize.Text = newvalue.ToString();
            if (newvalue >= 10)
                txtsize.Text = "15";
            lbsize.Text = $"{newvalue * 2 + 1} x {newvalue * 2 + 1}";
        }
        private void btndownsize_Click(object sender, EventArgs e)
        {
            int value = int.Parse(txtsize.Text);
            int newvalue = value - 1;
            if (newvalue <= 0)
                newvalue = 1;
            txtsize.Text = newvalue.ToString();
            lbsize.Text = $"{newvalue * 2 + 1} x {newvalue * 2 + 1}";
        }
        private void btnupk_Click(object sender, EventArgs e)
        {
            txtk.Text = (int.Parse(txtk.Text) + 1).ToString();
            int size = int.Parse(txtsize.Text) * 2 + 1;
            if (int.Parse(txtk.Text) >= size * size)
            {
                txtk.Text = (size * size - 1).ToString();
            }
        }
        private void btndownk_Click(object sender, EventArgs e)
        {
            int values = (int.Parse(txtk.Text) - 1);
            if (values <= 0)
                values = 1;
            txtk.Text = values.ToString();
        }
        private void btndosang_Click(object sender, EventArgs e)
        {
            activebutton(sender);
            choose = 1;
            _manager.Set(0, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
        }
        private void btncovert_Click(object sender, EventArgs e)
        {
            choose = 2;
            activebutton(sender);
            _manager.Set(1, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
        }
        private void btnhistogram_Click(object sender, EventArgs e)
        {
            choose = 3;
            activebutton(sender);
            _manager.Set(2, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
        }
        private void btntachnguong_Click(object sender, EventArgs e)
        {
            choose = 4;
            activebutton(sender);
            lblC.Text = "0";
            _manager.Set(3, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
        }
        private void btniso_Click(object sender, EventArgs e)
        {
            choose = 5;
            activebutton(sender);
            _manager.Set(4, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
        }
        private void btnbocum_Click(object sender, EventArgs e)
        {
            choose = 6;
            activebutton(sender);
            _manager.Set(5, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
        }
        private void btntuongphan_Click(object sender, EventArgs e)
        {
            choose = 7;
            activebutton(sender);
            _manager.Set(6, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
        }
        private void btnamban_Click(object sender, EventArgs e)
        {
            choose = 8;
            activebutton(sender);
            _manager.Set(7, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
        }
        private void btntrungbinh_Click(object sender, EventArgs e)
        {
            choose = 9;
            activebutton(sender);
            txtk.Enabled = false;
            btndownk.Enabled = false;
            btnupk.Enabled = false;
            _manager.Set(8, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
        }
        private void btntrungvi_Click(object sender, EventArgs e)
        {
            choose = 10;
            activebutton(sender);
            _manager.Set(9, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
            txtk.Enabled = false;
            btndownk.Enabled = false;
            btnupk.Enabled = false;
        }
        private void btnloctheok_Click(object sender, EventArgs e)
        {
            choose = 11;
            activebutton(sender);
            _manager.Set(10, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
            txtk.Enabled = true;
            btndownk.Enabled = true;
            btnupk.Enabled = true;
        }
        private void btnsobel_Click(object sender, EventArgs e)
        {
            choose = 12;
            activebutton(sender);
            _manager.Set(11, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
        }

        private void btnlaplace_Click(object sender, EventArgs e)
        {
            choose = 13;
            activebutton(sender);
            _manager.Set(12, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
        }
        public bool IsTaskCompleted(Task task)
        {
            return task.IsCompleted;
        }
    }
}
