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
        clsmanage _manager = new clsmanage();
        Bitmap _imgSource = null;
        Bitmap _imgResult = null;
        public Frm()
        {
            InitializeComponent();
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
                if (rdoconvert.Checked)//chuyen anh mau sang anh xam
                    picResult.Image = Convertanhxam(_imgSource);
                else if (rdohistogram.Checked)//ve histogram
                {
                    _imgResult = Convertanhxam(_imgSource);//chuyển đổi ảnh sang ảnh xám trước khi vẽ histogram
                    picHistogram.Image = Vehistogram(GethistogramValue(_imgResult));
                    picHistogram.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    picResult.Image = _imgResult;
                }
                else if (rdoisodata.Checked)
                {
                    this.picResult.Image = TachnguongIso(_imgSource);
                }
                else if (rdotuongphan.Checked)
                {
                    this.picResult.Image = Tangdotuongphan(_imgSource);
                }
                else if (rdoamban.Checked)
                {
                    this.picResult.Image = Amban(_imgSource);
                }
                else if (rdotrungbinh.Checked)
                {
                    int size = Convert.ToInt32(txtsize.Text);
                    this.picResult.Image = Loctrungbinh(_imgSource, size);
                }
                else if (rdoloctrungvi.Checked)
                {
                    int size = Convert.ToInt32(txtsize.Text);
                    this.picResult.Image = Loctrungvi(_imgSource, size);
                }
                else if (rdoloctheok.Checked)
                {
                    int k =Convert.ToInt32(txtk.Text);
                    int size = Convert.ToInt32(txtsize.Text);
                    this.picResult.Image = LoctheoK(_imgSource,k,size);
                }
                else
                    picResult.Image = _imgResult;
            }
        }
        Task<Bitmap> thaydoidosang(Bitmap _imgsouce, Int32 Value)
        {
            Color color1;
            Color color2;
            Bitmap _Rs = new Bitmap(_imgsouce.Width, _imgsouce.Height);
            for (int x = 0; x < _imgsouce.Width; x++)
                for (int y = 0; y < _imgsouce.Height; y++)
                {
                    color1 = _imgSource.GetPixel(x, y);
                    int tmp = color1.R + Value;
                    if (tmp > 255)
                        color2 = Color.FromArgb(255, 255, 255);
                    else if (tmp < 0)
                        color2 = Color.FromArgb(0, 0, 0);
                    else
                        color2 = Color.FromArgb(tmp, tmp, tmp);
                    _Rs.SetPixel(x, y, color2);
                }
            return Task.FromResult(_Rs);
        }
        private async void trkC_ValueChanged(object sender, EventArgs e)
        {
            lblC.Text=trkC.Value.ToString();
            if (_imgSource != null)
            {
                    if(rdosang.Checked)
                        picResult.Image = await thaydoidosang(_imgSource, trkC.Value);
                    else if (rdotachnguong.Checked)
                    {
                        this.picResult.Image = Tachnguong(trkC.Value, _imgSource);
                    }
                    else if (rdobocum.Checked)
                    {
                        this.picResult.Image = Bocum( _imgSource, trkC.Value);
                    }
                else if(rdobienanh.Checked)
                        this.picResult.Image = Timbienanh(_imgSource, trkC.Value);
                    else if (rdolaplace.Checked)
                        this.picResult.Image = Laplace(_imgSource, trkC.Value);
                


            }

        }
        Bitmap Tachnguong(int nguong, Bitmap _img)
        {
            _img = Convertanhxam(_img);//chuyển sang ảnh xám;
            Bitmap _Rs = new Bitmap(_img.Width, _img.Height);
            for (int x = 0; x < _img.Width; x++)
                for (int y = 0; y < _img.Height; y++)
                {
                    int color = _img.GetPixel(x, y).R;
                    if (color >= nguong)
                        _Rs.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    else
                        _Rs.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            return _Rs;
        }
        Bitmap TachnguongIso(Bitmap _img)
        {
            _img = Convertanhxam(_img);
            int gray = 0;
            Bitmap _Rs = new Bitmap(_img.Width, _img.Height);
            //tính trung bình mức xám 
            for (int x = 0; x < _img.Width; x++)
                for (int y = 0; y < _img.Height; y++)
                {
                    gray += _img.GetPixel(x, y).R;
                }
            int threshold = gray / (_img.Width * _img.Height);//ngưỡng ban đầu
            int oldthreadold = 0;
            while (threshold != oldthreadold)
            {
                // Tính trung bình của hai nhóm điểm ảnh được tách ra bởi ngưỡng hiện tại
                double sum1 = 0, sum2 = 0;
                int count1 = 0, count2 = 0;
                for (int x = 0; x < _img.Width; x++)
                {
                    for (int y = 0; y < _img.Height; y++)
                    {

                        int grayScale = _img.GetPixel(x, y).R;
                        if (grayScale < threshold)
                        {
                            sum1 += grayScale;
                            count1++;
                        }
                        else
                        {
                            sum2 += grayScale;
                            count2++;
                        }
                    }
                }
                double mean1 = sum1 / count1;
                double mean2 = sum2 / count2;

                // Cập nhật ngưỡng
                oldthreadold = threshold;
                threshold = (int)((mean1 + mean2) / 2);
            }
            // tạo ảnh nhị phân bằng ngưỡng mới
            for (int x = 0; x < _img.Width; x++)
                for (int y = 0; y < _img.Height; y++)
                {
                    int grayScale = _img.GetPixel(x, y).R;
                    if (grayScale < threshold)
                        _Rs.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        _Rs.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            return _Rs;
        }
        Bitmap Tangdotuongphan(Bitmap _img)//Linear Contrast Stretching
        {
            int gray = 0;
            int maxgray = 0;
            int mingray = 255;
            _img = Convertanhxam(_img);
            Bitmap _Rs = new Bitmap(_img.Width, _img.Height);
            for (int x = 0; x < _img.Width; x++)
                for (int y = 0; y < _img.Height; y++)
                {
                    if (_img.GetPixel(x, y).R > maxgray)
                    {
                        maxgray = _img.GetPixel(x, y).R; //mức xám lớn nhất
                    }
                    if (_img.GetPixel(x, y).R < mingray)
                    {
                        mingray = _img.GetPixel(x, y).R;//mức xám nhỏ nhất
                    }
                    gray += _img.GetPixel(x, y).R;
                }
            int avg = gray / (_img.Width * _img.Height);//trung bình mức xám trong ảnh
            //tăng độ tương phản cho từng điểm ảnh
            for (int x = 0; x < _img.Width; x++)
                for (int y = 0; y < _img.Height; y++)
                {
                    int current = _img.GetPixel(x, y).R;
                    double newcolor = (double)(current - mingray) / (double)(maxgray - mingray);
                    newcolor = newcolor * 255;
                    // newgray = Math.Max(0, Math.Min(255, newgray));
                    _Rs.SetPixel(x, y, Color.FromArgb((int)newcolor, (int)newcolor, (int)newcolor));
                }
            return _Rs;
        }
        Bitmap Amban(Bitmap _img)
        {
            _img = Convertanhxam(_img);
            Bitmap _Rs = new Bitmap(_img.Width, _img.Height);
            for (int x = 0; x < _img.Width; x++)
                for (int y = 0; y < _img.Height; y++)
                {
                    int color = _img.GetPixel(x, y).R;
                    _Rs.SetPixel(x, y, Color.FromArgb(255 - color, 255 - color, 255 - color));
                }
            return _Rs;
        }
        int avg(Bitmap _img, int x, int y, int _size)
        {
            int count = 0;
            int sum = 0;
            //chạy trong khoảng ma trận vuông truyền vào
            for (int i = x - _size; i <= x + _size; i++)
            {
                for (int j = y - _size; j <= y + _size; j++)
                {
                    if (i >= 0 && i < _img.Width && j >= 0 && j < _img.Height)
                    {
                        count++;
                        sum += _img.GetPixel(i, j).R;
                    }
                }
            }
            return (int)Math.Round((double)sum / (double)count);
        }
        Bitmap Loctrungbinh(Bitmap _img, int _size)
        {
            Bitmap _Rs = Convertanhxam(_img);
            for (int x = _size; x < _img.Width - _size; x++)
            {
                for (int y = _size; y < _img.Height - _size; y++)
                {
                    int newcolor = avg(_img, x, y, _size);
                    _Rs.SetPixel(x, y, Color.FromArgb(newcolor, newcolor, newcolor));
                }
            }
            return _Rs;
        }
        int Trungvi(Bitmap _img, int x, int y, int _size)
        {
            List<int> arr = new List<int>();
            //lấy giá trị trong khung ma trận vào một list
            for (int i = x - _size; i <= x + _size; i++)
            {
                for (int j = y - _size; j <= y + _size; j++)
                {
                    if (i >= 0 && i < _img.Width && j >= 0 && j < _img.Height)
                    {
                        arr.Add(_img.GetPixel(i, y).R);
                    }
                }
            }
            arr.Sort();
            return arr[arr.Count / 2];
        }
        Bitmap Loctrungvi(Bitmap _img, int _size)
        {
            Bitmap _Rs = Convertanhxam(_img);
            for (int x = _size; x <= _img.Width - _size; x++)
            {
                for (int y = _size; y <= _img.Height - _size; y++)
                {
                    int oldcolor = _img.GetPixel(x, y).R;
                    int newcolor = Trungvi(_img, x, y, _size);
                    _Rs.SetPixel(x, y, Color.FromArgb(newcolor, newcolor, newcolor));
                }
            }
            return _Rs;
        }
        Bitmap Bocum(Bitmap _img, int bunch_size)
        {
            _img = Convertanhxam(_img);
            Bitmap _Rs = new Bitmap(_img.Width, _img.Height);
            for (int x = 0; x < _img.Width; x++)
            {
                for (int y = 0; y < _img.Height; y++)
                {
                    int oldcolor = _img.GetPixel(x, y).R;
                    int newcolor = oldcolor / bunch_size * bunch_size;
                    _Rs.SetPixel(x, y, Color.FromArgb(newcolor, newcolor, newcolor));
                }
            }
            return _Rs;
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
            if (_imgResult == null)
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
        private void rdosang_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            switch (radio.Name)
            {
                case "rdosang":
                    _manager.Set(0, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    break;
                case "rdoconvert":
                    _manager.Set(1, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    break;
                case "rdohistogram":
                    _manager.Set(2, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    break;
                case "rdotachnguong":
                    _manager.Set(3, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    lblC.Text = "0";
                    break;
                case "rdoisodata":
                    _manager.Set(4, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    break;
                case "rdobocum":
                    _manager.Set(5, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    break;
                case "rdotuongphan":
                    _manager.Set(6, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    break;
                case "rdoamban":
                    _manager.Set(7, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    break;
                case "rdotrungbinh":
                    _manager.Set(8, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    txtk.Enabled = false;
                    btndownk.Enabled = false;
                    btnupk.Enabled = false;
                    break;
                case "rdoloctrungvi":
                    _manager.Set(9, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    txtk.Enabled = false;
                    btndownk.Enabled = false;
                    btnupk.Enabled = false;
                    break;
                case "rdoloctheok":
                    _manager.Set(10, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    txtk.Enabled = true;
                    btndownk.Enabled = true;
                    btnupk.Enabled = true;
                    break;
                case "rdobienanh":
                    _manager.Set(11, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    break;
                case "rdolaplace":
                    _manager.Set(11, Image, Parameter, grbHistogram, grbmatrix, lbbar, trkC);
                    break;
            }
        }
        Bitmap Convertanhxam(Bitmap input)//hàm chuyển ảnh màu sang ảnh xám
        {
            Bitmap output = new Bitmap(input.Width, input.Height);
            for (int x = 0; x < input.Width; x++)
                for (int y = 0; y < input.Height; y++)
                {
                    Color current = input.GetPixel(x, y);
                    var avg = (current.R + current.G + current.B) / 3;
                    output.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            return output;
        }
        int[] GethistogramValue(Bitmap _hinhxam)
        {
            byte mucxam;
            int[] histogram = new int[256];
            for (int x = 0; x < _hinhxam.Width; x++)
                for (int y = 0; y < _hinhxam.Height; y++)
                {
                    mucxam = _hinhxam.GetPixel(x, y).R;
                    histogram[mucxam]++;
                }
            return histogram;
        }
        Bitmap Vehistogram(int[] data)
        {
            Bitmap _his = new Bitmap(256, 300);
            int _tyley = Convert.ToInt32(Math.Ceiling(Findmax(data) / 300));//tỉ lệ biểu đồ cho khớp với picbox lam tron len
            for (int x = 0; x < data.Length; x++)
            {
                //_his.SetPixel(x, GethistogramValue(_imgResult)[x] / _tyley, Color.Red);
                using (var graphics = Graphics.FromImage(_his))
                {
                    graphics.DrawLine(new Pen(Color.Red, 1), x, 0, x, data[x] / _tyley);
                }
            }
            return _his;
        }
        double Findmax(int[] arr)
        {
            double max = 0;
            foreach (var i in GethistogramValue(_imgResult))
                if (i > max)
                    max = i;
            return max;
        }
        Bitmap Timbienanh(Bitmap _img, int nguong)//Giai thuat Sobel 
        {
            int[,] Hx =
            {
                { -1,0,1},
                {-2,0,2 },
                {-1,0,1}
            };
            int[,] Hy =
            {
                { -1,-2,-1},
                {0,0,0 },
                {1,2,1}
            };
            Bitmap _imgresult = Convertanhxam(_img);
            for (int x = 1; x < _img.Width - 1; x++)
                for (int y = 1; y < _img.Height - 1; y++)
                {
                    //I*Hx
                    int dx = _img.GetPixel(x - 1, y - 1).R * Hx[0, 0] + _img.GetPixel(x - 1, y + 1).R * Hx[0, 2] + _img.GetPixel(x, y - 1).R * Hx[1, 0] +
                            _img.GetPixel(x, y + 1).R * Hx[1, 2] + _img.GetPixel(x + 1, y - 1).R * Hx[2, 0] + _img.GetPixel(x + 1, y + 1).R * Hx[2, 2];
                    //I*Hy
                    int dy = _img.GetPixel(x - 1, y - 1).R * Hy[0, 0] + _img.GetPixel(x - 1, y).R * Hy[0, 1] + _img.GetPixel(x - 1, y + 1).R * Hy[0, 2] +
                             _img.GetPixel(x + 1, y - 1).R * Hy[2, 0] + _img.GetPixel(x + 1, y).R * Hy[2, 1] + _img.GetPixel(x + 1, y + 1).R * Hy[2, 2];
                    double derivata = Math.Sqrt((dx * dx) + (dy * dy));
                    if (derivata > nguong)
                    {
                        _imgresult.SetPixel(x, y, Color.Red);//set màu đỏ vào biên đã phát hiện
                    }
                }
            return _imgresult;
        }
        int avgK(Bitmap _img, int x, int y, int k, int _size)
        {
            List<int> values = new List<int>();
            int sum = 0;
            //chạy trong ma trận vuông
            for (int i = x - _size; i <= x + _size; i++)
            {
                for (int j = y - _size; j <= y + _size; j++)
                {
                    if (i >= 0 && i < _img.Width && j >= 0 && j < _img.Height)
                    {
                        values.Add(_img.GetPixel(i, j).R);
                    }
                }
            }
            int number = values[values.Count / 2];
            values.RemoveAt(values.Count / 2);
            int[] arr = new int[values.Count];
            for (int i = 0; i < values.Count; i++)
            {
                arr[i] = values[i];
            }
            Array.Sort(arr, (a, b) => Math.Abs(a - number).CompareTo(Math.Abs(b - number)));
            for (int i = 0; i < k; i++)
            {
                sum += arr[i];
            }
            return sum / k;
        }
        Bitmap LoctheoK(Bitmap _img, int k, int _size)
        {
            Bitmap _Rs = Convertanhxam(_img);
            for (int x = _size; x < _img.Width -_size; x++)
            {
                for (int y = _size; y < _img.Height -_size; y++)
                {
                    int oldcolor = _img.GetPixel(x, y).R;//thêm để debug
                    int newcolor = avgK(_img, x, y, k, _size);
                    _Rs.SetPixel(x, y, Color.FromArgb(newcolor, newcolor, newcolor));
                }
            }
            return _Rs;
        }
        Bitmap Laplace(Bitmap _img, int nguong)
        {
            Bitmap _Rs = Convertanhxam(_img);
            int[,] laplace =
            {
                {0,1,0},
                {1,-4,1},
                {0,1,0 }
            };
            for (int x = 1; x < _img.Width - 1; x++)
                for (int y = 1; y < _img.Height - 1; y++)
                {
                    //I*Laplace
                    int sold = _img.GetPixel(x - 1, y - 1).R * laplace[0, 0] + _img.GetPixel(x - 1, y).R * laplace[0, 1] + _img.GetPixel(x - 1, y + 1).R * laplace[0, 2] +
                        _img.GetPixel(x, y - 1).R * laplace[1, 0] + _img.GetPixel(x, y).R * laplace[1, 1] + _img.GetPixel(x, y + 1).R * laplace[1, 2] +
                        _img.GetPixel(x + 1, y - 1).R * laplace[2, 0] + _img.GetPixel(x + 1, y).R * laplace[2, 1] + _img.GetPixel(x + 1, y + 1).R * laplace[2, 2];
                    if (sold > nguong)
                    {
                        _Rs.SetPixel(x, y, Color.Red);
                    }
                }
            return _Rs;
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
            txtsize.Text= newvalue.ToString();
            lbsize.Text = $"{newvalue * 2 + 1} x {newvalue * 2 + 1}";
        }

        private void btnupk_Click(object sender, EventArgs e)
        {
            txtk.Text = (int.Parse(txtk.Text) + 1).ToString();
            int size = int.Parse(txtsize.Text)*2+1;
            if (int.Parse(txtk.Text) >=size*size)
            {
                txtk.Text = (size * size-1).ToString();
            }
        }
        private void btndownk_Click(object sender, EventArgs e)
        {
            int values = (int.Parse(txtk.Text) - 1);
            if (values <= 0)
                values = 1;
            txtk.Text = values.ToString();
        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            if (rdotrungbinh.Checked &&_imgSource!=null)
            {
                int size = Convert.ToInt32(txtsize.Text);
                this.picResult.Image = Loctrungbinh(_imgSource, size);
            }
           else if (rdoloctrungvi.Checked && _imgSource != null)
            {
                int size = Convert.ToInt32(txtsize.Text);
                this.picResult.Image = Loctrungvi(_imgSource, size);
            }
            else if (rdoloctheok.Checked && _imgSource != null)
            {
                int k = Convert.ToInt32(txtk.Text);
                int size = Convert.ToInt32(txtsize.Text);
                this.picResult.Image = LoctheoK(_imgSource, k, size);
            }
        }
        private void lbsize_TextChanged(object sender, EventArgs e)
        {
            int size = int.Parse(txtsize.Text) * 2 + 1;
            if (int.Parse(txtk.Text)>=size*size)
            {
                txtk.Text = (size * size-1).ToString();
            }
        }
    }
}
