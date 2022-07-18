namespace Multilingo
{
    partial class FormInitial
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
            this.panelInitial = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelInitial
            // 
            this.panelInitial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInitial.Location = new System.Drawing.Point(0, 0);
            this.panelInitial.Name = "panelInitial";
            this.panelInitial.Size = new System.Drawing.Size(874, 534);
            this.panelInitial.TabIndex = 0;
            // 
            // FormInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 534);
            this.Controls.Add(this.panelInitial);
            this.Name = "FormInitial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MultiLingo";
            this.Load += new System.EventHandler(this.FormInitial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInitial;
    }
}