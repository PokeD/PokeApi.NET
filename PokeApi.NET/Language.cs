﻿using Newtonsoft.Json;

namespace PokeAPI
{
    public class Language : NamedApiObject
    {
        /// <summary>
        /// Whether or not hte games are published in this language.
        /// </summary>
        [JsonProperty("official")]
        public bool IsOfficial { get; internal set; }

        /// <summary>
        /// The two-letter code of the country where this language is spoken. Note that it is not unique.
        /// </summary>
        public string Iso639 { get; internal set; }

        /// <summary>
        /// the two-letter code of the language. Note that this is not unique.
        /// </summary>
        public string Iso3166 { get; internal set; }

        /// <summary>
        /// The names of this language listed in different languages.
        /// </summary>
        public ResourceName[] Names { get; internal set; }
    }
}
