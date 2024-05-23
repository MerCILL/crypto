namespace TestCrypto.Infrastructure.Responses;

public record CurrencyDetailsResponse
{
    [JsonProperty("id")]
    public string Id { get; init; } = null!;

    [JsonProperty("symbol")]
    public string Symbol { get; init; } = null!;

    [JsonProperty("name")]
    public string Name { get; init; } = null!;

    [JsonProperty("market_cap_rank")]
    public int? MarketCapRank { get; init; }

    [JsonProperty("image")]
    public Dictionary<string, string> Image { get; init; } = null!;

    [JsonProperty("market_data")]
    public MarketDataResponse MarketData { get; init; } = null!;

    [JsonProperty("tickers")]
    public ObservableCollection<TickerResponse> Tickers { get; init; } = null!;
}

public record MarketDataResponse
{
    [JsonProperty("market_cap")]
    public Dictionary<string, decimal> MarketCap { get; init; } = null!;

    [JsonProperty("total_volume")]
    public Dictionary<string, decimal> TotalVolume { get; init; } = null!;

    [JsonProperty("current_price")]
    public Dictionary<string, decimal> CurrentPrice { get; init; } = null!;

    [JsonProperty("circulating_supply")]
    public decimal? CirculatingSupply { get; init; }

    [JsonProperty("price_change_24h")]
    public decimal? PriceChange24h { get; init; }

    [JsonProperty("price_change_percentage_24h")]
    public decimal? PriceChangePercentage24h { get; init; }
}

public record TickerResponse
{
    [JsonProperty("base")]
    public string Base { get; init; } = null!;

    [JsonProperty("target")]
    public string Target { get; init; } = null!;

    [JsonProperty("trade_url")]
    public string TradeUrl { get; init; } = null!;

    [JsonProperty("market")]
    public MarketResponse Market { get; init; } = null!;
}

public record MarketResponse
{
    [JsonProperty("name")]
    public string Name { get; init; } = null!;
}

