namespace Banking.UnitTests;

public class MakingWithdrawals
{
    [Fact]
    public void MakingAWithdrawalDecreaseBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = 100M;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }

}
