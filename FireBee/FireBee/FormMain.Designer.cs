namespace FireBee
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerNavigation = new FireBee.Controls.HeaderNavigation();
            this.panelView = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // headerNavigation
            // 
            this.headerNavigation.BackColor = System.Drawing.SystemColors.Window;
            this.headerNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerNavigation.Location = new System.Drawing.Point(0, 0);
            this.headerNavigation.Name = "headerNavigation";
            this.headerNavigation.Size = new System.Drawing.Size(631, 51);
            this.headerNavigation.TabIndex = 15;
            // 
            // panelView
            // 
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 51);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(631, 183);
            this.panelView.TabIndex = 16;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(631, 234);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.headerNavigation);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firebee";
            this.ResumeLayout(false);

        }

        #endregion

        internal Controls.HeaderNavigation headerNavigation;
        private System.Windows.Forms.Panel panelView;
    }
}

