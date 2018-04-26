using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class CEdit : Form
    {
        bool _isNew;
        Component _component;

        public CEdit( Component c, bool isNew)
        {
            InitializeComponent();

            _isNew = isNew;
            _component = c;

            if (isNew)
            {
                this.Text = "Создание компонента";
                cef_tb_title.Text = "";
                cef_rtb_characteristics.Text = "";
                cef_rtb_description.Text = "";
                cef_tb_price.Text = "0,00";
                cef_b_add.Text = "Создать";
            }
            else
            {
                this.Text = "Редактирование компонента";
                cef_tb_title.Text = _component.Title;
                cef_rtb_characteristics.Text = _component.Characteristic;
                cef_rtb_description.Text = _component.Description;
                cef_tb_price.Text = _component.Price.ToString();
                cef_b_add.Text = "Изменить";
            }
           
        }

        protected override void OnLoad(EventArgs e)
        {
            cef_b_cancel.Click += Cef_b_cancel_Click;
            cef_b_add.Click += Cef_b_add_Click;
        }

        /// <summary>
        /// Обработка события нажатия кнопки добавления / редакирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cef_b_add_Click(object sender, EventArgs e)
        {
            if (cef_tb_title.Text == "" || 
                cef_rtb_characteristics.Text == "" || 
                cef_rtb_description.Text == "" ||
                cef_tb_price.Text == ""
                )
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            else
            {
                if (_component == null)
                {
                    _component = new Component();
                }
                _component.Title = cef_tb_title.Text;
                _component.Characteristic = cef_rtb_characteristics.Text;
                _component.Description = cef_rtb_description.Text;
                try
                {
                    _component.Price = float.Parse(cef_tb_price.Text);

                    if (_component.Price < 0)
                    {
                        _component.Price = 0;
                        MessageBox.Show("Цена указана не верно!\rЦена не может быть меньше 0", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка формата цены!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Обработка нажатия на кнопку отмены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cef_b_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
