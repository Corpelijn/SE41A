using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FireBee.Brand
{
    public partial class Bestemming : Form
    {
        public Bestemming()
        {
            InitializeComponent();
        }

        public string Adres
        {
            get { return placeholderTextBox1.Text; }
        }

        public string Huisnummer
        {
            get { return placeholderTextBox2.Text; }
        }

        public string Postcode
        {
            get { return placeholderTextBox3.Text; }
        }

        public string Woonplaats
        {
            get { return placeholderTextBox4.Text; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (placeholderTextBox1.Text == "" && placeholderTextBox2.Text == "" && placeholderTextBox3.Text == "" && placeholderTextBox4.Text == "")
            {
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
