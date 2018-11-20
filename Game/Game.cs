using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public abstract class Game
    {
        private readonly string name;
        string Name
        {
            get
            {
                return name;
            }
        }
        protected decimal price { get; set; }
        public DateTime releaseDate { get; set; }

        public Game(string name, decimal price, DateTime releaseDate)
        {
            this.name = name;
            this.price = price;
            this.releaseDate = releaseDate;
        }
        public Game(string name, decimal price) : this(name, price, DateTime.Now)
        {

        }
        public Game() : this("", 0)
        {

        }

        public abstract void updatePrice(decimal percentageIncrease);


        public override string ToString()
        {
            return "Name: " + name + "\nPrice: " + price + "\nRelease date: " + releaseDate.ToShortDateString();
        }

        public void setPrice(decimal price)
        {
            this.price = price;
        }
    }
}
