namespace CodeSmell.ClassCodeSmells.RefactorTechnique
{
    class ReplaceInheritanceWithDelegation
    {
        /*
        Step:
            1. Create and initialize a field in the subclass with the type of the superclass
            2. Change each method defined in the subclass to use this new field
            3. Compile and Run Tests
            4. Remove the subclass declaration
            5. For each superclass method a client uses, add a delegating method
            6. Compile and Run Tests
        */
    }
}
