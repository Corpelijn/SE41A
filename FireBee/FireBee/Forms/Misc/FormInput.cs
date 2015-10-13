using System.Windows.Forms;

namespace FireBee.Forms.Misc
{
    public partial class FormInput : Form
    {
        protected FormInput()
        {
            InitializeComponent();
        }

        public string Input
        {
            get { return textBoxInput.Text; }
            set { textBoxInput.Text = value; }
        }

        /// <summary>
        ///     Opens an input form asking for the value and returns it. This method blocks.
        /// </summary>
        /// <returns></returns>
        public static string GetInput(string description = "Voer de waarde in")
        {
            var input = new FormInput();
            input.textBoxInput.PlaceholderText = description;
            if (input.ShowDialog() != DialogResult.OK) return null;
            return input.Input;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Return:
                    DialogResult = DialogResult.OK;
                    Close();
                    break;
                case Keys.Escape:
                    DialogResult = DialogResult.Cancel;
                    Close();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}