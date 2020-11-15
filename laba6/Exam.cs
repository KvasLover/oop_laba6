using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
{
    public class Exam : Quest
    {
        string Var = "Exam";
        public override string ToString()
        {
            return "Тип этого объекта: " + typeof(Exam) + ". Значение поля этого объекта: " + this.Var + " .";
        }

        public override void Show_date()
        {
            Console.WriteLine("Дата проведения экзамена: 01.01.2021.");
        }
    }

}
