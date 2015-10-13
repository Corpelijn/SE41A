using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FireBee.Domain;

namespace FireBee.Forms.Management
{
    public partial class FormMember : Form
    {
        public FormMember()
        {
            InitializeComponent();
            listViewGroups.Visible = Group.Groups.Count > 0;
            listViewGroups.Items.AddRange(
                Group.Groups.Select(g => new ListViewItem {Tag = g, Text = g.Name }).ToArray());
        }

        public string FirstName
        {
            get { return textBoxFirstName.Text; }
            set { textBoxFirstName.Text = value; }
        }

        public string LastName
        {
            get { return textBoxLastName.Text; }
            set { textBoxLastName.Text = value; }
        }

        public Image Image
        {
            get { return profileBox.Image; }
            set { profileBox.Image = value; }
        }

        public Group Group
        {
            get { return listViewGroups.SelectedItems.Count > 0 ? (Group) listViewGroups.SelectedItems[0].Tag : null; }
            set
            {
                ListViewItem itemToSelect = null;
                foreach (ListViewItem item in listViewGroups.Items)
                {
                    if (item.Tag == value)
                        itemToSelect = item;
                    item.Selected = false;
                }
                if (itemToSelect != null) itemToSelect.Selected = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Return))
            {
                buttonAccept.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}