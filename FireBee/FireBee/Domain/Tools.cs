using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FireBee.Domain
{
    class Tools
    {
        static int activeForms = 1;

        public static void CloseForm(Form form)
        {
            activeForms--;
            form.ShowInTaskbar = false;
            form.Hide();

            Check();
        }

        public static void ShowForm(Form form)
        {
            activeForms++;
            form.ShowInTaskbar = true;
            form.Show();
        }

        public static void Check()
        {
            if (activeForms == 0)
                Application.Exit();
        }
    }
}
