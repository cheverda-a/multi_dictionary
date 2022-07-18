using multilingo.Entities;
using Multilingo.Entities;
using Multilingo.Forms;
using Multilingo.SQL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Multilingo.UserControlers
{
    public partial class UserControlTermDisplay : UserControl
    {
        internal TermsAccessor termsAccessor = new TermsAccessor();
        internal TopicsAccessor topicsAccessor = new TopicsAccessor();
        public Term term;
        private FormInitial formInitial;

        public UserControlTermDisplay(FormInitial formInitial, Term term)
        {
            this.term = term;
            this.formInitial = formInitial;
            InitializeComponent();
        }

        private void UserControlTermDisplay_Load(object sender, EventArgs e)
        {
            if (Lingo.chosen == 1)
            {
                if ((term.DefinitionEn == "" || term.DefinitionEn == null) || (term.TermEn == "" || term.TermEn == null))
                {
                    lblTerm.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblDefinition.Text = term.DefinitionEn;
                    lblTerm.Text = term.TermEn;
                    lblTerm.ForeColor = Color.RoyalBlue;
                }
            }
            else if (Lingo.chosen == 2)
            {
                if ((term.DefinitionFr == "" || term.DefinitionFr == null) || (term.TermFr == "" || term.TermFr == null))
                {
                    lblTerm.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblDefinition.Text = term.DefinitionFr;
                    lblTerm.Text = term.TermFr;
                    lblTerm.ForeColor = Color.RoyalBlue;
                }
            }
            else
            {
                if ((term.DefinitionUa == "" || term.DefinitionUa == null) || (term.TermUa == "" || term.TermUa == null))
                {
                    lblTerm.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblDefinition.Text = term.DefinitionUa;
                    lblTerm.Text = term.TermUa;
                    lblTerm.ForeColor = Color.RoyalBlue;
                }
            }

            if (topicsAccessor.GetTopicById(termsAccessor.GetTopicId(term)) == null)
            {
                MessageBox.Show("This term was deleted permanently.");
                formInitial.OpenChildForm(new FormTopic(formInitial, topicsAccessor.GetTopicById(termsAccessor.GetTopicId(term))));
            }
            else lblTopic.Text = topicsAccessor.GetTopicById(termsAccessor.GetTopicId(term)).Name;

        }
    }
}
