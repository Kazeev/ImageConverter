namespace ImageConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.cbGry = new System.Windows.Forms.CheckBox();
            this.cbRGB = new System.Windows.Forms.CheckBox();
            this.cbHEX = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(12, 196);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(293, 23);
            this.open.TabIndex = 1;
            this.open.Text = "Открыть изображение";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.go_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 250);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(293, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранть массив";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cbGry
            // 
            this.cbGry.Checked = true;
            this.cbGry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGry.Enabled = false;
            this.cbGry.Location = new System.Drawing.Point(12, 220);
            this.cbGry.Name = "cbGry";
            this.cbGry.Size = new System.Drawing.Size(85, 24);
            this.cbGry.TabIndex = 3;
            this.cbGry.Text = "Gry";
            this.cbGry.UseVisualStyleBackColor = true;
            // 
            // cbRGB
            // 
            this.cbRGB.Enabled = false;
            this.cbRGB.Location = new System.Drawing.Point(113, 220);
            this.cbRGB.Name = "cbRGB";
            this.cbRGB.Size = new System.Drawing.Size(85, 24);
            this.cbRGB.TabIndex = 4;
            this.cbRGB.Text = "RGB";
            this.cbRGB.UseVisualStyleBackColor = true;
            // 
            // cbHEX
            // 
            this.cbHEX.Enabled = false;
            this.cbHEX.Location = new System.Drawing.Point(220, 220);
            this.cbHEX.Name = "cbHEX";
            this.cbHEX.Size = new System.Drawing.Size(85, 24);
            this.cbHEX.TabIndex = 5;
            this.cbHEX.Text = "HEX";
            this.cbHEX.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(317, 280);
            this.Controls.Add(this.cbHEX);
            this.Controls.Add(this.cbRGB);
            this.Controls.Add(this.cbGry);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox cbHEX;
        private System.Windows.Forms.CheckBox cbRGB;

        private System.Windows.Forms.CheckBox cbGry;

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;

        #endregion
    }
}