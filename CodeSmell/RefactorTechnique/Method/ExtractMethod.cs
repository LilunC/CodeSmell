using System;

namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class ExtractMethod
    {
        /*
        Have several lines of code that can be grouped together and given an intention revealing name.   

        Step:
            1. Identity the code to extract
            2. Create a new method with a good name
            3. Copy the code from the source to the new method - temporary variables used only in this code can be copied over as well
            4. Identity modified local variables
                a. Does the extracted method need to return a variable?
                b. If more than one, consider extracting a smaller method.
            5. Compile
            6. Replace extracted code with call to new method
            7. Compile and Run Tests
         */

        //Example common code
        string name { get; set; }
        string GetOutstanding() { return ""; }
        void PrintBanner() { }

        //BadCode
        void BadCodePrintOwing()
        {
            this.PrintBanner();

            // Print details.
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("amount: " + this.GetOutstanding());
        }

        //GoodCode
        void GoodeCodePrintOwing()
        {
            this.PrintBanner();
            this.PrintDetails();
        }
        void PrintDetails()
        {
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("amount: " + this.GetOutstanding());
        }
    }
}