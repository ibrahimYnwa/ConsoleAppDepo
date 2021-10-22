﻿using Business.Services;
using DepoApp.Controllers;
using Entities.Models;
using System;
using Utilies.Helpers;

namespace DepoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DrugCategoryController drugCategoryController = new DrugCategoryController ();
            DrugController drugController = new DrugController();

            Helper.ChangeTextColor(ConsoleColor.Blue, "Welcome");
            while (true)
            {
                ShowMenu();
                Helper.ChangeTextColor(ConsoleColor.Yellow, "Select Option Number");
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue && menu>=1 && menu<=8)
                {
                    switch (menu)
                    {
                        case (int)Helper.Menu.CreateDrugCategory:
                            drugCategoryController.Create();
                            break;

                        case (int)Helper.Menu.UpdateDrugCategory:
                            break;
                        case (int)Helper.Menu.DeleteDrugCategory:
                            drugCategoryController.Delete();
                            break;
                        case (int)Helper.Menu.GetDrugCategoryWithId:
                            break;
                        case (int)Helper.Menu.GetDrugCategorywithName:
                            break;
                        case (int)Helper.Menu.GetAllDrugCategory:
                            Helper.ChangeTextColor(ConsoleColor.Yellow, "All DrugCategory:");
                            drugCategoryController.GetAll();
                            break;
                        case (int)Helper.Menu.CreateDrug:
                            drugCategoryController.GetAll();
                            drugController.Create();
                            break;

                    }
                }
                else if (menu == 0)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkCyan, "Bye Bye");
                    break;

                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please select correct option");

                }

            }

        }

        static void ShowMenu()
        {
            Helper.ChangeTextColor(ConsoleColor.Green,
                   "1-Create DrugCategory,2-Update DrugCategory,3-Delete DrugCategory" +
                   "4-Get DrugCategory with Id,5-Get DrugCategory with Name" +
                   "6-All DrugCategory,7-Create Drug,0-Exit");
        }
    }
}
