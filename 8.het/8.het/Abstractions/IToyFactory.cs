using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _8.het.Entities;
using System.Drawing;
using System.Windows.Forms;

namespace _8.het.Abstractions
{
   public interface IToyFactory
    {
        Toy CreateNew();
    }
}
