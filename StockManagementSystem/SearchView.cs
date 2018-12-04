using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    class SearchView
    {

        public string ItemName { set; get; }
        public string CategoryName { set; get; }
        public string CompanyName { set; get; }
        public int AvQuantity { set; get; }
        public int ReorderLevel { set; get; }

    }
}
