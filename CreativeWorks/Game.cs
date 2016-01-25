#region License
// Copyright (c) 2016 1010Tires.com
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System.Collections.Generic;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting. See also open issues list.
    /// </summary>
    public class Game : Thing, IGame
    {
        /// <summary>
        /// Thing 	A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [JsonProperty("characterAttribute")]
        public Thing CharacterAttribute { get; set; }

        /// <summary>
        /// Thing - An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [JsonProperty("gameItem")]
        public Thing GameItem { get; set; }

        /// <summary>
        /// Place  or PostalAddress  or URL  - Real or fictional location of the game (or part of game).
        /// </summary>
        [JsonProperty("gameLocation")]
        public object GameLocation { get; set; }

        /// <summary>
        /// QuantitativeValue - Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [JsonProperty("numberOfPlayers")]
        public QuantitativeValue NumberOfPlayers { get; set; }

        /// <summary>
        /// Thing - The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [JsonProperty("quest")]
        public Thing Quest { get; set; }
    }
}
