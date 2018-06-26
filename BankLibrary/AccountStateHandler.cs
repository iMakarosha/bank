using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    //делегат для создания событий
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);

    //класс для обработки событий
    public class AccountEventArgs
    {
        //message
        public string Message { get; private set; }
        //сумма изменения счета
        public decimal Sum { get; private set; }

        public AccountEventArgs(string _mes, decimal _sum)
        {
            Message = _mes;
            Sum = _sum;
        }
    }

    //public abstract class Account : IAccount
    //{
    //    //событие при выводе денег
    //    protected internal event AccountStateHandler Withdrawed;
    //    //событие при добавлении на счет
    //}
}
