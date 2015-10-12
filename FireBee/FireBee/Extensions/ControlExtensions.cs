using System.Windows.Forms;

namespace FireBee.Extensions
{
    public static class ControlExtensions
    {
        public static void SetView<TBase, TView>(this TBase panel, TView form) where TBase : Control where TView : Form
        {
            // Set in form.
            form.TopLevel = false;
            form.Parent = panel;

            // Default settings.
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
    }
}