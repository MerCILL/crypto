namespace TestCrypto.Infrastructure.Mapper;

public class CurrencyMappingProfile : Profile
{
    public CurrencyMappingProfile()
    {
        CreateMap<CurrencyResponse, Currency>();
    }
}
