namespace BankAccountProject
{
    class BankAccount
    {
        //state variable/fileds
        public string Name;
        public int AccountID;
        public double Balance;



    
    
        //behaviours/ methods  
        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            Console.WriteLine("Withdrawal Unsuccessful");
            return false;
        }
        public bool transfer(double amount, BankAccount receiver)
        {
            if (Withdraw(amount))
            {
                receiver.Deposit(amount);
                return true;
            }
            return false;
        }

        public void Accountinfo()
        {
            Console.WriteLine($"Name: { Name }, Account ID: { AccountID}, Balance: { Balance}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Account ID: {AccountID}, Balance: {Balance}";
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount david = new BankAccount { Name = "David Alwright", AccountID = 1111 };
            david.Deposit(1000);

            BankAccount susan = new BankAccount { Name = "Susan Harper", AccountID = 2222 };
            susan.Deposit(50000);

            Console.WriteLine(david);
            Console.WriteLine(susan);

            Console.WriteLine($"Making a deposit of $1000 to {david.Name}'s Account");
            david.Deposit(1000);
            Console.WriteLine($"Making a withdrawal of $10000 to {susan.Name}'s Account");
            susan.Withdraw(10000);

            Console.WriteLine($"Making a transfer of $1000 from {susan.Name}'s to {david.Name}'s Account");
            susan.transfer(1000, david);


            Console.WriteLine(david);
            Console.WriteLine(susan);


        }
    }
}
