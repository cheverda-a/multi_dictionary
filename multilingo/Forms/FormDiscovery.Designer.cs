namespace Multilingo.Forms
{
    partial class FormDiscovery
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
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLingo = new System.Windows.Forms.Panel();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.panelLingo.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SearchBar.Location = new System.Drawing.Point(47, 23);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(83, 26);
            this.SearchBar.TabIndex = 0;
            this.SearchBar.Text = "Search";
            this.SearchBar.Click += new System.EventHandler(this.SearchBar_Click);
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            this.SearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBar_KeyDown);
            this.SearchBar.Leave += new System.EventHandler(this.SearchBar_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(47, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(707, 387);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panelLingo
            // 
            this.panelLingo.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLingo.Controls.Add(this.cmbSort);
            this.panelLingo.Controls.Add(this.SearchBar);
            this.panelLingo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLingo.Location = new System.Drawing.Point(0, 0);
            this.panelLingo.Name = "panelLingo";
            this.panelLingo.Size = new System.Drawing.Size(800, 67);
            this.panelLingo.TabIndex = 7;
            // 
            // cmbSort
            // 
            this.cmbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Alphabetical order",
            "Adding order"});
            this.cmbSort.Location = new System.Drawing.Point(512, 23);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(165, 28);
            this.cmbSort.TabIndex = 1;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // FormDiscovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.panelLingo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormDiscovery";
            this.Text = "Choose a topic";
            this.Load += new System.EventHandler(this.FormDiscovery_Load);
            this.panelLingo.ResumeLayout(false);
            this.panelLingo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelLingo;
        private System.Windows.Forms.ComboBox cmbSort;
    }
}