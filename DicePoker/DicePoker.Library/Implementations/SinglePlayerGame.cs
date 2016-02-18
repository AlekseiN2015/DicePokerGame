using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DicePoker.Library.Interfaces;

namespace DicePoker.Library.Implementations
{
    public class SinglePlayerGame : IGame
    {
        public void Start()
        {
            //TODO: create computer player
            var computer = new ComputerPlayer();
            //create a player
            //create a round 
            //add the rount into rounds collection
            //implement logic of game ...
            throw new NotImplementedException();
        }

        public IEnumerable<IRound> Rounds { get; }
        public IEnumerable<IPlayer> Players { get; }
    }
}
