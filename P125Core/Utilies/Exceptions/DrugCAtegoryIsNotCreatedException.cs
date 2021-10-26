using System;
using System.Collections.Generic;
using System.Text;

namespace Utilies.Exceptions
{
    public class DrugCAtegoryIsNotCreatedException:Exception
    {
        public DrugCAtegoryIsNotCreatedException(string message):base(message)
        {
           
        }
    }
}
