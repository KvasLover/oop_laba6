using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
{
    public partial class Quest : IRealizable
    {
        string Var = "Quest";
        public override string ToString()
        {
            return "Тип этого объекта: " + typeof(Quest) + ". Значение поля этого объекта: " + this.Var + " .";
        }

             
    }
    
}
