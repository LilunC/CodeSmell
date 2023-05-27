namespace CodeSmell.StatementCodeSmells
{
    /* 
    // Brief :
    // Certain operations must be called in a certain sequence, or they won't work.
    // Nothing in the design forces this behavior - developers just have to figure it out from context or tribal knowledge.
    // When someone wants to modify this part of the code, if he does not know that this is in order, then an error will occur.
    */
    class SmellHiddenTemporalCoupling //Code smells type : Couplers
    {
        class BadCode
        {
            //if you want to cook great egg , you need to follow this sequence.
            //you can't execute OpenEggIn() before AddOil().
            public void CookEgg()
            {
                AddOil();
                OpenFire();
                OpenEggIn();
                WaitForComplet();
            }

            void AddOil()
            {
            }
            void OpenFire()
            {
            }
            void OpenEggIn()
            {
            }
            void WaitForComplet()
            {
            }
        }

        class GooodCode
        {
            //solove1: Method depend
            public void CookEgg()
            {
                OilPan oilPna = AddOil();
                HotOilPan hotOilPan = OpenFire(oilPna);
                Cooking cooking = OpenEggIn(hotOilPan);
                WaitForComplet(cooking);
            }
            OilPan AddOil()
            {
                return null;
            }
            HotOilPan OpenFire(OilPan oilPan)
            {
                return null;
            }
            Cooking OpenEggIn(HotOilPan hotOilPan)
            {
                return null;
            }
            void WaitForComplet(Cooking cooking)
            {
            }

            public class OilPan
            {
            }
            public class HotOilPan
            {
            }
            public class Cooking
            {
            }

            //solove2: Using design pattern
            //功能由子類實現,但步驟定義在這個Class
            public abstract class CookGoodBase
            {
                public void MakeEgg()
                {
                    AddOil();
                    OpenFire();
                    OpenEggIn();
                    WaitForComplet();
                }
                protected abstract void AddOil();
                protected abstract void OpenFire();
                protected abstract void OpenEggIn();
                protected abstract void WaitForComplet();
            }
        }
    }
}