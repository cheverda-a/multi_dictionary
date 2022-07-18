using multilingo.Entities;
using Multilingo.Entities;
using Multilingo.Forms;
using Multilingo.SQL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Multilingo.UserControlers
{
    public partial class UserControlTermChoose : UserControl
    {
        private readonly FormInitial formInitial;
        public Term term;
        public Topic topic;

        public UserControlTermChoose(FormInitial formInitial, Topic topic)
        {
            this.formInitial = formInitial;
            this.topic = topic;
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            formInitial.OpenChildForm(new FormTermDisplay(formInitial, term));
        }

        private void lblName_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
            panelHover.BackColor = Color.DarkOrange;
        }

        private void lblName_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            panelHover.BackColor = Color.Orange;
        }

        private void UserControlTermChoose_Load(object sender, EventArgs e)
        {
            switch (Lingo.chosen)
            {
                case 1: 
                    lblName.Text = term.TermEn; 
                    break;
                case 2: 
                    lblName.Text = term.TermFr; 
                    break;
                case 3: 
                    lblName.Text = term.TermUa; 
                    break;
            }
        }
    }
}
