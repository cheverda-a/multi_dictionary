using Multilingo.Forms;
using System;
using Multilingo.SQL;
using System.Drawing;
using System.Windows.Forms;
using Multilingo.Entities;

namespace Multilingo
{
    public partial class FormMainMenu : Form
    {
        internal readonly FormInitial formInitial;
        public FormMainMenu(FormInitial formInitial)
        {
            this.formInitial = formInitial;
            formInitial.Size = new Size(900, 415);
            formInitial.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }

        private Button currentButton;
        private Form activeForm;

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormDiscovery(formInitial), btnDiscover);
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

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDiscovery(formInitial), sender);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = "";
            ShowInputDialogBox(ref input, "Put in the name of your new topic:", "New Topic Creation");
            Topic topic = new Topic();
            if (input != "")
            {
                topic.Name = input;
                TopicsAccessor accessor = new TopicsAccessor();
                accessor.CreateTopic(topic);
                OpenChildForm(new FormDiscovery(formInitial), btnDiscover);
            }
            else return;
        }

        private void Reset()
        {
            DisableButton();
            panelDesktop.BackColor = Color.White;
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private static DialogResult ShowInputDialogBox(ref string input, string prompt, string title = "Title")
        {
            Size size = new Size(250, 150);
            Form inputBox = new Form();
            inputBox.ControlBox = false;
            inputBox.StartPosition = FormStartPosition.CenterScreen;

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = title;

            Label label = new Label();
            label.Text = prompt;
            label.Location = new Point(45, 40);
            label.Width = size.Width - 10;
            inputBox.Controls.Add(label);

            TextBox textBox = new TextBox();
            textBox.Size = new Size(150, 25);
            textBox.Location = new Point(50, label.Location.Y + 20);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 25);
            okButton.Text = "&Create";
            okButton.Location = new Point(size.Width - 200, size.Height - 50);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 120, size.Height - 50);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;

            return result;
        }

    }
}

