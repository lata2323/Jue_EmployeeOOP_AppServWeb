namespace EmployeeOOP.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public int Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion

        #region Methods

        public HourlyEmployee()
        {
            
        }

        public override decimal GetValueToPay()
        {
            return HourValue*Hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" + //base hace referencia a la clase padre, al método ToString
                $"Salario Devengado: {GetValueToPay():C2}\n\t";
        }

        #endregion
    }
}
