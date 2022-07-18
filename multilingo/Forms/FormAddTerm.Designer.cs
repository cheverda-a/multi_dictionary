namespace Multilingo.Forms
{
    partial class FormChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChange));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDefine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDefine = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.ComboBox();
            this.bttnCreate = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.Topic = new System.Windows.Forms.ComboBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangeTerm = new System.Windows.Forms.ComboBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.UpdateLanguage = new System.Windows.Forms.ComboBox();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Language:";
            // 
            // txtDefine
            // 
            this.txtDefine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDefine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefine.Location = new System.Drawing.Point(483, 341);
            this.txtDefine.Multiline = true;
            this.txtDefine.Name = "txtDefine";
            this.txtDefine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDefine.Size = new System.Drawing.Size(333, 118);
            this.txtDefine.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Topic:";
            // 
            // lblDefine
            // 
            this.lblDefine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDefine.AutoSize = true;
            this.lblDefine.BackColor = System.Drawing.Color.Transparent;
            this.lblDefine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefine.Location = new System.Drawing.Point(268, 344);
            this.lblDefine.Name = "lblDefine";
            this.lblDefine.Size = new System.Drawing.Size(139, 25);
            this.lblDefine.TabIndex = 11;
            this.lblDefine.Text = "New definition:";
            // 
            // lblTerm
            // 
            this.lblTerm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(268, 163);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(184, 44);
            this.lblTerm.TabIndex = 13;
            this.lblTerm.Text = "Term to change:";
            // 
            // Language
            // 
            this.Language.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Language.FormattingEnabled = true;
            this.Language.Items.AddRange(new object[] {
            "English",
            "French",
            "Ukrainian"});
            this.Language.Location = new System.Drawing.Point(483, 54);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(333, 33);
            this.Language.TabIndex = 17;
            this.Language.SelectedIndexChanged += new System.EventHandler(this.Language_SelectedIndexChanged);
            // 
            // bttnCreate
            // 
            this.bttnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnCreate.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bttnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCreate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bttnCreate.Location = new System.Drawing.Point(693, 505);
            this.bttnCreate.Name = "bttnCreate";
            this.bttnCreate.Size = new System.Drawing.Size(160, 51);
            this.bttnCreate.TabIndex = 19;
            this.bttnCreate.Text = "Create";
            this.bttnCreate.UseVisualStyleBackColor = true;
            this.bttnCreate.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bttnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnUpdate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bttnUpdate.Location = new System.Drawing.Point(501, 505);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(160, 51);
            this.bttnUpdate.TabIndex = 20;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // Topic
            // 
            this.Topic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Topic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Topic.FormattingEnabled = true;
            this.Topic.Items.AddRange(new object[] {
            "English",
            "French",
            "Ukrainian"});
            this.Topic.Location = new System.Drawing.Point(483, 107);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(333, 33);
            this.Topic.TabIndex = 22;
            this.Topic.SelectedIndexChanged += new System.EventHandler(this.Topic_SelectedIndexChanged);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnCancel.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bttnCancel.Location = new System.Drawing.Point(306, 505);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(160, 51);
            this.bttnCancel.TabIndex = 23;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.btnCloseChildForm);
            this.panelMenu.Controls.Add(this.btnAddWord);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(219, 586);
            this.panelMenu.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 67);
            this.label3.TabIndex = 7;
            this.label3.Text = "MultiLingo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // txtTerm
            // 
            this.txtTerm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerm.Location = new System.Drawing.Point(483, 280);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(333, 30);
            this.txtTerm.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "New term:";
            // 
            // ChangeTerm
            // 
            this.ChangeTerm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChangeTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangeTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTerm.FormattingEnabled = true;
            this.ChangeTerm.Location = new System.Drawing.Point(483, 163);
            this.ChangeTerm.Name = "ChangeTerm";
            this.ChangeTerm.Size = new System.Drawing.Size(333, 33);
            this.ChangeTerm.TabIndex = 27;
            this.ChangeTerm.SelectedIndexChanged += new System.EventHandler(this.ChangeTerm_SelectedIndexChanged);
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(268, 224);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(101, 25);
            this.lblUpdate.TabIndex = 28;
            this.lblUpdate.Text = "Update in:";
            this.lblUpdate.Visible = false;
            // 
            // UpdateLanguage
            // 
            this.UpdateLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLanguage.FormattingEnabled = true;
            this.UpdateLanguage.Items.AddRange(new object[] {
            "English",
            "French",
            "Ukrainian"});
            this.UpdateLanguage.Location = new System.Drawing.Point(483, 221);
            this.UpdateLanguage.Name = "UpdateLanguage";
            this.UpdateLanguage.Size = new System.Drawing.Size(333, 33);
            this.UpdateLanguage.TabIndex = 29;
            this.UpdateLanguage.Visible = false;
            // 
            // FormChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(919, 586);
            this.Controls.Add(this.UpdateLanguage);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.ChangeTerm);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnCreate);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblDefine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDefine);
            this.Controls.Add(this.label1);
            this.Name = "FormChange";
            this.Text = "Change";
            this.Load += new System.EventHandler(this.FormChange_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDefine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDefine;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.ComboBox Language;
        private System.Windows.Forms.Button bttnCreate;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.ComboBox Topic;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ChangeTerm;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.ComboBox UpdateLanguage;
    }
}