namespace CodeSmell.ClassCodeSmells
{
    /* 
    // Brief :
    // Occurs when behavior lives in one object but requires data from another.
    // Related to Data Class, but can also occur between two classes that each have their own behavior.
    // (*)Some design patterns, like strategy and visitor, tend to break this rule. They provide a way of encapsulating behavior at the cost of a little bit of indirection.
    */
    class SmellFeatureEnvy //Code smells type : Coupler
    {
    }
}