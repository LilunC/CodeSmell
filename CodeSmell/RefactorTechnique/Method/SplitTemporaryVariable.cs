using System;

namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class SplitTemporaryVariable
    {
        /*
        The split temporary variable refactoring applies to temps that have too many responsibilities.
        You should avoid reusing the same temp variable for multiple different things within a method.
        
        Step:
            1. Change the name of the temp at its declaration and first assignment
            2. Confirm the new temp is not assigned elsewhere
            3. Change all reference of the temp up to its second assignment to use the new name
            4. Declare the original temp at its second assignment
            5. Compile and Run Tests
            6. Repeat until each temp is only assigned where seclares.
        */

        //Example common code
        double height { get; set; }
        double width { get; set; }

        //BadCode
        public void BadCode()
        {
            double temp = 2 * (height + width);
            Console.WriteLine(temp);
            temp = height * width;
            Console.WriteLine(temp);
        }

        //GoodCode
        public void GoodeCode()
        {
            double perimeter = 2 * (height + width);
            Console.WriteLine(perimeter);
            double area = height * width;
            Console.WriteLine(area);
        }
    }
}


