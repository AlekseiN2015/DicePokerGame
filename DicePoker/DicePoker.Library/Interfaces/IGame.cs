using System.Collections.Generic;

namespace DicePoker.Library.Interfaces
{
    public interface IGame
    {
        void Start();

        IEnumerable<IRound> Rounds { get; }

        IEnumerable<IPlayer> Players { get; }
    }
}