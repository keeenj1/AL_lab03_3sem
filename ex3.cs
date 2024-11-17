using System;

public class Currency
{
    public double Value;
    public Currency(double value)
    {
        Value = value;
    }
}
public class CurrencyUSD : Currency
{
    public static double USDToEUR { get; set; }
    public static double USDToRUB { get; set; }
    public CurrencyUSD(double value) : base(value) { }

    public static explicit operator CurrencyEUR(CurrencyUSD usd)
    {
        return new CurrencyEUR(usd.Value * USDToEUR);
    }
    public static explicit operator CurrencyRUB(CurrencyUSD usd)
    {
        return new CurrencyRUB(usd.Value * USDToRUB);
    }
}

public class CurrencyEUR : Currency
{
    public static double EURToUSD { get; set; }
    public static double EURToRUB { get; set; }

    public CurrencyEUR(double value) : base(value) { }

    public static explicit operator CurrencyUSD(CurrencyEUR eur)
    {
        return new CurrencyUSD(eur.Value * EURToUSD);
    }
    public static explicit operator CurrencyRUB(CurrencyEUR eur)
    {
        return new CurrencyRUB(eur.Value * EURToRUB);
    }
}

public class CurrencyRUB : Currency
{
    public static double RUBToUSD { get; set; }
    public static double RUBToEUR { get; set; }

    public CurrencyRUB(double value) : base(value) { }

    public static explicit operator CurrencyUSD(CurrencyRUB rub)
    {
        return new CurrencyUSD(rub.Value * RUBToUSD);
    }
    public static explicit operator CurrencyEUR(CurrencyRUB rub)
    {
        return new CurrencyEUR(rub.Value * RUBToEUR);
    }
}
