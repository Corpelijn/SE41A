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
    public partial class Beheer : Form
    {
        public Beheer()
        {
            InitializeComponent();
            ListViewItem item1 = new ListViewItem();
            item1.SubItems.Add("Baya");
            item1.SubItems.Add("1");
            ledenListView.Items.Add(item1);
        }

        private void toevoegenButton_Click(object sender, EventArgs e)
        {
            Lid lidForm = new Lid("Voornaam", "Achternaam");
            lidForm.ShowDialog();
        }

        private void bewerkenButton_Click(object sender, EventArgs e)
        {
            Lid lidForm = new Lid("Baya", "Horloo");
            lidForm.ShowDialog();
        }
    }
}
