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
        private DrugService drugService { get; }
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

        public void GetAllDrugWithCategory()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select possible drug category: ");
            string drugCategoryName = Console.ReadLine();
            List<Drug> drugs = drugService.GetAll(drugCategoryName);
            if (drugs != null)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Drug Category {drugCategoryName}:");
                foreach (var item in drugs)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green,
                        $" {item.Name}-{item.Id}");
                }
                return;
            }
            Helper.ChangeTextColor
                (ConsoleColor.Red, $"Couldn'n find such as Drug Category-{drugCategoryName}");

        }

        public void GetDrugWithName()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select possible drug name: ");
            string drugName = Console.ReadLine();
            Drug drug = drugService.Get(drugName);
            if (drug != null)
            {
                Helper.ChangeTextColor(ConsoleColor.Green,
                    $"{drugName} - {drug.DrugCategory.Name}");
                return;
            }
            Helper.ChangeTextColor
                (ConsoleColor.Red, $"Couldn't find such as Drug Name-{drugName}");

        }

        public void GetDrugWithId()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select possible drug Id: ");
            string input = Console.ReadLine();

            if (input != null)
            {
                int drugId;
                bool isTrueId = int.TryParse(input, out drugId);
                isTrueId = int.TryParse(input, out drugId);
                if (isTrueId)
                {
                    Drug drug = drugService.Get(drugId);
                    Helper.ChangeTextColor(ConsoleColor.Green,
                   $"{drug.Name} - {drug.DrugCategory.Name}");
                    return;
                }
                Helper.ChangeTextColor
                    (ConsoleColor.Red, $"Couldn't find such as Drug Name-{drugId}");
            }

        }

        public void GetAllDrug()
        {
            string drugName = Console.ReadLine();
            List<Drug> drugs = drugService.GetAll(drugName);
            if (drugs !=null)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Drug  {drugName}:");
                foreach (var item in drugs)
                {
                    Helper.ChangeTextColor
                        (ConsoleColor.Blue, $"{item.Id}- {item.Name}");
                }
                return;
            }
            Helper.ChangeTextColor
                (ConsoleColor.Red, $"Couldn't find such as Drug Name-{drugName}");

        }

        public void UpdateDrug()
        {
            GetAllDrugWithCategory();
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter Drug  id:");
            string input = Console.ReadLine();
            int drugId;
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter Drug  Name:");
            string drugName = Console.ReadLine();
            Drug drug = new Drug();
            drug.Name = drugName;
            bool isTrueId = int.TryParse(input, out drugId);
            if (isTrueId)
            {
                if (drugService.Update(drugId, drug) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Drug  is updated");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"{drug} is not found");
                    return;
                }

            }
        }

        public void DeleteDrug()
        {
            GetAllDrugWithCategory();
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter Drug id:");
            string input = Console.ReadLine();
            int drugId;
            bool isTrueId = int.TryParse(input, out drugId);
            if (isTrueId)
            {
                if (drugService.Delete(drugId) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Drug is deleted");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"{drugId} is not found");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Please Select correct format");
            }
        }
    }
}
