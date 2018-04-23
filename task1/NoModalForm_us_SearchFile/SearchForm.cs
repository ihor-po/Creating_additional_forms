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

namespace NoModalForm_us_SearchFile
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            sf_b_openFolder.Click += Sf_b_openFolder_Click;

            sf_tb_masks.TextChanged += Sf_tb_masks_TextChanged;

            sf_b_startSearch.Click += Sf_b_startSearch_Click;
        }

        /// <summary>
        /// Запуск процедуры поиска файлов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_b_startSearch_Click(object sender, EventArgs e)
        {
            sf_lb_files.Items.Clear(); //очищаю список

            String[] masks = sf_tb_masks.Text.Split('.').ToArray(); //разбиваю введенную маску на массив для проверки

            if (masks.Count() != 2 || masks[1] == "")
            {
                MessageBox.Show("Вы ввели не правильную маску.\rМаска должна быть вида *.*",
                    "Ошибка ввода маски!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                sf_lb_files.Cursor = Cursors.WaitCursor;
                this.Cursor = Cursors.WaitCursor;

                foreach (var file in Directory.GetFiles(sf_st_path.Text, sf_tb_masks.Text))
                {
                    sf_lb_files.Items.Add(file.ToString());
                }

                MessageBox.Show("Нашлось " + sf_lb_files.Items.Count.ToString() + " файлов", "Результат добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Cursor = Cursors.Default;
                sf_lb_files.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Изменение текста в поле для ввода маски
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_tb_masks_TextChanged(object sender, EventArgs e)
        {
            if (sf_tb_masks.Text.Length > 0)
            {
                sf_b_startSearch.Enabled = true;
            }
            else
            {
                sf_b_startSearch.Enabled = false;
            }
        }

        /// <summary>
        /// При нажатии на кнопку открывется диалог выбора папки для поиска файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_b_openFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            dir.ShowNewFolderButton = false; // Т.к. у нас предусмотрен только поиск, то пользователю не нужна возможность содавать папки

            if (dir.ShowDialog() == DialogResult.OK)
            {

                sf_st_path.Text = dir.SelectedPath;
                sf_tb_masks.Enabled = true;
                sf_tb_masks.Focus();
            }
            else
            {
                dir = null;
                sf_st_path.Text = "";
                sf_tb_masks.Text = "";
                if (sf_tb_masks.Enabled)
                {
                    sf_tb_masks.Enabled = false;
                }
            }
        }
    }
}
