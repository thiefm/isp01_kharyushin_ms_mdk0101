namespace ConsoleApp1
{
    class Driver : Worker
    {
        private int experience;
        private char drivingCategory;

        public Driver(string name, int age, double salary, int experience, char drivingCategory)
            : base(name, age, salary)
        {
            this.experience = experience;
            this.drivingCategory = drivingCategory;
        }
    }
}
