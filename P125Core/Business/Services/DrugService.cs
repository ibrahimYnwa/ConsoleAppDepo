using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilies.Exceptions;
using System.Text;

namespace Business.Services
{
    public class DrugService : IDrug
    {
        private DrugRepository drugRepository { get;}
        private DrugCategoryService drugCategoryService { get; }
        private static int count;
        public DrugService()
        {
            drugRepository = new DrugRepository();
            drugCategoryService = new DrugCategoryService();

        }
        public Drug Create(Drug drug, string drugCategoryName)
        {
            DrugCategory dbdrugCategory = drugCategoryService.Get(drugCategoryName);
            if (dbdrugCategory !=null)
            {
                drug.DrugCategory = dbdrugCategory;
                drug.Id = count;
                drugRepository.Create(drug);
                count++;
                return drug;
            }
            else
            {
                throw new DrugCAtegoryIsNotCreatedException("Drug is not Created");
            }
        }

        public Drug Delete(int id) 
        {
            Drug dbDrug = drugRepository.Get(g => g.Id == id);
            if (dbDrug != null)
            {
                drugRepository.Delete(dbDrug);
                return dbDrug;

            }
            else
            {
                throw new DrugIsNotFoundExceotion("Drug is not found with Id");
            }
        }

        public Drug Get(int id)
        {
            return drugRepository.Get(d => d.Id == id);
        }

        public Drug Get(string name)
        {
            return drugRepository.Get(g => g.Name.ToLower() == name.ToLower());

        }

        public List<Drug> GetAll(string drugCategoryName)
        {
            DrugCategory dbDrugCategory = drugCategoryService.Get(drugCategoryName);
            if (dbDrugCategory != null)
            {
                return drugRepository.GetAll(d => d.DrugCategory.Name == dbDrugCategory.Name);

            }
            else
            {
                return null;
            }
        }

        public Drug Update(int Id, Drug drug)
        {
            Drug dbDrug = drugRepository.Get(d => d.Id == Id);
            if (dbDrug !=null)
            {
                dbDrug.Name = drug.Name;
                if (drug.DrugCategory != null)
                {
                    dbDrug.DrugCategory = drug.DrugCategory;
                }
                return dbDrug;
            }
            else
            {
                throw new DrugIsNotFoundExceotion("Drug is not found");
            }
        }
    }
}
