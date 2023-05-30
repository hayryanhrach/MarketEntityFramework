using DBData;

namespace BLmarket
{
    public class BL
    {
        public List<Product> FromDBToList()
        {
            List<Product> prdlist = new List<Product>();
            using (MyDbContext db = new MyDbContext())
            {
                prdlist = db.Products.ToList();
            }
            return prdlist;
        }

        public static List<Market> MarketsFromDBToList()
        {
            List<Market> marketlist = new List<Market>();
            using (MyDbContext db = new MyDbContext())
            {
                marketlist = db.Markets.ToList();
            }
            return marketlist;
        }

        public void AddProductToDB(string prdname, string munit, string price, string rem, int marketid)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Products.Add(new Product(prdname, munit, price, rem, marketid));
                db.SaveChanges();
            }

        }
        public void AddMarketToDB( string marketname)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Markets.Add(new Market( marketname));
                db.SaveChanges();
            }

        }
        public static List<Product> SelectedRowToList(DataGridView sender)
        {
            List<Product> list = new List<Product>();
                list.Clear();
            if (sender.CurrentRow !=null )
            {      
                var selectedtid = (int)sender.CurrentRow.Cells[0].Value;
                var selectedname = (string)sender.CurrentRow.Cells[1].Value;
                var selectedunit = (string)sender.CurrentRow.Cells[2].Value;
                var selectedprice = (string)sender.CurrentRow.Cells[3].Value;
                var selectedrem = (string)sender.CurrentRow.Cells[4].Value;
                var selectedmarketid = (int)sender.CurrentRow.Cells[5].Value;
                list.Add(new Product(selectedtid, selectedname, selectedunit, selectedprice, selectedrem, selectedmarketid));
                return list;
            }
            MessageBox.Show("Ընտրված տող չկա");
            return list; 
            
        }
        

        public static void DeleteSelectedRow(DataGridView sender)
        {
            var selectedtid = (int)sender.CurrentRow.Cells[0].Value;
            using (var db = new MyDbContext())
            {
                foreach (var item in db.Products)
                {
                    if (item.ID == selectedtid)
                    {
                        db.Products.Remove(item);
                    }
                }
                db.SaveChanges();
            }

        }
        public static void EditSelectedRow(int id,string prdname, string munit, string price, string rem, int marketid)
        { 
            using (var db = new MyDbContext())
            {
                foreach (var item in db.Products)
                {
                    if (item.ID == id)
                    {
                        item.PrdName = prdname;
                        item.MUnit = munit;
                        item.Price=price;
                        item.Rem=rem;
                        item.MarketID = marketid;
                    }
                }
                db.SaveChanges();
            }

        }
    }
}