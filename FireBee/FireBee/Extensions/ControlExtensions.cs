using System.Drawing;
using System.Windows.Forms;

namespace FireBee.Extensions
{
    public static class ControlExtensions
    {
        public static void SetView<TBase, TView>(this TBase control, TView form) where TBase : Control where TView : Form
        {
            control.Controls.Clear();
            Control controlForm = control;
            while (controlForm.Parent != null)
            {
                controlForm = controlForm.Parent;
            }

            // Set in form.
            form.TopLevel = false;
            form.Parent = control;
            controlForm.ClientSize = form.Size + new Size(0, 44);

            // Default settings.
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
    }
}