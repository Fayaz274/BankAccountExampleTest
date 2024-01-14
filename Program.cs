namespace BankAccountNS
{
    public class BankAccount
    {
        private string account_title;
        private double account_balance;
        public BankAccount(string title,double balance)
        {
            account_title = title;
            account_balance = balance;
        }
        public string AccountTitle
        {
            get{
                return account_title;
            }
        }
        public double AccountBalance
        {
            get { return account_balance;}
        }
        public void Debit(double debit)
        {
            if (debit < 0)
            {
                throw new IndexOutOfRangeException("Not a valid debit amount");
            }
            else if(debit >account_balance)
            {
                throw new IndexOutOfRangeException("Debit is higher than account balance");
            }
            else
            {
                account_balance -= debit;
            }
        }
        public void Credit(double credit)
        {
            if(credit < 0)
            {
                throw new IndexOutOfRangeException("Not a valid credit");

            }
            else
            {
                account_balance += credit;
            }
        }
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Ahad", 250);
            bankAccount.Debit(50);
            bankAccount.Credit(50);
            Console.WriteLine(bankAccount.AccountBalance);
        }
    }
}
