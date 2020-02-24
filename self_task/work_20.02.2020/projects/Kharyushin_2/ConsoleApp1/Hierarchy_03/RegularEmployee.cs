namespace ConsoleApp1.Hierarchy_03
{
    class RegularEmployee : Employee
    {
        private double salary;
        private double bonus;
        
        public RegularEmployee(string name, double salary, double bonus)
            : base(name)
        {
            this.salary = salary;
            this.bonus = bonus;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Зарплата: {salary}; Премия: {bonus}";
        }
    }
}
