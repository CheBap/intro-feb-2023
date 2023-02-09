namespace Banking.Domain
{
    //a job description. any class that implements this interface is promising it can do this job description
    public interface ICanCalculateAccountBonuses
    {
        decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit);
    }
}