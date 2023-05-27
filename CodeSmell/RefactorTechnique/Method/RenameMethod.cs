namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class RenameMethod
    {
        /*
        Apply this refactoring when the name of a method doesn't reveal its purpose.
        
        Step:
            1. Is the method implemented by sub-/super class?
                a. If so, repeat these steps for each implementation
            2. Create a new method with the same parameters and the new name
            3. Copy(don't cut)the old method body into the new one
            4. Compile
            5. Change the old method to call the new method(optional)
            6. Compile and Run Tests
            7. Find all references to old method and update to new
                a. Remove(or mark[obsolete])the old method
            8. Compile and Run Tests
        */

        //BadCode
        public void SetSNm() { }

        //GoodCode
        public void SetSecondName() { }
    }
}
