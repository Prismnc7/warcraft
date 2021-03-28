﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of playable specializations.
    /// </summary>
    public class PlayableSpecializationsIndex
    {
        /// <summary>
        /// Gets links for the index of playable specializations.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the character specializations.
        /// </summary>
        [JsonPropertyName("character_specializations")]
        public PlayableSpecializationReference[] CharacterSpecializations { get; set; }

        /// <summary>
        /// Gets references to the pet specializations.
        /// </summary>
        [JsonPropertyName("pet_specializations")]
        public PlayableSpecializationReference[] PetSpecializations { get; set; }
    }
}
