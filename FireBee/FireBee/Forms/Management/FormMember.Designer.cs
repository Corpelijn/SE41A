namespace FireBee.Forms.Management
{
    partial class FormMember
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.voornaamLabel = new System.Windows.Forms.Label();
            this.achternaamLabel = new System.Windows.Forms.Label();
            this.textBoxLastName = new Demo.PlaceholderTextBox();
            this.textBoxFirstName = new Demo.PlaceholderTextBox();
            this.profileBox = new FireBee.Controls.ProfilePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(370, 65);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Annuleer";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Location = new System.Drawing.Point(289, 65);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 2;
            this.buttonAccept.Text = "Accepteer";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // voornaamLabel
            // 
            this.voornaamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.voornaamLabel.AutoSize = true;
            this.voornaamLabel.Location = new System.Drawing.Point(140, 15);
            this.voornaamLabel.Name = "voornaamLabel";
            this.voornaamLabel.Size = new System.Drawing.Size(58, 13);
            this.voornaamLabel.TabIndex = 4;
            this.voornaamLabel.Text = "Voornaam:";
            // 
            // achternaamLabel
            // 
            this.achternaamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.achternaamLabel.AutoSize = true;
            this.achternaamLabel.Location = new System.Drawing.Point(131, 42);
            this.achternaamLabel.Name = "achternaamLabel";
            this.achternaamLabel.Size = new System.Drawing.Size(67, 13);
            this.achternaamLabel.TabIndex = 5;
            this.achternaamLabel.Text = "Achternaam:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(204, 39);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.PlaceholderText = "Achternaam";
            this.textBoxLastName.Size = new System.Drawing.Size(241, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(204, 12);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.PlaceholderText = "Voornaam";
            this.textBoxFirstName.Size = new System.Drawing.Size(241, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // profileBox
            // 
            this.profileBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileBox.ButtonPlusSize = 20F;
            this.profileBox.Location = new System.Drawing.Point(12, 12);
            this.profileBox.Name = "profileBox";
            this.profileBox.PlusButtonDisableDefaultAction = false;
            this.profileBox.Size = new System.Drawing.Size(106, 111);
            this.profileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileBox.TabIndex = 7;
            this.profileBox.TabStop = false;
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(457, 135);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.achternaamLabel);
            this.Controls.Add(this.voornaamLabel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lid formulier";
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label voornaamLabel;
        private System.Windows.Forms.Label achternaamLabel;
        private Controls.ProfilePictureBox profileBox;
        private Demo.PlaceholderTextBox textBoxFirstName;
        private Demo.PlaceholderTextBox textBoxLastName;
    }
}