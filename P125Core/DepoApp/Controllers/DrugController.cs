using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace DepoApp.Controllers
{
   public class DrugController
    {
        private DrugService drugService { get;}
        public DrugController()
        {
            drugService = new DrugService();

        }

        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select possible drug category: ");
            string drugCategoryName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter drug name: ");
            string name = Console.ReadLine();
            Drug drug = new Drug { Name = name };
            Drug newDrug = drugService.Create(drug, drugCategoryName);
            if (newDrug != null)
            {
                Helper.ChangeTextColor
                    (ConsoleColor.Green, $"New Drug is Created- {newDrug.Name}");
                return;
            }
            Helper.ChangeTextColor
                (ConsoleColor.Red, $"Couldn'n find such as Drug Category-{drugCategoryName}");
        }
    }
}
