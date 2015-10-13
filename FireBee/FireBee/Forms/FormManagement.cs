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
                    if (FormMembers == null) FormMembers = new FormMembers(this);
                    panelView.SetView(FormMembers, false);
                    FormMembers.RefreshList();
                    break;
                case 1:
                    if (FormGroups == null) FormGroups = new FormGroups(this);
                    panelView.SetView(FormGroups, false);
                    FormMembers.RefreshList();
                    break;
                default:
                    // Open members in group.
                    if (FormMembers == null) FormMembers = new FormMembers(this);
                    panelView.SetView(FormMembers, false);
                    FormMembers.SetGroup(comboBoxSelection.SelectedText);
                    break;
            }
        }
    }
}
