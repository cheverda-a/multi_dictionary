namespace Multilingo.Forms
{
    partial class FormTermDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTermDisplay));
            this.panelWordDisplay = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelLingo = new System.Windows.Forms.Panel();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblFr = new System.Windows.Forms.Label();
            this.lbUa = new System.Windows.Forms.Label();
            this.btnFavourites = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLingo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWordDisplay
            // 
            this.panelWordDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWordDisplay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelWordDisplay.Location = new System.Drawing.Point(263, 105);
            this.panelWordDisplay.Name = "panelWordDisplay";
            this.panelWordDisplay.Size = new System.Drawing.Size(665, 391);
            this.panelWordDisplay.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.btnFavourites);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnCloseChildForm);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(223, 535);
            this.panelMenu.TabIndex = 4;
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
            this.btnDelete.Location = new System.Drawing.Point(0, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(220, 60);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = " Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelLingo
            // 
            this.panelLingo.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLingo.Controls.Add(this.lblEn);
            this.panelLingo.Controls.Add(this.lblFr);
            this.panelLingo.Controls.Add(this.lbUa);
            this.panelLingo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLingo.Location = new System.Drawing.Point(223, 0);
            this.panelLingo.Name = "panelLingo";
            this.panelLingo.Size = new System.Drawing.Size(758, 67);
            this.panelLingo.TabIndex = 6;
            // 
            // lblEn
            // 
            this.lblEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEn.Location = new System.Drawing.Point(500, 1);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(82, 66);
            this.lblEn.TabIndex = 6;
            this.lblEn.Text = "ENG";
            this.lblEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEn.Click += new System.EventHandler(this.lblEn_Click);
            // 
            // lblFr
            // 
            this.lblFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFr.Location = new System.Drawing.Point(588, 0);
            this.lblFr.Name = "lblFr";
            this.lblFr.Size = new System.Drawing.Size(82, 67);
            this.lblFr.TabIndex = 5;
            this.lblFr.Text = "FRA";
            this.lblFr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFr.Click += new System.EventHandler(this.lblFr_Click);
            // 
            // lbUa
            // 
            this.lbUa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUa.Location = new System.Drawing.Point(676, 0);
            this.lbUa.Name = "lbUa";
            this.lbUa.Size = new System.Drawing.Size(82, 67);
            this.lbUa.TabIndex = 4;
            this.lbUa.Text = "UKR";
            this.lbUa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUa.Click += new System.EventHandler(this.lbUa_Click);
            // 
            // btnFavourites
            // 
            this.btnFavourites.BackColor = System.Drawing.Color.Transparent;
            this.btnFavourites.FlatAppearance.BorderSize = 0;
            this.btnFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourites.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFavourites.Image = ((System.Drawing.Image)(resources.GetObject("btnFavourites.Image")));
            this.btnFavourites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavourites.Location = new System.Drawing.Point(0, 132);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnFavourites.Size = new System.Drawing.Size(220, 60);
            this.btnFavourites.TabIndex = 8;
            this.btnFavourites.Text = " Edit word";
            this.btnFavourites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavourites.UseVisualStyleBackColor = false;
            this.btnFavourites.Click += new System.EventHandler(this.btnFavourites_Click);
            // 
            // FormTermDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 535);
            this.Controls.Add(this.panelLingo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelWordDisplay);
            this.Name = "FormTermDisplay";
            this.Text = "FormWordDisplay";
            this.Load += new System.EventHandler(this.FormTermDisplay_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLingo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWordDisplay;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelLingo;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblFr;
        private System.Windows.Forms.Label lbUa;
        private System.Windows.Forms.Button btnFavourites;
    }
}