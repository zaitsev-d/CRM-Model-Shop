using System;
using System.Collections.Generic;

namespace CRM.BusinessLogic.Model
{
    public class Check
    {
        public int CheckID { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public int SellerID { get; set; }
        public virtual Seller Seller { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"#{CheckID} from {Created.ToString("dd.mm.yy hh:mm:ss")}";
        }
    }
}
