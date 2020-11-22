using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using _8.het.Abstractions;

namespace _8.het.Entities
{
   public class Ball : Toy
    {

     

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }

       
    }
    

}
