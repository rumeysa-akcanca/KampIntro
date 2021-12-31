using OyunProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProject.Entities
{
   public  class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EndingDate { get; set; }
        public decimal DiscountRate  { get; set; }
    }
}
