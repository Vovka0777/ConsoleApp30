using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3x
{
    internal class Magazine : PrintedProducts
    {
        private int tiraj;
        private int price;

        public int Tiraj { get => tiraj; set => tiraj = value; }
        public int Price { get => price; set => price = value; }

        public Magazine() { }
        public Magazine(string name, int tiraj, int price) : base(name)
        {
            this.Tiraj = tiraj;
            this.Price = price;
            //this.Name = name;
        }
        //public override void TirajPrice()
        //{
        //    int tirajprice = Price * Tiraj;
        //    Console.WriteLine($"Стоимость журнала: {tirajprice} рублей");
        //}

        public override int GetPrice()
        {
            int price = Tiraj * Price;
            return price;
        }
        public static Magazine Enter()
            {
                Console.Clear();
                Console.Write("Название журнала - ");
                string name = Console.ReadLine();
                Console.Write("Кол-во экземпляров - ");
                int tiraj = int.Parse(Console.ReadLine());
                Console.Write("Цена - ");
                int price = int.Parse(Console.ReadLine());
                return new Magazine(name, tiraj, price);
            }

        public override void Info()
        {
            Console.WriteLine($"Печатная продукция - журнал {Name}\nТираж - {Tiraj} экз.\tЦена 1-ого экземпляра - {Price} руб.\nСтоимость тиража:{GetPrice()} руб.");
        }
    }
}
