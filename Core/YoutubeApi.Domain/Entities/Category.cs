using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Domain.Entities
{
    public class Category : EntityBase, IEntityBase
    {
        public Category()
        {
            
        }

        public Category(int parentId, string name, int priorty)
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }

        public required int ParentId { get; set; }
        public required string Name { get; set; }
        public required int Priorty { get; set; }

        public ICollection<Detail> Details { get; set; } //Burada bire çok ilişki vardır. Bir kategorinin birden fazla detayı olabilir anlamına gelir.

        //Bir kategorinin birden fazla ürünü bir ürününde birden fazla kategorisi olacak , bu yüzden çoka çok ilişki var.
        public ICollection<Product> Products { get; set; }

    }
}
