using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Component
    {
        public string Title { get; set; }

        public string Characteristic { get; set; }
    
        public string Description { get; set; }

        public float Price { get; set; }

        public Component()
        {
            Title = "Noname";
            Characteristic = "none";
            Description = "none";
            Price = 0;
        }

        public Component(string _title, string _characteristic, string _description, float _price)
        {
            Title = _title;
            Characteristic = _characteristic;
            Description = _description;
            Price = _price;
        }

        public override string ToString()
        {
            return ($"Наименование: {Title}\rХарактеристики: {Characteristic}\rОписание: {Description}\rЦена : {Price}");
        }
    }
}
