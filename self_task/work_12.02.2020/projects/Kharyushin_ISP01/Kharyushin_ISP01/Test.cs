using System;

namespace Kharyushin_ISP01
{
    class Test
    {
        public string ExamineeFIO { get; set; }
        public string ExaminerFIO { get; set; }
        public DateTime Date { get; set; }
        public int Evalution { get; set; }

        public Test(string examineefio, string examinerfio, DateTime date, int evalution)
        {
            ExamineeFIO = examineefio;
            ExaminerFIO = examinerfio;
            Date = date;
            Evalution = evalution;
        }

        public override string ToString()
        {
            return $"ФИО экзаменуемого: {ExamineeFIO}; ФИО экзаменатора: {ExaminerFIO}; Дата: {Date}; Оценка: {Evalution}";
        }
    }
}
