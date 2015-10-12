using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FireBee.Extensions;
using FireBee.Forms;
using FireBee.Forms.Management;
using FireBee.Domain;

namespace FireBee
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.SetView(new FormLogin());
        }
    }
}
