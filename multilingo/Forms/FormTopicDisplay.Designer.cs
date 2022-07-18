namespace Multilingo.Forms
{
    partial class FormTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTopic));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.panelLingo = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblFr = new System.Windows.Forms.Label();
            this.lbUa = new System.Windows.Forms.Label();
            this.lblNameTopic = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.fpTerms = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu.SuspendLayout();
            this.panelLingo.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnCloseChildForm);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.btnAddWord);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(221, 593);
            this.panelMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 67);
            this.label1.TabIndex = 7;
            this.label1.Text = "MultiLingo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(147, 65);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(73, 61);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(220, 60);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = " Delete topic";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWord.FlatAppearance.BorderSize = 0;
            this.btnAddWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWord.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddWord.Image = ((System.Drawing.Image)(resources.GetObject("btnAddWord.Image")));
            this.btnAddWord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddWord.Location = new System.Drawing.Point(0, 132);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAddWord.Size = new System.Drawing.Size(220, 60);
            this.btnAddWord.TabIndex = 5;
            this.btnAddWord.Text = " Add a word";
            this.btnAddWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // panelLingo
            // 
            this.panelLingo.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLingo.Controls.Add(this.SearchBar);
            this.panelLingo.Controls.Add(this.lblEn);
            this.panelLingo.Controls.Add(this.lblFr);
            this.panelLingo.Controls.Add(this.lbUa);
            this.panelLingo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLingo.Location = new System.Drawing.Point(221, 0);
            this.panelLingo.Name = "panelLingo";
            this.panelLingo.Size = new System.Drawing.Size(967, 67);
            this.panelLingo.TabIndex = 7;
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SearchBar.Location = new System.Drawing.Point(47, 22);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(268, 26);
            this.SearchBar.TabIndex = 7;
            this.SearchBar.Text = "Search";
            this.SearchBar.Click += new System.EventHandler(this.SearchBar_Click_1);
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged_1);
            this.SearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBar_KeyDown_1);
            this.SearchBar.Leave += new System.EventHandler(this.SearchBar_Leave_1);
            // 
            // lblEn
            // 
            this.lblEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEn.Location = new System.Drawing.Point(709, 1);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(82, 66);
            this.lblEn.TabIndex = 6;
            this.lblEn.Text = "ENG";
            this.lblEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEn.Click += new System.EventHandler(this.lblEn_Click_1);
            // 
            // lblFr
            // 
            this.lblFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFr.Location = new System.Drawing.Point(797, 0);
            this.lblFr.Name = "lblFr";
            this.lblFr.Size = new System.Drawing.Size(82, 67);
            this.lblFr.TabIndex = 5;
            this.lblFr.Text = "FRA";
            this.lblFr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFr.Click += new System.EventHandler(this.lblFr_Click_1);
            // 
            // lbUa
            // 
            this.lbUa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUa.Location = new System.Drawing.Point(885, 0);
            this.lbUa.Name = "lbUa";
            this.lbUa.Size = new System.Drawing.Size(82, 67);
            this.lbUa.TabIndex = 4;
            this.lbUa.Text = "UKR";
            this.lbUa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUa.Click += new System.EventHandler(this.lbUa_Click_1);
            // 
            // lblNameTopic
            // 
            this.lblNameTopic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNameTopic.AutoSize = true;
            this.lblNameTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTopic.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNameTopic.Location = new System.Drawing.Point(383, 30);
            this.lblNameTopic.Name = "lblNameTopic";
            this.lblNameTopic.Size = new System.Drawing.Size(85, 29);
            this.lblNameTopic.TabIndex = 1;
            this.lblNameTopic.Text = "label2";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.lblNameTopic);
            this.panelDesktop.Controls.Add(this.fpTerms);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(221, 67);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(967, 526);
            this.panelDesktop.TabIndex = 8;
            // 
            // fpTerms
            // 
            this.fpTerms.AllowDrop = true;
            this.fpTerms.AutoScroll = true;
            this.fpTerms.BackColor = System.Drawing.Color.Transparent;
            this.fpTerms.Location = new System.Drawing.Point(47, 81);
            this.fpTerms.Name = "fpTerms";
            this.fpTerms.Size = new System.Drawing.Size(869, 386);
            this.fpTerms.TabIndex = 0;
            // 
            // FormTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 593);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelLingo);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1210, 584);
            this.Name = "FormTopic";
            this.Text = "TopicDisplay";
            this.Load += new System.EventHandler(this.FormTopics_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLingo.ResumeLayout(false);
            this.panelLingo.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLingo;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblFr;
        private System.Windows.Forms.Label lbUa;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblNameTopic;
        private System.Windows.Forms.FlowLayoutPanel fpTerms;
    }
}