
using multilingo.Entities;
using multilingo.UserControlers;
using Multilingo.Entities;
using Multilingo.SQL;
using Multilingo.UserControlers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Multilingo.Forms
{
    public partial class FormTermDisplay : Form
    {
        internal TermsAccessor termsAccessor = new TermsAccessor();
        internal TopicsAccessor topicsAccessor = new TopicsAccessor();
        internal readonly FormInitial formInitial;

        public Term term;
        private Button currentButton;
        private Label currentLanguage;

        public FormTermDisplay(FormInitial formInitial, Term term)
        {
            this.formInitial = formInitial;
            formInitial.Size = new Size(650, 415);
            this.term = term;
            InitializeComponent();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            formInitial.OpenChildForm(new FormTopic(formInitial, topicsAccessor.GetTopicById(termsAccessor.GetTopicId(term))));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Topic topic = topicsAccessor.GetTopicById(termsAccessor.GetTopicId(term));
            DialogResult dialogResult = MessageBox.Show("You are about to delete this term permanently.\nAre you sure you want to delete it?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                formInitial.OpenChildForm(new FormMainMenu(formInitial));
                termsAccessor.Delete(term.Id);
            }
            else if (dialogResult == DialogResult.No)
                DisableButton();
            
        }

        private void FormTermDisplay_Load(object sender, EventArgs e)
        {
            if (Lingo.chosen == 1)
                LingoActivate(lblEn);
            else if (Lingo.chosen == 2)
                LingoActivate(lblFr);
            else
                LingoActivate(lbUa); 
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

        private void LingoActivate(object lblSender)
        {
            if (lblSender != null)
            {
                if (currentLanguage != (Label)lblSender)
                {
                    LingoDisable();
                    panelWordDisplay.Controls.Clear();
                    UserControlTermDisplay word = new UserControlTermDisplay(formInitial, term);
                    panelWordDisplay.Controls.Add(word);
                    word.Dock = DockStyle.Fill;

                    if (word == null)
                    {
                        UserControlError error = new UserControlError("No translation for this term yet.");
                        panelWordDisplay.Controls.Add(error);
                        error.Dock = DockStyle.Fill;
                    }

                    currentLanguage = (Label)lblSender;
                    currentLanguage.BackColor = Color.Red;
                    currentLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, 
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        private void lblEn_Click(object sender, EventArgs e)
        {
            Lingo.chosen = 1;
            LingoActivate(sender);
        }

        private void lblFr_Click(object sender, EventArgs e)
        {
            Lingo.chosen = 2;
            LingoActivate(sender);
        }

        private void lbUa_Click(object sender, EventArgs e)
        {
            Lingo.chosen = 3;
            LingoActivate(sender);
        }

        private void btnFavourites_Click(object sender, EventArgs e)
        {
            formInitial.OpenChildForm(new FormChange(formInitial, topicsAccessor.GetTopicById(term.TopicId), term));
        }
    }
}
