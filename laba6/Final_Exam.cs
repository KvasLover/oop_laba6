using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
{
    // Sealed-класс (не может иметь потомков).
    public sealed class Final_Exam : Exam
    {
        string Var = "Final_Exam";
        public override string ToString()
        {
            return "Тип этого объекта: " + typeof(Final_Exam) + ". Значение поля этого объекта: " + this.Var + " .";
        }

        public override void Show_date()
        {
            Console.WriteLine("Дата проведения выпускного экзамена: 03.01.2021.");
        }

        // Переопределения методов System.Object.
        public override int GetHashCode()
        {            
            return 100;
        }
        public override bool Equals(object obj)
        {
            return false;
        }        
    }
}
