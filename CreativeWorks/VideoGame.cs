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
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A class, also often called a 'Type'; equivalent to rdfs:VideoGame.
    /// </summary>
    public class VideoGame : SoftwareApplication, IGame 
    {
        /// <summary>
        /// Person An actor, e.g. in TV, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip. Supersedes <see cref="Actors"/> .
        /// </summary>
        [JsonProperty("actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// An actor, e.g. in TV, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip. Sureseeded by <see cref="Actor"/>.
        /// </summary>
        [JsonProperty("actors")]
        public IList<Person> Actors { get; set; }

        /// <summary>
        /// CreativeWork - Cheat codes to the game.
        /// </summary>
        [JsonProperty("cheatCode")]
        public CreativeWork CheatCode { get; set; }

        /// <summary>
        /// A director of e.g. TV, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip. Supersedes <see cref="Directors"/> .
        /// </summary>
        [JsonProperty("director")]
        public Person Director { get; set; }

        /// <summary>
        ///A director of e.g. TV, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.  Sureseeded by <see cref="Director"/>.
        /// </summary>
        [JsonProperty("directors")]
        public IList<Person> Directors { get; set; }

        /// <summary>
        /// Text - The edition of a video game.
        /// </summary>
        [JsonProperty("gameEdition")]
        public string GameEdition { get; set; }

        /// <summary>
        /// Text  or Thing  or URL - The electronic systems used to play video games.
        /// </summary>
        [JsonProperty("gamePlatform")]
        public object GamePlatform { get; set; }

        /// <summary>
        /// GameServer - The server on which it is possible to play the game. Inverse property: <see cref="Game"/>
        /// </summary>
        [JsonProperty("gameServer")]
        public GameServer GameServer { get; set; }

        /// <summary>
        /// CreativeWork - Links to tips, tactics, etc.
        /// </summary>
        [JsonProperty("gameTip")]
        public CreativeWork GameTip { get; set; }

        /// <summary>
        /// MusicGroup  or Person - The composer of the soundtrack.
        /// </summary>
        [JsonProperty("musicBy")]
        public object MusicBy { get; set; }

        /// <summary>
        /// GamePlayMode - Indicates whether this game is multi-player, co-op or single-player.The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        [JsonProperty("playMode")]
        public GamePlayMode PlayMode { get; set; }

        /// <summary>
        /// VideoObject - The trailer of a movie or TV/radio series, season, episode, etc.
        /// </summary>
        [JsonProperty("trailer")]
        public VideoObject Trailer { get; set; }

        #region Properties from Game

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

        #endregion Properties from Game
    }
}
