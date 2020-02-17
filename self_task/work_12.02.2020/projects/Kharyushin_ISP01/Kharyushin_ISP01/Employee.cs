namespace Kharyushin_ISP01
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int WorkExperience { get; set; }

        public Employee(string name, string prof, int workexp)
        {
            Name = name;
            Profession = prof;
            WorkExperience = workexp;
        }

        public override string ToString()
        {
            return $"Имя: {Name}; Профессия: {Profession}; Стаж: {WorkExperience}";
        }
    }
}
