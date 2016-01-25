using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// Interface for <see cref="Game"/>
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Thing 	A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        Thing CharacterAttribute { get; set; }

        /// <summary>
        /// Thing - An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        Thing GameItem { get; set; }

        /// <summary>
        /// Place  or PostalAddress  or URL  - Real or fictional location of the game (or part of game).
        /// </summary>
        object GameLocation { get; set; }

        /// <summary>
        /// QuantitativeValue - Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        QuantitativeValue NumberOfPlayers { get; set; }

        /// <summary>
        /// Thing - The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        Thing Quest { get; set; }
    }
}
