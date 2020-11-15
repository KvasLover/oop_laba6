using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
    abstract class BaseLook
    {
        string Var = "BaseLook";
        public override string ToString()
        {
            return "Тип этого объекта: " + typeof(BaseLook) + ". Значение поля этого объекта: " + this.Var + " .";
        }

        public abstract void DoAnswer();
        
    }
    
}
