using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSmell.StatementCodeSmells
{
    /* 
    // Brief :
    // use descriptive names and avoid abbreviations and encodings where possible.
       
    //  Guidelines :
    // i. descriptive (描述性)
    // ii. appropriate abstraction level (保持適當抽象)
    // iii. follow standards (遵循C#標準編碼)
    // iv. unambigous (命名正確性)
    // v. longer names for longer scopes (長命名用長生命週期)
    // vi. dont encode or abbreviate (誤縮寫或加密命名)
    */

    class SmellPoorNames //Code smells type : Obfuscators
    {
        class DescriptiveExample
        {
            //BadCode:UnUse descriptive names
            //Can't understand function by name.
            public static List<int> Generate(int n)
            {
                var x = new List<int>();
                for (int i = 2; n > 1; i++)
                    for (; n % i == 0; n /= i)
                        x.Add(i);
                return x;
            }

            //GoodCode:Use descriptive names
            public static List<int> GeneratePrimeFactorsOf(int input)
            {
                var primeFactors = new List<int>();
                for (int candidateFactor = 2; input > 1; candidateFactor++)
                    while (input % candidateFactor == 0)
                    {
                        primeFactors.Add(candidateFactor);
                        input /= (candidateFactor);
                    }
                return primeFactors;
            }
        }

        class AbstractionLevelExample
        {
            private IOrderSource _orderSource;
            public void ProcessOrder()
            {
                //BadCode:GetOrder does not necessarily use the read file.
                //        So orderFromFile is a bad name.
                var orderFromFile = _orderSource.GetOrder();

                //GoodCode
                var order = _orderSource.GetOrder();
            }

            interface IOrderSource
            {
                List<String> GetOrder();
            }
        }

        class FollowStandardsExample
        {
            public void GoodCode()
            {
                // If you're using a design pattern,
                // Please use that term in the name of the type.

                // When I use the factory method design pattern, I must use "Factory" to design the name. 
                CustomerFactory customerFactory = new CustomerFactory();
                var customer = customerFactory.Create();

                // When I use the builder design pattern, I must use "Builder" to design the name. 
                OrderBuilder orderBuilder = new OrderBuilder();
                var order = orderBuilder.Make();


                // if you have common operations like create or add,
                // please call them by a single standard term.
                // order is use add,customer is use append.
                OrderItem orderItem = new OrderItem();
                order.AddItem(orderItem);

                customer.AppendOrder(order);
            }

            // The following Class is only used to illustrate the example and not to implement it
            public class CustomerFactory
            {
                public Customer Create()
                {
                    return null;
                }
            }
            public class OrderBuilder
            {
                public Order Make()
                {
                    return null;
                }
            }

            public class Order
            {
                public void AddItem(OrderItem orderItem)
                {
                }
            }
            public class OrderItem
            {
            }
            public class Customer
            {
                public void AppendOrder(Order order)
                {
                }
            }
        }

        class UnambigousExample
        {
            Amount amount;
            AccountID accountId, accountId2, accountId3;
            public void BadCode()
            {
                // this is bad for i can know who is recipient,who is sender.
                Account account1 = GetAccount(accountId);
                Account account2 = GetAccount(accountId2);
                Account account3 = GetAccount(accountId3);

                bool result = Transfer(amount, account1, account2, account3);
            }

            AccountID senderAccountId, recipientAccountId, commissionAccountId;
            public void GoodCode()
            {
                // this is good
                Account sender = GetAccount(senderAccountId);
                Account recipient = GetAccount(recipientAccountId);
                Account commissionAccount = GetAccount(commissionAccountId);

                bool result = Transfer(amount, sender, recipient, commissionAccount);
            }

            Account GetAccount(AccountID accountID)
            {
                return null;
            }

            bool Transfer(Amount amount, Account sender, Account recipient, Account commissionAccount)
            {
                return true;
            }

            class Account
            {
            }
            class AccountID
            {
            }
            class Amount
            {
            }
        }

        class LongerNamesForLongerScopesExample
        {
            // We can know sb is StringBuilder.
            // But I don't know when the Environment.NewLine code uses the E.NL name,
            // E.NL stands for Environment.NewLine.
            // So I cant use E.NL
            public string ListUsers()
            {
                //sb is standard for StringBuilder
                var sb = new StringBuilder();
                // i,j,k is standard for loop
                for (int i = 0; i < Application.CurrentUserCount; i++)
                {
                    sb.Append("User " + i + Environment.NewLine);
                }
                return sb.ToString();
            }
            public static class Application
            {
                public static int CurrentUserCount { get; set; }
            }
        }

        class DontEncodeOrAbbreviate
        {
            // We don't have to add encoding type before variable
            // beacause IDE is strong and C# have more than more type
            // Prefer simple names without encoding wherever possible.

            void BadCode()
            {
                //BadCode:Add encoding type before variable
                string strName;
                User usrOne;
            }

            void GoodCode()
            {
                //GoodCode:Prefer simple names without encoding.
                string name;
                List<User> users;

                // If you do need to include type information can add to behind of variable.
                // Can use for control component
                string userName = UserNameTextBox.Text;
                UserNameLable.Text = userName;
            }

            class User
            {
            }

            // This side is only used for analog control elements.
            static class UserNameTextBox
            {
                public static string Text { get; set; }
            }
            static class UserNameLable
            {
                public static string Text { get; set; }
            }
        }
    }
}