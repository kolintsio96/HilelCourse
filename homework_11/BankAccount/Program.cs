namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string owner = ReadInput("Enter owner name: ");  
            double balance = ReadInput("Enter your start balance: ", true);  
            double overdraftLimit = ReadInput("Enter overdraft limit: ", true);  
            BankAccount bankCheckingAccount = new CheckingAccount(owner, balance, overdraftLimit);
            bankCheckingAccount.DisplayAccountInfo();
            double deposit = ReadInput("Enter summ of deposit: ", true);
            double withdraw = ReadInput("Enter summ of withdraw: ", true);
            bankCheckingAccount.Deposit(deposit);
            bankCheckingAccount.Withdraw(withdraw);
            bankCheckingAccount.DisplayAccountInfo();
        }

        private static double ReadInput(string message, bool isNumber)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool succesfullParsing = double.TryParse(input, out double result);
            try
            {
                if (!succesfullParsing)
                {
                    throw new Exception("You enter wrong number");
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ReadInput(message, isNumber);
            }

        }
        private static string ReadInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            try
            {
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Field can not be empty");
                    return ReadInput(message);
                }
                return input;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ReadInput(message);
            }

        }
    }
}