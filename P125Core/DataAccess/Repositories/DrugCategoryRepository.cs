using DataAccess.Interfaces;
using Entities.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class DrugCategoryRepository : IRepository<DrugCategory>
    {
        public bool Create(DrugCategory entity)
        {
            try
            {
                DbContext.DrugCategorys.Add(entity);
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(DrugCategory entity)
        {
            try
            {
                DbContext.DrugCategorys.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DrugCategory Get(Predicate<DrugCategory> filter = null)
        {
            try
            {
                return filter==null ? DbContext.DrugCategorys[0]
                    : DbContext.DrugCategorys.Find(filter);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<DrugCategory> GetAll(Predicate<DrugCategory> filter = null)
        {
            try
            {
                return filter == null ? DbContext.DrugCategorys
                   : DbContext.DrugCategorys.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(DrugCategory entity)
        {
            try
            {
                DrugCategory dbDrugCategory = Get(s => s.Id == entity.Id);
                dbDrugCategory= entity;
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
