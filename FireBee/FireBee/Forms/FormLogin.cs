using System;
using System.Windows.Forms;
using FireBee.Domain;
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
            Account.IsLoggedIn = true;
            Parent.SetView(new FormManagement());
        }
    }
}
