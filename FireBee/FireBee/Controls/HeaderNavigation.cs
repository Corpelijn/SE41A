using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FireBee.Extensions;

namespace FireBee.Controls
{
    internal sealed class HeaderNavigation : Panel
    {
        public HeaderNavigation()
        {
            items = new List<HeaderButton>();
            BackColor = SystemColors.Window;
        }

        private List<HeaderButton> items { get; }

        public IEnumerable<HeaderButton> Items
        {
            get { return items; }
        }

        public void Add(string text)
        {
            var control = new HeaderButton();
            control.Text = text;
            items.Add(control);
            Controls.Add(control);
        }

        public bool RemoveAt(int index)
        {
            if (index > items.Count - 1) return false;
            items.RemoveAt(index);
            return true;
        }

        public void AddRange(params string[] newItems)
        {
            foreach (var newItem in newItems)
            {
                Add(newItem);
            }
        }

        public HeaderButton Index(int index)
        {
            return items[index];
        }

        protected override void OnResize(EventArgs eventargs)
        {
            int offsetX = 0;
            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                item.Location = new Point(offsetX, 0);
                item.Size = new Size(Width / items.Count, Height);

                offsetX += item.Width;
            }

            base.OnResize(eventargs);
        }

        public class HeaderButton : Button
        {
            public HeaderButton()
            {
                BackColor = SystemColors.Control;
            }
        }
    }
}