using System;
using System.Collections.Generic;
using System.Text;

namespace Utilies.Exceptions
{
   public class DrugIsNotCreatedException:Exception
    {
        public DrugIsNotCreatedException(string message):base(message)
        {

        }
    }
}
