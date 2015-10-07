using System;
using System.Drawing;
using System.Windows.Forms;
using FireBee.Extensions;

namespace FireBee.Controls
{
    public class ProfilePictureBox : PictureBox
    {
        public event MouseEventHandler PlusButtonClick;

        public RectangleF ButtonPlusRect { get; private set; }
        public float ButtonPlusSize { get; set; }
        public bool PlusButtonDisableDefaultAction { get; set; }

        public ProfilePictureBox()
        {
            ButtonPlusSize = 20;
            BorderStyle = BorderStyle.FixedSingle;

            PlusButtonClick += (sender, args) =>
            {
                if (PlusButtonDisableDefaultAction) return;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Alle afbeeldingen|*.jpg;*.png|JPEG (*.jpg)|*jpg|PNG (*.png)|*.png";
                    ofd.ShowDialog();
                    ImageLocation = ofd.FileName;
                }
            };
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            var mouseRect = new RectangleF(e.X, e.Y, 1, 1);
            if (mouseRect.IntersectsWith(ButtonPlusRect))
            {
                OnPlusButtonClick(e);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // Draw + button.
            float buttonX = Size.Width - ButtonPlusSize;
            float buttonY = Size.Height - ButtonPlusSize;
            float buttonWidth = Size.Width - buttonX;
            float buttonHeight = Size.Height - buttonY;
            float plusButtonSize = buttonWidth > buttonHeight ? buttonWidth : buttonHeight;

            ButtonPlusRect = new RectangleF(buttonX, buttonY, plusButtonSize, plusButtonSize);
            pe.Graphics.FillRectangle(Brushes.White, ButtonPlusRect);
            pe.Graphics.DrawRectangle(Pens.Gray, new Rectangle((int)ButtonPlusRect.X, (int)ButtonPlusRect.Y, (int)ButtonPlusRect.Width, (int)ButtonPlusRect.Height));

            pe.Graphics.FillRectangle(Brushes.LightGreen, new RectangleF(ButtonPlusRect.X + ButtonPlusRect.Width / 2 - 1, ButtonPlusRect.Y, 2, ButtonPlusRect.Height));
            pe.Graphics.FillRectangle(Brushes.LightGreen, new RectangleF(ButtonPlusRect.X, ButtonPlusRect.Y + ButtonPlusRect.Height / 2 - 1, ButtonPlusRect.Width, 2));

        }

        protected virtual void OnPlusButtonClick(MouseEventArgs e)
        {
            var del = PlusButtonClick;
            if (del != null)
            {
                del.Invoke(this, e);
            }
        }
    }
}