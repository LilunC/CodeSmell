namespace CodeSmell.StatementCodeSmells
{
    /* 
    // Brief :
    // Be consistent in your naming, formatting, and usage patterns with in your application
    */
    class SmellInconsistency //Code smells type : Obfuscators
    {
        class BadCode
        {
            // The idNnumber is the same as identificationNumber,
            // but it is not easy to read because of the different names.
            public void SetName(string idNnumber)
            {
            }

            public void SetAge(string identificationNumber)
            {
            }
        }

        class GoodCode
        {
            public void SetName(string idNnumber)
            {
            }

            public void SetAge(string idNnumber)
            {
            }
        }
    }
}



