using System;
using System.Linq;
using System.Windows.Forms;
using FireBee.Domain;
using FireBee.Forms.Misc;

namespace FireBee.Forms.Management
{
    public partial class FormGroups : Form
    {
        private FormManagement formManagement;

        public FormGroups(FormManagement form)
        {
            formManagement = form;
            InitializeComponent();
            RefreshList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string value = FormInput.GetInput("Voer de naam van de groep in");
            if (string.IsNullOrWhiteSpace(value)) return;
            var group = new Group(value);
            Group.Groups.Add(group);
            listView.Items.Add(new ListViewItem {Tag = group, SubItems = {group.Name != null ? group.Name : null}});
            formManagement.comboBoxSelection.Items.Add(group);
        }

        public void RefreshList()
        {
            listView.Items.Clear();
            listView.Items.AddRange(Group.Groups.Select(g => new ListViewItem
            {
                Tag = g,
                SubItems = { g.Name != null ? g.Name : null }
            }).ToArray());

            formManagement.comboBoxSelection.Items.Clear();
            formManagement.comboBoxSelection.Items.AddRange(new[] { "Alle leden", "Alle groepen" });
            formManagement.comboBoxSelection.Items.AddRange(Group.Groups.ToArray());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView.CheckedItems.Count <= 0) return;

            foreach (ListViewItem item in listView.CheckedItems)
            {
                string newName = FormInput.GetInput("Voer nieuwe naam in voor " + item.SubItems[1].Text);
                if (string.IsNullOrWhiteSpace(newName)) continue;

                ((Group) item.Tag).Name = newName;
                item.SubItems[1].Text = newName;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listView.CheckedItems.Count <= 0) return;

            foreach (ListViewItem item in listView.CheckedItems)
            {
                Group.Groups.Remove((Group)item.Tag);
                listView.Items.Remove(item);
            }
        }
    }
}
