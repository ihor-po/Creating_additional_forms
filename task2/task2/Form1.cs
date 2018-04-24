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
    public partial class OrderForm : Form
    {
        List<Component> Comp;
        public OrderForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Comp = new List<Component>();
            Component c = new Component(
                "Материнская плата Asus H110M-K",
                "Socket 1151, Intel H110, MicroATX, 2 x DDR4 DIMM; Количество каналов 2,Intel Core i7 / Core i5 / Core i3 / Pentium / Celeron 6-го и 7-го поколений под сокет LGA1151",
                "Тут должно быть описание :)",
                (float)1488.00
                );

            Comp.Add(c);

            of_cb_components.Items.Add(c.Title);

            c = new Component(
                "Блок питания Aerocool KCAS-700 700W",
                "Мощность 700W, Модульное подключение кабелей НЕТ, Охлаждение Вентилятор 120 мм",
                "Очень тихий, в однокомнатной квартире ночью тишина, как будто ПК и не включен! Жена счастлива)",
                (float)1699.00
                );

            Comp.Add(c);
            of_cb_components.Items.Add(c.Title);

            of_cb_components.SelectedIndexChanged += Of_cb_components_SelectedIndexChanged;

            of_b_add.Click += Of_b_add_Click;
        }

        /// <summary>
        /// Обработчик для нажатия кнопки добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Of_b_add_Click(object sender, EventArgs e)
        {
            of_lb_selectedComp.Items.Add(of_cb_components.SelectedItem.ToString());
            SetTotalPrice();
        }

        /// <summary>
        /// Функция обрабатывает выбор в combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Of_cb_components_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (of_cb_components.SelectedIndex >= 0)
            {
                of_b_add.Enabled = true;
                of_b_edit.Enabled = true;

                foreach (Component item in Comp)
                {
                    if (item.Title == of_cb_components.SelectedItem.ToString())
                    {
                        of_rtb_characteristics.Text = item.Characteristic;
                        of_rtb_description.Text = item.Description;
                        of_tb_price.Text = item.Price.ToString();
                    }
                }
            }
            else
            {
                of_b_add.Enabled = false;
                of_b_edit.Enabled = false;
            }
        }

        /// <summary>
        /// Функция подсчитывает стоимость добавленного товара и выводит результат в соответсвующее место на форме
        /// </summary>
        private void SetTotalPrice()
        {
            float res = 0;

            if (of_lb_selectedComp.Items.Count > 0)
            {
                foreach (string c in of_lb_selectedComp.Items)
                {
                    foreach (Component item in Comp)
                    {
                        if (c == item.Title)
                        {
                            res += item.Price;
                        }
                    }
                }
            }
            of_l_totalPrice.Text = res.ToString();
        }
    }
   
}
