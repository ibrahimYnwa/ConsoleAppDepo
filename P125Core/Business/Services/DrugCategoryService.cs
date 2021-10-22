using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class DrugCategoryService : IDrugCategory
    {
        public DrugCategoryRepository drugCategoryRepository { get; set; }
        public static int count { get; set; }
        public DrugCategoryService()
        {
            drugCategoryRepository = new DrugCategoryRepository();

        }
        public DrugCategory Create(DrugCategory drugCategory)
        {
            try
            {
                drugCategory.Id = count;
                DrugCategory isExist = 
                    drugCategoryRepository.Get(g => g.Name.ToLower()==drugCategory.Name.ToLower());
                if (isExist != null)
                    return null;
                drugCategoryRepository.Create(drugCategory);
                count++;
                return drugCategory;

            }
            catch (Exception)
            {

                return null;

            }
        }

        public DrugCategory Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public DrugCategory Get(int Id)
        {
            throw new NotImplementedException();
        }

        public DrugCategory Get(string Name)
        {
            throw new NotImplementedException();
        }

        public List<DrugCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public DrugCategory Update(int Id, DrugCategory drugCategory)
        {
            throw new NotImplementedException();
        }
    }
}
