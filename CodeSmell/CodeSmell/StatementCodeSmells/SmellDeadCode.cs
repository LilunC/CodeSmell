//BadCode : unused using
using System;
using System.Data.Common;

namespace CodeSmell.StatementCodeSmells
{
    /* 
    // Brief :
    // Get rid of useless code that is never executed.bury it.
    // Dead code include unused using,unused variable, unused private method and unreasonable logic code.
    // (the public method matbe call by other place.)
    */
    class SmellDeadCode //Code smells type : Dispensables
    {
        //BadCode:Because it will not be executed return false;.
        public bool IsEvenNumber()
        {
            int value = 2;
            if (value % 2 == 0) 
                return true;

            // This is unreasonable logic code
            // Because it will not be executed
            return false;
        }

        //GoodCode:You can delete return false code or modify as below.
        public bool IsEvenNumber(int value)
        {
            if (value % 2 == 0)
                return true;

            return false;
        }
    }
}
