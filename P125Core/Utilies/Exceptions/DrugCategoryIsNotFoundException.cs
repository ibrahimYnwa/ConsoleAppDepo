using System;
using System.Collections.Generic;
using System.Text;

namespace Utilies.Exceptions
{
   public class DrugCategoryIsNotFoundException:Exception
    {
        public DrugCategoryIsNotFoundException(string message):base(message)
        {

        }
    }
}
