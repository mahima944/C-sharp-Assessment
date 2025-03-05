using System;


public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}


public class NoDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount;
    }
}

public class PercentageDiscount : IDiscountStrategy
{
    private readonly decimal _percentage;

    public PercentageDiscount(decimal percentage)
    {
        _percentage = percentage;
    }

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - (totalAmount * _percentage / 100);
    }
}


public class FixedAmountDiscount : IDiscountStrategy
{
    private readonly decimal _discountAmount;

    public FixedAmountDiscount(decimal discountAmount)
    {
        _discountAmount = discountAmount;
    }

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return Math.Max(totalAmount - _discountAmount, 0);
    }
}


public class ShoppingCart
{
    private IDiscountStrategy _discountStrategy;

    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public decimal CalculateTotal(decimal totalAmount)
    {
        return _discountStrategy.ApplyDiscount(totalAmount);
    }
}