using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireBee.Domain;
using FireBee.Forms;
using FireBee.Utils;

namespace FireBee.Extensions
{
    public static class ControlExtensions
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public static void SetView<TBase, TView>(this TBase control, TView form, bool resize = true) where TBase : Control where TView : Form
        {
            if (control == null) throw new ArgumentException("Parameter control must not be null.");
            if (form == null) throw new ArgumentException("Parameter form must not be null.");
            if (form.WindowState == FormWindowState.Maximized) throw new InvalidOperationException(string.Format("Form must not be maximized.", form.Name));

            control.Controls.Clear();
            Control parentControl = control;
            while (parentControl.Parent != null)
            {
                parentControl = parentControl.Parent;
            }
            Form parentForm = parentControl as Form;

            // Set in form.
            form.TopLevel = false;
            form.Parent = control;
            if (resize && parentForm != null)
            {
                if (parentForm.WindowState != FormWindowState.Maximized)
                    parentControl.ClientSize = form.Size + new Size(0, 44);
                parentForm.SetDesktopLocation(Screen.PrimaryScreen.Bounds.Width / 2 - parentForm.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - parentForm.Height / 2);
            }

            // Default settings.
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();

            FormMain.Header.Index(0).Visible = !(form is FormLogin);
            if (Account.IsLoggedIn && form is FormLogin) Account.IsLoggedIn = false; 
            FormMain.Header.Index(3).Visible = Account.IsLoggedIn;
        }

        public static void InvokeSafe<T>(this T control, Action<T> action) where T : Control
        {
            if (control == null) throw new ArgumentException("Parameter control must not be null.", "control");
            if (action == null) return;

            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => action(control)));
            }
            else
            {
                action(control);
            }
        }

        public static void SuspendDrawing(this Control parent)
        {
            if (parent == null) return;
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(this Control parent)
        {
            if (parent == null) return;
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }

        public static void PauseDraw<T>(this T control, Action<T> action) where T : Control
        {
            if (control == null || action == null) return;
            control.SuspendDrawing();
            action(control);
            control.ResumeDrawing();
            //TaskEx.Delay(1000).ContinueWith((t) => control.InvokeSafe(c => c.ResumeDrawing()));
        }
    }
}