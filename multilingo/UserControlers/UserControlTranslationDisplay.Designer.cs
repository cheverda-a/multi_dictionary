namespace multilingo.UserControlers
{
    partial class UserControlTranslationDisplay
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
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.panelLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLanguage
            // 
            this.panelLanguage.BackColor = System.Drawing.Color.LightBlue;
            this.panelLanguage.Controls.Add(this.lblLanguage);
            this.panelLanguage.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLanguage.Location = new System.Drawing.Point(130, 0);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(67, 120);
            this.panelLanguage.TabIndex = 0;
            // 
            // lblTranslation
            // 
            this.lblTranslation.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTranslation.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTranslation.Location = new System.Drawing.Point(0, 0);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(124, 120);
            this.lblTranslation.TabIndex = 1;
            this.lblTranslation.Text = "Translation";
            this.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLanguage
            // 
            this.lblLanguage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.Color.Black;
            this.lblLanguage.Location = new System.Drawing.Point(0, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(67, 120);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "UKR";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlTranslationDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.panelLanguage);
            this.Name = "UserControlTranslationDisplay";
            this.Size = new System.Drawing.Size(197, 120);
            this.panelLanguage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblTranslation;
    }
}
