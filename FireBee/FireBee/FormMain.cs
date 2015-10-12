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
using FireBee.Brand;

namespace FireBee
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            tbWachtwoord.Text = "1";
            tbWachtwoord.Text = "";
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            Tools.ShowForm(new Brand.Brand());
            Tools.CloseForm(this);
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            Tools.ShowForm(new FormManagement());
            Tools.CloseForm(this);
        }
    }
}
