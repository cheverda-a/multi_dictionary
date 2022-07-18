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
    public partial class FormDiscovery : Form
    {
        internal TopicsAccessor topicsAccessor = new TopicsAccessor();
        internal readonly FormInitial formInitial;

        private static int topicsNumber;
        private UserControlTopicChoose[] topics;
        private List<Topic> topicsData = new List<Topic>();

        public FormDiscovery(FormInitial formInitial)
        {
            this.formInitial = formInitial;
            InitializeComponent();
        }

        private void FormDiscovery_Load(object sender, EventArgs e)
        {
            cmbSort.SelectedIndex = 1;
            topicsNumber = topicsAccessor.TopicCount();
            if (topicsNumber == 0)
            {
                flowLayoutPanel1.Hide();
                MessageBox.Show("No Topics. Come back when you add some.");
                return;
            }
            else cmbSort_SelectedIndexChanged(sender, e);
        }

        private void populateTopics()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < topics.Length; i++)
            {
                topics[i] = new UserControlTopicChoose(formInitial);
                topics[i].topic = topicsData[i];
                flowLayoutPanel1.Controls.Add(topics[i]);
            }
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            if (SearchBar.Text == "")
            {
                if (flowLayoutPanel1.Controls.Count != topicsNumber)
                {
                    for (int i = 0; i < topicsNumber; i++)
                    {
                        flowLayoutPanel1.Controls.Add(topics[i]);
                    }
                }
                SearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void SearchBar_Click(object sender, EventArgs e)
        {
            if (SearchBar.Text == "Search")
            {
                SearchBar.Text = "";
                SearchBar.ForeColor = Color.Black;
            }
        }

        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (SearchBar.Text != "")
                {
                    flowLayoutPanel1.Controls.Clear();
                    for (int i = 0; i < topicsNumber; i++)
                    {
                        if (Lingo.chosen == 1)
                        {
                            if (topics[i].topic.Name.ToLower().Contains(SearchBar.Text.ToLower()))
                                flowLayoutPanel1.Controls.Add(topics[i]);
                        }
                    }
                }
            }
        }

        private void SearchBar_Leave(object sender, EventArgs e)
        {
            SearchBar.Text = "Search";
            SearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            topics = new UserControlTopicChoose[topicsNumber];
            topicsData = topicsAccessor.GetTopics();

            if (cmbSort.SelectedIndex == 0)
            {
                topicsData.Sort((x, y) => string.Compare(x.Name, y.Name));
                populateTopics();
            }
            else populateTopics();
        }
    }
}
