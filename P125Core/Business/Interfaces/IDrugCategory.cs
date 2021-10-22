
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;



namespace Business.Interfaces
{
    public interface IDrugCategory
    {
        DrugCategory Create(DrugCategory drugCategory);
        DrugCategory Update(int Id, DrugCategory drugCategory);
        DrugCategory Delete(int Id);
        DrugCategory Get(int Id);
        DrugCategory Get(string Name);
        List<DrugCategory> GetAll();


    }
}
