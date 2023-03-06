using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP2023_Lvlanh
{
    public class clsmanage
    {
       public void Set(int _state,GroupBox a,GroupBox bar,GroupBox histogram,GroupBox size, Label lbbar,TrackBar trc)
        {
            switch (_state)
            {
                case 0://tăng giảm độ sáng
                    trc.Minimum = -255;
                    lbbar.Text = "thay dổi giá trị để tăng giảm độ sáng";
                    a.Enabled = true;
                    bar.Visible = true;
                    histogram.Visible = false;
                    size.Visible = false;
                    break;
                case 1://chuyển ảnh xám
                    a.Enabled = true;
                    bar.Visible = false;
                    histogram.Visible = false;
                    size.Visible = false;
                    size.Visible = false;
                    break ;
                case 2://vẽ histogram
                    a.Enabled = true;
                    bar.Visible = false;
                    histogram.Visible = true;
                    size.Visible = false;
                    size.Visible = false;
                    break ;
                case 3://tách ngưỡng cố định
                    trc.Minimum = 0;
                    lbbar.Text = "chọn ngưỡng";
                    a.Enabled = true;
                    bar.Visible = true;
                    histogram.Visible = false;
                    size.Visible = false;
                    break;
                case 4://tách ngưỡng tự dộng
                    a.Enabled = true;
                    bar.Visible = false;
                    size.Visible = false;
                    histogram.Visible = false;
                    break;
                case 5://bó cụm
                    trc.Minimum = 0;
                    lbbar.Text = "chọn bunch_size";
                    a.Enabled = true;
                    bar.Visible = true;
                    size.Visible = false;
                    histogram.Visible = false;
                    break;
                case 6://tăng tương phản 
                    trc.Minimum = 0;
                    lbbar.Text = "kéo để tùy chỉnh";
                    a.Enabled = true;
                    bar.Visible = true;
                    size.Visible = false;
                    histogram.Visible = false;
                    break;
                case 7://tạo âm bản
                    lbbar.Text = "chọn ngưỡng";
                    a.Enabled = true;
                    bar.Visible = false;
                    histogram.Visible = false;
                    size.Visible = false;
                    break;
                case 8://lọc trung bình
                    a.Enabled = true;
                    bar.Visible = false;
                    histogram.Visible = false;
                    size.Visible = true;
                    break;
                case 9://lọc trung vị
                    a.Enabled = true;
                    bar.Visible = false;
                    histogram.Visible = false;
                    size.Visible = true;
                    break;
                case 10://lọc theo k gần nhất
                    a.Enabled = true;
                    bar.Visible = false;
                    histogram.Visible = false;
                    size.Visible = true;
                    break;
                case 11://tìm biên ảnh
                    trc.Minimum = 0;
                    lbbar.Text = "chọn ngưỡng";
                    a.Enabled = true;
                    bar.Visible = true;
                    histogram.Visible = false;
                    size.Visible = false;
                    break;
                case 12://tìm biên laplace
                    trc.Minimum = 0;
                    lbbar.Text = "chọn ngưỡng";
                    a.Enabled = true;
                    bar.Visible = true;
                    histogram.Visible = false;
                    size.Visible = false;
                    break;


            }
            
        }
    }
}
