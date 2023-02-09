namespace Banking.UnitTests;

public class GoldCustomerGetBonusOnDeposits
{
    [Fact]
    public void BonusAppliedToDeposit()
    {
        var account = new BankAccount();
        account.Level = BankAccount.LoyaltyLevel.Gold;
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}
