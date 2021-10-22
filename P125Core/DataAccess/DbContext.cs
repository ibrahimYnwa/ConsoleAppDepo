using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
   public static class DbContext
    {
        public static List<DrugCategory> DrugCategorys { get; set; }
        public static List<Drug> Drugs { get; set; }

        static DbContext()
        {
            DrugCategorys = new List<DrugCategory>();
            Drugs = new List<Drug>();

        }
    }
}
