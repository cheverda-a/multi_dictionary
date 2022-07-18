using multilingo.Entities;
using multilingo.UserControlers;
using Multilingo.Entities;
using Multilingo.SQL;
using Multilingo.UserControlers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Multilingo.Forms
{
    public partial class FormTopic : Form
    {
        internal TermsAccessor termsAccessor = new TermsAccessor();
        internal TopicsAccessor topicsAccessor = new TopicsAccessor();

        internal readonly FormInitial formInitial;
        internal Topic topic;
        private int termsNumber;
        private UserControlTermChoose[] terms;

        private Button currentButton;
        private Label currentLanguage;
        private Form activeForm;

        public FormTopic(FormInitial formInitial, Topic topic)
        {
            this.formInitial = formInitial;
            formInitial.Size = new Size(900, 415);
            this.topic = topic;
            InitializeComponent();
        }

        // !!!
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (this.panelDesktop.Controls.Contains(new FormChange(formInitial, topic)))
                formInitial.OpenChildForm(new FormTopic(formInitial, topic));
            else
                formInitial.OpenChildForm(new FormMainMenu(formInitial));
        }

        internal void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.CornflowerBlue;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void LingoActivate(object lblSender)
        {
            if (lblSender != null)
            {
                if (currentLanguage != (Label)lblSender)
                {
                    LingoDisable();
                    populateTerms();
                    currentLanguage = (Label)lblSender;
                    currentLanguage.BackColor = Color.Red;
                    currentLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void LingoDisable()
        {
            foreach (Control label in panelLingo.Controls)
            {
                if (label.GetType() == typeof(Label))
                {
                    label.BackColor = Color.RoyalBlue;
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.RoyalBlue;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void FormTopics_Load(object sender, EventArgs e)
        {
            lblNameTopic.Text = topic.Name;
            fpTerms.Controls.Clear();

            if (Lingo.chosen == 1)
                LingoActivate(lblEn);
            else if (Lingo.chosen == 2)
                LingoActivate(lblFr);
            else
                LingoActivate(lbUa);
        }

        private void populateTerms()
        {
            fpTerms.Controls.Clear();
            termsNumber = topicsAccessor.TermsCount(topic.Id);
            terms = new UserControlTermChoose[termsNumber];
            List<Term> termsData = termsAccessor.GetTermsFromTopic(topic.Id);

            for (int i = 0; i < terms.Length; i++)
            {
                terms[i] = new UserControlTermChoose(formInitial, topic);
                terms[i].BringToFront();
                terms[i].term = termsData[i];

                switch (Lingo.chosen)
                {
                    case 1: if (termsData[i].TermEn == null) continue; break;
                    case 2: if (termsData[i].TermFr == null) continue; break;
                    case 3: if (termsData[i].TermUa == null) continue; break;
                }
                fpTerms.Controls.Add(terms[i]);
            }

            if (termsData.Count == 0)
            {
                lblNameTopic.Text = "No terms in " + topic.Name + " yet.";
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            formInitial.OpenChildForm(new FormChange(formInitial, topic));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            DialogResult dialogResult = MessageBox.Show("You are about to delete this topic permanently.\nAre you sure you want to delete it?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                topicsAccessor.DeleteTopic(topic.Id);
                formInitial.OpenChildForm(new FormMainMenu(formInitial));
            }
            else if (dialogResult == DialogResult.No)
                DisableButton();
            
        }

        private void lblEn_Click_1(object sender, EventArgs e)
        {
            Lingo.chosen = 1;
            LingoActivate(sender);
        }

        private void lblFr_Click_1(object sender, EventArgs e)
        {
            Lingo.chosen = 2;
            LingoActivate(sender);
        }

        private void lbUa_Click_1(object sender, EventArgs e)
        {
            Lingo.chosen = 3;
            LingoActivate(sender);
        }

        private void SearchBar_TextChanged_1(object sender, EventArgs e)
        {
            if (SearchBar.Text == "")
            {
                if (fpTerms.Controls.Count != termsNumber)
                {
                    populateTerms();
                }
            }
        }

        private void SearchBar_Click_1(object sender, EventArgs e)
        {
            if (SearchBar.Text == "Search")
            {
                SearchBar.Text = "";
                SearchBar.ForeColor = Color.Black;
            }
        }

        private void SearchBar_Leave_1(object sender, EventArgs e)
        {
            SearchBar.Text = "Search";
            SearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
        }

        private void SearchBar_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (SearchBar.Text != "")
                {
                    fpTerms.Controls.Clear();
                    for (int i = 0; i < termsNumber; i++)
                    {
                        if (Lingo.chosen == 1)
                        {
                            if (terms[i].term.TermEn != null && terms[i].term.TermEn != "")
                                if (terms[i].term.TermEn.ToLower().Contains(SearchBar.Text.ToLower()))
                                fpTerms.Controls.Add(terms[i]);
                        }
                        else if (Lingo.chosen == 2)
                        {
                            if (terms[i].term.TermFr != null && terms[i].term.TermFr != "")
                            if (terms[i].term.TermFr.ToLower().Contains(SearchBar.Text.ToLower()))
                                fpTerms.Controls.Add(terms[i]);
                        }
                        else
                        {
                            if (terms[i].term.TermUa != null && terms[i].term.TermUa != "")
                                if (terms[i].term.TermUa.ToLower().Contains(SearchBar.Text.ToLower()))
                                fpTerms.Controls.Add(terms[i]);
                        }
                    }
                }
            }
        }
    }
}
