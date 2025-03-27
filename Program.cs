using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3x
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintedProducts newpaper = new NewPaper();
            //PrintedProducts magazine = new Magazine();

            //object[] newpapermass = new object[3];
            //Console.WriteLine("Введите имя газеты - ");
            //newpapermass[0] = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Введите кол-во листов - ");
            //newpapermass[1] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите тираж - ");
            //newpapermass[2] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите цену листа - ");
            //newpapermass[3] = Convert.ToInt32(Console.ReadLine());

            //object[] magazinemass = new object[2];
            //Console.WriteLine("Введите имя журнала - ");
            //magazinemass[0] = Console.ReadLine();
            //Console.WriteLine("Введите тираж ");
            //magazinemass[1] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите цену 1 журнала - ");
            //magazinemass[0] = Console.ReadLine();

            //for (int i = 0; i < newpapermass.Length; i++)
            //{
            //    Console.WriteLine(newpapermass[i]);
            //}
            //newpaper.TirajPrice();

            //for (int i = 0; i < magazinemass.Length; i++)
            //{
            //    Console.WriteLine(magazinemass[i]);
            //}
            //magazine.TirajPrice();

            List<PrintedProducts> printedProducts = new List<PrintedProducts>();
            //printedProducts.Add(new Magazine("Весна",30,200));
            //printedProducts.Add(new NewPaper("Правда", 15, 25, 150));

            bool flag = true;

            do
            {
                Console.Write("Введите название печатной продукци: ");
                string metka = Console.ReadLine();

                switch (metka)
                {
                    case "ж":
                    case "Ж":
                        {
                            printedProducts.Add(Magazine.Enter()); break;
                        }
                    case "г":
                    case "Г":
                        {
                            printedProducts.Add(NewPaper.Enter()); break;
                        }
                    default: { Console.WriteLine("Нет такой продукции"); flag = false; break; }
                }
                foreach (PrintedProducts printed in printedProducts)
                {
                    printed.Info();
                    Console.WriteLine();
                }
            }
            while (flag);
            Console.Read();
        }
    }
}
