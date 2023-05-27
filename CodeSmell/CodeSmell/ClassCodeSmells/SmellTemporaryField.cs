namespace CodeSmell.ClassCodeSmells
{
    /* 
    // Brief :
    // Class has a field that is only set in certain situations, often used to pass state between methods instead of using parameters.
    */
    class SmellTemporaryField //Code smells type : Object-Orientation Abuser
    {
        //BadCode
        public class Employee
        {
            private decimal _earningsForBonus;
            // other fields and methods

            private decimal CalculateBonus()
            {
                return _earningsForBonus * BonusPercentage();
            }

            private void CalculateEarningsForBonus()
            {
                _earningsForBonus = YearToDateEarnings() + OvertimeEarnings() * 2;
            }

            private decimal BonusPercentage()
            {
                return 0;
            }

            private int YearToDateEarnings()
            {
                return 0;
            }

            private int OvertimeEarnings()
            {
                return 0;
            }
        }

        //GoodCode (the one method)
        public class NewEmployee
        {
            public decimal BonusPercentage()
            {
                return 0;
            }

            public int YearToDateEarnings()
            {
                return 0;
            }

            public int OvertimeEarnings()
            {
                return 0;
            }
        }
        public class BonusCalculator
        {
            private NewEmployee _employee;

            public BonusCalculator(NewEmployee employee)
            {
                _employee = employee;
            }

            public decimal CalculateBonus()
            {
                return CalculateEarningsForBonus() * _employee.BonusPercentage();
            }

            private decimal CalculateEarningsForBonus()
            {
                return _employee.YearToDateEarnings() + _employee.OvertimeEarnings() * 2;
            }
        }
    }
}
