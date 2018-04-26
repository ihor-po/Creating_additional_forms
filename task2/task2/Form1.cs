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
        Component newComponet;

        List<Component> Comp;
        public OrderForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Comp = new List<Component>();

            newComponet = null;

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

            of_lb_selectedComp.DoubleClick += Of_lb_selectedComp_DoubleClick;

            of_b_close.Click += Of_b_close_Click;

            of_b_createComp.Click += Of_b_createComp_Click;

            of_b_edit.Click += Of_b_edit_Click;
        }

        /// <summary>
        /// Обработка нажатия кнопки редактировать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Of_b_edit_Click(object sender, EventArgs e)
        {
            int index = of_cb_components.SelectedIndex; //позиция выбранного компонента
            int n = 0; int jj;//счетчики
            int[] j = new int[1];
            string oldTitle = of_cb_components.SelectedItem.ToString();
            string newTitle = "";
            bool isEdit = false; //флаг было ли редактирование
            foreach (Component item in Comp)
            {
                if (item.Title == oldTitle)
                {
                    CEdit f = new CEdit(item, false);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        //изменение компонента в выпадающем списке
                        of_cb_components.Items.RemoveAt(index);
                        of_cb_components.Items.Insert(index, item.Title);

                        //изменение компонента в обще списке
                        Comp.RemoveAt(n);
                        Comp.Insert(n, item);

                        newTitle = item.Title;

                        of_cb_components.SelectedIndex = -1;
                        of_b_add.Enabled = false;
                        of_b_edit.Enabled = false;
                        of_rtb_characteristics.Clear();
                        of_rtb_description.Clear();
                        of_tb_price.Clear();

                        isEdit = true;
                    }

                    break;
                }
                n++;
            }
            n = 0;
            jj = 1;
            //Если изменения были
            if (isEdit)
            {
                //В случае если компонент был добавлен изменение в списке
                
                foreach (string title in of_lb_selectedComp.Items)
                {
                    if (title == oldTitle)
                    {
                        Array.Resize(ref j, jj);

                        j[jj - 1] = n;
                        jj++;
                    }
                    n++;
                }
                // Изменение в списке добавленных компонентов
                ChangeListItem(j, newTitle);

                //Пересчет общей цены
                SetTotalPrice();
            }

        }

        /// <summary>
        /// Обработка нажатия кнопки создания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Of_b_createComp_Click(object sender, EventArgs e)
        {
            newComponet = new Component();
            CEdit f = new CEdit(newComponet, true);

            if (f.ShowDialog() == DialogResult.OK)
            {
                Comp.Add(newComponet);
                of_cb_components.Items.Add(newComponet.Title);

                int n = 0;
                foreach (string title in of_cb_components.Items)
                {
                    if (title == newComponet.Title)
                    {
                        break;
                    }
                    n++;
                }
                of_cb_components.SelectedIndex = n;
            }
        }

        /// <summary>
        /// Обработка события нажатия кнопки закрытия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Of_b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// При двойном клике в лист боксе выводится сообщение с информацие о товаре на котором было двойное нажатие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Of_lb_selectedComp_DoubleClick(object sender, EventArgs e)
        {
            if (of_lb_selectedComp.SelectedIndex != -1)
            {
                foreach (Component item in Comp)
                {
                    if (item.Title == of_lb_selectedComp.SelectedItem.ToString())
                    {
                        MessageBox.Show(item.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            
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

        /// <summary>
        /// возвращает цену компонента, если такой существует или -1 - если компонент не найден
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        private float GetComponentPrice(string component)
        {
            foreach (Component item in Comp)
            {
                if (item.Title == component)
                {
                    return item.Price;
                }
            }
            return -1;
        }

        /// <summary>
        /// Изменение значения в списке
        /// </summary>
        /// <param name="position"></param>
        /// <param name="newTitle"></param>
        private void ChangeListItem(int[] positions, string newTitle)
        {
            foreach(int position in positions)
            {
                of_lb_selectedComp.Items.RemoveAt(position);
                of_lb_selectedComp.Items.Insert(position, newTitle);
            }
        }
    }
   
}
