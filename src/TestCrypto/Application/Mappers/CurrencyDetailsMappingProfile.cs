namespace TestCrypto.Application.Mappers;

public class CurrencyDetailsMappingProfile : Profile
{
    public CurrencyDetailsMappingProfile()
    {
        CreateMap<MarketResponse, Market>();
        CreateMap<TickerResponse, Ticker>();
        CreateMap<MarketDataResponse, MarketData>();
        CreateMap<CurrencyDetailsResponse, CurrencyDetails>();
    }
}