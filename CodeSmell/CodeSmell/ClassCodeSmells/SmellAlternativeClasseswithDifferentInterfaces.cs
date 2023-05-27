namespace CodeSmell.ClassCodeSmells
{
    /* 
    // Brief :
    // Common operations should share common semantics, such as names, parameters, and parameter orders.
    */
    class SmellAlternativeClasseswithDifferentInterfaces //Code smells type : Object - Orientation Abuser
    {
        //Example common code
        public class Mail
        {
        }

        //BadCode
        public class BadCodeExample
        {
            // The parameters of the SendMail methods of the Email and PaperMail classes are not consistent.
            public class EMail : Mail
            {
                public void SendMail(string addressFrom, string addressTo) { }
            }

            public class PaperMail : Mail
            {
                private void SendMail(string addressTo, string addressFrom) { }
            }
        }

        //GoodCode
        public class GoodCodeExample
        {
            // Can use rename method to consistency among the different classes and their interfaces.
            public class EMail : Mail
            {
                public void SendMail(string addressFrom, string addressTo) { }
            }

            public class PaperMail : Mail
            {
                private void SendMail(string addressFrom, string addressTo) { }
            }
        }

    }
}


