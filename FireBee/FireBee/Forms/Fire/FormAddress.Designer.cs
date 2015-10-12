namespace FireBee.Forms.Fire
{
    partial class FormDestination
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.placeholderTextBox4 = new Demo.PlaceholderTextBox();
            this.placeholderTextBox3 = new Demo.PlaceholderTextBox();
            this.placeholderTextBox2 = new Demo.PlaceholderTextBox();
            this.placeholderTextBox1 = new Demo.PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vul hieronder een aantal gegevens in van de bestemming";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(272, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Annuleren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(161, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Route berekenen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // placeholderTextBox4
            // 
            this.placeholderTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox4.Location = new System.Drawing.Point(98, 66);
            this.placeholderTextBox4.Name = "placeholderTextBox4";
            this.placeholderTextBox4.PlaceholderText = "Woonplaats";
            this.placeholderTextBox4.Size = new System.Drawing.Size(249, 20);
            this.placeholderTextBox4.TabIndex = 3;
            // 
            // placeholderTextBox3
            // 
            this.placeholderTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox3.Location = new System.Drawing.Point(12, 66);
            this.placeholderTextBox3.Name = "placeholderTextBox3";
            this.placeholderTextBox3.PlaceholderText = "Postcode";
            this.placeholderTextBox3.Size = new System.Drawing.Size(80, 20);
            this.placeholderTextBox3.TabIndex = 2;
            // 
            // placeholderTextBox2
            // 
            this.placeholderTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox2.Location = new System.Drawing.Point(279, 40);
            this.placeholderTextBox2.Name = "placeholderTextBox2";
            this.placeholderTextBox2.PlaceholderText = "Huisnummer";
            this.placeholderTextBox2.Size = new System.Drawing.Size(68, 20);
            this.placeholderTextBox2.TabIndex = 1;
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox1.Location = new System.Drawing.Point(12, 40);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.PlaceholderText = "Straat";
            this.placeholderTextBox1.Size = new System.Drawing.Size(261, 20);
            this.placeholderTextBox1.TabIndex = 0;
            // 
            // FormDestination
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(359, 140);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.placeholderTextBox4);
            this.Controls.Add(this.placeholderTextBox3);
            this.Controls.Add(this.placeholderTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placeholderTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDestination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Demo.PlaceholderTextBox placeholderTextBox1;
        private System.Windows.Forms.Label label1;
        private Demo.PlaceholderTextBox placeholderTextBox2;
        private Demo.PlaceholderTextBox placeholderTextBox3;
        private Demo.PlaceholderTextBox placeholderTextBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}