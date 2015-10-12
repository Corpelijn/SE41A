namespace FireBee.Forms.Management
{
    partial class FormGroups
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
            this.verwijderenButton = new System.Windows.Forms.Button();
            this.bewerkenButton = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.checkerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naamColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groepColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // verwijderenButton
            // 
            this.verwijderenButton.Location = new System.Drawing.Point(642, 92);
            this.verwijderenButton.Name = "verwijderenButton";
            this.verwijderenButton.Size = new System.Drawing.Size(80, 40);
            this.verwijderenButton.TabIndex = 16;
            this.verwijderenButton.Text = "Verwijderen";
            this.verwijderenButton.UseVisualStyleBackColor = true;
            // 
            // bewerkenButton
            // 
            this.bewerkenButton.Location = new System.Drawing.Point(642, 46);
            this.bewerkenButton.Name = "bewerkenButton";
            this.bewerkenButton.Size = new System.Drawing.Size(80, 40);
            this.bewerkenButton.TabIndex = 15;
            this.bewerkenButton.Text = "Bewerken";
            this.bewerkenButton.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(642, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 40);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Toevoegen";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.checkerColumnHeader,
            this.naamColumnHeader,
            this.groepColumnHeader});
            this.listView.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(636, 496);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // checkerColumnHeader
            // 
            this.checkerColumnHeader.Text = "#";
            // 
            // naamColumnHeader
            // 
            this.naamColumnHeader.Text = "Naam";
            this.naamColumnHeader.Width = 213;
            // 
            // groepColumnHeader
            // 
            this.groepColumnHeader.Text = "Groep";
            this.groepColumnHeader.Width = 399;
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(724, 496);
            this.Controls.Add(this.verwijderenButton);
            this.Controls.Add(this.bewerkenButton);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listView);
            this.Name = "FormGroups";
            this.Text = "FormGroups";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button verwijderenButton;
        private System.Windows.Forms.Button bewerkenButton;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader checkerColumnHeader;
        private System.Windows.Forms.ColumnHeader naamColumnHeader;
        private System.Windows.Forms.ColumnHeader groepColumnHeader;
    }
}