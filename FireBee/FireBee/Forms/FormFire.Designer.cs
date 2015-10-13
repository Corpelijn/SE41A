namespace FireBee.Forms
{
    partial class FormFire
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
            this.panelView = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.SystemColors.Window;
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(967, 681);
            this.panelView.TabIndex = 15;
            // 
            // FormFire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 681);
            this.Controls.Add(this.panelView);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormFire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brand";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelView;
    }
}