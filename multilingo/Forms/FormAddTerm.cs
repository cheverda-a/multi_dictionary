using multilingo.Entities;
using Multilingo.Entities;
using Multilingo.SQL;
using Multilingo.UserControlers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Multilingo.Forms
{
    public partial class FormChange : Form
    {
        internal TermsAccessor termsAccessor = new TermsAccessor();
        internal TopicsAccessor topicsAccessor = new TopicsAccessor();

        internal readonly FormInitial formInitial;
        private string[] topics;
        private List<Topic> topicsData;

        private Term term = new Term();
        private Topic topic;
        List<Term> terms = new List<Term>();

        public FormChange(FormInitial formInitial, Topic topic)
        {
            this.formInitial = formInitial;
            this.topic = topic;
            formInitial.Size = new Size(615, 415);
            InitializeComponent();
        }
        public FormChange(FormInitial formInitial, Topic topic, Term term)
        {
            this.formInitial = formInitial;
            this.topic = topic;
            this.term = term;
            formInitial.Size = new Size(615, 415);
            InitializeComponent();
        }

        private void FormChange_Load(object sender, EventArgs e)
        {
            Topic.Items.Clear();
            txtTerm.MaxLength = 50;
            txtDefine.MaxLength = 150;

            topics = new string[topicsAccessor.TopicCount()];
            topicsData = new List<Topic>();
            topicsData = topicsAccessor.GetTopics();

            for (int i = 0; i < topics.Length; i++)
            {
                topics[i] = topicsData[i].Name;
                Topic.Items.Add(topics[i]);
            }

            btnAddWord.BackColor = Color.CornflowerBlue;
            btnAddWord.ForeColor = Color.White;
            btnAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            switch (Lingo.chosen)
            {
                case 1: Language.SelectedIndex = 0; break;
                case 2: Language.SelectedIndex = 1; break;
                case 3: Language.SelectedIndex = 2; break;
            }

            int neededIndex = 0;
            if (Topic.Items.Contains($"{topic.Name}"))
            {
                for (int i = 0; i < topics.Length; i++)
                {
                    if (topicsData[i].Name.ToLower().Contains($"{topic.Name.ToLower()}"))
                        neededIndex = i;
                }
            }
                Topic.SelectedIndex = neededIndex;

            if (term.Id != 0)
            {
                for (int i = 0; i < terms.Count; i++)
                {
                    switch (Lingo.chosen)
                    {
                        case 1:
                            if (terms[i].TermEn != null && term.TermEn != null)
                            {
                                if (terms[i].TermEn.ToLower().Contains($"{term.TermEn.ToLower()}"))
                                    ChangeTerm.SelectedIndex = i;
                            }
                            break;
                        case 2:
                            if (terms[i].TermFr != null && term.TermFr != null)
                            {
                                if (terms[i].TermFr.ToLower().Contains($"{term.TermFr.ToLower()}"))
                                    ChangeTerm.SelectedIndex = i;
                            } 
                            break;
                        case 3:
                            if (terms[i].TermUa != null && term.TermUa != null)
                            {
                                if (terms[i].TermUa.ToLower().Contains($"{term.TermUa.ToLower()}"))
                                    ChangeTerm.SelectedIndex = i; 
                            }
                            break;
                    }
                }
            }


        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (Language.SelectedIndex < 0 || Topic.SelectedIndex < 0)
            {
                MessageBox.Show("Fill in all information before proceeding.");
                return;
            }

            switch (Lingo.chosen)
            {
                case 1:
                    term.TermEn = txtTerm.Text;
                    term.DefinitionEn = txtDefine.Text;

                    if (termsAccessor.GetIdEn(term) == 0)
                    {
                        termsAccessor.CreateEn(term);
                        bttnCancel_Click(sender, e);
                        term.Id = termsAccessor.GetIdEn(term);
                        formInitial.OpenChildForm(new FormChange(formInitial, topicsAccessor.GetTopicById(term.TopicId), term));
                    }
                    else
                        MessageBox.Show("This term already exists in this language!\nTry updating this term.");
                    break;
                case 2:
                    term.TermFr = txtTerm.Text;
                    term.DefinitionFr = txtDefine.Text;

                    if (termsAccessor.GetIdFr(term) == 0)
                    {
                        termsAccessor.CreateFr(term);
                        bttnCancel_Click(sender, e);
                        term.Id = termsAccessor.GetIdFr(term);
                        formInitial.OpenChildForm(new FormChange(formInitial, topicsAccessor.GetTopicById(term.TopicId), term));

                    }
                    else
                        MessageBox.Show("This term already exists in this language!\nTry updating this term.");
                    break;
                case 3:
                    term.TermUa = txtTerm.Text;
                    term.DefinitionUa = txtDefine.Text;

                    if (termsAccessor.GetIdUa(term) == 0)
                    {
                        termsAccessor.CreateUa(term);
                        bttnCancel_Click(sender, e);
                        term.Id = termsAccessor.GetIdUa(term);
                        formInitial.OpenChildForm(new FormChange(formInitial, topicsAccessor.GetTopicById(term.TopicId), term));
                    }
                    else
                        MessageBox.Show("This term already exists in this language!\nTry updating this term.");
                    break;
            }
           
        }
        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (Language.SelectedIndex < 0 || Topic.SelectedIndex < 0 || ChangeTerm.SelectedIndex < 0)
            {
                MessageBox.Show("Fill in all information before proceeding.");
                return;
            }

            int update = UpdateLanguage.SelectedIndex;

            if (txtDefine.Text != "" && txtTerm.Text != "")
            {
                switch (Language.SelectedIndex)
                {
                    case 0: 
                        term.TermEn = terms[ChangeTerm.SelectedIndex].TermEn;
                        term.Id = termsAccessor.GetIdEn(term); 
                        break;
                    case 1:
                        term.TermFr = terms[ChangeTerm.SelectedIndex].TermFr;
                        term.Id = termsAccessor.GetIdFr(term);
                        break;
                    case 2:
                        term.TermUa = terms[ChangeTerm.SelectedIndex].TermUa;
                        term.Id = termsAccessor.GetIdUa(term);
                        break;
                } 
                if (update == 0)
                {
                    term.TermEn = txtTerm.Text;
                    term.DefinitionEn = txtDefine.Text;
                    termsAccessor.EditEn(term);
                }
                else if (update == 1)
                {
                    term.TermFr = txtTerm.Text;
                    term.DefinitionFr = txtDefine.Text;
                    termsAccessor.EditFr(term);
                }
                else
                { 
                    term.TermUa = txtTerm.Text;
                    term.DefinitionUa = txtDefine.Text;
                    termsAccessor.EditUa(term);
                }
            }
            else
            {
                MessageBox.Show("Fill in all information before proceeding.");
                return;
            }
            bttnCancel_Click(sender, e);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            topic.Id = topicsAccessor.GetTopicId(topic);
            if (topic.Id != 0)
                formInitial.OpenChildForm(new FormTopic(formInitial, topic));
            else
                formInitial.OpenChildForm(new FormMainMenu(formInitial));
        }

        private void ChangeTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttnCreate.Enabled = false;
            UpdateLanguage.Visible = true;
            lblUpdate.Visible = true;
            txtDefine.Text = String.Empty;
            txtTerm.Text = String.Empty;
           // Topic_SelectedIndexChanged(sender, e);
        }

        private void Topic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTerm.Items.Clear();
            Lingo.chosen = Language.SelectedIndex + 1;
            topic.Name = topics[Topic.SelectedIndex];
            term.TopicId = topicsData[Topic.SelectedIndex].Id;
            terms = termsAccessor.GetTermsFromTopic(term.TopicId);

            if (terms.Count != 0)
            {
                foreach (Term term in terms)
                {

                    switch (Lingo.chosen)
                    {
                        case 1:
                            if (term.TermEn != "" && term.TermEn != null)
                            {
                                ChangeTerm.Items.Add(term.TermEn);
                                ChangeTerm.Enabled = true;
                            }
                            else
                            {
                                if (ChangeTerm.Items.Count > 0) break;
                                else
                                {
                                    ChangeTerm.Items.Clear();
                                    ChangeTerm.Enabled = false;
                                }
                            }
                            break;
                        case 2:
                            if (term.TermFr != "" && term.TermFr != null)
                            {
                                ChangeTerm.Items.Add(term.TermFr);
                                ChangeTerm.Enabled = true;
                            }
                            else
                            {
                                if (ChangeTerm.Items.Count > 0) break;
                                else
                                {
                                    ChangeTerm.Items.Clear();
                                    ChangeTerm.Enabled = false;
                                }
                            }
                            break;
                        case 3:
                            if (term.TermUa != "" && term.TermUa != null)
                            {
                                ChangeTerm.Items.Add(term.TermUa);
                                ChangeTerm.Enabled = true;
                            }
                            else
                            {
                                if (ChangeTerm.Items.Count > 0) break;
                                else
                                {
                                    ChangeTerm.Items.Clear();
                                    ChangeTerm.Enabled = false;
                                }
                            }
                            break;
                        default:
                            if (term.TermEn != "" && term.TermEn != null)
                            {
                                ChangeTerm.Items.Add(term.TermEn);
                                ChangeTerm.Enabled = true;
                            }
                            else
                            {
                                if (ChangeTerm.Items.Count > 0) break;
                                else
                                {
                                    ChangeTerm.Items.Clear();
                                    ChangeTerm.Enabled = false;
                                }
                            }
                            break;
                    }
                }
            }
            else
            {
                ChangeTerm.Items.Clear();
                ChangeTerm.Enabled = false;
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            bttnCreate.Enabled = true;
            bttnUpdate.Enabled = true;

            UpdateLanguage.Visible = false;
            lblUpdate.Visible = false;

            txtTerm.Text = String.Empty;
            txtDefine.Text = String.Empty;
           // ChangeTerm.Items.Clear();
        }

        private void Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Topic.SelectedIndex >= 0)
             Topic_SelectedIndexChanged(sender, e);
        }
    }
}
