using Banking.Domain;
namespace BankingKiosk
{
    public partial class Form1 : Form
    {
        BankAccount _account;
        public Form1()
        {
            InitializeComponent();
            _account = new BankAccount(new StandardBonusCalculator(new StandardBusinessClock(new SystemTime())));
            UpdateBalanceDisplay(); //ctrl r + ctrl m = make a line a function - extracting a method
        }

        private void UpdateBalanceDisplay()
        {
            this.Text = $"You have a balance of {_account.GetBalance():c}.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void depositButton_Click(object sender, EventArgs e) //ctrl f5 to run
        {
            var amount = decimal.Parse(amountInput.Text);
            _account.Deposit(amount);
            UpdateBalanceDisplay();

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            DoTransaction();
        }

        private void DoTransaction()
        {
            var amount = decimal.Parse(amountInput.Text);
            _account.Withdraw(amount);
            UpdateBalanceDisplay();
        }
    }
}