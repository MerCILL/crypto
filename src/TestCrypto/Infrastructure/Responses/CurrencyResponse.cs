namespace TestCrypto.Infrastructure.Responses;

public class CurrencyResponse
{
    [JsonProperty("id")]
    public string Id { get; private set; } = null!;

    [JsonProperty("symbol")]
    public string Symbol { get; private set; } = null!;

    [JsonProperty("name")]
    public string Name { get; private set; } = null!;

    [JsonProperty("image")]
    public string Image { get; private set; } = null!;

    [JsonProperty("current_price")]
    public decimal CurrentPrice { get; private set; }

    [JsonProperty("market_cap")]
    public long MarketCap { get; private set; }

    [JsonProperty("market_cap_rank")]
    public int MarketCapRank { get; private set; }

    [JsonProperty("fully_diluted_valuation")]
    public long FullyDilutedValuation { get; private set; }

    [JsonProperty("total_volume")]
    public long TotalVolume { get; private set; }

    [JsonProperty("high_24h")]
    public decimal High24h { get; private set; }

    [JsonProperty("low_24h")]
    public decimal Low24h { get; private set; }

    [JsonProperty("price_change_24h")]
    public decimal PriceChange24h { get; private set; }

    [JsonProperty("price_change_percentage_24h")]
    public decimal PriceChangePercentage24h { get; private set; }

    [JsonProperty("market_cap_change_24h")]
    public long MarketCapChange24h { get; private set; }

    [JsonProperty("market_cap_change_percentage_24h")]
    public decimal MarketCapChangePercentage24h { get; private set; }

    [JsonProperty("circulating_supply")]
    public decimal CirculatingSupply { get; private set; }

    [JsonProperty("total_supply")]
    public decimal TotalSupply { get; private set; }

    [JsonProperty("max_supply")]
    public decimal? MaxSupply { get; private set; }

    [JsonProperty("ath")]
    public decimal Ath { get; private set; }

    [JsonProperty("ath_change_percentage")]
    public decimal AthChangePercentage { get; private set; }

    [JsonProperty("ath_date")]
    public DateTime AthDate { get; private set; }

    [JsonProperty("atl")]
    public decimal Atl { get; private set; }

    [JsonProperty("atl_change_percentage")]
    public decimal AtlChangePercentage { get; private set; }

    [JsonProperty("atl_date")]
    public DateTime AtlDate { get; private set; }

    [JsonProperty("last_updated")]
    public DateTime LastUpdated { get; private set; }
}
