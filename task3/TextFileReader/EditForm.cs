using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileReader
{
    public partial class EditForm : Form
    {
        public tfr_form MainForm;

        public EditForm(tfr_form f1)
        {
            MainForm = f1;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ef_b_save.Click += Ef_b_save_Click;
            ef_tb_edit.Text = MainForm.MainText;
            ef_b_cansel.Click += Ef_b_cansel_Click;
        }

        /// <summary>
        /// Обработка нажатия кнопки отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ef_b_cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработка нажатия кнопки схранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ef_b_save_Click(object sender, EventArgs e)
        {
            MainForm.MainText = ef_tb_edit.Text;
            this.Close();
        }
    }
}
