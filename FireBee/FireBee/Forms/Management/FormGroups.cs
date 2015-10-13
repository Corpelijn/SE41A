using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FireBee.Domain;
using FireBee.Forms.Misc;

namespace FireBee.Forms.Management
{
    public partial class FormGroups : Form
    {
        public FormGroups()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string value = FormInput.GetInput("Voer de naam van de groep in");
            if (string.IsNullOrWhiteSpace(value)) return;
            Group.Groups.Add(new Group(value));
            RefreshList();
        }

        public void RefreshList()
        {
            listView.Items.Clear();
            listView.Items.AddRange(Group.Groups.Select(g => new ListViewItem
            {
                Tag = g,
                SubItems = { g.Name != null ? g.Name : null }
            }).ToArray());
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
