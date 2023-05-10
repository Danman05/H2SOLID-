using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Mastercard : Card, IMaxDraft, IDraftDaily, IExpire, ICredit
    {
        // Card prefix
        private List<int> prefix = new List<int>
            {
                51,
                52,
                53,
                54, 
                55
            };
        // Valueables from implemented interfaces
        public int MaxMonthly { get ; set; }
        public int MaxDaily { get ; set; }
        public DateTime ExpiryDate { get; set; }
        public int Credit { get; set; }

        // Constructor
        public Mastercard(string cardHolderName, int age) : base(cardHolderName, age)
        {
            Credit = 40000;
            ExpiryDate = DateTime.Now.AddYears(5);
            MaxDaily = 5000;
            MaxMonthly = 30000;
            this.cardPrefix = GetCardPrefix(prefix);
            this.cardnumber = GetCardNumber();
            this.accountNumber = GetAccountNumber();
        }

        // String override method for output
        public override string ToString()
        {

            return $"Card type: {GetType().Name}\n" +
                $"Name: {cardHolderName}\n" +
                $"Age: {age}\n" +
                $"Account number: {accountNumber}\n" +
                $"Card number: {cardnumber}\n" +
                $"Max Daily Withdraw Limit {MaxDaily} kr \n" +
                $"Max Monthly Withdraw Limit {MaxMonthly} kr \n" +
                $"Max Monthly Credit {Credit} kr \n" +
                $"Expiry date: {ExpiryDate.Month}-{ExpiryDate.Year}\n";
        }
    }
}
