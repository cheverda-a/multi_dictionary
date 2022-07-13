namespace multilingo.UserControlers
{
    partial class UserControlTopicsChoose
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
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTopic
            // 
            this.lblTopic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTopic.Location = new System.Drawing.Point(0, 0);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTopic.Size = new System.Drawing.Size(247, 66);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "Topic Name";
            this.lblTopic.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTerm
            // 
            this.lblTerm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTerm.Location = new System.Drawing.Point(0, 66);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.lblTerm.Size = new System.Drawing.Size(247, 61);
            this.lblTerm.TabIndex = 1;
            this.lblTerm.Text = "no. terms";
            // 
            // UserControlTopicsChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblTopic);
            this.Name = "UserControlTopicsChoose";
            this.Size = new System.Drawing.Size(247, 127);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblTerm;
    }
}
