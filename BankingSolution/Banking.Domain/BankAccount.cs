using System.Net.Security;

namespace Banking.Domain;

public class BankAccount
{
    private decimal _balance = 5000M; // State - "Fields" variable.
    public enum LoyaltyLevel { Standard, Gold};
    public LoyaltyLevel Level;
    public void Deposit(decimal amountToDeposit)
    {
        decimal bonus = 0;
        if(Level == LoyaltyLevel.Gold)
        {
            bonus = amountToDeposit * .10M;
        }
        _balance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (NotOverdraft(amountToWithdraw))
        {
            _balance -= amountToWithdraw;
        }
        else
        {
            throw new AccountOverdraftException();
        }

    }


    // "Never type private, always refactor to it" - Corey Haines.
    private bool NotOverdraft(decimal amountToWithdraw)
    {
        return _balance >= amountToWithdraw;
    }
}