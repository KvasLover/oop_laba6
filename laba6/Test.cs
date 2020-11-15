using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
    public class Test : Quest
    {
        string Var = "Test";
        public override string ToString()
        {
            return "Тип этого объекта: " + typeof(Test) + ". Значение поля этого объекта: " + this.Var + " .";
        }

        public override void Show_date()
        {
            Console.WriteLine("Дата проведения теста: 02.01.2021.");
        }
    }
}
