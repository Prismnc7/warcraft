using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// PvP season match statistics.
    /// </summary>
    public record SeasonMatchStatistics
    {
        /// <summary>
        /// Gets the number of matches played.
        /// </summary>
        [JsonPropertyName("played")]
        public int Played { get; }

        /// <summary>
        /// Gets the number of matches won.
        /// </summary>
        [JsonPropertyName("won")]
        public int Won { get; }

        /// <summary>
        /// Gets the number of matches lost.
        /// </summary>
        [JsonPropertyName("lost")]
        public int Lost { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeasonMatchStatistics"/> class.
        /// </summary>
        /// <param name="played">The number of matches played.</param>
        /// <param name="won">The number of matches won.</param>
        /// <param name="lost">The number of matches lost.</param>
        [JsonConstructor]
        public SeasonMatchStatistics(int played, int won, int lost)
        {
            Played = played;
            Won = won;
            Lost = lost;
        }
    }
}
