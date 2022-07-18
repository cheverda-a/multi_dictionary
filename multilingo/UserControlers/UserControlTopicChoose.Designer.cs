namespace Multilingo.UserControlers
{
    partial class UserControlTopicChoose
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
            this.lblName = new System.Windows.Forms.Label();
            this.panelHover = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 95);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            this.lblName.MouseLeave += new System.EventHandler(this.lblName_MouseLeave);
            this.lblName.MouseHover += new System.EventHandler(this.lblName_MouseHover);
            // 
            // panelHover
            // 
            this.panelHover.BackColor = System.Drawing.Color.OrangeRed;
            this.panelHover.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHover.Location = new System.Drawing.Point(0, 98);
            this.panelHover.Name = "panelHover";
            this.panelHover.Size = new System.Drawing.Size(180, 47);
            this.panelHover.TabIndex = 1;
            // 
            // UserControlTopicChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelHover);
            this.Controls.Add(this.lblName);
            this.Name = "UserControlTopicChoose";
            this.Size = new System.Drawing.Size(180, 145);
            this.Load += new System.EventHandler(this.UserControlTopicChoose_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelHover;
    }
}
