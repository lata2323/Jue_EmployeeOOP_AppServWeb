namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee
    {
        #region Properties

        public decimal CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }

        #endregion

        #region Methods

        public CommissionEmployee()
        {

        }

        public override decimal GetValueToPay()
        {
            return CommissionPercentaje / 100 * Sales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" + //base hace referencia a la clase padre, al método ToString
                $"Salario Devengado: {GetValueToPay():C2}\n\t";
        }

        #endregion
    }
}
