using System;

namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class IntroduceExplainingVariable
    {
        /*
        Complex expressions, especially ones that contain many numeric terms, can quickly become difficult to read. Temporary variables can help break an expression up into more manageable named pieces.
            
         Step:
             1. Declare a temp variable and set it to part of the complex expression.(Make sure it has a clear name)
             2. Replace the result part of the expression with the temp.
             3. Compile and Run Tests.
             4. Repeat as needed for other parts of the expression.
         */

        //算圓錐體體積
        public class BadCode
        {
            decimal radius, height;
            public decimal CalculateConeVolume()
            {
                return (decimal)Math.PI * radius * radius * height / 3;
            }
        }
        public class GoodCode
        {
            decimal radius, height;
            public decimal CalculateConeVolume()
            {
                decimal coneOpeningArea = (decimal)Math.PI * radius * radius;
                return coneOpeningArea * height / 3;
            }
        }
    }
}

