using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bank
{
    private double balance;

    public Bank(double initial)
    {
        balance = initial;
    }

    public string makeDeposit(double _deposit)
    {
        if(_deposit < 0)
        {
            return "Please deposit a positive amount";
        }

        balance += _deposit;
        return "Your deposit was made successfully";
    }

    public string withdraw(double withdraw)
    {
        if (withdraw < 0)
        {
            return "Please withdraw a positive amount";
        }

        balance -= withdraw;
        return "Your withdrawal was made successfully";
    }

    public double getBalance()
    {
        return balance;
    }
}
