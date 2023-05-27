namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class ReplaceTempWithQuery
    {
        /*
        A temp variable that you need to use both in the new method that you 're extracting and still in the original one
        
        Step:
            1. Confirm the temp variable is only assigned once
                (if it's assigned to more than once, consider applying split temporary variable or else abandon this refactoring attempt )
            2. Extract the right-hand side of the assignment to a method
            3. Compile and Run Tests
            4. Replace references to the temp with calls to the new method
            5. Compile and Run Tests
            6. Remove the temp declaration and assignment
            7. Compile and Run Tests
        */

        //Example common code
        double quantity { get; set; }
        double itemPrice { get; set; }

        //BadCode 
        double BadCodeCalculateTotal()
        {
            double basePrice = quantity * itemPrice;

            if (basePrice > 1000)
            {
                return basePrice * 0.95;
            }
            else
            {
                return basePrice * 0.98;
            }
        }

        //GoodCode
        double GoodCodeCalculateTotal()
        {
            if (BasePrice() > 1000)
            {
                return BasePrice() * 0.95;
            }
            else
            {
                return BasePrice() * 0.98;
            }
        }
        double BasePrice()
        {
            return quantity * itemPrice;
        }
    }
}