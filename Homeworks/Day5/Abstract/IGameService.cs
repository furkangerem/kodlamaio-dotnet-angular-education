using Day5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Abstract
{
    internal interface IGameService
    {
        void Buy(Customer customer, Game game, Campaign campaign);
    }
}
