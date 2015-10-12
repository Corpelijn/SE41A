using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FireBee.Brand
{
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();

            ButtonRoute.Enabled = false;
            PanelRoute.Visible = true;
            PanelGebouw.Visible = false;

            route1.Parent = panel3;
            route2.Parent = panel3;
            route3.Parent = panel3;
            route4.Parent = panel3;

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

        private void Brand_Load(object sender, EventArgs e)
        {
            ResizeButtons();
        }

        private void ResizeButtons()
        {
            ButtonTerug.Size = new Size(200, 10);
            int width = (panel1.Size.Width - 200) / 2;
            ButtonGebouw.Size = new Size(width, 10);
            ButtonRoute.Size = new Size(width, 10);

            panel2.Size = new Size(150, 0);
        }

        private void Brand_Resize(object sender, EventArgs e)
        {
            ResizeButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bestemming bs = new Bestemming();
            if (bs.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            pictureBox1.Visible = false;

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
            webBrowser1.Navigate("http://google.nl/maps/?saddr=Rachelsmolen+1,+Eindhoven&daddr=" + daddr + "&views=traffic&directionsmode=driving&zoom=2&center");
        }

        private void ButtonGebouw_Click(object sender, EventArgs e)
        {
            PanelRoute.Visible = false;
            PanelGebouw.Visible = true;
            ButtonGebouw.Enabled = false;
            ButtonRoute.Enabled = true;
            timer1.Enabled = false;
            ButtonGebouw.BackColor = SystemColors.Control;
        }

        private void ButtonRoute_Click(object sender, EventArgs e)
        {
            PanelRoute.Visible = true;
            PanelGebouw.Visible = false;
            ButtonGebouw.Enabled = true;
            ButtonRoute.Enabled = false;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            timer1.Enabled = true;
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
                if (ButtonGebouw.BackColor == Color.Tomato)
                    ButtonGebouw.BackColor = SystemColors.Control;
                else
                    ButtonGebouw.BackColor = Color.Tomato;
            }
        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            button6.Location = new Point(panel3.Size.Width / 2 - button6.Size.Width / 2, panel3.Size.Height / 2 - button6.Size.Height / 2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = Properties.Resources.route_0;
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = null;
            button6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            route1.Visible = true;
            route2.Visible = true;
            route3.Visible = true;
            route4.Visible = true;
        }

        private void Brand_FormClosing(object sender, FormClosingEventArgs e)
        {
            FireBee.Domain.Tools.CloseForm(this);
        }
    }
}
