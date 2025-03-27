using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3x
{
    abstract class PrintedProducts
    {
        private string name;

        protected string Name { get => name; set => name = value; }

        //public abstract void TirajPrice();
        public abstract int GetPrice();
        public abstract void Info();


        public PrintedProducts() { }
        public PrintedProducts(string name) { this.Name = name; }
    }
}
