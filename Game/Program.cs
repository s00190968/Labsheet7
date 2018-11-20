using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerGame G1 = new ComputerGame("Monopoly", 19.99m, new DateTime(1970, 01, 31), "18, violence, gambling");
            //Game G2 = new Game() { price = 10.99m, releaseDate = new DateTime(2000, 6, 15) };

            ComputerGame CG1 = new ComputerGame("Pokemon", 59.99m, new DateTime(2018, 11, 16), "12, sex, violence, fear");
            ComputerGame CG2 = new ComputerGame("Spyro", 59.99m, new DateTime(2018, 11, 13), "7, gambling, violence, discrimination");

            displayGame(G1);
            displayGame(CG1);
            displayGame(CG2);
        }

        static void displayGame(Game game)
        {
            Console.WriteLine(game + "\n");
        }
    }
}
