using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
   public interface IDrug
    {
        Drug Create(Drug drug,string drugCategoryName);
        Drug Delete(int Id);
        Drug Update(Drug drug,string drugCategoryName); //elave elemek olar 
        Drug Get(int Id);
        List<Drug> Get(string name);
        List<Drug> GetAll(string drugCategoryName);

            
    }
}
