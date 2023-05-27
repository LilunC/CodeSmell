namespace CodeSmell.ClassCodeSmells
{
    /* 
    // Brief :
    // Two concepts are both modeled with inheritance hierarchies, and any change in one requires a matching change in the other.
       
    // My understand :  
    //  除非程式導致開發痛苦,否則通常不會解決此問題.
    */
    class SmellParallelInheritanceHierarchies //Code smells type : Change preventer
    {
        // If i want to add new service , I need to add new cost class.
        public class BadCode
        {
            public class ShippingService
            {
            }
            public class GreatShippingService : ShippingService
            {
            }
            public class OKShippingService : ShippingService
            {
            }
            public class ShippingCosrStrategy
            {
                public void GetCost()
                {
                }
            }
            public class GreatCostStrategy : ShippingCosrStrategy
            {
                public void GetCost(GreatShippingService greatShippingService)
                {
                }
            }
            public class OkCostStrategy : ShippingCosrStrategy
            {
                public void GetCost(OKShippingService okShippingService)
                {
                }
            }
        }
     
        public class GoodCodeMethodOne
        {
            //將方法移到SuperClass,但可能導致Large Class or 違反單一原則
            public class ShippingService
            {
                public void GetCost()
                {
                }
            }
            public class GreatShippingService : ShippingService
            {
            }
            public class OKShippingService : ShippingService
            {
            }
        }

        public class GoodCodeMethodTwo
        {
            // If have new Service, I can add new method to ShippingCosrStrategy(Limited to a Class).
            public class ShippingService
            {
                //Dependency to ShippingCosrStrategy
            }
            public class GreatShippingService : ShippingService
            {
            }
            public class OKShippingService : ShippingService
            {
            }
            public class ShippingCosrStrategy
            {
                public void GetGreatCost()
                {
                }
                public void GetOkCost()
                {
                }
            }
        }
    }
}