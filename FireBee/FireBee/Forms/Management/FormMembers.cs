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
        public FormMembers()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var popup = new FormMember())
            {
                if (popup.ShowDialog() != DialogResult.OK) return;

                Member.Members.Add(new Member(popup.FirstName, popup.LastName, popup.Image));
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
    }
}
