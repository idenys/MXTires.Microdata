#region License
// Copyright (c) 2015 1010Tires.com
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

using Newtonsoft.Json;
namespace MXTires.Microdata
{
    /// <summary>
    /// The act of an agent relocating to a place. 
    /// Related actions: 
    /// <see cref="TransferAction"/>: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object
    /// </summary>
    public class MoveAction : Action
    {
        /// <summary>
        /// Place - A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [JsonProperty("fromLocation")]
        public Place FromLocation { get; set; }

        /// <summary>
        /// Place - A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [JsonProperty("toLocation")]
        public Place ToLocation { get; set; }
    }
}