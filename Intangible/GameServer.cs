using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// 
    /// </summary>
    public class GameServer : Thing
    {
        /// <summary>
        /// VideoGame 	Video game which is played on this server.
        /// Inverse property: gameServer.
        /// </summary>
        [JsonProperty("game")]
        public VideoGame Game { get; set; }

        /// <summary>
        /// Integer 	Number of players on the server.
        /// </summary>
        [JsonProperty("playersOnline")]
        public Int32? PlayersOnline { get; set; }

        /// <summary>
        /// GameServerStatus - Status of a game server.
        /// </summary>
        [JsonProperty("serverStatus")]
        public GameServerStatus ServerStatus { get; set; }	
    }
}
