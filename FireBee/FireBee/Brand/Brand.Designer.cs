namespace FireBee.Brand
{
    partial class Brand
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
            this.ButtonTerug = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonRoute = new System.Windows.Forms.Button();
            this.ButtonGebouw = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.PanelRoute = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelGebouw = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.route1 = new System.Windows.Forms.PictureBox();
            this.route2 = new System.Windows.Forms.PictureBox();
            this.route3 = new System.Windows.Forms.PictureBox();
            this.route4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelGebouw.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.route1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.route2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.route3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.route4)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonTerug
            // 
            this.ButtonTerug.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTerug.Location = new System.Drawing.Point(0, 0);
            this.ButtonTerug.Name = "ButtonTerug";
            this.ButtonTerug.Size = new System.Drawing.Size(196, 41);
            this.ButtonTerug.TabIndex = 0;
            this.ButtonTerug.Text = "Terug";
            this.ButtonTerug.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonRoute);
            this.panel1.Controls.Add(this.ButtonTerug);
            this.panel1.Controls.Add(this.ButtonGebouw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 41);
            this.panel1.TabIndex = 1;
            // 
            // ButtonRoute
            // 
            this.ButtonRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRoute.Location = new System.Drawing.Point(196, 0);
            this.ButtonRoute.Name = "ButtonRoute";
            this.ButtonRoute.Size = new System.Drawing.Size(578, 41);
            this.ButtonRoute.TabIndex = 1;
            this.ButtonRoute.Text = "Route";
            this.ButtonRoute.UseVisualStyleBackColor = true;
            this.ButtonRoute.Click += new System.EventHandler(this.ButtonRoute_Click);
            // 
            // ButtonGebouw
            // 
            this.ButtonGebouw.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonGebouw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGebouw.Location = new System.Drawing.Point(774, 0);
            this.ButtonGebouw.Name = "ButtonGebouw";
            this.ButtonGebouw.Size = new System.Drawing.Size(490, 41);
            this.ButtonGebouw.TabIndex = 2;
            this.ButtonGebouw.Text = "Gebouw";
            this.ButtonGebouw.UseVisualStyleBackColor = true;
            this.ButtonGebouw.Click += new System.EventHandler(this.ButtonGebouw_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1117, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 640);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Route plannen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1117, 640);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // PanelRoute
            // 
            this.PanelRoute.Controls.Add(this.pictureBox1);
            this.PanelRoute.Controls.Add(this.webBrowser1);
            this.PanelRoute.Controls.Add(this.panel2);
            this.PanelRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoute.Location = new System.Drawing.Point(0, 41);
            this.PanelRoute.Name = "PanelRoute";
            this.PanelRoute.Size = new System.Drawing.Size(1264, 640);
            this.PanelRoute.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FireBee.Properties.Resources.firebee_plattegrond;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // PanelGebouw
            // 
            this.PanelGebouw.BackColor = System.Drawing.Color.White;
            this.PanelGebouw.Controls.Add(this.panel3);
            this.PanelGebouw.Controls.Add(this.panel5);
            this.PanelGebouw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGebouw.Location = new System.Drawing.Point(0, 41);
            this.PanelGebouw.Name = "PanelGebouw";
            this.PanelGebouw.Size = new System.Drawing.Size(1264, 640);
            this.PanelGebouw.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.route4);
            this.panel3.Controls.Add(this.route3);
            this.panel3.Controls.Add(this.route2);
            this.panel3.Controls.Add(this.route1);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 640);
            this.panel3.TabIndex = 1;
            this.panel3.Resize += new System.EventHandler(this.panel3_Resize);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.Location = new System.Drawing.Point(12, 605);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Andere kaart";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(258, 257);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(399, 70);
            this.button6.TabIndex = 0;
            this.button6.Text = "Gebouwkaart openen...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(986, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(278, 640);
            this.panel5.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(110, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Verwijderen";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Aanpassen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Route(s) automatisch berekenen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Route tekenen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Routes";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(18, 119);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 141);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 227;
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // route1
            // 
            this.route1.BackColor = System.Drawing.Color.Transparent;
            this.route1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.route1.Image = global::FireBee.Properties.Resources.route_1;
            this.route1.Location = new System.Drawing.Point(0, 0);
            this.route1.Name = "route1";
            this.route1.Size = new System.Drawing.Size(986, 640);
            this.route1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.route1.TabIndex = 7;
            this.route1.TabStop = false;
            this.route1.Visible = false;
            // 
            // route2
            // 
            this.route2.BackColor = System.Drawing.Color.Transparent;
            this.route2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.route2.Image = global::FireBee.Properties.Resources.route_2;
            this.route2.Location = new System.Drawing.Point(0, 0);
            this.route2.Name = "route2";
            this.route2.Size = new System.Drawing.Size(986, 640);
            this.route2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.route2.TabIndex = 8;
            this.route2.TabStop = false;
            this.route2.Visible = false;
            // 
            // route3
            // 
            this.route3.BackColor = System.Drawing.Color.Transparent;
            this.route3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.route3.Image = global::FireBee.Properties.Resources.route_3;
            this.route3.Location = new System.Drawing.Point(0, 0);
            this.route3.Name = "route3";
            this.route3.Size = new System.Drawing.Size(986, 640);
            this.route3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.route3.TabIndex = 9;
            this.route3.TabStop = false;
            this.route3.Visible = false;
            // 
            // route4
            // 
            this.route4.BackColor = System.Drawing.Color.Transparent;
            this.route4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.route4.Image = global::FireBee.Properties.Resources.route_4;
            this.route4.Location = new System.Drawing.Point(0, 0);
            this.route4.Name = "route4";
            this.route4.Size = new System.Drawing.Size(986, 640);
            this.route4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.route4.TabIndex = 10;
            this.route4.TabStop = false;
            this.route4.Visible = false;
            // 
            // Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PanelGebouw);
            this.Controls.Add(this.PanelRoute);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Brand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brand";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Brand_Load);
            this.Resize += new System.EventHandler(this.Brand_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelRoute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelGebouw.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.route1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.route2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.route3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.route4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonTerug;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonRoute;
        private System.Windows.Forms.Button ButtonGebouw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel PanelRoute;
        private System.Windows.Forms.Panel PanelGebouw;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox route1;
        private System.Windows.Forms.PictureBox route4;
        private System.Windows.Forms.PictureBox route3;
        private System.Windows.Forms.PictureBox route2;
    }
}