using ConsoleApp_testConcurrent.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_testConcurrent
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceGame = new Service1Client();
            Console.WriteLine("welcome to our game show");
            string name = Console.ReadLine();
            Queue<string> game = serviceGame.Setconnection2p(name);
            while(game.Count != 0)
            {
                Console.WriteLine(game.Count);
                game = serviceGame.checkPlayers();
            }
            Console.ReadLine();
        }
    }
}
