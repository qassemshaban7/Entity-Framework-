using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_EF_S03_DataBase_First.Entitites
{
    public partial class SalesByCategoryResult
    {
        public override string ToString()
            => $"{ProductName} :: {TotalPurchase}";

    }
}
