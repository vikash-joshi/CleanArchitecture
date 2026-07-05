namespace ProductManagement.Domain.ValueObjects;

public sealed record Money
{
    public decimal Amount { get; set; }
    public string Currency { get; set;}

    public Money(decimal Amount,string Currency)
    {

        if(Amount<0) throw new ArgumentException("Invalid Amount");

        if(string.IsNullOrEmpty(Currency)) throw new ArgumentException("Invalid Currency");

        this.Amount = Amount;
        this.Currency = Currency.ToUpperInvariant();;
    }
}
