﻿using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace DepoApp.Controllers
{
   public class DrugCategoryController
    {
        public DrugCategoryService drugCategoryService { get;}
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

        public void GetAllDrugCategory()
        {
            foreach (DrugCategory item in drugCategoryService.GetAll())
            {
                Helper.ChangeTextColor
                    (ConsoleColor.Blue, $"{item.Id}- {item.Name}");
            }
        }
    }
}