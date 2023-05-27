using System;
using System.Collections.Generic;

namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class InlineMethod
    {
        /* 
        When a method body is more obvious than the method itself, use this technique.
        Method contents are so obvious that the methods name adds no value after refactor.
        To perform this refactoring, first, confirm that the method is not polymorphic.

        (*) Should not apply this refactoring to such case:
            The method involved uses recursion
            The method has even minor complexity or multiple return statements

        Step:
            1. Confirm no subclasses override the method
            2. Find all calls to the method
            3. Replace each call with the method's body
            4. Compile and Run Tests
            5. Remove the original method
            6. Compile and Run Tests
        */

        public class BadCode
        {
            public void UpdateQuality(List<string> item)
            {
                foreach (String name in item)
                {
                    if (NameContainsBackstagePausses(name))
                    {
                        //do something
                    }
                }
            }
            public bool NameContainsBackstagePausses(string name)
            {
                return name.Contains("Backstage passes");
            }
        }
        public class GoodCode
        {
            public void UpdateQuality(List<string> item)
            {
                foreach (String name in item)
                {
                    if (name.Contains("Backstage passes"))
                    {
                        //do something
                    }
                }
            }
        }
    }
}
