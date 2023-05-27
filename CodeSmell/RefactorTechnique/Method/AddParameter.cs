namespace CodeSmell.MethodCodeSmells.RefactorTechnique
{
    class AddParameter
    {
        /*
        You perform it whenever you find you need more information within the method you're working with than you currently have.
        Consider whether there are other ways your method can get the information it requires perhaps by asking one of the objects already passed in
        //須注意參數是有過長的問題,這是一種Code smell - Long Parameter List
        
        Step:
            1. Check if the signature is also in a sub or superclass
                a. Repeat these steps for each one
            2. Seclare a new method with the new parameter
            3. Copy the old method body into the new method
            4. Compile
            5. Change the old method to call the new one
            6. Compile and Run Tests
            7. Find all references to the old method and change to use the new one
            8. Compile and Run Tests(after each change)
            9. Remove the original method
            10. Compile and Run Tests
        */

        //Before
        public void SetConract() { }

        //After add parameter
        public void SetConract(Data data) { }
        public class Data { }
    }
}
