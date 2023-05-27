namespace CodeSmell.StatementCodeSmells
{
    /* 
    // Brief :
    // Switch statements, and complex if-else chains, may indicate a lack of proper use of Object-orientation abuses
       
    // When to Ignore: 
    // 1. When a switch operator performs simple actions, there’s no reason to make code changes.
    // 2. Often switch operators are used by factory design patterns (Factory Method or Abstract Factory) to select a created class.
       
    // Question : 
    // 1. Need i to find other information to study
    // 2. 解決方法是將行為封裝到對象中,從而將邏輯轉移到新方法中,只需調用Objects方法就可以得到結果
    */
    class SmellSwitchStatements //Code smells type : Object-orientation abuses
    {
        //BadCode : The switch case code is duplication in the GoJapn and GoKorea methods.
        public void GoJapan(Travel travel)
        {
            switch (travel.TransportationTypeId)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        public void GoKorea(Travel travel)
        {
            switch (travel.TransportationTypeId)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        public class Travel
        {
            public int TransportationTypeId { get; set; }
        }
    }
}