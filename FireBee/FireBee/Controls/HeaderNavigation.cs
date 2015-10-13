using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            var control = new HeaderButton(this);
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
            var offsetX = 0;
            for (var i = 0; i < items.Count; i++)
            {
                var item = items[i];
                if (!item.Visible) continue;

                item.Location = new Point(offsetX, 0);
                item.Size = new Size(Width / items.Count(a => a.Visible), Height);

                offsetX += item.Width;
            }

            base.OnResize(eventargs);
        }

        public class HeaderButton : Button
        {
            public HeaderButton(HeaderNavigation owner)
            {
                if (owner == null) throw new ArgumentException("Parameter owner must not be null.", "owner");
                BackColor = SystemColors.Control;
                Owner = owner;
            }

            public HeaderNavigation Owner { get; set; }

            public override sealed Color BackColor
            {
                get { return base.BackColor; }
                set { base.BackColor = value; }
            }

            protected override void OnVisibleChanged(EventArgs e)
            {
                Owner.OnResize(e);
                base.OnVisibleChanged(e);
            }
        }
    }
}