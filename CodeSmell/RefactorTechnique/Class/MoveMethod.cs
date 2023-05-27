namespace CodeSmell.ClassCodeSmells.RefactorTechnique
{
    class MoveMethod
    {
        /*
        Step:
            1. Examine all fields/methods used by the method and defined in its current class
                a. Consider whether you can move them all
                b. Be sure to check sub- and super-classes
            2. Declare the method on the target class
                a. Copy the code from the source method and adjust to make it work
            3. Compile
            4. Reference the target class's method from the original class
                a. Delegate from the old method to the new one
            5. Compile and Run Tests
        */
    }
}
