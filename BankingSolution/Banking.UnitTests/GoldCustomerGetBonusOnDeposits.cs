
namespace Banking.UnitTests;


public class GoldCustomerGetBonusOnDeposits
{
    [Fact]
    public void BonusAppliedToDeposit()
    {
        //given
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;

        //when
        account.Deposit(amountToDeposit);

        //then
        Assert.Equal(openingBalance + amountToDeposit + 10M, account.GetBalance());

    }
    
    
}
