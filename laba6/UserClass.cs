using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
{
    class UserClass : BaseLook, IAnswer
    {
        string Var = "UserClass";
        public override string ToString()
        {
            return "Тип этого объекта: " + typeof(UserClass) + ". Значение поля этого объекта: " + this.Var + " .";
        }

        void IAnswer.DoAnswer()
        {
            Console.WriteLine("(IAnswer)");            
        }
        public override void DoAnswer()
        {
            Console.WriteLine("(BaseLook) Ваш ответ: ");
            if ((Convert.ToInt32(Console.ReadLine())) == 100)
                Console.WriteLine("Это правильный ответ!");
            else
                Console.WriteLine("Это неправильный ответ!");
        }

    }
}
