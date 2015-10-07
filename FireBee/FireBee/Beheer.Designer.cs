namespace FireBee
{
    partial class Beheer
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
            this.logUitButton = new System.Windows.Forms.Button();
            this.selectieComboBox = new System.Windows.Forms.ComboBox();
            this.ledenListView = new System.Windows.Forms.ListView();
            this.checkerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naamColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groepColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.evaluatieButton = new System.Windows.Forms.Button();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.bewerkenButton = new System.Windows.Forms.Button();
            this.verwijderenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logUitButton
            // 
            this.logUitButton.Location = new System.Drawing.Point(635, 0);
            this.logUitButton.Name = "logUitButton";
            this.logUitButton.Size = new System.Drawing.Size(80, 40);
            this.logUitButton.TabIndex = 0;
            this.logUitButton.Text = "Log Uit";
            this.logUitButton.UseVisualStyleBackColor = true;
            // 
            // selectieComboBox
            // 
            this.selectieComboBox.FormattingEnabled = true;
            this.selectieComboBox.Items.AddRange(new object[] {
            "Alle Leden",
            "Alle Groepen",
            "Groep 1",
            "Groep 2",
            "Groep 3"});
            this.selectieComboBox.Location = new System.Drawing.Point(5, 50);
            this.selectieComboBox.Name = "selectieComboBox";
            this.selectieComboBox.Size = new System.Drawing.Size(625, 21);
            this.selectieComboBox.TabIndex = 1;
            // 
            // ledenListView
            // 
            this.ledenListView.CheckBoxes = true;
            this.ledenListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.checkerColumnHeader,
            this.naamColumnHeader,
            this.groepColumnHeader});
            this.ledenListView.Location = new System.Drawing.Point(5, 80);
            this.ledenListView.Name = "ledenListView";
            this.ledenListView.Size = new System.Drawing.Size(625, 600);
            this.ledenListView.TabIndex = 3;
            this.ledenListView.UseCompatibleStateImageBehavior = false;
            this.ledenListView.View = System.Windows.Forms.View.Details;
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
            // evaluatieButton
            // 
            this.evaluatieButton.Location = new System.Drawing.Point(0, 0);
            this.evaluatieButton.Name = "evaluatieButton";
            this.evaluatieButton.Size = new System.Drawing.Size(635, 40);
            this.evaluatieButton.TabIndex = 4;
            this.evaluatieButton.Text = "Evaluatie";
            this.evaluatieButton.UseVisualStyleBackColor = true;
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Location = new System.Drawing.Point(635, 80);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(80, 40);
            this.toevoegenButton.TabIndex = 5;
            this.toevoegenButton.Text = "Toevoegen";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.toevoegenButton_Click);
            // 
            // bewerkenButton
            // 
            this.bewerkenButton.Location = new System.Drawing.Point(635, 126);
            this.bewerkenButton.Name = "bewerkenButton";
            this.bewerkenButton.Size = new System.Drawing.Size(80, 40);
            this.bewerkenButton.TabIndex = 6;
            this.bewerkenButton.Text = "Bewerken";
            this.bewerkenButton.UseVisualStyleBackColor = true;
            this.bewerkenButton.Click += new System.EventHandler(this.bewerkenButton_Click);
            // 
            // verwijderenButton
            // 
            this.verwijderenButton.Location = new System.Drawing.Point(635, 172);
            this.verwijderenButton.Name = "verwijderenButton";
            this.verwijderenButton.Size = new System.Drawing.Size(80, 40);
            this.verwijderenButton.TabIndex = 7;
            this.verwijderenButton.Text = "Verwijderen";
            this.verwijderenButton.UseVisualStyleBackColor = true;
            // 
            // Beheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 682);
            this.Controls.Add(this.verwijderenButton);
            this.Controls.Add(this.bewerkenButton);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.evaluatieButton);
            this.Controls.Add(this.ledenListView);
            this.Controls.Add(this.selectieComboBox);
            this.Controls.Add(this.logUitButton);
            this.MinimumSize = new System.Drawing.Size(600, 38);
            this.Name = "Beheer";
            this.Text = "Beheer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logUitButton;
        private System.Windows.Forms.ComboBox selectieComboBox;
        private System.Windows.Forms.ListView ledenListView;
        private System.Windows.Forms.ColumnHeader checkerColumnHeader;
        private System.Windows.Forms.ColumnHeader naamColumnHeader;
        private System.Windows.Forms.ColumnHeader groepColumnHeader;
        private System.Windows.Forms.Button evaluatieButton;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.Button bewerkenButton;
        private System.Windows.Forms.Button verwijderenButton;
    }
}