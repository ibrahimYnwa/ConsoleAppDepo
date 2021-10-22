using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public class Drug:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DrugCategory DrugCategory { get; set; }
    }
}
