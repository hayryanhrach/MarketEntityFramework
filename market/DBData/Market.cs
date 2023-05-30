using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DBData
{
    public class Market
    {   
        public int MarketID { get; set; }
        public string MarketName { get; set; }
        public Market(string maarketname)
        {
            MarketName = maarketname;
        }
        public Market()
        {
           
        }
    }
}
