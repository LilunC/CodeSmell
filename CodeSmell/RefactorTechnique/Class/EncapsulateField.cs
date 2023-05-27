namespace CodeSmell.ClassCodeSmells.RefactorTechnique
{
    class EncapsulateField
    {
        /*
        Step:
            1. Create get/set property accessors for the field - optionally, use an auto-property
            2. Find all references to the field
            3. Replace each reference to use the property
            4. Compile after each change
            5. Change the field to be private
            6. Compile and Run Tests
        */
    }
}
