using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class ComputerGame : Game
    {
        public string PEGI { get; set; }

        public ComputerGame(string name, decimal price, DateTime releaseDate, string PEGI) : base(name, price, releaseDate)
        {
            this.PEGI = PEGI;
        }
        public decimal getDiscountPrice()
        {
            return price * .9m;
        }
        public override void updatePrice(decimal percentageIncrease)
        {
            Console.WriteLine("Updating price from ComputerGame class");
            base.updatePrice(percentageIncrease);
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + PEGI;
        }
    }
}
