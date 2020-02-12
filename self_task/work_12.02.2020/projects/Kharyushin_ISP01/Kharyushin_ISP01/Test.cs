using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kharyushin_ISP01
{
    class Test
    {
        public string ExamineeFIO { get; set; }
        public string ExaminerFIO { get; set; }
        public string Date { get; set; }
        public int Evalution { get; set; }

        public Test(string examineefio, string examinerfio, string date, int evalution)
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
