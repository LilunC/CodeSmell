namespace CodeSmell.ClassCodeSmells.RefactorTechnique
{
    class EncapsulateCollection
    {
        /*
        Step:
            1. Add explicit Add/Remove item methods
            2. Initialize the field to an empty collection
            3. Compile
            4. Find references that set the collection - Modify to use new Add/Remove methods
            5. Compile and Run Tests
            6. Find references that get the collection, then modify its contents
            7. Compile and Run Tests
            8. Modify the property get to return a read-only collection
            9. Compile and Run Tests

            PS. Collection就算設定為readonly 或是 only get的屬性,仍然可以Add/Remove/Clear...只是不能new,
                可以將class內的collection設為readonly and private在使用 IReadOnlyCollection 承接AsReadOnly()並公開使用,
                如果要賦值的話就另創方法在Class內修改private的值
        */
    }
}
