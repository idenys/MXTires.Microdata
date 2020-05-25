#region License
// Copyright (c) 2020 1010Tires.com
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

using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    public class MusicComposition: CreativeWork
    {
        Thing composer;
        /// <summary>
        /// Organization  or Person - The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [JsonProperty("composer")]
        public Thing Composer
        {
            get { return composer; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                composer = value;
            }
        }

        /// <summary>
        /// Event - The date and place the work was first performed.
        /// </summary>
        [JsonProperty("firstPerformance")]
        public Event FirstPerformance { get; set; }

        /// <summary>
        /// MusicComposition - Smaller compositions included in this work (e.g.a movement in a symphony).
        /// </summary>
        [JsonProperty("includedComposition")]
        public MusicComposition IncludedComposition { get; set; }

        /// <summary>
        /// Text - The International Standard Musical Work Code for the composition.
        /// </summary>
        [JsonProperty("iswcCode")]
        public string IswcCode { get; set; }

        /// <summary>
        /// Person - The person who wrote the words.
        /// </summary>
        [JsonProperty("lyricist")]
        public Person Lyricist { get; set; }

        /// <summary>
        /// CreativeWork - The words in the song.
        /// </summary>
        [JsonProperty("lyrics")]
        public CreativeWork Lyrics { get; set; }

        /// <summary>
        /// MusicComposition - An arrangement derived from the composition.
        /// </summary>
        [JsonProperty("musicArrangement")]
        public MusicComposition MusicArrangement { get; set; }

        /// <summary>
        /// Text - The type of composition (e.g.overture, sonata, symphony, etc.).
        /// </summary>
        [JsonProperty("musicCompositionForm")]
        public string MusicCompositionForm { get; set; }

        /// <summary>
        /// Text - The key, mode, or scale this composition uses.
        /// </summary>
        [JsonProperty("musicalKey")]
        public string MusicalKey { get; set; }

        /// <summary>
        /// MusicRecording - An audio recording of the work. Inverse property: recordingOf.
        /// </summary>
        [JsonProperty("recordedAs")]
        public MusicRecording RecordedAs { get; set; }
        
    }
}
