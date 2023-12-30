using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFields
{
    public class Account
    {
        private string _name;
        private decimal _balance;

        public string GetBalance()
        {
            return $"{_balance:c}";
        }
       public void SetName (string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void Addinterest()
        {
            _balance *= 1.02M;
        }
        public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                _balance += amount;
            }
        }
        public bool Withdraw(decimal amount, bool allowOverDraft = false)
        {
            if((_balance - amount < 0) && !allowOverDraft)
            {
                return false;
            }
            if (_balance - amount > 0)
            {
                _balance -= amount;
                return true;
            }
            else if (allowOverDraft)
            {
                _balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
