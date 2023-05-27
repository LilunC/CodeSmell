namespace CodeSmell.ClassCodeSmells.RefactorTechnique
{
    class ReplaceConditionalWithPolymorphism
    {
        /*
        Step:
            1. If necessary, Extract Method to get the conditional in its own method
            2. If necessary, Move Method to pull the conditional to the top of the inheritance hierarchy
            3. Choose one subclass, override the conditional method
                a. Copy the appropriate body of the conditional into the subclass's method
            4. Compile and Run Tests
            5. Remove that leg of the conditional
            6. Compile and Run Tests
            7. Repeat until all parts of the conditional have their own methods
            8. Make the superclass method abstract
        */
    }
}
