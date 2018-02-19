using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bune.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Data.Enum.TransactionType TransactionType { get; set; }
        public float Amount { get; set; }
    }
}
