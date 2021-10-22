using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
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
                return null;
            }
        }

        public Drug Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Drug Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Drug> Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetAll(string drugCategoryName)
        {
            throw new NotImplementedException();
        }

        public Drug Update(Drug drug, string drugCategoryName)
        {
            throw new NotImplementedException();
        }
    }
}
