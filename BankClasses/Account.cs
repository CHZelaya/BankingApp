namespace BankClasses
{
    public class Account
    {
        // Defining Variables
        private int accountNumber;
        private double balance;

        // Static number that is incremented each time a new account is created
        private static int nextAccountNumber = 100;


        // Wrappers to access private variables. 

        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            // Removing set to make this a read-only property
        }

        public double Balance { get { return balance; } } // Removing set to make this a read-only property 

        //Constructor for creating an account
        public Account(double initialBalance = 0)
        {
            accountNumber = nextAccountNumber;
            nextAccountNumber++; // Increases for each account created.
            if(initialBalance >= 0)
            {
                balance = initialBalance;
            }
            else // if negative value is passed to the constructor, balance is set to 0
            {
                balance = 0;
            }
        }

        /// <summary>
        /// Withdrawal of money from account
        /// </summary>
        /// <param name="withdrawalAmount">amount to be withdrawan</param>
        /// <returns>Status of withdrawal (true/false)</returns>
        public bool Withdraw(double withdrawalAmount)
        {
            bool withdrawStatus = true;

            if (withdrawalAmount <= balance) // Can withdraw because the amount is less or equal to the balance
            {
                balance -= withdrawalAmount; 
            }
            else
            {
                withdrawStatus = false; // Cannot withdraw because the amount is greater than the balance
            }

            return withdrawStatus;
        }

        /// <summary>
        /// Deposit money into account
        /// </summary>
        /// <param name="depositAmount">Amount to be deposited</param>
        public void Desposit(double depositAmount)
        {
            balance += depositAmount;

        }
        public override string ToString()
        {
            return $"[{AccountNumber}] : {Balance.ToString("c")}";
        }















    }
}
