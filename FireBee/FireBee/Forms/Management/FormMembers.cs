using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FireBee.Domain;

namespace FireBee.Forms.Management
{
    public partial class FormMembers : Form
    {

        private FormManagement formManagement;
        public FormMembers(FormManagement formManagement)
        {
            InitializeComponent();
            RefreshList();
            this.formManagement = formManagement;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var popup = new FormMember())
            {
                if (popup.ShowDialog() != DialogResult.OK) return;

                var member = new Member(popup.FirstName, popup.LastName, popup.Image);
                Member.Members.Add(member);
                member.Group = popup.Group;
                RefreshList();
            }
        }

        public void RefreshList()
        {
            listView.Items.Clear();
            listView.Items.AddRange(Member.Members.Select(m => new ListViewItem
            {
                Tag = m,
                SubItems = { string.Format("{0} {1}", m.FirstName, m.LastName), m.Group != null ? m.Group.Name : null }
            }).ToArray());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView.CheckedItems.Count <= 0) return;

            FormMember form = new FormMember();
            foreach (ListViewItem item in listView.CheckedItems)
            {
                var member = (Member) item.Tag;

                // Fill form with actual member data.
                form.FirstName = member.FirstName;
                form.LastName = member.LastName;
                form.Image = member.Image;
                form.Group = member.Group;

                if (form.ShowDialog() != DialogResult.OK) continue;

                // Update member object.
                member.FirstName = form.FirstName;
                member.LastName = form.LastName;
                member.Image = form.Image;
                member.Group = form.Group;
                if (member.Group != null)
                {
                    Group.Groups.ForEach(g => g.Members.Remove(member));
                    member.Group.Members.Add(member);
                }

                // Updatge list item.
                item.SubItems[1].Text = form.FirstName + ' ' + form.LastName;
                if (member.Group != null) item.SubItems[2].Text = member.Group.Name;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listView.CheckedItems.Count <= 0) return;

            foreach (ListViewItem item in listView.CheckedItems)
            {
                listView.Items.Remove(item);
                Member.Members.Remove((Member)item.Tag);
            }
        }

        public void SetGroup(string name)
        {
            listView.Items.Clear();
            listView.Items.AddRange(Group.Groups.First(g => g.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).Members.Select(m => new ListViewItem()
            {
                Tag = MainMenuStrip,
                Text = m.FirstName + ' ' + m.LastName
            }).ToArray());
        }
    }
}
