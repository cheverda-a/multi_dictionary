namespace multilingo.Forms
{
    partial class FormWordDisplay
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
            this.panelWordDisplay = new System.Windows.Forms.Panel();
            this.btnFavourites = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panelOtherDisplay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelWordDisplay
            // 
            this.panelWordDisplay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelWordDisplay.Location = new System.Drawing.Point(24, 21);
            this.panelWordDisplay.Name = "panelWordDisplay";
            this.panelWordDisplay.Size = new System.Drawing.Size(750, 205);
            this.panelWordDisplay.TabIndex = 0;
            // 
            // btnFavourites
            // 
            this.btnFavourites.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourites.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavourites.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnFavourites.Location = new System.Drawing.Point(580, 361);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(185, 59);
            this.btnFavourites.TabIndex = 1;
            this.btnFavourites.Text = "Add to Favourites";
            this.btnFavourites.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(31, 253);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(232, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Check it out in other languages:";
            // 
            // panelOtherDisplay
            // 
            this.panelOtherDisplay.Location = new System.Drawing.Point(36, 276);
            this.panelOtherDisplay.Name = "panelOtherDisplay";
            this.panelOtherDisplay.Size = new System.Drawing.Size(510, 144);
            this.panelOtherDisplay.TabIndex = 3;
            // 
            // FormWordDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOtherDisplay);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnFavourites);
            this.Controls.Add(this.panelWordDisplay);
            this.Name = "FormWordDisplay";
            this.Text = "FormWordDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWordDisplay;
        private System.Windows.Forms.Button btnFavourites;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panelOtherDisplay;
    }
}