namespace FireBee.Forms
{
    partial class FormLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.tbWachtwoord = new Demo.PlaceholderTextBox();
            this.tbGebruikersnaam = new Demo.PlaceholderTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbWachtwoord);
            this.groupBox1.Controls.Add(this.tbGebruikersnaam);
            this.groupBox1.Controls.Add(this.btnInloggen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inloggen";
            // 
            // btnInloggen
            // 
            this.btnInloggen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInloggen.Location = new System.Drawing.Point(190, 71);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(136, 23);
            this.btnInloggen.TabIndex = 5;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWachtwoord.Location = new System.Drawing.Point(6, 45);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.PlaceholderText = "Wachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(320, 20);
            this.tbWachtwoord.TabIndex = 4;
            this.tbWachtwoord.UseSystemPasswordChar = true;
            // 
            // tbGebruikersnaam
            // 
            this.tbGebruikersnaam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGebruikersnaam.Location = new System.Drawing.Point(6, 19);
            this.tbGebruikersnaam.Name = "tbGebruikersnaam";
            this.tbGebruikersnaam.PlaceholderText = "Gebruikersnaam";
            this.tbGebruikersnaam.Size = new System.Drawing.Size(320, 20);
            this.tbGebruikersnaam.TabIndex = 3;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(332, 105);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLogin";
            this.Text = "Inloggen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Demo.PlaceholderTextBox tbWachtwoord;
        private Demo.PlaceholderTextBox tbGebruikersnaam;
        private System.Windows.Forms.Button btnInloggen;
    }
}