namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class InlineTemp
    {
        /*
        If the temp variable is getting in the way of other refactoring, such as an extract method that you're trying to apply, I can inline it.

        Step:
            1. Confirm the temp variable is only assigned once.
            2. Replace references to the temp with the right side of the temp's assignment operation.
            3. Compile and Run Tess(each time)
            4. Remove the temp declaration and assignment.
            5. Compile and Run Tests.
        */
    }
}
