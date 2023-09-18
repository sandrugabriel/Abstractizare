using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Models
{
    public interface IDraw
    {
        void draw(PictureBox pctDesen, Graphics graphics);

    }
}
