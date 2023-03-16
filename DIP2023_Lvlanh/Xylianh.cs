using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP2023_Lvlanh
{
    public class Xulianh
    {
   internal Bitmap _image;
        public Xulianh(Bitmap input) => this._image = input;
        internal Task<Bitmap> thaydoidosang( Int32 Value)//thay đổi độ sáng
        {
        Color color1;
        Color color2;
        Bitmap _Rs = new Bitmap(_image.Width, _image.Height);
        for (int x = 0; x < _image.Width; x++)
            for (int y = 0; y < _image.Height; y++)
            {
                color1 = _image.GetPixel(x, y);
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
        internal Task<Bitmap> Tachnguong(int nguong)//tách ngưỡng
        {
            _image =Convertanhxam();//chuyển sang ảnh xám;
            Bitmap _Rs = new Bitmap(_image.Width, _image.Height);
            for (int x = 0; x < _image.Width; x++)
                for (int y = 0; y < _image.Height; y++)
                {
                    int color = _image.GetPixel(x, y).R;
                    if (color >= nguong)
                        _Rs.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    else
                        _Rs.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            return Task.FromResult(_Rs);
        }
        internal Task<Bitmap> TachnguongIso()//tách ngưỡng tự động
        {
            _image =Convertanhxam();
            int gray = 0;
            Bitmap _Rs = new Bitmap(_image.Width, _image.Height);
            //tính trung bình mức xám 
            for (int x = 0; x < _image.Width; x++)
                for (int y = 0; y < _image.Height; y++)
                {
                    gray += _image.GetPixel(x, y).R;
                }
            int threshold = gray / (_image.Width * _image.Height);//ngưỡng ban đầu
            int oldthreadold = 0;
            while (threshold != oldthreadold)
            {
                // Tính trung bình của hai nhóm điểm ảnh được tách ra bởi ngưỡng hiện tại
                double sum1 = 0, sum2 = 0;
                int count1 = 0, count2 = 0;
                for (int x = 0; x < _image.Width; x++)
                {
                    for (int y = 0; y < _image.Height; y++)
                    {

                        int grayScale = _image.GetPixel(x, y).R;
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
            for (int x = 0; x < _image.Width; x++)
                for (int y = 0; y < _image.Height; y++)
                {
                    int grayScale = _image.GetPixel(x, y).R;
                    if (grayScale < threshold)
                        _Rs.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        _Rs.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            return Task.FromResult(_Rs); 
        }
        internal Task<Bitmap> Tangdotuongphan()//Tăng độ tương phản (Contrast Stretching)
        {
            int gray = 0;
            int maxgray = 0;
            int mingray = 255;
            _image =Convertanhxam();
            Bitmap _Rs = new Bitmap(_image.Width, _image.Height);
            for (int x = 0; x < _image.Width; x++)
                for (int y = 0; y < _image.Height; y++)
                {
                    if (_image.GetPixel(x, y).R > maxgray)
                    {
                        maxgray = _image.GetPixel(x, y).R; //mức xám lớn nhất
                    }
                    if (_image.GetPixel(x, y).R < mingray)
                    {
                        mingray = _image.GetPixel(x, y).R;//mức xám nhỏ nhất
                    }
                    gray += _image.GetPixel(x, y).R;
                }
            //tăng độ tương phản cho từng điểm ảnh
            for (int x = 0; x < _image.Width; x++)
                for (int y = 0; y < _image.Height; y++)
                {
                    int current = _image.GetPixel(x, y).R;
                    double newcolor = (double)(current - mingray) / (double)(maxgray - mingray);
                    newcolor = newcolor * 255;
                    // newgray = Math.Max(0, Math.Min(255, newgray));
                    _Rs.SetPixel(x, y, Color.FromArgb((int)newcolor, (int)newcolor, (int)newcolor));
                }
            return Task.FromResult(_Rs); ;
        }
        internal Task<Bitmap> Amban()//tạo ảnh âm bản
        {
            _image =Convertanhxam();
            Bitmap _Rs = new Bitmap(_image.Width, _image.Height);
            for (int x = 0; x < _image.Width; x++)
                for (int y = 0; y < _image.Height; y++)
                {
                    int color = _image.GetPixel(x, y).R;
                    _Rs.SetPixel(x, y, Color.FromArgb(255 - color, 255 - color, 255 - color));
                }
            return Task.FromResult(_Rs); ;
        }
        int avg(Bitmap _img, int x, int y, int _size)
        {
            double count = Math.Pow(_size * 2 + 1, 2);
            int sum = 0;
            for (int i = x - _size; i <= x + _size; i++)
            {
                for (int j = y - _size; j <= y + _size; j++)
                {
                    if (i >= 0 && i < _img.Width && j >= 0 && j < _img.Height)
                    {
                        //count++;
                        sum += _img.GetPixel(i, j).R;
                    }
                }
            }
            return (int)Math.Round((double)sum / count);
        }
        internal  Task<Bitmap> Loctrungbinh( int _size)//lọc trung bình
        {
            Bitmap _Rs =Convertanhxam();
            for (int x = _size; x < _image.Width - _size; x++)
            {
                for (int y = _size; y < _image.Height - _size; y++)
                {
                    int newcolor = avg(_image, x, y, _size);
                    _Rs.SetPixel(x, y, Color.FromArgb(newcolor, newcolor, newcolor));
                }
            }
            return Task.FromResult(_Rs); 
        }
        internal int Trungvi( int x, int y, int _size)
        {
            List<int> arr = new List<int>();
            //lấy giá trị trong khung ma trận vào một list
            for (int i = x - _size; i <= x + _size; i++)
            {
                for (int j = y - _size; j <= y + _size; j++)
                {
                    if (i >= 0 && i < _image.Width && j >= 0 && j < _image.Height)
                    {
                        arr.Add(_image.GetPixel(i, y).R);
                    }
                }
            }
            arr.Sort();
            return arr[arr.Count / 2];
        }
        internal Task<Bitmap> Loctrungvi( int _size)//lọc trung vị
        {
            Bitmap _Rs =Convertanhxam();
            for (int x = _size; x <= _image.Width - _size; x++)
            {
                for (int y = _size; y <= _image.Height - _size; y++)
                {
                    int oldcolor = _image.GetPixel(x, y).R;
                    int newcolor = Trungvi( x, y, _size);
                    _Rs.SetPixel(x, y, Color.FromArgb(newcolor, newcolor, newcolor));
                }
            }
            return Task.FromResult(_Rs); 
        }
        internal Task<Bitmap> Bocum( int bunch_size)//bó cụm
        {
            _image =Convertanhxam();
            Bitmap _Rs = new Bitmap(_image.Width, _image.Height);
            for (int x = 0; x < _image.Width; x++)
            {
                for (int y = 0; y < _image.Height; y++)
                {
                    int oldcolor = _image.GetPixel(x, y).R;
                    int newcolor = oldcolor / bunch_size * bunch_size;
                    _Rs.SetPixel(x, y, Color.FromArgb(newcolor, newcolor, newcolor));
                }
            }
            return Task.FromResult(_Rs); 
        }
        internal Bitmap Convertanhxam()//hàm chuyển ảnh màu sang ảnh xám
        {
                Bitmap _Rs = new Bitmap(_image.Width, _image.Height);
                for (int x = 0; x < _image.Width; x++)
                    for (int y = 0; y < _image.Height; y++)
                    {
                        Color current = _image.GetPixel(x, y);
                        var avg = (current.R + current.G + current.B) / 3;
                        _Rs.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                    }
            return _Rs; 
        }
        internal int[] GethistogramValue(Bitmap _hinhxam)
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
        internal Task<Bitmap> Vehistogram()//vẽ histogram
        {
            int[] data = GethistogramValue(Convertanhxam());
            Bitmap _his = new Bitmap(256, 300);
            int _tyley = Convert.ToInt32(Math.Ceiling((double)data.Max() / 300));//tỉ lệ biểu đồ cho khớp với picbox lam tron len
            for (int x = 0; x < data.Length; x++)
            {
                //_his.SetPixel(x, GethistogramValue(_imgResult)[x] / _tyley, Color.Red);
                using (var graphics = Graphics.FromImage(_his))
                {
                    graphics.DrawLine(new Pen(Color.Red, 1), x, 0, x, data[x] / _tyley);//vẽ đường thẳng
                }
            }
            return Task.FromResult(_his); 
        }
        internal Task<Bitmap> Timbienanh( int nguong)//Nổi biên (Giai thuat Sobel) 
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
                Bitmap _Rs =Convertanhxam();
                for (int x = 1; x < _image.Width - 1; x++)
                    for (int y = 1; y < _image.Height - 1; y++)
                    {
                        //I*Hx
                        int dx = _image.GetPixel(x - 1, y - 1).R * Hx[0, 0] + _image.GetPixel(x - 1, y + 1).R * Hx[0, 2] + _image.GetPixel(x, y - 1).R * Hx[1, 0] +
                                _image.GetPixel(x, y + 1).R * Hx[1, 2] + _image.GetPixel(x + 1, y - 1).R * Hx[2, 0] + _image.GetPixel(x + 1, y + 1).R * Hx[2, 2];
                        //I*Hy
                        int dy = _image.GetPixel(x - 1, y - 1).R * Hy[0, 0] + _image.GetPixel(x - 1, y).R * Hy[0, 1] + _image.GetPixel(x - 1, y + 1).R * Hy[0, 2] +
                                 _image.GetPixel(x + 1, y - 1).R * Hy[2, 0] + _image.GetPixel(x + 1, y).R * Hy[2, 1] + _image.GetPixel(x + 1, y + 1).R * Hy[2, 2];
                        double derivata = Math.Sqrt((dx * dx) + (dy * dy));
                        if (derivata > nguong)
                        {
                            _Rs.SetPixel(x, y, Color.Red);//set màu đỏ vào biên đã phát hiện
                        }
                    }
            return Task.FromResult(_Rs); 
        }
        internal int avgK( int x, int y, int k, int _size) //tính trung bình của k gần nhất
        {
            List<int> values = new List<int>();
            int sum = 0;
            for (int i = x - _size; i <= x + _size; i++)
            {
                for (int j = y - _size; j <= y + _size; j++)
                {
                    if (i >= 0 && i < _image.Width && j >= 0 && j < _image.Height)
                    {
                        values.Add(_image.GetPixel(i, j).R);
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
        internal Task<Bitmap> LoctheoK( int k, int _size)//lọc theo k gần nhất
        {
            Bitmap _Rs =Convertanhxam();
            for (int x = _size; x < _image.Width - _size; x++)
            {
                for (int y = _size; y < _image.Height - _size; y++)
                {
                    //int oldcolor = _image.GetPixel(x, y).R;//thêm để debug
                    int newcolor = avgK( x, y, k, _size);
                    _Rs.SetPixel(x, y, Color.FromArgb(newcolor, newcolor, newcolor));
                }
            }
            return Task.FromResult(_Rs);
        }
        internal Task<Bitmap> Laplace( int nguong)//làm nổi biên(Laplace)
        {
            Bitmap _Rs =Convertanhxam();
            int[,] laplace =
            {
                {0,1,0},
                {1,-4,1},
                {0,1,0 }
            };
            for (int x = 1; x < _image.Width - 1; x++)
                for (int y = 1; y < _image.Height - 1; y++)
                {
                    //I*Laplace
                    int sold = _image.GetPixel(x - 1, y - 1).R * laplace[0, 0] + _image.GetPixel(x - 1, y).R * laplace[0, 1] + _image.GetPixel(x - 1, y + 1).R * laplace[0, 2] +
                        _image.GetPixel(x, y - 1).R * laplace[1, 0] + _image.GetPixel(x, y).R * laplace[1, 1] + _image.GetPixel(x, y + 1).R * laplace[1, 2] +
                        _image.GetPixel(x + 1, y - 1).R * laplace[2, 0] + _image.GetPixel(x + 1, y).R * laplace[2, 1] + _image.GetPixel(x + 1, y + 1).R * laplace[2, 2];
                    if (sold > nguong)
                    {
                        _Rs.SetPixel(x, y, Color.Red);
                    }
                }
            return Task.FromResult(_Rs);
        }
    }
}
