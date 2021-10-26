using System;
using System.Collections.Generic;
using System.Text;

namespace Utilies.Exceptions
{
   public class DrugIsNotFoundExceotion:Exception
    {
        public DrugIsNotFoundExceotion(string message):base(message)
        {

        }
    }
}
