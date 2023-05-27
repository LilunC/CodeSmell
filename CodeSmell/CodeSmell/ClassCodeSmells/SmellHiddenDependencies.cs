namespace CodeSmell.ClassCodeSmells
{
    /* 
    // Brief :
    // Classes have external dependencies they do not specify through their constructors.
    // Calling code must inspect the class (or discover runtime errors) to identify its dependencies.
    // Instead, follow the Explicit Dependencies Principle.
    */
    class SmellHiddenDependencies //Code smells type : Coupler
    {
    }
}
