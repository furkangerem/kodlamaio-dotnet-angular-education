using Day5.Abstract;
using Day5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Concrete
{
    internal class GameManager : IGameService
    {
        public void Buy(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine("Selected campaign: " + campaign.name);
            Console.WriteLine("Selected Game " + game.name + " - " + game.price + " is added to your Library " + customer.firstName + " " + customer.lastName + "!");
        }
    }
}
