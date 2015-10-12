namespace FireBee.Forms.Fire
{
    partial class FormBuilding
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
            this.PanelGebouw = new System.Windows.Forms.Panel();
            this.buttonOpenOtherMap = new System.Windows.Forms.Button();
            this.buttonOpenMap = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewRoutes = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.canvasRoute = new FireBee.Controls.Canvas();
            this.PanelGebouw.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGebouw
            // 
            this.PanelGebouw.BackColor = System.Drawing.Color.White;
            this.PanelGebouw.Controls.Add(this.buttonOpenOtherMap);
            this.PanelGebouw.Controls.Add(this.buttonOpenMap);
            this.PanelGebouw.Controls.Add(this.canvasRoute);
            this.PanelGebouw.Controls.Add(this.panelControls);
            this.PanelGebouw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGebouw.Location = new System.Drawing.Point(0, 0);
            this.PanelGebouw.Name = "PanelGebouw";
            this.PanelGebouw.Size = new System.Drawing.Size(1307, 616);
            this.PanelGebouw.TabIndex = 7;
            // 
            // buttonOpenOtherMap
            // 
            this.buttonOpenOtherMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenOtherMap.Location = new System.Drawing.Point(12, 581);
            this.buttonOpenOtherMap.Name = "buttonOpenOtherMap";
            this.buttonOpenOtherMap.Size = new System.Drawing.Size(99, 23);
            this.buttonOpenOtherMap.TabIndex = 16;
            this.buttonOpenOtherMap.Text = "Andere kaart";
            this.buttonOpenOtherMap.UseVisualStyleBackColor = true;
            this.buttonOpenOtherMap.Click += new System.EventHandler(this.buttonOpenOtherMap_Click);
            // 
            // buttonOpenMap
            // 
            this.buttonOpenMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenMap.Location = new System.Drawing.Point(335, 220);
            this.buttonOpenMap.Name = "buttonOpenMap";
            this.buttonOpenMap.Size = new System.Drawing.Size(359, 103);
            this.buttonOpenMap.TabIndex = 15;
            this.buttonOpenMap.Text = "Gebouwkaart openen...";
            this.buttonOpenMap.UseVisualStyleBackColor = true;
            this.buttonOpenMap.Click += new System.EventHandler(this.buttonOpenMap_Click);
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.Gainsboro;
            this.panelControls.Controls.Add(this.button5);
            this.panelControls.Controls.Add(this.button4);
            this.panelControls.Controls.Add(this.button3);
            this.panelControls.Controls.Add(this.button2);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.listViewRoutes);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControls.Location = new System.Drawing.Point(1029, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(278, 616);
            this.panelControls.TabIndex = 0;
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
            // listViewRoutes
            // 
            this.listViewRoutes.CheckBoxes = true;
            this.listViewRoutes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName});
            this.listViewRoutes.FullRowSelect = true;
            this.listViewRoutes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRoutes.Location = new System.Drawing.Point(18, 119);
            this.listViewRoutes.Name = "listViewRoutes";
            this.listViewRoutes.Size = new System.Drawing.Size(248, 141);
            this.listViewRoutes.TabIndex = 0;
            this.listViewRoutes.UseCompatibleStateImageBehavior = false;
            this.listViewRoutes.View = System.Windows.Forms.View.Details;
            this.listViewRoutes.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewRoutes_ItemChecked);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Naam";
            this.columnHeaderName.Width = 242;
            // 
            // canvasRoute
            // 
            this.canvasRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.canvasRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasRoute.Location = new System.Drawing.Point(0, 0);
            this.canvasRoute.Name = "canvasRoute";
            this.canvasRoute.Size = new System.Drawing.Size(1029, 616);
            this.canvasRoute.TabIndex = 14;
            this.canvasRoute.Text = "canvas1";
            // 
            // FormBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 616);
            this.Controls.Add(this.PanelGebouw);
            this.DoubleBuffered = true;
            this.Name = "FormBuilding";
            this.Text = "Gebouw";
            this.PanelGebouw.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelGebouw;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewRoutes;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.Button buttonOpenOtherMap;
        private System.Windows.Forms.Button buttonOpenMap;
        private Controls.Canvas canvasRoute;
    }
}