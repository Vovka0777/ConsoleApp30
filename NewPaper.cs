using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3x
{
    internal class NewPaper : PrintedProducts
    {
        private int listcount;
        private int tiraj;
        private int listprice;

        public int Listcount { get => listcount; set => listcount = value; }
        public int Tiraj { get => tiraj; set => tiraj = value; }
        public int Listprice { get => listprice; set => listprice = value; }

        public NewPaper() { }
        public NewPaper(string name, int listcount, int tiraj, int listprice) : base (name) 
        {
            this.Listcount = listcount;
            this.Tiraj = tiraj;
            this.Listprice = listprice;
            //this.Name = name;
        }

        //public override void TirajPrice()
        //{
        //    int tirajprice = Listcount * Tiraj * Listprice;
        //    Console.WriteLine($"Стоимость газеты: {tirajprice} рублей");
        //}

        public static NewPaper Enter() 
        {
            Console.Write("Название газеты - ");
            string name = Console.ReadLine();
            Console.Write("Кол-во страниц - ");
            int listcount = int.Parse(Console.ReadLine());
            Console.Write("Кол-во экземпляров - ");
            int tiraj = int.Parse(Console.ReadLine());
            Console.Write("Цена 1-ой страницы - ");
            int listprice = int.Parse(Console.ReadLine());
            return new NewPaper (name, listcount, tiraj, listprice);
        }

        public override int GetPrice()
        {
            int price = Listprice * Listcount * Tiraj;
            return price;
        }
        public override void Info()
        {
            Console.WriteLine($"Печатная продукция - газета {Name}\nКол-во листов - {Listcount}\tСтоимость 1-ого листа - {Listprice} руб.\tТираж газеты составляет {Tiraj} экз.\nСтоимость тиража: {GetPrice()} руб.");
        }
    }
}
