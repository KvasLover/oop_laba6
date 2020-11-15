using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
    public class Quest : IRealizable
    {
        string Var = "Quest";
        public override string ToString()
        {
            return "Тип этого объекта: " + typeof(Quest) + ". Значение поля этого объекта: " + this.Var + " .";
        }

        public virtual void Show_date()
        {
            Console.WriteLine("Дата не определена");
        }        
    }
    
}
