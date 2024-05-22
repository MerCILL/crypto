namespace TestCrypto.Application.Mappers;

public class CurrencyMappingProfile : Profile
{
    public CurrencyMappingProfile()
    {
        CreateMap<CurrencyResponse, Currency>();
    }
}
