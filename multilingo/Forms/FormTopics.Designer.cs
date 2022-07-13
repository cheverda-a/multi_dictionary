namespace multilingo.Forms
{
    partial class FormTopics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTopics));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
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
            this.panelMenu.Size = new System.Drawing.Size(220, 528);
            this.panelMenu.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(147, 56);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(73, 61);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(220, 60);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = " Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWord.FlatAppearance.BorderSize = 0;
            this.btnAddWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWord.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddWord.Image = ((System.Drawing.Image)(resources.GetObject("btnAddWord.Image")));
            this.btnAddWord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddWord.Location = new System.Drawing.Point(0, 114);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAddWord.Size = new System.Drawing.Size(220, 60);
            this.btnAddWord.TabIndex = 5;
            this.btnAddWord.Text = "Add";
            this.btnAddWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddWord.UseVisualStyleBackColor = false;
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(219, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 528);
            this.panel1.TabIndex = 2;
            // 
            // FormTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormTopics";
            this.Text = "TopicDisplay";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}