using System;
using System.Collections.Generic;
using System.Text;

namespace Utilies.Helpers
{
   public static class Helper
    {
        public static void ChangeTextColor(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public enum Menu
        {
            Exit,
            CreateDrugCategory,
            UpdateDrugCategory,
            DeleteDrugCategory,
            GetDrugCategoryWithId,
            GetDrugCategorywithName,
            GetAllDrugCategory,
            CreateDrug,
            GetAllDrugWithCategory,
            GetDrugWithName,
            GetDrugWithId,
            GetAllDrug,
            UpdateDrug,



        }
    }
}
