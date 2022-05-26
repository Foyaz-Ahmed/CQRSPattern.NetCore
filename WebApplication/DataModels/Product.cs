using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public double Price { set; get; }
        public int CategoryId { set; get; }
        public DateTime PublishedDate { set; get; }

        public string ImageUrl {set; get;}

    }
}
