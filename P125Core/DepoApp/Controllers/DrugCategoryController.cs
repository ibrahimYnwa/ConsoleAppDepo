using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace DepoApp.Controllers
{
    public class DrugCategoryController
    {
        public DrugCategoryService drugCategoryService { get; }
        public DrugCategoryController()
        {
            drugCategoryService = new DrugCategoryService();

        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter DrugCategory name:");
            string name = Console.ReadLine();
            DrugCategory drugCategory = new DrugCategory { Name = name };
            if (drugCategoryService.Create(drugCategory) != null)
            {
                Helper.ChangeTextColor
                    (ConsoleColor.Green, $"{drugCategory.Name} created");
                return;
            }
            else
            {
                Helper.ChangeTextColor
                    (ConsoleColor.Red, "Something is wrong!");
                return;
            }
        }

        public void GetAll()
        {
            foreach (DrugCategory item in drugCategoryService.GetAll())
            {
                Helper.ChangeTextColor
                    (ConsoleColor.Blue, $"{item.Id}- {item.Name}");
            }
        }

        public void Delete()
        {
            GetAll();
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter Drug Category id:");
            string input = Console.ReadLine();
            int drugCategoryId;
            bool isTrueId = int.TryParse(input, out drugCategoryId);
            if (isTrueId)
            {
                if (drugCategoryService.Delete(drugCategoryId) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Drug Category is deleted");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"{drugCategoryId} is not found");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Please Select correct format");
            }
        }

        public void Update()
        {
            GetAll();
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter Drug Category id:");
            string input = Console.ReadLine();
            int drugCategoryId;
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter Drug Category Name:");
            string drugCategoryName = Console.ReadLine();
            DrugCategory drugCategory = new DrugCategory();
            drugCategory.Name = drugCategoryName;
            bool isTrueId = int.TryParse(input, out drugCategoryId);
            if (isTrueId)
            {
                if (drugCategoryService.Update(drugCategoryId, drugCategory) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Drug Category is updated");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"{drugCategoryId} is not found");
                    return;
                }
            }
        }
    }
}
