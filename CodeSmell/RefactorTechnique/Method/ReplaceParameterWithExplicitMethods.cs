using System;

namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class ReplaceParameterWithExplicitMethods
    {
        /*
        (Replace Parameter with Explicit Methods is the reverse of parameterize method)
        靈活度與代碼輕易度成反比 視情況而定

        Step:
            1. Create a separate, explicit method for each value of the parameter in the original method
            2. Move condition body logic to explicit methods and replace condition bodies with calls to new methods
            3. Compile and Run Tests (after each change)
            4. Replace each call to the original parameterized method with a call to the appropriate new method
            5. Compile and Run Tests (after each change)
            6. Remove the parameterized method
            7. Compile and Run Tests
        */

        //Example common code
        int height { get; set; }
        int width { get; set; }

        //BadCode
        void SetValue(string name, int value)
        {
            if (name.Equals("height"))
            {
                height = value;
                return;
            }
            if (name.Equals("width"))
            {
                width = value;
                return;
            }
            throw new Exception();
        }

        //GoodCode
        void SetHeight(int arg)
        {
            height = arg;
        }
        void SetWidth(int arg)
        {
            width = arg;
        }
    }
}
