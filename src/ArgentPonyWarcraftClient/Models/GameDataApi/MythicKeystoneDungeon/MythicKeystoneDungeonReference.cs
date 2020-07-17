﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a Mythic Keystone dungeon.
    /// </summary>
    public class MythicKeystoneDungeonReference
    {
        /// <summary>
        /// Gets the key for the Mythic Keystone dungeon.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the Mythic Keystone dungeon.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone dungeon.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
