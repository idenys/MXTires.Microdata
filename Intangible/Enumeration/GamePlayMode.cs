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

using System.Runtime.Serialization;

namespace MXTires.Microdata.Intangible.Enumeration
{
	/// <summary>
	/// Indicates whether this game is multi-player, co-op or single-player.
	/// </summary>
	public enum GamePlayMode
    {
		/// <summary>
		/// Play mode: CoOp. Co-operative games, where you play on the same team with friends.
		/// </summary>
		[EnumMember(Value = "http://schema.org/CoOp")]
        CoOp = 1 << 0,

		/// <summary>
		/// Play mode: MultiPlayer. Requiring or allowing multiple human players to play simultaneously.
		/// </summary>
		[EnumMember(Value = "http://schema.org/MultiPlayer")]
		MultiPlayer = 1 << 1,

		/// <summary>
		/// Play mode: SinglePlayer. Which is played by a lone player.
		/// </summary>
		[EnumMember(Value = "http://schema.org/SinglePlayer")]
		SinglePlayer = 1 << 2,
    }
}
