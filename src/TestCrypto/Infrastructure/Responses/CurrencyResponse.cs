namespace TestCrypto.Infrastructure.Responses;

public record CurrencyResponse
{
    [JsonProperty("id")]
    public string Id { get; init; } = null!;

    [JsonProperty("symbol")]
    public string Symbol { get; init; } = null!;

    [JsonProperty("name")]
    public string Name { get; init; } = null!;

    [JsonProperty("image")]
    public string Image { get; init; } = null!;

    [JsonProperty("current_price")]
    public decimal? CurrentPrice { get; init; }

    [JsonProperty("market_cap")]
    public long? MarketCap { get; init; }

    [JsonProperty("market_cap_rank")]
    public int? MarketCapRank { get; init; }

    [JsonProperty("fully_diluted_valuation")]
    public long? FullyDilutedValuation { get; init; }

    [JsonProperty("total_volume")]
    public long? TotalVolume { get; init; }

    [JsonProperty("high_24h")]
    public decimal? High24h { get; init; }

    [JsonProperty("low_24h")]
    public decimal? Low24h { get; init; }

    [JsonProperty("price_change_24h")]
    public decimal? PriceChange24h { get; init; }

    [JsonProperty("price_change_percentage_24h")]
    public decimal? PriceChangePercentage24h { get; init; }

    [JsonProperty("market_cap_change_24h")]
    public long? MarketCapChange24h { get; init; }

    [JsonProperty("market_cap_change_percentage_24h")]
    public decimal? MarketCapChangePercentage24h { get; init; }

    [JsonProperty("circulating_supply")]
    public decimal? CirculatingSupply { get; init; }

    [JsonProperty("total_supply")]
    public decimal? TotalSupply { get; init; }

    [JsonProperty("max_supply")]
    public decimal? MaxSupply { get; init; }

    [JsonProperty("ath")]
    public decimal? Ath { get; init; }

    [JsonProperty("ath_change_percentage")]
    public decimal? AthChangePercentage { get; init; }

    [JsonProperty("ath_date")]
    public DateTime AthDate { get; init; }

    [JsonProperty("atl")]
    public decimal? Atl { get; init; }

    [JsonProperty("atl_change_percentage")]
    public decimal? AtlChangePercentage { get; init; }

    [JsonProperty("atl_date")]
    public DateTime AtlDate { get; init; }

    [JsonProperty("last_updated")]
    public DateTime LastUpdated { get; init; }
}
