namespace FireBee
{
    partial class Lid
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.voornaamTextBox = new System.Windows.Forms.TextBox();
            this.annuleerButton = new System.Windows.Forms.Button();
            this.accepteerButton = new System.Windows.Forms.Button();
            this.voornaamLabel = new System.Windows.Forms.Label();
            this.achternaamLabel = new System.Windows.Forms.Label();
            this.achternaamTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // voornaamTextBox
            // 
            this.voornaamTextBox.Location = new System.Drawing.Point(194, 15);
            this.voornaamTextBox.Name = "voornaamTextBox";
            this.voornaamTextBox.Size = new System.Drawing.Size(178, 20);
            this.voornaamTextBox.TabIndex = 1;
            // 
            // annuleerButton
            // 
            this.annuleerButton.Location = new System.Drawing.Point(297, 89);
            this.annuleerButton.Name = "annuleerButton";
            this.annuleerButton.Size = new System.Drawing.Size(75, 23);
            this.annuleerButton.TabIndex = 2;
            this.annuleerButton.Text = "Annuleer";
            this.annuleerButton.UseVisualStyleBackColor = true;
            this.annuleerButton.Click += new System.EventHandler(this.annuleerButton_Click);
            // 
            // accepteerButton
            // 
            this.accepteerButton.Location = new System.Drawing.Point(216, 89);
            this.accepteerButton.Name = "accepteerButton";
            this.accepteerButton.Size = new System.Drawing.Size(75, 23);
            this.accepteerButton.TabIndex = 3;
            this.accepteerButton.Text = "Accepteer";
            this.accepteerButton.UseVisualStyleBackColor = true;
            // 
            // voornaamLabel
            // 
            this.voornaamLabel.AutoSize = true;
            this.voornaamLabel.Location = new System.Drawing.Point(127, 18);
            this.voornaamLabel.Name = "voornaamLabel";
            this.voornaamLabel.Size = new System.Drawing.Size(58, 13);
            this.voornaamLabel.TabIndex = 4;
            this.voornaamLabel.Text = "Voornaam:";
            // 
            // achternaamLabel
            // 
            this.achternaamLabel.AutoSize = true;
            this.achternaamLabel.Location = new System.Drawing.Point(118, 45);
            this.achternaamLabel.Name = "achternaamLabel";
            this.achternaamLabel.Size = new System.Drawing.Size(67, 13);
            this.achternaamLabel.TabIndex = 5;
            this.achternaamLabel.Text = "Achternaam:";
            // 
            // achternaamTextBox
            // 
            this.achternaamTextBox.Location = new System.Drawing.Point(194, 42);
            this.achternaamTextBox.Name = "achternaamTextBox";
            this.achternaamTextBox.Size = new System.Drawing.Size(178, 20);
            this.achternaamTextBox.TabIndex = 6;
            // 
            // Lid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 128);
            this.Controls.Add(this.achternaamTextBox);
            this.Controls.Add(this.achternaamLabel);
            this.Controls.Add(this.voornaamLabel);
            this.Controls.Add(this.accepteerButton);
            this.Controls.Add(this.annuleerButton);
            this.Controls.Add(this.voornaamTextBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "Lid";
            this.Text = "Lid";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox voornaamTextBox;
        private System.Windows.Forms.Button annuleerButton;
        private System.Windows.Forms.Button accepteerButton;
        private System.Windows.Forms.Label voornaamLabel;
        private System.Windows.Forms.Label achternaamLabel;
        private System.Windows.Forms.TextBox achternaamTextBox;
    }
}