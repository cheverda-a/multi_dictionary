namespace Multilingo.UserControlers
{
    partial class UserControlTermChoose
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHover = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelHover
            // 
            this.panelHover.BackColor = System.Drawing.Color.Orange;
            this.panelHover.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHover.Location = new System.Drawing.Point(0, 0);
            this.panelHover.Name = "panelHover";
            this.panelHover.Size = new System.Drawing.Size(75, 127);
            this.panelHover.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(75, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(184, 127);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Word";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            this.lblName.MouseLeave += new System.EventHandler(this.lblName_MouseLeave);
            this.lblName.MouseHover += new System.EventHandler(this.lblName_MouseHover);
            // 
            // UserControlTermChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelHover);
            this.Name = "UserControlTermChoose";
            this.Size = new System.Drawing.Size(259, 127);
            this.Load += new System.EventHandler(this.UserControlTermChoose_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHover;
        private System.Windows.Forms.Label lblName;
    }
}
