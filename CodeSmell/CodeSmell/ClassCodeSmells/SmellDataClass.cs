using System;

namespace CodeSmell.ClassCodeSmells
{
    /* 
    // Brief :
    // Classes that lack behavior and have only fields and/or properties. 
    // Such classes lack encapsulation and must be manipulated by other classes, rather than bundling state and behavior together.
    */
    class SmellDataClass //Code smells type : Dispensable
    {
        //BadCode
        //由於DataClass內沒有判斷名稱與對應行為,所以使用需要判斷AccountType 名稱才能有對應操作, 而這些相同邏輯將會散布在各個使用到的地方.
        public class Account // data class
        {
            public int Id;
            public string AccountType;
            public decimal Balance;
        }

        public class InterestCalculator
        {
            private decimal _interestRate = 1.01m;
            public void CalculateInterset(Account account)
            {
                if (account.AccountType == "Checking")
                {
                    return;
                }
                if (account.AccountType == "Savings")
                {
                    decimal interest = account.Balance * this._interestRate;
                    account.Balance += interest;
                    return;
                }
            }
        }
        
        //GoodCode
        public class RefactoredAccount
        {
            public int Id { get; }
            public string AccountType { get; }
            public decimal Balance { get; private set; }

            public RefactoredAccount(int id, string accountType, decimal balance)
            {
                Id = id;
                AccountType = accountType;
                Balance = balance;
            }

            public void CalculateAndApplyInterest(RefactoredInterestCalculator calculator)
            {
                var interest = calculator.CalculateInterest(this);
                IncreaseBalance(interest);
            }
            private void IncreaseBalance(decimal amount)
            {
                Balance += amount;
            }
        }

        public class RefactoredInterestCalculator
        {
            private decimal _interestRate = 1.01m;
            public decimal CalculateInterest(RefactoredAccount account)
            {
                if (account.AccountType == "Checking")
                {
                    return 0;
                }
                if (account.AccountType == "Savings")
                {
                    decimal interest = account.Balance * this._interestRate;
                    return interest;
                }
                throw new InvalidOperationException($"Unknow Account Type{account.AccountType}");
            }
        }
    }
}




