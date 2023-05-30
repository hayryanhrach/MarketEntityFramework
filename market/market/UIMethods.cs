using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLmarket;
using market;
using DBData;
using UImarket;


namespace UImarket
{
    public  class UIMethods
    {
        public static bool IsNumber(string x)
        {
            int k;
            return int.TryParse(x, out k);
        }
    }
}
