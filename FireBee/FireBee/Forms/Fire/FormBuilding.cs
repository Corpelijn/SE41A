using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireBee.Extensions;
using FireBee.Properties;

namespace FireBee.Forms.Fire
{
    public partial class FormBuilding : Form
    {
        protected List<Bitmap> Routes;

        public override Image BackgroundImage
        {
            get { return backgroundImage; }
            set
            {
                backgroundImage = value;

                canvasRoute.BackgroundImage = backgroundImage;
                listViewRoutes.Enabled = canvasRoute.BackgroundImage != null;
                if (!listViewRoutes.Enabled)
                {
                    foreach (ListViewItem item in listViewRoutes.Items)
                    {
                        item.Checked = false;
                    }
                }
            }
        }

        protected Bitmap bitmapRouteOverdraw;
        private Image backgroundImage;

        public FormBuilding()
        {
            InitializeComponent();
            Routes = new List<Bitmap>()
            {
                Resources.route_0,
                Resources.route_1,
                Resources.route_2,
                Resources.route_3,
                Resources.route_4,
                Resources.route_5
            };
            listViewRoutes.Items.AddRange(Routes.Skip(1).Select((r, i) => new ListViewItem { Text = "Route " + (i + 1), Tag = r }).ToArray());

            BackgroundImage = null;
        }

        private void buttonOpenMap_Click(object sender, EventArgs e)
        {
            ((Button) sender).Visible = false;
            BackgroundImage = Routes.First();
        }

        private void buttonOpenOtherMap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Alle afbeeldingen|*.jpg;*.jpeg;*.png;|JPEG|*.jpeg;*.jpg|PNG|*.png";
                ofd.CheckFileExists = true;

                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    buttonOpenMap.Visible = true;
                    BackgroundImage = null;
                }
                else
                {
                    buttonOpenMap.Visible = false;
                    BackgroundImage = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void listViewRoutes_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!listViewRoutes.Enabled) return;

            bitmapRouteOverdraw = new Bitmap(BackgroundImage.Width, BackgroundImage.Height);

            // Draw on bitmap.
            using (Graphics g = Graphics.FromImage(bitmapRouteOverdraw))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                // Draw background.
                g.DrawImage(BackgroundImage, Point.Empty);

                // Draw routes.
                foreach (ListViewItem item in listViewRoutes.Items)
                {
                    if (item.Checked)
                    {
                        var unit = GraphicsUnit.Pixel;
                        g.DrawImage(((Image)item.Tag), canvasRoute.BackgroundImage.GetBounds(ref unit));
                    }
                }
            }

            canvasRoute.BackgroundImage = bitmapRouteOverdraw;
        }
    }
}
