using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace laba6
{
    public class Exam : Quest
    {
        public string Var;
        public int var_int;
        public override string ToString()
        {
            return "Тип этого объекта: " + typeof(Exam) + ". Значение поля этого объекта: " + this.Var + " .";
        }

        public override void Show_date()
        {
            Console.WriteLine("Дата проведения экзамена: 01.01.2021.");
        }

        // Конструкторы на все случаи жизни.
        public Exam(int var_int)
        {
            this.var_int = var_int;
        }
        public Exam()
        {
            this.Var = "Exam";
        }

        public int Get_Setter
        {
            get { return var_int; }
            set
            {                
                if (value == 0)
                    throw new Number_is_equal_0("Введённое число нуль - сигнал для генерации этого исключения.");
                else var_int = value;
            }
        }
        public string Get_Setter2
        {
            get { return Var; }
            set
            {
                if (value.CompareTo("Exam")==0)
                    throw new Var_is_not_equal_exam("Введённая строка не 'Exam' - сигнал для генерации этого исключения.");
                else Var = value;
            }
        }
        public string Get_Setter3
        {
            get { return Var; }
            set
            {
                if (value.Length < 4)
                    throw new Length_of_Var_is_less_than_4("Введённая строка длиной меньше 4-х символов - сигнал для генерации этого исключения.");
                else Var = value;
            }
        }
        public int Get_Setter4
        {
            set
            {
                int temp2 = 1 / value;
            }
        }
        public int Get_Setter5
        {
            set
            {
                int[] Array = new int[] { 1, 2, 3, 4, 5 };
                Console.WriteLine(Array[value]);
                // Макрос Assert().
                Debug.Assert(Array is object);
            }            
        }
    }

}
