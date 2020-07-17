﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Pet ability media.
    /// </summary>
    public class PetAbilityMedia
    {
        /// <summary>
        /// Gets links for the pet ability media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the pet ability.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
