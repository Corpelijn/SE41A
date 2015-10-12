using System;
using System.Windows.Forms;
using FireBee.Extensions;
using FireBee.Forms.Fire;

namespace FireBee.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            Parent.SetView(new FormManagement());
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            Parent.SetView(new FormFire());
        }
    }
}
