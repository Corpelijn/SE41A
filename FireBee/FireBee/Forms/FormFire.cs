using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FireBee.Extensions;
using FireBee.Forms.Fire;
using Microsoft.Win32;

namespace FireBee.Forms
{
    public partial class FormFire : Form
    {
        public FormFire()
        {
            InitializeComponent();

            try
            {
                RegistryKey key = Registry.LocalMachine;
                string parentKeyLocation = @"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl";
                string keyName = "FEATURE_BROWSER_EMULATION";
                RegistryKey subkey = key.CreateSubKey(parentKeyLocation);
                subkey = subkey.CreateSubKey(keyName);
                subkey.SetValue(Process.GetCurrentProcess().ProcessName + ".exe", 11001);
            }
            catch (Exception)
            {
                MessageBox.Show("Start de applicatie als administrator");
            }

            panelView.SetView(new FormRoute());
            headerNavigation.AddRange("Terug", "Route", "Gebouw");
            headerNavigation.Index(0).Click += ButtonBack_OnClick;
            headerNavigation.Index(1).Click += ButtonRoute_OnClick;
            headerNavigation.Index(2).Click += ButtonBuilding_OnClick;
        }


        private void ButtonBack_OnClick(object sender, EventArgs eventArgs)
        {
            Parent.SetView(new FormLogin());
        }

        private void ButtonRoute_OnClick(object sender, EventArgs eventArgs)
        {
            panelView.SetView(new FormRoute());
        }

        private void ButtonBuilding_OnClick(object sender, EventArgs eventArgs)
        {
            panelView.SetView(new FormBuilding());
            ((Button) sender).BackColor = SystemColors.Control;
        }

        private void ButtonBuilding_Click(object sender, EventArgs e)
        {
            panelView.SetView(new FormBuilding());
        }
    }
}
