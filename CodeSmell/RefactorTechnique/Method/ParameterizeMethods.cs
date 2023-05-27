namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class ParameterizeMethods
    {
        /*
        It is best used when the only difference between the methods is a value that can easily be changed into a parameter

        Step:
            1. Create a new parameterized method that can be substituted for each repetitive method
            2. Compile
            3. Replace all calls to one old method with a call to the new method
            4. Compile and Run Tests
            5. Repeat for each method, testing each time
            6. Remove the Original Methods if they are no longer used
                a. Optional: replace their bodies with calls to the parameterized method
            7. Compile and Run Tests
        */

        //BadCode
        public void ShowTen() { }
        public void ShowFive() { }

        //GoodCode
        public void ShowNumber(int num) { }
    }
}