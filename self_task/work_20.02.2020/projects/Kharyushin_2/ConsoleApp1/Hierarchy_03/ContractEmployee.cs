namespace ConsoleApp1.Hierarchy_03
{
    class ContractEmployee : Employee
    {
        private double payPerHour;
        private string contactPeriod;

        public ContractEmployee(string name, double payPerHour, string contactPeriod)
            : base(name)
        {
            this.payPerHour = payPerHour;
            this.contactPeriod = contactPeriod;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Почасовая оплата: {payPerHour}; Период контракта: {contactPeriod}";
        }
    }
}
