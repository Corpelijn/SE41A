using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FireBee.Controls
{
    public partial class Canvas : Control
    {
        public Canvas()
        {
            InitializeComponent();
            DoubleBuffered = true;
            
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
