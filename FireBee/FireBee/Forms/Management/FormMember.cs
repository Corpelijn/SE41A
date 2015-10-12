using System.Drawing;
using System.Windows.Forms;

namespace FireBee.Forms.Management
{
    public partial class FormMember : Form
    {
        public string FirstName
        {
            get { return textBoxFirstName.Text; }
        }

        public string LastName
        {
            get { return textBoxLastName.Text; }
        }

        public Image Image
        {
            get { return profileBox.Image; }
        }

        public FormMember()
        {
            InitializeComponent();
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
