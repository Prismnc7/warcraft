﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Mythic keystone affix media.
    /// </summary>
    public class MythicKeystoneAffixMedia
    {
        /// <summary>
        /// Gets links for the mythic keystone affix media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the mythic keystone affix.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
