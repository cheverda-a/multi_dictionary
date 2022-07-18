using System;
using System.Windows.Forms;

namespace multilingo.UserControlers
{
    public partial class UserControlError : UserControl
    {
        private string message;
        public UserControlError(string message)
        {
            this.message = message;
            InitializeComponent();
        }

        private void UserControlError_Load(object sender, EventArgs e)
        {
            lblError.Text = message;
        }
    }
}
