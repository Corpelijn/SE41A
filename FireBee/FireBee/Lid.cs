using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FireBee
{
    public partial class Lid : Form
    {
        public Lid(string voornaam, string achternaam)
        {
            InitializeComponent();
            voornaamTextBox.Text = voornaam;
            achternaamTextBox.Text = achternaam;
        }

        private void annuleerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
