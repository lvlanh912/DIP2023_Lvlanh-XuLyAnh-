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
       public void Set(int _state,GroupBox a,GroupBox b,GroupBox histogram)
        {
            if(_state == 0)
            {
                a.Enabled = true;
                b.Visible = true;
                histogram.Visible = false;
            }
           else if (_state == 1)
            {
                a.Enabled = true;
                b.Visible = false;
                histogram.Visible = false;
            }
           else if (_state == 2)
            {
                a.Enabled = true;
                b.Visible = false;
                histogram.Visible = true;
            }
            else if (_state == 3)
            {
                a.Enabled = true;
                b.Visible = false;
                histogram.Visible = false;
            }
        }
    }
}
