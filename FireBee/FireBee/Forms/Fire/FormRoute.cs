﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FireBee.Utils;
using Microsoft.Win32;

namespace FireBee.Forms.Fire
{
    public partial class FormRoute : Form
    {
        public FormRoute()
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
        }

        private void buttonSetRoute_Click(object sender, EventArgs e)
        {
            FormDestination bs = new FormDestination();
            if (bs.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            string daddr = "";
            if (bs.Adres != null)
            {
                daddr = bs.Adres.Replace(" ", "+");
            }
            if (bs.Huisnummer != null)
            {
                daddr += (daddr == "" ? "" : ",") + bs.Huisnummer.Replace(" ", "+");
            }
            if (bs.Postcode != null)
            {
                daddr += (daddr == "" ? "" : ",") + bs.Postcode.Replace(" ", "+");
            }
            if (bs.Woonplaats != null)
            {
                daddr += (daddr == "" ? "" : ",") + bs.Woonplaats.Replace(" ", "+");
            }
            weBrowser.Navigate("http://google.nl/maps/?saddr=Rachelsmolen+1,+Eindhoven&daddr=" + daddr + "&views=traffic&directionsmode=driving&zoom=2&center");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!pictureBox1.Visible)
            {
                pictureBox1.Visible = true;
                timer1.Interval = 1000;
            }
            else
            {
                if (Parent != null && Parent.Parent != null)
                {
                    Button building = ((FormMain)Parent.Parent).headerNavigation.Index(2);
                    building.BackColor = building.BackColor == Color.Tomato ? SystemColors.Control : Color.Tomato;
                }
                else
                {
                    timer1.Stop();
                }
            }
        }

        private void weBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            TaskEx.Delay(5000).ContinueWith(t => timer1.Start());
        }

        private void buttonShowBuilding_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }
    }
}
