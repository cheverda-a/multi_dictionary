using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multilingo.UserControlers
{
    public partial class UserControlWordDisplay : UserControl
    {
        public UserControlWordDisplay()
        {
            InitializeComponent();
        }

        private string term;
        private string definition;
        private string topic;
        public string Term
        {
            get { return term; }
            set { term = value; lblTerm.Text = term; }
        }
        public string Definition
        {
            get { return definition; }
            set { definition = value; lblDefinition.Text = definition; }
        }

        public string Topic
        {
            get { return topic; }
            set { topic = value; lblTopic.Text = topic; }
        }


    }
}
