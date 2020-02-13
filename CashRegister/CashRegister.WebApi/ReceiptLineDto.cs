using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegister.WebApi
{
    public class ReceiptLineDto
    {
        
        public int ProductID { get; set; }
        public int Amount { get; set; }
        
    }
}
