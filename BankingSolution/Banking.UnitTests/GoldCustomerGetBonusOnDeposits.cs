
namespace Banking.UnitTests;

public class GoldCustomerGetBonusOnDeposits
{
    [Fact]
    public void BonusAppliedToDeposit()
    {
        var account = new GoldBankAccount();
        var openingBalance = account.GetBalance();
        //extra code here
        var amountToDeposit = 100M;

        account.Deposit(amountToDeposit);

        Assert.Equal (openingBalance + amountToDeposit + 10M, account.GetBalance());
    }
}
