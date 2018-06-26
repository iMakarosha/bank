using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    interface IAccount
    {
        //положить деньги на счет
        void Put(decimal sum);
        //снять со счета 
        decimal Withdraw(decimal sum);
    }
}
