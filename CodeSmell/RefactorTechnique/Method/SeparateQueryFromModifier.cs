﻿namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class SeparateQueryFromModifier
    {
        /*
        This refactoring is used to split apart methods that both return values and modify system state
        This also helps you follow CQRS (Command query responsibility segregation)
        
        Step:
            1. Create a query method that returns the same value as the original method
            2. Modify the original method to return the result of a call to the new query method
            3. Compile and Run Tests
            4. Find all references to the old method and change them:
                a. Call the original method (without assigning it)
                b. Call the query method (and assign its return value)
            5. Compile and Run Tests (after each change)
            6. Update the original method to return void and remove all return statements from it
            7. Compile and Run Tests
        */

        //BadCode
        public void GetTotalOutstandingAndSetReadyForSummaries() { }

        //GoodCode
        public void GetTotalOutstanding() { }
        public void SetReadyForSummaries() { }
    }
}