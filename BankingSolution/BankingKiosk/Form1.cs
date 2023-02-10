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
            DoTransaction(_account.Deposit);

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            DoTransaction(_account.Withdraw);
        }

        private void DoTransaction(Action<decimal>op)
        {
            try
            {
                var amount = decimal.Parse(amountInput.Text);
                op(amount);
                UpdateBalanceDisplay();
            }
            catch (FormatException)
            {

                MessageBox.Show("Enter a number, you moron.","Error on Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AccountOverdraftException)
            {
                MessageBox.Show("You don't have enough money, get a job", "Error in Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //run this if there is an error, or if there isn't an error. ALWAYS
                amountInput.SelectAll(); //select all the text in the input
                amountInput.Focus(); //put cursor there
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoTransaction((amount) => MessageBox.Show("You clicked a button, blah" +amount.ToString())); //anonymous function
        }
    }
}