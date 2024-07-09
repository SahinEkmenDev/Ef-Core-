using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CodeFirst.DAL
{
    public class Product
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public decimal Price { get; set; }
        public int stock { get; set; }

        public int barcode { get; set; }


    }
}
