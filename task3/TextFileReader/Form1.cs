using System;
using System.IO;
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
    public partial class tfr_form : Form
    {
        public string MainText {
            get { return tfr_tb_fileText.Text; }
            set { tfr_tb_fileText.Text = value; }
        }
        public tfr_form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            tfr_b_openFile.Click += Tfr_b_openFile_Click;
            tfr_b_editText.Click += Tfr_b_editText_Click;
        }

        /// <summary>
        /// Обработка нажатия кнопки редактирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tfr_b_editText_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm(this);
            ef.Show();
        }

        /// <summary>
        /// Обработка нажатия кнопки открытия файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tfr_b_openFile_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text files (*.txt)|*.txt";      //задает фильтры для выбора файлов
            ofd.FilterIndex = 1;                        //задает выбраный фильтр по умолчанию
            ofd.RestoreDirectory = true;                //восстанавливает ранее выбранный каталог

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MainText = File.ReadAllText(ofd.FileName, Encoding.Default);

                ofd.Dispose();

                tfr_b_editText.Enabled = true;
            }
        }
    }
}
