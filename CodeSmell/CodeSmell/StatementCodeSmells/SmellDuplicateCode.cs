using System;

namespace CodeSmell.StatementCodeSmells
{
    /* 
    // Brief :
    // Duplication is the root of all software evil. 
    // Follow the don't repeat yourself principle and avoid repetition in your code when possible.
    */
    class SmellDuplicateCode //Code smells type : Dispensables
    {
        class NullCheckExample
        {
            //Example common code
            public class Order { }
            public class Logger { }
            public class Customer { }

            //BadCode:This is bad for code is duplication.
            public void BadMethod(Customer customer, Order order, Logger logger)
            {
                if (customer == null)
                {
                    throw new ArgumentNullException("Customer can not be null");
                }
                if (order == null)
                {
                    throw new ArgumentNullException("Order can not be null");
                }
                if (logger == null)
                {
                    throw new ArgumentNullException("Logger can not be null");
                }
            }

            //GoodCode:we can extract a method
            //or use an extension method or pull it out into a shared package.
            //install Ardalis.GuardClauses
            public void GoodMethod(Customer customer, Order order, Logger logger)
            {
                NullCheck(customer, "Customer can not be null");
                NullCheck(order, "Order can not be null");
                NullCheck(logger, "Logger can not be null");
            }

            public void NullCheck<T>(T judgmentobject, string exceptionMessage)
            {
                if (judgmentobject == null)
                    throw new ArgumentNullException(exceptionMessage);
            }
        }

        class InstantiationExample
        {
            //Example common code
            public class Basket { }

            //this is bad for instantiation code is duplication.
            class BadCode
            {
                class BasketAddItem
                {
                    //[Fact]
                    public void AddsBasketAddItemIfNotPressent()
                    {
                        var bsaket = new Basket();
                        // other logic
                    }
                    //[Fact]
                    public void IncrementsItemQuantityIfPressent()
                    {
                        var bsaket = new Basket();
                        // other logic
                    }
                }
            }

            class GoodCode
            {
                class BasketAddItem
                {
                    private Basket _bsaket = new Basket();
                    //[Fact]
                    public void AddsBasketAddItemIfNotPressent()
                    {
                        // other logic
                    }
                    //[Fact]
                    public void IncrementsItemQuantityIfPressent()
                    {
                        // other logic
                    }
                }
            }
        }
    }
}