using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;

namespace YoutubeApi.Domain.Entities
{
    public class Product : EntityBase
    {
        public required string Title { get; set; }
        // public required string ImagePath {get; set;}
        public required string Description { get; set; }
        public required int BrandId { get; set; }
        public required decimal Price { get; set; }
        public required decimal Discount { get; set; } //indirim
        public Brand Brand { get; set; } //Brand(Marka) tekil olacağı için bunu yaptık.
        //Bir ürünün birden fazla kategorisi olabilir. Mesela Dizüstü bilgisayar hem elektronik hem bilgisayar kategorisinde yer alır.
        //Ve bir kategorininde birden fazla ürünü olavaktır bu yüzden ürün ve kategori arasında çoka çok ilişki vardır.
        public ICollection<Category> Categories { get; set; }





    }
}
