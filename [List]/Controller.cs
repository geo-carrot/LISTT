using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _List_
{
    internal class Controller
    {
        public static List<Goods> Goods = new List<Goods>();

        public void AddGood(string title, float price, float sale) { }

        public static string title;
        public static float price;
        public static float sale;

        Goods good = new Goods()
        {
            Title = title,
            Price = price,
            Sale = sale,
        };

        public string GetGoods()
        {
            int t = 0;
            string txt = "";
            foreach (var item in Goods)
            {
                txt += $"Номер товара - {t}, {item.Title}. Цена со скидкой - {item.Price}\n";
                t++;
            }
            return txt;
        }
        public void Delete()
        {
            Console.WriteLine("Введите номер товара, который хотите удалить");
            int number = Convert.ToInt32(Console.ReadLine());

            Goods.RemoveAt(number-1);
        }

        public void SaveList()
        {
            var json = JsonSerializer.Serialize<List<Goods>>(Goods);

            File.WriteAllText("list.json", json);
        }
        public void OpenList()
        {
            if (!File.Exists("list.lson"))
                return;

            var json = File.ReadAllText("list.json");

            Goods = JsonSerializer.Deserialize<List<Goods>>(json);
        }
    }
}
