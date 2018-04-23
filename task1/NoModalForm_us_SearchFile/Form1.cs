using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoModalForm_us_SearchFile
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            mf_b_close.Click += Mf_b_close_Click;
            mf_b_search.Click += Mf_b_search_Click;
        }

        private void Mf_b_search_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Show();
        }

        private void Mf_b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
