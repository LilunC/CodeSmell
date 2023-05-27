namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class RemoveParameter
    {
        /*
        If you find that you have a parameter that is no longer being used by a method, you should remove it.
        
        Step:
            1. Check if the signature is also in a sub or superclass
                a. If so, do not perform this refactoring
            2. Declare a new method without the parameter
            3. Copy the old method body into the new method
            4. Compile
            5. Change the old method to call the new one
            6. Compile and Run Tests
            7. Find all reference to the old method and change to use the new one
            8. Compile and Run Tests (after each change)
            9. Remove the original method
            10. Compile and Run Tests
        */

        //Example common code
        public class Data { }

        //BadCode: when Data not being used
        public void SetContact(Data data) { }

        //GoodCode
        public void SetConract() { }
    }
}
