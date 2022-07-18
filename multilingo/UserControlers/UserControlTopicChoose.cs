using Multilingo.Entities;
using Multilingo.Forms;
using Multilingo.SQL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Multilingo.UserControlers
{
    public partial class UserControlTopicChoose : UserControl
    {
        private readonly FormInitial formInitial;
        public Topic topic;

        public UserControlTopicChoose(FormInitial formInitial)
        {
            this.formInitial = formInitial;
            InitializeComponent();
        }

        private void lblName_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
            panelHover.BackColor = Color.Red;
        }

        private void lblName_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            panelHover.BackColor = Color.OrangeRed;
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            formInitial.OpenChildForm(new FormTopic(formInitial, topic));
        }

        private void UserControlTopicChoose_Load(object sender, EventArgs e)
        {
            lblName.Text = topic.Name;
        }
    }
}
