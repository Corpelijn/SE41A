using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FireBee.Extensions;
using FireBee.Forms.Management;

namespace FireBee.Forms
{
    public partial class FormManagement : Form
    {
        private FormMembers FormMembers { get; set; }
        private FormGroups FormGroups { get; set; }

        public FormManagement()
        {
            InitializeComponent();
            comboBoxSelection.SelectedIndex = 0;
        }

        private void comboBoxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelection.SelectedIndex)
            {
                case 0:
                    if (FormMembers == null) FormMembers = new FormMembers();
                    panelView.SetView(FormMembers, false);
                    break;
                default:
                    if (FormGroups == null) FormGroups = new FormGroups();
                    panelView.SetView(FormGroups, false);
                    break;
            }
        }
    }
}
