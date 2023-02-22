using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                    _imgResult=Convertanhxam(_imgSource);//chuyển đổi ảnh sang ảnh xám trước khi vẽ histogram
                    picHistogram.Image = Vehistogram(GethistogramValue(_imgResult));
                    picHistogram.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    picResult.Image = _imgResult;
                }
                else if (rdobienanh.Checked)
                {
                  picResult.Image= Timbienanh(_imgResult);
                }
                else
                    picResult.Image = _imgResult;

                /*picResult.Refresh();*/
            }
        }
        private void trkC_ValueChanged(object sender, EventArgs e)
        {
            lblC.Text = trkC.Value.ToString();
            if (_imgSource == null)
                return;
            int c = trkC.Value;
            Color color1;
            Color color2;
            for (int x = 0; x < _imgSource.Width; x++)
                for (int y = 0; y < _imgSource.Height; y++)
                {
                    color1 = _imgSource.GetPixel(x, y);
                    int tmp = color1.R + c;
                    if (tmp > 255)
                        color2 = Color.FromArgb(255, 255, 255);
                    else if (tmp < 0)
                        color2 = Color.FromArgb(0, 0, 0);
                    else
                        color2 = Color.FromArgb(tmp, tmp, tmp);
                    _imgResult.SetPixel(x, y, color2);
                }
            picResult.Image = _imgResult;
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
            if (rdosang.Checked)
                _manager.Set(0, Image, Parameter, grbHistogram);
            else if (rdoconvert.Checked)
                _manager.Set(1, Image, Parameter, grbHistogram);
            else if (rdohistogram.Checked)
                _manager.Set(2, Image, Parameter, grbHistogram);
            else if (rdobienanh.Checked)
                _manager.Set(3, Image, Parameter, grbHistogram);
        }
        Bitmap Convertanhxam(Bitmap input)//hàm chuyển ảnh màu sang ảnh xám
        {
            Bitmap output=new Bitmap(input.Width, input.Height);
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
            int _tyley =Convert.ToInt32(Math.Ceiling(Findmax(data) /300));//tỉ lệ biểu đồ cho khớp với picbox lam tron len
            for(int x=0;x<data.Length;x++)
            {
                //_his.SetPixel(x, GethistogramValue(_imgResult)[x] / _tyley, Color.Red);
                using (var graphics = Graphics.FromImage(_his))
                {
                    graphics.DrawLine(new Pen(Color.Red,1), x, 0, x, data[x] / _tyley);
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
          Bitmap Timbienanh(Bitmap _img)//ky thuat Sobel 
        {
            int[,] Hx =
            {
                { -1,0,1},
                {-1,0,2 },
                {-1,0,1}
            };
            int[,] Hy =
            {
                { -1,-2,-1},
                {0,0,0 },
                {1,2,1}
            };
            Bitmap _imgresult=new Bitmap(_img.Width, _img.Height);
            int dx = 0; int dy = 0;
            for (int x=1;x<_img.Width-1;x++)
                for(int y = 1; y < _img.Height-1; y++)
                {
                    //I*Hx
                    dx = _img.GetPixel(x - 1, y - 1).R * Hx[0, 0] + _img.GetPixel(x - 1, y).R * Hx[1, 0] + _img.GetPixel(x - 1, y + 1).R * Hx[1, 0] +
                        _img.GetPixel(x, y - 1).R * Hx[0, 1] + _img.GetPixel(x, y).R * Hx[1, 1] + _img.GetPixel(x, y + 1).R * Hx[2, 1] +
                         _img.GetPixel(x + 1, y - 1).R * Hx[0, 2] + _img.GetPixel(x + 1, y).R * Hx[1, 2] + _img.GetPixel(x + 1, y + 1).R * Hx[2, 2];
                    //I*Hy
                    dy= _img.GetPixel(x - 1, y - 1).R * Hy[0, 0] + _img.GetPixel(x - 1, y).R * Hy[0, 1] + _img.GetPixel(x - 1, y + 1).R * Hy[0, 2] +
                        _img.GetPixel(x, y - 1).R * Hy[1, 0] + _img.GetPixel(x, y).R * Hy[1, 1] + _img.GetPixel(x, y + 1).R * Hy[1, 2] +
                         _img.GetPixel(x + 1, y - 1).R * Hy[2, 0] + _img.GetPixel(x + 1, y).R * Hy[2, 1] + _img.GetPixel(x + 1, y + 1).R * Hy[2, 2];
                    double derivata = Math.Sqrt((dx * dx) + (dy * dy));
                    if (derivata > 255)
                    {
                        _imgresult.SetPixel(x, y, Color.Red);//set màu đỏ vào biên đã phát hiện
                    }
                    else
                        _imgresult.SetPixel(x, y, Color.FromArgb(Convert.ToInt32(derivata), Convert.ToInt32(derivata), Convert.ToInt32(derivata)));//set màu cũ
                }
            return _imgresult;
        }
      
        
    }
}
