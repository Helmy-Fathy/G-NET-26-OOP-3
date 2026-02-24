using G_NET_26_OOP_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_3
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50m;

        public new decimal PriceAfterTax
        {
            get { return base.PriceAfterTax + ServiceFee; }
        }

        public VIPTicket(string movieName, decimal price, bool loungeAccess): base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
        }
    }
}
