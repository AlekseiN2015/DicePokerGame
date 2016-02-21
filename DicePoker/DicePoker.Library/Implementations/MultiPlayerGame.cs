using System;
using System.Collections.Generic;
using DicePoker.Library.Interfaces;

namespace DicePoker.Library.Implementations
{
    public class MultiPlayerGame :IGame
    {
        public void Start()
        {



            throw new NotImplementedException();
        }

        public void NextRound()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRound> Rounds { get; }
        public IEnumerable<IPlayer> Players { get; }
    }
}
