namespace CodeSmell.StatementCodeSmells
{
    /* 
    // Brief :
    // define,assign and use variables and functions near where they are used.
    // define local variables where first used, ideally as they are assigned.
    // define private function just below their first use.avoid forcing the reader to scroll
       
    // My understand :   
    // 1. 變數放在使用的前一行
    // 2. Function第一次使用的下方或是對團隊或個人有意義的地方
    */
    class SmellVerticalSeparation //Code smells type : Obfuscators
    {
        public void BadCode()
        {
            int repeatTimes = 5;

            // More code in this implement.
            // doSomething();
            // doAnything();

            for (int i = 0; i < repeatTimes; i++)
            {
                // do();
            }
        }
        public void GoodeCode()
        {
            // doSomething();
            // doAnything();

            int repeatTimes = 5;
            for (int i = 0; i < repeatTimes; i++)
            {
                // do();
            }
        }
    }
}