namespace CleanArchitectureDemo.Domain.ValueObjects;

public sealed class Money
{
    public decimal Amount { get; }

    public Money(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be greater than zero.");

        Amount = amount;
    }
}
