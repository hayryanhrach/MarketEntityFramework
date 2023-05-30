using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBData
{
    public class Product
    {
        public int ID { get; set; }
        public string PrdName { get; set; }
        public string? MUnit { get; set; }
        public string? Price { get; set; }
        public string? Rem { get; set; }
        public int MarketID { get; set; }

        public  Product()
        {

        }
        public Product(string prdname, string munit, string price, string rem, int marketid)
        {
           PrdName = prdname;
            MUnit = munit;
            Price = price;
            Rem = rem;
            MarketID = marketid;

        }
        public Product(int id,string prdname, string munit, string price, string rem, int marketid)
        {
            ID = id;    
            PrdName = prdname;
            MUnit = munit;
            Price = price;
            Rem = rem;
            MarketID = marketid;

        }
    }
}
