using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestCrypto.Models;

public class Currency : INotifyPropertyChanged
{
    private string _id = null!;
    private string _symbol = null!;
    private string _name = null!;
    private string _image = null!;
    private decimal _currentPrice;
    private long _marketCap;
    private int _marketCapRank;
    private long _fullyDilutedValuation;
    private long _totalVolume;
    private decimal _high24h;
    private decimal _low24h;
    private decimal _priceChange24h;
    private decimal _priceChangePercentage24h;
    private long _marketCapChange24h;
    private decimal _marketCapChangePercentage24h;
    private decimal _circulatingSupply;
    private decimal _totalSupply;
    private decimal _maxSupply;
    private decimal _ath;
    private decimal _athChangePercentage;
    private DateTime _athDate;
    private decimal _atl;
    private decimal _atlChangePercentage;
    private DateTime _atlDate;
    private DateTime _lastUpdated;

    public string Id
    {
        get { return _id; }
        set
        {
            if (_id != value)
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
    }

    public string Symbol
    {
        get { return _symbol; }
        set
        {
            if (_symbol != value)
            {
                _symbol = value;
                OnPropertyChanged(nameof(Symbol));
            }
        }
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (_name != value)
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    public string Image
    {
        get { return _image; }
        set
        {
            if (_image != value)
            {
                _image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
    }

    public decimal CurrentPrice
    {
        get { return _currentPrice; }
        set
        {
            if (_currentPrice != value)
            {
                _currentPrice = value;
                OnPropertyChanged(nameof(CurrentPrice));
            }
        }
    }

    public long MarketCap
    {
        get { return _marketCap; }
        set
        {
            if (_marketCap != value)
            {
                _marketCap = value;
                OnPropertyChanged(nameof(MarketCap));
            }
        }
    }

    public int MarketCapRank
    {
        get { return _marketCapRank; }
        set
        {
            if (_marketCapRank != value)
            {
                _marketCapRank = value;
                OnPropertyChanged(nameof(MarketCap));
            }
        }
    }

    public long FullyDilutedValuation
    {
        get { return _fullyDilutedValuation; }
        set
        {
            if (_fullyDilutedValuation != value)
            {
                _fullyDilutedValuation = value;
                OnPropertyChanged(nameof(FullyDilutedValuation));
            }
        }
    }

    public long TotalVolume
    {
        get { return _totalVolume; }
        set
        {
            if (_totalVolume != value)
            {
                _totalVolume = value;
                OnPropertyChanged(nameof(TotalVolume));
            }
        }
    }

    public decimal High24h
    {
        get { return _high24h; }
        set
        {
            if (_high24h != value)
            {
                _high24h = value;
                OnPropertyChanged(nameof(High24h));
            }
        }
    }

    public decimal Low24h
    {
        get { return _low24h; }
        set
        {
            if (_low24h != value)
            {
                _low24h = value;
                OnPropertyChanged(nameof(Low24h));
            }
        }
    }

    public decimal PriceChange24h
    {
        get { return _priceChange24h; }
        set
        {
            if (_priceChange24h != value)
            {
                _priceChange24h = value;
                OnPropertyChanged(nameof(PriceChange24h));
            }
        }
    }

    public decimal PriceChangePercentage24h
    {
        get { return _priceChangePercentage24h; }
        set
        {
            if (_priceChangePercentage24h != value)
            {
                _priceChangePercentage24h = value;
                OnPropertyChanged(nameof(PriceChangePercentage24h));
            }
        }
    }

    public long MarketCapChange24h
    {
        get { return _marketCapChange24h; }
        set
        {
            if (_marketCapChange24h != value)
            {
                _marketCapChange24h = value;
                OnPropertyChanged(nameof(MarketCapChange24h));
            }
        }
    }

    public decimal MarketCapChangePercentage24h
    {
        get { return _marketCapChangePercentage24h; }
        set
        {
            if (_marketCapChangePercentage24h != value)
            {
                _marketCapChangePercentage24h = value;
                OnPropertyChanged(nameof(MarketCapChangePercentage24h));
            }
        }
    }

    public decimal CirculatingSupply
    {
        get { return _circulatingSupply; }
        set
        {
            if (_circulatingSupply != value)
            {
                _circulatingSupply = value;
                OnPropertyChanged(nameof(CirculatingSupply));
            }
        }
    }

    public decimal TotalSupply
    {
        get { return _totalSupply; }
        set
        {
            if (_totalSupply != value)
            {
                _totalSupply = value;
                OnPropertyChanged(nameof(TotalSupply));
            }
        }
    }

    public decimal MaxSupply
    {
        get { return _maxSupply; }
        set
        {
            if (_maxSupply != value)
            {
                _maxSupply = value;
                OnPropertyChanged(nameof(MaxSupply));
            }
        }
    }

    public decimal Ath
    {
        get { return _ath; }
        set
        {
            if (_ath != value)
            {
                _ath = value;
                OnPropertyChanged(nameof(Ath));
            }
        }
    }

    public decimal AthChangePercentage
    {
        get { return _athChangePercentage; }
        set
        {
            if (_athChangePercentage != value)
            {
                _athChangePercentage = value;
                OnPropertyChanged(nameof(AthChangePercentage));
            }
        }
    }

    public DateTime AthDate
    {
        get { return _athDate; }
        set
        {
            if (_athDate != value)
            {
                _athDate = value;
                OnPropertyChanged(nameof(AthDate));
            }
        }
    }

    public decimal Atl
    {
        get { return _atl; }
        set
        {
            if (_atl != value)
            {
                _atl = value;
                OnPropertyChanged(nameof(Atl));
            }
        }
    }

    public decimal AtlChangePercentage
    {
        get { return _atlChangePercentage; }
        set
        {
            if (_atlChangePercentage != value)
            {
                _atlChangePercentage = value;
                OnPropertyChanged(nameof(AtlChangePercentage));
            }
        }
    }

    public DateTime AtlDate
    {
        get { return _atlDate; }
        set
        {
            if (_atlDate != value)
            {
                _atlDate = value;
                OnPropertyChanged(nameof(AtlDate));
            }
        }
    }

    public DateTime LastUpdated
    {
        get { return _lastUpdated; }
        set
        {
            if (_lastUpdated != value)
            {
                _lastUpdated = value;
                OnPropertyChanged(nameof(LastUpdated));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}