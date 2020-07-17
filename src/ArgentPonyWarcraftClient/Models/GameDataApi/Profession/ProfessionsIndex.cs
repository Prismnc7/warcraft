﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of professions.
    /// </summary>
    public class ProfessionsIndex
    {
        /// <summary>
        /// Gets links for the index of professions.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the professions.
        /// </summary>
        [JsonPropertyName("professions")]
        public ProfessionReference[] Professions { get; set; }
    }
}
