namespace BankAccount
{
    internal class CheckingAccount : BankAccount
    {
        double overdraftLimit;
        public CheckingAccount(string accountHolder, double balance, double overdraftLimit) : base(accountHolder, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public override double Deposit(double amount)
        {
            balance += amount;
            return balance;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Balance = {balance}");
            Console.WriteLine($"AccountHolder = {accountHolder}");
            Console.WriteLine($"AccountNumber = {accountNumber}");
            Console.WriteLine($"OverdraftLimit = {overdraftLimit}");
        }

        public override double Withdraw(double amount)
        {
            try {
                if (amount > (balance + overdraftLimit))
                {
                    throw new Exception("Amount more then balance + overdraftLimit");
                }
                balance -= amount;

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return balance;
        }
    }
}