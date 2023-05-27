using System;

namespace CodeSmell.MethodCodeSmells
{
    /* 
    // Brief :
    // Prefer shorter methods to longer methods. 
    // Smell methods can have better names, because they're doing less 
    // and since they can  be well-named , are small, and don't do much, 
    // they're easier than long methods to understand.
       
    // My understand :  
       
    // Guidlines : 
    // 1. Methods should fit on one screen.(no scrolling)
    // 2. Ideally fewer than 10 lines of code.(easy to unit test)
       
    // Resolve method : 
    // 1. Extract Method
    // 2. Compose Method
    // 3. Replace Nested Conditional with Guard Clause
    //      --------4 to 6 are design pattern, and use to solve long method together.--------(未介紹)
    // 4. Replace Conditional Dispatcher with Command (design pattern)
    // 5. Move Accumulation to Visitor (design pattern)
    // 6. Replace Conditional Logic with Strategy (design pattern)
    */
    class SmellLongMethod //Code smells type : Bloater
    {
        //Example common code
        public class Customer { }
        public class Order { }

        //BadCode:Easy to lose sight of the methods actual purpose
        public void BadMethod(Customer customer, Order order)
        {
            if (customer != null)
            { }//dosomething
            else
                throw new ArgumentNullException("");

            if (order != null)
            { }
            else
                throw new ArgumentNullException("");
        }

        //GoodCode:Do something after null check ,可以增加可讀性
        public void GoodMethod(Customer customer, Order order)
        {
            if (customer == null) throw new ArgumentNullException("");
            if (order == null) throw new ArgumentNullException("");

            //if(order ==null) throw new ArgumentNullException(""); 也可改為一個ExtractFunction
        }

        //Example common code
        int iThsWkd, iThsRte;

        //BadCode:The function name is too short and can not easy to understand.
        public int m_otCalc()
        {
            return iThsWkd * iThsRte + (int)Math.Round(0.5 * iThsRte * Math.Max(0, iThsWkd - 400));
        }

        int tenthsWorked, tenthsRate;
        //GoodCode:I can understand.
        public int CalculateStraightPay()
        {
            return tenthsWorked * tenthsRate;
        }
        public int CalculateOverTimePay()
        {
            int overTimeTenths = Math.Max(0, tenthsWorked - 400);
            int overTimePay = CalculateOverTimeBonus(overTimeTenths);
            return CalculateStraightPay() + overTimePay;
        }
        public int CalculateOverTimeBonus(int overTimeTenths)
        {
            double bonus = 0.5 * tenthsRate * overTimeTenths;
            return (int)Math.Round(bonus);
        }
    }
}