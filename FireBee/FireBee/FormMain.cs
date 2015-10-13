using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FireBee.Controls;
using FireBee.Extensions;
using FireBee.Forms;
using FireBee.Forms.Management;
using FireBee.Domain;
using FireBee.Forms.Fire;

namespace FireBee
{
    public partial class FormMain : Form
    {
        public static HeaderNavigation Header { get; set; }

        public FormMain()
        {
            InitializeComponent();

            Header = headerNavigation;
            headerNavigation.AddRange("Terug", "Route", "Gebouw", "Beheer");
            headerNavigation.Index(0).Click += ButtonBack_OnClick;
            headerNavigation.Index(1).Click += ButtonRoute_OnClick;
            headerNavigation.Index(2).Click += ButtonBuilding_OnClick;
            headerNavigation.Index(3).Click += ButtonManagement_OnClick;
            panelView.SetView(new FormLogin());
        }

        private void ButtonBack_OnClick(object sender, EventArgs eventArgs)
        {
            panelView.SetView(new FormLogin());
        }

        private void ButtonRoute_OnClick(object sender, EventArgs eventArgs)
        {
            panelView.SetView(new FormRoute());
        }

        private void ButtonBuilding_OnClick(object sender, EventArgs eventArgs)
        {
            panelView.SetView(new FormBuilding());

            ((Button)sender).BackColor = SystemColors.Control;
        }

        private void ButtonManagement_OnClick(object sender, EventArgs eventArgs)
        {
            panelView.SetView(new FormManagement());
        }
    }
}
