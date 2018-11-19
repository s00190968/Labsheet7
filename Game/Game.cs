using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Game
    {
        string name { get; set; }
        protected decimal price { get; set; }
        public DateTime releaseDate { get; set; }

        public Game(string name, decimal price, DateTime releaseDate)
        {
            this.name = name;
            this.price = price;
            this.releaseDate = releaseDate;
        }
        public Game(string name, decimal price) : this(name, price, DateTime.Now) { 
}
        public Game() : this("", 0)
        {

        }

        public virtual void updatePrice(decimal percentageIncrease)
        {
            price *= (1 + percentageIncrease);
        }


        public override string ToString()
        {
            return name + "\n" + price + "\n" + releaseDate.ToShortDateString();
        }

        public void setPrice(decimal price)
        {
            this.price = price;
        }
    }
}
