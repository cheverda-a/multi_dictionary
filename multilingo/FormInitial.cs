using Multilingo.Entities;
using Multilingo.SQL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Multilingo
{
    public partial class FormInitial : Form
    {
        private Form activeForm;
        public FormInitial()
        {
            this.Size = new Size(1210, 584);
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void FormInitial_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormMainMenu(this));
        }

        internal void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
           
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelInitial.Controls.Add(childForm);
            this.panelInitial.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            activeForm = childForm;
        }
    }
}
