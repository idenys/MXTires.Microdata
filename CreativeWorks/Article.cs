using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// An article, such as a news article or piece of investigative report. 
    /// Newspapers and magazines have articles of many different types and this is intended to cover them all. 
    /// See also <seealso cref="blog post"/>.
    /// </summary>
    public class Article : CreativeWork
    {
        /// <summary>
        /// Text - The actual body of the article.
        /// </summary>
        [JsonProperty("articleBody")]
        public string ArticleBody { get; set; }

        /// <summary>
        /// Text - Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
        /// </summary>
        [JsonProperty("articleSection")]
        public string ArticleSection { get; set; }

        /// <summary>
        /// Text  or Integer - The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [JsonProperty("pageEnd")]
        public string PageEnd { get; set; }

        /// <summary>
        /// Text  or Integer - The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [JsonProperty("pageStart")]
        public string PageStart { get; set; }

        /// <summary>
        /// Text - Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        [JsonProperty("pagination")]
        public string Pagination { get; set; }

        /// <summary>
        /// Integer - The number of words in the text of the Article.
        /// </summary>
        [JsonProperty("wordCount")]
        public Int32? WordCount { get; set; }
    }
}
