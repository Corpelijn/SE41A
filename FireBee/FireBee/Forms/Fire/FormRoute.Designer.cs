namespace FireBee.Forms.Fire
{
    partial class FormRoute
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.weBrowser = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelRoute = new System.Windows.Forms.Panel();
            this.buttonSetRoute = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelRoute.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // weBrowser
            // 
            this.weBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weBrowser.Location = new System.Drawing.Point(0, 0);
            this.weBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.weBrowser.Name = "weBrowser";
            this.weBrowser.Size = new System.Drawing.Size(909, 502);
            this.weBrowser.TabIndex = 3;
            this.weBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.weBrowser_DocumentCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FireBee.Properties.Resources.firebee_plattegrond;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(909, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // PanelRoute
            // 
            this.PanelRoute.Controls.Add(this.pictureBox1);
            this.PanelRoute.Controls.Add(this.weBrowser);
            this.PanelRoute.Controls.Add(this.panel2);
            this.PanelRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoute.Location = new System.Drawing.Point(0, 0);
            this.PanelRoute.Name = "PanelRoute";
            this.PanelRoute.Size = new System.Drawing.Size(1056, 502);
            this.PanelRoute.TabIndex = 5;
            // 
            // buttonSetRoute
            // 
            this.buttonSetRoute.Location = new System.Drawing.Point(18, 15);
            this.buttonSetRoute.Name = "buttonSetRoute";
            this.buttonSetRoute.Size = new System.Drawing.Size(107, 30);
            this.buttonSetRoute.TabIndex = 0;
            this.buttonSetRoute.Text = "Route plannen";
            this.buttonSetRoute.UseVisualStyleBackColor = true;
            this.buttonSetRoute.Click += new System.EventHandler(this.buttonSetRoute_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.buttonSetRoute);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(909, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 502);
            this.panel2.TabIndex = 2;
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 502);
            this.Controls.Add(this.PanelRoute);
            this.Name = "FormRoute";
            this.Text = "Route";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelRoute.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser weBrowser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelRoute;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSetRoute;
    }
}