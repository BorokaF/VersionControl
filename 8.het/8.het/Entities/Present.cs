using _8.het.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _8.het.Entities
{
    public class Present : Toy
    {
        public SolidBrush RibbonColor { get; private set; }
        public SolidBrush BoxColor { get; private set; }

        public Present(Color ribbonColor, Color boxColor)
        {
            RibbonColor = new SolidBrush(ribbonColor);
            BoxColor = new SolidBrush(boxColor);
        }

        protected override void DrawImage(Graphics g)
        {
            int ribbonSize = 10;
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, Width / 2 - ribbonSize / 2, 0, ribbonSize, Height);
            g.FillRectangle(RibbonColor, 0, Height / 2 - ribbonSize / 2, Width, ribbonSize);
        }
    }
}
