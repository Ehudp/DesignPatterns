using Logger;

namespace DesignPatterns.BehavioralPatterns.State.RealWorld
{
    /// <summary>
    ///     The 'Context' class
    /// </summary>
    internal class Account
    {
        private string _owner;
        // Constructor
        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            _owner = owner;
            State = new SilverState(0.0, this);
        }

        // Properties
        public double Balance
        {
            get { return State.Balance; }
        }

        public RealState State { get; set; }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Log.WriteLine("Deposited {0:C} --- ", amount);
            Log.WriteLine(" Balance = {0:C}", Balance);
            Log.WriteLine(" Status = {0}",
                State.GetType().Name);
            Log.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Log.WriteLine("Withdrew {0:C} --- ", amount);
            Log.WriteLine(" Balance = {0:C}", Balance);
            Log.WriteLine(" Status = {0}\n",
                State.GetType().Name);
        }

        public void PayInterest()
        {
            State.PayInterest();
            Log.WriteLine("Interest Paid --- ");
            Log.WriteLine(" Balance = {0:C}", Balance);
            Log.WriteLine(" Status = {0}\n",
                State.GetType().Name);
        }
    }
}