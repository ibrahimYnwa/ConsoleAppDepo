using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IDrug
    {
        Drug Create(Drug drug, string drugCategoryName);
        Drug Delete(int Id);
        Drug Update(int Id, Drug drug);
        Drug Get(int Id);
        Drug Get(string name);
        List<Drug> GetAll(string drugCategoryName);


    }
}
