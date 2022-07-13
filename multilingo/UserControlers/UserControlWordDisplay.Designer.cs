namespace multilingo.UserControlers
{
    partial class UserControlWordDisplay
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
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTerm
            // 
            this.lblTerm.BackColor = System.Drawing.SystemColors.Control;
            this.lblTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTerm.Location = new System.Drawing.Point(47, 42);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(302, 37);
            this.lblTerm.TabIndex = 0;
            this.lblTerm.Text = "Word Term";
            this.lblTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDefinition
            // 
            this.lblDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDefinition.Location = new System.Drawing.Point(48, 79);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(611, 84);
            this.lblDefinition.TabIndex = 1;
            this.lblDefinition.Text = "Definition";
            this.lblDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTopic
            // 
            this.lblTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.Color.Navy;
            this.lblTopic.Location = new System.Drawing.Point(491, 0);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(209, 41);
            this.lblTopic.TabIndex = 2;
            this.lblTopic.Text = "Topic";
            this.lblTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlWordDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.lblTerm);
            this.Name = "UserControlWordDisplay";
            this.Size = new System.Drawing.Size(700, 190);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.Label lblTopic;
    }
}
